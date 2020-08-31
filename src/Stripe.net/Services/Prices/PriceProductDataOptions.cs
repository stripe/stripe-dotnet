namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PriceProductDataOptions : INestedOptions, IHasId, IHasMetadata
    {
        /// <summary>
        /// Whether the product is currently available for purchase. Defaults to <c>true</c>.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// The identifier for the product. Must be unique. If not provided, an identifier will be
        /// randomly generated.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The product's name, meant to be displayable to the customer. Whenever this product is
        /// sold via a subscription, name will show up on associated invoice line item descriptions.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// An arbitrary string to be displayed on your customer's credit card or bank statement.
        /// While most banks display this information consistently, some may display it incorrectly
        /// or not at all.
        ///
        /// This may be up to 22 characters. The statement description may not include <c>&lt;</c>,
        /// <c>&gt;</c>, <c>\</c>, <c>"</c>, <c>'</c> characters, and will appear on your customer's
        /// statement in capital letters. Non-ASCII characters are automatically stripped.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// A label that represents units of this product in Stripe and on customers’ receipts and
        /// invoices. When set, this will be included in associated invoice line item descriptions.
        /// </summary>
        [JsonProperty("unit_label")]
        public string UnitLabel { get; set; }
    }
}
