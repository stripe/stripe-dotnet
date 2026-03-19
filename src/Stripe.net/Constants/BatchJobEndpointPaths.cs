// File generated from our OpenAPI spec
namespace Stripe
{
    public static class BatchJobEndpointPaths
    {
        public const string V1AccountUpdate = "/v1/accounts/:account";

        public const string V1CreditNoteCreate = "/v1/credit_notes";

        public const string V1CustomerUpdate = "/v1/customers/:customer";

        public const string V1InvoiceUpdate = "/v1/invoices/:invoice";

        public const string V1InvoicePay = "/v1/invoices/:invoice/pay";

        public const string V1PromotionCodeCreate = "/v1/promotion_codes";

        public const string V1PromotionCodeUpdate = "/v1/promotion_codes/:promotion_code";

        public const string V1SubscriptionScheduleCreate = "/v1/subscription_schedules";

        public const string V1SubscriptionScheduleUpdate = "/v1/subscription_schedules/:schedule";

        public const string V1SubscriptionScheduleCancel = "/v1/subscription_schedules/:schedule/cancel";

        public const string V1SubscriptionUpdate = "/v1/subscriptions/:subscription_exposed_id";

        public const string V1SubscriptionMigrate = "/v1/subscriptions/:subscription/migrate";
    }
}