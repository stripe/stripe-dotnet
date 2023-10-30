// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargeFraudDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Either <c>safe</c> or <c>fraudulent</c>.
        /// One of: <c>fraudulent</c>, or <c>safe</c>.
        /// </summary>
        [JsonProperty("user_report")]
        public string UserReport { get; set; }
    }
}
