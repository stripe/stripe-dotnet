// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;

    public class InstitutionFeaturesPaymentMethod : StripeEntity<InstitutionFeaturesPaymentMethod>
    {
        /// <summary>
        /// Whether the given feature is supported by this institution.
        /// </summary>
        [JsonProperty("supported")]
        public bool Supported { get; set; }
    }
}
