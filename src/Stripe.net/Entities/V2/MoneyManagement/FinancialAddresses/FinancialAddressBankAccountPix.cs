// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAddressBankAccountPix : StripeEntity<FinancialAddressBankAccountPix>
    {
        /// <summary>
        /// The name of the account holder.
        /// </summary>
        [JsonProperty("account_holder_name")]
        [STJS.JsonPropertyName("account_holder_name")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The Pix BR code.
        /// </summary>
        [JsonProperty("br_code")]
        [STJS.JsonPropertyName("br_code")]
        public string BrCode { get; set; }
    }
}
