using System.Collections.Generic;

namespace Stripe
{
    public class StripeBaseOptions
    {
        public void AddExtraParam(string key, string value) {
            ExtraParams.Add(key, value);
        }

        public Dictionary<string, string> ExtraParams = new Dictionary<string, string>();


        public void AddExpand(string value) {
            Expand.Add(value);
        }

        public List<string> Expand = new List<string>();
    }
}
