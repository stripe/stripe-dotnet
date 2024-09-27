// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ApplicationFeeService : Service<ApplicationFee>,
        IListable<ApplicationFee, ApplicationFeeListOptions>,
        IRetrievable<ApplicationFee, ApplicationFeeGetOptions>
    {
        private ApplicationFeeRefundService refunds;

        public ApplicationFeeService()
        {
        }

        internal ApplicationFeeService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public ApplicationFeeService(IStripeClient client)
            : base(client)
        {
        }

        public virtual ApplicationFeeRefundService Refunds => this.refunds ??= new ApplicationFeeRefundService(
            this.Requestor);

        /// <summary>
        /// <p>Retrieves the details of an application fee that your account has collected. The same
        /// information is returned when refunding the application fee.</p>.
        /// </summary>
        public virtual ApplicationFee Get(string id, ApplicationFeeGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ApplicationFee>(BaseAddress.Api, HttpMethod.Get, $"/v1/application_fees/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of an application fee that your account has collected. The same
        /// information is returned when refunding the application fee.</p>.
        /// </summary>
        public virtual Task<ApplicationFee> GetAsync(string id, ApplicationFeeGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ApplicationFee>(BaseAddress.Api, HttpMethod.Get, $"/v1/application_fees/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of application fees you’ve previously collected. The application fees
        /// are returned in sorted order, with the most recent fees appearing first.</p>.
        /// </summary>
        public virtual StripeList<ApplicationFee> List(ApplicationFeeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<ApplicationFee>>(BaseAddress.Api, HttpMethod.Get, $"/v1/application_fees", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of application fees you’ve previously collected. The application fees
        /// are returned in sorted order, with the most recent fees appearing first.</p>.
        /// </summary>
        public virtual Task<StripeList<ApplicationFee>> ListAsync(ApplicationFeeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<ApplicationFee>>(BaseAddress.Api, HttpMethod.Get, $"/v1/application_fees", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of application fees you’ve previously collected. The application fees
        /// are returned in sorted order, with the most recent fees appearing first.</p>.
        /// </summary>
        public virtual IEnumerable<ApplicationFee> ListAutoPaging(ApplicationFeeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<ApplicationFee>($"/v1/application_fees", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of application fees you’ve previously collected. The application fees
        /// are returned in sorted order, with the most recent fees appearing first.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<ApplicationFee> ListAutoPagingAsync(ApplicationFeeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<ApplicationFee>($"/v1/application_fees", options, requestOptions, cancellationToken);
        }
    }
}
