// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class FormListOptions : ListOptions
    {
        /// <summary>
        /// The payee whose volume is represented on the tax form.
        /// </summary>
        [JsonProperty("payee")]
        public FormPayeeOptions Payee { get; set; }

        /// <summary>
        /// An optional filter on the list, based on the object <c>type</c> field. Without the
        /// filter, the list includes all current and future tax form types. If your integration
        /// expects only one type of tax form in the response, make sure to provide a type value in
        /// the request.
        /// One of: <c>au_serr</c>, <c>ca_mrdp</c>, <c>eu_dac7</c>, <c>gb_mrdp</c>, <c>nz_mrdp</c>,
        /// <c>us_1099_k</c>, <c>us_1099_misc</c>, or <c>us_1099_nec</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
