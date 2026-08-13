// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when a credit balance transaction is created.
    /// </summary>
    public class V1BillingCreditBalanceTransactionCreatedEventNotification : V2.Core.EventNotification
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
        public Task<Billing.CreditBalanceTransaction> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Billing.CreditBalanceTransaction>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Billing.CreditBalanceTransaction FetchRelatedObject()
        {
            return this.FetchRelatedObject<Billing.CreditBalanceTransaction>(this.RelatedObject);
        }

        public V1BillingCreditBalanceTransactionCreatedEvent FetchEvent()
        {
            return this.FetchEvent<V1BillingCreditBalanceTransactionCreatedEvent>();
        }

        public Task<V1BillingCreditBalanceTransactionCreatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1BillingCreditBalanceTransactionCreatedEvent>();
        }
    }
}
