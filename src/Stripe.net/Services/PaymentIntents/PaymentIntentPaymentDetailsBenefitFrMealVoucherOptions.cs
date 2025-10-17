// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentDetailsBenefitFrMealVoucherOptions : INestedOptions
    {
        /// <summary>
        /// The 14-digit SIRET of the meal voucher acceptor.
        /// </summary>
        [JsonProperty("siret")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("siret")]
#endif
        public string Siret { get; set; }
    }
}
