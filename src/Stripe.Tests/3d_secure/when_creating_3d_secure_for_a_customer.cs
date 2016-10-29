using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_3d_secure_for_a_customer
    {
        private static StripeCustomer _customer;
        private static Stripe3DSecure _3DSecure;

        Establish context = () =>
        {
            var customerOptions = test_data.stripe_customer_create_options.ValidCard();
            _customer = new StripeCustomerService().Create(customerOptions);
        };

        Because of = () =>
            _3DSecure = new Stripe3DSecureService().Create(new Stripe3DSecureCreateOptions
            {
                Amount = 1000,
                Currency = "usd",
                ReturnUrl = "http://3d-secure-needs-no-glasses.com",
                CardTokenOrCardId = _customer.DefaultSourceId,
                CustomerId = _customer.Id
            });

        It should_have_a_3d_secure_object = () =>
            _3DSecure.ShouldNotBeNull();

        It should_have_the_right_amount = () =>
            _3DSecure.Amount.ShouldEqual(1000);

        It should_have_the_right_currency = () =>
            _3DSecure.Currency.ShouldEqual("usd");
    }
}
