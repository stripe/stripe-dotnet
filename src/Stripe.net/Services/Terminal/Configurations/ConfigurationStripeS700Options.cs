// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ConfigurationStripeS700Options : INestedOptions, IHasSetTracking
    {
        private string splashscreen;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// A File ID representing an image you want to display on the reader.
        /// </summary>
        [JsonProperty("splashscreen", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("splashscreen")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string Splashscreen
        {
            get => this.splashscreen;
            set
            {
                this.splashscreen = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
