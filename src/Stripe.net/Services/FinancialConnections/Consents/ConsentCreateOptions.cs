// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ConsentCreateOptions : BaseOptions
    {
        /// <summary>
        /// The account holder for whom the Consent is issued.
        /// </summary>
        [JsonProperty("account_holder")]
        [STJS.JsonPropertyName("account_holder")]
        public ConsentAccountHolderOptions AccountHolder { get; set; }

        /// <summary>
        /// The customer's preferred locale for the consent text, expressed as a BCP 47 language
        /// tag. If omitted, Stripe uses the default locale.
        /// </summary>
        [JsonProperty("locale")]
        [STJS.JsonPropertyName("locale")]
        public string Locale { get; set; }
    }
}
