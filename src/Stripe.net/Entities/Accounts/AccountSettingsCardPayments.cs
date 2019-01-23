namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountSettingsCardPayments : StripeEntity<AccountSettingsCardPayments>
    {
        /// <summary>
        /// Automatically declines certain charge types regardless of whether the card issuer
        /// accepted or declined the charge.
        /// </summary>
        [JsonProperty("decline_on")]
        public AccountSettingsDeclineOn DeclineOn { get; set; }

        /// <summary>
        /// The default text that appears on credit card statements when a charge is made. This
        /// field prefixes any dynamic <c>statement_descriptor</c> specified on the charge.
        /// <c>statement_descriptor_prefix</c> is useful for maximizing descriptor space for
        /// the dynamic portion.
        /// </summary>
        [JsonProperty("statement_descriptor_prefix")]
        public string StatementDescriptorPrefix { get; set; }
    }
}
