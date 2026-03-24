// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class EventDestinationAzureEventGrid : StripeEntity<EventDestinationAzureEventGrid>
    {
        /// <summary>
        /// The name of the Azure partner topic.
        /// </summary>
        [JsonProperty("azure_partner_topic_name")]
        [STJS.JsonPropertyName("azure_partner_topic_name")]
        public string AzurePartnerTopicName { get; set; }

        /// <summary>
        /// The status of the Azure partner topic.
        /// One of: <c>activated</c>, <c>deleted</c>, <c>never_activated</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("azure_partner_topic_status")]
        [STJS.JsonPropertyName("azure_partner_topic_status")]
        public string AzurePartnerTopicStatus { get; set; }

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
