namespace Stripe.Tests.test_data
{
    public static class stripe_dispute_options
    {
        public static StripeChargeCreateOptions DisputedCard()
        {
            return new StripeChargeCreateOptions()
            {
                SourceTokenOrExistingSourceId = "tok_createDispute",
                Description = "Golf Clubs",
                StatementDescriptor = "ref# 1251",
                Amount = 50000,
                Currency = "usd"
            };
        }
    }
}