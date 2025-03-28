// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class AccountUpdateIdentityBusinessDetailsDocumentsPrimaryVerificationFrontBackOptions : INestedOptions
    {
        [JsonProperty("back")]
        [JsonConverter(typeof(EmptyableConverter<string>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("back")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<string>))]
#endif
        internal Emptyable<string> InternalBack { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyBack
        {
            get => this.InternalBack?.Empty ?? false;
            set
            {
                this.InternalBack ??= new Emptyable<string>();
                this.InternalBack.Empty = value;
            }
        }

        /// <summary>
        /// A <a href="https://docs.stripe.com/api/persons/update#create_file">file upload</a> token
        /// representing the back of the verification document. The purpose of the uploaded file
        /// should be 'identity_document'. The uploaded file needs to be a color image (smaller than
        /// 8,000px by 8,000px), in JPG, PNG, or PDF format, and less than 10 MB in size.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string Back
        {
            get => this.InternalBack?.Value;
            set
            {
                this.InternalBack ??= new Emptyable<string>();
                this.InternalBack.Value = value;
            }
        }

        /// <summary>
        /// A <a href="https://docs.stripe.com/api/persons/update#create_file">file upload</a> token
        /// representing the front of the verification document. The purpose of the uploaded file
        /// should be 'identity_document'. The uploaded file needs to be a color image (smaller than
        /// 8,000px by 8,000px), in JPG, PNG, or PDF format, and less than 10 MB in size.
        /// </summary>
        [JsonProperty("front")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("front")]
#endif
        public string Front { get; set; }
    }
}
