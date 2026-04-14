// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceCreatePreviewOptions : BaseOptions
    {
        private List<InvoiceDiscountOptions> discounts;
        private string onBehalfOf;

        /// <summary>
        /// Settings for automatic tax lookup for this invoice preview.
        /// </summary>
        [JsonProperty("automatic_tax")]
        [STJS.JsonPropertyName("automatic_tax")]
        public InvoiceAutomaticTaxOptions AutomaticTax { get; set; }

        /// <summary>
        /// The currency to preview this invoice in. Defaults to that of <c>customer</c> if not
        /// specified.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The identifier of the customer whose upcoming invoice you're retrieving. If
        /// <c>automatic_tax</c> is enabled then one of <c>customer</c>, <c>customer_details</c>,
        /// <c>subscription</c>, or <c>schedule</c> must be set.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The identifier of the account representing the customer whose upcoming invoice you're
        /// retrieving. If <c>automatic_tax</c> is enabled then one of <c>customer</c>,
        /// <c>customer_account</c>, <c>customer_details</c>, <c>subscription</c>, or
        /// <c>schedule</c> must be set.
        /// </summary>
        [JsonProperty("customer_account")]
        [STJS.JsonPropertyName("customer_account")]
        public string CustomerAccount { get; set; }

        /// <summary>
        /// Details about the customer you want to invoice or overrides for an existing customer. If
        /// <c>automatic_tax</c> is enabled then one of <c>customer</c>, <c>customer_details</c>,
        /// <c>subscription</c>, or <c>schedule</c> must be set.
        /// </summary>
        [JsonProperty("customer_details")]
        [STJS.JsonPropertyName("customer_details")]
        public InvoiceCustomerDetailsOptions CustomerDetails { get; set; }

        /// <summary>
        /// The coupons to redeem into discounts for the invoice preview. If not specified, inherits
        /// the discount from the subscription or customer. This works for both coupons directly
        /// applied to an invoice and coupons applied to a subscription. Pass an empty string to
        /// avoid inheriting any discounts.
        /// </summary>
        [JsonProperty("discounts", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("discounts")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<InvoiceDiscountOptions> Discounts
        {
            get => this.discounts;
            set
            {
                this.discounts = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// List of invoice items to add or update in the upcoming invoice preview (up to 250).
        /// </summary>
        [JsonProperty("invoice_items")]
        [STJS.JsonPropertyName("invoice_items")]
        public List<InvoiceUpcomingInvoiceItemOptions> InvoiceItems { get; set; }

        /// <summary>
        /// The connected account that issues the invoice. The invoice is presented with the
        /// branding and support information of the specified account.
        /// </summary>
        [JsonProperty("issuer")]
        [STJS.JsonPropertyName("issuer")]
        public InvoiceIssuerOptions Issuer { get; set; }

        /// <summary>
        /// The account (if any) for which the funds of the invoice payment are intended. If set,
        /// the invoice will be presented with the branding and support information of the specified
        /// account. See the <a href="https://docs.stripe.com/billing/invoices/connect">Invoices
        /// with Connect</a> documentation for details.
        /// </summary>
        [JsonProperty("on_behalf_of", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("on_behalf_of")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string OnBehalfOf
        {
            get => this.onBehalfOf;
            set
            {
                this.onBehalfOf = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Customizes the types of values to include when calculating the invoice. Defaults to
        /// <c>next</c> if unspecified.
        /// One of: <c>next</c>, or <c>recurring</c>.
        /// </summary>
        [JsonProperty("preview_mode")]
        [STJS.JsonPropertyName("preview_mode")]
        public string PreviewMode { get; set; }

        /// <summary>
        /// The identifier of the schedule whose upcoming invoice you'd like to retrieve. Cannot be
        /// used with subscription or subscription fields.
        /// </summary>
        [JsonProperty("schedule")]
        [STJS.JsonPropertyName("schedule")]
        public string Schedule { get; set; }

        /// <summary>
        /// The schedule creation or modification params to apply as a preview. Cannot be used with
        /// <c>subscription</c> or <c>subscription_</c> prefixed fields.
        /// </summary>
        [JsonProperty("schedule_details")]
        [STJS.JsonPropertyName("schedule_details")]
        public InvoiceScheduleDetailsOptions ScheduleDetails { get; set; }

        /// <summary>
        /// The identifier of the subscription for which you'd like to retrieve the upcoming
        /// invoice. If not provided, but a <c>subscription_details.items</c> is provided, you will
        /// preview creating a subscription with those items. If neither <c>subscription</c> nor
        /// <c>subscription_details.items</c> is provided, you will retrieve the next upcoming
        /// invoice from among the customer's subscriptions.
        /// </summary>
        [JsonProperty("subscription")]
        [STJS.JsonPropertyName("subscription")]
        public string Subscription { get; set; }

        /// <summary>
        /// The subscription creation or modification params to apply as a preview. Cannot be used
        /// with <c>schedule</c> or <c>schedule_details</c> fields.
        /// </summary>
        [JsonProperty("subscription_details")]
        [STJS.JsonPropertyName("subscription_details")]
        public InvoiceSubscriptionDetailsOptions SubscriptionDetails { get; set; }
    }
}
