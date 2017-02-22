using Machine.Specifications;

namespace Stripe.Tests
{
    [Behaviors]
    public class account_behaviors
    {
        protected static StripeAccountSharedOptions CreateOrUpdateOptions;
        protected static StripeAccount StripeAccount;

        //It should_have_the_correct_email_address = () =>
        //    StripeAccount.Email.ShouldEqual(CreateOrUpdateOptions.Email);

        It should_have_the_correct_business_info = () =>
        {
            StripeAccount.BusinessName.ShouldEqual(CreateOrUpdateOptions.BusinessName);
            StripeAccount.BusinessPrimaryColor.ShouldEqual(CreateOrUpdateOptions.BusinessPrimaryColor);
            StripeAccount.BusinessUrl.ShouldEqual(CreateOrUpdateOptions.BusinessUrl);
        };

        It should_have_the_correct_debit_negative_balances = () =>
            StripeAccount.DebitNegativeBalances.ShouldEqual(CreateOrUpdateOptions.DebitNegativeBalances.Value);

        It should_have_the_correct_decline_charge_values = () =>
        {
            StripeAccount.DeclineChargeOn.AvsFailure.ShouldEqual(CreateOrUpdateOptions.DeclineChargeOnAvsFailure.Value);
            StripeAccount.DeclineChargeOn.CvcFailure.ShouldEqual(CreateOrUpdateOptions.DeclineChargeOnCvcFailure.Value);
        };

        It should_have_the_correct_default_currency = () =>
            StripeAccount.DefaultCurrency.ShouldEqual(CreateOrUpdateOptions.DefaultCurrency);
    }
}
