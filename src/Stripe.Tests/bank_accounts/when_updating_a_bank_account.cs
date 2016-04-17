using System.Collections.Generic;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_updating_a_bank_account
    {
        private static StripeCustomer _stripeCustomer;
        private static BankAccountService _bankAccountService;
        private static BankAccountUpdateOptions _bankAccountUpdateOptions;
        private static CustomerBankAccount _customerBankAccount;
        private static CustomerBankAccount _updatedBankAccount;

        Establish context = () =>
        {
            _stripeCustomer = new StripeCustomerService().Create(test_data.stripe_customer_create_options.ValidCard());

            _bankAccountService = new BankAccountService();

            _customerBankAccount = _bankAccountService.Create(_stripeCustomer.Id, test_data.bank_account_create_options.ValidBankAccount());

            _bankAccountUpdateOptions = new BankAccountUpdateOptions()
            {
                AccountHolderName = "Robert",
                AccountHolderType = BankAccountHolderType.Individual,
                Metadata = new Dictionary<string, string>()
                {
                    { "Name", "Frank Barone" },
                    { "OftenSays", "Holy Crap" }
                }
            };
        };

        Because of = () =>
            _updatedBankAccount = _bankAccountService.Update(_stripeCustomer.Id, _customerBankAccount.Id, _bankAccountUpdateOptions);

        It should_not_be_null = () =>
            _updatedBankAccount.ShouldNotBeNull();

        It should_have_the_correct_account_holder_name = () =>
            _updatedBankAccount.AccountHolderName.ShouldEqual(_bankAccountUpdateOptions.AccountHolderName);

        It should_have_the_correct_account_holder_type = () =>
            _updatedBankAccount.AccountHolderType.ShouldEqual(_bankAccountUpdateOptions.AccountHolderType);

        It should_have_the_correct_metadata = () =>
            _updatedBankAccount.Metadata.ShouldEqual(_bankAccountUpdateOptions.Metadata);
    }
}
