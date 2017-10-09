using System;

namespace Stripe
{
    public static class StripeEvents
    {
        /// <summary>
        /// Occurs whenever an account status or property has changed.
        /// </summary>
        public const string AccountUpdated = "account.updated";

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
        /// Occurs whenever a receiver has been created.
        /// </summary>
        public const string BitcoinReceiverCreated = "bitcoin.receiver.created";

        /// <summary>
        /// Occurs whenever a receiver is filled (that is, when it has received enough bitcoin to process a payment of the same amount).
        /// </summary>
        public const string BitcoinReceiverFilled = "bitcoin.receiver.filled";

        /// <summary>
        /// Occurs whenever a receiver is updated.
        /// </summary>
        public const string BitcoinReceiverUpdated = "bitcoin.receiver.updated";

        /// <summary>
        /// Occurs whenever bitcoin is pushed to a receiver.
        /// </summary>
        public const string BitcoinReceiverTransactionUpdated = "bitcoin.receiver.transaction.created";

        /// <summary>
        /// Occurs whenever a previously uncaptured charge is captured.
        /// </summary>
        public const string ChargeCaptured = "charge.captured";

        /// <summary>
        /// Occurs whenever a failed charge attempt occurs.
        /// </summary>
        public const string ChargeFailed = "charge.failed";

        /// <summary>
        /// Occurs whenever a pending charge is created.
        /// </summary>
        public const string ChargePending = "charge.pending";

        /// <summary>
        /// Occurs whenever a refund is updated on selected payment methods.
        /// </summary>
        public const string ChargeRefundUpdated = "charge.refund.updated";

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
        /// Occurs when the dispute is closed and the dispute status changes to charge_refunded, lost, warning_closed, or won.
        /// </summary>
        public const string ChargeDisputeClosed = "charge.dispute.closed";

        /// <summary>
        /// Occurs whenever a customer disputes a charge with their bank (chargeback).
        /// </summary>
        public const string ChargeDisputeCreated = "charge.dispute.created";

        /// <summary>
        /// Occurs when funds are reinstated to your account after a dispute is won.
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
        public const string CustomerSourcedDeleted = "customer.source.deleted";

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
        /// Occurs three days before the trial period of a subscription is scheduled to end.
        /// </summary>
        public const string CustomerSubscriptionTrialWillEnd = "customer.subscription.trial_will_end";

        /// <summary>
        /// Occurs three days before the trial period of a subscription is scheduled to end.
        /// </summary>
        public const string CustomerSubscriptionUpdated = "customer.subscription.updated";

        /// <summary>
        /// Occurs whenever a new invoice is created. If you are using webhooks, Stripe will wait one hour after they have all succeeded to attempt to pay the invoice; the only exception here is on the first invoice, which gets created and paid immediately when you subscribe a customer to a plan. If your webhooks do not all respond successfully, Stripe will continue retrying the webhooks every hour and will not attempt to pay the invoice. After 3 days, Stripe will attempt to pay the invoice regardless of whether or not your webhooks have succeeded. 
        /// </summary>
        public const string InvoiceCreated = "invoice.created";

        /// <summary>
        /// Occurs whenever an invoice attempts to be paid, and the payment fails. This can occur either due to a declined payment, or because the customer has no active card. A particular case of note is that if a customer with no active card reaches the end of its free trial, an invoice.payment_failed notification will occur.
        /// </summary>
        public const string InvoicePaymentFailed = "invoice.payment_failed";

        /// <summary>
        /// Occurs whenever an invoice attempts to be paid, and the payment succeeds.
        /// </summary>
        public const string InvoicePaymentSucceeded = "invoice.payment_succeeded";

        /// <summary>
        /// Occurs whenever an invoice email is sent out.
        /// </summary>
        public const string InvoiceSent = "invoice.sent";

        /// <summary>
        /// Occurs X number of days before a subscription is scheduled to create an invoice that is charged automatically, where X is determined by your subscriptions settings.
        /// </summary>
        public const string InvoiceUpcoming = "invoice.upcoming";

        /// <summary>
        /// Occurs whenever an invoice changes (for example, the amount could change).
        /// </summary>
        public const string InvoiceUpdated = "invoice.updated";

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
        /// Occurs whenever a payout is expected to be available in the destination bank account. If the payout failed, a payout.failed webhook will additionally be sent at a later time.
        /// </summary>
        public const string PayoutPaid = "payout.paid";

        /// <summary>
        /// Occurs whenever the metadata of a payout is updated.
        /// </summary>
        public const string PayoutUpdated = "payout.updated";

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
        /// Occurs whenever a review is closed. The review's reason field will indicate why the review was closed (e.g. approved, refunded, refunded_as_fraud, disputed.
        /// </summary>
        public const string ReviewClosed = "review.closed";

        /// <summary>
        /// Occurs whenever a review is opened.
        /// </summary>
        public const string ReviewOpened = "review.opened";

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
        /// Occurs whenever a source transaction is created.
        /// </summary>
        public const string SourceTransactionCanceled = "source.transaction.created";

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
