using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stripe
{
    public class StripeEventService : StripeService
    {
        public StripeEventService(string apiKey = null) : base(apiKey) { }

        public virtual StripeEvent Get(string eventId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeEvent>.MapFromJson(
                Requestor.GetString($"{Urls.Events}/{eventId}",
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual IEnumerable<StripeEvent> List(StripeEventListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeEvent>.MapCollectionFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, Urls.Events, true),
                SetupRequestOptions(requestOptions))
            );
        }

#if !PORTABLE
        public virtual async Task<StripeEvent> GetAsync(string eventId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeEvent>.MapFromJson(
                await Requestor.GetStringAsync($"{Urls.Events}/{eventId}",
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<IEnumerable<StripeEvent>> ListAsync(StripeEventListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeEvent>.MapCollectionFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(listOptions, Urls.Events, true),
                SetupRequestOptions(requestOptions))
            );
        }
#endif
    }
}
