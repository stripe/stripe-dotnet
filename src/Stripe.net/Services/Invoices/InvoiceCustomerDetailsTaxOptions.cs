// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceCustomerDetailsTaxOptions : INestedOptions, IHasSetTracking
    {
        private string ipAddress;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// A recent IP address of the customer used for tax reporting and tax location inference.
        /// Stripe recommends updating the IP address when a new PaymentMethod is attached or the
        /// address field on the customer is updated. We recommend against updating this field more
        /// frequently since it could result in unexpected tax location/reporting outcomes.
        /// </summary>
        [JsonProperty("ip_address")]
        [STJS.JsonPropertyName("ip_address")]
        public string IpAddress
        {
            get => this.ipAddress;
            set
            {
                this.ipAddress = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
