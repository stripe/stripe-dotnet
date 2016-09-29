using System;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_getting_a_transfer_with_application_fee
    {
        private static StripeTransferService _stripeTransferService;
        private static StripeTransfer _stripeTransferCreated;
        private static StripeTransfer _stripeTransferRetrieved;

        Establish context = () =>
        {
            // create a managed account
            var accountService = new StripeAccountService();
            var managedAccount = accountService.Create(new StripeAccountCreateOptions
            {
                Managed = true,
                Email = $"TheNightOf{Guid.NewGuid()}@gmail.com"
            });

            // TODO: this isn't necessary, but it serves as a good example for using connect. Move this to a new test for documentation
            //// create a customer on that account
            //var customerService = new StripeCustomerService();
            //var customer = customerService.Create(
            //    new StripeCustomerCreateOptions
            //    {
            //        Email = $"thenightof-{Guid.NewGuid()}@gmail.com"
            //    }, 
            //    new StripeRequestOptions()
            //    {
            //        StripeConnectAccountId = managedAccount.Id
            //    }
            //);

            //// create a bank account for that customer
            //var bankAccountService = new BankAccountService();
            //var bankAccount = bankAccountService.Create(customer.Id, 
            //    test_data.bank_account_create_options.ValidBankAccount(), 
            //    new StripeRequestOptions()
            //    {
            //        StripeConnectAccountId = managedAccount.Id
            //    }
            //);

            // transfer from this account to the customers bank on the managed account
            _stripeTransferService = new StripeTransferService();
            _stripeTransferCreated = _stripeTransferService.Create(
                new StripeTransferCreateOptions
                {
                    Amount = 500,
                    ApplicationFee = 20,
                    Currency = "usd",
                    Destination = managedAccount.Id
                }
            );
        };

        Because of = () =>
        {
            _stripeTransferService.ExpandApplicationFee = true;
            _stripeTransferRetrieved = _stripeTransferService.Get(_stripeTransferCreated.Id);
        };

        It should_have_the_transfer_id = () =>
            _stripeTransferRetrieved.Id.ShouldNotBeNull();

        It should_have_the_application_fee_entity = () =>
            _stripeTransferRetrieved.ApplicationFee.ShouldNotBeNull();

        It should_have_the_application_fee_entity_id = () =>
            _stripeTransferRetrieved.ApplicationFee.Amount.ShouldEqual(20);

        It should_have_the_application_fee_id = () =>
            _stripeTransferRetrieved.ApplicationFeeId.ShouldStartWith("fee_");
    }
}