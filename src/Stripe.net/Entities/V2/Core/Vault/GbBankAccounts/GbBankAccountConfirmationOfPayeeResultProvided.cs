// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class GbBankAccountConfirmationOfPayeeResultProvided : StripeEntity<GbBankAccountConfirmationOfPayeeResultProvided>
    {
        /// <summary>
        /// The provided or Legal Entity business type to match against the CoP service. Closed
        /// enum.
        /// One of: <c>business</c>, or <c>personal</c>.
        /// </summary>
        [JsonProperty("business_type")]
        [STJS.JsonPropertyName("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// The provided or Legal Entity name to match against the CoP service.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
