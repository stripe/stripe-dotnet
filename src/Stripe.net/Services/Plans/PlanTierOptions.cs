namespace Stripe
{
    using Newtonsoft.Json;

    public class PlanTierOptions : INestedOptions
    {
        [JsonProperty("flat_amount")]
        public long? FlatAmount { get; set; }

        [JsonProperty("unit_amount")]
        public long? UnitAmount { get; set; }

        #region UpTo
        [JsonIgnore]
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
            public long Bound { get; set; }
        }
    }
}
