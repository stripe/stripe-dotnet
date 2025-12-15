// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundTransferDestinationPaymentMethodOptionsUsBankAccountOptions : INestedOptions
    {
        /// <summary>
        /// Specifies the network rails to be used. If not set, will default to the PaymentMethod's
        /// preferred network. See the <a
        /// href="https://docs.stripe.com/treasury/money-movement/timelines">docs</a> to learn more
        /// about money movement timelines for each network type.
        /// One of: <c>ach</c>, or <c>us_domestic_wire</c>.
        /// </summary>
        [JsonProperty("network")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network")]
#endif
        public string Network { get; set; }
    }
}
