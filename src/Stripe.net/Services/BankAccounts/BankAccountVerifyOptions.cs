namespace Stripe
{
    using Stripe.Infrastructure;

    public class BankAccountVerifyOptions : BaseOptions
    {
        [FormProperty("amounts[]")]
        public int? AmountOne { get; set; }

        [FormProperty("amounts[]")]
        public int? AmountTwo { get; set; }
    }
}
