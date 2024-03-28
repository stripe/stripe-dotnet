// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class InvoiceCreatePreviewOptions : BaseOptions
    {
        /// <summary>
        /// Settings for automatic tax lookup for this invoice preview.
        /// </summary>
        [JsonProperty("automatic_tax")]
        public InvoiceAutomaticTaxOptions AutomaticTax { get; set; }

        /// <summary>
        /// The identifier of the coupon to apply to this phase of the subscription schedule. This
        /// field has been deprecated and will be removed in a future API version. Use
        /// <c>discounts</c> instead.
        /// </summary>
        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        /// <summary>
        /// The currency to preview this invoice in. Defaults to that of <c>customer</c> if not
        /// specified.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The identifier of the customer whose upcoming invoice you'd like to retrieve. If
        /// <c>automatic_tax</c> is enabled then one of <c>customer</c>, <c>customer_details</c>,
        /// <c>subscription</c>, or <c>schedule</c> must be set.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Details about the customer you want to invoice or overrides for an existing customer. If
        /// <c>automatic_tax</c> is enabled then one of <c>customer</c>, <c>customer_details</c>,
        /// <c>subscription</c>, or <c>schedule</c> must be set.
        /// </summary>
        [JsonProperty("customer_details")]
        public InvoiceCustomerDetailsOptions CustomerDetails { get; set; }

        /// <summary>
        /// The coupons to redeem into discounts for the invoice preview. If not specified, inherits
        /// the discount from the customer or subscription. This works for both coupons directly
        /// applied to an invoice and coupons applied to a subscription. Pass an empty string to
        /// avoid inheriting any discounts.
        /// </summary>
        [JsonProperty("discounts")]
        public List<InvoiceDiscountOptions> Discounts { get; set; }

        /// <summary>
        /// List of invoice items to add or update in the upcoming invoice preview.
        /// </summary>
        [JsonProperty("invoice_items")]
        public List<InvoiceUpcomingInvoiceItemOptions> InvoiceItems { get; set; }

        /// <summary>
        /// The connected account that issues the invoice. The invoice is presented with the
        /// branding and support information of the specified account.
        /// </summary>
        [JsonProperty("issuer")]
        public InvoiceIssuerOptions Issuer { get; set; }

        /// <summary>
        /// The account (if any) for which the funds of the invoice payment are intended. If set,
        /// the invoice will be presented with the branding and support information of the specified
        /// account. See the <a href="https://stripe.com/docs/billing/invoices/connect">Invoices
        /// with Connect</a> documentation for details.
        /// </summary>
        [JsonProperty("on_behalf_of")]
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// Customizes the types of values to include when calculating the invoice. Defaults to
        /// <c>next</c> if unspecified.
        /// One of: <c>next</c>, or <c>recurring</c>.
        /// </summary>
        [JsonProperty("preview_mode")]
        public string PreviewMode { get; set; }

        /// <summary>
        /// The identifier of the schedule whose upcoming invoice you'd like to retrieve. Cannot be
        /// used with subscription or subscription fields.
        /// </summary>
        [JsonProperty("schedule")]
        public string Schedule { get; set; }

        /// <summary>
        /// The schedule creation or modification params to apply as a preview. Cannot be used with
        /// <c>subscription</c> or <c>subscription_</c> prefixed fields.
        /// </summary>
        [JsonProperty("schedule_details")]
        public InvoiceScheduleDetailsOptions ScheduleDetails { get; set; }

        /// <summary>
        /// The identifier of the subscription for which you'd like to retrieve the upcoming
        /// invoice. If not provided, but a <c>subscription_items</c> is provided, you will preview
        /// creating a subscription with those items. If neither <c>subscription</c> nor
        /// <c>subscription_items</c> is provided, you will retrieve the next upcoming invoice from
        /// among the customer's subscriptions.
        /// </summary>
        [JsonProperty("subscription")]
        public string Subscription { get; set; }

        /// <summary>
        /// The subscription creation or modification params to apply as a preview. Cannot be used
        /// with <c>schedule</c> or <c>schedule_details</c> fields.
        /// </summary>
        [JsonProperty("subscription_details")]
        public InvoiceSubscriptionDetailsOptions SubscriptionDetails { get; set; }
    }
}
