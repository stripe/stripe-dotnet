// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class GbBankAccountCreateConfirmationOfPayeeOptions : INestedOptions
    {
        /// <summary>
        /// The business type to be checked against. Legal entity information will be used if
        /// unspecified. Closed enum.
        /// One of: <c>business</c>, or <c>personal</c>.
        /// </summary>
        [JsonProperty("business_type")]
        [STJS.JsonPropertyName("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// User specifies whether Confirmation of Payee is automatically initiated when creating
        /// the bank account.
        /// </summary>
        [JsonProperty("initiate")]
        [STJS.JsonPropertyName("initiate")]
        public bool? Initiate { get; set; }

        /// <summary>
        /// The name to be checked against. Legal entity information will be used if unspecified.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
