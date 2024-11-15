// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentMethodOptionsUsBankAccountMandateOptionsOptions : INestedOptions
    {
        /// <summary>
        /// The method used to collect offline mandate customer acceptance.
        /// </summary>
        [JsonProperty("collection_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("collection_method")]
#endif

        public string CollectionMethod { get; set; }
    }
}
