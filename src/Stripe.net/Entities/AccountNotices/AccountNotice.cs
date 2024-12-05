// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// A notice to a Connected account. Notice can be sent by Stripe on your behalf or you can
    /// opt to send the notices yourself.
    ///
    /// See the <a
    /// href="https://stripe.com/docs/issuing/compliance-us/issuing-regulated-customer-notices">guide
    /// to send notices</a> to your connected accounts.
    /// </summary>
    public class AccountNotice : StripeEntity<AccountNotice>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// When present, the deadline for sending the notice to meet the relevant regulations.
        /// </summary>
        [JsonProperty("deadline")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Deadline { get; set; }

        /// <summary>
        /// Information about the email when sent.
        /// </summary>
        [JsonProperty("email")]
        public AccountNoticeEmail Email { get; set; }

        /// <summary>
        /// Information about objects related to the notice.
        /// </summary>
        [JsonProperty("linked_objects")]
        public AccountNoticeLinkedObjects LinkedObjects { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Reason the notice is being sent. The reason determines what copy the notice must
        /// contain. See the <a
        /// href="https://stripe.com/docs/issuing/compliance-us/issuing-regulated-customer-notices">regulated
        /// customer notices</a> guide. All reasons might not apply to your integration, and Stripe
        /// might add new reasons in the future, so we recommend an internal warning when you
        /// receive an unknown reason.
        /// One of: <c>issuing.account_closed_for_inactivity</c>,
        /// <c>issuing.account_closed_for_not_providing_business_model_clarification</c>,
        /// <c>issuing.account_closed_for_not_providing_url_clarification</c>,
        /// <c>issuing.account_closed_for_not_providing_use_case_clarification</c>,
        /// <c>issuing.account_closed_for_terms_of_service_violation</c>,
        /// <c>issuing.application_rejected_for_failure_to_verify</c>,
        /// <c>issuing.credit_application_rejected</c>,
        /// <c>issuing.credit_increase_application_rejected</c>,
        /// <c>issuing.credit_limit_decreased</c>, <c>issuing.credit_line_closed</c>,
        /// <c>issuing.dispute_lost</c>, <c>issuing.dispute_submitted</c>, or
        /// <c>issuing.dispute_won</c>.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Date when the notice was sent. When absent, you must send the notice, update the content
        /// of the email and date when it was sent.
        /// </summary>
        [JsonProperty("sent_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? SentAt { get; set; }
    }
}
