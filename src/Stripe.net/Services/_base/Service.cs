namespace Stripe
{
    using System;
    using System.Collections.Generic;
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

        protected TEntityReturned CreateEntity(BaseOptions options, RequestOptions requestOptions)
        {
            return this.Request(
                HttpMethod.Post,
                this.ClassUrl(),
                options,
                requestOptions);
        }

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

        protected IEnumerable<TEntityReturned> ListEntitiesAutoPaging(
            ListOptions options,
            RequestOptions requestOptions)
        {
            return this.ListRequestAutoPaging<TEntityReturned>(
                this.ClassUrl(),
                options,
                requestOptions);
        }

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

        protected IEnumerable<T> ListRequestAutoPaging<T>(
            string url,
            ListOptions options,
            RequestOptions requestOptions)
            where T : IStripeEntity
        {
            return AsyncUtils.ToEnumerable(
                this.ListRequestAutoPagingAsync<T>(url, options, requestOptions));
        }

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

        protected RequestOptions SetupRequestOptions(RequestOptions requestOptions)
        {
            if (requestOptions == null)
            {
                requestOptions = new RequestOptions();
            }

            requestOptions.BaseUrl = requestOptions.BaseUrl ?? this.BaseUrl;

            return requestOptions;
        }

        protected virtual string ClassUrl()
        {
            return this.BasePath;
        }

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

        private static bool IsStripeList<T>()
        {
            var typeInfo = typeof(T).GetTypeInfo();
            return typeInfo.IsGenericType
                && typeInfo.GetGenericTypeDefinition() == typeof(StripeList<>);
        }
    }
}
