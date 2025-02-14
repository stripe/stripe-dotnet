// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class CreditGrantApplicabilityConfigScopePrice : StripeEntity<CreditGrantApplicabilityConfigScopePrice>, IHasId
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
