// File generated from our OpenAPI spec
namespace Stripe
{
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(Infrastructure.STJStringEnumConverterFactory))]
    public class PriceTierUpTo : StringEnum
    {
        public static readonly PriceTierUpTo Inf = new PriceTierUpTo("inf");

        private PriceTierUpTo(string value)
            : base(value)
        {
        }
    }
}
