// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupAttemptListOptions : ListOptionsWithCreated
    {
        [JsonProperty("setup_intent")]
        public string SetupIntent { get; set; }
    }
}
