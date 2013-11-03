using System.Collections.Generic;

namespace Stripe
{
    public interface IStripePlanService
    {
        StripePlan Create(StripePlanCreateOptions createOptions);
        StripePlan Get(string planId);
        void Delete(string planId);
        StripePlan Update(string planId, StripePlanUpdateOptions updateOptions);
        IEnumerable<StripePlan> List(int count = 10, int offset = 0);
    }
}