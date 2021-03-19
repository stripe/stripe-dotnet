// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CapabilityRequirements : StripeEntity<CapabilityRequirements>
    {
        /// <summary>
        /// The date the fields in <c>currently_due</c> must be collected by to keep the capability
        /// enabled for the account.
        /// </summary>
        [JsonProperty("current_deadline")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CurrentDeadline { get; set; }

        /// <summary>
        /// The fields that need to be collected to keep the capability enabled. If not collected by
        /// the <c>current_deadline</c>, these fields appear in <c>past_due</c> as well, and the
        /// capability is disabled.
        /// </summary>
        [JsonProperty("currently_due")]
        public List<string> CurrentlyDue { get; set; }

        /// <summary>
        /// If the capability is disabled, this string describes why. Possible values are
        /// <c>requirement.fields_needed</c>, <c>pending.onboarding</c>, <c>pending.review</c>,
        /// <c>rejected_fraud</c>, <c>rejected.unsupported_business</c> or <c>rejected.other</c>.
        ///
        /// <c>rejected.unsupported_business</c> means that the account's business is not supported
        /// by the capability. For example, payment methods may restrict the businesses they support
        /// in their terms of service:.
        ///
        /// - <a href="https://stripe.com/afterpay-clearpay/legal#restricted-businesses">Afterpay
        /// Clearpay's terms of service</a>.
        ///
        /// If you believe that the rejection is in error, please contact support@stripe.com for
        /// assistance.
        /// </summary>
        [JsonProperty("disabled_reason")]
        public string DisabledReason { get; set; }

        /// <summary>
        /// The fields that are <c>currently_due</c> and need to be collected again because
        /// validation or verification failed for some reason.
        /// </summary>
        [JsonProperty("errors")]
        public List<AccountRequirementsError> Errors { get; set; }

        /// <summary>
        /// The fields that need to be collected assuming all volume thresholds are reached. As they
        /// become required, these fields appear in <c>currently_due</c> as well, and the
        /// <c>current_deadline</c> is set.
        /// </summary>
        [JsonProperty("eventually_due")]
        public List<string> EventuallyDue { get; set; }

        /// <summary>
        /// The fields that weren't collected by the <c>current_deadline</c>. These fields need to
        /// be collected to enable the capability for the account.
        /// </summary>
        [JsonProperty("past_due")]
        public List<string> PastDue { get; set; }

        /// <summary>
        /// Fields that may become required depending on the results of verification or review. An
        /// empty array unless an asynchronous verification is pending. If verification fails, the
        /// fields in this array become required and move to <c>currently_due</c> or
        /// <c>past_due</c>.
        /// </summary>
        [JsonProperty("pending_verification")]
        public List<string> PendingVerification { get; set; }
    }
}
