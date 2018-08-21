namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class EventService : StripeService
    {
        public EventService()
            : base(null)
        {
        }

        public EventService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual StripeEvent Get(string eventId, RequestOptions requestOptions = null)
        {
            return Mapper<StripeEvent>.MapFromJson(
                Requestor.GetString(
                    $"{Urls.Events}/{eventId}",
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<StripeEvent> List(EventListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<StripeEvent>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, Urls.Events, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<StripeEvent> GetAsync(string eventId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeEvent>.MapFromJson(
                await Requestor.GetStringAsync(
                   $"{Urls.Events}/{eventId}",
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<StripeEvent>> ListAsync(EventListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<StripeEvent>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, Urls.Events, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}
