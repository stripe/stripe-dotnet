// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// The FinancialAddress could not be activated and can not receive funds.
    /// </summary>
    public class V2MoneyManagementFinancialAddressFailedEvent : V2.Event
    {
        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("related_object")]
#endif

        public V2.EventRelatedObject RelatedObject { get; set; }

        /// <summary>
        /// Asynchronously retrieves the related object from the API. Make an API request on every
        /// call.
        /// </summary>
        public Task<V2.FinancialAddress> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.FinancialAddress>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.FinancialAddress FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.FinancialAddress>(this.RelatedObject);
        }
    }
}
