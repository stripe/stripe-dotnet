// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CustomerTaxExemptionReasonDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Details for the <c>other</c> exemption reason.
        /// </summary>
        [JsonProperty("other")]
        [STJS.JsonPropertyName("other")]
        public CustomerTaxExemptionReasonDetailsOtherOptions Other { get; set; }
    }
}
