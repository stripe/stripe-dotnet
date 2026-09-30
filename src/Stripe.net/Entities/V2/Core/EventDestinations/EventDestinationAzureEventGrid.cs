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
        /// The name of the Stripe-created partner topic that receives events.
        /// </summary>
        [JsonProperty("azure_partner_topic_name")]
        [STJS.JsonPropertyName("azure_partner_topic_name")]
        public string AzurePartnerTopicName { get; set; }

        /// <summary>
        /// The Azure-reported lifecycle state of the partner topic.
        /// One of: <c>activated</c>, <c>deleted</c>, <c>never_activated</c>, or <c>unknown</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("azure_partner_topic_status")]
        [STJS.JsonPropertyName("azure_partner_topic_status")]
        public string AzurePartnerTopicStatus { get; set; }

        /// <summary>
        /// The Azure region where the partner topic is located.
        /// </summary>
        [JsonProperty("azure_region")]
        [STJS.JsonPropertyName("azure_region")]
        public string AzureRegion { get; set; }

        /// <summary>
        /// The Azure resource group containing the partner topic.
        /// </summary>
        [JsonProperty("azure_resource_group_name")]
        [STJS.JsonPropertyName("azure_resource_group_name")]
        public string AzureResourceGroupName { get; set; }

        /// <summary>
        /// The Azure subscription containing the resource group and partner topic.
        /// </summary>
        [JsonProperty("azure_subscription_id")]
        [STJS.JsonPropertyName("azure_subscription_id")]
        public string AzureSubscriptionId { get; set; }
    }
}
