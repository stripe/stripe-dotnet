// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class EventDestinationCreateAzureEventGridOptions : INestedOptions
    {
        /// <summary>
        /// The Azure region.
        /// </summary>
        [JsonProperty("azure_region")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("azure_region")]
#endif
        public string AzureRegion { get; set; }

        /// <summary>
        /// The name of the Azure resource group.
        /// </summary>
        [JsonProperty("azure_resource_group_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("azure_resource_group_name")]
#endif
        public string AzureResourceGroupName { get; set; }

        /// <summary>
        /// The Azure subscription ID.
        /// </summary>
        [JsonProperty("azure_subscription_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("azure_subscription_id")]
#endif
        public string AzureSubscriptionId { get; set; }
    }
}
