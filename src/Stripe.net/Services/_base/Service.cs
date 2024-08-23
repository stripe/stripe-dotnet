namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    /// <summary>Abstract base class for all services.</summary>
    /// <typeparam name="TEntityReturned">
    /// The type of <see cref="IStripeEntity"/> that this service returns.
    /// </typeparam>
    public abstract class Service<TEntityReturned>
        where TEntityReturned : IStripeEntity
    {
        private IStripeClient client;

        /// <summary>
        /// Initializes a new instance of the <see cref="Service{EntityReturned}"/> class.
        /// </summary>
        protected Service()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Service{EntityReturned}"/> class with a
        /// custom <see cref="IStripeClient"/>.
        /// </summary>
        /// <param name="client">The client used by the service to send requests.</param>
        protected Service(IStripeClient client)
        {
            this.client = client;
        }

        [Obsolete("Please use the `Request` or `RequestAsync` method providing the full path.")]
        public abstract string BasePath { get; }

        public virtual string BaseUrl => this.Client.ApiBase;

        /// <summary>
        /// Gets or sets the client used by this service to send requests. If no client was set when the
        /// service instance was created, then the default client in
        /// <see cref="StripeConfiguration.StripeClient"/> is used instead.
        /// </summary>
        /// <remarks>
        /// Setting the client at runtime may not be thread-safe.
        /// If you wish to use a custom client, it is recommended that you pass it to the service's constructor and not change it during the service's lifetime.
        /// </remarks>
        public IStripeClient Client
        {
            get => this.client ?? StripeConfiguration.StripeClient;
            set => this.client = value;
        }

        [Obsolete("Use the `Request` method instead.")]
        protected TEntityReturned CreateEntity(BaseOptions options, RequestOptions requestOptions)
        {
            return this.Request(
                HttpMethod.Post,
                this.ClassUrl(),
                options,
                requestOptions);
        }

        [Obsolete("Use the `RequestAsync` method instead.")]
        protected Task<TEntityReturned> CreateEntityAsync(
            BaseOptions options,
            RequestOptions requestOptions,
            CancellationToken cancellationToken)
        {
            return this.RequestAsync(
                HttpMethod.Post,
                this.ClassUrl(),
                options,
                requestOptions,
                cancellationToken);
        }

        [Obsolete("Use the `Request` method instead.")]
        protected TEntityReturned DeleteEntity(
            string id,
            BaseOptions options,
            RequestOptions requestOptions)
        {
            return this.Request(
                HttpMethod.Delete,
                this.InstanceUrl(id),
                options,
                requestOptions);
        }

        [Obsolete("Use the `RequestAsync` method instead.")]
        protected Task<TEntityReturned> DeleteEntityAsync(
            string id,
            BaseOptions options,
            RequestOptions requestOptions,
            CancellationToken cancellationToken)
        {
            return this.RequestAsync(
                HttpMethod.Delete,
                this.InstanceUrl(id),
                options,
                requestOptions,
                cancellationToken);
        }

        [Obsolete("Use the `Request` method instead.")]
        protected TEntityReturned GetEntity(
            string id,
            BaseOptions options,
            RequestOptions requestOptions)
        {
            return this.Request(
                HttpMethod.Get,
                this.InstanceUrl(id),
                options,
                requestOptions);
        }

        [Obsolete("Use the `RequestAsync` method instead.")]
        protected Task<TEntityReturned> GetEntityAsync(
            string id,
            BaseOptions options,
            RequestOptions requestOptions,
            CancellationToken cancellationToken)
        {
            return this.RequestAsync(
                HttpMethod.Get,
                this.InstanceUrl(id),
                options,
                requestOptions,
                cancellationToken);
        }

        [Obsolete("Use the `Request` method instead.")]
        protected StripeList<TEntityReturned> ListEntities(
            ListOptions options,
            RequestOptions requestOptions)
        {
            return this.Request<StripeList<TEntityReturned>>(
                HttpMethod.Get,
                this.ClassUrl(),
                options,
                requestOptions);
        }

        [Obsolete("Use the `RequestAsync` method instead.")]
        protected Task<StripeList<TEntityReturned>> ListEntitiesAsync(
            ListOptions options,
            RequestOptions requestOptions,
            CancellationToken cancellationToken)
        {
            return this.RequestAsync<StripeList<TEntityReturned>>(
                HttpMethod.Get,
                this.ClassUrl(),
                options,
                requestOptions,
                cancellationToken);
        }

        [Obsolete("Use the `ListRequestAutoPaging` method instead.")]
        protected IEnumerable<TEntityReturned> ListEntitiesAutoPaging(
            ListOptions options,
            RequestOptions requestOptions)
        {
            return this.ListRequestAutoPaging<TEntityReturned>(
                this.ClassUrl(),
                options,
                requestOptions);
        }

        [Obsolete("Use the `ListRequestAutoPagingAsync` method instead.")]
        protected IAsyncEnumerable<TEntityReturned> ListEntitiesAutoPagingAsync(
            ListOptions options,
            RequestOptions requestOptions,
            CancellationToken cancellationToken)
        {
            return this.ListRequestAutoPagingAsync<TEntityReturned>(
                this.ClassUrl(),
                options,
                requestOptions,
                cancellationToken);
        }

        [Obsolete("Use the `Request` method instead.")]
        protected TEntityReturned UpdateEntity(
            string id,
            BaseOptions options,
            RequestOptions requestOptions)
        {
            return this.Request(
                HttpMethod.Post,
                this.InstanceUrl(id),
                options,
                requestOptions);
        }

        [Obsolete("Use the `RequestAsync` method instead.")]
        protected Task<TEntityReturned> UpdateEntityAsync(
            string id,
            BaseOptions options,
            RequestOptions requestOptions,
            CancellationToken cancellationToken)
        {
            return this.RequestAsync(
                HttpMethod.Post,
                this.InstanceUrl(id),
                options,
                requestOptions,
                cancellationToken);
        }

        protected TEntityReturned Request(
            HttpMethod method,
            string path,
            BaseOptions options,
            RequestOptions requestOptions)
        {
            return this.Request<TEntityReturned>(
                method,
                path,
                options,
                requestOptions);
        }

        protected Task<TEntityReturned> RequestAsync(
            HttpMethod method,
            string path,
            BaseOptions options,
            RequestOptions requestOptions,
            CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TEntityReturned>(
                method,
                path,
                options,
                requestOptions,
                cancellationToken);
        }

        protected T Request<T>(
            HttpMethod method,
            string path,
            BaseOptions options,
            RequestOptions requestOptions)
            where T : IStripeEntity
        {
            return this.RequestAsync<T>(method, path, options, requestOptions)
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        protected Stream RequestStreaming(
            HttpMethod method,
            string path,
            BaseOptions options,
            RequestOptions requestOptions)
        {
            return this.RequestStreamingAsync(method, path, options, requestOptions)
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        protected async Task<T> RequestAsync<T>(
            HttpMethod method,
            string path,
            BaseOptions options,
            RequestOptions requestOptions,
            CancellationToken cancellationToken = default)
            where T : IStripeEntity
        {
            requestOptions = this.SetupRequestOptions(requestOptions);
            return await this.Client.RequestAsync<T>(
                method,
                path,
                options,
                requestOptions,
                cancellationToken).ConfigureAwait(false);
        }

        protected async Task<Stream> RequestStreamingAsync(
            HttpMethod method,
            string path,
            BaseOptions options,
            RequestOptions requestOptions,
            CancellationToken cancellationToken = default)
        {
            requestOptions = this.SetupRequestOptions(requestOptions);
            var stream = await this.Client.RequestStreamingAsync(
                    method,
                    path,
                    options,
                    requestOptions,
                    cancellationToken)
                .ConfigureAwait(false);
            return stream;
        }

        protected IEnumerable<T> ListRequestAutoPaging<T>(
            string url,
            ListOptions options,
            RequestOptions requestOptions)
            where T : IStripeEntity
        {
#if NET461
            return
                this.ListRequestAutoPagingSync<T>(url, options, requestOptions);
#else
            return AsyncUtils.ToEnumerable(
                this.ListRequestAutoPagingAsync<T>(url, options, requestOptions));
#endif
        }

#if NET461
        protected IEnumerable<T> ListRequestAutoPagingSync<T>(
            string url,
            ListOptions options,
            RequestOptions requestOptions)
            where T : IStripeEntity
        {
            var page = this.Request<StripeList<T>>(
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
                    HttpMethod.Get,
                    url,
                    options,
                    requestOptions);
            }
        }

#endif
        protected async IAsyncEnumerable<T> ListRequestAutoPagingAsync<T>(
            string url,
            ListOptions options,
            RequestOptions requestOptions,
            [EnumeratorCancellation] CancellationToken cancellationToken = default)
            where T : IStripeEntity
        {
            var page = await this.RequestAsync<StripeList<T>>(
                HttpMethod.Get,
                url,
                options,
                requestOptions,
                cancellationToken);

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
                    HttpMethod.Get,
                    url,
                    options,
                    requestOptions,
                    cancellationToken);
            }
        }

        protected IEnumerable<T> SearchRequestAutoPaging<T>(
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
                    HttpMethod.Get,
                    url,
                    options,
                    requestOptions);
            }
}

#endif
        protected async IAsyncEnumerable<T> SearchRequestAutoPagingAsync<T>(
            string url,
            SearchOptions options,
            RequestOptions requestOptions,
            [EnumeratorCancellation] CancellationToken cancellationToken = default)
            where T : IStripeEntity
        {
            var page = await this.RequestAsync<StripeSearchResult<T>>(
                HttpMethod.Get,
                url,
                options,
                requestOptions,
                cancellationToken);

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
                    HttpMethod.Get,
                    url,
                    options,
                    requestOptions,
                    cancellationToken);
            }
        }

        protected RequestOptions SetupRequestOptions(RequestOptions requestOptions)
        {
            if (requestOptions == null)
            {
                requestOptions = new RequestOptions();
            }

            requestOptions.BaseUrl = requestOptions.BaseUrl ?? this.BaseUrl;

            return requestOptions;
        }

        [Obsolete("Please use the `Request` or `RequestAsync` method providing the full path.")]
        protected virtual string ClassUrl()
        {
            return this.BasePath;
        }

        [Obsolete("Please use the `Request` or `RequestAsync` method providing the full path.")]
        protected virtual string InstanceUrl(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException(
                    "The resource ID cannot be null or whitespace.",
                    nameof(id));
            }

            return $"{this.ClassUrl()}/{WebUtility.UrlEncode(id)}";
        }
    }
}
