// ***** This test needs a bank account setup in order to run correctly, and the ignore attribute wasn't working. Good times.

//using Machine.Specifications;

//namespace Stripe.Tests
//{
//    public class when_creating_a_transfer_with_application_fee
//    {
//        protected static StripeTransferCreateOptions StripeTransferCreateOptions;
//        protected static StripeTransfer StripeTransfer;

//        private static StripeTransferService _stripeTransferService;

//        Establish context = () =>
//        {
//            _stripeTransferService = new StripeTransferService();
//            StripeTransferCreateOptions = test_data.stripe_transfer_create_options.Valid();
//            StripeTransferCreateOptions.ApplicationFee = 10;
//        };

//        Because of = () =>
//            StripeTransfer = _stripeTransferService.Create(StripeTransferCreateOptions);

//        It should_have_application_fee = () =>
//            StripeTransfer.ApplicationFee.ShouldEqual(10);
//    }
//}