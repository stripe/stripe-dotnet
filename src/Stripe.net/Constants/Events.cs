// File generated from our OpenAPI spec
namespace Stripe
{
    public static class Events
    {
        /// <summary>
        /// The "account.application.authorized" webhook event.
        /// </summary>
        public const string AccountApplicationAuthorized = "account.application.authorized";

        /// <summary>
        /// The "account.application.deauthorized" webhook event.
        /// </summary>
        public const string AccountApplicationDeauthorized = "account.application.deauthorized";

        /// <summary>
        /// The "account.external_account.created" webhook event.
        /// </summary>
        public const string AccountExternalAccountCreated = "account.external_account.created";

        /// <summary>
        /// The "account.external_account.deleted" webhook event.
        /// </summary>
        public const string AccountExternalAccountDeleted = "account.external_account.deleted";

        /// <summary>
        /// The "account.external_account.updated" webhook event.
        /// </summary>
        public const string AccountExternalAccountUpdated = "account.external_account.updated";

        /// <summary>
        /// The "account.updated" webhook event.
        /// </summary>
        public const string AccountUpdated = "account.updated";

        /// <summary>
        /// The "application_fee.created" webhook event.
        /// </summary>
        public const string ApplicationFeeCreated = "application_fee.created";

        /// <summary>
        /// The "application_fee.refund.updated" webhook event.
        /// </summary>
        public const string ApplicationFeeRefundUpdated = "application_fee.refund.updated";

        /// <summary>
        /// The "application_fee.refunded" webhook event.
        /// </summary>
        public const string ApplicationFeeRefunded = "application_fee.refunded";

        /// <summary>
        /// The "balance.available" webhook event.
        /// </summary>
        public const string BalanceAvailable = "balance.available";

        /// <summary>
        /// The "billing_portal.configuration.created" webhook event.
        /// </summary>
        public const string BillingPortalConfigurationCreated = "billing_portal.configuration.created";

        /// <summary>
        /// The "billing_portal.configuration.updated" webhook event.
        /// </summary>
        public const string BillingPortalConfigurationUpdated = "billing_portal.configuration.updated";

        /// <summary>
        /// The "billing_portal.session.created" webhook event.
        /// </summary>
        public const string BillingPortalSessionCreated = "billing_portal.session.created";

        /// <summary>
        /// The "capability.updated" webhook event.
        /// </summary>
        public const string CapabilityUpdated = "capability.updated";

        /// <summary>
        /// The "cash_balance.funds_available" webhook event.
        /// </summary>
        public const string CashBalanceFundsAvailable = "cash_balance.funds_available";

        /// <summary>
        /// The "charge.captured" webhook event.
        /// </summary>
        public const string ChargeCaptured = "charge.captured";

        /// <summary>
        /// The "charge.dispute.closed" webhook event.
        /// </summary>
        public const string ChargeDisputeClosed = "charge.dispute.closed";

        /// <summary>
        /// The "charge.dispute.created" webhook event.
        /// </summary>
        public const string ChargeDisputeCreated = "charge.dispute.created";

        /// <summary>
        /// The "charge.dispute.funds_reinstated" webhook event.
        /// </summary>
        public const string ChargeDisputeFundsReinstated = "charge.dispute.funds_reinstated";

        /// <summary>
        /// The "charge.dispute.funds_withdrawn" webhook event.
        /// </summary>
        public const string ChargeDisputeFundsWithdrawn = "charge.dispute.funds_withdrawn";

        /// <summary>
        /// The "charge.dispute.updated" webhook event.
        /// </summary>
        public const string ChargeDisputeUpdated = "charge.dispute.updated";

        /// <summary>
        /// The "charge.expired" webhook event.
        /// </summary>
        public const string ChargeExpired = "charge.expired";

        /// <summary>
        /// The "charge.failed" webhook event.
        /// </summary>
        public const string ChargeFailed = "charge.failed";

        /// <summary>
        /// The "charge.pending" webhook event.
        /// </summary>
        public const string ChargePending = "charge.pending";

        /// <summary>
        /// The "charge.refund.updated" webhook event.
        /// </summary>
        public const string ChargeRefundUpdated = "charge.refund.updated";

        /// <summary>
        /// The "charge.refunded" webhook event.
        /// </summary>
        public const string ChargeRefunded = "charge.refunded";

        /// <summary>
        /// The "charge.succeeded" webhook event.
        /// </summary>
        public const string ChargeSucceeded = "charge.succeeded";

        /// <summary>
        /// The "charge.updated" webhook event.
        /// </summary>
        public const string ChargeUpdated = "charge.updated";

        /// <summary>
        /// The "checkout.session.async_payment_failed" webhook event.
        /// </summary>
        public const string CheckoutSessionAsyncPaymentFailed = "checkout.session.async_payment_failed";

        /// <summary>
        /// The "checkout.session.async_payment_succeeded" webhook event.
        /// </summary>
        public const string CheckoutSessionAsyncPaymentSucceeded = "checkout.session.async_payment_succeeded";

        /// <summary>
        /// The "checkout.session.completed" webhook event.
        /// </summary>
        public const string CheckoutSessionCompleted = "checkout.session.completed";

        /// <summary>
        /// The "checkout.session.expired" webhook event.
        /// </summary>
        public const string CheckoutSessionExpired = "checkout.session.expired";

        /// <summary>
        /// The "coupon.created" webhook event.
        /// </summary>
        public const string CouponCreated = "coupon.created";

        /// <summary>
        /// The "coupon.deleted" webhook event.
        /// </summary>
        public const string CouponDeleted = "coupon.deleted";

        /// <summary>
        /// The "coupon.updated" webhook event.
        /// </summary>
        public const string CouponUpdated = "coupon.updated";

        /// <summary>
        /// The "credit_note.created" webhook event.
        /// </summary>
        public const string CreditNoteCreated = "credit_note.created";

        /// <summary>
        /// The "credit_note.updated" webhook event.
        /// </summary>
        public const string CreditNoteUpdated = "credit_note.updated";

        /// <summary>
        /// The "credit_note.voided" webhook event.
        /// </summary>
        public const string CreditNoteVoided = "credit_note.voided";

        /// <summary>
        /// The "customer_cash_balance_transaction.created" webhook event.
        /// </summary>
        public const string CustomerCashBalanceTransactionCreated = "customer_cash_balance_transaction.created";

        /// <summary>
        /// The "customer.created" webhook event.
        /// </summary>
        public const string CustomerCreated = "customer.created";

        /// <summary>
        /// The "customer.deleted" webhook event.
        /// </summary>
        public const string CustomerDeleted = "customer.deleted";

        /// <summary>
        /// The "customer.discount.created" webhook event.
        /// </summary>
        public const string CustomerDiscountCreated = "customer.discount.created";

        /// <summary>
        /// The "customer.discount.deleted" webhook event.
        /// </summary>
        public const string CustomerDiscountDeleted = "customer.discount.deleted";

        /// <summary>
        /// The "customer.discount.updated" webhook event.
        /// </summary>
        public const string CustomerDiscountUpdated = "customer.discount.updated";

        /// <summary>
        /// The "customer.source.created" webhook event.
        /// </summary>
        public const string CustomerSourceCreated = "customer.source.created";

        /// <summary>
        /// The "customer.source.deleted" webhook event.
        /// </summary>
        public const string CustomerSourceDeleted = "customer.source.deleted";

        /// <summary>
        /// The "customer.source.expiring" webhook event.
        /// </summary>
        public const string CustomerSourceExpiring = "customer.source.expiring";

        /// <summary>
        /// The "customer.source.updated" webhook event.
        /// </summary>
        public const string CustomerSourceUpdated = "customer.source.updated";

        /// <summary>
        /// The "customer.subscription.created" webhook event.
        /// </summary>
        public const string CustomerSubscriptionCreated = "customer.subscription.created";

        /// <summary>
        /// The "customer.subscription.deleted" webhook event.
        /// </summary>
        public const string CustomerSubscriptionDeleted = "customer.subscription.deleted";

        /// <summary>
        /// The "customer.subscription.paused" webhook event.
        /// </summary>
        public const string CustomerSubscriptionPaused = "customer.subscription.paused";

        /// <summary>
        /// The "customer.subscription.pending_update_applied" webhook event.
        /// </summary>
        public const string CustomerSubscriptionPendingUpdateApplied = "customer.subscription.pending_update_applied";

        /// <summary>
        /// The "customer.subscription.pending_update_expired" webhook event.
        /// </summary>
        public const string CustomerSubscriptionPendingUpdateExpired = "customer.subscription.pending_update_expired";

        /// <summary>
        /// The "customer.subscription.resumed" webhook event.
        /// </summary>
        public const string CustomerSubscriptionResumed = "customer.subscription.resumed";

        /// <summary>
        /// The "customer.subscription.trial_will_end" webhook event.
        /// </summary>
        public const string CustomerSubscriptionTrialWillEnd = "customer.subscription.trial_will_end";

        /// <summary>
        /// The "customer.subscription.updated" webhook event.
        /// </summary>
        public const string CustomerSubscriptionUpdated = "customer.subscription.updated";

        /// <summary>
        /// The "customer.tax_id.created" webhook event.
        /// </summary>
        public const string CustomerTaxIdCreated = "customer.tax_id.created";

        /// <summary>
        /// The "customer.tax_id.deleted" webhook event.
        /// </summary>
        public const string CustomerTaxIdDeleted = "customer.tax_id.deleted";

        /// <summary>
        /// The "customer.tax_id.updated" webhook event.
        /// </summary>
        public const string CustomerTaxIdUpdated = "customer.tax_id.updated";

        /// <summary>
        /// The "customer.updated" webhook event.
        /// </summary>
        public const string CustomerUpdated = "customer.updated";

        /// <summary>
        /// The "file.created" webhook event.
        /// </summary>
        public const string FileCreated = "file.created";

        /// <summary>
        /// The "financial_connections.account.created" webhook event.
        /// </summary>
        public const string FinancialConnectionsAccountCreated = "financial_connections.account.created";

        /// <summary>
        /// The "financial_connections.account.deactivated" webhook event.
        /// </summary>
        public const string FinancialConnectionsAccountDeactivated = "financial_connections.account.deactivated";

        /// <summary>
        /// The "financial_connections.account.disconnected" webhook event.
        /// </summary>
        public const string FinancialConnectionsAccountDisconnected = "financial_connections.account.disconnected";

        /// <summary>
        /// The "financial_connections.account.reactivated" webhook event.
        /// </summary>
        public const string FinancialConnectionsAccountReactivated = "financial_connections.account.reactivated";

        /// <summary>
        /// The "financial_connections.account.refreshed_balance" webhook event.
        /// </summary>
        public const string FinancialConnectionsAccountRefreshedBalance = "financial_connections.account.refreshed_balance";

        /// <summary>
        /// The "identity.verification_session.canceled" webhook event.
        /// </summary>
        public const string IdentityVerificationSessionCanceled = "identity.verification_session.canceled";

        /// <summary>
        /// The "identity.verification_session.created" webhook event.
        /// </summary>
        public const string IdentityVerificationSessionCreated = "identity.verification_session.created";

        /// <summary>
        /// The "identity.verification_session.processing" webhook event.
        /// </summary>
        public const string IdentityVerificationSessionProcessing = "identity.verification_session.processing";

        /// <summary>
        /// The "identity.verification_session.redacted" webhook event.
        /// </summary>
        public const string IdentityVerificationSessionRedacted = "identity.verification_session.redacted";

        /// <summary>
        /// The "identity.verification_session.requires_input" webhook event.
        /// </summary>
        public const string IdentityVerificationSessionRequiresInput = "identity.verification_session.requires_input";

        /// <summary>
        /// The "identity.verification_session.verified" webhook event.
        /// </summary>
        public const string IdentityVerificationSessionVerified = "identity.verification_session.verified";

        /// <summary>
        /// The "invoice.created" webhook event.
        /// </summary>
        public const string InvoiceCreated = "invoice.created";

        /// <summary>
        /// The "invoice.deleted" webhook event.
        /// </summary>
        public const string InvoiceDeleted = "invoice.deleted";

        /// <summary>
        /// The "invoice.finalization_error" webhook event.
        /// </summary>
        [Obsolete("This event is part of a beta or deprecated API and will be removed.")]
        public const string InvoiceFinalizationError = "invoice.finalization_error";

        /// <summary>
        /// The "invoice.finalization_failed" webhook event.
        /// </summary>
        public const string InvoiceFinalizationFailed = "invoice.finalization_failed";

        /// <summary>
        /// The "invoice.finalized" webhook event.
        /// </summary>
        public const string InvoiceFinalized = "invoice.finalized";

        /// <summary>
        /// The "invoice.marked_uncollectible" webhook event.
        /// </summary>
        public const string InvoiceMarkedUncollectible = "invoice.marked_uncollectible";

        /// <summary>
        /// The "invoice.paid" webhook event.
        /// </summary>
        public const string InvoicePaid = "invoice.paid";

        /// <summary>
        /// The "invoice.payment_action_required" webhook event.
        /// </summary>
        public const string InvoicePaymentActionRequired = "invoice.payment_action_required";

        /// <summary>
        /// The "invoice.payment_failed" webhook event.
        /// </summary>
        public const string InvoicePaymentFailed = "invoice.payment_failed";

        /// <summary>
        /// The "invoice.payment_succeeded" webhook event.
        /// </summary>
        public const string InvoicePaymentSucceeded = "invoice.payment_succeeded";

        /// <summary>
        /// The "invoice.sent" webhook event.
        /// </summary>
        public const string InvoiceSent = "invoice.sent";

        /// <summary>
        /// The "invoice.upcoming" webhook event.
        /// </summary>
        public const string InvoiceUpcoming = "invoice.upcoming";

        /// <summary>
        /// The "invoice.updated" webhook event.
        /// </summary>
        public const string InvoiceUpdated = "invoice.updated";

        /// <summary>
        /// The "invoice.voided" webhook event.
        /// </summary>
        public const string InvoiceVoided = "invoice.voided";

        /// <summary>
        /// The "invoiceitem.created" webhook event.
        /// </summary>
        public const string InvoiceItemCreated = "invoiceitem.created";

        /// <summary>
        /// The "invoiceitem.deleted" webhook event.
        /// </summary>
        public const string InvoiceItemDeleted = "invoiceitem.deleted";

        /// <summary>
        /// The "invoiceitem.updated" webhook event.
        /// </summary>
        public const string InvoiceItemUpdated = "invoiceitem.updated";

        /// <summary>
        /// The "issuing_authorization.created" webhook event.
        /// </summary>
        public const string IssuingAuthorizationCreated = "issuing_authorization.created";

        /// <summary>
        /// The "issuing_authorization.request" webhook event.
        /// </summary>
        public const string IssuingAuthorizationRequest = "issuing_authorization.request";

        /// <summary>
        /// The "issuing_authorization.updated" webhook event.
        /// </summary>
        public const string IssuingAuthorizationUpdated = "issuing_authorization.updated";

        /// <summary>
        /// The "issuing_card.created" webhook event.
        /// </summary>
        public const string IssuingCardCreated = "issuing_card.created";

        /// <summary>
        /// The "issuing_card.updated" webhook event.
        /// </summary>
        public const string IssuingCardUpdated = "issuing_card.updated";

        /// <summary>
        /// The "issuing_cardholder.created" webhook event.
        /// </summary>
        public const string IssuingCardholderCreated = "issuing_cardholder.created";

        /// <summary>
        /// The "issuing_cardholder.updated" webhook event.
        /// </summary>
        public const string IssuingCardholderUpdated = "issuing_cardholder.updated";

        /// <summary>
        /// The "issuing_dispute.closed" webhook event.
        /// </summary>
        public const string IssuingDisputeClosed = "issuing_dispute.closed";

        /// <summary>
        /// The "issuing_dispute.created" webhook event.
        /// </summary>
        public const string IssuingDisputeCreated = "issuing_dispute.created";

        /// <summary>
        /// The "issuing_dispute.funds_reinstated" webhook event.
        /// </summary>
        public const string IssuingDisputeFundsReinstated = "issuing_dispute.funds_reinstated";

        /// <summary>
        /// The "issuing_dispute.submitted" webhook event.
        /// </summary>
        public const string IssuingDisputeSubmitted = "issuing_dispute.submitted";

        /// <summary>
        /// The "issuing_dispute.updated" webhook event.
        /// </summary>
        public const string IssuingDisputeUpdated = "issuing_dispute.updated";

        /// <summary>
        /// The "issuing_transaction.created" webhook event.
        /// </summary>
        public const string IssuingTransactionCreated = "issuing_transaction.created";

        /// <summary>
        /// The "issuing_transaction.updated" webhook event.
        /// </summary>
        public const string IssuingTransactionUpdated = "issuing_transaction.updated";

        /// <summary>
        /// The "mandate.updated" webhook event.
        /// </summary>
        public const string MandateUpdated = "mandate.updated";

        /// <summary>
        /// The "order.created" webhook event.
        /// </summary>
        public const string OrderCreated = "order.created";

        /// <summary>
        /// The "order.payment_failed" webhook event.
        /// </summary>
        [Obsolete("This event is part of a beta or deprecated API and will be removed.")]
        public const string OrderPaymentFailed = "order.payment_failed";

        /// <summary>
        /// The "payment_intent.amount_capturable_updated" webhook event.
        /// </summary>
        public const string PaymentIntentAmountCapturableUpdated = "payment_intent.amount_capturable_updated";

        /// <summary>
        /// The "payment_intent.canceled" webhook event.
        /// </summary>
        public const string PaymentIntentCanceled = "payment_intent.canceled";

        /// <summary>
        /// The "payment_intent.created" webhook event.
        /// </summary>
        public const string PaymentIntentCreated = "payment_intent.created";

        /// <summary>
        /// The "payment_intent.partially_funded" webhook event.
        /// </summary>
        public const string PaymentIntentPartiallyFunded = "payment_intent.partially_funded";

        /// <summary>
        /// The "payment_intent.payment_failed" webhook event.
        /// </summary>
        public const string PaymentIntentPaymentFailed = "payment_intent.payment_failed";

        /// <summary>
        /// The "payment_intent.processing" webhook event.
        /// </summary>
        public const string PaymentIntentProcessing = "payment_intent.processing";

        /// <summary>
        /// The "payment_intent.requires_action" webhook event.
        /// </summary>
        public const string PaymentIntentRequiresAction = "payment_intent.requires_action";

        /// <summary>
        /// The "payment_intent.succeeded" webhook event.
        /// </summary>
        public const string PaymentIntentSucceeded = "payment_intent.succeeded";

        /// <summary>
        /// The "payment_link.created" webhook event.
        /// </summary>
        public const string PaymentLinkCreated = "payment_link.created";

        /// <summary>
        /// The "payment_link.updated" webhook event.
        /// </summary>
        public const string PaymentLinkUpdated = "payment_link.updated";

        /// <summary>
        /// The "payment_method.attached" webhook event.
        /// </summary>
        public const string PaymentMethodAttached = "payment_method.attached";

        /// <summary>
        /// The "payment_method.automatically_updated" webhook event.
        /// </summary>
        public const string PaymentMethodAutomaticallyUpdated = "payment_method.automatically_updated";

        /// <summary>
        /// The "payment_method.card_automatically_updated" webhook event.
        /// </summary>
        [Obsolete("Use PaymentMethodAutomaticallyUpdated instead.")]
        public const string PaymentMethodCardAutomaticallyUpdated = "payment_method.card_automatically_updated";

        /// <summary>
        /// The "payment_method.detached" webhook event.
        /// </summary>
        public const string PaymentMethodDetached = "payment_method.detached";

        /// <summary>
        /// The "payment_method.updated" webhook event.
        /// </summary>
        public const string PaymentMethodUpdated = "payment_method.updated";

        /// <summary>
        /// The "payment.created" webhook event.
        /// </summary>
        public const string PaymentCreated = "payment.created";

        /// <summary>
        /// The "payout.canceled" webhook event.
        /// </summary>
        public const string PayoutCanceled = "payout.canceled";

        /// <summary>
        /// The "payout.created" webhook event.
        /// </summary>
        public const string PayoutCreated = "payout.created";

        /// <summary>
        /// The "payout.failed" webhook event.
        /// </summary>
        public const string PayoutFailed = "payout.failed";

        /// <summary>
        /// The "payout.paid" webhook event.
        /// </summary>
        public const string PayoutPaid = "payout.paid";

        /// <summary>
        /// The "payout.reconciliation_completed" webhook event.
        /// </summary>
        public const string PayoutReconciliationCompleted = "payout.reconciliation_completed";

        /// <summary>
        /// The "payout.updated" webhook event.
        /// </summary>
        public const string PayoutUpdated = "payout.updated";

        /// <summary>
        /// The "person.created" webhook event.
        /// </summary>
        public const string PersonCreated = "person.created";

        /// <summary>
        /// The "person.deleted" webhook event.
        /// </summary>
        public const string PersonDeleted = "person.deleted";

        /// <summary>
        /// The "person.updated" webhook event.
        /// </summary>
        public const string PersonUpdated = "person.updated";

        /// <summary>
        /// The "ping" webhook event.
        /// </summary>
        public const string Ping = "ping";

        /// <summary>
        /// The "plan.created" webhook event.
        /// </summary>
        public const string PlanCreated = "plan.created";

        /// <summary>
        /// The "plan.deleted" webhook event.
        /// </summary>
        public const string PlanDeleted = "plan.deleted";

        /// <summary>
        /// The "plan.updated" webhook event.
        /// </summary>
        public const string PlanUpdated = "plan.updated";

        /// <summary>
        /// The "price.created" webhook event.
        /// </summary>
        public const string PriceCreated = "price.created";

        /// <summary>
        /// The "price.deleted" webhook event.
        /// </summary>
        public const string PriceDeleted = "price.deleted";

        /// <summary>
        /// The "price.updated" webhook event.
        /// </summary>
        public const string PriceUpdated = "price.updated";

        /// <summary>
        /// The "product.created" webhook event.
        /// </summary>
        public const string ProductCreated = "product.created";

        /// <summary>
        /// The "product.deleted" webhook event.
        /// </summary>
        public const string ProductDeleted = "product.deleted";

        /// <summary>
        /// The "product.updated" webhook event.
        /// </summary>
        public const string ProductUpdated = "product.updated";

        /// <summary>
        /// The "promotion_code.created" webhook event.
        /// </summary>
        public const string PromotionCodeCreated = "promotion_code.created";

        /// <summary>
        /// The "promotion_code.updated" webhook event.
        /// </summary>
        public const string PromotionCodeUpdated = "promotion_code.updated";

        /// <summary>
        /// The "quote.accepted" webhook event.
        /// </summary>
        public const string QuoteAccepted = "quote.accepted";

        /// <summary>
        /// The "quote.canceled" webhook event.
        /// </summary>
        public const string QuoteCanceled = "quote.canceled";

        /// <summary>
        /// The "quote.created" webhook event.
        /// </summary>
        public const string QuoteCreated = "quote.created";

        /// <summary>
        /// The "quote.finalized" webhook event.
        /// </summary>
        public const string QuoteFinalized = "quote.finalized";

        /// <summary>
        /// The "radar.early_fraud_warning.created" webhook event.
        /// </summary>
        public const string RadarEarlyFraudWarningCreated = "radar.early_fraud_warning.created";

        /// <summary>
        /// The "radar.early_fraud_warning.updated" webhook event.
        /// </summary>
        public const string RadarEarlyFraudWarningUpdated = "radar.early_fraud_warning.updated";

        /// <summary>
        /// The "recipient.created" webhook event.
        /// </summary>
        public const string RecipientCreated = "recipient.created";

        /// <summary>
        /// The "recipient.deleted" webhook event.
        /// </summary>
        public const string RecipientDeleted = "recipient.deleted";

        /// <summary>
        /// The "recipient.updated" webhook event.
        /// </summary>
        public const string RecipientUpdated = "recipient.updated";

        /// <summary>
        /// The "refund.created" webhook event.
        /// </summary>
        public const string RefundCreated = "refund.created";

        /// <summary>
        /// The "refund.updated" webhook event.
        /// </summary>
        public const string RefundUpdated = "refund.updated";

        /// <summary>
        /// The "reporting.report_run.failed" webhook event.
        /// </summary>
        public const string ReportingReportRunFailed = "reporting.report_run.failed";

        /// <summary>
        /// The "reporting.report_run.succeeded" webhook event.
        /// </summary>
        public const string ReportingReportRunSucceeded = "reporting.report_run.succeeded";

        /// <summary>
        /// The "reporting.report_type.updated" webhook event.
        /// </summary>
        public const string ReportingReportTypeUpdated = "reporting.report_type.updated";

        /// <summary>
        /// The "review.closed" webhook event.
        /// </summary>
        public const string ReviewClosed = "review.closed";

        /// <summary>
        /// The "review.opened" webhook event.
        /// </summary>
        public const string ReviewOpened = "review.opened";

        /// <summary>
        /// The "setup_intent.canceled" webhook event.
        /// </summary>
        public const string SetupIntentCanceled = "setup_intent.canceled";

        /// <summary>
        /// The "setup_intent.created" webhook event.
        /// </summary>
        public const string SetupIntentCreated = "setup_intent.created";

        /// <summary>
        /// The "setup_intent.requires_action" webhook event.
        /// </summary>
        public const string SetupIntentRequiresAction = "setup_intent.requires_action";

        /// <summary>
        /// The "setup_intent.setup_failed" webhook event.
        /// </summary>
        public const string SetupIntentSetupFailed = "setup_intent.setup_failed";

        /// <summary>
        /// The "setup_intent.succeeded" webhook event.
        /// </summary>
        public const string SetupIntentSucceeded = "setup_intent.succeeded";

        /// <summary>
        /// The "sigma.scheduled_query_run.created" webhook event.
        /// </summary>
        [Obsolete("This event is part of a beta or deprecated API and will be removed.")]
        public const string SigmaScheduleQueryRunCreated = "sigma.scheduled_query_run.created";

        /// <summary>
        /// The "sku.created" webhook event.
        /// </summary>
        public const string SkuCreated = "sku.created";

        /// <summary>
        /// The "sku.deleted" webhook event.
        /// </summary>
        public const string SkuDeleted = "sku.deleted";

        /// <summary>
        /// The "sku.updated" webhook event.
        /// </summary>
        public const string SkuUpdated = "sku.updated";

        /// <summary>
        /// The "source.canceled" webhook event.
        /// </summary>
        public const string SourceCanceled = "source.canceled";

        /// <summary>
        /// The "source.chargeable" webhook event.
        /// </summary>
        public const string SourceChargeable = "source.chargeable";

        /// <summary>
        /// The "source.failed" webhook event.
        /// </summary>
        public const string SourceFailed = "source.failed";

        /// <summary>
        /// The "source.mandate_notification" webhook event.
        /// </summary>
        public const string SourceMandateNotification = "source.mandate_notification";

        /// <summary>
        /// The "source.refund_attributes_required" webhook event.
        /// </summary>
        public const string SourceRefundAttributesRequired = "source.refund_attributes_required";

        /// <summary>
        /// The "source.transaction.created" webhook event.
        /// </summary>
        public const string SourceTransactionCreated = "source.transaction.created";

        /// <summary>
        /// The "source.transaction.updated" webhook event.
        /// </summary>
        public const string SourceTransactionUpdated = "source.transaction.updated";

        /// <summary>
        /// The "subscription_schedule.aborted" webhook event.
        /// </summary>
        public const string SubscriptionScheduleAborted = "subscription_schedule.aborted";

        /// <summary>
        /// The "subscription_schedule.canceled" webhook event.
        /// </summary>
        public const string SubscriptionScheduleCanceled = "subscription_schedule.canceled";

        /// <summary>
        /// The "subscription_schedule.completed" webhook event.
        /// </summary>
        public const string SubscriptionScheduleCompleted = "subscription_schedule.completed";

        /// <summary>
        /// The "subscription_schedule.created" webhook event.
        /// </summary>
        public const string SubscriptionScheduleCreated = "subscription_schedule.created";

        /// <summary>
        /// The "subscription_schedule.expiring" webhook event.
        /// </summary>
        public const string SubscriptionScheduleExpiring = "subscription_schedule.expiring";

        /// <summary>
        /// The "subscription_schedule.released" webhook event.
        /// </summary>
        public const string SubscriptionScheduleReleased = "subscription_schedule.released";

        /// <summary>
        /// The "subscription_schedule.updated" webhook event.
        /// </summary>
        public const string SubscriptionScheduleUpdated = "subscription_schedule.updated";

        /// <summary>
        /// The "tax_rate.created" webhook event.
        /// </summary>
        public const string TaxRateCreated = "tax_rate.created";

        /// <summary>
        /// The "tax_rate.updated" webhook event.
        /// </summary>
        public const string TaxRateUpdated = "tax_rate.updated";

        /// <summary>
        /// The "tax.settings.updated" webhook event.
        /// </summary>
        public const string TaxSettingsUpdated = "tax.settings.updated";

        /// <summary>
        /// The "terminal.reader.action_failed" webhook event.
        /// </summary>
        public const string TerminalReaderActionFailed = "terminal.reader.action_failed";

        /// <summary>
        /// The "terminal.reader.action_succeeded" webhook event.
        /// </summary>
        public const string TerminalReaderActionSucceeded = "terminal.reader.action_succeeded";

        /// <summary>
        /// The "test_helpers.test_clock.advancing" webhook event.
        /// </summary>
        public const string TestHelpersTestClockAdvancing = "test_helpers.test_clock.advancing";

        /// <summary>
        /// The "test_helpers.test_clock.created" webhook event.
        /// </summary>
        public const string TestHelpersTestClockCreated = "test_helpers.test_clock.created";

        /// <summary>
        /// The "test_helpers.test_clock.deleted" webhook event.
        /// </summary>
        public const string TestHelpersTestClockDeleted = "test_helpers.test_clock.deleted";

        /// <summary>
        /// The "test_helpers.test_clock.internal_failure" webhook event.
        /// </summary>
        public const string TestHelpersTestClockInternalFailure = "test_helpers.test_clock.internal_failure";

        /// <summary>
        /// The "test_helpers.test_clock.ready" webhook event.
        /// </summary>
        public const string TestHelpersTestClockReady = "test_helpers.test_clock.ready";

        /// <summary>
        /// The "topup.canceled" webhook event.
        /// </summary>
        public const string TopupCanceled = "topup.canceled";

        /// <summary>
        /// The "topup.created" webhook event.
        /// </summary>
        public const string TopupCreated = "topup.created";

        /// <summary>
        /// The "topup.failed" webhook event.
        /// </summary>
        public const string TopupFailed = "topup.failed";

        /// <summary>
        /// The "topup.reversed" webhook event.
        /// </summary>
        public const string TopupReversed = "topup.reversed";

        /// <summary>
        /// The "topup.succeeded" webhook event.
        /// </summary>
        public const string TopupSucceeded = "topup.succeeded";

        /// <summary>
        /// The "transfer.created" webhook event.
        /// </summary>
        public const string TransferCreated = "transfer.created";

        /// <summary>
        /// The "transfer.reversed" webhook event.
        /// </summary>
        public const string TransferReversed = "transfer.reversed";

        /// <summary>
        /// The "transfer.updated" webhook event.
        /// </summary>
        public const string TransferUpdated = "transfer.updated";

        /// <summary>
        /// The "treasury.check_deposit.canceled" webhook event.
        /// </summary>
        [Obsolete("This event is part of a beta or deprecated API and will be removed.")]
        public const string TreasuryCheckDepositCanceled = "treasury.check_deposit.canceled";

        /// <summary>
        /// The "treasury.check_deposit.created" webhook event.
        /// </summary>
        [Obsolete("This event is part of a beta or deprecated API and will be removed.")]
        public const string TreasuryCheckDepositCreated = "treasury.check_deposit.created";

        /// <summary>
        /// The "treasury.check_deposit.processing" webhook event.
        /// </summary>
        [Obsolete("This event is part of a beta or deprecated API and will be removed.")]
        public const string TreasuryCheckDepositProcessing = "treasury.check_deposit.processing";

        /// <summary>
        /// The "treasury.check_deposit.received" webhook event.
        /// </summary>
        [Obsolete("This event is part of a beta or deprecated API and will be removed.")]
        public const string TreasuryCheckDepositReceived = "treasury.check_deposit.received";

        /// <summary>
        /// The "treasury.check_deposit.requires_action" webhook event.
        /// </summary>
        [Obsolete("This event is part of a beta or deprecated API and will be removed.")]
        public const string TreasuryCheckDepositRequiresAction = "treasury.check_deposit.requires_action";

        /// <summary>
        /// The "treasury.check_deposit.requires_confirmation" webhook event.
        /// </summary>
        [Obsolete("This event is part of a beta or deprecated API and will be removed.")]
        public const string TreasuryCheckDepositRequiresConfirmation = "treasury.check_deposit.requires_confirmation";

        /// <summary>
        /// The "treasury.check_deposit.reversed" webhook event.
        /// </summary>
        [Obsolete("This event is part of a beta or deprecated API and will be removed.")]
        public const string TreasuryCheckDepositReversed = "treasury.check_deposit.reversed";

        /// <summary>
        /// The "treasury.credit_reversal.created" webhook event.
        /// </summary>
        public const string TreasuryCreditReversalCreated = "treasury.credit_reversal.created";

        /// <summary>
        /// The "treasury.credit_reversal.posted" webhook event.
        /// </summary>
        public const string TreasuryCreditReversalPosted = "treasury.credit_reversal.posted";

        /// <summary>
        /// The "treasury.debit_reversal.completed" webhook event.
        /// </summary>
        public const string TreasuryDebitReversalCompleted = "treasury.debit_reversal.completed";

        /// <summary>
        /// The "treasury.debit_reversal.created" webhook event.
        /// </summary>
        public const string TreasuryDebitReversalCreated = "treasury.debit_reversal.created";

        /// <summary>
        /// The "treasury.debit_reversal.initial_credit_granted" webhook event.
        /// </summary>
        public const string TreasuryDebitReversalInitialCreditGranted = "treasury.debit_reversal.initial_credit_granted";

        /// <summary>
        /// The "treasury.financial_account.closed" webhook event.
        /// </summary>
        public const string TreasuryFinancialAccountClosed = "treasury.financial_account.closed";

        /// <summary>
        /// The "treasury.financial_account.created" webhook event.
        /// </summary>
        public const string TreasuryFinancialAccountCreated = "treasury.financial_account.created";

        /// <summary>
        /// The "treasury.financial_account.features_status_updated" webhook event.
        /// </summary>
        public const string TreasuryFinancialAccountFeaturesStatusUpdated = "treasury.financial_account.features_status_updated";

        /// <summary>
        /// The "treasury.inbound_transfer.canceled" webhook event.
        /// </summary>
        public const string TreasuryInboundTransferCanceled = "treasury.inbound_transfer.canceled";

        /// <summary>
        /// The "treasury.inbound_transfer.created" webhook event.
        /// </summary>
        public const string TreasuryInboundTransferCreated = "treasury.inbound_transfer.created";

        /// <summary>
        /// The "treasury.inbound_transfer.failed" webhook event.
        /// </summary>
        public const string TreasuryInboundTransferFailed = "treasury.inbound_transfer.failed";

        /// <summary>
        /// The "treasury.inbound_transfer.succeeded" webhook event.
        /// </summary>
        public const string TreasuryInboundTransferSucceeded = "treasury.inbound_transfer.succeeded";

        /// <summary>
        /// The "treasury.outbound_payment.canceled" webhook event.
        /// </summary>
        public const string TreasuryOutboundPaymentCanceled = "treasury.outbound_payment.canceled";

        /// <summary>
        /// The "treasury.outbound_payment.created" webhook event.
        /// </summary>
        public const string TreasuryOutboundPaymentCreated = "treasury.outbound_payment.created";

        /// <summary>
        /// The "treasury.outbound_payment.expected_arrival_date_updated" webhook event.
        /// </summary>
        public const string TreasuryOutboundPaymentExpectedArrivalDateUpdated = "treasury.outbound_payment.expected_arrival_date_updated";

        /// <summary>
        /// The "treasury.outbound_payment.failed" webhook event.
        /// </summary>
        public const string TreasuryOutboundPaymentFailed = "treasury.outbound_payment.failed";

        /// <summary>
        /// The "treasury.outbound_payment.posted" webhook event.
        /// </summary>
        public const string TreasuryOutboundPaymentPosted = "treasury.outbound_payment.posted";

        /// <summary>
        /// The "treasury.outbound_payment.returned" webhook event.
        /// </summary>
        public const string TreasuryOutboundPaymentReturned = "treasury.outbound_payment.returned";

        /// <summary>
        /// The "treasury.outbound_transfer.canceled" webhook event.
        /// </summary>
        public const string TreasuryOutboundTransferCanceled = "treasury.outbound_transfer.canceled";

        /// <summary>
        /// The "treasury.outbound_transfer.created" webhook event.
        /// </summary>
        public const string TreasuryOutboundTransferCreated = "treasury.outbound_transfer.created";

        /// <summary>
        /// The "treasury.outbound_transfer.expected_arrival_date_updated" webhook event.
        /// </summary>
        public const string TreasuryOutboundTransferExpectedArrivalDateUpdated = "treasury.outbound_transfer.expected_arrival_date_updated";

        /// <summary>
        /// The "treasury.outbound_transfer.failed" webhook event.
        /// </summary>
        public const string TreasuryOutboundTransferFailed = "treasury.outbound_transfer.failed";

        /// <summary>
        /// The "treasury.outbound_transfer.posted" webhook event.
        /// </summary>
        public const string TreasuryOutboundTransferPosted = "treasury.outbound_transfer.posted";

        /// <summary>
        /// The "treasury.outbound_transfer.returned" webhook event.
        /// </summary>
        public const string TreasuryOutboundTransferReturned = "treasury.outbound_transfer.returned";

        /// <summary>
        /// The "treasury.received_credit.created" webhook event.
        /// </summary>
        public const string TreasuryReceivedCreditCreated = "treasury.received_credit.created";

        /// <summary>
        /// The "treasury.received_credit.failed" webhook event.
        /// </summary>
        public const string TreasuryReceivedCreditFailed = "treasury.received_credit.failed";

        /// <summary>
        /// The "treasury.received_credit.reversed" webhook event.
        /// </summary>
        [Obsolete("This event is part of a beta or deprecated API and will be removed.")]
        public const string TreasuryReceivedCreditReversed = "treasury.received_credit.reversed";

        /// <summary>
        /// The "treasury.received_credit.succeeded" webhook event.
        /// </summary>
        public const string TreasuryReceivedCreditSucceeded = "treasury.received_credit.succeeded";

        /// <summary>
        /// The "treasury.received_debit.created" webhook event.
        /// </summary>
        public const string TreasuryReceivedDebitCreated = "treasury.received_debit.created";
    }
}