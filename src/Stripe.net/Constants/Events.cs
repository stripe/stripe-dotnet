// File generated from our OpenAPI spec
namespace Stripe
{
    using System;

    public static class Events
    {
        /// <summary>
        /// The "account.application.authorized" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-account.application.authorized for
        /// details.
        /// </summary>
        public const string AccountApplicationAuthorized = "account.application.authorized";

        /// <summary>
        /// The "account.application.deauthorized" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-account.application.deauthorized
        /// for details.
        /// </summary>
        public const string AccountApplicationDeauthorized = "account.application.deauthorized";

        /// <summary>
        /// The "account.external_account.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-account.external_account.created
        /// for details.
        /// </summary>
        public const string AccountExternalAccountCreated = "account.external_account.created";

        /// <summary>
        /// The "account.external_account.deleted" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-account.external_account.deleted
        /// for details.
        /// </summary>
        public const string AccountExternalAccountDeleted = "account.external_account.deleted";

        /// <summary>
        /// The "account.external_account.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-account.external_account.updated
        /// for details.
        /// </summary>
        public const string AccountExternalAccountUpdated = "account.external_account.updated";

        /// <summary>
        /// The "account.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-account.updated for details.
        /// </summary>
        public const string AccountUpdated = "account.updated";

        /// <summary>
        /// The "application_fee.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-application_fee.created for
        /// details.
        /// </summary>
        public const string ApplicationFeeCreated = "application_fee.created";

        /// <summary>
        /// The "application_fee.refund.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-application_fee.refund.updated for
        /// details.
        /// </summary>
        public const string ApplicationFeeRefundUpdated = "application_fee.refund.updated";

        /// <summary>
        /// The "application_fee.refunded" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-application_fee.refunded for
        /// details.
        /// </summary>
        public const string ApplicationFeeRefunded = "application_fee.refunded";

        /// <summary>
        /// The "balance.available" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-balance.available for details.
        /// </summary>
        public const string BalanceAvailable = "balance.available";

        /// <summary>
        /// The "billing_portal.configuration.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-billing_portal.configuration.created
        /// for details.
        /// </summary>
        public const string BillingPortalConfigurationCreated = "billing_portal.configuration.created";

        /// <summary>
        /// The "billing_portal.configuration.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-billing_portal.configuration.updated
        /// for details.
        /// </summary>
        public const string BillingPortalConfigurationUpdated = "billing_portal.configuration.updated";

        /// <summary>
        /// The "billing_portal.session.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-billing_portal.session.created for
        /// details.
        /// </summary>
        public const string BillingPortalSessionCreated = "billing_portal.session.created";

        /// <summary>
        /// The "capability.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-capability.updated for details.
        /// </summary>
        public const string CapabilityUpdated = "capability.updated";

        /// <summary>
        /// The "cash_balance.funds_available" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-cash_balance.funds_available for
        /// details.
        /// </summary>
        public const string CashBalanceFundsAvailable = "cash_balance.funds_available";

        /// <summary>
        /// The "charge.captured" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-charge.captured for details.
        /// </summary>
        public const string ChargeCaptured = "charge.captured";

        /// <summary>
        /// The "charge.dispute.closed" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-charge.dispute.closed for details.
        /// </summary>
        public const string ChargeDisputeClosed = "charge.dispute.closed";

        /// <summary>
        /// The "charge.dispute.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-charge.dispute.created for details.
        /// </summary>
        public const string ChargeDisputeCreated = "charge.dispute.created";

        /// <summary>
        /// The "charge.dispute.funds_reinstated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-charge.dispute.funds_reinstated for
        /// details.
        /// </summary>
        public const string ChargeDisputeFundsReinstated = "charge.dispute.funds_reinstated";

        /// <summary>
        /// The "charge.dispute.funds_withdrawn" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-charge.dispute.funds_withdrawn for
        /// details.
        /// </summary>
        public const string ChargeDisputeFundsWithdrawn = "charge.dispute.funds_withdrawn";

        /// <summary>
        /// The "charge.dispute.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-charge.dispute.updated for details.
        /// </summary>
        public const string ChargeDisputeUpdated = "charge.dispute.updated";

        /// <summary>
        /// The "charge.expired" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-charge.expired for details.
        /// </summary>
        public const string ChargeExpired = "charge.expired";

        /// <summary>
        /// The "charge.failed" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-charge.failed for details.
        /// </summary>
        public const string ChargeFailed = "charge.failed";

        /// <summary>
        /// The "charge.pending" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-charge.pending for details.
        /// </summary>
        public const string ChargePending = "charge.pending";

        /// <summary>
        /// The "charge.refund.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-charge.refund.updated for details.
        /// </summary>
        public const string ChargeRefundUpdated = "charge.refund.updated";

        /// <summary>
        /// The "charge.refunded" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-charge.refunded for details.
        /// </summary>
        public const string ChargeRefunded = "charge.refunded";

        /// <summary>
        /// The "charge.succeeded" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-charge.succeeded for details.
        /// </summary>
        public const string ChargeSucceeded = "charge.succeeded";

        /// <summary>
        /// The "charge.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-charge.updated for details.
        /// </summary>
        public const string ChargeUpdated = "charge.updated";

        /// <summary>
        /// The "checkout.session.async_payment_failed" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-checkout.session.async_payment_failed
        /// for details.
        /// </summary>
        public const string CheckoutSessionAsyncPaymentFailed = "checkout.session.async_payment_failed";

        /// <summary>
        /// The "checkout.session.async_payment_succeeded" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-checkout.session.async_payment_succeeded
        /// for details.
        /// </summary>
        public const string CheckoutSessionAsyncPaymentSucceeded = "checkout.session.async_payment_succeeded";

        /// <summary>
        /// The "checkout.session.completed" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-checkout.session.completed for
        /// details.
        /// </summary>
        public const string CheckoutSessionCompleted = "checkout.session.completed";

        /// <summary>
        /// The "checkout.session.expired" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-checkout.session.expired for
        /// details.
        /// </summary>
        public const string CheckoutSessionExpired = "checkout.session.expired";

        /// <summary>
        /// The "coupon.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-coupon.created for details.
        /// </summary>
        public const string CouponCreated = "coupon.created";

        /// <summary>
        /// The "coupon.deleted" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-coupon.deleted for details.
        /// </summary>
        public const string CouponDeleted = "coupon.deleted";

        /// <summary>
        /// The "coupon.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-coupon.updated for details.
        /// </summary>
        public const string CouponUpdated = "coupon.updated";

        /// <summary>
        /// The "credit_note.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-credit_note.created for details.
        /// </summary>
        public const string CreditNoteCreated = "credit_note.created";

        /// <summary>
        /// The "credit_note.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-credit_note.updated for details.
        /// </summary>
        public const string CreditNoteUpdated = "credit_note.updated";

        /// <summary>
        /// The "credit_note.voided" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-credit_note.voided for details.
        /// </summary>
        public const string CreditNoteVoided = "credit_note.voided";

        /// <summary>
        /// The "customer_cash_balance_transaction.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-customer_cash_balance_transaction.created
        /// for details.
        /// </summary>
        public const string CustomerCashBalanceTransactionCreated = "customer_cash_balance_transaction.created";

        /// <summary>
        /// The "customer.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-customer.created for details.
        /// </summary>
        public const string CustomerCreated = "customer.created";

        /// <summary>
        /// The "customer.deleted" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-customer.deleted for details.
        /// </summary>
        public const string CustomerDeleted = "customer.deleted";

        /// <summary>
        /// The "customer.discount.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-customer.discount.created for
        /// details.
        /// </summary>
        public const string CustomerDiscountCreated = "customer.discount.created";

        /// <summary>
        /// The "customer.discount.deleted" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-customer.discount.deleted for
        /// details.
        /// </summary>
        public const string CustomerDiscountDeleted = "customer.discount.deleted";

        /// <summary>
        /// The "customer.discount.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-customer.discount.updated for
        /// details.
        /// </summary>
        public const string CustomerDiscountUpdated = "customer.discount.updated";

        /// <summary>
        /// The "customer.source.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-customer.source.created for
        /// details.
        /// </summary>
        public const string CustomerSourceCreated = "customer.source.created";

        /// <summary>
        /// The "customer.source.deleted" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-customer.source.deleted for
        /// details.
        /// </summary>
        public const string CustomerSourceDeleted = "customer.source.deleted";

        /// <summary>
        /// The "customer.source.expiring" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-customer.source.expiring for
        /// details.
        /// </summary>
        public const string CustomerSourceExpiring = "customer.source.expiring";

        /// <summary>
        /// The "customer.source.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-customer.source.updated for
        /// details.
        /// </summary>
        public const string CustomerSourceUpdated = "customer.source.updated";

        /// <summary>
        /// The "customer.subscription.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-customer.subscription.created for
        /// details.
        /// </summary>
        public const string CustomerSubscriptionCreated = "customer.subscription.created";

        /// <summary>
        /// The "customer.subscription.deleted" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-customer.subscription.deleted for
        /// details.
        /// </summary>
        public const string CustomerSubscriptionDeleted = "customer.subscription.deleted";

        /// <summary>
        /// The "customer.subscription.paused" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-customer.subscription.paused for
        /// details.
        /// </summary>
        public const string CustomerSubscriptionPaused = "customer.subscription.paused";

        /// <summary>
        /// The "customer.subscription.pending_update_applied" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-customer.subscription.pending_update_applied
        /// for details.
        /// </summary>
        public const string CustomerSubscriptionPendingUpdateApplied = "customer.subscription.pending_update_applied";

        /// <summary>
        /// The "customer.subscription.pending_update_expired" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-customer.subscription.pending_update_expired
        /// for details.
        /// </summary>
        public const string CustomerSubscriptionPendingUpdateExpired = "customer.subscription.pending_update_expired";

        /// <summary>
        /// The "customer.subscription.resumed" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-customer.subscription.resumed for
        /// details.
        /// </summary>
        public const string CustomerSubscriptionResumed = "customer.subscription.resumed";

        /// <summary>
        /// The "customer.subscription.trial_will_end" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-customer.subscription.trial_will_end
        /// for details.
        /// </summary>
        public const string CustomerSubscriptionTrialWillEnd = "customer.subscription.trial_will_end";

        /// <summary>
        /// The "customer.subscription.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-customer.subscription.updated for
        /// details.
        /// </summary>
        public const string CustomerSubscriptionUpdated = "customer.subscription.updated";

        /// <summary>
        /// The "customer.tax_id.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-customer.tax_id.created for
        /// details.
        /// </summary>
        public const string CustomerTaxIdCreated = "customer.tax_id.created";

        /// <summary>
        /// The "customer.tax_id.deleted" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-customer.tax_id.deleted for
        /// details.
        /// </summary>
        public const string CustomerTaxIdDeleted = "customer.tax_id.deleted";

        /// <summary>
        /// The "customer.tax_id.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-customer.tax_id.updated for
        /// details.
        /// </summary>
        public const string CustomerTaxIdUpdated = "customer.tax_id.updated";

        /// <summary>
        /// The "customer.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-customer.updated for details.
        /// </summary>
        public const string CustomerUpdated = "customer.updated";

        /// <summary>
        /// The "file.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-file.created for details.
        /// </summary>
        public const string FileCreated = "file.created";

        /// <summary>
        /// The "financial_connections.account.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-financial_connections.account.created
        /// for details.
        /// </summary>
        public const string FinancialConnectionsAccountCreated = "financial_connections.account.created";

        /// <summary>
        /// The "financial_connections.account.deactivated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-financial_connections.account.deactivated
        /// for details.
        /// </summary>
        public const string FinancialConnectionsAccountDeactivated = "financial_connections.account.deactivated";

        /// <summary>
        /// The "financial_connections.account.disconnected" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-financial_connections.account.disconnected
        /// for details.
        /// </summary>
        public const string FinancialConnectionsAccountDisconnected = "financial_connections.account.disconnected";

        /// <summary>
        /// The "financial_connections.account.reactivated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-financial_connections.account.reactivated
        /// for details.
        /// </summary>
        public const string FinancialConnectionsAccountReactivated = "financial_connections.account.reactivated";

        /// <summary>
        /// The "financial_connections.account.refreshed_balance" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-financial_connections.account.refreshed_balance
        /// for details.
        /// </summary>
        public const string FinancialConnectionsAccountRefreshedBalance = "financial_connections.account.refreshed_balance";

        /// <summary>
        /// The "identity.verification_session.canceled" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-identity.verification_session.canceled
        /// for details.
        /// </summary>
        public const string IdentityVerificationSessionCanceled = "identity.verification_session.canceled";

        /// <summary>
        /// The "identity.verification_session.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-identity.verification_session.created
        /// for details.
        /// </summary>
        public const string IdentityVerificationSessionCreated = "identity.verification_session.created";

        /// <summary>
        /// The "identity.verification_session.processing" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-identity.verification_session.processing
        /// for details.
        /// </summary>
        public const string IdentityVerificationSessionProcessing = "identity.verification_session.processing";

        /// <summary>
        /// The "identity.verification_session.redacted" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-identity.verification_session.redacted
        /// for details.
        /// </summary>
        public const string IdentityVerificationSessionRedacted = "identity.verification_session.redacted";

        /// <summary>
        /// The "identity.verification_session.requires_input" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-identity.verification_session.requires_input
        /// for details.
        /// </summary>
        public const string IdentityVerificationSessionRequiresInput = "identity.verification_session.requires_input";

        /// <summary>
        /// The "identity.verification_session.verified" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-identity.verification_session.verified
        /// for details.
        /// </summary>
        public const string IdentityVerificationSessionVerified = "identity.verification_session.verified";

        /// <summary>
        /// The "invoice.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-invoice.created for details.
        /// </summary>
        public const string InvoiceCreated = "invoice.created";

        /// <summary>
        /// The "invoice.deleted" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-invoice.deleted for details.
        /// </summary>
        public const string InvoiceDeleted = "invoice.deleted";

        /// <summary>
        /// The "invoice.finalization_error" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-invoice.finalization_error for
        /// details.
        /// </summary>
        [Obsolete("This event is part of a beta or deprecated API and will be removed.")]
        public const string InvoiceFinalizationError = "invoice.finalization_error";

        /// <summary>
        /// The "invoice.finalization_failed" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-invoice.finalization_failed for
        /// details.
        /// </summary>
        public const string InvoiceFinalizationFailed = "invoice.finalization_failed";

        /// <summary>
        /// The "invoice.finalized" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-invoice.finalized for details.
        /// </summary>
        public const string InvoiceFinalized = "invoice.finalized";

        /// <summary>
        /// The "invoice.marked_uncollectible" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-invoice.marked_uncollectible for
        /// details.
        /// </summary>
        public const string InvoiceMarkedUncollectible = "invoice.marked_uncollectible";

        /// <summary>
        /// The "invoice.paid" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-invoice.paid for details.
        /// </summary>
        public const string InvoicePaid = "invoice.paid";

        /// <summary>
        /// The "invoice.payment_action_required" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-invoice.payment_action_required for
        /// details.
        /// </summary>
        public const string InvoicePaymentActionRequired = "invoice.payment_action_required";

        /// <summary>
        /// The "invoice.payment_failed" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-invoice.payment_failed for details.
        /// </summary>
        public const string InvoicePaymentFailed = "invoice.payment_failed";

        /// <summary>
        /// The "invoice.payment_succeeded" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-invoice.payment_succeeded for
        /// details.
        /// </summary>
        public const string InvoicePaymentSucceeded = "invoice.payment_succeeded";

        /// <summary>
        /// The "invoice.sent" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-invoice.sent for details.
        /// </summary>
        public const string InvoiceSent = "invoice.sent";

        /// <summary>
        /// The "invoice.upcoming" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-invoice.upcoming for details.
        /// </summary>
        public const string InvoiceUpcoming = "invoice.upcoming";

        /// <summary>
        /// The "invoice.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-invoice.updated for details.
        /// </summary>
        public const string InvoiceUpdated = "invoice.updated";

        /// <summary>
        /// The "invoice.voided" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-invoice.voided for details.
        /// </summary>
        public const string InvoiceVoided = "invoice.voided";

        /// <summary>
        /// The "invoiceitem.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-invoiceitem.created for details.
        /// </summary>
        public const string InvoiceItemCreated = "invoiceitem.created";

        /// <summary>
        /// The "invoiceitem.deleted" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-invoiceitem.deleted for details.
        /// </summary>
        public const string InvoiceItemDeleted = "invoiceitem.deleted";

        /// <summary>
        /// The "invoiceitem.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-invoiceitem.updated for details.
        /// </summary>
        public const string InvoiceItemUpdated = "invoiceitem.updated";

        /// <summary>
        /// The "issuing_authorization.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-issuing_authorization.created for
        /// details.
        /// </summary>
        public const string IssuingAuthorizationCreated = "issuing_authorization.created";

        /// <summary>
        /// The "issuing_authorization.request" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-issuing_authorization.request for
        /// details.
        /// </summary>
        public const string IssuingAuthorizationRequest = "issuing_authorization.request";

        /// <summary>
        /// The "issuing_authorization.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-issuing_authorization.updated for
        /// details.
        /// </summary>
        public const string IssuingAuthorizationUpdated = "issuing_authorization.updated";

        /// <summary>
        /// The "issuing_card.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-issuing_card.created for details.
        /// </summary>
        public const string IssuingCardCreated = "issuing_card.created";

        /// <summary>
        /// The "issuing_card.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-issuing_card.updated for details.
        /// </summary>
        public const string IssuingCardUpdated = "issuing_card.updated";

        /// <summary>
        /// The "issuing_cardholder.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-issuing_cardholder.created for
        /// details.
        /// </summary>
        public const string IssuingCardholderCreated = "issuing_cardholder.created";

        /// <summary>
        /// The "issuing_cardholder.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-issuing_cardholder.updated for
        /// details.
        /// </summary>
        public const string IssuingCardholderUpdated = "issuing_cardholder.updated";

        /// <summary>
        /// The "issuing_dispute.closed" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-issuing_dispute.closed for details.
        /// </summary>
        public const string IssuingDisputeClosed = "issuing_dispute.closed";

        /// <summary>
        /// The "issuing_dispute.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-issuing_dispute.created for
        /// details.
        /// </summary>
        public const string IssuingDisputeCreated = "issuing_dispute.created";

        /// <summary>
        /// The "issuing_dispute.funds_reinstated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-issuing_dispute.funds_reinstated
        /// for details.
        /// </summary>
        public const string IssuingDisputeFundsReinstated = "issuing_dispute.funds_reinstated";

        /// <summary>
        /// The "issuing_dispute.submitted" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-issuing_dispute.submitted for
        /// details.
        /// </summary>
        public const string IssuingDisputeSubmitted = "issuing_dispute.submitted";

        /// <summary>
        /// The "issuing_dispute.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-issuing_dispute.updated for
        /// details.
        /// </summary>
        public const string IssuingDisputeUpdated = "issuing_dispute.updated";

        /// <summary>
        /// The "issuing_transaction.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-issuing_transaction.created for
        /// details.
        /// </summary>
        public const string IssuingTransactionCreated = "issuing_transaction.created";

        /// <summary>
        /// The "issuing_transaction.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-issuing_transaction.updated for
        /// details.
        /// </summary>
        public const string IssuingTransactionUpdated = "issuing_transaction.updated";

        /// <summary>
        /// The "mandate.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-mandate.updated for details.
        /// </summary>
        public const string MandateUpdated = "mandate.updated";

        /// <summary>
        /// The "order.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-order.created for details.
        /// </summary>
        public const string OrderCreated = "order.created";

        /// <summary>
        /// The "order.payment_failed" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-order.payment_failed for details.
        /// </summary>
        [Obsolete("This event is part of a beta or deprecated API and will be removed.")]
        public const string OrderPaymentFailed = "order.payment_failed";

        /// <summary>
        /// The "payment_intent.amount_capturable_updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-payment_intent.amount_capturable_updated
        /// for details.
        /// </summary>
        public const string PaymentIntentAmountCapturableUpdated = "payment_intent.amount_capturable_updated";

        /// <summary>
        /// The "payment_intent.canceled" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-payment_intent.canceled for
        /// details.
        /// </summary>
        public const string PaymentIntentCanceled = "payment_intent.canceled";

        /// <summary>
        /// The "payment_intent.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-payment_intent.created for details.
        /// </summary>
        public const string PaymentIntentCreated = "payment_intent.created";

        /// <summary>
        /// The "payment_intent.partially_funded" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-payment_intent.partially_funded for
        /// details.
        /// </summary>
        public const string PaymentIntentPartiallyFunded = "payment_intent.partially_funded";

        /// <summary>
        /// The "payment_intent.payment_failed" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-payment_intent.payment_failed for
        /// details.
        /// </summary>
        public const string PaymentIntentPaymentFailed = "payment_intent.payment_failed";

        /// <summary>
        /// The "payment_intent.processing" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-payment_intent.processing for
        /// details.
        /// </summary>
        public const string PaymentIntentProcessing = "payment_intent.processing";

        /// <summary>
        /// The "payment_intent.requires_action" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-payment_intent.requires_action for
        /// details.
        /// </summary>
        public const string PaymentIntentRequiresAction = "payment_intent.requires_action";

        /// <summary>
        /// The "payment_intent.succeeded" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-payment_intent.succeeded for
        /// details.
        /// </summary>
        public const string PaymentIntentSucceeded = "payment_intent.succeeded";

        /// <summary>
        /// The "payment_link.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-payment_link.created for details.
        /// </summary>
        public const string PaymentLinkCreated = "payment_link.created";

        /// <summary>
        /// The "payment_link.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-payment_link.updated for details.
        /// </summary>
        public const string PaymentLinkUpdated = "payment_link.updated";

        /// <summary>
        /// The "payment_method.attached" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-payment_method.attached for
        /// details.
        /// </summary>
        public const string PaymentMethodAttached = "payment_method.attached";

        /// <summary>
        /// The "payment_method.automatically_updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-payment_method.automatically_updated
        /// for details.
        /// </summary>
        public const string PaymentMethodAutomaticallyUpdated = "payment_method.automatically_updated";

        /// <summary>
        /// The "payment_method.card_automatically_updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-payment_method.card_automatically_updated
        /// for details.
        /// </summary>
        [Obsolete("Use PaymentMethodAutomaticallyUpdated instead.")]
        public const string PaymentMethodCardAutomaticallyUpdated = "payment_method.card_automatically_updated";

        /// <summary>
        /// The "payment_method.detached" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-payment_method.detached for
        /// details.
        /// </summary>
        public const string PaymentMethodDetached = "payment_method.detached";

        /// <summary>
        /// The "payment_method.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-payment_method.updated for details.
        /// </summary>
        public const string PaymentMethodUpdated = "payment_method.updated";

        /// <summary>
        /// The "payment.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-payment.created for details.
        /// </summary>
        public const string PaymentCreated = "payment.created";

        /// <summary>
        /// The "payout.canceled" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-payout.canceled for details.
        /// </summary>
        public const string PayoutCanceled = "payout.canceled";

        /// <summary>
        /// The "payout.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-payout.created for details.
        /// </summary>
        public const string PayoutCreated = "payout.created";

        /// <summary>
        /// The "payout.failed" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-payout.failed for details.
        /// </summary>
        public const string PayoutFailed = "payout.failed";

        /// <summary>
        /// The "payout.paid" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-payout.paid for details.
        /// </summary>
        public const string PayoutPaid = "payout.paid";

        /// <summary>
        /// The "payout.reconciliation_completed" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-payout.reconciliation_completed for
        /// details.
        /// </summary>
        public const string PayoutReconciliationCompleted = "payout.reconciliation_completed";

        /// <summary>
        /// The "payout.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-payout.updated for details.
        /// </summary>
        public const string PayoutUpdated = "payout.updated";

        /// <summary>
        /// The "person.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-person.created for details.
        /// </summary>
        public const string PersonCreated = "person.created";

        /// <summary>
        /// The "person.deleted" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-person.deleted for details.
        /// </summary>
        public const string PersonDeleted = "person.deleted";

        /// <summary>
        /// The "person.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-person.updated for details.
        /// </summary>
        public const string PersonUpdated = "person.updated";

        /// <summary>
        /// The "ping" event type. See https://stripe.com/docs/api/events/types#event_types-ping for
        /// details.
        /// </summary>
        public const string Ping = "ping";

        /// <summary>
        /// The "plan.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-plan.created for details.
        /// </summary>
        public const string PlanCreated = "plan.created";

        /// <summary>
        /// The "plan.deleted" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-plan.deleted for details.
        /// </summary>
        public const string PlanDeleted = "plan.deleted";

        /// <summary>
        /// The "plan.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-plan.updated for details.
        /// </summary>
        public const string PlanUpdated = "plan.updated";

        /// <summary>
        /// The "price.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-price.created for details.
        /// </summary>
        public const string PriceCreated = "price.created";

        /// <summary>
        /// The "price.deleted" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-price.deleted for details.
        /// </summary>
        public const string PriceDeleted = "price.deleted";

        /// <summary>
        /// The "price.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-price.updated for details.
        /// </summary>
        public const string PriceUpdated = "price.updated";

        /// <summary>
        /// The "product.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-product.created for details.
        /// </summary>
        public const string ProductCreated = "product.created";

        /// <summary>
        /// The "product.deleted" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-product.deleted for details.
        /// </summary>
        public const string ProductDeleted = "product.deleted";

        /// <summary>
        /// The "product.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-product.updated for details.
        /// </summary>
        public const string ProductUpdated = "product.updated";

        /// <summary>
        /// The "promotion_code.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-promotion_code.created for details.
        /// </summary>
        public const string PromotionCodeCreated = "promotion_code.created";

        /// <summary>
        /// The "promotion_code.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-promotion_code.updated for details.
        /// </summary>
        public const string PromotionCodeUpdated = "promotion_code.updated";

        /// <summary>
        /// The "quote.accepted" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-quote.accepted for details.
        /// </summary>
        public const string QuoteAccepted = "quote.accepted";

        /// <summary>
        /// The "quote.canceled" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-quote.canceled for details.
        /// </summary>
        public const string QuoteCanceled = "quote.canceled";

        /// <summary>
        /// The "quote.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-quote.created for details.
        /// </summary>
        public const string QuoteCreated = "quote.created";

        /// <summary>
        /// The "quote.finalized" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-quote.finalized for details.
        /// </summary>
        public const string QuoteFinalized = "quote.finalized";

        /// <summary>
        /// The "radar.early_fraud_warning.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-radar.early_fraud_warning.created
        /// for details.
        /// </summary>
        public const string RadarEarlyFraudWarningCreated = "radar.early_fraud_warning.created";

        /// <summary>
        /// The "radar.early_fraud_warning.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-radar.early_fraud_warning.updated
        /// for details.
        /// </summary>
        public const string RadarEarlyFraudWarningUpdated = "radar.early_fraud_warning.updated";

        /// <summary>
        /// The "recipient.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-recipient.created for details.
        /// </summary>
        public const string RecipientCreated = "recipient.created";

        /// <summary>
        /// The "recipient.deleted" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-recipient.deleted for details.
        /// </summary>
        public const string RecipientDeleted = "recipient.deleted";

        /// <summary>
        /// The "recipient.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-recipient.updated for details.
        /// </summary>
        public const string RecipientUpdated = "recipient.updated";

        /// <summary>
        /// The "refund.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-refund.created for details.
        /// </summary>
        public const string RefundCreated = "refund.created";

        /// <summary>
        /// The "refund.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-refund.updated for details.
        /// </summary>
        public const string RefundUpdated = "refund.updated";

        /// <summary>
        /// The "reporting.report_run.failed" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-reporting.report_run.failed for
        /// details.
        /// </summary>
        public const string ReportingReportRunFailed = "reporting.report_run.failed";

        /// <summary>
        /// The "reporting.report_run.succeeded" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-reporting.report_run.succeeded for
        /// details.
        /// </summary>
        public const string ReportingReportRunSucceeded = "reporting.report_run.succeeded";

        /// <summary>
        /// The "reporting.report_type.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-reporting.report_type.updated for
        /// details.
        /// </summary>
        public const string ReportingReportTypeUpdated = "reporting.report_type.updated";

        /// <summary>
        /// The "review.closed" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-review.closed for details.
        /// </summary>
        public const string ReviewClosed = "review.closed";

        /// <summary>
        /// The "review.opened" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-review.opened for details.
        /// </summary>
        public const string ReviewOpened = "review.opened";

        /// <summary>
        /// The "setup_intent.canceled" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-setup_intent.canceled for details.
        /// </summary>
        public const string SetupIntentCanceled = "setup_intent.canceled";

        /// <summary>
        /// The "setup_intent.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-setup_intent.created for details.
        /// </summary>
        public const string SetupIntentCreated = "setup_intent.created";

        /// <summary>
        /// The "setup_intent.requires_action" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-setup_intent.requires_action for
        /// details.
        /// </summary>
        public const string SetupIntentRequiresAction = "setup_intent.requires_action";

        /// <summary>
        /// The "setup_intent.setup_failed" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-setup_intent.setup_failed for
        /// details.
        /// </summary>
        public const string SetupIntentSetupFailed = "setup_intent.setup_failed";

        /// <summary>
        /// The "setup_intent.succeeded" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-setup_intent.succeeded for details.
        /// </summary>
        public const string SetupIntentSucceeded = "setup_intent.succeeded";

        /// <summary>
        /// The "sigma.scheduled_query_run.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-sigma.scheduled_query_run.created
        /// for details.
        /// </summary>
        [Obsolete("This event is part of a beta or deprecated API and will be removed.")]
        public const string SigmaScheduleQueryRunCreated = "sigma.scheduled_query_run.created";

        /// <summary>
        /// The "sku.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-sku.created for details.
        /// </summary>
        public const string SkuCreated = "sku.created";

        /// <summary>
        /// The "sku.deleted" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-sku.deleted for details.
        /// </summary>
        public const string SkuDeleted = "sku.deleted";

        /// <summary>
        /// The "sku.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-sku.updated for details.
        /// </summary>
        public const string SkuUpdated = "sku.updated";

        /// <summary>
        /// The "source.canceled" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-source.canceled for details.
        /// </summary>
        public const string SourceCanceled = "source.canceled";

        /// <summary>
        /// The "source.chargeable" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-source.chargeable for details.
        /// </summary>
        public const string SourceChargeable = "source.chargeable";

        /// <summary>
        /// The "source.failed" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-source.failed for details.
        /// </summary>
        public const string SourceFailed = "source.failed";

        /// <summary>
        /// The "source.mandate_notification" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-source.mandate_notification for
        /// details.
        /// </summary>
        public const string SourceMandateNotification = "source.mandate_notification";

        /// <summary>
        /// The "source.refund_attributes_required" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-source.refund_attributes_required
        /// for details.
        /// </summary>
        public const string SourceRefundAttributesRequired = "source.refund_attributes_required";

        /// <summary>
        /// The "source.transaction.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-source.transaction.created for
        /// details.
        /// </summary>
        public const string SourceTransactionCreated = "source.transaction.created";

        /// <summary>
        /// The "source.transaction.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-source.transaction.updated for
        /// details.
        /// </summary>
        public const string SourceTransactionUpdated = "source.transaction.updated";

        /// <summary>
        /// The "subscription_schedule.aborted" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-subscription_schedule.aborted for
        /// details.
        /// </summary>
        public const string SubscriptionScheduleAborted = "subscription_schedule.aborted";

        /// <summary>
        /// The "subscription_schedule.canceled" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-subscription_schedule.canceled for
        /// details.
        /// </summary>
        public const string SubscriptionScheduleCanceled = "subscription_schedule.canceled";

        /// <summary>
        /// The "subscription_schedule.completed" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-subscription_schedule.completed for
        /// details.
        /// </summary>
        public const string SubscriptionScheduleCompleted = "subscription_schedule.completed";

        /// <summary>
        /// The "subscription_schedule.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-subscription_schedule.created for
        /// details.
        /// </summary>
        public const string SubscriptionScheduleCreated = "subscription_schedule.created";

        /// <summary>
        /// The "subscription_schedule.expiring" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-subscription_schedule.expiring for
        /// details.
        /// </summary>
        public const string SubscriptionScheduleExpiring = "subscription_schedule.expiring";

        /// <summary>
        /// The "subscription_schedule.released" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-subscription_schedule.released for
        /// details.
        /// </summary>
        public const string SubscriptionScheduleReleased = "subscription_schedule.released";

        /// <summary>
        /// The "subscription_schedule.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-subscription_schedule.updated for
        /// details.
        /// </summary>
        public const string SubscriptionScheduleUpdated = "subscription_schedule.updated";

        /// <summary>
        /// The "tax_rate.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-tax_rate.created for details.
        /// </summary>
        public const string TaxRateCreated = "tax_rate.created";

        /// <summary>
        /// The "tax_rate.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-tax_rate.updated for details.
        /// </summary>
        public const string TaxRateUpdated = "tax_rate.updated";

        /// <summary>
        /// The "tax.settings.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-tax.settings.updated for details.
        /// </summary>
        public const string TaxSettingsUpdated = "tax.settings.updated";

        /// <summary>
        /// The "terminal.reader.action_failed" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-terminal.reader.action_failed for
        /// details.
        /// </summary>
        public const string TerminalReaderActionFailed = "terminal.reader.action_failed";

        /// <summary>
        /// The "terminal.reader.action_succeeded" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-terminal.reader.action_succeeded
        /// for details.
        /// </summary>
        public const string TerminalReaderActionSucceeded = "terminal.reader.action_succeeded";

        /// <summary>
        /// The "test_helpers.test_clock.advancing" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-test_helpers.test_clock.advancing
        /// for details.
        /// </summary>
        public const string TestHelpersTestClockAdvancing = "test_helpers.test_clock.advancing";

        /// <summary>
        /// The "test_helpers.test_clock.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-test_helpers.test_clock.created for
        /// details.
        /// </summary>
        public const string TestHelpersTestClockCreated = "test_helpers.test_clock.created";

        /// <summary>
        /// The "test_helpers.test_clock.deleted" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-test_helpers.test_clock.deleted for
        /// details.
        /// </summary>
        public const string TestHelpersTestClockDeleted = "test_helpers.test_clock.deleted";

        /// <summary>
        /// The "test_helpers.test_clock.internal_failure" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-test_helpers.test_clock.internal_failure
        /// for details.
        /// </summary>
        public const string TestHelpersTestClockInternalFailure = "test_helpers.test_clock.internal_failure";

        /// <summary>
        /// The "test_helpers.test_clock.ready" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-test_helpers.test_clock.ready for
        /// details.
        /// </summary>
        public const string TestHelpersTestClockReady = "test_helpers.test_clock.ready";

        /// <summary>
        /// The "topup.canceled" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-topup.canceled for details.
        /// </summary>
        public const string TopupCanceled = "topup.canceled";

        /// <summary>
        /// The "topup.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-topup.created for details.
        /// </summary>
        public const string TopupCreated = "topup.created";

        /// <summary>
        /// The "topup.failed" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-topup.failed for details.
        /// </summary>
        public const string TopupFailed = "topup.failed";

        /// <summary>
        /// The "topup.reversed" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-topup.reversed for details.
        /// </summary>
        public const string TopupReversed = "topup.reversed";

        /// <summary>
        /// The "topup.succeeded" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-topup.succeeded for details.
        /// </summary>
        public const string TopupSucceeded = "topup.succeeded";

        /// <summary>
        /// The "transfer.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-transfer.created for details.
        /// </summary>
        public const string TransferCreated = "transfer.created";

        /// <summary>
        /// The "transfer.reversed" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-transfer.reversed for details.
        /// </summary>
        public const string TransferReversed = "transfer.reversed";

        /// <summary>
        /// The "transfer.updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-transfer.updated for details.
        /// </summary>
        public const string TransferUpdated = "transfer.updated";

        /// <summary>
        /// The "treasury.check_deposit.canceled" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.check_deposit.canceled for
        /// details.
        /// </summary>
        [Obsolete("This event is part of a beta or deprecated API and will be removed.")]
        public const string TreasuryCheckDepositCanceled = "treasury.check_deposit.canceled";

        /// <summary>
        /// The "treasury.check_deposit.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.check_deposit.created for
        /// details.
        /// </summary>
        [Obsolete("This event is part of a beta or deprecated API and will be removed.")]
        public const string TreasuryCheckDepositCreated = "treasury.check_deposit.created";

        /// <summary>
        /// The "treasury.check_deposit.processing" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.check_deposit.processing
        /// for details.
        /// </summary>
        [Obsolete("This event is part of a beta or deprecated API and will be removed.")]
        public const string TreasuryCheckDepositProcessing = "treasury.check_deposit.processing";

        /// <summary>
        /// The "treasury.check_deposit.received" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.check_deposit.received for
        /// details.
        /// </summary>
        [Obsolete("This event is part of a beta or deprecated API and will be removed.")]
        public const string TreasuryCheckDepositReceived = "treasury.check_deposit.received";

        /// <summary>
        /// The "treasury.check_deposit.requires_action" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.check_deposit.requires_action
        /// for details.
        /// </summary>
        [Obsolete("This event is part of a beta or deprecated API and will be removed.")]
        public const string TreasuryCheckDepositRequiresAction = "treasury.check_deposit.requires_action";

        /// <summary>
        /// The "treasury.check_deposit.requires_confirmation" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.check_deposit.requires_confirmation
        /// for details.
        /// </summary>
        [Obsolete("This event is part of a beta or deprecated API and will be removed.")]
        public const string TreasuryCheckDepositRequiresConfirmation = "treasury.check_deposit.requires_confirmation";

        /// <summary>
        /// The "treasury.check_deposit.reversed" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.check_deposit.reversed for
        /// details.
        /// </summary>
        [Obsolete("This event is part of a beta or deprecated API and will be removed.")]
        public const string TreasuryCheckDepositReversed = "treasury.check_deposit.reversed";

        /// <summary>
        /// The "treasury.credit_reversal.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.credit_reversal.created
        /// for details.
        /// </summary>
        public const string TreasuryCreditReversalCreated = "treasury.credit_reversal.created";

        /// <summary>
        /// The "treasury.credit_reversal.posted" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.credit_reversal.posted for
        /// details.
        /// </summary>
        public const string TreasuryCreditReversalPosted = "treasury.credit_reversal.posted";

        /// <summary>
        /// The "treasury.debit_reversal.completed" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.debit_reversal.completed
        /// for details.
        /// </summary>
        public const string TreasuryDebitReversalCompleted = "treasury.debit_reversal.completed";

        /// <summary>
        /// The "treasury.debit_reversal.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.debit_reversal.created for
        /// details.
        /// </summary>
        public const string TreasuryDebitReversalCreated = "treasury.debit_reversal.created";

        /// <summary>
        /// The "treasury.debit_reversal.initial_credit_granted" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.debit_reversal.initial_credit_granted
        /// for details.
        /// </summary>
        public const string TreasuryDebitReversalInitialCreditGranted = "treasury.debit_reversal.initial_credit_granted";

        /// <summary>
        /// The "treasury.financial_account.closed" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.financial_account.closed
        /// for details.
        /// </summary>
        public const string TreasuryFinancialAccountClosed = "treasury.financial_account.closed";

        /// <summary>
        /// The "treasury.financial_account.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.financial_account.created
        /// for details.
        /// </summary>
        public const string TreasuryFinancialAccountCreated = "treasury.financial_account.created";

        /// <summary>
        /// The "treasury.financial_account.features_status_updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.financial_account.features_status_updated
        /// for details.
        /// </summary>
        public const string TreasuryFinancialAccountFeaturesStatusUpdated = "treasury.financial_account.features_status_updated";

        /// <summary>
        /// The "treasury.inbound_transfer.canceled" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.inbound_transfer.canceled
        /// for details.
        /// </summary>
        public const string TreasuryInboundTransferCanceled = "treasury.inbound_transfer.canceled";

        /// <summary>
        /// The "treasury.inbound_transfer.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.inbound_transfer.created
        /// for details.
        /// </summary>
        public const string TreasuryInboundTransferCreated = "treasury.inbound_transfer.created";

        /// <summary>
        /// The "treasury.inbound_transfer.failed" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.inbound_transfer.failed
        /// for details.
        /// </summary>
        public const string TreasuryInboundTransferFailed = "treasury.inbound_transfer.failed";

        /// <summary>
        /// The "treasury.inbound_transfer.succeeded" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.inbound_transfer.succeeded
        /// for details.
        /// </summary>
        public const string TreasuryInboundTransferSucceeded = "treasury.inbound_transfer.succeeded";

        /// <summary>
        /// The "treasury.outbound_payment.canceled" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.outbound_payment.canceled
        /// for details.
        /// </summary>
        public const string TreasuryOutboundPaymentCanceled = "treasury.outbound_payment.canceled";

        /// <summary>
        /// The "treasury.outbound_payment.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.outbound_payment.created
        /// for details.
        /// </summary>
        public const string TreasuryOutboundPaymentCreated = "treasury.outbound_payment.created";

        /// <summary>
        /// The "treasury.outbound_payment.expected_arrival_date_updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.outbound_payment.expected_arrival_date_updated
        /// for details.
        /// </summary>
        public const string TreasuryOutboundPaymentExpectedArrivalDateUpdated = "treasury.outbound_payment.expected_arrival_date_updated";

        /// <summary>
        /// The "treasury.outbound_payment.failed" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.outbound_payment.failed
        /// for details.
        /// </summary>
        public const string TreasuryOutboundPaymentFailed = "treasury.outbound_payment.failed";

        /// <summary>
        /// The "treasury.outbound_payment.posted" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.outbound_payment.posted
        /// for details.
        /// </summary>
        public const string TreasuryOutboundPaymentPosted = "treasury.outbound_payment.posted";

        /// <summary>
        /// The "treasury.outbound_payment.returned" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.outbound_payment.returned
        /// for details.
        /// </summary>
        public const string TreasuryOutboundPaymentReturned = "treasury.outbound_payment.returned";

        /// <summary>
        /// The "treasury.outbound_transfer.canceled" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.outbound_transfer.canceled
        /// for details.
        /// </summary>
        public const string TreasuryOutboundTransferCanceled = "treasury.outbound_transfer.canceled";

        /// <summary>
        /// The "treasury.outbound_transfer.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.outbound_transfer.created
        /// for details.
        /// </summary>
        public const string TreasuryOutboundTransferCreated = "treasury.outbound_transfer.created";

        /// <summary>
        /// The "treasury.outbound_transfer.expected_arrival_date_updated" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.outbound_transfer.expected_arrival_date_updated
        /// for details.
        /// </summary>
        public const string TreasuryOutboundTransferExpectedArrivalDateUpdated = "treasury.outbound_transfer.expected_arrival_date_updated";

        /// <summary>
        /// The "treasury.outbound_transfer.failed" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.outbound_transfer.failed
        /// for details.
        /// </summary>
        public const string TreasuryOutboundTransferFailed = "treasury.outbound_transfer.failed";

        /// <summary>
        /// The "treasury.outbound_transfer.posted" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.outbound_transfer.posted
        /// for details.
        /// </summary>
        public const string TreasuryOutboundTransferPosted = "treasury.outbound_transfer.posted";

        /// <summary>
        /// The "treasury.outbound_transfer.returned" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.outbound_transfer.returned
        /// for details.
        /// </summary>
        public const string TreasuryOutboundTransferReturned = "treasury.outbound_transfer.returned";

        /// <summary>
        /// The "treasury.received_credit.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.received_credit.created
        /// for details.
        /// </summary>
        public const string TreasuryReceivedCreditCreated = "treasury.received_credit.created";

        /// <summary>
        /// The "treasury.received_credit.failed" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.received_credit.failed for
        /// details.
        /// </summary>
        public const string TreasuryReceivedCreditFailed = "treasury.received_credit.failed";

        /// <summary>
        /// The "treasury.received_credit.reversed" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.received_credit.reversed
        /// for details.
        /// </summary>
        [Obsolete("This event is part of a beta or deprecated API and will be removed.")]
        public const string TreasuryReceivedCreditReversed = "treasury.received_credit.reversed";

        /// <summary>
        /// The "treasury.received_credit.succeeded" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.received_credit.succeeded
        /// for details.
        /// </summary>
        public const string TreasuryReceivedCreditSucceeded = "treasury.received_credit.succeeded";

        /// <summary>
        /// The "treasury.received_debit.created" event type. See
        /// https://stripe.com/docs/api/events/types#event_types-treasury.received_debit.created for
        /// details.
        /// </summary>
        public const string TreasuryReceivedDebitCreated = "treasury.received_debit.created";
    }
}