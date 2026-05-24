// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class BatchJobCreateEndpointOptions : INestedOptions
    {
        /// <summary>
        /// The HTTP method to use when calling the endpoint.
        /// One of: <c>delete</c>, or <c>post</c>.
        /// </summary>
        [JsonProperty("http_method")]
        [STJS.JsonPropertyName("http_method")]
        public string HttpMethod { get; set; }

        /// <summary>
        /// The path of the endpoint to run this batch job against. In the form used in the
        /// documentation. For instance, for subscription migration this would be
        /// <c>/v1/subscriptions/:id/migrate</c>.
        /// One of: <c>/v1/accounts/:account</c>, <c>/v1/accounts</c>, <c>/v1/accounts/:account</c>,
        /// <c>/v1/coupons</c>, <c>/v1/coupons/:coupon</c>, <c>/v1/coupons/:coupon</c>,
        /// <c>/v1/credit_notes</c>, <c>/v1/customers/:customer</c>, <c>/v1/customers/:customer</c>,
        /// <c>/v1/customers</c>, <c>/v1/customers/:customer/discount</c>,
        /// <c>/v1/customers/:customer/funding_instructions</c>,
        /// <c>/v1/customers/:customer/subscriptions</c>,
        /// <c>/v1/customers/:customer/subscriptions</c>,
        /// <c>/v1/customers/:customer/subscriptions/:subscription_exposed_id</c>,
        /// <c>/v1/customers/:customer/subscriptions/:subscription_exposed_id/discount</c>,
        /// <c>/v1/customers/:customer/bank_accounts</c>,
        /// <c>/v1/customers/:customer/bank_accounts/:id</c>,
        /// <c>/v1/customers/:customer/bank_accounts/:id</c>,
        /// <c>/v1/customers/:customer/bank_accounts/:id/verify</c>,
        /// <c>/v1/customers/:customer/cards</c>, <c>/v1/customers/:customer/cards/:id</c>,
        /// <c>/v1/customers/:customer/cards/:id</c>, <c>/v1/customers/:customer/tax_ids</c>,
        /// <c>/v1/customers/:customer/sources</c>, <c>/v1/customers/:customer/sources/:id</c>,
        /// <c>/v1/customers/:customer/sources/:id</c>,
        /// <c>/v1/customers/:customer/sources/:id/verify</c>,
        /// <c>/v1/customers/:customer/balance_transactions</c>,
        /// <c>/v1/customers/:customer/balance_transactions/:transaction</c>,
        /// <c>/v1/customers/:customer/cash_balance</c>, <c>/v1/customer_sessions</c>,
        /// <c>/v1/disputes/:dispute/close</c>, <c>/v1/invoices</c>, <c>/v1/invoices/:invoice</c>,
        /// <c>/v1/invoices/:invoice</c>, <c>/v1/invoices/:invoice/pay</c>,
        /// <c>/v1/invoices/:invoice/send</c>, <c>/v1/invoices/:invoice/void</c>,
        /// <c>/v1/invoices/:invoice/finalize</c>, <c>/v1/invoices/:invoice/mark_uncollectible</c>,
        /// <c>/v1/invoices/:invoice/update_lines</c>, <c>/v1/invoices/:invoice/add_lines</c>,
        /// <c>/v1/invoices/:invoice/remove_lines</c>, <c>/v1/invoices/create_preview</c>,
        /// <c>/v1/invoices/:invoice/lines/:line_item_id</c>, <c>/v1/invoiceitems</c>,
        /// <c>/v1/invoiceitems/:invoiceitem</c>, <c>/v1/invoiceitems/:invoiceitem</c>,
        /// <c>/v1/invoice_rendering_templates/:template/archive</c>,
        /// <c>/v1/invoice_rendering_templates/:template/unarchive</c>,
        /// <c>/v1/payment_methods/:payment_method/attach</c>, <c>/v1/prices</c>,
        /// <c>/v1/prices/:price</c>, <c>/v1/products</c>, <c>/v1/products/:id</c>,
        /// <c>/v1/products/:id</c>, <c>/v1/products/:product/features</c>,
        /// <c>/v1/products/:product/features/:id</c>, <c>/v1/promotion_codes</c>,
        /// <c>/v1/promotion_codes/:promotion_code</c>, <c>/v1/radar/value_list_items</c>,
        /// <c>/v1/refunds</c>, <c>/v1/refunds/:refund/cancel</c>,
        /// <c>/v1/subscriptions/:subscription_exposed_id</c>,
        /// <c>/v1/subscriptions/:subscription_exposed_id</c>,
        /// <c>/v1/subscriptions/:subscription/migrate</c>, <c>/v1/subscriptions</c>,
        /// <c>/v1/subscriptions/:subscription/resume</c>,
        /// <c>/v1/subscriptions/:subscription/pause</c>, <c>/v1/subscription_items</c>,
        /// <c>/v1/subscription_items/:item</c>, <c>/v1/subscription_items/:item</c>,
        /// <c>/v1/subscription_schedules</c>, <c>/v1/subscription_schedules/:schedule</c>,
        /// <c>/v1/subscription_schedules/:schedule/cancel</c>,
        /// <c>/v1/subscription_schedules/:schedule/release</c>, <c>/v1/tax/registrations</c>,
        /// <c>/v1/tax/registrations/:id</c>, <c>/v1/tax/settings</c>,
        /// <c>/v1/tax/transactions/create_reversal</c>, <c>/v1/tax_ids</c>, <c>/v1/tax_ids/:id</c>,
        /// <c>/v1/customers/:customer/tax_ids</c>, <c>/v1/customers/:customer/tax_ids/:id</c>,
        /// <c>/v1/tax_rates</c>, or <c>/v1/tax_rates/:tax_rate</c>.
        /// </summary>
        [JsonProperty("path")]
        [STJS.JsonPropertyName("path")]
        public BatchJobEndpointPath Path { get; set; }
    }
}
