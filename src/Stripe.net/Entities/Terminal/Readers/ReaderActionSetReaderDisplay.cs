// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReaderActionSetReaderDisplay : StripeEntity<ReaderActionSetReaderDisplay>
    {
        /// <summary>
        /// Cart object to be displayed by the reader, including line items, amounts, and currency.
        /// </summary>
        [JsonProperty("cart")]
        [STJS.JsonPropertyName("cart")]
        public ReaderActionSetReaderDisplayCart Cart { get; set; }

        /// <summary>
        /// Type of information to be displayed by the reader. Only <c>cart</c> is currently
        /// supported.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
