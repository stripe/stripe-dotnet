// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CadenceCreatePayerOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the Billing Profile object which determines how a bill will be paid. If
        /// provided, the created cadence will be associated with the provided Billing Profile. If
        /// not provided, a new Billing Profile will be created and associated with the cadence.
        /// </summary>
        [JsonProperty("billing_profile")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_profile")]
#endif
        public string BillingProfile { get; set; }

        /// <summary>
        /// The ID of the Customer object.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// A string identifying the type of the payer. Currently the only supported value is
        /// <c>customer</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
