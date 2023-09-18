// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupAttemptListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return SetupAttempts created by the SetupIntent specified by this ID.
        /// </summary>
        [JsonProperty("setup_intent")]
        public string SetupIntent { get; set; }
    }
}
