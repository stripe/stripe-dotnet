// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ReaderSetReaderDisplayOptions : BaseOptions
    {
        /// <summary>
        /// Cart details to display on the reader screen, including line items, amounts, and
        /// currency.
        /// </summary>
        [JsonProperty("cart")]
        [STJS.JsonPropertyName("cart")]
        public ReaderCartOptions Cart { get; set; }

        /// <summary>
        /// Type of information to display. Only <c>cart</c> is currently supported.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
