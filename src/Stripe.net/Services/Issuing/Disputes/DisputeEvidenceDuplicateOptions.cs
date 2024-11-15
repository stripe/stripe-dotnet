// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class DisputeEvidenceDuplicateOptions : INestedOptions
    {
        /// <summary>
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>)
        /// Additional documentation supporting the dispute.
        /// </summary>
        [JsonProperty("additional_documentation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("additional_documentation")]
#endif

        public string AdditionalDocumentation { get; set; }

        /// <summary>
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) Copy of
        /// the card statement showing that the product had already been paid for.
        /// </summary>
        [JsonProperty("card_statement")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_statement")]
#endif

        public string CardStatement { get; set; }

        /// <summary>
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) Copy of
        /// the receipt showing that the product had been paid for in cash.
        /// </summary>
        [JsonProperty("cash_receipt")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cash_receipt")]
#endif

        public string CashReceipt { get; set; }

        /// <summary>
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) Image of
        /// the front and back of the check that was used to pay for the product.
        /// </summary>
        [JsonProperty("check_image")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("check_image")]
#endif

        public string CheckImage { get; set; }

        /// <summary>
        /// Explanation of why the cardholder is disputing this transaction.
        /// </summary>
        [JsonProperty("explanation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("explanation")]
#endif

        public string Explanation { get; set; }

        /// <summary>
        /// Transaction (e.g., ipi_...) that the disputed transaction is a duplicate of. Of the two
        /// or more transactions that are copies of each other, this is original undisputed one.
        /// </summary>
        [JsonProperty("original_transaction")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("original_transaction")]
#endif

        public string OriginalTransaction { get; set; }
    }
}
