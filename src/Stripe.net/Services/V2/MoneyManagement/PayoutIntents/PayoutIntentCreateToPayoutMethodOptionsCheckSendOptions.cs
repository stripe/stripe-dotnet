// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PayoutIntentCreateToPayoutMethodOptionsCheckSendOptions : INestedOptions
    {
        /// <summary>
        /// The ID of a file to include as an attachment with the check.
        /// </summary>
        [JsonProperty("attachment_file")]
        [STJS.JsonPropertyName("attachment_file")]
        public string AttachmentFile { get; set; }

        /// <summary>
        /// Memo printed on the memo field of the check.
        /// </summary>
        [JsonProperty("memo")]
        [STJS.JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// Open Enum. Shipping speed of the check. Defaults to standard.
        /// One of: <c>priority</c>, or <c>standard</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("shipping_speed")]
        [STJS.JsonPropertyName("shipping_speed")]
        public string ShippingSpeed { get; set; }

        /// <summary>
        /// Signature printed on the check.
        /// </summary>
        [JsonProperty("signature")]
        [STJS.JsonPropertyName("signature")]
        public string Signature { get; set; }
    }
}
