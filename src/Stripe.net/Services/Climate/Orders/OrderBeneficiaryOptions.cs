// File generated from our OpenAPI spec
namespace Stripe.Climate
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OrderBeneficiaryOptions : INestedOptions
    {
        /// <summary>
        /// Publicly displayable name for the end beneficiary of carbon removal.
        /// </summary>
        [JsonProperty("public_name")]
        [STJS.JsonPropertyName("public_name")]
        public string PublicName { get; set; }
    }
}
