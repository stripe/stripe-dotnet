// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Accounts
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class PersonUpdateScriptNamesKanaOptions : INestedOptions
    {
        [JsonProperty("given_name")]
        [JsonConverter(typeof(EmptyableConverter<string>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("given_name")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<string>))]
#endif
        internal Emptyable<string> InternalGivenName { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyGivenName
        {
            get => this.InternalGivenName?.Empty ?? false;
            set
            {
                this.InternalGivenName ??= new Emptyable<string>();
                this.InternalGivenName.Empty = value;
            }
        }

        /// <summary>
        /// The person's first or given name.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string GivenName
        {
            get => this.InternalGivenName?.Value;
            set
            {
                this.InternalGivenName ??= new Emptyable<string>();
                this.InternalGivenName.Value = value;
            }
        }

        [JsonProperty("surname")]
        [JsonConverter(typeof(EmptyableConverter<string>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("surname")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<string>))]
#endif
        internal Emptyable<string> InternalSurname { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptySurname
        {
            get => this.InternalSurname?.Empty ?? false;
            set
            {
                this.InternalSurname ??= new Emptyable<string>();
                this.InternalSurname.Empty = value;
            }
        }

        /// <summary>
        /// The person's last or family name.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string Surname
        {
            get => this.InternalSurname?.Value;
            set
            {
                this.InternalSurname ??= new Emptyable<string>();
                this.InternalSurname.Value = value;
            }
        }
    }
}
