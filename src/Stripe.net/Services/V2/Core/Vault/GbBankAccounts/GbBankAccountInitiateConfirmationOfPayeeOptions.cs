// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class GbBankAccountInitiateConfirmationOfPayeeOptions : BaseOptions
    {
        /// <summary>
        /// The business type to be checked against. Legal entity information will be used if
        /// unspecified.
        /// One of: <c>business</c>, or <c>personal</c>.
        /// </summary>
        [JsonProperty("business_type")]
        [STJS.JsonPropertyName("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// The name of the user to be checked against. Legal entity information will be used if
        /// unspecified.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
