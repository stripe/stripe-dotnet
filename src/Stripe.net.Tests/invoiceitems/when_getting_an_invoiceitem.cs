using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_getting_an_invoiceitem
    {
        protected static StripeInvoiceItemCreateOptions StripeInvoiceItemCreateOptions;
        protected static StripeInvoiceLineItem StripeInvoiceItem;
        protected static string StripeInvoiceItemId;

        private static StripeInvoiceItemService _stripeInvoiceItemService;
        private static StripeCustomer _stripeCustomer;

        Establish context = () =>
        {
            var stripeCustomerService = new StripeCustomerService();
            _stripeCustomer = stripeCustomerService.Create(test_data.stripe_customer_create_options.ValidCard());

            _stripeInvoiceItemService = new StripeInvoiceItemService();
            StripeInvoiceItemCreateOptions = test_data.stripe_invoiceitem_create_options.Valid(_stripeCustomer.Id);

            var createdInvoice = _stripeInvoiceItemService.Create(StripeInvoiceItemCreateOptions);
            StripeInvoiceItemId = createdInvoice.Id;
        };

        Because of = () =>
            StripeInvoiceItem = _stripeInvoiceItemService.Get(StripeInvoiceItemId);

#pragma warning disable 169, 414
        Behaves_like<invoiceitem_behaviors> behaviors;
#pragma warning restore 169, 414

    }
}