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
        public PaymentRecordAmount Amount { get; set; }

        /// <summary>
        /// A representation of an amount of money, consisting of an amount and a currency.
        /// </summary>
        [JsonProperty("amount_authorized")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_authorized")]
#endif
        public PaymentRecordAmountAuthorized AmountAuthorized { get; set; }

        /// <summary>
        /// A representation of an amount of money, consisting of an amount and a currency.
        /// </summary>
        [JsonProperty("amount_canceled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_canceled")]
#endif
        public PaymentRecordAmountCanceled AmountCanceled { get; set; }

        /// <summary>
        /// A representation of an amount of money, consisting of an amount and a currency.
        /// </summary>
        [JsonProperty("amount_failed")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_failed")]
#endif
        public PaymentRecordAmountFailed AmountFailed { get; set; }

        /// <summary>
        /// A representation of an amount of money, consisting of an amount and a currency.
        /// </summary>
        [JsonProperty("amount_guaranteed")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_guaranteed")]
#endif
        public PaymentRecordAmountGuaranteed AmountGuaranteed { get; set; }

        /// <summary>
        /// A representation of an amount of money, consisting of an amount and a currency.
        /// </summary>
        [JsonProperty("amount_refunded")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_refunded")]
#endif
        public PaymentRecordAmountRefunded AmountRefunded { get; set; }

        /// <summary>
        /// A representation of an amount of money, consisting of an amount and a currency.
        /// </summary>
        [JsonProperty("amount_requested")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_requested")]
#endif
        public PaymentRecordAmountRequested AmountRequested { get; set; }

        /// <summary>
        /// ID of the Connect application that created the PaymentRecord.
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
        public PaymentRecordCustomerDetails CustomerDetails { get; set; }

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
        /// ID of the latest Payment Attempt Record attached to this Payment Record.
        /// </summary>
        [JsonProperty("latest_payment_attempt_record")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("latest_payment_attempt_record")]
#endif
        public string LatestPaymentAttemptRecord { get; set; }

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
        public PaymentRecordPaymentMethodDetails PaymentMethodDetails { get; set; }

        /// <summary>
        /// Processor information associated with this payment.
        /// </summary>
        [JsonProperty("processor_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("processor_details")]
#endif
        public PaymentRecordProcessorDetails ProcessorDetails { get; set; }

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
        public PaymentRecordShippingDetails ShippingDetails { get; set; }
    }
}
