// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountIdentityBusinessDetails : StripeEntity<AccountIdentityBusinessDetails>
    {
        /// <summary>
        /// The company’s primary address.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public AccountIdentityBusinessDetailsAddress Address { get; set; }

        /// <summary>
        /// The business gross annual revenue for its preceding fiscal year.
        /// </summary>
        [JsonProperty("annual_revenue")]
        [STJS.JsonPropertyName("annual_revenue")]
        public AccountIdentityBusinessDetailsAnnualRevenue AnnualRevenue { get; set; }

        /// <summary>
        /// Documents that may be submitted to satisfy various informational requests.
        /// </summary>
        [JsonProperty("documents")]
        [STJS.JsonPropertyName("documents")]
        public AccountIdentityBusinessDetailsDocuments Documents { get; set; }

        /// <summary>
        /// Estimated maximum number of workers currently engaged by the business (including
        /// employees, contractors, and vendors).
        /// </summary>
        [JsonProperty("estimated_worker_count")]
        [STJS.JsonPropertyName("estimated_worker_count")]
        public long? EstimatedWorkerCount { get; set; }

        /// <summary>
        /// The provided ID numbers of a business entity.
        /// </summary>
        [JsonProperty("id_numbers")]
        [STJS.JsonPropertyName("id_numbers")]
        public List<AccountIdentityBusinessDetailsIdNumber> IdNumbers { get; set; }

        /// <summary>
        /// An estimate of the monthly revenue of the business. Only accepted for accounts in Brazil
        /// and India.
        /// </summary>
        [JsonProperty("monthly_estimated_revenue")]
        [STJS.JsonPropertyName("monthly_estimated_revenue")]
        public AccountIdentityBusinessDetailsMonthlyEstimatedRevenue MonthlyEstimatedRevenue { get; set; }

        /// <summary>
        /// The company’s phone number (used for verification).
        /// </summary>
        [JsonProperty("phone")]
        [STJS.JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The business legal name.
        /// </summary>
        [JsonProperty("registered_name")]
        [STJS.JsonPropertyName("registered_name")]
        public string RegisteredName { get; set; }

        /// <summary>
        /// When the business was incorporated or registered.
        /// </summary>
        [JsonProperty("registration_date")]
        [STJS.JsonPropertyName("registration_date")]
        public AccountIdentityBusinessDetailsRegistrationDate RegistrationDate { get; set; }

        /// <summary>
        /// The business registration address of the business entity in non latin script.
        /// </summary>
        [JsonProperty("script_addresses")]
        [STJS.JsonPropertyName("script_addresses")]
        public AccountIdentityBusinessDetailsScriptAddresses ScriptAddresses { get; set; }

        /// <summary>
        /// The business legal name in non latin script.
        /// </summary>
        [JsonProperty("script_names")]
        [STJS.JsonPropertyName("script_names")]
        public AccountIdentityBusinessDetailsScriptNames ScriptNames { get; set; }

        /// <summary>
        /// The category identifying the legal structure of the business.
        /// One of: <c>cooperative</c>, <c>free_zone_establishment</c>, <c>free_zone_llc</c>,
        /// <c>governmental_unit</c>, <c>government_instrumentality</c>,
        /// <c>incorporated_association</c>, <c>incorporated_non_profit</c>,
        /// <c>incorporated_partnership</c>, <c>limited_liability_partnership</c>, <c>llc</c>,
        /// <c>multi_member_llc</c>, <c>private_company</c>, <c>private_corporation</c>,
        /// <c>private_partnership</c>, <c>public_company</c>, <c>public_corporation</c>,
        /// <c>public_listed_corporation</c>, <c>public_partnership</c>, <c>registered_charity</c>,
        /// <c>single_member_llc</c>, <c>sole_establishment</c>, <c>sole_proprietorship</c>,
        /// <c>tax_exempt_government_instrumentality</c>, <c>trust</c>,
        /// <c>unincorporated_association</c>, <c>unincorporated_non_profit</c>, or
        /// <c>unincorporated_partnership</c>.
        /// </summary>
        [JsonProperty("structure")]
        [STJS.JsonPropertyName("structure")]
        public string Structure { get; set; }
    }
}
