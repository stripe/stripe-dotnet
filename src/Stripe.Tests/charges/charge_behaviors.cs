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
            StripeCharge.Amount.ShouldEqual(StripeChargeCreateOptions.Amount.Value);

        It should_have_the_correct_created_date = () =>
            StripeCharge.Created.Day.ShouldEqual(DateTime.UtcNow.Day);

        It should_have_the_correct_currency = () =>
            StripeCharge.Currency.ShouldEqual(StripeChargeCreateOptions.Currency);

        It should_have_the_correct_description = () =>
            StripeCharge.Description.ShouldEqual(StripeChargeCreateOptions.Description);

        It should_have_the_correct_statement_descriptor = () =>
            StripeCharge.StatementDescriptor.ShouldEqual(StripeChargeCreateOptions.StatementDescriptor);

        It should_have_the_correct_live_mode = () =>
            StripeCharge.LiveMode.ShouldEqual(false);

        It should_have_been_marked_as_paid = () =>
            StripeCharge.Paid.ShouldEqual(true);

        It should_have_not_been_marked_as_refunded = () =>
            StripeCharge.Refunded.ShouldEqual(false);

        It should_have_the_correct_failure_message = () =>
            StripeCharge.FailureMessage.ShouldBeNull();

        It should_have_the_correct_source_address_line_1 = () =>
            StripeCharge.Source.AddressLine1.ShouldEqual(StripeCard.AddressLine1);

        It should_have_the_correct_source_address_line_2 = () =>
            StripeCharge.Source.AddressLine2.ShouldEqual(StripeCard.AddressLine2);

        It should_have_the_correct_source_address_city = () =>
            StripeCharge.Source.AddressCity.ShouldEqual(StripeCard.AddressCity);

        It should_have_the_correct_source_address_state = () =>
            StripeCharge.Source.AddressState.ShouldEqual(StripeCard.AddressState);

        It should_have_the_correct_source_address_zip = () =>
            StripeCharge.Source.AddressZip.ShouldEqual(StripeCard.AddressZip);

        It should_have_the_correct_source_last_4 = () =>
            StripeCharge.Source.Last4.ShouldEqual(StripeCard.Last4.ShouldEqual(StripeCard.Last4));

        It should_have_the_correct_source_expiration_month = () =>
            StripeCharge.Source.ExpirationMonth.ShouldEqual(StripeCard.ExpirationMonth);

        It should_have_the_correct_source_expiration_year = () =>
            StripeCharge.Source.ExpirationYear.ShouldEqual(StripeCard.ExpirationYear);

        It should_have_the_correct_source_name = () =>
            StripeCharge.Source.Name.ShouldEqual(StripeCard.Name);

        It should_have_the_correct_source_type = () =>
            StripeCharge.Source.Brand.ShouldEqual("Visa");

        It should_have_the_correct_source_country = () =>
            StripeCharge.Source.Country.ShouldEqual("US");
    }
}