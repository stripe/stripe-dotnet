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
        /// Date by which the fields in <c>currently_due</c> must be collected to keep the
        /// capability enabled for the account. These fields may disable the capability sooner if
        /// the next threshold is reached before they are collected.
        /// </summary>
        [JsonProperty("current_deadline")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CurrentDeadline { get; set; }

        /// <summary>
        /// Fields that need to be collected to keep the capability enabled. If not collected by
        /// <c>current_deadline</c>, these fields appear in <c>past_due</c> as well, and the
        /// capability is disabled.
        /// </summary>
        [JsonProperty("currently_due")]
        public List<string> CurrentlyDue { get; set; }

        /// <summary>
        /// If the capability is disabled, this string describes why. Can be
        /// <c>requirements.past_due</c>, <c>requirements.pending_verification</c>, <c>listed</c>,
        /// <c>platform_paused</c>, <c>rejected.fraud</c>, <c>rejected.listed</c>,
        /// <c>rejected.terms_of_service</c>, <c>rejected.other</c>, <c>under_review</c>, or
        /// <c>other</c>.
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
        /// Fields that are <c>currently_due</c> and need to be collected again because validation
        /// or verification failed.
        /// </summary>
        [JsonProperty("errors")]
        public List<AccountRequirementsError> Errors { get; set; }

        /// <summary>
        /// Fields that need to be collected assuming all volume thresholds are reached. As they
        /// become required, they appear in <c>currently_due</c> as well, and
        /// <c>current_deadline</c> becomes set.
        /// </summary>
        [JsonProperty("eventually_due")]
        public List<string> EventuallyDue { get; set; }

        /// <summary>
        /// Fields that weren't collected by <c>current_deadline</c>. These fields need to be
        /// collected to enable the capability on the account.
        /// </summary>
        [JsonProperty("past_due")]
        public List<string> PastDue { get; set; }

        /// <summary>
        /// Fields that may become required depending on the results of verification or review. Will
        /// be an empty array unless an asynchronous verification is pending. If verification fails,
        /// these fields move to <c>eventually_due</c>, <c>currently_due</c>, or <c>past_due</c>.
        /// </summary>
        [JsonProperty("pending_verification")]
        public List<string> PendingVerification { get; set; }
    }
}
