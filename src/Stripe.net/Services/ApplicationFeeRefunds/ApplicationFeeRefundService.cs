namespace Stripe
{
    using System;
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

        public virtual ApplicationFeeRefund Create(string applicationFeeId, ApplicationFeeRefundCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.CreateNestedEntity(applicationFeeId, options, requestOptions);
        }

        public virtual Task<ApplicationFeeRefund> CreateAsync(string applicationFeeId, ApplicationFeeRefundCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateNestedEntityAsync(applicationFeeId, options, requestOptions, cancellationToken);
        }

        public virtual ApplicationFeeRefund Get(string applicationFeeId, string id, ApplicationFeeRefundGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetNestedEntity(applicationFeeId, id, options, requestOptions);
        }

        public virtual Task<ApplicationFeeRefund> GetAsync(string applicationFeeId, string id, ApplicationFeeRefundGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetNestedEntityAsync(applicationFeeId, id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<ApplicationFeeRefund> List(string applicationFeeId, ApplicationFeeRefundListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntities(applicationFeeId, options, requestOptions);
        }

        public virtual Task<StripeList<ApplicationFeeRefund>> ListAsync(string applicationFeeId, ApplicationFeeRefundListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAsync(applicationFeeId, options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<ApplicationFeeRefund> ListAutoPaging(string applicationFeeId, ApplicationFeeRefundListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntitiesAutoPaging(applicationFeeId, options, requestOptions);
        }

        public virtual IAsyncEnumerable<ApplicationFeeRefund> ListAutoPagingAsync(string applicationFeeId, ApplicationFeeRefundListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAutoPagingAsync(applicationFeeId, options, requestOptions, cancellationToken);
        }

        public virtual ApplicationFeeRefund Update(string applicationFeeId, string id, ApplicationFeeRefundUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateNestedEntity(applicationFeeId, id, options, requestOptions);
        }

        public virtual Task<ApplicationFeeRefund> UpdateAsync(string applicationFeeId, string id, ApplicationFeeRefundUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateNestedEntityAsync(applicationFeeId, id, options, requestOptions, cancellationToken);
        }
    }
}
