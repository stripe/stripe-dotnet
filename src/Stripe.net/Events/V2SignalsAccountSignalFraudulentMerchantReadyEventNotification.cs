// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when a fraudulent merchant signal is ready for an account.
    /// </summary>
    public class V2SignalsAccountSignalFraudulentMerchantReadyEventNotification : V2.Core.EventNotification
    {
        public V2SignalsAccountSignalFraudulentMerchantReadyEvent FetchEvent()
        {
            return this.FetchEvent<V2SignalsAccountSignalFraudulentMerchantReadyEvent>();
        }

        public Task<V2SignalsAccountSignalFraudulentMerchantReadyEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2SignalsAccountSignalFraudulentMerchantReadyEvent>();
        }
    }
}
