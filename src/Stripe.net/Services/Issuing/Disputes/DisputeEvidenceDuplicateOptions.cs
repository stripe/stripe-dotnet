// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class DisputeEvidenceDuplicateOptions : INestedOptions, IHasSetTracking
    {
        private string additionalDocumentation;
        private string cardStatement;
        private string cashReceipt;
        private string checkImage;
        private string explanation;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>)
        /// Additional documentation supporting the dispute.
        /// </summary>
        [JsonProperty("additional_documentation", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("additional_documentation")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string AdditionalDocumentation
        {
            get => this.additionalDocumentation;
            set
            {
                this.additionalDocumentation = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) Copy of
        /// the card statement showing that the product had already been paid for.
        /// </summary>
        [JsonProperty("card_statement", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("card_statement")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string CardStatement
        {
            get => this.cardStatement;
            set
            {
                this.cardStatement = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) Copy of
        /// the receipt showing that the product had been paid for in cash.
        /// </summary>
        [JsonProperty("cash_receipt", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("cash_receipt")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string CashReceipt
        {
            get => this.cashReceipt;
            set
            {
                this.cashReceipt = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) Image of
        /// the front and back of the check that was used to pay for the product.
        /// </summary>
        [JsonProperty("check_image", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("check_image")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string CheckImage
        {
            get => this.checkImage;
            set
            {
                this.checkImage = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Explanation of why the cardholder is disputing this transaction.
        /// </summary>
        [JsonProperty("explanation", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("explanation")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string Explanation
        {
            get => this.explanation;
            set
            {
                this.explanation = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Transaction (e.g., ipi_...) that the disputed transaction is a duplicate of. Of the two
        /// or more transactions that are copies of each other, this is original undisputed one.
        /// </summary>
        [JsonProperty("original_transaction")]
        [STJS.JsonPropertyName("original_transaction")]
        public string OriginalTransaction { get; set; }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
