// File generated from our OpenAPI spec
namespace Stripe.Crypto
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CustomerPaymentTokenCard : StripeEntity<CustomerPaymentTokenCard>
    {
        /// <summary>
        /// Card brand. Can be <c>amex</c>, <c>cartes_bancaires</c>, <c>diners</c>, <c>discover</c>,
        /// <c>eftpos_au</c>, <c>jcb</c>, <c>link</c>, <c>mastercard</c>, <c>unionpay</c>,
        /// <c>visa</c> or <c>unknown</c>.
        /// </summary>
        [JsonProperty("brand")]
        [STJS.JsonPropertyName("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// Two-digit number representing the card’s expiration month.
        /// </summary>
        [JsonProperty("exp_month")]
        [STJS.JsonPropertyName("exp_month")]
        public long? ExpMonth { get; set; }

        /// <summary>
        /// Four-digit number representing the card’s expiration year.
        /// </summary>
        [JsonProperty("exp_year")]
        [STJS.JsonPropertyName("exp_year")]
        public long? ExpYear { get; set; }

        /// <summary>
        /// Card funding type. Can be <c>credit</c>, <c>debit</c>, <c>prepaid</c>, or
        /// <c>unknown</c>.
        /// </summary>
        [JsonProperty("funding")]
        [STJS.JsonPropertyName("funding")]
        public string Funding { get; set; }

        /// <summary>
        /// The last four digits of the card.
        /// </summary>
        [JsonProperty("last4")]
        [STJS.JsonPropertyName("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// If this Card is part of a card wallet, this contains the details of the card wallet.
        /// </summary>
        [JsonProperty("wallet")]
        [STJS.JsonPropertyName("wallet")]
        public CustomerPaymentTokenCardWallet Wallet { get; set; }
    }
}
