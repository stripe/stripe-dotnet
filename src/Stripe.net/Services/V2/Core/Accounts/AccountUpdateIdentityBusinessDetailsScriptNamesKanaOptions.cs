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
    public class AccountUpdateIdentityBusinessDetailsScriptNamesKanaOptions : INestedOptions
    {
        [JsonProperty("registered_name")]
        [JsonConverter(typeof(EmptyableConverter<string>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("registered_name")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<string>))]
#endif
        internal Emptyable<string> InternalRegisteredName { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyRegisteredName
        {
            get => this.InternalRegisteredName?.Empty ?? false;
            set
            {
                this.InternalRegisteredName ??= new Emptyable<string>();
                this.InternalRegisteredName.Empty = value;
            }
        }

        /// <summary>
        /// Registered name of the business.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string RegisteredName
        {
            get => this.InternalRegisteredName?.Value;
            set
            {
                this.InternalRegisteredName ??= new Emptyable<string>();
                this.InternalRegisteredName.Value = value;
            }
        }
    }
}
