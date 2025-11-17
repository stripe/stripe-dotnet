// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountBusinessProfile : StripeEntity<AccountBusinessProfile>
    {
        /// <summary>
        /// The applicant's gross annual revenue for its preceding fiscal year.
        /// </summary>
        [JsonProperty("annual_revenue")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("annual_revenue")]
#endif
        public AccountBusinessProfileAnnualRevenue AnnualRevenue { get; set; }

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
        /// Whether the business is a minority-owned, women-owned, and/or LGBTQI+ -owned business.
        /// One of: <c>lgbtqi_owned_business</c>, <c>minority_owned_business</c>,
        /// <c>none_of_these_apply</c>, <c>prefer_not_to_answer</c>, or <c>women_owned_business</c>.
        /// </summary>
        [JsonProperty("minority_owned_business_designation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("minority_owned_business_designation")]
#endif
        public List<string> MinorityOwnedBusinessDesignation { get; set; }

        [JsonProperty("monthly_estimated_revenue")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("monthly_estimated_revenue")]
#endif
        public AccountBusinessProfileMonthlyEstimatedRevenue MonthlyEstimatedRevenue { get; set; }

        /// <summary>
        /// The customer-facing business name.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// Internal-only description of the product sold or service provided by the business. It's
        /// used by Stripe for risk and underwriting purposes.
        /// </summary>
        [JsonProperty("product_description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("product_description")]
#endif
        public string ProductDescription { get; set; }

        /// <summary>
        /// A link to the business's publicly available terms related to the Specified Commercial
        /// Transaction Act. Only used for accounts in Japan.
        /// </summary>
        [JsonProperty("specified_commercial_transactions_act_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("specified_commercial_transactions_act_url")]
#endif
        public string SpecifiedCommercialTransactionsActUrl { get; set; }

        /// <summary>
        /// A publicly available mailing address for sending support issues to.
        /// </summary>
        [JsonProperty("support_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("support_address")]
#endif
        public Address SupportAddress { get; set; }

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
