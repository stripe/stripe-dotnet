// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class CreditGrantApplicabilityConfigScopePriceOptions : INestedOptions, IHasId
    {
        /// <summary>
        /// The price ID this credit grant should apply to.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
