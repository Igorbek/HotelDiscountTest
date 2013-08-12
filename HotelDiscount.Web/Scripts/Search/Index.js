var HotelDiscount;
(function (HotelDiscount) {
    /// <reference path="../typings/linq/linq.3.0.3-Beta4.d.ts" />
    /// <reference path="../typings/jquery/jquery.d.ts" />
    /// <reference path="../typings/knockout/knockout.d.ts" />
    (function (Search) {
        var Currencies = [
            { title: 'RUR', sign: "р.", value: 1, isPostfix: true },
            { title: 'USD', sign: "$", value: 32.8606 },
            { title: 'EUR', sign: "€", value: 43.9806 },
            { title: 'GBP', sign: "£", value: 51.0654 }
        ];
        var CurrencyMap = Enumerable.from(Currencies).toObject(function (c) {
            return c.title;
        }, function (c) {
            return c;
        });

        var ViewModel = (function () {
            function ViewModel(model) {
                var _this = this;
                this.CityChoices = ["Зальцбург"];
                this.ItemsPerPage = 20;
                this.OrderOptions = ["цене", "звездам", "названию"];
                //public AllHotels:
                this.Currencies = Currencies.map(function (c) {
                    return c.title;
                });
                this.Currency = ko.observable(Currencies[0].title);
                this.DetailsHotel = ko.observable(null);
                this.City = ko.observable(model.Input.City);
                this.DateFrom = ko.observable(new Date(Date.parse(model.Input.DateFrom)));
                this.DateTo = ko.observable(new Date(Date.parse(model.Input.DateTo)));
                this.Results = model.SearchResult;
                if (this.Results) {
                    this.Pages = Enumerable.toInfinity(0).takeWhile(function (p) {
                        return _this.Results.Hotels.length > p * _this.ItemsPerPage;
                    }).toArray();
                    this.Page = ko.observable(0);
                    this.Order = ko.observable(this.OrderOptions[0]);
                    this.Hotels = ko.computed(function () {
                        return Enumerable.from(_this.Results.Hotels).orderBy(function (h) {
                            if (_this.Order() == _this.OrderOptions[1])
                                return -h.Hotel.Stars;
                            if (_this.Order() == _this.OrderOptions[2])
                                return h.Hotel.Name;
                            return Enumerable.from(h.PlacementOptions).min(function (po) {
                                return po.Price * CurrencyMap[po.Currency].value;
                            });
                        }).skip(_this.Page() * _this.ItemsPerPage).take(_this.ItemsPerPage).toArray();
                    });
                }
            }
            ViewModel.prototype.GetPrice = function (hotel) {
                var en = Enumerable.from(hotel.PlacementOptions).select(function (po) {
                    return po.Price * CurrencyMap[po.Currency].value;
                });
                var min = ViewModel.ToPrice(en.min(), this.Currency());
                var max = ViewModel.ToPrice(en.max(), this.Currency());
                if (min == max)
                    return min;
                return "от " + min;
            };

            ViewModel.prototype.GetPlacementPrice = function (placement) {
                return ViewModel.ToPrice(placement.Price * CurrencyMap[placement.Currency].value, this.Currency());
            };

            ViewModel.ToPrice = function (value, currency) {
                var c = CurrencyMap[currency];
                var strValue = (value / c.value).toFixed(0);
                return c.isPostfix ? (strValue + c.sign) : (c.sign + strValue);
            };
            return ViewModel;
        })();

        function Init() {
            _viewModel = new ViewModel(_Model);
            kendo.culture("ru-RU");
            $(function () {
                return ko.applyBindings(_viewModel);
            });
        }
        Search.Init = Init;
    })(HotelDiscount.Search || (HotelDiscount.Search = {}));
    var Search = HotelDiscount.Search;
})(HotelDiscount || (HotelDiscount = {}));
