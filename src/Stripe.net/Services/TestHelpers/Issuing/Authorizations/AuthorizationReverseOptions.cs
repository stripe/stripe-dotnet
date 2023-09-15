// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationReverseOptions : BaseOptions
    {
        /// <summary>
        /// The amount to reverse from the authorization. If not provided, the full amount of the
        /// authorization will be reversed. This amount is in the authorization currency and in the
        /// <a href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("reverse_amount")]
        public long? ReverseAmount { get; set; }
    }
}
