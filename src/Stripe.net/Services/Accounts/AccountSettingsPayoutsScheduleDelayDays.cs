// File generated from our OpenAPI spec
namespace Stripe
{
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(Infrastructure.STJStringEnumConverterFactory))]
    public class AccountSettingsPayoutsScheduleDelayDays : StringEnum
    {
        public static readonly AccountSettingsPayoutsScheduleDelayDays Minimum = new AccountSettingsPayoutsScheduleDelayDays("minimum");

        private AccountSettingsPayoutsScheduleDelayDays(string value)
            : base(value)
        {
        }
    }
}
