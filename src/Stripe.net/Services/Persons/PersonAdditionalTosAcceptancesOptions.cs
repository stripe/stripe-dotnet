namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    [Obsolete("Use AccountPersonAdditionalTosAcceptancesOptions instead.")]
    public class PersonAdditionalTosAcceptancesOptions : INestedOptions
    {
        /// <summary>
        /// Details on the legal guardian's acceptance of the main Stripe service agreement.
        /// </summary>
        [JsonProperty("account")]
        public PersonAdditionalTosAcceptancesAccountOptions Account { get; set; }
    }
}
