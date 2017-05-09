using System;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_requesting_something_from_stripe
    {
        private static StripeCharge _stripeChargeSync;
        private static StripeCharge _stripeChargeAsync;
        private static StripeList<StripeCharge> _stripeChargesSyncList;
        private static StripeList<StripeCharge> _stripeChargesAsyncList;

        Establish context = () =>
        {
            // no context. if needed, we can expand the stripe response to be on each object in a list
        };

        Because of = () =>
        {
            _stripeChargeSync = new StripeChargeService().Create(test_data.stripe_charge_create_options.ValidCard());
            _stripeChargeAsync = new StripeChargeService().CreateAsync(test_data.stripe_charge_create_options.ValidCard()).Result;

            _stripeChargesSyncList = new StripeChargeService().List(test_data.stripe_charge_list_options.ChargesSinceYesterday());
            _stripeChargesAsyncList = new StripeChargeService().ListAsync(test_data.stripe_charge_list_options.ChargesSinceYesterday()).Result;
        };

        It should_have_the_right_request_id = () =>
        {
            _stripeChargeSync.StripeResponse.RequestId.ShouldStartWith("req_");
            _stripeChargeAsync.StripeResponse.RequestId.ShouldStartWith("req_");

            _stripeChargesSyncList.StripeResponse.RequestId.ShouldStartWith("req_");
            _stripeChargesAsyncList.StripeResponse.RequestId.ShouldStartWith("req_");
        };

        It should_have_a_recent_request_datetime = () =>
        {
            _stripeChargeSync.StripeResponse.RequestDate.ShouldBeGreaterThanOrEqualTo(DateTime.Now.AddMinutes(-1).Date);
            _stripeChargeAsync.StripeResponse.RequestDate.ShouldBeGreaterThanOrEqualTo(DateTime.Now.AddMinutes(-1).Date);

            _stripeChargesSyncList.StripeResponse.RequestDate.ShouldBeGreaterThanOrEqualTo(DateTime.Now.AddMinutes(-1).Date);
            _stripeChargesAsyncList.StripeResponse.RequestDate.ShouldBeGreaterThanOrEqualTo(DateTime.Now.AddMinutes(-1).Date);
        };
    }
}
