namespace Stripe.FinancialConnections
{
    using System;
    using Newtonsoft.Json;

    [Obsolete("Use AccountOwnerListOptions instead.")]
    public class AccountListOwnersOptions : ListOptions
    {
        /// <summary>
        /// The ID of the ownership object to fetch owners from.
        /// </summary>
        [JsonProperty("ownership")]
        public string Ownership { get; set; }
    }
}
