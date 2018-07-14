namespace Stripe
{
    using System;
    using System.Reflection;
    using Newtonsoft.Json;

    public class StripePlanTierOptions
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        #region UpTo
        public UpToOption UpTo { get; set; }

        [JsonProperty("up_to")]
        internal string UpToInternal => this.UpTo is UpToInf ? "inf" : ((UpToBound)this.UpTo).Bound.ToString();
        #endregion

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
    }
}
