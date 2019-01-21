namespace Stripe
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class RetryHandler : DelegatingHandler
    {
        /// <summary>Initializes a new instance of the <see cref="RetryHandler"/> class.</summary>
        /// <param name="innerHandler">
        /// The inner handler which is responsible for processing the HTTP response messages.
        /// </param>
        public RetryHandler(HttpMessageHandler innerHandler)
            : base(innerHandler)
        {
            Console.WriteLine("hi!");
        }

        /// <summary>
        /// Sends an HTTP request to the inner handler to send to the server as an asynchronous
        /// operation.
        /// </summary>
        /// <param name="request">The HTTP request message to send to the server.</param>
        /// <param name="cancellationToken">A cancellation token to cancel operation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            await Console.Out.WriteLineAsync("hello");
            HttpResponseMessage response = null;
            OperationCanceledException timeoutException = null;

            for (var retry = 0; ;)
            {
                timeoutException = null;
                Console.WriteLine($"attempt = {retry}");

                try
                {
                    response = await base.SendAsync(request, cancellationToken);
                }
                catch (OperationCanceledException e)
                    when (!cancellationToken.IsCancellationRequested)
                {
                    timeoutException = e;
                }

                if (!this.ShouldRetry(retry, timeoutException != null, response))
                {
                    break;
                }

                await Task.Delay(this.SleepTimeMilliseconds(retry));

                retry += 1;
            }

            if (timeoutException != null)
            {
                throw timeoutException;
            }

            return response;
        }

        private bool ShouldRetry(int numRetries, bool timeout, HttpResponseMessage response)
        {
            // TODO: constant
            if (numRetries >= 3)
            {
                return false;
            }

            if (timeout)
            {
                return true;
            }

            if (response.StatusCode == HttpStatusCode.Conflict)
            {
                return true;
            }

            return false;
        }

        private int SleepTimeMilliseconds(int numRetries)
        {
            // TODO: exponential backoff
            return 10;
        }
    }
}
