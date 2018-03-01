using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public abstract class StripeAccountSharedOptions : StripeBaseOptions, ISupportMetadata
    {
        [JsonProperty("business_logo")]
        public string BusinessLogoFileId { get; set; }

        [JsonProperty("business_name")]
        public string BusinessName { get; set; }

        [JsonProperty("business_primary_color")]
        public string BusinessPrimaryColor { get; set; }

        [JsonProperty("business_url")]
        public string BusinessUrl { get; set; }

        [JsonProperty("debit_negative_balances")]
        public bool? DebitNegativeBalances { get; set; }

        [JsonProperty("decline_charge_on[cvc_failure]")]
        public bool? DeclineChargeOnCvcFailure { get; set; }

        [JsonProperty("decline_charge_on[avs_failure]")]
        public bool? DeclineChargeOnAvsFailure { get; set; }

        [JsonProperty("default_currency")]
        public string DefaultCurrency { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("external_account")]
        public StripeAccountCardOptions ExternalCardAccount { get; set; }

        [JsonProperty("external_account")]
        public StripeAccountBankAccountOptions ExternalBankAccount { get; set; }

        [JsonProperty("legal_entity")]
        public StripeAccountLegalEntityOptions LegalEntity { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("product_description")]
        public string ProductDescription { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }
        
        [JsonProperty("payout_statement_descriptor")]
        public string PayoutStatementDescriptor { get; set; }

        [JsonProperty("support_email")]
        public string SupportEmail { get; set; }

        [JsonProperty("support_phone")]
        public string SupportPhone { get; set; }

        [JsonProperty("support_url")]
        public string SupportUrl { get; set; }

        #region Tos Acceptance

        public DateTime? TosAcceptanceDate { get; set; }

        [JsonProperty("tos_acceptance[date]")]
        internal long? TosAcceptanceDateInternal
        {
            get
            {
                if (!TosAcceptanceDate.HasValue) return null;

                return EpochTime.ConvertDateTimeToEpoch(TosAcceptanceDate.Value);
            }
        }

        [JsonProperty("tos_acceptance[ip]")]
        public string TosAcceptanceIp { get; set; }

        [JsonProperty("tos_acceptance[user_agent]")]
        public string TosAcceptanceUserAgent { get; set; }

        #endregion

        #region Transfer Schedule

        [JsonProperty("payout_schedule[delay_days]")]
        public string TransferScheduleDelayDays { get; set; }

        [JsonProperty("payout_schedule[interval]")]
        public string TransferScheduleInterval { get; set; }

        [JsonProperty("payout_schedule[monthly_anchor]")]
        public string TransferScheduleMonthlyAnchor { get; set; }

        [JsonProperty("payout_schedule[weekly_anchor]")]
        public string TransferScheduleWeeklyAnchor { get; set; }

        #endregion
    }
}
