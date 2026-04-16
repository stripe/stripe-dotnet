// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentMethodConfigurationListOptions : ListOptions
    {
        private string application;

        /// <summary>
        /// The Connect application to filter by.
        /// </summary>
        [JsonProperty("application", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("application")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string Application
        {
            get => this.application;
            set
            {
                this.application = value;
                this.SetTracker.Track();
            }
        }
    }
}
