using Machine.Specifications;
using System.Linq;

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

		It should_have_an_id = () =>
			StripeCustomer.StripeCardList.StripeCards.First().Id.ShouldNotBeNull();

		It should_have_the_correct_card_address_line_1 = () =>
			StripeCustomer.StripeCardList.StripeCards.First().AddressLine1.ShouldEqual(StripeCard.AddressLine1);

		It should_have_the_correct_card_address_line_2 = () =>
			StripeCustomer.StripeCardList.StripeCards.First().AddressLine2.ShouldEqual(StripeCard.AddressLine2);

		It should_have_the_correct_card_address_state = () =>
			StripeCustomer.StripeCardList.StripeCards.First().AddressState.ShouldEqual(StripeCard.AddressState);

		It should_have_the_correct_card_address_zip = () =>
			StripeCustomer.StripeCardList.StripeCards.First().AddressZip.ShouldEqual(StripeCard.AddressZip);

		It should_have_the_correct_card_last_4 = () =>
			StripeCustomer.StripeCardList.StripeCards.First().Last4.ShouldEqual(StripeCard.Last4.ShouldEqual(StripeCard.Last4));

		It should_have_the_correct_card_expiration_month = () =>
			StripeCustomer.StripeCardList.StripeCards.First().ExpirationMonth.ShouldEqual(StripeCard.ExpirationMonth);

		It should_have_the_correct_card_expiration_year = () =>
			StripeCustomer.StripeCardList.StripeCards.First().ExpirationYear.ShouldEqual(StripeCard.ExpirationYear);

		It should_have_the_correct_card_name = () =>
			StripeCustomer.StripeCardList.StripeCards.First().Name.ShouldEqual(StripeCard.Name);

		It should_have_the_correct_card_type = () =>
			StripeCustomer.StripeCardList.StripeCards.First().Type.ShouldEqual("Visa");

		It should_have_a_fingerprint = () =>
			StripeCustomer.StripeCardList.StripeCards.First().Fingerprint.ShouldNotBeNull();

		It should_have_the_correct_card_country = () =>
			StripeCustomer.StripeCardList.StripeCards.First().Country.ShouldEqual("US");

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