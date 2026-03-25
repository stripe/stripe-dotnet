// File generated from our OpenAPI spec
namespace Stripe
{
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(Infrastructure.STJStringEnumConverterFactory))]
    public class PlanTierUpTo : StringEnum
    {
        public static readonly PlanTierUpTo Inf = new PlanTierUpTo("inf");

        private PlanTierUpTo(string value)
            : base(value)
        {
        }
    }
}
