// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SourceReceiverOptions : INestedOptions
    {
        /// <summary>
        /// The method Stripe should use to request information needed to process a refund or
        /// mispayment. Either <c>email</c> (an email is sent directly to the customer) or
        /// <c>manual</c> (a <c>source.refund_attributes_required</c> event is sent to your webhooks
        /// endpoint). Refer to each payment method's documentation to learn which refund attributes
        /// may be required.
        /// One of: <c>email</c>, <c>manual</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("refund_attributes_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refund_attributes_method")]
#endif
        public string RefundAttributesMethod { get; set; }
    }
}
