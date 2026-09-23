// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InboundTransferOriginPaymentMethodOptionsUsBankAccountAchOptions : INestedOptions
    {
        /// <summary>
        /// Freeform payment-related information to transmit in the ACH addenda record. Maximum 80
        /// characters, ACH character set. Applied only when the payment routes over ACH. Immutable
        /// after creation.
        /// </summary>
        [JsonProperty("addenda")]
        [STJS.JsonPropertyName("addenda")]
        public string Addenda { get; set; }
    }
}
