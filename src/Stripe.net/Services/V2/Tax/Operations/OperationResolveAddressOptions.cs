// File generated from our OpenAPI spec
namespace Stripe.V2.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OperationResolveAddressOptions : BaseOptions
    {
        /// <summary>
        /// The address to resolve.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public OperationResolveAddressAddressOptions Address { get; set; }
    }
}
