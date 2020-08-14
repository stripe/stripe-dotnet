namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountCompanyVerificationDocument : StripeEntity<AccountCompanyVerificationDocument>
    {
        #region Expandable Back

        [JsonIgnore]
        public string BackId
        {
            get => this.InternalBack?.Id;
            set => this.InternalBack = SetExpandableFieldId(value, this.InternalBack);
        }

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

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("details_code")]
        public string DetailsCode { get; set; }

        #region Expandable Front

        [JsonIgnore]
        public string FrontId
        {
            get => this.InternalFront?.Id;
            set => this.InternalFront = SetExpandableFieldId(value, this.InternalFront);
        }

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
