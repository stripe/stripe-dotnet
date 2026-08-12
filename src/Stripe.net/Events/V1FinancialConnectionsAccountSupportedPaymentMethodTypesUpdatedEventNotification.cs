// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when the supported_payment_method_types array on a Financial Connections account
    /// changes.
    /// </summary>
    public class V1FinancialConnectionsAccountSupportedPaymentMethodTypesUpdatedEventNotification : V2.Core.EventNotification
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
        public Task<FinancialConnections.Account> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<FinancialConnections.Account>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public FinancialConnections.Account FetchRelatedObject()
        {
            return this.FetchRelatedObject<FinancialConnections.Account>(this.RelatedObject);
        }

        public V1FinancialConnectionsAccountSupportedPaymentMethodTypesUpdatedEvent FetchEvent()
        {
            return this.FetchEvent<V1FinancialConnectionsAccountSupportedPaymentMethodTypesUpdatedEvent>();
        }

        public Task<V1FinancialConnectionsAccountSupportedPaymentMethodTypesUpdatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1FinancialConnectionsAccountSupportedPaymentMethodTypesUpdatedEvent>();
        }
    }
}
