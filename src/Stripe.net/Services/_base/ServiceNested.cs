namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public abstract class ServiceNested<TEntityReturned> : Service<TEntityReturned>
        where TEntityReturned : IStripeEntity
    {
        protected ServiceNested()
            : base(null)
        {
        }

        protected ServiceNested(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("Use the `Request` method instead.")]
        protected TEntityReturned CreateNestedEntity(
            string parentId,
            BaseOptions options,
            RequestOptions requestOptions)
        {
            return this.Request(
                HttpMethod.Post,
                this.ClassUrl(parentId),
                options,
                requestOptions);
        }

        [Obsolete("Use the `RequestAsync` method instead.")]
        protected Task<TEntityReturned> CreateNestedEntityAsync(
            string parentId,
            BaseOptions options,
            RequestOptions requestOptions,
            CancellationToken cancellationToken)
        {
            return this.RequestAsync(
                HttpMethod.Post,
                this.ClassUrl(parentId),
                options,
                requestOptions,
                cancellationToken);
        }

        [Obsolete("Use the `Request` method instead.")]
        protected TEntityReturned DeleteNestedEntity(
            string parentId,
            string id,
            BaseOptions options,
            RequestOptions requestOptions)
        {
            return this.Request(
                HttpMethod.Delete,
                this.InstanceUrl(parentId, id),
                options,
                requestOptions);
        }

        [Obsolete("Use the `RequestAsync` method instead.")]
        protected Task<TEntityReturned> DeleteNestedEntityAsync(
            string parentId,
            string id,
            BaseOptions options,
            RequestOptions requestOptions,
            CancellationToken cancellationToken)
        {
            return this.RequestAsync(
                HttpMethod.Delete,
                this.InstanceUrl(parentId, id),
                options,
                requestOptions,
                cancellationToken);
        }

        [Obsolete("Use the `Request` method instead.")]
        protected TEntityReturned GetNestedEntity(
            string parentId,
            string id,
            BaseOptions options,
            RequestOptions requestOptions)
        {
            return this.Request(
                HttpMethod.Get,
                this.InstanceUrl(parentId, id),
                options,
                requestOptions);
        }

        [Obsolete("Use the `RequestAsync` method instead.")]
        protected Task<TEntityReturned> GetNestedEntityAsync(
            string parentId,
            string id,
            BaseOptions options,
            RequestOptions requestOptions,
            CancellationToken cancellationToken)
        {
            return this.RequestAsync(
                HttpMethod.Get,
                this.InstanceUrl(parentId, id),
                options,
                requestOptions,
                cancellationToken);
        }

        [Obsolete("Use the `RequestAsync` method instead.")]
        protected StripeList<TEntityReturned> ListNestedEntities(
            string parentId,
            ListOptions options,
            RequestOptions requestOptions)
        {
            return this.Request<StripeList<TEntityReturned>>(
                HttpMethod.Get,
                this.ClassUrl(parentId),
                options,
                requestOptions);
        }

        [Obsolete("Use the `RequestAsync` method instead.")]
        protected Task<StripeList<TEntityReturned>> ListNestedEntitiesAsync(
            string parentId,
            ListOptions options,
            RequestOptions requestOptions,
            CancellationToken cancellationToken)
        {
            return this.RequestAsync<StripeList<TEntityReturned>>(
                HttpMethod.Get,
                this.ClassUrl(parentId),
                options,
                requestOptions,
                cancellationToken);
        }

        [Obsolete("Use the `ListRequestAutoPaging` method instead.")]
        protected IEnumerable<TEntityReturned> ListNestedEntitiesAutoPaging(
            string parentId,
            ListOptions options,
            RequestOptions requestOptions)
        {
            return this.ListRequestAutoPaging<TEntityReturned>(
                this.ClassUrl(parentId),
                options,
                requestOptions);
        }

        [Obsolete("Use the `ListRequestAutoPagingAsync` method instead.")]
        protected IAsyncEnumerable<TEntityReturned> ListNestedEntitiesAutoPagingAsync(
            string parentId,
            ListOptions options,
            RequestOptions requestOptions,
            CancellationToken cancellationToken)
        {
            return this.ListRequestAutoPagingAsync<TEntityReturned>(
                this.ClassUrl(parentId),
                options,
                requestOptions,
                cancellationToken);
        }

        [Obsolete("Use the `Request` method instead.")]
        protected TEntityReturned UpdateNestedEntity(
            string parentId,
            string id,
            BaseOptions options,
            RequestOptions requestOptions)
        {
            return this.Request(
                HttpMethod.Post,
                this.InstanceUrl(parentId, id),
                options,
                requestOptions);
        }

        [Obsolete("Use the `RequestAsync` method instead.")]
        protected Task<TEntityReturned> UpdateNestedEntityAsync(
            string parentId,
            string id,
            BaseOptions options,
            RequestOptions requestOptions,
            CancellationToken cancellationToken)
        {
            return this.RequestAsync(
                HttpMethod.Post,
                this.InstanceUrl(parentId, id),
                options,
                requestOptions,
                cancellationToken);
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        protected virtual string ClassUrl(string parentId)
        {
            if (string.IsNullOrWhiteSpace(parentId))
            {
                throw new ArgumentException(
                    "The parent resource ID cannot be null or whitespace.",
                    nameof(parentId));
            }

            return this.BasePath.Replace("{PARENT_ID}", parentId);
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        protected virtual string InstanceUrl(string parentId, string id)
        {
            if (string.IsNullOrWhiteSpace(parentId))
            {
                throw new ArgumentException(
                    "The parent resource ID cannot be null or whitespace.",
                    nameof(parentId));
            }

            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException(
                    "The resource ID cannot be null or whitespace.",
                    nameof(id));
            }

            return $"{this.ClassUrl(parentId)}/{WebUtility.UrlEncode(id)}";
        }
    }
}
