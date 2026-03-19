// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountBusinessProfileOptions : INestedOptions
    {
        /// <summary>
        /// The applicant's gross annual revenue for its preceding fiscal year.
        /// </summary>
        [JsonProperty("annual_revenue")]
        [STJS.JsonPropertyName("annual_revenue")]
        public AccountBusinessProfileAnnualRevenueOptions AnnualRevenue { get; set; }

        /// <summary>
        /// An estimated upper bound of employees, contractors, vendors, etc. currently working for
        /// the business.
        /// </summary>
        [JsonProperty("estimated_worker_count")]
        [STJS.JsonPropertyName("estimated_worker_count")]
        public long? EstimatedWorkerCount { get; set; }

        /// <summary>
        /// <a href="https://stripe.com/connect/setting-mcc">The merchant category code for the
        /// account</a>. MCCs are used to classify businesses based on the goods or services they
        /// provide.
        /// </summary>
        [JsonProperty("mcc")]
        [STJS.JsonPropertyName("mcc")]
        public string Mcc { get; set; }

        /// <summary>
        /// Whether the business is a minority-owned, women-owned, and/or LGBTQI+ -owned business.
        /// One of: <c>lgbtqi_owned_business</c>, <c>minority_owned_business</c>,
        /// <c>none_of_these_apply</c>, <c>prefer_not_to_answer</c>, or <c>women_owned_business</c>.
        /// </summary>
        [JsonProperty("minority_owned_business_designation")]
        [STJS.JsonPropertyName("minority_owned_business_designation")]
        public List<string> MinorityOwnedBusinessDesignation { get; set; }

        /// <summary>
        /// An estimate of the monthly revenue of the business. Only accepted for accounts in Brazil
        /// and India.
        /// </summary>
        [JsonProperty("monthly_estimated_revenue")]
        [STJS.JsonPropertyName("monthly_estimated_revenue")]
        public AccountBusinessProfileMonthlyEstimatedRevenueOptions MonthlyEstimatedRevenue { get; set; }

        /// <summary>
        /// The customer-facing business name.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Internal-only description of the product sold by, or service provided by, the business.
        /// Used by Stripe for risk and underwriting purposes.
        /// </summary>
        [JsonProperty("product_description")]
        [STJS.JsonPropertyName("product_description")]
        public string ProductDescription { get; set; }

        /// <summary>
        /// A link to the business's publicly available terms related to the Specified Commercial
        /// Transaction Act. Used by the Checkout product and for Japanese payment methods.
        /// </summary>
        [JsonProperty("specified_commercial_transactions_act_url")]
        [STJS.JsonPropertyName("specified_commercial_transactions_act_url")]
        public string SpecifiedCommercialTransactionsActUrl { get; set; }

        /// <summary>
        /// A publicly available mailing address for sending support issues to.
        /// </summary>
        [JsonProperty("support_address")]
        [STJS.JsonPropertyName("support_address")]
        public AddressOptions SupportAddress { get; set; }

        /// <summary>
        /// A publicly available email address for sending support issues to.
        /// </summary>
        [JsonProperty("support_email")]
        [STJS.JsonPropertyName("support_email")]
        public string SupportEmail { get; set; }

        /// <summary>
        /// A publicly available phone number to call with support issues.
        /// </summary>
        [JsonProperty("support_phone")]
        [STJS.JsonPropertyName("support_phone")]
        public string SupportPhone { get; set; }

        /// <summary>
        /// A publicly available website for handling support issues.
        /// </summary>
        [JsonProperty("support_url")]
        [STJS.JsonPropertyName("support_url")]
        public string SupportUrl { get; set; }

        /// <summary>
        /// The business's publicly available website.
        /// </summary>
        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
