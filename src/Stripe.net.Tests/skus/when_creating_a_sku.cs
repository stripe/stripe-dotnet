using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_sku
    {
        protected static StripeSkuCreateOptions StripeSkuCreateOptions;
        //protected static StripeProductCreateOptions StripeProductCreateOptions;

        protected static StripeSku StripeSku;

        private static StripeSkuService _stripeSkuService;
        private static StripeProductService _stripeProductService;

        Establish context = () =>
        {
            _stripeProductService = new StripeProductService();
            var _stripeProduct = _stripeProductService.Create(test_data.stripe_product_create_options.Valid());

            _stripeSkuService = new StripeSkuService();
            StripeSkuCreateOptions = test_data.stripe_sku_create_options.Valid(_stripeProduct.Id);
        };

        Because of = () =>
            StripeSku = _stripeSkuService.Create(StripeSkuCreateOptions);

        Behaves_like<sku_behaviors> behaviors;

        It should_have_metadata = () =>
            StripeSku.Metadata.Count.ShouldBeGreaterThan(0);

        It should_have_attributes = () =>
            StripeSku.Attributes.Count.ShouldBeGreaterThan(0);

        It should_have_correct_metadata = () =>
            StripeSku.Metadata.ShouldContainOnly(StripeSkuCreateOptions.Metadata);
    }
}
