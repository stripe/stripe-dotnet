// File generated from our OpenAPI spec
namespace Stripe
{
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(Infrastructure.STJStringEnumConverterFactory))]
    public class SubscriptionSchedulePhaseTrialEnd : StringEnum
    {
        public static readonly SubscriptionSchedulePhaseTrialEnd Now = new SubscriptionSchedulePhaseTrialEnd("now");

        private SubscriptionSchedulePhaseTrialEnd(string value)
            : base(value)
        {
        }
    }
}
