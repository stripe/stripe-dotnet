// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationStorerOptions : INestedOptions
    {
        /// <summary>
        /// Capabilities to request on the Storer Configuration.
        /// </summary>
        [JsonProperty("capabilities")]
        [STJS.JsonPropertyName("capabilities")]
        public AccountCreateConfigurationStorerCapabilitiesOptions Capabilities { get; set; }

        /// <summary>
        /// List of high-risk activities the business is involved in.
        /// One of: <c>adult_entertainment</c>, <c>gambling</c>, <c>hold_client_funds</c>,
        /// <c>investment_services</c>, <c>lending_banking</c>,
        /// <c>marijuana_or_related_services</c>, <c>money_services</c>,
        /// <c>nicotine_tobacco_or_related_services</c>, <c>none</c>,
        /// <c>operate_foreign_exchange_virtual_currencies_brokerage_otc</c>,
        /// <c>pharmaceuticals</c>, <c>precious_metals_precious_stones_jewelry</c>,
        /// <c>safe_deposit_box_rentals</c>, <c>third_party_payment_processing</c>, or
        /// <c>weapons_firearms_and_explosives</c>.
        /// </summary>
        [JsonProperty("high_risk_activities")]
        [STJS.JsonPropertyName("high_risk_activities")]
        public List<string> HighRiskActivities { get; set; }

        /// <summary>
        /// Description of the high-risk activities the business offers.
        /// </summary>
        [JsonProperty("high_risk_activities_description")]
        [STJS.JsonPropertyName("high_risk_activities_description")]
        public string HighRiskActivitiesDescription { get; set; }

        /// <summary>
        /// Description of the money services offered by the business.
        /// </summary>
        [JsonProperty("money_services_description")]
        [STJS.JsonPropertyName("money_services_description")]
        public string MoneyServicesDescription { get; set; }

        /// <summary>
        /// Indicates whether the business operates in any prohibited countries.
        /// </summary>
        [JsonProperty("operates_in_prohibited_countries")]
        [STJS.JsonPropertyName("operates_in_prohibited_countries")]
        public bool? OperatesInProhibitedCountries { get; set; }

        /// <summary>
        /// Indicates whether the business participates in any regulated activity.
        /// </summary>
        [JsonProperty("participates_in_regulated_activity")]
        [STJS.JsonPropertyName("participates_in_regulated_activity")]
        public bool? ParticipatesInRegulatedActivity { get; set; }

        /// <summary>
        /// Primary purpose of the stored funds.
        /// One of: <c>charitable_donations</c>, <c>ecommerce_retail_payments</c>,
        /// <c>investment_purposes</c>, <c>other</c>, <c>payments_to_friends_or_family_abroad</c>,
        /// <c>payroll</c>, <c>personal_or_living_expenses</c>, <c>protect_wealth</c>,
        /// <c>purchase_goods_and_services</c>, <c>receive_payments_for_goods_and_services</c>,
        /// <c>tax_optimization</c>, <c>third_party_money_transmission</c>, or
        /// <c>treasury_management</c>.
        /// </summary>
        [JsonProperty("purpose_of_funds")]
        [STJS.JsonPropertyName("purpose_of_funds")]
        public string PurposeOfFunds { get; set; }

        /// <summary>
        /// Description of the purpose of the stored funds.
        /// </summary>
        [JsonProperty("purpose_of_funds_description")]
        [STJS.JsonPropertyName("purpose_of_funds_description")]
        public string PurposeOfFundsDescription { get; set; }

        /// <summary>
        /// Details of the regulated activity if the business participates in one.
        /// </summary>
        [JsonProperty("regulated_activity")]
        [STJS.JsonPropertyName("regulated_activity")]
        public AccountCreateConfigurationStorerRegulatedActivityOptions RegulatedActivity { get; set; }

        /// <summary>
        /// The source of funds for the business, e.g. profits, income, venture capital, etc.
        /// One of: <c>business_loans</c>, <c>grants</c>, <c>inter_company_funds</c>,
        /// <c>investment_proceeds</c>, <c>legal_settlement</c>, <c>owners_capital</c>,
        /// <c>pension_retirement</c>, <c>sales_of_assets</c>, <c>sales_of_goods_and_services</c>,
        /// <c>tax_refund</c>, <c>third_party_funds</c>, or <c>treasury_reserves</c>.
        /// </summary>
        [JsonProperty("source_of_funds")]
        [STJS.JsonPropertyName("source_of_funds")]
        public string SourceOfFunds { get; set; }

        /// <summary>
        /// Description of the source of funds for the business' account.
        /// </summary>
        [JsonProperty("source_of_funds_description")]
        [STJS.JsonPropertyName("source_of_funds_description")]
        public string SourceOfFundsDescription { get; set; }
    }
}
