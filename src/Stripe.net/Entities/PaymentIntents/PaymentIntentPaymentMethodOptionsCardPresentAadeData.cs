// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentMethodOptionsCardPresentAadeData : StripeEntity<PaymentIntentPaymentMethodOptionsCardPresentAadeData>
    {
        /// <summary>
        /// The e-invoicing mode under which the provider signature was generated.
        /// One of: <c>autonomous</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("mode")]
        [STJS.JsonPropertyName("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// The AADE-assigned approval number of the e-invoicing provider that generated the
        /// provider signature. Required when <c>mode</c> is <c>standard</c>.
        /// </summary>
        [JsonProperty("provider_id")]
        [STJS.JsonPropertyName("provider_id")]
        public long ProviderId { get; set; }

        /// <summary>
        /// The cryptographic signature returned by the e-invoicing provider for this transaction,
        /// hex-encoded. Required when <c>mode</c> is <c>standard</c>.
        /// </summary>
        [JsonProperty("provider_signature")]
        [STJS.JsonPropertyName("provider_signature")]
        public string ProviderSignature { get; set; }

        /// <summary>
        /// The canonical string that was signed by the e-invoicing provider to produce
        /// <c>provider_signature</c>, formatted per Appendix A of A.1155/2023. Required when
        /// <c>mode</c> is <c>standard</c>.
        /// </summary>
        [JsonProperty("provider_signature_data")]
        [STJS.JsonPropertyName("provider_signature_data")]
        public string ProviderSignatureData { get; set; }

        /// <summary>
        /// The reason for entering autonomous mode. Required when <c>mode</c> is <c>autonomous</c>.
        /// One of: <c>interconnection_loss</c>, <c>lock</c>, or <c>replacement_cash_system</c>.
        /// </summary>
        [JsonProperty("unbound_pos")]
        [STJS.JsonPropertyName("unbound_pos")]
        public string UnboundPos { get; set; }
    }
}
