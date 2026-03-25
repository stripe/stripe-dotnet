// File generated from our OpenAPI spec
namespace Stripe
{
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(Infrastructure.STJStringEnumConverterFactory))]
    public class SubscriptionScheduleStartDate : StringEnum
    {
        public static readonly SubscriptionScheduleStartDate Now = new SubscriptionScheduleStartDate("now");

        private SubscriptionScheduleStartDate(string value)
            : base(value)
        {
        }
    }
}
