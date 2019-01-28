namespace Stripe
{
    using System.Collections.Generic;

    /// <summary>
    /// Base class for Stripe options classes, i.e. classes representing parameters for Stripe
    /// API requests.
    /// </summary>
    public class BaseOptions : INestedOptions
    {
        public Dictionary<string, string> ExtraParams { get; set; } = new Dictionary<string, string>();

        public List<string> Expand { get; set; } = new List<string>();

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
