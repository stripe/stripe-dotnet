namespace Stripe
{
    using Stripe.Infrastructure;

    public class TokenCreateOptions : BaseOptions
    {
        [FormProperty("customer")]
        public string CustomerId { get; set; }

        [FormProperty("card")]
        public CreditCardOptions Card { get; set; }

        [FormProperty("bank_account")]
        public BankAccountOptions BankAccount { get; set; }
    }
}
