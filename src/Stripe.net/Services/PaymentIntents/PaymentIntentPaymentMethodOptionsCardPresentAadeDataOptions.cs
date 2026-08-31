// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodOptionsCardPresentAadeDataOptions : INestedOptions
    {
        /// <summary>
        /// The canonical string that was signed by the e-invoicing provider to produce
        /// <c>signed_mark</c>, formatted per Appendix A of A.1155/2023. Required when <c>mode</c>
        /// is <c>standard</c>.
        /// </summary>
        [JsonProperty("mark_data")]
        [STJS.JsonPropertyName("mark_data")]
        public string MarkData { get; set; }

        /// <summary>
        /// The e-invoicing mode under which the mark was generated.
        /// One of: <c>autonomous</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("mode")]
        [STJS.JsonPropertyName("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// The AADE-assigned approval number of the e-invoicing provider that generated the mark.
        /// Required when <c>mode</c> is <c>standard</c>.
        /// </summary>
        [JsonProperty("provider_id")]
        [STJS.JsonPropertyName("provider_id")]
        public long? ProviderId { get; set; }

        /// <summary>
        /// The cryptographic signature returned by the e-invoicing provider for this transaction,
        /// hex-encoded. Required when <c>mode</c> is <c>standard</c>.
        /// </summary>
        [JsonProperty("signed_mark")]
        [STJS.JsonPropertyName("signed_mark")]
        public string SignedMark { get; set; }

        /// <summary>
        /// The reason for entering autonomous mode. Required when <c>mode</c> is <c>autonomous</c>.
        /// One of: <c>interconnection_loss</c>, <c>lock</c>, or <c>replacement_cash_system</c>.
        /// </summary>
        [JsonProperty("unbound_pos")]
        [STJS.JsonPropertyName("unbound_pos")]
        public string UnboundPos { get; set; }
    }
}
