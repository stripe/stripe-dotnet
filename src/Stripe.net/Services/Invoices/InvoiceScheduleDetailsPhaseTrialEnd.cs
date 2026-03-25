// File generated from our OpenAPI spec
namespace Stripe
{
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(Infrastructure.STJStringEnumConverterFactory))]
    public class InvoiceScheduleDetailsPhaseTrialEnd : StringEnum
    {
        public static readonly InvoiceScheduleDetailsPhaseTrialEnd Now = new InvoiceScheduleDetailsPhaseTrialEnd("now");

        private InvoiceScheduleDetailsPhaseTrialEnd(string value)
            : base(value)
        {
        }
    }
}
