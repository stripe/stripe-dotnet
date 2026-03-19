// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// A payment method domain represents a web domain that you have registered with Stripe.
    /// Stripe Elements use registered payment method domains to control where certain payment
    /// methods are shown.
    ///
    /// Related guide: <a
    /// href="https://docs.stripe.com/payments/payment-methods/pmd-registration">Payment method
    /// domains</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentMethodDomain : StripeEntity<PaymentMethodDomain>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Indicates the status of a specific payment method on a payment method domain.
        /// </summary>
        [JsonProperty("amazon_pay")]
        [STJS.JsonPropertyName("amazon_pay")]
        public PaymentMethodDomainAmazonPay AmazonPay { get; set; }

        /// <summary>
        /// Indicates the status of a specific payment method on a payment method domain.
        /// </summary>
        [JsonProperty("apple_pay")]
        [STJS.JsonPropertyName("apple_pay")]
        public PaymentMethodDomainApplePay ApplePay { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The domain name that this payment method domain object represents.
        /// </summary>
        [JsonProperty("domain_name")]
        [STJS.JsonPropertyName("domain_name")]
        public string DomainName { get; set; }

        /// <summary>
        /// Whether this payment method domain is enabled. If the domain is not enabled, payment
        /// methods that require a payment method domain will not appear in Elements.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Indicates the status of a specific payment method on a payment method domain.
        /// </summary>
        [JsonProperty("google_pay")]
        [STJS.JsonPropertyName("google_pay")]
        public PaymentMethodDomainGooglePay GooglePay { get; set; }

        /// <summary>
        /// Indicates the status of a specific payment method on a payment method domain.
        /// </summary>
        [JsonProperty("klarna")]
        [STJS.JsonPropertyName("klarna")]
        public PaymentMethodDomainKlarna Klarna { get; set; }

        /// <summary>
        /// Indicates the status of a specific payment method on a payment method domain.
        /// </summary>
        [JsonProperty("link")]
        [STJS.JsonPropertyName("link")]
        public PaymentMethodDomainLink Link { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Indicates the status of a specific payment method on a payment method domain.
        /// </summary>
        [JsonProperty("paypal")]
        [STJS.JsonPropertyName("paypal")]
        public PaymentMethodDomainPaypal Paypal { get; set; }
    }
}
