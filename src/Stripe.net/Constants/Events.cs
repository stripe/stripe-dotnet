namespace Stripe
{
    using System;

    public static class Events
    {
        public const string AccountUpdated = "account.updated";

        public const string AccountApplicationAuthorized = "account.application.authorized";

        public const string AccountApplicationDeauthorized = "account.application.deauthorized";

        public const string AccountExternalAccountCreated = "account.external_account.created";

        public const string AccountExternalAccountDeleted = "account.external_account.deleted";

        public const string AccountExternalAccountUpdated = "account.external_account.updated";

        public const string ApplicationFeeCreated = "application_fee.created";

        public const string ApplicationFeeRefunded = "application_fee.refunded";

        public const string ApplicationFeeRefundUpdated = "application_fee.refund.updated";

        public const string BalanceAvailable = "balance.available";

        [Obsolete]
        public const string BitcoinReceiverCreated = "bitcoin.receiver.created";

        [Obsolete]
        public const string BitcoinReceiverFilled = "bitcoin.receiver.filled";

        [Obsolete]
        public const string BitcoinReceiverUpdated = "bitcoin.receiver.updated";

        [Obsolete]
        public const string BitcoinReceiverTransactionUpdated = "bitcoin.receiver.transaction.created";

        public const string ChargeCaptured = "charge.captured";

        public const string ChargeExpired = "charge.expired";

        public const string ChargeFailed = "charge.failed";

        public const string ChargePending = "charge.pending";

        public const string ChargeRefunded = "charge.refunded";

        public const string ChargeSucceeded = "charge.succeeded";

        public const string ChargeUpdated = "charge.updated";

        public const string ChargeDisputeClosed = "charge.dispute.closed";

        public const string ChargeDisputeCreated = "charge.dispute.created";

        public const string ChargeDisputeFundsReinstated = "charge.dispute.funds_reinstated";

        public const string ChargeDisputeFundsWithdrawn = "charge.dispute.funds_withdrawn";

        public const string ChargeDisputeUpdated = "charge.dispute.updated";

        public const string ChargeRefundUpdated = "charge.refund.updated";

        public const string CheckoutSessionCompleted = "checkout.session.completed";

        public const string CouponCreated = "coupon.created";

        public const string CouponDeleted = "coupon.deleted";

        public const string CouponUpdated = "coupon.updated";

        public const string CreditNoteCreated = "credit_note.created";

        public const string CreditNoteUpdated = "credit_note.updated";

        public const string CreditNoteVoided = "credit_note.voided";

        public const string CustomerCreated = "customer.created";

        public const string CustomerDeleted = "customer.deleted";

        public const string CustomerUpdated = "customer.updated";

        public const string CustomerDiscountCreated = "customer.discount.created";

        public const string CustomerDiscountDeleted = "customer.discount.deleted";

        public const string CustomerDiscountUpdated = "customer.discount.updated";

        public const string CustomerSourceCreated = "customer.source.created";

        public const string CustomerSourceDeleted = "customer.source.deleted";

        public const string CustomerSourceExpiring = "customer.source.expiring";

        public const string CustomerSourceUpdated = "customer.source.updated";

        public const string CustomerSubscriptionCreated = "customer.subscription.created";

        public const string CustomerSubscriptionDeleted = "customer.subscription.deleted";

        public const string CustomerSubscriptionPendingUpdateApplied = "customer.subscription.pending_update_applied";

        public const string CustomerSubscriptionPendingUpdateExpired = "customer.subscription.pending_update_expired";

        public const string CustomerSubscriptionTrialWillEnd = "customer.subscription.trial_will_end";

        public const string CustomerSubscriptionUpdated = "customer.subscription.updated";

        public const string FileCreated = "file.created";

        public const string InvoiceCreated = "invoice.created";

        public const string InvoiceDeleted = "invoice.deleted";

        public const string InvoiceFinalized = "invoice.finalized";

        public const string InvoiceMarkedUncollectible = "invoice.marked_uncollectible";

        public const string InvoicePaymentActionRequired = "invoice.payment_action_required";

        public const string InvoicePaymentFailed = "invoice.payment_failed";

        public const string InvoicePaymentSucceeded = "invoice.payment_succeeded";

        public const string InvoiceSent = "invoice.sent";

        public const string InvoiceUpcoming = "invoice.upcoming";

        public const string InvoiceUpdated = "invoice.updated";

        public const string InvoiceVoided = "invoice.voided";

        public const string InvoiceItemCreated = "invoiceitem.created";

        public const string InvoiceItemDeleted = "invoiceitem.deleted";

        public const string InvoiceItemUpdated = "invoiceitem.updated";

        public const string IssuingAuthorizationCreated = "issuing_authorization.created";

        public const string IssuingAuthorizationRequest = "issuing_authorization.request";

        public const string IssuingAuthorizationUpdated = "issuing_authorization.updated";

        public const string IssuingCardCreated = "issuing_card.created";

        public const string IssuingCardUpdated = "issuing_card.updated";

        public const string IssuingCardholderCreated = "issuing_cardholder.created";

        public const string IssuingCardholderUpdated = "issuing_cardholder.updated";

        public const string IssuingDisputeCreated = "issuing_dispute.created";

        public const string IssuingDisputeUpdated = "issuing_dispute.updated";

        public const string IssuingTransactionCreated = "issuing_transaction.created";

        public const string IssuingTransactionUpdated = "issuing_transaction.updated";

        public const string MandateUpdated = "mandate.updated";

        public const string OrderCreated = "order.created";

        public const string OrderPaymentFailed = "order.payment_failed";

        public const string OrderPaymentSucceeded = "order.payment_succeeded";

        public const string OrderUpdated = "order.updated";

        public const string OrderReturnCreated = "order_return.created";

        public const string PaymentCreated = "payment.created";

        public const string PaymentIntentAmountCapturableUpdated = "payment_intent.amount_capturable_updated";

        public const string PaymentIntentCanceled = "payment_intent.canceled";

        public const string PaymentIntentCreated = "payment_intent.created";

        public const string PaymentIntentPaymentFailed = "payment_intent.payment_failed";

        public const string PaymentIntentProcessing = "payment_intent.processing";

        public const string PaymentIntentSucceeded = "payment_intent.succeeded";

        public const string PaymentMethodAttached = "payment_method.attached";

        public const string PaymentMethodCardAutomaticallyUpdated = "payment_method.card_automatically_updated";

        public const string PaymentMethodDetached = "payment_method.detached";

        public const string PaymentMethodUpdated = "payment_method.updated";

        public const string PayoutCanceled = "payout.canceled";

        public const string PayoutCreated = "payout.created";

        public const string PayoutFailed = "payout.failed";

        public const string PayoutPaid = "payout.paid";

        public const string PayoutUpdated = "payout.updated";

        public const string PersonCreated = "person.created";

        public const string PersonDeleted = "person.deleted";

        public const string PersonUpdated = "person.updated";

        public const string PlanCreated = "plan.created";

        public const string PlanDeleted = "plan.deleted";

        public const string PlanUpdated = "plan.updated";

        public const string ProductCreated = "product.created";

        public const string ProductDeleted = "product.deleted";

        public const string ProductUpdated = "product.updated";

        public const string RadarEarlyFraudWarningCreated = "radar.early_fraud_warning.created";

        public const string RadarEarlyFraudWarningUpdated = "radar.early_fraud_warning.updated";

        public const string RecipientCreated = "recipient.created";

        public const string RecipientDeleted = "recipient.deleted";

        public const string RecipientUpdated = "recipient.updated";

        public const string ReportingReportRunFailed = "reporting.report_run.failed";

        public const string ReportingReportRunSucceeded = "reporting.report_run.succeeded";

        public const string ReportingReportTypeUpdated = "reporting.report_type.updated";

        public const string ReviewClosed = "review.closed";

        public const string ReviewOpened = "review.opened";

        public const string SetupIntentCanceled = "setup_intent.canceled";

        public const string SetupIntentCreated = "setup_intent.created";

        public const string SetupIntentSetupFailed = "setup_intent.setup_failed";

        public const string SetupIntentSucceeded = "setup_intent.succeeded";

        public const string SigmaScheduleQueryRunCreated = "sigma.scheduled_query_run.created";

        public const string SkuCreated = "sku.created";

        public const string SkuDeleted = "sku.deleted";

        public const string SkuUpdated = "sku.updated";

        public const string SourceCanceled = "source.canceled";

        public const string SourceChargeable = "source.chargeable";

        public const string SourceFailed = "source.failed";

        public const string SourceMandateNotification = "source.mandate_notification";

        public const string SourceRefundAttributesRequired = "source.refund_attributes_required";

        public const string SourceTransactionCreated = "source.transaction.created";

        public const string SourceTransactionUpdated = "source.transaction.updated";

        public const string SubscriptionScheduleAborted = "subscription_schedule.aborted";

        public const string SubscriptionScheduleCanceled = "subscription_schedule.canceled";

        public const string SubscriptionScheduleCompleted = "subscription_schedule.completed";

        public const string SubscriptionScheduleCreated = "subscription_schedule.created";

        public const string SubscriptionScheduleExpiring = "subscription_schedule.expiring";

        public const string SubscriptionScheduleReleased = "subscription_schedule.released";

        public const string SubscriptionScheduleUpdated = "subscription_schedule.updated";

        public const string TaxRateCreated = "tax_rate.created";

        public const string TaxRateUpdated = "tax_rate.updated";

        public const string TopupCanceled = "topup.canceled";

        public const string TopupCreated = "topup.created";

        public const string TopupFailed = "topup.failed";

        public const string TopupReversed = "topup.reversed";

        public const string TopupSucceeded = "topup.succeeded";

        public const string TransferCreated = "transfer.created";

        public const string TransferReversed = "transfer.reversed";

        public const string TransferUpdated = "transfer.updated";

        public const string Ping = "ping";
    }
}
