namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class SetupIntentPaymentMethodOptionsOptions : INestedOptions
    {
        [JsonProperty("card")]
        public SetupIntentPaymentMethodOptionsCardOptions Card { get; set; }
    }
}
