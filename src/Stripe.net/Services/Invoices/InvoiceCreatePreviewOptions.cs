// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceCreatePreviewOptions : BaseOptions
    {
        /// <summary>
        /// Settings for automatic tax lookup for this invoice preview.
        /// </summary>
        [JsonProperty("automatic_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("automatic_tax")]
#endif
        public InvoiceAutomaticTaxOptions AutomaticTax { get; set; }

        /// <summary>
        /// The currency to preview this invoice in. Defaults to that of <c>customer</c> if not
        /// specified.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// The identifier of the customer whose upcoming invoice you'd like to retrieve. If
        /// <c>automatic_tax</c> is enabled then one of <c>customer</c>, <c>customer_details</c>,
        /// <c>subscription</c>, or <c>schedule</c> must be set.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// Details about the customer you want to invoice or overrides for an existing customer. If
        /// <c>automatic_tax</c> is enabled then one of <c>customer</c>, <c>customer_details</c>,
        /// <c>subscription</c>, or <c>schedule</c> must be set.
        /// </summary>
        [JsonProperty("customer_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_details")]
#endif
        public InvoiceCustomerDetailsOptions CustomerDetails { get; set; }

        /// <summary>
        /// The coupons to redeem into discounts for the invoice preview. If not specified, inherits
        /// the discount from the subscription or customer. This works for both coupons directly
        /// applied to an invoice and coupons applied to a subscription. Pass an empty string to
        /// avoid inheriting any discounts.
        /// </summary>
        [JsonProperty("discounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discounts")]
#endif
        public List<InvoiceDiscountOptions> Discounts { get; set; }

        /// <summary>
        /// List of invoice items to add or update in the upcoming invoice preview (up to 250).
        /// </summary>
        [JsonProperty("invoice_items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_items")]
#endif
        public List<InvoiceUpcomingInvoiceItemOptions> InvoiceItems { get; set; }

        /// <summary>
        /// The connected account that issues the invoice. The invoice is presented with the
        /// branding and support information of the specified account.
        /// </summary>
        [JsonProperty("issuer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuer")]
#endif
        public InvoiceIssuerOptions Issuer { get; set; }

        /// <summary>
        /// The account (if any) for which the funds of the invoice payment are intended. If set,
        /// the invoice will be presented with the branding and support information of the specified
        /// account. See the <a href="https://stripe.com/docs/billing/invoices/connect">Invoices
        /// with Connect</a> documentation for details.
        /// </summary>
        [JsonProperty("on_behalf_of")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("on_behalf_of")]
#endif
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// Customizes the types of values to include when calculating the invoice. Defaults to
        /// <c>next</c> if unspecified.
        /// One of: <c>next</c>, or <c>recurring</c>.
        /// </summary>
        [JsonProperty("preview_mode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("preview_mode")]
#endif
        public string PreviewMode { get; set; }

        /// <summary>
        /// The identifier of the schedule whose upcoming invoice you'd like to retrieve. Cannot be
        /// used with subscription or subscription fields.
        /// </summary>
        [JsonProperty("schedule")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("schedule")]
#endif
        public string Schedule { get; set; }

        /// <summary>
        /// The schedule creation or modification params to apply as a preview. Cannot be used with
        /// <c>subscription</c> or <c>subscription_</c> prefixed fields.
        /// </summary>
        [JsonProperty("schedule_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("schedule_details")]
#endif
        public InvoiceScheduleDetailsOptions ScheduleDetails { get; set; }

        /// <summary>
        /// The identifier of the subscription for which you'd like to retrieve the upcoming
        /// invoice. If not provided, but a <c>subscription_details.items</c> is provided, you will
        /// preview creating a subscription with those items. If neither <c>subscription</c> nor
        /// <c>subscription_details.items</c> is provided, you will retrieve the next upcoming
        /// invoice from among the customer's subscriptions.
        /// </summary>
        [JsonProperty("subscription")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription")]
#endif
        public string Subscription { get; set; }

        /// <summary>
        /// The subscription creation or modification params to apply as a preview. Cannot be used
        /// with <c>schedule</c> or <c>schedule_details</c> fields.
        /// </summary>
        [JsonProperty("subscription_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_details")]
#endif
        public InvoiceSubscriptionDetailsOptions SubscriptionDetails { get; set; }
    }
}
