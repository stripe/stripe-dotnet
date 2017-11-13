using System;

namespace Stripe.Tests.Xunit
{
    public class apple_pay_domains_fixture : IDisposable
    {
        public StripeApplePayDomainCreateOptions DomainCreateOptions { get; set; }
        public StripeApplePayDomainListOptions DomainListOptions { get; set; }

        public StripeApplePayDomain Domain { get; set; }
        public StripeApplePayDomain DomainRetrieved { get; set; }
        public StripeList<StripeApplePayDomain> Domains { get; set; }

        public apple_pay_domains_fixture()
        {
            DomainCreateOptions = new StripeApplePayDomainCreateOptions
            {
                DomainName = "example.com"
            };
            DomainListOptions = new StripeApplePayDomainListOptions();

            var service = new StripeApplePayDomainService(Cache.ApiKey);
            Domain = service.Create(DomainCreateOptions);
            DomainRetrieved = service.Get(Domain.Id);
            Domains = service.List(DomainListOptions);
            service.Delete(Domain.Id);
        }

        public void Dispose() { }
    }
}
