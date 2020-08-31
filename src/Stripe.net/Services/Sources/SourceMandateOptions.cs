namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceMandateOptions : INestedOptions
    {
        /// <summary>
        /// The parameters required to notify Stripe of a mandate acceptance or refusal by the
        /// customer.
        /// </summary>
        [JsonProperty("acceptance")]
        public SourceMandateAcceptanceOptions Acceptance { get; set; }

        /// <summary>
        /// The amount specified by the mandate. (Leave null for a mandate covering all amounts).
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// The currency specified by the mandate. (Must match <c>currency</c> of the source).
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The interval of debits permitted by the mandate. Either <c>one_time</c> (just permitting
        /// a single debit), <c>scheduled</c> (with debits on an agreed schedule or for
        /// clearly-defined events), or <c>variable</c>(for debits with any frequency).
        /// One of: <c>one_time</c>, <c>scheduled</c>, or <c>variable</c>.
        /// </summary>
        [JsonProperty("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// The method Stripe should use to notify the customer of upcoming debit instructions
        /// and/or mandate confirmation as required by the underlying debit network. Either
        /// <c>email</c> (an email is sent directly to the customer), <c>manual</c> (a
        /// <c>source.mandate_notification</c> event is sent to your webhooks endpoint and you
        /// should handle the notification) or <c>none</c> (the underlying debit network does not
        /// require any notification).
        /// One of: <c>deprecated_none</c>, <c>email</c>, <c>manual</c>, <c>none</c>, or
        /// <c>stripe_email</c>.
        /// </summary>
        [JsonProperty("notification_method")]
        public string NotificationMethod { get; set; }
    }
}
