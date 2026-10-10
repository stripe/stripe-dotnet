// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSettingsWechatPayMobileWebPayments : StripeEntity<AccountSettingsWechatPayMobileWebPayments>
    {
        /// <summary>
        /// The domains of the user's mobile web checkout pages for WeChat Pay payments.
        /// </summary>
        [JsonProperty("domains")]
        [STJS.JsonPropertyName("domains")]
        public List<string> Domains { get; set; }
    }
}
