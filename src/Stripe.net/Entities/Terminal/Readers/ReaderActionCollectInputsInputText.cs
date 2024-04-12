// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ReaderActionCollectInputsInputText : StripeEntity<ReaderActionCollectInputsInputText>
    {
        /// <summary>
        /// The collected text value.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
