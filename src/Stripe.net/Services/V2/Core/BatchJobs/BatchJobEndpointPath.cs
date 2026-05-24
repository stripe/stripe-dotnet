// File generated from our OpenAPI spec
namespace Stripe
{
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(Infrastructure.STJStringEnumConverterFactory))]
    public class BatchJobEndpointPath : StringEnum
    {
        public static readonly BatchJobEndpointPath V1AccountUpdate = new BatchJobEndpointPath("/v1/accounts/:account");
        public static readonly BatchJobEndpointPath V1AccountCreate = new BatchJobEndpointPath("/v1/accounts");
        public static readonly BatchJobEndpointPath V1AccountDelete = new BatchJobEndpointPath("/v1/accounts/:account");
        public static readonly BatchJobEndpointPath V1CouponCreate = new BatchJobEndpointPath("/v1/coupons");
        public static readonly BatchJobEndpointPath V1CouponUpdate = new BatchJobEndpointPath("/v1/coupons/:coupon");
        public static readonly BatchJobEndpointPath V1CouponDelete = new BatchJobEndpointPath("/v1/coupons/:coupon");
        public static readonly BatchJobEndpointPath V1CreditNoteCreate = new BatchJobEndpointPath("/v1/credit_notes");
        public static readonly BatchJobEndpointPath V1CustomerUpdate = new BatchJobEndpointPath("/v1/customers/:customer");
        public static readonly BatchJobEndpointPath V1CustomerDelete = new BatchJobEndpointPath("/v1/customers/:customer");
        public static readonly BatchJobEndpointPath V1CustomerCreate = new BatchJobEndpointPath("/v1/customers");
        public static readonly BatchJobEndpointPath V1CustomerDeleteDiscount = new BatchJobEndpointPath("/v1/customers/:customer/discount");
        public static readonly BatchJobEndpointPath V1CustomerCreateFundingInstructions = new BatchJobEndpointPath("/v1/customers/:customer/funding_instructions");
        public static readonly BatchJobEndpointPath V1CustomerCreateSubscription = new BatchJobEndpointPath("/v1/customers/:customer/subscriptions");
        public static readonly BatchJobEndpointPath V1CustomerDeleteSubscription = new BatchJobEndpointPath("/v1/customers/:customer/subscriptions");
        public static readonly BatchJobEndpointPath V1CustomerUpdateSubscription = new BatchJobEndpointPath("/v1/customers/:customer/subscriptions/:subscription_exposed_id");
        public static readonly BatchJobEndpointPath V1CustomerDeleteSubscriptionDiscount = new BatchJobEndpointPath("/v1/customers/:customer/subscriptions/:subscription_exposed_id/discount");
        public static readonly BatchJobEndpointPath V1CustomerCreateBankAccount = new BatchJobEndpointPath("/v1/customers/:customer/bank_accounts");
        public static readonly BatchJobEndpointPath V1CustomerUpdateBankAccount = new BatchJobEndpointPath("/v1/customers/:customer/bank_accounts/:id");
        public static readonly BatchJobEndpointPath V1CustomerDeleteBankAccount = new BatchJobEndpointPath("/v1/customers/:customer/bank_accounts/:id");
        public static readonly BatchJobEndpointPath V1CustomerVerifyBankAccount = new BatchJobEndpointPath("/v1/customers/:customer/bank_accounts/:id/verify");
        public static readonly BatchJobEndpointPath V1CustomerCreateCard = new BatchJobEndpointPath("/v1/customers/:customer/cards");
        public static readonly BatchJobEndpointPath V1CustomerUpdateCard = new BatchJobEndpointPath("/v1/customers/:customer/cards/:id");
        public static readonly BatchJobEndpointPath V1CustomerDeleteCard = new BatchJobEndpointPath("/v1/customers/:customer/cards/:id");
        public static readonly BatchJobEndpointPath V1CustomerDeleteTaxIds = new BatchJobEndpointPath("/v1/customers/:customer/tax_ids");
        public static readonly BatchJobEndpointPath V1PaymentSourceCreate = new BatchJobEndpointPath("/v1/customers/:customer/sources");
        public static readonly BatchJobEndpointPath V1BankAccountUpdate = new BatchJobEndpointPath("/v1/customers/:customer/sources/:id");
        public static readonly BatchJobEndpointPath V1BankAccountDelete = new BatchJobEndpointPath("/v1/customers/:customer/sources/:id");
        public static readonly BatchJobEndpointPath V1BankAccountVerify = new BatchJobEndpointPath("/v1/customers/:customer/sources/:id/verify");
        public static readonly BatchJobEndpointPath V1CustomerBalanceTransactionCreate = new BatchJobEndpointPath("/v1/customers/:customer/balance_transactions");
        public static readonly BatchJobEndpointPath V1CustomerBalanceTransactionUpdate = new BatchJobEndpointPath("/v1/customers/:customer/balance_transactions/:transaction");
        public static readonly BatchJobEndpointPath V1CashBalanceUpdate = new BatchJobEndpointPath("/v1/customers/:customer/cash_balance");
        public static readonly BatchJobEndpointPath V1CustomerSessionCreate = new BatchJobEndpointPath("/v1/customer_sessions");
        public static readonly BatchJobEndpointPath V1DisputeClose = new BatchJobEndpointPath("/v1/disputes/:dispute/close");
        public static readonly BatchJobEndpointPath V1InvoiceCreate = new BatchJobEndpointPath("/v1/invoices");
        public static readonly BatchJobEndpointPath V1InvoiceUpdate = new BatchJobEndpointPath("/v1/invoices/:invoice");
        public static readonly BatchJobEndpointPath V1InvoiceDelete = new BatchJobEndpointPath("/v1/invoices/:invoice");
        public static readonly BatchJobEndpointPath V1InvoicePay = new BatchJobEndpointPath("/v1/invoices/:invoice/pay");
        public static readonly BatchJobEndpointPath V1InvoiceSendInvoice = new BatchJobEndpointPath("/v1/invoices/:invoice/send");
        public static readonly BatchJobEndpointPath V1InvoiceVoidInvoice = new BatchJobEndpointPath("/v1/invoices/:invoice/void");
        public static readonly BatchJobEndpointPath V1InvoiceFinalizeInvoice = new BatchJobEndpointPath("/v1/invoices/:invoice/finalize");
        public static readonly BatchJobEndpointPath V1InvoiceMarkUncollectible = new BatchJobEndpointPath("/v1/invoices/:invoice/mark_uncollectible");
        public static readonly BatchJobEndpointPath V1InvoiceUpdateLines = new BatchJobEndpointPath("/v1/invoices/:invoice/update_lines");
        public static readonly BatchJobEndpointPath V1InvoiceAddLines = new BatchJobEndpointPath("/v1/invoices/:invoice/add_lines");
        public static readonly BatchJobEndpointPath V1InvoiceRemoveLines = new BatchJobEndpointPath("/v1/invoices/:invoice/remove_lines");
        public static readonly BatchJobEndpointPath V1InvoiceCreatePreview = new BatchJobEndpointPath("/v1/invoices/create_preview");
        public static readonly BatchJobEndpointPath V1LineItemUpdate = new BatchJobEndpointPath("/v1/invoices/:invoice/lines/:line_item_id");
        public static readonly BatchJobEndpointPath V1InvoiceitemCreate = new BatchJobEndpointPath("/v1/invoiceitems");
        public static readonly BatchJobEndpointPath V1InvoiceitemUpdate = new BatchJobEndpointPath("/v1/invoiceitems/:invoiceitem");
        public static readonly BatchJobEndpointPath V1InvoiceitemDelete = new BatchJobEndpointPath("/v1/invoiceitems/:invoiceitem");
        public static readonly BatchJobEndpointPath V1InvoiceRenderingTemplateArchive = new BatchJobEndpointPath("/v1/invoice_rendering_templates/:template/archive");
        public static readonly BatchJobEndpointPath V1InvoiceRenderingTemplateUnarchive = new BatchJobEndpointPath("/v1/invoice_rendering_templates/:template/unarchive");
        public static readonly BatchJobEndpointPath V1PaymentMethodAttach = new BatchJobEndpointPath("/v1/payment_methods/:payment_method/attach");
        public static readonly BatchJobEndpointPath V1PriceCreate = new BatchJobEndpointPath("/v1/prices");
        public static readonly BatchJobEndpointPath V1PriceUpdate = new BatchJobEndpointPath("/v1/prices/:price");
        public static readonly BatchJobEndpointPath V1ProductCreate = new BatchJobEndpointPath("/v1/products");
        public static readonly BatchJobEndpointPath V1ProductUpdate = new BatchJobEndpointPath("/v1/products/:id");
        public static readonly BatchJobEndpointPath V1ProductDelete = new BatchJobEndpointPath("/v1/products/:id");
        public static readonly BatchJobEndpointPath V1ProductFeatureCreate = new BatchJobEndpointPath("/v1/products/:product/features");
        public static readonly BatchJobEndpointPath V1ProductFeatureDelete = new BatchJobEndpointPath("/v1/products/:product/features/:id");
        public static readonly BatchJobEndpointPath V1PromotionCodeCreate = new BatchJobEndpointPath("/v1/promotion_codes");
        public static readonly BatchJobEndpointPath V1PromotionCodeUpdate = new BatchJobEndpointPath("/v1/promotion_codes/:promotion_code");
        public static readonly BatchJobEndpointPath V1RadarValueListItemCreate = new BatchJobEndpointPath("/v1/radar/value_list_items");
        public static readonly BatchJobEndpointPath V1RefundCreate = new BatchJobEndpointPath("/v1/refunds");
        public static readonly BatchJobEndpointPath V1RefundCancel = new BatchJobEndpointPath("/v1/refunds/:refund/cancel");
        public static readonly BatchJobEndpointPath V1SubscriptionUpdate = new BatchJobEndpointPath("/v1/subscriptions/:subscription_exposed_id");
        public static readonly BatchJobEndpointPath V1SubscriptionCancel = new BatchJobEndpointPath("/v1/subscriptions/:subscription_exposed_id");
        public static readonly BatchJobEndpointPath V1SubscriptionMigrate = new BatchJobEndpointPath("/v1/subscriptions/:subscription/migrate");
        public static readonly BatchJobEndpointPath V1SubscriptionCreate = new BatchJobEndpointPath("/v1/subscriptions");
        public static readonly BatchJobEndpointPath V1SubscriptionResume = new BatchJobEndpointPath("/v1/subscriptions/:subscription/resume");
        public static readonly BatchJobEndpointPath V1SubscriptionPause = new BatchJobEndpointPath("/v1/subscriptions/:subscription/pause");
        public static readonly BatchJobEndpointPath V1SubscriptionItemCreate = new BatchJobEndpointPath("/v1/subscription_items");
        public static readonly BatchJobEndpointPath V1SubscriptionItemUpdate = new BatchJobEndpointPath("/v1/subscription_items/:item");
        public static readonly BatchJobEndpointPath V1SubscriptionItemDelete = new BatchJobEndpointPath("/v1/subscription_items/:item");
        public static readonly BatchJobEndpointPath V1SubscriptionScheduleCreate = new BatchJobEndpointPath("/v1/subscription_schedules");
        public static readonly BatchJobEndpointPath V1SubscriptionScheduleUpdate = new BatchJobEndpointPath("/v1/subscription_schedules/:schedule");
        public static readonly BatchJobEndpointPath V1SubscriptionScheduleCancel = new BatchJobEndpointPath("/v1/subscription_schedules/:schedule/cancel");
        public static readonly BatchJobEndpointPath V1SubscriptionScheduleRelease = new BatchJobEndpointPath("/v1/subscription_schedules/:schedule/release");
        public static readonly BatchJobEndpointPath V1TaxRegistrationCreate = new BatchJobEndpointPath("/v1/tax/registrations");
        public static readonly BatchJobEndpointPath V1TaxRegistrationUpdate = new BatchJobEndpointPath("/v1/tax/registrations/:id");
        public static readonly BatchJobEndpointPath V1TaxSettingsUpdate = new BatchJobEndpointPath("/v1/tax/settings");
        public static readonly BatchJobEndpointPath V1TaxTransactionCreateReversal = new BatchJobEndpointPath("/v1/tax/transactions/create_reversal");
        public static readonly BatchJobEndpointPath V1TaxIdCreate = new BatchJobEndpointPath("/v1/tax_ids");
        public static readonly BatchJobEndpointPath V1TaxIdUpdate = new BatchJobEndpointPath("/v1/tax_ids/:id");
        public static readonly BatchJobEndpointPath V1TaxIdCreateForCustomer = new BatchJobEndpointPath("/v1/customers/:customer/tax_ids");
        public static readonly BatchJobEndpointPath V1TaxIdDelete = new BatchJobEndpointPath("/v1/customers/:customer/tax_ids/:id");
        public static readonly BatchJobEndpointPath V1TaxRateCreate = new BatchJobEndpointPath("/v1/tax_rates");
        public static readonly BatchJobEndpointPath V1TaxRateUpdate = new BatchJobEndpointPath("/v1/tax_rates/:tax_rate");

        private BatchJobEndpointPath(string value)
            : base(value)
        {
        }
    }
}
