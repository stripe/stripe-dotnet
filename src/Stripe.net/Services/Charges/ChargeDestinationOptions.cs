namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargeDestinationOptions : INestedOptions
    {
        /// <summary>
        /// ID of an existing, connected Stripe account.
        /// </summary>
        [JsonProperty("account")]
        public string Account { get; set; }

        /// <summary>
        /// The amount to transfer to the destination account without creating an <c>Application
        /// Fee</c> object. Cannot be combined with the <c>application_fee</c> parameter. Must be
        /// less than or equal to the charge amount.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }
    }
}
