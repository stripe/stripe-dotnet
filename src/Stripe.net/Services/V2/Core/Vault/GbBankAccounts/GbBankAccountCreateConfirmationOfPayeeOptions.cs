// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class GbBankAccountCreateConfirmationOfPayeeOptions : INestedOptions
    {
        /// <summary>
        /// The business type to be checked against. Legal entity information will be used if
        /// unspecified. Closed enum.
        /// One of: <c>business</c>, or <c>personal</c>.
        /// </summary>
        [JsonProperty("business_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("business_type")]
#endif
        public string BusinessType { get; set; }

        /// <summary>
        /// User specifies whether Confirmation of Payee is automatically initiated when creating
        /// the bank account.
        /// </summary>
        [JsonProperty("initiate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("initiate")]
#endif
        public bool? Initiate { get; set; }

        /// <summary>
        /// The name to be checked against. Legal entity information will be used if unspecified.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }
    }
}
