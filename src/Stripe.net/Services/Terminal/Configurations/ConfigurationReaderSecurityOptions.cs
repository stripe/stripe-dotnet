// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ConfigurationReaderSecurityOptions : INestedOptions, IHasSetTracking
    {
        private string adminMenuPasscode;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Passcode used to access a reader's admin menu.
        /// </summary>
        [JsonProperty("admin_menu_passcode")]
        [STJS.JsonPropertyName("admin_menu_passcode")]
        public string AdminMenuPasscode
        {
            get => this.adminMenuPasscode;
            set
            {
                this.adminMenuPasscode = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
