// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class TestClockService : Service,
        ICreatable<TestClock, TestClockCreateOptions>,
        IDeletable<TestClock, TestClockDeleteOptions>,
        IListable<TestClock, TestClockListOptions>,
        IRetrievable<TestClock, TestClockGetOptions>
    {
        public TestClockService()
        {
        }

        internal TestClockService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public TestClockService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Starts advancing a test clock to a specified time in the future. Advancement is done
        /// when status changes to <c>Ready</c>.</p>.
        /// </summary>
        public virtual TestClock Advance(string id, TestClockAdvanceOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<TestClock>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/test_clocks/{WebUtility.UrlEncode(id)}/advance", options, requestOptions);
        }

        /// <summary>
        /// <p>Starts advancing a test clock to a specified time in the future. Advancement is done
        /// when status changes to <c>Ready</c>.</p>.
        /// </summary>
        public virtual Task<TestClock> AdvanceAsync(string id, TestClockAdvanceOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TestClock>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/test_clocks/{WebUtility.UrlEncode(id)}/advance", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Creates a new test clock that can be attached to new customers and quotes.</p>.
        /// </summary>
        public virtual TestClock Create(TestClockCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<TestClock>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/test_clocks", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a new test clock that can be attached to new customers and quotes.</p>.
        /// </summary>
        public virtual Task<TestClock> CreateAsync(TestClockCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TestClock>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/test_clocks", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Deletes a test clock.</p>.
        /// </summary>
        public virtual TestClock Delete(string id, TestClockDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<TestClock>(BaseAddress.Api, HttpMethod.Delete, $"/v1/test_helpers/test_clocks/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Deletes a test clock.</p>.
        /// </summary>
        public virtual Task<TestClock> DeleteAsync(string id, TestClockDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TestClock>(BaseAddress.Api, HttpMethod.Delete, $"/v1/test_helpers/test_clocks/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a test clock.</p>.
        /// </summary>
        public virtual TestClock Get(string id, TestClockGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<TestClock>(BaseAddress.Api, HttpMethod.Get, $"/v1/test_helpers/test_clocks/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a test clock.</p>.
        /// </summary>
        public virtual Task<TestClock> GetAsync(string id, TestClockGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TestClock>(BaseAddress.Api, HttpMethod.Get, $"/v1/test_helpers/test_clocks/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your test clocks.</p>.
        /// </summary>
        public virtual StripeList<TestClock> List(TestClockListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<TestClock>>(BaseAddress.Api, HttpMethod.Get, $"/v1/test_helpers/test_clocks", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your test clocks.</p>.
        /// </summary>
        public virtual Task<StripeList<TestClock>> ListAsync(TestClockListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<TestClock>>(BaseAddress.Api, HttpMethod.Get, $"/v1/test_helpers/test_clocks", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your test clocks.</p>.
        /// </summary>
        public virtual IEnumerable<TestClock> ListAutoPaging(TestClockListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<TestClock>($"/v1/test_helpers/test_clocks", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your test clocks.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<TestClock> ListAutoPagingAsync(TestClockListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<TestClock>($"/v1/test_helpers/test_clocks", options, requestOptions, cancellationToken);
        }
    }
}
