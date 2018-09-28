namespace Stripe
{
    using Stripe.Infrastructure;

    public class BankAccountCreateOptions : BaseOptions
    {
        [FormProperty("source")]
        public string SourceToken { get; set; }

        [FormProperty("source")]
        public SourceBankAccount SourceBankAccount { get; set; }
    }
}
