// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PaymentMethodService : Service<PaymentMethod>,
        ICreatable<PaymentMethod, PaymentMethodCreateOptions>,
        IListable<PaymentMethod, PaymentMethodListOptions>,
        IRetrievable<PaymentMethod, PaymentMethodGetOptions>,
        IUpdatable<PaymentMethod, PaymentMethodUpdateOptions>
    {
        public PaymentMethodService()
        {
        }

        public PaymentMethodService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/payment_methods";

        /// <summary>
        /// <p>Attaches a PaymentMethod object to a Customer.</p>.
        ///
        /// <p>To attach a new PaymentMethod to a customer for future payments, we recommend you use
        /// a <a href="https://stripe.com/docs/api/setup_intents">SetupIntent</a> or a PaymentIntent
        /// with <a
        /// href="https://stripe.com/docs/api/payment_intents/create#create_payment_intent-setup_future_usage">setup_future_usage</a>.
        /// These approaches will perform any necessary steps to set up the PaymentMethod for future
        /// payments. Using the <c>/v1/payment_methods/:id/attach</c> endpoint without first using a
        /// SetupIntent or PaymentIntent with <c>setup_future_usage</c> does not optimize the
        /// PaymentMethod for future use, which makes later declines and payment friction more
        /// likely. See <a
        /// href="https://stripe.com/docs/payments/payment-intents#future-usage">Optimizing cards
        /// for future payments</a> for more information about setting up future payments.</p>.
        ///
        /// <p>To use this PaymentMethod as the default for invoice or subscription payments, set <a
        /// href="https://stripe.com/docs/api/customers/update#update_customer-invoice_settings-default_payment_method"><c>invoice_settings.default_payment_method</c></a>,
        /// on the Customer to the PaymentMethod’s ID.</p>.
        /// </summary>
        public virtual PaymentMethod Attach(string id, PaymentMethodAttachOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentMethod>(HttpMethod.Post, $"/v1/payment_methods/{id}/attach", options, requestOptions);
        }

        /// <summary>
        /// <p>Attaches a PaymentMethod object to a Customer.</p>.
        ///
        /// <p>To attach a new PaymentMethod to a customer for future payments, we recommend you use
        /// a <a href="https://stripe.com/docs/api/setup_intents">SetupIntent</a> or a PaymentIntent
        /// with <a
        /// href="https://stripe.com/docs/api/payment_intents/create#create_payment_intent-setup_future_usage">setup_future_usage</a>.
        /// These approaches will perform any necessary steps to set up the PaymentMethod for future
        /// payments. Using the <c>/v1/payment_methods/:id/attach</c> endpoint without first using a
        /// SetupIntent or PaymentIntent with <c>setup_future_usage</c> does not optimize the
        /// PaymentMethod for future use, which makes later declines and payment friction more
        /// likely. See <a
        /// href="https://stripe.com/docs/payments/payment-intents#future-usage">Optimizing cards
        /// for future payments</a> for more information about setting up future payments.</p>.
        ///
        /// <p>To use this PaymentMethod as the default for invoice or subscription payments, set <a
        /// href="https://stripe.com/docs/api/customers/update#update_customer-invoice_settings-default_payment_method"><c>invoice_settings.default_payment_method</c></a>,
        /// on the Customer to the PaymentMethod’s ID.</p>.
        /// </summary>
        public virtual Task<PaymentMethod> AttachAsync(string id, PaymentMethodAttachOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentMethod>(HttpMethod.Post, $"/v1/payment_methods/{id}/attach", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Creates a PaymentMethod object. Read the <a
        /// href="https://stripe.com/docs/stripe-js/reference#stripe-create-payment-method">Stripe.js
        /// reference</a> to learn how to create PaymentMethods via Stripe.js.</p>.
        ///
        /// <p>Instead of creating a PaymentMethod directly, we recommend using the <a
        /// href="https://stripe.com/docs/payments/accept-a-payment">PaymentIntents</a> API to
        /// accept a payment immediately or the <a
        /// href="https://stripe.com/docs/payments/save-and-reuse">SetupIntent</a> API to collect
        /// payment method details ahead of a future payment.</p>.
        /// </summary>
        public virtual PaymentMethod Create(PaymentMethodCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentMethod>(HttpMethod.Post, $"/v1/payment_methods", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a PaymentMethod object. Read the <a
        /// href="https://stripe.com/docs/stripe-js/reference#stripe-create-payment-method">Stripe.js
        /// reference</a> to learn how to create PaymentMethods via Stripe.js.</p>.
        ///
        /// <p>Instead of creating a PaymentMethod directly, we recommend using the <a
        /// href="https://stripe.com/docs/payments/accept-a-payment">PaymentIntents</a> API to
        /// accept a payment immediately or the <a
        /// href="https://stripe.com/docs/payments/save-and-reuse">SetupIntent</a> API to collect
        /// payment method details ahead of a future payment.</p>.
        /// </summary>
        public virtual Task<PaymentMethod> CreateAsync(PaymentMethodCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentMethod>(HttpMethod.Post, $"/v1/payment_methods", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Detaches a PaymentMethod object from a Customer. After a PaymentMethod is detached,
        /// it can no longer be used for a payment or re-attached to a Customer.</p>.
        /// </summary>
        public virtual PaymentMethod Detach(string id, PaymentMethodDetachOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentMethod>(HttpMethod.Post, $"/v1/payment_methods/{id}/detach", options, requestOptions);
        }

        /// <summary>
        /// <p>Detaches a PaymentMethod object from a Customer. After a PaymentMethod is detached,
        /// it can no longer be used for a payment or re-attached to a Customer.</p>.
        /// </summary>
        public virtual Task<PaymentMethod> DetachAsync(string id, PaymentMethodDetachOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentMethod>(HttpMethod.Post, $"/v1/payment_methods/{id}/detach", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a PaymentMethod object attached to the StripeAccount. To retrieve a payment
        /// method attached to a Customer, you should use <a
        /// href="https://stripe.com/docs/api/payment_methods/customer">Retrieve a Customer’s
        /// PaymentMethods</a></p>.
        /// </summary>
        public virtual PaymentMethod Get(string id, PaymentMethodGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentMethod>(HttpMethod.Get, $"/v1/payment_methods/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a PaymentMethod object attached to the StripeAccount. To retrieve a payment
        /// method attached to a Customer, you should use <a
        /// href="https://stripe.com/docs/api/payment_methods/customer">Retrieve a Customer’s
        /// PaymentMethods</a></p>.
        /// </summary>
        public virtual Task<PaymentMethod> GetAsync(string id, PaymentMethodGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentMethod>(HttpMethod.Get, $"/v1/payment_methods/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of PaymentMethods for Treasury flows. If you want to list the
        /// PaymentMethods attached to a Customer for payments, you should use the <a
        /// href="https://stripe.com/docs/api/payment_methods/customer_list">List a Customer’s
        /// PaymentMethods</a> API instead.</p>.
        /// </summary>
        public virtual StripeList<PaymentMethod> List(PaymentMethodListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<PaymentMethod>>(HttpMethod.Get, $"/v1/payment_methods", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of PaymentMethods for Treasury flows. If you want to list the
        /// PaymentMethods attached to a Customer for payments, you should use the <a
        /// href="https://stripe.com/docs/api/payment_methods/customer_list">List a Customer’s
        /// PaymentMethods</a> API instead.</p>.
        /// </summary>
        public virtual Task<StripeList<PaymentMethod>> ListAsync(PaymentMethodListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<PaymentMethod>>(HttpMethod.Get, $"/v1/payment_methods", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of PaymentMethods for Treasury flows. If you want to list the
        /// PaymentMethods attached to a Customer for payments, you should use the <a
        /// href="https://stripe.com/docs/api/payment_methods/customer_list">List a Customer’s
        /// PaymentMethods</a> API instead.</p>.
        /// </summary>
        public virtual IEnumerable<PaymentMethod> ListAutoPaging(PaymentMethodListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<PaymentMethod>($"/v1/payment_methods", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of PaymentMethods for Treasury flows. If you want to list the
        /// PaymentMethods attached to a Customer for payments, you should use the <a
        /// href="https://stripe.com/docs/api/payment_methods/customer_list">List a Customer’s
        /// PaymentMethods</a> API instead.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<PaymentMethod> ListAutoPagingAsync(PaymentMethodListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<PaymentMethod>($"/v1/payment_methods", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates a PaymentMethod object. A PaymentMethod must be attached a customer to be
        /// updated.</p>.
        /// </summary>
        public virtual PaymentMethod Update(string id, PaymentMethodUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentMethod>(HttpMethod.Post, $"/v1/payment_methods/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates a PaymentMethod object. A PaymentMethod must be attached a customer to be
        /// updated.</p>.
        /// </summary>
        public virtual Task<PaymentMethod> UpdateAsync(string id, PaymentMethodUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentMethod>(HttpMethod.Post, $"/v1/payment_methods/{id}", options, requestOptions, cancellationToken);
        }
    }
}
