// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class TokenNetworkDataWalletProvider : StripeEntity<TokenNetworkDataWalletProvider>
    {
        /// <summary>
        /// The wallet provider-given account ID of the digital wallet the token belongs to.
        /// </summary>
        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// An evaluation on the trustworthiness of the wallet account between 1 and 5. A higher
        /// score indicates more trustworthy.
        /// </summary>
        [JsonProperty("account_trust_score")]
        public long AccountTrustScore { get; set; }

        /// <summary>
        /// The method used for tokenizing a card.
        /// One of: <c>app</c>, <c>manual</c>, <c>on_file</c>, or <c>other</c>.
        /// </summary>
        [JsonProperty("card_number_source")]
        public string CardNumberSource { get; set; }

        [JsonProperty("cardholder_address")]
        public TokenNetworkDataWalletProviderCardholderAddress CardholderAddress { get; set; }

        /// <summary>
        /// The name of the cardholder tokenizing the card.
        /// </summary>
        [JsonProperty("cardholder_name")]
        public string CardholderName { get; set; }

        /// <summary>
        /// An evaluation on the trustworthiness of the device. A higher score indicates more
        /// trustworthy.
        /// </summary>
        [JsonProperty("device_trust_score")]
        public long DeviceTrustScore { get; set; }

        /// <summary>
        /// The hashed email address of the cardholder's account with the wallet provider.
        /// </summary>
        [JsonProperty("hashed_account_email_address")]
        public string HashedAccountEmailAddress { get; set; }

        /// <summary>
        /// The reasons for suggested tokenization given by the card network.
        /// One of: <c>account_card_too_new</c>, <c>account_recently_changed</c>,
        /// <c>account_too_new</c>, <c>account_too_new_since_launch</c>, <c>additional_device</c>,
        /// <c>data_expired</c>, <c>defer_id_v_decision</c>, <c>device_recently_lost</c>,
        /// <c>good_activity_history</c>, <c>has_suspended_tokens</c>, <c>high_risk</c>,
        /// <c>inactive_account</c>, <c>long_account_tenure</c>, <c>low_account_score</c>,
        /// <c>low_device_score</c>, <c>low_phone_number_score</c>, <c>network_service_error</c>,
        /// <c>outside_home_territory</c>, <c>provisioning_cardholder_mismatch</c>,
        /// <c>provisioning_device_and_cardholder_mismatch</c>, <c>provisioning_device_mismatch</c>,
        /// <c>same_device_no_prior_authentication</c>,
        /// <c>same_device_successful_prior_authentication</c>, <c>software_update</c>,
        /// <c>suspicious_activity</c>, <c>too_many_different_cardholders</c>,
        /// <c>too_many_recent_attempts</c>, or <c>too_many_recent_tokens</c>.
        /// </summary>
        [JsonProperty("reason_codes")]
        public List<string> ReasonCodes { get; set; }

        /// <summary>
        /// The recommendation on responding to the tokenization request.
        /// One of: <c>approve</c>, <c>decline</c>, or <c>require_auth</c>.
        /// </summary>
        [JsonProperty("suggested_decision")]
        public string SuggestedDecision { get; set; }

        /// <summary>
        /// The version of the standard for mapping reason codes followed by the wallet provider.
        /// </summary>
        [JsonProperty("suggested_decision_version")]
        public string SuggestedDecisionVersion { get; set; }
    }
}
