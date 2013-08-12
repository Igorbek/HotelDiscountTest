/// <reference path="../typings/linq/linq.3.0.3-Beta4.d.ts" />
/// <reference path="../typings/jquery/jquery.d.ts" />
/// <reference path="../typings/knockout/knockout.d.ts" />

module HotelDiscount.Search {

    interface ISearchResult {
        Hotels: Array<IHotelSearchResult>;
    }

    interface IHotelSearchResult {
        Hotel: IHotel;
        PlacementOptions: Array<IHotelPlacementOptionSearchResult>;
    }

    interface IHotel {
        Name: string;
        Address: string;
        Stars: number;
        Description: string;
        ThumbnailImageUri: string;
        ImagesUris: string[];
    }

    interface IHotelPlacementOptionSearchResult {
        Name: string;
        Currency: string;
        Price: number;
        Rooms: Array<IRoom>;
        Meals: Array<string>;
    }

    interface IRoom {
        Name: string;
    }

    interface SearchOutputModel {
        Input: SearchInputModel;
        SearchResult: ISearchResult;
    }

    interface SearchInputModel {
        City: string;
        DateFrom: string;
        DateTo: string;
        RoomsDescription: string;
    }

    interface ICurrencyInfo
    {
        title: string;
        sign: string;
        value: number;
        isPostfix?: boolean;
    }

    var Currencies: ICurrencyInfo[] = [
        { title: 'RUR', sign: "р.", value: 1, isPostfix: true },
        { title: 'USD', sign: "$", value: 32.8606 },
        { title: 'EUR', sign: "€", value: 43.9806 },
        { title: 'GBP', sign: "£", value: 51.0654 }
    ];
    var CurrencyMap: { [c: string]: ICurrencyInfo; } = Enumerable.from(Currencies).toObject((c: ICurrencyInfo) => c.title, (c: ICurrencyInfo) => c);

    class ViewModel {
        public City: KnockoutObservable<string>;
        public CityChoices = ["Зальцбург"];
        public DateFrom: KnockoutObservable<Date>;
        public DateTo: KnockoutObservable<Date>;
        public Results: ISearchResult;
        public Page: KnockoutObservable<number>;
        public ItemsPerPage = 20;
        public Pages: Array<number>;
        public Hotels: KnockoutComputed<Array<IHotelSearchResult>>;
        public OrderOptions = ["цене", "звездам", "названию"];
        public Order: KnockoutObservable<string>;
        //public AllHotels: 
        public Currencies = Currencies.map(c => c.title);
        public Currency = ko.observable(Currencies[0].title);
        public DetailsHotel = ko.observable<IHotelSearchResult>(null);

        constructor(model: SearchOutputModel) {
            this.City = ko.observable(model.Input.City);
            this.DateFrom = ko.observable(new Date(Date.parse(model.Input.DateFrom)));
            this.DateTo = ko.observable(new Date(Date.parse(model.Input.DateTo)));
            this.Results = model.SearchResult;
            if (this.Results) {
                this.Pages = Enumerable
                    .toInfinity(0)
                    .takeWhile(p => this.Results.Hotels.length > p * this.ItemsPerPage)
                    .toArray();
                this.Page = ko.observable(0);
                this.Order = ko.observable(this.OrderOptions[0]);
                this.Hotels = ko.computed(() => Enumerable
                    .from(this.Results.Hotels)
                    .orderBy((h: IHotelSearchResult) => {
                        if (this.Order() == this.OrderOptions[1])
                            return -h.Hotel.Stars;
                        if (this.Order() == this.OrderOptions[2])
                            return h.Hotel.Name;
                        return Enumerable.from(h.PlacementOptions)
                            .min(po => po.Price * CurrencyMap[po.Currency].value);
                    })
                    .skip(this.Page() * this.ItemsPerPage)
                    .take(this.ItemsPerPage)
                    .toArray());
            }
        }

        public GetPrice(hotel: IHotelSearchResult): string
        {
            var en = Enumerable.from(hotel.PlacementOptions).select(po => po.Price * CurrencyMap[po.Currency].value);
            var min = ViewModel.ToPrice(en.min(), this.Currency());
            var max = ViewModel.ToPrice(en.max(), this.Currency());
            if (min == max)
                return min;
            return "от " + min;
        }

        public GetPlacementPrice(placement: IHotelPlacementOptionSearchResult): string
        {
            return ViewModel.ToPrice(placement.Price * CurrencyMap[placement.Currency].value, this.Currency());
        }

        static ToPrice(value: number, currency: string): string
        {
            var c = CurrencyMap[currency];
            var strValue = (value / c.value).toFixed(0);
            return c.isPostfix ? (strValue + c.sign) : (c.sign + strValue);
        }
    }

    declare var _viewModel: ViewModel;
    declare var _Model: SearchOutputModel;
    declare var kendo: any;

    export function Init()
    {
        _viewModel = new ViewModel(_Model);
        kendo.culture("ru-RU");
        $(() => ko.applyBindings(_viewModel));
    }

}