// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSessionComponentsRecipientsFeaturesOptions : INestedOptions
    {
        /// <summary>
        /// Whether to allow sending money.
        /// </summary>
        [JsonProperty("send_money")]
        public bool? SendMoney { get; set; }
    }
}
