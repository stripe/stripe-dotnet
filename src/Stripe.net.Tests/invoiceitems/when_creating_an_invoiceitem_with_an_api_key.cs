using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_an_invoiceitem_with_an_api_key
    {
        protected static StripeInvoiceItemCreateOptions StripeInvoiceItemCreateOptions;
        protected static StripeInvoiceLineItem StripeInvoiceItem;
        protected static string StripeInvoiceItemId;

        private static StripeInvoiceItemService _stripeInvoiceItemService;

        Establish context = () =>
        {
            var stripeCustomerService = new StripeCustomerService();
            var stripeCustomer = stripeCustomerService.Create(test_data.stripe_customer_create_options.ValidCard());

            _stripeInvoiceItemService = new StripeInvoiceItemService();
            StripeInvoiceItemCreateOptions = test_data.stripe_invoiceitem_create_options.Valid(stripeCustomer.Id);
        };

        Because of = () =>
            StripeInvoiceItem = _stripeInvoiceItemService.Create(StripeInvoiceItemCreateOptions);

        Behaves_like<invoiceitem_behaviors> behaviors;
    }
}
