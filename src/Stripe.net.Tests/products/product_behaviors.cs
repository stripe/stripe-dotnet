using Machine.Specifications;

namespace Stripe.Tests
{
    [Behaviors]
    public class product_behaviors
    {
        protected static StripeProductCreateOptions StripeProductCreateOptions;
        protected static StripeProduct StripeProduct;

        It should_have_the_correct_id = () =>
            StripeProduct.Id.ShouldEqual(StripeProductCreateOptions.Id);

//        private It should_have_the_correct_active =
//            () =>
//            (StripeProductCreateOptions.Active.HasValue
//                ? StripeProduct.Active.ShouldEqual(StripeProductCreateOptions.Active.Value)
//                : true);

        private It should_have_the_correct_active =() => 
            StripeProduct.Active.ShouldEqual(StripeProductCreateOptions.Active.Value);

        It should_have_the_correct_caption = () =>
            StripeProduct.Caption.ShouldEqual(StripeProductCreateOptions.Caption);

        It should_have_the_correct_description = () =>
            StripeProduct.Description.ShouldEqual(StripeProductCreateOptions.Description);

        It should_have_the_correct_name = () =>
            StripeProduct.Name.ShouldEqual(StripeProductCreateOptions.Name);

        It should_have_the_correct_shippable = () =>
            StripeProduct.Shippable.ShouldEqual(StripeProductCreateOptions.Shippable.Value);

        It should_have_the_correct_url = () =>
            StripeProduct.Url.ShouldEqual(StripeProductCreateOptions.Url);

        It should_have_a_created_date = () =>
            StripeProduct.Created.ShouldNotBeNull();

        It should_have_the_correct_live_mode = () =>
            StripeProduct.LiveMode.ShouldEqual(false);
        //Attributes
        //Images
        //PackageDimensions
        //StripeSkus
        //Metadata
    }
}
