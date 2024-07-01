// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;

    public class InstitutionFeaturesBalances : StripeEntity<InstitutionFeaturesBalances>
    {
        /// <summary>
        /// Whether the given feature is supported by this institution.
        /// </summary>
        [JsonProperty("supported")]
        public bool Supported { get; set; }
    }
}
