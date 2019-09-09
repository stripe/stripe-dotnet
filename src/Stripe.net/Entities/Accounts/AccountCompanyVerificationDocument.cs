namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountCompanyVerificationDocument : StripeEntity<AccountCompanyVerificationDocument>
    {
        #region Expandable Back

        /// <summary>
        /// (ID of a <see cref="File"/>) The back of a document returned by a file upload with a
        /// <c>purpose</c> value of <c>additional_verification</c>.
        /// <para>Expandable.</para>
        /// </summary>
        [JsonIgnore]
        public string BackId
        {
            get => this.InternalBack?.Id;
            set => this.InternalBack = SetExpandableFieldId(value, this.InternalBack);
        }

        /// <summary>
        /// (Expanded) The back of a document returned by a file upload with a <c>purpose</c>
        /// value of <c>additional_verification</c>.
        /// </summary>
        [JsonIgnore]
        public File Back
        {
            get => this.InternalBack?.ExpandedObject;
            set => this.InternalBack = SetExpandableFieldObject(value, this.InternalBack);
        }

        [JsonProperty("back")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalBack { get; set; }
        #endregion

        /// <summary>
        /// A user-displayable string describing the verification state of this document.
        /// </summary>
        [JsonProperty("details")]
        public string Details { get; set; }

        /// <summary>
        /// A machine-readable code specifying the verification state for this document. One of
        /// <c>document_corrupt</c>, <c>document_failed_copy</c>, <c>document_not_readable</c>,
        /// <c>document_not_uploaded</c>, <c>document_failed_other</c>, <c>document_fraudulent</c>,
        /// <c>document_invalid</c>, <c>document_manipulated</c>, <c>document_too_large</c>,
        /// <c>or document_failed_test_mode</c>.
        /// </summary>
        [JsonProperty("details_code")]
        public string DetailsCode { get; set; }

        #region Expandable Front

        /// <summary>
        /// (ID of a <see cref="File"/>) The front of a document returned by a file upload with a
        /// <c>purpose</c> value of <c>additional_verification</c>.
        /// <para>Expandable.</para>
        /// </summary>
        [JsonIgnore]
        public string FrontId
        {
            get => this.InternalFront?.Id;
            set => this.InternalFront = SetExpandableFieldId(value, this.InternalFront);
        }

        /// <summary>
        /// (Expanded) The front of a document returned by a file upload with a <c>purpose</c>
        /// value of <c>additional_verification</c>.
        /// </summary>
        [JsonIgnore]
        public File Front
        {
            get => this.InternalFront?.ExpandedObject;
            set => this.InternalFront = SetExpandableFieldObject(value, this.InternalFront);
        }

        [JsonProperty("front")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalFront { get; set; }
        #endregion
    }
}
