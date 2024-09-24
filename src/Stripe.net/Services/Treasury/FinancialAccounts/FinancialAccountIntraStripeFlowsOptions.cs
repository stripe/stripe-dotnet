namespace Stripe.Treasury
{
    using System;
    using Newtonsoft.Json;

    [Obsolete("Use FinancialAccountFeaturesIntraStripeFlowsOptions instead.")]
    public class FinancialAccountIntraStripeFlowsOptions : INestedOptions
    {
        /// <summary>
        /// Whether the FinancialAccount should have the Feature.
        /// </summary>
        [JsonProperty("requested")]
        public bool? Requested { get; set; }
    }
}
