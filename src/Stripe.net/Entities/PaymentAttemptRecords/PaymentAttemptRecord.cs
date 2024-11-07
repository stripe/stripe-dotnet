// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// A Payment Attempt Record represents an individual attempt at making a payment, on or off
    /// Stripe. Each payment attempt tries to collect a fixed amount of money from a fixed
    /// customer and payment method. Payment Attempt Records are attached to Payment Records.
    /// Only one attempt per Payment Record can have guaranteed funds.
    /// </summary>
    public class PaymentAttemptRecord : StripeEntity<PaymentAttemptRecord>, IHasId, IHasMetadata, IHasObject
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
        public PaymentAttemptRecordAmountCanceled AmountCanceled { get; set; }

        /// <summary>
        /// A representation of an amount of money, consisting of an amount and a currency.
        /// </summary>
        [JsonProperty("amount_failed")]
        public PaymentAttemptRecordAmountFailed AmountFailed { get; set; }

        /// <summary>
        /// A representation of an amount of money, consisting of an amount and a currency.
        /// </summary>
        [JsonProperty("amount_guaranteed")]
        public PaymentAttemptRecordAmountGuaranteed AmountGuaranteed { get; set; }

        /// <summary>
        /// A representation of an amount of money, consisting of an amount and a currency.
        /// </summary>
        [JsonProperty("amount_requested")]
        public PaymentAttemptRecordAmountRequested AmountRequested { get; set; }

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
        public PaymentAttemptRecordCustomerDetails CustomerDetails { get; set; }

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
        public PaymentAttemptRecordPaymentMethodDetails PaymentMethodDetails { get; set; }

        /// <summary>
        /// ID of the Payment Record this Payment Attempt Record belongs to.
        /// </summary>
        [JsonProperty("payment_record")]
        public string PaymentRecord { get; set; }

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
        public PaymentAttemptRecordShippingDetails ShippingDetails { get; set; }
    }
}
