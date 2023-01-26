// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsKlarna : StripeEntity<ChargePaymentMethodDetailsKlarna>
    {
        /// <summary>
        /// The Klarna payment method used for this transaction. Can be one of <c>pay_later</c>,
        /// <c>pay_now</c>, <c>pay_with_financing</c>, or <c>pay_in_installments</c>.
        /// </summary>
        [JsonProperty("payment_method_category")]
        public string PaymentMethodCategory { get; set; }

        /// <summary>
        /// Preferred language of the Klarna authorization page that the customer is redirected to.
        /// Can be one of <c>de-AT</c>, <c>en-AT</c>, <c>nl-BE</c>, <c>fr-BE</c>, <c>en-BE</c>,
        /// <c>de-DE</c>, <c>en-DE</c>, <c>da-DK</c>, <c>en-DK</c>, <c>es-ES</c>, <c>en-ES</c>,
        /// <c>fi-FI</c>, <c>sv-FI</c>, <c>en-FI</c>, <c>en-GB</c>, <c>en-IE</c>, <c>it-IT</c>,
        /// <c>en-IT</c>, <c>nl-NL</c>, <c>en-NL</c>, <c>nb-NO</c>, <c>en-NO</c>, <c>sv-SE</c>,
        /// <c>en-SE</c>, <c>en-US</c>, <c>es-US</c>, <c>fr-FR</c>, <c>en-FR</c>, <c>cs-CZ</c>,
        /// <c>en-CZ</c>, <c>el-GR</c>, <c>en-GR</c>, <c>en-AU</c>, <c>en-NZ</c>, <c>en-CA</c>,
        /// <c>fr-CA</c>, <c>pl-PL</c>, <c>en-PL</c>, <c>pt-PT</c>, <c>en-PT</c>, <c>de-CH</c>,
        /// <c>fr-CH</c>, <c>it-CH</c>, or <c>en-CH</c>.
        /// </summary>
        [JsonProperty("preferred_locale")]
        public string PreferredLocale { get; set; }
    }
}
