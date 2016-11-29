using System;
using Machine.Specifications;

namespace Stripe.Tests
{
    [Behaviors]
    public class recipient_behaviors
    {
        protected static StripeRecipientCreateOptions StripeRecipientCreateOptions;
        protected static StripeRecipient StripeRecipient;

        It should_have_a_new_id = () =>
            StripeRecipient.Id.ShouldNotBeNull();

        It should_have_an_object_value_of_transfer = () =>
            StripeRecipient.Object.ShouldEqual("recipient");

        It should_have_the_correct_live_mode = () =>
            StripeRecipient.LiveMode.ShouldEqual(false);

        It should_have_the_correct_created_date = () =>
            StripeRecipient.Created.Day.ShouldEqual(DateTime.UtcNow.Day);

        It should_have_the_correct_type = () =>
            StripeRecipient.Type.ShouldEqual(StripeRecipientCreateOptions.Type);

        It should_have_the_correct_description = () =>
            StripeRecipient.Description.ShouldEqual(StripeRecipientCreateOptions.Description);

        It should_have_the_correct_email = () =>
            StripeRecipient.Email.ShouldEqual(StripeRecipientCreateOptions.Email);

        It should_have_the_correct_name = () =>
            StripeRecipient.Name.ShouldEqual(StripeRecipientCreateOptions.Name);
    }
}
