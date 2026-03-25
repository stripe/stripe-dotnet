// File generated from our OpenAPI spec
namespace Stripe
{
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(Infrastructure.STJStringEnumConverterFactory))]
    public class InvoiceScheduleDetailsPhaseEndDate : StringEnum
    {
        public static readonly InvoiceScheduleDetailsPhaseEndDate Now = new InvoiceScheduleDetailsPhaseEndDate("now");

        private InvoiceScheduleDetailsPhaseEndDate(string value)
            : base(value)
        {
        }
    }
}
