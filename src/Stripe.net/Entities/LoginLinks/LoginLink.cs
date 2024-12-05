// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// Login Links are single-use URLs for a connected account to access the Express Dashboard.
    /// The connected account's <a
    /// href="https://stripe.com/api/accounts/object#account_object-controller-stripe_dashboard-type">account.controller.stripe_dashboard.type</a>
    /// must be <c>express</c> to have access to the Express Dashboard.
    /// </summary>
    public class LoginLink : StripeEntity<LoginLink>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The URL for the login link.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
