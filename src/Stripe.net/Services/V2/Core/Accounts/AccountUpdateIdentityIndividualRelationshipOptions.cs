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
    public class AccountUpdateIdentityIndividualRelationshipOptions : INestedOptions
    {
        [JsonProperty("director")]
        [JsonConverter(typeof(EmptyableConverter<bool?>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("director")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<bool?>))]
#endif
        internal Emptyable<bool?> InternalDirector { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyDirector
        {
            get => this.InternalDirector?.Empty ?? false;
            set
            {
                this.InternalDirector ??= new Emptyable<bool?>();
                this.InternalDirector.Empty = value;
            }
        }

        /// <summary>
        /// Whether the person is a director of the account's identity. Directors are typically
        /// members of the governing board of the company, or responsible for ensuring the company
        /// meets its regulatory obligations.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool? Director
        {
            get => this.InternalDirector?.Value;
            set
            {
                this.InternalDirector ??= new Emptyable<bool?>();
                this.InternalDirector.Value = value;
            }
        }

        [JsonProperty("executive")]
        [JsonConverter(typeof(EmptyableConverter<bool?>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("executive")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<bool?>))]
#endif
        internal Emptyable<bool?> InternalExecutive { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyExecutive
        {
            get => this.InternalExecutive?.Empty ?? false;
            set
            {
                this.InternalExecutive ??= new Emptyable<bool?>();
                this.InternalExecutive.Empty = value;
            }
        }

        /// <summary>
        /// Whether the person has significant responsibility to control, manage, or direct the
        /// organization.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool? Executive
        {
            get => this.InternalExecutive?.Value;
            set
            {
                this.InternalExecutive ??= new Emptyable<bool?>();
                this.InternalExecutive.Value = value;
            }
        }

        [JsonProperty("owner")]
        [JsonConverter(typeof(EmptyableConverter<bool?>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("owner")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<bool?>))]
#endif
        internal Emptyable<bool?> InternalOwner { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyOwner
        {
            get => this.InternalOwner?.Empty ?? false;
            set
            {
                this.InternalOwner ??= new Emptyable<bool?>();
                this.InternalOwner.Empty = value;
            }
        }

        /// <summary>
        /// Whether the person is an owner of the account’s identity.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool? Owner
        {
            get => this.InternalOwner?.Value;
            set
            {
                this.InternalOwner ??= new Emptyable<bool?>();
                this.InternalOwner.Value = value;
            }
        }

        [JsonProperty("percent_ownership")]
        [JsonConverter(typeof(EmptyableConverter<string>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("percent_ownership")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<string>))]
#endif
        internal Emptyable<string> InternalPercentOwnership { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyPercentOwnership
        {
            get => this.InternalPercentOwnership?.Empty ?? false;
            set
            {
                this.InternalPercentOwnership ??= new Emptyable<string>();
                this.InternalPercentOwnership.Empty = value;
            }
        }

        /// <summary>
        /// The percent owned by the person of the account's legal entity.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string PercentOwnership
        {
            get => this.InternalPercentOwnership?.Value;
            set
            {
                this.InternalPercentOwnership ??= new Emptyable<string>();
                this.InternalPercentOwnership.Value = value;
            }
        }

        [JsonProperty("title")]
        [JsonConverter(typeof(EmptyableConverter<string>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("title")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<string>))]
#endif
        internal Emptyable<string> InternalTitle { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyTitle
        {
            get => this.InternalTitle?.Empty ?? false;
            set
            {
                this.InternalTitle ??= new Emptyable<string>();
                this.InternalTitle.Empty = value;
            }
        }

        /// <summary>
        /// The person's title (e.g., CEO, Support Engineer).
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string Title
        {
            get => this.InternalTitle?.Value;
            set
            {
                this.InternalTitle ??= new Emptyable<string>();
                this.InternalTitle.Value = value;
            }
        }
    }
}
