// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSettingsWechatPayPayments : StripeEntity<AccountSettingsWechatPayPayments>
    {
        /// <summary>
        /// The domains of the user's mobile web checkout pages for WeChat Pay payments. At most 4
        /// domains are allowed.
        /// </summary>
        [JsonProperty("mobile_web_domains")]
        [STJS.JsonPropertyName("mobile_web_domains")]
        public List<string> MobileWebDomains { get; set; }
    }
}
