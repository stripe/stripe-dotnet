namespace Stripe
{
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public abstract class ServiceNested<EntityReturned> : Service<EntityReturned>
        where EntityReturned : IStripeEntity
    {
        protected ServiceNested()
            : base(null)
        {
        }

        protected ServiceNested(string apiKey)
            : base(apiKey)
        {
        }

        protected EntityReturned CreateNestedEntity(
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

        protected Task<EntityReturned> CreateNestedEntityAsync(
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

        protected EntityReturned DeleteNestedEntity(
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

        protected Task<EntityReturned> DeleteNestedEntityAsync(
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

        protected EntityReturned GetNestedEntity(
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

        protected Task<EntityReturned> GetNestedEntityAsync(
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

        protected StripeList<EntityReturned> ListNestedEntities(
            string parentId,
            ListOptions options,
            RequestOptions requestOptions)
        {
            return this.Request<StripeList<EntityReturned>>(
                HttpMethod.Get,
                this.ClassUrl(parentId),
                options,
                requestOptions);
        }

        protected Task<StripeList<EntityReturned>> ListNestedEntitiesAsync(
            string parentId,
            ListOptions options,
            RequestOptions requestOptions,
            CancellationToken cancellationToken)
        {
            return this.RequestAsync<StripeList<EntityReturned>>(
                HttpMethod.Get,
                this.ClassUrl(parentId),
                options,
                requestOptions,
                cancellationToken);
        }

        protected IEnumerable<EntityReturned> ListNestedEntitiesAutoPaging(
            string parentId,
            ListOptions options,
            RequestOptions requestOptions)
        {
            return this.ListRequestAutoPaging<EntityReturned>(
                this.ClassUrl(parentId),
                options,
                requestOptions);
        }

        protected EntityReturned UpdateNestedEntity(
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

        protected Task<EntityReturned> UpdateNestedEntityAsync(
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

        protected virtual string ClassUrl(string parentId)
        {
            return this.BasePath.Replace("{PARENT_ID}", parentId);
        }

        protected virtual string InstanceUrl(string parentId, string id)
        {
            return $"{this.ClassUrl(parentId)}/{WebUtility.UrlEncode(id)}";
        }
    }
}
