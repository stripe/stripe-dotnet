namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class RefundCreateOptions : BaseOptions
    {
        /// <summary>
        /// A positive integer in cents representing how much of this charge to refund. Can refund
        /// only up to the remaining, unrefunded amount of the charge.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// REQUIRED. The identifier of the charge to refund.
        /// </summary>
        [JsonProperty("charge")]
        public string ChargeId { get; set; }

        /// <summary>
        /// A set of key-value pairs that you can attach to a <c>Refund</c> object. This can be
        /// useful for storing additional information about the refund in a structured format. You
        /// can unset individual keys if you POST an empty value for that key. You can clear all
        /// keys if you POST an empty value for <c>metadata</c>
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// String indicating the reason for the refund. If set, possible values are
        /// <c>duplicate</c>, <c>fraudulent</c>, and <c>requested_by_customer</c>. If you believe
        /// the charge to be fraudulent, specifying <c>fraudulent</c> as the reason will add the
        /// associated card and email to your
        /// <see href="https://stripe.com/docs/radar/lists">blocklists</see>, and will also help us
        /// improve our fraud detection algorithms.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Boolean indicating whether the application fee should be refunded when refunding this
        /// charge. If a full charge refund is given, the full application fee will be refunded.
        /// Otherwise, the application fee will be refunded in an amount proportional to the amount
        /// of the charge refunded.
        /// An application fee can be refunded only by the application that created the charge.
        /// </summary>
        [JsonProperty("refund_application_fee")]
        public bool? RefundApplicationFee { get; set; }

        /// <summary>
        /// Boolean indicating whether the transfer should be reversed when refunding this charge.
        /// The transfer will be reversed proportionally to the amount being refunded (either the
        /// entire or partial amount).
        /// A transfer can be reversed only by the application that created the charge.
        /// </summary>
        [JsonProperty("reverse_transfer")]
        public bool? ReverseTransfer { get; set; }
    }
}
