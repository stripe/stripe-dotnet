using Machine.Specifications;

namespace Stripe.Tests
{
    [Behaviors]
    public class coupon_behaviors
    {
        protected static StripeCouponCreateOptions StripeCouponCreateOptions;
        protected static StripeCoupon StripeCoupon;

        It should_have_the_correct_id = () =>
            StripeCoupon.Id.ShouldEqual(StripeCouponCreateOptions.Id);
        
        It should_have_the_correct_percent_off = () =>
            StripeCoupon.PercentOff.ShouldEqual(StripeCouponCreateOptions.PercentOff.Value);

        It should_have_the_correct_duration = () =>
            StripeCoupon.Duration.ShouldEqual(StripeCouponCreateOptions.Duration);

        It should_have_the_correct_duration_in_months = () =>
            StripeCoupon.DurationInMonths.ShouldEqual(StripeCouponCreateOptions.DurationInMonths);

        It should_have_the_correct_max_redemptions = () =>
            StripeCoupon.MaxRedemptions.ShouldEqual(StripeCouponCreateOptions.MaxRedemptions);

        It should_have_the_correct_redeem_by_days = () =>
            StripeCoupon.RedeemBy.Value.Date.ShouldEqual(StripeCouponCreateOptions.RedeemBy.Value.Date);

        It should_have_the_correct_times_redeemed = () =>
            StripeCoupon.TimesRedeemed.ShouldEqual(0);

        It should_have_the_correct_live_mode = () =>
            StripeCoupon.LiveMode.ShouldEqual(false);
    }
}