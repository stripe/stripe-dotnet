// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodDataBillingDetailsOptions : INestedOptions, IHasSetTracking
    {
        private AddressOptions address;
        private string email;
        private string name;
        private string phone;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Billing address.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public AddressOptions Address
        {
            get => this.address;
            set
            {
                this.address = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Email address.
        /// </summary>
        [JsonProperty("email")]
        [STJS.JsonPropertyName("email")]
        public string Email
        {
            get => this.email;
            set
            {
                this.email = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Full name.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name
        {
            get => this.name;
            set
            {
                this.name = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Billing phone number (including extension).
        /// </summary>
        [JsonProperty("phone")]
        [STJS.JsonPropertyName("phone")]
        public string Phone
        {
            get => this.phone;
            set
            {
                this.phone = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Taxpayer identification number. Used only for transactions between LATAM buyers and
        /// non-LATAM sellers.
        /// </summary>
        [JsonProperty("tax_id")]
        [STJS.JsonPropertyName("tax_id")]
        public string TaxId { get; set; }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
