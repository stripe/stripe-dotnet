using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_listing_topups_with_paging
    {
        private static StripeTopupService _stripeTopupService;

        private static StripeList<StripeTopup> _stripeTopupListFirstPage;
        private static StripeList<StripeTopup> _stripeTopupListSecondPage;
        private static StripeList<StripeTopup> _stripeTopupListFirstPageFromSecond;

        private static List<string> _topupIds;

        Establish context = () =>
        {
            _stripeTopupService = new StripeTopupService();
            var topupCreateOptions = test_data.stripe_topup_create_options.ValidToken("tok_visa");

            _stripeTopupService = new StripeTopupService();

            _topupIds = new List<string>();
            _topupIds.Add(_stripeTopupService.Create(topupCreateOptions).Id);
            _topupIds.Add(_stripeTopupService.Create(topupCreateOptions).Id);
            _topupIds.Add(_stripeTopupService.Create(topupCreateOptions).Id);
            _topupIds.Add(_stripeTopupService.Create(topupCreateOptions).Id);
            _topupIds.Reverse();
        };

        Because of = () =>
        {
            _stripeTopupListFirstPage = _stripeTopupService.List(new StripeTopupListOptions
            {
                Limit = 2
            });

            _stripeTopupListSecondPage = _stripeTopupService.List(new StripeTopupListOptions
            {
                Limit = 2,
                StartingAfter = _stripeTopupListFirstPage.Data.Last().Id
            });

            _stripeTopupListFirstPageFromSecond = _stripeTopupService.List(new StripeTopupListOptions
            {
                Limit = 2,
                EndingBefore = _stripeTopupListSecondPage.Data.First().Id
            });
        };

        It should_only_have_2_entries_on_first_page = () =>
            _stripeTopupListFirstPage.Data.Count.ShouldEqual(2);

        It should_only_have_2_entries_on_second_page = () =>
            _stripeTopupListSecondPage.Data.Count.ShouldEqual(2);

        It should_only_have_2_entries_on_first_page_from_second = () =>
            _stripeTopupListFirstPageFromSecond.Data.Count.ShouldEqual(2);

        It should_start_second_page_from_third_topup = () =>
            _stripeTopupListSecondPage.Data.First().Id.ShouldEqual(_topupIds[2]);

        It should_start_first_page_from_second_from_first_topup = () =>
            _stripeTopupListFirstPageFromSecond.Data.First().Id.ShouldEqual(_topupIds[0]);
    }
}
