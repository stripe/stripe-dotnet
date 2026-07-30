// File generated from our OpenAPI spec
namespace Stripe.V2.Risk
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class InquiryService : Service
    {
        internal InquiryService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal InquiryService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Retrieves a risk inquiry by ID.
        /// </summary>
        public virtual Inquiry Get(string id, InquiryGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Inquiry>(BaseAddress.Api, HttpMethod.Get, $"/v2/risk/inquiries/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves a risk inquiry by ID.
        /// </summary>
        public virtual Task<Inquiry> GetAsync(string id, InquiryGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Inquiry>(BaseAddress.Api, HttpMethod.Get, $"/v2/risk/inquiries/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Lists risk inquiries for a connected account.
        /// </summary>
        public virtual V2.StripeList<Inquiry> List(InquiryListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<Inquiry>>(BaseAddress.Api, HttpMethod.Get, $"/v2/risk/inquiries", options, requestOptions);
        }

        /// <summary>
        /// Lists risk inquiries for a connected account.
        /// </summary>
        public virtual Task<V2.StripeList<Inquiry>> ListAsync(InquiryListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<Inquiry>>(BaseAddress.Api, HttpMethod.Get, $"/v2/risk/inquiries", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Lists risk inquiries for a connected account.
        /// </summary>
        public virtual IEnumerable<Inquiry> ListAutoPaging(InquiryListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Inquiry>($"/v2/risk/inquiries", options, requestOptions);
        }

        /// <summary>
        /// Lists risk inquiries for a connected account.
        /// </summary>
        public virtual IAsyncEnumerable<Inquiry> ListAutoPagingAsync(InquiryListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Inquiry>($"/v2/risk/inquiries", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Submits a response to a risk inquiry.
        /// </summary>
        public virtual Inquiry Update(string id, InquiryUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Inquiry>(BaseAddress.Api, HttpMethod.Post, $"/v2/risk/inquiries/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Submits a response to a risk inquiry.
        /// </summary>
        public virtual Task<Inquiry> UpdateAsync(string id, InquiryUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Inquiry>(BaseAddress.Api, HttpMethod.Post, $"/v2/risk/inquiries/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
