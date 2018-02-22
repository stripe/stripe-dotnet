using System;
using Machine.Specifications;

namespace Stripe.Tests
{
    [Behaviors]
    public class topup_behaviors
    {
        protected static StripeTopupCreateOptions StripeTopupCreateOptions;
        protected static StripeTopup StripeTopup;
        protected static StripeCard StripeCard;

        It should_have_an_id = () =>
            StripeTopup.Id.ShouldNotBeNull();

        It should_have_the_correct_amount = () =>
            StripeTopup.Amount.ShouldEqual(StripeTopupCreateOptions.Amount.Value);

        It should_have_the_correct_created_date = () =>
            StripeTopup.Created.Day.ShouldEqual(DateTime.UtcNow.Day);

        It should_have_the_correct_currency = () =>
            StripeTopup.Currency.ShouldEqual(StripeTopupCreateOptions.Currency);

        It should_have_the_correct_description = () =>
            StripeTopup.Description.ShouldEqual(StripeTopupCreateOptions.Description);

        It should_have_the_correct_statement_descriptor = () =>
            StripeTopup.StatementDescriptor.ShouldEqual(StripeTopupCreateOptions.StatementDescriptor);

        It should_have_the_correct_live_mode = () =>
            StripeTopup.LiveMode.ShouldEqual(false);

        It should_have_the_correct_failure_message = () =>
            StripeTopup.FailureMessage.ShouldBeNull();

        It should_have_the_correct_source_type = () =>
            StripeTopup.Source.Card.Brand.ShouldEqual("Visa");

        It should_have_the_correct_source_country = () =>
            StripeTopup.Source.Card.Country.ShouldEqual("US");
    }
}
