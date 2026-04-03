// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ChargePaymentDetailsFleetDatumVatOptions : INestedOptions
    {
        /// <summary>
        /// Indicates the merchant's agreement for Invoice on Behalf (IOB) VAT processing.
        /// One of: <c>issuer_to_iob</c>, <c>issuer_to_iob_and_incremental_certification</c>, or
        /// <c>merchant_does_not_agree_to_iob</c>.
        /// </summary>
        [JsonProperty("iob_indicator")]
        [STJS.JsonPropertyName("iob_indicator")]
        public string IobIndicator { get; set; }
    }
}
