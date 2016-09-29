// ***** This test needs a bank account setup in order to run correctly, and the ignore attribute wasn't working. Good times.

//using System.Collections.Generic;
//using System.Linq;
//using Machine.Specifications;

//namespace Stripe.Tests
//{
//    public class when_listing_transfers
//    {
//        private static List<StripeTransfer> _stripeTransferList;
//        private static StripeTransferService _stripeTransferService;

//        Establish context = () =>
//        {
//            _stripeTransferService = new StripeTransferService();

//            _stripeTransferService.Create(test_data.stripe_transfer_create_options.Valid());
//            _stripeTransferService.Create(test_data.stripe_transfer_create_options.Valid());
//            _stripeTransferService.Create(test_data.stripe_transfer_create_options.Valid());
//        };

//        Because of = () =>
//            _stripeTransferList = _stripeTransferService.List().ToList();

//        It should_have_at_least_three_entries = () =>
//            _stripeTransferList.Count.ShouldBeGreaterThanOrEqualTo(3);
//    }
//}
