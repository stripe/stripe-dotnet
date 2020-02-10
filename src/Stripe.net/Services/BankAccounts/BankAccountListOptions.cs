namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class BankAccountListOptions : ListOptions
    {
        [JsonProperty("object")]
        internal string Object => "bank_account";
    }
}
