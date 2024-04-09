// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ReaderActionCollectInputsInputPhone : StripeEntity<ReaderActionCollectInputsInputPhone>
    {
        /// <summary>
        /// The collected phone number.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
