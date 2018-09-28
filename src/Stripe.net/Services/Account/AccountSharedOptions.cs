namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public abstract class AccountSharedOptions : BaseOptions, ISupportMetadata
    {
        [FormProperty("account_token")]
        public string AccountToken { get; set; }

        [FormProperty("business_logo")]
        public string BusinessLogoFileId { get; set; }

        [FormProperty("business_name")]
        public string BusinessName { get; set; }

        [FormProperty("business_primary_color")]
        public string BusinessPrimaryColor { get; set; }

        [FormProperty("business_url")]
        public string BusinessUrl { get; set; }

        [FormProperty("debit_negative_balances")]
        public bool? DebitNegativeBalances { get; set; }

        [FormProperty("decline_charge_on[cvc_failure]")]
        public bool? DeclineChargeOnCvcFailure { get; set; }

        [FormProperty("decline_charge_on[avs_failure]")]
        public bool? DeclineChargeOnAvsFailure { get; set; }

        [FormProperty("default_currency")]
        public string DefaultCurrency { get; set; }

        [FormProperty("email")]
        public string Email { get; set; }

        [FormProperty("external_account")]
        public string ExternalAccountId { get; set; }

        [FormProperty("external_account")]
        public AccountCardOptions ExternalCardAccount { get; set; }

        [FormProperty("external_account")]
        public AccountBankAccountOptions ExternalBankAccount { get; set; }

        [FormProperty("legal_entity")]
        public AccountLegalEntityOptions LegalEntity { get; set; }

        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [FormProperty("product_description")]
        public string ProductDescription { get; set; }

        [FormProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [FormProperty("payout_statement_descriptor")]
        public string PayoutStatementDescriptor { get; set; }

        [FormProperty("support_email")]
        public string SupportEmail { get; set; }

        [FormProperty("support_phone")]
        public string SupportPhone { get; set; }

        [FormProperty("support_url")]
        public string SupportUrl { get; set; }

        #region Tos Acceptance

        [FormProperty("tos_acceptance[date]")]
        public DateTime? TosAcceptanceDate { get; set; }

        [FormProperty("tos_acceptance[ip]")]
        public string TosAcceptanceIp { get; set; }

        [FormProperty("tos_acceptance[user_agent]")]
        public string TosAcceptanceUserAgent { get; set; }

        #endregion

        #region Transfer Schedule

        [FormProperty("payout_schedule[delay_days]")]
        public string TransferScheduleDelayDays { get; set; }

        [FormProperty("payout_schedule[interval]")]
        public string TransferScheduleInterval { get; set; }

        [FormProperty("payout_schedule[monthly_anchor]")]
        public string TransferScheduleMonthlyAnchor { get; set; }

        [FormProperty("payout_schedule[weekly_anchor]")]
        public string TransferScheduleWeeklyAnchor { get; set; }

        #endregion
    }
}
