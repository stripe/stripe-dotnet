namespace Stripe
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class CustomerService : StripeService
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

        public virtual StripeCustomer Create(CustomerCreateOptions createOptions, RequestOptions requestOptions = null)
        {
            return Mapper<StripeCustomer>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(createOptions, Urls.Customers, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeCustomer Get(string customerId, RequestOptions requestOptions = null)
        {
            return Mapper<StripeCustomer>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{Urls.Customers}/{WebUtility.UrlEncode(customerId)}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeCustomer Update(string customerId, CustomerUpdateOptions updateOptions, RequestOptions requestOptions = null)
        {
            return Mapper<StripeCustomer>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(updateOptions, $"{Urls.Customers}/{WebUtility.UrlEncode(customerId)}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeCustomer Delete(string customerId, RequestOptions requestOptions = null)
        {
            return Mapper<StripeCustomer>.MapFromJson(
                Requestor.Delete(
                    $"{Urls.Customers}/{WebUtility.UrlEncode(customerId)}",
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<StripeCustomer> List(CustomerListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<StripeCustomer>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, Urls.Customers, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<StripeCustomer> CreateAsync(CustomerCreateOptions createOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeCustomer>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(createOptions, Urls.Customers, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeCustomer> GetAsync(string customerId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeCustomer>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{Urls.Customers}/{WebUtility.UrlEncode(customerId)}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeCustomer> UpdateAsync(string customerId, CustomerUpdateOptions updateOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeCustomer>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(updateOptions, $"{Urls.Customers}/{WebUtility.UrlEncode(customerId)}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeCustomer> DeleteAsync(string customerId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeCustomer>.MapFromJson(
                await Requestor.DeleteAsync(
                    $"{Urls.Customers}/{WebUtility.UrlEncode(customerId)}",
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<StripeCustomer>> ListAsync(CustomerListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<StripeCustomer>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, Urls.Customers, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}
