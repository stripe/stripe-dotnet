// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountLinkCreateOptions : BaseOptions
    {
        /// <summary>
        /// The ID of the Account to create link for.
        /// </summary>
        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
#endif
        public string Account { get; set; }

        /// <summary>
        /// The use case of the AccountLink.
        /// </summary>
        [JsonProperty("use_case")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("use_case")]
#endif
        public AccountLinkCreateUseCaseOptions UseCase { get; set; }
    }
}
