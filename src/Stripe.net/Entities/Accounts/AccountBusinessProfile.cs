namespace Stripe
{
#if USE_SYSTEM_TEXT_JSON
    using System.Text.Json.Serialization;
#else
    using Newtonsoft.Json;
#endif

    public class AccountBusinessProfile : StripeEntity<AccountBusinessProfile>
    {
        /// <summary>
        /// The applicant's gross annual revenue for its preceding fiscal year.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("annual_revenue")]
#else
        [JsonProperty("annual_revenue")]
#endif
        public AccountBusinessProfileAnnualRevenue AnnualRevenue { get; set; }

        /// <summary>
        /// An estimated upper bound of employees, contractors, vendors, etc. currently working for
        /// the business.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("estimated_worker_count")]
#else
        [JsonProperty("estimated_worker_count")]
#endif
        public long? EstimatedWorkerCount { get; set; }

        /// <summary>
        /// <a href="https://stripe.com/connect/setting-mcc">The merchant category code for the
        /// account</a>. MCCs are used to classify businesses based on the goods or services they
        /// provide.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("mcc")]
#else
        [JsonProperty("mcc")]
#endif
        public string Mcc { get; set; }

#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("monthly_estimated_revenue")]
#else
        [JsonProperty("monthly_estimated_revenue")]
#endif
        public AccountBusinessProfileMonthlyEstimatedRevenue MonthlyEstimatedRevenue { get; set; }

        /// <summary>
        /// The customer-facing business name.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("name")]
#else
        [JsonProperty("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// Internal-only description of the product sold or service provided by the business. It's
        /// used by Stripe for risk and underwriting purposes.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("product_description")]
#else
        [JsonProperty("product_description")]
#endif
        public string ProductDescription { get; set; }

        /// <summary>
        /// A publicly available mailing address for sending support issues to.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("support_address")]
#else
        [JsonProperty("support_address")]
#endif
        public Address SupportAddress { get; set; }

        /// <summary>
        /// A publicly available email address for sending support issues to.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("support_email")]
#else
        [JsonProperty("support_email")]
#endif
        public string SupportEmail { get; set; }

        /// <summary>
        /// A publicly available phone number to call with support issues.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("support_phone")]
#else
        [JsonProperty("support_phone")]
#endif
        public string SupportPhone { get; set; }

        /// <summary>
        /// A publicly available website for handling support issues.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("support_url")]
#else
        [JsonProperty("support_url")]
#endif
        public string SupportUrl { get; set; }

        /// <summary>
        /// The business's publicly available website.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("url")]
#else
        [JsonProperty("url")]
#endif
        public string Url { get; set; }
    }
}
