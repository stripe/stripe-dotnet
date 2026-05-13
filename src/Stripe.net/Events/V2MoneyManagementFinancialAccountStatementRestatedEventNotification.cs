// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when a Financial Account Statement has been restated. A restatement occurs when a
    /// new statement is generated for a period that already had an existing statement. The
    /// related object references the original statement that was restated. The new replacement
    /// statement will also fire a FinancialAccountStatementCreated event.
    /// </summary>
    public class V2MoneyManagementFinancialAccountStatementRestatedEventNotification : V2.Core.EventNotification
    {
        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
        [STJS.JsonPropertyName("related_object")]

        public V2.Core.EventNotificationRelatedObject RelatedObject { get; set; }

        /// <summary>
        /// Asynchronously retrieves the related object from the API. Make an API request on every
        /// call.
        /// </summary>
        public Task<V2.MoneyManagement.FinancialAccountStatement> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.MoneyManagement.FinancialAccountStatement>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.MoneyManagement.FinancialAccountStatement FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.MoneyManagement.FinancialAccountStatement>(this.RelatedObject);
        }

        public V2MoneyManagementFinancialAccountStatementRestatedEvent FetchEvent()
        {
            return this.FetchEvent<V2MoneyManagementFinancialAccountStatementRestatedEvent>();
        }

        public Task<V2MoneyManagementFinancialAccountStatementRestatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2MoneyManagementFinancialAccountStatementRestatedEvent>();
        }
    }
}
