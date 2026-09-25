// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// An activity log records a single action performed on an account.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ActivityLog : StripeEntity<ActivityLog>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier of the activity log entry.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The actor that performed the action.
        /// </summary>
        [JsonProperty("actor")]
        [STJS.JsonPropertyName("actor")]
        public ActivityLogActor Actor { get; set; }

        /// <summary>
        /// The account on which the action was performed.
        /// </summary>
        [JsonProperty("context")]
        [STJS.JsonPropertyName("context")]
        public string Context { get; set; }

        /// <summary>
        /// Timestamp when the activity log entry was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Action-specific details of the activity log entry.
        /// </summary>
        [JsonProperty("details")]
        [STJS.JsonPropertyName("details")]
        public ActivityLogDetails Details { get; set; }

        /// <summary>
        /// Whether the action was performed in live mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The object related to the activity log entry.
        /// </summary>
        [JsonProperty("related_object")]
        [STJS.JsonPropertyName("related_object")]
        public ActivityLogRelatedObject RelatedObject { get; set; }

        /// <summary>
        /// The API request that instigated the action.
        /// </summary>
        [JsonProperty("request")]
        [STJS.JsonPropertyName("request")]
        public ActivityLogRequest Request { get; set; }

        /// <summary>
        /// The type of action that was performed.
        /// One of: <c>anomaly_detection_settings_updated</c>, <c>api_key_created</c>,
        /// <c>api_key_deleted</c>, <c>api_key_updated</c>, <c>api_key_viewed</c>,
        /// <c>issuing_activated</c>, <c>issuing_balance_transfer_created</c>,
        /// <c>issuing_cardholder_created</c>, <c>issuing_cardholder_updated</c>,
        /// <c>issuing_card_created</c>, <c>issuing_card_sensitive_details_viewed</c>,
        /// <c>issuing_card_updated</c>, <c>issuing_dispute_created</c>,
        /// <c>issuing_dispute_submitted</c>, <c>issuing_dispute_updated</c>,
        /// <c>manual_payouts_disabled</c>, <c>manual_payouts_enabled</c>,
        /// <c>payout_destination_added</c>, <c>payout_destination_removed</c>,
        /// <c>payout_destination_updated</c>, <c>payout_schedule_edits_disabled</c>,
        /// <c>payout_schedule_edits_enabled</c>, <c>scim_group_deleted</c>,
        /// <c>scim_group_member_added</c>, <c>scim_group_member_removed</c>,
        /// <c>scim_group_roles_updated</c>, <c>scim_group_updated</c>, <c>sso_domain_verified</c>,
        /// <c>sso_settings_created</c>, <c>sso_settings_deleted</c>, <c>sso_settings_updated</c>,
        /// <c>two_step_authentication_mandate_disabled</c>,
        /// <c>two_step_authentication_mandate_enabled</c>, <c>user_access_started</c>,
        /// <c>user_auth_challenge_failed</c>, <c>user_email_changed</c>,
        /// <c>user_email_verified</c>, <c>user_express_phone_number_changed</c>,
        /// <c>user_google_account_connected</c>, <c>user_google_account_disconnected</c>,
        /// <c>user_invite_accepted</c>, <c>user_invite_created</c>, <c>user_invite_deleted</c>,
        /// <c>user_passkey_added</c>, <c>user_passkey_removed</c>, <c>user_passkey_updated</c>,
        /// <c>user_passkey_upgraded</c>, <c>user_password_changed</c>,
        /// <c>user_password_initialized</c>, <c>user_password_reset_failed</c>,
        /// <c>user_password_reset_requested</c>, <c>user_password_reset_succeeded</c>,
        /// <c>user_roles_deleted</c>, <c>user_roles_updated</c>,
        /// <c>user_two_step_authentication_backup_code_used</c>,
        /// <c>user_two_step_authentication_method_added</c>,
        /// <c>user_two_step_authentication_method_removed</c>,
        /// <c>user_two_step_authentication_method_reset</c>,
        /// <c>user_two_step_authentication_method_updated</c>, or
        /// <c>user_two_step_authentication_reset_requested</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
