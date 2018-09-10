namespace Stripe
{
    using System.Collections.Generic;

    public class StripeBaseOptions : INestedOptions
    {
        public Dictionary<string, string> ExtraParams = new Dictionary<string, string>();
        public List<string> Expand = new List<string>();

        public void AddExtraParam(string key, string value)
        {
            this.ExtraParams.Add(key, value);
        }

        public void AddExpand(string value)
        {
            this.Expand.Add(value);
        }
    }
}
