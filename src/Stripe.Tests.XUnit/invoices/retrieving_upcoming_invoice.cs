using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class retrieving_upcoming_invoice
    {
        public StripeInvoice InvoiceUpcoming { get; }

        public retrieving_upcoming_invoice()
        {
            var customerService = new StripeCustomerService(Cache.ApiKey);
            var invoiceItemService = new StripeInvoiceItemService(Cache.ApiKey);
            var invoiceService = new StripeInvoiceService(Cache.ApiKey);

            var CustomerCreateOptions = new StripeCustomerCreateOptions
            {
                SourceToken = "tok_visa",
            };
            var Customer = customerService.Create(CustomerCreateOptions);

            var InvoiceItemCreateOptions = new StripeInvoiceItemCreateOptions
            {
                Amount = 1000,
                Currency = "usd",
                CustomerId = Customer.Id
            };
            var InvoiceItem = invoiceItemService.Create(InvoiceItemCreateOptions);

            var UpcomingInvoiceOptions = new StripeUpcomingInvoiceOptions
            {
                InvoiceItems = new List<StripeInvoiceUpcomingInvoiceItemOption> {
                    new StripeInvoiceUpcomingInvoiceItemOption {
                        Amount = 1001,
                        Currency = "usd",
                    },
                    new StripeInvoiceUpcomingInvoiceItemOption {
                        Amount = 1002,
                        InvoiceItemId = InvoiceItem.Id,
                    },
                },
            };
            InvoiceUpcoming = invoiceService.Upcoming(Customer.Id, UpcomingInvoiceOptions);
        }

        [Fact]
        public void invoice_upcoming_has_correct_information()
        {
            InvoiceUpcoming.Should().NotBeNull();
            InvoiceUpcoming.StripeInvoiceLineItems.Should().NotBeNull();
            InvoiceUpcoming.StripeInvoiceLineItems.Data.Count.Should().Be(2);
        }
    }
}
