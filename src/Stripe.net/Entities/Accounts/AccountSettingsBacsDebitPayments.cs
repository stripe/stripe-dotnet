namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountSettingsBacsDebitPayments : StripeEntity<AccountSettingsBacsDebitPayments>
    {
        /// <summary>
        /// The Bacs Direct Debit Display Name for this account. For payments made with Bacs Direct
        /// Debit, this will appear on the mandate, and as the statement descriptor.
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
    }
}
