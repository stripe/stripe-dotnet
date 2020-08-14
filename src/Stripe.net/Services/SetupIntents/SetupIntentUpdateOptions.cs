namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SetupIntentUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        [JsonProperty("payment_method_options")]
        public SetupIntentPaymentMethodOptionsOptions PaymentMethodOptions { get; set; }

        [JsonProperty("payment_method_types")]
        public List<string> PaymentMethodTypes { get; set; }
    }
}
