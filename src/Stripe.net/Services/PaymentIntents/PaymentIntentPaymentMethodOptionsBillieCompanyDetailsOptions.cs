// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodOptionsBillieCompanyDetailsOptions : INestedOptions, IHasSetTracking
    {
        private AddressOptions registeredAddress;
        private string registrationType;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// The address the company or entity is registered with.
        /// </summary>
        [JsonProperty("registered_address", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("registered_address")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public AddressOptions RegisteredAddress
        {
            get => this.registeredAddress;
            set
            {
                this.registeredAddress = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Company or entity name.
        /// </summary>
        [JsonProperty("registered_name")]
        [STJS.JsonPropertyName("registered_name")]
        public string RegisteredName { get; set; }

        /// <summary>
        /// The official registration number for the given registration type.
        /// </summary>
        [JsonProperty("registration_number")]
        [STJS.JsonPropertyName("registration_number")]
        public string RegistrationNumber { get; set; }

        /// <summary>
        /// Type of registration the company or entity holds in their registered country.
        /// One of: <c>ch_ein</c>, <c>de_hrb</c>, <c>dk_cvr</c>, <c>es_cif</c>, <c>fi_tunnus</c>,
        /// <c>fr_siren</c>, <c>fr_siret</c>, <c>it_rea</c>, <c>nl_kvk</c>, <c>no_org_number</c>,
        /// <c>no_pno</c>, <c>se_org_number</c>, <c>se_pno</c>, or <c>uk_crn</c>.
        /// </summary>
        [JsonProperty("registration_type", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("registration_type")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string RegistrationType
        {
            get => this.registrationType;
            set
            {
                this.registrationType = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// VAT id number.
        /// </summary>
        [JsonProperty("vat")]
        [STJS.JsonPropertyName("vat")]
        public string Vat { get; set; }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
