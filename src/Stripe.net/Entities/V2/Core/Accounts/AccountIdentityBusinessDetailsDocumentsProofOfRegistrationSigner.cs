// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountIdentityBusinessDetailsDocumentsProofOfRegistrationSigner : StripeEntity<AccountIdentityBusinessDetailsDocumentsProofOfRegistrationSigner>
    {
        /// <summary>
        /// Person signing the document.
        /// </summary>
        [JsonProperty("person")]
        [STJS.JsonPropertyName("person")]
        public string Person { get; set; }
    }
}
