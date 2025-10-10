// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReaderActionSetReaderDisplay : StripeEntity<ReaderActionSetReaderDisplay>
    {
        /// <summary>
        /// Cart object to be displayed by the reader, including line items, amounts, and currency.
        /// </summary>
        [JsonProperty("cart")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cart")]
#endif
        public ReaderActionSetReaderDisplayCart Cart { get; set; }

        /// <summary>
        /// Type of information to be displayed by the reader. Only <c>cart</c> is currently
        /// supported.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
