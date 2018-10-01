namespace Stripe
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;

    using Stripe.Infrastructure;

    public abstract class ServiceNested<EntityReturned> : Service<EntityReturned>
        where EntityReturned : StripeEntity
    {
        protected ServiceNested()
            : base(null)
        {
        }

        protected ServiceNested(string apiKey)
            : base(apiKey)
        {
        }

        protected EntityReturned CreateNestedEntity(string parentId, BaseOptions options, RequestOptions requestOptions)
        {
            return this.PostRequest<EntityReturned>(this.ClassUrl(parentId), options, requestOptions);
        }

        protected Task<EntityReturned> CreateNestedEntityAsync(string parentId, BaseOptions options, RequestOptions requestOptions, CancellationToken cancellationToken)
        {
            return this.PostRequestAsync<EntityReturned>(this.ClassUrl(parentId), options, requestOptions, cancellationToken);
        }

        protected EntityReturned DeleteNestedEntity(string parentId, string id, BaseOptions options, RequestOptions requestOptions)
        {
            return this.DeleteRequest<EntityReturned>(this.InstanceUrl(parentId, id), options, requestOptions);
        }

        protected Task<EntityReturned> DeleteNestedEntityAsync(string parentId, string id, BaseOptions options, RequestOptions requestOptions, CancellationToken cancellationToken)
        {
            return this.DeleteRequestAsync<EntityReturned>(this.InstanceUrl(parentId, id), options, requestOptions, cancellationToken);
        }

        protected EntityReturned GetNestedEntity(string parentId, string id, BaseOptions options, RequestOptions requestOptions)
        {
            return this.GetRequest<EntityReturned>(this.InstanceUrl(parentId, id), options, requestOptions);
        }

        protected Task<EntityReturned> GetNestedEntityAsync(string parentId, string id, BaseOptions options, RequestOptions requestOptions, CancellationToken cancellationToken)
        {
            return this.GetRequestAsync<EntityReturned>(this.InstanceUrl(parentId, id), options, requestOptions, cancellationToken);
        }

        protected StripeList<EntityReturned> ListNestedEntities(string parentId, BaseOptions options, RequestOptions requestOptions)
        {
            return this.GetRequest<StripeList<EntityReturned>>(this.ClassUrl(parentId), options, requestOptions);
        }

        protected Task<StripeList<EntityReturned>> ListNestedEntitiesAsync(string parentId, BaseOptions options, RequestOptions requestOptions, CancellationToken cancellationToken)
        {
            return this.GetRequestAsync<StripeList<EntityReturned>>(this.ClassUrl(parentId), options, requestOptions, cancellationToken);
        }

        protected EntityReturned UpdateNestedEntity(string parentId, string id, BaseOptions options, RequestOptions requestOptions)
        {
            return this.PostRequest<EntityReturned>(this.InstanceUrl(parentId, id), options, requestOptions);
        }

        protected Task<EntityReturned> UpdateNestedEntityAsync(string parentId, string id, BaseOptions options, RequestOptions requestOptions, CancellationToken cancellationToken)
        {
            return this.PostRequestAsync<EntityReturned>(this.InstanceUrl(parentId, id), options, requestOptions, cancellationToken);
        }

        protected virtual string ClassUrl(string parentId, string baseUrl = null)
        {
            baseUrl = baseUrl ?? StripeConfiguration.GetApiBase();
            return $"{baseUrl}{this.BasePath.Replace("{PARENT_ID}", parentId)}";
        }

        protected virtual string InstanceUrl(string parentId, string id, string baseUrl = null)
        {
            return $"{this.ClassUrl(parentId, baseUrl)}/{WebUtility.UrlEncode(id)}";
        }
    }
}
