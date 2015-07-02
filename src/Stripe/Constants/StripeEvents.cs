namespace Stripe
{
    public static class StripeEvents
    {
        public const string AccountUpdated = "account.updated";
        public const string AccountApplicationDeauthorized = "account.application.deauthorized";
        public const string ApplicationFeeCreated = "application_fee.created";
        public const string ApplicationFeeRefunded = "application_fee.refunded";
        public const string BalanceAvailable = "balance.available";
        public const string ChargeSucceeded = "charge.succeeded";
        public const string ChargeFailed = "charge.failed";
        public const string ChargeRefunded = "charge.refunded";
        public const string ChargeCaptured = "charge.captured";
        public const string ChargeUpdated = "charge.updated";
        public const string ChargeDisputeCreated = "charge.dispute.created";
        public const string ChargeDisputeUpdated = "charge.dispute.updated";
        public const string ChargeDisputeClosed = "charge.dispute.closed";
        public const string ChargeDisputeFundsWithdrawn = "charge.dispute.funds_withdrawn";
        public const string ChargeDisputeFundsReinstated = "charge.dispute.funds_reinstated";
        public const string CustomerCreated = "customer.created";
        public const string CustomerUpdated = "customer.updated";
        public const string CustomerDeleted = "customer.deleted";
        public const string CustomerSourceCreated = "customer.source.created";
        public const string CustomerSourceUpdated = "customer.source.updated";
        public const string CustomerSourcedDeleted = "customer.source.deleted";
        public const string CustomerSubscriptionCreated = "customer.subscription.created";
        public const string CustomerSubscriptionUpdated = "customer.subscription.updated";
        public const string CustomerSubscriptionDeleted = "customer.subscription.deleted";
        public const string CustomerSubscriptionTrialWillEnd = "customer.subscription.trial_will_end";
        public const string CustomerDiscountCreated = "customer.discount.created";
        public const string CustomerDiscountUpdated = "customer.discount.updated";
        public const string CustomerDiscountDeleted = "customer.discount.deleted";
        public const string InvoiceCreated = "invoice.created";
        public const string InvoiceUpdated = "invoice.updated";
        public const string InvoicePaymentSucceeded = "invoice.payment_succeeded";
        public const string InvoicePaymentFailed = "invoice.payment_failed";
        public const string InvoiceItemCreated = "invoiceitem.created";
        public const string InvoiceItemUpdated = "invoiceitem.updated";
        public const string InvoiceItemDeleted = "invoiceitem.deleted";
        public const string PlanCreated = "plan.created";
        public const string PlanUpdated = "plan.updated";
        public const string PlanDeleted = "plan.deleted";
        public const string CouponCreated = "coupon.created";
        public const string CouponDeleted = "coupon.deleted";
        public const string RecipientCreated = "recipient.created";
        public const string RecipientUpdated = "recipient.updated";
        public const string RecipientDeleted = "recipient.deleted";
        public const string TransferCreated = "transfer.created";
        public const string TransferUpdated = "transfer.updated";
        public const string TransferReversed = "transfer.reversed";
        public const string TransferPaid = "transfer.paid";
        public const string TransferFailed = "transfer.failed";
        public const string Ping = "ping";
    }
}
