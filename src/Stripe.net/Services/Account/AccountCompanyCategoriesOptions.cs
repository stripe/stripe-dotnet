namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountCompanyCategoriesOptions : INestedOptions
    {
        /// <summary>
        /// Whether this company is a government agency.
        /// </summary>
        [JsonProperty("government_agency")]
        public bool? GovernmentAgency { get; set; }

        /// <summary>
        /// Whether this company is a non-profit.
        /// </summary>
        [JsonProperty("non_profit")]
        public bool? NonProfit { get; set; }

        /// <summary>
        /// Whether this company is publicly traded.
        /// </summary>
        [JsonProperty("publicly_traded")]
        public bool? PubliclyTraded { get; set; }
    }
}
