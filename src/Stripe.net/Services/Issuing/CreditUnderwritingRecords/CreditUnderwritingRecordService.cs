// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
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

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/issuing/credit_underwriting_records";

        public virtual CreditUnderwritingRecord Correct(string id, CreditUnderwritingRecordCorrectOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CreditUnderwritingRecord>(HttpMethod.Post, $"/v1/issuing/credit_underwriting_records/{id}/correct", options, requestOptions);
        }

        public virtual Task<CreditUnderwritingRecord> CorrectAsync(string id, CreditUnderwritingRecordCorrectOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CreditUnderwritingRecord>(HttpMethod.Post, $"/v1/issuing/credit_underwriting_records/{id}/correct", options, requestOptions, cancellationToken);
        }

        public virtual CreditUnderwritingRecord CreateFromApplication(CreditUnderwritingRecordCreateFromApplicationOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CreditUnderwritingRecord>(HttpMethod.Post, $"/v1/issuing/credit_underwriting_records/create_from_application", options, requestOptions);
        }

        public virtual Task<CreditUnderwritingRecord> CreateFromApplicationAsync(CreditUnderwritingRecordCreateFromApplicationOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CreditUnderwritingRecord>(HttpMethod.Post, $"/v1/issuing/credit_underwriting_records/create_from_application", options, requestOptions, cancellationToken);
        }

        public virtual CreditUnderwritingRecord CreateFromProactiveReview(CreditUnderwritingRecordCreateFromProactiveReviewOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CreditUnderwritingRecord>(HttpMethod.Post, $"/v1/issuing/credit_underwriting_records/create_from_proactive_review", options, requestOptions);
        }

        public virtual Task<CreditUnderwritingRecord> CreateFromProactiveReviewAsync(CreditUnderwritingRecordCreateFromProactiveReviewOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CreditUnderwritingRecord>(HttpMethod.Post, $"/v1/issuing/credit_underwriting_records/create_from_proactive_review", options, requestOptions, cancellationToken);
        }

        public virtual CreditUnderwritingRecord Get(string id, CreditUnderwritingRecordGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CreditUnderwritingRecord>(HttpMethod.Get, $"/v1/issuing/credit_underwriting_records/{id}", options, requestOptions);
        }

        public virtual Task<CreditUnderwritingRecord> GetAsync(string id, CreditUnderwritingRecordGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CreditUnderwritingRecord>(HttpMethod.Get, $"/v1/issuing/credit_underwriting_records/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<CreditUnderwritingRecord> List(CreditUnderwritingRecordListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<CreditUnderwritingRecord>>(HttpMethod.Get, $"/v1/issuing/credit_underwriting_records", options, requestOptions);
        }

        public virtual Task<StripeList<CreditUnderwritingRecord>> ListAsync(CreditUnderwritingRecordListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<CreditUnderwritingRecord>>(HttpMethod.Get, $"/v1/issuing/credit_underwriting_records", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<CreditUnderwritingRecord> ListAutoPaging(CreditUnderwritingRecordListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<CreditUnderwritingRecord>($"/v1/issuing/credit_underwriting_records", options, requestOptions);
        }

        public virtual IAsyncEnumerable<CreditUnderwritingRecord> ListAutoPagingAsync(CreditUnderwritingRecordListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<CreditUnderwritingRecord>($"/v1/issuing/credit_underwriting_records", options, requestOptions, cancellationToken);
        }

        public virtual CreditUnderwritingRecord ReportDecision(string id, CreditUnderwritingRecordReportDecisionOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CreditUnderwritingRecord>(HttpMethod.Post, $"/v1/issuing/credit_underwriting_records/{id}/report_decision", options, requestOptions);
        }

        public virtual Task<CreditUnderwritingRecord> ReportDecisionAsync(string id, CreditUnderwritingRecordReportDecisionOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CreditUnderwritingRecord>(HttpMethod.Post, $"/v1/issuing/credit_underwriting_records/{id}/report_decision", options, requestOptions, cancellationToken);
        }
    }
}
