// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PaymentPlanService : Service,
        ICreatable<PaymentPlan, PaymentPlanCreateOptions>,
        IListable<PaymentPlan, PaymentPlanListOptions>,
        IRetrievable<PaymentPlan, PaymentPlanGetOptions>,
        IUpdatable<PaymentPlan, PaymentPlanUpdateOptions>
    {
        public PaymentPlanService()
        {
        }

        internal PaymentPlanService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public PaymentPlanService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Creates a payment plan that splits a single invoice obligation into installments with
        /// their own due dates and amounts.</p>.
        /// </summary>
        public virtual PaymentPlan Create(PaymentPlanCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentPlan>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_plans", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a payment plan that splits a single invoice obligation into installments with
        /// their own due dates and amounts.</p>.
        /// </summary>
        public virtual Task<PaymentPlan> CreateAsync(PaymentPlanCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentPlan>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_plans", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the payment plan with the given ID.</p>.
        /// </summary>
        public virtual PaymentPlan Get(string id, PaymentPlanGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentPlan>(BaseAddress.Api, HttpMethod.Get, $"/v1/payment_plans/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the payment plan with the given ID.</p>.
        /// </summary>
        public virtual Task<PaymentPlan> GetAsync(string id, PaymentPlanGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentPlan>(BaseAddress.Api, HttpMethod.Get, $"/v1/payment_plans/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of payment plans.</p>.
        /// </summary>
        public virtual StripeList<PaymentPlan> List(PaymentPlanListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<PaymentPlan>>(BaseAddress.Api, HttpMethod.Get, $"/v1/payment_plans", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of payment plans.</p>.
        /// </summary>
        public virtual Task<StripeList<PaymentPlan>> ListAsync(PaymentPlanListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<PaymentPlan>>(BaseAddress.Api, HttpMethod.Get, $"/v1/payment_plans", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of payment plans.</p>.
        /// </summary>
        public virtual IEnumerable<PaymentPlan> ListAutoPaging(PaymentPlanListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<PaymentPlan>($"/v1/payment_plans", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of payment plans.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<PaymentPlan> ListAutoPagingAsync(PaymentPlanListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<PaymentPlan>($"/v1/payment_plans", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the schedule or metadata of an existing payment plan. Only unpaid
        /// installments can be updated.</p>.
        /// </summary>
        public virtual PaymentPlan Update(string id, PaymentPlanUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentPlan>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_plans/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the schedule or metadata of an existing payment plan. Only unpaid
        /// installments can be updated.</p>.
        /// </summary>
        public virtual Task<PaymentPlan> UpdateAsync(string id, PaymentPlanUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentPlan>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_plans/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
