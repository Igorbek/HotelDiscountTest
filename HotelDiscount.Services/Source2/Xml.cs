namespace HotelDiscount.Services.Source2
{

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class TWS_HotelList
    {

        private TWS_HotelListHotel[] hotelField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Hotel")]
        public TWS_HotelListHotel[] Hotel
        {
            get
            {
                return this.hotelField;
            }
            set
            {
                this.hotelField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TWS_HotelListHotel
    {

        private TWS_HotelListHotelRoomType[] roomTypeField;

        private uint hotelIdField;

        private string providerField;

        private string nameField;

        private string addressField;

        private string categoryField;

        private byte bestValField;

        private string thumbField;

        private byte starsLevelField;

        private decimal minAverPriceField;

        private string descField;

        private string locationField;

        private string currencyField;

        private byte brandIdField;

        private string brandNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RoomType")]
        public TWS_HotelListHotelRoomType[] RoomType
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint hotelId
        {
            get
            {
                return this.hotelIdField;
            }
            set
            {
                this.hotelIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string provider
        {
            get
            {
                return this.providerField;
            }
            set
            {
                this.providerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string category
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte bestVal
        {
            get
            {
                return this.bestValField;
            }
            set
            {
                this.bestValField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string thumb
        {
            get
            {
                return this.thumbField;
            }
            set
            {
                this.thumbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte starsLevel
        {
            get
            {
                return this.starsLevelField;
            }
            set
            {
                this.starsLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal minAverPrice
        {
            get
            {
                return this.minAverPriceField;
            }
            set
            {
                this.minAverPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string desc
        {
            get
            {
                return this.descField;
            }
            set
            {
                this.descField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currency
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
        public byte brandId
        {
            get
            {
                return this.brandIdField;
            }
            set
            {
                this.brandIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string brandName
        {
            get
            {
                return this.brandNameField;
            }
            set
            {
                this.brandNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TWS_HotelListHotelRoomType
    {

        private TWS_HotelListHotelRoomTypeOccup[] occupField;

        private string productIdField;

        private string nameField;

        private byte nightsField;

        private System.DateTime startDateField;

        private bool isAvailableField;

        private uint roomIdField;

        private uint hotelRoomTypeIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Occup")]
        public TWS_HotelListHotelRoomTypeOccup[] Occup
        {
            get
            {
                return this.occupField;
            }
            set
            {
                this.occupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string productId
        {
            get
            {
                return this.productIdField;
            }
            set
            {
                this.productIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte nights
        {
            get
            {
                return this.nightsField;
            }
            set
            {
                this.nightsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime startDate
        {
            get
            {
                return this.startDateField;
            }
            set
            {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isAvailable
        {
            get
            {
                return this.isAvailableField;
            }
            set
            {
                this.isAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint roomId
        {
            get
            {
                return this.roomIdField;
            }
            set
            {
                this.roomIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint hotelRoomTypeId
        {
            get
            {
                return this.hotelRoomTypeIdField;
            }
            set
            {
                this.hotelRoomTypeIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TWS_HotelListHotelRoomTypeOccup
    {

        private TWS_HotelListHotelRoomTypeOccupBoard boardField;

        private TWS_HotelListHotelRoomTypeOccupRoom roomField;

        private TWS_HotelListHotelRoomTypeOccupPrice[] priceField;

        private TWS_HotelListHotelRoomTypeOccupSelctedSupplements selctedSupplementsField;

        private string occupIdField;

        private decimal priceField1;

        private string beddingField;

        private bool my_dblBedField;

        private bool isPublishField;

        /// <remarks/>
        public TWS_HotelListHotelRoomTypeOccupBoard Board
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
        public TWS_HotelListHotelRoomTypeOccupRoom Room
        {
            get
            {
                return this.roomField;
            }
            set
            {
                this.roomField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Price")]
        public TWS_HotelListHotelRoomTypeOccupPrice[] Price
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
        public TWS_HotelListHotelRoomTypeOccupSelctedSupplements SelctedSupplements
        {
            get
            {
                return this.selctedSupplementsField;
            }
            set
            {
                this.selctedSupplementsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string occupId
        {
            get
            {
                return this.occupIdField;
            }
            set
            {
                this.occupIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal price
        {
            get
            {
                return this.priceField1;
            }
            set
            {
                this.priceField1 = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string bedding
        {
            get
            {
                return this.beddingField;
            }
            set
            {
                this.beddingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool my_dblBed
        {
            get
            {
                return this.my_dblBedField;
            }
            set
            {
                this.my_dblBedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isPublish
        {
            get
            {
                return this.isPublishField;
            }
            set
            {
                this.isPublishField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TWS_HotelListHotelRoomTypeOccupBoard
    {

        private uint bbIdField;

        private string nameField;

        private byte priceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint bbId
        {
            get
            {
                return this.bbIdField;
            }
            set
            {
                this.bbIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte price
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TWS_HotelListHotelRoomTypeOccupRoom
    {

        private byte seqNumField;

        private byte adultNumField;

        private byte childNumField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte seqNum
        {
            get
            {
                return this.seqNumField;
            }
            set
            {
                this.seqNumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte adultNum
        {
            get
            {
                return this.adultNumField;
            }
            set
            {
                this.adultNumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte childNum
        {
            get
            {
                return this.childNumField;
            }
            set
            {
                this.childNumField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TWS_HotelListHotelRoomTypeOccupPrice
    {

        private byte offsetField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte offset
        {
            get
            {
                return this.offsetField;
            }
            set
            {
                this.offsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal value
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
    public partial class TWS_HotelListHotelRoomTypeOccupSelctedSupplements
    {

        private TWS_HotelListHotelRoomTypeOccupSelctedSupplementsSupplement supplementField;

        /// <remarks/>
        public TWS_HotelListHotelRoomTypeOccupSelctedSupplementsSupplement Supplement
        {
            get
            {
                return this.supplementField;
            }
            set
            {
                this.supplementField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TWS_HotelListHotelRoomTypeOccupSelctedSupplementsSupplement
    {

        private TWS_HotelListHotelRoomTypeOccupSelctedSupplementsSupplementSuppAgeGroup suppAgeGroupField;

        private string typeField;

        private uint suppIdField;

        private string suppNameField;

        private byte supptTypeField;

        private bool suppIsMandatoryField;

        private string suppChargeTypeField;

        private decimal priceField;

        /// <remarks/>
        public TWS_HotelListHotelRoomTypeOccupSelctedSupplementsSupplementSuppAgeGroup SuppAgeGroup
        {
            get
            {
                return this.suppAgeGroupField;
            }
            set
            {
                this.suppAgeGroupField = value;
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
        public uint suppId
        {
            get
            {
                return this.suppIdField;
            }
            set
            {
                this.suppIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string suppName
        {
            get
            {
                return this.suppNameField;
            }
            set
            {
                this.suppNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte supptType
        {
            get
            {
                return this.supptTypeField;
            }
            set
            {
                this.supptTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool suppIsMandatory
        {
            get
            {
                return this.suppIsMandatoryField;
            }
            set
            {
                this.suppIsMandatoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string suppChargeType
        {
            get
            {
                return this.suppChargeTypeField;
            }
            set
            {
                this.suppChargeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal price
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TWS_HotelListHotelRoomTypeOccupSelctedSupplementsSupplementSuppAgeGroup
    {

        private TWS_HotelListHotelRoomTypeOccupSelctedSupplementsSupplementSuppAgeGroupSupplementAge supplementAgeField;

        /// <remarks/>
        public TWS_HotelListHotelRoomTypeOccupSelctedSupplementsSupplementSuppAgeGroupSupplementAge SupplementAge
        {
            get
            {
                return this.supplementAgeField;
            }
            set
            {
                this.supplementAgeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TWS_HotelListHotelRoomTypeOccupSelctedSupplementsSupplementSuppAgeGroupSupplementAge
    {

        private byte suppFromField;

        private byte suppToField;

        private byte suppQuantityField;

        private decimal suppPriceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte suppFrom
        {
            get
            {
                return this.suppFromField;
            }
            set
            {
                this.suppFromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte suppTo
        {
            get
            {
                return this.suppToField;
            }
            set
            {
                this.suppToField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte suppQuantity
        {
            get
            {
                return this.suppQuantityField;
            }
            set
            {
                this.suppQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal suppPrice
        {
            get
            {
                return this.suppPriceField;
            }
            set
            {
                this.suppPriceField = value;
            }
        }
    }


}