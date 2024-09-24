namespace Stripe.Treasury
{
    using System;
    using Newtonsoft.Json;

    [Obsolete("Use FinancialAccountFeaturesOutboundTransfersAchOptions instead.")]
    public class FinancialAccountOutboundTransfersAchOptions : INestedOptions
    {
        /// <summary>
        /// Whether the FinancialAccount should have the Feature.
        /// </summary>
        [JsonProperty("requested")]
        public bool? Requested { get; set; }
    }
}
