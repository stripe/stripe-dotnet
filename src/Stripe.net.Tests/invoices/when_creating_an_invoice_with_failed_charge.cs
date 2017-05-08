using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_an_invoice_with_failed_charge
    {
        private static StripeInvoice _stripeCreatedInvoice;
        private static StripeInvoiceService _stripeInvoiceService;
        private static StripeException _stripeException;

        Establish context = () =>
        {
            var stripeCustomerService = new StripeCustomerService();
            var stripeCustomerCreateOptions = test_data.stripe_customer_create_options.ValidCardButChargeFails();
            var stripeCustomer = stripeCustomerService.Create(stripeCustomerCreateOptions);

            var stripeInvoiceItemService = new StripeInvoiceItemService();
            var stripeInvoiceItemCreateOptions = test_data.stripe_invoiceitem_create_options.Valid(stripeCustomer.Id);
            stripeInvoiceItemService.Create(stripeInvoiceItemCreateOptions);

            _stripeInvoiceService = new StripeInvoiceService();
            _stripeCreatedInvoice = _stripeInvoiceService.Create(stripeCustomer.Id);
        };

        Because of = () =>
        {
            try
            {
                _stripeInvoiceService.Pay(_stripeCreatedInvoice.Id);
            }
            catch (StripeException exception)
            {
                _stripeException = exception;
            }
        };

        It should_have_a_declined_failure_message = () =>
            _stripeException.Message.ShouldBeEqualIgnoringCase("Your card was declined.");

        It should_have_a_declined_failure_code = () =>
            _stripeException.StripeError.Code.ShouldBeEqualIgnoringCase("card_declined");
    }
}
