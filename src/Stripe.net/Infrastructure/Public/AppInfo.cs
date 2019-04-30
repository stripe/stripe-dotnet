namespace Stripe
{
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Contains information about the "app" which this integration belongs to. This should be
    /// reserved for plugins that wish to identify themselves with Stripe.
    /// </summary>
    public class AppInfo
    {
        /// <summary>Gets or sets the name of your application (e.g. <c>"MyAwesomeApp"</c>).</summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets your Stripe Partner ID (e.g. <c>"pp_partner_1234"</c>), if you have one.
        /// </summary>
        [JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>Gets or sets the version of your application (e.g. <c>"1.2.34"</c>).</summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>Gets or sets the website for your application (e.g. <c>"https://myawesomeapp.info"</c>).</summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Formats a <see cref="AppInfo"/> in a way that's suitable to be appended to a
        /// <c>User-Agent</c> string.
        /// </summary>
        /// <returns>The formatted app information to be appended.</returns>
        /// <remarks>
        /// Note that this format is shared between all libraries so if it's changed, it should be
        /// changed everywhere.
        /// </remarks>
        public string FormatUserAgent()
        {
            var b = new StringBuilder();

            b.Append(this.Name);

            if (!string.IsNullOrEmpty(this.Version))
            {
                b.Append("/");
                b.Append(this.Version);
            }

            if (!string.IsNullOrEmpty(this.Url))
            {
                b.Append(" (");
                b.Append(this.Url);
                b.Append(")");
            }

            return b.ToString();
        }
    }
}
