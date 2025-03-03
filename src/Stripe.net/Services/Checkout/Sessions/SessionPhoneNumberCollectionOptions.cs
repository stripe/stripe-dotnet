// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionPhoneNumberCollectionOptions : INestedOptions
    {
        /// <summary>
        /// Set to <c>true</c> to enable phone number collection.
        ///
        /// Can only be set in <c>payment</c> and <c>subscription</c> mode.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
    }
}
