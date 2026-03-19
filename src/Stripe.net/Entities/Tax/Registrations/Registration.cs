// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A Tax <c>Registration</c> lets us know that your business is registered to collect tax
    /// on payments within a region, enabling you to <a
    /// href="https://docs.stripe.com/tax">automatically collect tax</a>.
    ///
    /// Stripe doesn't register on your behalf with the relevant authorities when you create a
    /// Tax <c>Registration</c> object. For more information on how to register to collect tax,
    /// see <a href="https://docs.stripe.com/tax/registering">our guide</a>.
    ///
    /// Related guide: <a href="https://docs.stripe.com/tax/registrations-api">Using the
    /// Registrations API</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Registration : StripeEntity<Registration>, IHasId, IHasObject
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
        /// Time at which the registration becomes active. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("active_from")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("active_from")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime ActiveFrom { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Two-letter country code (<a href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO
        /// 3166-1 alpha-2</a>).
        /// </summary>
        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonProperty("country_options")]
        [STJS.JsonPropertyName("country_options")]
        public RegistrationCountryOptions CountryOptions { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// If set, the registration stops being active at this time. If not set, the registration
        /// will be active indefinitely. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The status of the registration. This field is present for convenience and can be deduced
        /// from <c>active_from</c> and <c>expires_at</c>.
        /// One of: <c>active</c>, <c>expired</c>, or <c>scheduled</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
