// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

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
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// A representation of an amount of money, consisting of an amount and a currency.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public PaymentAttemptRecordAmount Amount { get; set; }

        /// <summary>
        /// A representation of an amount of money, consisting of an amount and a currency.
        /// </summary>
        [JsonProperty("amount_authorized")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_authorized")]
#endif
        public PaymentAttemptRecordAmountAuthorized AmountAuthorized { get; set; }

        /// <summary>
        /// A representation of an amount of money, consisting of an amount and a currency.
        /// </summary>
        [JsonProperty("amount_canceled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_canceled")]
#endif
        public PaymentAttemptRecordAmountCanceled AmountCanceled { get; set; }

        /// <summary>
        /// A representation of an amount of money, consisting of an amount and a currency.
        /// </summary>
        [JsonProperty("amount_failed")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_failed")]
#endif
        public PaymentAttemptRecordAmountFailed AmountFailed { get; set; }

        /// <summary>
        /// A representation of an amount of money, consisting of an amount and a currency.
        /// </summary>
        [JsonProperty("amount_guaranteed")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_guaranteed")]
#endif
        public PaymentAttemptRecordAmountGuaranteed AmountGuaranteed { get; set; }

        /// <summary>
        /// A representation of an amount of money, consisting of an amount and a currency.
        /// </summary>
        [JsonProperty("amount_refunded")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_refunded")]
#endif
        public PaymentAttemptRecordAmountRefunded AmountRefunded { get; set; }

        /// <summary>
        /// A representation of an amount of money, consisting of an amount and a currency.
        /// </summary>
        [JsonProperty("amount_requested")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_requested")]
#endif
        public PaymentAttemptRecordAmountRequested AmountRequested { get; set; }

        /// <summary>
        /// ID of the Connect application that created the PaymentAttemptRecord.
        /// </summary>
        [JsonProperty("application")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("application")]
#endif
        public string Application { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Customer information for this payment.
        /// </summary>
        [JsonProperty("customer_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_details")]
#endif
        public PaymentAttemptRecordCustomerDetails CustomerDetails { get; set; }

        /// <summary>
        /// Indicates whether the customer was present in your checkout flow during this payment.
        /// One of: <c>off_session</c>, or <c>on_session</c>.
        /// </summary>
        [JsonProperty("customer_presence")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_presence")]
#endif
        public string CustomerPresence { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Information about the Payment Method debited for this payment.
        /// </summary>
        [JsonProperty("payment_method_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_details")]
#endif
        public PaymentAttemptRecordPaymentMethodDetails PaymentMethodDetails { get; set; }

        /// <summary>
        /// ID of the Payment Record this Payment Attempt Record belongs to.
        /// </summary>
        [JsonProperty("payment_record")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_record")]
#endif
        public string PaymentRecord { get; set; }

        /// <summary>
        /// Processor information associated with this payment.
        /// </summary>
        [JsonProperty("processor_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("processor_details")]
#endif
        public PaymentAttemptRecordProcessorDetails ProcessorDetails { get; set; }

        /// <summary>
        /// Indicates who reported the payment.
        /// One of: <c>self</c>, or <c>stripe</c>.
        /// </summary>
        [JsonProperty("reported_by")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reported_by")]
#endif
        public string ReportedBy { get; set; }

        /// <summary>
        /// Shipping information for this payment.
        /// </summary>
        [JsonProperty("shipping_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_details")]
#endif
        public PaymentAttemptRecordShippingDetails ShippingDetails { get; set; }
    }
}
