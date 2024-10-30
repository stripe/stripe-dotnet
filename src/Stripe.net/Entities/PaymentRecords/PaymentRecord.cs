// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// A PaymentRecord represents a payment that happened on or off Stripe.
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
        /// Amount object.
        /// </summary>
        [JsonProperty("amount_canceled")]
        public PaymentRecordAmountCanceled AmountCanceled { get; set; }

        /// <summary>
        /// Amount object.
        /// </summary>
        [JsonProperty("amount_failed")]
        public PaymentRecordAmountFailed AmountFailed { get; set; }

        /// <summary>
        /// Amount object.
        /// </summary>
        [JsonProperty("amount_guaranteed")]
        public PaymentRecordAmountGuaranteed AmountGuaranteed { get; set; }

        /// <summary>
        /// Amount object.
        /// </summary>
        [JsonProperty("amount_refunded")]
        public PaymentRecordAmountRefunded AmountRefunded { get; set; }

        /// <summary>
        /// Amount object.
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
        /// Whether the customer was present during the transaction.
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
        /// ID of the latest PaymentAttemptRecord attached to this PaymentRecord.
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
        /// Information about the method used to make this payment.
        /// </summary>
        [JsonProperty("payment_method_details")]
        public PaymentRecordPaymentMethodDetails PaymentMethodDetails { get; set; }

        /// <summary>
        /// An opaque string for manual reconciliation of this payment, for example a check number.
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
