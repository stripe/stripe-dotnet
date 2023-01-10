namespace Stripe
{
    using System.IO;
    using System.Net;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;

    /// <summary>
    /// A streaming binary response. Body is not assumed to be text for successful responses.
    /// </summary>
    public class StripeStreamedResponse : StripeResponseBase
    {
        private Task<StripeResponse> fetchFullyTask;

        public StripeStreamedResponse(HttpStatusCode statusCode, HttpResponseHeaders headers, Stream body)
            : base(statusCode, headers)
        {
            this.Body = body;
        }

        /// <summary>
        /// Binary response body as a <see cref="Stream"/>.
        /// </summary>
        public Stream Body { get; }

        /// <summary>
        /// Converts this response into a regular <see cref="StripeResponse"/> by
        /// reading the body in full.
        /// </summary>
        /// This assumes that the response body is textual, which will be the case for
        /// most API responses and for errors.
        /// <returns>The response with body fully read.</returns>
        public async Task<StripeResponse> ToStripeResponseAsync()
        {
            // We keep a reference to the task because we can only read the body once.
            if (this.fetchFullyTask == null)
            {
                this.fetchFullyTask = this.FetchResponseAsTextAsync();
            }

            return await this.fetchFullyTask.ConfigureAwait(false);
        }

        private async Task<StripeResponse> FetchResponseAsTextAsync()
        {
            using var reader = new StreamReader(this.Body);
            var content = await reader.ReadToEndAsync().ConfigureAwait(false);
            return new StripeResponse(this.StatusCode, this.Headers, content);
        }
    }
}
