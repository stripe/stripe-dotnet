namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentSingleUseOptions : INestedOptions
    {
        /// <summary>
        /// Amount associated with the Mandate created by this SetupIntent.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// 3-letter ISO code for currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
