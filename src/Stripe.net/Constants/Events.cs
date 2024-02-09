// File generated from our OpenAPI spec
namespace Stripe
{
    using System;

    public static class Events
    {
        /// <summary>
        /// Occurs whenever a user authorizes an application. Sent to the related application only.
        /// </summary>
        public const string AccountApplicationAuthorized = "account.application.authorized";

        /// <summary>
        /// Occurs whenever a user deauthorizes an application. Sent to the related application
        /// only.
        /// </summary>
        public const string AccountApplicationDeauthorized = "account.application.deauthorized";

        /// <summary>
        /// Occurs whenever an external account is created.
        /// </summary>
        public const string AccountExternalAccountCreated = "account.external_account.created";

        /// <summary>
        /// Occurs whenever an external account is deleted.
        /// </summary>
        public const string AccountExternalAccountDeleted = "account.external_account.deleted";

        /// <summary>
        /// Occurs whenever an external account is updated.
        /// </summary>
        public const string AccountExternalAccountUpdated = "account.external_account.updated";

        /// <summary>
        /// Occurs whenever an account status or property has changed.
        /// </summary>
        public const string AccountUpdated = "account.updated";

        /// <summary>
        /// Occurs whenever an application fee is created on a charge.
        /// </summary>
        public const string ApplicationFeeCreated = "application_fee.created";

        /// <summary>
        /// Occurs whenever an application fee refund is updated.
        /// </summary>
        public const string ApplicationFeeRefundUpdated = "application_fee.refund.updated";

        /// <summary>
        /// Occurs whenever an application fee is refunded, whether from refunding a charge or from
        /// <a href="https://stripe.com/docs/api#fee_refunds">refunding the application fee
        /// directly</a>. This includes partial refunds.
        /// </summary>
        public const string ApplicationFeeRefunded = "application_fee.refunded";

        /// <summary>
        /// Occurs whenever your Stripe balance has been updated (e.g., when a charge is available
        /// to be paid out). By default, Stripe automatically transfers funds in your balance to
        /// your bank account on a daily basis. This event is not fired for negative transactions.
        /// </summary>
        public const string BalanceAvailable = "balance.available";

        /// <summary>
        /// Occurs whenever a portal configuration is created.
        /// </summary>
        public const string BillingPortalConfigurationCreated = "billing_portal.configuration.created";

        /// <summary>
        /// Occurs whenever a portal configuration is updated.
        /// </summary>
        public const string BillingPortalConfigurationUpdated = "billing_portal.configuration.updated";

        /// <summary>
        /// Occurs whenever a portal session is created.
        /// </summary>
        public const string BillingPortalSessionCreated = "billing_portal.session.created";

        /// <summary>
        /// Occurs whenever a capability has new requirements or a new status.
        /// </summary>
        public const string CapabilityUpdated = "capability.updated";

        /// <summary>
        /// Occurs whenever there is a positive remaining cash balance after Stripe automatically
        /// reconciles new funds into the cash balance. If you enabled manual reconciliation, this
        /// webhook will fire whenever there are new funds into the cash balance.
        /// </summary>
        public const string CashBalanceFundsAvailable = "cash_balance.funds_available";

        /// <summary>
        /// Occurs whenever a previously uncaptured charge is captured.
        /// </summary>
        public const string ChargeCaptured = "charge.captured";

        /// <summary>
        /// Occurs when a dispute is closed and the dispute status changes to <c>lost</c>,
        /// <c>warning_closed</c>, or <c>won</c>.
        /// </summary>
        public const string ChargeDisputeClosed = "charge.dispute.closed";

        /// <summary>
        /// Occurs whenever a customer disputes a charge with their bank.
        /// </summary>
        public const string ChargeDisputeCreated = "charge.dispute.created";

        /// <summary>
        /// Occurs when funds are reinstated to your account after a dispute is closed. This
        /// includes <a
        /// href="https://stripe.com/docs/disputes#disputes-on-partially-refunded-payments">partially
        /// refunded payments</a>.
        /// </summary>
        public const string ChargeDisputeFundsReinstated = "charge.dispute.funds_reinstated";

        /// <summary>
        /// Occurs when funds are removed from your account due to a dispute.
        /// </summary>
        public const string ChargeDisputeFundsWithdrawn = "charge.dispute.funds_withdrawn";

        /// <summary>
        /// Occurs when the dispute is updated (usually with evidence).
        /// </summary>
        public const string ChargeDisputeUpdated = "charge.dispute.updated";

        /// <summary>
        /// Occurs whenever an uncaptured charge expires.
        /// </summary>
        public const string ChargeExpired = "charge.expired";

        /// <summary>
        /// Occurs whenever a failed charge attempt occurs.
        /// </summary>
        public const string ChargeFailed = "charge.failed";

        /// <summary>
        /// Occurs whenever a pending charge is created.
        /// </summary>
        public const string ChargePending = "charge.pending";

        /// <summary>
        /// Occurs whenever a refund is updated, on selected payment methods.
        /// </summary>
        public const string ChargeRefundUpdated = "charge.refund.updated";

        /// <summary>
        /// Occurs whenever a charge is refunded, including partial refunds.
        /// </summary>
        public const string ChargeRefunded = "charge.refunded";

        /// <summary>
        /// Occurs whenever a charge is successful.
        /// </summary>
        public const string ChargeSucceeded = "charge.succeeded";

        /// <summary>
        /// Occurs whenever a charge description or metadata is updated, or upon an asynchronous
        /// capture.
        /// </summary>
        public const string ChargeUpdated = "charge.updated";

        /// <summary>
        /// Occurs when a payment intent using a delayed payment method fails.
        /// </summary>
        public const string CheckoutSessionAsyncPaymentFailed = "checkout.session.async_payment_failed";

        /// <summary>
        /// Occurs when a payment intent using a delayed payment method finally succeeds.
        /// </summary>
        public const string CheckoutSessionAsyncPaymentSucceeded = "checkout.session.async_payment_succeeded";

        /// <summary>
        /// Occurs when a Checkout Session has been successfully completed.
        /// </summary>
        public const string CheckoutSessionCompleted = "checkout.session.completed";

        /// <summary>
        /// Occurs when a Checkout Session is expired.
        /// </summary>
        public const string CheckoutSessionExpired = "checkout.session.expired";

        /// <summary>
        /// Occurs when a Climate order is canceled.
        /// </summary>
        public const string ClimateOrderCanceled = "climate.order.canceled";

        /// <summary>
        /// Occurs when a Climate order is created.
        /// </summary>
        public const string ClimateOrderCreated = "climate.order.created";

        /// <summary>
        /// Occurs when a Climate order is delayed.
        /// </summary>
        public const string ClimateOrderDelayed = "climate.order.delayed";

        /// <summary>
        /// Occurs when a Climate order is delivered.
        /// </summary>
        public const string ClimateOrderDelivered = "climate.order.delivered";

        /// <summary>
        /// Occurs when a Climate order's product is substituted for another.
        /// </summary>
        public const string ClimateOrderProductSubstituted = "climate.order.product_substituted";

        /// <summary>
        /// Occurs when a Climate product is created.
        /// </summary>
        public const string ClimateProductCreated = "climate.product.created";

        /// <summary>
        /// Occurs when a Climate product is updated.
        /// </summary>
        public const string ClimateProductPricingUpdated = "climate.product.pricing_updated";

        /// <summary>
        /// Occurs whenever a coupon is created.
        /// </summary>
        public const string CouponCreated = "coupon.created";

        /// <summary>
        /// Occurs whenever a coupon is deleted.
        /// </summary>
        public const string CouponDeleted = "coupon.deleted";

        /// <summary>
        /// Occurs whenever a coupon is updated.
        /// </summary>
        public const string CouponUpdated = "coupon.updated";

        /// <summary>
        /// Occurs whenever a credit note is created.
        /// </summary>
        public const string CreditNoteCreated = "credit_note.created";

        /// <summary>
        /// Occurs whenever a credit note is updated.
        /// </summary>
        public const string CreditNoteUpdated = "credit_note.updated";

        /// <summary>
        /// Occurs whenever a credit note is voided.
        /// </summary>
        public const string CreditNoteVoided = "credit_note.voided";

        /// <summary>
        /// Occurs whenever a new customer cash balance transactions is created.
        /// </summary>
        public const string CustomerCashBalanceTransactionCreated = "customer_cash_balance_transaction.created";

        /// <summary>
        /// Occurs whenever a new customer is created.
        /// </summary>
        public const string CustomerCreated = "customer.created";

        /// <summary>
        /// Occurs whenever a customer is deleted.
        /// </summary>
        public const string CustomerDeleted = "customer.deleted";

        /// <summary>
        /// Occurs whenever a coupon is attached to a customer.
        /// </summary>
        public const string CustomerDiscountCreated = "customer.discount.created";

        /// <summary>
        /// Occurs whenever a coupon is removed from a customer.
        /// </summary>
        public const string CustomerDiscountDeleted = "customer.discount.deleted";

        /// <summary>
        /// Occurs whenever a customer is switched from one coupon to another.
        /// </summary>
        public const string CustomerDiscountUpdated = "customer.discount.updated";

        /// <summary>
        /// Occurs whenever a new source is created for a customer.
        /// </summary>
        public const string CustomerSourceCreated = "customer.source.created";

        /// <summary>
        /// Occurs whenever a source is removed from a customer.
        /// </summary>
        public const string CustomerSourceDeleted = "customer.source.deleted";

        /// <summary>
        /// Occurs whenever a card or source will expire at the end of the month.
        /// </summary>
        public const string CustomerSourceExpiring = "customer.source.expiring";

        /// <summary>
        /// Occurs whenever a source's details are changed.
        /// </summary>
        public const string CustomerSourceUpdated = "customer.source.updated";

        /// <summary>
        /// Occurs whenever a customer is signed up for a new plan.
        /// </summary>
        public const string CustomerSubscriptionCreated = "customer.subscription.created";

        /// <summary>
        /// Occurs whenever a customer's subscription ends.
        /// </summary>
        public const string CustomerSubscriptionDeleted = "customer.subscription.deleted";

        /// <summary>
        /// Occurs whenever a customer's subscription is paused. Only applies when subscriptions
        /// enter <c>status=paused</c>, not when <a
        /// href="https://stripe.com/docs/billing/subscriptions/pause">payment collection</a> is
        /// paused.
        /// </summary>
        public const string CustomerSubscriptionPaused = "customer.subscription.paused";

        /// <summary>
        /// Occurs whenever a customer's subscription's pending update is applied, and the
        /// subscription is updated.
        /// </summary>
        public const string CustomerSubscriptionPendingUpdateApplied = "customer.subscription.pending_update_applied";

        /// <summary>
        /// Occurs whenever a customer's subscription's pending update expires before the related
        /// invoice is paid.
        /// </summary>
        public const string CustomerSubscriptionPendingUpdateExpired = "customer.subscription.pending_update_expired";

        /// <summary>
        /// Occurs whenever a customer's subscription is no longer paused. Only applies when a
        /// <c>status=paused</c> subscription is <a
        /// href="https://stripe.com/docs/api/subscriptions/resume">resumed</a>, not when <a
        /// href="https://stripe.com/docs/billing/subscriptions/pause">payment collection</a> is
        /// resumed.
        /// </summary>
        public const string CustomerSubscriptionResumed = "customer.subscription.resumed";

        /// <summary>
        /// Occurs three days before a subscription's trial period is scheduled to end, or when a
        /// trial is ended immediately (using <c>trial_end=now</c>).
        /// </summary>
        public const string CustomerSubscriptionTrialWillEnd = "customer.subscription.trial_will_end";

        /// <summary>
        /// Occurs whenever a subscription changes (e.g., switching from one plan to another, or
        /// changing the status from trial to active).
        /// </summary>
        public const string CustomerSubscriptionUpdated = "customer.subscription.updated";

        /// <summary>
        /// Occurs whenever a tax ID is created for a customer.
        /// </summary>
        public const string CustomerTaxIdCreated = "customer.tax_id.created";

        /// <summary>
        /// Occurs whenever a tax ID is deleted from a customer.
        /// </summary>
        public const string CustomerTaxIdDeleted = "customer.tax_id.deleted";

        /// <summary>
        /// Occurs whenever a customer's tax ID is updated.
        /// </summary>
        public const string CustomerTaxIdUpdated = "customer.tax_id.updated";

        /// <summary>
        /// Occurs whenever any property of a customer changes.
        /// </summary>
        public const string CustomerUpdated = "customer.updated";

        /// <summary>
        /// Occurs whenever a new Stripe-generated file is available for your account.
        /// </summary>
        public const string FileCreated = "file.created";

        /// <summary>
        /// Occurs when a new Financial Connections account is created.
        /// </summary>
        public const string FinancialConnectionsAccountCreated = "financial_connections.account.created";

        /// <summary>
        /// Occurs when a Financial Connections account's status is updated from <c>active</c> to
        /// <c>inactive</c>.
        /// </summary>
        public const string FinancialConnectionsAccountDeactivated = "financial_connections.account.deactivated";

        /// <summary>
        /// Occurs when a Financial Connections account is disconnected.
        /// </summary>
        public const string FinancialConnectionsAccountDisconnected = "financial_connections.account.disconnected";

        /// <summary>
        /// Occurs when a Financial Connections account's status is updated from <c>inactive</c> to
        /// <c>active</c>.
        /// </summary>
        public const string FinancialConnectionsAccountReactivated = "financial_connections.account.reactivated";

        /// <summary>
        /// Occurs when an Account’s <c>balance_refresh</c> status transitions from <c>pending</c>
        /// to either <c>succeeded</c> or <c>failed</c>.
        /// </summary>
        public const string FinancialConnectionsAccountRefreshedBalance = "financial_connections.account.refreshed_balance";

        /// <summary>
        /// Occurs when an Account’s <c>ownership_refresh</c> status transitions from <c>pending</c>
        /// to either <c>succeeded</c> or <c>failed</c>.
        /// </summary>
        public const string FinancialConnectionsAccountRefreshedOwnership = "financial_connections.account.refreshed_ownership";

        /// <summary>
        /// Occurs when an Account’s <c>transaction_refresh</c> status transitions from
        /// <c>pending</c> to either <c>succeeded</c> or <c>failed</c>.
        /// </summary>
        public const string FinancialConnectionsAccountRefreshedTransactions = "financial_connections.account.refreshed_transactions";

        /// <summary>
        /// Occurs whenever a VerificationSession is canceled.
        /// </summary>
        public const string IdentityVerificationSessionCanceled = "identity.verification_session.canceled";

        /// <summary>
        /// Occurs whenever a VerificationSession is created.
        /// </summary>
        public const string IdentityVerificationSessionCreated = "identity.verification_session.created";

        /// <summary>
        /// Occurs whenever a VerificationSession transitions to processing.
        /// </summary>
        public const string IdentityVerificationSessionProcessing = "identity.verification_session.processing";

        /// <summary>
        /// Occurs whenever a VerificationSession is redacted.
        /// </summary>
        public const string IdentityVerificationSessionRedacted = "identity.verification_session.redacted";

        /// <summary>
        /// Occurs whenever a VerificationSession transitions to require user input.
        /// </summary>
        public const string IdentityVerificationSessionRequiresInput = "identity.verification_session.requires_input";

        /// <summary>
        /// Occurs whenever a VerificationSession transitions to verified.
        /// </summary>
        public const string IdentityVerificationSessionVerified = "identity.verification_session.verified";

        /// <summary>
        /// Occurs whenever a new invoice is created. To learn how webhooks can be used with this
        /// event, and how they can affect it, see <a
        /// href="https://stripe.com/docs/subscriptions/webhooks">Using Webhooks with
        /// Subscriptions</a>.
        /// </summary>
        public const string InvoiceCreated = "invoice.created";

        /// <summary>
        /// Occurs whenever a draft invoice is deleted.
        /// </summary>
        public const string InvoiceDeleted = "invoice.deleted";

        /// <summary>
        /// Occurs whenever a draft invoice cannot be finalized. See the invoice’s <a
        /// href="https://stripe.com/docs/api/invoices/object#invoice_object-last_finalization_error">last
        /// finalization error</a> for details.
        /// </summary>
        public const string InvoiceFinalizationFailed = "invoice.finalization_failed";

        /// <summary>
        /// Occurs whenever a draft invoice is finalized and updated to be an open invoice.
        /// </summary>
        public const string InvoiceFinalized = "invoice.finalized";

        /// <summary>
        /// Occurs whenever an invoice is marked uncollectible.
        /// </summary>
        public const string InvoiceMarkedUncollectible = "invoice.marked_uncollectible";

        /// <summary>
        /// Occurs whenever an invoice payment attempt succeeds or an invoice is marked as paid
        /// out-of-band.
        /// </summary>
        public const string InvoicePaid = "invoice.paid";

        /// <summary>
        /// Occurs whenever an invoice payment attempt requires further user action to complete.
        /// </summary>
        public const string InvoicePaymentActionRequired = "invoice.payment_action_required";

        /// <summary>
        /// Occurs whenever an invoice payment attempt fails, due either to a declined payment or to
        /// the lack of a stored payment method.
        /// </summary>
        public const string InvoicePaymentFailed = "invoice.payment_failed";

        /// <summary>
        /// Occurs whenever an invoice payment attempt succeeds.
        /// </summary>
        public const string InvoicePaymentSucceeded = "invoice.payment_succeeded";

        /// <summary>
        /// Occurs whenever an invoice email is sent out.
        /// </summary>
        public const string InvoiceSent = "invoice.sent";

        /// <summary>
        /// Occurs X number of days before a subscription is scheduled to create an invoice that is
        /// automatically charged—where X is determined by your <a
        /// href="https://dashboard.stripe.com/account/billing/automatic">subscriptions
        /// settings</a>. Note: The received <c>Invoice</c> object will not have an invoice ID.
        /// </summary>
        public const string InvoiceUpcoming = "invoice.upcoming";

        /// <summary>
        /// Occurs whenever an invoice changes (e.g., the invoice amount).
        /// </summary>
        public const string InvoiceUpdated = "invoice.updated";

        /// <summary>
        /// Occurs whenever an invoice is voided.
        /// </summary>
        public const string InvoiceVoided = "invoice.voided";

        /// <summary>
        /// Occurs whenever an invoice item is created.
        /// </summary>
        public const string InvoiceItemCreated = "invoiceitem.created";

        /// <summary>
        /// Occurs whenever an invoice item is deleted.
        /// </summary>
        public const string InvoiceItemDeleted = "invoiceitem.deleted";

        /// <summary>
        /// The "invoiceitem.updated" event is deprecated and will be removed in the next major
        /// version.
        /// </summary>
        [Obsolete("This event is deprecated and going to be removed")]
        public const string InvoiceItemUpdated = "invoiceitem.updated";

        /// <summary>
        /// Occurs whenever an authorization is created.
        /// </summary>
        public const string IssuingAuthorizationCreated = "issuing_authorization.created";

        /// <summary>
        /// Represents a synchronous request for authorization, see <a
        /// href="https://stripe.com/docs/issuing/purchases/authorizations#authorization-handling">Using
        /// your integration to handle authorization requests</a>.
        /// </summary>
        public const string IssuingAuthorizationRequest = "issuing_authorization.request";

        /// <summary>
        /// Occurs whenever an authorization is updated.
        /// </summary>
        public const string IssuingAuthorizationUpdated = "issuing_authorization.updated";

        /// <summary>
        /// Occurs whenever a card is created.
        /// </summary>
        public const string IssuingCardCreated = "issuing_card.created";

        /// <summary>
        /// Occurs whenever a card is updated.
        /// </summary>
        public const string IssuingCardUpdated = "issuing_card.updated";

        /// <summary>
        /// Occurs whenever a cardholder is created.
        /// </summary>
        public const string IssuingCardholderCreated = "issuing_cardholder.created";

        /// <summary>
        /// Occurs whenever a cardholder is updated.
        /// </summary>
        public const string IssuingCardholderUpdated = "issuing_cardholder.updated";

        /// <summary>
        /// Occurs whenever a dispute is won, lost or expired.
        /// </summary>
        public const string IssuingDisputeClosed = "issuing_dispute.closed";

        /// <summary>
        /// Occurs whenever a dispute is created.
        /// </summary>
        public const string IssuingDisputeCreated = "issuing_dispute.created";

        /// <summary>
        /// Occurs whenever funds are reinstated to your account for an Issuing dispute.
        /// </summary>
        public const string IssuingDisputeFundsReinstated = "issuing_dispute.funds_reinstated";

        /// <summary>
        /// Occurs whenever a dispute is submitted.
        /// </summary>
        public const string IssuingDisputeSubmitted = "issuing_dispute.submitted";

        /// <summary>
        /// Occurs whenever a dispute is updated.
        /// </summary>
        public const string IssuingDisputeUpdated = "issuing_dispute.updated";

        /// <summary>
        /// Occurs whenever an issuing digital wallet token is created.
        /// </summary>
        public const string IssuingTokenCreated = "issuing_token.created";

        /// <summary>
        /// Occurs whenever an issuing digital wallet token is updated.
        /// </summary>
        public const string IssuingTokenUpdated = "issuing_token.updated";

        /// <summary>
        /// Occurs whenever an issuing transaction is created.
        /// </summary>
        public const string IssuingTransactionCreated = "issuing_transaction.created";

        /// <summary>
        /// Occurs whenever an issuing transaction is updated.
        /// </summary>
        public const string IssuingTransactionUpdated = "issuing_transaction.updated";

        /// <summary>
        /// Occurs whenever a Mandate is updated.
        /// </summary>
        public const string MandateUpdated = "mandate.updated";

        /// <summary>
        /// The "order.created" event is deprecated and will be removed in the next major version.
        /// </summary>
        [Obsolete("This event is deprecated and going to be removed")]
        public const string OrderCreated = "order.created";

        /// <summary>
        /// Occurs when a PaymentIntent has funds to be captured. Check the <c>amount_capturable</c>
        /// property on the PaymentIntent to determine the amount that can be captured. You may
        /// capture the PaymentIntent with an <c>amount_to_capture</c> value up to the specified
        /// amount. <a href="https://stripe.com/docs/api/payment_intents/capture">Learn more about
        /// capturing PaymentIntents.</a>.
        /// </summary>
        public const string PaymentIntentAmountCapturableUpdated = "payment_intent.amount_capturable_updated";

        /// <summary>
        /// Occurs when a PaymentIntent is canceled.
        /// </summary>
        public const string PaymentIntentCanceled = "payment_intent.canceled";

        /// <summary>
        /// Occurs when a new PaymentIntent is created.
        /// </summary>
        public const string PaymentIntentCreated = "payment_intent.created";

        /// <summary>
        /// Occurs when funds are applied to a customer_balance PaymentIntent and the
        /// 'amount_remaining' changes.
        /// </summary>
        public const string PaymentIntentPartiallyFunded = "payment_intent.partially_funded";

        /// <summary>
        /// Occurs when a PaymentIntent has failed the attempt to create a payment method or a
        /// payment.
        /// </summary>
        public const string PaymentIntentPaymentFailed = "payment_intent.payment_failed";

        /// <summary>
        /// Occurs when a PaymentIntent has started processing.
        /// </summary>
        public const string PaymentIntentProcessing = "payment_intent.processing";

        /// <summary>
        /// Occurs when a PaymentIntent transitions to requires_action state.
        /// </summary>
        public const string PaymentIntentRequiresAction = "payment_intent.requires_action";

        /// <summary>
        /// Occurs when a PaymentIntent has successfully completed payment.
        /// </summary>
        public const string PaymentIntentSucceeded = "payment_intent.succeeded";

        /// <summary>
        /// Occurs when a payment link is created.
        /// </summary>
        public const string PaymentLinkCreated = "payment_link.created";

        /// <summary>
        /// Occurs when a payment link is updated.
        /// </summary>
        public const string PaymentLinkUpdated = "payment_link.updated";

        /// <summary>
        /// Occurs whenever a new payment method is attached to a customer.
        /// </summary>
        public const string PaymentMethodAttached = "payment_method.attached";

        /// <summary>
        /// Occurs whenever a payment method's details are automatically updated by the network.
        /// </summary>
        public const string PaymentMethodAutomaticallyUpdated = "payment_method.automatically_updated";

        /// <summary>
        /// Occurs whenever a payment method is detached from a customer.
        /// </summary>
        public const string PaymentMethodDetached = "payment_method.detached";

        /// <summary>
        /// Occurs whenever a payment method is updated via the <a
        /// href="https://stripe.com/docs/api/payment_methods/update">PaymentMethod update API</a>.
        /// </summary>
        public const string PaymentMethodUpdated = "payment_method.updated";

        /// <summary>
        /// Occurs whenever a payout is canceled.
        /// </summary>
        public const string PayoutCanceled = "payout.canceled";

        /// <summary>
        /// Occurs whenever a payout is created.
        /// </summary>
        public const string PayoutCreated = "payout.created";

        /// <summary>
        /// Occurs whenever a payout attempt fails.
        /// </summary>
        public const string PayoutFailed = "payout.failed";

        /// <summary>
        /// Occurs whenever a payout is <em>expected</em> to be available in the destination
        /// account. If the payout fails, a <c>payout.failed</c> notification is also sent, at a
        /// later time.
        /// </summary>
        public const string PayoutPaid = "payout.paid";

        /// <summary>
        /// Occurs whenever balance transactions paid out in an automatic payout can be queried.
        /// </summary>
        public const string PayoutReconciliationCompleted = "payout.reconciliation_completed";

        /// <summary>
        /// Occurs whenever a payout is updated.
        /// </summary>
        public const string PayoutUpdated = "payout.updated";

        /// <summary>
        /// Occurs whenever a person associated with an account is created.
        /// </summary>
        public const string PersonCreated = "person.created";

        /// <summary>
        /// Occurs whenever a person associated with an account is deleted.
        /// </summary>
        public const string PersonDeleted = "person.deleted";

        /// <summary>
        /// Occurs whenever a person associated with an account is updated.
        /// </summary>
        public const string PersonUpdated = "person.updated";

        /// <summary>
        /// The "ping" event type. See https://stripe.com/docs/api/events/types#event_types-ping for
        /// details.
        /// </summary>
        public const string Ping = "ping";

        /// <summary>
        /// Occurs whenever a plan is created.
        /// </summary>
        public const string PlanCreated = "plan.created";

        /// <summary>
        /// Occurs whenever a plan is deleted.
        /// </summary>
        public const string PlanDeleted = "plan.deleted";

        /// <summary>
        /// Occurs whenever a plan is updated.
        /// </summary>
        public const string PlanUpdated = "plan.updated";

        /// <summary>
        /// Occurs whenever a price is created.
        /// </summary>
        public const string PriceCreated = "price.created";

        /// <summary>
        /// Occurs whenever a price is deleted.
        /// </summary>
        public const string PriceDeleted = "price.deleted";

        /// <summary>
        /// Occurs whenever a price is updated.
        /// </summary>
        public const string PriceUpdated = "price.updated";

        /// <summary>
        /// Occurs whenever a product is created.
        /// </summary>
        public const string ProductCreated = "product.created";

        /// <summary>
        /// Occurs whenever a product is deleted.
        /// </summary>
        public const string ProductDeleted = "product.deleted";

        /// <summary>
        /// Occurs whenever a product is updated.
        /// </summary>
        public const string ProductUpdated = "product.updated";

        /// <summary>
        /// Occurs whenever a promotion code is created.
        /// </summary>
        public const string PromotionCodeCreated = "promotion_code.created";

        /// <summary>
        /// Occurs whenever a promotion code is updated.
        /// </summary>
        public const string PromotionCodeUpdated = "promotion_code.updated";

        /// <summary>
        /// Occurs whenever a quote is accepted.
        /// </summary>
        public const string QuoteAccepted = "quote.accepted";

        /// <summary>
        /// Occurs whenever a quote is canceled.
        /// </summary>
        public const string QuoteCanceled = "quote.canceled";

        /// <summary>
        /// Occurs whenever a quote is created.
        /// </summary>
        public const string QuoteCreated = "quote.created";

        /// <summary>
        /// Occurs whenever a quote is finalized.
        /// </summary>
        public const string QuoteFinalized = "quote.finalized";

        /// <summary>
        /// Occurs whenever an early fraud warning is created.
        /// </summary>
        public const string RadarEarlyFraudWarningCreated = "radar.early_fraud_warning.created";

        /// <summary>
        /// Occurs whenever an early fraud warning is updated.
        /// </summary>
        public const string RadarEarlyFraudWarningUpdated = "radar.early_fraud_warning.updated";

        /// <summary>
        /// The "recipient.created" event is deprecated and will be removed in the next major
        /// version.
        /// </summary>
        [Obsolete("This event is deprecated and going to be removed")]
        public const string RecipientCreated = "recipient.created";

        /// <summary>
        /// The "recipient.deleted" event is deprecated and will be removed in the next major
        /// version.
        /// </summary>
        [Obsolete("This event is deprecated and going to be removed")]
        public const string RecipientDeleted = "recipient.deleted";

        /// <summary>
        /// The "recipient.updated" event is deprecated and will be removed in the next major
        /// version.
        /// </summary>
        [Obsolete("This event is deprecated and going to be removed")]
        public const string RecipientUpdated = "recipient.updated";

        /// <summary>
        /// Occurs whenever a refund from a customer's cash balance is created.
        /// </summary>
        public const string RefundCreated = "refund.created";

        /// <summary>
        /// Occurs whenever a refund from a customer's cash balance is updated.
        /// </summary>
        public const string RefundUpdated = "refund.updated";

        /// <summary>
        /// Occurs whenever a requested <c>ReportRun</c> failed to complete.
        /// </summary>
        public const string ReportingReportRunFailed = "reporting.report_run.failed";

        /// <summary>
        /// Occurs whenever a requested <c>ReportRun</c> completed successfully.
        /// </summary>
        public const string ReportingReportRunSucceeded = "reporting.report_run.succeeded";

        /// <summary>
        /// Occurs whenever a <c>ReportType</c> is updated (typically to indicate that a new day's
        /// data has come available).
        /// </summary>
        public const string ReportingReportTypeUpdated = "reporting.report_type.updated";

        /// <summary>
        /// Occurs whenever a review is closed. The review's <c>reason</c> field indicates why:
        /// <c>approved</c>, <c>disputed</c>, <c>refunded</c>, or <c>refunded_as_fraud</c>.
        /// </summary>
        public const string ReviewClosed = "review.closed";

        /// <summary>
        /// Occurs whenever a review is opened.
        /// </summary>
        public const string ReviewOpened = "review.opened";

        /// <summary>
        /// Occurs when a SetupIntent is canceled.
        /// </summary>
        public const string SetupIntentCanceled = "setup_intent.canceled";

        /// <summary>
        /// Occurs when a new SetupIntent is created.
        /// </summary>
        public const string SetupIntentCreated = "setup_intent.created";

        /// <summary>
        /// Occurs when a SetupIntent is in requires_action state.
        /// </summary>
        public const string SetupIntentRequiresAction = "setup_intent.requires_action";

        /// <summary>
        /// Occurs when a SetupIntent has failed the attempt to setup a payment method.
        /// </summary>
        public const string SetupIntentSetupFailed = "setup_intent.setup_failed";

        /// <summary>
        /// Occurs when an SetupIntent has successfully setup a payment method.
        /// </summary>
        public const string SetupIntentSucceeded = "setup_intent.succeeded";

        /// <summary>
        /// Occurs whenever a Sigma scheduled query run finishes.
        /// </summary>
        public const string SigmaScheduledQueryRunCreated = "sigma.scheduled_query_run.created";

        /// <summary>
        /// The "sku.created" event is deprecated and will be removed in the next major version.
        /// </summary>
        [Obsolete("This event is deprecated and going to be removed")]
        public const string SkuCreated = "sku.created";

        /// <summary>
        /// The "sku.deleted" event is deprecated and will be removed in the next major version.
        /// </summary>
        [Obsolete("This event is deprecated and going to be removed")]
        public const string SkuDeleted = "sku.deleted";

        /// <summary>
        /// The "sku.updated" event is deprecated and will be removed in the next major version.
        /// </summary>
        [Obsolete("This event is deprecated and going to be removed")]
        public const string SkuUpdated = "sku.updated";

        /// <summary>
        /// Occurs whenever a source is canceled.
        /// </summary>
        public const string SourceCanceled = "source.canceled";

        /// <summary>
        /// Occurs whenever a source transitions to chargeable.
        /// </summary>
        public const string SourceChargeable = "source.chargeable";

        /// <summary>
        /// Occurs whenever a source fails.
        /// </summary>
        public const string SourceFailed = "source.failed";

        /// <summary>
        /// Occurs whenever a source mandate notification method is set to manual.
        /// </summary>
        public const string SourceMandateNotification = "source.mandate_notification";

        /// <summary>
        /// Occurs whenever the refund attributes are required on a receiver source to process a
        /// refund or a mispayment.
        /// </summary>
        public const string SourceRefundAttributesRequired = "source.refund_attributes_required";

        /// <summary>
        /// Occurs whenever a source transaction is created.
        /// </summary>
        public const string SourceTransactionCreated = "source.transaction.created";

        /// <summary>
        /// Occurs whenever a source transaction is updated.
        /// </summary>
        public const string SourceTransactionUpdated = "source.transaction.updated";

        /// <summary>
        /// Occurs whenever a subscription schedule is canceled due to the underlying subscription
        /// being canceled because of delinquency.
        /// </summary>
        public const string SubscriptionScheduleAborted = "subscription_schedule.aborted";

        /// <summary>
        /// Occurs whenever a subscription schedule is canceled.
        /// </summary>
        public const string SubscriptionScheduleCanceled = "subscription_schedule.canceled";

        /// <summary>
        /// Occurs whenever a new subscription schedule is completed.
        /// </summary>
        public const string SubscriptionScheduleCompleted = "subscription_schedule.completed";

        /// <summary>
        /// Occurs whenever a new subscription schedule is created.
        /// </summary>
        public const string SubscriptionScheduleCreated = "subscription_schedule.created";

        /// <summary>
        /// Occurs 7 days before a subscription schedule will expire.
        /// </summary>
        public const string SubscriptionScheduleExpiring = "subscription_schedule.expiring";

        /// <summary>
        /// Occurs whenever a new subscription schedule is released.
        /// </summary>
        public const string SubscriptionScheduleReleased = "subscription_schedule.released";

        /// <summary>
        /// Occurs whenever a subscription schedule is updated.
        /// </summary>
        public const string SubscriptionScheduleUpdated = "subscription_schedule.updated";

        /// <summary>
        /// Occurs whenever a new tax rate is created.
        /// </summary>
        public const string TaxRateCreated = "tax_rate.created";

        /// <summary>
        /// Occurs whenever a tax rate is updated.
        /// </summary>
        public const string TaxRateUpdated = "tax_rate.updated";

        /// <summary>
        /// Occurs whenever tax settings is updated.
        /// </summary>
        public const string TaxSettingsUpdated = "tax.settings.updated";

        /// <summary>
        /// Occurs whenever an action sent to a Terminal reader failed.
        /// </summary>
        public const string TerminalReaderActionFailed = "terminal.reader.action_failed";

        /// <summary>
        /// Occurs whenever an action sent to a Terminal reader was successful.
        /// </summary>
        public const string TerminalReaderActionSucceeded = "terminal.reader.action_succeeded";

        /// <summary>
        /// Occurs whenever a test clock starts advancing.
        /// </summary>
        public const string TestHelpersTestClockAdvancing = "test_helpers.test_clock.advancing";

        /// <summary>
        /// Occurs whenever a test clock is created.
        /// </summary>
        public const string TestHelpersTestClockCreated = "test_helpers.test_clock.created";

        /// <summary>
        /// Occurs whenever a test clock is deleted.
        /// </summary>
        public const string TestHelpersTestClockDeleted = "test_helpers.test_clock.deleted";

        /// <summary>
        /// Occurs whenever a test clock fails to advance its frozen time.
        /// </summary>
        public const string TestHelpersTestClockInternalFailure = "test_helpers.test_clock.internal_failure";

        /// <summary>
        /// Occurs whenever a test clock transitions to a ready status.
        /// </summary>
        public const string TestHelpersTestClockReady = "test_helpers.test_clock.ready";

        /// <summary>
        /// Occurs whenever a top-up is canceled.
        /// </summary>
        public const string TopupCanceled = "topup.canceled";

        /// <summary>
        /// Occurs whenever a top-up is created.
        /// </summary>
        public const string TopupCreated = "topup.created";

        /// <summary>
        /// Occurs whenever a top-up fails.
        /// </summary>
        public const string TopupFailed = "topup.failed";

        /// <summary>
        /// Occurs whenever a top-up is reversed.
        /// </summary>
        public const string TopupReversed = "topup.reversed";

        /// <summary>
        /// Occurs whenever a top-up succeeds.
        /// </summary>
        public const string TopupSucceeded = "topup.succeeded";

        /// <summary>
        /// Occurs whenever a transfer is created.
        /// </summary>
        public const string TransferCreated = "transfer.created";

        /// <summary>
        /// Occurs whenever a transfer is reversed, including partial reversals.
        /// </summary>
        public const string TransferReversed = "transfer.reversed";

        /// <summary>
        /// Occurs whenever a transfer's description or metadata is updated.
        /// </summary>
        public const string TransferUpdated = "transfer.updated";

        /// <summary>
        /// Occurs whenever an CreditReversal is submitted and created.
        /// </summary>
        public const string TreasuryCreditReversalCreated = "treasury.credit_reversal.created";

        /// <summary>
        /// Occurs whenever an CreditReversal post is posted.
        /// </summary>
        public const string TreasuryCreditReversalPosted = "treasury.credit_reversal.posted";

        /// <summary>
        /// Occurs whenever a DebitReversal is completed.
        /// </summary>
        public const string TreasuryDebitReversalCompleted = "treasury.debit_reversal.completed";

        /// <summary>
        /// Occurs whenever a DebitReversal is created.
        /// </summary>
        public const string TreasuryDebitReversalCreated = "treasury.debit_reversal.created";

        /// <summary>
        /// Occurs whenever an initial credit is granted on a DebitReversal.
        /// </summary>
        public const string TreasuryDebitReversalInitialCreditGranted = "treasury.debit_reversal.initial_credit_granted";

        /// <summary>
        /// Occurs whenever the status of the FinancialAccount becomes closed.
        /// </summary>
        public const string TreasuryFinancialAccountClosed = "treasury.financial_account.closed";

        /// <summary>
        /// Occurs whenever a new FinancialAccount is created.
        /// </summary>
        public const string TreasuryFinancialAccountCreated = "treasury.financial_account.created";

        /// <summary>
        /// Occurs whenever the statuses of any features within an existing FinancialAccount are
        /// updated.
        /// </summary>
        public const string TreasuryFinancialAccountFeaturesStatusUpdated = "treasury.financial_account.features_status_updated";

        /// <summary>
        /// Occurs whenever an InboundTransfer is canceled.
        /// </summary>
        public const string TreasuryInboundTransferCanceled = "treasury.inbound_transfer.canceled";

        /// <summary>
        /// Occurs whenever an InboundTransfer is created.
        /// </summary>
        public const string TreasuryInboundTransferCreated = "treasury.inbound_transfer.created";

        /// <summary>
        /// Occurs whenever an InboundTransfer has failed.
        /// </summary>
        public const string TreasuryInboundTransferFailed = "treasury.inbound_transfer.failed";

        /// <summary>
        /// Occurs whenever an InboundTransfer has succeeded.
        /// </summary>
        public const string TreasuryInboundTransferSucceeded = "treasury.inbound_transfer.succeeded";

        /// <summary>
        /// Occurs whenever an OutboundPayment is canceled.
        /// </summary>
        public const string TreasuryOutboundPaymentCanceled = "treasury.outbound_payment.canceled";

        /// <summary>
        /// Occurs whenever a new OutboundPayment is successfully created.
        /// </summary>
        public const string TreasuryOutboundPaymentCreated = "treasury.outbound_payment.created";

        /// <summary>
        /// Occurs whenever the arrival date on an OutboundPayment updates.
        /// </summary>
        public const string TreasuryOutboundPaymentExpectedArrivalDateUpdated = "treasury.outbound_payment.expected_arrival_date_updated";

        /// <summary>
        /// Occurs whenever an OutboundPayment fails.
        /// </summary>
        public const string TreasuryOutboundPaymentFailed = "treasury.outbound_payment.failed";

        /// <summary>
        /// Occurs whenever an OutboundPayment posts.
        /// </summary>
        public const string TreasuryOutboundPaymentPosted = "treasury.outbound_payment.posted";

        /// <summary>
        /// Occurs whenever an OutboundPayment was returned.
        /// </summary>
        public const string TreasuryOutboundPaymentReturned = "treasury.outbound_payment.returned";

        /// <summary>
        /// Occurs whenever an OutboundTransfer is canceled.
        /// </summary>
        public const string TreasuryOutboundTransferCanceled = "treasury.outbound_transfer.canceled";

        /// <summary>
        /// Occurs whenever an OutboundTransfer is created.
        /// </summary>
        public const string TreasuryOutboundTransferCreated = "treasury.outbound_transfer.created";

        /// <summary>
        /// Occurs whenever the arrival date on an OutboundTransfer updates.
        /// </summary>
        public const string TreasuryOutboundTransferExpectedArrivalDateUpdated = "treasury.outbound_transfer.expected_arrival_date_updated";

        /// <summary>
        /// Occurs whenever an OutboundTransfer has failed.
        /// </summary>
        public const string TreasuryOutboundTransferFailed = "treasury.outbound_transfer.failed";

        /// <summary>
        /// Occurs whenever an OutboundTransfer is posted.
        /// </summary>
        public const string TreasuryOutboundTransferPosted = "treasury.outbound_transfer.posted";

        /// <summary>
        /// Occurs whenever an OutboundTransfer is returned.
        /// </summary>
        public const string TreasuryOutboundTransferReturned = "treasury.outbound_transfer.returned";

        /// <summary>
        /// Occurs whenever a received_credit is created as a result of funds being pushed by
        /// another account.
        /// </summary>
        public const string TreasuryReceivedCreditCreated = "treasury.received_credit.created";

        /// <summary>
        /// Occurs whenever a received_credit transitions to failed state. Only applicable for check
        /// deposits.
        /// </summary>
        public const string TreasuryReceivedCreditFailed = "treasury.received_credit.failed";

        /// <summary>
        /// Occurs whenever a received_credit transitions to succeeded state. Only applicable for
        /// check deposits.
        /// </summary>
        public const string TreasuryReceivedCreditSucceeded = "treasury.received_credit.succeeded";

        /// <summary>
        /// Occurs whenever a received_debit is created as a result of funds being pulled by another
        /// account.
        /// </summary>
        public const string TreasuryReceivedDebitCreated = "treasury.received_debit.created";
    }
}