namespace Stripe
{
    public class StripeCustomerUpdateOptions : CreditCardOptions
    {
        [StripeArgument("coupon")]
        public string Coupon { get; set; }

        [StripeArgument("email")]
        public string Email { get; set; }

        [StripeArgument("description")]
        public string Description { get; set; }
    }
}
