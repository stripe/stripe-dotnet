using System.Collections.Generic;

namespace Stripe
{
    public class StripeBaseOptions
    {
        public Dictionary<string, string> ExtraParams = new Dictionary<string, string>();
        public List<string> Expand = new List<string>();

        public void AddExtraParam(string key, string value)
        {
            ExtraParams.Add(key, value);
        }

        public void AddExpand(string value)
        {
            Expand.Add(value);
        }
    }
}
