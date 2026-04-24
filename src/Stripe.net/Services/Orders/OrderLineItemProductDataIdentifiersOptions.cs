// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OrderLineItemProductDataIdentifiersOptions : INestedOptions, IHasSetTracking
    {
        private string ean;
        private string gtin;
        private string isbn;
        private string jan;
        private string mpn;
        private string nsn;
        private string upc;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// European Article Number (EAN) consisting of 8 or 13 digits and optional dashes. You may
        /// optionally provide a leading 0 for a total of 14 digits. The final digit is a validated
        /// check digit.
        /// </summary>
        [JsonProperty("ean", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("ean")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string Ean
        {
            get => this.ean;
            set
            {
                this.ean = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Global Trade Item Number (GTIN) consisting of 8, 12, 13, or 14 digits and optional
        /// dashes. The final digit is a validated check digit.
        /// </summary>
        [JsonProperty("gtin", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("gtin")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string Gtin
        {
            get => this.gtin;
            set
            {
                this.gtin = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// International Standard Book Number (ISBN) consisting of 10 or 13 digits and optional
        /// dashes. The final digit is a validated check digit. For ISBN-10, the final digit may be
        /// a <c>X</c>.
        /// </summary>
        [JsonProperty("isbn", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("isbn")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string Isbn
        {
            get => this.isbn;
            set
            {
                this.isbn = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Japanese Article Number (JAN) consisting of 13 digits and optional dashes. The first two
        /// digits must either be <c>45</c> or <c>49</c>. The final digit is a validated check
        /// digit.
        /// </summary>
        [JsonProperty("jan", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("jan")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string Jan
        {
            get => this.jan;
            set
            {
                this.jan = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Manufacturer Part Number (MPN). May include up to 70 alphanumeric characters and dashes.
        /// </summary>
        [JsonProperty("mpn", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("mpn")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string Mpn
        {
            get => this.mpn;
            set
            {
                this.mpn = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// National Stock Number (NSN) consisting of 13 digits and optional dashes. The seventh
        /// character may also be alphanumeric.
        /// </summary>
        [JsonProperty("nsn", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("nsn")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string Nsn
        {
            get => this.nsn;
            set
            {
                this.nsn = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Universal Product Code (UPC) consisting of 12 digits and optional dashes. The final
        /// digit is a validated check digit.
        /// </summary>
        [JsonProperty("upc", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("upc")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string Upc
        {
            get => this.upc;
            set
            {
                this.upc = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
