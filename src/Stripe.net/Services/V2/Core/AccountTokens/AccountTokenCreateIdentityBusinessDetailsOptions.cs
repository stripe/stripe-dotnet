// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountTokenCreateIdentityBusinessDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The business registration address of the business entity.
        /// </summary>
        [JsonProperty("address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
#endif
        public AddressJapanOptions Address { get; set; }

        /// <summary>
        /// The business gross annual revenue for its preceding fiscal year.
        /// </summary>
        [JsonProperty("annual_revenue")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("annual_revenue")]
#endif
        public AccountTokenCreateIdentityBusinessDetailsAnnualRevenueOptions AnnualRevenue { get; set; }

        /// <summary>
        /// A document verifying the business.
        /// </summary>
        [JsonProperty("documents")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("documents")]
#endif
        public AccountTokenCreateIdentityBusinessDetailsDocumentsOptions Documents { get; set; }

        /// <summary>
        /// Estimated maximum number of workers currently engaged by the business (including
        /// employees, contractors, and vendors).
        /// </summary>
        [JsonProperty("estimated_worker_count")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("estimated_worker_count")]
#endif
        public long? EstimatedWorkerCount { get; set; }

        /// <summary>
        /// The ID numbers of a business entity.
        /// </summary>
        [JsonProperty("id_numbers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id_numbers")]
#endif
        public List<AccountTokenCreateIdentityBusinessDetailsIdNumberOptions> IdNumbers { get; set; }

        /// <summary>
        /// An estimate of the monthly revenue of the business.
        /// </summary>
        [JsonProperty("monthly_estimated_revenue")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("monthly_estimated_revenue")]
#endif
        public AccountTokenCreateIdentityBusinessDetailsMonthlyEstimatedRevenueOptions MonthlyEstimatedRevenue { get; set; }

        /// <summary>
        /// The phone number of the Business Entity.
        /// </summary>
        [JsonProperty("phone")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("phone")]
#endif
        public string Phone { get; set; }

        /// <summary>
        /// The business legal name.
        /// </summary>
        [JsonProperty("registered_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("registered_name")]
#endif
        public string RegisteredName { get; set; }

        /// <summary>
        /// The business registration address of the business entity in non latin script.
        /// </summary>
        [JsonProperty("script_addresses")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("script_addresses")]
#endif
        public AccountTokenCreateIdentityBusinessDetailsScriptAddressesOptions ScriptAddresses { get; set; }

        /// <summary>
        /// The business legal name in non latin script.
        /// </summary>
        [JsonProperty("script_names")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("script_names")]
#endif
        public AccountTokenCreateIdentityBusinessDetailsScriptNamesOptions ScriptNames { get; set; }

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
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("structure")]
#endif
        public string Structure { get; set; }
    }
}
