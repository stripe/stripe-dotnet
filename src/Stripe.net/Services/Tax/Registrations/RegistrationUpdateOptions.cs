// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RegistrationUpdateOptions : BaseOptions
    {
        private AnyOf<DateTime?, RegistrationExpiresAt> expiresAt;

        /// <summary>
        /// Time at which the registration becomes active. It can be either <c>now</c> to indicate
        /// the current time, or a timestamp measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("active_from")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("active_from")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, RegistrationActiveFrom> ActiveFrom { get; set; }

        /// <summary>
        /// If set, the registration stops being active at this time. If not set, the registration
        /// will be active indefinitely. It can be either <c>now</c> to indicate the current time,
        /// or a timestamp measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, RegistrationExpiresAt> ExpiresAt
        {
            get => this.expiresAt;
            set
            {
                this.expiresAt = value;
                this.SetTracker.Track();
            }
        }
    }
}
