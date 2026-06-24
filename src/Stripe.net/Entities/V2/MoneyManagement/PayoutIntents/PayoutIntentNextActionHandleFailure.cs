// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PayoutIntentNextActionHandleFailure : StripeEntity<PayoutIntentNextActionHandleFailure>
    {
        /// <summary>
        /// Open Enum. The reason for the failure.
        /// One of: <c>account_not_configured_as_recipient</c>,
        /// <c>currency_not_supported_for_financial_account_balance</c>,
        /// <c>feature_not_active_for_recipient</c>, <c>fx_rate_drift_exceeded_after_review</c>,
        /// <c>insufficient_funds</c>, <c>payout_method_account_type_incorrect</c>,
        /// <c>payout_method_amount_limit_exceeded</c>, <c>payout_method_canceled_by_customer</c>,
        /// <c>payout_method_closed</c>, <c>payout_method_currency_unsupported</c>,
        /// <c>payout_method_declined</c>, <c>payout_method_does_not_exist</c>,
        /// <c>payout_method_expired</c>, <c>payout_method_holder_address_incorrect</c>,
        /// <c>payout_method_holder_details_incorrect</c>,
        /// <c>payout_method_holder_name_incorrect</c>, <c>payout_method_invalid_account_number</c>,
        /// <c>payout_method_restricted</c>, <c>payout_method_unsupported</c>,
        /// <c>payout_method_usage_frequency_limit_exceeded</c>, <c>recalled</c>,
        /// <c>review_rejected</c>, <c>to_destination_invalid</c>, or <c>unknown_failure</c>.
        /// </summary>
        [JsonProperty("failure_reason")]
        [STJS.JsonPropertyName("failure_reason")]
        public string FailureReason { get; set; }
    }
}
