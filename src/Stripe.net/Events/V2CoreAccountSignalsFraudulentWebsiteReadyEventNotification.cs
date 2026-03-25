// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when a Fraudulent Website signal is ready for an account.
    /// </summary>
    public class V2CoreAccountSignalsFraudulentWebsiteReadyEventNotification : V2.Core.EventNotification
    {
        public V2CoreAccountSignalsFraudulentWebsiteReadyEvent FetchEvent()
        {
            return this.FetchEvent<V2CoreAccountSignalsFraudulentWebsiteReadyEvent>();
        }

        public Task<V2CoreAccountSignalsFraudulentWebsiteReadyEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2CoreAccountSignalsFraudulentWebsiteReadyEvent>();
        }
    }
}
