// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class ApplicationFeeRefundService : ServiceNested<ApplicationFeeRefund>,
        INestedCreatable<ApplicationFeeRefund, ApplicationFeeRefundCreateOptions>,
        INestedListable<ApplicationFeeRefund, ApplicationFeeRefundListOptions>,
        INestedRetrievable<ApplicationFeeRefund, ApplicationFeeRefundGetOptions>,
        INestedUpdatable<ApplicationFeeRefund, ApplicationFeeRefundUpdateOptions>
    {
        public ApplicationFeeRefundService()
            : base(null)
        {
        }

        public ApplicationFeeRefundService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/application_fees/{PARENT_ID}/refunds";

        public virtual ApplicationFeeRefund Create(string parentId, ApplicationFeeRefundCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.CreateNestedEntity(parentId, options, requestOptions);
        }

        public virtual Task<ApplicationFeeRefund> CreateAsync(string parentId, ApplicationFeeRefundCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateNestedEntityAsync(parentId, options, requestOptions, cancellationToken);
        }

        public virtual ApplicationFeeRefund Get(string parentId, string id, ApplicationFeeRefundGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetNestedEntity(parentId, id, options, requestOptions);
        }

        public virtual Task<ApplicationFeeRefund> GetAsync(string parentId, string id, ApplicationFeeRefundGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetNestedEntityAsync(parentId, id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<ApplicationFeeRefund> List(string parentId, ApplicationFeeRefundListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntities(parentId, options, requestOptions);
        }

        public virtual Task<StripeList<ApplicationFeeRefund>> ListAsync(string parentId, ApplicationFeeRefundListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAsync(parentId, options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<ApplicationFeeRefund> ListAutoPaging(string parentId, ApplicationFeeRefundListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntitiesAutoPaging(parentId, options, requestOptions);
        }

        public virtual IAsyncEnumerable<ApplicationFeeRefund> ListAutoPagingAsync(string parentId, ApplicationFeeRefundListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAutoPagingAsync(parentId, options, requestOptions, cancellationToken);
        }

        public virtual ApplicationFeeRefund Update(string parentId, string id, ApplicationFeeRefundUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateNestedEntity(parentId, id, options, requestOptions);
        }

        public virtual Task<ApplicationFeeRefund> UpdateAsync(string parentId, string id, ApplicationFeeRefundUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateNestedEntityAsync(parentId, id, options, requestOptions, cancellationToken);
        }
    }
}
