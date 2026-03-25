// File generated from our OpenAPI spec
namespace Stripe
{
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(Infrastructure.STJStringEnumConverterFactory))]
    public class InvoiceScheduleDetailsPhaseStartDate : StringEnum
    {
        public static readonly InvoiceScheduleDetailsPhaseStartDate Now = new InvoiceScheduleDetailsPhaseStartDate("now");

        private InvoiceScheduleDetailsPhaseStartDate(string value)
            : base(value)
        {
        }
    }
}
