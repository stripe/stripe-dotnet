namespace Stripe.V2
{
    using System.Threading.Tasks;

    /// <summary>
    /// Base class for Pushed event classes.  This class should not be used directly.
    ///
    /// This is part of an experiment and may be changed or removed at any time.
    /// See StripeClient.ParseThinEvent__Experimental.
    /// </summary>
    public abstract class PushedEvent : Event
    {
        protected T PullEvent<T>()
        where T : V2.Event
        {
            var svc = new V2.Core.EventService(this.Requestor);
            return (T)svc.Get(this.Id, null, new RequestOptions
            {
                StripeAccount = this.Context,
                Usage = PullEventUsage,
            });
        }

        protected async Task<T> PullEventAsync<T>()
        where T : V2.Event
        {
            var svc = new V2.Core.EventService(this.Requestor);
            return (T)await svc.GetAsync(this.Id, null, new RequestOptions
            {
                StripeAccount = this.Context,
                Usage = PullEventUsage,
            })
            .ConfigureAwait(false);
        }
    }
}
