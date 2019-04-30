namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class BankAccountCreateOptions : BaseOptions
    {
        /// <summary>
        /// REQUIRED. Either a token, like the ones returned by
        /// <a href="https://stripe.com/docs/stripe.js">Stripe.js</a>, or a
        /// <see cref="SourceBankAccount"/> instance containing a user’s bank account
        /// details.
        /// </summary>
        [JsonProperty("source")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<string, SourceBankAccount> Source { get; set; }
    }
}
