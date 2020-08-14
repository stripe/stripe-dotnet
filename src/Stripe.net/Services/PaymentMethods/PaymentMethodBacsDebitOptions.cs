namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodBacsDebitOptions : INestedOptions
    {
        /// <summary>
        /// Account number of the bank account that the funds will be debited from.
        /// </summary>
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Sort code of the bank account. (e.g., <c>10-20-30</c>).
        /// </summary>
        [JsonProperty("sort_code")]
        public string SortCode { get; set; }
    }
}
