namespace Stripe
{
    using System;

    public static class Events
    {
        /// <summary>
        /// Occurs whenever an account status or property has changed.
        /// </summary>
        public const string AccountUpdated = "account.updated";

        /// <summary>
        /// Occurs whenever a user authorizes an application. Sent to the related application only.
        /// </summary>
        public const string AccountApplicationAuthorized = "account.application.authorized";

        /// <summary>
        /// Occurs whenever a user deauthorizes an application. Sent to the related application only.
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
        /// Occurs whenever an application fee is created on a charge.
        /// </summary>
        public const string ApplicationFeeCreated = "application_fee.created";

        /// <summary>
        /// Occurs whenever an application fee is refunded, whether from refunding a charge or from refunding the application fee directly, including partial refunds.
        /// </summary>
        public const string ApplicationFeeRefunded = "application_fee.refunded";

        /// <summary>
        /// Occurs whenever an application fee refund is updated.
        /// </summary>
        public const string ApplicationFeeRefundUpdated = "application_fee.refund.updated";

        /// <summary>
        /// Occurs whenever your Stripe balance has been updated (e.g. when a charge collected is available to be paid out). By default, Stripe will automatically transfer any funds in your balance to your bank account on a daily basis.
        /// </summary>
        public const string BalanceAvailable = "balance.available";

        /// <summary>
        /// Occurs whenever a capability has new requirements or a new status.
        /// </summary>
        public const string CapabilityUpdated = "capability.updated";

        /// <summary>
        /// Occurs whenever a previously uncaptured charge is captured.
        /// </summary>
        public const string ChargeCaptured = "charge.captured";

        /// <summary>
        /// Occurs whenever a previously uncaptured charge expires.
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
        /// Occurs whenever a charge is refunded, including partial refunds.
        /// </summary>
        public const string ChargeRefunded = "charge.refunded";

        /// <summary>
        /// Occurs whenever a new charge is created and is successful.
        /// </summary>
        public const string ChargeSucceeded = "charge.succeeded";

        /// <summary>
        /// Occurs whenever a charge description or metadata is updated.
        /// </summary>
        public const string ChargeUpdated = "charge.updated";

        /// <summary>
        /// Occurs when the dispute is closed and the dispute status changes to
        /// <c>charge_refunded</c>, <c>lost</c>, <c>warning_closed</c>, or <c>won</c>.
        /// </summary>
        public const string ChargeDisputeClosed = "charge.dispute.closed";

        /// <summary>
        /// Occurs whenever a customer disputes a charge with their bank.
        /// </summary>
        public const string ChargeDisputeCreated = "charge.dispute.created";

        /// <summary>
        /// Occurs when funds are reinstated to your account after a dispute is closed. This
        /// includes <a href="https://stripe.com/docs/disputes#disputes-on-partially-refunded-payments">partially
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
        /// Occurs whenever a refund is updated on selected payment methods.
        /// </summary>
        public const string ChargeRefundUpdated = "charge.refund.updated";

        /// <summary>
        /// Occurs when a Checkout Session asynchronous payment has failed.
        /// </summary>
        public const string CheckoutSessionAsyncPaymentFailed = "checkout.session.async_payment_failed";

        /// <summary>
        /// Occurs when a Checkout Session asynchronous payment has succeeded.
        /// </summary>
        public const string CheckoutSessionAsyncPaymentSucceeded = "checkout.session.async_payment_succeeded";

        /// <summary>
        /// Occurs when a Checkout Session has been successfully completed.
        /// </summary>
        public const string CheckoutSessionCompleted = "checkout.session.completed";

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
        /// Occurs whenever a new customer is created.
        /// </summary>
        public const string CustomerCreated = "customer.created";

        /// <summary>
        /// Occurs whenever a customer is deleted.
        /// </summary>
        public const string CustomerDeleted = "customer.deleted";

        /// <summary>
        /// Occurs whenever any property of a customer changes.
        /// </summary>
        public const string CustomerUpdated = "customer.updated";

        /// <summary>
        /// Occurs whenever a coupon is attached to a customer.
        /// </summary>
        public const string CustomerDiscountCreated = "customer.discount.created";

        /// <summary>
        /// Occurs whenever a customer's discount is removed.
        /// </summary>
        public const string CustomerDiscountDeleted = "customer.discount.deleted";

        /// <summary>
        /// Occurs whenever a customer is switched from one coupon to another.
        /// </summary>
        public const string CustomerDiscountUpdated = "customer.discount.updated";

        /// <summary>
        /// Occurs whenever a new source is created for the customer.
        /// </summary>
        public const string CustomerSourceCreated = "customer.source.created";

        /// <summary>
        /// Occurs whenever a source is removed from a customer.
        /// </summary>
        public const string CustomerSourceDeleted = "customer.source.deleted";

        /// <summary>
        /// Occurs whenever a source will expire at the end of the month.
        /// </summary>
        public const string CustomerSourceExpiring = "customer.source.expiring";

        /// <summary>
        /// Occurs whenever a source's details are changed.
        /// </summary>
        public const string CustomerSourceUpdated = "customer.source.updated";

        /// <summary>
        /// Occurs whenever a customer with no subscription is signed up for a plan.
        /// </summary>
        public const string CustomerSubscriptionCreated = "customer.subscription.created";

        /// <summary>
        /// Occurs whenever a customer ends their subscription.
        /// </summary>
        public const string CustomerSubscriptionDeleted = "customer.subscription.deleted";

        /// <summary>
        /// Occurs whenever a customer's subscription's pending update is
        /// applied, and the subscription is updated.
        /// </summary>
        public const string CustomerSubscriptionPendingUpdateApplied = "customer.subscription.pending_update_applied";

        /// <summary>
        /// Occurs whenever a customer's subscription's pending update expires
        /// before the related invoice is paid.
        /// </summary>
        public const string CustomerSubscriptionPendingUpdateExpired = "customer.subscription.pending_update_expired";

        /// <summary>
        /// Occurs three days before the trial period of a subscription is scheduled to end.
        /// </summary>
        public const string CustomerSubscriptionTrialWillEnd = "customer.subscription.trial_will_end";

        /// <summary>
        /// Occurs three days before the trial period of a subscription is scheduled to end.
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
        /// Occurs whenever a new Stripe-generated file is available for your account.
        /// </summary>
        public const string FileCreated = "file.created";

        /// <summary>
        /// Occurs whenever a new invoice is created. To learn how webhooks can be used with this
        /// event, and how they can affect it, see
        /// <a href="https://stripe.com/docs/subscriptions/webhooks">Using Webhooks with
        /// Subscriptions</a>.
        /// </summary>
        public const string InvoiceCreated = "invoice.created";

        /// <summary>
        /// Occurs whenever a draft invoice is deleted.
        /// </summary>
        public const string InvoiceDeleted = "invoice.deleted";

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
        /// Occurs whenever an invoice payment attempt fails, due either to a declined payment or
        /// to the lack of a stored payment method.
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
        /// automatically charged—where X is determined by your
        /// <a href="https://dashboard.stripe.com/account/billing/automatic">subscriptions
        /// settings</a>. Note: The received <see cref="Invoice"/> object will not have an invoice
        /// ID.
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
        /// Occurs whenever an invoice item is updated.
        /// </summary>
        public const string InvoiceItemUpdated = "invoiceitem.updated";

        /// <summary>
        /// Occurs whenever an issuing authorization is created.
        /// </summary>
        public const string IssuingAuthorizationCreated = "issuing_authorization.created";

        /// <summary>
        /// Occurs whenever an issuing authorization request is sent.
        /// </summary>
        public const string IssuingAuthorizationRequest = "issuing_authorization.request";

        /// <summary>
        /// Occurs whenever an issuing authorization is updated.
        /// </summary>
        public const string IssuingAuthorizationUpdated = "issuing_authorization.updated";

        /// <summary>
        /// Occurs whenever an issuing card is created.
        /// </summary>
        public const string IssuingCardCreated = "issuing_card.created";

        /// <summary>
        /// Occurs whenever an issuing card is updated.
        /// </summary>
        public const string IssuingCardUpdated = "issuing_card.updated";

        /// <summary>
        /// Occurs whenever an issuing cardholder is created.
        /// </summary>
        public const string IssuingCardholderCreated = "issuing_cardholder.created";

        /// <summary>
        /// Occurs whenever an issuing cardholder is updated.
        /// </summary>
        public const string IssuingCardholderUpdated = "issuing_cardholder.updated";

        /// <summary>
        /// Occurs whenever an issuing dispute is created.
        /// </summary>
        public const string IssuingDisputeCreated = "issuing_dispute.created";

        /// <summary>
        /// Occurs whenever an issuing dispute's funds are reinstate.
        /// </summary>
        public const string IssuingDisputeFundsReinstated = "issuing_dispute.funds_reinstated";

        /// <summary>
        /// Occurs whenever an issuing dispute is updated.
        /// </summary>
        public const string IssuingDisputeUpdated = "issuing_dispute.updated";

        /// <summary>
        /// Occurs whenever an issuing transaction is created.
        /// </summary>
        public const string IssuingTransactionCreated = "issuing_transaction.created";

        /// <summary>
        /// Occurs whenever an issuing transaction is updated.
        /// </summary>
        public const string IssuingTransactionUpdated = "issuing_transaction.updated";

        /// <summary>
        /// Occurs whenever a mandate is updated.
        /// </summary>
        public const string MandateUpdated = "mandate.updated";

        /// <summary>
        /// Occurs whenever an order is created.
        /// </summary>
        public const string OrderCreated = "order.created";

        /// <summary>
        /// Occurs whenever payment is attempted on an order, and the payment fails.
        /// </summary>
        public const string OrderPaymentFailed = "order.payment_failed";

        /// <summary>
        /// Occurs whenever payment is attempted on an order, and the payment succeeds.
        /// </summary>
        public const string OrderPaymentSucceeded = "order.payment_succeeded";

        /// <summary>
        /// Occurs whenever an order is updated.
        /// </summary>
        public const string OrderUpdated = "order.updated";

        /// <summary>
        /// Occurs whenever an order return is created.
        /// </summary>
        public const string OrderReturnCreated = "order_return.created";

        /// <summary>
        /// Occurs whenever a payment is created.
        /// </summary>
        public const string PaymentCreated = "payment.created";

        /// <summary>
        /// Occurs when a <see cref="PaymentIntent"/> has funds to be captured. Check the
        /// <see cref="PaymentIntent.AmountCapturable"/> property on the PaymentIntent to determine
        /// the amount that can be captured. You may capture the PaymentIntent with an
        /// <see cref="PaymentIntentCaptureOptions.AmountToCapture"/> value up to the specified
        /// amount. <a href="https://stripe.com/docs/api/payment_intents/capture">Learn more about
        /// capturing PaymentIntents.</a>
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
        /// Occurs when a PaymentIntent has failed the attempt to create a source or a payment.
        /// </summary>
        public const string PaymentIntentPaymentFailed = "payment_intent.payment_failed";

        /// <summary>
        /// Occurs when a PaymentIntent has started processing.
        /// </summary>
        public const string PaymentIntentProcessing = "payment_intent.processing";

        /// <summary>
        /// Occurs when a PaymentIntent has been successfully fulfilled.
        /// </summary>
        public const string PaymentIntentSucceeded = "payment_intent.succeeded";

        /// <summary>
        /// Occurs whenever a new payment method is attached to a customer.
        /// </summary>
        public const string PaymentMethodAttached = "payment_method.attached";

        /// <summary>
        /// Occurs whenever a card payment method's details are automatically updated by CAU.
        /// </summary>
        public const string PaymentMethodCardAutomaticallyUpdated = "payment_method.card_automatically_updated";

        /// <summary>
        /// Occurs whenever a payment method is detached from a customer.
        /// </summary>
        public const string PaymentMethodDetached = "payment_method.detached";

        /// <summary>
        /// Occurs whenever a payment method is updated via the API.
        /// </summary>
        public const string PaymentMethodUpdated = "payment_method.updated";

        /// <summary>
        /// Occurs whenever a payout is canceled.
        /// </summary>
        public const string PayoutCanceled = "payout.canceled";

        /// <summary>
        /// Occurs whenever a new payout is created.
        /// </summary>
        public const string PayoutCreated = "payout.created";

        /// <summary>
        /// Occurs whenever Stripe attempts to send a payout and that transfer fails.
        /// </summary>
        public const string PayoutFailed = "payout.failed";

        /// <summary>
        /// Occurs whenever a payout is *expected* to be available in the destination account.
        /// If the payout fails, a <see cref="PayoutFailed"/> notification is also sent, at a later
        /// time.
        /// </summary>
        public const string PayoutPaid = "payout.paid";

        /// <summary>
        /// Occurs whenever a payout's metadata is updated.
        /// </summary>
        public const string PayoutUpdated = "payout.updated";

        /// <summary>
        /// Occurs whenever a person is created.
        /// </summary>
        public const string PersonCreated = "person.created";

        /// <summary>
        /// Occurs whenever a person is deleted.
        /// </summary>
        public const string PersonDeleted = "person.deleted";

        /// <summary>
        /// Occurs whenever a person is updated.
        /// </summary>
        public const string PersonUpdated = "person.updated";

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
        /// Occurs whenever an early fraud warning is created.
        /// </summary>
        public const string RadarEarlyFraudWarningCreated = "radar.early_fraud_warning.created";

        /// <summary>
        /// Occurs whenever an early fraud warning is updated.
        /// </summary>
        public const string RadarEarlyFraudWarningUpdated = "radar.early_fraud_warning.updated";

        /// <summary>
        /// Occurs whenever a recipient is created.
        /// </summary>
        public const string RecipientCreated = "recipient.created";

        /// <summary>
        /// Occurs whenever a recipient is deleted.
        /// </summary>
        public const string RecipientDeleted = "recipient.deleted";

        /// <summary>
        /// Occurs whenever a recipient is updated.
        /// </summary>
        public const string RecipientUpdated = "recipient.updated";

        /// <summary>
        /// Occurs whenever a requested <see cref="Reporting.ReportRun"/> failed to complete.
        /// </summary>
        public const string ReportingReportRunFailed = "reporting.report_run.failed";

        /// <summary>
        /// Occurs whenever a requested <see cref="Reporting.ReportRun"/> completed succesfully.
        /// </summary>
        public const string ReportingReportRunSucceeded = "reporting.report_run.succeeded";

        /// <summary>
        /// Occurs whenever a requested <see cref="Reporting.ReportType"/> is updated (typically to
        /// indicate that a new day's data has come available).
        /// </summary>
        public const string ReportingReportTypeUpdated = "reporting.report_type.updated";

        /// <summary>
        /// Occurs whenever a review is closed. The review's reason field indicates why:
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
        /// Occurs when a SetupIntent has failed the attempt to setup a payment method.
        /// </summary>
        public const string SetupIntentSetupFailed = "setup_intent.setup_failed";

        /// <summary>
        /// Occurs when a SetupIntent has successfully setup a payment method.
        /// </summary>
        public const string SetupIntentSucceeded = "setup_intent.succeeded";

        /// <summary>
        /// Occurs whenever a Sigma scheduled query run finishes.
        /// </summary>
        public const string SigmaScheduleQueryRunCreated = "sigma.scheduled_query_run.created";

        /// <summary>
        /// Occurs whenever a SKU is created.
        /// </summary>
        public const string SkuCreated = "sku.created";

        /// <summary>
        /// Occurs whenever a SKU is deleted.
        /// </summary>
        public const string SkuDeleted = "sku.deleted";

        /// <summary>
        /// Occurs whenever a SKU is updated.
        /// </summary>
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
        /// Occurs whenever a source is failed.
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
        /// Occurs whenever a tax rate is created.
        /// </summary>
        public const string TaxRateCreated = "tax_rate.created";

        /// <summary>
        /// Occurs whenever a tax rate changes.
        /// </summary>
        public const string TaxRateUpdated = "tax_rate.updated";

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
        /// Occurs whenever a new transfer is created.
        /// </summary>
        public const string TransferCreated = "transfer.created";

        /// <summary>
        /// Occurs whenever a transfer is reversed, including partial reversals.
        /// </summary>
        public const string TransferReversed = "transfer.reversed";

        /// <summary>
        /// Occurs whenever the description or metadata of a transfer is updated.
        /// </summary>
        public const string TransferUpdated = "transfer.updated";

        /// <summary>
        /// May be sent by Stripe at any time to see if a provided webhook URL is working.
        /// </summary>
        public const string Ping = "ping";
    }
}
