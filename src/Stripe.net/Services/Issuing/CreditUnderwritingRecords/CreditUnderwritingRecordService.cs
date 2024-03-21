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
        {
        }

        public CreditUnderwritingRecordService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/issuing/credit_underwriting_records";

        /// <summary>
        /// <p>Update a <c>CreditUnderwritingRecord</c> object to correct mistakes.</p>.
        /// </summary>
        public virtual CreditUnderwritingRecord Correct(string id, CreditUnderwritingRecordCorrectOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CreditUnderwritingRecord>(HttpMethod.Post, $"/v1/issuing/credit_underwriting_records/{id}/correct", options, requestOptions);
        }

        /// <summary>
        /// <p>Update a <c>CreditUnderwritingRecord</c> object to correct mistakes.</p>.
        /// </summary>
        public virtual Task<CreditUnderwritingRecord> CorrectAsync(string id, CreditUnderwritingRecordCorrectOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CreditUnderwritingRecord>(HttpMethod.Post, $"/v1/issuing/credit_underwriting_records/{id}/correct", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Creates a <c>CreditUnderwritingRecord</c> object with information about a credit
        /// application submission.</p>.
        /// </summary>
        public virtual CreditUnderwritingRecord CreateFromApplication(CreditUnderwritingRecordCreateFromApplicationOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CreditUnderwritingRecord>(HttpMethod.Post, $"/v1/issuing/credit_underwriting_records/create_from_application", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a <c>CreditUnderwritingRecord</c> object with information about a credit
        /// application submission.</p>.
        /// </summary>
        public virtual Task<CreditUnderwritingRecord> CreateFromApplicationAsync(CreditUnderwritingRecordCreateFromApplicationOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CreditUnderwritingRecord>(HttpMethod.Post, $"/v1/issuing/credit_underwriting_records/create_from_application", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Creates a <c>CreditUnderwritingRecord</c> object from an underwriting decision coming
        /// from a proactive review of an existing accountholder.</p>.
        /// </summary>
        public virtual CreditUnderwritingRecord CreateFromProactiveReview(CreditUnderwritingRecordCreateFromProactiveReviewOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CreditUnderwritingRecord>(HttpMethod.Post, $"/v1/issuing/credit_underwriting_records/create_from_proactive_review", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a <c>CreditUnderwritingRecord</c> object from an underwriting decision coming
        /// from a proactive review of an existing accountholder.</p>.
        /// </summary>
        public virtual Task<CreditUnderwritingRecord> CreateFromProactiveReviewAsync(CreditUnderwritingRecordCreateFromProactiveReviewOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CreditUnderwritingRecord>(HttpMethod.Post, $"/v1/issuing/credit_underwriting_records/create_from_proactive_review", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a <c>CreditUnderwritingRecord</c> object.</p>.
        /// </summary>
        public virtual CreditUnderwritingRecord Get(string id, CreditUnderwritingRecordGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CreditUnderwritingRecord>(HttpMethod.Get, $"/v1/issuing/credit_underwriting_records/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a <c>CreditUnderwritingRecord</c> object.</p>.
        /// </summary>
        public virtual Task<CreditUnderwritingRecord> GetAsync(string id, CreditUnderwritingRecordGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CreditUnderwritingRecord>(HttpMethod.Get, $"/v1/issuing/credit_underwriting_records/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a list of <c>CreditUnderwritingRecord</c> objects. The objects are sorted
        /// in descending order by creation date, with the most-recently-created object appearing
        /// first.</p>.
        /// </summary>
        public virtual StripeList<CreditUnderwritingRecord> List(CreditUnderwritingRecordListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<CreditUnderwritingRecord>>(HttpMethod.Get, $"/v1/issuing/credit_underwriting_records", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a list of <c>CreditUnderwritingRecord</c> objects. The objects are sorted
        /// in descending order by creation date, with the most-recently-created object appearing
        /// first.</p>.
        /// </summary>
        public virtual Task<StripeList<CreditUnderwritingRecord>> ListAsync(CreditUnderwritingRecordListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<CreditUnderwritingRecord>>(HttpMethod.Get, $"/v1/issuing/credit_underwriting_records", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a list of <c>CreditUnderwritingRecord</c> objects. The objects are sorted
        /// in descending order by creation date, with the most-recently-created object appearing
        /// first.</p>.
        /// </summary>
        public virtual IEnumerable<CreditUnderwritingRecord> ListAutoPaging(CreditUnderwritingRecordListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<CreditUnderwritingRecord>($"/v1/issuing/credit_underwriting_records", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a list of <c>CreditUnderwritingRecord</c> objects. The objects are sorted
        /// in descending order by creation date, with the most-recently-created object appearing
        /// first.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<CreditUnderwritingRecord> ListAutoPagingAsync(CreditUnderwritingRecordListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<CreditUnderwritingRecord>($"/v1/issuing/credit_underwriting_records", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Update a <c>CreditUnderwritingRecord</c> object from a decision made on a credit
        /// application.</p>.
        /// </summary>
        public virtual CreditUnderwritingRecord ReportDecision(string id, CreditUnderwritingRecordReportDecisionOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CreditUnderwritingRecord>(HttpMethod.Post, $"/v1/issuing/credit_underwriting_records/{id}/report_decision", options, requestOptions);
        }

        /// <summary>
        /// <p>Update a <c>CreditUnderwritingRecord</c> object from a decision made on a credit
        /// application.</p>.
        /// </summary>
        public virtual Task<CreditUnderwritingRecord> ReportDecisionAsync(string id, CreditUnderwritingRecordReportDecisionOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CreditUnderwritingRecord>(HttpMethod.Post, $"/v1/issuing/credit_underwriting_records/{id}/report_decision", options, requestOptions, cancellationToken);
        }
    }
}
