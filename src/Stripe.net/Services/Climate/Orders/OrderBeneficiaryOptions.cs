// File generated from our OpenAPI spec
namespace Stripe.Climate
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OrderBeneficiaryOptions : INestedOptions
    {
        /// <summary>
        /// Publicly displayable name for the end beneficiary of carbon removal.
        /// </summary>
        [JsonProperty("public_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("public_name")]
#endif

        public string PublicName { get; set; }
    }
}
