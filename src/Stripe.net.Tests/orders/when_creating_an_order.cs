using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_an_order
    {
        protected static StripeOrderCreateOptions StripeOrderCreateOptions;
        //protected static StripeProductCreateOptions StripeProductCreateOptions;

        protected static StripeOrder StripeOrder;

        private static StripeOrderService _stripeOrderService;
        private static StripeProductService _stripeProductService;

        Establish context = () =>
        {
            var stripeCustomerService = new StripeCustomerService();
            //var stripeCustomerCreateOptions = test_data.stripe_customer_create_options.ValidCard(stripePlan.Id, stripeCoupon.Id);
            var stripeCustomer = stripeCustomerService.Create(test_data.stripe_customer_create_options.ValidCard());


            var stripeProductService = new StripeProductService();
            var stripeProduct = stripeProductService.Create(test_data.stripe_product_create_options.Valid());

            var stripeSkuService = new StripeSkuService();
            var stripeSku = stripeSkuService.Create(test_data.stripe_sku_create_options.Valid(stripeProduct.Id));



            _stripeOrderService = new StripeOrderService();
            StripeOrderCreateOptions = test_data.stripe_order_create_options.Valid(stripeCustomer.Id, stripeSku.Id);
        };

        Because of = () =>
            StripeOrder = _stripeOrderService.Create(StripeOrderCreateOptions);

        Behaves_like<order_behaviors> behaviors;

        It should_have_metadata = () =>
            StripeOrder.Metadata.Count.ShouldBeGreaterThan(0);

        It should_have_correct_metadata = () =>
            StripeOrder.Metadata.ShouldContainOnly(StripeOrderCreateOptions.Metadata);
    }
}
