namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodFpxOptions : INestedOptions
    {
        /// <summary>
        /// Account holder type for FPX transaction.
        /// One of: <c>company</c>, or <c>individual</c>.
        /// </summary>
        [JsonProperty("account_holder_type")]
        public string AccountHolderType { get; set; }

        /// <summary>
        /// The customer's bank.
        /// One of: <c>affin_bank</c>, <c>alliance_bank</c>, <c>ambank</c>, <c>bank_islam</c>,
        /// <c>bank_muamalat</c>, <c>bank_rakyat</c>, <c>bsn</c>, <c>cimb</c>, <c>deutsche_bank</c>,
        /// <c>hong_leong_bank</c>, <c>hsbc</c>, <c>kfh</c>, <c>maybank2e</c>, <c>maybank2u</c>,
        /// <c>ocbc</c>, <c>pb_enterprise</c>, <c>public_bank</c>, <c>rhb</c>,
        /// <c>standard_chartered</c>, or <c>uob</c>.
        /// </summary>
        [JsonProperty("bank")]
        public string Bank { get; set; }
    }
}
