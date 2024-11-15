// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountBusinessProfileOptions : INestedOptions
    {
        /// <summary>
        /// The applicant's gross annual revenue for its preceding fiscal year.
        /// </summary>
        [JsonProperty("annual_revenue")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("annual_revenue")]
#endif

        public AccountBusinessProfileAnnualRevenueOptions AnnualRevenue { get; set; }

        /// <summary>
        /// An estimated upper bound of employees, contractors, vendors, etc. currently working for
        /// the business.
        /// </summary>
        [JsonProperty("estimated_worker_count")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("estimated_worker_count")]
#endif

        public long? EstimatedWorkerCount { get; set; }

        /// <summary>
        /// <a href="https://stripe.com/connect/setting-mcc">The merchant category code for the
        /// account</a>. MCCs are used to classify businesses based on the goods or services they
        /// provide.
        /// </summary>
        [JsonProperty("mcc")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mcc")]
#endif

        public string Mcc { get; set; }

        /// <summary>
        /// An estimate of the monthly revenue of the business. Only accepted for accounts in Brazil
        /// and India.
        /// </summary>
        [JsonProperty("monthly_estimated_revenue")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("monthly_estimated_revenue")]
#endif

        public AccountBusinessProfileMonthlyEstimatedRevenueOptions MonthlyEstimatedRevenue { get; set; }

        /// <summary>
        /// The customer-facing business name.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif

        public string Name { get; set; }

        /// <summary>
        /// Internal-only description of the product sold by, or service provided by, the business.
        /// Used by Stripe for risk and underwriting purposes.
        /// </summary>
        [JsonProperty("product_description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("product_description")]
#endif

        public string ProductDescription { get; set; }

        /// <summary>
        /// A publicly available mailing address for sending support issues to.
        /// </summary>
        [JsonProperty("support_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("support_address")]
#endif

        public AddressOptions SupportAddress { get; set; }

        /// <summary>
        /// A publicly available email address for sending support issues to.
        /// </summary>
        [JsonProperty("support_email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("support_email")]
#endif

        public string SupportEmail { get; set; }

        /// <summary>
        /// A publicly available phone number to call with support issues.
        /// </summary>
        [JsonProperty("support_phone")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("support_phone")]
#endif

        public string SupportPhone { get; set; }

        /// <summary>
        /// A publicly available website for handling support issues.
        /// </summary>
        [JsonProperty("support_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("support_url")]
#endif

        public string SupportUrl { get; set; }

        /// <summary>
        /// The business's publicly available website.
        /// </summary>
        [JsonProperty("url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("url")]
#endif

        public string Url { get; set; }
    }
}
