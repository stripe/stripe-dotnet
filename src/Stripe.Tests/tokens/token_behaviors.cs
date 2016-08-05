using System;
using Machine.Specifications;

namespace Stripe.Tests
{
    [Behaviors]
    public class token_behaviors
    {
        protected static StripeTokenCreateOptions StripeTokenCreateOptions;
        protected static StripeToken StripeToken;

        It should_have_an_id = () =>
            StripeToken.Id.ShouldNotBeNull();

        It should_have_a_card_token = () =>
            StripeToken.Id.ShouldStartWith("tok_");

        It should_have_the_correct_created_date = () =>
            StripeToken.Created.Value.Day.ShouldEqual(DateTime.UtcNow.Day);

        It should_have_the_correct_live_mode = () =>
            StripeToken.LiveMode.ShouldEqual(false);

        It should_have_not_been_marked_as_used = () =>
            StripeToken.Used.ShouldEqual(false);

        It should_have_the_correct_card_address_line_1 = () =>
            StripeToken.StripeCard.AddressLine1.ShouldEqual(StripeTokenCreateOptions.Card.AddressLine1);

        It should_have_the_correct_card_address_line_2 = () =>
            StripeToken.StripeCard.AddressLine2.ShouldEqual(StripeTokenCreateOptions.Card.AddressLine2);

        It should_have_the_correct_card_address_state = () =>
            StripeToken.StripeCard.AddressState.ShouldEqual(StripeTokenCreateOptions.Card.AddressState);

        It should_have_the_correct_card_address_zip = () =>
            StripeToken.StripeCard.AddressZip.ShouldEqual(StripeTokenCreateOptions.Card.AddressZip);

        It should_have_the_correct_card_last_4 = () =>
            StripeToken.StripeCard.Last4.ShouldEqual(StripeTokenCreateOptions.Card.Number.Substring(StripeTokenCreateOptions.Card.Number.Length - 4));

        It should_have_the_correct_card_expiration_month = () =>
            StripeToken.StripeCard.ExpirationMonth.ShouldEqual(StripeTokenCreateOptions.Card.ExpirationMonth);

        It should_have_the_correct_card_expiration_year = () =>
            StripeToken.StripeCard.ExpirationYear.ShouldEqual(StripeTokenCreateOptions.Card.ExpirationYear);

        It should_have_the_correct_card_name = () =>
            StripeToken.StripeCard.Name.ShouldEqual(StripeTokenCreateOptions.Card.Name);

        It should_have_the_correct_card_type = () =>
            StripeToken.StripeCard.Brand.ShouldEqual("Visa");

        It should_have_the_correct_card_country = () =>
            StripeToken.StripeCard.Country.ShouldEqual("US");
    }
}