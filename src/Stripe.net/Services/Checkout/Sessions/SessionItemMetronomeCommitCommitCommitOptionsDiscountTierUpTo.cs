// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(Infrastructure.STJStringEnumConverterFactory))]
    public class SessionItemMetronomeCommitCommitCommitOptionsDiscountTierUpTo : StringEnum
    {
        public static readonly SessionItemMetronomeCommitCommitCommitOptionsDiscountTierUpTo Inf = new SessionItemMetronomeCommitCommitCommitOptionsDiscountTierUpTo("inf");

        private SessionItemMetronomeCommitCommitCommitOptionsDiscountTierUpTo(string value)
            : base(value)
        {
        }
    }
}
