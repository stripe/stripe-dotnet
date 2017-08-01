using System;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_custom_account_with_a_card
    {
        protected static StripeAccountCreateOptions CreateOrUpdateOptions;
        protected static StripeAccount StripeAccount;

        private static StripeAccountService _stripeAccountService;

        Establish context = () =>
        {
            _stripeAccountService = new StripeAccountService();
        };

        Because of = () =>
        {
            StripeAccount = Cache.GetCustomAccountWithCard();
            CreateOrUpdateOptions = Cache.CustomAccountWithCardOptions;
        };

        It should_have_the_correct_country = () =>
            StripeAccount.Country.ShouldEqual(CreateOrUpdateOptions.Country);

        It should_have_the_correct_email = () =>
            StripeAccount.Email.ShouldEqual(CreateOrUpdateOptions.Email);

        It should_be_a_custom_account = () =>
            StripeAccount.Type.ShouldEqual("custom");

        It should_have_the_correct_external_account_info = () =>
        {
            StripeAccount.ExternalAccounts.TotalCount.ShouldEqual(1);

            var firstEntry = (StripeCard)StripeAccount.ExternalAccounts.Data.First().Card;

            firstEntry.Brand.ShouldEqual("Visa");
            firstEntry.Funding.ShouldEqual("debit");
            firstEntry.DefaultForCurrency.ShouldBeTrue();
        };

        It should_have_the_correct_card = () =>
        {
            var firstEntry = (StripeCard)StripeAccount.ExternalAccounts.Data.First().Card;

            StripeAccount.ExternalAccounts.Data.First().Card.Name.ShouldEqual(firstEntry.Name);
        };

#pragma warning disable 169, 414
        Behaves_like<account_behaviors> behaviors;
#pragma warning restore 169, 414

    }
}
