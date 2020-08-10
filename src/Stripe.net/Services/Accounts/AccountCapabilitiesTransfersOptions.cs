namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountCapabilitiesTransfersOptions : INestedOptions
    {
        [JsonProperty("requested")]
        public bool? Requested { get; set; }
    }
}
