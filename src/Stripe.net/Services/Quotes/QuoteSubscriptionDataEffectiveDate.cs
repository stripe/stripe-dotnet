namespace Stripe
{
    public class QuoteSubscriptionDataEffectiveDate : StringEnum
    {
        /// <summary>Special value used to indicate that a subscription should be updated at the end of its current period.</summary>
        public static readonly QuoteSubscriptionDataEffectiveDate CurrentPeriodEnd = new QuoteSubscriptionDataEffectiveDate("current_period_end");

        private QuoteSubscriptionDataEffectiveDate(string value)
            : base(value)
        {
        }
    }
}
