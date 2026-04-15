// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class DisputeEvidenceEnhancedEvidenceVisaCompellingEvidence3DisputedTransactionOptions : INestedOptions, IHasSetTracking
    {
        private string customerAccountId;
        private string customerDeviceFingerprint;
        private string customerDeviceId;
        private string customerEmailAddress;
        private string customerPurchaseIp;
        private string productDescription;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// User Account ID used to log into business platform. Must be recognizable by the user.
        /// </summary>
        [JsonProperty("customer_account_id", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("customer_account_id")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string CustomerAccountId
        {
            get => this.customerAccountId;
            set
            {
                this.customerAccountId = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Unique identifier of the cardholder’s device derived from a combination of at least two
        /// hardware and software attributes. Must be at least 20 characters.
        /// </summary>
        [JsonProperty("customer_device_fingerprint", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("customer_device_fingerprint")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string CustomerDeviceFingerprint
        {
            get => this.customerDeviceFingerprint;
            set
            {
                this.customerDeviceFingerprint = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Unique identifier of the cardholder’s device such as a device serial number (e.g.,
        /// International Mobile Equipment Identity [IMEI]). Must be at least 15 characters.
        /// </summary>
        [JsonProperty("customer_device_id", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("customer_device_id")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string CustomerDeviceId
        {
            get => this.customerDeviceId;
            set
            {
                this.customerDeviceId = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The email address of the customer.
        /// </summary>
        [JsonProperty("customer_email_address", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("customer_email_address")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string CustomerEmailAddress
        {
            get => this.customerEmailAddress;
            set
            {
                this.customerEmailAddress = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The IP address that the customer used when making the purchase.
        /// </summary>
        [JsonProperty("customer_purchase_ip", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("customer_purchase_ip")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string CustomerPurchaseIp
        {
            get => this.customerPurchaseIp;
            set
            {
                this.customerPurchaseIp = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Categorization of disputed payment.
        /// One of: <c>merchandise</c>, or <c>services</c>.
        /// </summary>
        [JsonProperty("merchandise_or_services")]
        [STJS.JsonPropertyName("merchandise_or_services")]
        public string MerchandiseOrServices { get; set; }

        /// <summary>
        /// A description of the product or service that was sold.
        /// </summary>
        [JsonProperty("product_description", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("product_description")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string ProductDescription
        {
            get => this.productDescription;
            set
            {
                this.productDescription = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The address to which a physical product was shipped. All fields are required for Visa
        /// Compelling Evidence 3.0 evidence submission.
        /// </summary>
        [JsonProperty("shipping_address")]
        [STJS.JsonPropertyName("shipping_address")]
        public AddressOptions ShippingAddress { get; set; }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
