using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeEventService : StripeService
    {
        public StripeEventService(string apiKey = null) : base(apiKey) { }



        //Sync
        public virtual StripeEvent Get(string eventId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeEvent>.MapFromJson(
                Requestor.GetString($"{Urls.Events}/{eventId}",
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeList<StripeEvent> List(StripeEventListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeList<StripeEvent>>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, Urls.Events, true),
                SetupRequestOptions(requestOptions))
            );
        }



        //Async
        public virtual async Task<StripeEvent> GetAsync(string eventId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeEvent>.MapFromJson(
                await Requestor.GetStringAsync($"{Urls.Events}/{eventId}",
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }

        public virtual async Task<StripeList<StripeEvent>> ListAsync(StripeEventListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<StripeEvent>>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(listOptions, Urls.Events, true),
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }
    }
}
