// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsUsBankAccountMandateOptionsOptions : INestedOptions
    {
        /// <summary>
        /// The method used to collect offline mandate customer acceptance.
        /// </summary>
        [JsonProperty("collection_method")]
        public string CollectionMethod { get; set; }
    }
}
