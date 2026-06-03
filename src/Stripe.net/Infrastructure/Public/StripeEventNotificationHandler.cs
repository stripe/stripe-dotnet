// File copied from our code generator; changes here will be overwritten.
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Stripe.Events;

    /// <summary>
    /// A handler for Stripe webhook events that uses the .NET event handler pattern.
    /// Allows registration of strongly-typed event handlers for specific EventNotification types.
    /// </summary>
    public class StripeEventNotificationHandler
    {
        private readonly StripeClient client;
        private readonly string webhookSecret;
        private readonly HashSet<string> handledEventTypes = new HashSet<string>();
        private readonly StripeClientOptions clientOptions;

        // A private EventHandler for each EventNotification. We'll route notifications to the correct handler.
        // private-event-handlers: The beginning of the section generated from our OpenAPI spec
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1AccountApplicationAuthorizedEventNotification>> v1AccountApplicationAuthorized;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1AccountApplicationDeauthorizedEventNotification>> v1AccountApplicationDeauthorized;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1AccountExternalAccountCreatedEventNotification>> v1AccountExternalAccountCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1AccountExternalAccountDeletedEventNotification>> v1AccountExternalAccountDeleted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1AccountExternalAccountUpdatedEventNotification>> v1AccountExternalAccountUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1AccountUpdatedEventNotification>> v1AccountUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1AccountSignalsIncludingDelinquencyCreatedEventNotification>> v1AccountSignalsIncludingDelinquencyCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ApplicationFeeCreatedEventNotification>> v1ApplicationFeeCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ApplicationFeeRefundUpdatedEventNotification>> v1ApplicationFeeRefundUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ApplicationFeeRefundedEventNotification>> v1ApplicationFeeRefunded;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BalanceAvailableEventNotification>> v1BalanceAvailable;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingAlertTriggeredEventNotification>> v1BillingAlertTriggered;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterErrorReportTriggeredEventNotification>> v1BillingMeterErrorReportTriggered;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterNoMeterFoundEventNotification>> v1BillingMeterNoMeterFound;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingPortalConfigurationCreatedEventNotification>> v1BillingPortalConfigurationCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingPortalConfigurationUpdatedEventNotification>> v1BillingPortalConfigurationUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingPortalSessionCreatedEventNotification>> v1BillingPortalSessionCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CapabilityUpdatedEventNotification>> v1CapabilityUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CashBalanceFundsAvailableEventNotification>> v1CashBalanceFundsAvailable;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ChargeCapturedEventNotification>> v1ChargeCaptured;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ChargeDisputeClosedEventNotification>> v1ChargeDisputeClosed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ChargeDisputeCreatedEventNotification>> v1ChargeDisputeCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ChargeDisputeFundsReinstatedEventNotification>> v1ChargeDisputeFundsReinstated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ChargeDisputeFundsWithdrawnEventNotification>> v1ChargeDisputeFundsWithdrawn;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ChargeDisputeUpdatedEventNotification>> v1ChargeDisputeUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ChargeExpiredEventNotification>> v1ChargeExpired;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ChargeFailedEventNotification>> v1ChargeFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ChargePendingEventNotification>> v1ChargePending;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ChargeRefundUpdatedEventNotification>> v1ChargeRefundUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ChargeRefundedEventNotification>> v1ChargeRefunded;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ChargeSucceededEventNotification>> v1ChargeSucceeded;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ChargeUpdatedEventNotification>> v1ChargeUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CheckoutSessionAsyncPaymentFailedEventNotification>> v1CheckoutSessionAsyncPaymentFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CheckoutSessionAsyncPaymentSucceededEventNotification>> v1CheckoutSessionAsyncPaymentSucceeded;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CheckoutSessionCompletedEventNotification>> v1CheckoutSessionCompleted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CheckoutSessionExpiredEventNotification>> v1CheckoutSessionExpired;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ClimateOrderCanceledEventNotification>> v1ClimateOrderCanceled;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ClimateOrderCreatedEventNotification>> v1ClimateOrderCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ClimateOrderDelayedEventNotification>> v1ClimateOrderDelayed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ClimateOrderDeliveredEventNotification>> v1ClimateOrderDelivered;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ClimateOrderProductSubstitutedEventNotification>> v1ClimateOrderProductSubstituted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ClimateProductCreatedEventNotification>> v1ClimateProductCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ClimateProductPricingUpdatedEventNotification>> v1ClimateProductPricingUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CouponCreatedEventNotification>> v1CouponCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CouponDeletedEventNotification>> v1CouponDeleted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CouponUpdatedEventNotification>> v1CouponUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CreditNoteCreatedEventNotification>> v1CreditNoteCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CreditNoteUpdatedEventNotification>> v1CreditNoteUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CreditNoteVoidedEventNotification>> v1CreditNoteVoided;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerCreatedEventNotification>> v1CustomerCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerDeletedEventNotification>> v1CustomerDeleted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerSubscriptionCreatedEventNotification>> v1CustomerSubscriptionCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerSubscriptionDeletedEventNotification>> v1CustomerSubscriptionDeleted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerSubscriptionPausedEventNotification>> v1CustomerSubscriptionPaused;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerSubscriptionPendingUpdateAppliedEventNotification>> v1CustomerSubscriptionPendingUpdateApplied;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerSubscriptionPendingUpdateExpiredEventNotification>> v1CustomerSubscriptionPendingUpdateExpired;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerSubscriptionResumedEventNotification>> v1CustomerSubscriptionResumed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerSubscriptionTrialWillEndEventNotification>> v1CustomerSubscriptionTrialWillEnd;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerSubscriptionUpdatedEventNotification>> v1CustomerSubscriptionUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerTaxIdCreatedEventNotification>> v1CustomerTaxIdCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerTaxIdDeletedEventNotification>> v1CustomerTaxIdDeleted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerTaxIdUpdatedEventNotification>> v1CustomerTaxIdUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerUpdatedEventNotification>> v1CustomerUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerCashBalanceTransactionCreatedEventNotification>> v1CustomerCashBalanceTransactionCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1EntitlementsActiveEntitlementSummaryUpdatedEventNotification>> v1EntitlementsActiveEntitlementSummaryUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1FileCreatedEventNotification>> v1FileCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountCreatedEventNotification>> v1FinancialConnectionsAccountCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountDeactivatedEventNotification>> v1FinancialConnectionsAccountDeactivated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountDisconnectedEventNotification>> v1FinancialConnectionsAccountDisconnected;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountReactivatedEventNotification>> v1FinancialConnectionsAccountReactivated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountRefreshedBalanceEventNotification>> v1FinancialConnectionsAccountRefreshedBalance;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountRefreshedOwnershipEventNotification>> v1FinancialConnectionsAccountRefreshedOwnership;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountRefreshedTransactionsEventNotification>> v1FinancialConnectionsAccountRefreshedTransactions;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IdentityVerificationSessionCanceledEventNotification>> v1IdentityVerificationSessionCanceled;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IdentityVerificationSessionCreatedEventNotification>> v1IdentityVerificationSessionCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IdentityVerificationSessionProcessingEventNotification>> v1IdentityVerificationSessionProcessing;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IdentityVerificationSessionRedactedEventNotification>> v1IdentityVerificationSessionRedacted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IdentityVerificationSessionRequiresInputEventNotification>> v1IdentityVerificationSessionRequiresInput;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IdentityVerificationSessionVerifiedEventNotification>> v1IdentityVerificationSessionVerified;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceCreatedEventNotification>> v1InvoiceCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceDeletedEventNotification>> v1InvoiceDeleted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceFinalizationFailedEventNotification>> v1InvoiceFinalizationFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceFinalizedEventNotification>> v1InvoiceFinalized;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceMarkedUncollectibleEventNotification>> v1InvoiceMarkedUncollectible;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceOverdueEventNotification>> v1InvoiceOverdue;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceOverpaidEventNotification>> v1InvoiceOverpaid;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoicePaidEventNotification>> v1InvoicePaid;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoicePaymentActionRequiredEventNotification>> v1InvoicePaymentActionRequired;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoicePaymentFailedEventNotification>> v1InvoicePaymentFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoicePaymentSucceededEventNotification>> v1InvoicePaymentSucceeded;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceSentEventNotification>> v1InvoiceSent;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceUpcomingEventNotification>> v1InvoiceUpcoming;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceUpdatedEventNotification>> v1InvoiceUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceVoidedEventNotification>> v1InvoiceVoided;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceWillBeDueEventNotification>> v1InvoiceWillBeDue;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoicePaymentPaidEventNotification>> v1InvoicePaymentPaid;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceitemCreatedEventNotification>> v1InvoiceitemCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceitemDeletedEventNotification>> v1InvoiceitemDeleted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingAuthorizationCreatedEventNotification>> v1IssuingAuthorizationCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingAuthorizationRequestEventNotification>> v1IssuingAuthorizationRequest;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingAuthorizationUpdatedEventNotification>> v1IssuingAuthorizationUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingCardCreatedEventNotification>> v1IssuingCardCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingCardUpdatedEventNotification>> v1IssuingCardUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingCardholderCreatedEventNotification>> v1IssuingCardholderCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingCardholderUpdatedEventNotification>> v1IssuingCardholderUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingDisputeClosedEventNotification>> v1IssuingDisputeClosed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingDisputeCreatedEventNotification>> v1IssuingDisputeCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingDisputeFundsReinstatedEventNotification>> v1IssuingDisputeFundsReinstated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingDisputeFundsRescindedEventNotification>> v1IssuingDisputeFundsRescinded;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingDisputeSubmittedEventNotification>> v1IssuingDisputeSubmitted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingDisputeUpdatedEventNotification>> v1IssuingDisputeUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingPersonalizationDesignActivatedEventNotification>> v1IssuingPersonalizationDesignActivated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingPersonalizationDesignDeactivatedEventNotification>> v1IssuingPersonalizationDesignDeactivated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingPersonalizationDesignRejectedEventNotification>> v1IssuingPersonalizationDesignRejected;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingPersonalizationDesignUpdatedEventNotification>> v1IssuingPersonalizationDesignUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingTokenCreatedEventNotification>> v1IssuingTokenCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingTokenUpdatedEventNotification>> v1IssuingTokenUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingTransactionCreatedEventNotification>> v1IssuingTransactionCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingTransactionPurchaseDetailsReceiptUpdatedEventNotification>> v1IssuingTransactionPurchaseDetailsReceiptUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingTransactionUpdatedEventNotification>> v1IssuingTransactionUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1MandateUpdatedEventNotification>> v1MandateUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PaymentIntentAmountCapturableUpdatedEventNotification>> v1PaymentIntentAmountCapturableUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PaymentIntentCanceledEventNotification>> v1PaymentIntentCanceled;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PaymentIntentCreatedEventNotification>> v1PaymentIntentCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PaymentIntentPartiallyFundedEventNotification>> v1PaymentIntentPartiallyFunded;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PaymentIntentPaymentFailedEventNotification>> v1PaymentIntentPaymentFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PaymentIntentProcessingEventNotification>> v1PaymentIntentProcessing;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PaymentIntentRequiresActionEventNotification>> v1PaymentIntentRequiresAction;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PaymentIntentSucceededEventNotification>> v1PaymentIntentSucceeded;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PaymentLinkCreatedEventNotification>> v1PaymentLinkCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PaymentLinkUpdatedEventNotification>> v1PaymentLinkUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PaymentMethodAttachedEventNotification>> v1PaymentMethodAttached;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PaymentMethodAutomaticallyUpdatedEventNotification>> v1PaymentMethodAutomaticallyUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PaymentMethodDetachedEventNotification>> v1PaymentMethodDetached;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PaymentMethodUpdatedEventNotification>> v1PaymentMethodUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PayoutCanceledEventNotification>> v1PayoutCanceled;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PayoutCreatedEventNotification>> v1PayoutCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PayoutFailedEventNotification>> v1PayoutFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PayoutPaidEventNotification>> v1PayoutPaid;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PayoutReconciliationCompletedEventNotification>> v1PayoutReconciliationCompleted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PayoutUpdatedEventNotification>> v1PayoutUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PersonCreatedEventNotification>> v1PersonCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PersonDeletedEventNotification>> v1PersonDeleted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PersonUpdatedEventNotification>> v1PersonUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PlanCreatedEventNotification>> v1PlanCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PlanDeletedEventNotification>> v1PlanDeleted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PlanUpdatedEventNotification>> v1PlanUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PriceCreatedEventNotification>> v1PriceCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PriceDeletedEventNotification>> v1PriceDeleted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PriceUpdatedEventNotification>> v1PriceUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ProductCreatedEventNotification>> v1ProductCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ProductDeletedEventNotification>> v1ProductDeleted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ProductUpdatedEventNotification>> v1ProductUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PromotionCodeCreatedEventNotification>> v1PromotionCodeCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PromotionCodeUpdatedEventNotification>> v1PromotionCodeUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1QuoteAcceptedEventNotification>> v1QuoteAccepted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1QuoteCanceledEventNotification>> v1QuoteCanceled;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1QuoteCreatedEventNotification>> v1QuoteCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1QuoteFinalizedEventNotification>> v1QuoteFinalized;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1RadarEarlyFraudWarningCreatedEventNotification>> v1RadarEarlyFraudWarningCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1RadarEarlyFraudWarningUpdatedEventNotification>> v1RadarEarlyFraudWarningUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1RefundCreatedEventNotification>> v1RefundCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1RefundFailedEventNotification>> v1RefundFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1RefundUpdatedEventNotification>> v1RefundUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ReviewClosedEventNotification>> v1ReviewClosed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ReviewOpenedEventNotification>> v1ReviewOpened;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1SetupIntentCanceledEventNotification>> v1SetupIntentCanceled;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1SetupIntentCreatedEventNotification>> v1SetupIntentCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1SetupIntentRequiresActionEventNotification>> v1SetupIntentRequiresAction;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1SetupIntentSetupFailedEventNotification>> v1SetupIntentSetupFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1SetupIntentSucceededEventNotification>> v1SetupIntentSucceeded;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1SigmaScheduledQueryRunCreatedEventNotification>> v1SigmaScheduledQueryRunCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1SourceCanceledEventNotification>> v1SourceCanceled;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1SourceChargeableEventNotification>> v1SourceChargeable;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1SourceFailedEventNotification>> v1SourceFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1SourceRefundAttributesRequiredEventNotification>> v1SourceRefundAttributesRequired;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1SubscriptionScheduleAbortedEventNotification>> v1SubscriptionScheduleAborted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1SubscriptionScheduleCanceledEventNotification>> v1SubscriptionScheduleCanceled;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1SubscriptionScheduleCompletedEventNotification>> v1SubscriptionScheduleCompleted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1SubscriptionScheduleCreatedEventNotification>> v1SubscriptionScheduleCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1SubscriptionScheduleExpiringEventNotification>> v1SubscriptionScheduleExpiring;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1SubscriptionScheduleReleasedEventNotification>> v1SubscriptionScheduleReleased;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1SubscriptionScheduleUpdatedEventNotification>> v1SubscriptionScheduleUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TaxSettingsUpdatedEventNotification>> v1TaxSettingsUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TaxRateCreatedEventNotification>> v1TaxRateCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TaxRateUpdatedEventNotification>> v1TaxRateUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TerminalReaderActionFailedEventNotification>> v1TerminalReaderActionFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TerminalReaderActionSucceededEventNotification>> v1TerminalReaderActionSucceeded;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TerminalReaderActionUpdatedEventNotification>> v1TerminalReaderActionUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TestHelpersTestClockAdvancingEventNotification>> v1TestHelpersTestClockAdvancing;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TestHelpersTestClockCreatedEventNotification>> v1TestHelpersTestClockCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TestHelpersTestClockDeletedEventNotification>> v1TestHelpersTestClockDeleted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TestHelpersTestClockInternalFailureEventNotification>> v1TestHelpersTestClockInternalFailure;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TestHelpersTestClockReadyEventNotification>> v1TestHelpersTestClockReady;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TopupCanceledEventNotification>> v1TopupCanceled;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TopupCreatedEventNotification>> v1TopupCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TopupFailedEventNotification>> v1TopupFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TopupReversedEventNotification>> v1TopupReversed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TopupSucceededEventNotification>> v1TopupSucceeded;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TransferCreatedEventNotification>> v1TransferCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TransferReversedEventNotification>> v1TransferReversed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TransferUpdatedEventNotification>> v1TransferUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingCadenceBilledEventNotification>> v2BillingCadenceBilled;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingCadenceCanceledEventNotification>> v2BillingCadenceCanceled;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingCadenceCreatedEventNotification>> v2BillingCadenceCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingLicenseFeeCreatedEventNotification>> v2BillingLicenseFeeCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingLicenseFeeUpdatedEventNotification>> v2BillingLicenseFeeUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingLicenseFeeVersionCreatedEventNotification>> v2BillingLicenseFeeVersionCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingLicensedItemCreatedEventNotification>> v2BillingLicensedItemCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingLicensedItemUpdatedEventNotification>> v2BillingLicensedItemUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingMeteredItemCreatedEventNotification>> v2BillingMeteredItemCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingMeteredItemUpdatedEventNotification>> v2BillingMeteredItemUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanCreatedEventNotification>> v2BillingPricingPlanCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanUpdatedEventNotification>> v2BillingPricingPlanUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanComponentCreatedEventNotification>> v2BillingPricingPlanComponentCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanComponentUpdatedEventNotification>> v2BillingPricingPlanComponentUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanSubscriptionCollectionAwaitingCustomerActionEventNotification>> v2BillingPricingPlanSubscriptionCollectionAwaitingCustomerAction;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanSubscriptionCollectionCurrentEventNotification>> v2BillingPricingPlanSubscriptionCollectionCurrent;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanSubscriptionCollectionPastDueEventNotification>> v2BillingPricingPlanSubscriptionCollectionPastDue;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanSubscriptionCollectionPausedEventNotification>> v2BillingPricingPlanSubscriptionCollectionPaused;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanSubscriptionCollectionUnpaidEventNotification>> v2BillingPricingPlanSubscriptionCollectionUnpaid;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanSubscriptionServicingActivatedEventNotification>> v2BillingPricingPlanSubscriptionServicingActivated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanSubscriptionServicingCanceledEventNotification>> v2BillingPricingPlanSubscriptionServicingCanceled;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanSubscriptionServicingPausedEventNotification>> v2BillingPricingPlanSubscriptionServicingPaused;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanVersionCreatedEventNotification>> v2BillingPricingPlanVersionCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardCreatedEventNotification>> v2BillingRateCardCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardUpdatedEventNotification>> v2BillingRateCardUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardCustomPricingUnitOverageRateCreatedEventNotification>> v2BillingRateCardCustomPricingUnitOverageRateCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardRateCreatedEventNotification>> v2BillingRateCardRateCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionActivatedEventNotification>> v2BillingRateCardSubscriptionActivated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionCanceledEventNotification>> v2BillingRateCardSubscriptionCanceled;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionCollectionAwaitingCustomerActionEventNotification>> v2BillingRateCardSubscriptionCollectionAwaitingCustomerAction;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionCollectionCurrentEventNotification>> v2BillingRateCardSubscriptionCollectionCurrent;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionCollectionPastDueEventNotification>> v2BillingRateCardSubscriptionCollectionPastDue;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionCollectionPausedEventNotification>> v2BillingRateCardSubscriptionCollectionPaused;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionCollectionUnpaidEventNotification>> v2BillingRateCardSubscriptionCollectionUnpaid;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionServicingActivatedEventNotification>> v2BillingRateCardSubscriptionServicingActivated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionServicingCanceledEventNotification>> v2BillingRateCardSubscriptionServicingCanceled;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionServicingPausedEventNotification>> v2BillingRateCardSubscriptionServicingPaused;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardVersionCreatedEventNotification>> v2BillingRateCardVersionCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CommerceProductCatalogImportsFailedEventNotification>> v2CommerceProductCatalogImportsFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CommerceProductCatalogImportsProcessingEventNotification>> v2CommerceProductCatalogImportsProcessing;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CommerceProductCatalogImportsSucceededEventNotification>> v2CommerceProductCatalogImportsSucceeded;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CommerceProductCatalogImportsSucceededWithErrorsEventNotification>> v2CommerceProductCatalogImportsSucceededWithErrors;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountClosedEventNotification>> v2CoreAccountClosed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountCreatedEventNotification>> v2CoreAccountCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountUpdatedEventNotification>> v2CoreAccountUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationCardCreatorCapabilityStatusUpdatedEventNotification>> v2CoreAccountIncludingConfigurationCardCreatorCapabilityStatusUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationCardCreatorUpdatedEventNotification>> v2CoreAccountIncludingConfigurationCardCreatorUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdatedEventNotification>> v2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationCustomerUpdatedEventNotification>> v2CoreAccountIncludingConfigurationCustomerUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationMerchantCapabilityStatusUpdatedEventNotification>> v2CoreAccountIncludingConfigurationMerchantCapabilityStatusUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationMerchantUpdatedEventNotification>> v2CoreAccountIncludingConfigurationMerchantUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdatedEventNotification>> v2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationRecipientUpdatedEventNotification>> v2CoreAccountIncludingConfigurationRecipientUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdatedEventNotification>> v2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationStorerUpdatedEventNotification>> v2CoreAccountIncludingConfigurationStorerUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingDefaultsUpdatedEventNotification>> v2CoreAccountIncludingDefaultsUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingFutureRequirementsUpdatedEventNotification>> v2CoreAccountIncludingFutureRequirementsUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingIdentityUpdatedEventNotification>> v2CoreAccountIncludingIdentityUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingRequirementsUpdatedEventNotification>> v2CoreAccountIncludingRequirementsUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountLinkReturnedEventNotification>> v2CoreAccountLinkReturned;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountPersonCreatedEventNotification>> v2CoreAccountPersonCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountPersonDeletedEventNotification>> v2CoreAccountPersonDeleted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountPersonUpdatedEventNotification>> v2CoreAccountPersonUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountSignalsFraudulentWebsiteReadyEventNotification>> v2CoreAccountSignalsFraudulentWebsiteReady;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreApprovalRequestApprovedEventNotification>> v2CoreApprovalRequestApproved;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreApprovalRequestCanceledEventNotification>> v2CoreApprovalRequestCanceled;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreApprovalRequestCreatedEventNotification>> v2CoreApprovalRequestCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreApprovalRequestExpiredEventNotification>> v2CoreApprovalRequestExpired;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreApprovalRequestFailedEventNotification>> v2CoreApprovalRequestFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreApprovalRequestRejectedEventNotification>> v2CoreApprovalRequestRejected;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreApprovalRequestSucceededEventNotification>> v2CoreApprovalRequestSucceeded;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobBatchFailedEventNotification>> v2CoreBatchJobBatchFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobCanceledEventNotification>> v2CoreBatchJobCanceled;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobCompletedEventNotification>> v2CoreBatchJobCompleted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobCreatedEventNotification>> v2CoreBatchJobCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobReadyForUploadEventNotification>> v2CoreBatchJobReadyForUpload;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobTimeoutEventNotification>> v2CoreBatchJobTimeout;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobUpdatedEventNotification>> v2CoreBatchJobUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobUploadTimeoutEventNotification>> v2CoreBatchJobUploadTimeout;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobValidatingEventNotification>> v2CoreBatchJobValidating;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobValidationFailedEventNotification>> v2CoreBatchJobValidationFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreClaimableSandboxClaimedEventNotification>> v2CoreClaimableSandboxClaimed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreClaimableSandboxCreatedEventNotification>> v2CoreClaimableSandboxCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreClaimableSandboxExpiredEventNotification>> v2CoreClaimableSandboxExpired;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreClaimableSandboxExpiringEventNotification>> v2CoreClaimableSandboxExpiring;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreClaimableSandboxUpdatedEventNotification>> v2CoreClaimableSandboxUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreEventDestinationPingEventNotification>> v2CoreEventDestinationPing;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthApiErrorFiringEventNotification>> v2CoreHealthApiErrorFiring;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthApiErrorResolvedEventNotification>> v2CoreHealthApiErrorResolved;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthApiLatencyFiringEventNotification>> v2CoreHealthApiLatencyFiring;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthApiLatencyResolvedEventNotification>> v2CoreHealthApiLatencyResolved;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthAuthorizationRateDropFiringEventNotification>> v2CoreHealthAuthorizationRateDropFiring;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthAuthorizationRateDropResolvedEventNotification>> v2CoreHealthAuthorizationRateDropResolved;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthElementsErrorFiringEventNotification>> v2CoreHealthElementsErrorFiring;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthElementsErrorResolvedEventNotification>> v2CoreHealthElementsErrorResolved;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthEventGenerationFailureResolvedEventNotification>> v2CoreHealthEventGenerationFailureResolved;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthFraudRateIncreasedEventNotification>> v2CoreHealthFraudRateIncreased;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthInvoiceCountDroppedFiringEventNotification>> v2CoreHealthInvoiceCountDroppedFiring;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthInvoiceCountDroppedResolvedEventNotification>> v2CoreHealthInvoiceCountDroppedResolved;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthIssuingAuthorizationRequestErrorsFiringEventNotification>> v2CoreHealthIssuingAuthorizationRequestErrorsFiring;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthIssuingAuthorizationRequestErrorsResolvedEventNotification>> v2CoreHealthIssuingAuthorizationRequestErrorsResolved;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthIssuingAuthorizationRequestTimeoutFiringEventNotification>> v2CoreHealthIssuingAuthorizationRequestTimeoutFiring;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthIssuingAuthorizationRequestTimeoutResolvedEventNotification>> v2CoreHealthIssuingAuthorizationRequestTimeoutResolved;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthMeterEventSummariesDelayedFiringEventNotification>> v2CoreHealthMeterEventSummariesDelayedFiring;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthMeterEventSummariesDelayedResolvedEventNotification>> v2CoreHealthMeterEventSummariesDelayedResolved;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthPaymentMethodErrorFiringEventNotification>> v2CoreHealthPaymentMethodErrorFiring;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthPaymentMethodErrorResolvedEventNotification>> v2CoreHealthPaymentMethodErrorResolved;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthSepaDebitDelayedFiringEventNotification>> v2CoreHealthSepaDebitDelayedFiring;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthSepaDebitDelayedResolvedEventNotification>> v2CoreHealthSepaDebitDelayedResolved;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthTrafficVolumeDropFiringEventNotification>> v2CoreHealthTrafficVolumeDropFiring;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthTrafficVolumeDropResolvedEventNotification>> v2CoreHealthTrafficVolumeDropResolved;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthWebhookLatencyFiringEventNotification>> v2CoreHealthWebhookLatencyFiring;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthWebhookLatencyResolvedEventNotification>> v2CoreHealthWebhookLatencyResolved;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2DataReportingQueryRunCreatedEventNotification>> v2DataReportingQueryRunCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2DataReportingQueryRunFailedEventNotification>> v2DataReportingQueryRunFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2DataReportingQueryRunSucceededEventNotification>> v2DataReportingQueryRunSucceeded;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2DataReportingQueryRunUpdatedEventNotification>> v2DataReportingQueryRunUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2ExtendExtensionRunFailedEventNotification>> v2ExtendExtensionRunFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2ExtendWorkflowRunFailedEventNotification>> v2ExtendWorkflowRunFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2ExtendWorkflowRunStartedEventNotification>> v2ExtendWorkflowRunStarted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2ExtendWorkflowRunSucceededEventNotification>> v2ExtendWorkflowRunSucceeded;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2IamApiKeyCreatedEventNotification>> v2IamApiKeyCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2IamApiKeyDefaultSecretRevealedEventNotification>> v2IamApiKeyDefaultSecretRevealed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2IamApiKeyExpiredEventNotification>> v2IamApiKeyExpired;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2IamApiKeyPermissionsUpdatedEventNotification>> v2IamApiKeyPermissionsUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2IamApiKeyRotatedEventNotification>> v2IamApiKeyRotated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2IamApiKeyUpdatedEventNotification>> v2IamApiKeyUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2IamStripeAccessGrantApprovedEventNotification>> v2IamStripeAccessGrantApproved;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2IamStripeAccessGrantCanceledEventNotification>> v2IamStripeAccessGrantCanceled;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2IamStripeAccessGrantDeniedEventNotification>> v2IamStripeAccessGrantDenied;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2IamStripeAccessGrantRemovedEventNotification>> v2IamStripeAccessGrantRemoved;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2IamStripeAccessGrantRequestedEventNotification>> v2IamStripeAccessGrantRequested;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2IamStripeAccessGrantUpdatedEventNotification>> v2IamStripeAccessGrantUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementAdjustmentCreatedEventNotification>> v2MoneyManagementAdjustmentCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAccountCreatedEventNotification>> v2MoneyManagementFinancialAccountCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAccountUpdatedEventNotification>> v2MoneyManagementFinancialAccountUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAccountStatementCreatedEventNotification>> v2MoneyManagementFinancialAccountStatementCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAccountStatementRestatedEventNotification>> v2MoneyManagementFinancialAccountStatementRestated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAddressActivatedEventNotification>> v2MoneyManagementFinancialAddressActivated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAddressFailedEventNotification>> v2MoneyManagementFinancialAddressFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferAvailableEventNotification>> v2MoneyManagementInboundTransferAvailable;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitFailedEventNotification>> v2MoneyManagementInboundTransferBankDebitFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitProcessingEventNotification>> v2MoneyManagementInboundTransferBankDebitProcessing;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitQueuedEventNotification>> v2MoneyManagementInboundTransferBankDebitQueued;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitReturnedEventNotification>> v2MoneyManagementInboundTransferBankDebitReturned;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitSucceededEventNotification>> v2MoneyManagementInboundTransferBankDebitSucceeded;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentCanceledEventNotification>> v2MoneyManagementOutboundPaymentCanceled;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentCreatedEventNotification>> v2MoneyManagementOutboundPaymentCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentFailedEventNotification>> v2MoneyManagementOutboundPaymentFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentPostedEventNotification>> v2MoneyManagementOutboundPaymentPosted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentReturnedEventNotification>> v2MoneyManagementOutboundPaymentReturned;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentUpdatedEventNotification>> v2MoneyManagementOutboundPaymentUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferCanceledEventNotification>> v2MoneyManagementOutboundTransferCanceled;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferCreatedEventNotification>> v2MoneyManagementOutboundTransferCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferFailedEventNotification>> v2MoneyManagementOutboundTransferFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferPostedEventNotification>> v2MoneyManagementOutboundTransferPosted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferReturnedEventNotification>> v2MoneyManagementOutboundTransferReturned;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferUpdatedEventNotification>> v2MoneyManagementOutboundTransferUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementPayoutMethodCreatedEventNotification>> v2MoneyManagementPayoutMethodCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementPayoutMethodUpdatedEventNotification>> v2MoneyManagementPayoutMethodUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditAvailableEventNotification>> v2MoneyManagementReceivedCreditAvailable;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditFailedEventNotification>> v2MoneyManagementReceivedCreditFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditReturnedEventNotification>> v2MoneyManagementReceivedCreditReturned;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditSucceededEventNotification>> v2MoneyManagementReceivedCreditSucceeded;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitCanceledEventNotification>> v2MoneyManagementReceivedDebitCanceled;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitFailedEventNotification>> v2MoneyManagementReceivedDebitFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitPendingEventNotification>> v2MoneyManagementReceivedDebitPending;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitSucceededEventNotification>> v2MoneyManagementReceivedDebitSucceeded;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitUpdatedEventNotification>> v2MoneyManagementReceivedDebitUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementRecipientVerificationCreatedEventNotification>> v2MoneyManagementRecipientVerificationCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementRecipientVerificationUpdatedEventNotification>> v2MoneyManagementRecipientVerificationUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementTransactionCreatedEventNotification>> v2MoneyManagementTransactionCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementTransactionUpdatedEventNotification>> v2MoneyManagementTransactionUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2OrchestratedCommerceAgreementConfirmedEventNotification>> v2OrchestratedCommerceAgreementConfirmed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2OrchestratedCommerceAgreementCreatedEventNotification>> v2OrchestratedCommerceAgreementCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2OrchestratedCommerceAgreementPartiallyConfirmedEventNotification>> v2OrchestratedCommerceAgreementPartiallyConfirmed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2OrchestratedCommerceAgreementTerminatedEventNotification>> v2OrchestratedCommerceAgreementTerminated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentAttemptFailedEventNotification>> v2PaymentsOffSessionPaymentAttemptFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentAttemptStartedEventNotification>> v2PaymentsOffSessionPaymentAttemptStarted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentAuthorizationAttemptFailedEventNotification>> v2PaymentsOffSessionPaymentAuthorizationAttemptFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentAuthorizationAttemptStartedEventNotification>> v2PaymentsOffSessionPaymentAuthorizationAttemptStarted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentCanceledEventNotification>> v2PaymentsOffSessionPaymentCanceled;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentCreatedEventNotification>> v2PaymentsOffSessionPaymentCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentFailedEventNotification>> v2PaymentsOffSessionPaymentFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentPausedEventNotification>> v2PaymentsOffSessionPaymentPaused;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentRequiresCaptureEventNotification>> v2PaymentsOffSessionPaymentRequiresCapture;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentResumedEventNotification>> v2PaymentsOffSessionPaymentResumed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentSucceededEventNotification>> v2PaymentsOffSessionPaymentSucceeded;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentCanceledEventNotification>> v2PaymentsSettlementAllocationIntentCanceled;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentCreatedEventNotification>> v2PaymentsSettlementAllocationIntentCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentErroredEventNotification>> v2PaymentsSettlementAllocationIntentErrored;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentFundsNotReceivedEventNotification>> v2PaymentsSettlementAllocationIntentFundsNotReceived;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentMatchedEventNotification>> v2PaymentsSettlementAllocationIntentMatched;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentNotFoundEventNotification>> v2PaymentsSettlementAllocationIntentNotFound;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentSettledEventNotification>> v2PaymentsSettlementAllocationIntentSettled;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentSubmittedEventNotification>> v2PaymentsSettlementAllocationIntentSubmitted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentSplitCanceledEventNotification>> v2PaymentsSettlementAllocationIntentSplitCanceled;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentSplitCreatedEventNotification>> v2PaymentsSettlementAllocationIntentSplitCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentSplitSettledEventNotification>> v2PaymentsSettlementAllocationIntentSplitSettled;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2ReportingReportRunCreatedEventNotification>> v2ReportingReportRunCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2ReportingReportRunFailedEventNotification>> v2ReportingReportRunFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2ReportingReportRunSucceededEventNotification>> v2ReportingReportRunSucceeded;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2ReportingReportRunUpdatedEventNotification>> v2ReportingReportRunUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2SignalsAccountSignalFraudulentMerchantReadyEventNotification>> v2SignalsAccountSignalFraudulentMerchantReady;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2SignalsAccountSignalMerchantDelinquencyReadyEventNotification>> v2SignalsAccountSignalMerchantDelinquencyReady;

        // private-event-handlers: The end of the section generated from our OpenAPI spec

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeEventNotificationHandler"/> class.
        /// </summary>
        /// <param name="client">The StripeClient instance to use for parsing and API requests.</param>
        /// <param name="webhookSecret">The webhook secret used for signature verification.</param>
        /// <param name="fallbackCallback">The function to call when handing an event for whom there's no callback registered.</param>
        public StripeEventNotificationHandler(StripeClient client, string webhookSecret, Action<object, StripeUnhandledEventNotificationEventArgs> fallbackCallback)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            this.client = client;

            if (string.IsNullOrEmpty(webhookSecret))
            {
                throw new ArgumentNullException(nameof(webhookSecret));
            }

            this.webhookSecret = webhookSecret;

            this.FallbackCallback += new EventHandler<StripeUnhandledEventNotificationEventArgs>(fallbackCallback);

            // Capture the client options to reuse configuration when creating new clients
            var requestor = client.Requestor as LiveApiRequestor;
            if (requestor == null)
            {
                throw new InvalidOperationException("StripeEventNotificationHandler requires a StripeClient with a LiveApiRequestor.");
            }

            this.clientOptions = new StripeClientOptions
            {
                ApiKey = requestor.ApiKey,
                ClientId = requestor.ClientId,
                HttpClient = requestor.HttpClient,
                ApiBase = requestor.ApiBase,
                ConnectBase = requestor.ConnectBase,
                FilesBase = requestor.FilesBase,
                MeterEventsBase = requestor.MeterEventsBase,
                StripeAccount = null, // Don't copy StripeAccount or StripeContext
                StripeContext = null,
            };
        }

        private event EventHandler<StripeUnhandledEventNotificationEventArgs> FallbackCallback;

        // public facing EventHandler
        // public-event-handlers: The beginning of the section generated from our OpenAPI spec
        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1AccountApplicationAuthorizedEventNotification>> V1AccountApplicationAuthorized
        {
            add { this.AddEventHandler(ref this.v1AccountApplicationAuthorized, value, "v1.account.application.authorized"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1AccountApplicationDeauthorizedEventNotification>> V1AccountApplicationDeauthorized
        {
            add { this.AddEventHandler(ref this.v1AccountApplicationDeauthorized, value, "v1.account.application.deauthorized"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1AccountExternalAccountCreatedEventNotification>> V1AccountExternalAccountCreated
        {
            add { this.AddEventHandler(ref this.v1AccountExternalAccountCreated, value, "v1.account.external_account.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1AccountExternalAccountDeletedEventNotification>> V1AccountExternalAccountDeleted
        {
            add { this.AddEventHandler(ref this.v1AccountExternalAccountDeleted, value, "v1.account.external_account.deleted"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1AccountExternalAccountUpdatedEventNotification>> V1AccountExternalAccountUpdated
        {
            add { this.AddEventHandler(ref this.v1AccountExternalAccountUpdated, value, "v1.account.external_account.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1AccountUpdatedEventNotification>> V1AccountUpdated
        {
            add { this.AddEventHandler(ref this.v1AccountUpdated, value, "v1.account.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1AccountSignalsIncludingDelinquencyCreatedEventNotification>> V1AccountSignalsIncludingDelinquencyCreated
        {
            add { this.AddEventHandler(ref this.v1AccountSignalsIncludingDelinquencyCreated, value, "v1.account_signals[delinquency].created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ApplicationFeeCreatedEventNotification>> V1ApplicationFeeCreated
        {
            add { this.AddEventHandler(ref this.v1ApplicationFeeCreated, value, "v1.application_fee.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ApplicationFeeRefundUpdatedEventNotification>> V1ApplicationFeeRefundUpdated
        {
            add { this.AddEventHandler(ref this.v1ApplicationFeeRefundUpdated, value, "v1.application_fee.refund.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ApplicationFeeRefundedEventNotification>> V1ApplicationFeeRefunded
        {
            add { this.AddEventHandler(ref this.v1ApplicationFeeRefunded, value, "v1.application_fee.refunded"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BalanceAvailableEventNotification>> V1BalanceAvailable
        {
            add { this.AddEventHandler(ref this.v1BalanceAvailable, value, "v1.balance.available"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingAlertTriggeredEventNotification>> V1BillingAlertTriggered
        {
            add { this.AddEventHandler(ref this.v1BillingAlertTriggered, value, "v1.billing.alert.triggered"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterErrorReportTriggeredEventNotification>> V1BillingMeterErrorReportTriggered
        {
            add { this.AddEventHandler(ref this.v1BillingMeterErrorReportTriggered, value, "v1.billing.meter.error_report_triggered"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterNoMeterFoundEventNotification>> V1BillingMeterNoMeterFound
        {
            add { this.AddEventHandler(ref this.v1BillingMeterNoMeterFound, value, "v1.billing.meter.no_meter_found"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingPortalConfigurationCreatedEventNotification>> V1BillingPortalConfigurationCreated
        {
            add { this.AddEventHandler(ref this.v1BillingPortalConfigurationCreated, value, "v1.billing_portal.configuration.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingPortalConfigurationUpdatedEventNotification>> V1BillingPortalConfigurationUpdated
        {
            add { this.AddEventHandler(ref this.v1BillingPortalConfigurationUpdated, value, "v1.billing_portal.configuration.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingPortalSessionCreatedEventNotification>> V1BillingPortalSessionCreated
        {
            add { this.AddEventHandler(ref this.v1BillingPortalSessionCreated, value, "v1.billing_portal.session.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CapabilityUpdatedEventNotification>> V1CapabilityUpdated
        {
            add { this.AddEventHandler(ref this.v1CapabilityUpdated, value, "v1.capability.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CashBalanceFundsAvailableEventNotification>> V1CashBalanceFundsAvailable
        {
            add { this.AddEventHandler(ref this.v1CashBalanceFundsAvailable, value, "v1.cash_balance.funds_available"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ChargeCapturedEventNotification>> V1ChargeCaptured
        {
            add { this.AddEventHandler(ref this.v1ChargeCaptured, value, "v1.charge.captured"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ChargeDisputeClosedEventNotification>> V1ChargeDisputeClosed
        {
            add { this.AddEventHandler(ref this.v1ChargeDisputeClosed, value, "v1.charge.dispute.closed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ChargeDisputeCreatedEventNotification>> V1ChargeDisputeCreated
        {
            add { this.AddEventHandler(ref this.v1ChargeDisputeCreated, value, "v1.charge.dispute.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ChargeDisputeFundsReinstatedEventNotification>> V1ChargeDisputeFundsReinstated
        {
            add { this.AddEventHandler(ref this.v1ChargeDisputeFundsReinstated, value, "v1.charge.dispute.funds_reinstated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ChargeDisputeFundsWithdrawnEventNotification>> V1ChargeDisputeFundsWithdrawn
        {
            add { this.AddEventHandler(ref this.v1ChargeDisputeFundsWithdrawn, value, "v1.charge.dispute.funds_withdrawn"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ChargeDisputeUpdatedEventNotification>> V1ChargeDisputeUpdated
        {
            add { this.AddEventHandler(ref this.v1ChargeDisputeUpdated, value, "v1.charge.dispute.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ChargeExpiredEventNotification>> V1ChargeExpired
        {
            add { this.AddEventHandler(ref this.v1ChargeExpired, value, "v1.charge.expired"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ChargeFailedEventNotification>> V1ChargeFailed
        {
            add { this.AddEventHandler(ref this.v1ChargeFailed, value, "v1.charge.failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ChargePendingEventNotification>> V1ChargePending
        {
            add { this.AddEventHandler(ref this.v1ChargePending, value, "v1.charge.pending"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ChargeRefundUpdatedEventNotification>> V1ChargeRefundUpdated
        {
            add { this.AddEventHandler(ref this.v1ChargeRefundUpdated, value, "v1.charge.refund.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ChargeRefundedEventNotification>> V1ChargeRefunded
        {
            add { this.AddEventHandler(ref this.v1ChargeRefunded, value, "v1.charge.refunded"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ChargeSucceededEventNotification>> V1ChargeSucceeded
        {
            add { this.AddEventHandler(ref this.v1ChargeSucceeded, value, "v1.charge.succeeded"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ChargeUpdatedEventNotification>> V1ChargeUpdated
        {
            add { this.AddEventHandler(ref this.v1ChargeUpdated, value, "v1.charge.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CheckoutSessionAsyncPaymentFailedEventNotification>> V1CheckoutSessionAsyncPaymentFailed
        {
            add { this.AddEventHandler(ref this.v1CheckoutSessionAsyncPaymentFailed, value, "v1.checkout.session.async_payment_failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CheckoutSessionAsyncPaymentSucceededEventNotification>> V1CheckoutSessionAsyncPaymentSucceeded
        {
            add { this.AddEventHandler(ref this.v1CheckoutSessionAsyncPaymentSucceeded, value, "v1.checkout.session.async_payment_succeeded"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CheckoutSessionCompletedEventNotification>> V1CheckoutSessionCompleted
        {
            add { this.AddEventHandler(ref this.v1CheckoutSessionCompleted, value, "v1.checkout.session.completed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CheckoutSessionExpiredEventNotification>> V1CheckoutSessionExpired
        {
            add { this.AddEventHandler(ref this.v1CheckoutSessionExpired, value, "v1.checkout.session.expired"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ClimateOrderCanceledEventNotification>> V1ClimateOrderCanceled
        {
            add { this.AddEventHandler(ref this.v1ClimateOrderCanceled, value, "v1.climate.order.canceled"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ClimateOrderCreatedEventNotification>> V1ClimateOrderCreated
        {
            add { this.AddEventHandler(ref this.v1ClimateOrderCreated, value, "v1.climate.order.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ClimateOrderDelayedEventNotification>> V1ClimateOrderDelayed
        {
            add { this.AddEventHandler(ref this.v1ClimateOrderDelayed, value, "v1.climate.order.delayed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ClimateOrderDeliveredEventNotification>> V1ClimateOrderDelivered
        {
            add { this.AddEventHandler(ref this.v1ClimateOrderDelivered, value, "v1.climate.order.delivered"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ClimateOrderProductSubstitutedEventNotification>> V1ClimateOrderProductSubstituted
        {
            add { this.AddEventHandler(ref this.v1ClimateOrderProductSubstituted, value, "v1.climate.order.product_substituted"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ClimateProductCreatedEventNotification>> V1ClimateProductCreated
        {
            add { this.AddEventHandler(ref this.v1ClimateProductCreated, value, "v1.climate.product.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ClimateProductPricingUpdatedEventNotification>> V1ClimateProductPricingUpdated
        {
            add { this.AddEventHandler(ref this.v1ClimateProductPricingUpdated, value, "v1.climate.product.pricing_updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CouponCreatedEventNotification>> V1CouponCreated
        {
            add { this.AddEventHandler(ref this.v1CouponCreated, value, "v1.coupon.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CouponDeletedEventNotification>> V1CouponDeleted
        {
            add { this.AddEventHandler(ref this.v1CouponDeleted, value, "v1.coupon.deleted"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CouponUpdatedEventNotification>> V1CouponUpdated
        {
            add { this.AddEventHandler(ref this.v1CouponUpdated, value, "v1.coupon.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CreditNoteCreatedEventNotification>> V1CreditNoteCreated
        {
            add { this.AddEventHandler(ref this.v1CreditNoteCreated, value, "v1.credit_note.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CreditNoteUpdatedEventNotification>> V1CreditNoteUpdated
        {
            add { this.AddEventHandler(ref this.v1CreditNoteUpdated, value, "v1.credit_note.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CreditNoteVoidedEventNotification>> V1CreditNoteVoided
        {
            add { this.AddEventHandler(ref this.v1CreditNoteVoided, value, "v1.credit_note.voided"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerCreatedEventNotification>> V1CustomerCreated
        {
            add { this.AddEventHandler(ref this.v1CustomerCreated, value, "v1.customer.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerDeletedEventNotification>> V1CustomerDeleted
        {
            add { this.AddEventHandler(ref this.v1CustomerDeleted, value, "v1.customer.deleted"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerSubscriptionCreatedEventNotification>> V1CustomerSubscriptionCreated
        {
            add { this.AddEventHandler(ref this.v1CustomerSubscriptionCreated, value, "v1.customer.subscription.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerSubscriptionDeletedEventNotification>> V1CustomerSubscriptionDeleted
        {
            add { this.AddEventHandler(ref this.v1CustomerSubscriptionDeleted, value, "v1.customer.subscription.deleted"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerSubscriptionPausedEventNotification>> V1CustomerSubscriptionPaused
        {
            add { this.AddEventHandler(ref this.v1CustomerSubscriptionPaused, value, "v1.customer.subscription.paused"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerSubscriptionPendingUpdateAppliedEventNotification>> V1CustomerSubscriptionPendingUpdateApplied
        {
            add { this.AddEventHandler(ref this.v1CustomerSubscriptionPendingUpdateApplied, value, "v1.customer.subscription.pending_update_applied"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerSubscriptionPendingUpdateExpiredEventNotification>> V1CustomerSubscriptionPendingUpdateExpired
        {
            add { this.AddEventHandler(ref this.v1CustomerSubscriptionPendingUpdateExpired, value, "v1.customer.subscription.pending_update_expired"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerSubscriptionResumedEventNotification>> V1CustomerSubscriptionResumed
        {
            add { this.AddEventHandler(ref this.v1CustomerSubscriptionResumed, value, "v1.customer.subscription.resumed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerSubscriptionTrialWillEndEventNotification>> V1CustomerSubscriptionTrialWillEnd
        {
            add { this.AddEventHandler(ref this.v1CustomerSubscriptionTrialWillEnd, value, "v1.customer.subscription.trial_will_end"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerSubscriptionUpdatedEventNotification>> V1CustomerSubscriptionUpdated
        {
            add { this.AddEventHandler(ref this.v1CustomerSubscriptionUpdated, value, "v1.customer.subscription.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerTaxIdCreatedEventNotification>> V1CustomerTaxIdCreated
        {
            add { this.AddEventHandler(ref this.v1CustomerTaxIdCreated, value, "v1.customer.tax_id.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerTaxIdDeletedEventNotification>> V1CustomerTaxIdDeleted
        {
            add { this.AddEventHandler(ref this.v1CustomerTaxIdDeleted, value, "v1.customer.tax_id.deleted"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerTaxIdUpdatedEventNotification>> V1CustomerTaxIdUpdated
        {
            add { this.AddEventHandler(ref this.v1CustomerTaxIdUpdated, value, "v1.customer.tax_id.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerUpdatedEventNotification>> V1CustomerUpdated
        {
            add { this.AddEventHandler(ref this.v1CustomerUpdated, value, "v1.customer.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerCashBalanceTransactionCreatedEventNotification>> V1CustomerCashBalanceTransactionCreated
        {
            add { this.AddEventHandler(ref this.v1CustomerCashBalanceTransactionCreated, value, "v1.customer_cash_balance_transaction.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1EntitlementsActiveEntitlementSummaryUpdatedEventNotification>> V1EntitlementsActiveEntitlementSummaryUpdated
        {
            add { this.AddEventHandler(ref this.v1EntitlementsActiveEntitlementSummaryUpdated, value, "v1.entitlements.active_entitlement_summary.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1FileCreatedEventNotification>> V1FileCreated
        {
            add { this.AddEventHandler(ref this.v1FileCreated, value, "v1.file.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountCreatedEventNotification>> V1FinancialConnectionsAccountCreated
        {
            add { this.AddEventHandler(ref this.v1FinancialConnectionsAccountCreated, value, "v1.financial_connections.account.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountDeactivatedEventNotification>> V1FinancialConnectionsAccountDeactivated
        {
            add { this.AddEventHandler(ref this.v1FinancialConnectionsAccountDeactivated, value, "v1.financial_connections.account.deactivated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountDisconnectedEventNotification>> V1FinancialConnectionsAccountDisconnected
        {
            add { this.AddEventHandler(ref this.v1FinancialConnectionsAccountDisconnected, value, "v1.financial_connections.account.disconnected"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountReactivatedEventNotification>> V1FinancialConnectionsAccountReactivated
        {
            add { this.AddEventHandler(ref this.v1FinancialConnectionsAccountReactivated, value, "v1.financial_connections.account.reactivated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountRefreshedBalanceEventNotification>> V1FinancialConnectionsAccountRefreshedBalance
        {
            add { this.AddEventHandler(ref this.v1FinancialConnectionsAccountRefreshedBalance, value, "v1.financial_connections.account.refreshed_balance"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountRefreshedOwnershipEventNotification>> V1FinancialConnectionsAccountRefreshedOwnership
        {
            add { this.AddEventHandler(ref this.v1FinancialConnectionsAccountRefreshedOwnership, value, "v1.financial_connections.account.refreshed_ownership"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountRefreshedTransactionsEventNotification>> V1FinancialConnectionsAccountRefreshedTransactions
        {
            add { this.AddEventHandler(ref this.v1FinancialConnectionsAccountRefreshedTransactions, value, "v1.financial_connections.account.refreshed_transactions"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IdentityVerificationSessionCanceledEventNotification>> V1IdentityVerificationSessionCanceled
        {
            add { this.AddEventHandler(ref this.v1IdentityVerificationSessionCanceled, value, "v1.identity.verification_session.canceled"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IdentityVerificationSessionCreatedEventNotification>> V1IdentityVerificationSessionCreated
        {
            add { this.AddEventHandler(ref this.v1IdentityVerificationSessionCreated, value, "v1.identity.verification_session.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IdentityVerificationSessionProcessingEventNotification>> V1IdentityVerificationSessionProcessing
        {
            add { this.AddEventHandler(ref this.v1IdentityVerificationSessionProcessing, value, "v1.identity.verification_session.processing"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IdentityVerificationSessionRedactedEventNotification>> V1IdentityVerificationSessionRedacted
        {
            add { this.AddEventHandler(ref this.v1IdentityVerificationSessionRedacted, value, "v1.identity.verification_session.redacted"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IdentityVerificationSessionRequiresInputEventNotification>> V1IdentityVerificationSessionRequiresInput
        {
            add { this.AddEventHandler(ref this.v1IdentityVerificationSessionRequiresInput, value, "v1.identity.verification_session.requires_input"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IdentityVerificationSessionVerifiedEventNotification>> V1IdentityVerificationSessionVerified
        {
            add { this.AddEventHandler(ref this.v1IdentityVerificationSessionVerified, value, "v1.identity.verification_session.verified"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceCreatedEventNotification>> V1InvoiceCreated
        {
            add { this.AddEventHandler(ref this.v1InvoiceCreated, value, "v1.invoice.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceDeletedEventNotification>> V1InvoiceDeleted
        {
            add { this.AddEventHandler(ref this.v1InvoiceDeleted, value, "v1.invoice.deleted"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceFinalizationFailedEventNotification>> V1InvoiceFinalizationFailed
        {
            add { this.AddEventHandler(ref this.v1InvoiceFinalizationFailed, value, "v1.invoice.finalization_failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceFinalizedEventNotification>> V1InvoiceFinalized
        {
            add { this.AddEventHandler(ref this.v1InvoiceFinalized, value, "v1.invoice.finalized"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceMarkedUncollectibleEventNotification>> V1InvoiceMarkedUncollectible
        {
            add { this.AddEventHandler(ref this.v1InvoiceMarkedUncollectible, value, "v1.invoice.marked_uncollectible"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceOverdueEventNotification>> V1InvoiceOverdue
        {
            add { this.AddEventHandler(ref this.v1InvoiceOverdue, value, "v1.invoice.overdue"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceOverpaidEventNotification>> V1InvoiceOverpaid
        {
            add { this.AddEventHandler(ref this.v1InvoiceOverpaid, value, "v1.invoice.overpaid"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoicePaidEventNotification>> V1InvoicePaid
        {
            add { this.AddEventHandler(ref this.v1InvoicePaid, value, "v1.invoice.paid"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoicePaymentActionRequiredEventNotification>> V1InvoicePaymentActionRequired
        {
            add { this.AddEventHandler(ref this.v1InvoicePaymentActionRequired, value, "v1.invoice.payment_action_required"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoicePaymentFailedEventNotification>> V1InvoicePaymentFailed
        {
            add { this.AddEventHandler(ref this.v1InvoicePaymentFailed, value, "v1.invoice.payment_failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoicePaymentSucceededEventNotification>> V1InvoicePaymentSucceeded
        {
            add { this.AddEventHandler(ref this.v1InvoicePaymentSucceeded, value, "v1.invoice.payment_succeeded"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceSentEventNotification>> V1InvoiceSent
        {
            add { this.AddEventHandler(ref this.v1InvoiceSent, value, "v1.invoice.sent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceUpcomingEventNotification>> V1InvoiceUpcoming
        {
            add { this.AddEventHandler(ref this.v1InvoiceUpcoming, value, "v1.invoice.upcoming"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceUpdatedEventNotification>> V1InvoiceUpdated
        {
            add { this.AddEventHandler(ref this.v1InvoiceUpdated, value, "v1.invoice.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceVoidedEventNotification>> V1InvoiceVoided
        {
            add { this.AddEventHandler(ref this.v1InvoiceVoided, value, "v1.invoice.voided"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceWillBeDueEventNotification>> V1InvoiceWillBeDue
        {
            add { this.AddEventHandler(ref this.v1InvoiceWillBeDue, value, "v1.invoice.will_be_due"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoicePaymentPaidEventNotification>> V1InvoicePaymentPaid
        {
            add { this.AddEventHandler(ref this.v1InvoicePaymentPaid, value, "v1.invoice_payment.paid"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceitemCreatedEventNotification>> V1InvoiceitemCreated
        {
            add { this.AddEventHandler(ref this.v1InvoiceitemCreated, value, "v1.invoiceitem.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceitemDeletedEventNotification>> V1InvoiceitemDeleted
        {
            add { this.AddEventHandler(ref this.v1InvoiceitemDeleted, value, "v1.invoiceitem.deleted"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingAuthorizationCreatedEventNotification>> V1IssuingAuthorizationCreated
        {
            add { this.AddEventHandler(ref this.v1IssuingAuthorizationCreated, value, "v1.issuing_authorization.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingAuthorizationRequestEventNotification>> V1IssuingAuthorizationRequest
        {
            add { this.AddEventHandler(ref this.v1IssuingAuthorizationRequest, value, "v1.issuing_authorization.request"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingAuthorizationUpdatedEventNotification>> V1IssuingAuthorizationUpdated
        {
            add { this.AddEventHandler(ref this.v1IssuingAuthorizationUpdated, value, "v1.issuing_authorization.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingCardCreatedEventNotification>> V1IssuingCardCreated
        {
            add { this.AddEventHandler(ref this.v1IssuingCardCreated, value, "v1.issuing_card.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingCardUpdatedEventNotification>> V1IssuingCardUpdated
        {
            add { this.AddEventHandler(ref this.v1IssuingCardUpdated, value, "v1.issuing_card.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingCardholderCreatedEventNotification>> V1IssuingCardholderCreated
        {
            add { this.AddEventHandler(ref this.v1IssuingCardholderCreated, value, "v1.issuing_cardholder.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingCardholderUpdatedEventNotification>> V1IssuingCardholderUpdated
        {
            add { this.AddEventHandler(ref this.v1IssuingCardholderUpdated, value, "v1.issuing_cardholder.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingDisputeClosedEventNotification>> V1IssuingDisputeClosed
        {
            add { this.AddEventHandler(ref this.v1IssuingDisputeClosed, value, "v1.issuing_dispute.closed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingDisputeCreatedEventNotification>> V1IssuingDisputeCreated
        {
            add { this.AddEventHandler(ref this.v1IssuingDisputeCreated, value, "v1.issuing_dispute.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingDisputeFundsReinstatedEventNotification>> V1IssuingDisputeFundsReinstated
        {
            add { this.AddEventHandler(ref this.v1IssuingDisputeFundsReinstated, value, "v1.issuing_dispute.funds_reinstated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingDisputeFundsRescindedEventNotification>> V1IssuingDisputeFundsRescinded
        {
            add { this.AddEventHandler(ref this.v1IssuingDisputeFundsRescinded, value, "v1.issuing_dispute.funds_rescinded"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingDisputeSubmittedEventNotification>> V1IssuingDisputeSubmitted
        {
            add { this.AddEventHandler(ref this.v1IssuingDisputeSubmitted, value, "v1.issuing_dispute.submitted"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingDisputeUpdatedEventNotification>> V1IssuingDisputeUpdated
        {
            add { this.AddEventHandler(ref this.v1IssuingDisputeUpdated, value, "v1.issuing_dispute.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingPersonalizationDesignActivatedEventNotification>> V1IssuingPersonalizationDesignActivated
        {
            add { this.AddEventHandler(ref this.v1IssuingPersonalizationDesignActivated, value, "v1.issuing_personalization_design.activated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingPersonalizationDesignDeactivatedEventNotification>> V1IssuingPersonalizationDesignDeactivated
        {
            add { this.AddEventHandler(ref this.v1IssuingPersonalizationDesignDeactivated, value, "v1.issuing_personalization_design.deactivated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingPersonalizationDesignRejectedEventNotification>> V1IssuingPersonalizationDesignRejected
        {
            add { this.AddEventHandler(ref this.v1IssuingPersonalizationDesignRejected, value, "v1.issuing_personalization_design.rejected"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingPersonalizationDesignUpdatedEventNotification>> V1IssuingPersonalizationDesignUpdated
        {
            add { this.AddEventHandler(ref this.v1IssuingPersonalizationDesignUpdated, value, "v1.issuing_personalization_design.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingTokenCreatedEventNotification>> V1IssuingTokenCreated
        {
            add { this.AddEventHandler(ref this.v1IssuingTokenCreated, value, "v1.issuing_token.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingTokenUpdatedEventNotification>> V1IssuingTokenUpdated
        {
            add { this.AddEventHandler(ref this.v1IssuingTokenUpdated, value, "v1.issuing_token.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingTransactionCreatedEventNotification>> V1IssuingTransactionCreated
        {
            add { this.AddEventHandler(ref this.v1IssuingTransactionCreated, value, "v1.issuing_transaction.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingTransactionPurchaseDetailsReceiptUpdatedEventNotification>> V1IssuingTransactionPurchaseDetailsReceiptUpdated
        {
            add { this.AddEventHandler(ref this.v1IssuingTransactionPurchaseDetailsReceiptUpdated, value, "v1.issuing_transaction.purchase_details_receipt_updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1IssuingTransactionUpdatedEventNotification>> V1IssuingTransactionUpdated
        {
            add { this.AddEventHandler(ref this.v1IssuingTransactionUpdated, value, "v1.issuing_transaction.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1MandateUpdatedEventNotification>> V1MandateUpdated
        {
            add { this.AddEventHandler(ref this.v1MandateUpdated, value, "v1.mandate.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PaymentIntentAmountCapturableUpdatedEventNotification>> V1PaymentIntentAmountCapturableUpdated
        {
            add { this.AddEventHandler(ref this.v1PaymentIntentAmountCapturableUpdated, value, "v1.payment_intent.amount_capturable_updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PaymentIntentCanceledEventNotification>> V1PaymentIntentCanceled
        {
            add { this.AddEventHandler(ref this.v1PaymentIntentCanceled, value, "v1.payment_intent.canceled"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PaymentIntentCreatedEventNotification>> V1PaymentIntentCreated
        {
            add { this.AddEventHandler(ref this.v1PaymentIntentCreated, value, "v1.payment_intent.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PaymentIntentPartiallyFundedEventNotification>> V1PaymentIntentPartiallyFunded
        {
            add { this.AddEventHandler(ref this.v1PaymentIntentPartiallyFunded, value, "v1.payment_intent.partially_funded"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PaymentIntentPaymentFailedEventNotification>> V1PaymentIntentPaymentFailed
        {
            add { this.AddEventHandler(ref this.v1PaymentIntentPaymentFailed, value, "v1.payment_intent.payment_failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PaymentIntentProcessingEventNotification>> V1PaymentIntentProcessing
        {
            add { this.AddEventHandler(ref this.v1PaymentIntentProcessing, value, "v1.payment_intent.processing"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PaymentIntentRequiresActionEventNotification>> V1PaymentIntentRequiresAction
        {
            add { this.AddEventHandler(ref this.v1PaymentIntentRequiresAction, value, "v1.payment_intent.requires_action"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PaymentIntentSucceededEventNotification>> V1PaymentIntentSucceeded
        {
            add { this.AddEventHandler(ref this.v1PaymentIntentSucceeded, value, "v1.payment_intent.succeeded"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PaymentLinkCreatedEventNotification>> V1PaymentLinkCreated
        {
            add { this.AddEventHandler(ref this.v1PaymentLinkCreated, value, "v1.payment_link.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PaymentLinkUpdatedEventNotification>> V1PaymentLinkUpdated
        {
            add { this.AddEventHandler(ref this.v1PaymentLinkUpdated, value, "v1.payment_link.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PaymentMethodAttachedEventNotification>> V1PaymentMethodAttached
        {
            add { this.AddEventHandler(ref this.v1PaymentMethodAttached, value, "v1.payment_method.attached"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PaymentMethodAutomaticallyUpdatedEventNotification>> V1PaymentMethodAutomaticallyUpdated
        {
            add { this.AddEventHandler(ref this.v1PaymentMethodAutomaticallyUpdated, value, "v1.payment_method.automatically_updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PaymentMethodDetachedEventNotification>> V1PaymentMethodDetached
        {
            add { this.AddEventHandler(ref this.v1PaymentMethodDetached, value, "v1.payment_method.detached"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PaymentMethodUpdatedEventNotification>> V1PaymentMethodUpdated
        {
            add { this.AddEventHandler(ref this.v1PaymentMethodUpdated, value, "v1.payment_method.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PayoutCanceledEventNotification>> V1PayoutCanceled
        {
            add { this.AddEventHandler(ref this.v1PayoutCanceled, value, "v1.payout.canceled"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PayoutCreatedEventNotification>> V1PayoutCreated
        {
            add { this.AddEventHandler(ref this.v1PayoutCreated, value, "v1.payout.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PayoutFailedEventNotification>> V1PayoutFailed
        {
            add { this.AddEventHandler(ref this.v1PayoutFailed, value, "v1.payout.failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PayoutPaidEventNotification>> V1PayoutPaid
        {
            add { this.AddEventHandler(ref this.v1PayoutPaid, value, "v1.payout.paid"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PayoutReconciliationCompletedEventNotification>> V1PayoutReconciliationCompleted
        {
            add { this.AddEventHandler(ref this.v1PayoutReconciliationCompleted, value, "v1.payout.reconciliation_completed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PayoutUpdatedEventNotification>> V1PayoutUpdated
        {
            add { this.AddEventHandler(ref this.v1PayoutUpdated, value, "v1.payout.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PersonCreatedEventNotification>> V1PersonCreated
        {
            add { this.AddEventHandler(ref this.v1PersonCreated, value, "v1.person.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PersonDeletedEventNotification>> V1PersonDeleted
        {
            add { this.AddEventHandler(ref this.v1PersonDeleted, value, "v1.person.deleted"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PersonUpdatedEventNotification>> V1PersonUpdated
        {
            add { this.AddEventHandler(ref this.v1PersonUpdated, value, "v1.person.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PlanCreatedEventNotification>> V1PlanCreated
        {
            add { this.AddEventHandler(ref this.v1PlanCreated, value, "v1.plan.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PlanDeletedEventNotification>> V1PlanDeleted
        {
            add { this.AddEventHandler(ref this.v1PlanDeleted, value, "v1.plan.deleted"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PlanUpdatedEventNotification>> V1PlanUpdated
        {
            add { this.AddEventHandler(ref this.v1PlanUpdated, value, "v1.plan.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PriceCreatedEventNotification>> V1PriceCreated
        {
            add { this.AddEventHandler(ref this.v1PriceCreated, value, "v1.price.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PriceDeletedEventNotification>> V1PriceDeleted
        {
            add { this.AddEventHandler(ref this.v1PriceDeleted, value, "v1.price.deleted"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PriceUpdatedEventNotification>> V1PriceUpdated
        {
            add { this.AddEventHandler(ref this.v1PriceUpdated, value, "v1.price.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ProductCreatedEventNotification>> V1ProductCreated
        {
            add { this.AddEventHandler(ref this.v1ProductCreated, value, "v1.product.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ProductDeletedEventNotification>> V1ProductDeleted
        {
            add { this.AddEventHandler(ref this.v1ProductDeleted, value, "v1.product.deleted"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ProductUpdatedEventNotification>> V1ProductUpdated
        {
            add { this.AddEventHandler(ref this.v1ProductUpdated, value, "v1.product.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PromotionCodeCreatedEventNotification>> V1PromotionCodeCreated
        {
            add { this.AddEventHandler(ref this.v1PromotionCodeCreated, value, "v1.promotion_code.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1PromotionCodeUpdatedEventNotification>> V1PromotionCodeUpdated
        {
            add { this.AddEventHandler(ref this.v1PromotionCodeUpdated, value, "v1.promotion_code.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1QuoteAcceptedEventNotification>> V1QuoteAccepted
        {
            add { this.AddEventHandler(ref this.v1QuoteAccepted, value, "v1.quote.accepted"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1QuoteCanceledEventNotification>> V1QuoteCanceled
        {
            add { this.AddEventHandler(ref this.v1QuoteCanceled, value, "v1.quote.canceled"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1QuoteCreatedEventNotification>> V1QuoteCreated
        {
            add { this.AddEventHandler(ref this.v1QuoteCreated, value, "v1.quote.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1QuoteFinalizedEventNotification>> V1QuoteFinalized
        {
            add { this.AddEventHandler(ref this.v1QuoteFinalized, value, "v1.quote.finalized"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1RadarEarlyFraudWarningCreatedEventNotification>> V1RadarEarlyFraudWarningCreated
        {
            add { this.AddEventHandler(ref this.v1RadarEarlyFraudWarningCreated, value, "v1.radar.early_fraud_warning.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1RadarEarlyFraudWarningUpdatedEventNotification>> V1RadarEarlyFraudWarningUpdated
        {
            add { this.AddEventHandler(ref this.v1RadarEarlyFraudWarningUpdated, value, "v1.radar.early_fraud_warning.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1RefundCreatedEventNotification>> V1RefundCreated
        {
            add { this.AddEventHandler(ref this.v1RefundCreated, value, "v1.refund.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1RefundFailedEventNotification>> V1RefundFailed
        {
            add { this.AddEventHandler(ref this.v1RefundFailed, value, "v1.refund.failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1RefundUpdatedEventNotification>> V1RefundUpdated
        {
            add { this.AddEventHandler(ref this.v1RefundUpdated, value, "v1.refund.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ReviewClosedEventNotification>> V1ReviewClosed
        {
            add { this.AddEventHandler(ref this.v1ReviewClosed, value, "v1.review.closed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ReviewOpenedEventNotification>> V1ReviewOpened
        {
            add { this.AddEventHandler(ref this.v1ReviewOpened, value, "v1.review.opened"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1SetupIntentCanceledEventNotification>> V1SetupIntentCanceled
        {
            add { this.AddEventHandler(ref this.v1SetupIntentCanceled, value, "v1.setup_intent.canceled"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1SetupIntentCreatedEventNotification>> V1SetupIntentCreated
        {
            add { this.AddEventHandler(ref this.v1SetupIntentCreated, value, "v1.setup_intent.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1SetupIntentRequiresActionEventNotification>> V1SetupIntentRequiresAction
        {
            add { this.AddEventHandler(ref this.v1SetupIntentRequiresAction, value, "v1.setup_intent.requires_action"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1SetupIntentSetupFailedEventNotification>> V1SetupIntentSetupFailed
        {
            add { this.AddEventHandler(ref this.v1SetupIntentSetupFailed, value, "v1.setup_intent.setup_failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1SetupIntentSucceededEventNotification>> V1SetupIntentSucceeded
        {
            add { this.AddEventHandler(ref this.v1SetupIntentSucceeded, value, "v1.setup_intent.succeeded"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1SigmaScheduledQueryRunCreatedEventNotification>> V1SigmaScheduledQueryRunCreated
        {
            add { this.AddEventHandler(ref this.v1SigmaScheduledQueryRunCreated, value, "v1.sigma.scheduled_query_run.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1SourceCanceledEventNotification>> V1SourceCanceled
        {
            add { this.AddEventHandler(ref this.v1SourceCanceled, value, "v1.source.canceled"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1SourceChargeableEventNotification>> V1SourceChargeable
        {
            add { this.AddEventHandler(ref this.v1SourceChargeable, value, "v1.source.chargeable"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1SourceFailedEventNotification>> V1SourceFailed
        {
            add { this.AddEventHandler(ref this.v1SourceFailed, value, "v1.source.failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1SourceRefundAttributesRequiredEventNotification>> V1SourceRefundAttributesRequired
        {
            add { this.AddEventHandler(ref this.v1SourceRefundAttributesRequired, value, "v1.source.refund_attributes_required"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1SubscriptionScheduleAbortedEventNotification>> V1SubscriptionScheduleAborted
        {
            add { this.AddEventHandler(ref this.v1SubscriptionScheduleAborted, value, "v1.subscription_schedule.aborted"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1SubscriptionScheduleCanceledEventNotification>> V1SubscriptionScheduleCanceled
        {
            add { this.AddEventHandler(ref this.v1SubscriptionScheduleCanceled, value, "v1.subscription_schedule.canceled"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1SubscriptionScheduleCompletedEventNotification>> V1SubscriptionScheduleCompleted
        {
            add { this.AddEventHandler(ref this.v1SubscriptionScheduleCompleted, value, "v1.subscription_schedule.completed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1SubscriptionScheduleCreatedEventNotification>> V1SubscriptionScheduleCreated
        {
            add { this.AddEventHandler(ref this.v1SubscriptionScheduleCreated, value, "v1.subscription_schedule.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1SubscriptionScheduleExpiringEventNotification>> V1SubscriptionScheduleExpiring
        {
            add { this.AddEventHandler(ref this.v1SubscriptionScheduleExpiring, value, "v1.subscription_schedule.expiring"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1SubscriptionScheduleReleasedEventNotification>> V1SubscriptionScheduleReleased
        {
            add { this.AddEventHandler(ref this.v1SubscriptionScheduleReleased, value, "v1.subscription_schedule.released"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1SubscriptionScheduleUpdatedEventNotification>> V1SubscriptionScheduleUpdated
        {
            add { this.AddEventHandler(ref this.v1SubscriptionScheduleUpdated, value, "v1.subscription_schedule.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TaxSettingsUpdatedEventNotification>> V1TaxSettingsUpdated
        {
            add { this.AddEventHandler(ref this.v1TaxSettingsUpdated, value, "v1.tax.settings.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TaxRateCreatedEventNotification>> V1TaxRateCreated
        {
            add { this.AddEventHandler(ref this.v1TaxRateCreated, value, "v1.tax_rate.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TaxRateUpdatedEventNotification>> V1TaxRateUpdated
        {
            add { this.AddEventHandler(ref this.v1TaxRateUpdated, value, "v1.tax_rate.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TerminalReaderActionFailedEventNotification>> V1TerminalReaderActionFailed
        {
            add { this.AddEventHandler(ref this.v1TerminalReaderActionFailed, value, "v1.terminal.reader.action_failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TerminalReaderActionSucceededEventNotification>> V1TerminalReaderActionSucceeded
        {
            add { this.AddEventHandler(ref this.v1TerminalReaderActionSucceeded, value, "v1.terminal.reader.action_succeeded"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TerminalReaderActionUpdatedEventNotification>> V1TerminalReaderActionUpdated
        {
            add { this.AddEventHandler(ref this.v1TerminalReaderActionUpdated, value, "v1.terminal.reader.action_updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TestHelpersTestClockAdvancingEventNotification>> V1TestHelpersTestClockAdvancing
        {
            add { this.AddEventHandler(ref this.v1TestHelpersTestClockAdvancing, value, "v1.test_helpers.test_clock.advancing"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TestHelpersTestClockCreatedEventNotification>> V1TestHelpersTestClockCreated
        {
            add { this.AddEventHandler(ref this.v1TestHelpersTestClockCreated, value, "v1.test_helpers.test_clock.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TestHelpersTestClockDeletedEventNotification>> V1TestHelpersTestClockDeleted
        {
            add { this.AddEventHandler(ref this.v1TestHelpersTestClockDeleted, value, "v1.test_helpers.test_clock.deleted"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TestHelpersTestClockInternalFailureEventNotification>> V1TestHelpersTestClockInternalFailure
        {
            add { this.AddEventHandler(ref this.v1TestHelpersTestClockInternalFailure, value, "v1.test_helpers.test_clock.internal_failure"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TestHelpersTestClockReadyEventNotification>> V1TestHelpersTestClockReady
        {
            add { this.AddEventHandler(ref this.v1TestHelpersTestClockReady, value, "v1.test_helpers.test_clock.ready"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TopupCanceledEventNotification>> V1TopupCanceled
        {
            add { this.AddEventHandler(ref this.v1TopupCanceled, value, "v1.topup.canceled"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TopupCreatedEventNotification>> V1TopupCreated
        {
            add { this.AddEventHandler(ref this.v1TopupCreated, value, "v1.topup.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TopupFailedEventNotification>> V1TopupFailed
        {
            add { this.AddEventHandler(ref this.v1TopupFailed, value, "v1.topup.failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TopupReversedEventNotification>> V1TopupReversed
        {
            add { this.AddEventHandler(ref this.v1TopupReversed, value, "v1.topup.reversed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TopupSucceededEventNotification>> V1TopupSucceeded
        {
            add { this.AddEventHandler(ref this.v1TopupSucceeded, value, "v1.topup.succeeded"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TransferCreatedEventNotification>> V1TransferCreated
        {
            add { this.AddEventHandler(ref this.v1TransferCreated, value, "v1.transfer.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TransferReversedEventNotification>> V1TransferReversed
        {
            add { this.AddEventHandler(ref this.v1TransferReversed, value, "v1.transfer.reversed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1TransferUpdatedEventNotification>> V1TransferUpdated
        {
            add { this.AddEventHandler(ref this.v1TransferUpdated, value, "v1.transfer.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingCadenceBilledEventNotification>> V2BillingCadenceBilled
        {
            add { this.AddEventHandler(ref this.v2BillingCadenceBilled, value, "v2.billing.cadence.billed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingCadenceCanceledEventNotification>> V2BillingCadenceCanceled
        {
            add { this.AddEventHandler(ref this.v2BillingCadenceCanceled, value, "v2.billing.cadence.canceled"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingCadenceCreatedEventNotification>> V2BillingCadenceCreated
        {
            add { this.AddEventHandler(ref this.v2BillingCadenceCreated, value, "v2.billing.cadence.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingLicenseFeeCreatedEventNotification>> V2BillingLicenseFeeCreated
        {
            add { this.AddEventHandler(ref this.v2BillingLicenseFeeCreated, value, "v2.billing.license_fee.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingLicenseFeeUpdatedEventNotification>> V2BillingLicenseFeeUpdated
        {
            add { this.AddEventHandler(ref this.v2BillingLicenseFeeUpdated, value, "v2.billing.license_fee.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingLicenseFeeVersionCreatedEventNotification>> V2BillingLicenseFeeVersionCreated
        {
            add { this.AddEventHandler(ref this.v2BillingLicenseFeeVersionCreated, value, "v2.billing.license_fee_version.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingLicensedItemCreatedEventNotification>> V2BillingLicensedItemCreated
        {
            add { this.AddEventHandler(ref this.v2BillingLicensedItemCreated, value, "v2.billing.licensed_item.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingLicensedItemUpdatedEventNotification>> V2BillingLicensedItemUpdated
        {
            add { this.AddEventHandler(ref this.v2BillingLicensedItemUpdated, value, "v2.billing.licensed_item.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingMeteredItemCreatedEventNotification>> V2BillingMeteredItemCreated
        {
            add { this.AddEventHandler(ref this.v2BillingMeteredItemCreated, value, "v2.billing.metered_item.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingMeteredItemUpdatedEventNotification>> V2BillingMeteredItemUpdated
        {
            add { this.AddEventHandler(ref this.v2BillingMeteredItemUpdated, value, "v2.billing.metered_item.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanCreatedEventNotification>> V2BillingPricingPlanCreated
        {
            add { this.AddEventHandler(ref this.v2BillingPricingPlanCreated, value, "v2.billing.pricing_plan.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanUpdatedEventNotification>> V2BillingPricingPlanUpdated
        {
            add { this.AddEventHandler(ref this.v2BillingPricingPlanUpdated, value, "v2.billing.pricing_plan.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanComponentCreatedEventNotification>> V2BillingPricingPlanComponentCreated
        {
            add { this.AddEventHandler(ref this.v2BillingPricingPlanComponentCreated, value, "v2.billing.pricing_plan_component.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanComponentUpdatedEventNotification>> V2BillingPricingPlanComponentUpdated
        {
            add { this.AddEventHandler(ref this.v2BillingPricingPlanComponentUpdated, value, "v2.billing.pricing_plan_component.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanSubscriptionCollectionAwaitingCustomerActionEventNotification>> V2BillingPricingPlanSubscriptionCollectionAwaitingCustomerAction
        {
            add { this.AddEventHandler(ref this.v2BillingPricingPlanSubscriptionCollectionAwaitingCustomerAction, value, "v2.billing.pricing_plan_subscription.collection_awaiting_customer_action"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanSubscriptionCollectionCurrentEventNotification>> V2BillingPricingPlanSubscriptionCollectionCurrent
        {
            add { this.AddEventHandler(ref this.v2BillingPricingPlanSubscriptionCollectionCurrent, value, "v2.billing.pricing_plan_subscription.collection_current"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanSubscriptionCollectionPastDueEventNotification>> V2BillingPricingPlanSubscriptionCollectionPastDue
        {
            add { this.AddEventHandler(ref this.v2BillingPricingPlanSubscriptionCollectionPastDue, value, "v2.billing.pricing_plan_subscription.collection_past_due"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanSubscriptionCollectionPausedEventNotification>> V2BillingPricingPlanSubscriptionCollectionPaused
        {
            add { this.AddEventHandler(ref this.v2BillingPricingPlanSubscriptionCollectionPaused, value, "v2.billing.pricing_plan_subscription.collection_paused"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanSubscriptionCollectionUnpaidEventNotification>> V2BillingPricingPlanSubscriptionCollectionUnpaid
        {
            add { this.AddEventHandler(ref this.v2BillingPricingPlanSubscriptionCollectionUnpaid, value, "v2.billing.pricing_plan_subscription.collection_unpaid"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanSubscriptionServicingActivatedEventNotification>> V2BillingPricingPlanSubscriptionServicingActivated
        {
            add { this.AddEventHandler(ref this.v2BillingPricingPlanSubscriptionServicingActivated, value, "v2.billing.pricing_plan_subscription.servicing_activated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanSubscriptionServicingCanceledEventNotification>> V2BillingPricingPlanSubscriptionServicingCanceled
        {
            add { this.AddEventHandler(ref this.v2BillingPricingPlanSubscriptionServicingCanceled, value, "v2.billing.pricing_plan_subscription.servicing_canceled"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanSubscriptionServicingPausedEventNotification>> V2BillingPricingPlanSubscriptionServicingPaused
        {
            add { this.AddEventHandler(ref this.v2BillingPricingPlanSubscriptionServicingPaused, value, "v2.billing.pricing_plan_subscription.servicing_paused"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanVersionCreatedEventNotification>> V2BillingPricingPlanVersionCreated
        {
            add { this.AddEventHandler(ref this.v2BillingPricingPlanVersionCreated, value, "v2.billing.pricing_plan_version.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardCreatedEventNotification>> V2BillingRateCardCreated
        {
            add { this.AddEventHandler(ref this.v2BillingRateCardCreated, value, "v2.billing.rate_card.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardUpdatedEventNotification>> V2BillingRateCardUpdated
        {
            add { this.AddEventHandler(ref this.v2BillingRateCardUpdated, value, "v2.billing.rate_card.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardCustomPricingUnitOverageRateCreatedEventNotification>> V2BillingRateCardCustomPricingUnitOverageRateCreated
        {
            add { this.AddEventHandler(ref this.v2BillingRateCardCustomPricingUnitOverageRateCreated, value, "v2.billing.rate_card_custom_pricing_unit_overage_rate.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardRateCreatedEventNotification>> V2BillingRateCardRateCreated
        {
            add { this.AddEventHandler(ref this.v2BillingRateCardRateCreated, value, "v2.billing.rate_card_rate.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionActivatedEventNotification>> V2BillingRateCardSubscriptionActivated
        {
            add { this.AddEventHandler(ref this.v2BillingRateCardSubscriptionActivated, value, "v2.billing.rate_card_subscription.activated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionCanceledEventNotification>> V2BillingRateCardSubscriptionCanceled
        {
            add { this.AddEventHandler(ref this.v2BillingRateCardSubscriptionCanceled, value, "v2.billing.rate_card_subscription.canceled"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionCollectionAwaitingCustomerActionEventNotification>> V2BillingRateCardSubscriptionCollectionAwaitingCustomerAction
        {
            add { this.AddEventHandler(ref this.v2BillingRateCardSubscriptionCollectionAwaitingCustomerAction, value, "v2.billing.rate_card_subscription.collection_awaiting_customer_action"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionCollectionCurrentEventNotification>> V2BillingRateCardSubscriptionCollectionCurrent
        {
            add { this.AddEventHandler(ref this.v2BillingRateCardSubscriptionCollectionCurrent, value, "v2.billing.rate_card_subscription.collection_current"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionCollectionPastDueEventNotification>> V2BillingRateCardSubscriptionCollectionPastDue
        {
            add { this.AddEventHandler(ref this.v2BillingRateCardSubscriptionCollectionPastDue, value, "v2.billing.rate_card_subscription.collection_past_due"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionCollectionPausedEventNotification>> V2BillingRateCardSubscriptionCollectionPaused
        {
            add { this.AddEventHandler(ref this.v2BillingRateCardSubscriptionCollectionPaused, value, "v2.billing.rate_card_subscription.collection_paused"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionCollectionUnpaidEventNotification>> V2BillingRateCardSubscriptionCollectionUnpaid
        {
            add { this.AddEventHandler(ref this.v2BillingRateCardSubscriptionCollectionUnpaid, value, "v2.billing.rate_card_subscription.collection_unpaid"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionServicingActivatedEventNotification>> V2BillingRateCardSubscriptionServicingActivated
        {
            add { this.AddEventHandler(ref this.v2BillingRateCardSubscriptionServicingActivated, value, "v2.billing.rate_card_subscription.servicing_activated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionServicingCanceledEventNotification>> V2BillingRateCardSubscriptionServicingCanceled
        {
            add { this.AddEventHandler(ref this.v2BillingRateCardSubscriptionServicingCanceled, value, "v2.billing.rate_card_subscription.servicing_canceled"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionServicingPausedEventNotification>> V2BillingRateCardSubscriptionServicingPaused
        {
            add { this.AddEventHandler(ref this.v2BillingRateCardSubscriptionServicingPaused, value, "v2.billing.rate_card_subscription.servicing_paused"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardVersionCreatedEventNotification>> V2BillingRateCardVersionCreated
        {
            add { this.AddEventHandler(ref this.v2BillingRateCardVersionCreated, value, "v2.billing.rate_card_version.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CommerceProductCatalogImportsFailedEventNotification>> V2CommerceProductCatalogImportsFailed
        {
            add { this.AddEventHandler(ref this.v2CommerceProductCatalogImportsFailed, value, "v2.commerce.product_catalog.imports.failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CommerceProductCatalogImportsProcessingEventNotification>> V2CommerceProductCatalogImportsProcessing
        {
            add { this.AddEventHandler(ref this.v2CommerceProductCatalogImportsProcessing, value, "v2.commerce.product_catalog.imports.processing"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CommerceProductCatalogImportsSucceededEventNotification>> V2CommerceProductCatalogImportsSucceeded
        {
            add { this.AddEventHandler(ref this.v2CommerceProductCatalogImportsSucceeded, value, "v2.commerce.product_catalog.imports.succeeded"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CommerceProductCatalogImportsSucceededWithErrorsEventNotification>> V2CommerceProductCatalogImportsSucceededWithErrors
        {
            add { this.AddEventHandler(ref this.v2CommerceProductCatalogImportsSucceededWithErrors, value, "v2.commerce.product_catalog.imports.succeeded_with_errors"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountClosedEventNotification>> V2CoreAccountClosed
        {
            add { this.AddEventHandler(ref this.v2CoreAccountClosed, value, "v2.core.account.closed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountCreatedEventNotification>> V2CoreAccountCreated
        {
            add { this.AddEventHandler(ref this.v2CoreAccountCreated, value, "v2.core.account.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountUpdatedEventNotification>> V2CoreAccountUpdated
        {
            add { this.AddEventHandler(ref this.v2CoreAccountUpdated, value, "v2.core.account.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationCardCreatorCapabilityStatusUpdatedEventNotification>> V2CoreAccountIncludingConfigurationCardCreatorCapabilityStatusUpdated
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingConfigurationCardCreatorCapabilityStatusUpdated, value, "v2.core.account[configuration.card_creator].capability_status_updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationCardCreatorUpdatedEventNotification>> V2CoreAccountIncludingConfigurationCardCreatorUpdated
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingConfigurationCardCreatorUpdated, value, "v2.core.account[configuration.card_creator].updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdatedEventNotification>> V2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdated
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdated, value, "v2.core.account[configuration.customer].capability_status_updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationCustomerUpdatedEventNotification>> V2CoreAccountIncludingConfigurationCustomerUpdated
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingConfigurationCustomerUpdated, value, "v2.core.account[configuration.customer].updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationMerchantCapabilityStatusUpdatedEventNotification>> V2CoreAccountIncludingConfigurationMerchantCapabilityStatusUpdated
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingConfigurationMerchantCapabilityStatusUpdated, value, "v2.core.account[configuration.merchant].capability_status_updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationMerchantUpdatedEventNotification>> V2CoreAccountIncludingConfigurationMerchantUpdated
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingConfigurationMerchantUpdated, value, "v2.core.account[configuration.merchant].updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdatedEventNotification>> V2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdated
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdated, value, "v2.core.account[configuration.recipient].capability_status_updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationRecipientUpdatedEventNotification>> V2CoreAccountIncludingConfigurationRecipientUpdated
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingConfigurationRecipientUpdated, value, "v2.core.account[configuration.recipient].updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdatedEventNotification>> V2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdated
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdated, value, "v2.core.account[configuration.storer].capability_status_updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationStorerUpdatedEventNotification>> V2CoreAccountIncludingConfigurationStorerUpdated
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingConfigurationStorerUpdated, value, "v2.core.account[configuration.storer].updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingDefaultsUpdatedEventNotification>> V2CoreAccountIncludingDefaultsUpdated
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingDefaultsUpdated, value, "v2.core.account[defaults].updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingFutureRequirementsUpdatedEventNotification>> V2CoreAccountIncludingFutureRequirementsUpdated
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingFutureRequirementsUpdated, value, "v2.core.account[future_requirements].updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingIdentityUpdatedEventNotification>> V2CoreAccountIncludingIdentityUpdated
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingIdentityUpdated, value, "v2.core.account[identity].updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingRequirementsUpdatedEventNotification>> V2CoreAccountIncludingRequirementsUpdated
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingRequirementsUpdated, value, "v2.core.account[requirements].updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountLinkReturnedEventNotification>> V2CoreAccountLinkReturned
        {
            add { this.AddEventHandler(ref this.v2CoreAccountLinkReturned, value, "v2.core.account_link.returned"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountPersonCreatedEventNotification>> V2CoreAccountPersonCreated
        {
            add { this.AddEventHandler(ref this.v2CoreAccountPersonCreated, value, "v2.core.account_person.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountPersonDeletedEventNotification>> V2CoreAccountPersonDeleted
        {
            add { this.AddEventHandler(ref this.v2CoreAccountPersonDeleted, value, "v2.core.account_person.deleted"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountPersonUpdatedEventNotification>> V2CoreAccountPersonUpdated
        {
            add { this.AddEventHandler(ref this.v2CoreAccountPersonUpdated, value, "v2.core.account_person.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountSignalsFraudulentWebsiteReadyEventNotification>> V2CoreAccountSignalsFraudulentWebsiteReady
        {
            add { this.AddEventHandler(ref this.v2CoreAccountSignalsFraudulentWebsiteReady, value, "v2.core.account_signals.fraudulent_website_ready"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreApprovalRequestApprovedEventNotification>> V2CoreApprovalRequestApproved
        {
            add { this.AddEventHandler(ref this.v2CoreApprovalRequestApproved, value, "v2.core.approval_request.approved"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreApprovalRequestCanceledEventNotification>> V2CoreApprovalRequestCanceled
        {
            add { this.AddEventHandler(ref this.v2CoreApprovalRequestCanceled, value, "v2.core.approval_request.canceled"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreApprovalRequestCreatedEventNotification>> V2CoreApprovalRequestCreated
        {
            add { this.AddEventHandler(ref this.v2CoreApprovalRequestCreated, value, "v2.core.approval_request.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreApprovalRequestExpiredEventNotification>> V2CoreApprovalRequestExpired
        {
            add { this.AddEventHandler(ref this.v2CoreApprovalRequestExpired, value, "v2.core.approval_request.expired"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreApprovalRequestFailedEventNotification>> V2CoreApprovalRequestFailed
        {
            add { this.AddEventHandler(ref this.v2CoreApprovalRequestFailed, value, "v2.core.approval_request.failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreApprovalRequestRejectedEventNotification>> V2CoreApprovalRequestRejected
        {
            add { this.AddEventHandler(ref this.v2CoreApprovalRequestRejected, value, "v2.core.approval_request.rejected"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreApprovalRequestSucceededEventNotification>> V2CoreApprovalRequestSucceeded
        {
            add { this.AddEventHandler(ref this.v2CoreApprovalRequestSucceeded, value, "v2.core.approval_request.succeeded"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobBatchFailedEventNotification>> V2CoreBatchJobBatchFailed
        {
            add { this.AddEventHandler(ref this.v2CoreBatchJobBatchFailed, value, "v2.core.batch_job.batch_failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobCanceledEventNotification>> V2CoreBatchJobCanceled
        {
            add { this.AddEventHandler(ref this.v2CoreBatchJobCanceled, value, "v2.core.batch_job.canceled"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobCompletedEventNotification>> V2CoreBatchJobCompleted
        {
            add { this.AddEventHandler(ref this.v2CoreBatchJobCompleted, value, "v2.core.batch_job.completed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobCreatedEventNotification>> V2CoreBatchJobCreated
        {
            add { this.AddEventHandler(ref this.v2CoreBatchJobCreated, value, "v2.core.batch_job.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobReadyForUploadEventNotification>> V2CoreBatchJobReadyForUpload
        {
            add { this.AddEventHandler(ref this.v2CoreBatchJobReadyForUpload, value, "v2.core.batch_job.ready_for_upload"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobTimeoutEventNotification>> V2CoreBatchJobTimeout
        {
            add { this.AddEventHandler(ref this.v2CoreBatchJobTimeout, value, "v2.core.batch_job.timeout"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobUpdatedEventNotification>> V2CoreBatchJobUpdated
        {
            add { this.AddEventHandler(ref this.v2CoreBatchJobUpdated, value, "v2.core.batch_job.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobUploadTimeoutEventNotification>> V2CoreBatchJobUploadTimeout
        {
            add { this.AddEventHandler(ref this.v2CoreBatchJobUploadTimeout, value, "v2.core.batch_job.upload_timeout"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobValidatingEventNotification>> V2CoreBatchJobValidating
        {
            add { this.AddEventHandler(ref this.v2CoreBatchJobValidating, value, "v2.core.batch_job.validating"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobValidationFailedEventNotification>> V2CoreBatchJobValidationFailed
        {
            add { this.AddEventHandler(ref this.v2CoreBatchJobValidationFailed, value, "v2.core.batch_job.validation_failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreClaimableSandboxClaimedEventNotification>> V2CoreClaimableSandboxClaimed
        {
            add { this.AddEventHandler(ref this.v2CoreClaimableSandboxClaimed, value, "v2.core.claimable_sandbox.claimed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreClaimableSandboxCreatedEventNotification>> V2CoreClaimableSandboxCreated
        {
            add { this.AddEventHandler(ref this.v2CoreClaimableSandboxCreated, value, "v2.core.claimable_sandbox.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreClaimableSandboxExpiredEventNotification>> V2CoreClaimableSandboxExpired
        {
            add { this.AddEventHandler(ref this.v2CoreClaimableSandboxExpired, value, "v2.core.claimable_sandbox.expired"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreClaimableSandboxExpiringEventNotification>> V2CoreClaimableSandboxExpiring
        {
            add { this.AddEventHandler(ref this.v2CoreClaimableSandboxExpiring, value, "v2.core.claimable_sandbox.expiring"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreClaimableSandboxUpdatedEventNotification>> V2CoreClaimableSandboxUpdated
        {
            add { this.AddEventHandler(ref this.v2CoreClaimableSandboxUpdated, value, "v2.core.claimable_sandbox.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreEventDestinationPingEventNotification>> V2CoreEventDestinationPing
        {
            add { this.AddEventHandler(ref this.v2CoreEventDestinationPing, value, "v2.core.event_destination.ping"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthApiErrorFiringEventNotification>> V2CoreHealthApiErrorFiring
        {
            add { this.AddEventHandler(ref this.v2CoreHealthApiErrorFiring, value, "v2.core.health.api_error.firing"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthApiErrorResolvedEventNotification>> V2CoreHealthApiErrorResolved
        {
            add { this.AddEventHandler(ref this.v2CoreHealthApiErrorResolved, value, "v2.core.health.api_error.resolved"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthApiLatencyFiringEventNotification>> V2CoreHealthApiLatencyFiring
        {
            add { this.AddEventHandler(ref this.v2CoreHealthApiLatencyFiring, value, "v2.core.health.api_latency.firing"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthApiLatencyResolvedEventNotification>> V2CoreHealthApiLatencyResolved
        {
            add { this.AddEventHandler(ref this.v2CoreHealthApiLatencyResolved, value, "v2.core.health.api_latency.resolved"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthAuthorizationRateDropFiringEventNotification>> V2CoreHealthAuthorizationRateDropFiring
        {
            add { this.AddEventHandler(ref this.v2CoreHealthAuthorizationRateDropFiring, value, "v2.core.health.authorization_rate_drop.firing"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthAuthorizationRateDropResolvedEventNotification>> V2CoreHealthAuthorizationRateDropResolved
        {
            add { this.AddEventHandler(ref this.v2CoreHealthAuthorizationRateDropResolved, value, "v2.core.health.authorization_rate_drop.resolved"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthElementsErrorFiringEventNotification>> V2CoreHealthElementsErrorFiring
        {
            add { this.AddEventHandler(ref this.v2CoreHealthElementsErrorFiring, value, "v2.core.health.elements_error.firing"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthElementsErrorResolvedEventNotification>> V2CoreHealthElementsErrorResolved
        {
            add { this.AddEventHandler(ref this.v2CoreHealthElementsErrorResolved, value, "v2.core.health.elements_error.resolved"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthEventGenerationFailureResolvedEventNotification>> V2CoreHealthEventGenerationFailureResolved
        {
            add { this.AddEventHandler(ref this.v2CoreHealthEventGenerationFailureResolved, value, "v2.core.health.event_generation_failure.resolved"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthFraudRateIncreasedEventNotification>> V2CoreHealthFraudRateIncreased
        {
            add { this.AddEventHandler(ref this.v2CoreHealthFraudRateIncreased, value, "v2.core.health.fraud_rate.increased"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthInvoiceCountDroppedFiringEventNotification>> V2CoreHealthInvoiceCountDroppedFiring
        {
            add { this.AddEventHandler(ref this.v2CoreHealthInvoiceCountDroppedFiring, value, "v2.core.health.invoice_count_dropped.firing"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthInvoiceCountDroppedResolvedEventNotification>> V2CoreHealthInvoiceCountDroppedResolved
        {
            add { this.AddEventHandler(ref this.v2CoreHealthInvoiceCountDroppedResolved, value, "v2.core.health.invoice_count_dropped.resolved"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthIssuingAuthorizationRequestErrorsFiringEventNotification>> V2CoreHealthIssuingAuthorizationRequestErrorsFiring
        {
            add { this.AddEventHandler(ref this.v2CoreHealthIssuingAuthorizationRequestErrorsFiring, value, "v2.core.health.issuing_authorization_request_errors.firing"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthIssuingAuthorizationRequestErrorsResolvedEventNotification>> V2CoreHealthIssuingAuthorizationRequestErrorsResolved
        {
            add { this.AddEventHandler(ref this.v2CoreHealthIssuingAuthorizationRequestErrorsResolved, value, "v2.core.health.issuing_authorization_request_errors.resolved"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthIssuingAuthorizationRequestTimeoutFiringEventNotification>> V2CoreHealthIssuingAuthorizationRequestTimeoutFiring
        {
            add { this.AddEventHandler(ref this.v2CoreHealthIssuingAuthorizationRequestTimeoutFiring, value, "v2.core.health.issuing_authorization_request_timeout.firing"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthIssuingAuthorizationRequestTimeoutResolvedEventNotification>> V2CoreHealthIssuingAuthorizationRequestTimeoutResolved
        {
            add { this.AddEventHandler(ref this.v2CoreHealthIssuingAuthorizationRequestTimeoutResolved, value, "v2.core.health.issuing_authorization_request_timeout.resolved"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthMeterEventSummariesDelayedFiringEventNotification>> V2CoreHealthMeterEventSummariesDelayedFiring
        {
            add { this.AddEventHandler(ref this.v2CoreHealthMeterEventSummariesDelayedFiring, value, "v2.core.health.meter_event_summaries_delayed.firing"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthMeterEventSummariesDelayedResolvedEventNotification>> V2CoreHealthMeterEventSummariesDelayedResolved
        {
            add { this.AddEventHandler(ref this.v2CoreHealthMeterEventSummariesDelayedResolved, value, "v2.core.health.meter_event_summaries_delayed.resolved"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthPaymentMethodErrorFiringEventNotification>> V2CoreHealthPaymentMethodErrorFiring
        {
            add { this.AddEventHandler(ref this.v2CoreHealthPaymentMethodErrorFiring, value, "v2.core.health.payment_method_error.firing"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthPaymentMethodErrorResolvedEventNotification>> V2CoreHealthPaymentMethodErrorResolved
        {
            add { this.AddEventHandler(ref this.v2CoreHealthPaymentMethodErrorResolved, value, "v2.core.health.payment_method_error.resolved"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthSepaDebitDelayedFiringEventNotification>> V2CoreHealthSepaDebitDelayedFiring
        {
            add { this.AddEventHandler(ref this.v2CoreHealthSepaDebitDelayedFiring, value, "v2.core.health.sepa_debit_delayed.firing"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthSepaDebitDelayedResolvedEventNotification>> V2CoreHealthSepaDebitDelayedResolved
        {
            add { this.AddEventHandler(ref this.v2CoreHealthSepaDebitDelayedResolved, value, "v2.core.health.sepa_debit_delayed.resolved"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthTrafficVolumeDropFiringEventNotification>> V2CoreHealthTrafficVolumeDropFiring
        {
            add { this.AddEventHandler(ref this.v2CoreHealthTrafficVolumeDropFiring, value, "v2.core.health.traffic_volume_drop.firing"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthTrafficVolumeDropResolvedEventNotification>> V2CoreHealthTrafficVolumeDropResolved
        {
            add { this.AddEventHandler(ref this.v2CoreHealthTrafficVolumeDropResolved, value, "v2.core.health.traffic_volume_drop.resolved"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthWebhookLatencyFiringEventNotification>> V2CoreHealthWebhookLatencyFiring
        {
            add { this.AddEventHandler(ref this.v2CoreHealthWebhookLatencyFiring, value, "v2.core.health.webhook_latency.firing"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthWebhookLatencyResolvedEventNotification>> V2CoreHealthWebhookLatencyResolved
        {
            add { this.AddEventHandler(ref this.v2CoreHealthWebhookLatencyResolved, value, "v2.core.health.webhook_latency.resolved"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2DataReportingQueryRunCreatedEventNotification>> V2DataReportingQueryRunCreated
        {
            add { this.AddEventHandler(ref this.v2DataReportingQueryRunCreated, value, "v2.data.reporting.query_run.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2DataReportingQueryRunFailedEventNotification>> V2DataReportingQueryRunFailed
        {
            add { this.AddEventHandler(ref this.v2DataReportingQueryRunFailed, value, "v2.data.reporting.query_run.failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2DataReportingQueryRunSucceededEventNotification>> V2DataReportingQueryRunSucceeded
        {
            add { this.AddEventHandler(ref this.v2DataReportingQueryRunSucceeded, value, "v2.data.reporting.query_run.succeeded"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2DataReportingQueryRunUpdatedEventNotification>> V2DataReportingQueryRunUpdated
        {
            add { this.AddEventHandler(ref this.v2DataReportingQueryRunUpdated, value, "v2.data.reporting.query_run.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2ExtendExtensionRunFailedEventNotification>> V2ExtendExtensionRunFailed
        {
            add { this.AddEventHandler(ref this.v2ExtendExtensionRunFailed, value, "v2.extend.extension_run.failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2ExtendWorkflowRunFailedEventNotification>> V2ExtendWorkflowRunFailed
        {
            add { this.AddEventHandler(ref this.v2ExtendWorkflowRunFailed, value, "v2.extend.workflow_run.failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2ExtendWorkflowRunStartedEventNotification>> V2ExtendWorkflowRunStarted
        {
            add { this.AddEventHandler(ref this.v2ExtendWorkflowRunStarted, value, "v2.extend.workflow_run.started"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2ExtendWorkflowRunSucceededEventNotification>> V2ExtendWorkflowRunSucceeded
        {
            add { this.AddEventHandler(ref this.v2ExtendWorkflowRunSucceeded, value, "v2.extend.workflow_run.succeeded"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2IamApiKeyCreatedEventNotification>> V2IamApiKeyCreated
        {
            add { this.AddEventHandler(ref this.v2IamApiKeyCreated, value, "v2.iam.api_key.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2IamApiKeyDefaultSecretRevealedEventNotification>> V2IamApiKeyDefaultSecretRevealed
        {
            add { this.AddEventHandler(ref this.v2IamApiKeyDefaultSecretRevealed, value, "v2.iam.api_key.default_secret_revealed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2IamApiKeyExpiredEventNotification>> V2IamApiKeyExpired
        {
            add { this.AddEventHandler(ref this.v2IamApiKeyExpired, value, "v2.iam.api_key.expired"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2IamApiKeyPermissionsUpdatedEventNotification>> V2IamApiKeyPermissionsUpdated
        {
            add { this.AddEventHandler(ref this.v2IamApiKeyPermissionsUpdated, value, "v2.iam.api_key.permissions_updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2IamApiKeyRotatedEventNotification>> V2IamApiKeyRotated
        {
            add { this.AddEventHandler(ref this.v2IamApiKeyRotated, value, "v2.iam.api_key.rotated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2IamApiKeyUpdatedEventNotification>> V2IamApiKeyUpdated
        {
            add { this.AddEventHandler(ref this.v2IamApiKeyUpdated, value, "v2.iam.api_key.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2IamStripeAccessGrantApprovedEventNotification>> V2IamStripeAccessGrantApproved
        {
            add { this.AddEventHandler(ref this.v2IamStripeAccessGrantApproved, value, "v2.iam.stripe_access_grant.approved"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2IamStripeAccessGrantCanceledEventNotification>> V2IamStripeAccessGrantCanceled
        {
            add { this.AddEventHandler(ref this.v2IamStripeAccessGrantCanceled, value, "v2.iam.stripe_access_grant.canceled"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2IamStripeAccessGrantDeniedEventNotification>> V2IamStripeAccessGrantDenied
        {
            add { this.AddEventHandler(ref this.v2IamStripeAccessGrantDenied, value, "v2.iam.stripe_access_grant.denied"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2IamStripeAccessGrantRemovedEventNotification>> V2IamStripeAccessGrantRemoved
        {
            add { this.AddEventHandler(ref this.v2IamStripeAccessGrantRemoved, value, "v2.iam.stripe_access_grant.removed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2IamStripeAccessGrantRequestedEventNotification>> V2IamStripeAccessGrantRequested
        {
            add { this.AddEventHandler(ref this.v2IamStripeAccessGrantRequested, value, "v2.iam.stripe_access_grant.requested"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2IamStripeAccessGrantUpdatedEventNotification>> V2IamStripeAccessGrantUpdated
        {
            add { this.AddEventHandler(ref this.v2IamStripeAccessGrantUpdated, value, "v2.iam.stripe_access_grant.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementAdjustmentCreatedEventNotification>> V2MoneyManagementAdjustmentCreated
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementAdjustmentCreated, value, "v2.money_management.adjustment.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAccountCreatedEventNotification>> V2MoneyManagementFinancialAccountCreated
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementFinancialAccountCreated, value, "v2.money_management.financial_account.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAccountUpdatedEventNotification>> V2MoneyManagementFinancialAccountUpdated
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementFinancialAccountUpdated, value, "v2.money_management.financial_account.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAccountStatementCreatedEventNotification>> V2MoneyManagementFinancialAccountStatementCreated
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementFinancialAccountStatementCreated, value, "v2.money_management.financial_account_statement.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAccountStatementRestatedEventNotification>> V2MoneyManagementFinancialAccountStatementRestated
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementFinancialAccountStatementRestated, value, "v2.money_management.financial_account_statement.restated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAddressActivatedEventNotification>> V2MoneyManagementFinancialAddressActivated
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementFinancialAddressActivated, value, "v2.money_management.financial_address.activated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAddressFailedEventNotification>> V2MoneyManagementFinancialAddressFailed
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementFinancialAddressFailed, value, "v2.money_management.financial_address.failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferAvailableEventNotification>> V2MoneyManagementInboundTransferAvailable
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementInboundTransferAvailable, value, "v2.money_management.inbound_transfer.available"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitFailedEventNotification>> V2MoneyManagementInboundTransferBankDebitFailed
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementInboundTransferBankDebitFailed, value, "v2.money_management.inbound_transfer.bank_debit_failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitProcessingEventNotification>> V2MoneyManagementInboundTransferBankDebitProcessing
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementInboundTransferBankDebitProcessing, value, "v2.money_management.inbound_transfer.bank_debit_processing"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitQueuedEventNotification>> V2MoneyManagementInboundTransferBankDebitQueued
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementInboundTransferBankDebitQueued, value, "v2.money_management.inbound_transfer.bank_debit_queued"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitReturnedEventNotification>> V2MoneyManagementInboundTransferBankDebitReturned
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementInboundTransferBankDebitReturned, value, "v2.money_management.inbound_transfer.bank_debit_returned"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitSucceededEventNotification>> V2MoneyManagementInboundTransferBankDebitSucceeded
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementInboundTransferBankDebitSucceeded, value, "v2.money_management.inbound_transfer.bank_debit_succeeded"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentCanceledEventNotification>> V2MoneyManagementOutboundPaymentCanceled
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundPaymentCanceled, value, "v2.money_management.outbound_payment.canceled"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentCreatedEventNotification>> V2MoneyManagementOutboundPaymentCreated
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundPaymentCreated, value, "v2.money_management.outbound_payment.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentFailedEventNotification>> V2MoneyManagementOutboundPaymentFailed
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundPaymentFailed, value, "v2.money_management.outbound_payment.failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentPostedEventNotification>> V2MoneyManagementOutboundPaymentPosted
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundPaymentPosted, value, "v2.money_management.outbound_payment.posted"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentReturnedEventNotification>> V2MoneyManagementOutboundPaymentReturned
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundPaymentReturned, value, "v2.money_management.outbound_payment.returned"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentUpdatedEventNotification>> V2MoneyManagementOutboundPaymentUpdated
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundPaymentUpdated, value, "v2.money_management.outbound_payment.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferCanceledEventNotification>> V2MoneyManagementOutboundTransferCanceled
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundTransferCanceled, value, "v2.money_management.outbound_transfer.canceled"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferCreatedEventNotification>> V2MoneyManagementOutboundTransferCreated
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundTransferCreated, value, "v2.money_management.outbound_transfer.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferFailedEventNotification>> V2MoneyManagementOutboundTransferFailed
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundTransferFailed, value, "v2.money_management.outbound_transfer.failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferPostedEventNotification>> V2MoneyManagementOutboundTransferPosted
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundTransferPosted, value, "v2.money_management.outbound_transfer.posted"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferReturnedEventNotification>> V2MoneyManagementOutboundTransferReturned
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundTransferReturned, value, "v2.money_management.outbound_transfer.returned"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferUpdatedEventNotification>> V2MoneyManagementOutboundTransferUpdated
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundTransferUpdated, value, "v2.money_management.outbound_transfer.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementPayoutMethodCreatedEventNotification>> V2MoneyManagementPayoutMethodCreated
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementPayoutMethodCreated, value, "v2.money_management.payout_method.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementPayoutMethodUpdatedEventNotification>> V2MoneyManagementPayoutMethodUpdated
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementPayoutMethodUpdated, value, "v2.money_management.payout_method.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditAvailableEventNotification>> V2MoneyManagementReceivedCreditAvailable
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementReceivedCreditAvailable, value, "v2.money_management.received_credit.available"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditFailedEventNotification>> V2MoneyManagementReceivedCreditFailed
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementReceivedCreditFailed, value, "v2.money_management.received_credit.failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditReturnedEventNotification>> V2MoneyManagementReceivedCreditReturned
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementReceivedCreditReturned, value, "v2.money_management.received_credit.returned"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditSucceededEventNotification>> V2MoneyManagementReceivedCreditSucceeded
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementReceivedCreditSucceeded, value, "v2.money_management.received_credit.succeeded"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitCanceledEventNotification>> V2MoneyManagementReceivedDebitCanceled
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementReceivedDebitCanceled, value, "v2.money_management.received_debit.canceled"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitFailedEventNotification>> V2MoneyManagementReceivedDebitFailed
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementReceivedDebitFailed, value, "v2.money_management.received_debit.failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitPendingEventNotification>> V2MoneyManagementReceivedDebitPending
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementReceivedDebitPending, value, "v2.money_management.received_debit.pending"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitSucceededEventNotification>> V2MoneyManagementReceivedDebitSucceeded
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementReceivedDebitSucceeded, value, "v2.money_management.received_debit.succeeded"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitUpdatedEventNotification>> V2MoneyManagementReceivedDebitUpdated
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementReceivedDebitUpdated, value, "v2.money_management.received_debit.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementRecipientVerificationCreatedEventNotification>> V2MoneyManagementRecipientVerificationCreated
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementRecipientVerificationCreated, value, "v2.money_management.recipient_verification.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementRecipientVerificationUpdatedEventNotification>> V2MoneyManagementRecipientVerificationUpdated
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementRecipientVerificationUpdated, value, "v2.money_management.recipient_verification.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementTransactionCreatedEventNotification>> V2MoneyManagementTransactionCreated
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementTransactionCreated, value, "v2.money_management.transaction.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementTransactionUpdatedEventNotification>> V2MoneyManagementTransactionUpdated
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementTransactionUpdated, value, "v2.money_management.transaction.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2OrchestratedCommerceAgreementConfirmedEventNotification>> V2OrchestratedCommerceAgreementConfirmed
        {
            add { this.AddEventHandler(ref this.v2OrchestratedCommerceAgreementConfirmed, value, "v2.orchestrated_commerce.agreement.confirmed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2OrchestratedCommerceAgreementCreatedEventNotification>> V2OrchestratedCommerceAgreementCreated
        {
            add { this.AddEventHandler(ref this.v2OrchestratedCommerceAgreementCreated, value, "v2.orchestrated_commerce.agreement.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2OrchestratedCommerceAgreementPartiallyConfirmedEventNotification>> V2OrchestratedCommerceAgreementPartiallyConfirmed
        {
            add { this.AddEventHandler(ref this.v2OrchestratedCommerceAgreementPartiallyConfirmed, value, "v2.orchestrated_commerce.agreement.partially_confirmed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2OrchestratedCommerceAgreementTerminatedEventNotification>> V2OrchestratedCommerceAgreementTerminated
        {
            add { this.AddEventHandler(ref this.v2OrchestratedCommerceAgreementTerminated, value, "v2.orchestrated_commerce.agreement.terminated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentAttemptFailedEventNotification>> V2PaymentsOffSessionPaymentAttemptFailed
        {
            add { this.AddEventHandler(ref this.v2PaymentsOffSessionPaymentAttemptFailed, value, "v2.payments.off_session_payment.attempt_failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentAttemptStartedEventNotification>> V2PaymentsOffSessionPaymentAttemptStarted
        {
            add { this.AddEventHandler(ref this.v2PaymentsOffSessionPaymentAttemptStarted, value, "v2.payments.off_session_payment.attempt_started"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentAuthorizationAttemptFailedEventNotification>> V2PaymentsOffSessionPaymentAuthorizationAttemptFailed
        {
            add { this.AddEventHandler(ref this.v2PaymentsOffSessionPaymentAuthorizationAttemptFailed, value, "v2.payments.off_session_payment.authorization_attempt_failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentAuthorizationAttemptStartedEventNotification>> V2PaymentsOffSessionPaymentAuthorizationAttemptStarted
        {
            add { this.AddEventHandler(ref this.v2PaymentsOffSessionPaymentAuthorizationAttemptStarted, value, "v2.payments.off_session_payment.authorization_attempt_started"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentCanceledEventNotification>> V2PaymentsOffSessionPaymentCanceled
        {
            add { this.AddEventHandler(ref this.v2PaymentsOffSessionPaymentCanceled, value, "v2.payments.off_session_payment.canceled"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentCreatedEventNotification>> V2PaymentsOffSessionPaymentCreated
        {
            add { this.AddEventHandler(ref this.v2PaymentsOffSessionPaymentCreated, value, "v2.payments.off_session_payment.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentFailedEventNotification>> V2PaymentsOffSessionPaymentFailed
        {
            add { this.AddEventHandler(ref this.v2PaymentsOffSessionPaymentFailed, value, "v2.payments.off_session_payment.failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentPausedEventNotification>> V2PaymentsOffSessionPaymentPaused
        {
            add { this.AddEventHandler(ref this.v2PaymentsOffSessionPaymentPaused, value, "v2.payments.off_session_payment.paused"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentRequiresCaptureEventNotification>> V2PaymentsOffSessionPaymentRequiresCapture
        {
            add { this.AddEventHandler(ref this.v2PaymentsOffSessionPaymentRequiresCapture, value, "v2.payments.off_session_payment.requires_capture"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentResumedEventNotification>> V2PaymentsOffSessionPaymentResumed
        {
            add { this.AddEventHandler(ref this.v2PaymentsOffSessionPaymentResumed, value, "v2.payments.off_session_payment.resumed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentSucceededEventNotification>> V2PaymentsOffSessionPaymentSucceeded
        {
            add { this.AddEventHandler(ref this.v2PaymentsOffSessionPaymentSucceeded, value, "v2.payments.off_session_payment.succeeded"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentCanceledEventNotification>> V2PaymentsSettlementAllocationIntentCanceled
        {
            add { this.AddEventHandler(ref this.v2PaymentsSettlementAllocationIntentCanceled, value, "v2.payments.settlement_allocation_intent.canceled"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentCreatedEventNotification>> V2PaymentsSettlementAllocationIntentCreated
        {
            add { this.AddEventHandler(ref this.v2PaymentsSettlementAllocationIntentCreated, value, "v2.payments.settlement_allocation_intent.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentErroredEventNotification>> V2PaymentsSettlementAllocationIntentErrored
        {
            add { this.AddEventHandler(ref this.v2PaymentsSettlementAllocationIntentErrored, value, "v2.payments.settlement_allocation_intent.errored"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentFundsNotReceivedEventNotification>> V2PaymentsSettlementAllocationIntentFundsNotReceived
        {
            add { this.AddEventHandler(ref this.v2PaymentsSettlementAllocationIntentFundsNotReceived, value, "v2.payments.settlement_allocation_intent.funds_not_received"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentMatchedEventNotification>> V2PaymentsSettlementAllocationIntentMatched
        {
            add { this.AddEventHandler(ref this.v2PaymentsSettlementAllocationIntentMatched, value, "v2.payments.settlement_allocation_intent.matched"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentNotFoundEventNotification>> V2PaymentsSettlementAllocationIntentNotFound
        {
            add { this.AddEventHandler(ref this.v2PaymentsSettlementAllocationIntentNotFound, value, "v2.payments.settlement_allocation_intent.not_found"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentSettledEventNotification>> V2PaymentsSettlementAllocationIntentSettled
        {
            add { this.AddEventHandler(ref this.v2PaymentsSettlementAllocationIntentSettled, value, "v2.payments.settlement_allocation_intent.settled"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentSubmittedEventNotification>> V2PaymentsSettlementAllocationIntentSubmitted
        {
            add { this.AddEventHandler(ref this.v2PaymentsSettlementAllocationIntentSubmitted, value, "v2.payments.settlement_allocation_intent.submitted"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentSplitCanceledEventNotification>> V2PaymentsSettlementAllocationIntentSplitCanceled
        {
            add { this.AddEventHandler(ref this.v2PaymentsSettlementAllocationIntentSplitCanceled, value, "v2.payments.settlement_allocation_intent_split.canceled"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentSplitCreatedEventNotification>> V2PaymentsSettlementAllocationIntentSplitCreated
        {
            add { this.AddEventHandler(ref this.v2PaymentsSettlementAllocationIntentSplitCreated, value, "v2.payments.settlement_allocation_intent_split.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentSplitSettledEventNotification>> V2PaymentsSettlementAllocationIntentSplitSettled
        {
            add { this.AddEventHandler(ref this.v2PaymentsSettlementAllocationIntentSplitSettled, value, "v2.payments.settlement_allocation_intent_split.settled"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2ReportingReportRunCreatedEventNotification>> V2ReportingReportRunCreated
        {
            add { this.AddEventHandler(ref this.v2ReportingReportRunCreated, value, "v2.reporting.report_run.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2ReportingReportRunFailedEventNotification>> V2ReportingReportRunFailed
        {
            add { this.AddEventHandler(ref this.v2ReportingReportRunFailed, value, "v2.reporting.report_run.failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2ReportingReportRunSucceededEventNotification>> V2ReportingReportRunSucceeded
        {
            add { this.AddEventHandler(ref this.v2ReportingReportRunSucceeded, value, "v2.reporting.report_run.succeeded"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2ReportingReportRunUpdatedEventNotification>> V2ReportingReportRunUpdated
        {
            add { this.AddEventHandler(ref this.v2ReportingReportRunUpdated, value, "v2.reporting.report_run.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2SignalsAccountSignalFraudulentMerchantReadyEventNotification>> V2SignalsAccountSignalFraudulentMerchantReady
        {
            add { this.AddEventHandler(ref this.v2SignalsAccountSignalFraudulentMerchantReady, value, "v2.signals.account_signal.fraudulent_merchant_ready"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2SignalsAccountSignalMerchantDelinquencyReadyEventNotification>> V2SignalsAccountSignalMerchantDelinquencyReady
        {
            add { this.AddEventHandler(ref this.v2SignalsAccountSignalMerchantDelinquencyReady, value, "v2.signals.account_signal.merchant_delinquency_ready"); }
            remove { this.RemoveEventHandler(); }
        }

        // public-event-handlers: The end of the section generated from our OpenAPI spec

        /// <summary>
        /// Centralizes the logic for adding event handlers.
        /// </summary>
        private void AddEventHandler<T>(ref EventHandler<T> handler, EventHandler<T> value, string eventType)
        where T : EventArgs
        {
            if (this.handledEventTypes.Add(eventType))
            {
                handler = value;
            }
            else
            {
                throw new InvalidOperationException($"A handler for event type '{eventType}' is already registered. Only one handler per event type is allowed.");
            }
        }

        /// <summary>
        /// Centralizes the logic for removing event handlers.
        /// </summary>
        private void RemoveEventHandler()
        {
            throw new InvalidOperationException("Removing handlers is not supported.");
        }

        /// <summary>
        /// Handles an incoming webhook by parsing the payload, validating the signature,
        /// and dispatching to the registered handler if one exists.
        /// </summary>
        /// <param name="json">The JSON payload from the webhook request body.</param>
        /// <param name="stripeSignatureHeader">The Stripe-Signature header value.</param>
        /// <exception cref="ArgumentNullException">Thrown if any required parameter is null.</exception>
        /// <exception cref="StripeException">Thrown if signature validation fails or parsing fails.</exception>
        /// TODO: allow async?
        public void Handle(
            string json,
            string stripeSignatureHeader)
        {
            // this.hasHandledEvent = true;
            if (json == null)
            {
                throw new ArgumentNullException(nameof(json));
            }

            if (stripeSignatureHeader == null)
            {
                throw new ArgumentNullException(nameof(stripeSignatureHeader));
            }

            // Parse and validate the event notification
            var eventNotification = this.client.ParseEventNotification(json, stripeSignatureHeader, this.webhookSecret);

            // Dispatch to the registered handler with the event's context
            this.DispatchEventWithContext(eventNotification);
        }

        /// <summary>
        /// Returns a sorted list of event types that have registered handlers.
        /// </summary>
        /// <returns></returns>
        public List<string> HandledEventTypes()
        {
            var events = new List<string>(this.handledEventTypes);
            events.Sort();
            return events;
        }

        /// <summary>
        /// Dispatches the event with the event's StripeContext by creating a new client instance.
        /// </summary>
        /// <param name="eventNotification">The event notification to dispatch.</param>
        private void DispatchEventWithContext(V2.Core.EventNotification eventNotification)
        {
            if (eventNotification == null)
            {
                throw new ArgumentNullException(nameof(eventNotification));
            }

            // If client options somehow didn't get created, bail.
            if (this.clientOptions == null)
            {
                throw new InvalidOperationException("Unable to create client with event context: client options not available.");
            }

            // Create a new client with the event's context
            var eventClientOptions = this.clientOptions.Clone();
            eventClientOptions.StripeContext = eventNotification.Context;
            var eventClient = new StripeClient(eventClientOptions);

            this.DispatchEvent(eventNotification, eventClient);
        }

        private void DispatchEvent(V2.Core.EventNotification eventNotification, StripeClient client)
        {
            if (eventNotification == null)
            {
                throw new ArgumentNullException(nameof(eventNotification));
            }

            if (this.handledEventTypes.Contains(eventNotification.Type))
            {
                // Known event type; dispatch to the appropriate handler
                if (false)
                {
                    // so all of our generated handlers can be `else if`s
                }

                // event-handler-dispatch: The beginning of the section generated from our OpenAPI spec
                else if (eventNotification is Stripe.Events.V1AccountApplicationAuthorizedEventNotification)
                {
                    this.v1AccountApplicationAuthorized.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1AccountApplicationAuthorizedEventNotification>((Stripe.Events.V1AccountApplicationAuthorizedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1AccountApplicationDeauthorizedEventNotification)
                {
                    this.v1AccountApplicationDeauthorized.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1AccountApplicationDeauthorizedEventNotification>((Stripe.Events.V1AccountApplicationDeauthorizedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1AccountExternalAccountCreatedEventNotification)
                {
                    this.v1AccountExternalAccountCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1AccountExternalAccountCreatedEventNotification>((Stripe.Events.V1AccountExternalAccountCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1AccountExternalAccountDeletedEventNotification)
                {
                    this.v1AccountExternalAccountDeleted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1AccountExternalAccountDeletedEventNotification>((Stripe.Events.V1AccountExternalAccountDeletedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1AccountExternalAccountUpdatedEventNotification)
                {
                    this.v1AccountExternalAccountUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1AccountExternalAccountUpdatedEventNotification>((Stripe.Events.V1AccountExternalAccountUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1AccountUpdatedEventNotification)
                {
                    this.v1AccountUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1AccountUpdatedEventNotification>((Stripe.Events.V1AccountUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1AccountSignalsIncludingDelinquencyCreatedEventNotification)
                {
                    this.v1AccountSignalsIncludingDelinquencyCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1AccountSignalsIncludingDelinquencyCreatedEventNotification>((Stripe.Events.V1AccountSignalsIncludingDelinquencyCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ApplicationFeeCreatedEventNotification)
                {
                    this.v1ApplicationFeeCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ApplicationFeeCreatedEventNotification>((Stripe.Events.V1ApplicationFeeCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ApplicationFeeRefundUpdatedEventNotification)
                {
                    this.v1ApplicationFeeRefundUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ApplicationFeeRefundUpdatedEventNotification>((Stripe.Events.V1ApplicationFeeRefundUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ApplicationFeeRefundedEventNotification)
                {
                    this.v1ApplicationFeeRefunded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ApplicationFeeRefundedEventNotification>((Stripe.Events.V1ApplicationFeeRefundedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1BalanceAvailableEventNotification)
                {
                    this.v1BalanceAvailable.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1BalanceAvailableEventNotification>((Stripe.Events.V1BalanceAvailableEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1BillingAlertTriggeredEventNotification)
                {
                    this.v1BillingAlertTriggered.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1BillingAlertTriggeredEventNotification>((Stripe.Events.V1BillingAlertTriggeredEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1BillingMeterErrorReportTriggeredEventNotification)
                {
                    this.v1BillingMeterErrorReportTriggered.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterErrorReportTriggeredEventNotification>((Stripe.Events.V1BillingMeterErrorReportTriggeredEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1BillingMeterNoMeterFoundEventNotification)
                {
                    this.v1BillingMeterNoMeterFound.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterNoMeterFoundEventNotification>((Stripe.Events.V1BillingMeterNoMeterFoundEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1BillingPortalConfigurationCreatedEventNotification)
                {
                    this.v1BillingPortalConfigurationCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1BillingPortalConfigurationCreatedEventNotification>((Stripe.Events.V1BillingPortalConfigurationCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1BillingPortalConfigurationUpdatedEventNotification)
                {
                    this.v1BillingPortalConfigurationUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1BillingPortalConfigurationUpdatedEventNotification>((Stripe.Events.V1BillingPortalConfigurationUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1BillingPortalSessionCreatedEventNotification)
                {
                    this.v1BillingPortalSessionCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1BillingPortalSessionCreatedEventNotification>((Stripe.Events.V1BillingPortalSessionCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CapabilityUpdatedEventNotification)
                {
                    this.v1CapabilityUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CapabilityUpdatedEventNotification>((Stripe.Events.V1CapabilityUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CashBalanceFundsAvailableEventNotification)
                {
                    this.v1CashBalanceFundsAvailable.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CashBalanceFundsAvailableEventNotification>((Stripe.Events.V1CashBalanceFundsAvailableEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ChargeCapturedEventNotification)
                {
                    this.v1ChargeCaptured.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ChargeCapturedEventNotification>((Stripe.Events.V1ChargeCapturedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ChargeDisputeClosedEventNotification)
                {
                    this.v1ChargeDisputeClosed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ChargeDisputeClosedEventNotification>((Stripe.Events.V1ChargeDisputeClosedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ChargeDisputeCreatedEventNotification)
                {
                    this.v1ChargeDisputeCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ChargeDisputeCreatedEventNotification>((Stripe.Events.V1ChargeDisputeCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ChargeDisputeFundsReinstatedEventNotification)
                {
                    this.v1ChargeDisputeFundsReinstated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ChargeDisputeFundsReinstatedEventNotification>((Stripe.Events.V1ChargeDisputeFundsReinstatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ChargeDisputeFundsWithdrawnEventNotification)
                {
                    this.v1ChargeDisputeFundsWithdrawn.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ChargeDisputeFundsWithdrawnEventNotification>((Stripe.Events.V1ChargeDisputeFundsWithdrawnEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ChargeDisputeUpdatedEventNotification)
                {
                    this.v1ChargeDisputeUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ChargeDisputeUpdatedEventNotification>((Stripe.Events.V1ChargeDisputeUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ChargeExpiredEventNotification)
                {
                    this.v1ChargeExpired.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ChargeExpiredEventNotification>((Stripe.Events.V1ChargeExpiredEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ChargeFailedEventNotification)
                {
                    this.v1ChargeFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ChargeFailedEventNotification>((Stripe.Events.V1ChargeFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ChargePendingEventNotification)
                {
                    this.v1ChargePending.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ChargePendingEventNotification>((Stripe.Events.V1ChargePendingEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ChargeRefundUpdatedEventNotification)
                {
                    this.v1ChargeRefundUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ChargeRefundUpdatedEventNotification>((Stripe.Events.V1ChargeRefundUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ChargeRefundedEventNotification)
                {
                    this.v1ChargeRefunded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ChargeRefundedEventNotification>((Stripe.Events.V1ChargeRefundedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ChargeSucceededEventNotification)
                {
                    this.v1ChargeSucceeded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ChargeSucceededEventNotification>((Stripe.Events.V1ChargeSucceededEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ChargeUpdatedEventNotification)
                {
                    this.v1ChargeUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ChargeUpdatedEventNotification>((Stripe.Events.V1ChargeUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CheckoutSessionAsyncPaymentFailedEventNotification)
                {
                    this.v1CheckoutSessionAsyncPaymentFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CheckoutSessionAsyncPaymentFailedEventNotification>((Stripe.Events.V1CheckoutSessionAsyncPaymentFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CheckoutSessionAsyncPaymentSucceededEventNotification)
                {
                    this.v1CheckoutSessionAsyncPaymentSucceeded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CheckoutSessionAsyncPaymentSucceededEventNotification>((Stripe.Events.V1CheckoutSessionAsyncPaymentSucceededEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CheckoutSessionCompletedEventNotification)
                {
                    this.v1CheckoutSessionCompleted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CheckoutSessionCompletedEventNotification>((Stripe.Events.V1CheckoutSessionCompletedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CheckoutSessionExpiredEventNotification)
                {
                    this.v1CheckoutSessionExpired.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CheckoutSessionExpiredEventNotification>((Stripe.Events.V1CheckoutSessionExpiredEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ClimateOrderCanceledEventNotification)
                {
                    this.v1ClimateOrderCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ClimateOrderCanceledEventNotification>((Stripe.Events.V1ClimateOrderCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ClimateOrderCreatedEventNotification)
                {
                    this.v1ClimateOrderCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ClimateOrderCreatedEventNotification>((Stripe.Events.V1ClimateOrderCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ClimateOrderDelayedEventNotification)
                {
                    this.v1ClimateOrderDelayed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ClimateOrderDelayedEventNotification>((Stripe.Events.V1ClimateOrderDelayedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ClimateOrderDeliveredEventNotification)
                {
                    this.v1ClimateOrderDelivered.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ClimateOrderDeliveredEventNotification>((Stripe.Events.V1ClimateOrderDeliveredEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ClimateOrderProductSubstitutedEventNotification)
                {
                    this.v1ClimateOrderProductSubstituted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ClimateOrderProductSubstitutedEventNotification>((Stripe.Events.V1ClimateOrderProductSubstitutedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ClimateProductCreatedEventNotification)
                {
                    this.v1ClimateProductCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ClimateProductCreatedEventNotification>((Stripe.Events.V1ClimateProductCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ClimateProductPricingUpdatedEventNotification)
                {
                    this.v1ClimateProductPricingUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ClimateProductPricingUpdatedEventNotification>((Stripe.Events.V1ClimateProductPricingUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CouponCreatedEventNotification)
                {
                    this.v1CouponCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CouponCreatedEventNotification>((Stripe.Events.V1CouponCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CouponDeletedEventNotification)
                {
                    this.v1CouponDeleted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CouponDeletedEventNotification>((Stripe.Events.V1CouponDeletedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CouponUpdatedEventNotification)
                {
                    this.v1CouponUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CouponUpdatedEventNotification>((Stripe.Events.V1CouponUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CreditNoteCreatedEventNotification)
                {
                    this.v1CreditNoteCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CreditNoteCreatedEventNotification>((Stripe.Events.V1CreditNoteCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CreditNoteUpdatedEventNotification)
                {
                    this.v1CreditNoteUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CreditNoteUpdatedEventNotification>((Stripe.Events.V1CreditNoteUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CreditNoteVoidedEventNotification)
                {
                    this.v1CreditNoteVoided.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CreditNoteVoidedEventNotification>((Stripe.Events.V1CreditNoteVoidedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CustomerCreatedEventNotification)
                {
                    this.v1CustomerCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CustomerCreatedEventNotification>((Stripe.Events.V1CustomerCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CustomerDeletedEventNotification)
                {
                    this.v1CustomerDeleted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CustomerDeletedEventNotification>((Stripe.Events.V1CustomerDeletedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CustomerSubscriptionCreatedEventNotification)
                {
                    this.v1CustomerSubscriptionCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CustomerSubscriptionCreatedEventNotification>((Stripe.Events.V1CustomerSubscriptionCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CustomerSubscriptionDeletedEventNotification)
                {
                    this.v1CustomerSubscriptionDeleted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CustomerSubscriptionDeletedEventNotification>((Stripe.Events.V1CustomerSubscriptionDeletedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CustomerSubscriptionPausedEventNotification)
                {
                    this.v1CustomerSubscriptionPaused.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CustomerSubscriptionPausedEventNotification>((Stripe.Events.V1CustomerSubscriptionPausedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CustomerSubscriptionPendingUpdateAppliedEventNotification)
                {
                    this.v1CustomerSubscriptionPendingUpdateApplied.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CustomerSubscriptionPendingUpdateAppliedEventNotification>((Stripe.Events.V1CustomerSubscriptionPendingUpdateAppliedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CustomerSubscriptionPendingUpdateExpiredEventNotification)
                {
                    this.v1CustomerSubscriptionPendingUpdateExpired.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CustomerSubscriptionPendingUpdateExpiredEventNotification>((Stripe.Events.V1CustomerSubscriptionPendingUpdateExpiredEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CustomerSubscriptionResumedEventNotification)
                {
                    this.v1CustomerSubscriptionResumed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CustomerSubscriptionResumedEventNotification>((Stripe.Events.V1CustomerSubscriptionResumedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CustomerSubscriptionTrialWillEndEventNotification)
                {
                    this.v1CustomerSubscriptionTrialWillEnd.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CustomerSubscriptionTrialWillEndEventNotification>((Stripe.Events.V1CustomerSubscriptionTrialWillEndEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CustomerSubscriptionUpdatedEventNotification)
                {
                    this.v1CustomerSubscriptionUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CustomerSubscriptionUpdatedEventNotification>((Stripe.Events.V1CustomerSubscriptionUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CustomerTaxIdCreatedEventNotification)
                {
                    this.v1CustomerTaxIdCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CustomerTaxIdCreatedEventNotification>((Stripe.Events.V1CustomerTaxIdCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CustomerTaxIdDeletedEventNotification)
                {
                    this.v1CustomerTaxIdDeleted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CustomerTaxIdDeletedEventNotification>((Stripe.Events.V1CustomerTaxIdDeletedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CustomerTaxIdUpdatedEventNotification)
                {
                    this.v1CustomerTaxIdUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CustomerTaxIdUpdatedEventNotification>((Stripe.Events.V1CustomerTaxIdUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CustomerUpdatedEventNotification)
                {
                    this.v1CustomerUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CustomerUpdatedEventNotification>((Stripe.Events.V1CustomerUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CustomerCashBalanceTransactionCreatedEventNotification)
                {
                    this.v1CustomerCashBalanceTransactionCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CustomerCashBalanceTransactionCreatedEventNotification>((Stripe.Events.V1CustomerCashBalanceTransactionCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1EntitlementsActiveEntitlementSummaryUpdatedEventNotification)
                {
                    this.v1EntitlementsActiveEntitlementSummaryUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1EntitlementsActiveEntitlementSummaryUpdatedEventNotification>((Stripe.Events.V1EntitlementsActiveEntitlementSummaryUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1FileCreatedEventNotification)
                {
                    this.v1FileCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1FileCreatedEventNotification>((Stripe.Events.V1FileCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1FinancialConnectionsAccountCreatedEventNotification)
                {
                    this.v1FinancialConnectionsAccountCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountCreatedEventNotification>((Stripe.Events.V1FinancialConnectionsAccountCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1FinancialConnectionsAccountDeactivatedEventNotification)
                {
                    this.v1FinancialConnectionsAccountDeactivated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountDeactivatedEventNotification>((Stripe.Events.V1FinancialConnectionsAccountDeactivatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1FinancialConnectionsAccountDisconnectedEventNotification)
                {
                    this.v1FinancialConnectionsAccountDisconnected.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountDisconnectedEventNotification>((Stripe.Events.V1FinancialConnectionsAccountDisconnectedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1FinancialConnectionsAccountReactivatedEventNotification)
                {
                    this.v1FinancialConnectionsAccountReactivated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountReactivatedEventNotification>((Stripe.Events.V1FinancialConnectionsAccountReactivatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1FinancialConnectionsAccountRefreshedBalanceEventNotification)
                {
                    this.v1FinancialConnectionsAccountRefreshedBalance.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountRefreshedBalanceEventNotification>((Stripe.Events.V1FinancialConnectionsAccountRefreshedBalanceEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1FinancialConnectionsAccountRefreshedOwnershipEventNotification)
                {
                    this.v1FinancialConnectionsAccountRefreshedOwnership.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountRefreshedOwnershipEventNotification>((Stripe.Events.V1FinancialConnectionsAccountRefreshedOwnershipEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1FinancialConnectionsAccountRefreshedTransactionsEventNotification)
                {
                    this.v1FinancialConnectionsAccountRefreshedTransactions.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountRefreshedTransactionsEventNotification>((Stripe.Events.V1FinancialConnectionsAccountRefreshedTransactionsEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IdentityVerificationSessionCanceledEventNotification)
                {
                    this.v1IdentityVerificationSessionCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IdentityVerificationSessionCanceledEventNotification>((Stripe.Events.V1IdentityVerificationSessionCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IdentityVerificationSessionCreatedEventNotification)
                {
                    this.v1IdentityVerificationSessionCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IdentityVerificationSessionCreatedEventNotification>((Stripe.Events.V1IdentityVerificationSessionCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IdentityVerificationSessionProcessingEventNotification)
                {
                    this.v1IdentityVerificationSessionProcessing.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IdentityVerificationSessionProcessingEventNotification>((Stripe.Events.V1IdentityVerificationSessionProcessingEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IdentityVerificationSessionRedactedEventNotification)
                {
                    this.v1IdentityVerificationSessionRedacted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IdentityVerificationSessionRedactedEventNotification>((Stripe.Events.V1IdentityVerificationSessionRedactedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IdentityVerificationSessionRequiresInputEventNotification)
                {
                    this.v1IdentityVerificationSessionRequiresInput.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IdentityVerificationSessionRequiresInputEventNotification>((Stripe.Events.V1IdentityVerificationSessionRequiresInputEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IdentityVerificationSessionVerifiedEventNotification)
                {
                    this.v1IdentityVerificationSessionVerified.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IdentityVerificationSessionVerifiedEventNotification>((Stripe.Events.V1IdentityVerificationSessionVerifiedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoiceCreatedEventNotification)
                {
                    this.v1InvoiceCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceCreatedEventNotification>((Stripe.Events.V1InvoiceCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoiceDeletedEventNotification)
                {
                    this.v1InvoiceDeleted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceDeletedEventNotification>((Stripe.Events.V1InvoiceDeletedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoiceFinalizationFailedEventNotification)
                {
                    this.v1InvoiceFinalizationFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceFinalizationFailedEventNotification>((Stripe.Events.V1InvoiceFinalizationFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoiceFinalizedEventNotification)
                {
                    this.v1InvoiceFinalized.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceFinalizedEventNotification>((Stripe.Events.V1InvoiceFinalizedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoiceMarkedUncollectibleEventNotification)
                {
                    this.v1InvoiceMarkedUncollectible.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceMarkedUncollectibleEventNotification>((Stripe.Events.V1InvoiceMarkedUncollectibleEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoiceOverdueEventNotification)
                {
                    this.v1InvoiceOverdue.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceOverdueEventNotification>((Stripe.Events.V1InvoiceOverdueEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoiceOverpaidEventNotification)
                {
                    this.v1InvoiceOverpaid.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceOverpaidEventNotification>((Stripe.Events.V1InvoiceOverpaidEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoicePaidEventNotification)
                {
                    this.v1InvoicePaid.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoicePaidEventNotification>((Stripe.Events.V1InvoicePaidEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoicePaymentActionRequiredEventNotification)
                {
                    this.v1InvoicePaymentActionRequired.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoicePaymentActionRequiredEventNotification>((Stripe.Events.V1InvoicePaymentActionRequiredEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoicePaymentFailedEventNotification)
                {
                    this.v1InvoicePaymentFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoicePaymentFailedEventNotification>((Stripe.Events.V1InvoicePaymentFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoicePaymentSucceededEventNotification)
                {
                    this.v1InvoicePaymentSucceeded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoicePaymentSucceededEventNotification>((Stripe.Events.V1InvoicePaymentSucceededEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoiceSentEventNotification)
                {
                    this.v1InvoiceSent.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceSentEventNotification>((Stripe.Events.V1InvoiceSentEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoiceUpcomingEventNotification)
                {
                    this.v1InvoiceUpcoming.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceUpcomingEventNotification>((Stripe.Events.V1InvoiceUpcomingEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoiceUpdatedEventNotification)
                {
                    this.v1InvoiceUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceUpdatedEventNotification>((Stripe.Events.V1InvoiceUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoiceVoidedEventNotification)
                {
                    this.v1InvoiceVoided.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceVoidedEventNotification>((Stripe.Events.V1InvoiceVoidedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoiceWillBeDueEventNotification)
                {
                    this.v1InvoiceWillBeDue.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceWillBeDueEventNotification>((Stripe.Events.V1InvoiceWillBeDueEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoicePaymentPaidEventNotification)
                {
                    this.v1InvoicePaymentPaid.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoicePaymentPaidEventNotification>((Stripe.Events.V1InvoicePaymentPaidEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoiceitemCreatedEventNotification)
                {
                    this.v1InvoiceitemCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceitemCreatedEventNotification>((Stripe.Events.V1InvoiceitemCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoiceitemDeletedEventNotification)
                {
                    this.v1InvoiceitemDeleted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceitemDeletedEventNotification>((Stripe.Events.V1InvoiceitemDeletedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingAuthorizationCreatedEventNotification)
                {
                    this.v1IssuingAuthorizationCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingAuthorizationCreatedEventNotification>((Stripe.Events.V1IssuingAuthorizationCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingAuthorizationRequestEventNotification)
                {
                    this.v1IssuingAuthorizationRequest.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingAuthorizationRequestEventNotification>((Stripe.Events.V1IssuingAuthorizationRequestEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingAuthorizationUpdatedEventNotification)
                {
                    this.v1IssuingAuthorizationUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingAuthorizationUpdatedEventNotification>((Stripe.Events.V1IssuingAuthorizationUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingCardCreatedEventNotification)
                {
                    this.v1IssuingCardCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingCardCreatedEventNotification>((Stripe.Events.V1IssuingCardCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingCardUpdatedEventNotification)
                {
                    this.v1IssuingCardUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingCardUpdatedEventNotification>((Stripe.Events.V1IssuingCardUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingCardholderCreatedEventNotification)
                {
                    this.v1IssuingCardholderCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingCardholderCreatedEventNotification>((Stripe.Events.V1IssuingCardholderCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingCardholderUpdatedEventNotification)
                {
                    this.v1IssuingCardholderUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingCardholderUpdatedEventNotification>((Stripe.Events.V1IssuingCardholderUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingDisputeClosedEventNotification)
                {
                    this.v1IssuingDisputeClosed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingDisputeClosedEventNotification>((Stripe.Events.V1IssuingDisputeClosedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingDisputeCreatedEventNotification)
                {
                    this.v1IssuingDisputeCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingDisputeCreatedEventNotification>((Stripe.Events.V1IssuingDisputeCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingDisputeFundsReinstatedEventNotification)
                {
                    this.v1IssuingDisputeFundsReinstated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingDisputeFundsReinstatedEventNotification>((Stripe.Events.V1IssuingDisputeFundsReinstatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingDisputeFundsRescindedEventNotification)
                {
                    this.v1IssuingDisputeFundsRescinded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingDisputeFundsRescindedEventNotification>((Stripe.Events.V1IssuingDisputeFundsRescindedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingDisputeSubmittedEventNotification)
                {
                    this.v1IssuingDisputeSubmitted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingDisputeSubmittedEventNotification>((Stripe.Events.V1IssuingDisputeSubmittedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingDisputeUpdatedEventNotification)
                {
                    this.v1IssuingDisputeUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingDisputeUpdatedEventNotification>((Stripe.Events.V1IssuingDisputeUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingPersonalizationDesignActivatedEventNotification)
                {
                    this.v1IssuingPersonalizationDesignActivated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingPersonalizationDesignActivatedEventNotification>((Stripe.Events.V1IssuingPersonalizationDesignActivatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingPersonalizationDesignDeactivatedEventNotification)
                {
                    this.v1IssuingPersonalizationDesignDeactivated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingPersonalizationDesignDeactivatedEventNotification>((Stripe.Events.V1IssuingPersonalizationDesignDeactivatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingPersonalizationDesignRejectedEventNotification)
                {
                    this.v1IssuingPersonalizationDesignRejected.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingPersonalizationDesignRejectedEventNotification>((Stripe.Events.V1IssuingPersonalizationDesignRejectedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingPersonalizationDesignUpdatedEventNotification)
                {
                    this.v1IssuingPersonalizationDesignUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingPersonalizationDesignUpdatedEventNotification>((Stripe.Events.V1IssuingPersonalizationDesignUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingTokenCreatedEventNotification)
                {
                    this.v1IssuingTokenCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingTokenCreatedEventNotification>((Stripe.Events.V1IssuingTokenCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingTokenUpdatedEventNotification)
                {
                    this.v1IssuingTokenUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingTokenUpdatedEventNotification>((Stripe.Events.V1IssuingTokenUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingTransactionCreatedEventNotification)
                {
                    this.v1IssuingTransactionCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingTransactionCreatedEventNotification>((Stripe.Events.V1IssuingTransactionCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingTransactionPurchaseDetailsReceiptUpdatedEventNotification)
                {
                    this.v1IssuingTransactionPurchaseDetailsReceiptUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingTransactionPurchaseDetailsReceiptUpdatedEventNotification>((Stripe.Events.V1IssuingTransactionPurchaseDetailsReceiptUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingTransactionUpdatedEventNotification)
                {
                    this.v1IssuingTransactionUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingTransactionUpdatedEventNotification>((Stripe.Events.V1IssuingTransactionUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1MandateUpdatedEventNotification)
                {
                    this.v1MandateUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1MandateUpdatedEventNotification>((Stripe.Events.V1MandateUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PaymentIntentAmountCapturableUpdatedEventNotification)
                {
                    this.v1PaymentIntentAmountCapturableUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PaymentIntentAmountCapturableUpdatedEventNotification>((Stripe.Events.V1PaymentIntentAmountCapturableUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PaymentIntentCanceledEventNotification)
                {
                    this.v1PaymentIntentCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PaymentIntentCanceledEventNotification>((Stripe.Events.V1PaymentIntentCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PaymentIntentCreatedEventNotification)
                {
                    this.v1PaymentIntentCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PaymentIntentCreatedEventNotification>((Stripe.Events.V1PaymentIntentCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PaymentIntentPartiallyFundedEventNotification)
                {
                    this.v1PaymentIntentPartiallyFunded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PaymentIntentPartiallyFundedEventNotification>((Stripe.Events.V1PaymentIntentPartiallyFundedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PaymentIntentPaymentFailedEventNotification)
                {
                    this.v1PaymentIntentPaymentFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PaymentIntentPaymentFailedEventNotification>((Stripe.Events.V1PaymentIntentPaymentFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PaymentIntentProcessingEventNotification)
                {
                    this.v1PaymentIntentProcessing.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PaymentIntentProcessingEventNotification>((Stripe.Events.V1PaymentIntentProcessingEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PaymentIntentRequiresActionEventNotification)
                {
                    this.v1PaymentIntentRequiresAction.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PaymentIntentRequiresActionEventNotification>((Stripe.Events.V1PaymentIntentRequiresActionEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PaymentIntentSucceededEventNotification)
                {
                    this.v1PaymentIntentSucceeded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PaymentIntentSucceededEventNotification>((Stripe.Events.V1PaymentIntentSucceededEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PaymentLinkCreatedEventNotification)
                {
                    this.v1PaymentLinkCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PaymentLinkCreatedEventNotification>((Stripe.Events.V1PaymentLinkCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PaymentLinkUpdatedEventNotification)
                {
                    this.v1PaymentLinkUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PaymentLinkUpdatedEventNotification>((Stripe.Events.V1PaymentLinkUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PaymentMethodAttachedEventNotification)
                {
                    this.v1PaymentMethodAttached.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PaymentMethodAttachedEventNotification>((Stripe.Events.V1PaymentMethodAttachedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PaymentMethodAutomaticallyUpdatedEventNotification)
                {
                    this.v1PaymentMethodAutomaticallyUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PaymentMethodAutomaticallyUpdatedEventNotification>((Stripe.Events.V1PaymentMethodAutomaticallyUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PaymentMethodDetachedEventNotification)
                {
                    this.v1PaymentMethodDetached.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PaymentMethodDetachedEventNotification>((Stripe.Events.V1PaymentMethodDetachedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PaymentMethodUpdatedEventNotification)
                {
                    this.v1PaymentMethodUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PaymentMethodUpdatedEventNotification>((Stripe.Events.V1PaymentMethodUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PayoutCanceledEventNotification)
                {
                    this.v1PayoutCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PayoutCanceledEventNotification>((Stripe.Events.V1PayoutCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PayoutCreatedEventNotification)
                {
                    this.v1PayoutCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PayoutCreatedEventNotification>((Stripe.Events.V1PayoutCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PayoutFailedEventNotification)
                {
                    this.v1PayoutFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PayoutFailedEventNotification>((Stripe.Events.V1PayoutFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PayoutPaidEventNotification)
                {
                    this.v1PayoutPaid.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PayoutPaidEventNotification>((Stripe.Events.V1PayoutPaidEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PayoutReconciliationCompletedEventNotification)
                {
                    this.v1PayoutReconciliationCompleted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PayoutReconciliationCompletedEventNotification>((Stripe.Events.V1PayoutReconciliationCompletedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PayoutUpdatedEventNotification)
                {
                    this.v1PayoutUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PayoutUpdatedEventNotification>((Stripe.Events.V1PayoutUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PersonCreatedEventNotification)
                {
                    this.v1PersonCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PersonCreatedEventNotification>((Stripe.Events.V1PersonCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PersonDeletedEventNotification)
                {
                    this.v1PersonDeleted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PersonDeletedEventNotification>((Stripe.Events.V1PersonDeletedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PersonUpdatedEventNotification)
                {
                    this.v1PersonUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PersonUpdatedEventNotification>((Stripe.Events.V1PersonUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PlanCreatedEventNotification)
                {
                    this.v1PlanCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PlanCreatedEventNotification>((Stripe.Events.V1PlanCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PlanDeletedEventNotification)
                {
                    this.v1PlanDeleted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PlanDeletedEventNotification>((Stripe.Events.V1PlanDeletedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PlanUpdatedEventNotification)
                {
                    this.v1PlanUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PlanUpdatedEventNotification>((Stripe.Events.V1PlanUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PriceCreatedEventNotification)
                {
                    this.v1PriceCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PriceCreatedEventNotification>((Stripe.Events.V1PriceCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PriceDeletedEventNotification)
                {
                    this.v1PriceDeleted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PriceDeletedEventNotification>((Stripe.Events.V1PriceDeletedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PriceUpdatedEventNotification)
                {
                    this.v1PriceUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PriceUpdatedEventNotification>((Stripe.Events.V1PriceUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ProductCreatedEventNotification)
                {
                    this.v1ProductCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ProductCreatedEventNotification>((Stripe.Events.V1ProductCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ProductDeletedEventNotification)
                {
                    this.v1ProductDeleted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ProductDeletedEventNotification>((Stripe.Events.V1ProductDeletedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ProductUpdatedEventNotification)
                {
                    this.v1ProductUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ProductUpdatedEventNotification>((Stripe.Events.V1ProductUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PromotionCodeCreatedEventNotification)
                {
                    this.v1PromotionCodeCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PromotionCodeCreatedEventNotification>((Stripe.Events.V1PromotionCodeCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PromotionCodeUpdatedEventNotification)
                {
                    this.v1PromotionCodeUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PromotionCodeUpdatedEventNotification>((Stripe.Events.V1PromotionCodeUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1QuoteAcceptedEventNotification)
                {
                    this.v1QuoteAccepted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1QuoteAcceptedEventNotification>((Stripe.Events.V1QuoteAcceptedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1QuoteCanceledEventNotification)
                {
                    this.v1QuoteCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1QuoteCanceledEventNotification>((Stripe.Events.V1QuoteCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1QuoteCreatedEventNotification)
                {
                    this.v1QuoteCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1QuoteCreatedEventNotification>((Stripe.Events.V1QuoteCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1QuoteFinalizedEventNotification)
                {
                    this.v1QuoteFinalized.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1QuoteFinalizedEventNotification>((Stripe.Events.V1QuoteFinalizedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1RadarEarlyFraudWarningCreatedEventNotification)
                {
                    this.v1RadarEarlyFraudWarningCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1RadarEarlyFraudWarningCreatedEventNotification>((Stripe.Events.V1RadarEarlyFraudWarningCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1RadarEarlyFraudWarningUpdatedEventNotification)
                {
                    this.v1RadarEarlyFraudWarningUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1RadarEarlyFraudWarningUpdatedEventNotification>((Stripe.Events.V1RadarEarlyFraudWarningUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1RefundCreatedEventNotification)
                {
                    this.v1RefundCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1RefundCreatedEventNotification>((Stripe.Events.V1RefundCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1RefundFailedEventNotification)
                {
                    this.v1RefundFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1RefundFailedEventNotification>((Stripe.Events.V1RefundFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1RefundUpdatedEventNotification)
                {
                    this.v1RefundUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1RefundUpdatedEventNotification>((Stripe.Events.V1RefundUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ReviewClosedEventNotification)
                {
                    this.v1ReviewClosed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ReviewClosedEventNotification>((Stripe.Events.V1ReviewClosedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ReviewOpenedEventNotification)
                {
                    this.v1ReviewOpened.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ReviewOpenedEventNotification>((Stripe.Events.V1ReviewOpenedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1SetupIntentCanceledEventNotification)
                {
                    this.v1SetupIntentCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1SetupIntentCanceledEventNotification>((Stripe.Events.V1SetupIntentCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1SetupIntentCreatedEventNotification)
                {
                    this.v1SetupIntentCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1SetupIntentCreatedEventNotification>((Stripe.Events.V1SetupIntentCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1SetupIntentRequiresActionEventNotification)
                {
                    this.v1SetupIntentRequiresAction.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1SetupIntentRequiresActionEventNotification>((Stripe.Events.V1SetupIntentRequiresActionEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1SetupIntentSetupFailedEventNotification)
                {
                    this.v1SetupIntentSetupFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1SetupIntentSetupFailedEventNotification>((Stripe.Events.V1SetupIntentSetupFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1SetupIntentSucceededEventNotification)
                {
                    this.v1SetupIntentSucceeded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1SetupIntentSucceededEventNotification>((Stripe.Events.V1SetupIntentSucceededEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1SigmaScheduledQueryRunCreatedEventNotification)
                {
                    this.v1SigmaScheduledQueryRunCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1SigmaScheduledQueryRunCreatedEventNotification>((Stripe.Events.V1SigmaScheduledQueryRunCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1SourceCanceledEventNotification)
                {
                    this.v1SourceCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1SourceCanceledEventNotification>((Stripe.Events.V1SourceCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1SourceChargeableEventNotification)
                {
                    this.v1SourceChargeable.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1SourceChargeableEventNotification>((Stripe.Events.V1SourceChargeableEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1SourceFailedEventNotification)
                {
                    this.v1SourceFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1SourceFailedEventNotification>((Stripe.Events.V1SourceFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1SourceRefundAttributesRequiredEventNotification)
                {
                    this.v1SourceRefundAttributesRequired.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1SourceRefundAttributesRequiredEventNotification>((Stripe.Events.V1SourceRefundAttributesRequiredEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1SubscriptionScheduleAbortedEventNotification)
                {
                    this.v1SubscriptionScheduleAborted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1SubscriptionScheduleAbortedEventNotification>((Stripe.Events.V1SubscriptionScheduleAbortedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1SubscriptionScheduleCanceledEventNotification)
                {
                    this.v1SubscriptionScheduleCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1SubscriptionScheduleCanceledEventNotification>((Stripe.Events.V1SubscriptionScheduleCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1SubscriptionScheduleCompletedEventNotification)
                {
                    this.v1SubscriptionScheduleCompleted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1SubscriptionScheduleCompletedEventNotification>((Stripe.Events.V1SubscriptionScheduleCompletedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1SubscriptionScheduleCreatedEventNotification)
                {
                    this.v1SubscriptionScheduleCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1SubscriptionScheduleCreatedEventNotification>((Stripe.Events.V1SubscriptionScheduleCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1SubscriptionScheduleExpiringEventNotification)
                {
                    this.v1SubscriptionScheduleExpiring.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1SubscriptionScheduleExpiringEventNotification>((Stripe.Events.V1SubscriptionScheduleExpiringEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1SubscriptionScheduleReleasedEventNotification)
                {
                    this.v1SubscriptionScheduleReleased.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1SubscriptionScheduleReleasedEventNotification>((Stripe.Events.V1SubscriptionScheduleReleasedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1SubscriptionScheduleUpdatedEventNotification)
                {
                    this.v1SubscriptionScheduleUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1SubscriptionScheduleUpdatedEventNotification>((Stripe.Events.V1SubscriptionScheduleUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TaxSettingsUpdatedEventNotification)
                {
                    this.v1TaxSettingsUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TaxSettingsUpdatedEventNotification>((Stripe.Events.V1TaxSettingsUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TaxRateCreatedEventNotification)
                {
                    this.v1TaxRateCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TaxRateCreatedEventNotification>((Stripe.Events.V1TaxRateCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TaxRateUpdatedEventNotification)
                {
                    this.v1TaxRateUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TaxRateUpdatedEventNotification>((Stripe.Events.V1TaxRateUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TerminalReaderActionFailedEventNotification)
                {
                    this.v1TerminalReaderActionFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TerminalReaderActionFailedEventNotification>((Stripe.Events.V1TerminalReaderActionFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TerminalReaderActionSucceededEventNotification)
                {
                    this.v1TerminalReaderActionSucceeded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TerminalReaderActionSucceededEventNotification>((Stripe.Events.V1TerminalReaderActionSucceededEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TerminalReaderActionUpdatedEventNotification)
                {
                    this.v1TerminalReaderActionUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TerminalReaderActionUpdatedEventNotification>((Stripe.Events.V1TerminalReaderActionUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TestHelpersTestClockAdvancingEventNotification)
                {
                    this.v1TestHelpersTestClockAdvancing.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TestHelpersTestClockAdvancingEventNotification>((Stripe.Events.V1TestHelpersTestClockAdvancingEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TestHelpersTestClockCreatedEventNotification)
                {
                    this.v1TestHelpersTestClockCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TestHelpersTestClockCreatedEventNotification>((Stripe.Events.V1TestHelpersTestClockCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TestHelpersTestClockDeletedEventNotification)
                {
                    this.v1TestHelpersTestClockDeleted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TestHelpersTestClockDeletedEventNotification>((Stripe.Events.V1TestHelpersTestClockDeletedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TestHelpersTestClockInternalFailureEventNotification)
                {
                    this.v1TestHelpersTestClockInternalFailure.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TestHelpersTestClockInternalFailureEventNotification>((Stripe.Events.V1TestHelpersTestClockInternalFailureEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TestHelpersTestClockReadyEventNotification)
                {
                    this.v1TestHelpersTestClockReady.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TestHelpersTestClockReadyEventNotification>((Stripe.Events.V1TestHelpersTestClockReadyEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TopupCanceledEventNotification)
                {
                    this.v1TopupCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TopupCanceledEventNotification>((Stripe.Events.V1TopupCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TopupCreatedEventNotification)
                {
                    this.v1TopupCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TopupCreatedEventNotification>((Stripe.Events.V1TopupCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TopupFailedEventNotification)
                {
                    this.v1TopupFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TopupFailedEventNotification>((Stripe.Events.V1TopupFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TopupReversedEventNotification)
                {
                    this.v1TopupReversed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TopupReversedEventNotification>((Stripe.Events.V1TopupReversedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TopupSucceededEventNotification)
                {
                    this.v1TopupSucceeded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TopupSucceededEventNotification>((Stripe.Events.V1TopupSucceededEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TransferCreatedEventNotification)
                {
                    this.v1TransferCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TransferCreatedEventNotification>((Stripe.Events.V1TransferCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TransferReversedEventNotification)
                {
                    this.v1TransferReversed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TransferReversedEventNotification>((Stripe.Events.V1TransferReversedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TransferUpdatedEventNotification)
                {
                    this.v1TransferUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TransferUpdatedEventNotification>((Stripe.Events.V1TransferUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingCadenceBilledEventNotification)
                {
                    this.v2BillingCadenceBilled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingCadenceBilledEventNotification>((Stripe.Events.V2BillingCadenceBilledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingCadenceCanceledEventNotification)
                {
                    this.v2BillingCadenceCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingCadenceCanceledEventNotification>((Stripe.Events.V2BillingCadenceCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingCadenceCreatedEventNotification)
                {
                    this.v2BillingCadenceCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingCadenceCreatedEventNotification>((Stripe.Events.V2BillingCadenceCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingLicenseFeeCreatedEventNotification)
                {
                    this.v2BillingLicenseFeeCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingLicenseFeeCreatedEventNotification>((Stripe.Events.V2BillingLicenseFeeCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingLicenseFeeUpdatedEventNotification)
                {
                    this.v2BillingLicenseFeeUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingLicenseFeeUpdatedEventNotification>((Stripe.Events.V2BillingLicenseFeeUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingLicenseFeeVersionCreatedEventNotification)
                {
                    this.v2BillingLicenseFeeVersionCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingLicenseFeeVersionCreatedEventNotification>((Stripe.Events.V2BillingLicenseFeeVersionCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingLicensedItemCreatedEventNotification)
                {
                    this.v2BillingLicensedItemCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingLicensedItemCreatedEventNotification>((Stripe.Events.V2BillingLicensedItemCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingLicensedItemUpdatedEventNotification)
                {
                    this.v2BillingLicensedItemUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingLicensedItemUpdatedEventNotification>((Stripe.Events.V2BillingLicensedItemUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingMeteredItemCreatedEventNotification)
                {
                    this.v2BillingMeteredItemCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingMeteredItemCreatedEventNotification>((Stripe.Events.V2BillingMeteredItemCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingMeteredItemUpdatedEventNotification)
                {
                    this.v2BillingMeteredItemUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingMeteredItemUpdatedEventNotification>((Stripe.Events.V2BillingMeteredItemUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingPricingPlanCreatedEventNotification)
                {
                    this.v2BillingPricingPlanCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanCreatedEventNotification>((Stripe.Events.V2BillingPricingPlanCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingPricingPlanUpdatedEventNotification)
                {
                    this.v2BillingPricingPlanUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanUpdatedEventNotification>((Stripe.Events.V2BillingPricingPlanUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingPricingPlanComponentCreatedEventNotification)
                {
                    this.v2BillingPricingPlanComponentCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanComponentCreatedEventNotification>((Stripe.Events.V2BillingPricingPlanComponentCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingPricingPlanComponentUpdatedEventNotification)
                {
                    this.v2BillingPricingPlanComponentUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanComponentUpdatedEventNotification>((Stripe.Events.V2BillingPricingPlanComponentUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingPricingPlanSubscriptionCollectionAwaitingCustomerActionEventNotification)
                {
                    this.v2BillingPricingPlanSubscriptionCollectionAwaitingCustomerAction.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanSubscriptionCollectionAwaitingCustomerActionEventNotification>((Stripe.Events.V2BillingPricingPlanSubscriptionCollectionAwaitingCustomerActionEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingPricingPlanSubscriptionCollectionCurrentEventNotification)
                {
                    this.v2BillingPricingPlanSubscriptionCollectionCurrent.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanSubscriptionCollectionCurrentEventNotification>((Stripe.Events.V2BillingPricingPlanSubscriptionCollectionCurrentEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingPricingPlanSubscriptionCollectionPastDueEventNotification)
                {
                    this.v2BillingPricingPlanSubscriptionCollectionPastDue.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanSubscriptionCollectionPastDueEventNotification>((Stripe.Events.V2BillingPricingPlanSubscriptionCollectionPastDueEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingPricingPlanSubscriptionCollectionPausedEventNotification)
                {
                    this.v2BillingPricingPlanSubscriptionCollectionPaused.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanSubscriptionCollectionPausedEventNotification>((Stripe.Events.V2BillingPricingPlanSubscriptionCollectionPausedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingPricingPlanSubscriptionCollectionUnpaidEventNotification)
                {
                    this.v2BillingPricingPlanSubscriptionCollectionUnpaid.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanSubscriptionCollectionUnpaidEventNotification>((Stripe.Events.V2BillingPricingPlanSubscriptionCollectionUnpaidEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingPricingPlanSubscriptionServicingActivatedEventNotification)
                {
                    this.v2BillingPricingPlanSubscriptionServicingActivated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanSubscriptionServicingActivatedEventNotification>((Stripe.Events.V2BillingPricingPlanSubscriptionServicingActivatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingPricingPlanSubscriptionServicingCanceledEventNotification)
                {
                    this.v2BillingPricingPlanSubscriptionServicingCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanSubscriptionServicingCanceledEventNotification>((Stripe.Events.V2BillingPricingPlanSubscriptionServicingCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingPricingPlanSubscriptionServicingPausedEventNotification)
                {
                    this.v2BillingPricingPlanSubscriptionServicingPaused.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanSubscriptionServicingPausedEventNotification>((Stripe.Events.V2BillingPricingPlanSubscriptionServicingPausedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingPricingPlanVersionCreatedEventNotification)
                {
                    this.v2BillingPricingPlanVersionCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanVersionCreatedEventNotification>((Stripe.Events.V2BillingPricingPlanVersionCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingRateCardCreatedEventNotification)
                {
                    this.v2BillingRateCardCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardCreatedEventNotification>((Stripe.Events.V2BillingRateCardCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingRateCardUpdatedEventNotification)
                {
                    this.v2BillingRateCardUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardUpdatedEventNotification>((Stripe.Events.V2BillingRateCardUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingRateCardCustomPricingUnitOverageRateCreatedEventNotification)
                {
                    this.v2BillingRateCardCustomPricingUnitOverageRateCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardCustomPricingUnitOverageRateCreatedEventNotification>((Stripe.Events.V2BillingRateCardCustomPricingUnitOverageRateCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingRateCardRateCreatedEventNotification)
                {
                    this.v2BillingRateCardRateCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardRateCreatedEventNotification>((Stripe.Events.V2BillingRateCardRateCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingRateCardSubscriptionActivatedEventNotification)
                {
                    this.v2BillingRateCardSubscriptionActivated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionActivatedEventNotification>((Stripe.Events.V2BillingRateCardSubscriptionActivatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingRateCardSubscriptionCanceledEventNotification)
                {
                    this.v2BillingRateCardSubscriptionCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionCanceledEventNotification>((Stripe.Events.V2BillingRateCardSubscriptionCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingRateCardSubscriptionCollectionAwaitingCustomerActionEventNotification)
                {
                    this.v2BillingRateCardSubscriptionCollectionAwaitingCustomerAction.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionCollectionAwaitingCustomerActionEventNotification>((Stripe.Events.V2BillingRateCardSubscriptionCollectionAwaitingCustomerActionEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingRateCardSubscriptionCollectionCurrentEventNotification)
                {
                    this.v2BillingRateCardSubscriptionCollectionCurrent.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionCollectionCurrentEventNotification>((Stripe.Events.V2BillingRateCardSubscriptionCollectionCurrentEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingRateCardSubscriptionCollectionPastDueEventNotification)
                {
                    this.v2BillingRateCardSubscriptionCollectionPastDue.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionCollectionPastDueEventNotification>((Stripe.Events.V2BillingRateCardSubscriptionCollectionPastDueEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingRateCardSubscriptionCollectionPausedEventNotification)
                {
                    this.v2BillingRateCardSubscriptionCollectionPaused.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionCollectionPausedEventNotification>((Stripe.Events.V2BillingRateCardSubscriptionCollectionPausedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingRateCardSubscriptionCollectionUnpaidEventNotification)
                {
                    this.v2BillingRateCardSubscriptionCollectionUnpaid.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionCollectionUnpaidEventNotification>((Stripe.Events.V2BillingRateCardSubscriptionCollectionUnpaidEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingRateCardSubscriptionServicingActivatedEventNotification)
                {
                    this.v2BillingRateCardSubscriptionServicingActivated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionServicingActivatedEventNotification>((Stripe.Events.V2BillingRateCardSubscriptionServicingActivatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingRateCardSubscriptionServicingCanceledEventNotification)
                {
                    this.v2BillingRateCardSubscriptionServicingCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionServicingCanceledEventNotification>((Stripe.Events.V2BillingRateCardSubscriptionServicingCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingRateCardSubscriptionServicingPausedEventNotification)
                {
                    this.v2BillingRateCardSubscriptionServicingPaused.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionServicingPausedEventNotification>((Stripe.Events.V2BillingRateCardSubscriptionServicingPausedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingRateCardVersionCreatedEventNotification)
                {
                    this.v2BillingRateCardVersionCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardVersionCreatedEventNotification>((Stripe.Events.V2BillingRateCardVersionCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CommerceProductCatalogImportsFailedEventNotification)
                {
                    this.v2CommerceProductCatalogImportsFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CommerceProductCatalogImportsFailedEventNotification>((Stripe.Events.V2CommerceProductCatalogImportsFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CommerceProductCatalogImportsProcessingEventNotification)
                {
                    this.v2CommerceProductCatalogImportsProcessing.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CommerceProductCatalogImportsProcessingEventNotification>((Stripe.Events.V2CommerceProductCatalogImportsProcessingEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CommerceProductCatalogImportsSucceededEventNotification)
                {
                    this.v2CommerceProductCatalogImportsSucceeded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CommerceProductCatalogImportsSucceededEventNotification>((Stripe.Events.V2CommerceProductCatalogImportsSucceededEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CommerceProductCatalogImportsSucceededWithErrorsEventNotification)
                {
                    this.v2CommerceProductCatalogImportsSucceededWithErrors.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CommerceProductCatalogImportsSucceededWithErrorsEventNotification>((Stripe.Events.V2CommerceProductCatalogImportsSucceededWithErrorsEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountClosedEventNotification)
                {
                    this.v2CoreAccountClosed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountClosedEventNotification>((Stripe.Events.V2CoreAccountClosedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountCreatedEventNotification)
                {
                    this.v2CoreAccountCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountCreatedEventNotification>((Stripe.Events.V2CoreAccountCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountUpdatedEventNotification)
                {
                    this.v2CoreAccountUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountUpdatedEventNotification>((Stripe.Events.V2CoreAccountUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingConfigurationCardCreatorCapabilityStatusUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingConfigurationCardCreatorCapabilityStatusUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationCardCreatorCapabilityStatusUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingConfigurationCardCreatorCapabilityStatusUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingConfigurationCardCreatorUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingConfigurationCardCreatorUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationCardCreatorUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingConfigurationCardCreatorUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingConfigurationCustomerUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingConfigurationCustomerUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationCustomerUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingConfigurationCustomerUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingConfigurationMerchantCapabilityStatusUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingConfigurationMerchantCapabilityStatusUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationMerchantCapabilityStatusUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingConfigurationMerchantCapabilityStatusUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingConfigurationMerchantUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingConfigurationMerchantUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationMerchantUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingConfigurationMerchantUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingConfigurationRecipientUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingConfigurationRecipientUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationRecipientUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingConfigurationRecipientUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingConfigurationStorerUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingConfigurationStorerUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationStorerUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingConfigurationStorerUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingDefaultsUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingDefaultsUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingDefaultsUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingDefaultsUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingFutureRequirementsUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingFutureRequirementsUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingFutureRequirementsUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingFutureRequirementsUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingIdentityUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingIdentityUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingIdentityUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingIdentityUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingRequirementsUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingRequirementsUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingRequirementsUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingRequirementsUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountLinkReturnedEventNotification)
                {
                    this.v2CoreAccountLinkReturned.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountLinkReturnedEventNotification>((Stripe.Events.V2CoreAccountLinkReturnedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountPersonCreatedEventNotification)
                {
                    this.v2CoreAccountPersonCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountPersonCreatedEventNotification>((Stripe.Events.V2CoreAccountPersonCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountPersonDeletedEventNotification)
                {
                    this.v2CoreAccountPersonDeleted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountPersonDeletedEventNotification>((Stripe.Events.V2CoreAccountPersonDeletedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountPersonUpdatedEventNotification)
                {
                    this.v2CoreAccountPersonUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountPersonUpdatedEventNotification>((Stripe.Events.V2CoreAccountPersonUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountSignalsFraudulentWebsiteReadyEventNotification)
                {
                    this.v2CoreAccountSignalsFraudulentWebsiteReady.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountSignalsFraudulentWebsiteReadyEventNotification>((Stripe.Events.V2CoreAccountSignalsFraudulentWebsiteReadyEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreApprovalRequestApprovedEventNotification)
                {
                    this.v2CoreApprovalRequestApproved.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreApprovalRequestApprovedEventNotification>((Stripe.Events.V2CoreApprovalRequestApprovedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreApprovalRequestCanceledEventNotification)
                {
                    this.v2CoreApprovalRequestCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreApprovalRequestCanceledEventNotification>((Stripe.Events.V2CoreApprovalRequestCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreApprovalRequestCreatedEventNotification)
                {
                    this.v2CoreApprovalRequestCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreApprovalRequestCreatedEventNotification>((Stripe.Events.V2CoreApprovalRequestCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreApprovalRequestExpiredEventNotification)
                {
                    this.v2CoreApprovalRequestExpired.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreApprovalRequestExpiredEventNotification>((Stripe.Events.V2CoreApprovalRequestExpiredEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreApprovalRequestFailedEventNotification)
                {
                    this.v2CoreApprovalRequestFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreApprovalRequestFailedEventNotification>((Stripe.Events.V2CoreApprovalRequestFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreApprovalRequestRejectedEventNotification)
                {
                    this.v2CoreApprovalRequestRejected.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreApprovalRequestRejectedEventNotification>((Stripe.Events.V2CoreApprovalRequestRejectedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreApprovalRequestSucceededEventNotification)
                {
                    this.v2CoreApprovalRequestSucceeded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreApprovalRequestSucceededEventNotification>((Stripe.Events.V2CoreApprovalRequestSucceededEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreBatchJobBatchFailedEventNotification)
                {
                    this.v2CoreBatchJobBatchFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobBatchFailedEventNotification>((Stripe.Events.V2CoreBatchJobBatchFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreBatchJobCanceledEventNotification)
                {
                    this.v2CoreBatchJobCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobCanceledEventNotification>((Stripe.Events.V2CoreBatchJobCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreBatchJobCompletedEventNotification)
                {
                    this.v2CoreBatchJobCompleted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobCompletedEventNotification>((Stripe.Events.V2CoreBatchJobCompletedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreBatchJobCreatedEventNotification)
                {
                    this.v2CoreBatchJobCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobCreatedEventNotification>((Stripe.Events.V2CoreBatchJobCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreBatchJobReadyForUploadEventNotification)
                {
                    this.v2CoreBatchJobReadyForUpload.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobReadyForUploadEventNotification>((Stripe.Events.V2CoreBatchJobReadyForUploadEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreBatchJobTimeoutEventNotification)
                {
                    this.v2CoreBatchJobTimeout.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobTimeoutEventNotification>((Stripe.Events.V2CoreBatchJobTimeoutEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreBatchJobUpdatedEventNotification)
                {
                    this.v2CoreBatchJobUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobUpdatedEventNotification>((Stripe.Events.V2CoreBatchJobUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreBatchJobUploadTimeoutEventNotification)
                {
                    this.v2CoreBatchJobUploadTimeout.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobUploadTimeoutEventNotification>((Stripe.Events.V2CoreBatchJobUploadTimeoutEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreBatchJobValidatingEventNotification)
                {
                    this.v2CoreBatchJobValidating.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobValidatingEventNotification>((Stripe.Events.V2CoreBatchJobValidatingEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreBatchJobValidationFailedEventNotification)
                {
                    this.v2CoreBatchJobValidationFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobValidationFailedEventNotification>((Stripe.Events.V2CoreBatchJobValidationFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreClaimableSandboxClaimedEventNotification)
                {
                    this.v2CoreClaimableSandboxClaimed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreClaimableSandboxClaimedEventNotification>((Stripe.Events.V2CoreClaimableSandboxClaimedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreClaimableSandboxCreatedEventNotification)
                {
                    this.v2CoreClaimableSandboxCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreClaimableSandboxCreatedEventNotification>((Stripe.Events.V2CoreClaimableSandboxCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreClaimableSandboxExpiredEventNotification)
                {
                    this.v2CoreClaimableSandboxExpired.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreClaimableSandboxExpiredEventNotification>((Stripe.Events.V2CoreClaimableSandboxExpiredEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreClaimableSandboxExpiringEventNotification)
                {
                    this.v2CoreClaimableSandboxExpiring.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreClaimableSandboxExpiringEventNotification>((Stripe.Events.V2CoreClaimableSandboxExpiringEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreClaimableSandboxUpdatedEventNotification)
                {
                    this.v2CoreClaimableSandboxUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreClaimableSandboxUpdatedEventNotification>((Stripe.Events.V2CoreClaimableSandboxUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreEventDestinationPingEventNotification)
                {
                    this.v2CoreEventDestinationPing.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreEventDestinationPingEventNotification>((Stripe.Events.V2CoreEventDestinationPingEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthApiErrorFiringEventNotification)
                {
                    this.v2CoreHealthApiErrorFiring.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthApiErrorFiringEventNotification>((Stripe.Events.V2CoreHealthApiErrorFiringEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthApiErrorResolvedEventNotification)
                {
                    this.v2CoreHealthApiErrorResolved.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthApiErrorResolvedEventNotification>((Stripe.Events.V2CoreHealthApiErrorResolvedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthApiLatencyFiringEventNotification)
                {
                    this.v2CoreHealthApiLatencyFiring.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthApiLatencyFiringEventNotification>((Stripe.Events.V2CoreHealthApiLatencyFiringEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthApiLatencyResolvedEventNotification)
                {
                    this.v2CoreHealthApiLatencyResolved.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthApiLatencyResolvedEventNotification>((Stripe.Events.V2CoreHealthApiLatencyResolvedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthAuthorizationRateDropFiringEventNotification)
                {
                    this.v2CoreHealthAuthorizationRateDropFiring.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthAuthorizationRateDropFiringEventNotification>((Stripe.Events.V2CoreHealthAuthorizationRateDropFiringEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthAuthorizationRateDropResolvedEventNotification)
                {
                    this.v2CoreHealthAuthorizationRateDropResolved.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthAuthorizationRateDropResolvedEventNotification>((Stripe.Events.V2CoreHealthAuthorizationRateDropResolvedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthElementsErrorFiringEventNotification)
                {
                    this.v2CoreHealthElementsErrorFiring.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthElementsErrorFiringEventNotification>((Stripe.Events.V2CoreHealthElementsErrorFiringEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthElementsErrorResolvedEventNotification)
                {
                    this.v2CoreHealthElementsErrorResolved.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthElementsErrorResolvedEventNotification>((Stripe.Events.V2CoreHealthElementsErrorResolvedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthEventGenerationFailureResolvedEventNotification)
                {
                    this.v2CoreHealthEventGenerationFailureResolved.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthEventGenerationFailureResolvedEventNotification>((Stripe.Events.V2CoreHealthEventGenerationFailureResolvedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthFraudRateIncreasedEventNotification)
                {
                    this.v2CoreHealthFraudRateIncreased.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthFraudRateIncreasedEventNotification>((Stripe.Events.V2CoreHealthFraudRateIncreasedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthInvoiceCountDroppedFiringEventNotification)
                {
                    this.v2CoreHealthInvoiceCountDroppedFiring.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthInvoiceCountDroppedFiringEventNotification>((Stripe.Events.V2CoreHealthInvoiceCountDroppedFiringEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthInvoiceCountDroppedResolvedEventNotification)
                {
                    this.v2CoreHealthInvoiceCountDroppedResolved.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthInvoiceCountDroppedResolvedEventNotification>((Stripe.Events.V2CoreHealthInvoiceCountDroppedResolvedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthIssuingAuthorizationRequestErrorsFiringEventNotification)
                {
                    this.v2CoreHealthIssuingAuthorizationRequestErrorsFiring.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthIssuingAuthorizationRequestErrorsFiringEventNotification>((Stripe.Events.V2CoreHealthIssuingAuthorizationRequestErrorsFiringEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthIssuingAuthorizationRequestErrorsResolvedEventNotification)
                {
                    this.v2CoreHealthIssuingAuthorizationRequestErrorsResolved.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthIssuingAuthorizationRequestErrorsResolvedEventNotification>((Stripe.Events.V2CoreHealthIssuingAuthorizationRequestErrorsResolvedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthIssuingAuthorizationRequestTimeoutFiringEventNotification)
                {
                    this.v2CoreHealthIssuingAuthorizationRequestTimeoutFiring.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthIssuingAuthorizationRequestTimeoutFiringEventNotification>((Stripe.Events.V2CoreHealthIssuingAuthorizationRequestTimeoutFiringEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthIssuingAuthorizationRequestTimeoutResolvedEventNotification)
                {
                    this.v2CoreHealthIssuingAuthorizationRequestTimeoutResolved.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthIssuingAuthorizationRequestTimeoutResolvedEventNotification>((Stripe.Events.V2CoreHealthIssuingAuthorizationRequestTimeoutResolvedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthMeterEventSummariesDelayedFiringEventNotification)
                {
                    this.v2CoreHealthMeterEventSummariesDelayedFiring.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthMeterEventSummariesDelayedFiringEventNotification>((Stripe.Events.V2CoreHealthMeterEventSummariesDelayedFiringEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthMeterEventSummariesDelayedResolvedEventNotification)
                {
                    this.v2CoreHealthMeterEventSummariesDelayedResolved.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthMeterEventSummariesDelayedResolvedEventNotification>((Stripe.Events.V2CoreHealthMeterEventSummariesDelayedResolvedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthPaymentMethodErrorFiringEventNotification)
                {
                    this.v2CoreHealthPaymentMethodErrorFiring.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthPaymentMethodErrorFiringEventNotification>((Stripe.Events.V2CoreHealthPaymentMethodErrorFiringEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthPaymentMethodErrorResolvedEventNotification)
                {
                    this.v2CoreHealthPaymentMethodErrorResolved.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthPaymentMethodErrorResolvedEventNotification>((Stripe.Events.V2CoreHealthPaymentMethodErrorResolvedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthSepaDebitDelayedFiringEventNotification)
                {
                    this.v2CoreHealthSepaDebitDelayedFiring.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthSepaDebitDelayedFiringEventNotification>((Stripe.Events.V2CoreHealthSepaDebitDelayedFiringEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthSepaDebitDelayedResolvedEventNotification)
                {
                    this.v2CoreHealthSepaDebitDelayedResolved.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthSepaDebitDelayedResolvedEventNotification>((Stripe.Events.V2CoreHealthSepaDebitDelayedResolvedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthTrafficVolumeDropFiringEventNotification)
                {
                    this.v2CoreHealthTrafficVolumeDropFiring.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthTrafficVolumeDropFiringEventNotification>((Stripe.Events.V2CoreHealthTrafficVolumeDropFiringEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthTrafficVolumeDropResolvedEventNotification)
                {
                    this.v2CoreHealthTrafficVolumeDropResolved.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthTrafficVolumeDropResolvedEventNotification>((Stripe.Events.V2CoreHealthTrafficVolumeDropResolvedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthWebhookLatencyFiringEventNotification)
                {
                    this.v2CoreHealthWebhookLatencyFiring.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthWebhookLatencyFiringEventNotification>((Stripe.Events.V2CoreHealthWebhookLatencyFiringEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthWebhookLatencyResolvedEventNotification)
                {
                    this.v2CoreHealthWebhookLatencyResolved.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthWebhookLatencyResolvedEventNotification>((Stripe.Events.V2CoreHealthWebhookLatencyResolvedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2DataReportingQueryRunCreatedEventNotification)
                {
                    this.v2DataReportingQueryRunCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2DataReportingQueryRunCreatedEventNotification>((Stripe.Events.V2DataReportingQueryRunCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2DataReportingQueryRunFailedEventNotification)
                {
                    this.v2DataReportingQueryRunFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2DataReportingQueryRunFailedEventNotification>((Stripe.Events.V2DataReportingQueryRunFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2DataReportingQueryRunSucceededEventNotification)
                {
                    this.v2DataReportingQueryRunSucceeded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2DataReportingQueryRunSucceededEventNotification>((Stripe.Events.V2DataReportingQueryRunSucceededEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2DataReportingQueryRunUpdatedEventNotification)
                {
                    this.v2DataReportingQueryRunUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2DataReportingQueryRunUpdatedEventNotification>((Stripe.Events.V2DataReportingQueryRunUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2ExtendExtensionRunFailedEventNotification)
                {
                    this.v2ExtendExtensionRunFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2ExtendExtensionRunFailedEventNotification>((Stripe.Events.V2ExtendExtensionRunFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2ExtendWorkflowRunFailedEventNotification)
                {
                    this.v2ExtendWorkflowRunFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2ExtendWorkflowRunFailedEventNotification>((Stripe.Events.V2ExtendWorkflowRunFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2ExtendWorkflowRunStartedEventNotification)
                {
                    this.v2ExtendWorkflowRunStarted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2ExtendWorkflowRunStartedEventNotification>((Stripe.Events.V2ExtendWorkflowRunStartedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2ExtendWorkflowRunSucceededEventNotification)
                {
                    this.v2ExtendWorkflowRunSucceeded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2ExtendWorkflowRunSucceededEventNotification>((Stripe.Events.V2ExtendWorkflowRunSucceededEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2IamApiKeyCreatedEventNotification)
                {
                    this.v2IamApiKeyCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2IamApiKeyCreatedEventNotification>((Stripe.Events.V2IamApiKeyCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2IamApiKeyDefaultSecretRevealedEventNotification)
                {
                    this.v2IamApiKeyDefaultSecretRevealed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2IamApiKeyDefaultSecretRevealedEventNotification>((Stripe.Events.V2IamApiKeyDefaultSecretRevealedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2IamApiKeyExpiredEventNotification)
                {
                    this.v2IamApiKeyExpired.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2IamApiKeyExpiredEventNotification>((Stripe.Events.V2IamApiKeyExpiredEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2IamApiKeyPermissionsUpdatedEventNotification)
                {
                    this.v2IamApiKeyPermissionsUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2IamApiKeyPermissionsUpdatedEventNotification>((Stripe.Events.V2IamApiKeyPermissionsUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2IamApiKeyRotatedEventNotification)
                {
                    this.v2IamApiKeyRotated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2IamApiKeyRotatedEventNotification>((Stripe.Events.V2IamApiKeyRotatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2IamApiKeyUpdatedEventNotification)
                {
                    this.v2IamApiKeyUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2IamApiKeyUpdatedEventNotification>((Stripe.Events.V2IamApiKeyUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2IamStripeAccessGrantApprovedEventNotification)
                {
                    this.v2IamStripeAccessGrantApproved.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2IamStripeAccessGrantApprovedEventNotification>((Stripe.Events.V2IamStripeAccessGrantApprovedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2IamStripeAccessGrantCanceledEventNotification)
                {
                    this.v2IamStripeAccessGrantCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2IamStripeAccessGrantCanceledEventNotification>((Stripe.Events.V2IamStripeAccessGrantCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2IamStripeAccessGrantDeniedEventNotification)
                {
                    this.v2IamStripeAccessGrantDenied.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2IamStripeAccessGrantDeniedEventNotification>((Stripe.Events.V2IamStripeAccessGrantDeniedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2IamStripeAccessGrantRemovedEventNotification)
                {
                    this.v2IamStripeAccessGrantRemoved.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2IamStripeAccessGrantRemovedEventNotification>((Stripe.Events.V2IamStripeAccessGrantRemovedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2IamStripeAccessGrantRequestedEventNotification)
                {
                    this.v2IamStripeAccessGrantRequested.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2IamStripeAccessGrantRequestedEventNotification>((Stripe.Events.V2IamStripeAccessGrantRequestedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2IamStripeAccessGrantUpdatedEventNotification)
                {
                    this.v2IamStripeAccessGrantUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2IamStripeAccessGrantUpdatedEventNotification>((Stripe.Events.V2IamStripeAccessGrantUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementAdjustmentCreatedEventNotification)
                {
                    this.v2MoneyManagementAdjustmentCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementAdjustmentCreatedEventNotification>((Stripe.Events.V2MoneyManagementAdjustmentCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementFinancialAccountCreatedEventNotification)
                {
                    this.v2MoneyManagementFinancialAccountCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAccountCreatedEventNotification>((Stripe.Events.V2MoneyManagementFinancialAccountCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementFinancialAccountUpdatedEventNotification)
                {
                    this.v2MoneyManagementFinancialAccountUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAccountUpdatedEventNotification>((Stripe.Events.V2MoneyManagementFinancialAccountUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementFinancialAccountStatementCreatedEventNotification)
                {
                    this.v2MoneyManagementFinancialAccountStatementCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAccountStatementCreatedEventNotification>((Stripe.Events.V2MoneyManagementFinancialAccountStatementCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementFinancialAccountStatementRestatedEventNotification)
                {
                    this.v2MoneyManagementFinancialAccountStatementRestated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAccountStatementRestatedEventNotification>((Stripe.Events.V2MoneyManagementFinancialAccountStatementRestatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementFinancialAddressActivatedEventNotification)
                {
                    this.v2MoneyManagementFinancialAddressActivated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAddressActivatedEventNotification>((Stripe.Events.V2MoneyManagementFinancialAddressActivatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementFinancialAddressFailedEventNotification)
                {
                    this.v2MoneyManagementFinancialAddressFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAddressFailedEventNotification>((Stripe.Events.V2MoneyManagementFinancialAddressFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementInboundTransferAvailableEventNotification)
                {
                    this.v2MoneyManagementInboundTransferAvailable.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferAvailableEventNotification>((Stripe.Events.V2MoneyManagementInboundTransferAvailableEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementInboundTransferBankDebitFailedEventNotification)
                {
                    this.v2MoneyManagementInboundTransferBankDebitFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitFailedEventNotification>((Stripe.Events.V2MoneyManagementInboundTransferBankDebitFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementInboundTransferBankDebitProcessingEventNotification)
                {
                    this.v2MoneyManagementInboundTransferBankDebitProcessing.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitProcessingEventNotification>((Stripe.Events.V2MoneyManagementInboundTransferBankDebitProcessingEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementInboundTransferBankDebitQueuedEventNotification)
                {
                    this.v2MoneyManagementInboundTransferBankDebitQueued.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitQueuedEventNotification>((Stripe.Events.V2MoneyManagementInboundTransferBankDebitQueuedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementInboundTransferBankDebitReturnedEventNotification)
                {
                    this.v2MoneyManagementInboundTransferBankDebitReturned.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitReturnedEventNotification>((Stripe.Events.V2MoneyManagementInboundTransferBankDebitReturnedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementInboundTransferBankDebitSucceededEventNotification)
                {
                    this.v2MoneyManagementInboundTransferBankDebitSucceeded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitSucceededEventNotification>((Stripe.Events.V2MoneyManagementInboundTransferBankDebitSucceededEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundPaymentCanceledEventNotification)
                {
                    this.v2MoneyManagementOutboundPaymentCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentCanceledEventNotification>((Stripe.Events.V2MoneyManagementOutboundPaymentCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundPaymentCreatedEventNotification)
                {
                    this.v2MoneyManagementOutboundPaymentCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentCreatedEventNotification>((Stripe.Events.V2MoneyManagementOutboundPaymentCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundPaymentFailedEventNotification)
                {
                    this.v2MoneyManagementOutboundPaymentFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentFailedEventNotification>((Stripe.Events.V2MoneyManagementOutboundPaymentFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundPaymentPostedEventNotification)
                {
                    this.v2MoneyManagementOutboundPaymentPosted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentPostedEventNotification>((Stripe.Events.V2MoneyManagementOutboundPaymentPostedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundPaymentReturnedEventNotification)
                {
                    this.v2MoneyManagementOutboundPaymentReturned.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentReturnedEventNotification>((Stripe.Events.V2MoneyManagementOutboundPaymentReturnedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundPaymentUpdatedEventNotification)
                {
                    this.v2MoneyManagementOutboundPaymentUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentUpdatedEventNotification>((Stripe.Events.V2MoneyManagementOutboundPaymentUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundTransferCanceledEventNotification)
                {
                    this.v2MoneyManagementOutboundTransferCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferCanceledEventNotification>((Stripe.Events.V2MoneyManagementOutboundTransferCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundTransferCreatedEventNotification)
                {
                    this.v2MoneyManagementOutboundTransferCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferCreatedEventNotification>((Stripe.Events.V2MoneyManagementOutboundTransferCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundTransferFailedEventNotification)
                {
                    this.v2MoneyManagementOutboundTransferFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferFailedEventNotification>((Stripe.Events.V2MoneyManagementOutboundTransferFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundTransferPostedEventNotification)
                {
                    this.v2MoneyManagementOutboundTransferPosted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferPostedEventNotification>((Stripe.Events.V2MoneyManagementOutboundTransferPostedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundTransferReturnedEventNotification)
                {
                    this.v2MoneyManagementOutboundTransferReturned.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferReturnedEventNotification>((Stripe.Events.V2MoneyManagementOutboundTransferReturnedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundTransferUpdatedEventNotification)
                {
                    this.v2MoneyManagementOutboundTransferUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferUpdatedEventNotification>((Stripe.Events.V2MoneyManagementOutboundTransferUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementPayoutMethodCreatedEventNotification)
                {
                    this.v2MoneyManagementPayoutMethodCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementPayoutMethodCreatedEventNotification>((Stripe.Events.V2MoneyManagementPayoutMethodCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementPayoutMethodUpdatedEventNotification)
                {
                    this.v2MoneyManagementPayoutMethodUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementPayoutMethodUpdatedEventNotification>((Stripe.Events.V2MoneyManagementPayoutMethodUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementReceivedCreditAvailableEventNotification)
                {
                    this.v2MoneyManagementReceivedCreditAvailable.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditAvailableEventNotification>((Stripe.Events.V2MoneyManagementReceivedCreditAvailableEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementReceivedCreditFailedEventNotification)
                {
                    this.v2MoneyManagementReceivedCreditFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditFailedEventNotification>((Stripe.Events.V2MoneyManagementReceivedCreditFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementReceivedCreditReturnedEventNotification)
                {
                    this.v2MoneyManagementReceivedCreditReturned.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditReturnedEventNotification>((Stripe.Events.V2MoneyManagementReceivedCreditReturnedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementReceivedCreditSucceededEventNotification)
                {
                    this.v2MoneyManagementReceivedCreditSucceeded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditSucceededEventNotification>((Stripe.Events.V2MoneyManagementReceivedCreditSucceededEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementReceivedDebitCanceledEventNotification)
                {
                    this.v2MoneyManagementReceivedDebitCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitCanceledEventNotification>((Stripe.Events.V2MoneyManagementReceivedDebitCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementReceivedDebitFailedEventNotification)
                {
                    this.v2MoneyManagementReceivedDebitFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitFailedEventNotification>((Stripe.Events.V2MoneyManagementReceivedDebitFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementReceivedDebitPendingEventNotification)
                {
                    this.v2MoneyManagementReceivedDebitPending.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitPendingEventNotification>((Stripe.Events.V2MoneyManagementReceivedDebitPendingEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementReceivedDebitSucceededEventNotification)
                {
                    this.v2MoneyManagementReceivedDebitSucceeded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitSucceededEventNotification>((Stripe.Events.V2MoneyManagementReceivedDebitSucceededEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementReceivedDebitUpdatedEventNotification)
                {
                    this.v2MoneyManagementReceivedDebitUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitUpdatedEventNotification>((Stripe.Events.V2MoneyManagementReceivedDebitUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementRecipientVerificationCreatedEventNotification)
                {
                    this.v2MoneyManagementRecipientVerificationCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementRecipientVerificationCreatedEventNotification>((Stripe.Events.V2MoneyManagementRecipientVerificationCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementRecipientVerificationUpdatedEventNotification)
                {
                    this.v2MoneyManagementRecipientVerificationUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementRecipientVerificationUpdatedEventNotification>((Stripe.Events.V2MoneyManagementRecipientVerificationUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementTransactionCreatedEventNotification)
                {
                    this.v2MoneyManagementTransactionCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementTransactionCreatedEventNotification>((Stripe.Events.V2MoneyManagementTransactionCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementTransactionUpdatedEventNotification)
                {
                    this.v2MoneyManagementTransactionUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementTransactionUpdatedEventNotification>((Stripe.Events.V2MoneyManagementTransactionUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2OrchestratedCommerceAgreementConfirmedEventNotification)
                {
                    this.v2OrchestratedCommerceAgreementConfirmed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2OrchestratedCommerceAgreementConfirmedEventNotification>((Stripe.Events.V2OrchestratedCommerceAgreementConfirmedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2OrchestratedCommerceAgreementCreatedEventNotification)
                {
                    this.v2OrchestratedCommerceAgreementCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2OrchestratedCommerceAgreementCreatedEventNotification>((Stripe.Events.V2OrchestratedCommerceAgreementCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2OrchestratedCommerceAgreementPartiallyConfirmedEventNotification)
                {
                    this.v2OrchestratedCommerceAgreementPartiallyConfirmed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2OrchestratedCommerceAgreementPartiallyConfirmedEventNotification>((Stripe.Events.V2OrchestratedCommerceAgreementPartiallyConfirmedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2OrchestratedCommerceAgreementTerminatedEventNotification)
                {
                    this.v2OrchestratedCommerceAgreementTerminated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2OrchestratedCommerceAgreementTerminatedEventNotification>((Stripe.Events.V2OrchestratedCommerceAgreementTerminatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsOffSessionPaymentAttemptFailedEventNotification)
                {
                    this.v2PaymentsOffSessionPaymentAttemptFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentAttemptFailedEventNotification>((Stripe.Events.V2PaymentsOffSessionPaymentAttemptFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsOffSessionPaymentAttemptStartedEventNotification)
                {
                    this.v2PaymentsOffSessionPaymentAttemptStarted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentAttemptStartedEventNotification>((Stripe.Events.V2PaymentsOffSessionPaymentAttemptStartedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsOffSessionPaymentAuthorizationAttemptFailedEventNotification)
                {
                    this.v2PaymentsOffSessionPaymentAuthorizationAttemptFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentAuthorizationAttemptFailedEventNotification>((Stripe.Events.V2PaymentsOffSessionPaymentAuthorizationAttemptFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsOffSessionPaymentAuthorizationAttemptStartedEventNotification)
                {
                    this.v2PaymentsOffSessionPaymentAuthorizationAttemptStarted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentAuthorizationAttemptStartedEventNotification>((Stripe.Events.V2PaymentsOffSessionPaymentAuthorizationAttemptStartedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsOffSessionPaymentCanceledEventNotification)
                {
                    this.v2PaymentsOffSessionPaymentCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentCanceledEventNotification>((Stripe.Events.V2PaymentsOffSessionPaymentCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsOffSessionPaymentCreatedEventNotification)
                {
                    this.v2PaymentsOffSessionPaymentCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentCreatedEventNotification>((Stripe.Events.V2PaymentsOffSessionPaymentCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsOffSessionPaymentFailedEventNotification)
                {
                    this.v2PaymentsOffSessionPaymentFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentFailedEventNotification>((Stripe.Events.V2PaymentsOffSessionPaymentFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsOffSessionPaymentPausedEventNotification)
                {
                    this.v2PaymentsOffSessionPaymentPaused.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentPausedEventNotification>((Stripe.Events.V2PaymentsOffSessionPaymentPausedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsOffSessionPaymentRequiresCaptureEventNotification)
                {
                    this.v2PaymentsOffSessionPaymentRequiresCapture.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentRequiresCaptureEventNotification>((Stripe.Events.V2PaymentsOffSessionPaymentRequiresCaptureEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsOffSessionPaymentResumedEventNotification)
                {
                    this.v2PaymentsOffSessionPaymentResumed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentResumedEventNotification>((Stripe.Events.V2PaymentsOffSessionPaymentResumedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsOffSessionPaymentSucceededEventNotification)
                {
                    this.v2PaymentsOffSessionPaymentSucceeded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentSucceededEventNotification>((Stripe.Events.V2PaymentsOffSessionPaymentSucceededEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsSettlementAllocationIntentCanceledEventNotification)
                {
                    this.v2PaymentsSettlementAllocationIntentCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentCanceledEventNotification>((Stripe.Events.V2PaymentsSettlementAllocationIntentCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsSettlementAllocationIntentCreatedEventNotification)
                {
                    this.v2PaymentsSettlementAllocationIntentCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentCreatedEventNotification>((Stripe.Events.V2PaymentsSettlementAllocationIntentCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsSettlementAllocationIntentErroredEventNotification)
                {
                    this.v2PaymentsSettlementAllocationIntentErrored.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentErroredEventNotification>((Stripe.Events.V2PaymentsSettlementAllocationIntentErroredEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsSettlementAllocationIntentFundsNotReceivedEventNotification)
                {
                    this.v2PaymentsSettlementAllocationIntentFundsNotReceived.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentFundsNotReceivedEventNotification>((Stripe.Events.V2PaymentsSettlementAllocationIntentFundsNotReceivedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsSettlementAllocationIntentMatchedEventNotification)
                {
                    this.v2PaymentsSettlementAllocationIntentMatched.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentMatchedEventNotification>((Stripe.Events.V2PaymentsSettlementAllocationIntentMatchedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsSettlementAllocationIntentNotFoundEventNotification)
                {
                    this.v2PaymentsSettlementAllocationIntentNotFound.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentNotFoundEventNotification>((Stripe.Events.V2PaymentsSettlementAllocationIntentNotFoundEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsSettlementAllocationIntentSettledEventNotification)
                {
                    this.v2PaymentsSettlementAllocationIntentSettled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentSettledEventNotification>((Stripe.Events.V2PaymentsSettlementAllocationIntentSettledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsSettlementAllocationIntentSubmittedEventNotification)
                {
                    this.v2PaymentsSettlementAllocationIntentSubmitted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentSubmittedEventNotification>((Stripe.Events.V2PaymentsSettlementAllocationIntentSubmittedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsSettlementAllocationIntentSplitCanceledEventNotification)
                {
                    this.v2PaymentsSettlementAllocationIntentSplitCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentSplitCanceledEventNotification>((Stripe.Events.V2PaymentsSettlementAllocationIntentSplitCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsSettlementAllocationIntentSplitCreatedEventNotification)
                {
                    this.v2PaymentsSettlementAllocationIntentSplitCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentSplitCreatedEventNotification>((Stripe.Events.V2PaymentsSettlementAllocationIntentSplitCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsSettlementAllocationIntentSplitSettledEventNotification)
                {
                    this.v2PaymentsSettlementAllocationIntentSplitSettled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentSplitSettledEventNotification>((Stripe.Events.V2PaymentsSettlementAllocationIntentSplitSettledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2ReportingReportRunCreatedEventNotification)
                {
                    this.v2ReportingReportRunCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2ReportingReportRunCreatedEventNotification>((Stripe.Events.V2ReportingReportRunCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2ReportingReportRunFailedEventNotification)
                {
                    this.v2ReportingReportRunFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2ReportingReportRunFailedEventNotification>((Stripe.Events.V2ReportingReportRunFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2ReportingReportRunSucceededEventNotification)
                {
                    this.v2ReportingReportRunSucceeded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2ReportingReportRunSucceededEventNotification>((Stripe.Events.V2ReportingReportRunSucceededEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2ReportingReportRunUpdatedEventNotification)
                {
                    this.v2ReportingReportRunUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2ReportingReportRunUpdatedEventNotification>((Stripe.Events.V2ReportingReportRunUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2SignalsAccountSignalFraudulentMerchantReadyEventNotification)
                {
                    this.v2SignalsAccountSignalFraudulentMerchantReady.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2SignalsAccountSignalFraudulentMerchantReadyEventNotification>((Stripe.Events.V2SignalsAccountSignalFraudulentMerchantReadyEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2SignalsAccountSignalMerchantDelinquencyReadyEventNotification)
                {
                    this.v2SignalsAccountSignalMerchantDelinquencyReady.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2SignalsAccountSignalMerchantDelinquencyReadyEventNotification>((Stripe.Events.V2SignalsAccountSignalMerchantDelinquencyReadyEventNotification)eventNotification, client));
                }

                // event-handler-dispatch: The end of the section generated from our OpenAPI spec
                else
                {
                    throw new Exception("unexpected state, please file a bug");
                }
            }
            else
            {
                // Unknown event type; invoke the unhandled event handler
                this.FallbackCallback.Invoke(
                    this,
                    new StripeUnhandledEventNotificationEventArgs(eventNotification, client, new UnhandledNotificationDetails(!(eventNotification is UnknownEventNotification))));
            }
        }
    }
}
