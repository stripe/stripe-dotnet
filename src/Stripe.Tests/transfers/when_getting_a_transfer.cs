// ***** This test needs a bank account setup in order to run correctly, and the ignore attribute wasn't working. Good times.

//using Machine.Specifications;

//namespace Stripe.Tests
//{
//    public class when_getting_a_transfer
//    {
//        protected static StripeTransferCreateOptions StripeTransferCreateOptions;
//        protected static StripeTransfer StripeTransfer;

//        private static StripeTransferService _stripeTransferService;
//        private static string _createStripeTransferId;

//        Establish context = () =>
//        {
//            _stripeTransferService = new StripeTransferService();
//            StripeTransferCreateOptions = test_data.stripe_transfer_create_options.Valid();

//            var stripeTransfer = _stripeTransferService.Create(StripeTransferCreateOptions);
//            _createStripeTransferId = stripeTransfer.Id;
//        };

//        Because of = () =>
//        {
//            StripeTransfer = _stripeTransferService.Get(_createStripeTransferId);
//        };

//        Behaves_like<transfer_behaviors> behaviors;
//    }
//}