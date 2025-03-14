// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSessionComponentsRecipientsFeaturesOptions : INestedOptions
    {
        /// <summary>
        /// Whether to allow sending money.
        /// </summary>
        [JsonProperty("send_money")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("send_money")]
#endif
        public bool? SendMoney { get; set; }
    }
}
