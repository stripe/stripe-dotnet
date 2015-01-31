using System.Collections.Generic;

namespace Stripe
{
    public class StripeEventService : StripeService
    {
        public StripeEventService(string apiKey = null) : base(apiKey) { }

        public virtual StripeEvent Get(string eventId)
        {
            var url = string.Format("{0}/{1}", Urls.Events, eventId);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeEvent>.MapFromJson(response);
        }

        public virtual IEnumerable<StripeEvent> List(StripeEventListOptions listOptions = null)
        {
            var url = Urls.Events;
            url = this.ApplyAllParameters(listOptions, url, true);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeEvent>.MapCollectionFromJson(response);
        }
    }
}