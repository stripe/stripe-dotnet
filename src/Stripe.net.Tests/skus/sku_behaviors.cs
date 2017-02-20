using Machine.Specifications;

namespace Stripe.Tests
{
    [Behaviors]
    public class sku_behaviors
    {
        protected static StripeSkuCreateOptions StripeSkuCreateOptions;
        protected static StripeSku StripeSku;

        It should_have_the_correct_id = () =>
            StripeSku.Id.ShouldEqual(StripeSkuCreateOptions.Id);

        private It should_have_the_correct_active = () =>
            StripeSku.Active.ShouldEqual(StripeSkuCreateOptions.Active.Value);
        
        It should_have_the_correct_currency = () =>
            StripeSku.Currency.ShouldEqual(StripeSkuCreateOptions.Currency);

        It should_have_the_correct_image = () =>
            StripeSku.Image.ShouldEqual(StripeSkuCreateOptions.Image);

        It should_have_the_correct_inventory =
            () => StripeSku.Inventory.ShouldBeLike(StripeSkuCreateOptions.Inventory);

        It should_have_the_correct_package_dimensions =
            () => StripeSku.PackageDimensions.ShouldBeLike(StripeSkuCreateOptions.PackageDimensions);

        It should_have_the_correct_price = () =>
            StripeSku.Price.ShouldEqual(StripeSkuCreateOptions.Price);

        It should_have_the_correct_product_id = () =>
            StripeSku.ProductId.ShouldEqual(StripeSkuCreateOptions.ProductId);

        It should_have_a_created_date = () =>
            StripeSku.Created.ShouldNotBeNull();
        It should_have_the_correct_live_mode = () =>
            StripeSku.LiveMode.ShouldEqual(false);

        It should_have_the_correct_attributes = () =>
            StripeSku.Attributes.ShouldBeLike(StripeSkuCreateOptions.Attributes);
    }
}
