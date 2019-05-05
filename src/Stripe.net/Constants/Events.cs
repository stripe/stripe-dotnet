namespace Stripe
{
    using System;

    public static class Events
    {
        /// <summary>
        /// Occurs whenever an account status or property has changed.
        /// </summary>
        public static string AccountUpdated => "account.updated";

        /// <summary>
        /// Occurs whenever a user authorizes an application. Sent to the related application only.
        /// </summary>
        public static string AccountApplicationAuthorized => "account.application.authorized";

        /// <summary>
        /// Occurs whenever a user deauthorizes an application. Sent to the related application only.
        /// </summary>
        public static string AccountApplicationDeauthorized => "account.application.deauthorized";

        /// <summary>
        /// Occurs whenever an external account is created.
        /// </summary>
        public static string AccountExternalAccountCreated => "account.external_account.created";

        /// <summary>
        /// Occurs whenever an external account is deleted.
        /// </summary>
        public static string AccountExternalAccountDeleted => "account.external_account.deleted";

        /// <summary>
        /// Occurs whenever an external account is updated.
        /// </summary>
        public static string AccountExternalAccountUpdated => "account.external_account.updated";

        /// <summary>
        /// Occurs whenever an application fee is created on a charge.
        /// </summary>
        public static string ApplicationFeeCreated => "application_fee.created";

        /// <summary>
        /// Occurs whenever an application fee is refunded, whether from refunding a charge or from refunding the application fee directly, including partial refunds.
        /// </summary>
        public static string ApplicationFeeRefunded => "application_fee.refunded";

        /// <summary>
        /// Occurs whenever an application fee refund is updated.
        /// </summary>
        public static string ApplicationFeeRefundUpdated => "application_fee.refund.updated";

        /// <summary>
        /// Occurs whenever your Stripe balance has been updated (e.g. when a charge collected is available to be paid out). By default, Stripe will automatically transfer any funds in your balance to your bank account on a daily basis.
        /// </summary>
        public static string BalanceAvailable => "balance.available";

        /// <summary>
        /// Occurs whenever a receiver has been created.
        /// </summary>
        [Obsolete]
        public static string BitcoinReceiverCreated => "bitcoin.receiver.created";

        /// <summary>
        /// Occurs whenever a receiver is filled (that is, when it has received enough bitcoin to process a payment of the same amount).
        /// </summary>
        [Obsolete]
        public static string BitcoinReceiverFilled => "bitcoin.receiver.filled";

        /// <summary>
        /// Occurs whenever a receiver is updated.
        /// </summary>
        [Obsolete]
        public static string BitcoinReceiverUpdated => "bitcoin.receiver.updated";

        /// <summary>
        /// Occurs whenever bitcoin is pushed to a receiver.
        /// </summary>
        [Obsolete]
        public static string BitcoinReceiverTransactionUpdated => "bitcoin.receiver.transaction.created";

        /// <summary>
        /// Occurs whenever a previously uncaptured charge is captured.
        /// </summary>
        public static string ChargeCaptured => "charge.captured";

        /// <summary>
        /// Occurs whenever a previously uncaptured charge expires.
        /// </summary>
        public static string ChargeExpired => "charge.expired";

        /// <summary>
        /// Occurs whenever a failed charge attempt occurs.
        /// </summary>
        public static string ChargeFailed => "charge.failed";

        /// <summary>
        /// Occurs whenever a pending charge is created.
        /// </summary>
        public static string ChargePending => "charge.pending";

        /// <summary>
        /// Occurs whenever a charge is refunded, including partial refunds.
        /// </summary>
        public static string ChargeRefunded => "charge.refunded";

        /// <summary>
        /// Occurs whenever a new charge is created and is successful.
        /// </summary>
        public static string ChargeSucceeded => "charge.succeeded";

        /// <summary>
        /// Occurs whenever a charge description or metadata is updated.
        /// </summary>
        public static string ChargeUpdated => "charge.updated";

        /// <summary>
        /// Occurs when the dispute is closed and the dispute status changes to
        /// <c>charge_refunded</c>, <c>lost</c>, <c>warning_closed</c>, or <c>won</c>.
        /// </summary>
        public static string ChargeDisputeClosed => "charge.dispute.closed";

        /// <summary>
        /// Occurs whenever a customer disputes a charge with their bank.
        /// </summary>
        public static string ChargeDisputeCreated => "charge.dispute.created";

        /// <summary>
        /// Occurs when funds are reinstated to your account after a dispute is closed. This
        /// includes <a href="https://stripe.com/docs/disputes#disputes-on-partially-refunded-payments">partially
        /// refunded payments</a>.
        /// </summary>
        public static string ChargeDisputeFundsReinstated => "charge.dispute.funds_reinstated";

        /// <summary>
        /// Occurs when funds are removed from your account due to a dispute.
        /// </summary>
        public static string ChargeDisputeFundsWithdrawn => "charge.dispute.funds_withdrawn";

        /// <summary>
        /// Occurs when the dispute is updated (usually with evidence).
        /// </summary>
        public static string ChargeDisputeUpdated => "charge.dispute.updated";

        /// <summary>
        /// Occurs whenever a refund is updated on selected payment methods.
        /// </summary>
        public static string ChargeRefundUpdated => "charge.refund.updated";

        /// <summary>
        /// Occurs when a Checkout Session has been successfully completed.
        /// </summary>
        public static string CheckoutSessionCompleted => "checkout.session.completed";

        /// <summary>
        /// Occurs whenever a coupon is created.
        /// </summary>
        public static string CouponCreated => "coupon.created";

        /// <summary>
        /// Occurs whenever a coupon is deleted.
        /// </summary>
        public static string CouponDeleted => "coupon.deleted";

        /// <summary>
        /// Occurs whenever a coupon is updated.
        /// </summary>
        public static string CouponUpdated => "coupon.updated";

        /// <summary>
        /// Occurs whenever a credit note is created.
        /// </summary>
        public static string CreditNoteCreated => "credit_note.created";

        /// <summary>
        /// Occurs whenever a credit note is updated.
        /// </summary>
        public static string CreditNoteUpdated => "credit_note.updated";

        /// <summary>
        /// Occurs whenever a credit note is voided.
        /// </summary>
        public static string CreditNoteVoided => "credit_note.voided";

        /// <summary>
        /// Occurs whenever a new customer is created.
        /// </summary>
        public static string CustomerCreated => "customer.created";

        /// <summary>
        /// Occurs whenever a customer is deleted.
        /// </summary>
        public static string CustomerDeleted => "customer.deleted";

        /// <summary>
        /// Occurs whenever any property of a customer changes.
        /// </summary>
        public static string CustomerUpdated => "customer.updated";

        /// <summary>
        /// Occurs whenever a coupon is attached to a customer.
        /// </summary>
        public static string CustomerDiscountCreated => "customer.discount.created";

        /// <summary>
        /// Occurs whenever a customer's discount is removed.
        /// </summary>
        public static string CustomerDiscountDeleted => "customer.discount.deleted";

        /// <summary>
        /// Occurs whenever a customer is switched from one coupon to another.
        /// </summary>
        public static string CustomerDiscountUpdated => "customer.discount.updated";

        /// <summary>
        /// Occurs whenever a new source is created for the customer.
        /// </summary>
        public static string CustomerSourceCreated => "customer.source.created";

        /// <summary>
        /// Occurs whenever a source is removed from a customer.
        /// </summary>
        public static string CustomerSourceDeleted => "customer.source.deleted";

        /// <summary>
        /// Occurs whenever a source will expire at the end of the month.
        /// </summary>
        public static string CustomerSourceExpiring => "customer.source.expiring";

        /// <summary>
        /// Occurs whenever a source's details are changed.
        /// </summary>
        public static string CustomerSourceUpdated => "customer.source.updated";

        /// <summary>
        /// Occurs whenever a customer with no subscription is signed up for a plan.
        /// </summary>
        public static string CustomerSubscriptionCreated => "customer.subscription.created";

        /// <summary>
        /// Occurs whenever a customer ends their subscription.
        /// </summary>
        public static string CustomerSubscriptionDeleted => "customer.subscription.deleted";

        /// <summary>
        /// Occurs three days before the trial period of a subscription is scheduled to end.
        /// </summary>
        public static string CustomerSubscriptionTrialWillEnd => "customer.subscription.trial_will_end";

        /// <summary>
        /// Occurs three days before the trial period of a subscription is scheduled to end.
        /// </summary>
        public static string CustomerSubscriptionUpdated => "customer.subscription.updated";

        /// <summary>
        /// Occurs whenever a new Stripe-generated file is available for your account.
        /// </summary>
        public static string FileCreated => "file.created";

        /// <summary>
        /// Occurs whenever a new invoice is created. To learn how webhooks can be used with this
        /// event, and how they can affect it, see
        /// <a href="https://stripe.com/docs/subscriptions/webhooks">Using Webhooks with
        /// Subscriptions</a>.
        /// </summary>
        public static string InvoiceCreated => "invoice.created";

        /// <summary>
        /// Occurs whenever a draft invoice is deleted.
        /// </summary>
        public static string InvoiceDeleted => "invoice.deleted";

        /// <summary>
        /// Occurs whenever a draft invoice is finalized and updated to be an open invoice.
        /// </summary>
        public static string InvoiceFinalized => "invoice.finalized";

        /// <summary>
        /// Occurs whenever an invoice is marked uncollectible.
        /// </summary>
        public static string InvoiceMarkedUncollectible => "invoice.marked_uncollectible";

        /// <summary>
        /// Occurs whenever an invoice payment attempt requires further user action to complete.
        /// </summary>
        public static string InvoicePaymentActionRequired => "invoice.payment_action_required";

        /// <summary>
        /// Occurs whenever an invoice payment attempt fails, due either to a declined payment or
        /// to the lack of a stored payment method.
        /// </summary>
        public static string InvoicePaymentFailed => "invoice.payment_failed";

        /// <summary>
        /// Occurs whenever an invoice payment attempt succeeds.
        /// </summary>
        public static string InvoicePaymentSucceeded => "invoice.payment_succeeded";

        /// <summary>
        /// Occurs whenever an invoice email is sent out.
        /// </summary>
        public static string InvoiceSent => "invoice.sent";

        /// <summary>
        /// Occurs X number of days before a subscription is scheduled to create an invoice that is
        /// automatically charged—where X is determined by your
        /// <a href="https://dashboard.stripe.com/account/billing/automatic">subscriptions
        /// settings</a>. Note: The received <see cref="Invoice"/> object will not have an invoice
        /// ID.
        /// </summary>
        public static string InvoiceUpcoming => "invoice.upcoming";

        /// <summary>
        /// Occurs whenever an invoice changes (e.g., the invoice amount).
        /// </summary>
        public static string InvoiceUpdated => "invoice.updated";

        /// <summary>
        /// Occurs whenever an invoice is voided.
        /// </summary>
        public static string InvoiceVoided => "invoice.voided";

        /// <summary>
        /// Occurs whenever an invoice item is created.
        /// </summary>
        public static string InvoiceItemCreated => "invoiceitem.created";

        /// <summary>
        /// Occurs whenever an invoice item is deleted.
        /// </summary>
        public static string InvoiceItemDeleted => "invoiceitem.deleted";

        /// <summary>
        /// Occurs whenever an invoice item is updated.
        /// </summary>
        public static string InvoiceItemUpdated => "invoiceitem.updated";

        /// <summary>
        /// Occurs whenever an issuing authorization is created.
        /// </summary>
        public static string IssuingAuthorizationCreated => "issuing_authorization.created";

        /// <summary>
        /// Occurs whenever an issuing authorization request is sent.
        /// </summary>
        public static string IssuingAuthorizationRequest => "issuing_authorization.request";

        /// <summary>
        /// Occurs whenever an issuing authorization is updated.
        /// </summary>
        public static string IssuingAuthorizationUpdated => "issuing_authorization.updated";

        /// <summary>
        /// Occurs whenever an issuing card is created.
        /// </summary>
        public static string IssuingCardCreated => "issuing_card.created";

        /// <summary>
        /// Occurs whenever an issuing card is updated.
        /// </summary>
        public static string IssuingCardUpdated => "issuing_card.updated";

        /// <summary>
        /// Occurs whenever an issuing cardholder is created.
        /// </summary>
        public static string IssuingCardholderCreated => "issuing_cardholder.created";

        /// <summary>
        /// Occurs whenever an issuing cardholder is updated.
        /// </summary>
        public static string IssuingCardholderUpdated => "issuing_cardholder.updated";

        /// <summary>
        /// Occurs whenever an issuing dispute is created.
        /// </summary>
        public static string IssuingDisputeCreated => "issuing_dispute.created";

        /// <summary>
        /// Occurs whenever an issuing dispute is updated.
        /// </summary>
        public static string IssuingDisputeUpdated => "issuing_dispute.updated";

        /// <summary>
        /// Occurs whenever an issuing transaction is created.
        /// </summary>
        public static string IssuingTransactionCreated => "issuing_transaction.created";

        /// <summary>
        /// Occurs whenever an issuing transaction is updated.
        /// </summary>
        public static string IssuingTransactionUpdated => "issuing_transaction.updated";

        /// <summary>
        /// Occurs whenever an order is created.
        /// </summary>
        public static string OrderCreated => "order.created";

        /// <summary>
        /// Occurs whenever payment is attempted on an order, and the payment fails.
        /// </summary>
        public static string OrderPaymentFailed => "order.payment_failed";

        /// <summary>
        /// Occurs whenever payment is attempted on an order, and the payment succeeds.
        /// </summary>
        public static string OrderPaymentSucceeded => "order.payment_succeeded";

        /// <summary>
        /// Occurs whenever an order is updated.
        /// </summary>
        public static string OrderUpdated => "order.updated";

        /// <summary>
        /// Occurs whenever an order return is created.
        /// </summary>
        public static string OrderReturnCreated => "order_return.created";

        /// <summary>
        /// Occurs when a <see cref="PaymentIntent"/> has funds to be captured. Check the
        /// <see cref="PaymentIntent.AmountCapturable"/> property on the PaymentIntent to determine
        /// the amount that can be captured. You may capture the PaymentIntent with an
        /// <see cref="PaymentIntentCaptureOptions.AmountToCapture"/> value up to the specified
        /// amount. <a href="https://stripe.com/docs/api/payment_intents/capture">Learn more about
        /// capturing PaymentIntents.</a>
        /// </summary>
        public static string PaymentIntentAmountCapturableUpdated => "payment_intent.amount_capturable_updated";

        /// <summary>
        /// Occurs when a new PaymentIntent is created.
        /// </summary>
        public static string PaymentIntentCreated => "payment_intent.created";

        /// <summary>
        /// Occurs when a PaymentIntent has failed the attempt to create a source or a payment.
        /// </summary>
        public static string PaymentIntentPaymentFailed => "payment_intent.payment_failed";

        /// <summary>
        /// Occurs when a PaymentIntent has been successfully fulfilled.
        /// </summary>
        public static string PaymentIntentSucceeded => "payment_intent.succeeded";

        /// <summary>
        /// Occurs whenever a new payment method is attached to a customer.
        /// </summary>
        public static string PaymentMethodAttached => "payment_method.attached";

        /// <summary>
        /// Occurs whenever a card payment method's details are automatically updated by CAU.
        /// </summary>
        public static string PaymentMethodCardAutomaticallyUpdated => "payment_method.card_automatically_updated";

        /// <summary>
        /// Occurs whenever a payment method is detached from a customer.
        /// </summary>
        public static string PaymentMethodDetached => "payment_method.detached";

        /// <summary>
        /// Occurs whenever a payment method is updated via the API.
        /// </summary>
        public static string PaymentMethodUpdated => "payment_method.updated";

        /// <summary>
        /// Occurs whenever a payout is canceled.
        /// </summary>
        public static string PayoutCanceled => "payout.canceled";

        /// <summary>
        /// Occurs whenever a new payout is created.
        /// </summary>
        public static string PayoutCreated => "payout.created";

        /// <summary>
        /// Occurs whenever Stripe attempts to send a payout and that transfer fails.
        /// </summary>
        public static string PayoutFailed => "payout.failed";

        /// <summary>
        /// Occurs whenever a payout is *expected* to be available in the destination account.
        /// If the payout fails, a <see cref="PayoutFailed"/> notification is also sent, at a later
        /// time.
        /// </summary>
        public static string PayoutPaid => "payout.paid";

        /// <summary>
        /// Occurs whenever a payout's metadata is updated.
        /// </summary>
        public static string PayoutUpdated => "payout.updated";

        /// <summary>
        /// Occurs whenever a person is created.
        /// </summary>
        public static string PersonCreated => "person.created";

        /// <summary>
        /// Occurs whenever a person is deleted.
        /// </summary>
        public static string PersonDeleted => "person.deleted";

        /// <summary>
        /// Occurs whenever a person is updated.
        /// </summary>
        public static string PersonUpdated => "person.updated";

        /// <summary>
        /// Occurs whenever a plan is created.
        /// </summary>
        public static string PlanCreated => "plan.created";

        /// <summary>
        /// Occurs whenever a plan is deleted.
        /// </summary>
        public static string PlanDeleted => "plan.deleted";

        /// <summary>
        /// Occurs whenever a plan is updated.
        /// </summary>
        public static string PlanUpdated => "plan.updated";

        /// <summary>
        /// Occurs whenever a product is created.
        /// </summary>
        public static string ProductCreated => "product.created";

        /// <summary>
        /// Occurs whenever a product is deleted.
        /// </summary>
        public static string ProductDeleted => "product.deleted";

        /// <summary>
        /// Occurs whenever a product is updated.
        /// </summary>
        public static string ProductUpdated => "product.updated";

        /// <summary>
        /// Occurs whenever a recipient is created.
        /// </summary>
        public static string RecipientCreated => "recipient.created";

        /// <summary>
        /// Occurs whenever a recipient is deleted.
        /// </summary>
        public static string RecipientDeleted => "recipient.deleted";

        /// <summary>
        /// Occurs whenever a recipient is updated.
        /// </summary>
        public static string RecipientUpdated => "recipient.updated";

        /// <summary>
        /// Occurs whenever a requested <see cref="Reporting.ReportRun"/> failed to complete.
        /// </summary>
        public static string ReportingReportRunFailed => "reporting.report_run.failed";

        /// <summary>
        /// Occurs whenever a requested <see cref="Reporting.ReportRun"/> completed succesfully.
        /// </summary>
        public static string ReportingReportRunSucceeded => "reporting.report_run.succeeded";

        /// <summary>
        /// Occurs whenever a requested <see cref="Reporting.ReportType"/> is updated (typically to
        /// indicate that a new day's data has come available).
        /// </summary>
        public static string ReportingReportTypeUpdated => "reporting.report_type.updated";

        /// <summary>
        /// Occurs whenever a review is closed. The review's reason field indicates why:
        /// <c>approved</c>, <c>disputed</c>, <c>refunded</c>, or <c>refunded_as_fraud</c>.
        /// </summary>
        public static string ReviewClosed => "review.closed";

        /// <summary>
        /// Occurs whenever a review is opened.
        /// </summary>
        public static string ReviewOpened => "review.opened";

        /// <summary>
        /// Occurs whenever a Sigma scheduled query run finishes.
        /// </summary>
        public static string SigmaScheduleQueryRunCreated => "sigma.scheduled_query_run.created";

        /// <summary>
        /// Occurs whenever a SKU is created.
        /// </summary>
        public static string SkuCreated => "sku.created";

        /// <summary>
        /// Occurs whenever a SKU is deleted.
        /// </summary>
        public static string SkuDeleted => "sku.deleted";

        /// <summary>
        /// Occurs whenever a SKU is updated.
        /// </summary>
        public static string SkuUpdated => "sku.updated";

        /// <summary>
        /// Occurs whenever a source is canceled.
        /// </summary>
        public static string SourceCanceled => "source.canceled";

        /// <summary>
        /// Occurs whenever a source transitions to chargeable.
        /// </summary>
        public static string SourceChargeable => "source.chargeable";

        /// <summary>
        /// Occurs whenever a source is failed.
        /// </summary>
        public static string SourceFailed => "source.failed";

        /// <summary>
        /// Occurs whenever a source mandate notification method is set to manual.
        /// </summary>
        public static string SourceMandateNotification => "source.mandate_notification";

        /// <summary>
        /// Occurs whenever the refund attributes are required on a receiver source to process a
        /// refund or a mispayment.
        /// </summary>
        public static string SourceRefundAttributesRequired => "source.refund_attributes_required";

        /// <summary>
        /// Occurs whenever a source transaction is created.
        /// </summary>
        public static string SourceTransactionCreated => "source.transaction.created";

        /// <summary>
        /// Occurs whenever a source transaction is updated.
        /// </summary>
        public static string SourceTransactionUpdated => "source.transaction.updated";

        /// <summary>
        /// Occurs whenever a subscription schedule is canceled due to the underlying subscription
        /// being canceled because of delinquency.
        /// </summary>
        public static string SubscriptionScheduleAborted => "subscription_schedule.aborted";

        /// <summary>
        /// Occurs whenever a subscription schedule is canceled.
        /// </summary>
        public static string SubscriptionScheduleCanceled => "subscription_schedule.canceled";

        /// <summary>
        /// Occurs whenever a new subscription schedule is completed.
        /// </summary>
        public static string SubscriptionScheduleCompleted => "subscription_schedule.completed";

        /// <summary>
        /// Occurs whenever a new subscription schedule is created.
        /// </summary>
        public static string SubscriptionScheduleCreated => "subscription_schedule.created";

        /// <summary>
        /// Occurs 7 days before a subscription schedule will expire.
        /// </summary>
        public static string SubscriptionScheduleExpiring => "subscription_schedule.expiring";

        /// <summary>
        /// Occurs whenever a new subscription schedule is released.
        /// </summary>
        public static string SubscriptionScheduleReleased => "subscription_schedule.released";

        /// <summary>
        /// Occurs whenever a subscription schedule is updated.
        /// </summary>
        public static string SubscriptionScheduleUpdated => "subscription_schedule.updated";

        /// <summary>
        /// Occurs whenever a tax rate is created.
        /// </summary>
        public static string TaxRateCreated => "tax_rate.created";

        /// <summary>
        /// Occurs whenever a tax rate changes.
        /// </summary>
        public static string TaxRateUpdated => "tax_rate.updated";

        /// <summary>
        /// Occurs whenever a top-up is canceled.
        /// </summary>
        public static string TopupCanceled => "topup.canceled";

        /// <summary>
        /// Occurs whenever a top-up is created.
        /// </summary>
        public static string TopupCreated => "topup.created";

        /// <summary>
        /// Occurs whenever a top-up fails.
        /// </summary>
        public static string TopupFailed => "topup.failed";

        /// <summary>
        /// Occurs whenever a top-up is reversed.
        /// </summary>
        public static string TopupReversed => "topup.reversed";

        /// <summary>
        /// Occurs whenever a top-up succeeds.
        /// </summary>
        public static string TopupSucceeded => "topup.succeeded";

        /// <summary>
        /// Occurs whenever a new transfer is created.
        /// </summary>
        public static string TransferCreated => "transfer.created";

        /// <summary>
        /// Occurs whenever a transfer is reversed, including partial reversals.
        /// </summary>
        public static string TransferReversed => "transfer.reversed";

        /// <summary>
        /// Occurs whenever the description or metadata of a transfer is updated.
        /// </summary>
        public static string TransferUpdated => "transfer.updated";

        /// <summary>
        /// May be sent by Stripe at any time to see if a provided webhook URL is working.
        /// </summary>
        public static string Ping => "ping";
    }
}
