namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountSettingsSepaDebitPayments : StripeEntity<AccountSettingsSepaDebitPayments>
    {
        /// <summary>
        /// SEPA creditor identifier that identifies the company making the payment.
        /// </summary>
        [JsonProperty("creditor_id")]
        public string CreditorId { get; set; }
    }
}
