using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_listing_country_specs
    {
        private static List<StripeCountrySpec> _stripeCountrySpecList;
        private static StripeCountrySpecsService _stripeCountrySpecsService;

        Establish context = () =>
        {
            _stripeCountrySpecsService = new StripeCountrySpecsService();
        };

        Because of = () =>
            _stripeCountrySpecList = _stripeCountrySpecsService.List().ToList();

        It should_have_atleast_21_entries = () =>
            _stripeCountrySpecList.Count.ShouldBeGreaterThanOrEqualTo(21);
    }
}