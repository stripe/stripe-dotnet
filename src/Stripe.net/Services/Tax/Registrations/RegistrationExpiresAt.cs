// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(Infrastructure.STJStringEnumConverterFactory))]
    public class RegistrationExpiresAt : StringEnum
    {
        public static readonly RegistrationExpiresAt Now = new RegistrationExpiresAt("now");

        private RegistrationExpiresAt(string value)
            : base(value)
        {
        }
    }
}
