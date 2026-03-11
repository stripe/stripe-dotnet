// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OffSessionPaymentCreatePaymentMethodDataCardOptions : INestedOptions
    {
        /// <summary>
        /// The card CVC.
        /// </summary>
        [JsonProperty("cvc")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cvc")]
#endif
        public string Cvc { get; set; }

        /// <summary>
        /// The card expiration month.
        /// </summary>
        [JsonProperty("exp_month")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("exp_month")]
#endif
        public string ExpMonth { get; set; }

        /// <summary>
        /// The card expiration year.
        /// </summary>
        [JsonProperty("exp_year")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("exp_year")]
#endif
        public string ExpYear { get; set; }

        /// <summary>
        /// The card number.
        /// </summary>
        [JsonProperty("number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("number")]
#endif
        public string Number { get; set; }
    }
}
