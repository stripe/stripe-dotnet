// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodIdeal : StripeEntity<PaymentMethodIdeal>
    {
        /// <summary>
        /// The customer's bank, if provided. Can be one of <c>abn_amro</c>, <c>asn_bank</c>,
        /// <c>bunq</c>, <c>handelsbanken</c>, <c>ing</c>, <c>knab</c>, <c>moneyou</c>, <c>n26</c>,
        /// <c>nn</c>, <c>rabobank</c>, <c>regiobank</c>, <c>revolut</c>, <c>sns_bank</c>,
        /// <c>triodos_bank</c>, <c>van_lanschot</c>, or <c>yoursafe</c>.
        /// One of: <c>abn_amro</c>, <c>asn_bank</c>, <c>bunq</c>, <c>handelsbanken</c>, <c>ing</c>,
        /// <c>knab</c>, <c>moneyou</c>, <c>n26</c>, <c>nn</c>, <c>rabobank</c>, <c>regiobank</c>,
        /// <c>revolut</c>, <c>sns_bank</c>, <c>triodos_bank</c>, <c>van_lanschot</c>, or
        /// <c>yoursafe</c>.
        /// </summary>
        [JsonProperty("bank")]
        public string Bank { get; set; }

        /// <summary>
        /// The Bank Identifier Code of the customer's bank, if the bank was provided.
        /// One of: <c>ABNANL2A</c>, <c>ASNBNL21</c>, <c>BITSNL2A</c>, <c>BUNQNL2A</c>,
        /// <c>FVLBNL22</c>, <c>HANDNL2A</c>, <c>INGBNL2A</c>, <c>KNABNL2H</c>, <c>MOYONL21</c>,
        /// <c>NNBANL2G</c>, <c>NTSBDEB1</c>, <c>RABONL2U</c>, <c>RBRBNL21</c>, <c>REVOIE23</c>,
        /// <c>REVOLT21</c>, <c>SNSBNL2A</c>, or <c>TRIONL2U</c>.
        /// </summary>
        [JsonProperty("bic")]
        public string Bic { get; set; }
    }
}
