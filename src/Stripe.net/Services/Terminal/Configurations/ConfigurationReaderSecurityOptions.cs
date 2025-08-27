// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfigurationReaderSecurityOptions : INestedOptions
    {
        /// <summary>
        /// Passcode used to access a reader's admin menu.
        /// </summary>
        [JsonProperty("admin_menu_passcode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("admin_menu_passcode")]
#endif
        public string AdminMenuPasscode { get; set; }
    }
}
