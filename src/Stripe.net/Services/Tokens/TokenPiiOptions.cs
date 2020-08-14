namespace Stripe
{
    using Newtonsoft.Json;

    public class TokenPiiOptions : INestedOptions
    {
        /// <summary>
        /// The <c>id_number</c> for the PII, in string form.
        /// </summary>
        [JsonProperty("id_number")]
        public string IdNumber { get; set; }
    }
}
