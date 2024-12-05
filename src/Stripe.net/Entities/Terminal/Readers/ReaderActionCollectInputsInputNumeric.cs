// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ReaderActionCollectInputsInputNumeric : StripeEntity<ReaderActionCollectInputsInputNumeric>
    {
        /// <summary>
        /// The collected number.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
