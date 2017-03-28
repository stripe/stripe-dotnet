using Machine.Specifications;

namespace Stripe.Tests
{
    [Behaviors]
    public class order_behaviors
    {
        protected static StripeOrderCreateOptions StripeOrderCreateOptions;
        protected static StripeOrder StripeOrder;

        It should_have_the_correct_customer_id = () =>
            StripeOrder.CustomerId.ShouldEqual(StripeOrderCreateOptions.CustomerId);
        
        It should_have_the_correct_currency = () =>
            StripeOrder.Currency.ShouldEqual(StripeOrderCreateOptions.Currency);        

        It should_have_the_correct_email = () =>
            StripeOrder.Email.ShouldEqual(StripeOrderCreateOptions.Email);

        It should_have_the_correct_Shipping = () =>
            StripeOrder.Shipping.ShouldBeLike(StripeOrderCreateOptions.Shipping);

        It should_have_a_lines_object = () =>
            StripeOrder.StripeOrderItems.ShouldNotBeNull();

        It should_have_the_correct_live_mode = () =>
            StripeOrder.LiveMode.ShouldEqual(false);
    }
}
