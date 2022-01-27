// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkPhoneNumberCollectionOptions : INestedOptions
    {
        /// <summary>
        /// Set to <c>true</c> to enable phone number collection.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
    }
}
