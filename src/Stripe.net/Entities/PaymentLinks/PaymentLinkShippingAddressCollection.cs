// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentLinkShippingAddressCollection : StripeEntity<PaymentLinkShippingAddressCollection>
    {
        /// <summary>
        /// An array of two-letter ISO country codes representing which countries Checkout should
        /// provide as options for shipping locations. Unsupported country codes: <c>AS, CX, CC, CU,
        /// HM, IR, KP, MH, FM, NF, MP, PW, SD, SY, UM, VI</c>.
        /// </summary>
        [JsonProperty("allowed_countries")]
        public List<string> AllowedCountries { get; set; }
    }
}
