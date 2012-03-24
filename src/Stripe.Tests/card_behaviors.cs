using Machine.Specifications;

namespace Stripe.Tests
{
	[Behaviors]
	public class card_behaviors
	{
		protected static StripeCustomerCreateOptions StripeCustomerCreateOptions;
		protected static StripeCustomer StripeCustomer;
		protected static StripePlan StripePlan;
		protected static StripeCoupon StripeCoupon;
		protected static StripeCard StripeCard;
		
		It should_have_a_new_id = () =>
			StripeCustomer.Id.ShouldNotBeNull();

		It should_have_the_correct_email = () =>
			StripeCustomer.Email.ShouldEqual(StripeCustomerCreateOptions.Email);

		It should_have_the_correct_description = () =>
			StripeCustomer.Description.ShouldEqual(StripeCustomerCreateOptions.Description);

		It should_have_the_correct_livemode = () =>
			StripeCustomer.LiveMode.ShouldEqual(false);

		It should_have_the_correct_card_address_line_1 = () =>
			StripeCustomer.StripeCard.AddressLine1.ShouldEqual(StripeCard.AddressLine1);

		It should_have_the_correct_card_address_line_2 = () =>
			StripeCustomer.StripeCard.AddressLine2.ShouldEqual(StripeCard.AddressLine2);

		It should_have_the_correct_card_address_state = () =>
			StripeCustomer.StripeCard.AddressState.ShouldEqual(StripeCard.AddressState);

		It should_have_the_correct_card_address_zip = () =>
			StripeCustomer.StripeCard.AddressZip.ShouldEqual(StripeCard.AddressZip);

		It should_have_the_correct_card_last_4 = () =>
			StripeCustomer.StripeCard.Last4.ShouldEqual(StripeCard.Last4.ShouldEqual(StripeCard.Last4));

		It should_have_the_correct_card_expiration_month = () =>
			StripeCustomer.StripeCard.ExpirationMonth.ShouldEqual(StripeCard.ExpirationMonth);

		It should_have_the_correct_card_expiration_year = () =>
			StripeCustomer.StripeCard.ExpirationYear.ShouldEqual(StripeCard.ExpirationYear);

		It should_have_the_correct_card_name = () =>
			StripeCustomer.StripeCard.Name.ShouldEqual(StripeCard.Name);

		It should_have_the_correct_card_type = () =>
			StripeCustomer.StripeCard.Type.ShouldEqual("Visa");

		It should_have_the_correct_card_country = () =>
			StripeCustomer.StripeCard.Country.ShouldEqual("US");

		It should_have_the_correct_trial_period_days = () =>
			StripeCustomer.StripeSubscription.TrialEnd.Value.Date.ShouldEqual(StripeCustomerCreateOptions.TrialEnd.Value.Date);

		It should_have_the_correct_plan_id = () =>
			StripeCustomer.StripeSubscription.StripePlan.Id.ShouldEqual(StripePlan.Id);

		It should_have_the_correct_plan_amount = () =>
			StripeCustomer.StripeSubscription.StripePlan.AmountInCents.ShouldEqual(StripePlan.AmountInCents);

		It should_have_the_correct_plan_currency = () =>
			StripeCustomer.StripeSubscription.StripePlan.Currency.ShouldEqual(StripePlan.Currency);

		It should_have_the_correct_plan_interval = () =>
			StripeCustomer.StripeSubscription.StripePlan.Interval.ShouldEqual(StripePlan.Interval);

		It should_have_the_correct_plan_name = () =>
			StripeCustomer.StripeSubscription.StripePlan.Name.ShouldEqual(StripePlan.Name);

		It should_have_the_correct_plan_trial_period_days = () =>
			StripeCustomer.StripeSubscription.StripePlan.TrialPeriodDays.ShouldEqual(StripePlan.TrialPeriodDays);

		It should_have_the_correct_plan_livemode = () =>
			StripeCustomer.StripeSubscription.StripePlan.LiveMode.ShouldEqual(false);

		It should_have_the_correct_coupon_id = () =>
			StripeCustomer.StripeDiscount.StripeCoupon.Id.ShouldEqual(StripeCoupon.Id);

		It should_have_the_correct_coupon_percent_off = () =>
			StripeCustomer.StripeDiscount.StripeCoupon.PercentOff.ShouldEqual(StripeCoupon.PercentOff);

		It should_have_the_correct_coupon_duration = () =>
			StripeCustomer.StripeDiscount.StripeCoupon.Duration.ShouldEqual(StripeCoupon.Duration);

		It should_have_the_correct_coupon_duration_in_months = () =>
			StripeCustomer.StripeDiscount.StripeCoupon.DurationInMonths.ShouldEqual(StripeCoupon.DurationInMonths);

		It should_have_the_correct_coupon_max_redemptions = () =>
			StripeCustomer.StripeDiscount.StripeCoupon.MaxRedemptions.ShouldEqual(StripeCoupon.MaxRedemptions);

		It should_have_the_correct_coupon_livemode = () =>
			StripeCustomer.StripeDiscount.StripeCoupon.LiveMode.ShouldEqual(false);
	}
}