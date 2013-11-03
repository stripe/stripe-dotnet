using System.Collections.Generic;

namespace Stripe
{
    public interface IStripeCardService
    {
        StripeCard Create(string customerId, StripeCardCreateOptions createOptions);
        StripeCard Get(string customerId, string cardId);
        StripeCard Update(string customerId, string cardId, StripeCardUpdateOptions updateOptions);
        void Delete(string customerId, string cardId);
        IEnumerable<StripeCard> List(string customerId, int count = 10, int offset = 0);
    }
}