using System;
using Machine.Specifications;

namespace Stripe.Tests
{
    [Behaviors]
    public class invoiceitem_behaviors
    {
        protected static StripeInvoiceItemCreateOptions StripeInvoiceItemCreateOptions;
        protected static StripeInvoiceLineItem StripeInvoiceItem;
        protected static string StripeInvoiceItemId;

        It should_have_the_correct_amount = () =>
            StripeInvoiceItem.Amount.ShouldEqual(StripeInvoiceItemCreateOptions.Amount);

        It should_have_the_correct_currency = () =>
            StripeInvoiceItem.Currency.ShouldEqual(StripeInvoiceItemCreateOptions.Currency);

        It should_have_the_correct_customer = () =>
            StripeInvoiceItem.CustomerId.ShouldEqual(StripeInvoiceItemCreateOptions.CustomerId);

        It should_have_the_correct_date = () =>
            StripeInvoiceItem.Date.ShouldBeLessThanOrEqualTo(DateTime.UtcNow.AddMinutes(1));

        It should_have_the_correct_description = () =>
            StripeInvoiceItem.Description.ShouldEqual(StripeInvoiceItemCreateOptions.Description);

        It should_have_a_valid_id = () =>
        {
            if (!string.IsNullOrEmpty(StripeInvoiceItemId))
                StripeInvoiceItem.Id.ShouldEqual(StripeInvoiceItemId);
            else
                StripeInvoiceItem.Id.ShouldNotBeNull();
        };
    }
}