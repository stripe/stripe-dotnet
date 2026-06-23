namespace Stripe
{
    /// <summary>
    /// Options that can be specified on a <see cref="StripeClient"/>.  To use, initialize this
    /// object and pass it into the StripeClient constructor.  Changes to this object after
    /// creating the StripeClient are ignored.
    /// </summary>
    public class StripeClientOptions
    {
        /// <summary>
        /// Gets or sets the <a href="https://stripe.com/docs/api/authentication?lang=dotnet">API
        /// key</a> to use for the request.
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>The client ID used by the client in OAuth requests.</summary>
        public string ClientId { get; set; }

        /// <summary>The <see cref="IHttpClient"/> client to use. If <c>null</c>, an HTTP client will be
        /// created with default parameters.</summary>
        public IHttpClient HttpClient { get; set; }

        /// <summary>Get or set the base URL for Stripe's API.</summary>
        /// <value>The base URL for Stripe's API.</value>
        public string ApiBase { get; set; }

        /// <summary>Gets the base URL for Stripe's OAuth API.</summary>
        /// <value>The base URL for Stripe's OAuth API.</value>
        public string ConnectBase { get; set; }

        /// <summary>Gets the base URL for Stripe's Files API.</summary>
        /// <value>The base URL for Stripe's Files API.</value>
        public string FilesBase { get; set; }

        /// <summary>Gets and sets the base URL for Stripe's Meter Events API.</summary>
        /// <value>The base URL for Stripe's Meter Events API.</value>
        public string MeterEventsBase { get; set; }

        /// <summary>Gets and sets the Stripe-Account header value for requests made from this client.</summary>
        public string StripeAccount { get; set; }

        /// <summary>Gets and sets the Stripe-Context header value for requests made from this client.</summary>
        public string StripeContext { get; set; }

        internal StripeClientOptions Clone()
        {
            return (StripeClientOptions)this.MemberwiseClone();
        }
    }
}
