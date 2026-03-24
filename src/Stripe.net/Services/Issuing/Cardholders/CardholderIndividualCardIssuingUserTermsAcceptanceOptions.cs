// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CardholderIndividualCardIssuingUserTermsAcceptanceOptions : INestedOptions, IHasSetTracking
    {
        private string userAgent;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// The Unix timestamp marking when the cardholder accepted the Authorized User Terms.
        /// Required for Celtic Spend Card users.
        /// </summary>
        [JsonProperty("date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The IP address from which the cardholder accepted the Authorized User Terms. Required
        /// for Celtic Spend Card users.
        /// </summary>
        [JsonProperty("ip")]
        [STJS.JsonPropertyName("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// The user agent of the browser from which the cardholder accepted the Authorized User
        /// Terms.
        /// </summary>
        [JsonProperty("user_agent")]
        [STJS.JsonPropertyName("user_agent")]
        public string UserAgent
        {
            get => this.userAgent;
            set
            {
                this.userAgent = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
