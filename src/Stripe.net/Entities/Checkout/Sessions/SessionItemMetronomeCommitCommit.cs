// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionItemMetronomeCommitCommit : StripeEntity<SessionItemMetronomeCommitCommit>
    {
        /// <summary>
        /// Sets the balance amount and release schedule. Mutually exclusive with
        /// <c>commit_options</c>.
        /// </summary>
        [JsonProperty("access_schedule")]
        [STJS.JsonPropertyName("access_schedule")]
        public SessionItemMetronomeCommitCommitAccessSchedule AccessSchedule { get; set; }

        /// <summary>
        /// Metronome product tags this commit can be drawn down against. Products must have all
        /// specified tags. If <c>applicable_metronome_products</c>,
        /// <c>applicable_metronome_product_tags</c>, and <c>specifiers</c> are all absent, the
        /// commit applies to all products. See Metronome's <a
        /// href="https://docs.metronome.com/api-reference/contracts/edit-a-contract#body-add-commits-items-applicable-product-tags">applicable_product_tags</a>.
        /// </summary>
        [JsonProperty("applicable_metronome_product_tags")]
        [STJS.JsonPropertyName("applicable_metronome_product_tags")]
        public List<string> ApplicableMetronomeProductTags { get; set; }

        /// <summary>
        /// Metronome product IDs this commit can be drawn down against. If
        /// <c>applicable_metronome_products</c>, <c>applicable_metronome_product_tags</c>, and
        /// <c>specifiers</c> are all absent, the commit applies to all products. See Metronome's <a
        /// href="https://docs.metronome.com/api-reference/contracts/edit-a-contract#body-add-commits-items-applicable-product-ids">applicable_product_ids</a>.
        /// </summary>
        [JsonProperty("applicable_metronome_products")]
        [STJS.JsonPropertyName("applicable_metronome_products")]
        public List<string> ApplicableMetronomeProducts { get; set; }

        /// <summary>
        /// Customer selects the balance amount to purchase. Mutually exclusive with
        /// <c>access_schedule</c>.
        /// </summary>
        [JsonProperty("commit_options")]
        [STJS.JsonPropertyName("commit_options")]
        public SessionItemMetronomeCommitCommitCommitOptions CommitOptions { get; set; }

        /// <summary>
        /// The Metronome Custom Pricing Unit credit type ID for this commit. Null when the commit
        /// prices in fiat.
        /// </summary>
        [JsonProperty("credit_type_id")]
        [STJS.JsonPropertyName("credit_type_id")]
        public string CreditTypeId { get; set; }

        /// <summary>
        /// Key-value pairs forwarded to the Metronome commit's <a
        /// href="https://docs.metronome.com/api-reference/contracts/edit-a-contract#body-add-commits-items-custom-fields">custom_fields</a>.
        /// </summary>
        [JsonProperty("custom_fields")]
        [STJS.JsonPropertyName("custom_fields")]
        public Dictionary<string, string> CustomFields { get; set; }

        /// <summary>
        /// Free-form description. Forwarded to the Metronome commit's description.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The Metronome commit ID, populated after successful activation.
        /// </summary>
        [JsonProperty("metronome_commit")]
        [STJS.JsonPropertyName("metronome_commit")]
        public string MetronomeCommit { get; set; }

        /// <summary>
        /// The Metronome product ID for this commit.
        /// </summary>
        [JsonProperty("metronome_product")]
        [STJS.JsonPropertyName("metronome_product")]
        public string MetronomeProduct { get; set; }

        /// <summary>
        /// Display name for the commit. Surfaced on the Metronome commit's name.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Priority for applying the commit. Lower priority values apply first. Forwarded to
        /// Metronome as-is.
        /// </summary>
        [JsonProperty("priority")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("priority")]
        public decimal? Priority { get; set; }

        /// <summary>
        /// Specifies which rates are used to draw down the commit. Accepts <c>commit_rate</c>,
        /// <c>list_rate</c>, <c>COMMIT_RATE</c>, or <c>LIST_RATE</c>.
        /// </summary>
        [JsonProperty("rate_type")]
        [STJS.JsonPropertyName("rate_type")]
        public string RateType { get; set; }

        /// <summary>
        /// Fraction of unused balance that rolls over on a Metronome contract transition. Must be
        /// between <c>0</c> and <c>1</c>. Forwarded to Metronome as-is.
        /// </summary>
        [JsonProperty("rollover_fraction")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("rollover_fraction")]
        public decimal? RolloverFraction { get; set; }

        /// <summary>
        /// Usage filters that determine what draws down the commit. If
        /// <c>applicable_metronome_products</c>, <c>applicable_metronome_product_tags</c>, and
        /// <c>specifiers</c> are all absent, the commit applies to all products. See Metronome's <a
        /// href="https://docs.metronome.com/api-reference/contracts/edit-a-contract#body-add-commits-items-specifiers">specifiers</a>.
        /// </summary>
        [JsonProperty("specifiers")]
        [STJS.JsonPropertyName("specifiers")]
        public List<SessionItemMetronomeCommitCommitSpecifier> Specifiers { get; set; }

        /// <summary>
        /// Tax details for the Stripe product created for this commit. If provided, <c>tax_code</c>
        /// is required.
        /// </summary>
        [JsonProperty("tax_details")]
        [STJS.JsonPropertyName("tax_details")]
        public SessionItemMetronomeCommitCommitTaxDetails TaxDetails { get; set; }
    }
}
