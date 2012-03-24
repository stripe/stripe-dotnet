using System;
using Machine.Specifications;

namespace Stripe.Tests
{
	[Behaviors]
	public class charge_behaviors
	{
		protected static StripeChargeCreateOptions StripeChargeCreateOptions;
		protected static StripeCharge StripeCharge;
		protected static StripeCard StripeCard;

		It should_have_an_id = () =>
			StripeCharge.Id.ShouldNotBeNull();

		It should_have_the_correct_amount = () =>
			StripeCharge.AmountInCents.ShouldEqual(StripeChargeCreateOptions.AmountInCents.Value);

		It should_have_the_correct_created_date = () =>
			StripeCharge.Created.Day.ShouldEqual(DateTime.UtcNow.Day);

		It should_have_the_correct_currency = () =>
			StripeCharge.Currency.ShouldEqual(StripeChargeCreateOptions.Currency);

		It should_have_the_correct_description = () =>
			StripeCharge.Description.ShouldEqual(StripeChargeCreateOptions.Description);

		It should_have_a_fee = () =>
			StripeCharge.FeeInCents.ShouldBeGreaterThanOrEqualTo(0);

		It should_have_the_correct_live_mode = () =>
			StripeCharge.LiveMode.ShouldEqual(false);

		It should_have_been_marked_as_paid = () =>
			StripeCharge.Paid.ShouldEqual(true);

		It should_have_not_been_marked_as_refunded = () =>
			StripeCharge.Refunded.ShouldEqual(false);

		It should_have_the_correct_card_address_line_1 = () =>
			StripeCharge.StripeCard.AddressLine1.ShouldEqual(StripeCard.AddressLine1);

		It should_have_the_correct_card_address_line_2 = () =>
			StripeCharge.StripeCard.AddressLine2.ShouldEqual(StripeCard.AddressLine2);

		It should_have_the_correct_card_address_state = () =>
			StripeCharge.StripeCard.AddressState.ShouldEqual(StripeCard.AddressState);

		It should_have_the_correct_card_address_zip = () =>
			StripeCharge.StripeCard.AddressZip.ShouldEqual(StripeCard.AddressZip);

		It should_have_the_correct_card_last_4 = () =>
			StripeCharge.StripeCard.Last4.ShouldEqual(StripeCard.Last4.ShouldEqual(StripeCard.Last4));

		It should_have_the_correct_card_expiration_month = () =>
			StripeCharge.StripeCard.ExpirationMonth.ShouldEqual(StripeCard.ExpirationMonth);

		It should_have_the_correct_card_expiration_year = () =>
			StripeCharge.StripeCard.ExpirationYear.ShouldEqual(StripeCard.ExpirationYear);

		It should_have_the_correct_card_name = () =>
			StripeCharge.StripeCard.Name.ShouldEqual(StripeCard.Name);

		It should_have_the_correct_card_type = () =>
			StripeCharge.StripeCard.Type.ShouldEqual("Visa");

		It should_have_the_correct_card_country = () =>
			StripeCharge.StripeCard.Country.ShouldEqual("US");
	}
}