namespace Stripe
{
    using System;
    using System.Reflection;
    using Stripe.Infrastructure;

    public class PlanTierOptions : INestedOptions
    {
        [FormProperty("unit_amount")]
        public int? UnitAmount { get; set; }

        #region UpTo
        public UpToOption UpTo { get; set; }

        [FormProperty("up_to")]
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
