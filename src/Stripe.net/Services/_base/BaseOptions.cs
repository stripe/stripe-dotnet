namespace Stripe
{
    using System.Collections.Generic;

    public class BaseOptions : INestedOptions
    {
        private Dictionary<string, string> extraParams = new Dictionary<string, string>();
        private List<string> expand = new List<string>();

        public Dictionary<string, string> ExtraParams
        {
            get { return this.extraParams; }
            set { this.extraParams = value; }
        }

        public List<string> Expand
        {
            get { return this.expand; }
            set { this.expand = value; }
        }

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
