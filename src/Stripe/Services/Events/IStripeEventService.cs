using System.Collections.Generic;

namespace Stripe
{
    public interface IStripeEventService
    {
        StripeEvent Get(string eventId);
        IEnumerable<StripeEvent> List(int count = 10, int offset = 0, StripeEventSearchOptions searchOptions = null);
    }
}