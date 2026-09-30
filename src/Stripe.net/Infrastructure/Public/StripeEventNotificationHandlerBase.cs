namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Stripe.Events;

    /// <summary>
    /// Shared registration and dispatch machinery for <see cref="StripeEventNotificationHandler"/>
    /// and <see cref="StripeEventNotificationHandlerWithoutVerification"/>.
    ///
    /// Deliberately declares no Handle method. C# resolves overloads by signature rather than
    /// replacing them, so if either handler derived from the other it would inherit — and publicly
    /// expose — the other's Handle. As siblings, each declares only its own.
    ///
    /// This type has to be public (CS0060 forbids a less-accessible base for a public class), but
    /// its constructor is internal, so it cannot be derived from outside this assembly.
    /// </summary>
    public abstract class StripeEventNotificationHandlerBase
    {
#pragma warning disable SA1401 // Fields should be private
        protected readonly StripeClient client;
#pragma warning restore SA1401 // Fields should be private
        private readonly HashSet<string> handledEventTypes = new HashSet<string>();
#pragma warning disable SA1401 // Fields should be private
        protected readonly StripeClientOptions clientOptions;
#pragma warning restore SA1401 // Fields should be private

        // A private EventHandler for each EventNotification. We'll route notifications to the correct handler.
        // private-event-handlers: The beginning of the section generated from our OpenAPI spec
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1AccountApplicationAuthorizedEventNotification>> v1AccountApplicationAuthorized;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1AccountApplicationDeauthorizedEventNotification>> v1AccountApplicationDeauthorized;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1AccountExternalAccountCreatedEventNotification>> v1AccountExternalAccountCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1AccountExternalAccountDeletedEventNotification>> v1AccountExternalAccountDeleted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1AccountExternalAccountUpdatedEventNotification>> v1AccountExternalAccountUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1AccountUpdatedEventNotification>> v1AccountUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ApplicationFeeCreatedEventNotification>> v1ApplicationFeeCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ApplicationFeeRefundUpdatedEventNotification>> v1ApplicationFeeRefundUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1ApplicationFeeRefundedEventNotification>> v1ApplicationFeeRefunded;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BalanceAvailableEventNotification>> v1BalanceAvailable;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BalanceSettingsUpdatedEventNotification>> v1BalanceSettingsUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingAlertTriggeredEventNotification>> v1BillingAlertTriggered;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingCreditBalanceTransactionCreatedEventNotification>> v1BillingCreditBalanceTransactionCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingCreditGrantCreatedEventNotification>> v1BillingCreditGrantCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingCreditGrantUpdatedEventNotification>> v1BillingCreditGrantUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterCreatedEventNotification>> v1BillingMeterCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterDeactivatedEventNotification>> v1BillingMeterDeactivated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterErrorReportTriggeredEventNotification>> v1BillingMeterErrorReportTriggered;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterNoMeterFoundEventNotification>> v1BillingMeterNoMeterFound;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterReactivatedEventNotification>> v1BillingMeterReactivated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterUpdatedEventNotification>> v1BillingMeterUpdated;
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
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerDiscountCreatedEventNotification>> v1CustomerDiscountCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerDiscountDeletedEventNotification>> v1CustomerDiscountDeleted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerDiscountUpdatedEventNotification>> v1CustomerDiscountUpdated;
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
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountAccountNumbersUpdatedEventNotification>> v1FinancialConnectionsAccountAccountNumbersUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountCreatedEventNotification>> v1FinancialConnectionsAccountCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountDeactivatedEventNotification>> v1FinancialConnectionsAccountDeactivated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountDisconnectedEventNotification>> v1FinancialConnectionsAccountDisconnected;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountExpectedDeactivationDateUpdatedEventNotification>> v1FinancialConnectionsAccountExpectedDeactivationDateUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountReactivatedEventNotification>> v1FinancialConnectionsAccountReactivated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountRefreshedBalanceEventNotification>> v1FinancialConnectionsAccountRefreshedBalance;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountRefreshedOwnershipEventNotification>> v1FinancialConnectionsAccountRefreshedOwnership;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountRefreshedTransactionsEventNotification>> v1FinancialConnectionsAccountRefreshedTransactions;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountSupportedPaymentMethodTypesUpdatedEventNotification>> v1FinancialConnectionsAccountSupportedPaymentMethodTypesUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountUpcomingAccountNumberExpiryEventNotification>> v1FinancialConnectionsAccountUpcomingAccountNumberExpiry;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountUpcomingDeactivationEventNotification>> v1FinancialConnectionsAccountUpcomingDeactivation;
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
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoicePaymentAttemptRequiredEventNotification>> v1InvoicePaymentAttemptRequired;
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
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CommerceProductCatalogImportsFailedEventNotification>> v2CommerceProductCatalogImportsFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CommerceProductCatalogImportsProcessingEventNotification>> v2CommerceProductCatalogImportsProcessing;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CommerceProductCatalogImportsSucceededEventNotification>> v2CommerceProductCatalogImportsSucceeded;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CommerceProductCatalogImportsSucceededWithErrorsEventNotification>> v2CommerceProductCatalogImportsSucceededWithErrors;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountClosedEventNotification>> v2CoreAccountClosed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountCreatedEventNotification>> v2CoreAccountCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountUpdatedEventNotification>> v2CoreAccountUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdatedEventNotification>> v2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationCustomerUpdatedEventNotification>> v2CoreAccountIncludingConfigurationCustomerUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationMerchantCapabilityStatusUpdatedEventNotification>> v2CoreAccountIncludingConfigurationMerchantCapabilityStatusUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationMerchantUpdatedEventNotification>> v2CoreAccountIncludingConfigurationMerchantUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdatedEventNotification>> v2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationRecipientUpdatedEventNotification>> v2CoreAccountIncludingConfigurationRecipientUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingDefaultsUpdatedEventNotification>> v2CoreAccountIncludingDefaultsUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingFutureRequirementsUpdatedEventNotification>> v2CoreAccountIncludingFutureRequirementsUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingIdentityUpdatedEventNotification>> v2CoreAccountIncludingIdentityUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingRequirementsUpdatedEventNotification>> v2CoreAccountIncludingRequirementsUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountLinkReturnedEventNotification>> v2CoreAccountLinkReturned;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountPersonCreatedEventNotification>> v2CoreAccountPersonCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountPersonDeletedEventNotification>> v2CoreAccountPersonDeleted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountPersonUpdatedEventNotification>> v2CoreAccountPersonUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreEventDestinationPingEventNotification>> v2CoreEventDestinationPing;

        // private-event-handlers: The end of the section generated from our OpenAPI spec
        private EventHandler<StripePreHandleEventNotificationEventArgs> preHandleCallback;

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeEventNotificationHandlerBase"/> class.
        /// </summary>
        /// <param name="client">The StripeClient instance to use for parsing and API requests.</param>
        /// <param name="fallbackCallback">The function to call when handing an event for whom there's no callback registered.</param>
        internal StripeEventNotificationHandlerBase(StripeClient client, Action<object, StripeUnhandledEventNotificationEventArgs> fallbackCallback)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            this.client = client;

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

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BalanceSettingsUpdatedEventNotification>> V1BalanceSettingsUpdated
        {
            add { this.AddEventHandler(ref this.v1BalanceSettingsUpdated, value, "v1.balance_settings.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingAlertTriggeredEventNotification>> V1BillingAlertTriggered
        {
            add { this.AddEventHandler(ref this.v1BillingAlertTriggered, value, "v1.billing.alert.triggered"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingCreditBalanceTransactionCreatedEventNotification>> V1BillingCreditBalanceTransactionCreated
        {
            add { this.AddEventHandler(ref this.v1BillingCreditBalanceTransactionCreated, value, "v1.billing.credit_balance_transaction.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingCreditGrantCreatedEventNotification>> V1BillingCreditGrantCreated
        {
            add { this.AddEventHandler(ref this.v1BillingCreditGrantCreated, value, "v1.billing.credit_grant.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingCreditGrantUpdatedEventNotification>> V1BillingCreditGrantUpdated
        {
            add { this.AddEventHandler(ref this.v1BillingCreditGrantUpdated, value, "v1.billing.credit_grant.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterCreatedEventNotification>> V1BillingMeterCreated
        {
            add { this.AddEventHandler(ref this.v1BillingMeterCreated, value, "v1.billing.meter.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterDeactivatedEventNotification>> V1BillingMeterDeactivated
        {
            add { this.AddEventHandler(ref this.v1BillingMeterDeactivated, value, "v1.billing.meter.deactivated"); }
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

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterReactivatedEventNotification>> V1BillingMeterReactivated
        {
            add { this.AddEventHandler(ref this.v1BillingMeterReactivated, value, "v1.billing.meter.reactivated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterUpdatedEventNotification>> V1BillingMeterUpdated
        {
            add { this.AddEventHandler(ref this.v1BillingMeterUpdated, value, "v1.billing.meter.updated"); }
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

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerDiscountCreatedEventNotification>> V1CustomerDiscountCreated
        {
            add { this.AddEventHandler(ref this.v1CustomerDiscountCreated, value, "v1.customer.discount.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerDiscountDeletedEventNotification>> V1CustomerDiscountDeleted
        {
            add { this.AddEventHandler(ref this.v1CustomerDiscountDeleted, value, "v1.customer.discount.deleted"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1CustomerDiscountUpdatedEventNotification>> V1CustomerDiscountUpdated
        {
            add { this.AddEventHandler(ref this.v1CustomerDiscountUpdated, value, "v1.customer.discount.updated"); }
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

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountAccountNumbersUpdatedEventNotification>> V1FinancialConnectionsAccountAccountNumbersUpdated
        {
            add { this.AddEventHandler(ref this.v1FinancialConnectionsAccountAccountNumbersUpdated, value, "v1.financial_connections.account.account_numbers_updated"); }
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

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountExpectedDeactivationDateUpdatedEventNotification>> V1FinancialConnectionsAccountExpectedDeactivationDateUpdated
        {
            add { this.AddEventHandler(ref this.v1FinancialConnectionsAccountExpectedDeactivationDateUpdated, value, "v1.financial_connections.account.expected_deactivation_date_updated"); }
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

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountSupportedPaymentMethodTypesUpdatedEventNotification>> V1FinancialConnectionsAccountSupportedPaymentMethodTypesUpdated
        {
            add { this.AddEventHandler(ref this.v1FinancialConnectionsAccountSupportedPaymentMethodTypesUpdated, value, "v1.financial_connections.account.supported_payment_method_types_updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountUpcomingAccountNumberExpiryEventNotification>> V1FinancialConnectionsAccountUpcomingAccountNumberExpiry
        {
            add { this.AddEventHandler(ref this.v1FinancialConnectionsAccountUpcomingAccountNumberExpiry, value, "v1.financial_connections.account.upcoming_account_number_expiry"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountUpcomingDeactivationEventNotification>> V1FinancialConnectionsAccountUpcomingDeactivation
        {
            add { this.AddEventHandler(ref this.v1FinancialConnectionsAccountUpcomingDeactivation, value, "v1.financial_connections.account.upcoming_deactivation"); }
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

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1InvoicePaymentAttemptRequiredEventNotification>> V1InvoicePaymentAttemptRequired
        {
            add { this.AddEventHandler(ref this.v1InvoicePaymentAttemptRequired, value, "v1.invoice.payment_attempt_required"); }
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

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreEventDestinationPingEventNotification>> V2CoreEventDestinationPing
        {
            add { this.AddEventHandler(ref this.v2CoreEventDestinationPing, value, "v2.core.event_destination.ping"); }
            remove { this.RemoveEventHandler(); }
        }

        // public-event-handlers: The end of the section generated from our OpenAPI spec

        /// <summary>
        /// A callback that runs before any event-specific callbacks. A useful place for
        /// event-agnostic logic, such as logging or checking for
        /// <see href="https://docs.stripe.com/webhooks#handle-duplicate-events">duplicate event deliveries</see>.
        ///
        /// The callback receives the parsed event notification and the context-scoped client.
        /// Setting <see cref="StripePreHandleEventNotificationEventArgs.Cancel"/> to <c>true</c>
        /// returns from <c>Handle</c> once the preHandle callback finishes, so further callbacks are called.
        /// </summary>
        public event EventHandler<StripePreHandleEventNotificationEventArgs> PreHandle
        {
            add
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                this.AssertHasntHandled();

                if (this.preHandleCallback != null)
                {
                    throw new InvalidOperationException("A PreHandle callback is already registered");
                }

                this.preHandleCallback = value;
            }

            remove
            {
                this.RemoveEventHandler();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this handler has already handled an event.
        /// Registering a callback afterwards is refused, since callbacks are expected to be
        /// registered once at startup; doing so later indicates a bug.
        ///
        /// Set naiively rather than with a lock: we expect registration to happen synchronously
        /// at startup and handling to happen afterwards, so a race here is not a real concern.
        /// </summary>
        protected bool HasHandledEvent { get; set; }

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
        /// Throws if callbacks can no longer be registered. Callbacks are expected to be
        /// registered once at startup, so registering anything after handling has begun
        /// indicates a bug.
        /// </summary>
        /// <exception cref="InvalidOperationException">
        /// Thrown if <c>Handle</c> has already been called.
        /// </exception>
        private void AssertHasntHandled()
        {
            if (this.HasHandledEvent)
            {
                throw new InvalidOperationException("Cannot register new callbacks after an event has been handled. This is indicative of a bug.");
            }
        }

        /// <summary>
        /// Dispatches the event with the event's StripeContext by creating a new client instance.
        /// </summary>
        /// <param name="eventNotification">The event notification to dispatch.</param>
        protected void DispatchEventWithContext(V2.Core.EventNotification eventNotification)
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

        /// <summary>
        /// Centralizes the logic for adding event handlers.
        ///
        /// Rejects a null callback rather than storing it. C# permits <c>SomeEvent += null</c>,
        /// which would otherwise record the event type as handled while leaving the backing
        /// delegate null — dispatch would then take the registered branch (bypassing the
        /// fallback) and throw a NullReferenceException far from the offending registration.
        /// </summary>
        private void AddEventHandler<T>(ref EventHandler<T> handler, EventHandler<T> value, string eventType)
        where T : EventArgs
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            this.AssertHasntHandled();

            if (this.handledEventTypes.Add(eventType))
            {
                handler = value;
            }
            else
            {
                throw new InvalidOperationException($"Callback for event type '{eventType}' is already registered");
            }
        }

        /// <summary>
        /// Centralizes the logic for removing event handlers.
        /// </summary>
        private void RemoveEventHandler()
        {
            throw new InvalidOperationException("Removing callbacks is not supported.");
        }

        private void DispatchEvent(V2.Core.EventNotification eventNotification, StripeClient client)
        {
            if (eventNotification == null)
            {
                throw new ArgumentNullException(nameof(eventNotification));
            }

            if (this.preHandleCallback != null)
            {
                var preHandleArgs = new StripePreHandleEventNotificationEventArgs(eventNotification, client);
                this.preHandleCallback.Invoke(this, preHandleArgs);

                if (preHandleArgs.Cancel)
                {
                    return;
                }
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
                else if (eventNotification is Stripe.Events.V1BalanceSettingsUpdatedEventNotification)
                {
                    this.v1BalanceSettingsUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1BalanceSettingsUpdatedEventNotification>((Stripe.Events.V1BalanceSettingsUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1BillingAlertTriggeredEventNotification)
                {
                    this.v1BillingAlertTriggered.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1BillingAlertTriggeredEventNotification>((Stripe.Events.V1BillingAlertTriggeredEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1BillingCreditBalanceTransactionCreatedEventNotification)
                {
                    this.v1BillingCreditBalanceTransactionCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1BillingCreditBalanceTransactionCreatedEventNotification>((Stripe.Events.V1BillingCreditBalanceTransactionCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1BillingCreditGrantCreatedEventNotification)
                {
                    this.v1BillingCreditGrantCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1BillingCreditGrantCreatedEventNotification>((Stripe.Events.V1BillingCreditGrantCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1BillingCreditGrantUpdatedEventNotification)
                {
                    this.v1BillingCreditGrantUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1BillingCreditGrantUpdatedEventNotification>((Stripe.Events.V1BillingCreditGrantUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1BillingMeterCreatedEventNotification)
                {
                    this.v1BillingMeterCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterCreatedEventNotification>((Stripe.Events.V1BillingMeterCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1BillingMeterDeactivatedEventNotification)
                {
                    this.v1BillingMeterDeactivated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterDeactivatedEventNotification>((Stripe.Events.V1BillingMeterDeactivatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1BillingMeterErrorReportTriggeredEventNotification)
                {
                    this.v1BillingMeterErrorReportTriggered.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterErrorReportTriggeredEventNotification>((Stripe.Events.V1BillingMeterErrorReportTriggeredEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1BillingMeterNoMeterFoundEventNotification)
                {
                    this.v1BillingMeterNoMeterFound.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterNoMeterFoundEventNotification>((Stripe.Events.V1BillingMeterNoMeterFoundEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1BillingMeterReactivatedEventNotification)
                {
                    this.v1BillingMeterReactivated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterReactivatedEventNotification>((Stripe.Events.V1BillingMeterReactivatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1BillingMeterUpdatedEventNotification)
                {
                    this.v1BillingMeterUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterUpdatedEventNotification>((Stripe.Events.V1BillingMeterUpdatedEventNotification)eventNotification, client));
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
                else if (eventNotification is Stripe.Events.V1CustomerDiscountCreatedEventNotification)
                {
                    this.v1CustomerDiscountCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CustomerDiscountCreatedEventNotification>((Stripe.Events.V1CustomerDiscountCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CustomerDiscountDeletedEventNotification)
                {
                    this.v1CustomerDiscountDeleted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CustomerDiscountDeletedEventNotification>((Stripe.Events.V1CustomerDiscountDeletedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CustomerDiscountUpdatedEventNotification)
                {
                    this.v1CustomerDiscountUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CustomerDiscountUpdatedEventNotification>((Stripe.Events.V1CustomerDiscountUpdatedEventNotification)eventNotification, client));
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
                else if (eventNotification is Stripe.Events.V1FinancialConnectionsAccountAccountNumbersUpdatedEventNotification)
                {
                    this.v1FinancialConnectionsAccountAccountNumbersUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountAccountNumbersUpdatedEventNotification>((Stripe.Events.V1FinancialConnectionsAccountAccountNumbersUpdatedEventNotification)eventNotification, client));
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
                else if (eventNotification is Stripe.Events.V1FinancialConnectionsAccountExpectedDeactivationDateUpdatedEventNotification)
                {
                    this.v1FinancialConnectionsAccountExpectedDeactivationDateUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountExpectedDeactivationDateUpdatedEventNotification>((Stripe.Events.V1FinancialConnectionsAccountExpectedDeactivationDateUpdatedEventNotification)eventNotification, client));
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
                else if (eventNotification is Stripe.Events.V1FinancialConnectionsAccountSupportedPaymentMethodTypesUpdatedEventNotification)
                {
                    this.v1FinancialConnectionsAccountSupportedPaymentMethodTypesUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountSupportedPaymentMethodTypesUpdatedEventNotification>((Stripe.Events.V1FinancialConnectionsAccountSupportedPaymentMethodTypesUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1FinancialConnectionsAccountUpcomingAccountNumberExpiryEventNotification)
                {
                    this.v1FinancialConnectionsAccountUpcomingAccountNumberExpiry.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountUpcomingAccountNumberExpiryEventNotification>((Stripe.Events.V1FinancialConnectionsAccountUpcomingAccountNumberExpiryEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1FinancialConnectionsAccountUpcomingDeactivationEventNotification)
                {
                    this.v1FinancialConnectionsAccountUpcomingDeactivation.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountUpcomingDeactivationEventNotification>((Stripe.Events.V1FinancialConnectionsAccountUpcomingDeactivationEventNotification)eventNotification, client));
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
                else if (eventNotification is Stripe.Events.V1InvoicePaymentAttemptRequiredEventNotification)
                {
                    this.v1InvoicePaymentAttemptRequired.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoicePaymentAttemptRequiredEventNotification>((Stripe.Events.V1InvoicePaymentAttemptRequiredEventNotification)eventNotification, client));
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
                else if (eventNotification is Stripe.Events.V2CoreEventDestinationPingEventNotification)
                {
                    this.v2CoreEventDestinationPing.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreEventDestinationPingEventNotification>((Stripe.Events.V2CoreEventDestinationPingEventNotification)eventNotification, client));
                }

                // event-handler-dispatch: The end of the section generated from our OpenAPI spec
                else
                {
                    throw new Exception("Unexpected state, please file a bug.");
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
