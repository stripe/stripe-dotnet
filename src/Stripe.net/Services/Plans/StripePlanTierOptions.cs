using System;
using System.Reflection;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripePlanTierOptions
    {
        public class UpToOption
        {
        }

        public class UpToInf : UpToOption
        {

        }

        public class UpToBound : UpToOption
        {
            public int Bound { get; set; }
        }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        #region UpTo
        public UpToOption UpTo { get; set; }

        [JsonProperty("up_to")]
        internal string UpToInternal => UpTo is UpToInf ? "inf" : ((UpToBound) UpTo).Bound.ToString();
        #endregion
    }
}
