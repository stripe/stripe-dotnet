namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class EventService : StripeService,
        IListable<Event, EventListOptions>,
        IRetrievable<Event>
    {
        public EventService()
            : base(null)
        {
        }

        public EventService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual Event Get(string eventId, RequestOptions requestOptions = null)
        {
            return Mapper<Event>.MapFromJson(
                Requestor.GetString(
                    $"{Urls.Events}/{eventId}",
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<Event> List(EventListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<Event>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, Urls.Events, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<Event> GetAsync(string eventId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Event>.MapFromJson(
                await Requestor.GetStringAsync(
                   $"{Urls.Events}/{eventId}",
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<Event>> ListAsync(EventListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<Event>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, Urls.Events, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}
