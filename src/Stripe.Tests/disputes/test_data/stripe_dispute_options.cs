namespace Stripe.Tests.test_data
{
    public static class stripe_dispute_options
    {
        public static StripeChargeCreateOptions DisputedCard()
        {
            var cardOptions = new SourceCard()
            {
                AddressCountry = "US",
                AddressLine1 = "320 Fowler Street",
                AddressLine2 = "ATTN: Barone Family",
                AddressCity = "Lynbrook",
                AddressState = "NY",
                AddressZip = "11563",
                Cvc = "1223",
                ExpirationMonth = "10",
                ExpirationYear = "2021",
                Name = "Ray Barone",
                Number = "4000000000000259",
            };

            return new StripeChargeCreateOptions()
            {
                SourceCard = cardOptions,
                Description = "Golf Clubs",
                StatementDescriptor = "ref# 1251",
                Amount = 50000,
                Currency = "usd"
            };
        }
    }
}