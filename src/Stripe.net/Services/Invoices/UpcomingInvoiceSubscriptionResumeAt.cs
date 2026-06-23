namespace Stripe
{
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(Infrastructure.STJStringEnumConverterFactory))]
    public class UpcomingInvoiceSubscriptionResumeAt : StringEnum
    {
        /// <summary>When viewing an upcoming invoice for a subscription, simulates it resuming to the current time.</summary>
        public static readonly UpcomingInvoiceSubscriptionResumeAt Now
            = new UpcomingInvoiceSubscriptionResumeAt("now");

        private UpcomingInvoiceSubscriptionResumeAt(string value)
            : base(value)
        {
        }
    }
}
