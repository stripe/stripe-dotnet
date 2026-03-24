// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class EventDestinationCreateAzureEventGridOptions : INestedOptions
    {
        /// <summary>
        /// The Azure region.
        /// </summary>
        [JsonProperty("azure_region")]
        [STJS.JsonPropertyName("azure_region")]
        public string AzureRegion { get; set; }

        /// <summary>
        /// The name of the Azure resource group.
        /// </summary>
        [JsonProperty("azure_resource_group_name")]
        [STJS.JsonPropertyName("azure_resource_group_name")]
        public string AzureResourceGroupName { get; set; }

        /// <summary>
        /// The Azure subscription ID.
        /// </summary>
        [JsonProperty("azure_subscription_id")]
        [STJS.JsonPropertyName("azure_subscription_id")]
        public string AzureSubscriptionId { get; set; }
    }
}
