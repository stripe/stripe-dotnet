using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.xUnit
{
    public class when_using_a_stripe_date_filter : test
    {
        private List<StripeInvoice> Invoices{ get; }

        public when_using_a_stripe_date_filter()
        {
            Invoices = new StripeInvoiceService(_stripe_api_key).List(
                new StripeInvoiceListOptions
                {
                    Date = new StripeDateFilter { EqualTo = DateTime.UtcNow.AddYears(-10) }
                }
            ).ToList();
        }

        public StripeAccount Account { get; set; }

        [Fact]
        public void it_should_have_no_invoices()
        {
            Invoices.Count.ShouldBeEquivalentTo(0);
        }
    }
}
