// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CreditUnderwritingRecordDecisionApplicationRejected : StripeEntity<CreditUnderwritingRecordDecisionApplicationRejected>
    {
        /// <summary>
        /// Details about the <c>reasons.other</c> when present.
        /// </summary>
        [JsonProperty("reason_other_explanation")]
        public string ReasonOtherExplanation { get; set; }

        /// <summary>
        /// List of reasons why the application was rejected up to 4 reasons, in order of
        /// importance.
        /// One of: <c>applicant_is_not_beneficial_owner</c>, <c>applicant_too_young</c>,
        /// <c>application_is_not_beneficial_owner</c>, <c>bankruptcy</c>,
        /// <c>business_size_too_small</c>, <c>current_account_tier_ineligible</c>,
        /// <c>customer_already_exists</c>, <c>customer_requested_account_closure</c>,
        /// <c>debt_to_cash_balance_ratio_too_high</c>, <c>debt_to_equity_ratio_too_high</c>,
        /// <c>delinquent_credit_obligations</c>, <c>dispute_rate_too_high</c>,
        /// <c>duration_of_residence</c>, <c>excessive_income_or_revenue_obligations</c>,
        /// <c>expenses_to_cash_balance_ratio_too_high</c>, <c>foreclosure_or_repossession</c>,
        /// <c>frozen_file_at_credit_bureau</c>, <c>garnishment_or_attachment</c>,
        /// <c>government_loan_program_criteria</c>, <c>high_concentration_of_clients</c>,
        /// <c>incomplete_application</c>, <c>inconsistent_monthly_revenues</c>,
        /// <c>insufficient_account_history_with_platform</c>,
        /// <c>insufficient_bank_account_history</c>, <c>insufficient_cash_balance</c>,
        /// <c>insufficient_cash_flow</c>, <c>insufficient_collateral</c>,
        /// <c>insufficient_credit_experience</c>, <c>insufficient_deposits</c>,
        /// <c>insufficient_income</c>, <c>insufficient_period_in_operation</c>,
        /// <c>insufficient_revenue</c>, <c>insufficient_social_media_performance</c>,
        /// <c>insufficient_trade_credit_insurance</c>, <c>invalid_business_license</c>,
        /// <c>late_payment_history_reported_to_bureau</c>,
        /// <c>lien_collection_action_or_judgement</c>, <c>negative_public_information</c>,
        /// <c>no_credit_file</c>, <c>other</c>, <c>outside_supported_country</c>,
        /// <c>outside_supported_state</c>, <c>prior_or_current_legal_action</c>,
        /// <c>prohibited_industry</c>, <c>rate_of_cash_balance_fluctuation_too_high</c>,
        /// <c>recent_inquiries_on_business_credit_report</c>,
        /// <c>removal_of_bank_account_connection</c>, <c>revenue_discrepancy</c>,
        /// <c>runway_too_short</c>, <c>suspected_fraud</c>,
        /// <c>too_many_non_sufficient_funds_or_overdrafts</c>, <c>unable_to_verify_address</c>,
        /// <c>unable_to_verify_identity</c>, <c>unable_to_verify_income_or_revenue</c>,
        /// <c>unprofitable</c>, or <c>unsupportable_business_type</c>.
        /// </summary>
        [JsonProperty("reasons")]
        public List<string> Reasons { get; set; }
    }
}
