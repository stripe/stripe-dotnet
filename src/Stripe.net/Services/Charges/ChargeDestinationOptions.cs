// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ChargeDestinationOptions : INestedOptions
    {
        /// <summary>
        /// ID of an existing, connected Stripe account.
        /// </summary>
        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
#endif
        public string Account { get; set; }

        /// <summary>
        /// The amount to transfer to the destination account without creating an <c>Application
        /// Fee</c> object. Cannot be combined with the <c>application_fee</c> parameter. Must be
        /// less than or equal to the charge amount.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }
    }
}
