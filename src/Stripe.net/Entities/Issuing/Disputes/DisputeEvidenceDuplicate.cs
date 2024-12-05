// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class DisputeEvidenceDuplicate : StripeEntity<DisputeEvidenceDuplicate>
    {
        #region Expandable AdditionalDocumentation

        /// <summary>
        /// (ID of the File)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>)
        /// Additional documentation supporting the dispute.
        /// </summary>
        [JsonIgnore]
        public string AdditionalDocumentationId
        {
            get => this.InternalAdditionalDocumentation?.Id;
            set => this.InternalAdditionalDocumentation = SetExpandableFieldId(value, this.InternalAdditionalDocumentation);
        }

        /// <summary>
        /// (Expanded)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>)
        /// Additional documentation supporting the dispute.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public File AdditionalDocumentation
        {
            get => this.InternalAdditionalDocumentation?.ExpandedObject;
            set => this.InternalAdditionalDocumentation = SetExpandableFieldObject(value, this.InternalAdditionalDocumentation);
        }

        [JsonProperty("additional_documentation")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalAdditionalDocumentation { get; set; }
        #endregion

        #region Expandable CardStatement

        /// <summary>
        /// (ID of the File)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) Copy of
        /// the card statement showing that the product had already been paid for.
        /// </summary>
        [JsonIgnore]
        public string CardStatementId
        {
            get => this.InternalCardStatement?.Id;
            set => this.InternalCardStatement = SetExpandableFieldId(value, this.InternalCardStatement);
        }

        /// <summary>
        /// (Expanded)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) Copy of
        /// the card statement showing that the product had already been paid for.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public File CardStatement
        {
            get => this.InternalCardStatement?.ExpandedObject;
            set => this.InternalCardStatement = SetExpandableFieldObject(value, this.InternalCardStatement);
        }

        [JsonProperty("card_statement")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalCardStatement { get; set; }
        #endregion

        #region Expandable CashReceipt

        /// <summary>
        /// (ID of the File)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) Copy of
        /// the receipt showing that the product had been paid for in cash.
        /// </summary>
        [JsonIgnore]
        public string CashReceiptId
        {
            get => this.InternalCashReceipt?.Id;
            set => this.InternalCashReceipt = SetExpandableFieldId(value, this.InternalCashReceipt);
        }

        /// <summary>
        /// (Expanded)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) Copy of
        /// the receipt showing that the product had been paid for in cash.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public File CashReceipt
        {
            get => this.InternalCashReceipt?.ExpandedObject;
            set => this.InternalCashReceipt = SetExpandableFieldObject(value, this.InternalCashReceipt);
        }

        [JsonProperty("cash_receipt")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalCashReceipt { get; set; }
        #endregion

        #region Expandable CheckImage

        /// <summary>
        /// (ID of the File)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) Image of
        /// the front and back of the check that was used to pay for the product.
        /// </summary>
        [JsonIgnore]
        public string CheckImageId
        {
            get => this.InternalCheckImage?.Id;
            set => this.InternalCheckImage = SetExpandableFieldId(value, this.InternalCheckImage);
        }

        /// <summary>
        /// (Expanded)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) Image of
        /// the front and back of the check that was used to pay for the product.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public File CheckImage
        {
            get => this.InternalCheckImage?.ExpandedObject;
            set => this.InternalCheckImage = SetExpandableFieldObject(value, this.InternalCheckImage);
        }

        [JsonProperty("check_image")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalCheckImage { get; set; }
        #endregion

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
