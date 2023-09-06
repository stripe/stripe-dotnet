// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// A payment method domain represents a web domain that you have registered with Stripe.
    /// Stripe Elements use registered payment method domains to control where certain payment
    /// methods are shown.
    ///
    /// Related guides: <a
    /// href="https://stripe.com/docs/payments/payment-methods/pmd-registration">Payment method
    /// domains</a>.
    /// </summary>
    public class PaymentMethodDomain : StripeEntity<PaymentMethodDomain>, IHasId, IHasObject
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
        /// Indicates the status of a specific payment method on a payment method domain.
        /// </summary>
        [JsonProperty("apple_pay")]
        public PaymentMethodDomainApplePay ApplePay { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The domain name that this payment method domain object represents.
        /// </summary>
        [JsonProperty("domain_name")]
        public string DomainName { get; set; }

        /// <summary>
        /// Whether this payment method domain is enabled. If the domain is not enabled, payment
        /// methods that require a payment method domain will not appear in Elements.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Indicates the status of a specific payment method on a payment method domain.
        /// </summary>
        [JsonProperty("google_pay")]
        public PaymentMethodDomainGooglePay GooglePay { get; set; }

        /// <summary>
        /// Indicates the status of a specific payment method on a payment method domain.
        /// </summary>
        [JsonProperty("link")]
        public PaymentMethodDomainLink Link { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Indicates the status of a specific payment method on a payment method domain.
        /// </summary>
        [JsonProperty("paypal")]
        public PaymentMethodDomainPaypal Paypal { get; set; }
    }
}
