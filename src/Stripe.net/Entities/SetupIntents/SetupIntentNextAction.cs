namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SetupIntentNextAction : StripeEntity<SetupIntentNextAction>
    {
        [JsonProperty("redirect_to_url")]
        public SetupIntentNextActionRedirectToUrl RedirectToUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
