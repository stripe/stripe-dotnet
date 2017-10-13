using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_and_updating_invoices_with_manual_invoicing
    {
        public StripeInvoice InvoiceCreated { get; }
        public StripeInvoice InvoiceUpdated { get; }

        public creating_and_updating_invoices_with_manual_invoicing()
        {
            var customerService = new StripeCustomerService(Cache.ApiKey);
            var invoiceItemService = new StripeInvoiceItemService(Cache.ApiKey);
            var invoiceService = new StripeInvoiceService(Cache.ApiKey);

            var CustomerCreateOptions = new StripeCustomerCreateOptions
            {
                Email = "manual-invoicing@example.com",
            };
            var Customer = customerService.Create(CustomerCreateOptions);

            var InvoiceItemCreateOptions = new StripeInvoiceItemCreateOptions
            {
                Amount = 1000,
                Currency = "usd",
                CustomerId = Customer.Id
            };
            var InvoiceItem = invoiceItemService.Create(InvoiceItemCreateOptions);

            var InvoiceCreateOptions = new StripeInvoiceCreateOptions
            {
                Billing = StripeBilling.SendInvoice,
                DaysUntilDue = 7,
            };
            InvoiceCreated = invoiceService.Create(Customer.Id, InvoiceCreateOptions);

            var InvoiceUpdateOptions = new StripeInvoiceUpdateOptions
            {
                Paid = true,
            };
            InvoiceUpdated = invoiceService.Update(InvoiceCreated.Id, InvoiceUpdateOptions);
        }

        [Fact]
        public void invoice_created_should_not_be_null()
        {
            InvoiceCreated.Should().NotBeNull();
        }

        [Fact]
        public void invoice_created_has_correct_billing()
        {
            InvoiceCreated.Billing.Should().Be(StripeBilling.SendInvoice);
        }

        [Fact]
        public void invoice_created_due_date_should_not_be_null()
        {
            InvoiceCreated.DueDate.Should().NotBeNull();
        }

        [Fact]
        public void invoice_created_number_should_not_be_null()
        {
            InvoiceCreated.Number.Should().NotBeNull();
        }

        [Fact]
        public void invoice_updated_should_not_be_null()
        {
            InvoiceUpdated.Should().NotBeNull();
        }

        [Fact]
        public void invoice_updated_has_correct_paid()
        {
            InvoiceUpdated.Paid.Should().Be(true);
        }
    }
}
