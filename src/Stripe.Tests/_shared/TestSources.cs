namespace Stripe.Tests
{
    public static class TestSources
    {
        public static BankAccountOptions ValidBankAccountOptions()
        {
            return new BankAccountOptions()
            {
                AccountNumber = "000123456789",
                Country = "US",
                Currency = "usd",
                AccountHolderName = "Bobby Barone",
                AccountHolderType = BankAccountHolderType.Company,
                RoutingNumber = "110000000"
            };
        }
    }
}
