namespace HotelDiscount.Services.Source3
{

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class HotelValuedAvailRS
    {

        private HotelValuedAvailRSServiceHotel[] serviceHotelField;

        private uint timeToExpirationField;

        private byte totalItemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ServiceHotel")]
        public HotelValuedAvailRSServiceHotel[] ServiceHotel
        {
            get
            {
                return this.serviceHotelField;
            }
            set
            {
                this.serviceHotelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint timeToExpiration
        {
            get
            {
                return this.timeToExpirationField;
            }
            set
            {
                this.timeToExpirationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte totalItems
        {
            get
            {
                return this.totalItemsField;
            }
            set
            {
                this.totalItemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute("ServiceHotel")]
    public partial class HotelValuedAvailRSServiceHotel
    {

        private HotelValuedAvailRSServiceHotelContractList contractListField;

        private HotelValuedAvailRSServiceHotelDateFrom dateFromField;

        private HotelValuedAvailRSServiceHotelDateTo dateToField;

        private HotelValuedAvailRSServiceHotelCurrency currencyField;

        private HotelValuedAvailRSServiceHotelHotelInfo hotelInfoField;

        private HotelValuedAvailRSServiceHotelAvailableRoom[] availableRoomField;

        private string availTokenField;

        /// <remarks/>
        public HotelValuedAvailRSServiceHotelContractList ContractList
        {
            get
            {
                return this.contractListField;
            }
            set
            {
                this.contractListField = value;
            }
        }

        /// <remarks/>
        public HotelValuedAvailRSServiceHotelDateFrom DateFrom
        {
            get
            {
                return this.dateFromField;
            }
            set
            {
                this.dateFromField = value;
            }
        }

        /// <remarks/>
        public HotelValuedAvailRSServiceHotelDateTo DateTo
        {
            get
            {
                return this.dateToField;
            }
            set
            {
                this.dateToField = value;
            }
        }

        /// <remarks/>
        public HotelValuedAvailRSServiceHotelCurrency Currency
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
        public HotelValuedAvailRSServiceHotelHotelInfo HotelInfo
        {
            get
            {
                return this.hotelInfoField;
            }
            set
            {
                this.hotelInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AvailableRoom")]
        public HotelValuedAvailRSServiceHotelAvailableRoom[] AvailableRoom
        {
            get
            {
                return this.availableRoomField;
            }
            set
            {
                this.availableRoomField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string availToken
        {
            get
            {
                return this.availTokenField;
            }
            set
            {
                this.availTokenField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelValuedAvailRSServiceHotelContractList
    {

        private HotelValuedAvailRSServiceHotelContractListContract contractField;

        /// <remarks/>
        public HotelValuedAvailRSServiceHotelContractListContract Contract
        {
            get
            {
                return this.contractField;
            }
            set
            {
                this.contractField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelValuedAvailRSServiceHotelContractListContract
    {

        private string nameField;

        private HotelValuedAvailRSServiceHotelContractListContractIncomingOffice incomingOfficeField;

        private HotelValuedAvailRSServiceHotelContractListContractClassification classificationField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public HotelValuedAvailRSServiceHotelContractListContractIncomingOffice IncomingOffice
        {
            get
            {
                return this.incomingOfficeField;
            }
            set
            {
                this.incomingOfficeField = value;
            }
        }

        /// <remarks/>
        public HotelValuedAvailRSServiceHotelContractListContractClassification Classification
        {
            get
            {
                return this.classificationField;
            }
            set
            {
                this.classificationField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelValuedAvailRSServiceHotelContractListContractIncomingOffice
    {

        private byte codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte code
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelValuedAvailRSServiceHotelContractListContractClassification
    {

        private string codeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code
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
    public partial class HotelValuedAvailRSServiceHotelDateFrom
    {

        private uint dateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelValuedAvailRSServiceHotelDateTo
    {

        private uint dateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelValuedAvailRSServiceHotelCurrency
    {

        private string codeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code
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
    [System.Xml.Serialization.XmlTypeAttribute("ProductHotel")]
    public partial class HotelValuedAvailRSServiceHotelHotelInfo
    {

        private uint codeField;

        private string nameField;

        private HotelValuedAvailRSServiceHotelHotelInfoImage[] imageListField;

        private HotelValuedAvailRSServiceHotelHotelInfoCategory categoryField;

        private HotelValuedAvailRSServiceHotelHotelInfoDestination destinationField;

        private HotelValuedAvailRSServiceHotelHotelInfoChildAge childAgeField;

        private HotelValuedAvailRSServiceHotelHotelInfoPosition positionField;

        /// <remarks/>
        public uint Code
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
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Image", IsNullable = false)]
        public HotelValuedAvailRSServiceHotelHotelInfoImage[] ImageList
        {
            get
            {
                return this.imageListField;
            }
            set
            {
                this.imageListField = value;
            }
        }

        /// <remarks/>
        public HotelValuedAvailRSServiceHotelHotelInfoCategory Category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        public HotelValuedAvailRSServiceHotelHotelInfoDestination Destination
        {
            get
            {
                return this.destinationField;
            }
            set
            {
                this.destinationField = value;
            }
        }

        /// <remarks/>
        public HotelValuedAvailRSServiceHotelHotelInfoChildAge ChildAge
        {
            get
            {
                return this.childAgeField;
            }
            set
            {
                this.childAgeField = value;
            }
        }

        /// <remarks/>
        public HotelValuedAvailRSServiceHotelHotelInfoPosition Position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelValuedAvailRSServiceHotelHotelInfoImage
    {

        private string typeField;

        private byte orderField;

        private byte visualizationOrderField;

        private string urlField;

        /// <remarks/>
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public byte Order
        {
            get
            {
                return this.orderField;
            }
            set
            {
                this.orderField = value;
            }
        }

        /// <remarks/>
        public byte VisualizationOrder
        {
            get
            {
                return this.visualizationOrderField;
            }
            set
            {
                this.visualizationOrderField = value;
            }
        }

        /// <remarks/>
        public string Url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelValuedAvailRSServiceHotelHotelInfoCategory
    {

        private string typeField;

        private string codeField;

        private string shortnameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code
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
        public string shortname
        {
            get
            {
                return this.shortnameField;
            }
            set
            {
                this.shortnameField = value;
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
    public partial class HotelValuedAvailRSServiceHotelHotelInfoDestination
    {

        private string nameField;

        private HotelValuedAvailRSServiceHotelHotelInfoDestinationZoneList zoneListField;

        private string typeField;

        private string codeField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public HotelValuedAvailRSServiceHotelHotelInfoDestinationZoneList ZoneList
        {
            get
            {
                return this.zoneListField;
            }
            set
            {
                this.zoneListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelValuedAvailRSServiceHotelHotelInfoDestinationZoneList
    {

        private HotelValuedAvailRSServiceHotelHotelInfoDestinationZoneListZone zoneField;

        /// <remarks/>
        public HotelValuedAvailRSServiceHotelHotelInfoDestinationZoneListZone Zone
        {
            get
            {
                return this.zoneField;
            }
            set
            {
                this.zoneField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelValuedAvailRSServiceHotelHotelInfoDestinationZoneListZone
    {

        private string typeField;

        private byte codeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte code
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
    public partial class HotelValuedAvailRSServiceHotelHotelInfoChildAge
    {

        private byte ageFromField;

        private byte ageToField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ageFrom
        {
            get
            {
                return this.ageFromField;
            }
            set
            {
                this.ageFromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ageTo
        {
            get
            {
                return this.ageToField;
            }
            set
            {
                this.ageToField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelValuedAvailRSServiceHotelHotelInfoPosition
    {

        private decimal latitudeField;

        private decimal longitudeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelValuedAvailRSServiceHotelAvailableRoom
    {

        private HotelValuedAvailRSServiceHotelAvailableRoomHotelOccupancy hotelOccupancyField;

        private HotelValuedAvailRSServiceHotelAvailableRoomHotelRoom hotelRoomField;

        /// <remarks/>
        public HotelValuedAvailRSServiceHotelAvailableRoomHotelOccupancy HotelOccupancy
        {
            get
            {
                return this.hotelOccupancyField;
            }
            set
            {
                this.hotelOccupancyField = value;
            }
        }

        /// <remarks/>
        public HotelValuedAvailRSServiceHotelAvailableRoomHotelRoom HotelRoom
        {
            get
            {
                return this.hotelRoomField;
            }
            set
            {
                this.hotelRoomField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelValuedAvailRSServiceHotelAvailableRoomHotelOccupancy
    {

        private byte roomCountField;

        private HotelValuedAvailRSServiceHotelAvailableRoomHotelOccupancyOccupancy occupancyField;

        /// <remarks/>
        public byte RoomCount
        {
            get
            {
                return this.roomCountField;
            }
            set
            {
                this.roomCountField = value;
            }
        }

        /// <remarks/>
        public HotelValuedAvailRSServiceHotelAvailableRoomHotelOccupancyOccupancy Occupancy
        {
            get
            {
                return this.occupancyField;
            }
            set
            {
                this.occupancyField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelValuedAvailRSServiceHotelAvailableRoomHotelOccupancyOccupancy
    {

        private byte adultCountField;

        private byte childCountField;

        /// <remarks/>
        public byte AdultCount
        {
            get
            {
                return this.adultCountField;
            }
            set
            {
                this.adultCountField = value;
            }
        }

        /// <remarks/>
        public byte ChildCount
        {
            get
            {
                return this.childCountField;
            }
            set
            {
                this.childCountField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelValuedAvailRSServiceHotelAvailableRoomHotelRoom
    {

        private HotelValuedAvailRSServiceHotelAvailableRoomHotelRoomBoard boardField;

        private HotelValuedAvailRSServiceHotelAvailableRoomHotelRoomRoomType roomTypeField;

        private HotelValuedAvailRSServiceHotelAvailableRoomHotelRoomPrice priceField;

        private string sHRUIField;

        private byte availCountField;

        private string onRequestField;

        /// <remarks/>
        public HotelValuedAvailRSServiceHotelAvailableRoomHotelRoomBoard Board
        {
            get
            {
                return this.boardField;
            }
            set
            {
                this.boardField = value;
            }
        }

        /// <remarks/>
        public HotelValuedAvailRSServiceHotelAvailableRoomHotelRoomRoomType RoomType
        {
            get
            {
                return this.roomTypeField;
            }
            set
            {
                this.roomTypeField = value;
            }
        }

        /// <remarks/>
        public HotelValuedAvailRSServiceHotelAvailableRoomHotelRoomPrice Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SHRUI
        {
            get
            {
                return this.sHRUIField;
            }
            set
            {
                this.sHRUIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte availCount
        {
            get
            {
                return this.availCountField;
            }
            set
            {
                this.availCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string onRequest
        {
            get
            {
                return this.onRequestField;
            }
            set
            {
                this.onRequestField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelValuedAvailRSServiceHotelAvailableRoomHotelRoomBoard
    {

        private string typeField;

        private string codeField;

        private string shortnameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code
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
        public string shortname
        {
            get
            {
                return this.shortnameField;
            }
            set
            {
                this.shortnameField = value;
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
    public partial class HotelValuedAvailRSServiceHotelAvailableRoomHotelRoomRoomType
    {

        private string typeField;

        private string codeField;

        private string characteristicField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code
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
        public string characteristic
        {
            get
            {
                return this.characteristicField;
            }
            set
            {
                this.characteristicField = value;
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
    public partial class HotelValuedAvailRSServiceHotelAvailableRoomHotelRoomPrice
    {

        private decimal amountField;

        /// <remarks/>
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }


}