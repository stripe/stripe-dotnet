using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_getting_upcoming_invoice_line_items
    {
        private static StripePlan _stripePlan;
        private static StripeCustomer _stripeCustomer;
        private static StripeInvoiceService _stripeInvoiceService;
        private static StripeInvoiceItemService _stripeInvoiceItemService;
        private static StripeList<StripeInvoiceLineItem> _stripeInvoiceLineItems;
        private static StripeInvoiceLineItem _stripeInvoiceItem;

        Establish context = () =>
        {
            var stripePlanService = new StripePlanService();
            var stripePlanCreateOptions = test_data.stripe_plan_create_options.Valid();
            _stripePlan = stripePlanService.Create(stripePlanCreateOptions);

            var stripeCustomerService = new StripeCustomerService();
            var stripeCustomerCreateOptions = test_data.stripe_customer_create_options.ValidCard(_stripePlan.Id);
            _stripeCustomer = stripeCustomerService.Create(stripeCustomerCreateOptions);

            _stripeInvoiceService = new StripeInvoiceService();
            _stripeInvoiceItemService = new StripeInvoiceItemService();

            _stripeInvoiceItem = _stripeInvoiceItemService.Create(test_data.stripe_invoiceitem_create_options.Valid(_stripeCustomer.Id));
        };

        Because of = () =>
            _stripeInvoiceLineItems = _stripeInvoiceService.UpcomingLines(_stripeCustomer.Id);

        It should_have_only_this_pending_invoice_line_item = () =>
            (_stripeInvoiceLineItems.Data.Single().Id).ShouldEqual(_stripeInvoiceItem.Id);

        

    }
}