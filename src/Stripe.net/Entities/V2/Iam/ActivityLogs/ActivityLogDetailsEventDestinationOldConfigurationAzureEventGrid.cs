// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ActivityLogDetailsEventDestinationOldConfigurationAzureEventGrid : StripeEntity<ActivityLogDetailsEventDestinationOldConfigurationAzureEventGrid>
    {
        /// <summary>
        /// Azure partner topic name configured for the event destination.
        /// </summary>
        [JsonProperty("azure_partner_topic_name")]
        [STJS.JsonPropertyName("azure_partner_topic_name")]
        public string AzurePartnerTopicName { get; set; }

        /// <summary>
        /// Azure region configured for the event destination.
        /// </summary>
        [JsonProperty("azure_region")]
        [STJS.JsonPropertyName("azure_region")]
        public string AzureRegion { get; set; }

        /// <summary>
        /// Azure resource group name configured for the event destination.
        /// </summary>
        [JsonProperty("azure_resource_group_name")]
        [STJS.JsonPropertyName("azure_resource_group_name")]
        public string AzureResourceGroupName { get; set; }

        /// <summary>
        /// Azure subscription ID configured for the event destination.
        /// </summary>
        [JsonProperty("azure_subscription_id")]
        [STJS.JsonPropertyName("azure_subscription_id")]
        public string AzureSubscriptionId { get; set; }
    }
}
