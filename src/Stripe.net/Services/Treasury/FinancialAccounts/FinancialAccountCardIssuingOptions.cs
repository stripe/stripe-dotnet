namespace Stripe.Treasury
{
    using System;
    using Newtonsoft.Json;

    [Obsolete("Use FinancialAccountFeaturesCardIssuingOptions instead.")]
    public class FinancialAccountCardIssuingOptions : INestedOptions
    {
        /// <summary>
        /// Whether the FinancialAccount should have the Feature.
        /// </summary>
        [JsonProperty("requested")]
        public bool? Requested { get; set; }
    }
}
