// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class CadenceUpdateSettingsOptions : INestedOptions
    {
        [JsonProperty("bill")]
        [JsonConverter(typeof(EmptyableConverter<CadenceUpdateSettingsBillOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bill")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<CadenceUpdateSettingsBillOptions>))]
#endif
        internal Emptyable<CadenceUpdateSettingsBillOptions> InternalBill { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyBill
        {
            get => this.InternalBill?.Empty ?? false;
            set
            {
                this.InternalBill ??= new Emptyable<CadenceUpdateSettingsBillOptions>();
                this.InternalBill.Empty = value;
            }
        }

        /// <summary>
        /// Settings that configure bills generation, which includes calculating totals, tax, and
        /// presenting invoices. If null is provided, the current bill settings will be removed from
        /// the billing cadence.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public CadenceUpdateSettingsBillOptions Bill
        {
            get => this.InternalBill?.Value;
            set
            {
                this.InternalBill ??= new Emptyable<CadenceUpdateSettingsBillOptions>();
                this.InternalBill.Value = value;
            }
        }

        [JsonProperty("collection")]
        [JsonConverter(typeof(EmptyableConverter<CadenceUpdateSettingsCollectionOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("collection")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<CadenceUpdateSettingsCollectionOptions>))]
#endif
        internal Emptyable<CadenceUpdateSettingsCollectionOptions> InternalCollection { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyCollection
        {
            get => this.InternalCollection?.Empty ?? false;
            set
            {
                this.InternalCollection ??= new Emptyable<CadenceUpdateSettingsCollectionOptions>();
                this.InternalCollection.Empty = value;
            }
        }

        /// <summary>
        /// Settings that configure and manage the behavior of collecting payments. If null is
        /// provided, the current collection settings will be removed from the billing cadence.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public CadenceUpdateSettingsCollectionOptions Collection
        {
            get => this.InternalCollection?.Value;
            set
            {
                this.InternalCollection ??= new Emptyable<CadenceUpdateSettingsCollectionOptions>();
                this.InternalCollection.Value = value;
            }
        }
    }
}
