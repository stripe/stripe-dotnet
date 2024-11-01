// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// A Payment Record is a resource that allows you to represent payments that occur on- or
    /// off-Stripe. For example, you can create a Payment Record to model a payment made on a
    /// different payment processor, in order to mark an Invoice as paid and a Subscription as
    /// active. Payment Records consist of one or more Payment Attempt Records, which represent
    /// individual attempts made on a payment network.
    /// </summary>
    public class PaymentRecord : StripeEntity<PaymentRecord>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// A representation of an amount of money, consisting of an amount and a currency.
        /// </summary>
        [JsonProperty("amount_canceled")]
        public PaymentRecordAmountCanceled AmountCanceled { get; set; }

        /// <summary>
        /// A representation of an amount of money, consisting of an amount and a currency.
        /// </summary>
        [JsonProperty("amount_failed")]
        public PaymentRecordAmountFailed AmountFailed { get; set; }

        /// <summary>
        /// A representation of an amount of money, consisting of an amount and a currency.
        /// </summary>
        [JsonProperty("amount_guaranteed")]
        public PaymentRecordAmountGuaranteed AmountGuaranteed { get; set; }

        /// <summary>
        /// A representation of an amount of money, consisting of an amount and a currency.
        /// </summary>
        [JsonProperty("amount_refunded")]
        public PaymentRecordAmountRefunded AmountRefunded { get; set; }

        /// <summary>
        /// A representation of an amount of money, consisting of an amount and a currency.
        /// </summary>
        [JsonProperty("amount_requested")]
        public PaymentRecordAmountRequested AmountRequested { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Customer information for this payment.
        /// </summary>
        [JsonProperty("customer_details")]
        public PaymentRecordCustomerDetails CustomerDetails { get; set; }

        /// <summary>
        /// Indicates whether the customer was present in your checkout flow during this payment.
        /// One of: <c>off_session</c>, or <c>on_session</c>.
        /// </summary>
        [JsonProperty("customer_presence")]
        public string CustomerPresence { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// ID of the latest Payment Attempt Record attached to this Payment Record.
        /// </summary>
        [JsonProperty("latest_payment_attempt_record")]
        public string LatestPaymentAttemptRecord { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Information about the Payment Method debited for this payment.
        /// </summary>
        [JsonProperty("payment_method_details")]
        public PaymentRecordPaymentMethodDetails PaymentMethodDetails { get; set; }

        /// <summary>
        /// An opaque string for manual reconciliation of this payment, for example a check number
        /// or a payment processor ID.
        /// </summary>
        [JsonProperty("payment_reference")]
        public string PaymentReference { get; set; }

        /// <summary>
        /// Shipping information for this payment.
        /// </summary>
        [JsonProperty("shipping_details")]
        public PaymentRecordShippingDetails ShippingDetails { get; set; }
    }
}
