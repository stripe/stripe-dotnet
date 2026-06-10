// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class GiftCardVoidOperationOptions : BaseOptions
    {
        /// <summary>
        /// The Stripe account ID to process the gift card operation on behalf of.
        /// </summary>
        [JsonProperty("on_behalf_of")]
        [STJS.JsonPropertyName("on_behalf_of")]
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// The ID of the gift card operation to void.
        /// </summary>
        [JsonProperty("operation")]
        [STJS.JsonPropertyName("operation")]
        public string Operation { get; set; }
    }
}
