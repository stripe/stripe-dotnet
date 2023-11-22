// File generated from our OpenAPI spec
namespace Stripe.Climate
{
    using Newtonsoft.Json;

    public class OrderBeneficiaryOptions : INestedOptions
    {
        /// <summary>
        /// Publicly displayable name for the end beneficiary of carbon removal.
        /// </summary>
        [JsonProperty("public_name")]
        public string PublicName { get; set; }
    }
}
