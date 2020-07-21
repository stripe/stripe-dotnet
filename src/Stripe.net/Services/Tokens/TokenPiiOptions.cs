namespace Stripe
{
    using Newtonsoft.Json;

    public class TokenPiiOptions : INestedOptions
    {
        /// <summary>
        /// The <c>IdNumber</c> for the PII, in string form.
        /// </summary>
        [JsonProperty("id_number")]
        public string IdNumber { get; set; }
    }
}
