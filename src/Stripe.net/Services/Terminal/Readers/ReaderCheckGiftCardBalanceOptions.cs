// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ReaderCheckGiftCardBalanceOptions : BaseOptions
    {
        /// <summary>
        /// The brand of the gift card.
        /// One of: <c>svs</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("brand")]
        [STJS.JsonPropertyName("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// Enables cancel button on gift card operation screens.
        /// </summary>
        [JsonProperty("enable_customer_cancellation")]
        [STJS.JsonPropertyName("enable_customer_cancellation")]
        public bool? EnableCustomerCancellation { get; set; }

        /// <summary>
        /// The Stripe account ID to process the gift card operation on behalf of.
        /// </summary>
        [JsonProperty("on_behalf_of")]
        [STJS.JsonPropertyName("on_behalf_of")]
        public string OnBehalfOf { get; set; }
    }
}
