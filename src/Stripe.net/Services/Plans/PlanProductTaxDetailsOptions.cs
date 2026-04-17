// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PlanProductTaxDetailsOptions : INestedOptions, IHasSetTracking
    {
        private string taxCode;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// A tax location ID. Depending on the <a
        /// href="https://stripe.com/tax/tax-for-tickets/reference/tax-location-performance">tax
        /// code</a>, this is required, optional, or not supported.
        /// </summary>
        [JsonProperty("performance_location")]
        [STJS.JsonPropertyName("performance_location")]
        public string PerformanceLocation { get; set; }

        /// <summary>
        /// A <a href="https://docs.stripe.com/tax/tax-categories">tax code</a> ID.
        /// </summary>
        [JsonProperty("tax_code", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("tax_code")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string TaxCode
        {
            get => this.taxCode;
            set
            {
                this.taxCode = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
