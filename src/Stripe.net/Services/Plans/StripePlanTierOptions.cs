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

        [JsonProperty("up_to")]
        public UpToOption UpTo { get; set; }
    }
}