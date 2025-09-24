// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CadenceUpdatePayerOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the Billing Profile object which determines how a bill will be paid.
        /// </summary>
        [JsonProperty("billing_profile")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_profile")]
#endif
        public string BillingProfile { get; set; }
    }
}
