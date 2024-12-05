// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TokenCreateOptions : BaseOptions
    {
        /// <summary>
        /// Information for the account this token represents.
        /// </summary>
        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
#endif
        public TokenAccountOptions Account { get; set; }

        /// <summary>
        /// The bank account this token will represent.
        /// </summary>
        [JsonProperty("bank_account")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_account")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<string, TokenBankAccountOptions> BankAccount { get; set; }

        /// <summary>
        /// The card this token will represent. If you also pass in a customer, the card must be the
        /// ID of a card belonging to the customer. Otherwise, if you do not pass in a customer,
        /// this is a dictionary containing a user's credit card details, with the options described
        /// below.
        /// </summary>
        [JsonProperty("card")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<string, TokenCardOptions> Card { get; set; }

        /// <summary>
        /// Create a token for the customer, which is owned by the application's account. You can
        /// only use this with an <a href="https://stripe.com/docs/connect/standard-accounts">OAuth
        /// access token</a> or <a
        /// href="https://stripe.com/docs/connect/authentication">Stripe-Account header</a>. Learn
        /// more about <a
        /// href="https://stripe.com/docs/connect/cloning-saved-payment-methods">cloning saved
        /// payment methods</a>.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// The updated CVC value this token represents.
        /// </summary>
        [JsonProperty("cvc_update")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cvc_update")]
#endif
        public TokenCvcUpdateOptions CvcUpdate { get; set; }

        /// <summary>
        /// Information for the person this token represents.
        /// </summary>
        [JsonProperty("person")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("person")]
#endif
        public TokenPersonOptions Person { get; set; }

        /// <summary>
        /// The PII this token represents.
        /// </summary>
        [JsonProperty("pii")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pii")]
#endif
        public TokenPiiOptions Pii { get; set; }
    }
}
