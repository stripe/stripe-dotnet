using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_listing_application_fee_refunds
    {
        private static StripeCharge _charge;
        private static StripeApplicationFeeRefund _refund1Sync;
        private static StripeApplicationFeeRefund _refund2Async;
        private static List<StripeApplicationFeeRefund> _refunds;

        Establish context = () =>
        {
            var customAccount = Cache.GetCustomAccountWithCard();

            // create a charge on that custom account with an application fee of 10 cents
            var chargeCreateOptions = test_data.stripe_charge_create_options.ValidToken("tok_visa");
            chargeCreateOptions.ApplicationFee = 20;

            _charge = new StripeChargeService().Create(chargeCreateOptions,
                new StripeRequestOptions
                {
                    StripeConnectAccountId = customAccount.Id
                }
            );

            _refund1Sync = new StripeApplicationFeeRefundService().Create(_charge.ApplicationFeeId, new StripeApplicationFeeRefundCreateOptions { Amount = 7 });
            _refund2Async = new StripeApplicationFeeRefundService().CreateAsync(_charge.ApplicationFeeId, new StripeApplicationFeeRefundCreateOptions { Amount = 3 }).Result;
        };

        Because of = () =>
            _refunds = new StripeApplicationFeeRefundService().List(_charge.ApplicationFeeId).ToList();

        It should_have_a_refund_object = () =>
            _refunds.ShouldNotBeNull();

        It should_have_a_seven_cent_refund = () =>
            _refunds.ShouldContain(rf => rf.Amount == 7);

        It should_have_a_three_cent_refund = () =>
            _refunds.ShouldContain(rf => rf.Amount == 3);
    }
}
