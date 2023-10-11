// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CreditUnderwritingRecordService : Service<CreditUnderwritingRecord>,
        IListable<CreditUnderwritingRecord, CreditUnderwritingRecordListOptions>,
        IRetrievable<CreditUnderwritingRecord, CreditUnderwritingRecordGetOptions>
    {
        public CreditUnderwritingRecordService()
            : base(null)
        {
        }

        public CreditUnderwritingRecordService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/issuing/credit_underwriting_records";

        public virtual CreditUnderwritingRecord Correct(string id, CreditUnderwritingRecordCorrectOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/correct", options, requestOptions);
        }

        public virtual Task<CreditUnderwritingRecord> CorrectAsync(string id, CreditUnderwritingRecordCorrectOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/correct", options, requestOptions, cancellationToken);
        }

        public virtual CreditUnderwritingRecord CreateFromApplication(CreditUnderwritingRecordCreateFromApplicationOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl("create_from_application")}", options, requestOptions);
        }

        public virtual Task<CreditUnderwritingRecord> CreateFromApplicationAsync(CreditUnderwritingRecordCreateFromApplicationOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl("create_from_application")}", options, requestOptions, cancellationToken);
        }

        public virtual CreditUnderwritingRecord CreateFromProactiveReview(CreditUnderwritingRecordCreateFromProactiveReviewOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl("create_from_proactive_review")}", options, requestOptions);
        }

        public virtual Task<CreditUnderwritingRecord> CreateFromProactiveReviewAsync(CreditUnderwritingRecordCreateFromProactiveReviewOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl("create_from_proactive_review")}", options, requestOptions, cancellationToken);
        }

        public virtual CreditUnderwritingRecord Get(string id, CreditUnderwritingRecordGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<CreditUnderwritingRecord> GetAsync(string id, CreditUnderwritingRecordGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<CreditUnderwritingRecord> List(CreditUnderwritingRecordListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<CreditUnderwritingRecord>> ListAsync(CreditUnderwritingRecordListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<CreditUnderwritingRecord> ListAutoPaging(CreditUnderwritingRecordListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual IAsyncEnumerable<CreditUnderwritingRecord> ListAutoPagingAsync(CreditUnderwritingRecordListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }

        public virtual CreditUnderwritingRecord ReportDecision(string id, CreditUnderwritingRecordReportDecisionOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/report_decision", options, requestOptions);
        }

        public virtual Task<CreditUnderwritingRecord> ReportDecisionAsync(string id, CreditUnderwritingRecordReportDecisionOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/report_decision", options, requestOptions, cancellationToken);
        }
    }
}
