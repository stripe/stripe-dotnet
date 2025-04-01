// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class AccountUpdateIdentityBusinessDetailsOptions : INestedOptions
    {
        [JsonProperty("address")]
        [JsonConverter(typeof(EmptyableConverter<AddressJapanOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<AddressJapanOptions>))]
#endif
        internal Emptyable<AddressJapanOptions> InternalAddress { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyAddress
        {
            get => this.InternalAddress?.Empty ?? false;
            set
            {
                this.InternalAddress ??= new Emptyable<AddressJapanOptions>();
                this.InternalAddress.Empty = value;
            }
        }

        /// <summary>
        /// The business registration address of the business entity.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public AddressJapanOptions Address
        {
            get => this.InternalAddress?.Value;
            set
            {
                this.InternalAddress ??= new Emptyable<AddressJapanOptions>();
                this.InternalAddress.Value = value;
            }
        }

        [JsonProperty("annual_revenue")]
        [JsonConverter(typeof(EmptyableConverter<AccountUpdateIdentityBusinessDetailsAnnualRevenueOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("annual_revenue")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<AccountUpdateIdentityBusinessDetailsAnnualRevenueOptions>))]
#endif
        internal Emptyable<AccountUpdateIdentityBusinessDetailsAnnualRevenueOptions> InternalAnnualRevenue { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyAnnualRevenue
        {
            get => this.InternalAnnualRevenue?.Empty ?? false;
            set
            {
                this.InternalAnnualRevenue ??= new Emptyable<AccountUpdateIdentityBusinessDetailsAnnualRevenueOptions>();
                this.InternalAnnualRevenue.Empty = value;
            }
        }

        /// <summary>
        /// The business gross annual revenue for its preceding fiscal year.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public AccountUpdateIdentityBusinessDetailsAnnualRevenueOptions AnnualRevenue
        {
            get => this.InternalAnnualRevenue?.Value;
            set
            {
                this.InternalAnnualRevenue ??= new Emptyable<AccountUpdateIdentityBusinessDetailsAnnualRevenueOptions>();
                this.InternalAnnualRevenue.Value = value;
            }
        }

        [JsonProperty("documents")]
        [JsonConverter(typeof(EmptyableConverter<AccountUpdateIdentityBusinessDetailsDocumentsOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("documents")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<AccountUpdateIdentityBusinessDetailsDocumentsOptions>))]
#endif
        internal Emptyable<AccountUpdateIdentityBusinessDetailsDocumentsOptions> InternalDocuments { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyDocuments
        {
            get => this.InternalDocuments?.Empty ?? false;
            set
            {
                this.InternalDocuments ??= new Emptyable<AccountUpdateIdentityBusinessDetailsDocumentsOptions>();
                this.InternalDocuments.Empty = value;
            }
        }

        /// <summary>
        /// A document verifying the business.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public AccountUpdateIdentityBusinessDetailsDocumentsOptions Documents
        {
            get => this.InternalDocuments?.Value;
            set
            {
                this.InternalDocuments ??= new Emptyable<AccountUpdateIdentityBusinessDetailsDocumentsOptions>();
                this.InternalDocuments.Value = value;
            }
        }

        [JsonProperty("doing_business_as")]
        [JsonConverter(typeof(EmptyableConverter<string>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("doing_business_as")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<string>))]
#endif
        internal Emptyable<string> InternalDoingBusinessAs { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyDoingBusinessAs
        {
            get => this.InternalDoingBusinessAs?.Empty ?? false;
            set
            {
                this.InternalDoingBusinessAs ??= new Emptyable<string>();
                this.InternalDoingBusinessAs.Empty = value;
            }
        }

        /// <summary>
        /// The name which is used by the business.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string DoingBusinessAs
        {
            get => this.InternalDoingBusinessAs?.Value;
            set
            {
                this.InternalDoingBusinessAs ??= new Emptyable<string>();
                this.InternalDoingBusinessAs.Value = value;
            }
        }

        [JsonProperty("estimated_worker_count")]
        [JsonConverter(typeof(EmptyableConverter<long?>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("estimated_worker_count")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<long?>))]
#endif
        internal Emptyable<long?> InternalEstimatedWorkerCount { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyEstimatedWorkerCount
        {
            get => this.InternalEstimatedWorkerCount?.Empty ?? false;
            set
            {
                this.InternalEstimatedWorkerCount ??= new Emptyable<long?>();
                this.InternalEstimatedWorkerCount.Empty = value;
            }
        }

        /// <summary>
        /// An estimated upper bound of employees, contractors, vendors, etc. currently working for
        /// the business.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public long? EstimatedWorkerCount
        {
            get => this.InternalEstimatedWorkerCount?.Value;
            set
            {
                this.InternalEstimatedWorkerCount ??= new Emptyable<long?>();
                this.InternalEstimatedWorkerCount.Value = value;
            }
        }

        [JsonProperty("id_numbers")]
        [JsonConverter(typeof(EmptyableConverter<List<AccountUpdateIdentityBusinessDetailsIdNumberOptions>>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id_numbers")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<List<AccountUpdateIdentityBusinessDetailsIdNumberOptions>>))]
#endif
        internal Emptyable<List<AccountUpdateIdentityBusinessDetailsIdNumberOptions>> InternalIdNumbers { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyIdNumbers
        {
            get => this.InternalIdNumbers?.Empty ?? false;
            set
            {
                this.InternalIdNumbers ??= new Emptyable<List<AccountUpdateIdentityBusinessDetailsIdNumberOptions>>();
                this.InternalIdNumbers.Empty = value;
            }
        }

        /// <summary>
        /// The ID numbers of a business entity.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public List<AccountUpdateIdentityBusinessDetailsIdNumberOptions> IdNumbers
        {
            get => this.InternalIdNumbers?.Value;
            set
            {
                this.InternalIdNumbers ??= new Emptyable<List<AccountUpdateIdentityBusinessDetailsIdNumberOptions>>();
                this.InternalIdNumbers.Value = value;
            }
        }

        [JsonProperty("monthly_estimated_revenue")]
        [JsonConverter(typeof(EmptyableConverter<AccountUpdateIdentityBusinessDetailsMonthlyEstimatedRevenueOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("monthly_estimated_revenue")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<AccountUpdateIdentityBusinessDetailsMonthlyEstimatedRevenueOptions>))]
#endif
        internal Emptyable<AccountUpdateIdentityBusinessDetailsMonthlyEstimatedRevenueOptions> InternalMonthlyEstimatedRevenue { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyMonthlyEstimatedRevenue
        {
            get => this.InternalMonthlyEstimatedRevenue?.Empty ?? false;
            set
            {
                this.InternalMonthlyEstimatedRevenue ??= new Emptyable<AccountUpdateIdentityBusinessDetailsMonthlyEstimatedRevenueOptions>();
                this.InternalMonthlyEstimatedRevenue.Empty = value;
            }
        }

        /// <summary>
        /// An estimate of the monthly revenue of the business.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public AccountUpdateIdentityBusinessDetailsMonthlyEstimatedRevenueOptions MonthlyEstimatedRevenue
        {
            get => this.InternalMonthlyEstimatedRevenue?.Value;
            set
            {
                this.InternalMonthlyEstimatedRevenue ??= new Emptyable<AccountUpdateIdentityBusinessDetailsMonthlyEstimatedRevenueOptions>();
                this.InternalMonthlyEstimatedRevenue.Value = value;
            }
        }

        [JsonProperty("phone")]
        [JsonConverter(typeof(EmptyableConverter<string>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("phone")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<string>))]
#endif
        internal Emptyable<string> InternalPhone { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyPhone
        {
            get => this.InternalPhone?.Empty ?? false;
            set
            {
                this.InternalPhone ??= new Emptyable<string>();
                this.InternalPhone.Empty = value;
            }
        }

        /// <summary>
        /// The phone number of the Business Entity.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string Phone
        {
            get => this.InternalPhone?.Value;
            set
            {
                this.InternalPhone ??= new Emptyable<string>();
                this.InternalPhone.Value = value;
            }
        }

        [JsonProperty("product_description")]
        [JsonConverter(typeof(EmptyableConverter<string>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("product_description")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<string>))]
#endif
        internal Emptyable<string> InternalProductDescription { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyProductDescription
        {
            get => this.InternalProductDescription?.Empty ?? false;
            set
            {
                this.InternalProductDescription ??= new Emptyable<string>();
                this.InternalProductDescription.Empty = value;
            }
        }

        /// <summary>
        /// Internal-only description of the product sold or service provided by the business. It’s
        /// used by Stripe for risk and underwriting purposes.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string ProductDescription
        {
            get => this.InternalProductDescription?.Value;
            set
            {
                this.InternalProductDescription ??= new Emptyable<string>();
                this.InternalProductDescription.Value = value;
            }
        }

        [JsonProperty("registered_name")]
        [JsonConverter(typeof(EmptyableConverter<string>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("registered_name")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<string>))]
#endif
        internal Emptyable<string> InternalRegisteredName { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyRegisteredName
        {
            get => this.InternalRegisteredName?.Empty ?? false;
            set
            {
                this.InternalRegisteredName ??= new Emptyable<string>();
                this.InternalRegisteredName.Empty = value;
            }
        }

        /// <summary>
        /// The business legal name.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string RegisteredName
        {
            get => this.InternalRegisteredName?.Value;
            set
            {
                this.InternalRegisteredName ??= new Emptyable<string>();
                this.InternalRegisteredName.Value = value;
            }
        }

        [JsonProperty("script_addresses")]
        [JsonConverter(typeof(EmptyableConverter<AccountUpdateIdentityBusinessDetailsScriptAddressesOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("script_addresses")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<AccountUpdateIdentityBusinessDetailsScriptAddressesOptions>))]
#endif
        internal Emptyable<AccountUpdateIdentityBusinessDetailsScriptAddressesOptions> InternalScriptAddresses { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyScriptAddresses
        {
            get => this.InternalScriptAddresses?.Empty ?? false;
            set
            {
                this.InternalScriptAddresses ??= new Emptyable<AccountUpdateIdentityBusinessDetailsScriptAddressesOptions>();
                this.InternalScriptAddresses.Empty = value;
            }
        }

        /// <summary>
        /// The business registration address of the business entity in non latin script.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public AccountUpdateIdentityBusinessDetailsScriptAddressesOptions ScriptAddresses
        {
            get => this.InternalScriptAddresses?.Value;
            set
            {
                this.InternalScriptAddresses ??= new Emptyable<AccountUpdateIdentityBusinessDetailsScriptAddressesOptions>();
                this.InternalScriptAddresses.Value = value;
            }
        }

        [JsonProperty("script_names")]
        [JsonConverter(typeof(EmptyableConverter<AccountUpdateIdentityBusinessDetailsScriptNamesOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("script_names")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<AccountUpdateIdentityBusinessDetailsScriptNamesOptions>))]
#endif
        internal Emptyable<AccountUpdateIdentityBusinessDetailsScriptNamesOptions> InternalScriptNames { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyScriptNames
        {
            get => this.InternalScriptNames?.Empty ?? false;
            set
            {
                this.InternalScriptNames ??= new Emptyable<AccountUpdateIdentityBusinessDetailsScriptNamesOptions>();
                this.InternalScriptNames.Empty = value;
            }
        }

        /// <summary>
        /// The business legal name in non latin script.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public AccountUpdateIdentityBusinessDetailsScriptNamesOptions ScriptNames
        {
            get => this.InternalScriptNames?.Value;
            set
            {
                this.InternalScriptNames ??= new Emptyable<AccountUpdateIdentityBusinessDetailsScriptNamesOptions>();
                this.InternalScriptNames.Value = value;
            }
        }

        [JsonProperty("structure")]
        [JsonConverter(typeof(EmptyableConverter<string>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("structure")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<string>))]
#endif
        internal Emptyable<string> InternalStructure { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyStructure
        {
            get => this.InternalStructure?.Empty ?? false;
            set
            {
                this.InternalStructure ??= new Emptyable<string>();
                this.InternalStructure.Empty = value;
            }
        }

        /// <summary>
        /// The category identifying the legal structure of the business.
        /// One of: <c>free_zone_establishment</c>, <c>free_zone_llc</c>, <c>governmental_unit</c>,
        /// <c>government_instrumentality</c>, <c>incorporated_non_profit</c>,
        /// <c>incorporated_partnership</c>, <c>llc</c>, <c>multi_member_llc</c>,
        /// <c>private_company</c>, <c>private_corporation</c>, <c>private_partnership</c>,
        /// <c>public_company</c>, <c>public_corporation</c>, <c>public_partnership</c>,
        /// <c>registered_charity</c>, <c>single_member_llc</c>, <c>sole_establishment</c>,
        /// <c>sole_proprietorship</c>, <c>tax_exempt_government_instrumentality</c>,
        /// <c>unincorporated_association</c>, <c>unincorporated_non_profit</c>, or
        /// <c>unincorporated_partnership</c>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string Structure
        {
            get => this.InternalStructure?.Value;
            set
            {
                this.InternalStructure ??= new Emptyable<string>();
                this.InternalStructure.Value = value;
            }
        }

        [JsonProperty("url")]
        [JsonConverter(typeof(EmptyableConverter<string>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("url")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<string>))]
#endif
        internal Emptyable<string> InternalUrl { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyUrl
        {
            get => this.InternalUrl?.Empty ?? false;
            set
            {
                this.InternalUrl ??= new Emptyable<string>();
                this.InternalUrl.Empty = value;
            }
        }

        /// <summary>
        /// The business's publicly available website.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string Url
        {
            get => this.InternalUrl?.Value;
            set
            {
                this.InternalUrl ??= new Emptyable<string>();
                this.InternalUrl.Value = value;
            }
        }
    }
}
