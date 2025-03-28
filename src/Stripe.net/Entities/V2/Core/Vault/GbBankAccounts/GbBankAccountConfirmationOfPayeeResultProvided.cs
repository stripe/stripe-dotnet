// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class GbBankAccountConfirmationOfPayeeResultProvided : StripeEntity<GbBankAccountConfirmationOfPayeeResultProvided>
    {
        /// <summary>
        /// The provided or Legal Entity business type to match against the CoP service. Closed
        /// enum.
        /// One of: <c>business</c>, or <c>personal</c>.
        /// </summary>
        [JsonProperty("business_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("business_type")]
#endif
        public string BusinessType { get; set; }

        /// <summary>
        /// The provided or Legal Entity name to match against the CoP service.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }
    }
}
