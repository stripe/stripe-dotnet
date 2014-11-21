using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_listing_recipients
    {
        private static List<StripeRecipient> _stripeRecipientList;
        private static StripeRecipientService _stripeRecipientService;

        Establish context = () =>
        {
            _stripeRecipientService = new StripeRecipientService();

            _stripeRecipientService.Create(test_data.stripe_recipient_create_options.ValidCorporation());
            _stripeRecipientService.Create(test_data.stripe_recipient_create_options.ValidIndividual());
        };

        Because of = () =>
            _stripeRecipientList = _stripeRecipientService.List().ToList();

        It should_havea_atleast_2_entries = () =>
            _stripeRecipientList.Count.ShouldBeGreaterThanOrEqualTo(2);
    }
}