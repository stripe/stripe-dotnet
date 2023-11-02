// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// Source mandate notifications should be created when a notification related to a source
    /// mandate must be sent to the payer. They will trigger a webhook or deliver an email to
    /// the customer.
    /// </summary>
    public class SourceMandateNotification : StripeEntity<SourceMandateNotification>, IHasId, IHasObject
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

        [JsonProperty("acss_debit")]
        public SourceMandateNotificationAcssDebit AcssDebit { get; set; }

        /// <summary>
        /// A positive integer in the smallest currency unit (that is, 100 cents for $1.00, or 1 for
        /// ¥1, Japanese Yen being a zero-decimal currency) representing the amount associated with
        /// the mandate notification. The amount is expressed in the currency of the underlying
        /// source. Required if the notification type is <c>debit_initiated</c>.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        [JsonProperty("bacs_debit")]
        public SourceMandateNotificationBacsDebit BacsDebit { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The reason of the mandate notification. Valid reasons are <c>mandate_confirmed</c> or
        /// <c>debit_initiated</c>.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("sepa_debit")]
        public SourceMandateNotificationSepaDebit SepaDebit { get; set; }

        /// <summary>
        /// <c>Source</c> objects allow you to accept a variety of payment methods. They represent a
        /// customer's payment instrument, and can be used with the Stripe API just like a
        /// <c>Card</c> object: once chargeable, they can be charged, or can be attached to
        /// customers.
        ///
        /// Stripe doesn't recommend using the deprecated <a
        /// href="https://stripe.com/docs/api/sources">Sources API</a>. We recommend that you adopt
        /// the <a href="https://stripe.com/docs/api/payment_methods">PaymentMethods API</a>. This
        /// newer API provides access to our latest features and payment method types.
        ///
        /// Related guides: <a href="https://stripe.com/docs/sources">Sources API</a> and <a
        /// href="https://stripe.com/docs/sources/customers">Sources &amp; Customers</a>.
        /// </summary>
        [JsonProperty("source")]
        public Source Source { get; set; }

        /// <summary>
        /// The status of the mandate notification. Valid statuses are <c>pending</c> or
        /// <c>submitted</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// The type of source this mandate notification is attached to. Should be the source type
        /// identifier code for the payment method, such as <c>three_d_secure</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
