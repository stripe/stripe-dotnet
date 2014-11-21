using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_updating_a_customer
    {
        private static StripeCustomerUpdateOptions StripeCustomerUpdateOptions;
        private static StripeCustomer _stripeCustomer;
        private static StripeCustomerService _stripeCustomerService;
        private static string _createdStripeCustomerId;

        Establish context = () =>
        {
            _stripeCustomerService = new StripeCustomerService();

            var stripeCustomer = _stripeCustomerService.Create(test_data.stripe_customer_create_options.ValidCard());
            _createdStripeCustomerId = stripeCustomer.Id;
            
            StripeCustomerUpdateOptions = test_data.stripe_customer_update_options.Valid();
        };

        Because of = () =>
            _stripeCustomer = _stripeCustomerService.Update(_createdStripeCustomerId, StripeCustomerUpdateOptions);

        It should_have_the_correct_description = () =>
            _stripeCustomer.Description.ShouldEqual(StripeCustomerUpdateOptions.Description);

        It should_have_the_correct_account_balance = () =>
            _stripeCustomer.AccountBalance.ShouldEqual(1000);

        It should_have_metadata = () =>
            _stripeCustomer.Metadata.Count.ShouldBeGreaterThan(0);

        It should_have_the_correct_metadata = () =>
            _stripeCustomer.Metadata.ShouldContainOnly(StripeCustomerUpdateOptions.Metadata);
    }
}