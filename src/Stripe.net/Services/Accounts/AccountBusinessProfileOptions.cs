// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountBusinessProfileOptions : INestedOptions
    {
        /// <summary>
        /// The applicant's gross annual revenue for its preceding fiscal year.
        /// </summary>
        [JsonProperty("annual_revenue")]
        public AccountBusinessProfileAnnualRevenueOptions AnnualRevenue { get; set; }

        /// <summary>
        /// An estimated upper bound of employees, contractors, vendors, etc. currently working for
        /// the business.
        /// </summary>
        [JsonProperty("estimated_worker_count")]
        public long? EstimatedWorkerCount { get; set; }

        /// <summary>
        /// <a href="https://stripe.com/docs/connect/setting-mcc">The merchant category code for the
        /// account</a>. MCCs are used to classify businesses based on the goods or services they
        /// provide.
        /// </summary>
        [JsonProperty("mcc")]
        public string Mcc { get; set; }

        /// <summary>
        /// An estimate of the monthly revenue of the business. Only accepted for accounts in Brazil
        /// and India.
        /// </summary>
        [JsonProperty("monthly_estimated_revenue")]
        public AccountBusinessProfileMonthlyEstimatedRevenueOptions MonthlyEstimatedRevenue { get; set; }

        /// <summary>
        /// The customer-facing business name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Internal-only description of the product sold by, or service provided by, the business.
        /// Used by Stripe for risk and underwriting purposes.
        /// </summary>
        [JsonProperty("product_description")]
        public string ProductDescription { get; set; }

        /// <summary>
        /// A publicly available mailing address for sending support issues to.
        /// </summary>
        [JsonProperty("support_address")]
        public AddressOptions SupportAddress { get; set; }

        /// <summary>
        /// A publicly available email address for sending support issues to.
        /// </summary>
        [JsonProperty("support_email")]
        public string SupportEmail { get; set; }

        /// <summary>
        /// A publicly available phone number to call with support issues.
        /// </summary>
        [JsonProperty("support_phone")]
        public string SupportPhone { get; set; }

        /// <summary>
        /// A publicly available website for handling support issues.
        /// </summary>
        [JsonProperty("support_url")]
        public string SupportUrl { get; set; }

        /// <summary>
        /// The business's publicly available website.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
