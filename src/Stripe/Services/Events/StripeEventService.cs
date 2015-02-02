using System.Collections.Generic;

#if NET40
using System.Threading.Tasks;
#endif

namespace Stripe
{
    public class StripeEventService : StripeService
    {
        public StripeEventService(string apiKey = null) : base(apiKey) { }

        public virtual StripeEvent Get(string eventId)
        {
            var url = FormatGetUrl(eventId);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeEvent>.MapFromJson(response);
        }

#if NET40
        public virtual async Task<StripeEvent> GetAsync(string eventId)
        {
            var url = FormatGetUrl(eventId);

            var response = await Requestor.GetStringAsync(url, ApiKey);

            return Mapper<StripeEvent>.MapFromJson(response);
        }
#endif

        public virtual IEnumerable<StripeEvent> List(StripeEventListOptions listOptions = null)
        {
            var url = FormatListUrl(listOptions);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeEvent>.MapCollectionFromJson(response);
        }

#if NET40
        public virtual async Task<IEnumerable<StripeEvent>> ListAsync(StripeEventListOptions listOptions = null)
        {
            var url = FormatListUrl(listOptions);

            var response = await Requestor.GetStringAsync(url, ApiKey);

            return Mapper<StripeEvent>.MapCollectionFromJson(response);
        }
#endif

        private string FormatListUrl(StripeEventListOptions listOptions)
        {
            var url = Urls.Events;
            url = this.ApplyAllParameters(listOptions, url, true);
            return url;
        }

        private static string FormatGetUrl(string eventId)
        {
            var url = string.Format("{0}/{1}", Urls.Events, eventId);
            return url;
        }
    }
}