// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountUpdateIdentityBusinessDetailsAnnualRevenueOptions : INestedOptions
    {
        /// <summary>
        /// A non-negative integer representing the amount in the smallest currency unit.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public V2.Amount Amount { get; set; }

        [JsonProperty("fiscal_year_end")]
        [JsonConverter(typeof(EmptyableConverter<string>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fiscal_year_end")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<string>))]
#endif
        internal Emptyable<string> InternalFiscalYearEnd { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyFiscalYearEnd
        {
            get => this.InternalFiscalYearEnd?.Empty ?? false;
            set
            {
                this.InternalFiscalYearEnd ??= new Emptyable<string>();
                this.InternalFiscalYearEnd.Empty = value;
            }
        }

        /// <summary>
        /// The close-out date of the preceding fiscal year in ISO 8601 format. E.g. 2023-12-31 for
        /// the 31st of December, 2023.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string FiscalYearEnd
        {
            get => this.InternalFiscalYearEnd?.Value;
            set
            {
                this.InternalFiscalYearEnd ??= new Emptyable<string>();
                this.InternalFiscalYearEnd.Value = value;
            }
        }
    }
}
