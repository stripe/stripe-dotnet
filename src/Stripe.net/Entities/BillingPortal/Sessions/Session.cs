namespace Stripe.BillingPortal
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Session : StripeEntity<Session>, IHasId, IHasObject
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
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The ID of the customer for this session.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The URL to which Stripe should send customers when they click on the link to return to
        /// your website.
        /// </summary>
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// The short-lived URL of the session giving customers access to the customer portal.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
