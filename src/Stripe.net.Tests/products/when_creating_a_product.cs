using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_product
    {
        protected static StripeProductCreateOptions StripeProductCreateOptions;
        protected static StripeProduct StripeProduct;

        private static StripeProductService _stripeProductService;

        Establish context = () =>
        {
            _stripeProductService = new StripeProductService();
            StripeProductCreateOptions = test_data.stripe_product_create_options.Valid();
        };

        Because of = () =>
            StripeProduct = _stripeProductService.Create(StripeProductCreateOptions);

        Behaves_like<product_behaviors> behaviors;

        It should_have_metadata = () =>
            StripeProduct.Metadata.Count.ShouldBeGreaterThan(0);

        It should_have_attributes = () =>
            StripeProduct.Attributes.Length.ShouldBeGreaterThan(0);

        It should_have_correct_metadata = () =>
            StripeProduct.Metadata.ShouldContainOnly(StripeProductCreateOptions.Metadata);
    }
}
