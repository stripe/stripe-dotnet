using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_listing_country_specs
    {
        private static List<CountrySpec> _countrySpecList;
        private static CountrySpecService _countrySpecService;

        Establish context = () =>
        {
            _countrySpecService = new CountrySpecService();
        };

        Because of = () =>
        {
            _countrySpecList = _countrySpecService.List(
                new StripeListOptions() { Limit = 8 }
            ).ToList();
        };

        It should_have_8_entries = () =>
            _countrySpecList.Count.ShouldEqual(8);
    }
}