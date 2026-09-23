// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InboundTransferOriginPaymentMethodDetailsUsBankAccountAch : StripeEntity<InboundTransferOriginPaymentMethodDetailsUsBankAccountAch>
    {
        /// <summary>
        /// Freeform payment-related information transmitted in the ACH addenda record.
        /// </summary>
        [JsonProperty("addenda")]
        [STJS.JsonPropertyName("addenda")]
        public string Addenda { get; set; }
    }
}
