using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_bank_account
    {
        private static StripeCustomer _stripeCustomer;
        private static BankAccountService _bankAccountService;
        private static BankAccountCreateOptions _bankAccountCreateOptions;
        private static CustomerBankAccount _customerBankAccount;

        Establish context = () =>
        {
            _stripeCustomer = new StripeCustomerService().Create(test_data.stripe_customer_create_options.ValidCard());

            _bankAccountService = new BankAccountService();

            _bankAccountCreateOptions = test_data.bank_account_create_options.ValidBankAccount();
        };

        Because of = () =>
            _customerBankAccount = _bankAccountService.Create(_stripeCustomer.Id, _bankAccountCreateOptions);

        It should_not_be_null = () =>
            _customerBankAccount.ShouldNotBeNull();

        It should_have_the_correct_country = () =>
            _customerBankAccount.Country.ShouldEqual(_bankAccountCreateOptions.SourceBankAccount.Country);

        It should_have_the_correct_currency = () =>
            _customerBankAccount.Currency.ShouldEqual(_bankAccountCreateOptions.SourceBankAccount.Currency);

        It should_have_the_correct_account_holder_name = () =>
            _customerBankAccount.AccountHolderName.ShouldEqual(_bankAccountCreateOptions.SourceBankAccount.AccountHolderName);

        It should_have_the_correct_account_holder_type = () =>
            _customerBankAccount.AccountHolderType.ShouldEqual(_bankAccountCreateOptions.SourceBankAccount.AccountHolderType);

        It should_have_the_correct_metadata = () =>
             _customerBankAccount.Metadata.ShouldEqual(_bankAccountCreateOptions.SourceBankAccount.Metadata);
    }
}
