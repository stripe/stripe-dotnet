// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TokenCreateOptions : BaseOptions
    {
        /// <summary>
        /// Information for the account this token represents.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public TokenAccountOptions Account { get; set; }

        /// <summary>
        /// The bank account this token will represent.
        /// </summary>
        [JsonProperty("bank_account")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("bank_account")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<string, TokenBankAccountOptions> BankAccount { get; set; }

        /// <summary>
        /// The card this token will represent. If you also pass in a customer, the card must be the
        /// ID of a card belonging to the customer. Otherwise, if you do not pass in a customer,
        /// this is a dictionary containing a user's credit card details, with the options described
        /// below.
        /// </summary>
        [JsonProperty("card")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("card")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<string, TokenCardOptions> Card { get; set; }

        /// <summary>
        /// Create a token for the customer, which is owned by the application's account. You can
        /// only use this with an <a href="https://docs.stripe.com/connect/standard-accounts">OAuth
        /// access token</a> or <a
        /// href="https://docs.stripe.com/connect/authentication">Stripe-Account header</a>. Learn
        /// more about <a
        /// href="https://docs.stripe.com/connect/cloning-saved-payment-methods">cloning saved
        /// payment methods</a>.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The updated CVC value this token represents.
        /// </summary>
        [JsonProperty("cvc_update")]
        [STJS.JsonPropertyName("cvc_update")]
        public TokenCvcUpdateOptions CvcUpdate { get; set; }

        /// <summary>
        /// Information for the person this token represents.
        /// </summary>
        [JsonProperty("person")]
        [STJS.JsonPropertyName("person")]
        public TokenPersonOptions Person { get; set; }

        /// <summary>
        /// The PII this token represents.
        /// </summary>
        [JsonProperty("pii")]
        [STJS.JsonPropertyName("pii")]
        public TokenPiiOptions Pii { get; set; }
    }
}
