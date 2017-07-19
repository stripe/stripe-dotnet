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

        It should_have_the_correct_source_type = () =>
            StripeCharge.Source.Card.Brand.ShouldEqual("Visa");

        It should_have_the_correct_source_country = () =>
            StripeCharge.Source.Card.Country.ShouldEqual("US");
    }
}