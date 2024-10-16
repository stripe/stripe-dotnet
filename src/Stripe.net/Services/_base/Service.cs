namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public abstract class Service
    {
        private IStripeClient client;
        private ApiRequestor requestor;

        /// <summary>
        /// Initializes a new instance of the <see cref="Service"/> class.
        /// </summary>
        protected Service()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Service"/> class with a
        /// custom <see cref="ApiRequestor"/>.
        /// </summary>
        /// <param name="requestor">The requestor used by the service to send requests.</param>
        internal Service(ApiRequestor requestor)
        {
            this.requestor = requestor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Service"/> class with a
        /// custom <see cref="IStripeClient"/>.
        /// </summary>
        /// <param name="client">The client used by the service to send requests.</param>
        protected Service(IStripeClient client)
            : this(ApiRequestorAdapter.Adapt(client))
        {
        }

        /// <summary>
        /// Gets or sets the client used by this service to send requests. If no client was set when the
        /// service instance was created, then the default client in
        /// <see cref="StripeConfiguration.StripeClient"/> is used instead.
        /// </summary>
        /// <remarks>
        /// Setting the client at runtime may not be thread-safe.
        /// If you wish to use a custom client, it is recommended that you pass it to the service's constructor and not change it during the service's lifetime.
        /// </remarks>
        [Obsolete("This member will be removed in a future version")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IStripeClient Client
        {
            get => this.client ?? StripeConfiguration.StripeClient;
            set => this.client = value;
        }

        internal ApiRequestor Requestor
        {
#pragma warning disable CS0618 // Type or member is obsolete
            get => this.requestor ?? ApiRequestorAdapter.Adapt(this.Client);
#pragma warning restore CS0618 // Type or member is obsolete
        }

        internal T Request<T>(
            BaseAddress baseAddress,
            HttpMethod method,
            string path,
            BaseOptions options,
            RequestOptions requestOptions)
            where T : IStripeEntity
        {
            return this.RequestAsync<T>(baseAddress, method, path, options, requestOptions)
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        internal Stream RequestStreaming(
            BaseAddress baseAddress,
            HttpMethod method,
            string path,
            BaseOptions options,
            RequestOptions requestOptions)
        {
            return this.RequestStreamingAsync(baseAddress, method, path, options, requestOptions)
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        internal async Task<T> RequestAsync<T>(
            BaseAddress baseAddress,
            HttpMethod method,
            string path,
            BaseOptions options,
            RequestOptions requestOptions,
            CancellationToken cancellationToken = default)
            where T : IStripeEntity
        {
            return await this.Requestor.RequestAsync<T>(
                baseAddress,
                method,
                path,
                options,
                requestOptions,
                cancellationToken).ConfigureAwait(false);
        }

        internal async Task<Stream> RequestStreamingAsync(
            BaseAddress baseAddress,
            HttpMethod method,
            string path,
            BaseOptions options,
            RequestOptions requestOptions,
            CancellationToken cancellationToken = default)
        {
            var stream = await this.Requestor.RequestStreamingAsync(
                    baseAddress,
                    method,
                    path,
                    options,
                    requestOptions,
                    cancellationToken)
                .ConfigureAwait(false);
            return stream;
        }

        internal IEnumerable<T> ListRequestAutoPaging<T>(
            string url,
            BaseOptions options,
            RequestOptions requestOptions)
            where T : IStripeEntity
        {
            var apiMode = ApiModeUtils.GetApiMode(url);
#if NET461
            if (apiMode == ApiMode.V2)
            {
                return
                    this.V2ListRequestAutoPagingSync<T>(url, options, requestOptions);
            }

            return
                this.V1ListRequestAutoPagingSync<T>(url, options as ListOptions, requestOptions);
#else
            if (apiMode == ApiMode.V2)
            {
                return AsyncUtils.ToEnumerable(
                    this.V2ListRequestAutoPagingAsync<T>(url, options, requestOptions));
            }

            return AsyncUtils.ToEnumerable(
                this.V1ListRequestAutoPagingAsync<T>(url, options as ListOptions, requestOptions));
#endif
        }

#if NET461
        internal IEnumerable<T> V1ListRequestAutoPagingSync<T>(
            string url,
            ListOptions options,
            RequestOptions requestOptions)
            where T : IStripeEntity
        {
            var page = this.Request<StripeList<T>>(
                BaseAddress.Api,
                HttpMethod.Get,
                url,
                options,
                requestOptions);

            options = options ?? new ListOptions();
            bool iterateBackward = false;

            // Backward iterating activates if we have an `EndingBefore`
            // constraint and not a `StartingAfter` constraint
            if (!string.IsNullOrEmpty(options.EndingBefore) && string.IsNullOrEmpty(options.StartingAfter))
            {
                iterateBackward = true;
            }

            while (true)
            {
                if (iterateBackward)
                {
                    page.Reverse();
                }

                string itemId = null;
                foreach (var item in page)
                {
                    // Elements in `StripeList` instances are decoded by `StripeObjectConverter`,
                    // which returns `null` for objects it doesn't know how to decode.
                    // When auto-paginating, we simply ignore these null elements but still return
                    // other elements.
                    if (item == null)
                    {
                        continue;
                    }

                    itemId = ((IHasId)item).Id;
                    yield return item;
                }

                if (!page.HasMore || string.IsNullOrEmpty(itemId))
                {
                    break;
                }

                if (iterateBackward)
                {
                    options.EndingBefore = itemId;
                }
                else
                {
                    options.StartingAfter = itemId;
                }

                page = this.Request<StripeList<T>>(
                    BaseAddress.Api,
                    HttpMethod.Get,
                    url,
                    options,
                    requestOptions);
            }
        }

        internal IEnumerable<T> V2ListRequestAutoPagingSync<T>(
            string url,
            BaseOptions options,
            RequestOptions requestOptions)
            where T : IStripeEntity
        {
            var page = this.Request<Stripe.V2.StripeList<T>>(
                BaseAddress.Api,
                HttpMethod.Get,
                url,
                options,
                requestOptions);

            while (true)
            {
                foreach (var item in page)
                {
                    // Elements in `StripeList` instances are decoded by `StripeObjectConverter`,
                    // which returns `null` for objects it doesn't know how to decode.
                    // When auto-paginating, we simply ignore these null elements but still return
                    // other elements.
                    if (item == null)
                    {
                        continue;
                    }

                    yield return item;
                }

                if (page.NextPageUrl == null)
                {
                    break;
                }

                // no options (params) needed for nextPageUrl calls
                page = this.Request<Stripe.V2.StripeList<T>>(
                    BaseAddress.Api,
                    HttpMethod.Get,
                    page.NextPageUrl,
                    new BaseOptions(),
                    requestOptions);
            }
        }

#endif
        internal async IAsyncEnumerable<T> V2ListRequestAutoPagingAsync<T>(
            string url,
            BaseOptions options,
            RequestOptions requestOptions,
            [EnumeratorCancellation] CancellationToken cancellationToken = default)
            where T : IStripeEntity
        {
            var page = await this.RequestAsync<Stripe.V2.StripeList<T>>(
                BaseAddress.Api,
                HttpMethod.Get,
                url,
                options,
                requestOptions,
                cancellationToken).ConfigureAwait(false);

            while (true)
            {
                cancellationToken.ThrowIfCancellationRequested();

                foreach (var item in page)
                {
                    cancellationToken.ThrowIfCancellationRequested();

                    // Elements in `StripeList` instances are decoded by `StripeObjectConverter`,
                    // which returns `null` for objects it doesn't know how to decode.
                    // When auto-paginating, we simply ignore these null elements but still return
                    // other elements.
                    if (item == null)
                    {
                        continue;
                    }

                    yield return item;
                }

                if (page.NextPageUrl == null)
                {
                    break;
                }

                // no options (params) needed for nextPageUrl calls
                page = await this.RequestAsync<Stripe.V2.StripeList<T>>(
                    BaseAddress.Api,
                    HttpMethod.Get,
                    page.NextPageUrl,
                    new BaseOptions(),
                    requestOptions,
                    cancellationToken).ConfigureAwait(false);
            }
        }

        internal IAsyncEnumerable<T> ListRequestAutoPagingAsync<T>(
            string url,
            BaseOptions options,
            RequestOptions requestOptions,
            CancellationToken cancellationToken = default)
            where T : IStripeEntity
        {
            var apiMode = ApiModeUtils.GetApiMode(url);
            if (apiMode == ApiMode.V2)
            {
                return this.V2ListRequestAutoPagingAsync<T>(
                    url,
                    options,
                    requestOptions,
                    cancellationToken);
            }
            else
            {
                return this.V1ListRequestAutoPagingAsync<T>(
                    url,
                    options as ListOptions,
                    requestOptions,
                    cancellationToken);
            }
        }

        internal async IAsyncEnumerable<T> V1ListRequestAutoPagingAsync<T>(
            string url,
            ListOptions options,
            RequestOptions requestOptions,
            [EnumeratorCancellation] CancellationToken cancellationToken = default)
            where T : IStripeEntity
        {
            var page = await this.RequestAsync<StripeList<T>>(
                BaseAddress.Api,
                HttpMethod.Get,
                url,
                options,
                requestOptions,
                cancellationToken).ConfigureAwait(false);

            options = options ?? new ListOptions();
            bool iterateBackward = false;

            // Backward iterating activates if we have an `EndingBefore`
            // constraint and not a `StartingAfter` constraint
            if (!string.IsNullOrEmpty(options.EndingBefore) && string.IsNullOrEmpty(options.StartingAfter))
            {
                iterateBackward = true;
            }

            while (true)
            {
                cancellationToken.ThrowIfCancellationRequested();

                if (iterateBackward)
                {
                    page.Reverse();
                }

                string itemId = null;
                foreach (var item in page)
                {
                    cancellationToken.ThrowIfCancellationRequested();

                    // Elements in `StripeList` instances are decoded by `StripeObjectConverter`,
                    // which returns `null` for objects it doesn't know how to decode.
                    // When auto-paginating, we simply ignore these null elements but still return
                    // other elements.
                    if (item == null)
                    {
                        continue;
                    }

                    itemId = ((IHasId)item).Id;
                    yield return item;
                }

                if (!page.HasMore || string.IsNullOrEmpty(itemId))
                {
                    break;
                }

                if (iterateBackward)
                {
                    options.EndingBefore = itemId;
                }
                else
                {
                    options.StartingAfter = itemId;
                }

                page = await this.RequestAsync<StripeList<T>>(
                    BaseAddress.Api,
                    HttpMethod.Get,
                    url,
                    options,
                    requestOptions,
                    cancellationToken).ConfigureAwait(false);
            }
        }

        internal IEnumerable<T> SearchRequestAutoPaging<T>(
            string url,
            SearchOptions options,
            RequestOptions requestOptions)
            where T : IStripeEntity
        {
#if NET461
            return
                this.SearchRequestAutoPagingSync<T>(url, options, requestOptions);
#else
            return AsyncUtils.ToEnumerable(
                this.SearchRequestAutoPagingAsync<T>(url, options, requestOptions));
#endif
        }

#if NET461
        private IEnumerable<T> SearchRequestAutoPagingSync<T>(
            string url,
            SearchOptions options,
            RequestOptions requestOptions)
            where T : IStripeEntity
        {
            var page = this.Request<StripeSearchResult<T>>(
                BaseAddress.Api,
                HttpMethod.Get,
                url,
                options,
                requestOptions);

            options = options ?? new SearchOptions();

            while (true)
            {
                foreach (var item in page)
                {
                    // Elements in `StripeList` instances are decoded by `StripeObjectConverter`,
                    // which returns `null` for objects it doesn't know how to decode.
                    // When auto-paginating, we simply ignore these null elements but still return
                    // other elements.
                    if (item == null)
                    {
                        continue;
                    }

                    yield return item;
                }

                if (!page.HasMore || string.IsNullOrEmpty(page.NextPage))
                {
                    break;
                }

                options.Page = page.NextPage;

                page = this.Request<StripeSearchResult<T>>(
                    BaseAddress.Api,
                    HttpMethod.Get,
                    url,
                    options,
                    requestOptions);
            }
}

#endif
        internal async IAsyncEnumerable<T> SearchRequestAutoPagingAsync<T>(
            string url,
            SearchOptions options,
            RequestOptions requestOptions,
            [EnumeratorCancellation] CancellationToken cancellationToken = default)
            where T : IStripeEntity
        {
            var page = await this.RequestAsync<StripeSearchResult<T>>(
                BaseAddress.Api,
                HttpMethod.Get,
                url,
                options,
                requestOptions,
                cancellationToken).ConfigureAwait(false);

            options = options ?? new SearchOptions();

            while (true)
            {
                cancellationToken.ThrowIfCancellationRequested();
                foreach (var item in page)
                {
                    // Elements in `StripeList` instances are decoded by `StripeObjectConverter`,
                    // which returns `null` for objects it doesn't know how to decode.
                    // When auto-paginating, we simply ignore these null elements but still return
                    // other elements.
                    if (item == null)
                    {
                        continue;
                    }

                    yield return item;
                }

                if (!page.HasMore || string.IsNullOrEmpty(page.NextPage))
                {
                    break;
                }

                options.Page = page.NextPage;

                page = await this.RequestAsync<StripeSearchResult<T>>(
                    BaseAddress.Api,
                    HttpMethod.Get,
                    url,
                    options,
                    requestOptions,
                    cancellationToken).ConfigureAwait(false);
            }
        }
    }
}
