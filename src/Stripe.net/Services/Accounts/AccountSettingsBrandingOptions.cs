namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountSettingsBrandingOptions : INestedOptions
    {
        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("primary_color")]
        public string PrimaryColor { get; set; }
    }
}
