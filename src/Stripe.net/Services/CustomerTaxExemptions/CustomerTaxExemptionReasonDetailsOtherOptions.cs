// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CustomerTaxExemptionReasonDetailsOtherOptions : INestedOptions
    {
        /// <summary>
        /// A free-text description of the exemption reason. Maximum 5000 characters.
        /// </summary>
        [JsonProperty("reason_text")]
        [STJS.JsonPropertyName("reason_text")]
        public string ReasonText { get; set; }
    }
}
