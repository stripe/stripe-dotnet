using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_listing_country_specs
    {
        private static List<CountrySpec> _stripeCountrySpecList;
        private static StripeCountrySpecService _stripeCountrySpecService;

        Establish context = () =>
        {
            _stripeCountrySpecService = new StripeCountrySpecService();
        };

        Because of = () =>
            _stripeCountrySpecList = _stripeCountrySpecService.List().ToList();

        It should_have_atleast_21_entries = () =>
            _stripeCountrySpecList.Count.ShouldBeGreaterThanOrEqualTo(21);
    }
}