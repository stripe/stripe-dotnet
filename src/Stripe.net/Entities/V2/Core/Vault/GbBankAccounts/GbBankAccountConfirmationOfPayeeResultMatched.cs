// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class GbBankAccountConfirmationOfPayeeResultMatched : StripeEntity<GbBankAccountConfirmationOfPayeeResultMatched>
    {
        /// <summary>
        /// The business type given by the bank for this account, in case of a MATCH or
        /// PARTIAL_MATCH. Closed enum.
        /// One of: <c>business</c>, or <c>personal</c>.
        /// </summary>
        [JsonProperty("business_type")]
        [STJS.JsonPropertyName("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// The name given by the bank for this account, in case of a MATCH or PARTIAL_MATCH.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
