// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class DisputeEvidenceDuplicateOptions : INestedOptions
    {
        /// <summary>
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>)
        /// Additional documentation supporting the dispute.
        /// </summary>
        [JsonProperty("additional_documentation")]
        public string AdditionalDocumentation { get; set; }

        /// <summary>
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) Copy of
        /// the card statement showing that the product had already been paid for.
        /// </summary>
        [JsonProperty("card_statement")]
        public string CardStatement { get; set; }

        /// <summary>
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) Copy of
        /// the receipt showing that the product had been paid for in cash.
        /// </summary>
        [JsonProperty("cash_receipt")]
        public string CashReceipt { get; set; }

        /// <summary>
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) Image of
        /// the front and back of the check that was used to pay for the product.
        /// </summary>
        [JsonProperty("check_image")]
        public string CheckImage { get; set; }

        /// <summary>
        /// Explanation of why the cardholder is disputing this transaction.
        /// </summary>
        [JsonProperty("explanation")]
        public string Explanation { get; set; }

        /// <summary>
        /// Transaction (e.g., ipi_...) that the disputed transaction is a duplicate of. Of the two
        /// or more transactions that are copies of each other, this is original undisputed one.
        /// </summary>
        [JsonProperty("original_transaction")]
        public string OriginalTransaction { get; set; }
    }
}
