namespace Stripe
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class CustomerService : StripeService,
        ICreatable<Customer, CustomerCreateOptions>,
        IDeletable<Customer>,
        IListable<Customer, CustomerListOptions>,
        IRetrievable<Customer>,
        IUpdatable<Customer, CustomerUpdateOptions>
    {
        public CustomerService()
            : base(null)
        {
        }

        public CustomerService(string apiKey)
            : base(apiKey)
        {
        }

        public bool ExpandDefaultSource { get; set; }

        public bool ExpandDefaultCustomerBankAccount { get; set; }

        public virtual Customer Create(CustomerCreateOptions createOptions, RequestOptions requestOptions = null)
        {
            return Mapper<Customer>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(createOptions, Urls.Customers, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Customer Get(string customerId, RequestOptions requestOptions = null)
        {
            return Mapper<Customer>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{Urls.Customers}/{WebUtility.UrlEncode(customerId)}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Customer Update(string customerId, CustomerUpdateOptions updateOptions, RequestOptions requestOptions = null)
        {
            return Mapper<Customer>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(updateOptions, $"{Urls.Customers}/{WebUtility.UrlEncode(customerId)}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Customer Delete(string customerId, RequestOptions requestOptions = null)
        {
            return Mapper<Customer>.MapFromJson(
                Requestor.Delete(
                    $"{Urls.Customers}/{WebUtility.UrlEncode(customerId)}",
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<Customer> List(CustomerListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<Customer>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, Urls.Customers, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<Customer> CreateAsync(CustomerCreateOptions createOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Customer>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(createOptions, Urls.Customers, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Customer> GetAsync(string customerId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Customer>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{Urls.Customers}/{WebUtility.UrlEncode(customerId)}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Customer> UpdateAsync(string customerId, CustomerUpdateOptions updateOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Customer>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(updateOptions, $"{Urls.Customers}/{WebUtility.UrlEncode(customerId)}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Customer> DeleteAsync(string customerId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Customer>.MapFromJson(
                await Requestor.DeleteAsync(
                    $"{Urls.Customers}/{WebUtility.UrlEncode(customerId)}",
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<Customer>> ListAsync(CustomerListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<Customer>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, Urls.Customers, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}
