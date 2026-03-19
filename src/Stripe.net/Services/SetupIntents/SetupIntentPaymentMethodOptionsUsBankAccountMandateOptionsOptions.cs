// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SetupIntentPaymentMethodOptionsUsBankAccountMandateOptionsOptions : INestedOptions
    {
        /// <summary>
        /// The method used to collect offline mandate customer acceptance.
        /// </summary>
        [JsonProperty("collection_method")]
        [STJS.JsonPropertyName("collection_method")]
        public string CollectionMethod { get; set; }
    }
}
