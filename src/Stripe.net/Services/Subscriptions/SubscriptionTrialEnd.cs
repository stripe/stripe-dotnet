// File generated from our OpenAPI spec
namespace Stripe
{
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(Infrastructure.STJStringEnumConverterFactory))]
    public class SubscriptionTrialEnd : StringEnum
    {
        public static readonly SubscriptionTrialEnd Now = new SubscriptionTrialEnd("now");

        private SubscriptionTrialEnd(string value)
            : base(value)
        {
        }
    }
}
