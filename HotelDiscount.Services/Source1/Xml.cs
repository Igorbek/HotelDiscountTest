// Generated from xml sample

namespace HotelDiscount.Services.Source1
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Response
    {

        private ResponseResponseDetails responseDetailsField;

        /// <remarks/>
        public ResponseResponseDetails ResponseDetails
        {
            get
            {
                return this.responseDetailsField;
            }
            set
            {
                this.responseDetailsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetails
    {

        private ResponseResponseDetailsSearchHotelPriceResponse searchHotelPriceResponseField;

        private string languageField;

        /// <remarks/>
        public ResponseResponseDetailsSearchHotelPriceResponse SearchHotelPriceResponse
        {
            get
            {
                return this.searchHotelPriceResponseField;
            }
            set
            {
                this.searchHotelPriceResponseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsSearchHotelPriceResponse
    {

        private ResponseResponseDetailsSearchHotelPriceResponseHotel[] hotelDetailsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Hotel", IsNullable = false)]
        public ResponseResponseDetailsSearchHotelPriceResponseHotel[] HotelDetails
        {
            get
            {
                return this.hotelDetailsField;
            }
            set
            {
                this.hotelDetailsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsSearchHotelPriceResponseHotel
    {

        private ResponseResponseDetailsSearchHotelPriceResponseHotelCity cityField;

        private ResponseResponseDetailsSearchHotelPriceResponseHotelItem itemField;

        private ResponseResponseDetailsSearchHotelPriceResponseHotelLocation[] locationDetailsField;

        private byte starRatingField;

        private ResponseResponseDetailsSearchHotelPriceResponseHotelHotelRoom[] hotelRoomsField;

        private ResponseResponseDetailsSearchHotelPriceResponseHotelRoomCategory[] roomCategoriesField;

        private bool hasExtraInfoField;

        private bool hasPicturesField;

        private bool hasPicturesFieldSpecified;

        private bool hasMapField;

        private bool hasMapFieldSpecified;

        /// <remarks/>
        public ResponseResponseDetailsSearchHotelPriceResponseHotelCity City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public ResponseResponseDetailsSearchHotelPriceResponseHotelItem Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Location", IsNullable = false)]
        public ResponseResponseDetailsSearchHotelPriceResponseHotelLocation[] LocationDetails
        {
            get
            {
                return this.locationDetailsField;
            }
            set
            {
                this.locationDetailsField = value;
            }
        }

        /// <remarks/>
        public byte StarRating
        {
            get
            {
                return this.starRatingField;
            }
            set
            {
                this.starRatingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("HotelRoom", IsNullable = false)]
        public ResponseResponseDetailsSearchHotelPriceResponseHotelHotelRoom[] HotelRooms
        {
            get
            {
                return this.hotelRoomsField;
            }
            set
            {
                this.hotelRoomsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("RoomCategory", IsNullable = false)]
        public ResponseResponseDetailsSearchHotelPriceResponseHotelRoomCategory[] RoomCategories
        {
            get
            {
                return this.roomCategoriesField;
            }
            set
            {
                this.roomCategoriesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool HasExtraInfo
        {
            get
            {
                return this.hasExtraInfoField;
            }
            set
            {
                this.hasExtraInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool HasPictures
        {
            get
            {
                return this.hasPicturesField;
            }
            set
            {
                this.hasPicturesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HasPicturesSpecified
        {
            get
            {
                return this.hasPicturesFieldSpecified;
            }
            set
            {
                this.hasPicturesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool HasMap
        {
            get
            {
                return this.hasMapField;
            }
            set
            {
                this.hasMapField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HasMapSpecified
        {
            get
            {
                return this.hasMapFieldSpecified;
            }
            set
            {
                this.hasMapFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsSearchHotelPriceResponseHotelCity
    {

        private string codeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsSearchHotelPriceResponseHotelItem
    {

        private string codeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsSearchHotelPriceResponseHotelLocation
    {

        private string codeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsSearchHotelPriceResponseHotelHotelRoom
    {

        private string codeField;

        private byte numberOfRoomsField;

        private bool extraBedField;

        private bool extraBedFieldSpecified;

        private byte numberOfExtraBedsField;

        private bool numberOfExtraBedsFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte NumberOfRooms
        {
            get
            {
                return this.numberOfRoomsField;
            }
            set
            {
                this.numberOfRoomsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ExtraBed
        {
            get
            {
                return this.extraBedField;
            }
            set
            {
                this.extraBedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExtraBedSpecified
        {
            get
            {
                return this.extraBedFieldSpecified;
            }
            set
            {
                this.extraBedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte NumberOfExtraBeds
        {
            get
            {
                return this.numberOfExtraBedsField;
            }
            set
            {
                this.numberOfExtraBedsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumberOfExtraBedsSpecified
        {
            get
            {
                return this.numberOfExtraBedsFieldSpecified;
            }
            set
            {
                this.numberOfExtraBedsFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsSearchHotelPriceResponseHotelRoomCategory
    {

        private string descriptionField;

        private ResponseResponseDetailsSearchHotelPriceResponseHotelRoomCategoryItemPrice itemPriceField;

        private ResponseResponseDetailsSearchHotelPriceResponseHotelRoomCategoryOffer offerField;

        private ResponseResponseDetailsSearchHotelPriceResponseHotelRoomCategoryConfirmation confirmationField;

        private bool sharingBeddingField;

        private ResponseResponseDetailsSearchHotelPriceResponseHotelRoomCategoryMeals mealsField;

        private ResponseResponseDetailsSearchHotelPriceResponseHotelRoomCategoryEssentialInformation essentialInformationField;

        private string idField;

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public ResponseResponseDetailsSearchHotelPriceResponseHotelRoomCategoryItemPrice ItemPrice
        {
            get
            {
                return this.itemPriceField;
            }
            set
            {
                this.itemPriceField = value;
            }
        }

        /// <remarks/>
        public ResponseResponseDetailsSearchHotelPriceResponseHotelRoomCategoryOffer Offer
        {
            get
            {
                return this.offerField;
            }
            set
            {
                this.offerField = value;
            }
        }

        /// <remarks/>
        public ResponseResponseDetailsSearchHotelPriceResponseHotelRoomCategoryConfirmation Confirmation
        {
            get
            {
                return this.confirmationField;
            }
            set
            {
                this.confirmationField = value;
            }
        }

        /// <remarks/>
        public bool SharingBedding
        {
            get
            {
                return this.sharingBeddingField;
            }
            set
            {
                this.sharingBeddingField = value;
            }
        }

        /// <remarks/>
        public ResponseResponseDetailsSearchHotelPriceResponseHotelRoomCategoryMeals Meals
        {
            get
            {
                return this.mealsField;
            }
            set
            {
                this.mealsField = value;
            }
        }

        /// <remarks/>
        public ResponseResponseDetailsSearchHotelPriceResponseHotelRoomCategoryEssentialInformation EssentialInformation
        {
            get
            {
                return this.essentialInformationField;
            }
            set
            {
                this.essentialInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsSearchHotelPriceResponseHotelRoomCategoryItemPrice
    {

        private string currencyField;

        private decimal grossWithoutDiscountField;

        private bool grossWithoutDiscountFieldSpecified;

        private decimal includedOfferDiscountField;

        private bool includedOfferDiscountFieldSpecified;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal GrossWithoutDiscount
        {
            get
            {
                return this.grossWithoutDiscountField;
            }
            set
            {
                this.grossWithoutDiscountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GrossWithoutDiscountSpecified
        {
            get
            {
                return this.grossWithoutDiscountFieldSpecified;
            }
            set
            {
                this.grossWithoutDiscountFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal IncludedOfferDiscount
        {
            get
            {
                return this.includedOfferDiscountField;
            }
            set
            {
                this.includedOfferDiscountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludedOfferDiscountSpecified
        {
            get
            {
                return this.includedOfferDiscountFieldSpecified;
            }
            set
            {
                this.includedOfferDiscountFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsSearchHotelPriceResponseHotelRoomCategoryOffer
    {

        private string codeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsSearchHotelPriceResponseHotelRoomCategoryConfirmation
    {

        private string codeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsSearchHotelPriceResponseHotelRoomCategoryMeals
    {

        private ResponseResponseDetailsSearchHotelPriceResponseHotelRoomCategoryMealsBasis basisField;

        private ResponseResponseDetailsSearchHotelPriceResponseHotelRoomCategoryMealsBreakfast breakfastField;

        /// <remarks/>
        public ResponseResponseDetailsSearchHotelPriceResponseHotelRoomCategoryMealsBasis Basis
        {
            get
            {
                return this.basisField;
            }
            set
            {
                this.basisField = value;
            }
        }

        /// <remarks/>
        public ResponseResponseDetailsSearchHotelPriceResponseHotelRoomCategoryMealsBreakfast Breakfast
        {
            get
            {
                return this.breakfastField;
            }
            set
            {
                this.breakfastField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsSearchHotelPriceResponseHotelRoomCategoryMealsBasis
    {

        private string codeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsSearchHotelPriceResponseHotelRoomCategoryMealsBreakfast
    {

        private string codeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsSearchHotelPriceResponseHotelRoomCategoryEssentialInformation
    {

        private ResponseResponseDetailsSearchHotelPriceResponseHotelRoomCategoryEssentialInformationInformation informationField;

        /// <remarks/>
        public ResponseResponseDetailsSearchHotelPriceResponseHotelRoomCategoryEssentialInformationInformation Information
        {
            get
            {
                return this.informationField;
            }
            set
            {
                this.informationField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsSearchHotelPriceResponseHotelRoomCategoryEssentialInformationInformation
    {

        private string textField;

        private ResponseResponseDetailsSearchHotelPriceResponseHotelRoomCategoryEssentialInformationInformationDateRange dateRangeField;

        /// <remarks/>
        public string Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        public ResponseResponseDetailsSearchHotelPriceResponseHotelRoomCategoryEssentialInformationInformationDateRange DateRange
        {
            get
            {
                return this.dateRangeField;
            }
            set
            {
                this.dateRangeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsSearchHotelPriceResponseHotelRoomCategoryEssentialInformationInformationDateRange
    {

        private System.DateTime fromDateField;

        private System.DateTime toDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime FromDate
        {
            get
            {
                return this.fromDateField;
            }
            set
            {
                this.fromDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime ToDate
        {
            get
            {
                return this.toDateField;
            }
            set
            {
                this.toDateField = value;
            }
        }
    }


}