// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class GbBankAccountConfirmationOfPayeeResultMatched : StripeEntity<GbBankAccountConfirmationOfPayeeResultMatched>
    {
        /// <summary>
        /// The business type given by the bank for this account, in case of a MATCH or
        /// PARTIAL_MATCH. Closed enum.
        /// One of: <c>business</c>, or <c>personal</c>.
        /// </summary>
        [JsonProperty("business_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("business_type")]
#endif
        public string BusinessType { get; set; }

        /// <summary>
        /// The name given by the bank for this account, in case of a MATCH or PARTIAL_MATCH.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }
    }
}
