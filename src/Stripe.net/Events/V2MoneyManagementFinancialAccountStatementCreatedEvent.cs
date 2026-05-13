// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when a Financial Account Statement is created and ready for download.
    /// </summary>
    public class V2MoneyManagementFinancialAccountStatementCreatedEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.money_management.financial_account_statement.created event.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]

        public V2MoneyManagementFinancialAccountStatementCreatedEventData Data { get; set; }

        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
        [STJS.JsonPropertyName("related_object")]

        public V2.Core.EventRelatedObject RelatedObject { get; set; }

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
    }
}
