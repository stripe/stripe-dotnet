using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_charge_with_a_bank_account
    {
        private static StripeCustomer _stripeCustomer;
        private static StripeCharge _stripeCharge;

        private static StripeChargeService _stripeChargeService;

        Establish context = () =>
        {
            // create a new customer
            _stripeCustomer = new StripeCustomerService().Create(new StripeCustomerCreateOptions()
            {
                Email = "hello@moto.com"
            });

            // create the bank account, and then verify that bank account
            var createdBankAccount = new BankAccountService().Create(_stripeCustomer.Id, new BankAccountCreateOptions()
            {
                SourceBankAccount = new SourceBankAccount()
                {
                    AccountNumber = "000123456789",
                    Country = "US",
                    Currency = "usd",
                    AccountHolderName = "Bobby Barone",
                    AccountHolderType = BankAccountHolderType.Company,
                    RoutingNumber = "110000000"
                }
            });

            // these are the test amounts you plugin for testing with Stripe. in a real life scenario, you would 
            // have your customer verify this from the deposits
            var verifiedBankAccount = new BankAccountService().Verify(_stripeCustomer.Id, createdBankAccount.Id, new BankAccountVerifyOptions()
            {
                AmountOne = 32,
                AmountTwo = 45
            });
        };

        Because of = () =>
        {
            // charge the customer something
            _stripeCharge = new StripeChargeService().Create(new StripeChargeCreateOptions()
            {
                Amount = 100,
                Currency = "usd",
                CustomerId = _stripeCustomer.Id
            });
        };

        It should_have_the_right_source = () =>
            _stripeCharge.Source.BankAccount.ShouldNotBeNull();

        It should_not_have_the_wrong_source = () =>
            _stripeCharge.Source.Card.ShouldBeNull();

        It should_have_the_right_source_type = () =>
            _stripeCharge.Source.Type.ShouldEqual(SourceType.BankAccount);

        It should_start_with_the_right_id = () =>
            _stripeCharge.Source.Id.ShouldStartWith("ba_");
    }
}