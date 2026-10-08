// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InboundTransferMandateAuBecs : StripeEntity<InboundTransferMandateAuBecs>
    {
        /// <summary>
        /// The generated AU BECS lodgement reference. It is 18 uppercase alphanumeric or underscore
        /// characters and incorporates lodgement_reference_prefix when one was supplied at
        /// creation.
        /// </summary>
        [JsonProperty("lodgement_reference")]
        [STJS.JsonPropertyName("lodgement_reference")]
        public string LodgementReference { get; set; }
    }
}
