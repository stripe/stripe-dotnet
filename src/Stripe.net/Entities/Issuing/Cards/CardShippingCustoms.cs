// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardShippingCustoms : StripeEntity<CardShippingCustoms>
    {
        /// <summary>
        /// A registration number used for customs in Europe. See <a
        /// href="https://www.gov.uk/eori">https://www.gov.uk/eori</a> for the UK and <a
        /// href="https://ec.europa.eu/taxation_customs/business/customs-procedures-import-and-export/customs-procedures/economic-operators-registration-and-identification-number-eori_en">https://ec.europa.eu/taxation_customs/business/customs-procedures-import-and-export/customs-procedures/economic-operators-registration-and-identification-number-eori_en</a>
        /// for the EU.
        /// </summary>
        [JsonProperty("eori_number")]
        public string EoriNumber { get; set; }
    }
}
