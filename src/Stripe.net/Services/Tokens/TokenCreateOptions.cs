namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class TokenCreateOptions : BaseOptions
    {
        /// <summary>
        /// The customer (owned by the application's account) for which to create a token. For use
        /// only with <a href="https://stripe.com/docs/connect">Stripe Connect</a>. Also, this can
        /// be used only with an <a href="https://stripe.com/docs/connect/standard-accounts">OAuth
        /// access token</a> or
        /// <a href="https://stripe.com/docs/connect/authentication">Stripe-Account header</a>. For
        /// more details, see <a href="https://stripe.com/docs/connect/shared-customers">Shared
        /// Customers</a>.
        /// </summary>
        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        /// <summary>
        /// The card this token will represent. If you also pass in a customer, the card must be the
        /// ID of a card belonging to the customer. Otherwise, if you do not pass in a customer,
        /// this is a <see cref="CreditCardOptions"/> instance containing a user's credit card
        /// details.
        /// </summary>
        [JsonProperty("card")]
        public AnyOf<string, CreditCardOptions> Card { get; set; }

        /// <summary>
        /// The bank account this token will represent. If you also pass in a customer, the bank
        /// account must be the ID of a bank account belonging to the customer. Otherwise, if you do
        /// not pass in a customer, this is a <see cref="BankAccountOptions"/> instance containing a
        /// user's bank account details.
        /// </summary>
        [JsonProperty("bank_account")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<string, BankAccountOptions> BankAccount { get; set; }
    }
}
