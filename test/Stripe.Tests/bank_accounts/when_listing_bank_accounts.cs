using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_listing_bank_accounts
    {
        private static StripeCustomer _stripeCustomer;
        private static BankAccountService _bankAccountService;
        private static BankAccountCreateOptions _bankAccountCreateOptions;
        private static List<CustomerBankAccount> _bankAccountList = new List<CustomerBankAccount>(); 

        Establish context = () =>
        {
            _stripeCustomer = new StripeCustomerService().Create(test_data.stripe_customer_create_options.ValidCard());

            _bankAccountService = new BankAccountService();

            _bankAccountCreateOptions = test_data.bank_account_create_options.ValidBankAccount();

            _bankAccountCreateOptions.SourceBankAccount.AccountHolderName = "Nemo";
            _bankAccountList.Add(_bankAccountService.Create(_stripeCustomer.Id, _bankAccountCreateOptions));
        };

        Because of = () =>
            _bankAccountList = _bankAccountService.List(_stripeCustomer.Id).ToList();

        It should_not_be_null = () =>
            _bankAccountList.ShouldNotBeNull();

        It should_have_the_correct_count = () =>
            _bankAccountList.Count.ShouldEqual(1);

        It should_have_the_correct_first_entry = () =>
            _bankAccountList[0].AccountHolderName.ShouldEqual("Nemo");
    }
}
