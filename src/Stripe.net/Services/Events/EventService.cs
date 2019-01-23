namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class EventService : Service<Event>,
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

        public override string BasePath => "/v1/events";

        public virtual Event Get(string eventId, RequestOptions requestOptions = null)
        {
            return this.GetEntity(eventId, null, requestOptions);
        }

        public virtual Task<Event> GetAsync(string eventId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(eventId, null, requestOptions, cancellationToken);
        }

        public virtual StripeList<Event> List(EventListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Event>> ListAsync(EventListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Event> ListAutoPaging(EventListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }
    }
}
