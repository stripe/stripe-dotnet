// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ReaderActionCollectInputsInputEmail : StripeEntity<ReaderActionCollectInputsInputEmail>
    {
        /// <summary>
        /// The collected email address.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
