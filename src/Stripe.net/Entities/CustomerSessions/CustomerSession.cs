// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// A Customer Session allows you to grant Stripe's frontend SDKs (like Stripe.js)
    /// client-side access control over a Customer.
    ///
    /// Related guides: <a
    /// href="https://stripe.com/payments/accept-a-payment-deferred?platform=web&amp;type=payment#save-payment-methods">Customer
    /// Session with the Payment Element</a>, <a
    /// href="https://stripe.com/payments/checkout/pricing-table#customer-session">Customer
    /// Session with the Pricing Table</a>, <a
    /// href="https://stripe.com/payment-links/buy-button#pass-an-existing-customer">Customer
    /// Session with the Buy Button</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CustomerSession : StripeEntity<CustomerSession>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The client secret of this Customer Session. Used on the client to set up secure access
        /// to the given <c>customer</c>.
        ///
        /// The client secret can be used to provide access to <c>customer</c> from your frontend.
        /// It should not be stored, logged, or exposed to anyone other than the relevant customer.
        /// Make sure that you have TLS enabled on any page that includes the client secret.
        /// </summary>
        [JsonProperty("client_secret")]
        [STJS.JsonPropertyName("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Configuration for the components supported by this Customer Session.
        /// </summary>
        [JsonProperty("components")]
        [STJS.JsonPropertyName("components")]
        public CustomerSessionComponents Components { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// The Customer the Customer Session was created for.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// (Expanded)
        /// The Customer the Customer Session was created for.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Customer Customer
        {
            get => this.InternalCustomer?.ExpandedObject;
            set => this.InternalCustomer = SetExpandableFieldObject(value, this.InternalCustomer);
        }

        [JsonProperty("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
        [STJS.JsonPropertyName("customer")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Customer>))]
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        /// <summary>
        /// The Account that the Customer Session was created for.
        /// </summary>
        [JsonProperty("customer_account")]
        [STJS.JsonPropertyName("customer_account")]
        public string CustomerAccount { get; set; }

        /// <summary>
        /// The timestamp at which this Customer Session will expire.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }
    }
}
