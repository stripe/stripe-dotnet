// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PersonAdditionalTosAcceptancesOptions : INestedOptions
    {
        /// <summary>
        /// Details on the legal guardian's acceptance of the main Stripe service agreement.
        /// </summary>
        [JsonProperty("account")]
        public PersonAdditionalTosAcceptancesAccountOptions Account { get; set; }
    }
}
