// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodOptionsCardPresentFleetTransactionDatumOptions : INestedOptions, IHasSetTracking
    {
        private string value;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// The prompt that the Terminal SDK displays to collect this Fleet value.
        /// One of: <c>additional_fleet_data_1</c>, <c>additional_fleet_data_2</c>,
        /// <c>driver_id</c>, <c>employee_number</c>, <c>entered_data_alphanumeric</c>,
        /// <c>entered_data_numeric</c>, <c>generic_id</c>, <c>invoice_number</c>, <c>odometer</c>,
        /// <c>postal_code</c>, <c>reefer_hours</c>, <c>replacement_car</c>, <c>trailer_number</c>,
        /// <c>trip_number</c>, <c>unit_number</c>, <c>vehicle_id</c>, <c>vehicle_tag</c>, or
        /// <c>work_order</c>.
        /// </summary>
        [JsonProperty("prompt")]
        [STJS.JsonPropertyName("prompt")]
        public string Prompt { get; set; }

        /// <summary>
        /// Whether the collected value is printed on the receipt. Defaults to <c>omit</c>.
        /// One of: <c>omit</c>, or <c>print</c>.
        /// </summary>
        [JsonProperty("receipt_behavior")]
        [STJS.JsonPropertyName("receipt_behavior")]
        public string ReceiptBehavior { get; set; }

        /// <summary>
        /// The value collected for this Fleet prompt.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("value")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string Value
        {
            get => this.value;
            set
            {
                this.value = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
