// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public partial class InvoiceService : Service<Invoice>,
        ICreatable<Invoice, InvoiceCreateOptions>,
        IDeletable<Invoice, InvoiceDeleteOptions>,
        IListable<Invoice, InvoiceListOptions>,
        IRetrievable<Invoice, InvoiceGetOptions>,
        ISearchable<Invoice, InvoiceSearchOptions>,
        IUpdatable<Invoice, InvoiceUpdateOptions>
    {
        private InvoiceLineItemService lineItems;
        private InvoiceUpcomingLinesService upcomingLines;

        public InvoiceService()
        {
        }

        internal InvoiceService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public InvoiceService(IStripeClient client)
            : base(client)
        {
        }

        public virtual InvoiceLineItemService LineItems => this.lineItems ??= new InvoiceLineItemService(
            this.Requestor);

        public virtual InvoiceUpcomingLinesService UpcomingLines => this.upcomingLines ??= new InvoiceUpcomingLinesService(
            this.Requestor);

        /// <summary>
        /// <p>Adds multiple line items to an invoice. This is only possible when an invoice is
        /// still a draft.</p>.
        /// </summary>
        public virtual Invoice AddLines(string id, InvoiceAddLinesOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Invoice>(BaseAddress.Api, HttpMethod.Post, $"/v1/invoices/{WebUtility.UrlEncode(id)}/add_lines", options, requestOptions);
        }

        /// <summary>
        /// <p>Adds multiple line items to an invoice. This is only possible when an invoice is
        /// still a draft.</p>.
        /// </summary>
        public virtual Task<Invoice> AddLinesAsync(string id, InvoiceAddLinesOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Invoice>(BaseAddress.Api, HttpMethod.Post, $"/v1/invoices/{WebUtility.UrlEncode(id)}/add_lines", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>This endpoint creates a draft invoice for a given customer. The invoice remains a
        /// draft until you <a href="https://stripe.com/docs/api#finalize_invoice">finalize</a> the
        /// invoice, which allows you to <a href="https://stripe.com/docs/api#pay_invoice">pay</a>
        /// or <a href="https://stripe.com/docs/api#send_invoice">send</a> the invoice to your
        /// customers.</p>.
        /// </summary>
        public virtual Invoice Create(InvoiceCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Invoice>(BaseAddress.Api, HttpMethod.Post, $"/v1/invoices", options, requestOptions);
        }

        /// <summary>
        /// <p>This endpoint creates a draft invoice for a given customer. The invoice remains a
        /// draft until you <a href="https://stripe.com/docs/api#finalize_invoice">finalize</a> the
        /// invoice, which allows you to <a href="https://stripe.com/docs/api#pay_invoice">pay</a>
        /// or <a href="https://stripe.com/docs/api#send_invoice">send</a> the invoice to your
        /// customers.</p>.
        /// </summary>
        public virtual Task<Invoice> CreateAsync(InvoiceCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Invoice>(BaseAddress.Api, HttpMethod.Post, $"/v1/invoices", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>At any time, you can preview the upcoming invoice for a customer. This will show you
        /// all the charges that are pending, including subscription renewal charges, invoice item
        /// charges, etc. It will also show you any discounts that are applicable to the
        /// invoice.</p>.
        ///
        /// <p>Note that when you are viewing an upcoming invoice, you are simply viewing a preview
        /// – the invoice has not yet been created. As such, the upcoming invoice will not show up
        /// in invoice listing calls, and you cannot use the API to pay or edit the invoice. If you
        /// want to change the amount that your customer will be billed, you can add, remove, or
        /// update pending invoice items, or update the customer’s discount.</p>.
        ///
        /// <p>You can preview the effects of updating a subscription, including a preview of what
        /// proration will take place. To ensure that the actual proration is calculated exactly the
        /// same as the previewed proration, you should pass the
        /// <c>subscription_details.proration_date</c> parameter when doing the actual subscription
        /// update. The recommended way to get only the prorations being previewed is to consider
        /// only proration line items where <c>period[start]</c> is equal to the
        /// <c>subscription_details.proration_date</c> value passed in the request. </p>.
        ///
        /// <p>Note: Currency conversion calculations use the latest exchange rates. Exchange rates
        /// may vary between the time of the preview and the time of the actual invoice creation. <a
        /// href="https://docs.stripe.com/currencies/conversions">Learn more</a></p>.
        /// </summary>
        public virtual Invoice CreatePreview(InvoiceCreatePreviewOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Invoice>(BaseAddress.Api, HttpMethod.Post, $"/v1/invoices/create_preview", options, requestOptions);
        }

        /// <summary>
        /// <p>At any time, you can preview the upcoming invoice for a customer. This will show you
        /// all the charges that are pending, including subscription renewal charges, invoice item
        /// charges, etc. It will also show you any discounts that are applicable to the
        /// invoice.</p>.
        ///
        /// <p>Note that when you are viewing an upcoming invoice, you are simply viewing a preview
        /// – the invoice has not yet been created. As such, the upcoming invoice will not show up
        /// in invoice listing calls, and you cannot use the API to pay or edit the invoice. If you
        /// want to change the amount that your customer will be billed, you can add, remove, or
        /// update pending invoice items, or update the customer’s discount.</p>.
        ///
        /// <p>You can preview the effects of updating a subscription, including a preview of what
        /// proration will take place. To ensure that the actual proration is calculated exactly the
        /// same as the previewed proration, you should pass the
        /// <c>subscription_details.proration_date</c> parameter when doing the actual subscription
        /// update. The recommended way to get only the prorations being previewed is to consider
        /// only proration line items where <c>period[start]</c> is equal to the
        /// <c>subscription_details.proration_date</c> value passed in the request. </p>.
        ///
        /// <p>Note: Currency conversion calculations use the latest exchange rates. Exchange rates
        /// may vary between the time of the preview and the time of the actual invoice creation. <a
        /// href="https://docs.stripe.com/currencies/conversions">Learn more</a></p>.
        /// </summary>
        public virtual Task<Invoice> CreatePreviewAsync(InvoiceCreatePreviewOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Invoice>(BaseAddress.Api, HttpMethod.Post, $"/v1/invoices/create_preview", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Permanently deletes a one-off invoice draft. This cannot be undone. Attempts to
        /// delete invoices that are no longer in a draft state will fail; once an invoice has been
        /// finalized or if an invoice is for a subscription, it must be <a
        /// href="https://stripe.com/docs/api#void_invoice">voided</a>.</p>.
        /// </summary>
        public virtual Invoice Delete(string id, InvoiceDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Invoice>(BaseAddress.Api, HttpMethod.Delete, $"/v1/invoices/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Permanently deletes a one-off invoice draft. This cannot be undone. Attempts to
        /// delete invoices that are no longer in a draft state will fail; once an invoice has been
        /// finalized or if an invoice is for a subscription, it must be <a
        /// href="https://stripe.com/docs/api#void_invoice">voided</a>.</p>.
        /// </summary>
        public virtual Task<Invoice> DeleteAsync(string id, InvoiceDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Invoice>(BaseAddress.Api, HttpMethod.Delete, $"/v1/invoices/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Stripe automatically finalizes drafts before sending and attempting payment on
        /// invoices. However, if you’d like to finalize a draft invoice manually, you can do so
        /// using this method.</p>.
        /// </summary>
        public virtual Invoice FinalizeInvoice(string id, InvoiceFinalizeOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Invoice>(BaseAddress.Api, HttpMethod.Post, $"/v1/invoices/{WebUtility.UrlEncode(id)}/finalize", options, requestOptions);
        }

        /// <summary>
        /// <p>Stripe automatically finalizes drafts before sending and attempting payment on
        /// invoices. However, if you’d like to finalize a draft invoice manually, you can do so
        /// using this method.</p>.
        /// </summary>
        public virtual Task<Invoice> FinalizeInvoiceAsync(string id, InvoiceFinalizeOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Invoice>(BaseAddress.Api, HttpMethod.Post, $"/v1/invoices/{WebUtility.UrlEncode(id)}/finalize", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the invoice with the given ID.</p>.
        /// </summary>
        public virtual Invoice Get(string id, InvoiceGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Invoice>(BaseAddress.Api, HttpMethod.Get, $"/v1/invoices/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the invoice with the given ID.</p>.
        /// </summary>
        public virtual Task<Invoice> GetAsync(string id, InvoiceGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Invoice>(BaseAddress.Api, HttpMethod.Get, $"/v1/invoices/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>You can list all invoices, or list the invoices for a specific customer. The invoices
        /// are returned sorted by creation date, with the most recently created invoices appearing
        /// first.</p>.
        /// </summary>
        public virtual StripeList<Invoice> List(InvoiceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Invoice>>(BaseAddress.Api, HttpMethod.Get, $"/v1/invoices", options, requestOptions);
        }

        /// <summary>
        /// <p>You can list all invoices, or list the invoices for a specific customer. The invoices
        /// are returned sorted by creation date, with the most recently created invoices appearing
        /// first.</p>.
        /// </summary>
        public virtual Task<StripeList<Invoice>> ListAsync(InvoiceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Invoice>>(BaseAddress.Api, HttpMethod.Get, $"/v1/invoices", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>You can list all invoices, or list the invoices for a specific customer. The invoices
        /// are returned sorted by creation date, with the most recently created invoices appearing
        /// first.</p>.
        /// </summary>
        public virtual IEnumerable<Invoice> ListAutoPaging(InvoiceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Invoice>($"/v1/invoices", options, requestOptions);
        }

        /// <summary>
        /// <p>You can list all invoices, or list the invoices for a specific customer. The invoices
        /// are returned sorted by creation date, with the most recently created invoices appearing
        /// first.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Invoice> ListAutoPagingAsync(InvoiceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Invoice>($"/v1/invoices", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When retrieving an invoice, you’ll get a <strong>lines</strong> property containing
        /// the total count of line items and the first handful of those items. There is also a URL
        /// where you can retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual StripeList<InvoiceLineItem> List(string id, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<InvoiceLineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/invoices/{WebUtility.UrlEncode(id)}/lines", null, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving an invoice, you’ll get a <strong>lines</strong> property containing
        /// the total count of line items and the first handful of those items. There is also a URL
        /// where you can retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual Task<StripeList<InvoiceLineItem>> ListAsync(string id, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<InvoiceLineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/invoices/{WebUtility.UrlEncode(id)}/lines", null, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When retrieving an invoice, you’ll get a <strong>lines</strong> property containing
        /// the total count of line items and the first handful of those items. There is also a URL
        /// where you can retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual IEnumerable<InvoiceLineItem> ListAutoPaging(string id, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<InvoiceLineItem>($"/v1/invoices/{WebUtility.UrlEncode(id)}/lines", null, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving an invoice, you’ll get a <strong>lines</strong> property containing
        /// the total count of line items and the first handful of those items. There is also a URL
        /// where you can retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<InvoiceLineItem> ListAutoPagingAsync(string id, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<InvoiceLineItem>($"/v1/invoices/{WebUtility.UrlEncode(id)}/lines", null, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When retrieving an upcoming invoice, you’ll get a <strong>lines</strong> property
        /// containing the total count of line items and the first handful of those items. There is
        /// also a URL where you can retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual StripeList<InvoiceLineItem> List(RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<InvoiceLineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/invoices/upcoming/lines", null, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving an upcoming invoice, you’ll get a <strong>lines</strong> property
        /// containing the total count of line items and the first handful of those items. There is
        /// also a URL where you can retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual Task<StripeList<InvoiceLineItem>> ListAsync(RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<InvoiceLineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/invoices/upcoming/lines", null, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When retrieving an upcoming invoice, you’ll get a <strong>lines</strong> property
        /// containing the total count of line items and the first handful of those items. There is
        /// also a URL where you can retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual IEnumerable<InvoiceLineItem> ListAutoPaging(RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<InvoiceLineItem>($"/v1/invoices/upcoming/lines", null, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving an upcoming invoice, you’ll get a <strong>lines</strong> property
        /// containing the total count of line items and the first handful of those items. There is
        /// also a URL where you can retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<InvoiceLineItem> ListAutoPagingAsync(RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<InvoiceLineItem>($"/v1/invoices/upcoming/lines", null, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Marking an invoice as uncollectible is useful for keeping track of bad debts that can
        /// be written off for accounting purposes.</p>.
        /// </summary>
        public virtual Invoice MarkUncollectible(string id, InvoiceMarkUncollectibleOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Invoice>(BaseAddress.Api, HttpMethod.Post, $"/v1/invoices/{WebUtility.UrlEncode(id)}/mark_uncollectible", options, requestOptions);
        }

        /// <summary>
        /// <p>Marking an invoice as uncollectible is useful for keeping track of bad debts that can
        /// be written off for accounting purposes.</p>.
        /// </summary>
        public virtual Task<Invoice> MarkUncollectibleAsync(string id, InvoiceMarkUncollectibleOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Invoice>(BaseAddress.Api, HttpMethod.Post, $"/v1/invoices/{WebUtility.UrlEncode(id)}/mark_uncollectible", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Stripe automatically creates and then attempts to collect payment on invoices for
        /// customers on subscriptions according to your <a
        /// href="https://dashboard.stripe.com/account/billing/automatic">subscriptions
        /// settings</a>. However, if you’d like to attempt payment on an invoice out of the normal
        /// collection schedule or for some other reason, you can do so.</p>.
        /// </summary>
        public virtual Invoice Pay(string id, InvoicePayOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Invoice>(BaseAddress.Api, HttpMethod.Post, $"/v1/invoices/{WebUtility.UrlEncode(id)}/pay", options, requestOptions);
        }

        /// <summary>
        /// <p>Stripe automatically creates and then attempts to collect payment on invoices for
        /// customers on subscriptions according to your <a
        /// href="https://dashboard.stripe.com/account/billing/automatic">subscriptions
        /// settings</a>. However, if you’d like to attempt payment on an invoice out of the normal
        /// collection schedule or for some other reason, you can do so.</p>.
        /// </summary>
        public virtual Task<Invoice> PayAsync(string id, InvoicePayOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Invoice>(BaseAddress.Api, HttpMethod.Post, $"/v1/invoices/{WebUtility.UrlEncode(id)}/pay", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Removes multiple line items from an invoice. This is only possible when an invoice is
        /// still a draft.</p>.
        /// </summary>
        public virtual Invoice RemoveLines(string id, InvoiceRemoveLinesOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Invoice>(BaseAddress.Api, HttpMethod.Post, $"/v1/invoices/{WebUtility.UrlEncode(id)}/remove_lines", options, requestOptions);
        }

        /// <summary>
        /// <p>Removes multiple line items from an invoice. This is only possible when an invoice is
        /// still a draft.</p>.
        /// </summary>
        public virtual Task<Invoice> RemoveLinesAsync(string id, InvoiceRemoveLinesOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Invoice>(BaseAddress.Api, HttpMethod.Post, $"/v1/invoices/{WebUtility.UrlEncode(id)}/remove_lines", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Search for invoices you’ve previously created using Stripe’s <a
        /// href="https://stripe.com/docs/search#search-query-language">Search Query Language</a>.
        /// Don’t use search in read-after-write flows where strict consistency is necessary. Under
        /// normal operating conditions, data is searchable in less than a minute. Occasionally,
        /// propagation of new or updated data can be up to an hour behind during outages. Search
        /// functionality is not available to merchants in India.</p>.
        /// </summary>
        public virtual StripeSearchResult<Invoice> Search(InvoiceSearchOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeSearchResult<Invoice>>(BaseAddress.Api, HttpMethod.Get, $"/v1/invoices/search", options, requestOptions);
        }

        /// <summary>
        /// <p>Search for invoices you’ve previously created using Stripe’s <a
        /// href="https://stripe.com/docs/search#search-query-language">Search Query Language</a>.
        /// Don’t use search in read-after-write flows where strict consistency is necessary. Under
        /// normal operating conditions, data is searchable in less than a minute. Occasionally,
        /// propagation of new or updated data can be up to an hour behind during outages. Search
        /// functionality is not available to merchants in India.</p>.
        /// </summary>
        public virtual Task<StripeSearchResult<Invoice>> SearchAsync(InvoiceSearchOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeSearchResult<Invoice>>(BaseAddress.Api, HttpMethod.Get, $"/v1/invoices/search", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Search for invoices you’ve previously created using Stripe’s <a
        /// href="https://stripe.com/docs/search#search-query-language">Search Query Language</a>.
        /// Don’t use search in read-after-write flows where strict consistency is necessary. Under
        /// normal operating conditions, data is searchable in less than a minute. Occasionally,
        /// propagation of new or updated data can be up to an hour behind during outages. Search
        /// functionality is not available to merchants in India.</p>.
        /// </summary>
        public virtual IEnumerable<Invoice> SearchAutoPaging(InvoiceSearchOptions options = null, RequestOptions requestOptions = null)
        {
            return this.SearchRequestAutoPaging<Invoice>($"/v1/invoices/search", options, requestOptions);
        }

        /// <summary>
        /// <p>Search for invoices you’ve previously created using Stripe’s <a
        /// href="https://stripe.com/docs/search#search-query-language">Search Query Language</a>.
        /// Don’t use search in read-after-write flows where strict consistency is necessary. Under
        /// normal operating conditions, data is searchable in less than a minute. Occasionally,
        /// propagation of new or updated data can be up to an hour behind during outages. Search
        /// functionality is not available to merchants in India.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Invoice> SearchAutoPagingAsync(InvoiceSearchOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.SearchRequestAutoPagingAsync<Invoice>($"/v1/invoices/search", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Stripe will automatically send invoices to customers according to your <a
        /// href="https://dashboard.stripe.com/account/billing/automatic">subscriptions
        /// settings</a>. However, if you’d like to manually send an invoice to your customer out of
        /// the normal schedule, you can do so. When sending invoices that have already been paid,
        /// there will be no reference to the payment in the email.</p>.
        ///
        /// <p>Requests made in test-mode result in no emails being sent, despite sending an
        /// <c>invoice.sent</c> event.</p>.
        /// </summary>
        public virtual Invoice SendInvoice(string id, InvoiceSendOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Invoice>(BaseAddress.Api, HttpMethod.Post, $"/v1/invoices/{WebUtility.UrlEncode(id)}/send", options, requestOptions);
        }

        /// <summary>
        /// <p>Stripe will automatically send invoices to customers according to your <a
        /// href="https://dashboard.stripe.com/account/billing/automatic">subscriptions
        /// settings</a>. However, if you’d like to manually send an invoice to your customer out of
        /// the normal schedule, you can do so. When sending invoices that have already been paid,
        /// there will be no reference to the payment in the email.</p>.
        ///
        /// <p>Requests made in test-mode result in no emails being sent, despite sending an
        /// <c>invoice.sent</c> event.</p>.
        /// </summary>
        public virtual Task<Invoice> SendInvoiceAsync(string id, InvoiceSendOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Invoice>(BaseAddress.Api, HttpMethod.Post, $"/v1/invoices/{WebUtility.UrlEncode(id)}/send", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>At any time, you can preview the upcoming invoice for a customer. This will show you
        /// all the charges that are pending, including subscription renewal charges, invoice item
        /// charges, etc. It will also show you any discounts that are applicable to the
        /// invoice.</p>.
        ///
        /// <p>Note that when you are viewing an upcoming invoice, you are simply viewing a preview
        /// – the invoice has not yet been created. As such, the upcoming invoice will not show up
        /// in invoice listing calls, and you cannot use the API to pay or edit the invoice. If you
        /// want to change the amount that your customer will be billed, you can add, remove, or
        /// update pending invoice items, or update the customer’s discount.</p>.
        ///
        /// <p>You can preview the effects of updating a subscription, including a preview of what
        /// proration will take place. To ensure that the actual proration is calculated exactly the
        /// same as the previewed proration, you should pass the
        /// <c>subscription_details.proration_date</c> parameter when doing the actual subscription
        /// update. The recommended way to get only the prorations being previewed is to consider
        /// only proration line items where <c>period[start]</c> is equal to the
        /// <c>subscription_details.proration_date</c> value passed in the request.</p>.
        ///
        /// <p>Note: Currency conversion calculations use the latest exchange rates. Exchange rates
        /// may vary between the time of the preview and the time of the actual invoice creation. <a
        /// href="https://docs.stripe.com/currencies/conversions">Learn more</a></p>.
        /// </summary>
        public virtual Invoice Upcoming(UpcomingInvoiceOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Invoice>(BaseAddress.Api, HttpMethod.Get, $"/v1/invoices/upcoming", options, requestOptions);
        }

        /// <summary>
        /// <p>At any time, you can preview the upcoming invoice for a customer. This will show you
        /// all the charges that are pending, including subscription renewal charges, invoice item
        /// charges, etc. It will also show you any discounts that are applicable to the
        /// invoice.</p>.
        ///
        /// <p>Note that when you are viewing an upcoming invoice, you are simply viewing a preview
        /// – the invoice has not yet been created. As such, the upcoming invoice will not show up
        /// in invoice listing calls, and you cannot use the API to pay or edit the invoice. If you
        /// want to change the amount that your customer will be billed, you can add, remove, or
        /// update pending invoice items, or update the customer’s discount.</p>.
        ///
        /// <p>You can preview the effects of updating a subscription, including a preview of what
        /// proration will take place. To ensure that the actual proration is calculated exactly the
        /// same as the previewed proration, you should pass the
        /// <c>subscription_details.proration_date</c> parameter when doing the actual subscription
        /// update. The recommended way to get only the prorations being previewed is to consider
        /// only proration line items where <c>period[start]</c> is equal to the
        /// <c>subscription_details.proration_date</c> value passed in the request.</p>.
        ///
        /// <p>Note: Currency conversion calculations use the latest exchange rates. Exchange rates
        /// may vary between the time of the preview and the time of the actual invoice creation. <a
        /// href="https://docs.stripe.com/currencies/conversions">Learn more</a></p>.
        /// </summary>
        public virtual Task<Invoice> UpcomingAsync(UpcomingInvoiceOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Invoice>(BaseAddress.Api, HttpMethod.Get, $"/v1/invoices/upcoming", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Draft invoices are fully editable. Once an invoice is <a
        /// href="https://stripe.com/docs/billing/invoices/workflow#finalized">finalized</a>,
        /// monetary values, as well as <c>collection_method</c>, become uneditable.</p>.
        ///
        /// <p>If you would like to stop the Stripe Billing engine from automatically finalizing,
        /// reattempting payments on, sending reminders for, or <a
        /// href="https://stripe.com/docs/billing/invoices/reconciliation">automatically
        /// reconciling</a> invoices, pass <c>auto_advance=false</c>.</p>.
        /// </summary>
        public virtual Invoice Update(string id, InvoiceUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Invoice>(BaseAddress.Api, HttpMethod.Post, $"/v1/invoices/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Draft invoices are fully editable. Once an invoice is <a
        /// href="https://stripe.com/docs/billing/invoices/workflow#finalized">finalized</a>,
        /// monetary values, as well as <c>collection_method</c>, become uneditable.</p>.
        ///
        /// <p>If you would like to stop the Stripe Billing engine from automatically finalizing,
        /// reattempting payments on, sending reminders for, or <a
        /// href="https://stripe.com/docs/billing/invoices/reconciliation">automatically
        /// reconciling</a> invoices, pass <c>auto_advance=false</c>.</p>.
        /// </summary>
        public virtual Task<Invoice> UpdateAsync(string id, InvoiceUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Invoice>(BaseAddress.Api, HttpMethod.Post, $"/v1/invoices/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates an invoice’s line item. Some fields, such as <c>tax_amounts</c>, only live on
        /// the invoice line item, so they can only be updated through this endpoint. Other fields,
        /// such as <c>amount</c>, live on both the invoice item and the invoice line item, so
        /// updates on this endpoint will propagate to the invoice item as well. Updating an
        /// invoice’s line item is only possible before the invoice is finalized.</p>.
        /// </summary>
        public virtual InvoiceLineItem Update(string parentId, string id, InvoiceUpdateInvoiceLineItemsOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<InvoiceLineItem>(BaseAddress.Api, HttpMethod.Post, $"/v1/invoices/{WebUtility.UrlEncode(parentId)}/lines/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates an invoice’s line item. Some fields, such as <c>tax_amounts</c>, only live on
        /// the invoice line item, so they can only be updated through this endpoint. Other fields,
        /// such as <c>amount</c>, live on both the invoice item and the invoice line item, so
        /// updates on this endpoint will propagate to the invoice item as well. Updating an
        /// invoice’s line item is only possible before the invoice is finalized.</p>.
        /// </summary>
        public virtual Task<InvoiceLineItem> UpdateAsync(string parentId, string id, InvoiceUpdateInvoiceLineItemsOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<InvoiceLineItem>(BaseAddress.Api, HttpMethod.Post, $"/v1/invoices/{WebUtility.UrlEncode(parentId)}/lines/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates multiple line items on an invoice. This is only possible when an invoice is
        /// still a draft.</p>.
        /// </summary>
        public virtual Invoice UpdateLines(string id, InvoiceUpdateLinesOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Invoice>(BaseAddress.Api, HttpMethod.Post, $"/v1/invoices/{WebUtility.UrlEncode(id)}/update_lines", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates multiple line items on an invoice. This is only possible when an invoice is
        /// still a draft.</p>.
        /// </summary>
        public virtual Task<Invoice> UpdateLinesAsync(string id, InvoiceUpdateLinesOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Invoice>(BaseAddress.Api, HttpMethod.Post, $"/v1/invoices/{WebUtility.UrlEncode(id)}/update_lines", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Mark a finalized invoice as void. This cannot be undone. Voiding an invoice is
        /// similar to <a href="https://stripe.com/docs/api#delete_invoice">deletion</a>, however it
        /// only applies to finalized invoices and maintains a papertrail where the invoice can
        /// still be found.</p>.
        ///
        /// <p>Consult with local regulations to determine whether and how an invoice might be
        /// amended, canceled, or voided in the jurisdiction you’re doing business in. You might
        /// need to <a href="https://stripe.com/docs/api#create_invoice">issue another invoice</a>
        /// or <a href="https://stripe.com/docs/api#create_credit_note">credit note</a> instead.
        /// Stripe recommends that you consult with your legal counsel for advice specific to your
        /// business.</p>.
        /// </summary>
        public virtual Invoice VoidInvoice(string id, InvoiceVoidOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Invoice>(BaseAddress.Api, HttpMethod.Post, $"/v1/invoices/{WebUtility.UrlEncode(id)}/void", options, requestOptions);
        }

        /// <summary>
        /// <p>Mark a finalized invoice as void. This cannot be undone. Voiding an invoice is
        /// similar to <a href="https://stripe.com/docs/api#delete_invoice">deletion</a>, however it
        /// only applies to finalized invoices and maintains a papertrail where the invoice can
        /// still be found.</p>.
        ///
        /// <p>Consult with local regulations to determine whether and how an invoice might be
        /// amended, canceled, or voided in the jurisdiction you’re doing business in. You might
        /// need to <a href="https://stripe.com/docs/api#create_invoice">issue another invoice</a>
        /// or <a href="https://stripe.com/docs/api#create_credit_note">credit note</a> instead.
        /// Stripe recommends that you consult with your legal counsel for advice specific to your
        /// business.</p>.
        /// </summary>
        public virtual Task<Invoice> VoidInvoiceAsync(string id, InvoiceVoidOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Invoice>(BaseAddress.Api, HttpMethod.Post, $"/v1/invoices/{WebUtility.UrlEncode(id)}/void", options, requestOptions, cancellationToken);
        }
    }
}
