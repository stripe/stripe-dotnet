// File generated from our OpenAPI spec
namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Stripe;
    using Xunit;

    public class GeneratedExamplesTest : BaseStripeTest
    {
        public GeneratedExamplesTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
        }

        [Fact]
        public void TestAccountLinksPost()
        {
            var options = new AccountLinkCreateOptions
            {
                Account = "acct_xxxxxxxxxxxxx",
                RefreshUrl = "https://example.com/reauth",
                ReturnUrl = "https://example.com/return",
                Type = "account_onboarding",
            };
            var service = new AccountLinkService(this.StripeClient);
            AccountLink accountLink = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/account_links");
        }

        [Fact]
        public async Task TestAccountLinksPostAsync()
        {
            var options = new AccountLinkCreateOptions
            {
                Account = "acct_xxxxxxxxxxxxx",
                RefreshUrl = "https://example.com/reauth",
                ReturnUrl = "https://example.com/return",
                Type = "account_onboarding",
            };
            var service = new AccountLinkService(this.StripeClient);
            AccountLink accountLink = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/account_links");
        }

        [Fact]
        public void TestAccountsCapabilitiesGet()
        {
            var service = new AccountCapabilityService(this.StripeClient);
            StripeList<Capability> capabilities = service.List(
                "acct_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/accounts/acct_xxxxxxxxxxxxx/capabilities");
        }

        [Fact]
        public async Task TestAccountsCapabilitiesGetAsync()
        {
            var service = new AccountCapabilityService(this.StripeClient);
            StripeList<Capability> capabilities = await service.ListAsync(
                "acct_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/accounts/acct_xxxxxxxxxxxxx/capabilities");
        }

        [Fact]
        public void TestAccountsCapabilitiesGet2()
        {
            var service = new AccountCapabilityService(this.StripeClient);
            Capability capability = service.Get(
                "acct_xxxxxxxxxxxxx",
                "card_payments");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/accounts/acct_xxxxxxxxxxxxx/capabilities/card_payments");
        }

        [Fact]
        public async Task TestAccountsCapabilitiesGet2Async()
        {
            var service = new AccountCapabilityService(this.StripeClient);
            Capability capability = await service.GetAsync(
                "acct_xxxxxxxxxxxxx",
                "card_payments");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/accounts/acct_xxxxxxxxxxxxx/capabilities/card_payments");
        }

        [Fact]
        public void TestAccountsCapabilitiesPost()
        {
            var options = new AccountCapabilityUpdateOptions
            {
                Requested = true,
            };
            var service = new AccountCapabilityService(this.StripeClient);
            Capability capability = service.Update(
                "acct_xxxxxxxxxxxxx",
                "card_payments",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/accounts/acct_xxxxxxxxxxxxx/capabilities/card_payments");
        }

        [Fact]
        public async Task TestAccountsCapabilitiesPostAsync()
        {
            var options = new AccountCapabilityUpdateOptions
            {
                Requested = true,
            };
            var service = new AccountCapabilityService(this.StripeClient);
            Capability capability = await service.UpdateAsync(
                "acct_xxxxxxxxxxxxx",
                "card_payments",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/accounts/acct_xxxxxxxxxxxxx/capabilities/card_payments");
        }

        [Fact]
        public void TestAccountsDelete()
        {
            var service = new AccountService(this.StripeClient);
            Account deleted = service.Delete("acct_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/accounts/acct_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestAccountsDeleteAsync()
        {
            var service = new AccountService(this.StripeClient);
            Account deleted = await service.DeleteAsync("acct_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/accounts/acct_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestAccountsGet()
        {
            var options = new AccountListOptions { Limit = 3 };
            var service = new AccountService(this.StripeClient);
            StripeList<Account> accounts = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/accounts", "limit=3");
        }

        [Fact]
        public async Task TestAccountsGetAsync()
        {
            var options = new AccountListOptions { Limit = 3 };
            var service = new AccountService(this.StripeClient);
            StripeList<Account> accounts = await service.ListAsync(options);
            this.AssertRequest(HttpMethod.Get, "/v1/accounts", "limit=3");
        }

        [Fact]
        public void TestAccountsGetAutoPaging()
        {
            var options = new AccountListOptions { Limit = 3 };
            var service = new AccountService(this.StripeClient);
            var account = service.ListAutoPaging(options).First();
            this.AssertRequest(HttpMethod.Get, "/v1/accounts", "limit=3");
        }

        [Fact]
        public async Task TestAccountsGetAutoPagingAsync()
        {
            var options = new AccountListOptions { Limit = 3 };
            var service = new AccountService(this.StripeClient);
            var account = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/accounts", "limit=3");
        }

        [Fact]
        public void TestAccountsGet2()
        {
            var service = new AccountService(this.StripeClient);
            Account account = service.Get("acct_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/accounts/acct_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestAccountsGet2Async()
        {
            var service = new AccountService(this.StripeClient);
            Account account = await service.GetAsync("acct_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/accounts/acct_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestAccountsLoginLinksPost()
        {
            var service = new AccountLoginLinkService(this.StripeClient);
            LoginLink loginLink = service.Create("acct_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/accounts/acct_xxxxxxxxxxxxx/login_links");
        }

        [Fact]
        public async Task TestAccountsLoginLinksPostAsync()
        {
            var service = new AccountLoginLinkService(this.StripeClient);
            LoginLink loginLink = await service.CreateAsync(
                "acct_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/accounts/acct_xxxxxxxxxxxxx/login_links");
        }

        [Fact]
        public void TestAccountsPersonsDelete()
        {
            var service = new AccountPersonService(this.StripeClient);
            Person deleted = service.Delete(
                "acct_xxxxxxxxxxxxx",
                "person_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/accounts/acct_xxxxxxxxxxxxx/persons/person_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestAccountsPersonsDeleteAsync()
        {
            var service = new AccountPersonService(this.StripeClient);
            Person deleted = await service.DeleteAsync(
                "acct_xxxxxxxxxxxxx",
                "person_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/accounts/acct_xxxxxxxxxxxxx/persons/person_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestAccountsPersonsGet()
        {
            var options = new AccountPersonListOptions { Limit = 3 };
            var service = new AccountPersonService(this.StripeClient);
            StripeList<Person> persons = service.List(
                "acct_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/accounts/acct_xxxxxxxxxxxxx/persons",
                "limit=3");
        }

        [Fact]
        public async Task TestAccountsPersonsGetAsync()
        {
            var options = new AccountPersonListOptions { Limit = 3 };
            var service = new AccountPersonService(this.StripeClient);
            StripeList<Person> persons = await service.ListAsync(
                "acct_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/accounts/acct_xxxxxxxxxxxxx/persons",
                "limit=3");
        }

        [Fact]
        public void TestAccountsPersonsGetAutoPaging()
        {
            var options = new AccountPersonListOptions { Limit = 3 };
            var service = new AccountPersonService(this.StripeClient);
            var person = service.ListAutoPaging("acct_xxxxxxxxxxxxx", options)
                .First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/accounts/acct_xxxxxxxxxxxxx/persons",
                "limit=3");
        }

        [Fact]
        public async Task TestAccountsPersonsGetAutoPagingAsync()
        {
            var options = new AccountPersonListOptions { Limit = 3 };
            var service = new AccountPersonService(this.StripeClient);
            var person = await service.ListAutoPagingAsync(
                "acct_xxxxxxxxxxxxx",
                options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/accounts/acct_xxxxxxxxxxxxx/persons",
                "limit=3");
        }

        [Fact]
        public void TestAccountsPersonsGet2()
        {
            var service = new AccountPersonService(this.StripeClient);
            Person person = service.Get(
                "acct_xxxxxxxxxxxxx",
                "person_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/accounts/acct_xxxxxxxxxxxxx/persons/person_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestAccountsPersonsGet2Async()
        {
            var service = new AccountPersonService(this.StripeClient);
            Person person = await service.GetAsync(
                "acct_xxxxxxxxxxxxx",
                "person_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/accounts/acct_xxxxxxxxxxxxx/persons/person_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestAccountsPersonsPost()
        {
            var options = new AccountPersonCreateOptions
            {
                FirstName = "Jane",
                LastName = "Diaz",
            };
            var service = new AccountPersonService(this.StripeClient);
            Person person = service.Create("acct_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/accounts/acct_xxxxxxxxxxxxx/persons");
        }

        [Fact]
        public async Task TestAccountsPersonsPostAsync()
        {
            var options = new AccountPersonCreateOptions
            {
                FirstName = "Jane",
                LastName = "Diaz",
            };
            var service = new AccountPersonService(this.StripeClient);
            Person person = await service.CreateAsync(
                "acct_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/accounts/acct_xxxxxxxxxxxxx/persons");
        }

        [Fact]
        public void TestAccountsPersonsPost2()
        {
            var options = new AccountPersonUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new AccountPersonService(this.StripeClient);
            Person person = service.Update(
                "acct_xxxxxxxxxxxxx",
                "person_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/accounts/acct_xxxxxxxxxxxxx/persons/person_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestAccountsPersonsPost2Async()
        {
            var options = new AccountPersonUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new AccountPersonService(this.StripeClient);
            Person person = await service.UpdateAsync(
                "acct_xxxxxxxxxxxxx",
                "person_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/accounts/acct_xxxxxxxxxxxxx/persons/person_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestAccountsPost()
        {
            var options = new AccountCreateOptions
            {
                Type = "custom",
                Country = "US",
                Email = "jenny.rosen@example.com",
                Capabilities = new AccountCapabilitiesOptions
                {
                    CardPayments = new AccountCapabilitiesCardPaymentsOptions
                    {
                        Requested = true,
                    },
                    Transfers = new AccountCapabilitiesTransfersOptions
                    {
                        Requested = true,
                    },
                },
            };
            var service = new AccountService(this.StripeClient);
            Account account = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/accounts");
        }

        [Fact]
        public async Task TestAccountsPostAsync()
        {
            var options = new AccountCreateOptions
            {
                Type = "custom",
                Country = "US",
                Email = "jenny.rosen@example.com",
                Capabilities = new AccountCapabilitiesOptions
                {
                    CardPayments = new AccountCapabilitiesCardPaymentsOptions
                    {
                        Requested = true,
                    },
                    Transfers = new AccountCapabilitiesTransfersOptions
                    {
                        Requested = true,
                    },
                },
            };
            var service = new AccountService(this.StripeClient);
            Account account = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/accounts");
        }

        [Fact]
        public void TestAccountsPost2()
        {
            var options = new AccountUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new AccountService(this.StripeClient);
            Account account = service.Update("acct_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/accounts/acct_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestAccountsPost2Async()
        {
            var options = new AccountUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new AccountService(this.StripeClient);
            Account account = await service.UpdateAsync(
                "acct_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/accounts/acct_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestAccountsRejectPost()
        {
            var options = new AccountRejectOptions { Reason = "fraud" };
            var service = new AccountService(this.StripeClient);
            Account account = service.Reject("acct_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/accounts/acct_xxxxxxxxxxxxx/reject");
        }

        [Fact]
        public async Task TestAccountsRejectPostAsync()
        {
            var options = new AccountRejectOptions { Reason = "fraud" };
            var service = new AccountService(this.StripeClient);
            Account account = await service.RejectAsync(
                "acct_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/accounts/acct_xxxxxxxxxxxxx/reject");
        }

        [Fact]
        public void TestApplicationFeesGet()
        {
            var options = new ApplicationFeeListOptions { Limit = 3 };
            var service = new ApplicationFeeService(this.StripeClient);
            StripeList<ApplicationFee> applicationFees = service.List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/application_fees",
                "limit=3");
        }

        [Fact]
        public async Task TestApplicationFeesGetAsync()
        {
            var options = new ApplicationFeeListOptions { Limit = 3 };
            var service = new ApplicationFeeService(this.StripeClient);
            StripeList<ApplicationFee> applicationFees = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/application_fees",
                "limit=3");
        }

        [Fact]
        public void TestApplicationFeesGetAutoPaging()
        {
            var options = new ApplicationFeeListOptions { Limit = 3 };
            var service = new ApplicationFeeService(this.StripeClient);
            var applicationFee = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/application_fees",
                "limit=3");
        }

        [Fact]
        public async Task TestApplicationFeesGetAutoPagingAsync()
        {
            var options = new ApplicationFeeListOptions { Limit = 3 };
            var service = new ApplicationFeeService(this.StripeClient);
            var applicationFee = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/application_fees",
                "limit=3");
        }

        [Fact]
        public void TestApplicationFeesGet2()
        {
            var service = new ApplicationFeeService(this.StripeClient);
            ApplicationFee applicationFee = service.Get("fee_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/application_fees/fee_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestApplicationFeesGet2Async()
        {
            var service = new ApplicationFeeService(this.StripeClient);
            ApplicationFee applicationFee = await service.GetAsync(
                "fee_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/application_fees/fee_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestApplicationFeesRefundsGet()
        {
            var options = new ApplicationFeeRefundListOptions { Limit = 3 };
            var service = new ApplicationFeeRefundService(this.StripeClient);
            StripeList<ApplicationFeeRefund> applicationFeeRefunds = service
                .List("fee_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/application_fees/fee_xxxxxxxxxxxxx/refunds",
                "limit=3");
        }

        [Fact]
        public async Task TestApplicationFeesRefundsGetAsync()
        {
            var options = new ApplicationFeeRefundListOptions { Limit = 3 };
            var service = new ApplicationFeeRefundService(this.StripeClient);
            StripeList<ApplicationFeeRefund> applicationFeeRefunds = await service
                .ListAsync("fee_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/application_fees/fee_xxxxxxxxxxxxx/refunds",
                "limit=3");
        }

        [Fact]
        public void TestApplicationFeesRefundsGetAutoPaging()
        {
            var options = new ApplicationFeeRefundListOptions { Limit = 3 };
            var service = new ApplicationFeeRefundService(this.StripeClient);
            var applicationFeeRefund = service.ListAutoPaging(
                "fee_xxxxxxxxxxxxx",
                options)
                .First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/application_fees/fee_xxxxxxxxxxxxx/refunds",
                "limit=3");
        }

        [Fact]
        public async Task TestApplicationFeesRefundsGetAutoPagingAsync()
        {
            var options = new ApplicationFeeRefundListOptions { Limit = 3 };
            var service = new ApplicationFeeRefundService(this.StripeClient);
            var applicationFeeRefund = await service.ListAutoPagingAsync(
                "fee_xxxxxxxxxxxxx",
                options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/application_fees/fee_xxxxxxxxxxxxx/refunds",
                "limit=3");
        }

        [Fact]
        public void TestApplicationFeesRefundsGet2()
        {
            var service = new ApplicationFeeRefundService(this.StripeClient);
            ApplicationFeeRefund applicationFeeRefund = service.Get(
                "fee_xxxxxxxxxxxxx",
                "fr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/application_fees/fee_xxxxxxxxxxxxx/refunds/fr_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestApplicationFeesRefundsGet2Async()
        {
            var service = new ApplicationFeeRefundService(this.StripeClient);
            ApplicationFeeRefund applicationFeeRefund = await service.GetAsync(
                "fee_xxxxxxxxxxxxx",
                "fr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/application_fees/fee_xxxxxxxxxxxxx/refunds/fr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestApplicationFeesRefundsPost()
        {
            var service = new ApplicationFeeRefundService(this.StripeClient);
            ApplicationFeeRefund applicationFeeRefund = service.Create(
                "fee_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/application_fees/fee_xxxxxxxxxxxxx/refunds");
        }

        [Fact]
        public async Task TestApplicationFeesRefundsPostAsync()
        {
            var service = new ApplicationFeeRefundService(this.StripeClient);
            ApplicationFeeRefund applicationFeeRefund = await service
                .CreateAsync("fee_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/application_fees/fee_xxxxxxxxxxxxx/refunds");
        }

        [Fact]
        public void TestApplicationFeesRefundsPost2()
        {
            var options = new ApplicationFeeRefundUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new ApplicationFeeRefundService(this.StripeClient);
            ApplicationFeeRefund applicationFeeRefund = service.Update(
                "fee_xxxxxxxxxxxxx",
                "fr_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/application_fees/fee_xxxxxxxxxxxxx/refunds/fr_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestApplicationFeesRefundsPost2Async()
        {
            var options = new ApplicationFeeRefundUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new ApplicationFeeRefundService(this.StripeClient);
            ApplicationFeeRefund applicationFeeRefund = await service
                .UpdateAsync("fee_xxxxxxxxxxxxx", "fr_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/application_fees/fee_xxxxxxxxxxxxx/refunds/fr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestAppsSecretsDeletePost()
        {
            var options = new Stripe.Apps.SecretDeleteWhereOptions
            {
                Name = "my-api-key",
                Scope = new Stripe.Apps.SecretScopeOptions { Type = "account" },
            };
            var service = new Stripe.Apps.SecretService(this.StripeClient);
            Stripe.Apps.Secret secret = service.DeleteWhere(options);
            this.AssertRequest(HttpMethod.Post, "/v1/apps/secrets/delete");
        }

        [Fact]
        public async Task TestAppsSecretsDeletePostAsync()
        {
            var options = new Stripe.Apps.SecretDeleteWhereOptions
            {
                Name = "my-api-key",
                Scope = new Stripe.Apps.SecretScopeOptions { Type = "account" },
            };
            var service = new Stripe.Apps.SecretService(this.StripeClient);
            Stripe.Apps.Secret secret = await service.DeleteWhereAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/apps/secrets/delete");
        }

        [Fact]
        public void TestAppsSecretsFindGet()
        {
            var options = new Stripe.Apps.SecretFindOptions
            {
                Name = "sec_123",
                Scope = new Stripe.Apps.SecretScopeOptions { Type = "account" },
            };
            var service = new Stripe.Apps.SecretService(this.StripeClient);
            Stripe.Apps.Secret secret = service.Find(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/apps/secrets/find",
                "name=sec_123&scope[type]=account");
        }

        [Fact]
        public async Task TestAppsSecretsFindGetAsync()
        {
            var options = new Stripe.Apps.SecretFindOptions
            {
                Name = "sec_123",
                Scope = new Stripe.Apps.SecretScopeOptions { Type = "account" },
            };
            var service = new Stripe.Apps.SecretService(this.StripeClient);
            Stripe.Apps.Secret secret = await service.FindAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/apps/secrets/find",
                "name=sec_123&scope[type]=account");
        }

        [Fact]
        public void TestAppsSecretsGet()
        {
            var options = new Stripe.Apps.SecretListOptions
            {
                Scope = new Stripe.Apps.SecretScopeOptions { Type = "account" },
                Limit = 2,
            };
            var service = new Stripe.Apps.SecretService(this.StripeClient);
            StripeList<Stripe.Apps.Secret> secrets = service.List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/apps/secrets",
                "scope[type]=account&limit=2");
        }

        [Fact]
        public async Task TestAppsSecretsGetAsync()
        {
            var options = new Stripe.Apps.SecretListOptions
            {
                Scope = new Stripe.Apps.SecretScopeOptions { Type = "account" },
                Limit = 2,
            };
            var service = new Stripe.Apps.SecretService(this.StripeClient);
            StripeList<Stripe.Apps.Secret> secrets = await service.ListAsync(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/apps/secrets",
                "scope[type]=account&limit=2");
        }

        [Fact]
        public void TestAppsSecretsGetAutoPaging()
        {
            var options = new Stripe.Apps.SecretListOptions
            {
                Scope = new Stripe.Apps.SecretScopeOptions { Type = "account" },
                Limit = 2,
            };
            var service = new Stripe.Apps.SecretService(this.StripeClient);
            var secret = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/apps/secrets",
                "scope[type]=account&limit=2");
        }

        [Fact]
        public async Task TestAppsSecretsGetAutoPagingAsync()
        {
            var options = new Stripe.Apps.SecretListOptions
            {
                Scope = new Stripe.Apps.SecretScopeOptions { Type = "account" },
                Limit = 2,
            };
            var service = new Stripe.Apps.SecretService(this.StripeClient);
            var secret = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/apps/secrets",
                "scope[type]=account&limit=2");
        }

        [Fact]
        public void TestAppsSecretsGet2()
        {
            var options = new Stripe.Apps.SecretListOptions
            {
                Scope = new Stripe.Apps.SecretScopeOptions { Type = "account" },
                Limit = 2,
            };
            var service = new Stripe.Apps.SecretService(this.StripeClient);
            StripeList<Stripe.Apps.Secret> secrets = service.List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/apps/secrets",
                "scope[type]=account&limit=2");
        }

        [Fact]
        public async Task TestAppsSecretsGet2Async()
        {
            var options = new Stripe.Apps.SecretListOptions
            {
                Scope = new Stripe.Apps.SecretScopeOptions { Type = "account" },
                Limit = 2,
            };
            var service = new Stripe.Apps.SecretService(this.StripeClient);
            StripeList<Stripe.Apps.Secret> secrets = await service.ListAsync(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/apps/secrets",
                "scope[type]=account&limit=2");
        }

        [Fact]
        public void TestAppsSecretsGet2AutoPaging()
        {
            var options = new Stripe.Apps.SecretListOptions
            {
                Scope = new Stripe.Apps.SecretScopeOptions { Type = "account" },
                Limit = 2,
            };
            var service = new Stripe.Apps.SecretService(this.StripeClient);
            var secret = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/apps/secrets",
                "scope[type]=account&limit=2");
        }

        [Fact]
        public async Task TestAppsSecretsGet2AutoPagingAsync()
        {
            var options = new Stripe.Apps.SecretListOptions
            {
                Scope = new Stripe.Apps.SecretScopeOptions { Type = "account" },
                Limit = 2,
            };
            var service = new Stripe.Apps.SecretService(this.StripeClient);
            var secret = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/apps/secrets",
                "scope[type]=account&limit=2");
        }

        [Fact]
        public void TestAppsSecretsPost()
        {
            var options = new Stripe.Apps.SecretCreateOptions
            {
                Name = "sec_123",
                Payload = "very secret string",
                Scope = new Stripe.Apps.SecretScopeOptions { Type = "account" },
            };
            var service = new Stripe.Apps.SecretService(this.StripeClient);
            Stripe.Apps.Secret secret = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/apps/secrets");
        }

        [Fact]
        public async Task TestAppsSecretsPostAsync()
        {
            var options = new Stripe.Apps.SecretCreateOptions
            {
                Name = "sec_123",
                Payload = "very secret string",
                Scope = new Stripe.Apps.SecretScopeOptions { Type = "account" },
            };
            var service = new Stripe.Apps.SecretService(this.StripeClient);
            Stripe.Apps.Secret secret = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/apps/secrets");
        }

        [Fact]
        public void TestAppsSecretsPost2()
        {
            var options = new Stripe.Apps.SecretCreateOptions
            {
                Name = "my-api-key",
                Payload = "secret_key_xxxxxx",
                Scope = new Stripe.Apps.SecretScopeOptions { Type = "account" },
            };
            var service = new Stripe.Apps.SecretService(this.StripeClient);
            Stripe.Apps.Secret secret = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/apps/secrets");
        }

        [Fact]
        public async Task TestAppsSecretsPost2Async()
        {
            var options = new Stripe.Apps.SecretCreateOptions
            {
                Name = "my-api-key",
                Payload = "secret_key_xxxxxx",
                Scope = new Stripe.Apps.SecretScopeOptions { Type = "account" },
            };
            var service = new Stripe.Apps.SecretService(this.StripeClient);
            Stripe.Apps.Secret secret = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/apps/secrets");
        }

        [Fact]
        public void TestBalanceTransactionsGet()
        {
            var options = new BalanceTransactionListOptions { Limit = 3 };
            var service = new BalanceTransactionService(this.StripeClient);
            StripeList<BalanceTransaction> balanceTransactions = service.List(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/balance_transactions",
                "limit=3");
        }

        [Fact]
        public async Task TestBalanceTransactionsGetAsync()
        {
            var options = new BalanceTransactionListOptions { Limit = 3 };
            var service = new BalanceTransactionService(this.StripeClient);
            StripeList<BalanceTransaction> balanceTransactions = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/balance_transactions",
                "limit=3");
        }

        [Fact]
        public void TestBalanceTransactionsGetAutoPaging()
        {
            var options = new BalanceTransactionListOptions { Limit = 3 };
            var service = new BalanceTransactionService(this.StripeClient);
            var balanceTransaction = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/balance_transactions",
                "limit=3");
        }

        [Fact]
        public async Task TestBalanceTransactionsGetAutoPagingAsync()
        {
            var options = new BalanceTransactionListOptions { Limit = 3 };
            var service = new BalanceTransactionService(this.StripeClient);
            var balanceTransaction = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/balance_transactions",
                "limit=3");
        }

        [Fact]
        public void TestBalanceTransactionsGet2()
        {
            var service = new BalanceTransactionService(this.StripeClient);
            BalanceTransaction balanceTransaction = service.Get(
                "txn_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/balance_transactions/txn_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestBalanceTransactionsGet2Async()
        {
            var service = new BalanceTransactionService(this.StripeClient);
            BalanceTransaction balanceTransaction = await service.GetAsync(
                "txn_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/balance_transactions/txn_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestBillingPortalConfigurationsGet()
        {
            var options = new Stripe.BillingPortal.ConfigurationListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.BillingPortal.ConfigurationService(
                this.StripeClient);
            StripeList<Stripe.BillingPortal.Configuration> configurations = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/billing_portal/configurations",
                "limit=3");
        }

        [Fact]
        public async Task TestBillingPortalConfigurationsGetAsync()
        {
            var options = new Stripe.BillingPortal.ConfigurationListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.BillingPortal.ConfigurationService(
                this.StripeClient);
            StripeList<Stripe.BillingPortal.Configuration> configurations = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/billing_portal/configurations",
                "limit=3");
        }

        [Fact]
        public void TestBillingPortalConfigurationsGetAutoPaging()
        {
            var options = new Stripe.BillingPortal.ConfigurationListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.BillingPortal.ConfigurationService(
                this.StripeClient);
            var configuration = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/billing_portal/configurations",
                "limit=3");
        }

        [Fact]
        public async Task TestBillingPortalConfigurationsGetAutoPagingAsync()
        {
            var options = new Stripe.BillingPortal.ConfigurationListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.BillingPortal.ConfigurationService(
                this.StripeClient);
            var configuration = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/billing_portal/configurations",
                "limit=3");
        }

        [Fact]
        public void TestBillingPortalConfigurationsGet2()
        {
            var service = new Stripe.BillingPortal.ConfigurationService(
                this.StripeClient);
            Stripe.BillingPortal.Configuration configuration = service.Get(
                "bpc_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/billing_portal/configurations/bpc_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestBillingPortalConfigurationsGet2Async()
        {
            var service = new Stripe.BillingPortal.ConfigurationService(
                this.StripeClient);
            Stripe.BillingPortal.Configuration configuration = await service
                .GetAsync("bpc_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/billing_portal/configurations/bpc_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestBillingPortalConfigurationsPost()
        {
            var options = new Stripe.BillingPortal.ConfigurationCreateOptions
            {
                Features = new Stripe.BillingPortal.ConfigurationFeaturesOptions
                {
                    CustomerUpdate = new Stripe.BillingPortal.ConfigurationFeaturesCustomerUpdateOptions
                    {
                        AllowedUpdates = new List<string> { "email", "tax_id" },
                        Enabled = true,
                    },
                    InvoiceHistory = new Stripe.BillingPortal.ConfigurationFeaturesInvoiceHistoryOptions
                    {
                        Enabled = true,
                    },
                },
                BusinessProfile = new Stripe.BillingPortal.ConfigurationBusinessProfileOptions
                {
                    PrivacyPolicyUrl = "https://example.com/privacy",
                    TermsOfServiceUrl = "https://example.com/terms",
                },
            };
            var service = new Stripe.BillingPortal.ConfigurationService(
                this.StripeClient);
            Stripe.BillingPortal.Configuration configuration = service.Create(
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/billing_portal/configurations");
        }

        [Fact]
        public async Task TestBillingPortalConfigurationsPostAsync()
        {
            var options = new Stripe.BillingPortal.ConfigurationCreateOptions
            {
                Features = new Stripe.BillingPortal.ConfigurationFeaturesOptions
                {
                    CustomerUpdate = new Stripe.BillingPortal.ConfigurationFeaturesCustomerUpdateOptions
                    {
                        AllowedUpdates = new List<string> { "email", "tax_id" },
                        Enabled = true,
                    },
                    InvoiceHistory = new Stripe.BillingPortal.ConfigurationFeaturesInvoiceHistoryOptions
                    {
                        Enabled = true,
                    },
                },
                BusinessProfile = new Stripe.BillingPortal.ConfigurationBusinessProfileOptions
                {
                    PrivacyPolicyUrl = "https://example.com/privacy",
                    TermsOfServiceUrl = "https://example.com/terms",
                },
            };
            var service = new Stripe.BillingPortal.ConfigurationService(
                this.StripeClient);
            Stripe.BillingPortal.Configuration configuration = await service
                .CreateAsync(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/billing_portal/configurations");
        }

        [Fact]
        public void TestBillingPortalConfigurationsPost2()
        {
            var options = new Stripe.BillingPortal.ConfigurationUpdateOptions
            {
                BusinessProfile = new Stripe.BillingPortal.ConfigurationBusinessProfileOptions
                {
                    PrivacyPolicyUrl = "https://example.com/privacy",
                    TermsOfServiceUrl = "https://example.com/terms",
                },
            };
            var service = new Stripe.BillingPortal.ConfigurationService(
                this.StripeClient);
            Stripe.BillingPortal.Configuration configuration = service.Update(
                "bpc_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/billing_portal/configurations/bpc_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestBillingPortalConfigurationsPost2Async()
        {
            var options = new Stripe.BillingPortal.ConfigurationUpdateOptions
            {
                BusinessProfile = new Stripe.BillingPortal.ConfigurationBusinessProfileOptions
                {
                    PrivacyPolicyUrl = "https://example.com/privacy",
                    TermsOfServiceUrl = "https://example.com/terms",
                },
            };
            var service = new Stripe.BillingPortal.ConfigurationService(
                this.StripeClient);
            Stripe.BillingPortal.Configuration configuration = await service
                .UpdateAsync("bpc_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/billing_portal/configurations/bpc_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestBillingPortalSessionsPost()
        {
            var options = new Stripe.BillingPortal.SessionCreateOptions
            {
                Customer = "cus_xxxxxxxxxxxxx",
                ReturnUrl = "https://example.com/account",
            };
            var service = new Stripe.BillingPortal.SessionService(
                this.StripeClient);
            Stripe.BillingPortal.Session session = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/billing_portal/sessions");
        }

        [Fact]
        public async Task TestBillingPortalSessionsPostAsync()
        {
            var options = new Stripe.BillingPortal.SessionCreateOptions
            {
                Customer = "cus_xxxxxxxxxxxxx",
                ReturnUrl = "https://example.com/account",
            };
            var service = new Stripe.BillingPortal.SessionService(
                this.StripeClient);
            Stripe.BillingPortal.Session session = await service.CreateAsync(
                options);
            this.AssertRequest(HttpMethod.Post, "/v1/billing_portal/sessions");
        }

        [Fact]
        public void TestChargesCapturePost()
        {
            var service = new ChargeService(this.StripeClient);
            Charge charge = service.Capture("ch_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/charges/ch_xxxxxxxxxxxxx/capture");
        }

        [Fact]
        public async Task TestChargesCapturePostAsync()
        {
            var service = new ChargeService(this.StripeClient);
            Charge charge = await service.CaptureAsync("ch_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/charges/ch_xxxxxxxxxxxxx/capture");
        }

        [Fact]
        public void TestChargesGet()
        {
            var options = new ChargeListOptions { Limit = 3 };
            var service = new ChargeService(this.StripeClient);
            StripeList<Charge> charges = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/charges", "limit=3");
        }

        [Fact]
        public async Task TestChargesGetAsync()
        {
            var options = new ChargeListOptions { Limit = 3 };
            var service = new ChargeService(this.StripeClient);
            StripeList<Charge> charges = await service.ListAsync(options);
            this.AssertRequest(HttpMethod.Get, "/v1/charges", "limit=3");
        }

        [Fact]
        public void TestChargesGetAutoPaging()
        {
            var options = new ChargeListOptions { Limit = 3 };
            var service = new ChargeService(this.StripeClient);
            var charge = service.ListAutoPaging(options).First();
            this.AssertRequest(HttpMethod.Get, "/v1/charges", "limit=3");
        }

        [Fact]
        public async Task TestChargesGetAutoPagingAsync()
        {
            var options = new ChargeListOptions { Limit = 3 };
            var service = new ChargeService(this.StripeClient);
            var charge = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/charges", "limit=3");
        }

        [Fact]
        public void TestChargesGet2()
        {
            var service = new ChargeService(this.StripeClient);
            Charge charge = service.Get("ch_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/charges/ch_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestChargesGet2Async()
        {
            var service = new ChargeService(this.StripeClient);
            Charge charge = await service.GetAsync("ch_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/charges/ch_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestChargesPost()
        {
            var options = new ChargeCreateOptions
            {
                Amount = 2000,
                Currency = "usd",
                Source = "tok_xxxx",
                Description = "My First Test Charge (created for API docs at https://www.stripe.com/docs/api)",
            };
            var service = new ChargeService(this.StripeClient);
            Charge charge = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/charges");
        }

        [Fact]
        public async Task TestChargesPostAsync()
        {
            var options = new ChargeCreateOptions
            {
                Amount = 2000,
                Currency = "usd",
                Source = "tok_xxxx",
                Description = "My First Test Charge (created for API docs at https://www.stripe.com/docs/api)",
            };
            var service = new ChargeService(this.StripeClient);
            Charge charge = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/charges");
        }

        [Fact]
        public void TestChargesPost2()
        {
            var options = new ChargeUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new ChargeService(this.StripeClient);
            Charge charge = service.Update("ch_xxxxxxxxxxxxx", options);
            this.AssertRequest(HttpMethod.Post, "/v1/charges/ch_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestChargesPost2Async()
        {
            var options = new ChargeUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new ChargeService(this.StripeClient);
            Charge charge = await service.UpdateAsync(
                "ch_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(HttpMethod.Post, "/v1/charges/ch_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestChargesSearchGet()
        {
            var options = new ChargeSearchOptions
            {
                Query = "amount>999 AND metadata['order_id']:'6735'",
            };
            var service = new ChargeService(this.StripeClient);
            StripeSearchResult<Charge> charges = service.Search(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/charges/search",
                "query=amount%3E999%20AND%20metadata%5B%27order_id%27%5D%3A%276735%27");
        }

        [Fact]
        public async Task TestChargesSearchGetAsync()
        {
            var options = new ChargeSearchOptions
            {
                Query = "amount>999 AND metadata['order_id']:'6735'",
            };
            var service = new ChargeService(this.StripeClient);
            StripeSearchResult<Charge> charges = await service.SearchAsync(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/charges/search",
                "query=amount%3E999%20AND%20metadata%5B%27order_id%27%5D%3A%276735%27");
        }

        [Fact]
        public void TestChargesSearchGetAutoPaging()
        {
            var options = new ChargeSearchOptions
            {
                Query = "amount>999 AND metadata['order_id']:'6735'",
            };
            var service = new ChargeService(this.StripeClient);
            var charge = service.SearchAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/charges/search",
                "query=amount%3E999%20AND%20metadata%5B%27order_id%27%5D%3A%276735%27");
        }

        [Fact]
        public async Task TestChargesSearchGetAutoPagingAsync()
        {
            var options = new ChargeSearchOptions
            {
                Query = "amount>999 AND metadata['order_id']:'6735'",
            };
            var service = new ChargeService(this.StripeClient);
            var charge = await service.SearchAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/charges/search",
                "query=amount%3E999%20AND%20metadata%5B%27order_id%27%5D%3A%276735%27");
        }

        [Fact]
        public void TestCheckoutSessionsExpirePost()
        {
            var service = new Stripe.Checkout.SessionService(this.StripeClient);
            Stripe.Checkout.Session session = service.Expire("sess_xyz");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/checkout/sessions/sess_xyz/expire");
        }

        [Fact]
        public async Task TestCheckoutSessionsExpirePostAsync()
        {
            var service = new Stripe.Checkout.SessionService(this.StripeClient);
            Stripe.Checkout.Session session = await service.ExpireAsync(
                "sess_xyz");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/checkout/sessions/sess_xyz/expire");
        }

        [Fact]
        public void TestCheckoutSessionsExpirePost2()
        {
            var service = new Stripe.Checkout.SessionService(this.StripeClient);
            Stripe.Checkout.Session session = service.Expire(
                "cs_test_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/checkout/sessions/cs_test_xxxxxxxxxxxxx/expire");
        }

        [Fact]
        public async Task TestCheckoutSessionsExpirePost2Async()
        {
            var service = new Stripe.Checkout.SessionService(this.StripeClient);
            Stripe.Checkout.Session session = await service.ExpireAsync(
                "cs_test_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/checkout/sessions/cs_test_xxxxxxxxxxxxx/expire");
        }

        [Fact]
        public void TestCheckoutSessionsGet()
        {
            var options = new Stripe.Checkout.SessionListOptions { Limit = 3 };
            var service = new Stripe.Checkout.SessionService(this.StripeClient);
            StripeList<Stripe.Checkout.Session> sessions = service.List(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/checkout/sessions",
                "limit=3");
        }

        [Fact]
        public async Task TestCheckoutSessionsGetAsync()
        {
            var options = new Stripe.Checkout.SessionListOptions { Limit = 3 };
            var service = new Stripe.Checkout.SessionService(this.StripeClient);
            StripeList<Stripe.Checkout.Session> sessions = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/checkout/sessions",
                "limit=3");
        }

        [Fact]
        public void TestCheckoutSessionsGetAutoPaging()
        {
            var options = new Stripe.Checkout.SessionListOptions { Limit = 3 };
            var service = new Stripe.Checkout.SessionService(this.StripeClient);
            var session = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/checkout/sessions",
                "limit=3");
        }

        [Fact]
        public async Task TestCheckoutSessionsGetAutoPagingAsync()
        {
            var options = new Stripe.Checkout.SessionListOptions { Limit = 3 };
            var service = new Stripe.Checkout.SessionService(this.StripeClient);
            var session = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/checkout/sessions",
                "limit=3");
        }

        [Fact]
        public void TestCheckoutSessionsGet2()
        {
            var service = new Stripe.Checkout.SessionService(this.StripeClient);
            Stripe.Checkout.Session session = service.Get(
                "cs_test_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/checkout/sessions/cs_test_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestCheckoutSessionsGet2Async()
        {
            var service = new Stripe.Checkout.SessionService(this.StripeClient);
            Stripe.Checkout.Session session = await service.GetAsync(
                "cs_test_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/checkout/sessions/cs_test_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestCheckoutSessionsLineItemsGet()
        {
            var service = new Stripe.Checkout.SessionLineItemService(
                this.StripeClient);
            StripeList<LineItem> lineItems = service.List("sess_xyz");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/checkout/sessions/sess_xyz/line_items");
        }

        [Fact]
        public async Task TestCheckoutSessionsLineItemsGetAsync()
        {
            var service = new Stripe.Checkout.SessionLineItemService(
                this.StripeClient);
            StripeList<LineItem> lineItems = await service.ListAsync(
                "sess_xyz");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/checkout/sessions/sess_xyz/line_items");
        }

        [Fact]
        public void TestCheckoutSessionsLineItemsGetAutoPaging()
        {
            var service = new Stripe.Checkout.SessionLineItemService(
                this.StripeClient);
            var lineItem = service.ListAutoPaging("sess_xyz").First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/checkout/sessions/sess_xyz/line_items");
        }

        [Fact]
        public async Task TestCheckoutSessionsLineItemsGetAutoPagingAsync()
        {
            var service = new Stripe.Checkout.SessionLineItemService(
                this.StripeClient);
            var lineItem = await service.ListAutoPagingAsync("sess_xyz")
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/checkout/sessions/sess_xyz/line_items");
        }

        [Fact]
        public void TestCheckoutSessionsPost()
        {
            var options = new Stripe.Checkout.SessionCreateOptions
            {
                SuccessUrl = "https://example.com/success",
                CancelUrl = "https://example.com/cancel",
                Mode = "payment",
                ShippingOptions = new List<Stripe.Checkout.SessionShippingOptionOptions>
                {
                    new Stripe.Checkout.SessionShippingOptionOptions
                    {
                        ShippingRate = "shr_standard",
                    },
                    new Stripe.Checkout.SessionShippingOptionOptions
                    {
                        ShippingRateData = new Stripe.Checkout.SessionShippingOptionShippingRateDataOptions
                        {
                            DisplayName = "Standard",
                            DeliveryEstimate = new Stripe.Checkout.SessionShippingOptionShippingRateDataDeliveryEstimateOptions
                            {
                                Minimum = new Stripe.Checkout.SessionShippingOptionShippingRateDataDeliveryEstimateMinimumOptions
                                {
                                    Unit = "day",
                                    Value = 5,
                                },
                                Maximum = new Stripe.Checkout.SessionShippingOptionShippingRateDataDeliveryEstimateMaximumOptions
                                {
                                    Unit = "day",
                                    Value = 7,
                                },
                            },
                        },
                    },
                },
            };
            var service = new Stripe.Checkout.SessionService(this.StripeClient);
            Stripe.Checkout.Session session = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/checkout/sessions");
        }

        [Fact]
        public async Task TestCheckoutSessionsPostAsync()
        {
            var options = new Stripe.Checkout.SessionCreateOptions
            {
                SuccessUrl = "https://example.com/success",
                CancelUrl = "https://example.com/cancel",
                Mode = "payment",
                ShippingOptions = new List<Stripe.Checkout.SessionShippingOptionOptions>
                {
                    new Stripe.Checkout.SessionShippingOptionOptions
                    {
                        ShippingRate = "shr_standard",
                    },
                    new Stripe.Checkout.SessionShippingOptionOptions
                    {
                        ShippingRateData = new Stripe.Checkout.SessionShippingOptionShippingRateDataOptions
                        {
                            DisplayName = "Standard",
                            DeliveryEstimate = new Stripe.Checkout.SessionShippingOptionShippingRateDataDeliveryEstimateOptions
                            {
                                Minimum = new Stripe.Checkout.SessionShippingOptionShippingRateDataDeliveryEstimateMinimumOptions
                                {
                                    Unit = "day",
                                    Value = 5,
                                },
                                Maximum = new Stripe.Checkout.SessionShippingOptionShippingRateDataDeliveryEstimateMaximumOptions
                                {
                                    Unit = "day",
                                    Value = 7,
                                },
                            },
                        },
                    },
                },
            };
            var service = new Stripe.Checkout.SessionService(this.StripeClient);
            Stripe.Checkout.Session session = await service.CreateAsync(
                options);
            this.AssertRequest(HttpMethod.Post, "/v1/checkout/sessions");
        }

        [Fact]
        public void TestCheckoutSessionsPost2()
        {
            var options = new Stripe.Checkout.SessionCreateOptions
            {
                SuccessUrl = "https://example.com/success",
                LineItems = new List<Stripe.Checkout.SessionLineItemOptions>
                {
                    new Stripe.Checkout.SessionLineItemOptions
                    {
                        Price = "price_xxxxxxxxxxxxx",
                        Quantity = 2,
                    },
                },
                Mode = "payment",
            };
            var service = new Stripe.Checkout.SessionService(this.StripeClient);
            Stripe.Checkout.Session session = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/checkout/sessions");
        }

        [Fact]
        public async Task TestCheckoutSessionsPost2Async()
        {
            var options = new Stripe.Checkout.SessionCreateOptions
            {
                SuccessUrl = "https://example.com/success",
                LineItems = new List<Stripe.Checkout.SessionLineItemOptions>
                {
                    new Stripe.Checkout.SessionLineItemOptions
                    {
                        Price = "price_xxxxxxxxxxxxx",
                        Quantity = 2,
                    },
                },
                Mode = "payment",
            };
            var service = new Stripe.Checkout.SessionService(this.StripeClient);
            Stripe.Checkout.Session session = await service.CreateAsync(
                options);
            this.AssertRequest(HttpMethod.Post, "/v1/checkout/sessions");
        }

        [Fact]
        public void TestCoreEventsGet()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/events/ll_123",
                HttpStatusCode.OK,
                "{\"object\":\"v2.core.event\",\"changes\":{\"int_key\":123,\"string_key\":\"value\",\"boolean_key\":true,\"object_key\":{\"object_int_key\":123,\"object_string_key\":\"value\",\"object_boolean_key\":true},\"array_key\":[1,2,3]},\"context\":\"context\",\"created\":\"1970-01-12T21:42:34.472Z\",\"id\":\"obj_123\",\"livemode\":true,\"reason\":{\"request\":{\"id\":\"obj_123\",\"idempotency_key\":\"idempotency_key\"},\"type\":\"request\"},\"type\":\"type\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Events;
            Stripe.V2.Core.Event result = service.Get("ll_123");
            this.AssertRequest(HttpMethod.Get, "/v2/core/events/ll_123");
        }

        [Fact]
        public async Task TestCoreEventsGetAsync()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/events/ll_123",
                HttpStatusCode.OK,
                "{\"object\":\"v2.core.event\",\"changes\":{\"int_key\":123,\"string_key\":\"value\",\"boolean_key\":true,\"object_key\":{\"object_int_key\":123,\"object_string_key\":\"value\",\"object_boolean_key\":true},\"array_key\":[1,2,3]},\"context\":\"context\",\"created\":\"1970-01-12T21:42:34.472Z\",\"id\":\"obj_123\",\"livemode\":true,\"reason\":{\"request\":{\"id\":\"obj_123\",\"idempotency_key\":\"idempotency_key\"},\"type\":\"request\"},\"type\":\"type\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Events;
            Stripe.V2.Core.Event result = await service.GetAsync("ll_123");
            this.AssertRequest(HttpMethod.Get, "/v2/core/events/ll_123");
        }

        [Fact]
        public void TestCountrySpecsGet()
        {
            var options = new CountrySpecListOptions { Limit = 3 };
            var service = new CountrySpecService(this.StripeClient);
            StripeList<CountrySpec> countrySpecs = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/country_specs", "limit=3");
        }

        [Fact]
        public async Task TestCountrySpecsGetAsync()
        {
            var options = new CountrySpecListOptions { Limit = 3 };
            var service = new CountrySpecService(this.StripeClient);
            StripeList<CountrySpec> countrySpecs = await service.ListAsync(
                options);
            this.AssertRequest(HttpMethod.Get, "/v1/country_specs", "limit=3");
        }

        [Fact]
        public void TestCountrySpecsGetAutoPaging()
        {
            var options = new CountrySpecListOptions { Limit = 3 };
            var service = new CountrySpecService(this.StripeClient);
            var countrySpec = service.ListAutoPaging(options).First();
            this.AssertRequest(HttpMethod.Get, "/v1/country_specs", "limit=3");
        }

        [Fact]
        public async Task TestCountrySpecsGetAutoPagingAsync()
        {
            var options = new CountrySpecListOptions { Limit = 3 };
            var service = new CountrySpecService(this.StripeClient);
            var countrySpec = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/country_specs", "limit=3");
        }

        [Fact]
        public void TestCountrySpecsGet2()
        {
            var service = new CountrySpecService(this.StripeClient);
            CountrySpec countrySpec = service.Get("US");
            this.AssertRequest(HttpMethod.Get, "/v1/country_specs/US");
        }

        [Fact]
        public async Task TestCountrySpecsGet2Async()
        {
            var service = new CountrySpecService(this.StripeClient);
            CountrySpec countrySpec = await service.GetAsync("US");
            this.AssertRequest(HttpMethod.Get, "/v1/country_specs/US");
        }

        [Fact]
        public void TestCouponsDelete()
        {
            var service = new CouponService(this.StripeClient);
            Coupon deleted = service.Delete("Z4OV52SU");
            this.AssertRequest(HttpMethod.Delete, "/v1/coupons/Z4OV52SU");
        }

        [Fact]
        public async Task TestCouponsDeleteAsync()
        {
            var service = new CouponService(this.StripeClient);
            Coupon deleted = await service.DeleteAsync("Z4OV52SU");
            this.AssertRequest(HttpMethod.Delete, "/v1/coupons/Z4OV52SU");
        }

        [Fact]
        public void TestCouponsGet()
        {
            var options = new CouponListOptions { Limit = 3 };
            var service = new CouponService(this.StripeClient);
            StripeList<Coupon> coupons = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/coupons", "limit=3");
        }

        [Fact]
        public async Task TestCouponsGetAsync()
        {
            var options = new CouponListOptions { Limit = 3 };
            var service = new CouponService(this.StripeClient);
            StripeList<Coupon> coupons = await service.ListAsync(options);
            this.AssertRequest(HttpMethod.Get, "/v1/coupons", "limit=3");
        }

        [Fact]
        public void TestCouponsGetAutoPaging()
        {
            var options = new CouponListOptions { Limit = 3 };
            var service = new CouponService(this.StripeClient);
            var coupon = service.ListAutoPaging(options).First();
            this.AssertRequest(HttpMethod.Get, "/v1/coupons", "limit=3");
        }

        [Fact]
        public async Task TestCouponsGetAutoPagingAsync()
        {
            var options = new CouponListOptions { Limit = 3 };
            var service = new CouponService(this.StripeClient);
            var coupon = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/coupons", "limit=3");
        }

        [Fact]
        public void TestCouponsGet2()
        {
            var service = new CouponService(this.StripeClient);
            Coupon coupon = service.Get("Z4OV52SU");
            this.AssertRequest(HttpMethod.Get, "/v1/coupons/Z4OV52SU");
        }

        [Fact]
        public async Task TestCouponsGet2Async()
        {
            var service = new CouponService(this.StripeClient);
            Coupon coupon = await service.GetAsync("Z4OV52SU");
            this.AssertRequest(HttpMethod.Get, "/v1/coupons/Z4OV52SU");
        }

        [Fact]
        public void TestCouponsPost()
        {
            var options = new CouponCreateOptions
            {
                PercentOff = 25.5M,
                Duration = "once",
            };
            var service = new CouponService(this.StripeClient);
            Coupon coupon = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/coupons");
        }

        [Fact]
        public async Task TestCouponsPostAsync()
        {
            var options = new CouponCreateOptions
            {
                PercentOff = 25.5M,
                Duration = "once",
            };
            var service = new CouponService(this.StripeClient);
            Coupon coupon = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/coupons");
        }

        [Fact]
        public void TestCouponsPost2()
        {
            var options = new CouponUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new CouponService(this.StripeClient);
            Coupon coupon = service.Update("Z4OV52SU", options);
            this.AssertRequest(HttpMethod.Post, "/v1/coupons/Z4OV52SU");
        }

        [Fact]
        public async Task TestCouponsPost2Async()
        {
            var options = new CouponUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new CouponService(this.StripeClient);
            Coupon coupon = await service.UpdateAsync("Z4OV52SU", options);
            this.AssertRequest(HttpMethod.Post, "/v1/coupons/Z4OV52SU");
        }

        [Fact]
        public void TestCreditNotesGet()
        {
            var options = new CreditNoteListOptions { Limit = 3 };
            var service = new CreditNoteService(this.StripeClient);
            StripeList<CreditNote> creditNotes = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/credit_notes", "limit=3");
        }

        [Fact]
        public async Task TestCreditNotesGetAsync()
        {
            var options = new CreditNoteListOptions { Limit = 3 };
            var service = new CreditNoteService(this.StripeClient);
            StripeList<CreditNote> creditNotes = await service.ListAsync(
                options);
            this.AssertRequest(HttpMethod.Get, "/v1/credit_notes", "limit=3");
        }

        [Fact]
        public void TestCreditNotesGetAutoPaging()
        {
            var options = new CreditNoteListOptions { Limit = 3 };
            var service = new CreditNoteService(this.StripeClient);
            var creditNote = service.ListAutoPaging(options).First();
            this.AssertRequest(HttpMethod.Get, "/v1/credit_notes", "limit=3");
        }

        [Fact]
        public async Task TestCreditNotesGetAutoPagingAsync()
        {
            var options = new CreditNoteListOptions { Limit = 3 };
            var service = new CreditNoteService(this.StripeClient);
            var creditNote = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/credit_notes", "limit=3");
        }

        [Fact]
        public void TestCreditNotesPost()
        {
            var options = new CreditNoteCreateOptions
            {
                Invoice = "in_xxxxxxxxxxxxx",
                Lines = new List<CreditNoteLineOptions>
                {
                    new CreditNoteLineOptions
                    {
                        Type = "invoice_line_item",
                        InvoiceLineItem = "il_xxxxxxxxxxxxx",
                        Quantity = 1,
                    },
                },
            };
            var service = new CreditNoteService(this.StripeClient);
            CreditNote creditNote = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/credit_notes");
        }

        [Fact]
        public async Task TestCreditNotesPostAsync()
        {
            var options = new CreditNoteCreateOptions
            {
                Invoice = "in_xxxxxxxxxxxxx",
                Lines = new List<CreditNoteLineOptions>
                {
                    new CreditNoteLineOptions
                    {
                        Type = "invoice_line_item",
                        InvoiceLineItem = "il_xxxxxxxxxxxxx",
                        Quantity = 1,
                    },
                },
            };
            var service = new CreditNoteService(this.StripeClient);
            CreditNote creditNote = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/credit_notes");
        }

        [Fact]
        public void TestCreditNotesPreviewGet()
        {
            var options = new CreditNotePreviewOptions
            {
                Invoice = "in_xxxxxxxxxxxxx",
                Lines = new List<CreditNoteLineOptions>
                {
                    new CreditNoteLineOptions
                    {
                        Type = "invoice_line_item",
                        InvoiceLineItem = "il_xxxxxxxxxxxxx",
                        Quantity = 1,
                    },
                },
            };
            var service = new CreditNoteService(this.StripeClient);
            CreditNote creditNote = service.Preview(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/credit_notes/preview",
                "invoice=in_xxxxxxxxxxxxx&lines[0][type]=invoice_line_item&lines[0][invoice_line_item]=il_xxxxxxxxxxxxx&lines[0][quantity]=1");
        }

        [Fact]
        public async Task TestCreditNotesPreviewGetAsync()
        {
            var options = new CreditNotePreviewOptions
            {
                Invoice = "in_xxxxxxxxxxxxx",
                Lines = new List<CreditNoteLineOptions>
                {
                    new CreditNoteLineOptions
                    {
                        Type = "invoice_line_item",
                        InvoiceLineItem = "il_xxxxxxxxxxxxx",
                        Quantity = 1,
                    },
                },
            };
            var service = new CreditNoteService(this.StripeClient);
            CreditNote creditNote = await service.PreviewAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/credit_notes/preview",
                "invoice=in_xxxxxxxxxxxxx&lines[0][type]=invoice_line_item&lines[0][invoice_line_item]=il_xxxxxxxxxxxxx&lines[0][quantity]=1");
        }

        [Fact]
        public void TestCreditNotesVoidPost()
        {
            var service = new CreditNoteService(this.StripeClient);
            CreditNote creditNote = service.VoidCreditNote("cn_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/credit_notes/cn_xxxxxxxxxxxxx/void");
        }

        [Fact]
        public async Task TestCreditNotesVoidPostAsync()
        {
            var service = new CreditNoteService(this.StripeClient);
            CreditNote creditNote = await service.VoidCreditNoteAsync(
                "cn_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/credit_notes/cn_xxxxxxxxxxxxx/void");
        }

        [Fact]
        public void TestCustomerSessionsPost()
        {
            var options = new CustomerSessionCreateOptions
            {
                Customer = "cus_123",
                Components = new CustomerSessionComponentsOptions
                {
                    BuyButton = new CustomerSessionComponentsBuyButtonOptions
                    {
                        Enabled = true,
                    },
                },
            };
            var service = new CustomerSessionService(this.StripeClient);
            CustomerSession customerSession = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/customer_sessions");
        }

        [Fact]
        public async Task TestCustomerSessionsPostAsync()
        {
            var options = new CustomerSessionCreateOptions
            {
                Customer = "cus_123",
                Components = new CustomerSessionComponentsOptions
                {
                    BuyButton = new CustomerSessionComponentsBuyButtonOptions
                    {
                        Enabled = true,
                    },
                },
            };
            var service = new CustomerSessionService(this.StripeClient);
            CustomerSession customerSession = await service.CreateAsync(
                options);
            this.AssertRequest(HttpMethod.Post, "/v1/customer_sessions");
        }

        [Fact]
        public void TestCustomersBalanceTransactionsGet()
        {
            var options = new CustomerBalanceTransactionListOptions
            {
                Limit = 3,
            };
            var service = new CustomerBalanceTransactionService(
                this.StripeClient);
            StripeList<CustomerBalanceTransaction> customerBalanceTransactions = service
                .List("cus_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_xxxxxxxxxxxxx/balance_transactions",
                "limit=3");
        }

        [Fact]
        public async Task TestCustomersBalanceTransactionsGetAsync()
        {
            var options = new CustomerBalanceTransactionListOptions
            {
                Limit = 3,
            };
            var service = new CustomerBalanceTransactionService(
                this.StripeClient);
            StripeList<CustomerBalanceTransaction> customerBalanceTransactions = await service
                .ListAsync("cus_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_xxxxxxxxxxxxx/balance_transactions",
                "limit=3");
        }

        [Fact]
        public void TestCustomersBalanceTransactionsGetAutoPaging()
        {
            var options = new CustomerBalanceTransactionListOptions
            {
                Limit = 3,
            };
            var service = new CustomerBalanceTransactionService(
                this.StripeClient);
            var customerBalanceTransaction = service.ListAutoPaging(
                "cus_xxxxxxxxxxxxx",
                options)
                .First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_xxxxxxxxxxxxx/balance_transactions",
                "limit=3");
        }

        [Fact]
        public async Task TestCustomersBalanceTransactionsGetAutoPagingAsync()
        {
            var options = new CustomerBalanceTransactionListOptions
            {
                Limit = 3,
            };
            var service = new CustomerBalanceTransactionService(
                this.StripeClient);
            var customerBalanceTransaction = await service.ListAutoPagingAsync(
                "cus_xxxxxxxxxxxxx",
                options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_xxxxxxxxxxxxx/balance_transactions",
                "limit=3");
        }

        [Fact]
        public void TestCustomersBalanceTransactionsGet2()
        {
            var service = new CustomerBalanceTransactionService(
                this.StripeClient);
            CustomerBalanceTransaction customerBalanceTransaction = service.Get(
                "cus_xxxxxxxxxxxxx",
                "cbtxn_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_xxxxxxxxxxxxx/balance_transactions/cbtxn_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestCustomersBalanceTransactionsGet2Async()
        {
            var service = new CustomerBalanceTransactionService(
                this.StripeClient);
            CustomerBalanceTransaction customerBalanceTransaction = await service
                .GetAsync("cus_xxxxxxxxxxxxx", "cbtxn_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_xxxxxxxxxxxxx/balance_transactions/cbtxn_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestCustomersBalanceTransactionsPost()
        {
            var options = new CustomerBalanceTransactionCreateOptions
            {
                Amount = -500,
                Currency = "usd",
            };
            var service = new CustomerBalanceTransactionService(
                this.StripeClient);
            CustomerBalanceTransaction customerBalanceTransaction = service
                .Create("cus_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/customers/cus_xxxxxxxxxxxxx/balance_transactions");
        }

        [Fact]
        public async Task TestCustomersBalanceTransactionsPostAsync()
        {
            var options = new CustomerBalanceTransactionCreateOptions
            {
                Amount = -500,
                Currency = "usd",
            };
            var service = new CustomerBalanceTransactionService(
                this.StripeClient);
            CustomerBalanceTransaction customerBalanceTransaction = await service
                .CreateAsync("cus_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/customers/cus_xxxxxxxxxxxxx/balance_transactions");
        }

        [Fact]
        public void TestCustomersBalanceTransactionsPost2()
        {
            var options = new CustomerBalanceTransactionUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new CustomerBalanceTransactionService(
                this.StripeClient);
            CustomerBalanceTransaction customerBalanceTransaction = service
                .Update("cus_xxxxxxxxxxxxx", "cbtxn_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/customers/cus_xxxxxxxxxxxxx/balance_transactions/cbtxn_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestCustomersBalanceTransactionsPost2Async()
        {
            var options = new CustomerBalanceTransactionUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new CustomerBalanceTransactionService(
                this.StripeClient);
            CustomerBalanceTransaction customerBalanceTransaction = await service
                .UpdateAsync(
                "cus_xxxxxxxxxxxxx",
                "cbtxn_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/customers/cus_xxxxxxxxxxxxx/balance_transactions/cbtxn_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestCustomersCashBalanceGet()
        {
            var service = new CustomerCashBalanceService(this.StripeClient);
            CashBalance cashBalance = service.Get("cus_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_123/cash_balance");
        }

        [Fact]
        public async Task TestCustomersCashBalanceGetAsync()
        {
            var service = new CustomerCashBalanceService(this.StripeClient);
            CashBalance cashBalance = await service.GetAsync("cus_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_123/cash_balance");
        }

        [Fact]
        public void TestCustomersCashBalancePost()
        {
            var options = new CustomerCashBalanceUpdateOptions
            {
                Settings = new CustomerCashBalanceSettingsOptions
                {
                    ReconciliationMode = "manual",
                },
            };
            var service = new CustomerCashBalanceService(this.StripeClient);
            CashBalance cashBalance = service.Update("cus_123", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/customers/cus_123/cash_balance");
        }

        [Fact]
        public async Task TestCustomersCashBalancePostAsync()
        {
            var options = new CustomerCashBalanceUpdateOptions
            {
                Settings = new CustomerCashBalanceSettingsOptions
                {
                    ReconciliationMode = "manual",
                },
            };
            var service = new CustomerCashBalanceService(this.StripeClient);
            CashBalance cashBalance = await service.UpdateAsync(
                "cus_123",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/customers/cus_123/cash_balance");
        }

        [Fact]
        public void TestCustomersCashBalanceTransactionsGet()
        {
            var options = new CustomerCashBalanceTransactionListOptions
            {
                Limit = 3,
            };
            var service = new CustomerCashBalanceTransactionService(
                this.StripeClient);
            StripeList<CustomerCashBalanceTransaction> customerCashBalanceTransactions = service
                .List("cus_123", options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_123/cash_balance_transactions",
                "limit=3");
        }

        [Fact]
        public async Task TestCustomersCashBalanceTransactionsGetAsync()
        {
            var options = new CustomerCashBalanceTransactionListOptions
            {
                Limit = 3,
            };
            var service = new CustomerCashBalanceTransactionService(
                this.StripeClient);
            StripeList<CustomerCashBalanceTransaction> customerCashBalanceTransactions = await service
                .ListAsync("cus_123", options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_123/cash_balance_transactions",
                "limit=3");
        }

        [Fact]
        public void TestCustomersCashBalanceTransactionsGetAutoPaging()
        {
            var options = new CustomerCashBalanceTransactionListOptions
            {
                Limit = 3,
            };
            var service = new CustomerCashBalanceTransactionService(
                this.StripeClient);
            var customerCashBalanceTransaction = service.ListAutoPaging(
                "cus_123",
                options)
                .First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_123/cash_balance_transactions",
                "limit=3");
        }

        [Fact]
        public async Task TestCustomersCashBalanceTransactionsGetAutoPagingAsync()
        {
            var options = new CustomerCashBalanceTransactionListOptions
            {
                Limit = 3,
            };
            var service = new CustomerCashBalanceTransactionService(
                this.StripeClient);
            var customerCashBalanceTransaction = await service
                .ListAutoPagingAsync("cus_123", options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_123/cash_balance_transactions",
                "limit=3");
        }

        [Fact]
        public void TestCustomersDelete()
        {
            var service = new CustomerService(this.StripeClient);
            Customer deleted = service.Delete("cus_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/customers/cus_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestCustomersDeleteAsync()
        {
            var service = new CustomerService(this.StripeClient);
            Customer deleted = await service.DeleteAsync("cus_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/customers/cus_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestCustomersFundingInstructionsPost()
        {
            var options = new CustomerFundingInstructionsCreateOptions
            {
                BankTransfer = new CustomerFundingInstructionsBankTransferOptions
                {
                    RequestedAddressTypes = new List<string> { "zengin" },
                    Type = "jp_bank_transfer",
                },
                Currency = "usd",
                FundingType = "bank_transfer",
            };
            var service = new CustomerFundingInstructionsService(
                this.StripeClient);
            FundingInstructions fundingInstructions = service.Create(
                "cus_123",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/customers/cus_123/funding_instructions");
        }

        [Fact]
        public async Task TestCustomersFundingInstructionsPostAsync()
        {
            var options = new CustomerFundingInstructionsCreateOptions
            {
                BankTransfer = new CustomerFundingInstructionsBankTransferOptions
                {
                    RequestedAddressTypes = new List<string> { "zengin" },
                    Type = "jp_bank_transfer",
                },
                Currency = "usd",
                FundingType = "bank_transfer",
            };
            var service = new CustomerFundingInstructionsService(
                this.StripeClient);
            FundingInstructions fundingInstructions = await service.CreateAsync(
                "cus_123",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/customers/cus_123/funding_instructions");
        }

        [Fact]
        public void TestCustomersGet()
        {
            var options = new CustomerListOptions { Limit = 3 };
            var service = new CustomerService(this.StripeClient);
            StripeList<Customer> customers = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/customers", "limit=3");
        }

        [Fact]
        public async Task TestCustomersGetAsync()
        {
            var options = new CustomerListOptions { Limit = 3 };
            var service = new CustomerService(this.StripeClient);
            StripeList<Customer> customers = await service.ListAsync(options);
            this.AssertRequest(HttpMethod.Get, "/v1/customers", "limit=3");
        }

        [Fact]
        public void TestCustomersGetAutoPaging()
        {
            var options = new CustomerListOptions { Limit = 3 };
            var service = new CustomerService(this.StripeClient);
            var customer = service.ListAutoPaging(options).First();
            this.AssertRequest(HttpMethod.Get, "/v1/customers", "limit=3");
        }

        [Fact]
        public async Task TestCustomersGetAutoPagingAsync()
        {
            var options = new CustomerListOptions { Limit = 3 };
            var service = new CustomerService(this.StripeClient);
            var customer = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/customers", "limit=3");
        }

        [Fact]
        public void TestCustomersGet2()
        {
            var options = new CustomerListOptions { Limit = 3 };
            var service = new CustomerService(this.StripeClient);
            StripeList<Customer> customers = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/customers", "limit=3");
        }

        [Fact]
        public async Task TestCustomersGet2Async()
        {
            var options = new CustomerListOptions { Limit = 3 };
            var service = new CustomerService(this.StripeClient);
            StripeList<Customer> customers = await service.ListAsync(options);
            this.AssertRequest(HttpMethod.Get, "/v1/customers", "limit=3");
        }

        [Fact]
        public void TestCustomersGet2AutoPaging()
        {
            var options = new CustomerListOptions { Limit = 3 };
            var service = new CustomerService(this.StripeClient);
            var customer = service.ListAutoPaging(options).First();
            this.AssertRequest(HttpMethod.Get, "/v1/customers", "limit=3");
        }

        [Fact]
        public async Task TestCustomersGet2AutoPagingAsync()
        {
            var options = new CustomerListOptions { Limit = 3 };
            var service = new CustomerService(this.StripeClient);
            var customer = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/customers", "limit=3");
        }

        [Fact]
        public void TestCustomersGet3()
        {
            var service = new CustomerService(this.StripeClient);
            Customer customer = service.Get("cus_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestCustomersGet3Async()
        {
            var service = new CustomerService(this.StripeClient);
            Customer customer = await service.GetAsync("cus_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestCustomersPaymentMethodsGet()
        {
            var options = new CustomerPaymentMethodListOptions
            {
                Type = "card",
            };
            var service = new CustomerPaymentMethodService(this.StripeClient);
            StripeList<PaymentMethod> paymentMethods = service.List(
                "cus_xyz",
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_xyz/payment_methods",
                "type=card");
        }

        [Fact]
        public async Task TestCustomersPaymentMethodsGetAsync()
        {
            var options = new CustomerPaymentMethodListOptions
            {
                Type = "card",
            };
            var service = new CustomerPaymentMethodService(this.StripeClient);
            StripeList<PaymentMethod> paymentMethods = await service.ListAsync(
                "cus_xyz",
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_xyz/payment_methods",
                "type=card");
        }

        [Fact]
        public void TestCustomersPaymentMethodsGetAutoPaging()
        {
            var options = new CustomerPaymentMethodListOptions
            {
                Type = "card",
            };
            var service = new CustomerPaymentMethodService(this.StripeClient);
            var paymentMethod = service.ListAutoPaging("cus_xyz", options)
                .First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_xyz/payment_methods",
                "type=card");
        }

        [Fact]
        public async Task TestCustomersPaymentMethodsGetAutoPagingAsync()
        {
            var options = new CustomerPaymentMethodListOptions
            {
                Type = "card",
            };
            var service = new CustomerPaymentMethodService(this.StripeClient);
            var paymentMethod = await service.ListAutoPagingAsync(
                "cus_xyz",
                options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_xyz/payment_methods",
                "type=card");
        }

        [Fact]
        public void TestCustomersPaymentMethodsGet2()
        {
            var options = new CustomerPaymentMethodListOptions
            {
                Type = "card",
            };
            var service = new CustomerPaymentMethodService(this.StripeClient);
            StripeList<PaymentMethod> paymentMethods = service.List(
                "cus_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_xxxxxxxxxxxxx/payment_methods",
                "type=card");
        }

        [Fact]
        public async Task TestCustomersPaymentMethodsGet2Async()
        {
            var options = new CustomerPaymentMethodListOptions
            {
                Type = "card",
            };
            var service = new CustomerPaymentMethodService(this.StripeClient);
            StripeList<PaymentMethod> paymentMethods = await service.ListAsync(
                "cus_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_xxxxxxxxxxxxx/payment_methods",
                "type=card");
        }

        [Fact]
        public void TestCustomersPaymentMethodsGet2AutoPaging()
        {
            var options = new CustomerPaymentMethodListOptions
            {
                Type = "card",
            };
            var service = new CustomerPaymentMethodService(this.StripeClient);
            var paymentMethod = service.ListAutoPaging(
                "cus_xxxxxxxxxxxxx",
                options)
                .First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_xxxxxxxxxxxxx/payment_methods",
                "type=card");
        }

        [Fact]
        public async Task TestCustomersPaymentMethodsGet2AutoPagingAsync()
        {
            var options = new CustomerPaymentMethodListOptions
            {
                Type = "card",
            };
            var service = new CustomerPaymentMethodService(this.StripeClient);
            var paymentMethod = await service.ListAutoPagingAsync(
                "cus_xxxxxxxxxxxxx",
                options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_xxxxxxxxxxxxx/payment_methods",
                "type=card");
        }

        [Fact]
        public void TestCustomersPost()
        {
            var options = new CustomerCreateOptions
            {
                Description = "My First Test Customer (created for API docs at https://www.stripe.com/docs/api)",
            };
            var service = new CustomerService(this.StripeClient);
            Customer customer = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/customers");
        }

        [Fact]
        public async Task TestCustomersPostAsync()
        {
            var options = new CustomerCreateOptions
            {
                Description = "My First Test Customer (created for API docs at https://www.stripe.com/docs/api)",
            };
            var service = new CustomerService(this.StripeClient);
            Customer customer = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/customers");
        }

        [Fact]
        public void TestCustomersPost2()
        {
            var options = new CustomerUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new CustomerService(this.StripeClient);
            Customer customer = service.Update("cus_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/customers/cus_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestCustomersPost2Async()
        {
            var options = new CustomerUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new CustomerService(this.StripeClient);
            Customer customer = await service.UpdateAsync(
                "cus_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/customers/cus_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestCustomersSearchGet()
        {
            var options = new CustomerSearchOptions
            {
                Query = "name:'fakename' AND metadata['foo']:'bar'",
            };
            var service = new CustomerService(this.StripeClient);
            StripeSearchResult<Customer> customers = service.Search(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/search",
                "query=name%3A%27fakename%27%20AND%20metadata%5B%27foo%27%5D%3A%27bar%27");
        }

        [Fact]
        public async Task TestCustomersSearchGetAsync()
        {
            var options = new CustomerSearchOptions
            {
                Query = "name:'fakename' AND metadata['foo']:'bar'",
            };
            var service = new CustomerService(this.StripeClient);
            StripeSearchResult<Customer> customers = await service.SearchAsync(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/search",
                "query=name%3A%27fakename%27%20AND%20metadata%5B%27foo%27%5D%3A%27bar%27");
        }

        [Fact]
        public void TestCustomersSearchGetAutoPaging()
        {
            var options = new CustomerSearchOptions
            {
                Query = "name:'fakename' AND metadata['foo']:'bar'",
            };
            var service = new CustomerService(this.StripeClient);
            var customer = service.SearchAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/search",
                "query=name%3A%27fakename%27%20AND%20metadata%5B%27foo%27%5D%3A%27bar%27");
        }

        [Fact]
        public async Task TestCustomersSearchGetAutoPagingAsync()
        {
            var options = new CustomerSearchOptions
            {
                Query = "name:'fakename' AND metadata['foo']:'bar'",
            };
            var service = new CustomerService(this.StripeClient);
            var customer = await service.SearchAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/search",
                "query=name%3A%27fakename%27%20AND%20metadata%5B%27foo%27%5D%3A%27bar%27");
        }

        [Fact]
        public void TestCustomersSearchGet2()
        {
            var options = new CustomerSearchOptions
            {
                Query = "name:'fakename' AND metadata['foo']:'bar'",
            };
            var service = new CustomerService(this.StripeClient);
            StripeSearchResult<Customer> customers = service.Search(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/search",
                "query=name%3A%27fakename%27%20AND%20metadata%5B%27foo%27%5D%3A%27bar%27");
        }

        [Fact]
        public async Task TestCustomersSearchGet2Async()
        {
            var options = new CustomerSearchOptions
            {
                Query = "name:'fakename' AND metadata['foo']:'bar'",
            };
            var service = new CustomerService(this.StripeClient);
            StripeSearchResult<Customer> customers = await service.SearchAsync(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/search",
                "query=name%3A%27fakename%27%20AND%20metadata%5B%27foo%27%5D%3A%27bar%27");
        }

        [Fact]
        public void TestCustomersSearchGet2AutoPaging()
        {
            var options = new CustomerSearchOptions
            {
                Query = "name:'fakename' AND metadata['foo']:'bar'",
            };
            var service = new CustomerService(this.StripeClient);
            var customer = service.SearchAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/search",
                "query=name%3A%27fakename%27%20AND%20metadata%5B%27foo%27%5D%3A%27bar%27");
        }

        [Fact]
        public async Task TestCustomersSearchGet2AutoPagingAsync()
        {
            var options = new CustomerSearchOptions
            {
                Query = "name:'fakename' AND metadata['foo']:'bar'",
            };
            var service = new CustomerService(this.StripeClient);
            var customer = await service.SearchAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/search",
                "query=name%3A%27fakename%27%20AND%20metadata%5B%27foo%27%5D%3A%27bar%27");
        }

        [Fact]
        public void TestCustomersTaxIdsDelete()
        {
            var service = new CustomerTaxIdService(this.StripeClient);
            TaxId deleted = service.Delete(
                "cus_xxxxxxxxxxxxx",
                "txi_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/customers/cus_xxxxxxxxxxxxx/tax_ids/txi_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestCustomersTaxIdsDeleteAsync()
        {
            var service = new CustomerTaxIdService(this.StripeClient);
            TaxId deleted = await service.DeleteAsync(
                "cus_xxxxxxxxxxxxx",
                "txi_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/customers/cus_xxxxxxxxxxxxx/tax_ids/txi_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestCustomersTaxIdsGet()
        {
            var options = new CustomerTaxIdListOptions { Limit = 3 };
            var service = new CustomerTaxIdService(this.StripeClient);
            StripeList<TaxId> taxIds = service.List(
                "cus_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_xxxxxxxxxxxxx/tax_ids",
                "limit=3");
        }

        [Fact]
        public async Task TestCustomersTaxIdsGetAsync()
        {
            var options = new CustomerTaxIdListOptions { Limit = 3 };
            var service = new CustomerTaxIdService(this.StripeClient);
            StripeList<TaxId> taxIds = await service.ListAsync(
                "cus_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_xxxxxxxxxxxxx/tax_ids",
                "limit=3");
        }

        [Fact]
        public void TestCustomersTaxIdsGetAutoPaging()
        {
            var options = new CustomerTaxIdListOptions { Limit = 3 };
            var service = new CustomerTaxIdService(this.StripeClient);
            var taxId = service.ListAutoPaging("cus_xxxxxxxxxxxxx", options)
                .First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_xxxxxxxxxxxxx/tax_ids",
                "limit=3");
        }

        [Fact]
        public async Task TestCustomersTaxIdsGetAutoPagingAsync()
        {
            var options = new CustomerTaxIdListOptions { Limit = 3 };
            var service = new CustomerTaxIdService(this.StripeClient);
            var taxId = await service.ListAutoPagingAsync(
                "cus_xxxxxxxxxxxxx",
                options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_xxxxxxxxxxxxx/tax_ids",
                "limit=3");
        }

        [Fact]
        public void TestCustomersTaxIdsGet2()
        {
            var service = new CustomerTaxIdService(this.StripeClient);
            TaxId taxId = service.Get("cus_xxxxxxxxxxxxx", "txi_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_xxxxxxxxxxxxx/tax_ids/txi_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestCustomersTaxIdsGet2Async()
        {
            var service = new CustomerTaxIdService(this.StripeClient);
            TaxId taxId = await service.GetAsync(
                "cus_xxxxxxxxxxxxx",
                "txi_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_xxxxxxxxxxxxx/tax_ids/txi_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestCustomersTaxIdsPost()
        {
            var options = new CustomerTaxIdCreateOptions
            {
                Type = "eu_vat",
                Value = "DE123456789",
            };
            var service = new CustomerTaxIdService(this.StripeClient);
            TaxId taxId = service.Create("cus_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/customers/cus_xxxxxxxxxxxxx/tax_ids");
        }

        [Fact]
        public async Task TestCustomersTaxIdsPostAsync()
        {
            var options = new CustomerTaxIdCreateOptions
            {
                Type = "eu_vat",
                Value = "DE123456789",
            };
            var service = new CustomerTaxIdService(this.StripeClient);
            TaxId taxId = await service.CreateAsync(
                "cus_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/customers/cus_xxxxxxxxxxxxx/tax_ids");
        }

        [Fact]
        public void TestDisputesClosePost()
        {
            var service = new DisputeService(this.StripeClient);
            Dispute dispute = service.Close("dp_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/disputes/dp_xxxxxxxxxxxxx/close");
        }

        [Fact]
        public async Task TestDisputesClosePostAsync()
        {
            var service = new DisputeService(this.StripeClient);
            Dispute dispute = await service.CloseAsync("dp_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/disputes/dp_xxxxxxxxxxxxx/close");
        }

        [Fact]
        public void TestDisputesGet()
        {
            var options = new DisputeListOptions { Limit = 3 };
            var service = new DisputeService(this.StripeClient);
            StripeList<Dispute> disputes = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/disputes", "limit=3");
        }

        [Fact]
        public async Task TestDisputesGetAsync()
        {
            var options = new DisputeListOptions { Limit = 3 };
            var service = new DisputeService(this.StripeClient);
            StripeList<Dispute> disputes = await service.ListAsync(options);
            this.AssertRequest(HttpMethod.Get, "/v1/disputes", "limit=3");
        }

        [Fact]
        public void TestDisputesGetAutoPaging()
        {
            var options = new DisputeListOptions { Limit = 3 };
            var service = new DisputeService(this.StripeClient);
            var dispute = service.ListAutoPaging(options).First();
            this.AssertRequest(HttpMethod.Get, "/v1/disputes", "limit=3");
        }

        [Fact]
        public async Task TestDisputesGetAutoPagingAsync()
        {
            var options = new DisputeListOptions { Limit = 3 };
            var service = new DisputeService(this.StripeClient);
            var dispute = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/disputes", "limit=3");
        }

        [Fact]
        public void TestDisputesGet2()
        {
            var service = new DisputeService(this.StripeClient);
            Dispute dispute = service.Get("dp_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/disputes/dp_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestDisputesGet2Async()
        {
            var service = new DisputeService(this.StripeClient);
            Dispute dispute = await service.GetAsync("dp_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/disputes/dp_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestDisputesPost()
        {
            var options = new DisputeUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new DisputeService(this.StripeClient);
            Dispute dispute = service.Update("dp_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/disputes/dp_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestDisputesPostAsync()
        {
            var options = new DisputeUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new DisputeService(this.StripeClient);
            Dispute dispute = await service.UpdateAsync(
                "dp_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/disputes/dp_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestEventsGet()
        {
            var options = new EventListOptions { Limit = 3 };
            var service = new EventService(this.StripeClient);
            StripeList<Event> events = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/events", "limit=3");
        }

        [Fact]
        public async Task TestEventsGetAsync()
        {
            var options = new EventListOptions { Limit = 3 };
            var service = new EventService(this.StripeClient);
            StripeList<Event> events = await service.ListAsync(options);
            this.AssertRequest(HttpMethod.Get, "/v1/events", "limit=3");
        }

        [Fact]
        public void TestEventsGetAutoPaging()
        {
            var options = new EventListOptions { Limit = 3 };
            var service = new EventService(this.StripeClient);
            var result = service.ListAutoPaging(options).First();
            this.AssertRequest(HttpMethod.Get, "/v1/events", "limit=3");
        }

        [Fact]
        public async Task TestEventsGetAutoPagingAsync()
        {
            var options = new EventListOptions { Limit = 3 };
            var service = new EventService(this.StripeClient);
            var result = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/events", "limit=3");
        }

        [Fact]
        public void TestEventsGet2()
        {
            var service = new EventService(this.StripeClient);
            Event result = service.Get("evt_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/events/evt_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestEventsGet2Async()
        {
            var service = new EventService(this.StripeClient);
            Event result = await service.GetAsync("evt_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/events/evt_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestFileLinksGet()
        {
            var options = new FileLinkListOptions { Limit = 3 };
            var service = new FileLinkService(this.StripeClient);
            StripeList<FileLink> fileLinks = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/file_links", "limit=3");
        }

        [Fact]
        public async Task TestFileLinksGetAsync()
        {
            var options = new FileLinkListOptions { Limit = 3 };
            var service = new FileLinkService(this.StripeClient);
            StripeList<FileLink> fileLinks = await service.ListAsync(options);
            this.AssertRequest(HttpMethod.Get, "/v1/file_links", "limit=3");
        }

        [Fact]
        public void TestFileLinksGetAutoPaging()
        {
            var options = new FileLinkListOptions { Limit = 3 };
            var service = new FileLinkService(this.StripeClient);
            var fileLink = service.ListAutoPaging(options).First();
            this.AssertRequest(HttpMethod.Get, "/v1/file_links", "limit=3");
        }

        [Fact]
        public async Task TestFileLinksGetAutoPagingAsync()
        {
            var options = new FileLinkListOptions { Limit = 3 };
            var service = new FileLinkService(this.StripeClient);
            var fileLink = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/file_links", "limit=3");
        }

        [Fact]
        public void TestFileLinksGet2()
        {
            var service = new FileLinkService(this.StripeClient);
            FileLink fileLink = service.Get("link_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/file_links/link_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestFileLinksGet2Async()
        {
            var service = new FileLinkService(this.StripeClient);
            FileLink fileLink = await service.GetAsync("link_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/file_links/link_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestFileLinksPost()
        {
            var options = new FileLinkCreateOptions
            {
                File = "file_xxxxxxxxxxxxx",
            };
            var service = new FileLinkService(this.StripeClient);
            FileLink fileLink = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/file_links");
        }

        [Fact]
        public async Task TestFileLinksPostAsync()
        {
            var options = new FileLinkCreateOptions
            {
                File = "file_xxxxxxxxxxxxx",
            };
            var service = new FileLinkService(this.StripeClient);
            FileLink fileLink = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/file_links");
        }

        [Fact]
        public void TestFileLinksPost2()
        {
            var options = new FileLinkUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new FileLinkService(this.StripeClient);
            FileLink fileLink = service.Update("link_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/file_links/link_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestFileLinksPost2Async()
        {
            var options = new FileLinkUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new FileLinkService(this.StripeClient);
            FileLink fileLink = await service.UpdateAsync(
                "link_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/file_links/link_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestFilesGet()
        {
            var options = new FileListOptions { Limit = 3 };
            var service = new FileService(this.StripeClient);
            StripeList<File> files = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/files", "limit=3");
        }

        [Fact]
        public async Task TestFilesGetAsync()
        {
            var options = new FileListOptions { Limit = 3 };
            var service = new FileService(this.StripeClient);
            StripeList<File> files = await service.ListAsync(options);
            this.AssertRequest(HttpMethod.Get, "/v1/files", "limit=3");
        }

        [Fact]
        public void TestFilesGetAutoPaging()
        {
            var options = new FileListOptions { Limit = 3 };
            var service = new FileService(this.StripeClient);
            var file = service.ListAutoPaging(options).First();
            this.AssertRequest(HttpMethod.Get, "/v1/files", "limit=3");
        }

        [Fact]
        public async Task TestFilesGetAutoPagingAsync()
        {
            var options = new FileListOptions { Limit = 3 };
            var service = new FileService(this.StripeClient);
            var file = await service.ListAutoPagingAsync(options).FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/files", "limit=3");
        }

        [Fact]
        public void TestFilesGet2()
        {
            var service = new FileService(this.StripeClient);
            File file = service.Get("file_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/files/file_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestFilesGet2Async()
        {
            var service = new FileService(this.StripeClient);
            File file = await service.GetAsync("file_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/files/file_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestFilesPost()
        {
            var options = new FileCreateOptions
            {
                Purpose = "account_requirement",
                File = new Stripe.MultipartFileContent
                {
                    Data = new System.IO.MemoryStream(
                        System.Text.Encoding.UTF8.GetBytes("File contents")),
                },
            };
            var service = new FileService(this.StripeClient);
            File file = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/files");
        }

        [Fact]
        public async Task TestFilesPostAsync()
        {
            var options = new FileCreateOptions
            {
                Purpose = "account_requirement",
                File = new Stripe.MultipartFileContent
                {
                    Data = new System.IO.MemoryStream(
                        System.Text.Encoding.UTF8.GetBytes("File contents")),
                },
            };
            var service = new FileService(this.StripeClient);
            File file = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/files");
        }

        [Fact]
        public void TestFinancialConnectionsAccountsDisconnectPost()
        {
            var service = new Stripe.FinancialConnections.AccountService(
                this.StripeClient);
            Stripe.FinancialConnections.Account account = service.Disconnect(
                "fca_xyz");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/financial_connections/accounts/fca_xyz/disconnect");
        }

        [Fact]
        public async Task TestFinancialConnectionsAccountsDisconnectPostAsync()
        {
            var service = new Stripe.FinancialConnections.AccountService(
                this.StripeClient);
            Stripe.FinancialConnections.Account account = await service
                .DisconnectAsync("fca_xyz");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/financial_connections/accounts/fca_xyz/disconnect");
        }

        [Fact]
        public void TestFinancialConnectionsAccountsDisconnectPost2()
        {
            var service = new Stripe.FinancialConnections.AccountService(
                this.StripeClient);
            Stripe.FinancialConnections.Account account = service.Disconnect(
                "fca_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/financial_connections/accounts/fca_xxxxxxxxxxxxx/disconnect");
        }

        [Fact]
        public async Task TestFinancialConnectionsAccountsDisconnectPost2Async()
        {
            var service = new Stripe.FinancialConnections.AccountService(
                this.StripeClient);
            Stripe.FinancialConnections.Account account = await service
                .DisconnectAsync("fca_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/financial_connections/accounts/fca_xxxxxxxxxxxxx/disconnect");
        }

        [Fact]
        public void TestFinancialConnectionsAccountsGet()
        {
            var service = new Stripe.FinancialConnections.AccountService(
                this.StripeClient);
            StripeList<Stripe.FinancialConnections.Account> accounts = service
                .List();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/accounts");
        }

        [Fact]
        public async Task TestFinancialConnectionsAccountsGetAsync()
        {
            var service = new Stripe.FinancialConnections.AccountService(
                this.StripeClient);
            StripeList<Stripe.FinancialConnections.Account> accounts = await service
                .ListAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/accounts");
        }

        [Fact]
        public void TestFinancialConnectionsAccountsGetAutoPaging()
        {
            var service = new Stripe.FinancialConnections.AccountService(
                this.StripeClient);
            var account = service.ListAutoPaging().First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/accounts");
        }

        [Fact]
        public async Task TestFinancialConnectionsAccountsGetAutoPagingAsync()
        {
            var service = new Stripe.FinancialConnections.AccountService(
                this.StripeClient);
            var account = await service.ListAutoPagingAsync().FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/accounts");
        }

        [Fact]
        public void TestFinancialConnectionsAccountsGet2()
        {
            var service = new Stripe.FinancialConnections.AccountService(
                this.StripeClient);
            Stripe.FinancialConnections.Account account = service.Get(
                "fca_xyz");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/accounts/fca_xyz");
        }

        [Fact]
        public async Task TestFinancialConnectionsAccountsGet2Async()
        {
            var service = new Stripe.FinancialConnections.AccountService(
                this.StripeClient);
            Stripe.FinancialConnections.Account account = await service
                .GetAsync("fca_xyz");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/accounts/fca_xyz");
        }

        [Fact]
        public void TestFinancialConnectionsAccountsGet3()
        {
            var options = new Stripe.FinancialConnections.AccountListOptions
            {
                AccountHolder = new Stripe.FinancialConnections.AccountAccountHolderOptions
                {
                    Customer = "cus_xxxxxxxxxxxxx",
                },
            };
            var service = new Stripe.FinancialConnections.AccountService(
                this.StripeClient);
            StripeList<Stripe.FinancialConnections.Account> accounts = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/accounts",
                "account_holder[customer]=cus_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestFinancialConnectionsAccountsGet3Async()
        {
            var options = new Stripe.FinancialConnections.AccountListOptions
            {
                AccountHolder = new Stripe.FinancialConnections.AccountAccountHolderOptions
                {
                    Customer = "cus_xxxxxxxxxxxxx",
                },
            };
            var service = new Stripe.FinancialConnections.AccountService(
                this.StripeClient);
            StripeList<Stripe.FinancialConnections.Account> accounts = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/accounts",
                "account_holder[customer]=cus_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestFinancialConnectionsAccountsGet3AutoPaging()
        {
            var options = new Stripe.FinancialConnections.AccountListOptions
            {
                AccountHolder = new Stripe.FinancialConnections.AccountAccountHolderOptions
                {
                    Customer = "cus_xxxxxxxxxxxxx",
                },
            };
            var service = new Stripe.FinancialConnections.AccountService(
                this.StripeClient);
            var account = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/accounts",
                "account_holder[customer]=cus_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestFinancialConnectionsAccountsGet3AutoPagingAsync()
        {
            var options = new Stripe.FinancialConnections.AccountListOptions
            {
                AccountHolder = new Stripe.FinancialConnections.AccountAccountHolderOptions
                {
                    Customer = "cus_xxxxxxxxxxxxx",
                },
            };
            var service = new Stripe.FinancialConnections.AccountService(
                this.StripeClient);
            var account = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/accounts",
                "account_holder[customer]=cus_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestFinancialConnectionsAccountsGet4()
        {
            var service = new Stripe.FinancialConnections.AccountService(
                this.StripeClient);
            Stripe.FinancialConnections.Account account = service.Get(
                "fca_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/accounts/fca_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestFinancialConnectionsAccountsGet4Async()
        {
            var service = new Stripe.FinancialConnections.AccountService(
                this.StripeClient);
            Stripe.FinancialConnections.Account account = await service
                .GetAsync("fca_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/accounts/fca_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestFinancialConnectionsAccountsOwnersGet()
        {
            var options = new Stripe.FinancialConnections.AccountOwnerListOptions
            {
                Ownership = "fcaowns_xyz",
            };
            var service = new Stripe.FinancialConnections.AccountOwnerService(
                this.StripeClient);
            StripeList<Stripe.FinancialConnections.AccountOwner> accountOwners = service
                .List("fca_xyz", options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/accounts/fca_xyz/owners",
                "ownership=fcaowns_xyz");
        }

        [Fact]
        public async Task TestFinancialConnectionsAccountsOwnersGetAsync()
        {
            var options = new Stripe.FinancialConnections.AccountOwnerListOptions
            {
                Ownership = "fcaowns_xyz",
            };
            var service = new Stripe.FinancialConnections.AccountOwnerService(
                this.StripeClient);
            StripeList<Stripe.FinancialConnections.AccountOwner> accountOwners = await service
                .ListAsync("fca_xyz", options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/accounts/fca_xyz/owners",
                "ownership=fcaowns_xyz");
        }

        [Fact]
        public void TestFinancialConnectionsAccountsOwnersGetAutoPaging()
        {
            var options = new Stripe.FinancialConnections.AccountOwnerListOptions
            {
                Ownership = "fcaowns_xyz",
            };
            var service = new Stripe.FinancialConnections.AccountOwnerService(
                this.StripeClient);
            var accountOwner = service.ListAutoPaging("fca_xyz", options)
                .First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/accounts/fca_xyz/owners",
                "ownership=fcaowns_xyz");
        }

        [Fact]
        public async Task TestFinancialConnectionsAccountsOwnersGetAutoPagingAsync()
        {
            var options = new Stripe.FinancialConnections.AccountOwnerListOptions
            {
                Ownership = "fcaowns_xyz",
            };
            var service = new Stripe.FinancialConnections.AccountOwnerService(
                this.StripeClient);
            var accountOwner = await service.ListAutoPagingAsync(
                "fca_xyz",
                options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/accounts/fca_xyz/owners",
                "ownership=fcaowns_xyz");
        }

        [Fact]
        public void TestFinancialConnectionsAccountsOwnersGet2()
        {
            var options = new Stripe.FinancialConnections.AccountOwnerListOptions
            {
                Limit = 3,
                Ownership = "fcaowns_xxxxxxxxxxxxx",
            };
            var service = new Stripe.FinancialConnections.AccountOwnerService(
                this.StripeClient);
            StripeList<Stripe.FinancialConnections.AccountOwner> accountOwners = service
                .List("fca_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/accounts/fca_xxxxxxxxxxxxx/owners",
                "limit=3&ownership=fcaowns_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestFinancialConnectionsAccountsOwnersGet2Async()
        {
            var options = new Stripe.FinancialConnections.AccountOwnerListOptions
            {
                Limit = 3,
                Ownership = "fcaowns_xxxxxxxxxxxxx",
            };
            var service = new Stripe.FinancialConnections.AccountOwnerService(
                this.StripeClient);
            StripeList<Stripe.FinancialConnections.AccountOwner> accountOwners = await service
                .ListAsync("fca_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/accounts/fca_xxxxxxxxxxxxx/owners",
                "limit=3&ownership=fcaowns_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestFinancialConnectionsAccountsOwnersGet2AutoPaging()
        {
            var options = new Stripe.FinancialConnections.AccountOwnerListOptions
            {
                Limit = 3,
                Ownership = "fcaowns_xxxxxxxxxxxxx",
            };
            var service = new Stripe.FinancialConnections.AccountOwnerService(
                this.StripeClient);
            var accountOwner = service.ListAutoPaging(
                "fca_xxxxxxxxxxxxx",
                options)
                .First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/accounts/fca_xxxxxxxxxxxxx/owners",
                "limit=3&ownership=fcaowns_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestFinancialConnectionsAccountsOwnersGet2AutoPagingAsync()
        {
            var options = new Stripe.FinancialConnections.AccountOwnerListOptions
            {
                Limit = 3,
                Ownership = "fcaowns_xxxxxxxxxxxxx",
            };
            var service = new Stripe.FinancialConnections.AccountOwnerService(
                this.StripeClient);
            var accountOwner = await service.ListAutoPagingAsync(
                "fca_xxxxxxxxxxxxx",
                options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/accounts/fca_xxxxxxxxxxxxx/owners",
                "limit=3&ownership=fcaowns_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestFinancialConnectionsAccountsRefreshPost()
        {
            var options = new Stripe.FinancialConnections.AccountRefreshOptions
            {
                Features = new List<string> { "balance" },
            };
            var service = new Stripe.FinancialConnections.AccountService(
                this.StripeClient);
            Stripe.FinancialConnections.Account account = service.Refresh(
                "fca_xyz",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/financial_connections/accounts/fca_xyz/refresh");
        }

        [Fact]
        public async Task TestFinancialConnectionsAccountsRefreshPostAsync()
        {
            var options = new Stripe.FinancialConnections.AccountRefreshOptions
            {
                Features = new List<string> { "balance" },
            };
            var service = new Stripe.FinancialConnections.AccountService(
                this.StripeClient);
            Stripe.FinancialConnections.Account account = await service
                .RefreshAsync("fca_xyz", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/financial_connections/accounts/fca_xyz/refresh");
        }

        [Fact]
        public void TestFinancialConnectionsAccountsSubscribePost()
        {
            var options = new Stripe.FinancialConnections.AccountSubscribeOptions
            {
                Features = new List<string> { "transactions" },
            };
            var service = new Stripe.FinancialConnections.AccountService(
                this.StripeClient);
            Stripe.FinancialConnections.Account account = service.Subscribe(
                "fa_123",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/financial_connections/accounts/fa_123/subscribe");
        }

        [Fact]
        public async Task TestFinancialConnectionsAccountsSubscribePostAsync()
        {
            var options = new Stripe.FinancialConnections.AccountSubscribeOptions
            {
                Features = new List<string> { "transactions" },
            };
            var service = new Stripe.FinancialConnections.AccountService(
                this.StripeClient);
            Stripe.FinancialConnections.Account account = await service
                .SubscribeAsync("fa_123", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/financial_connections/accounts/fa_123/subscribe");
        }

        [Fact]
        public void TestFinancialConnectionsAccountsUnsubscribePost()
        {
            var options = new Stripe.FinancialConnections.AccountUnsubscribeOptions
            {
                Features = new List<string> { "transactions" },
            };
            var service = new Stripe.FinancialConnections.AccountService(
                this.StripeClient);
            Stripe.FinancialConnections.Account account = service.Unsubscribe(
                "fa_123",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/financial_connections/accounts/fa_123/unsubscribe");
        }

        [Fact]
        public async Task TestFinancialConnectionsAccountsUnsubscribePostAsync()
        {
            var options = new Stripe.FinancialConnections.AccountUnsubscribeOptions
            {
                Features = new List<string> { "transactions" },
            };
            var service = new Stripe.FinancialConnections.AccountService(
                this.StripeClient);
            Stripe.FinancialConnections.Account account = await service
                .UnsubscribeAsync("fa_123", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/financial_connections/accounts/fa_123/unsubscribe");
        }

        [Fact]
        public void TestFinancialConnectionsSessionsGet()
        {
            var service = new Stripe.FinancialConnections.SessionService(
                this.StripeClient);
            Stripe.FinancialConnections.Session session = service.Get(
                "fcsess_xyz");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/sessions/fcsess_xyz");
        }

        [Fact]
        public async Task TestFinancialConnectionsSessionsGetAsync()
        {
            var service = new Stripe.FinancialConnections.SessionService(
                this.StripeClient);
            Stripe.FinancialConnections.Session session = await service
                .GetAsync("fcsess_xyz");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/sessions/fcsess_xyz");
        }

        [Fact]
        public void TestFinancialConnectionsSessionsGet2()
        {
            var service = new Stripe.FinancialConnections.SessionService(
                this.StripeClient);
            Stripe.FinancialConnections.Session session = service.Get(
                "fcsess_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/sessions/fcsess_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestFinancialConnectionsSessionsGet2Async()
        {
            var service = new Stripe.FinancialConnections.SessionService(
                this.StripeClient);
            Stripe.FinancialConnections.Session session = await service
                .GetAsync("fcsess_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/sessions/fcsess_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestFinancialConnectionsSessionsPost()
        {
            var options = new Stripe.FinancialConnections.SessionCreateOptions
            {
                AccountHolder = new Stripe.FinancialConnections.SessionAccountHolderOptions
                {
                    Type = "customer",
                    Customer = "cus_123",
                },
                Permissions = new List<string> { "balances" },
            };
            var service = new Stripe.FinancialConnections.SessionService(
                this.StripeClient);
            Stripe.FinancialConnections.Session session = service.Create(
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/financial_connections/sessions");
        }

        [Fact]
        public async Task TestFinancialConnectionsSessionsPostAsync()
        {
            var options = new Stripe.FinancialConnections.SessionCreateOptions
            {
                AccountHolder = new Stripe.FinancialConnections.SessionAccountHolderOptions
                {
                    Type = "customer",
                    Customer = "cus_123",
                },
                Permissions = new List<string> { "balances" },
            };
            var service = new Stripe.FinancialConnections.SessionService(
                this.StripeClient);
            Stripe.FinancialConnections.Session session = await service
                .CreateAsync(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/financial_connections/sessions");
        }

        [Fact]
        public void TestFinancialConnectionsSessionsPost2()
        {
            var options = new Stripe.FinancialConnections.SessionCreateOptions
            {
                AccountHolder = new Stripe.FinancialConnections.SessionAccountHolderOptions
                {
                    Type = "customer",
                    Customer = "cus_xxxxxxxxxxxxx",
                },
                Permissions = new List<string> { "payment_method", "balances" },
                Filters = new Stripe.FinancialConnections.SessionFiltersOptions
                {
                    Countries = new List<string> { "US" },
                },
            };
            var service = new Stripe.FinancialConnections.SessionService(
                this.StripeClient);
            Stripe.FinancialConnections.Session session = service.Create(
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/financial_connections/sessions");
        }

        [Fact]
        public async Task TestFinancialConnectionsSessionsPost2Async()
        {
            var options = new Stripe.FinancialConnections.SessionCreateOptions
            {
                AccountHolder = new Stripe.FinancialConnections.SessionAccountHolderOptions
                {
                    Type = "customer",
                    Customer = "cus_xxxxxxxxxxxxx",
                },
                Permissions = new List<string> { "payment_method", "balances" },
                Filters = new Stripe.FinancialConnections.SessionFiltersOptions
                {
                    Countries = new List<string> { "US" },
                },
            };
            var service = new Stripe.FinancialConnections.SessionService(
                this.StripeClient);
            Stripe.FinancialConnections.Session session = await service
                .CreateAsync(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/financial_connections/sessions");
        }

        [Fact]
        public void TestFinancialConnectionsTransactionsGet()
        {
            var service = new Stripe.FinancialConnections.TransactionService(
                this.StripeClient);
            Stripe.FinancialConnections.Transaction transaction = service.Get(
                "tr_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/transactions/tr_123");
        }

        [Fact]
        public async Task TestFinancialConnectionsTransactionsGetAsync()
        {
            var service = new Stripe.FinancialConnections.TransactionService(
                this.StripeClient);
            Stripe.FinancialConnections.Transaction transaction = await service
                .GetAsync("tr_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/transactions/tr_123");
        }

        [Fact]
        public void TestFinancialConnectionsTransactionsGet2()
        {
            var options = new Stripe.FinancialConnections.TransactionListOptions
            {
                Account = "fca_xyz",
            };
            var service = new Stripe.FinancialConnections.TransactionService(
                this.StripeClient);
            StripeList<Stripe.FinancialConnections.Transaction> transactions = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/transactions",
                "account=fca_xyz");
        }

        [Fact]
        public async Task TestFinancialConnectionsTransactionsGet2Async()
        {
            var options = new Stripe.FinancialConnections.TransactionListOptions
            {
                Account = "fca_xyz",
            };
            var service = new Stripe.FinancialConnections.TransactionService(
                this.StripeClient);
            StripeList<Stripe.FinancialConnections.Transaction> transactions = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/transactions",
                "account=fca_xyz");
        }

        [Fact]
        public void TestFinancialConnectionsTransactionsGet2AutoPaging()
        {
            var options = new Stripe.FinancialConnections.TransactionListOptions
            {
                Account = "fca_xyz",
            };
            var service = new Stripe.FinancialConnections.TransactionService(
                this.StripeClient);
            var transaction = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/transactions",
                "account=fca_xyz");
        }

        [Fact]
        public async Task TestFinancialConnectionsTransactionsGet2AutoPagingAsync()
        {
            var options = new Stripe.FinancialConnections.TransactionListOptions
            {
                Account = "fca_xyz",
            };
            var service = new Stripe.FinancialConnections.TransactionService(
                this.StripeClient);
            var transaction = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/transactions",
                "account=fca_xyz");
        }

        [Fact]
        public void TestIdentityVerificationReportsGet()
        {
            var options = new Stripe.Identity.VerificationReportListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Identity.VerificationReportService(
                this.StripeClient);
            StripeList<Stripe.Identity.VerificationReport> verificationReports = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/identity/verification_reports",
                "limit=3");
        }

        [Fact]
        public async Task TestIdentityVerificationReportsGetAsync()
        {
            var options = new Stripe.Identity.VerificationReportListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Identity.VerificationReportService(
                this.StripeClient);
            StripeList<Stripe.Identity.VerificationReport> verificationReports = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/identity/verification_reports",
                "limit=3");
        }

        [Fact]
        public void TestIdentityVerificationReportsGetAutoPaging()
        {
            var options = new Stripe.Identity.VerificationReportListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Identity.VerificationReportService(
                this.StripeClient);
            var verificationReport = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/identity/verification_reports",
                "limit=3");
        }

        [Fact]
        public async Task TestIdentityVerificationReportsGetAutoPagingAsync()
        {
            var options = new Stripe.Identity.VerificationReportListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Identity.VerificationReportService(
                this.StripeClient);
            var verificationReport = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/identity/verification_reports",
                "limit=3");
        }

        [Fact]
        public void TestIdentityVerificationReportsGet2()
        {
            var service = new Stripe.Identity.VerificationReportService(
                this.StripeClient);
            Stripe.Identity.VerificationReport verificationReport = service.Get(
                "vr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/identity/verification_reports/vr_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestIdentityVerificationReportsGet2Async()
        {
            var service = new Stripe.Identity.VerificationReportService(
                this.StripeClient);
            Stripe.Identity.VerificationReport verificationReport = await service
                .GetAsync("vr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/identity/verification_reports/vr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIdentityVerificationSessionsCancelPost()
        {
            var service = new Stripe.Identity.VerificationSessionService(
                this.StripeClient);
            Stripe.Identity.VerificationSession verificationSession = service
                .Cancel("vs_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/identity/verification_sessions/vs_xxxxxxxxxxxxx/cancel");
        }

        [Fact]
        public async Task TestIdentityVerificationSessionsCancelPostAsync()
        {
            var service = new Stripe.Identity.VerificationSessionService(
                this.StripeClient);
            Stripe.Identity.VerificationSession verificationSession = await service
                .CancelAsync("vs_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/identity/verification_sessions/vs_xxxxxxxxxxxxx/cancel");
        }

        [Fact]
        public void TestIdentityVerificationSessionsGet()
        {
            var options = new Stripe.Identity.VerificationSessionListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Identity.VerificationSessionService(
                this.StripeClient);
            StripeList<Stripe.Identity.VerificationSession> verificationSessions = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/identity/verification_sessions",
                "limit=3");
        }

        [Fact]
        public async Task TestIdentityVerificationSessionsGetAsync()
        {
            var options = new Stripe.Identity.VerificationSessionListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Identity.VerificationSessionService(
                this.StripeClient);
            StripeList<Stripe.Identity.VerificationSession> verificationSessions = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/identity/verification_sessions",
                "limit=3");
        }

        [Fact]
        public void TestIdentityVerificationSessionsGetAutoPaging()
        {
            var options = new Stripe.Identity.VerificationSessionListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Identity.VerificationSessionService(
                this.StripeClient);
            var verificationSession = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/identity/verification_sessions",
                "limit=3");
        }

        [Fact]
        public async Task TestIdentityVerificationSessionsGetAutoPagingAsync()
        {
            var options = new Stripe.Identity.VerificationSessionListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Identity.VerificationSessionService(
                this.StripeClient);
            var verificationSession = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/identity/verification_sessions",
                "limit=3");
        }

        [Fact]
        public void TestIdentityVerificationSessionsGet2()
        {
            var service = new Stripe.Identity.VerificationSessionService(
                this.StripeClient);
            Stripe.Identity.VerificationSession verificationSession = service
                .Get("vs_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/identity/verification_sessions/vs_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestIdentityVerificationSessionsGet2Async()
        {
            var service = new Stripe.Identity.VerificationSessionService(
                this.StripeClient);
            Stripe.Identity.VerificationSession verificationSession = await service
                .GetAsync("vs_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/identity/verification_sessions/vs_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIdentityVerificationSessionsPost()
        {
            var options = new Stripe.Identity.VerificationSessionCreateOptions
            {
                Type = "document",
            };
            var service = new Stripe.Identity.VerificationSessionService(
                this.StripeClient);
            Stripe.Identity.VerificationSession verificationSession = service
                .Create(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/identity/verification_sessions");
        }

        [Fact]
        public async Task TestIdentityVerificationSessionsPostAsync()
        {
            var options = new Stripe.Identity.VerificationSessionCreateOptions
            {
                Type = "document",
            };
            var service = new Stripe.Identity.VerificationSessionService(
                this.StripeClient);
            Stripe.Identity.VerificationSession verificationSession = await service
                .CreateAsync(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/identity/verification_sessions");
        }

        [Fact]
        public void TestIdentityVerificationSessionsPost2()
        {
            var options = new Stripe.Identity.VerificationSessionUpdateOptions
            {
                Type = "id_number",
            };
            var service = new Stripe.Identity.VerificationSessionService(
                this.StripeClient);
            Stripe.Identity.VerificationSession verificationSession = service
                .Update("vs_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/identity/verification_sessions/vs_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestIdentityVerificationSessionsPost2Async()
        {
            var options = new Stripe.Identity.VerificationSessionUpdateOptions
            {
                Type = "id_number",
            };
            var service = new Stripe.Identity.VerificationSessionService(
                this.StripeClient);
            Stripe.Identity.VerificationSession verificationSession = await service
                .UpdateAsync("vs_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/identity/verification_sessions/vs_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIdentityVerificationSessionsRedactPost()
        {
            var service = new Stripe.Identity.VerificationSessionService(
                this.StripeClient);
            Stripe.Identity.VerificationSession verificationSession = service
                .Redact("vs_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/identity/verification_sessions/vs_xxxxxxxxxxxxx/redact");
        }

        [Fact]
        public async Task TestIdentityVerificationSessionsRedactPostAsync()
        {
            var service = new Stripe.Identity.VerificationSessionService(
                this.StripeClient);
            Stripe.Identity.VerificationSession verificationSession = await service
                .RedactAsync("vs_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/identity/verification_sessions/vs_xxxxxxxxxxxxx/redact");
        }

        [Fact]
        public void TestInvoiceitemsDelete()
        {
            var service = new InvoiceItemService(this.StripeClient);
            InvoiceItem deleted = service.Delete("ii_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/invoiceitems/ii_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestInvoiceitemsDeleteAsync()
        {
            var service = new InvoiceItemService(this.StripeClient);
            InvoiceItem deleted = await service.DeleteAsync("ii_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/invoiceitems/ii_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestInvoiceitemsGet()
        {
            var options = new InvoiceItemListOptions { Limit = 3 };
            var service = new InvoiceItemService(this.StripeClient);
            StripeList<InvoiceItem> invoiceItems = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/invoiceitems", "limit=3");
        }

        [Fact]
        public async Task TestInvoiceitemsGetAsync()
        {
            var options = new InvoiceItemListOptions { Limit = 3 };
            var service = new InvoiceItemService(this.StripeClient);
            StripeList<InvoiceItem> invoiceItems = await service.ListAsync(
                options);
            this.AssertRequest(HttpMethod.Get, "/v1/invoiceitems", "limit=3");
        }

        [Fact]
        public void TestInvoiceitemsGetAutoPaging()
        {
            var options = new InvoiceItemListOptions { Limit = 3 };
            var service = new InvoiceItemService(this.StripeClient);
            var invoiceItem = service.ListAutoPaging(options).First();
            this.AssertRequest(HttpMethod.Get, "/v1/invoiceitems", "limit=3");
        }

        [Fact]
        public async Task TestInvoiceitemsGetAutoPagingAsync()
        {
            var options = new InvoiceItemListOptions { Limit = 3 };
            var service = new InvoiceItemService(this.StripeClient);
            var invoiceItem = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/invoiceitems", "limit=3");
        }

        [Fact]
        public void TestInvoiceitemsGet2()
        {
            var service = new InvoiceItemService(this.StripeClient);
            InvoiceItem invoiceItem = service.Get("ii_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/invoiceitems/ii_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestInvoiceitemsGet2Async()
        {
            var service = new InvoiceItemService(this.StripeClient);
            InvoiceItem invoiceItem = await service.GetAsync(
                "ii_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/invoiceitems/ii_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestInvoiceitemsPost()
        {
            var options = new InvoiceItemCreateOptions
            {
                Customer = "cus_xxxxxxxxxxxxx",
            };
            var service = new InvoiceItemService(this.StripeClient);
            InvoiceItem invoiceItem = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/invoiceitems");
        }

        [Fact]
        public async Task TestInvoiceitemsPostAsync()
        {
            var options = new InvoiceItemCreateOptions
            {
                Customer = "cus_xxxxxxxxxxxxx",
            };
            var service = new InvoiceItemService(this.StripeClient);
            InvoiceItem invoiceItem = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/invoiceitems");
        }

        [Fact]
        public void TestInvoiceitemsPost2()
        {
            var options = new InvoiceItemUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new InvoiceItemService(this.StripeClient);
            InvoiceItem invoiceItem = service.Update(
                "ii_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/invoiceitems/ii_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestInvoiceitemsPost2Async()
        {
            var options = new InvoiceItemUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new InvoiceItemService(this.StripeClient);
            InvoiceItem invoiceItem = await service.UpdateAsync(
                "ii_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/invoiceitems/ii_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestInvoicesDelete()
        {
            var service = new InvoiceService(this.StripeClient);
            Invoice deleted = service.Delete("in_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/invoices/in_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestInvoicesDeleteAsync()
        {
            var service = new InvoiceService(this.StripeClient);
            Invoice deleted = await service.DeleteAsync("in_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/invoices/in_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestInvoicesFinalizePost()
        {
            var service = new InvoiceService(this.StripeClient);
            Invoice invoice = service.FinalizeInvoice("in_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/invoices/in_xxxxxxxxxxxxx/finalize");
        }

        [Fact]
        public async Task TestInvoicesFinalizePostAsync()
        {
            var service = new InvoiceService(this.StripeClient);
            Invoice invoice = await service.FinalizeInvoiceAsync(
                "in_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/invoices/in_xxxxxxxxxxxxx/finalize");
        }

        [Fact]
        public void TestInvoicesGet()
        {
            var options = new InvoiceListOptions { Limit = 3 };
            var service = new InvoiceService(this.StripeClient);
            StripeList<Invoice> invoices = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/invoices", "limit=3");
        }

        [Fact]
        public async Task TestInvoicesGetAsync()
        {
            var options = new InvoiceListOptions { Limit = 3 };
            var service = new InvoiceService(this.StripeClient);
            StripeList<Invoice> invoices = await service.ListAsync(options);
            this.AssertRequest(HttpMethod.Get, "/v1/invoices", "limit=3");
        }

        [Fact]
        public void TestInvoicesGetAutoPaging()
        {
            var options = new InvoiceListOptions { Limit = 3 };
            var service = new InvoiceService(this.StripeClient);
            var invoice = service.ListAutoPaging(options).First();
            this.AssertRequest(HttpMethod.Get, "/v1/invoices", "limit=3");
        }

        [Fact]
        public async Task TestInvoicesGetAutoPagingAsync()
        {
            var options = new InvoiceListOptions { Limit = 3 };
            var service = new InvoiceService(this.StripeClient);
            var invoice = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/invoices", "limit=3");
        }

        [Fact]
        public void TestInvoicesGet2()
        {
            var service = new InvoiceService(this.StripeClient);
            Invoice invoice = service.Get("in_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/invoices/in_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestInvoicesGet2Async()
        {
            var service = new InvoiceService(this.StripeClient);
            Invoice invoice = await service.GetAsync("in_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/invoices/in_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestInvoicesGet3()
        {
            var options = new InvoiceGetOptions
            {
                Expand = new List<string> { "customer" },
            };
            var service = new InvoiceService(this.StripeClient);
            Invoice invoice = service.Get("in_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/invoices/in_xxxxxxxxxxxxx",
                "expand[]=customer");
        }

        [Fact]
        public async Task TestInvoicesGet3Async()
        {
            var options = new InvoiceGetOptions
            {
                Expand = new List<string> { "customer" },
            };
            var service = new InvoiceService(this.StripeClient);
            Invoice invoice = await service.GetAsync(
                "in_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/invoices/in_xxxxxxxxxxxxx",
                "expand[]=customer");
        }

        [Fact]
        public void TestInvoicesMarkUncollectiblePost()
        {
            var service = new InvoiceService(this.StripeClient);
            Invoice invoice = service.MarkUncollectible("in_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/invoices/in_xxxxxxxxxxxxx/mark_uncollectible");
        }

        [Fact]
        public async Task TestInvoicesMarkUncollectiblePostAsync()
        {
            var service = new InvoiceService(this.StripeClient);
            Invoice invoice = await service.MarkUncollectibleAsync(
                "in_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/invoices/in_xxxxxxxxxxxxx/mark_uncollectible");
        }

        [Fact]
        public void TestInvoicesPayPost()
        {
            var service = new InvoiceService(this.StripeClient);
            Invoice invoice = service.Pay("in_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/invoices/in_xxxxxxxxxxxxx/pay");
        }

        [Fact]
        public async Task TestInvoicesPayPostAsync()
        {
            var service = new InvoiceService(this.StripeClient);
            Invoice invoice = await service.PayAsync("in_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/invoices/in_xxxxxxxxxxxxx/pay");
        }

        [Fact]
        public void TestInvoicesPost()
        {
            var options = new InvoiceCreateOptions
            {
                Customer = "cus_xxxxxxxxxxxxx",
            };
            var service = new InvoiceService(this.StripeClient);
            Invoice invoice = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/invoices");
        }

        [Fact]
        public async Task TestInvoicesPostAsync()
        {
            var options = new InvoiceCreateOptions
            {
                Customer = "cus_xxxxxxxxxxxxx",
            };
            var service = new InvoiceService(this.StripeClient);
            Invoice invoice = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/invoices");
        }

        [Fact]
        public void TestInvoicesPost2()
        {
            var options = new InvoiceUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new InvoiceService(this.StripeClient);
            Invoice invoice = service.Update("in_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/invoices/in_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestInvoicesPost2Async()
        {
            var options = new InvoiceUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new InvoiceService(this.StripeClient);
            Invoice invoice = await service.UpdateAsync(
                "in_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/invoices/in_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestInvoicesSearchGet()
        {
            var options = new InvoiceSearchOptions
            {
                Query = "total>999 AND metadata['order_id']:'6735'",
            };
            var service = new InvoiceService(this.StripeClient);
            StripeSearchResult<Invoice> invoices = service.Search(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/invoices/search",
                "query=total%3E999%20AND%20metadata%5B%27order_id%27%5D%3A%276735%27");
        }

        [Fact]
        public async Task TestInvoicesSearchGetAsync()
        {
            var options = new InvoiceSearchOptions
            {
                Query = "total>999 AND metadata['order_id']:'6735'",
            };
            var service = new InvoiceService(this.StripeClient);
            StripeSearchResult<Invoice> invoices = await service.SearchAsync(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/invoices/search",
                "query=total%3E999%20AND%20metadata%5B%27order_id%27%5D%3A%276735%27");
        }

        [Fact]
        public void TestInvoicesSearchGetAutoPaging()
        {
            var options = new InvoiceSearchOptions
            {
                Query = "total>999 AND metadata['order_id']:'6735'",
            };
            var service = new InvoiceService(this.StripeClient);
            var invoice = service.SearchAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/invoices/search",
                "query=total%3E999%20AND%20metadata%5B%27order_id%27%5D%3A%276735%27");
        }

        [Fact]
        public async Task TestInvoicesSearchGetAutoPagingAsync()
        {
            var options = new InvoiceSearchOptions
            {
                Query = "total>999 AND metadata['order_id']:'6735'",
            };
            var service = new InvoiceService(this.StripeClient);
            var invoice = await service.SearchAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/invoices/search",
                "query=total%3E999%20AND%20metadata%5B%27order_id%27%5D%3A%276735%27");
        }

        [Fact]
        public void TestInvoicesSendPost()
        {
            var service = new InvoiceService(this.StripeClient);
            Invoice invoice = service.SendInvoice("in_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/invoices/in_xxxxxxxxxxxxx/send");
        }

        [Fact]
        public async Task TestInvoicesSendPostAsync()
        {
            var service = new InvoiceService(this.StripeClient);
            Invoice invoice = await service.SendInvoiceAsync(
                "in_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/invoices/in_xxxxxxxxxxxxx/send");
        }

        [Fact]
        public void TestInvoicesVoidPost()
        {
            var service = new InvoiceService(this.StripeClient);
            Invoice invoice = service.VoidInvoice("in_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/invoices/in_xxxxxxxxxxxxx/void");
        }

        [Fact]
        public async Task TestInvoicesVoidPostAsync()
        {
            var service = new InvoiceService(this.StripeClient);
            Invoice invoice = await service.VoidInvoiceAsync(
                "in_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/invoices/in_xxxxxxxxxxxxx/void");
        }

        [Fact]
        public void TestIssuingAuthorizationsApprovePost()
        {
            var service = new Stripe.Issuing.AuthorizationService(
                this.StripeClient);
            Stripe.Issuing.Authorization authorization = service.Approve(
                "iauth_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/issuing/authorizations/iauth_xxxxxxxxxxxxx/approve");
        }

        [Fact]
        public async Task TestIssuingAuthorizationsApprovePostAsync()
        {
            var service = new Stripe.Issuing.AuthorizationService(
                this.StripeClient);
            Stripe.Issuing.Authorization authorization = await service
                .ApproveAsync("iauth_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/issuing/authorizations/iauth_xxxxxxxxxxxxx/approve");
        }

        [Fact]
        public void TestIssuingAuthorizationsDeclinePost()
        {
            var service = new Stripe.Issuing.AuthorizationService(
                this.StripeClient);
            Stripe.Issuing.Authorization authorization = service.Decline(
                "iauth_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/issuing/authorizations/iauth_xxxxxxxxxxxxx/decline");
        }

        [Fact]
        public async Task TestIssuingAuthorizationsDeclinePostAsync()
        {
            var service = new Stripe.Issuing.AuthorizationService(
                this.StripeClient);
            Stripe.Issuing.Authorization authorization = await service
                .DeclineAsync("iauth_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/issuing/authorizations/iauth_xxxxxxxxxxxxx/decline");
        }

        [Fact]
        public void TestIssuingAuthorizationsGet()
        {
            var options = new Stripe.Issuing.AuthorizationListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Issuing.AuthorizationService(
                this.StripeClient);
            StripeList<Stripe.Issuing.Authorization> authorizations = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/authorizations",
                "limit=3");
        }

        [Fact]
        public async Task TestIssuingAuthorizationsGetAsync()
        {
            var options = new Stripe.Issuing.AuthorizationListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Issuing.AuthorizationService(
                this.StripeClient);
            StripeList<Stripe.Issuing.Authorization> authorizations = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/authorizations",
                "limit=3");
        }

        [Fact]
        public void TestIssuingAuthorizationsGetAutoPaging()
        {
            var options = new Stripe.Issuing.AuthorizationListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Issuing.AuthorizationService(
                this.StripeClient);
            var authorization = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/authorizations",
                "limit=3");
        }

        [Fact]
        public async Task TestIssuingAuthorizationsGetAutoPagingAsync()
        {
            var options = new Stripe.Issuing.AuthorizationListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Issuing.AuthorizationService(
                this.StripeClient);
            var authorization = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/authorizations",
                "limit=3");
        }

        [Fact]
        public void TestIssuingAuthorizationsGet2()
        {
            var service = new Stripe.Issuing.AuthorizationService(
                this.StripeClient);
            Stripe.Issuing.Authorization authorization = service.Get(
                "iauth_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/authorizations/iauth_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestIssuingAuthorizationsGet2Async()
        {
            var service = new Stripe.Issuing.AuthorizationService(
                this.StripeClient);
            Stripe.Issuing.Authorization authorization = await service.GetAsync(
                "iauth_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/authorizations/iauth_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIssuingAuthorizationsPost()
        {
            var options = new Stripe.Issuing.AuthorizationUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new Stripe.Issuing.AuthorizationService(
                this.StripeClient);
            Stripe.Issuing.Authorization authorization = service.Update(
                "iauth_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/issuing/authorizations/iauth_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestIssuingAuthorizationsPostAsync()
        {
            var options = new Stripe.Issuing.AuthorizationUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new Stripe.Issuing.AuthorizationService(
                this.StripeClient);
            Stripe.Issuing.Authorization authorization = await service
                .UpdateAsync("iauth_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/issuing/authorizations/iauth_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIssuingCardholdersGet()
        {
            var options = new Stripe.Issuing.CardholderListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Issuing.CardholderService(
                this.StripeClient);
            StripeList<Stripe.Issuing.Cardholder> cardholders = service.List(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/cardholders",
                "limit=3");
        }

        [Fact]
        public async Task TestIssuingCardholdersGetAsync()
        {
            var options = new Stripe.Issuing.CardholderListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Issuing.CardholderService(
                this.StripeClient);
            StripeList<Stripe.Issuing.Cardholder> cardholders = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/cardholders",
                "limit=3");
        }

        [Fact]
        public void TestIssuingCardholdersGetAutoPaging()
        {
            var options = new Stripe.Issuing.CardholderListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Issuing.CardholderService(
                this.StripeClient);
            var cardholder = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/cardholders",
                "limit=3");
        }

        [Fact]
        public async Task TestIssuingCardholdersGetAutoPagingAsync()
        {
            var options = new Stripe.Issuing.CardholderListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Issuing.CardholderService(
                this.StripeClient);
            var cardholder = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/cardholders",
                "limit=3");
        }

        [Fact]
        public void TestIssuingCardholdersGet2()
        {
            var service = new Stripe.Issuing.CardholderService(
                this.StripeClient);
            Stripe.Issuing.Cardholder cardholder = service.Get(
                "ich_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/cardholders/ich_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestIssuingCardholdersGet2Async()
        {
            var service = new Stripe.Issuing.CardholderService(
                this.StripeClient);
            Stripe.Issuing.Cardholder cardholder = await service.GetAsync(
                "ich_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/cardholders/ich_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIssuingCardholdersPost()
        {
            var options = new Stripe.Issuing.CardholderCreateOptions
            {
                Type = "individual",
                Name = "Jenny Rosen",
                Email = "jenny.rosen@example.com",
                PhoneNumber = "+18888675309",
                Billing = new Stripe.Issuing.CardholderBillingOptions
                {
                    Address = new AddressOptions
                    {
                        Line1 = "1234 Main Street",
                        City = "San Francisco",
                        State = "CA",
                        Country = "US",
                        PostalCode = "94111",
                    },
                },
            };
            var service = new Stripe.Issuing.CardholderService(
                this.StripeClient);
            Stripe.Issuing.Cardholder cardholder = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/issuing/cardholders");
        }

        [Fact]
        public async Task TestIssuingCardholdersPostAsync()
        {
            var options = new Stripe.Issuing.CardholderCreateOptions
            {
                Type = "individual",
                Name = "Jenny Rosen",
                Email = "jenny.rosen@example.com",
                PhoneNumber = "+18888675309",
                Billing = new Stripe.Issuing.CardholderBillingOptions
                {
                    Address = new AddressOptions
                    {
                        Line1 = "1234 Main Street",
                        City = "San Francisco",
                        State = "CA",
                        Country = "US",
                        PostalCode = "94111",
                    },
                },
            };
            var service = new Stripe.Issuing.CardholderService(
                this.StripeClient);
            Stripe.Issuing.Cardholder cardholder = await service.CreateAsync(
                options);
            this.AssertRequest(HttpMethod.Post, "/v1/issuing/cardholders");
        }

        [Fact]
        public void TestIssuingCardholdersPost2()
        {
            var options = new Stripe.Issuing.CardholderUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new Stripe.Issuing.CardholderService(
                this.StripeClient);
            Stripe.Issuing.Cardholder cardholder = service.Update(
                "ich_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/issuing/cardholders/ich_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestIssuingCardholdersPost2Async()
        {
            var options = new Stripe.Issuing.CardholderUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new Stripe.Issuing.CardholderService(
                this.StripeClient);
            Stripe.Issuing.Cardholder cardholder = await service.UpdateAsync(
                "ich_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/issuing/cardholders/ich_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIssuingCardsGet()
        {
            var options = new Stripe.Issuing.CardListOptions { Limit = 3 };
            var service = new Stripe.Issuing.CardService(this.StripeClient);
            StripeList<Stripe.Issuing.Card> cards = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/issuing/cards", "limit=3");
        }

        [Fact]
        public async Task TestIssuingCardsGetAsync()
        {
            var options = new Stripe.Issuing.CardListOptions { Limit = 3 };
            var service = new Stripe.Issuing.CardService(this.StripeClient);
            StripeList<Stripe.Issuing.Card> cards = await service.ListAsync(
                options);
            this.AssertRequest(HttpMethod.Get, "/v1/issuing/cards", "limit=3");
        }

        [Fact]
        public void TestIssuingCardsGetAutoPaging()
        {
            var options = new Stripe.Issuing.CardListOptions { Limit = 3 };
            var service = new Stripe.Issuing.CardService(this.StripeClient);
            var card = service.ListAutoPaging(options).First();
            this.AssertRequest(HttpMethod.Get, "/v1/issuing/cards", "limit=3");
        }

        [Fact]
        public async Task TestIssuingCardsGetAutoPagingAsync()
        {
            var options = new Stripe.Issuing.CardListOptions { Limit = 3 };
            var service = new Stripe.Issuing.CardService(this.StripeClient);
            var card = await service.ListAutoPagingAsync(options).FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/issuing/cards", "limit=3");
        }

        [Fact]
        public void TestIssuingCardsGet2()
        {
            var service = new Stripe.Issuing.CardService(this.StripeClient);
            Stripe.Issuing.Card card = service.Get("ic_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/cards/ic_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestIssuingCardsGet2Async()
        {
            var service = new Stripe.Issuing.CardService(this.StripeClient);
            Stripe.Issuing.Card card = await service.GetAsync(
                "ic_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/cards/ic_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIssuingCardsPost()
        {
            var options = new Stripe.Issuing.CardCreateOptions
            {
                Cardholder = "ich_xxxxxxxxxxxxx",
                Currency = "usd",
                Type = "virtual",
            };
            var service = new Stripe.Issuing.CardService(this.StripeClient);
            Stripe.Issuing.Card card = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/issuing/cards");
        }

        [Fact]
        public async Task TestIssuingCardsPostAsync()
        {
            var options = new Stripe.Issuing.CardCreateOptions
            {
                Cardholder = "ich_xxxxxxxxxxxxx",
                Currency = "usd",
                Type = "virtual",
            };
            var service = new Stripe.Issuing.CardService(this.StripeClient);
            Stripe.Issuing.Card card = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/issuing/cards");
        }

        [Fact]
        public void TestIssuingCardsPost2()
        {
            var options = new Stripe.Issuing.CardUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new Stripe.Issuing.CardService(this.StripeClient);
            Stripe.Issuing.Card card = service.Update(
                "ic_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/issuing/cards/ic_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestIssuingCardsPost2Async()
        {
            var options = new Stripe.Issuing.CardUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new Stripe.Issuing.CardService(this.StripeClient);
            Stripe.Issuing.Card card = await service.UpdateAsync(
                "ic_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/issuing/cards/ic_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIssuingDisputesGet()
        {
            var options = new Stripe.Issuing.DisputeListOptions { Limit = 3 };
            var service = new Stripe.Issuing.DisputeService(this.StripeClient);
            StripeList<Stripe.Issuing.Dispute> disputes = service.List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/disputes",
                "limit=3");
        }

        [Fact]
        public async Task TestIssuingDisputesGetAsync()
        {
            var options = new Stripe.Issuing.DisputeListOptions { Limit = 3 };
            var service = new Stripe.Issuing.DisputeService(this.StripeClient);
            StripeList<Stripe.Issuing.Dispute> disputes = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/disputes",
                "limit=3");
        }

        [Fact]
        public void TestIssuingDisputesGetAutoPaging()
        {
            var options = new Stripe.Issuing.DisputeListOptions { Limit = 3 };
            var service = new Stripe.Issuing.DisputeService(this.StripeClient);
            var dispute = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/disputes",
                "limit=3");
        }

        [Fact]
        public async Task TestIssuingDisputesGetAutoPagingAsync()
        {
            var options = new Stripe.Issuing.DisputeListOptions { Limit = 3 };
            var service = new Stripe.Issuing.DisputeService(this.StripeClient);
            var dispute = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/disputes",
                "limit=3");
        }

        [Fact]
        public void TestIssuingDisputesGet2()
        {
            var service = new Stripe.Issuing.DisputeService(this.StripeClient);
            Stripe.Issuing.Dispute dispute = service.Get("idp_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/disputes/idp_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestIssuingDisputesGet2Async()
        {
            var service = new Stripe.Issuing.DisputeService(this.StripeClient);
            Stripe.Issuing.Dispute dispute = await service.GetAsync(
                "idp_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/disputes/idp_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIssuingDisputesPost()
        {
            var options = new Stripe.Issuing.DisputeCreateOptions
            {
                Transaction = "ipi_xxxxxxxxxxxxx",
                Evidence = new Stripe.Issuing.DisputeEvidenceOptions
                {
                    Reason = "fraudulent",
                    Fraudulent = new Stripe.Issuing.DisputeEvidenceFraudulentOptions
                    {
                        Explanation = "Purchase was unrecognized.",
                    },
                },
            };
            var service = new Stripe.Issuing.DisputeService(this.StripeClient);
            Stripe.Issuing.Dispute dispute = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/issuing/disputes");
        }

        [Fact]
        public async Task TestIssuingDisputesPostAsync()
        {
            var options = new Stripe.Issuing.DisputeCreateOptions
            {
                Transaction = "ipi_xxxxxxxxxxxxx",
                Evidence = new Stripe.Issuing.DisputeEvidenceOptions
                {
                    Reason = "fraudulent",
                    Fraudulent = new Stripe.Issuing.DisputeEvidenceFraudulentOptions
                    {
                        Explanation = "Purchase was unrecognized.",
                    },
                },
            };
            var service = new Stripe.Issuing.DisputeService(this.StripeClient);
            Stripe.Issuing.Dispute dispute = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/issuing/disputes");
        }

        [Fact]
        public void TestIssuingDisputesSubmitPost()
        {
            var service = new Stripe.Issuing.DisputeService(this.StripeClient);
            Stripe.Issuing.Dispute dispute = service.Submit(
                "idp_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/issuing/disputes/idp_xxxxxxxxxxxxx/submit");
        }

        [Fact]
        public async Task TestIssuingDisputesSubmitPostAsync()
        {
            var service = new Stripe.Issuing.DisputeService(this.StripeClient);
            Stripe.Issuing.Dispute dispute = await service.SubmitAsync(
                "idp_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/issuing/disputes/idp_xxxxxxxxxxxxx/submit");
        }

        [Fact]
        public void TestIssuingPersonalizationDesignsGet()
        {
            var service = new Stripe.Issuing.PersonalizationDesignService(
                this.StripeClient);
            StripeList<Stripe.Issuing.PersonalizationDesign> personalizationDesigns = service
                .List();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/personalization_designs");
        }

        [Fact]
        public async Task TestIssuingPersonalizationDesignsGetAsync()
        {
            var service = new Stripe.Issuing.PersonalizationDesignService(
                this.StripeClient);
            StripeList<Stripe.Issuing.PersonalizationDesign> personalizationDesigns = await service
                .ListAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/personalization_designs");
        }

        [Fact]
        public void TestIssuingPersonalizationDesignsGetAutoPaging()
        {
            var service = new Stripe.Issuing.PersonalizationDesignService(
                this.StripeClient);
            var personalizationDesign = service.ListAutoPaging().First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/personalization_designs");
        }

        [Fact]
        public async Task TestIssuingPersonalizationDesignsGetAutoPagingAsync()
        {
            var service = new Stripe.Issuing.PersonalizationDesignService(
                this.StripeClient);
            var personalizationDesign = await service.ListAutoPagingAsync()
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/personalization_designs");
        }

        [Fact]
        public void TestIssuingPersonalizationDesignsGet2()
        {
            var service = new Stripe.Issuing.PersonalizationDesignService(
                this.StripeClient);
            Stripe.Issuing.PersonalizationDesign personalizationDesign = service
                .Get("pd_xyz");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/personalization_designs/pd_xyz");
        }

        [Fact]
        public async Task TestIssuingPersonalizationDesignsGet2Async()
        {
            var service = new Stripe.Issuing.PersonalizationDesignService(
                this.StripeClient);
            Stripe.Issuing.PersonalizationDesign personalizationDesign = await service
                .GetAsync("pd_xyz");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/personalization_designs/pd_xyz");
        }

        [Fact]
        public void TestIssuingPersonalizationDesignsPost()
        {
            var options = new Stripe.Issuing.PersonalizationDesignCreateOptions
            {
                PhysicalBundle = "pb_xyz",
            };
            var service = new Stripe.Issuing.PersonalizationDesignService(
                this.StripeClient);
            Stripe.Issuing.PersonalizationDesign personalizationDesign = service
                .Create(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/issuing/personalization_designs");
        }

        [Fact]
        public async Task TestIssuingPersonalizationDesignsPostAsync()
        {
            var options = new Stripe.Issuing.PersonalizationDesignCreateOptions
            {
                PhysicalBundle = "pb_xyz",
            };
            var service = new Stripe.Issuing.PersonalizationDesignService(
                this.StripeClient);
            Stripe.Issuing.PersonalizationDesign personalizationDesign = await service
                .CreateAsync(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/issuing/personalization_designs");
        }

        [Fact]
        public void TestIssuingPersonalizationDesignsPost2()
        {
            var options = new Stripe.Issuing.PersonalizationDesignUpdateOptions();
            var service = new Stripe.Issuing.PersonalizationDesignService(
                this.StripeClient);
            Stripe.Issuing.PersonalizationDesign personalizationDesign = service
                .Update("pd_xyz", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/issuing/personalization_designs/pd_xyz");
        }

        [Fact]
        public async Task TestIssuingPersonalizationDesignsPost2Async()
        {
            var options = new Stripe.Issuing.PersonalizationDesignUpdateOptions();
            var service = new Stripe.Issuing.PersonalizationDesignService(
                this.StripeClient);
            Stripe.Issuing.PersonalizationDesign personalizationDesign = await service
                .UpdateAsync("pd_xyz", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/issuing/personalization_designs/pd_xyz");
        }

        [Fact]
        public void TestIssuingPhysicalBundlesGet()
        {
            var service = new Stripe.Issuing.PhysicalBundleService(
                this.StripeClient);
            StripeList<Stripe.Issuing.PhysicalBundle> physicalBundles = service
                .List();
            this.AssertRequest(HttpMethod.Get, "/v1/issuing/physical_bundles");
        }

        [Fact]
        public async Task TestIssuingPhysicalBundlesGetAsync()
        {
            var service = new Stripe.Issuing.PhysicalBundleService(
                this.StripeClient);
            StripeList<Stripe.Issuing.PhysicalBundle> physicalBundles = await service
                .ListAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/issuing/physical_bundles");
        }

        [Fact]
        public void TestIssuingPhysicalBundlesGetAutoPaging()
        {
            var service = new Stripe.Issuing.PhysicalBundleService(
                this.StripeClient);
            var physicalBundle = service.ListAutoPaging().First();
            this.AssertRequest(HttpMethod.Get, "/v1/issuing/physical_bundles");
        }

        [Fact]
        public async Task TestIssuingPhysicalBundlesGetAutoPagingAsync()
        {
            var service = new Stripe.Issuing.PhysicalBundleService(
                this.StripeClient);
            var physicalBundle = await service.ListAutoPagingAsync()
                .FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/issuing/physical_bundles");
        }

        [Fact]
        public void TestIssuingPhysicalBundlesGet2()
        {
            var service = new Stripe.Issuing.PhysicalBundleService(
                this.StripeClient);
            Stripe.Issuing.PhysicalBundle physicalBundle = service.Get(
                "pb_xyz");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/physical_bundles/pb_xyz");
        }

        [Fact]
        public async Task TestIssuingPhysicalBundlesGet2Async()
        {
            var service = new Stripe.Issuing.PhysicalBundleService(
                this.StripeClient);
            Stripe.Issuing.PhysicalBundle physicalBundle = await service
                .GetAsync("pb_xyz");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/physical_bundles/pb_xyz");
        }

        [Fact]
        public void TestIssuingTransactionsGet()
        {
            var options = new Stripe.Issuing.TransactionListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Issuing.TransactionService(
                this.StripeClient);
            StripeList<Stripe.Issuing.Transaction> transactions = service.List(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/transactions",
                "limit=3");
        }

        [Fact]
        public async Task TestIssuingTransactionsGetAsync()
        {
            var options = new Stripe.Issuing.TransactionListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Issuing.TransactionService(
                this.StripeClient);
            StripeList<Stripe.Issuing.Transaction> transactions = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/transactions",
                "limit=3");
        }

        [Fact]
        public void TestIssuingTransactionsGetAutoPaging()
        {
            var options = new Stripe.Issuing.TransactionListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Issuing.TransactionService(
                this.StripeClient);
            var transaction = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/transactions",
                "limit=3");
        }

        [Fact]
        public async Task TestIssuingTransactionsGetAutoPagingAsync()
        {
            var options = new Stripe.Issuing.TransactionListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Issuing.TransactionService(
                this.StripeClient);
            var transaction = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/transactions",
                "limit=3");
        }

        [Fact]
        public void TestIssuingTransactionsGet2()
        {
            var service = new Stripe.Issuing.TransactionService(
                this.StripeClient);
            Stripe.Issuing.Transaction transaction = service.Get(
                "ipi_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/transactions/ipi_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestIssuingTransactionsGet2Async()
        {
            var service = new Stripe.Issuing.TransactionService(
                this.StripeClient);
            Stripe.Issuing.Transaction transaction = await service.GetAsync(
                "ipi_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/transactions/ipi_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIssuingTransactionsPost()
        {
            var options = new Stripe.Issuing.TransactionUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new Stripe.Issuing.TransactionService(
                this.StripeClient);
            Stripe.Issuing.Transaction transaction = service.Update(
                "ipi_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/issuing/transactions/ipi_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestIssuingTransactionsPostAsync()
        {
            var options = new Stripe.Issuing.TransactionUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new Stripe.Issuing.TransactionService(
                this.StripeClient);
            Stripe.Issuing.Transaction transaction = await service.UpdateAsync(
                "ipi_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/issuing/transactions/ipi_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestMandatesGet()
        {
            var service = new MandateService(this.StripeClient);
            Mandate mandate = service.Get("mandate_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/mandates/mandate_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestMandatesGetAsync()
        {
            var service = new MandateService(this.StripeClient);
            Mandate mandate = await service.GetAsync("mandate_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/mandates/mandate_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPaymentIntentsApplyCustomerBalancePost()
        {
            var service = new PaymentIntentService(this.StripeClient);
            PaymentIntent paymentIntent = service.ApplyCustomerBalance(
                "pi_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_intents/pi_xxxxxxxxxxxxx/apply_customer_balance");
        }

        [Fact]
        public async Task TestPaymentIntentsApplyCustomerBalancePostAsync()
        {
            var service = new PaymentIntentService(this.StripeClient);
            PaymentIntent paymentIntent = await service
                .ApplyCustomerBalanceAsync("pi_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_intents/pi_xxxxxxxxxxxxx/apply_customer_balance");
        }

        [Fact]
        public void TestPaymentIntentsCancelPost()
        {
            var service = new PaymentIntentService(this.StripeClient);
            PaymentIntent paymentIntent = service.Cancel("pi_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_intents/pi_xxxxxxxxxxxxx/cancel");
        }

        [Fact]
        public async Task TestPaymentIntentsCancelPostAsync()
        {
            var service = new PaymentIntentService(this.StripeClient);
            PaymentIntent paymentIntent = await service.CancelAsync(
                "pi_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_intents/pi_xxxxxxxxxxxxx/cancel");
        }

        [Fact]
        public void TestPaymentIntentsCapturePost()
        {
            var service = new PaymentIntentService(this.StripeClient);
            PaymentIntent paymentIntent = service.Capture("pi_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_intents/pi_xxxxxxxxxxxxx/capture");
        }

        [Fact]
        public async Task TestPaymentIntentsCapturePostAsync()
        {
            var service = new PaymentIntentService(this.StripeClient);
            PaymentIntent paymentIntent = await service.CaptureAsync(
                "pi_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_intents/pi_xxxxxxxxxxxxx/capture");
        }

        [Fact]
        public void TestPaymentIntentsConfirmPost()
        {
            var options = new PaymentIntentConfirmOptions
            {
                PaymentMethod = "pm_card_visa",
            };
            var service = new PaymentIntentService(this.StripeClient);
            PaymentIntent paymentIntent = service.Confirm(
                "pi_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_intents/pi_xxxxxxxxxxxxx/confirm");
        }

        [Fact]
        public async Task TestPaymentIntentsConfirmPostAsync()
        {
            var options = new PaymentIntentConfirmOptions
            {
                PaymentMethod = "pm_card_visa",
            };
            var service = new PaymentIntentService(this.StripeClient);
            PaymentIntent paymentIntent = await service.ConfirmAsync(
                "pi_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_intents/pi_xxxxxxxxxxxxx/confirm");
        }

        [Fact]
        public void TestPaymentIntentsGet()
        {
            var options = new PaymentIntentListOptions { Limit = 3 };
            var service = new PaymentIntentService(this.StripeClient);
            StripeList<PaymentIntent> paymentIntents = service.List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_intents",
                "limit=3");
        }

        [Fact]
        public async Task TestPaymentIntentsGetAsync()
        {
            var options = new PaymentIntentListOptions { Limit = 3 };
            var service = new PaymentIntentService(this.StripeClient);
            StripeList<PaymentIntent> paymentIntents = await service.ListAsync(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_intents",
                "limit=3");
        }

        [Fact]
        public void TestPaymentIntentsGetAutoPaging()
        {
            var options = new PaymentIntentListOptions { Limit = 3 };
            var service = new PaymentIntentService(this.StripeClient);
            var paymentIntent = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_intents",
                "limit=3");
        }

        [Fact]
        public async Task TestPaymentIntentsGetAutoPagingAsync()
        {
            var options = new PaymentIntentListOptions { Limit = 3 };
            var service = new PaymentIntentService(this.StripeClient);
            var paymentIntent = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_intents",
                "limit=3");
        }

        [Fact]
        public void TestPaymentIntentsGet2()
        {
            var service = new PaymentIntentService(this.StripeClient);
            PaymentIntent paymentIntent = service.Get("pi_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_intents/pi_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestPaymentIntentsGet2Async()
        {
            var service = new PaymentIntentService(this.StripeClient);
            PaymentIntent paymentIntent = await service.GetAsync(
                "pi_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_intents/pi_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPaymentIntentsIncrementAuthorizationPost()
        {
            var options = new PaymentIntentIncrementAuthorizationOptions
            {
                Amount = 2099,
            };
            var service = new PaymentIntentService(this.StripeClient);
            PaymentIntent paymentIntent = service.IncrementAuthorization(
                "pi_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_intents/pi_xxxxxxxxxxxxx/increment_authorization");
        }

        [Fact]
        public async Task TestPaymentIntentsIncrementAuthorizationPostAsync()
        {
            var options = new PaymentIntentIncrementAuthorizationOptions
            {
                Amount = 2099,
            };
            var service = new PaymentIntentService(this.StripeClient);
            PaymentIntent paymentIntent = await service
                .IncrementAuthorizationAsync("pi_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_intents/pi_xxxxxxxxxxxxx/increment_authorization");
        }

        [Fact]
        public void TestPaymentIntentsPost()
        {
            var options = new PaymentIntentCreateOptions
            {
                Amount = 1099,
                Currency = "eur",
                AutomaticPaymentMethods = new PaymentIntentAutomaticPaymentMethodsOptions
                {
                    Enabled = true,
                },
            };
            var service = new PaymentIntentService(this.StripeClient);
            PaymentIntent paymentIntent = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/payment_intents");
        }

        [Fact]
        public async Task TestPaymentIntentsPostAsync()
        {
            var options = new PaymentIntentCreateOptions
            {
                Amount = 1099,
                Currency = "eur",
                AutomaticPaymentMethods = new PaymentIntentAutomaticPaymentMethodsOptions
                {
                    Enabled = true,
                },
            };
            var service = new PaymentIntentService(this.StripeClient);
            PaymentIntent paymentIntent = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/payment_intents");
        }

        [Fact]
        public void TestPaymentIntentsPost2()
        {
            var options = new PaymentIntentCreateOptions
            {
                Amount = 2000,
                Currency = "usd",
                AutomaticPaymentMethods = new PaymentIntentAutomaticPaymentMethodsOptions
                {
                    Enabled = true,
                },
            };
            var service = new PaymentIntentService(this.StripeClient);
            PaymentIntent paymentIntent = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/payment_intents");
        }

        [Fact]
        public async Task TestPaymentIntentsPost2Async()
        {
            var options = new PaymentIntentCreateOptions
            {
                Amount = 2000,
                Currency = "usd",
                AutomaticPaymentMethods = new PaymentIntentAutomaticPaymentMethodsOptions
                {
                    Enabled = true,
                },
            };
            var service = new PaymentIntentService(this.StripeClient);
            PaymentIntent paymentIntent = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/payment_intents");
        }

        [Fact]
        public void TestPaymentIntentsPost3()
        {
            var options = new PaymentIntentUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new PaymentIntentService(this.StripeClient);
            PaymentIntent paymentIntent = service.Update(
                "pi_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_intents/pi_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestPaymentIntentsPost3Async()
        {
            var options = new PaymentIntentUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new PaymentIntentService(this.StripeClient);
            PaymentIntent paymentIntent = await service.UpdateAsync(
                "pi_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_intents/pi_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPaymentIntentsPost4()
        {
            var options = new PaymentIntentCreateOptions
            {
                Amount = 200,
                Currency = "usd",
                PaymentMethodData = new PaymentIntentPaymentMethodDataOptions
                {
                    Type = "p24",
                    P24 = new PaymentIntentPaymentMethodDataP24Options
                    {
                        Bank = "blik",
                    },
                },
            };
            var service = new PaymentIntentService(this.StripeClient);
            PaymentIntent paymentIntent = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/payment_intents");
        }

        [Fact]
        public async Task TestPaymentIntentsPost4Async()
        {
            var options = new PaymentIntentCreateOptions
            {
                Amount = 200,
                Currency = "usd",
                PaymentMethodData = new PaymentIntentPaymentMethodDataOptions
                {
                    Type = "p24",
                    P24 = new PaymentIntentPaymentMethodDataP24Options
                    {
                        Bank = "blik",
                    },
                },
            };
            var service = new PaymentIntentService(this.StripeClient);
            PaymentIntent paymentIntent = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/payment_intents");
        }

        [Fact]
        public void TestPaymentIntentsSearchGet()
        {
            var options = new PaymentIntentSearchOptions
            {
                Query = "status:'succeeded' AND metadata['order_id']:'6735'",
            };
            var service = new PaymentIntentService(this.StripeClient);
            StripeSearchResult<PaymentIntent> paymentIntents = service.Search(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_intents/search",
                "query=status%3A%27succeeded%27%20AND%20metadata%5B%27order_id%27%5D%3A%276735%27");
        }

        [Fact]
        public async Task TestPaymentIntentsSearchGetAsync()
        {
            var options = new PaymentIntentSearchOptions
            {
                Query = "status:'succeeded' AND metadata['order_id']:'6735'",
            };
            var service = new PaymentIntentService(this.StripeClient);
            StripeSearchResult<PaymentIntent> paymentIntents = await service
                .SearchAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_intents/search",
                "query=status%3A%27succeeded%27%20AND%20metadata%5B%27order_id%27%5D%3A%276735%27");
        }

        [Fact]
        public void TestPaymentIntentsSearchGetAutoPaging()
        {
            var options = new PaymentIntentSearchOptions
            {
                Query = "status:'succeeded' AND metadata['order_id']:'6735'",
            };
            var service = new PaymentIntentService(this.StripeClient);
            var paymentIntent = service.SearchAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_intents/search",
                "query=status%3A%27succeeded%27%20AND%20metadata%5B%27order_id%27%5D%3A%276735%27");
        }

        [Fact]
        public async Task TestPaymentIntentsSearchGetAutoPagingAsync()
        {
            var options = new PaymentIntentSearchOptions
            {
                Query = "status:'succeeded' AND metadata['order_id']:'6735'",
            };
            var service = new PaymentIntentService(this.StripeClient);
            var paymentIntent = await service.SearchAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_intents/search",
                "query=status%3A%27succeeded%27%20AND%20metadata%5B%27order_id%27%5D%3A%276735%27");
        }

        [Fact]
        public void TestPaymentIntentsVerifyMicrodepositsPost()
        {
            var service = new PaymentIntentService(this.StripeClient);
            PaymentIntent paymentIntent = service.VerifyMicrodeposits(
                "pi_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_intents/pi_xxxxxxxxxxxxx/verify_microdeposits");
        }

        [Fact]
        public async Task TestPaymentIntentsVerifyMicrodepositsPostAsync()
        {
            var service = new PaymentIntentService(this.StripeClient);
            PaymentIntent paymentIntent = await service
                .VerifyMicrodepositsAsync("pi_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_intents/pi_xxxxxxxxxxxxx/verify_microdeposits");
        }

        [Fact]
        public void TestPaymentIntentsVerifyMicrodepositsPost2()
        {
            var options = new PaymentIntentVerifyMicrodepositsOptions
            {
                Amounts = new List<long?> { 32, 45 },
            };
            var service = new PaymentIntentService(this.StripeClient);
            PaymentIntent paymentIntent = service.VerifyMicrodeposits(
                "pi_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_intents/pi_xxxxxxxxxxxxx/verify_microdeposits");
        }

        [Fact]
        public async Task TestPaymentIntentsVerifyMicrodepositsPost2Async()
        {
            var options = new PaymentIntentVerifyMicrodepositsOptions
            {
                Amounts = new List<long?> { 32, 45 },
            };
            var service = new PaymentIntentService(this.StripeClient);
            PaymentIntent paymentIntent = await service
                .VerifyMicrodepositsAsync("pi_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_intents/pi_xxxxxxxxxxxxx/verify_microdeposits");
        }

        [Fact]
        public void TestPaymentLinksGet()
        {
            var service = new PaymentLinkService(this.StripeClient);
            PaymentLink paymentLink = service.Get("pl_xyz");
            this.AssertRequest(HttpMethod.Get, "/v1/payment_links/pl_xyz");
        }

        [Fact]
        public async Task TestPaymentLinksGetAsync()
        {
            var service = new PaymentLinkService(this.StripeClient);
            PaymentLink paymentLink = await service.GetAsync("pl_xyz");
            this.AssertRequest(HttpMethod.Get, "/v1/payment_links/pl_xyz");
        }

        [Fact]
        public void TestPaymentLinksGet2()
        {
            var options = new PaymentLinkListOptions { Limit = 3 };
            var service = new PaymentLinkService(this.StripeClient);
            StripeList<PaymentLink> paymentLinks = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/payment_links", "limit=3");
        }

        [Fact]
        public async Task TestPaymentLinksGet2Async()
        {
            var options = new PaymentLinkListOptions { Limit = 3 };
            var service = new PaymentLinkService(this.StripeClient);
            StripeList<PaymentLink> paymentLinks = await service.ListAsync(
                options);
            this.AssertRequest(HttpMethod.Get, "/v1/payment_links", "limit=3");
        }

        [Fact]
        public void TestPaymentLinksGet2AutoPaging()
        {
            var options = new PaymentLinkListOptions { Limit = 3 };
            var service = new PaymentLinkService(this.StripeClient);
            var paymentLink = service.ListAutoPaging(options).First();
            this.AssertRequest(HttpMethod.Get, "/v1/payment_links", "limit=3");
        }

        [Fact]
        public async Task TestPaymentLinksGet2AutoPagingAsync()
        {
            var options = new PaymentLinkListOptions { Limit = 3 };
            var service = new PaymentLinkService(this.StripeClient);
            var paymentLink = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/payment_links", "limit=3");
        }

        [Fact]
        public void TestPaymentLinksGet3()
        {
            var service = new PaymentLinkService(this.StripeClient);
            PaymentLink paymentLink = service.Get("plink_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_links/plink_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestPaymentLinksGet3Async()
        {
            var service = new PaymentLinkService(this.StripeClient);
            PaymentLink paymentLink = await service.GetAsync(
                "plink_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_links/plink_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPaymentLinksLineItemsGet()
        {
            var service = new PaymentLinkLineItemService(this.StripeClient);
            StripeList<LineItem> lineItems = service.List("pl_xyz");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_links/pl_xyz/line_items");
        }

        [Fact]
        public async Task TestPaymentLinksLineItemsGetAsync()
        {
            var service = new PaymentLinkLineItemService(this.StripeClient);
            StripeList<LineItem> lineItems = await service.ListAsync("pl_xyz");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_links/pl_xyz/line_items");
        }

        [Fact]
        public void TestPaymentLinksLineItemsGetAutoPaging()
        {
            var service = new PaymentLinkLineItemService(this.StripeClient);
            var lineItem = service.ListAutoPaging("pl_xyz").First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_links/pl_xyz/line_items");
        }

        [Fact]
        public async Task TestPaymentLinksLineItemsGetAutoPagingAsync()
        {
            var service = new PaymentLinkLineItemService(this.StripeClient);
            var lineItem = await service.ListAutoPagingAsync("pl_xyz")
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_links/pl_xyz/line_items");
        }

        [Fact]
        public void TestPaymentLinksPost()
        {
            var options = new PaymentLinkCreateOptions
            {
                LineItems = new List<PaymentLinkLineItemOptions>
                {
                    new PaymentLinkLineItemOptions
                    {
                        Price = "price_xxxxxxxxxxxxx",
                        Quantity = 1,
                    },
                },
            };
            var service = new PaymentLinkService(this.StripeClient);
            PaymentLink paymentLink = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/payment_links");
        }

        [Fact]
        public async Task TestPaymentLinksPostAsync()
        {
            var options = new PaymentLinkCreateOptions
            {
                LineItems = new List<PaymentLinkLineItemOptions>
                {
                    new PaymentLinkLineItemOptions
                    {
                        Price = "price_xxxxxxxxxxxxx",
                        Quantity = 1,
                    },
                },
            };
            var service = new PaymentLinkService(this.StripeClient);
            PaymentLink paymentLink = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/payment_links");
        }

        [Fact]
        public void TestPaymentLinksPost2()
        {
            var options = new PaymentLinkCreateOptions
            {
                LineItems = new List<PaymentLinkLineItemOptions>
                {
                    new PaymentLinkLineItemOptions
                    {
                        Price = "price_xxxxxxxxxxxxx",
                        Quantity = 1,
                    },
                },
            };
            var service = new PaymentLinkService(this.StripeClient);
            PaymentLink paymentLink = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/payment_links");
        }

        [Fact]
        public async Task TestPaymentLinksPost2Async()
        {
            var options = new PaymentLinkCreateOptions
            {
                LineItems = new List<PaymentLinkLineItemOptions>
                {
                    new PaymentLinkLineItemOptions
                    {
                        Price = "price_xxxxxxxxxxxxx",
                        Quantity = 1,
                    },
                },
            };
            var service = new PaymentLinkService(this.StripeClient);
            PaymentLink paymentLink = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/payment_links");
        }

        [Fact]
        public void TestPaymentLinksPost3()
        {
            var options = new PaymentLinkUpdateOptions { Active = false };
            var service = new PaymentLinkService(this.StripeClient);
            PaymentLink paymentLink = service.Update(
                "plink_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_links/plink_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestPaymentLinksPost3Async()
        {
            var options = new PaymentLinkUpdateOptions { Active = false };
            var service = new PaymentLinkService(this.StripeClient);
            PaymentLink paymentLink = await service.UpdateAsync(
                "plink_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_links/plink_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPaymentMethodConfigurationsGet()
        {
            var options = new PaymentMethodConfigurationListOptions
            {
                Application = "foo",
            };
            var service = new PaymentMethodConfigurationService(
                this.StripeClient);
            StripeList<PaymentMethodConfiguration> paymentMethodConfigurations = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_method_configurations",
                "application=foo");
        }

        [Fact]
        public async Task TestPaymentMethodConfigurationsGetAsync()
        {
            var options = new PaymentMethodConfigurationListOptions
            {
                Application = "foo",
            };
            var service = new PaymentMethodConfigurationService(
                this.StripeClient);
            StripeList<PaymentMethodConfiguration> paymentMethodConfigurations = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_method_configurations",
                "application=foo");
        }

        [Fact]
        public void TestPaymentMethodConfigurationsGetAutoPaging()
        {
            var options = new PaymentMethodConfigurationListOptions
            {
                Application = "foo",
            };
            var service = new PaymentMethodConfigurationService(
                this.StripeClient);
            var paymentMethodConfiguration = service.ListAutoPaging(options)
                .First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_method_configurations",
                "application=foo");
        }

        [Fact]
        public async Task TestPaymentMethodConfigurationsGetAutoPagingAsync()
        {
            var options = new PaymentMethodConfigurationListOptions
            {
                Application = "foo",
            };
            var service = new PaymentMethodConfigurationService(
                this.StripeClient);
            var paymentMethodConfiguration = await service.ListAutoPagingAsync(
                options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_method_configurations",
                "application=foo");
        }

        [Fact]
        public void TestPaymentMethodConfigurationsGet2()
        {
            var service = new PaymentMethodConfigurationService(
                this.StripeClient);
            PaymentMethodConfiguration paymentMethodConfiguration = service.Get(
                "foo");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_method_configurations/foo");
        }

        [Fact]
        public async Task TestPaymentMethodConfigurationsGet2Async()
        {
            var service = new PaymentMethodConfigurationService(
                this.StripeClient);
            PaymentMethodConfiguration paymentMethodConfiguration = await service
                .GetAsync("foo");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_method_configurations/foo");
        }

        [Fact]
        public void TestPaymentMethodConfigurationsPost()
        {
            var options = new PaymentMethodConfigurationCreateOptions
            {
                AcssDebit = new PaymentMethodConfigurationAcssDebitOptions
                {
                    DisplayPreference = new PaymentMethodConfigurationAcssDebitDisplayPreferenceOptions
                    {
                        Preference = "none",
                    },
                },
                Affirm = new PaymentMethodConfigurationAffirmOptions
                {
                    DisplayPreference = new PaymentMethodConfigurationAffirmDisplayPreferenceOptions
                    {
                        Preference = "none",
                    },
                },
            };
            var service = new PaymentMethodConfigurationService(
                this.StripeClient);
            PaymentMethodConfiguration paymentMethodConfiguration = service
                .Create(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_method_configurations");
        }

        [Fact]
        public async Task TestPaymentMethodConfigurationsPostAsync()
        {
            var options = new PaymentMethodConfigurationCreateOptions
            {
                AcssDebit = new PaymentMethodConfigurationAcssDebitOptions
                {
                    DisplayPreference = new PaymentMethodConfigurationAcssDebitDisplayPreferenceOptions
                    {
                        Preference = "none",
                    },
                },
                Affirm = new PaymentMethodConfigurationAffirmOptions
                {
                    DisplayPreference = new PaymentMethodConfigurationAffirmDisplayPreferenceOptions
                    {
                        Preference = "none",
                    },
                },
            };
            var service = new PaymentMethodConfigurationService(
                this.StripeClient);
            PaymentMethodConfiguration paymentMethodConfiguration = await service
                .CreateAsync(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_method_configurations");
        }

        [Fact]
        public void TestPaymentMethodConfigurationsPost2()
        {
            var options = new PaymentMethodConfigurationUpdateOptions
            {
                AcssDebit = new PaymentMethodConfigurationAcssDebitOptions
                {
                    DisplayPreference = new PaymentMethodConfigurationAcssDebitDisplayPreferenceOptions
                    {
                        Preference = "on",
                    },
                },
            };
            var service = new PaymentMethodConfigurationService(
                this.StripeClient);
            PaymentMethodConfiguration paymentMethodConfiguration = service
                .Update("foo", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_method_configurations/foo");
        }

        [Fact]
        public async Task TestPaymentMethodConfigurationsPost2Async()
        {
            var options = new PaymentMethodConfigurationUpdateOptions
            {
                AcssDebit = new PaymentMethodConfigurationAcssDebitOptions
                {
                    DisplayPreference = new PaymentMethodConfigurationAcssDebitDisplayPreferenceOptions
                    {
                        Preference = "on",
                    },
                },
            };
            var service = new PaymentMethodConfigurationService(
                this.StripeClient);
            PaymentMethodConfiguration paymentMethodConfiguration = await service
                .UpdateAsync("foo", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_method_configurations/foo");
        }

        [Fact]
        public void TestPaymentMethodsAttachPost()
        {
            var options = new PaymentMethodAttachOptions
            {
                Customer = "cus_xxxxxxxxxxxxx",
            };
            var service = new PaymentMethodService(this.StripeClient);
            PaymentMethod paymentMethod = service.Attach(
                "pm_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_methods/pm_xxxxxxxxxxxxx/attach");
        }

        [Fact]
        public async Task TestPaymentMethodsAttachPostAsync()
        {
            var options = new PaymentMethodAttachOptions
            {
                Customer = "cus_xxxxxxxxxxxxx",
            };
            var service = new PaymentMethodService(this.StripeClient);
            PaymentMethod paymentMethod = await service.AttachAsync(
                "pm_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_methods/pm_xxxxxxxxxxxxx/attach");
        }

        [Fact]
        public void TestPaymentMethodsDetachPost()
        {
            var service = new PaymentMethodService(this.StripeClient);
            PaymentMethod paymentMethod = service.Detach("pm_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_methods/pm_xxxxxxxxxxxxx/detach");
        }

        [Fact]
        public async Task TestPaymentMethodsDetachPostAsync()
        {
            var service = new PaymentMethodService(this.StripeClient);
            PaymentMethod paymentMethod = await service.DetachAsync(
                "pm_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_methods/pm_xxxxxxxxxxxxx/detach");
        }

        [Fact]
        public void TestPaymentMethodsGet()
        {
            var options = new PaymentMethodListOptions
            {
                Customer = "cus_xxxxxxxxxxxxx",
                Type = "card",
            };
            var service = new PaymentMethodService(this.StripeClient);
            StripeList<PaymentMethod> paymentMethods = service.List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_methods",
                "customer=cus_xxxxxxxxxxxxx&type=card");
        }

        [Fact]
        public async Task TestPaymentMethodsGetAsync()
        {
            var options = new PaymentMethodListOptions
            {
                Customer = "cus_xxxxxxxxxxxxx",
                Type = "card",
            };
            var service = new PaymentMethodService(this.StripeClient);
            StripeList<PaymentMethod> paymentMethods = await service.ListAsync(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_methods",
                "customer=cus_xxxxxxxxxxxxx&type=card");
        }

        [Fact]
        public void TestPaymentMethodsGetAutoPaging()
        {
            var options = new PaymentMethodListOptions
            {
                Customer = "cus_xxxxxxxxxxxxx",
                Type = "card",
            };
            var service = new PaymentMethodService(this.StripeClient);
            var paymentMethod = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_methods",
                "customer=cus_xxxxxxxxxxxxx&type=card");
        }

        [Fact]
        public async Task TestPaymentMethodsGetAutoPagingAsync()
        {
            var options = new PaymentMethodListOptions
            {
                Customer = "cus_xxxxxxxxxxxxx",
                Type = "card",
            };
            var service = new PaymentMethodService(this.StripeClient);
            var paymentMethod = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_methods",
                "customer=cus_xxxxxxxxxxxxx&type=card");
        }

        [Fact]
        public void TestPaymentMethodsGet2()
        {
            var service = new PaymentMethodService(this.StripeClient);
            PaymentMethod paymentMethod = service.Get("pm_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_methods/pm_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestPaymentMethodsGet2Async()
        {
            var service = new PaymentMethodService(this.StripeClient);
            PaymentMethod paymentMethod = await service.GetAsync(
                "pm_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_methods/pm_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPaymentMethodsPost()
        {
            var options = new PaymentMethodCreateOptions
            {
                Type = "card",
                Card = new PaymentMethodCardOptions
                {
                    Number = "4242424242424242",
                    ExpMonth = 8,
                    ExpYear = 2024,
                    Cvc = "314",
                },
            };
            var service = new PaymentMethodService(this.StripeClient);
            PaymentMethod paymentMethod = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/payment_methods");
        }

        [Fact]
        public async Task TestPaymentMethodsPostAsync()
        {
            var options = new PaymentMethodCreateOptions
            {
                Type = "card",
                Card = new PaymentMethodCardOptions
                {
                    Number = "4242424242424242",
                    ExpMonth = 8,
                    ExpYear = 2024,
                    Cvc = "314",
                },
            };
            var service = new PaymentMethodService(this.StripeClient);
            PaymentMethod paymentMethod = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/payment_methods");
        }

        [Fact]
        public void TestPaymentMethodsPost2()
        {
            var options = new PaymentMethodUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new PaymentMethodService(this.StripeClient);
            PaymentMethod paymentMethod = service.Update(
                "pm_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_methods/pm_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestPaymentMethodsPost2Async()
        {
            var options = new PaymentMethodUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new PaymentMethodService(this.StripeClient);
            PaymentMethod paymentMethod = await service.UpdateAsync(
                "pm_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_methods/pm_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPayoutsCancelPost()
        {
            var service = new PayoutService(this.StripeClient);
            Payout payout = service.Cancel("po_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payouts/po_xxxxxxxxxxxxx/cancel");
        }

        [Fact]
        public async Task TestPayoutsCancelPostAsync()
        {
            var service = new PayoutService(this.StripeClient);
            Payout payout = await service.CancelAsync("po_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payouts/po_xxxxxxxxxxxxx/cancel");
        }

        [Fact]
        public void TestPayoutsGet()
        {
            var options = new PayoutListOptions { Limit = 3 };
            var service = new PayoutService(this.StripeClient);
            StripeList<Payout> payouts = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/payouts", "limit=3");
        }

        [Fact]
        public async Task TestPayoutsGetAsync()
        {
            var options = new PayoutListOptions { Limit = 3 };
            var service = new PayoutService(this.StripeClient);
            StripeList<Payout> payouts = await service.ListAsync(options);
            this.AssertRequest(HttpMethod.Get, "/v1/payouts", "limit=3");
        }

        [Fact]
        public void TestPayoutsGetAutoPaging()
        {
            var options = new PayoutListOptions { Limit = 3 };
            var service = new PayoutService(this.StripeClient);
            var payout = service.ListAutoPaging(options).First();
            this.AssertRequest(HttpMethod.Get, "/v1/payouts", "limit=3");
        }

        [Fact]
        public async Task TestPayoutsGetAutoPagingAsync()
        {
            var options = new PayoutListOptions { Limit = 3 };
            var service = new PayoutService(this.StripeClient);
            var payout = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/payouts", "limit=3");
        }

        [Fact]
        public void TestPayoutsGet2()
        {
            var service = new PayoutService(this.StripeClient);
            Payout payout = service.Get("po_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/payouts/po_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestPayoutsGet2Async()
        {
            var service = new PayoutService(this.StripeClient);
            Payout payout = await service.GetAsync("po_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/payouts/po_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPayoutsPost()
        {
            var options = new PayoutCreateOptions
            {
                Amount = 1100,
                Currency = "usd",
            };
            var service = new PayoutService(this.StripeClient);
            Payout payout = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/payouts");
        }

        [Fact]
        public async Task TestPayoutsPostAsync()
        {
            var options = new PayoutCreateOptions
            {
                Amount = 1100,
                Currency = "usd",
            };
            var service = new PayoutService(this.StripeClient);
            Payout payout = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/payouts");
        }

        [Fact]
        public void TestPayoutsPost2()
        {
            var options = new PayoutUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new PayoutService(this.StripeClient);
            Payout payout = service.Update("po_xxxxxxxxxxxxx", options);
            this.AssertRequest(HttpMethod.Post, "/v1/payouts/po_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestPayoutsPost2Async()
        {
            var options = new PayoutUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new PayoutService(this.StripeClient);
            Payout payout = await service.UpdateAsync(
                "po_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(HttpMethod.Post, "/v1/payouts/po_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPayoutsReversePost()
        {
            var service = new PayoutService(this.StripeClient);
            Payout payout = service.Reverse("po_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payouts/po_xxxxxxxxxxxxx/reverse");
        }

        [Fact]
        public async Task TestPayoutsReversePostAsync()
        {
            var service = new PayoutService(this.StripeClient);
            Payout payout = await service.ReverseAsync("po_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payouts/po_xxxxxxxxxxxxx/reverse");
        }

        [Fact]
        public void TestPlansDelete()
        {
            var service = new PlanService(this.StripeClient);
            Plan deleted = service.Delete("price_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/plans/price_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestPlansDeleteAsync()
        {
            var service = new PlanService(this.StripeClient);
            Plan deleted = await service.DeleteAsync("price_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/plans/price_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPlansGet()
        {
            var options = new PlanListOptions { Limit = 3 };
            var service = new PlanService(this.StripeClient);
            StripeList<Plan> plans = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/plans", "limit=3");
        }

        [Fact]
        public async Task TestPlansGetAsync()
        {
            var options = new PlanListOptions { Limit = 3 };
            var service = new PlanService(this.StripeClient);
            StripeList<Plan> plans = await service.ListAsync(options);
            this.AssertRequest(HttpMethod.Get, "/v1/plans", "limit=3");
        }

        [Fact]
        public void TestPlansGetAutoPaging()
        {
            var options = new PlanListOptions { Limit = 3 };
            var service = new PlanService(this.StripeClient);
            var plan = service.ListAutoPaging(options).First();
            this.AssertRequest(HttpMethod.Get, "/v1/plans", "limit=3");
        }

        [Fact]
        public async Task TestPlansGetAutoPagingAsync()
        {
            var options = new PlanListOptions { Limit = 3 };
            var service = new PlanService(this.StripeClient);
            var plan = await service.ListAutoPagingAsync(options).FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/plans", "limit=3");
        }

        [Fact]
        public void TestPlansGet2()
        {
            var service = new PlanService(this.StripeClient);
            Plan plan = service.Get("price_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/plans/price_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestPlansGet2Async()
        {
            var service = new PlanService(this.StripeClient);
            Plan plan = await service.GetAsync("price_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/plans/price_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPlansPost()
        {
            var options = new PlanCreateOptions
            {
                Amount = 2000,
                Currency = "usd",
                Interval = "month",
                Product = "prod_xxxxxxxxxxxxx",
            };
            var service = new PlanService(this.StripeClient);
            Plan plan = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/plans");
        }

        [Fact]
        public async Task TestPlansPostAsync()
        {
            var options = new PlanCreateOptions
            {
                Amount = 2000,
                Currency = "usd",
                Interval = "month",
                Product = "prod_xxxxxxxxxxxxx",
            };
            var service = new PlanService(this.StripeClient);
            Plan plan = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/plans");
        }

        [Fact]
        public void TestPlansPost2()
        {
            var options = new PlanCreateOptions
            {
                Amount = 2000,
                Currency = "usd",
                Interval = "month",
                Product = new PlanProductOptions { Name = "My product" },
            };
            var service = new PlanService(this.StripeClient);
            Plan plan = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/plans");
        }

        [Fact]
        public async Task TestPlansPost2Async()
        {
            var options = new PlanCreateOptions
            {
                Amount = 2000,
                Currency = "usd",
                Interval = "month",
                Product = new PlanProductOptions { Name = "My product" },
            };
            var service = new PlanService(this.StripeClient);
            Plan plan = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/plans");
        }

        [Fact]
        public void TestPlansPost3()
        {
            var options = new PlanUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new PlanService(this.StripeClient);
            Plan plan = service.Update("price_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/plans/price_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestPlansPost3Async()
        {
            var options = new PlanUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new PlanService(this.StripeClient);
            Plan plan = await service.UpdateAsync(
                "price_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/plans/price_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPricesGet()
        {
            var options = new PriceListOptions { Limit = 3 };
            var service = new PriceService(this.StripeClient);
            StripeList<Price> prices = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/prices", "limit=3");
        }

        [Fact]
        public async Task TestPricesGetAsync()
        {
            var options = new PriceListOptions { Limit = 3 };
            var service = new PriceService(this.StripeClient);
            StripeList<Price> prices = await service.ListAsync(options);
            this.AssertRequest(HttpMethod.Get, "/v1/prices", "limit=3");
        }

        [Fact]
        public void TestPricesGetAutoPaging()
        {
            var options = new PriceListOptions { Limit = 3 };
            var service = new PriceService(this.StripeClient);
            var price = service.ListAutoPaging(options).First();
            this.AssertRequest(HttpMethod.Get, "/v1/prices", "limit=3");
        }

        [Fact]
        public async Task TestPricesGetAutoPagingAsync()
        {
            var options = new PriceListOptions { Limit = 3 };
            var service = new PriceService(this.StripeClient);
            var price = await service.ListAutoPagingAsync(options).FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/prices", "limit=3");
        }

        [Fact]
        public void TestPricesGet2()
        {
            var service = new PriceService(this.StripeClient);
            Price price = service.Get("price_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/prices/price_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestPricesGet2Async()
        {
            var service = new PriceService(this.StripeClient);
            Price price = await service.GetAsync("price_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/prices/price_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPricesPost()
        {
            var options = new PriceCreateOptions
            {
                UnitAmount = 2000,
                Currency = "usd",
                CurrencyOptions = new Dictionary<string, PriceCurrencyOptionsOptions>
                {
                    {
                        "uah", new PriceCurrencyOptionsOptions
                        {
                            UnitAmount = 5000,
                        }
                    },
                    {
                        "eur", new PriceCurrencyOptionsOptions
                        {
                            UnitAmount = 1800,
                        }
                    },
                },
                Recurring = new PriceRecurringOptions { Interval = "month" },
                Product = "prod_xxxxxxxxxxxxx",
            };
            var service = new PriceService(this.StripeClient);
            Price price = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/prices");
        }

        [Fact]
        public async Task TestPricesPostAsync()
        {
            var options = new PriceCreateOptions
            {
                UnitAmount = 2000,
                Currency = "usd",
                CurrencyOptions = new Dictionary<string, PriceCurrencyOptionsOptions>
                {
                    {
                        "uah", new PriceCurrencyOptionsOptions
                        {
                            UnitAmount = 5000,
                        }
                    },
                    {
                        "eur", new PriceCurrencyOptionsOptions
                        {
                            UnitAmount = 1800,
                        }
                    },
                },
                Recurring = new PriceRecurringOptions { Interval = "month" },
                Product = "prod_xxxxxxxxxxxxx",
            };
            var service = new PriceService(this.StripeClient);
            Price price = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/prices");
        }

        [Fact]
        public void TestPricesPost2()
        {
            var options = new PriceCreateOptions
            {
                UnitAmount = 2000,
                Currency = "usd",
                Recurring = new PriceRecurringOptions { Interval = "month" },
                Product = "prod_xxxxxxxxxxxxx",
            };
            var service = new PriceService(this.StripeClient);
            Price price = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/prices");
        }

        [Fact]
        public async Task TestPricesPost2Async()
        {
            var options = new PriceCreateOptions
            {
                UnitAmount = 2000,
                Currency = "usd",
                Recurring = new PriceRecurringOptions { Interval = "month" },
                Product = "prod_xxxxxxxxxxxxx",
            };
            var service = new PriceService(this.StripeClient);
            Price price = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/prices");
        }

        [Fact]
        public void TestPricesPost3()
        {
            var options = new PriceUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new PriceService(this.StripeClient);
            Price price = service.Update("price_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/prices/price_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestPricesPost3Async()
        {
            var options = new PriceUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new PriceService(this.StripeClient);
            Price price = await service.UpdateAsync(
                "price_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/prices/price_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPricesSearchGet()
        {
            var options = new PriceSearchOptions
            {
                Query = "active:'true' AND metadata['order_id']:'6735'",
            };
            var service = new PriceService(this.StripeClient);
            StripeSearchResult<Price> prices = service.Search(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/prices/search",
                "query=active%3A%27true%27%20AND%20metadata%5B%27order_id%27%5D%3A%276735%27");
        }

        [Fact]
        public async Task TestPricesSearchGetAsync()
        {
            var options = new PriceSearchOptions
            {
                Query = "active:'true' AND metadata['order_id']:'6735'",
            };
            var service = new PriceService(this.StripeClient);
            StripeSearchResult<Price> prices = await service.SearchAsync(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/prices/search",
                "query=active%3A%27true%27%20AND%20metadata%5B%27order_id%27%5D%3A%276735%27");
        }

        [Fact]
        public void TestPricesSearchGetAutoPaging()
        {
            var options = new PriceSearchOptions
            {
                Query = "active:'true' AND metadata['order_id']:'6735'",
            };
            var service = new PriceService(this.StripeClient);
            var price = service.SearchAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/prices/search",
                "query=active%3A%27true%27%20AND%20metadata%5B%27order_id%27%5D%3A%276735%27");
        }

        [Fact]
        public async Task TestPricesSearchGetAutoPagingAsync()
        {
            var options = new PriceSearchOptions
            {
                Query = "active:'true' AND metadata['order_id']:'6735'",
            };
            var service = new PriceService(this.StripeClient);
            var price = await service.SearchAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/prices/search",
                "query=active%3A%27true%27%20AND%20metadata%5B%27order_id%27%5D%3A%276735%27");
        }

        [Fact]
        public void TestProductsDelete()
        {
            var service = new ProductService(this.StripeClient);
            Product deleted = service.Delete("prod_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/products/prod_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestProductsDeleteAsync()
        {
            var service = new ProductService(this.StripeClient);
            Product deleted = await service.DeleteAsync("prod_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/products/prod_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestProductsGet()
        {
            var options = new ProductListOptions { Limit = 3 };
            var service = new ProductService(this.StripeClient);
            StripeList<Product> products = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/products", "limit=3");
        }

        [Fact]
        public async Task TestProductsGetAsync()
        {
            var options = new ProductListOptions { Limit = 3 };
            var service = new ProductService(this.StripeClient);
            StripeList<Product> products = await service.ListAsync(options);
            this.AssertRequest(HttpMethod.Get, "/v1/products", "limit=3");
        }

        [Fact]
        public void TestProductsGetAutoPaging()
        {
            var options = new ProductListOptions { Limit = 3 };
            var service = new ProductService(this.StripeClient);
            var product = service.ListAutoPaging(options).First();
            this.AssertRequest(HttpMethod.Get, "/v1/products", "limit=3");
        }

        [Fact]
        public async Task TestProductsGetAutoPagingAsync()
        {
            var options = new ProductListOptions { Limit = 3 };
            var service = new ProductService(this.StripeClient);
            var product = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/products", "limit=3");
        }

        [Fact]
        public void TestProductsGet2()
        {
            var service = new ProductService(this.StripeClient);
            Product product = service.Get("prod_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/products/prod_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestProductsGet2Async()
        {
            var service = new ProductService(this.StripeClient);
            Product product = await service.GetAsync("prod_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/products/prod_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestProductsPost()
        {
            var options = new ProductCreateOptions { Name = "Gold Special" };
            var service = new ProductService(this.StripeClient);
            Product product = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/products");
        }

        [Fact]
        public async Task TestProductsPostAsync()
        {
            var options = new ProductCreateOptions { Name = "Gold Special" };
            var service = new ProductService(this.StripeClient);
            Product product = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/products");
        }

        [Fact]
        public void TestProductsPost2()
        {
            var options = new ProductUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new ProductService(this.StripeClient);
            Product product = service.Update("prod_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/products/prod_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestProductsPost2Async()
        {
            var options = new ProductUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new ProductService(this.StripeClient);
            Product product = await service.UpdateAsync(
                "prod_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/products/prod_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestProductsSearchGet()
        {
            var options = new ProductSearchOptions
            {
                Query = "active:'true' AND metadata['order_id']:'6735'",
            };
            var service = new ProductService(this.StripeClient);
            StripeSearchResult<Product> products = service.Search(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/products/search",
                "query=active%3A%27true%27%20AND%20metadata%5B%27order_id%27%5D%3A%276735%27");
        }

        [Fact]
        public async Task TestProductsSearchGetAsync()
        {
            var options = new ProductSearchOptions
            {
                Query = "active:'true' AND metadata['order_id']:'6735'",
            };
            var service = new ProductService(this.StripeClient);
            StripeSearchResult<Product> products = await service.SearchAsync(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/products/search",
                "query=active%3A%27true%27%20AND%20metadata%5B%27order_id%27%5D%3A%276735%27");
        }

        [Fact]
        public void TestProductsSearchGetAutoPaging()
        {
            var options = new ProductSearchOptions
            {
                Query = "active:'true' AND metadata['order_id']:'6735'",
            };
            var service = new ProductService(this.StripeClient);
            var product = service.SearchAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/products/search",
                "query=active%3A%27true%27%20AND%20metadata%5B%27order_id%27%5D%3A%276735%27");
        }

        [Fact]
        public async Task TestProductsSearchGetAutoPagingAsync()
        {
            var options = new ProductSearchOptions
            {
                Query = "active:'true' AND metadata['order_id']:'6735'",
            };
            var service = new ProductService(this.StripeClient);
            var product = await service.SearchAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/products/search",
                "query=active%3A%27true%27%20AND%20metadata%5B%27order_id%27%5D%3A%276735%27");
        }

        [Fact]
        public void TestPromotionCodesGet()
        {
            var options = new PromotionCodeListOptions { Limit = 3 };
            var service = new PromotionCodeService(this.StripeClient);
            StripeList<PromotionCode> promotionCodes = service.List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/promotion_codes",
                "limit=3");
        }

        [Fact]
        public async Task TestPromotionCodesGetAsync()
        {
            var options = new PromotionCodeListOptions { Limit = 3 };
            var service = new PromotionCodeService(this.StripeClient);
            StripeList<PromotionCode> promotionCodes = await service.ListAsync(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/promotion_codes",
                "limit=3");
        }

        [Fact]
        public void TestPromotionCodesGetAutoPaging()
        {
            var options = new PromotionCodeListOptions { Limit = 3 };
            var service = new PromotionCodeService(this.StripeClient);
            var promotionCode = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/promotion_codes",
                "limit=3");
        }

        [Fact]
        public async Task TestPromotionCodesGetAutoPagingAsync()
        {
            var options = new PromotionCodeListOptions { Limit = 3 };
            var service = new PromotionCodeService(this.StripeClient);
            var promotionCode = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/promotion_codes",
                "limit=3");
        }

        [Fact]
        public void TestPromotionCodesGet2()
        {
            var service = new PromotionCodeService(this.StripeClient);
            PromotionCode promotionCode = service.Get("promo_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/promotion_codes/promo_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestPromotionCodesGet2Async()
        {
            var service = new PromotionCodeService(this.StripeClient);
            PromotionCode promotionCode = await service.GetAsync(
                "promo_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/promotion_codes/promo_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPromotionCodesPost()
        {
            var options = new PromotionCodeCreateOptions
            {
                Promotion = new PromotionCodePromotionOptions
                {
                    Type = "coupon",
                    Coupon = "Z4OV52SU",
                },
            };
            var service = new PromotionCodeService(this.StripeClient);
            PromotionCode promotionCode = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/promotion_codes");
        }

        [Fact]
        public async Task TestPromotionCodesPostAsync()
        {
            var options = new PromotionCodeCreateOptions
            {
                Promotion = new PromotionCodePromotionOptions
                {
                    Type = "coupon",
                    Coupon = "Z4OV52SU",
                },
            };
            var service = new PromotionCodeService(this.StripeClient);
            PromotionCode promotionCode = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/promotion_codes");
        }

        [Fact]
        public void TestPromotionCodesPost2()
        {
            var options = new PromotionCodeUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new PromotionCodeService(this.StripeClient);
            PromotionCode promotionCode = service.Update(
                "promo_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/promotion_codes/promo_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestPromotionCodesPost2Async()
        {
            var options = new PromotionCodeUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new PromotionCodeService(this.StripeClient);
            PromotionCode promotionCode = await service.UpdateAsync(
                "promo_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/promotion_codes/promo_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestQuotesAcceptPost()
        {
            var service = new QuoteService(this.StripeClient);
            Quote quote = service.Accept("qt_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/quotes/qt_xxxxxxxxxxxxx/accept");
        }

        [Fact]
        public async Task TestQuotesAcceptPostAsync()
        {
            var service = new QuoteService(this.StripeClient);
            Quote quote = await service.AcceptAsync("qt_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/quotes/qt_xxxxxxxxxxxxx/accept");
        }

        [Fact]
        public void TestQuotesCancelPost()
        {
            var service = new QuoteService(this.StripeClient);
            Quote quote = service.Cancel("qt_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/quotes/qt_xxxxxxxxxxxxx/cancel");
        }

        [Fact]
        public async Task TestQuotesCancelPostAsync()
        {
            var service = new QuoteService(this.StripeClient);
            Quote quote = await service.CancelAsync("qt_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/quotes/qt_xxxxxxxxxxxxx/cancel");
        }

        [Fact]
        public void TestQuotesFinalizePost()
        {
            var service = new QuoteService(this.StripeClient);
            Quote quote = service.FinalizeQuote("qt_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/quotes/qt_xxxxxxxxxxxxx/finalize");
        }

        [Fact]
        public async Task TestQuotesFinalizePostAsync()
        {
            var service = new QuoteService(this.StripeClient);
            Quote quote = await service.FinalizeQuoteAsync("qt_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/quotes/qt_xxxxxxxxxxxxx/finalize");
        }

        [Fact]
        public void TestQuotesGet()
        {
            var options = new QuoteListOptions { Limit = 3 };
            var service = new QuoteService(this.StripeClient);
            StripeList<Quote> quotes = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/quotes", "limit=3");
        }

        [Fact]
        public async Task TestQuotesGetAsync()
        {
            var options = new QuoteListOptions { Limit = 3 };
            var service = new QuoteService(this.StripeClient);
            StripeList<Quote> quotes = await service.ListAsync(options);
            this.AssertRequest(HttpMethod.Get, "/v1/quotes", "limit=3");
        }

        [Fact]
        public void TestQuotesGetAutoPaging()
        {
            var options = new QuoteListOptions { Limit = 3 };
            var service = new QuoteService(this.StripeClient);
            var quote = service.ListAutoPaging(options).First();
            this.AssertRequest(HttpMethod.Get, "/v1/quotes", "limit=3");
        }

        [Fact]
        public async Task TestQuotesGetAutoPagingAsync()
        {
            var options = new QuoteListOptions { Limit = 3 };
            var service = new QuoteService(this.StripeClient);
            var quote = await service.ListAutoPagingAsync(options).FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/quotes", "limit=3");
        }

        [Fact]
        public void TestQuotesGet2()
        {
            var service = new QuoteService(this.StripeClient);
            Quote quote = service.Get("qt_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/quotes/qt_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestQuotesGet2Async()
        {
            var service = new QuoteService(this.StripeClient);
            Quote quote = await service.GetAsync("qt_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/quotes/qt_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestQuotesLineItemsGet()
        {
            var service = new QuoteLineItemService(this.StripeClient);
            StripeList<LineItem> lineItems = service.List("qt_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/quotes/qt_xxxxxxxxxxxxx/line_items");
        }

        [Fact]
        public async Task TestQuotesLineItemsGetAsync()
        {
            var service = new QuoteLineItemService(this.StripeClient);
            StripeList<LineItem> lineItems = await service.ListAsync(
                "qt_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/quotes/qt_xxxxxxxxxxxxx/line_items");
        }

        [Fact]
        public void TestQuotesLineItemsGetAutoPaging()
        {
            var service = new QuoteLineItemService(this.StripeClient);
            var lineItem = service.ListAutoPaging("qt_xxxxxxxxxxxxx").First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/quotes/qt_xxxxxxxxxxxxx/line_items");
        }

        [Fact]
        public async Task TestQuotesLineItemsGetAutoPagingAsync()
        {
            var service = new QuoteLineItemService(this.StripeClient);
            var lineItem = await service.ListAutoPagingAsync("qt_xxxxxxxxxxxxx")
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/quotes/qt_xxxxxxxxxxxxx/line_items");
        }

        [Fact]
        public void TestQuotesPdfGet()
        {
            var service = new QuoteService(this.StripeClient);
            System.IO.Stream stream = service.Pdf("qt_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/quotes/qt_xxxxxxxxxxxxx/pdf");
        }

        [Fact]
        public async Task TestQuotesPdfGetAsync()
        {
            var service = new QuoteService(this.StripeClient);
            System.IO.Stream stream = await service.PdfAsync(
                "qt_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/quotes/qt_xxxxxxxxxxxxx/pdf");
        }

        [Fact]
        public void TestQuotesPost()
        {
            var options = new QuoteCreateOptions
            {
                Customer = "cus_xxxxxxxxxxxxx",
                LineItems = new List<QuoteLineItemOptions>
                {
                    new QuoteLineItemOptions
                    {
                        Price = "price_xxxxxxxxxxxxx",
                        Quantity = 2,
                    },
                },
            };
            var service = new QuoteService(this.StripeClient);
            Quote quote = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/quotes");
        }

        [Fact]
        public async Task TestQuotesPostAsync()
        {
            var options = new QuoteCreateOptions
            {
                Customer = "cus_xxxxxxxxxxxxx",
                LineItems = new List<QuoteLineItemOptions>
                {
                    new QuoteLineItemOptions
                    {
                        Price = "price_xxxxxxxxxxxxx",
                        Quantity = 2,
                    },
                },
            };
            var service = new QuoteService(this.StripeClient);
            Quote quote = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/quotes");
        }

        [Fact]
        public void TestQuotesPost2()
        {
            var options = new QuoteUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new QuoteService(this.StripeClient);
            Quote quote = service.Update("qt_xxxxxxxxxxxxx", options);
            this.AssertRequest(HttpMethod.Post, "/v1/quotes/qt_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestQuotesPost2Async()
        {
            var options = new QuoteUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new QuoteService(this.StripeClient);
            Quote quote = await service.UpdateAsync(
                "qt_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(HttpMethod.Post, "/v1/quotes/qt_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestRadarEarlyFraudWarningsGet()
        {
            var options = new Stripe.Radar.EarlyFraudWarningListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Radar.EarlyFraudWarningService(
                this.StripeClient);
            StripeList<Stripe.Radar.EarlyFraudWarning> earlyFraudWarnings = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/radar/early_fraud_warnings",
                "limit=3");
        }

        [Fact]
        public async Task TestRadarEarlyFraudWarningsGetAsync()
        {
            var options = new Stripe.Radar.EarlyFraudWarningListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Radar.EarlyFraudWarningService(
                this.StripeClient);
            StripeList<Stripe.Radar.EarlyFraudWarning> earlyFraudWarnings = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/radar/early_fraud_warnings",
                "limit=3");
        }

        [Fact]
        public void TestRadarEarlyFraudWarningsGetAutoPaging()
        {
            var options = new Stripe.Radar.EarlyFraudWarningListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Radar.EarlyFraudWarningService(
                this.StripeClient);
            var earlyFraudWarning = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/radar/early_fraud_warnings",
                "limit=3");
        }

        [Fact]
        public async Task TestRadarEarlyFraudWarningsGetAutoPagingAsync()
        {
            var options = new Stripe.Radar.EarlyFraudWarningListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Radar.EarlyFraudWarningService(
                this.StripeClient);
            var earlyFraudWarning = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/radar/early_fraud_warnings",
                "limit=3");
        }

        [Fact]
        public void TestRadarEarlyFraudWarningsGet2()
        {
            var service = new Stripe.Radar.EarlyFraudWarningService(
                this.StripeClient);
            Stripe.Radar.EarlyFraudWarning earlyFraudWarning = service.Get(
                "issfr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/radar/early_fraud_warnings/issfr_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestRadarEarlyFraudWarningsGet2Async()
        {
            var service = new Stripe.Radar.EarlyFraudWarningService(
                this.StripeClient);
            Stripe.Radar.EarlyFraudWarning earlyFraudWarning = await service
                .GetAsync("issfr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/radar/early_fraud_warnings/issfr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestRadarValueListItemsDelete()
        {
            var service = new Stripe.Radar.ValueListItemService(
                this.StripeClient);
            Stripe.Radar.ValueListItem deleted = service.Delete(
                "rsli_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/radar/value_list_items/rsli_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestRadarValueListItemsDeleteAsync()
        {
            var service = new Stripe.Radar.ValueListItemService(
                this.StripeClient);
            Stripe.Radar.ValueListItem deleted = await service.DeleteAsync(
                "rsli_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/radar/value_list_items/rsli_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestRadarValueListItemsGet()
        {
            var options = new Stripe.Radar.ValueListItemListOptions
            {
                Limit = 3,
                ValueList = "rsl_xxxxxxxxxxxxx",
            };
            var service = new Stripe.Radar.ValueListItemService(
                this.StripeClient);
            StripeList<Stripe.Radar.ValueListItem> valueListItems = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/radar/value_list_items",
                "limit=3&value_list=rsl_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestRadarValueListItemsGetAsync()
        {
            var options = new Stripe.Radar.ValueListItemListOptions
            {
                Limit = 3,
                ValueList = "rsl_xxxxxxxxxxxxx",
            };
            var service = new Stripe.Radar.ValueListItemService(
                this.StripeClient);
            StripeList<Stripe.Radar.ValueListItem> valueListItems = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/radar/value_list_items",
                "limit=3&value_list=rsl_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestRadarValueListItemsGetAutoPaging()
        {
            var options = new Stripe.Radar.ValueListItemListOptions
            {
                Limit = 3,
                ValueList = "rsl_xxxxxxxxxxxxx",
            };
            var service = new Stripe.Radar.ValueListItemService(
                this.StripeClient);
            var valueListItem = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/radar/value_list_items",
                "limit=3&value_list=rsl_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestRadarValueListItemsGetAutoPagingAsync()
        {
            var options = new Stripe.Radar.ValueListItemListOptions
            {
                Limit = 3,
                ValueList = "rsl_xxxxxxxxxxxxx",
            };
            var service = new Stripe.Radar.ValueListItemService(
                this.StripeClient);
            var valueListItem = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/radar/value_list_items",
                "limit=3&value_list=rsl_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestRadarValueListItemsGet2()
        {
            var service = new Stripe.Radar.ValueListItemService(
                this.StripeClient);
            Stripe.Radar.ValueListItem valueListItem = service.Get(
                "rsli_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/radar/value_list_items/rsli_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestRadarValueListItemsGet2Async()
        {
            var service = new Stripe.Radar.ValueListItemService(
                this.StripeClient);
            Stripe.Radar.ValueListItem valueListItem = await service.GetAsync(
                "rsli_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/radar/value_list_items/rsli_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestRadarValueListItemsPost()
        {
            var options = new Stripe.Radar.ValueListItemCreateOptions
            {
                ValueList = "rsl_xxxxxxxxxxxxx",
                Value = "1.2.3.4",
            };
            var service = new Stripe.Radar.ValueListItemService(
                this.StripeClient);
            Stripe.Radar.ValueListItem valueListItem = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/radar/value_list_items");
        }

        [Fact]
        public async Task TestRadarValueListItemsPostAsync()
        {
            var options = new Stripe.Radar.ValueListItemCreateOptions
            {
                ValueList = "rsl_xxxxxxxxxxxxx",
                Value = "1.2.3.4",
            };
            var service = new Stripe.Radar.ValueListItemService(
                this.StripeClient);
            Stripe.Radar.ValueListItem valueListItem = await service
                .CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/radar/value_list_items");
        }

        [Fact]
        public void TestRadarValueListsDelete()
        {
            var service = new Stripe.Radar.ValueListService(this.StripeClient);
            Stripe.Radar.ValueList deleted = service.Delete(
                "rsl_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/radar/value_lists/rsl_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestRadarValueListsDeleteAsync()
        {
            var service = new Stripe.Radar.ValueListService(this.StripeClient);
            Stripe.Radar.ValueList deleted = await service.DeleteAsync(
                "rsl_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/radar/value_lists/rsl_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestRadarValueListsGet()
        {
            var options = new Stripe.Radar.ValueListListOptions { Limit = 3 };
            var service = new Stripe.Radar.ValueListService(this.StripeClient);
            StripeList<Stripe.Radar.ValueList> valueLists = service.List(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/radar/value_lists",
                "limit=3");
        }

        [Fact]
        public async Task TestRadarValueListsGetAsync()
        {
            var options = new Stripe.Radar.ValueListListOptions { Limit = 3 };
            var service = new Stripe.Radar.ValueListService(this.StripeClient);
            StripeList<Stripe.Radar.ValueList> valueLists = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/radar/value_lists",
                "limit=3");
        }

        [Fact]
        public void TestRadarValueListsGetAutoPaging()
        {
            var options = new Stripe.Radar.ValueListListOptions { Limit = 3 };
            var service = new Stripe.Radar.ValueListService(this.StripeClient);
            var valueList = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/radar/value_lists",
                "limit=3");
        }

        [Fact]
        public async Task TestRadarValueListsGetAutoPagingAsync()
        {
            var options = new Stripe.Radar.ValueListListOptions { Limit = 3 };
            var service = new Stripe.Radar.ValueListService(this.StripeClient);
            var valueList = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/radar/value_lists",
                "limit=3");
        }

        [Fact]
        public void TestRadarValueListsGet2()
        {
            var service = new Stripe.Radar.ValueListService(this.StripeClient);
            Stripe.Radar.ValueList valueList = service.Get("rsl_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/radar/value_lists/rsl_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestRadarValueListsGet2Async()
        {
            var service = new Stripe.Radar.ValueListService(this.StripeClient);
            Stripe.Radar.ValueList valueList = await service.GetAsync(
                "rsl_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/radar/value_lists/rsl_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestRadarValueListsPost()
        {
            var options = new Stripe.Radar.ValueListCreateOptions
            {
                Alias = "custom_ip_xxxxxxxxxxxxx",
                Name = "Custom IP Blocklist",
                ItemType = "ip_address",
            };
            var service = new Stripe.Radar.ValueListService(this.StripeClient);
            Stripe.Radar.ValueList valueList = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/radar/value_lists");
        }

        [Fact]
        public async Task TestRadarValueListsPostAsync()
        {
            var options = new Stripe.Radar.ValueListCreateOptions
            {
                Alias = "custom_ip_xxxxxxxxxxxxx",
                Name = "Custom IP Blocklist",
                ItemType = "ip_address",
            };
            var service = new Stripe.Radar.ValueListService(this.StripeClient);
            Stripe.Radar.ValueList valueList = await service.CreateAsync(
                options);
            this.AssertRequest(HttpMethod.Post, "/v1/radar/value_lists");
        }

        [Fact]
        public void TestRadarValueListsPost2()
        {
            var options = new Stripe.Radar.ValueListUpdateOptions
            {
                Name = "Updated IP Block List",
            };
            var service = new Stripe.Radar.ValueListService(this.StripeClient);
            Stripe.Radar.ValueList valueList = service.Update(
                "rsl_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/radar/value_lists/rsl_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestRadarValueListsPost2Async()
        {
            var options = new Stripe.Radar.ValueListUpdateOptions
            {
                Name = "Updated IP Block List",
            };
            var service = new Stripe.Radar.ValueListService(this.StripeClient);
            Stripe.Radar.ValueList valueList = await service.UpdateAsync(
                "rsl_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/radar/value_lists/rsl_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestRefundsCancelPost()
        {
            var service = new RefundService(this.StripeClient);
            Refund refund = service.Cancel("re_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/refunds/re_xxxxxxxxxxxxx/cancel");
        }

        [Fact]
        public async Task TestRefundsCancelPostAsync()
        {
            var service = new RefundService(this.StripeClient);
            Refund refund = await service.CancelAsync("re_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/refunds/re_xxxxxxxxxxxxx/cancel");
        }

        [Fact]
        public void TestRefundsGet()
        {
            var options = new RefundListOptions { Limit = 3 };
            var service = new RefundService(this.StripeClient);
            StripeList<Refund> refunds = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/refunds", "limit=3");
        }

        [Fact]
        public async Task TestRefundsGetAsync()
        {
            var options = new RefundListOptions { Limit = 3 };
            var service = new RefundService(this.StripeClient);
            StripeList<Refund> refunds = await service.ListAsync(options);
            this.AssertRequest(HttpMethod.Get, "/v1/refunds", "limit=3");
        }

        [Fact]
        public void TestRefundsGetAutoPaging()
        {
            var options = new RefundListOptions { Limit = 3 };
            var service = new RefundService(this.StripeClient);
            var refund = service.ListAutoPaging(options).First();
            this.AssertRequest(HttpMethod.Get, "/v1/refunds", "limit=3");
        }

        [Fact]
        public async Task TestRefundsGetAutoPagingAsync()
        {
            var options = new RefundListOptions { Limit = 3 };
            var service = new RefundService(this.StripeClient);
            var refund = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/refunds", "limit=3");
        }

        [Fact]
        public void TestRefundsGet2()
        {
            var service = new RefundService(this.StripeClient);
            Refund refund = service.Get("re_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/refunds/re_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestRefundsGet2Async()
        {
            var service = new RefundService(this.StripeClient);
            Refund refund = await service.GetAsync("re_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/refunds/re_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestRefundsPost()
        {
            var options = new RefundCreateOptions
            {
                Charge = "ch_xxxxxxxxxxxxx",
            };
            var service = new RefundService(this.StripeClient);
            Refund refund = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/refunds");
        }

        [Fact]
        public async Task TestRefundsPostAsync()
        {
            var options = new RefundCreateOptions
            {
                Charge = "ch_xxxxxxxxxxxxx",
            };
            var service = new RefundService(this.StripeClient);
            Refund refund = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/refunds");
        }

        [Fact]
        public void TestRefundsPost2()
        {
            var options = new RefundUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new RefundService(this.StripeClient);
            Refund refund = service.Update("re_xxxxxxxxxxxxx", options);
            this.AssertRequest(HttpMethod.Post, "/v1/refunds/re_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestRefundsPost2Async()
        {
            var options = new RefundUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new RefundService(this.StripeClient);
            Refund refund = await service.UpdateAsync(
                "re_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(HttpMethod.Post, "/v1/refunds/re_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestReportingReportRunsGet()
        {
            var options = new Stripe.Reporting.ReportRunListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Reporting.ReportRunService(
                this.StripeClient);
            StripeList<Stripe.Reporting.ReportRun> reportRuns = service.List(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/reporting/report_runs",
                "limit=3");
        }

        [Fact]
        public async Task TestReportingReportRunsGetAsync()
        {
            var options = new Stripe.Reporting.ReportRunListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Reporting.ReportRunService(
                this.StripeClient);
            StripeList<Stripe.Reporting.ReportRun> reportRuns = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/reporting/report_runs",
                "limit=3");
        }

        [Fact]
        public void TestReportingReportRunsGetAutoPaging()
        {
            var options = new Stripe.Reporting.ReportRunListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Reporting.ReportRunService(
                this.StripeClient);
            var reportRun = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/reporting/report_runs",
                "limit=3");
        }

        [Fact]
        public async Task TestReportingReportRunsGetAutoPagingAsync()
        {
            var options = new Stripe.Reporting.ReportRunListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Reporting.ReportRunService(
                this.StripeClient);
            var reportRun = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/reporting/report_runs",
                "limit=3");
        }

        [Fact]
        public void TestReportingReportRunsGet2()
        {
            var service = new Stripe.Reporting.ReportRunService(
                this.StripeClient);
            Stripe.Reporting.ReportRun reportRun = service.Get(
                "frr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/reporting/report_runs/frr_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestReportingReportRunsGet2Async()
        {
            var service = new Stripe.Reporting.ReportRunService(
                this.StripeClient);
            Stripe.Reporting.ReportRun reportRun = await service.GetAsync(
                "frr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/reporting/report_runs/frr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestReportingReportRunsPost()
        {
            var options = new Stripe.Reporting.ReportRunCreateOptions
            {
                ReportType = "balance.summary.1",
                Parameters = new Stripe.Reporting.ReportRunParametersOptions
                {
                    IntervalStart = DateTimeOffset.FromUnixTimeSeconds(
                        1522540800)
                        .UtcDateTime,
                    IntervalEnd = DateTimeOffset.FromUnixTimeSeconds(1525132800)
                        .UtcDateTime,
                },
            };
            var service = new Stripe.Reporting.ReportRunService(
                this.StripeClient);
            Stripe.Reporting.ReportRun reportRun = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/reporting/report_runs");
        }

        [Fact]
        public async Task TestReportingReportRunsPostAsync()
        {
            var options = new Stripe.Reporting.ReportRunCreateOptions
            {
                ReportType = "balance.summary.1",
                Parameters = new Stripe.Reporting.ReportRunParametersOptions
                {
                    IntervalStart = DateTimeOffset.FromUnixTimeSeconds(
                        1522540800)
                        .UtcDateTime,
                    IntervalEnd = DateTimeOffset.FromUnixTimeSeconds(1525132800)
                        .UtcDateTime,
                },
            };
            var service = new Stripe.Reporting.ReportRunService(
                this.StripeClient);
            Stripe.Reporting.ReportRun reportRun = await service.CreateAsync(
                options);
            this.AssertRequest(HttpMethod.Post, "/v1/reporting/report_runs");
        }

        [Fact]
        public void TestReportingReportTypesGet()
        {
            var service = new Stripe.Reporting.ReportTypeService(
                this.StripeClient);
            StripeList<Stripe.Reporting.ReportType> reportTypes = service
                .List();
            this.AssertRequest(HttpMethod.Get, "/v1/reporting/report_types");
        }

        [Fact]
        public async Task TestReportingReportTypesGetAsync()
        {
            var service = new Stripe.Reporting.ReportTypeService(
                this.StripeClient);
            StripeList<Stripe.Reporting.ReportType> reportTypes = await service
                .ListAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/reporting/report_types");
        }

        [Fact]
        public void TestReportingReportTypesGet2()
        {
            var service = new Stripe.Reporting.ReportTypeService(
                this.StripeClient);
            Stripe.Reporting.ReportType reportType = service.Get(
                "balance.summary.1");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/reporting/report_types/balance.summary.1");
        }

        [Fact]
        public async Task TestReportingReportTypesGet2Async()
        {
            var service = new Stripe.Reporting.ReportTypeService(
                this.StripeClient);
            Stripe.Reporting.ReportType reportType = await service.GetAsync(
                "balance.summary.1");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/reporting/report_types/balance.summary.1");
        }

        [Fact]
        public void TestReviewsApprovePost()
        {
            var service = new ReviewService(this.StripeClient);
            Review review = service.Approve("prv_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/reviews/prv_xxxxxxxxxxxxx/approve");
        }

        [Fact]
        public async Task TestReviewsApprovePostAsync()
        {
            var service = new ReviewService(this.StripeClient);
            Review review = await service.ApproveAsync("prv_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/reviews/prv_xxxxxxxxxxxxx/approve");
        }

        [Fact]
        public void TestReviewsGet()
        {
            var options = new ReviewListOptions { Limit = 3 };
            var service = new ReviewService(this.StripeClient);
            StripeList<Review> reviews = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/reviews", "limit=3");
        }

        [Fact]
        public async Task TestReviewsGetAsync()
        {
            var options = new ReviewListOptions { Limit = 3 };
            var service = new ReviewService(this.StripeClient);
            StripeList<Review> reviews = await service.ListAsync(options);
            this.AssertRequest(HttpMethod.Get, "/v1/reviews", "limit=3");
        }

        [Fact]
        public void TestReviewsGetAutoPaging()
        {
            var options = new ReviewListOptions { Limit = 3 };
            var service = new ReviewService(this.StripeClient);
            var review = service.ListAutoPaging(options).First();
            this.AssertRequest(HttpMethod.Get, "/v1/reviews", "limit=3");
        }

        [Fact]
        public async Task TestReviewsGetAutoPagingAsync()
        {
            var options = new ReviewListOptions { Limit = 3 };
            var service = new ReviewService(this.StripeClient);
            var review = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/reviews", "limit=3");
        }

        [Fact]
        public void TestReviewsGet2()
        {
            var service = new ReviewService(this.StripeClient);
            Review review = service.Get("prv_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/reviews/prv_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestReviewsGet2Async()
        {
            var service = new ReviewService(this.StripeClient);
            Review review = await service.GetAsync("prv_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/reviews/prv_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSetupAttemptsGet()
        {
            var options = new SetupAttemptListOptions
            {
                Limit = 3,
                SetupIntent = "si_xyz",
            };
            var service = new SetupAttemptService(this.StripeClient);
            StripeList<SetupAttempt> setupAttempts = service.List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/setup_attempts",
                "limit=3&setup_intent=si_xyz");
        }

        [Fact]
        public async Task TestSetupAttemptsGetAsync()
        {
            var options = new SetupAttemptListOptions
            {
                Limit = 3,
                SetupIntent = "si_xyz",
            };
            var service = new SetupAttemptService(this.StripeClient);
            StripeList<SetupAttempt> setupAttempts = await service.ListAsync(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/setup_attempts",
                "limit=3&setup_intent=si_xyz");
        }

        [Fact]
        public void TestSetupAttemptsGetAutoPaging()
        {
            var options = new SetupAttemptListOptions
            {
                Limit = 3,
                SetupIntent = "si_xyz",
            };
            var service = new SetupAttemptService(this.StripeClient);
            var setupAttempt = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/setup_attempts",
                "limit=3&setup_intent=si_xyz");
        }

        [Fact]
        public async Task TestSetupAttemptsGetAutoPagingAsync()
        {
            var options = new SetupAttemptListOptions
            {
                Limit = 3,
                SetupIntent = "si_xyz",
            };
            var service = new SetupAttemptService(this.StripeClient);
            var setupAttempt = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/setup_attempts",
                "limit=3&setup_intent=si_xyz");
        }

        [Fact]
        public void TestSetupIntentsCancelPost()
        {
            var service = new SetupIntentService(this.StripeClient);
            SetupIntent setupIntent = service.Cancel("seti_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/setup_intents/seti_xxxxxxxxxxxxx/cancel");
        }

        [Fact]
        public async Task TestSetupIntentsCancelPostAsync()
        {
            var service = new SetupIntentService(this.StripeClient);
            SetupIntent setupIntent = await service.CancelAsync(
                "seti_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/setup_intents/seti_xxxxxxxxxxxxx/cancel");
        }

        [Fact]
        public void TestSetupIntentsConfirmPost()
        {
            var options = new SetupIntentConfirmOptions
            {
                PaymentMethod = "pm_card_visa",
            };
            var service = new SetupIntentService(this.StripeClient);
            SetupIntent setupIntent = service.Confirm(
                "seti_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/setup_intents/seti_xxxxxxxxxxxxx/confirm");
        }

        [Fact]
        public async Task TestSetupIntentsConfirmPostAsync()
        {
            var options = new SetupIntentConfirmOptions
            {
                PaymentMethod = "pm_card_visa",
            };
            var service = new SetupIntentService(this.StripeClient);
            SetupIntent setupIntent = await service.ConfirmAsync(
                "seti_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/setup_intents/seti_xxxxxxxxxxxxx/confirm");
        }

        [Fact]
        public void TestSetupIntentsGet()
        {
            var options = new SetupIntentListOptions { Limit = 3 };
            var service = new SetupIntentService(this.StripeClient);
            StripeList<SetupIntent> setupIntents = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/setup_intents", "limit=3");
        }

        [Fact]
        public async Task TestSetupIntentsGetAsync()
        {
            var options = new SetupIntentListOptions { Limit = 3 };
            var service = new SetupIntentService(this.StripeClient);
            StripeList<SetupIntent> setupIntents = await service.ListAsync(
                options);
            this.AssertRequest(HttpMethod.Get, "/v1/setup_intents", "limit=3");
        }

        [Fact]
        public void TestSetupIntentsGetAutoPaging()
        {
            var options = new SetupIntentListOptions { Limit = 3 };
            var service = new SetupIntentService(this.StripeClient);
            var setupIntent = service.ListAutoPaging(options).First();
            this.AssertRequest(HttpMethod.Get, "/v1/setup_intents", "limit=3");
        }

        [Fact]
        public async Task TestSetupIntentsGetAutoPagingAsync()
        {
            var options = new SetupIntentListOptions { Limit = 3 };
            var service = new SetupIntentService(this.StripeClient);
            var setupIntent = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/setup_intents", "limit=3");
        }

        [Fact]
        public void TestSetupIntentsGet2()
        {
            var service = new SetupIntentService(this.StripeClient);
            SetupIntent setupIntent = service.Get("seti_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/setup_intents/seti_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestSetupIntentsGet2Async()
        {
            var service = new SetupIntentService(this.StripeClient);
            SetupIntent setupIntent = await service.GetAsync(
                "seti_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/setup_intents/seti_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSetupIntentsPost()
        {
            var options = new SetupIntentCreateOptions
            {
                PaymentMethodTypes = new List<string> { "card" },
            };
            var service = new SetupIntentService(this.StripeClient);
            SetupIntent setupIntent = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/setup_intents");
        }

        [Fact]
        public async Task TestSetupIntentsPostAsync()
        {
            var options = new SetupIntentCreateOptions
            {
                PaymentMethodTypes = new List<string> { "card" },
            };
            var service = new SetupIntentService(this.StripeClient);
            SetupIntent setupIntent = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/setup_intents");
        }

        [Fact]
        public void TestSetupIntentsPost2()
        {
            var options = new SetupIntentUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "user_id", "3435453" },
                },
            };
            var service = new SetupIntentService(this.StripeClient);
            SetupIntent setupIntent = service.Update(
                "seti_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/setup_intents/seti_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestSetupIntentsPost2Async()
        {
            var options = new SetupIntentUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "user_id", "3435453" },
                },
            };
            var service = new SetupIntentService(this.StripeClient);
            SetupIntent setupIntent = await service.UpdateAsync(
                "seti_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/setup_intents/seti_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSetupIntentsVerifyMicrodepositsPost()
        {
            var service = new SetupIntentService(this.StripeClient);
            SetupIntent setupIntent = service.VerifyMicrodeposits(
                "seti_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/setup_intents/seti_xxxxxxxxxxxxx/verify_microdeposits");
        }

        [Fact]
        public async Task TestSetupIntentsVerifyMicrodepositsPostAsync()
        {
            var service = new SetupIntentService(this.StripeClient);
            SetupIntent setupIntent = await service.VerifyMicrodepositsAsync(
                "seti_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/setup_intents/seti_xxxxxxxxxxxxx/verify_microdeposits");
        }

        [Fact]
        public void TestSetupIntentsVerifyMicrodepositsPost2()
        {
            var options = new SetupIntentVerifyMicrodepositsOptions
            {
                Amounts = new List<long?> { 32, 45 },
            };
            var service = new SetupIntentService(this.StripeClient);
            SetupIntent setupIntent = service.VerifyMicrodeposits(
                "seti_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/setup_intents/seti_xxxxxxxxxxxxx/verify_microdeposits");
        }

        [Fact]
        public async Task TestSetupIntentsVerifyMicrodepositsPost2Async()
        {
            var options = new SetupIntentVerifyMicrodepositsOptions
            {
                Amounts = new List<long?> { 32, 45 },
            };
            var service = new SetupIntentService(this.StripeClient);
            SetupIntent setupIntent = await service.VerifyMicrodepositsAsync(
                "seti_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/setup_intents/seti_xxxxxxxxxxxxx/verify_microdeposits");
        }

        [Fact]
        public void TestShippingRatesGet()
        {
            var service = new ShippingRateService(this.StripeClient);
            StripeList<ShippingRate> shippingRates = service.List();
            this.AssertRequest(HttpMethod.Get, "/v1/shipping_rates");
        }

        [Fact]
        public async Task TestShippingRatesGetAsync()
        {
            var service = new ShippingRateService(this.StripeClient);
            StripeList<ShippingRate> shippingRates = await service.ListAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/shipping_rates");
        }

        [Fact]
        public void TestShippingRatesGetAutoPaging()
        {
            var service = new ShippingRateService(this.StripeClient);
            var shippingRate = service.ListAutoPaging().First();
            this.AssertRequest(HttpMethod.Get, "/v1/shipping_rates");
        }

        [Fact]
        public async Task TestShippingRatesGetAutoPagingAsync()
        {
            var service = new ShippingRateService(this.StripeClient);
            var shippingRate = await service.ListAutoPagingAsync().FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/shipping_rates");
        }

        [Fact]
        public void TestShippingRatesGet2()
        {
            var options = new ShippingRateListOptions { Limit = 3 };
            var service = new ShippingRateService(this.StripeClient);
            StripeList<ShippingRate> shippingRates = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/shipping_rates", "limit=3");
        }

        [Fact]
        public async Task TestShippingRatesGet2Async()
        {
            var options = new ShippingRateListOptions { Limit = 3 };
            var service = new ShippingRateService(this.StripeClient);
            StripeList<ShippingRate> shippingRates = await service.ListAsync(
                options);
            this.AssertRequest(HttpMethod.Get, "/v1/shipping_rates", "limit=3");
        }

        [Fact]
        public void TestShippingRatesGet2AutoPaging()
        {
            var options = new ShippingRateListOptions { Limit = 3 };
            var service = new ShippingRateService(this.StripeClient);
            var shippingRate = service.ListAutoPaging(options).First();
            this.AssertRequest(HttpMethod.Get, "/v1/shipping_rates", "limit=3");
        }

        [Fact]
        public async Task TestShippingRatesGet2AutoPagingAsync()
        {
            var options = new ShippingRateListOptions { Limit = 3 };
            var service = new ShippingRateService(this.StripeClient);
            var shippingRate = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/shipping_rates", "limit=3");
        }

        [Fact]
        public void TestShippingRatesGet3()
        {
            var service = new ShippingRateService(this.StripeClient);
            ShippingRate shippingRate = service.Get("shr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/shipping_rates/shr_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestShippingRatesGet3Async()
        {
            var service = new ShippingRateService(this.StripeClient);
            ShippingRate shippingRate = await service.GetAsync(
                "shr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/shipping_rates/shr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestShippingRatesPost()
        {
            var options = new ShippingRateCreateOptions
            {
                DisplayName = "Sample Shipper",
                FixedAmount = new ShippingRateFixedAmountOptions
                {
                    Currency = "usd",
                    Amount = 400,
                },
                Type = "fixed_amount",
            };
            var service = new ShippingRateService(this.StripeClient);
            ShippingRate shippingRate = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/shipping_rates");
        }

        [Fact]
        public async Task TestShippingRatesPostAsync()
        {
            var options = new ShippingRateCreateOptions
            {
                DisplayName = "Sample Shipper",
                FixedAmount = new ShippingRateFixedAmountOptions
                {
                    Currency = "usd",
                    Amount = 400,
                },
                Type = "fixed_amount",
            };
            var service = new ShippingRateService(this.StripeClient);
            ShippingRate shippingRate = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/shipping_rates");
        }

        [Fact]
        public void TestShippingRatesPost2()
        {
            var options = new ShippingRateCreateOptions
            {
                DisplayName = "Ground shipping",
                Type = "fixed_amount",
                FixedAmount = new ShippingRateFixedAmountOptions
                {
                    Amount = 500,
                    Currency = "usd",
                },
            };
            var service = new ShippingRateService(this.StripeClient);
            ShippingRate shippingRate = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/shipping_rates");
        }

        [Fact]
        public async Task TestShippingRatesPost2Async()
        {
            var options = new ShippingRateCreateOptions
            {
                DisplayName = "Ground shipping",
                Type = "fixed_amount",
                FixedAmount = new ShippingRateFixedAmountOptions
                {
                    Amount = 500,
                    Currency = "usd",
                },
            };
            var service = new ShippingRateService(this.StripeClient);
            ShippingRate shippingRate = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/shipping_rates");
        }

        [Fact]
        public void TestShippingRatesPost3()
        {
            var options = new ShippingRateUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new ShippingRateService(this.StripeClient);
            ShippingRate shippingRate = service.Update(
                "shr_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/shipping_rates/shr_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestShippingRatesPost3Async()
        {
            var options = new ShippingRateUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new ShippingRateService(this.StripeClient);
            ShippingRate shippingRate = await service.UpdateAsync(
                "shr_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/shipping_rates/shr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSigmaScheduledQueryRunsGet()
        {
            var options = new Stripe.Sigma.ScheduledQueryRunListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Sigma.ScheduledQueryRunService(
                this.StripeClient);
            StripeList<Stripe.Sigma.ScheduledQueryRun> scheduledQueryRuns = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/sigma/scheduled_query_runs",
                "limit=3");
        }

        [Fact]
        public async Task TestSigmaScheduledQueryRunsGetAsync()
        {
            var options = new Stripe.Sigma.ScheduledQueryRunListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Sigma.ScheduledQueryRunService(
                this.StripeClient);
            StripeList<Stripe.Sigma.ScheduledQueryRun> scheduledQueryRuns = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/sigma/scheduled_query_runs",
                "limit=3");
        }

        [Fact]
        public void TestSigmaScheduledQueryRunsGetAutoPaging()
        {
            var options = new Stripe.Sigma.ScheduledQueryRunListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Sigma.ScheduledQueryRunService(
                this.StripeClient);
            var scheduledQueryRun = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/sigma/scheduled_query_runs",
                "limit=3");
        }

        [Fact]
        public async Task TestSigmaScheduledQueryRunsGetAutoPagingAsync()
        {
            var options = new Stripe.Sigma.ScheduledQueryRunListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Sigma.ScheduledQueryRunService(
                this.StripeClient);
            var scheduledQueryRun = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/sigma/scheduled_query_runs",
                "limit=3");
        }

        [Fact]
        public void TestSigmaScheduledQueryRunsGet2()
        {
            var service = new Stripe.Sigma.ScheduledQueryRunService(
                this.StripeClient);
            Stripe.Sigma.ScheduledQueryRun scheduledQueryRun = service.Get(
                "sqr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/sigma/scheduled_query_runs/sqr_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestSigmaScheduledQueryRunsGet2Async()
        {
            var service = new Stripe.Sigma.ScheduledQueryRunService(
                this.StripeClient);
            Stripe.Sigma.ScheduledQueryRun scheduledQueryRun = await service
                .GetAsync("sqr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/sigma/scheduled_query_runs/sqr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSourcesGet()
        {
            var service = new SourceService(this.StripeClient);
            Source source = service.Get("src_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/sources/src_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestSourcesGetAsync()
        {
            var service = new SourceService(this.StripeClient);
            Source source = await service.GetAsync("src_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/sources/src_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSourcesGet2()
        {
            var service = new SourceService(this.StripeClient);
            Source source = service.Get("src_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/sources/src_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestSourcesGet2Async()
        {
            var service = new SourceService(this.StripeClient);
            Source source = await service.GetAsync("src_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/sources/src_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSourcesPost()
        {
            var options = new SourceUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new SourceService(this.StripeClient);
            Source source = service.Update("src_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/sources/src_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestSourcesPostAsync()
        {
            var options = new SourceUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new SourceService(this.StripeClient);
            Source source = await service.UpdateAsync(
                "src_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/sources/src_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSubscriptionItemsDelete()
        {
            var service = new SubscriptionItemService(this.StripeClient);
            SubscriptionItem deleted = service.Delete("si_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/subscription_items/si_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestSubscriptionItemsDeleteAsync()
        {
            var service = new SubscriptionItemService(this.StripeClient);
            SubscriptionItem deleted = await service.DeleteAsync(
                "si_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/subscription_items/si_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSubscriptionItemsGet()
        {
            var options = new SubscriptionItemListOptions
            {
                Subscription = "sub_xxxxxxxxxxxxx",
            };
            var service = new SubscriptionItemService(this.StripeClient);
            StripeList<SubscriptionItem> subscriptionItems = service.List(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/subscription_items",
                "subscription=sub_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestSubscriptionItemsGetAsync()
        {
            var options = new SubscriptionItemListOptions
            {
                Subscription = "sub_xxxxxxxxxxxxx",
            };
            var service = new SubscriptionItemService(this.StripeClient);
            StripeList<SubscriptionItem> subscriptionItems = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/subscription_items",
                "subscription=sub_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSubscriptionItemsGetAutoPaging()
        {
            var options = new SubscriptionItemListOptions
            {
                Subscription = "sub_xxxxxxxxxxxxx",
            };
            var service = new SubscriptionItemService(this.StripeClient);
            var subscriptionItem = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/subscription_items",
                "subscription=sub_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestSubscriptionItemsGetAutoPagingAsync()
        {
            var options = new SubscriptionItemListOptions
            {
                Subscription = "sub_xxxxxxxxxxxxx",
            };
            var service = new SubscriptionItemService(this.StripeClient);
            var subscriptionItem = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/subscription_items",
                "subscription=sub_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSubscriptionItemsGet2()
        {
            var service = new SubscriptionItemService(this.StripeClient);
            SubscriptionItem subscriptionItem = service.Get("si_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/subscription_items/si_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestSubscriptionItemsGet2Async()
        {
            var service = new SubscriptionItemService(this.StripeClient);
            SubscriptionItem subscriptionItem = await service.GetAsync(
                "si_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/subscription_items/si_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSubscriptionItemsPost()
        {
            var options = new SubscriptionItemCreateOptions
            {
                Subscription = "sub_xxxxxxxxxxxxx",
                Price = "price_xxxxxxxxxxxxx",
                Quantity = 2,
            };
            var service = new SubscriptionItemService(this.StripeClient);
            SubscriptionItem subscriptionItem = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/subscription_items");
        }

        [Fact]
        public async Task TestSubscriptionItemsPostAsync()
        {
            var options = new SubscriptionItemCreateOptions
            {
                Subscription = "sub_xxxxxxxxxxxxx",
                Price = "price_xxxxxxxxxxxxx",
                Quantity = 2,
            };
            var service = new SubscriptionItemService(this.StripeClient);
            SubscriptionItem subscriptionItem = await service.CreateAsync(
                options);
            this.AssertRequest(HttpMethod.Post, "/v1/subscription_items");
        }

        [Fact]
        public void TestSubscriptionItemsPost2()
        {
            var options = new SubscriptionItemUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new SubscriptionItemService(this.StripeClient);
            SubscriptionItem subscriptionItem = service.Update(
                "si_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/subscription_items/si_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestSubscriptionItemsPost2Async()
        {
            var options = new SubscriptionItemUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new SubscriptionItemService(this.StripeClient);
            SubscriptionItem subscriptionItem = await service.UpdateAsync(
                "si_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/subscription_items/si_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSubscriptionSchedulesCancelPost()
        {
            var service = new SubscriptionScheduleService(this.StripeClient);
            SubscriptionSchedule subscriptionSchedule = service.Cancel(
                "sub_sched_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/subscription_schedules/sub_sched_xxxxxxxxxxxxx/cancel");
        }

        [Fact]
        public async Task TestSubscriptionSchedulesCancelPostAsync()
        {
            var service = new SubscriptionScheduleService(this.StripeClient);
            SubscriptionSchedule subscriptionSchedule = await service
                .CancelAsync("sub_sched_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/subscription_schedules/sub_sched_xxxxxxxxxxxxx/cancel");
        }

        [Fact]
        public void TestSubscriptionSchedulesGet()
        {
            var options = new SubscriptionScheduleListOptions { Limit = 3 };
            var service = new SubscriptionScheduleService(this.StripeClient);
            StripeList<SubscriptionSchedule> subscriptionSchedules = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/subscription_schedules",
                "limit=3");
        }

        [Fact]
        public async Task TestSubscriptionSchedulesGetAsync()
        {
            var options = new SubscriptionScheduleListOptions { Limit = 3 };
            var service = new SubscriptionScheduleService(this.StripeClient);
            StripeList<SubscriptionSchedule> subscriptionSchedules = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/subscription_schedules",
                "limit=3");
        }

        [Fact]
        public void TestSubscriptionSchedulesGetAutoPaging()
        {
            var options = new SubscriptionScheduleListOptions { Limit = 3 };
            var service = new SubscriptionScheduleService(this.StripeClient);
            var subscriptionSchedule = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/subscription_schedules",
                "limit=3");
        }

        [Fact]
        public async Task TestSubscriptionSchedulesGetAutoPagingAsync()
        {
            var options = new SubscriptionScheduleListOptions { Limit = 3 };
            var service = new SubscriptionScheduleService(this.StripeClient);
            var subscriptionSchedule = await service.ListAutoPagingAsync(
                options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/subscription_schedules",
                "limit=3");
        }

        [Fact]
        public void TestSubscriptionSchedulesGet2()
        {
            var service = new SubscriptionScheduleService(this.StripeClient);
            SubscriptionSchedule subscriptionSchedule = service.Get(
                "sub_sched_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/subscription_schedules/sub_sched_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestSubscriptionSchedulesGet2Async()
        {
            var service = new SubscriptionScheduleService(this.StripeClient);
            SubscriptionSchedule subscriptionSchedule = await service.GetAsync(
                "sub_sched_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/subscription_schedules/sub_sched_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSubscriptionSchedulesPost()
        {
            var options = new SubscriptionScheduleCreateOptions
            {
                Customer = "cus_xxxxxxxxxxxxx",
                StartDate = DateTimeOffset.FromUnixTimeSeconds(1676070661)
                    .UtcDateTime,
                EndBehavior = "release",
                Phases = new List<SubscriptionSchedulePhaseOptions>
                {
                    new SubscriptionSchedulePhaseOptions
                    {
                        Items = new List<SubscriptionSchedulePhaseItemOptions>
                        {
                            new SubscriptionSchedulePhaseItemOptions
                            {
                                Price = "price_xxxxxxxxxxxxx",
                                Quantity = 1,
                            },
                        },
                    },
                },
            };
            var service = new SubscriptionScheduleService(this.StripeClient);
            SubscriptionSchedule subscriptionSchedule = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/subscription_schedules");
        }

        [Fact]
        public async Task TestSubscriptionSchedulesPostAsync()
        {
            var options = new SubscriptionScheduleCreateOptions
            {
                Customer = "cus_xxxxxxxxxxxxx",
                StartDate = DateTimeOffset.FromUnixTimeSeconds(1676070661)
                    .UtcDateTime,
                EndBehavior = "release",
                Phases = new List<SubscriptionSchedulePhaseOptions>
                {
                    new SubscriptionSchedulePhaseOptions
                    {
                        Items = new List<SubscriptionSchedulePhaseItemOptions>
                        {
                            new SubscriptionSchedulePhaseItemOptions
                            {
                                Price = "price_xxxxxxxxxxxxx",
                                Quantity = 1,
                            },
                        },
                    },
                },
            };
            var service = new SubscriptionScheduleService(this.StripeClient);
            SubscriptionSchedule subscriptionSchedule = await service
                .CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/subscription_schedules");
        }

        [Fact]
        public void TestSubscriptionSchedulesPost2()
        {
            var options = new SubscriptionScheduleUpdateOptions
            {
                EndBehavior = "release",
            };
            var service = new SubscriptionScheduleService(this.StripeClient);
            SubscriptionSchedule subscriptionSchedule = service.Update(
                "sub_sched_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/subscription_schedules/sub_sched_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestSubscriptionSchedulesPost2Async()
        {
            var options = new SubscriptionScheduleUpdateOptions
            {
                EndBehavior = "release",
            };
            var service = new SubscriptionScheduleService(this.StripeClient);
            SubscriptionSchedule subscriptionSchedule = await service
                .UpdateAsync("sub_sched_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/subscription_schedules/sub_sched_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSubscriptionSchedulesReleasePost()
        {
            var service = new SubscriptionScheduleService(this.StripeClient);
            SubscriptionSchedule subscriptionSchedule = service.Release(
                "sub_sched_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/subscription_schedules/sub_sched_xxxxxxxxxxxxx/release");
        }

        [Fact]
        public async Task TestSubscriptionSchedulesReleasePostAsync()
        {
            var service = new SubscriptionScheduleService(this.StripeClient);
            SubscriptionSchedule subscriptionSchedule = await service
                .ReleaseAsync("sub_sched_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/subscription_schedules/sub_sched_xxxxxxxxxxxxx/release");
        }

        [Fact]
        public void TestSubscriptionsDelete()
        {
            var service = new SubscriptionService(this.StripeClient);
            Subscription subscription = service.Cancel("sub_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/subscriptions/sub_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestSubscriptionsDeleteAsync()
        {
            var service = new SubscriptionService(this.StripeClient);
            Subscription subscription = await service.CancelAsync(
                "sub_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/subscriptions/sub_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSubscriptionsDiscountDelete()
        {
            var service = new SubscriptionService(this.StripeClient);
            Discount discount = service.DeleteDiscount("sub_xyz");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/subscriptions/sub_xyz/discount");
        }

        [Fact]
        public async Task TestSubscriptionsDiscountDeleteAsync()
        {
            var service = new SubscriptionService(this.StripeClient);
            Discount discount = await service.DeleteDiscountAsync("sub_xyz");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/subscriptions/sub_xyz/discount");
        }

        [Fact]
        public void TestSubscriptionsGet()
        {
            var options = new SubscriptionListOptions { Limit = 3 };
            var service = new SubscriptionService(this.StripeClient);
            StripeList<Subscription> subscriptions = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/subscriptions", "limit=3");
        }

        [Fact]
        public async Task TestSubscriptionsGetAsync()
        {
            var options = new SubscriptionListOptions { Limit = 3 };
            var service = new SubscriptionService(this.StripeClient);
            StripeList<Subscription> subscriptions = await service.ListAsync(
                options);
            this.AssertRequest(HttpMethod.Get, "/v1/subscriptions", "limit=3");
        }

        [Fact]
        public void TestSubscriptionsGetAutoPaging()
        {
            var options = new SubscriptionListOptions { Limit = 3 };
            var service = new SubscriptionService(this.StripeClient);
            var subscription = service.ListAutoPaging(options).First();
            this.AssertRequest(HttpMethod.Get, "/v1/subscriptions", "limit=3");
        }

        [Fact]
        public async Task TestSubscriptionsGetAutoPagingAsync()
        {
            var options = new SubscriptionListOptions { Limit = 3 };
            var service = new SubscriptionService(this.StripeClient);
            var subscription = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/subscriptions", "limit=3");
        }

        [Fact]
        public void TestSubscriptionsGet2()
        {
            var service = new SubscriptionService(this.StripeClient);
            Subscription subscription = service.Get("sub_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/subscriptions/sub_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestSubscriptionsGet2Async()
        {
            var service = new SubscriptionService(this.StripeClient);
            Subscription subscription = await service.GetAsync(
                "sub_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/subscriptions/sub_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSubscriptionsPost()
        {
            var options = new SubscriptionCreateOptions
            {
                Customer = "cus_xxxxxxxxxxxxx",
                Items = new List<SubscriptionItemOptions>
                {
                    new SubscriptionItemOptions
                    {
                        Price = "price_xxxxxxxxxxxxx",
                    },
                },
            };
            var service = new SubscriptionService(this.StripeClient);
            Subscription subscription = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/subscriptions");
        }

        [Fact]
        public async Task TestSubscriptionsPostAsync()
        {
            var options = new SubscriptionCreateOptions
            {
                Customer = "cus_xxxxxxxxxxxxx",
                Items = new List<SubscriptionItemOptions>
                {
                    new SubscriptionItemOptions
                    {
                        Price = "price_xxxxxxxxxxxxx",
                    },
                },
            };
            var service = new SubscriptionService(this.StripeClient);
            Subscription subscription = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/subscriptions");
        }

        [Fact]
        public void TestSubscriptionsPost2()
        {
            var options = new SubscriptionUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new SubscriptionService(this.StripeClient);
            Subscription subscription = service.Update(
                "sub_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/subscriptions/sub_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestSubscriptionsPost2Async()
        {
            var options = new SubscriptionUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new SubscriptionService(this.StripeClient);
            Subscription subscription = await service.UpdateAsync(
                "sub_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/subscriptions/sub_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSubscriptionsSearchGet()
        {
            var options = new SubscriptionSearchOptions
            {
                Query = "status:'active' AND metadata['order_id']:'6735'",
            };
            var service = new SubscriptionService(this.StripeClient);
            StripeSearchResult<Subscription> subscriptions = service.Search(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/subscriptions/search",
                "query=status%3A%27active%27%20AND%20metadata%5B%27order_id%27%5D%3A%276735%27");
        }

        [Fact]
        public async Task TestSubscriptionsSearchGetAsync()
        {
            var options = new SubscriptionSearchOptions
            {
                Query = "status:'active' AND metadata['order_id']:'6735'",
            };
            var service = new SubscriptionService(this.StripeClient);
            StripeSearchResult<Subscription> subscriptions = await service
                .SearchAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/subscriptions/search",
                "query=status%3A%27active%27%20AND%20metadata%5B%27order_id%27%5D%3A%276735%27");
        }

        [Fact]
        public void TestSubscriptionsSearchGetAutoPaging()
        {
            var options = new SubscriptionSearchOptions
            {
                Query = "status:'active' AND metadata['order_id']:'6735'",
            };
            var service = new SubscriptionService(this.StripeClient);
            var subscription = service.SearchAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/subscriptions/search",
                "query=status%3A%27active%27%20AND%20metadata%5B%27order_id%27%5D%3A%276735%27");
        }

        [Fact]
        public async Task TestSubscriptionsSearchGetAutoPagingAsync()
        {
            var options = new SubscriptionSearchOptions
            {
                Query = "status:'active' AND metadata['order_id']:'6735'",
            };
            var service = new SubscriptionService(this.StripeClient);
            var subscription = await service.SearchAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/subscriptions/search",
                "query=status%3A%27active%27%20AND%20metadata%5B%27order_id%27%5D%3A%276735%27");
        }

        [Fact]
        public void TestTaxCalculationsLineItemsGet()
        {
            var service = new Stripe.Tax.CalculationLineItemService(
                this.StripeClient);
            StripeList<Stripe.Tax.CalculationLineItem> calculationLineItems = service
                .List("xxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/tax/calculations/xxx/line_items");
        }

        [Fact]
        public async Task TestTaxCalculationsLineItemsGetAsync()
        {
            var service = new Stripe.Tax.CalculationLineItemService(
                this.StripeClient);
            StripeList<Stripe.Tax.CalculationLineItem> calculationLineItems = await service
                .ListAsync("xxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/tax/calculations/xxx/line_items");
        }

        [Fact]
        public void TestTaxCalculationsLineItemsGetAutoPaging()
        {
            var service = new Stripe.Tax.CalculationLineItemService(
                this.StripeClient);
            var calculationLineItem = service.ListAutoPaging("xxx").First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/tax/calculations/xxx/line_items");
        }

        [Fact]
        public async Task TestTaxCalculationsLineItemsGetAutoPagingAsync()
        {
            var service = new Stripe.Tax.CalculationLineItemService(
                this.StripeClient);
            var calculationLineItem = await service.ListAutoPagingAsync("xxx")
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/tax/calculations/xxx/line_items");
        }

        [Fact]
        public void TestTaxCalculationsPost()
        {
            var options = new Stripe.Tax.CalculationCreateOptions
            {
                Currency = "usd",
                LineItems = new List<Stripe.Tax.CalculationLineItemOptions>
                {
                    new Stripe.Tax.CalculationLineItemOptions
                    {
                        Amount = 1000,
                        Reference = "L1",
                    },
                },
                CustomerDetails = new Stripe.Tax.CalculationCustomerDetailsOptions
                {
                    Address = new AddressOptions
                    {
                        Line1 = "354 Oyster Point Blvd",
                        City = "South San Francisco",
                        State = "CA",
                        PostalCode = "94080",
                        Country = "US",
                    },
                    AddressSource = "shipping",
                },
            };
            var service = new Stripe.Tax.CalculationService(this.StripeClient);
            Stripe.Tax.Calculation calculation = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/tax/calculations");
        }

        [Fact]
        public async Task TestTaxCalculationsPostAsync()
        {
            var options = new Stripe.Tax.CalculationCreateOptions
            {
                Currency = "usd",
                LineItems = new List<Stripe.Tax.CalculationLineItemOptions>
                {
                    new Stripe.Tax.CalculationLineItemOptions
                    {
                        Amount = 1000,
                        Reference = "L1",
                    },
                },
                CustomerDetails = new Stripe.Tax.CalculationCustomerDetailsOptions
                {
                    Address = new AddressOptions
                    {
                        Line1 = "354 Oyster Point Blvd",
                        City = "South San Francisco",
                        State = "CA",
                        PostalCode = "94080",
                        Country = "US",
                    },
                    AddressSource = "shipping",
                },
            };
            var service = new Stripe.Tax.CalculationService(this.StripeClient);
            Stripe.Tax.Calculation calculation = await service.CreateAsync(
                options);
            this.AssertRequest(HttpMethod.Post, "/v1/tax/calculations");
        }

        [Fact]
        public void TestTaxCodesGet()
        {
            var options = new TaxCodeListOptions { Limit = 3 };
            var service = new TaxCodeService(this.StripeClient);
            StripeList<TaxCode> taxCodes = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/tax_codes", "limit=3");
        }

        [Fact]
        public async Task TestTaxCodesGetAsync()
        {
            var options = new TaxCodeListOptions { Limit = 3 };
            var service = new TaxCodeService(this.StripeClient);
            StripeList<TaxCode> taxCodes = await service.ListAsync(options);
            this.AssertRequest(HttpMethod.Get, "/v1/tax_codes", "limit=3");
        }

        [Fact]
        public void TestTaxCodesGetAutoPaging()
        {
            var options = new TaxCodeListOptions { Limit = 3 };
            var service = new TaxCodeService(this.StripeClient);
            var taxCode = service.ListAutoPaging(options).First();
            this.AssertRequest(HttpMethod.Get, "/v1/tax_codes", "limit=3");
        }

        [Fact]
        public async Task TestTaxCodesGetAutoPagingAsync()
        {
            var options = new TaxCodeListOptions { Limit = 3 };
            var service = new TaxCodeService(this.StripeClient);
            var taxCode = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/tax_codes", "limit=3");
        }

        [Fact]
        public void TestTaxCodesGet2()
        {
            var service = new TaxCodeService(this.StripeClient);
            TaxCode taxCode = service.Get("txcd_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/tax_codes/txcd_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestTaxCodesGet2Async()
        {
            var service = new TaxCodeService(this.StripeClient);
            TaxCode taxCode = await service.GetAsync("txcd_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/tax_codes/txcd_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTaxIdsDelete()
        {
            var service = new TaxIdService(this.StripeClient);
            TaxId deleted = service.Delete("taxid_123");
            this.AssertRequest(HttpMethod.Delete, "/v1/tax_ids/taxid_123");
        }

        [Fact]
        public async Task TestTaxIdsDeleteAsync()
        {
            var service = new TaxIdService(this.StripeClient);
            TaxId deleted = await service.DeleteAsync("taxid_123");
            this.AssertRequest(HttpMethod.Delete, "/v1/tax_ids/taxid_123");
        }

        [Fact]
        public void TestTaxIdsGet()
        {
            var service = new TaxIdService(this.StripeClient);
            StripeList<TaxId> taxIds = service.List();
            this.AssertRequest(HttpMethod.Get, "/v1/tax_ids");
        }

        [Fact]
        public async Task TestTaxIdsGetAsync()
        {
            var service = new TaxIdService(this.StripeClient);
            StripeList<TaxId> taxIds = await service.ListAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/tax_ids");
        }

        [Fact]
        public void TestTaxIdsGetAutoPaging()
        {
            var service = new TaxIdService(this.StripeClient);
            var taxId = service.ListAutoPaging().First();
            this.AssertRequest(HttpMethod.Get, "/v1/tax_ids");
        }

        [Fact]
        public async Task TestTaxIdsGetAutoPagingAsync()
        {
            var service = new TaxIdService(this.StripeClient);
            var taxId = await service.ListAutoPagingAsync().FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/tax_ids");
        }

        [Fact]
        public void TestTaxIdsGet2()
        {
            var service = new TaxIdService(this.StripeClient);
            TaxId taxId = service.Get("taxid_123");
            this.AssertRequest(HttpMethod.Get, "/v1/tax_ids/taxid_123");
        }

        [Fact]
        public async Task TestTaxIdsGet2Async()
        {
            var service = new TaxIdService(this.StripeClient);
            TaxId taxId = await service.GetAsync("taxid_123");
            this.AssertRequest(HttpMethod.Get, "/v1/tax_ids/taxid_123");
        }

        [Fact]
        public void TestTaxIdsPost()
        {
            var options = new TaxIdCreateOptions
            {
                Type = "eu_vat",
                Value = "123",
            };
            var service = new TaxIdService(this.StripeClient);
            TaxId taxId = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/tax_ids");
        }

        [Fact]
        public async Task TestTaxIdsPostAsync()
        {
            var options = new TaxIdCreateOptions
            {
                Type = "eu_vat",
                Value = "123",
            };
            var service = new TaxIdService(this.StripeClient);
            TaxId taxId = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/tax_ids");
        }

        [Fact]
        public void TestTaxRatesGet()
        {
            var options = new TaxRateListOptions { Limit = 3 };
            var service = new TaxRateService(this.StripeClient);
            StripeList<TaxRate> taxRates = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/tax_rates", "limit=3");
        }

        [Fact]
        public async Task TestTaxRatesGetAsync()
        {
            var options = new TaxRateListOptions { Limit = 3 };
            var service = new TaxRateService(this.StripeClient);
            StripeList<TaxRate> taxRates = await service.ListAsync(options);
            this.AssertRequest(HttpMethod.Get, "/v1/tax_rates", "limit=3");
        }

        [Fact]
        public void TestTaxRatesGetAutoPaging()
        {
            var options = new TaxRateListOptions { Limit = 3 };
            var service = new TaxRateService(this.StripeClient);
            var taxRate = service.ListAutoPaging(options).First();
            this.AssertRequest(HttpMethod.Get, "/v1/tax_rates", "limit=3");
        }

        [Fact]
        public async Task TestTaxRatesGetAutoPagingAsync()
        {
            var options = new TaxRateListOptions { Limit = 3 };
            var service = new TaxRateService(this.StripeClient);
            var taxRate = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/tax_rates", "limit=3");
        }

        [Fact]
        public void TestTaxRatesGet2()
        {
            var service = new TaxRateService(this.StripeClient);
            TaxRate taxRate = service.Get("txr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/tax_rates/txr_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestTaxRatesGet2Async()
        {
            var service = new TaxRateService(this.StripeClient);
            TaxRate taxRate = await service.GetAsync("txr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/tax_rates/txr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTaxRatesPost()
        {
            var options = new TaxRateCreateOptions
            {
                DisplayName = "VAT",
                Description = "VAT Germany",
                Jurisdiction = "DE",
                Percentage = 16M,
                Inclusive = false,
            };
            var service = new TaxRateService(this.StripeClient);
            TaxRate taxRate = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/tax_rates");
        }

        [Fact]
        public async Task TestTaxRatesPostAsync()
        {
            var options = new TaxRateCreateOptions
            {
                DisplayName = "VAT",
                Description = "VAT Germany",
                Jurisdiction = "DE",
                Percentage = 16M,
                Inclusive = false,
            };
            var service = new TaxRateService(this.StripeClient);
            TaxRate taxRate = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/tax_rates");
        }

        [Fact]
        public void TestTaxRatesPost2()
        {
            var options = new TaxRateUpdateOptions { Active = false };
            var service = new TaxRateService(this.StripeClient);
            TaxRate taxRate = service.Update("txr_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/tax_rates/txr_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestTaxRatesPost2Async()
        {
            var options = new TaxRateUpdateOptions { Active = false };
            var service = new TaxRateService(this.StripeClient);
            TaxRate taxRate = await service.UpdateAsync(
                "txr_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/tax_rates/txr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTaxRegistrationsGet()
        {
            var options = new Stripe.Tax.RegistrationListOptions
            {
                Status = "all",
            };
            var service = new Stripe.Tax.RegistrationService(this.StripeClient);
            StripeList<Stripe.Tax.Registration> registrations = service.List(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/tax/registrations",
                "status=all");
        }

        [Fact]
        public async Task TestTaxRegistrationsGetAsync()
        {
            var options = new Stripe.Tax.RegistrationListOptions
            {
                Status = "all",
            };
            var service = new Stripe.Tax.RegistrationService(this.StripeClient);
            StripeList<Stripe.Tax.Registration> registrations = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/tax/registrations",
                "status=all");
        }

        [Fact]
        public void TestTaxRegistrationsGetAutoPaging()
        {
            var options = new Stripe.Tax.RegistrationListOptions
            {
                Status = "all",
            };
            var service = new Stripe.Tax.RegistrationService(this.StripeClient);
            var registration = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/tax/registrations",
                "status=all");
        }

        [Fact]
        public async Task TestTaxRegistrationsGetAutoPagingAsync()
        {
            var options = new Stripe.Tax.RegistrationListOptions
            {
                Status = "all",
            };
            var service = new Stripe.Tax.RegistrationService(this.StripeClient);
            var registration = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/tax/registrations",
                "status=all");
        }

        [Fact]
        public void TestTaxRegistrationsPost()
        {
            var options = new Stripe.Tax.RegistrationCreateOptions
            {
                Country = "IE",
                CountryOptions = new Stripe.Tax.RegistrationCountryOptionsOptions
                {
                    Ie = new Stripe.Tax.RegistrationCountryOptionsIeOptions
                    {
                        Type = "oss_union",
                    },
                },
                ActiveFrom = Stripe.Tax.RegistrationActiveFrom.Now,
            };
            var service = new Stripe.Tax.RegistrationService(this.StripeClient);
            Stripe.Tax.Registration registration = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/tax/registrations");
        }

        [Fact]
        public async Task TestTaxRegistrationsPostAsync()
        {
            var options = new Stripe.Tax.RegistrationCreateOptions
            {
                Country = "IE",
                CountryOptions = new Stripe.Tax.RegistrationCountryOptionsOptions
                {
                    Ie = new Stripe.Tax.RegistrationCountryOptionsIeOptions
                    {
                        Type = "oss_union",
                    },
                },
                ActiveFrom = Stripe.Tax.RegistrationActiveFrom.Now,
            };
            var service = new Stripe.Tax.RegistrationService(this.StripeClient);
            Stripe.Tax.Registration registration = await service.CreateAsync(
                options);
            this.AssertRequest(HttpMethod.Post, "/v1/tax/registrations");
        }

        [Fact]
        public void TestTaxRegistrationsPost2()
        {
            var options = new Stripe.Tax.RegistrationUpdateOptions
            {
                ExpiresAt = Stripe.Tax.RegistrationExpiresAt.Now,
            };
            var service = new Stripe.Tax.RegistrationService(this.StripeClient);
            Stripe.Tax.Registration registration = service.Update(
                "taxreg_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/tax/registrations/taxreg_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestTaxRegistrationsPost2Async()
        {
            var options = new Stripe.Tax.RegistrationUpdateOptions
            {
                ExpiresAt = Stripe.Tax.RegistrationExpiresAt.Now,
            };
            var service = new Stripe.Tax.RegistrationService(this.StripeClient);
            Stripe.Tax.Registration registration = await service.UpdateAsync(
                "taxreg_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/tax/registrations/taxreg_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTaxSettingsGet()
        {
            var options = new Stripe.Tax.SettingsGetOptions();
            var service = new Stripe.Tax.SettingsService(this.StripeClient);
            Stripe.Tax.Settings settings = service.Get(options);
            this.AssertRequest(HttpMethod.Get, "/v1/tax/settings");
        }

        [Fact]
        public async Task TestTaxSettingsGetAsync()
        {
            var options = new Stripe.Tax.SettingsGetOptions();
            var service = new Stripe.Tax.SettingsService(this.StripeClient);
            Stripe.Tax.Settings settings = await service.GetAsync(options);
            this.AssertRequest(HttpMethod.Get, "/v1/tax/settings");
        }

        [Fact]
        public void TestTaxSettingsPost()
        {
            var options = new Stripe.Tax.SettingsUpdateOptions
            {
                Defaults = new Stripe.Tax.SettingsDefaultsOptions
                {
                    TaxCode = "txcd_10000000",
                },
            };
            var service = new Stripe.Tax.SettingsService(this.StripeClient);
            Stripe.Tax.Settings settings = service.Update(options);
            this.AssertRequest(HttpMethod.Post, "/v1/tax/settings");
        }

        [Fact]
        public async Task TestTaxSettingsPostAsync()
        {
            var options = new Stripe.Tax.SettingsUpdateOptions
            {
                Defaults = new Stripe.Tax.SettingsDefaultsOptions
                {
                    TaxCode = "txcd_10000000",
                },
            };
            var service = new Stripe.Tax.SettingsService(this.StripeClient);
            Stripe.Tax.Settings settings = await service.UpdateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/tax/settings");
        }

        [Fact]
        public void TestTaxTransactionsCreateFromCalculationPost()
        {
            var options = new Stripe.Tax.TransactionCreateFromCalculationOptions
            {
                Calculation = "xxx",
                Reference = "yyy",
            };
            var service = new Stripe.Tax.TransactionService(this.StripeClient);
            Stripe.Tax.Transaction transaction = service.CreateFromCalculation(
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/tax/transactions/create_from_calculation");
        }

        [Fact]
        public async Task TestTaxTransactionsCreateFromCalculationPostAsync()
        {
            var options = new Stripe.Tax.TransactionCreateFromCalculationOptions
            {
                Calculation = "xxx",
                Reference = "yyy",
            };
            var service = new Stripe.Tax.TransactionService(this.StripeClient);
            Stripe.Tax.Transaction transaction = await service
                .CreateFromCalculationAsync(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/tax/transactions/create_from_calculation");
        }

        [Fact]
        public void TestTerminalConfigurationsDelete()
        {
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            Stripe.Terminal.Configuration deleted = service.Delete("uc_123");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/terminal/configurations/uc_123");
        }

        [Fact]
        public async Task TestTerminalConfigurationsDeleteAsync()
        {
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            Stripe.Terminal.Configuration deleted = await service.DeleteAsync(
                "uc_123");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/terminal/configurations/uc_123");
        }

        [Fact]
        public void TestTerminalConfigurationsDelete2()
        {
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            Stripe.Terminal.Configuration deleted = service.Delete(
                "tmc_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/terminal/configurations/tmc_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestTerminalConfigurationsDelete2Async()
        {
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            Stripe.Terminal.Configuration deleted = await service.DeleteAsync(
                "tmc_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/terminal/configurations/tmc_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTerminalConfigurationsGet()
        {
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            StripeList<Stripe.Terminal.Configuration> configurations = service
                .List();
            this.AssertRequest(HttpMethod.Get, "/v1/terminal/configurations");
        }

        [Fact]
        public async Task TestTerminalConfigurationsGetAsync()
        {
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            StripeList<Stripe.Terminal.Configuration> configurations = await service
                .ListAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/terminal/configurations");
        }

        [Fact]
        public void TestTerminalConfigurationsGetAutoPaging()
        {
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            var configuration = service.ListAutoPaging().First();
            this.AssertRequest(HttpMethod.Get, "/v1/terminal/configurations");
        }

        [Fact]
        public async Task TestTerminalConfigurationsGetAutoPagingAsync()
        {
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            var configuration = await service.ListAutoPagingAsync()
                .FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/terminal/configurations");
        }

        [Fact]
        public void TestTerminalConfigurationsGet2()
        {
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            Stripe.Terminal.Configuration configuration = service.Get("uc_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/terminal/configurations/uc_123");
        }

        [Fact]
        public async Task TestTerminalConfigurationsGet2Async()
        {
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            Stripe.Terminal.Configuration configuration = await service
                .GetAsync("uc_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/terminal/configurations/uc_123");
        }

        [Fact]
        public void TestTerminalConfigurationsGet3()
        {
            var options = new Stripe.Terminal.ConfigurationListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            StripeList<Stripe.Terminal.Configuration> configurations = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/terminal/configurations",
                "limit=3");
        }

        [Fact]
        public async Task TestTerminalConfigurationsGet3Async()
        {
            var options = new Stripe.Terminal.ConfigurationListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            StripeList<Stripe.Terminal.Configuration> configurations = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/terminal/configurations",
                "limit=3");
        }

        [Fact]
        public void TestTerminalConfigurationsGet3AutoPaging()
        {
            var options = new Stripe.Terminal.ConfigurationListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            var configuration = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/terminal/configurations",
                "limit=3");
        }

        [Fact]
        public async Task TestTerminalConfigurationsGet3AutoPagingAsync()
        {
            var options = new Stripe.Terminal.ConfigurationListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            var configuration = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/terminal/configurations",
                "limit=3");
        }

        [Fact]
        public void TestTerminalConfigurationsGet4()
        {
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            Stripe.Terminal.Configuration configuration = service.Get(
                "tmc_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/terminal/configurations/tmc_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestTerminalConfigurationsGet4Async()
        {
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            Stripe.Terminal.Configuration configuration = await service
                .GetAsync("tmc_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/terminal/configurations/tmc_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTerminalConfigurationsPost()
        {
            var options = new Stripe.Terminal.ConfigurationCreateOptions();
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            Stripe.Terminal.Configuration configuration = service.Create(
                options);
            this.AssertRequest(HttpMethod.Post, "/v1/terminal/configurations");
        }

        [Fact]
        public async Task TestTerminalConfigurationsPostAsync()
        {
            var options = new Stripe.Terminal.ConfigurationCreateOptions();
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            Stripe.Terminal.Configuration configuration = await service
                .CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/terminal/configurations");
        }

        [Fact]
        public void TestTerminalConfigurationsPost2()
        {
            var options = new Stripe.Terminal.ConfigurationUpdateOptions
            {
                Tipping = new Stripe.Terminal.ConfigurationTippingOptions
                {
                    Usd = new Stripe.Terminal.ConfigurationTippingUsdOptions
                    {
                        FixedAmounts = new List<long?> { 10 },
                    },
                },
            };
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            Stripe.Terminal.Configuration configuration = service.Update(
                "uc_123",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/terminal/configurations/uc_123");
        }

        [Fact]
        public async Task TestTerminalConfigurationsPost2Async()
        {
            var options = new Stripe.Terminal.ConfigurationUpdateOptions
            {
                Tipping = new Stripe.Terminal.ConfigurationTippingOptions
                {
                    Usd = new Stripe.Terminal.ConfigurationTippingUsdOptions
                    {
                        FixedAmounts = new List<long?> { 10 },
                    },
                },
            };
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            Stripe.Terminal.Configuration configuration = await service
                .UpdateAsync("uc_123", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/terminal/configurations/uc_123");
        }

        [Fact]
        public void TestTerminalConfigurationsPost3()
        {
            var options = new Stripe.Terminal.ConfigurationCreateOptions
            {
                BbposWiseposE = new Stripe.Terminal.ConfigurationBbposWiseposEOptions
                {
                    Splashscreen = "file_xxxxxxxxxxxxx",
                },
            };
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            Stripe.Terminal.Configuration configuration = service.Create(
                options);
            this.AssertRequest(HttpMethod.Post, "/v1/terminal/configurations");
        }

        [Fact]
        public async Task TestTerminalConfigurationsPost3Async()
        {
            var options = new Stripe.Terminal.ConfigurationCreateOptions
            {
                BbposWiseposE = new Stripe.Terminal.ConfigurationBbposWiseposEOptions
                {
                    Splashscreen = "file_xxxxxxxxxxxxx",
                },
            };
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            Stripe.Terminal.Configuration configuration = await service
                .CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/terminal/configurations");
        }

        [Fact]
        public void TestTerminalConfigurationsPost4()
        {
            var options = new Stripe.Terminal.ConfigurationUpdateOptions
            {
                BbposWiseposE = new Stripe.Terminal.ConfigurationBbposWiseposEOptions
                {
                    Splashscreen = "file_xxxxxxxxxxxxx",
                },
            };
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            Stripe.Terminal.Configuration configuration = service.Update(
                "tmc_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/terminal/configurations/tmc_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestTerminalConfigurationsPost4Async()
        {
            var options = new Stripe.Terminal.ConfigurationUpdateOptions
            {
                BbposWiseposE = new Stripe.Terminal.ConfigurationBbposWiseposEOptions
                {
                    Splashscreen = "file_xxxxxxxxxxxxx",
                },
            };
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            Stripe.Terminal.Configuration configuration = await service
                .UpdateAsync("tmc_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/terminal/configurations/tmc_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTerminalConnectionTokensPost()
        {
            var options = new Stripe.Terminal.ConnectionTokenCreateOptions();
            var service = new Stripe.Terminal.ConnectionTokenService(
                this.StripeClient);
            Stripe.Terminal.ConnectionToken connectionToken = service.Create(
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/terminal/connection_tokens");
        }

        [Fact]
        public async Task TestTerminalConnectionTokensPostAsync()
        {
            var options = new Stripe.Terminal.ConnectionTokenCreateOptions();
            var service = new Stripe.Terminal.ConnectionTokenService(
                this.StripeClient);
            Stripe.Terminal.ConnectionToken connectionToken = await service
                .CreateAsync(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/terminal/connection_tokens");
        }

        [Fact]
        public void TestTerminalLocationsDelete()
        {
            var service = new Stripe.Terminal.LocationService(
                this.StripeClient);
            Stripe.Terminal.Location deleted = service.Delete(
                "tml_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/terminal/locations/tml_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestTerminalLocationsDeleteAsync()
        {
            var service = new Stripe.Terminal.LocationService(
                this.StripeClient);
            Stripe.Terminal.Location deleted = await service.DeleteAsync(
                "tml_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/terminal/locations/tml_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTerminalLocationsGet()
        {
            var options = new Stripe.Terminal.LocationListOptions { Limit = 3 };
            var service = new Stripe.Terminal.LocationService(
                this.StripeClient);
            StripeList<Stripe.Terminal.Location> locations = service.List(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/terminal/locations",
                "limit=3");
        }

        [Fact]
        public async Task TestTerminalLocationsGetAsync()
        {
            var options = new Stripe.Terminal.LocationListOptions { Limit = 3 };
            var service = new Stripe.Terminal.LocationService(
                this.StripeClient);
            StripeList<Stripe.Terminal.Location> locations = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/terminal/locations",
                "limit=3");
        }

        [Fact]
        public void TestTerminalLocationsGetAutoPaging()
        {
            var options = new Stripe.Terminal.LocationListOptions { Limit = 3 };
            var service = new Stripe.Terminal.LocationService(
                this.StripeClient);
            var location = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/terminal/locations",
                "limit=3");
        }

        [Fact]
        public async Task TestTerminalLocationsGetAutoPagingAsync()
        {
            var options = new Stripe.Terminal.LocationListOptions { Limit = 3 };
            var service = new Stripe.Terminal.LocationService(
                this.StripeClient);
            var location = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/terminal/locations",
                "limit=3");
        }

        [Fact]
        public void TestTerminalLocationsGet2()
        {
            var service = new Stripe.Terminal.LocationService(
                this.StripeClient);
            Stripe.Terminal.Location location = service.Get(
                "tml_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/terminal/locations/tml_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestTerminalLocationsGet2Async()
        {
            var service = new Stripe.Terminal.LocationService(
                this.StripeClient);
            Stripe.Terminal.Location location = await service.GetAsync(
                "tml_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/terminal/locations/tml_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTerminalLocationsPost()
        {
            var options = new Stripe.Terminal.LocationCreateOptions
            {
                DisplayName = "My First Store",
                Address = new AddressOptions
                {
                    Line1 = "1234 Main Street",
                    City = "San Francisco",
                    PostalCode = "94111",
                    State = "CA",
                    Country = "US",
                },
            };
            var service = new Stripe.Terminal.LocationService(
                this.StripeClient);
            Stripe.Terminal.Location location = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/terminal/locations");
        }

        [Fact]
        public async Task TestTerminalLocationsPostAsync()
        {
            var options = new Stripe.Terminal.LocationCreateOptions
            {
                DisplayName = "My First Store",
                Address = new AddressOptions
                {
                    Line1 = "1234 Main Street",
                    City = "San Francisco",
                    PostalCode = "94111",
                    State = "CA",
                    Country = "US",
                },
            };
            var service = new Stripe.Terminal.LocationService(
                this.StripeClient);
            Stripe.Terminal.Location location = await service.CreateAsync(
                options);
            this.AssertRequest(HttpMethod.Post, "/v1/terminal/locations");
        }

        [Fact]
        public void TestTerminalLocationsPost2()
        {
            var options = new Stripe.Terminal.LocationUpdateOptions
            {
                DisplayName = "My First Store",
            };
            var service = new Stripe.Terminal.LocationService(
                this.StripeClient);
            Stripe.Terminal.Location location = service.Update(
                "tml_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/terminal/locations/tml_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestTerminalLocationsPost2Async()
        {
            var options = new Stripe.Terminal.LocationUpdateOptions
            {
                DisplayName = "My First Store",
            };
            var service = new Stripe.Terminal.LocationService(
                this.StripeClient);
            Stripe.Terminal.Location location = await service.UpdateAsync(
                "tml_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/terminal/locations/tml_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTerminalReadersCancelActionPost()
        {
            var service = new Stripe.Terminal.ReaderService(this.StripeClient);
            Stripe.Terminal.Reader reader = service.CancelAction(
                "tmr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/terminal/readers/tmr_xxxxxxxxxxxxx/cancel_action");
        }

        [Fact]
        public async Task TestTerminalReadersCancelActionPostAsync()
        {
            var service = new Stripe.Terminal.ReaderService(this.StripeClient);
            Stripe.Terminal.Reader reader = await service.CancelActionAsync(
                "tmr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/terminal/readers/tmr_xxxxxxxxxxxxx/cancel_action");
        }

        [Fact]
        public void TestTerminalReadersDelete()
        {
            var service = new Stripe.Terminal.ReaderService(this.StripeClient);
            Stripe.Terminal.Reader deleted = service.Delete(
                "tmr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/terminal/readers/tmr_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestTerminalReadersDeleteAsync()
        {
            var service = new Stripe.Terminal.ReaderService(this.StripeClient);
            Stripe.Terminal.Reader deleted = await service.DeleteAsync(
                "tmr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/terminal/readers/tmr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTerminalReadersGet()
        {
            var options = new Stripe.Terminal.ReaderListOptions { Limit = 3 };
            var service = new Stripe.Terminal.ReaderService(this.StripeClient);
            StripeList<Stripe.Terminal.Reader> readers = service.List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/terminal/readers",
                "limit=3");
        }

        [Fact]
        public async Task TestTerminalReadersGetAsync()
        {
            var options = new Stripe.Terminal.ReaderListOptions { Limit = 3 };
            var service = new Stripe.Terminal.ReaderService(this.StripeClient);
            StripeList<Stripe.Terminal.Reader> readers = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/terminal/readers",
                "limit=3");
        }

        [Fact]
        public void TestTerminalReadersGetAutoPaging()
        {
            var options = new Stripe.Terminal.ReaderListOptions { Limit = 3 };
            var service = new Stripe.Terminal.ReaderService(this.StripeClient);
            var reader = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/terminal/readers",
                "limit=3");
        }

        [Fact]
        public async Task TestTerminalReadersGetAutoPagingAsync()
        {
            var options = new Stripe.Terminal.ReaderListOptions { Limit = 3 };
            var service = new Stripe.Terminal.ReaderService(this.StripeClient);
            var reader = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/terminal/readers",
                "limit=3");
        }

        [Fact]
        public void TestTerminalReadersGet2()
        {
            var service = new Stripe.Terminal.ReaderService(this.StripeClient);
            Stripe.Terminal.Reader reader = service.Get("tmr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/terminal/readers/tmr_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestTerminalReadersGet2Async()
        {
            var service = new Stripe.Terminal.ReaderService(this.StripeClient);
            Stripe.Terminal.Reader reader = await service.GetAsync(
                "tmr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/terminal/readers/tmr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTerminalReadersPost()
        {
            var options = new Stripe.Terminal.ReaderCreateOptions
            {
                RegistrationCode = "puppies-plug-could",
                Label = "Blue Rabbit",
                Location = "tml_1234",
            };
            var service = new Stripe.Terminal.ReaderService(this.StripeClient);
            Stripe.Terminal.Reader reader = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/terminal/readers");
        }

        [Fact]
        public async Task TestTerminalReadersPostAsync()
        {
            var options = new Stripe.Terminal.ReaderCreateOptions
            {
                RegistrationCode = "puppies-plug-could",
                Label = "Blue Rabbit",
                Location = "tml_1234",
            };
            var service = new Stripe.Terminal.ReaderService(this.StripeClient);
            Stripe.Terminal.Reader reader = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/terminal/readers");
        }

        [Fact]
        public void TestTerminalReadersPost2()
        {
            var options = new Stripe.Terminal.ReaderUpdateOptions
            {
                Label = "Blue Rabbit",
            };
            var service = new Stripe.Terminal.ReaderService(this.StripeClient);
            Stripe.Terminal.Reader reader = service.Update(
                "tmr_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/terminal/readers/tmr_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestTerminalReadersPost2Async()
        {
            var options = new Stripe.Terminal.ReaderUpdateOptions
            {
                Label = "Blue Rabbit",
            };
            var service = new Stripe.Terminal.ReaderService(this.StripeClient);
            Stripe.Terminal.Reader reader = await service.UpdateAsync(
                "tmr_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/terminal/readers/tmr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTerminalReadersProcessPaymentIntentPost()
        {
            var options = new Stripe.Terminal.ReaderProcessPaymentIntentOptions
            {
                PaymentIntent = "pi_xxxxxxxxxxxxx",
            };
            var service = new Stripe.Terminal.ReaderService(this.StripeClient);
            Stripe.Terminal.Reader reader = service.ProcessPaymentIntent(
                "tmr_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/terminal/readers/tmr_xxxxxxxxxxxxx/process_payment_intent");
        }

        [Fact]
        public async Task TestTerminalReadersProcessPaymentIntentPostAsync()
        {
            var options = new Stripe.Terminal.ReaderProcessPaymentIntentOptions
            {
                PaymentIntent = "pi_xxxxxxxxxxxxx",
            };
            var service = new Stripe.Terminal.ReaderService(this.StripeClient);
            Stripe.Terminal.Reader reader = await service
                .ProcessPaymentIntentAsync("tmr_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/terminal/readers/tmr_xxxxxxxxxxxxx/process_payment_intent");
        }

        [Fact]
        public void TestTerminalReadersProcessSetupIntentPost()
        {
            var options = new Stripe.Terminal.ReaderProcessSetupIntentOptions
            {
                SetupIntent = "seti_xxxxxxxxxxxxx",
                AllowRedisplay = "always",
            };
            var service = new Stripe.Terminal.ReaderService(this.StripeClient);
            Stripe.Terminal.Reader reader = service.ProcessSetupIntent(
                "tmr_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/terminal/readers/tmr_xxxxxxxxxxxxx/process_setup_intent");
        }

        [Fact]
        public async Task TestTerminalReadersProcessSetupIntentPostAsync()
        {
            var options = new Stripe.Terminal.ReaderProcessSetupIntentOptions
            {
                SetupIntent = "seti_xxxxxxxxxxxxx",
                AllowRedisplay = "always",
            };
            var service = new Stripe.Terminal.ReaderService(this.StripeClient);
            Stripe.Terminal.Reader reader = await service
                .ProcessSetupIntentAsync("tmr_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/terminal/readers/tmr_xxxxxxxxxxxxx/process_setup_intent");
        }

        [Fact]
        public void TestTestHelpersCustomersFundCashBalancePost()
        {
            var options = new Stripe.TestHelpers.CustomerFundCashBalanceOptions
            {
                Amount = 30,
                Currency = "eur",
            };
            var service = new Stripe.TestHelpers.CustomerService(
                this.StripeClient);
            CustomerCashBalanceTransaction customerCashBalanceTransaction = service
                .FundCashBalance("cus_123", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/customers/cus_123/fund_cash_balance");
        }

        [Fact]
        public async Task TestTestHelpersCustomersFundCashBalancePostAsync()
        {
            var options = new Stripe.TestHelpers.CustomerFundCashBalanceOptions
            {
                Amount = 30,
                Currency = "eur",
            };
            var service = new Stripe.TestHelpers.CustomerService(
                this.StripeClient);
            CustomerCashBalanceTransaction customerCashBalanceTransaction = await service
                .FundCashBalanceAsync("cus_123", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/customers/cus_123/fund_cash_balance");
        }

        [Fact]
        public void TestTestHelpersIssuingAuthorizationsCapturePost()
        {
            var options = new Stripe.TestHelpers.Issuing.AuthorizationCaptureOptions
            {
                CaptureAmount = 100,
                CloseAuthorization = true,
                PurchaseDetails = new Stripe.TestHelpers.Issuing.AuthorizationPurchaseDetailsOptions
                {
                    Flight = new Stripe.TestHelpers.Issuing.AuthorizationPurchaseDetailsFlightOptions
                    {
                        DepartureAt = DateTimeOffset.FromUnixTimeSeconds(
                            1633651200)
                            .UtcDateTime,
                        PassengerName = "John Doe",
                        Refundable = true,
                        Segments = new List<Stripe.TestHelpers.Issuing.AuthorizationPurchaseDetailsFlightSegmentOptions>
                        {
                            new Stripe.TestHelpers.Issuing.AuthorizationPurchaseDetailsFlightSegmentOptions
                            {
                                ArrivalAirportCode = "SFO",
                                Carrier = "Delta",
                                DepartureAirportCode = "LAX",
                                FlightNumber = "DL100",
                                ServiceClass = "Economy",
                                StopoverAllowed = true,
                            },
                        },
                        TravelAgency = "Orbitz",
                    },
                    Fuel = new Stripe.TestHelpers.Issuing.AuthorizationPurchaseDetailsFuelOptions
                    {
                        Type = "diesel",
                        Unit = "liter",
                        UnitCostDecimal = 3.5M,
                        QuantityDecimal = 10M,
                    },
                    Lodging = new Stripe.TestHelpers.Issuing.AuthorizationPurchaseDetailsLodgingOptions
                    {
                        CheckInAt = DateTimeOffset.FromUnixTimeSeconds(
                            1633651200)
                            .UtcDateTime,
                        Nights = 2,
                    },
                    Receipt = new List<Stripe.TestHelpers.Issuing.AuthorizationPurchaseDetailsReceiptOptions>
                    {
                        new Stripe.TestHelpers.Issuing.AuthorizationPurchaseDetailsReceiptOptions
                        {
                            Description = "Room charge",
                            Quantity = 1M,
                            Total = 200,
                            UnitCost = 200,
                        },
                    },
                    Reference = "foo",
                },
            };
            var service = new Stripe.TestHelpers.Issuing.AuthorizationService(
                this.StripeClient);
            Stripe.Issuing.Authorization authorization = service.Capture(
                "example_authorization",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/authorizations/example_authorization/capture");
        }

        [Fact]
        public async Task TestTestHelpersIssuingAuthorizationsCapturePostAsync()
        {
            var options = new Stripe.TestHelpers.Issuing.AuthorizationCaptureOptions
            {
                CaptureAmount = 100,
                CloseAuthorization = true,
                PurchaseDetails = new Stripe.TestHelpers.Issuing.AuthorizationPurchaseDetailsOptions
                {
                    Flight = new Stripe.TestHelpers.Issuing.AuthorizationPurchaseDetailsFlightOptions
                    {
                        DepartureAt = DateTimeOffset.FromUnixTimeSeconds(
                            1633651200)
                            .UtcDateTime,
                        PassengerName = "John Doe",
                        Refundable = true,
                        Segments = new List<Stripe.TestHelpers.Issuing.AuthorizationPurchaseDetailsFlightSegmentOptions>
                        {
                            new Stripe.TestHelpers.Issuing.AuthorizationPurchaseDetailsFlightSegmentOptions
                            {
                                ArrivalAirportCode = "SFO",
                                Carrier = "Delta",
                                DepartureAirportCode = "LAX",
                                FlightNumber = "DL100",
                                ServiceClass = "Economy",
                                StopoverAllowed = true,
                            },
                        },
                        TravelAgency = "Orbitz",
                    },
                    Fuel = new Stripe.TestHelpers.Issuing.AuthorizationPurchaseDetailsFuelOptions
                    {
                        Type = "diesel",
                        Unit = "liter",
                        UnitCostDecimal = 3.5M,
                        QuantityDecimal = 10M,
                    },
                    Lodging = new Stripe.TestHelpers.Issuing.AuthorizationPurchaseDetailsLodgingOptions
                    {
                        CheckInAt = DateTimeOffset.FromUnixTimeSeconds(
                            1633651200)
                            .UtcDateTime,
                        Nights = 2,
                    },
                    Receipt = new List<Stripe.TestHelpers.Issuing.AuthorizationPurchaseDetailsReceiptOptions>
                    {
                        new Stripe.TestHelpers.Issuing.AuthorizationPurchaseDetailsReceiptOptions
                        {
                            Description = "Room charge",
                            Quantity = 1M,
                            Total = 200,
                            UnitCost = 200,
                        },
                    },
                    Reference = "foo",
                },
            };
            var service = new Stripe.TestHelpers.Issuing.AuthorizationService(
                this.StripeClient);
            Stripe.Issuing.Authorization authorization = await service
                .CaptureAsync("example_authorization", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/authorizations/example_authorization/capture");
        }

        [Fact]
        public void TestTestHelpersIssuingAuthorizationsExpirePost()
        {
            var service = new Stripe.TestHelpers.Issuing.AuthorizationService(
                this.StripeClient);
            Stripe.Issuing.Authorization authorization = service.Expire(
                "example_authorization");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/authorizations/example_authorization/expire");
        }

        [Fact]
        public async Task TestTestHelpersIssuingAuthorizationsExpirePostAsync()
        {
            var service = new Stripe.TestHelpers.Issuing.AuthorizationService(
                this.StripeClient);
            Stripe.Issuing.Authorization authorization = await service
                .ExpireAsync("example_authorization");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/authorizations/example_authorization/expire");
        }

        [Fact]
        public void TestTestHelpersIssuingAuthorizationsIncrementPost()
        {
            var options = new Stripe.TestHelpers.Issuing.AuthorizationIncrementOptions
            {
                IncrementAmount = 50,
                IsAmountControllable = true,
            };
            var service = new Stripe.TestHelpers.Issuing.AuthorizationService(
                this.StripeClient);
            Stripe.Issuing.Authorization authorization = service.Increment(
                "example_authorization",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/authorizations/example_authorization/increment");
        }

        [Fact]
        public async Task TestTestHelpersIssuingAuthorizationsIncrementPostAsync()
        {
            var options = new Stripe.TestHelpers.Issuing.AuthorizationIncrementOptions
            {
                IncrementAmount = 50,
                IsAmountControllable = true,
            };
            var service = new Stripe.TestHelpers.Issuing.AuthorizationService(
                this.StripeClient);
            Stripe.Issuing.Authorization authorization = await service
                .IncrementAsync("example_authorization", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/authorizations/example_authorization/increment");
        }

        [Fact]
        public void TestTestHelpersIssuingAuthorizationsPost()
        {
            var options = new Stripe.TestHelpers.Issuing.AuthorizationCreateOptions
            {
                Amount = 100,
                AmountDetails = new Stripe.TestHelpers.Issuing.AuthorizationAmountDetailsOptions
                {
                    AtmFee = 10,
                    CashbackAmount = 5,
                },
                AuthorizationMethod = "chip",
                Card = "foo",
                Currency = "usd",
                IsAmountControllable = true,
                MerchantData = new Stripe.TestHelpers.Issuing.AuthorizationMerchantDataOptions
                {
                    Category = "ac_refrigeration_repair",
                    City = "foo",
                    Country = "bar",
                    Name = "foo",
                    NetworkId = "bar",
                    PostalCode = "foo",
                    State = "bar",
                    TerminalId = "foo",
                },
                NetworkData = new Stripe.TestHelpers.Issuing.AuthorizationNetworkDataOptions
                {
                    AcquiringInstitutionId = "foo",
                },
                VerificationData = new Stripe.TestHelpers.Issuing.AuthorizationVerificationDataOptions
                {
                    AddressLine1Check = "mismatch",
                    AddressPostalCodeCheck = "match",
                    CvcCheck = "match",
                    ExpiryCheck = "mismatch",
                },
                Wallet = "apple_pay",
            };
            var service = new Stripe.TestHelpers.Issuing.AuthorizationService(
                this.StripeClient);
            Stripe.Issuing.Authorization authorization = service.Create(
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/authorizations");
        }

        [Fact]
        public async Task TestTestHelpersIssuingAuthorizationsPostAsync()
        {
            var options = new Stripe.TestHelpers.Issuing.AuthorizationCreateOptions
            {
                Amount = 100,
                AmountDetails = new Stripe.TestHelpers.Issuing.AuthorizationAmountDetailsOptions
                {
                    AtmFee = 10,
                    CashbackAmount = 5,
                },
                AuthorizationMethod = "chip",
                Card = "foo",
                Currency = "usd",
                IsAmountControllable = true,
                MerchantData = new Stripe.TestHelpers.Issuing.AuthorizationMerchantDataOptions
                {
                    Category = "ac_refrigeration_repair",
                    City = "foo",
                    Country = "bar",
                    Name = "foo",
                    NetworkId = "bar",
                    PostalCode = "foo",
                    State = "bar",
                    TerminalId = "foo",
                },
                NetworkData = new Stripe.TestHelpers.Issuing.AuthorizationNetworkDataOptions
                {
                    AcquiringInstitutionId = "foo",
                },
                VerificationData = new Stripe.TestHelpers.Issuing.AuthorizationVerificationDataOptions
                {
                    AddressLine1Check = "mismatch",
                    AddressPostalCodeCheck = "match",
                    CvcCheck = "match",
                    ExpiryCheck = "mismatch",
                },
                Wallet = "apple_pay",
            };
            var service = new Stripe.TestHelpers.Issuing.AuthorizationService(
                this.StripeClient);
            Stripe.Issuing.Authorization authorization = await service
                .CreateAsync(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/authorizations");
        }

        [Fact]
        public void TestTestHelpersIssuingAuthorizationsReversePost()
        {
            var options = new Stripe.TestHelpers.Issuing.AuthorizationReverseOptions
            {
                ReverseAmount = 20,
            };
            var service = new Stripe.TestHelpers.Issuing.AuthorizationService(
                this.StripeClient);
            Stripe.Issuing.Authorization authorization = service.Reverse(
                "example_authorization",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/authorizations/example_authorization/reverse");
        }

        [Fact]
        public async Task TestTestHelpersIssuingAuthorizationsReversePostAsync()
        {
            var options = new Stripe.TestHelpers.Issuing.AuthorizationReverseOptions
            {
                ReverseAmount = 20,
            };
            var service = new Stripe.TestHelpers.Issuing.AuthorizationService(
                this.StripeClient);
            Stripe.Issuing.Authorization authorization = await service
                .ReverseAsync("example_authorization", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/authorizations/example_authorization/reverse");
        }

        [Fact]
        public void TestTestHelpersIssuingCardsShippingDeliverPost()
        {
            var service = new Stripe.TestHelpers.Issuing.CardService(
                this.StripeClient);
            Stripe.Issuing.Card card = service.DeliverCard("card_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/cards/card_123/shipping/deliver");
        }

        [Fact]
        public async Task TestTestHelpersIssuingCardsShippingDeliverPostAsync()
        {
            var service = new Stripe.TestHelpers.Issuing.CardService(
                this.StripeClient);
            Stripe.Issuing.Card card = await service.DeliverCardAsync(
                "card_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/cards/card_123/shipping/deliver");
        }

        [Fact]
        public void TestTestHelpersIssuingCardsShippingFailPost()
        {
            var service = new Stripe.TestHelpers.Issuing.CardService(
                this.StripeClient);
            Stripe.Issuing.Card card = service.FailCard("card_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/cards/card_123/shipping/fail");
        }

        [Fact]
        public async Task TestTestHelpersIssuingCardsShippingFailPostAsync()
        {
            var service = new Stripe.TestHelpers.Issuing.CardService(
                this.StripeClient);
            Stripe.Issuing.Card card = await service.FailCardAsync("card_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/cards/card_123/shipping/fail");
        }

        [Fact]
        public void TestTestHelpersIssuingCardsShippingReturnPost()
        {
            var service = new Stripe.TestHelpers.Issuing.CardService(
                this.StripeClient);
            Stripe.Issuing.Card card = service.ReturnCard("card_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/cards/card_123/shipping/return");
        }

        [Fact]
        public async Task TestTestHelpersIssuingCardsShippingReturnPostAsync()
        {
            var service = new Stripe.TestHelpers.Issuing.CardService(
                this.StripeClient);
            Stripe.Issuing.Card card = await service.ReturnCardAsync(
                "card_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/cards/card_123/shipping/return");
        }

        [Fact]
        public void TestTestHelpersIssuingCardsShippingShipPost()
        {
            var service = new Stripe.TestHelpers.Issuing.CardService(
                this.StripeClient);
            Stripe.Issuing.Card card = service.ShipCard("card_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/cards/card_123/shipping/ship");
        }

        [Fact]
        public async Task TestTestHelpersIssuingCardsShippingShipPostAsync()
        {
            var service = new Stripe.TestHelpers.Issuing.CardService(
                this.StripeClient);
            Stripe.Issuing.Card card = await service.ShipCardAsync("card_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/cards/card_123/shipping/ship");
        }

        [Fact]
        public void TestTestHelpersIssuingPersonalizationDesignsActivatePost()
        {
            var service = new Stripe.TestHelpers.Issuing.PersonalizationDesignService(
                this.StripeClient);
            Stripe.Issuing.PersonalizationDesign personalizationDesign = service
                .Activate("pd_xyz");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/personalization_designs/pd_xyz/activate");
        }

        [Fact]
        public async Task TestTestHelpersIssuingPersonalizationDesignsActivatePostAsync()
        {
            var service = new Stripe.TestHelpers.Issuing.PersonalizationDesignService(
                this.StripeClient);
            Stripe.Issuing.PersonalizationDesign personalizationDesign = await service
                .ActivateAsync("pd_xyz");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/personalization_designs/pd_xyz/activate");
        }

        [Fact]
        public void TestTestHelpersIssuingPersonalizationDesignsDeactivatePost()
        {
            var service = new Stripe.TestHelpers.Issuing.PersonalizationDesignService(
                this.StripeClient);
            Stripe.Issuing.PersonalizationDesign personalizationDesign = service
                .Deactivate("pd_xyz");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/personalization_designs/pd_xyz/deactivate");
        }

        [Fact]
        public async Task TestTestHelpersIssuingPersonalizationDesignsDeactivatePostAsync()
        {
            var service = new Stripe.TestHelpers.Issuing.PersonalizationDesignService(
                this.StripeClient);
            Stripe.Issuing.PersonalizationDesign personalizationDesign = await service
                .DeactivateAsync("pd_xyz");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/personalization_designs/pd_xyz/deactivate");
        }

        [Fact]
        public void TestTestHelpersIssuingPersonalizationDesignsRejectPost()
        {
            var options = new Stripe.TestHelpers.Issuing.PersonalizationDesignRejectOptions
            {
                RejectionReasons = new Stripe.TestHelpers.Issuing.PersonalizationDesignRejectionReasonsOptions
                {
                    CardLogo = new List<string> { "geographic_location" },
                },
            };
            var service = new Stripe.TestHelpers.Issuing.PersonalizationDesignService(
                this.StripeClient);
            Stripe.Issuing.PersonalizationDesign personalizationDesign = service
                .Reject("pd_xyz", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/personalization_designs/pd_xyz/reject");
        }

        [Fact]
        public async Task TestTestHelpersIssuingPersonalizationDesignsRejectPostAsync()
        {
            var options = new Stripe.TestHelpers.Issuing.PersonalizationDesignRejectOptions
            {
                RejectionReasons = new Stripe.TestHelpers.Issuing.PersonalizationDesignRejectionReasonsOptions
                {
                    CardLogo = new List<string> { "geographic_location" },
                },
            };
            var service = new Stripe.TestHelpers.Issuing.PersonalizationDesignService(
                this.StripeClient);
            Stripe.Issuing.PersonalizationDesign personalizationDesign = await service
                .RejectAsync("pd_xyz", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/personalization_designs/pd_xyz/reject");
        }

        [Fact]
        public void TestTestHelpersIssuingTransactionsCreateForceCapturePost()
        {
            var options = new Stripe.TestHelpers.Issuing.TransactionCreateForceCaptureOptions
            {
                Amount = 100,
                Card = "foo",
                Currency = "usd",
                MerchantData = new Stripe.TestHelpers.Issuing.TransactionMerchantDataOptions
                {
                    Category = "ac_refrigeration_repair",
                    City = "foo",
                    Country = "US",
                    Name = "foo",
                    NetworkId = "bar",
                    PostalCode = "10001",
                    State = "NY",
                    TerminalId = "foo",
                },
                PurchaseDetails = new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsOptions
                {
                    Flight = new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsFlightOptions
                    {
                        DepartureAt = DateTimeOffset.FromUnixTimeSeconds(
                            1633651200)
                            .UtcDateTime,
                        PassengerName = "John Doe",
                        Refundable = true,
                        Segments = new List<Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsFlightSegmentOptions>
                        {
                            new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsFlightSegmentOptions
                            {
                                ArrivalAirportCode = "SFO",
                                Carrier = "Delta",
                                DepartureAirportCode = "LAX",
                                FlightNumber = "DL100",
                                ServiceClass = "Economy",
                                StopoverAllowed = true,
                            },
                        },
                        TravelAgency = "Orbitz",
                    },
                    Fuel = new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsFuelOptions
                    {
                        Type = "diesel",
                        Unit = "liter",
                        UnitCostDecimal = 3.5M,
                        QuantityDecimal = 10M,
                    },
                    Lodging = new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsLodgingOptions
                    {
                        CheckInAt = DateTimeOffset.FromUnixTimeSeconds(
                            1533651200)
                            .UtcDateTime,
                        Nights = 2,
                    },
                    Receipt = new List<Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsReceiptOptions>
                    {
                        new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsReceiptOptions
                        {
                            Description = "Room charge",
                            Quantity = 1M,
                            Total = 200,
                            UnitCost = 200,
                        },
                    },
                    Reference = "foo",
                },
            };
            var service = new Stripe.TestHelpers.Issuing.TransactionService(
                this.StripeClient);
            Stripe.Issuing.Transaction transaction = service.CreateForceCapture(
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/transactions/create_force_capture");
        }

        [Fact]
        public async Task TestTestHelpersIssuingTransactionsCreateForceCapturePostAsync()
        {
            var options = new Stripe.TestHelpers.Issuing.TransactionCreateForceCaptureOptions
            {
                Amount = 100,
                Card = "foo",
                Currency = "usd",
                MerchantData = new Stripe.TestHelpers.Issuing.TransactionMerchantDataOptions
                {
                    Category = "ac_refrigeration_repair",
                    City = "foo",
                    Country = "US",
                    Name = "foo",
                    NetworkId = "bar",
                    PostalCode = "10001",
                    State = "NY",
                    TerminalId = "foo",
                },
                PurchaseDetails = new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsOptions
                {
                    Flight = new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsFlightOptions
                    {
                        DepartureAt = DateTimeOffset.FromUnixTimeSeconds(
                            1633651200)
                            .UtcDateTime,
                        PassengerName = "John Doe",
                        Refundable = true,
                        Segments = new List<Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsFlightSegmentOptions>
                        {
                            new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsFlightSegmentOptions
                            {
                                ArrivalAirportCode = "SFO",
                                Carrier = "Delta",
                                DepartureAirportCode = "LAX",
                                FlightNumber = "DL100",
                                ServiceClass = "Economy",
                                StopoverAllowed = true,
                            },
                        },
                        TravelAgency = "Orbitz",
                    },
                    Fuel = new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsFuelOptions
                    {
                        Type = "diesel",
                        Unit = "liter",
                        UnitCostDecimal = 3.5M,
                        QuantityDecimal = 10M,
                    },
                    Lodging = new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsLodgingOptions
                    {
                        CheckInAt = DateTimeOffset.FromUnixTimeSeconds(
                            1533651200)
                            .UtcDateTime,
                        Nights = 2,
                    },
                    Receipt = new List<Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsReceiptOptions>
                    {
                        new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsReceiptOptions
                        {
                            Description = "Room charge",
                            Quantity = 1M,
                            Total = 200,
                            UnitCost = 200,
                        },
                    },
                    Reference = "foo",
                },
            };
            var service = new Stripe.TestHelpers.Issuing.TransactionService(
                this.StripeClient);
            Stripe.Issuing.Transaction transaction = await service
                .CreateForceCaptureAsync(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/transactions/create_force_capture");
        }

        [Fact]
        public void TestTestHelpersIssuingTransactionsCreateUnlinkedRefundPost()
        {
            var options = new Stripe.TestHelpers.Issuing.TransactionCreateUnlinkedRefundOptions
            {
                Amount = 100,
                Card = "foo",
                Currency = "usd",
                MerchantData = new Stripe.TestHelpers.Issuing.TransactionMerchantDataOptions
                {
                    Category = "ac_refrigeration_repair",
                    City = "foo",
                    Country = "bar",
                    Name = "foo",
                    NetworkId = "bar",
                    PostalCode = "foo",
                    State = "bar",
                    TerminalId = "foo",
                },
                PurchaseDetails = new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsOptions
                {
                    Flight = new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsFlightOptions
                    {
                        DepartureAt = DateTimeOffset.FromUnixTimeSeconds(
                            1533651200)
                            .UtcDateTime,
                        PassengerName = "John Doe",
                        Refundable = true,
                        Segments = new List<Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsFlightSegmentOptions>
                        {
                            new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsFlightSegmentOptions
                            {
                                ArrivalAirportCode = "SFO",
                                Carrier = "Delta",
                                DepartureAirportCode = "LAX",
                                FlightNumber = "DL100",
                                ServiceClass = "Economy",
                                StopoverAllowed = true,
                            },
                        },
                        TravelAgency = "Orbitz",
                    },
                    Fuel = new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsFuelOptions
                    {
                        Type = "diesel",
                        Unit = "liter",
                        UnitCostDecimal = 3.5M,
                        QuantityDecimal = 10M,
                    },
                    Lodging = new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsLodgingOptions
                    {
                        CheckInAt = DateTimeOffset.FromUnixTimeSeconds(
                            1533651200)
                            .UtcDateTime,
                        Nights = 2,
                    },
                    Receipt = new List<Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsReceiptOptions>
                    {
                        new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsReceiptOptions
                        {
                            Description = "Room charge",
                            Quantity = 1M,
                            Total = 200,
                            UnitCost = 200,
                        },
                    },
                    Reference = "foo",
                },
            };
            var service = new Stripe.TestHelpers.Issuing.TransactionService(
                this.StripeClient);
            Stripe.Issuing.Transaction transaction = service
                .CreateUnlinkedRefund(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/transactions/create_unlinked_refund");
        }

        [Fact]
        public async Task TestTestHelpersIssuingTransactionsCreateUnlinkedRefundPostAsync()
        {
            var options = new Stripe.TestHelpers.Issuing.TransactionCreateUnlinkedRefundOptions
            {
                Amount = 100,
                Card = "foo",
                Currency = "usd",
                MerchantData = new Stripe.TestHelpers.Issuing.TransactionMerchantDataOptions
                {
                    Category = "ac_refrigeration_repair",
                    City = "foo",
                    Country = "bar",
                    Name = "foo",
                    NetworkId = "bar",
                    PostalCode = "foo",
                    State = "bar",
                    TerminalId = "foo",
                },
                PurchaseDetails = new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsOptions
                {
                    Flight = new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsFlightOptions
                    {
                        DepartureAt = DateTimeOffset.FromUnixTimeSeconds(
                            1533651200)
                            .UtcDateTime,
                        PassengerName = "John Doe",
                        Refundable = true,
                        Segments = new List<Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsFlightSegmentOptions>
                        {
                            new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsFlightSegmentOptions
                            {
                                ArrivalAirportCode = "SFO",
                                Carrier = "Delta",
                                DepartureAirportCode = "LAX",
                                FlightNumber = "DL100",
                                ServiceClass = "Economy",
                                StopoverAllowed = true,
                            },
                        },
                        TravelAgency = "Orbitz",
                    },
                    Fuel = new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsFuelOptions
                    {
                        Type = "diesel",
                        Unit = "liter",
                        UnitCostDecimal = 3.5M,
                        QuantityDecimal = 10M,
                    },
                    Lodging = new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsLodgingOptions
                    {
                        CheckInAt = DateTimeOffset.FromUnixTimeSeconds(
                            1533651200)
                            .UtcDateTime,
                        Nights = 2,
                    },
                    Receipt = new List<Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsReceiptOptions>
                    {
                        new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsReceiptOptions
                        {
                            Description = "Room charge",
                            Quantity = 1M,
                            Total = 200,
                            UnitCost = 200,
                        },
                    },
                    Reference = "foo",
                },
            };
            var service = new Stripe.TestHelpers.Issuing.TransactionService(
                this.StripeClient);
            Stripe.Issuing.Transaction transaction = await service
                .CreateUnlinkedRefundAsync(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/transactions/create_unlinked_refund");
        }

        [Fact]
        public void TestTestHelpersIssuingTransactionsRefundPost()
        {
            var options = new Stripe.TestHelpers.Issuing.TransactionRefundOptions
            {
                RefundAmount = 50,
            };
            var service = new Stripe.TestHelpers.Issuing.TransactionService(
                this.StripeClient);
            Stripe.Issuing.Transaction transaction = service.Refund(
                "example_transaction",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/transactions/example_transaction/refund");
        }

        [Fact]
        public async Task TestTestHelpersIssuingTransactionsRefundPostAsync()
        {
            var options = new Stripe.TestHelpers.Issuing.TransactionRefundOptions
            {
                RefundAmount = 50,
            };
            var service = new Stripe.TestHelpers.Issuing.TransactionService(
                this.StripeClient);
            Stripe.Issuing.Transaction transaction = await service.RefundAsync(
                "example_transaction",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/transactions/example_transaction/refund");
        }

        [Fact]
        public void TestTestHelpersRefundsExpirePost()
        {
            var service = new Stripe.TestHelpers.RefundService(
                this.StripeClient);
            Refund refund = service.Expire("re_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/refunds/re_123/expire");
        }

        [Fact]
        public async Task TestTestHelpersRefundsExpirePostAsync()
        {
            var service = new Stripe.TestHelpers.RefundService(
                this.StripeClient);
            Refund refund = await service.ExpireAsync("re_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/refunds/re_123/expire");
        }

        [Fact]
        public void TestTestHelpersTestClocksAdvancePost()
        {
            var options = new Stripe.TestHelpers.TestClockAdvanceOptions
            {
                FrozenTime = DateTimeOffset.FromUnixTimeSeconds(142)
                    .UtcDateTime,
            };
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            Stripe.TestHelpers.TestClock testClock = service.Advance(
                "clock_xyz",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/test_clocks/clock_xyz/advance");
        }

        [Fact]
        public async Task TestTestHelpersTestClocksAdvancePostAsync()
        {
            var options = new Stripe.TestHelpers.TestClockAdvanceOptions
            {
                FrozenTime = DateTimeOffset.FromUnixTimeSeconds(142)
                    .UtcDateTime,
            };
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            Stripe.TestHelpers.TestClock testClock = await service.AdvanceAsync(
                "clock_xyz",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/test_clocks/clock_xyz/advance");
        }

        [Fact]
        public void TestTestHelpersTestClocksAdvancePost2()
        {
            var options = new Stripe.TestHelpers.TestClockAdvanceOptions
            {
                FrozenTime = DateTimeOffset.FromUnixTimeSeconds(1675552261)
                    .UtcDateTime,
            };
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            Stripe.TestHelpers.TestClock testClock = service.Advance(
                "clock_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/test_clocks/clock_xxxxxxxxxxxxx/advance");
        }

        [Fact]
        public async Task TestTestHelpersTestClocksAdvancePost2Async()
        {
            var options = new Stripe.TestHelpers.TestClockAdvanceOptions
            {
                FrozenTime = DateTimeOffset.FromUnixTimeSeconds(1675552261)
                    .UtcDateTime,
            };
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            Stripe.TestHelpers.TestClock testClock = await service.AdvanceAsync(
                "clock_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/test_clocks/clock_xxxxxxxxxxxxx/advance");
        }

        [Fact]
        public void TestTestHelpersTestClocksDelete()
        {
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            Stripe.TestHelpers.TestClock deleted = service.Delete("clock_xyz");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/test_helpers/test_clocks/clock_xyz");
        }

        [Fact]
        public async Task TestTestHelpersTestClocksDeleteAsync()
        {
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            Stripe.TestHelpers.TestClock deleted = await service.DeleteAsync(
                "clock_xyz");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/test_helpers/test_clocks/clock_xyz");
        }

        [Fact]
        public void TestTestHelpersTestClocksDelete2()
        {
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            Stripe.TestHelpers.TestClock deleted = service.Delete(
                "clock_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/test_helpers/test_clocks/clock_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestTestHelpersTestClocksDelete2Async()
        {
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            Stripe.TestHelpers.TestClock deleted = await service.DeleteAsync(
                "clock_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/test_helpers/test_clocks/clock_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTestHelpersTestClocksGet()
        {
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            StripeList<Stripe.TestHelpers.TestClock> testClocks = service
                .List();
            this.AssertRequest(HttpMethod.Get, "/v1/test_helpers/test_clocks");
        }

        [Fact]
        public async Task TestTestHelpersTestClocksGetAsync()
        {
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            StripeList<Stripe.TestHelpers.TestClock> testClocks = await service
                .ListAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/test_helpers/test_clocks");
        }

        [Fact]
        public void TestTestHelpersTestClocksGetAutoPaging()
        {
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            var testClock = service.ListAutoPaging().First();
            this.AssertRequest(HttpMethod.Get, "/v1/test_helpers/test_clocks");
        }

        [Fact]
        public async Task TestTestHelpersTestClocksGetAutoPagingAsync()
        {
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            var testClock = await service.ListAutoPagingAsync().FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/test_helpers/test_clocks");
        }

        [Fact]
        public void TestTestHelpersTestClocksGet2()
        {
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            Stripe.TestHelpers.TestClock testClock = service.Get("clock_xyz");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/test_helpers/test_clocks/clock_xyz");
        }

        [Fact]
        public async Task TestTestHelpersTestClocksGet2Async()
        {
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            Stripe.TestHelpers.TestClock testClock = await service.GetAsync(
                "clock_xyz");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/test_helpers/test_clocks/clock_xyz");
        }

        [Fact]
        public void TestTestHelpersTestClocksGet3()
        {
            var options = new Stripe.TestHelpers.TestClockListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            StripeList<Stripe.TestHelpers.TestClock> testClocks = service.List(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/test_helpers/test_clocks",
                "limit=3");
        }

        [Fact]
        public async Task TestTestHelpersTestClocksGet3Async()
        {
            var options = new Stripe.TestHelpers.TestClockListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            StripeList<Stripe.TestHelpers.TestClock> testClocks = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/test_helpers/test_clocks",
                "limit=3");
        }

        [Fact]
        public void TestTestHelpersTestClocksGet3AutoPaging()
        {
            var options = new Stripe.TestHelpers.TestClockListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            var testClock = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/test_helpers/test_clocks",
                "limit=3");
        }

        [Fact]
        public async Task TestTestHelpersTestClocksGet3AutoPagingAsync()
        {
            var options = new Stripe.TestHelpers.TestClockListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            var testClock = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/test_helpers/test_clocks",
                "limit=3");
        }

        [Fact]
        public void TestTestHelpersTestClocksGet4()
        {
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            Stripe.TestHelpers.TestClock testClock = service.Get(
                "clock_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/test_helpers/test_clocks/clock_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestTestHelpersTestClocksGet4Async()
        {
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            Stripe.TestHelpers.TestClock testClock = await service.GetAsync(
                "clock_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/test_helpers/test_clocks/clock_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTestHelpersTestClocksPost()
        {
            var options = new Stripe.TestHelpers.TestClockCreateOptions
            {
                FrozenTime = DateTimeOffset.FromUnixTimeSeconds(123)
                    .UtcDateTime,
                Name = "cogsworth",
            };
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            Stripe.TestHelpers.TestClock testClock = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/test_helpers/test_clocks");
        }

        [Fact]
        public async Task TestTestHelpersTestClocksPostAsync()
        {
            var options = new Stripe.TestHelpers.TestClockCreateOptions
            {
                FrozenTime = DateTimeOffset.FromUnixTimeSeconds(123)
                    .UtcDateTime,
                Name = "cogsworth",
            };
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            Stripe.TestHelpers.TestClock testClock = await service.CreateAsync(
                options);
            this.AssertRequest(HttpMethod.Post, "/v1/test_helpers/test_clocks");
        }

        [Fact]
        public void TestTestHelpersTestClocksPost2()
        {
            var options = new Stripe.TestHelpers.TestClockCreateOptions
            {
                FrozenTime = DateTimeOffset.FromUnixTimeSeconds(1577836800)
                    .UtcDateTime,
            };
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            Stripe.TestHelpers.TestClock testClock = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/test_helpers/test_clocks");
        }

        [Fact]
        public async Task TestTestHelpersTestClocksPost2Async()
        {
            var options = new Stripe.TestHelpers.TestClockCreateOptions
            {
                FrozenTime = DateTimeOffset.FromUnixTimeSeconds(1577836800)
                    .UtcDateTime,
            };
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            Stripe.TestHelpers.TestClock testClock = await service.CreateAsync(
                options);
            this.AssertRequest(HttpMethod.Post, "/v1/test_helpers/test_clocks");
        }

        [Fact]
        public void TestTestHelpersTreasuryInboundTransfersFailPost()
        {
            var options = new Stripe.TestHelpers.Treasury.InboundTransferFailOptions
            {
                FailureDetails = new Stripe.TestHelpers.Treasury.InboundTransferFailureDetailsOptions
                {
                    Code = "account_closed",
                },
            };
            var service = new Stripe.TestHelpers.Treasury.InboundTransferService(
                this.StripeClient);
            Stripe.Treasury.InboundTransfer inboundTransfer = service.Fail(
                "ibt_123",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/treasury/inbound_transfers/ibt_123/fail");
        }

        [Fact]
        public async Task TestTestHelpersTreasuryInboundTransfersFailPostAsync()
        {
            var options = new Stripe.TestHelpers.Treasury.InboundTransferFailOptions
            {
                FailureDetails = new Stripe.TestHelpers.Treasury.InboundTransferFailureDetailsOptions
                {
                    Code = "account_closed",
                },
            };
            var service = new Stripe.TestHelpers.Treasury.InboundTransferService(
                this.StripeClient);
            Stripe.Treasury.InboundTransfer inboundTransfer = await service
                .FailAsync("ibt_123", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/treasury/inbound_transfers/ibt_123/fail");
        }

        [Fact]
        public void TestTestHelpersTreasuryInboundTransfersReturnPost()
        {
            var service = new Stripe.TestHelpers.Treasury.InboundTransferService(
                this.StripeClient);
            Stripe.Treasury.InboundTransfer inboundTransfer = service
                .ReturnInboundTransfer("ibt_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/treasury/inbound_transfers/ibt_123/return");
        }

        [Fact]
        public async Task TestTestHelpersTreasuryInboundTransfersReturnPostAsync()
        {
            var service = new Stripe.TestHelpers.Treasury.InboundTransferService(
                this.StripeClient);
            Stripe.Treasury.InboundTransfer inboundTransfer = await service
                .ReturnInboundTransferAsync("ibt_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/treasury/inbound_transfers/ibt_123/return");
        }

        [Fact]
        public void TestTestHelpersTreasuryInboundTransfersSucceedPost()
        {
            var service = new Stripe.TestHelpers.Treasury.InboundTransferService(
                this.StripeClient);
            Stripe.Treasury.InboundTransfer inboundTransfer = service.Succeed(
                "ibt_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/treasury/inbound_transfers/ibt_123/succeed");
        }

        [Fact]
        public async Task TestTestHelpersTreasuryInboundTransfersSucceedPostAsync()
        {
            var service = new Stripe.TestHelpers.Treasury.InboundTransferService(
                this.StripeClient);
            Stripe.Treasury.InboundTransfer inboundTransfer = await service
                .SucceedAsync("ibt_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/treasury/inbound_transfers/ibt_123/succeed");
        }

        [Fact]
        public void TestTestHelpersTreasuryOutboundTransfersFailPost()
        {
            var service = new Stripe.TestHelpers.Treasury.OutboundTransferService(
                this.StripeClient);
            Stripe.Treasury.OutboundTransfer outboundTransfer = service.Fail(
                "obt_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/treasury/outbound_transfers/obt_123/fail");
        }

        [Fact]
        public async Task TestTestHelpersTreasuryOutboundTransfersFailPostAsync()
        {
            var service = new Stripe.TestHelpers.Treasury.OutboundTransferService(
                this.StripeClient);
            Stripe.Treasury.OutboundTransfer outboundTransfer = await service
                .FailAsync("obt_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/treasury/outbound_transfers/obt_123/fail");
        }

        [Fact]
        public void TestTestHelpersTreasuryOutboundTransfersPostPost()
        {
            var service = new Stripe.TestHelpers.Treasury.OutboundTransferService(
                this.StripeClient);
            Stripe.Treasury.OutboundTransfer outboundTransfer = service.Post(
                "obt_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/treasury/outbound_transfers/obt_123/post");
        }

        [Fact]
        public async Task TestTestHelpersTreasuryOutboundTransfersPostPostAsync()
        {
            var service = new Stripe.TestHelpers.Treasury.OutboundTransferService(
                this.StripeClient);
            Stripe.Treasury.OutboundTransfer outboundTransfer = await service
                .PostAsync("obt_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/treasury/outbound_transfers/obt_123/post");
        }

        [Fact]
        public void TestTestHelpersTreasuryOutboundTransfersReturnPost()
        {
            var options = new Stripe.TestHelpers.Treasury.OutboundTransferReturnOutboundTransferOptions
            {
                ReturnedDetails = new Stripe.TestHelpers.Treasury.OutboundTransferReturnedDetailsOptions
                {
                    Code = "account_closed",
                },
            };
            var service = new Stripe.TestHelpers.Treasury.OutboundTransferService(
                this.StripeClient);
            Stripe.Treasury.OutboundTransfer outboundTransfer = service
                .ReturnOutboundTransfer("obt_123", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/treasury/outbound_transfers/obt_123/return");
        }

        [Fact]
        public async Task TestTestHelpersTreasuryOutboundTransfersReturnPostAsync()
        {
            var options = new Stripe.TestHelpers.Treasury.OutboundTransferReturnOutboundTransferOptions
            {
                ReturnedDetails = new Stripe.TestHelpers.Treasury.OutboundTransferReturnedDetailsOptions
                {
                    Code = "account_closed",
                },
            };
            var service = new Stripe.TestHelpers.Treasury.OutboundTransferService(
                this.StripeClient);
            Stripe.Treasury.OutboundTransfer outboundTransfer = await service
                .ReturnOutboundTransferAsync("obt_123", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/treasury/outbound_transfers/obt_123/return");
        }

        [Fact]
        public void TestTestHelpersTreasuryReceivedCreditsPost()
        {
            var options = new Stripe.TestHelpers.Treasury.ReceivedCreditCreateOptions
            {
                FinancialAccount = "fa_123",
                Network = "ach",
                Amount = 1234,
                Currency = "usd",
            };
            var service = new Stripe.TestHelpers.Treasury.ReceivedCreditService(
                this.StripeClient);
            Stripe.Treasury.ReceivedCredit receivedCredit = service.Create(
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/treasury/received_credits");
        }

        [Fact]
        public async Task TestTestHelpersTreasuryReceivedCreditsPostAsync()
        {
            var options = new Stripe.TestHelpers.Treasury.ReceivedCreditCreateOptions
            {
                FinancialAccount = "fa_123",
                Network = "ach",
                Amount = 1234,
                Currency = "usd",
            };
            var service = new Stripe.TestHelpers.Treasury.ReceivedCreditService(
                this.StripeClient);
            Stripe.Treasury.ReceivedCredit receivedCredit = await service
                .CreateAsync(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/treasury/received_credits");
        }

        [Fact]
        public void TestTestHelpersTreasuryReceivedDebitsPost()
        {
            var options = new Stripe.TestHelpers.Treasury.ReceivedDebitCreateOptions
            {
                FinancialAccount = "fa_123",
                Network = "ach",
                Amount = 1234,
                Currency = "usd",
            };
            var service = new Stripe.TestHelpers.Treasury.ReceivedDebitService(
                this.StripeClient);
            Stripe.Treasury.ReceivedDebit receivedDebit = service.Create(
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/treasury/received_debits");
        }

        [Fact]
        public async Task TestTestHelpersTreasuryReceivedDebitsPostAsync()
        {
            var options = new Stripe.TestHelpers.Treasury.ReceivedDebitCreateOptions
            {
                FinancialAccount = "fa_123",
                Network = "ach",
                Amount = 1234,
                Currency = "usd",
            };
            var service = new Stripe.TestHelpers.Treasury.ReceivedDebitService(
                this.StripeClient);
            Stripe.Treasury.ReceivedDebit receivedDebit = await service
                .CreateAsync(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/treasury/received_debits");
        }

        [Fact]
        public void TestTokensGet()
        {
            var service = new TokenService(this.StripeClient);
            Token token = service.Get("tok_xxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/tokens/tok_xxxx");
        }

        [Fact]
        public async Task TestTokensGetAsync()
        {
            var service = new TokenService(this.StripeClient);
            Token token = await service.GetAsync("tok_xxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/tokens/tok_xxxx");
        }

        [Fact]
        public void TestTokensPost()
        {
            var options = new TokenCreateOptions
            {
                Card = new TokenCardOptions
                {
                    Number = "4242424242424242",
                    ExpMonth = "5",
                    ExpYear = "2023",
                    Cvc = "314",
                },
            };
            var service = new TokenService(this.StripeClient);
            Token token = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/tokens");
        }

        [Fact]
        public async Task TestTokensPostAsync()
        {
            var options = new TokenCreateOptions
            {
                Card = new TokenCardOptions
                {
                    Number = "4242424242424242",
                    ExpMonth = "5",
                    ExpYear = "2023",
                    Cvc = "314",
                },
            };
            var service = new TokenService(this.StripeClient);
            Token token = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/tokens");
        }

        [Fact]
        public void TestTokensPost2()
        {
            var options = new TokenCreateOptions
            {
                BankAccount = new TokenBankAccountOptions
                {
                    Country = "US",
                    Currency = "usd",
                    AccountHolderName = "Jenny Rosen",
                    AccountHolderType = "individual",
                    RoutingNumber = "110000000",
                    AccountNumber = "000123456789",
                },
            };
            var service = new TokenService(this.StripeClient);
            Token token = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/tokens");
        }

        [Fact]
        public async Task TestTokensPost2Async()
        {
            var options = new TokenCreateOptions
            {
                BankAccount = new TokenBankAccountOptions
                {
                    Country = "US",
                    Currency = "usd",
                    AccountHolderName = "Jenny Rosen",
                    AccountHolderType = "individual",
                    RoutingNumber = "110000000",
                    AccountNumber = "000123456789",
                },
            };
            var service = new TokenService(this.StripeClient);
            Token token = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/tokens");
        }

        [Fact]
        public void TestTokensPost3()
        {
            var options = new TokenCreateOptions
            {
                Pii = new TokenPiiOptions { IdNumber = "000000000" },
            };
            var service = new TokenService(this.StripeClient);
            Token token = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/tokens");
        }

        [Fact]
        public async Task TestTokensPost3Async()
        {
            var options = new TokenCreateOptions
            {
                Pii = new TokenPiiOptions { IdNumber = "000000000" },
            };
            var service = new TokenService(this.StripeClient);
            Token token = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/tokens");
        }

        [Fact]
        public void TestTokensPost4()
        {
            var options = new TokenCreateOptions
            {
                Account = new TokenAccountOptions
                {
                    Individual = new TokenAccountIndividualOptions
                    {
                        FirstName = "Jane",
                        LastName = "Doe",
                    },
                    TosShownAndAccepted = true,
                },
            };
            var service = new TokenService(this.StripeClient);
            Token token = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/tokens");
        }

        [Fact]
        public async Task TestTokensPost4Async()
        {
            var options = new TokenCreateOptions
            {
                Account = new TokenAccountOptions
                {
                    Individual = new TokenAccountIndividualOptions
                    {
                        FirstName = "Jane",
                        LastName = "Doe",
                    },
                    TosShownAndAccepted = true,
                },
            };
            var service = new TokenService(this.StripeClient);
            Token token = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/tokens");
        }

        [Fact]
        public void TestTokensPost5()
        {
            var options = new TokenCreateOptions
            {
                Person = new TokenPersonOptions
                {
                    FirstName = "Jane",
                    LastName = "Doe",
                    Relationship = new TokenPersonRelationshipOptions
                    {
                        Owner = true,
                    },
                },
            };
            var service = new TokenService(this.StripeClient);
            Token token = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/tokens");
        }

        [Fact]
        public async Task TestTokensPost5Async()
        {
            var options = new TokenCreateOptions
            {
                Person = new TokenPersonOptions
                {
                    FirstName = "Jane",
                    LastName = "Doe",
                    Relationship = new TokenPersonRelationshipOptions
                    {
                        Owner = true,
                    },
                },
            };
            var service = new TokenService(this.StripeClient);
            Token token = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/tokens");
        }

        [Fact]
        public void TestTokensPost6()
        {
            var options = new TokenCreateOptions
            {
                CvcUpdate = new TokenCvcUpdateOptions { Cvc = "123" },
            };
            var service = new TokenService(this.StripeClient);
            Token token = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/tokens");
        }

        [Fact]
        public async Task TestTokensPost6Async()
        {
            var options = new TokenCreateOptions
            {
                CvcUpdate = new TokenCvcUpdateOptions { Cvc = "123" },
            };
            var service = new TokenService(this.StripeClient);
            Token token = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/tokens");
        }

        [Fact]
        public void TestTopupsCancelPost()
        {
            var service = new TopupService(this.StripeClient);
            Topup topup = service.Cancel("tu_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/topups/tu_xxxxxxxxxxxxx/cancel");
        }

        [Fact]
        public async Task TestTopupsCancelPostAsync()
        {
            var service = new TopupService(this.StripeClient);
            Topup topup = await service.CancelAsync("tu_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/topups/tu_xxxxxxxxxxxxx/cancel");
        }

        [Fact]
        public void TestTopupsGet()
        {
            var options = new TopupListOptions { Limit = 3 };
            var service = new TopupService(this.StripeClient);
            StripeList<Topup> topups = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/topups", "limit=3");
        }

        [Fact]
        public async Task TestTopupsGetAsync()
        {
            var options = new TopupListOptions { Limit = 3 };
            var service = new TopupService(this.StripeClient);
            StripeList<Topup> topups = await service.ListAsync(options);
            this.AssertRequest(HttpMethod.Get, "/v1/topups", "limit=3");
        }

        [Fact]
        public void TestTopupsGetAutoPaging()
        {
            var options = new TopupListOptions { Limit = 3 };
            var service = new TopupService(this.StripeClient);
            var topup = service.ListAutoPaging(options).First();
            this.AssertRequest(HttpMethod.Get, "/v1/topups", "limit=3");
        }

        [Fact]
        public async Task TestTopupsGetAutoPagingAsync()
        {
            var options = new TopupListOptions { Limit = 3 };
            var service = new TopupService(this.StripeClient);
            var topup = await service.ListAutoPagingAsync(options).FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/topups", "limit=3");
        }

        [Fact]
        public void TestTopupsGet2()
        {
            var service = new TopupService(this.StripeClient);
            Topup topup = service.Get("tu_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/topups/tu_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestTopupsGet2Async()
        {
            var service = new TopupService(this.StripeClient);
            Topup topup = await service.GetAsync("tu_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/topups/tu_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTopupsPost()
        {
            var options = new TopupCreateOptions
            {
                Amount = 2000,
                Currency = "usd",
                Description = "Top-up for Jenny Rosen",
                StatementDescriptor = "Top-up",
            };
            var service = new TopupService(this.StripeClient);
            Topup topup = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/topups");
        }

        [Fact]
        public async Task TestTopupsPostAsync()
        {
            var options = new TopupCreateOptions
            {
                Amount = 2000,
                Currency = "usd",
                Description = "Top-up for Jenny Rosen",
                StatementDescriptor = "Top-up",
            };
            var service = new TopupService(this.StripeClient);
            Topup topup = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/topups");
        }

        [Fact]
        public void TestTopupsPost2()
        {
            var options = new TopupUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new TopupService(this.StripeClient);
            Topup topup = service.Update("tu_xxxxxxxxxxxxx", options);
            this.AssertRequest(HttpMethod.Post, "/v1/topups/tu_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestTopupsPost2Async()
        {
            var options = new TopupUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new TopupService(this.StripeClient);
            Topup topup = await service.UpdateAsync(
                "tu_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(HttpMethod.Post, "/v1/topups/tu_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTransfersGet()
        {
            var options = new TransferListOptions { Limit = 3 };
            var service = new TransferService(this.StripeClient);
            StripeList<Transfer> transfers = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/transfers", "limit=3");
        }

        [Fact]
        public async Task TestTransfersGetAsync()
        {
            var options = new TransferListOptions { Limit = 3 };
            var service = new TransferService(this.StripeClient);
            StripeList<Transfer> transfers = await service.ListAsync(options);
            this.AssertRequest(HttpMethod.Get, "/v1/transfers", "limit=3");
        }

        [Fact]
        public void TestTransfersGetAutoPaging()
        {
            var options = new TransferListOptions { Limit = 3 };
            var service = new TransferService(this.StripeClient);
            var transfer = service.ListAutoPaging(options).First();
            this.AssertRequest(HttpMethod.Get, "/v1/transfers", "limit=3");
        }

        [Fact]
        public async Task TestTransfersGetAutoPagingAsync()
        {
            var options = new TransferListOptions { Limit = 3 };
            var service = new TransferService(this.StripeClient);
            var transfer = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/transfers", "limit=3");
        }

        [Fact]
        public void TestTransfersGet2()
        {
            var service = new TransferService(this.StripeClient);
            Transfer transfer = service.Get("tr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/transfers/tr_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestTransfersGet2Async()
        {
            var service = new TransferService(this.StripeClient);
            Transfer transfer = await service.GetAsync("tr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/transfers/tr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTransfersPost()
        {
            var options = new TransferCreateOptions
            {
                Amount = 400,
                Currency = "usd",
                Destination = "acct_xxxxxxxxxxxxx",
                TransferGroup = "ORDER_95",
            };
            var service = new TransferService(this.StripeClient);
            Transfer transfer = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/transfers");
        }

        [Fact]
        public async Task TestTransfersPostAsync()
        {
            var options = new TransferCreateOptions
            {
                Amount = 400,
                Currency = "usd",
                Destination = "acct_xxxxxxxxxxxxx",
                TransferGroup = "ORDER_95",
            };
            var service = new TransferService(this.StripeClient);
            Transfer transfer = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/transfers");
        }

        [Fact]
        public void TestTransfersPost2()
        {
            var options = new TransferUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new TransferService(this.StripeClient);
            Transfer transfer = service.Update("tr_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/transfers/tr_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestTransfersPost2Async()
        {
            var options = new TransferUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new TransferService(this.StripeClient);
            Transfer transfer = await service.UpdateAsync(
                "tr_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/transfers/tr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTransfersReversalsGet()
        {
            var options = new TransferReversalListOptions { Limit = 3 };
            var service = new TransferReversalService(this.StripeClient);
            StripeList<TransferReversal> transferReversals = service.List(
                "tr_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/transfers/tr_xxxxxxxxxxxxx/reversals",
                "limit=3");
        }

        [Fact]
        public async Task TestTransfersReversalsGetAsync()
        {
            var options = new TransferReversalListOptions { Limit = 3 };
            var service = new TransferReversalService(this.StripeClient);
            StripeList<TransferReversal> transferReversals = await service
                .ListAsync("tr_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/transfers/tr_xxxxxxxxxxxxx/reversals",
                "limit=3");
        }

        [Fact]
        public void TestTransfersReversalsGetAutoPaging()
        {
            var options = new TransferReversalListOptions { Limit = 3 };
            var service = new TransferReversalService(this.StripeClient);
            var transferReversal = service.ListAutoPaging(
                "tr_xxxxxxxxxxxxx",
                options)
                .First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/transfers/tr_xxxxxxxxxxxxx/reversals",
                "limit=3");
        }

        [Fact]
        public async Task TestTransfersReversalsGetAutoPagingAsync()
        {
            var options = new TransferReversalListOptions { Limit = 3 };
            var service = new TransferReversalService(this.StripeClient);
            var transferReversal = await service.ListAutoPagingAsync(
                "tr_xxxxxxxxxxxxx",
                options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/transfers/tr_xxxxxxxxxxxxx/reversals",
                "limit=3");
        }

        [Fact]
        public void TestTransfersReversalsGet2()
        {
            var service = new TransferReversalService(this.StripeClient);
            TransferReversal transferReversal = service.Get(
                "tr_xxxxxxxxxxxxx",
                "trr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/transfers/tr_xxxxxxxxxxxxx/reversals/trr_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestTransfersReversalsGet2Async()
        {
            var service = new TransferReversalService(this.StripeClient);
            TransferReversal transferReversal = await service.GetAsync(
                "tr_xxxxxxxxxxxxx",
                "trr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/transfers/tr_xxxxxxxxxxxxx/reversals/trr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTransfersReversalsPost()
        {
            var options = new TransferReversalCreateOptions { Amount = 100 };
            var service = new TransferReversalService(this.StripeClient);
            TransferReversal transferReversal = service.Create(
                "tr_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/transfers/tr_xxxxxxxxxxxxx/reversals");
        }

        [Fact]
        public async Task TestTransfersReversalsPostAsync()
        {
            var options = new TransferReversalCreateOptions { Amount = 100 };
            var service = new TransferReversalService(this.StripeClient);
            TransferReversal transferReversal = await service.CreateAsync(
                "tr_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/transfers/tr_xxxxxxxxxxxxx/reversals");
        }

        [Fact]
        public void TestTransfersReversalsPost2()
        {
            var options = new TransferReversalUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new TransferReversalService(this.StripeClient);
            TransferReversal transferReversal = service.Update(
                "tr_xxxxxxxxxxxxx",
                "trr_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/transfers/tr_xxxxxxxxxxxxx/reversals/trr_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestTransfersReversalsPost2Async()
        {
            var options = new TransferReversalUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new TransferReversalService(this.StripeClient);
            TransferReversal transferReversal = await service.UpdateAsync(
                "tr_xxxxxxxxxxxxx",
                "trr_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/transfers/tr_xxxxxxxxxxxxx/reversals/trr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryCreditReversalsGet()
        {
            var options = new Stripe.Treasury.CreditReversalListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.CreditReversalService(
                this.StripeClient);
            StripeList<Stripe.Treasury.CreditReversal> creditReversals = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/credit_reversals",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public async Task TestTreasuryCreditReversalsGetAsync()
        {
            var options = new Stripe.Treasury.CreditReversalListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.CreditReversalService(
                this.StripeClient);
            StripeList<Stripe.Treasury.CreditReversal> creditReversals = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/credit_reversals",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public void TestTreasuryCreditReversalsGetAutoPaging()
        {
            var options = new Stripe.Treasury.CreditReversalListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.CreditReversalService(
                this.StripeClient);
            var creditReversal = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/credit_reversals",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public async Task TestTreasuryCreditReversalsGetAutoPagingAsync()
        {
            var options = new Stripe.Treasury.CreditReversalListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.CreditReversalService(
                this.StripeClient);
            var creditReversal = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/credit_reversals",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public void TestTreasuryCreditReversalsGet2()
        {
            var service = new Stripe.Treasury.CreditReversalService(
                this.StripeClient);
            Stripe.Treasury.CreditReversal creditReversal = service.Get(
                "credrev_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/credit_reversals/credrev_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestTreasuryCreditReversalsGet2Async()
        {
            var service = new Stripe.Treasury.CreditReversalService(
                this.StripeClient);
            Stripe.Treasury.CreditReversal creditReversal = await service
                .GetAsync("credrev_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/credit_reversals/credrev_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryCreditReversalsPost()
        {
            var options = new Stripe.Treasury.CreditReversalCreateOptions
            {
                ReceivedCredit = "rc_xxxxxxxxxxxxx",
            };
            var service = new Stripe.Treasury.CreditReversalService(
                this.StripeClient);
            Stripe.Treasury.CreditReversal creditReversal = service.Create(
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/treasury/credit_reversals");
        }

        [Fact]
        public async Task TestTreasuryCreditReversalsPostAsync()
        {
            var options = new Stripe.Treasury.CreditReversalCreateOptions
            {
                ReceivedCredit = "rc_xxxxxxxxxxxxx",
            };
            var service = new Stripe.Treasury.CreditReversalService(
                this.StripeClient);
            Stripe.Treasury.CreditReversal creditReversal = await service
                .CreateAsync(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/treasury/credit_reversals");
        }

        [Fact]
        public void TestTreasuryDebitReversalsGet()
        {
            var options = new Stripe.Treasury.DebitReversalListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.DebitReversalService(
                this.StripeClient);
            StripeList<Stripe.Treasury.DebitReversal> debitReversals = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/debit_reversals",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public async Task TestTreasuryDebitReversalsGetAsync()
        {
            var options = new Stripe.Treasury.DebitReversalListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.DebitReversalService(
                this.StripeClient);
            StripeList<Stripe.Treasury.DebitReversal> debitReversals = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/debit_reversals",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public void TestTreasuryDebitReversalsGetAutoPaging()
        {
            var options = new Stripe.Treasury.DebitReversalListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.DebitReversalService(
                this.StripeClient);
            var debitReversal = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/debit_reversals",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public async Task TestTreasuryDebitReversalsGetAutoPagingAsync()
        {
            var options = new Stripe.Treasury.DebitReversalListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.DebitReversalService(
                this.StripeClient);
            var debitReversal = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/debit_reversals",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public void TestTreasuryDebitReversalsGet2()
        {
            var service = new Stripe.Treasury.DebitReversalService(
                this.StripeClient);
            Stripe.Treasury.DebitReversal debitReversal = service.Get(
                "debrev_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/debit_reversals/debrev_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestTreasuryDebitReversalsGet2Async()
        {
            var service = new Stripe.Treasury.DebitReversalService(
                this.StripeClient);
            Stripe.Treasury.DebitReversal debitReversal = await service
                .GetAsync("debrev_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/debit_reversals/debrev_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryDebitReversalsPost()
        {
            var options = new Stripe.Treasury.DebitReversalCreateOptions
            {
                ReceivedDebit = "rd_xxxxxxxxxxxxx",
            };
            var service = new Stripe.Treasury.DebitReversalService(
                this.StripeClient);
            Stripe.Treasury.DebitReversal debitReversal = service.Create(
                options);
            this.AssertRequest(HttpMethod.Post, "/v1/treasury/debit_reversals");
        }

        [Fact]
        public async Task TestTreasuryDebitReversalsPostAsync()
        {
            var options = new Stripe.Treasury.DebitReversalCreateOptions
            {
                ReceivedDebit = "rd_xxxxxxxxxxxxx",
            };
            var service = new Stripe.Treasury.DebitReversalService(
                this.StripeClient);
            Stripe.Treasury.DebitReversal debitReversal = await service
                .CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v1/treasury/debit_reversals");
        }

        [Fact]
        public void TestTreasuryFinancialAccountsFeaturesGet()
        {
            var service = new Stripe.Treasury.FinancialAccountFeaturesService(
                this.StripeClient);
            Stripe.Treasury.FinancialAccountFeatures financialAccountFeatures = service
                .Get("fa_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/financial_accounts/fa_xxxxxxxxxxxxx/features");
        }

        [Fact]
        public async Task TestTreasuryFinancialAccountsFeaturesGetAsync()
        {
            var service = new Stripe.Treasury.FinancialAccountFeaturesService(
                this.StripeClient);
            Stripe.Treasury.FinancialAccountFeatures financialAccountFeatures = await service
                .GetAsync("fa_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/financial_accounts/fa_xxxxxxxxxxxxx/features");
        }

        [Fact]
        public void TestTreasuryFinancialAccountsGet()
        {
            var options = new Stripe.Treasury.FinancialAccountListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Treasury.FinancialAccountService(
                this.StripeClient);
            StripeList<Stripe.Treasury.FinancialAccount> financialAccounts = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/financial_accounts",
                "limit=3");
        }

        [Fact]
        public async Task TestTreasuryFinancialAccountsGetAsync()
        {
            var options = new Stripe.Treasury.FinancialAccountListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Treasury.FinancialAccountService(
                this.StripeClient);
            StripeList<Stripe.Treasury.FinancialAccount> financialAccounts = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/financial_accounts",
                "limit=3");
        }

        [Fact]
        public void TestTreasuryFinancialAccountsGetAutoPaging()
        {
            var options = new Stripe.Treasury.FinancialAccountListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Treasury.FinancialAccountService(
                this.StripeClient);
            var financialAccount = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/financial_accounts",
                "limit=3");
        }

        [Fact]
        public async Task TestTreasuryFinancialAccountsGetAutoPagingAsync()
        {
            var options = new Stripe.Treasury.FinancialAccountListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Treasury.FinancialAccountService(
                this.StripeClient);
            var financialAccount = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/financial_accounts",
                "limit=3");
        }

        [Fact]
        public void TestTreasuryFinancialAccountsGet2()
        {
            var service = new Stripe.Treasury.FinancialAccountService(
                this.StripeClient);
            Stripe.Treasury.FinancialAccount financialAccount = service.Get(
                "fa_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/financial_accounts/fa_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestTreasuryFinancialAccountsGet2Async()
        {
            var service = new Stripe.Treasury.FinancialAccountService(
                this.StripeClient);
            Stripe.Treasury.FinancialAccount financialAccount = await service
                .GetAsync("fa_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/financial_accounts/fa_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryFinancialAccountsPost()
        {
            var options = new Stripe.Treasury.FinancialAccountCreateOptions
            {
                SupportedCurrencies = new List<string> { "usd" },
                Features = new Stripe.Treasury.FinancialAccountFeaturesOptions(),
            };
            var service = new Stripe.Treasury.FinancialAccountService(
                this.StripeClient);
            Stripe.Treasury.FinancialAccount financialAccount = service.Create(
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/treasury/financial_accounts");
        }

        [Fact]
        public async Task TestTreasuryFinancialAccountsPostAsync()
        {
            var options = new Stripe.Treasury.FinancialAccountCreateOptions
            {
                SupportedCurrencies = new List<string> { "usd" },
                Features = new Stripe.Treasury.FinancialAccountFeaturesOptions(),
            };
            var service = new Stripe.Treasury.FinancialAccountService(
                this.StripeClient);
            Stripe.Treasury.FinancialAccount financialAccount = await service
                .CreateAsync(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/treasury/financial_accounts");
        }

        [Fact]
        public void TestTreasuryFinancialAccountsPost2()
        {
            var options = new Stripe.Treasury.FinancialAccountUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new Stripe.Treasury.FinancialAccountService(
                this.StripeClient);
            Stripe.Treasury.FinancialAccount financialAccount = service.Update(
                "fa_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/treasury/financial_accounts/fa_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestTreasuryFinancialAccountsPost2Async()
        {
            var options = new Stripe.Treasury.FinancialAccountUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new Stripe.Treasury.FinancialAccountService(
                this.StripeClient);
            Stripe.Treasury.FinancialAccount financialAccount = await service
                .UpdateAsync("fa_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/treasury/financial_accounts/fa_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryInboundTransfersCancelPost()
        {
            var service = new Stripe.Treasury.InboundTransferService(
                this.StripeClient);
            Stripe.Treasury.InboundTransfer inboundTransfer = service.Cancel(
                "ibt_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/treasury/inbound_transfers/ibt_xxxxxxxxxxxxx/cancel");
        }

        [Fact]
        public async Task TestTreasuryInboundTransfersCancelPostAsync()
        {
            var service = new Stripe.Treasury.InboundTransferService(
                this.StripeClient);
            Stripe.Treasury.InboundTransfer inboundTransfer = await service
                .CancelAsync("ibt_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/treasury/inbound_transfers/ibt_xxxxxxxxxxxxx/cancel");
        }

        [Fact]
        public void TestTreasuryInboundTransfersGet()
        {
            var options = new Stripe.Treasury.InboundTransferListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.InboundTransferService(
                this.StripeClient);
            StripeList<Stripe.Treasury.InboundTransfer> inboundTransfers = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/inbound_transfers",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public async Task TestTreasuryInboundTransfersGetAsync()
        {
            var options = new Stripe.Treasury.InboundTransferListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.InboundTransferService(
                this.StripeClient);
            StripeList<Stripe.Treasury.InboundTransfer> inboundTransfers = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/inbound_transfers",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public void TestTreasuryInboundTransfersGetAutoPaging()
        {
            var options = new Stripe.Treasury.InboundTransferListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.InboundTransferService(
                this.StripeClient);
            var inboundTransfer = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/inbound_transfers",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public async Task TestTreasuryInboundTransfersGetAutoPagingAsync()
        {
            var options = new Stripe.Treasury.InboundTransferListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.InboundTransferService(
                this.StripeClient);
            var inboundTransfer = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/inbound_transfers",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public void TestTreasuryInboundTransfersGet2()
        {
            var service = new Stripe.Treasury.InboundTransferService(
                this.StripeClient);
            Stripe.Treasury.InboundTransfer inboundTransfer = service.Get(
                "ibt_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/inbound_transfers/ibt_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestTreasuryInboundTransfersGet2Async()
        {
            var service = new Stripe.Treasury.InboundTransferService(
                this.StripeClient);
            Stripe.Treasury.InboundTransfer inboundTransfer = await service
                .GetAsync("ibt_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/inbound_transfers/ibt_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryInboundTransfersPost()
        {
            var options = new Stripe.Treasury.InboundTransferCreateOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Amount = 10000,
                Currency = "usd",
                OriginPaymentMethod = "pm_xxxxxxxxxxxxx",
                Description = "InboundTransfer from my bank account",
            };
            var service = new Stripe.Treasury.InboundTransferService(
                this.StripeClient);
            Stripe.Treasury.InboundTransfer inboundTransfer = service.Create(
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/treasury/inbound_transfers");
        }

        [Fact]
        public async Task TestTreasuryInboundTransfersPostAsync()
        {
            var options = new Stripe.Treasury.InboundTransferCreateOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Amount = 10000,
                Currency = "usd",
                OriginPaymentMethod = "pm_xxxxxxxxxxxxx",
                Description = "InboundTransfer from my bank account",
            };
            var service = new Stripe.Treasury.InboundTransferService(
                this.StripeClient);
            Stripe.Treasury.InboundTransfer inboundTransfer = await service
                .CreateAsync(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/treasury/inbound_transfers");
        }

        [Fact]
        public void TestTreasuryOutboundPaymentsCancelPost()
        {
            var service = new Stripe.Treasury.OutboundPaymentService(
                this.StripeClient);
            Stripe.Treasury.OutboundPayment outboundPayment = service.Cancel(
                "bot_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/treasury/outbound_payments/bot_xxxxxxxxxxxxx/cancel");
        }

        [Fact]
        public async Task TestTreasuryOutboundPaymentsCancelPostAsync()
        {
            var service = new Stripe.Treasury.OutboundPaymentService(
                this.StripeClient);
            Stripe.Treasury.OutboundPayment outboundPayment = await service
                .CancelAsync("bot_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/treasury/outbound_payments/bot_xxxxxxxxxxxxx/cancel");
        }

        [Fact]
        public void TestTreasuryOutboundPaymentsGet()
        {
            var options = new Stripe.Treasury.OutboundPaymentListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.OutboundPaymentService(
                this.StripeClient);
            StripeList<Stripe.Treasury.OutboundPayment> outboundPayments = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/outbound_payments",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public async Task TestTreasuryOutboundPaymentsGetAsync()
        {
            var options = new Stripe.Treasury.OutboundPaymentListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.OutboundPaymentService(
                this.StripeClient);
            StripeList<Stripe.Treasury.OutboundPayment> outboundPayments = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/outbound_payments",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public void TestTreasuryOutboundPaymentsGetAutoPaging()
        {
            var options = new Stripe.Treasury.OutboundPaymentListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.OutboundPaymentService(
                this.StripeClient);
            var outboundPayment = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/outbound_payments",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public async Task TestTreasuryOutboundPaymentsGetAutoPagingAsync()
        {
            var options = new Stripe.Treasury.OutboundPaymentListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.OutboundPaymentService(
                this.StripeClient);
            var outboundPayment = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/outbound_payments",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public void TestTreasuryOutboundPaymentsGet2()
        {
            var service = new Stripe.Treasury.OutboundPaymentService(
                this.StripeClient);
            Stripe.Treasury.OutboundPayment outboundPayment = service.Get(
                "bot_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/outbound_payments/bot_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestTreasuryOutboundPaymentsGet2Async()
        {
            var service = new Stripe.Treasury.OutboundPaymentService(
                this.StripeClient);
            Stripe.Treasury.OutboundPayment outboundPayment = await service
                .GetAsync("bot_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/outbound_payments/bot_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryOutboundPaymentsPost()
        {
            var options = new Stripe.Treasury.OutboundPaymentCreateOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Amount = 10000,
                Currency = "usd",
                Customer = "cus_xxxxxxxxxxxxx",
                DestinationPaymentMethod = "pm_xxxxxxxxxxxxx",
                Description = "OutboundPayment to a 3rd party",
            };
            var service = new Stripe.Treasury.OutboundPaymentService(
                this.StripeClient);
            Stripe.Treasury.OutboundPayment outboundPayment = service.Create(
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/treasury/outbound_payments");
        }

        [Fact]
        public async Task TestTreasuryOutboundPaymentsPostAsync()
        {
            var options = new Stripe.Treasury.OutboundPaymentCreateOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Amount = 10000,
                Currency = "usd",
                Customer = "cus_xxxxxxxxxxxxx",
                DestinationPaymentMethod = "pm_xxxxxxxxxxxxx",
                Description = "OutboundPayment to a 3rd party",
            };
            var service = new Stripe.Treasury.OutboundPaymentService(
                this.StripeClient);
            Stripe.Treasury.OutboundPayment outboundPayment = await service
                .CreateAsync(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/treasury/outbound_payments");
        }

        [Fact]
        public void TestTreasuryOutboundTransfersCancelPost()
        {
            var service = new Stripe.Treasury.OutboundTransferService(
                this.StripeClient);
            Stripe.Treasury.OutboundTransfer outboundTransfer = service.Cancel(
                "obt_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/treasury/outbound_transfers/obt_xxxxxxxxxxxxx/cancel");
        }

        [Fact]
        public async Task TestTreasuryOutboundTransfersCancelPostAsync()
        {
            var service = new Stripe.Treasury.OutboundTransferService(
                this.StripeClient);
            Stripe.Treasury.OutboundTransfer outboundTransfer = await service
                .CancelAsync("obt_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/treasury/outbound_transfers/obt_xxxxxxxxxxxxx/cancel");
        }

        [Fact]
        public void TestTreasuryOutboundTransfersGet()
        {
            var options = new Stripe.Treasury.OutboundTransferListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.OutboundTransferService(
                this.StripeClient);
            StripeList<Stripe.Treasury.OutboundTransfer> outboundTransfers = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/outbound_transfers",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public async Task TestTreasuryOutboundTransfersGetAsync()
        {
            var options = new Stripe.Treasury.OutboundTransferListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.OutboundTransferService(
                this.StripeClient);
            StripeList<Stripe.Treasury.OutboundTransfer> outboundTransfers = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/outbound_transfers",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public void TestTreasuryOutboundTransfersGetAutoPaging()
        {
            var options = new Stripe.Treasury.OutboundTransferListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.OutboundTransferService(
                this.StripeClient);
            var outboundTransfer = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/outbound_transfers",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public async Task TestTreasuryOutboundTransfersGetAutoPagingAsync()
        {
            var options = new Stripe.Treasury.OutboundTransferListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.OutboundTransferService(
                this.StripeClient);
            var outboundTransfer = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/outbound_transfers",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public void TestTreasuryOutboundTransfersGet2()
        {
            var service = new Stripe.Treasury.OutboundTransferService(
                this.StripeClient);
            Stripe.Treasury.OutboundTransfer outboundTransfer = service.Get(
                "obt_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/outbound_transfers/obt_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestTreasuryOutboundTransfersGet2Async()
        {
            var service = new Stripe.Treasury.OutboundTransferService(
                this.StripeClient);
            Stripe.Treasury.OutboundTransfer outboundTransfer = await service
                .GetAsync("obt_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/outbound_transfers/obt_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryOutboundTransfersPost()
        {
            var options = new Stripe.Treasury.OutboundTransferCreateOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                DestinationPaymentMethod = "pm_xxxxxxxxxxxxx",
                Amount = 500,
                Currency = "usd",
                Description = "OutboundTransfer to my external bank account",
            };
            var service = new Stripe.Treasury.OutboundTransferService(
                this.StripeClient);
            Stripe.Treasury.OutboundTransfer outboundTransfer = service.Create(
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/treasury/outbound_transfers");
        }

        [Fact]
        public async Task TestTreasuryOutboundTransfersPostAsync()
        {
            var options = new Stripe.Treasury.OutboundTransferCreateOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                DestinationPaymentMethod = "pm_xxxxxxxxxxxxx",
                Amount = 500,
                Currency = "usd",
                Description = "OutboundTransfer to my external bank account",
            };
            var service = new Stripe.Treasury.OutboundTransferService(
                this.StripeClient);
            Stripe.Treasury.OutboundTransfer outboundTransfer = await service
                .CreateAsync(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/treasury/outbound_transfers");
        }

        [Fact]
        public void TestTreasuryReceivedCreditsGet()
        {
            var options = new Stripe.Treasury.ReceivedCreditListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.ReceivedCreditService(
                this.StripeClient);
            StripeList<Stripe.Treasury.ReceivedCredit> receivedCredits = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/received_credits",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public async Task TestTreasuryReceivedCreditsGetAsync()
        {
            var options = new Stripe.Treasury.ReceivedCreditListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.ReceivedCreditService(
                this.StripeClient);
            StripeList<Stripe.Treasury.ReceivedCredit> receivedCredits = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/received_credits",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public void TestTreasuryReceivedCreditsGetAutoPaging()
        {
            var options = new Stripe.Treasury.ReceivedCreditListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.ReceivedCreditService(
                this.StripeClient);
            var receivedCredit = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/received_credits",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public async Task TestTreasuryReceivedCreditsGetAutoPagingAsync()
        {
            var options = new Stripe.Treasury.ReceivedCreditListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.ReceivedCreditService(
                this.StripeClient);
            var receivedCredit = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/received_credits",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public void TestTreasuryReceivedCreditsGet2()
        {
            var service = new Stripe.Treasury.ReceivedCreditService(
                this.StripeClient);
            Stripe.Treasury.ReceivedCredit receivedCredit = service.Get(
                "rc_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/received_credits/rc_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestTreasuryReceivedCreditsGet2Async()
        {
            var service = new Stripe.Treasury.ReceivedCreditService(
                this.StripeClient);
            Stripe.Treasury.ReceivedCredit receivedCredit = await service
                .GetAsync("rc_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/received_credits/rc_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryReceivedDebitsGet()
        {
            var options = new Stripe.Treasury.ReceivedDebitListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.ReceivedDebitService(
                this.StripeClient);
            StripeList<Stripe.Treasury.ReceivedDebit> receivedDebits = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/received_debits",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public async Task TestTreasuryReceivedDebitsGetAsync()
        {
            var options = new Stripe.Treasury.ReceivedDebitListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.ReceivedDebitService(
                this.StripeClient);
            StripeList<Stripe.Treasury.ReceivedDebit> receivedDebits = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/received_debits",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public void TestTreasuryReceivedDebitsGetAutoPaging()
        {
            var options = new Stripe.Treasury.ReceivedDebitListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.ReceivedDebitService(
                this.StripeClient);
            var receivedDebit = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/received_debits",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public async Task TestTreasuryReceivedDebitsGetAutoPagingAsync()
        {
            var options = new Stripe.Treasury.ReceivedDebitListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.ReceivedDebitService(
                this.StripeClient);
            var receivedDebit = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/received_debits",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public void TestTreasuryReceivedDebitsGet2()
        {
            var service = new Stripe.Treasury.ReceivedDebitService(
                this.StripeClient);
            Stripe.Treasury.ReceivedDebit receivedDebit = service.Get(
                "rd_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/received_debits/rd_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestTreasuryReceivedDebitsGet2Async()
        {
            var service = new Stripe.Treasury.ReceivedDebitService(
                this.StripeClient);
            Stripe.Treasury.ReceivedDebit receivedDebit = await service
                .GetAsync("rd_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/received_debits/rd_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryTransactionEntriesGet()
        {
            var options = new Stripe.Treasury.TransactionEntryListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.TransactionEntryService(
                this.StripeClient);
            StripeList<Stripe.Treasury.TransactionEntry> transactionEntries = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/transaction_entries",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public async Task TestTreasuryTransactionEntriesGetAsync()
        {
            var options = new Stripe.Treasury.TransactionEntryListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.TransactionEntryService(
                this.StripeClient);
            StripeList<Stripe.Treasury.TransactionEntry> transactionEntries = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/transaction_entries",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public void TestTreasuryTransactionEntriesGetAutoPaging()
        {
            var options = new Stripe.Treasury.TransactionEntryListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.TransactionEntryService(
                this.StripeClient);
            var transactionEntry = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/transaction_entries",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public async Task TestTreasuryTransactionEntriesGetAutoPagingAsync()
        {
            var options = new Stripe.Treasury.TransactionEntryListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.TransactionEntryService(
                this.StripeClient);
            var transactionEntry = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/transaction_entries",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public void TestTreasuryTransactionEntriesGet2()
        {
            var service = new Stripe.Treasury.TransactionEntryService(
                this.StripeClient);
            Stripe.Treasury.TransactionEntry transactionEntry = service.Get(
                "trxne_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/transaction_entries/trxne_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestTreasuryTransactionEntriesGet2Async()
        {
            var service = new Stripe.Treasury.TransactionEntryService(
                this.StripeClient);
            Stripe.Treasury.TransactionEntry transactionEntry = await service
                .GetAsync("trxne_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/transaction_entries/trxne_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryTransactionsGet()
        {
            var options = new Stripe.Treasury.TransactionListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.TransactionService(
                this.StripeClient);
            StripeList<Stripe.Treasury.Transaction> transactions = service.List(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/transactions",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public async Task TestTreasuryTransactionsGetAsync()
        {
            var options = new Stripe.Treasury.TransactionListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.TransactionService(
                this.StripeClient);
            StripeList<Stripe.Treasury.Transaction> transactions = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/transactions",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public void TestTreasuryTransactionsGetAutoPaging()
        {
            var options = new Stripe.Treasury.TransactionListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.TransactionService(
                this.StripeClient);
            var transaction = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/transactions",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public async Task TestTreasuryTransactionsGetAutoPagingAsync()
        {
            var options = new Stripe.Treasury.TransactionListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.TransactionService(
                this.StripeClient);
            var transaction = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/transactions",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public void TestTreasuryTransactionsGet2()
        {
            var service = new Stripe.Treasury.TransactionService(
                this.StripeClient);
            Stripe.Treasury.Transaction transaction = service.Get(
                "trxn_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/transactions/trxn_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestTreasuryTransactionsGet2Async()
        {
            var service = new Stripe.Treasury.TransactionService(
                this.StripeClient);
            Stripe.Treasury.Transaction transaction = await service.GetAsync(
                "trxn_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/transactions/trxn_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestWebhookEndpointsDelete()
        {
            var service = new WebhookEndpointService(this.StripeClient);
            WebhookEndpoint deleted = service.Delete("we_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/webhook_endpoints/we_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestWebhookEndpointsDeleteAsync()
        {
            var service = new WebhookEndpointService(this.StripeClient);
            WebhookEndpoint deleted = await service.DeleteAsync(
                "we_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/webhook_endpoints/we_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestWebhookEndpointsGet()
        {
            var options = new WebhookEndpointListOptions { Limit = 3 };
            var service = new WebhookEndpointService(this.StripeClient);
            StripeList<WebhookEndpoint> webhookEndpoints = service.List(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/webhook_endpoints",
                "limit=3");
        }

        [Fact]
        public async Task TestWebhookEndpointsGetAsync()
        {
            var options = new WebhookEndpointListOptions { Limit = 3 };
            var service = new WebhookEndpointService(this.StripeClient);
            StripeList<WebhookEndpoint> webhookEndpoints = await service
                .ListAsync(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/webhook_endpoints",
                "limit=3");
        }

        [Fact]
        public void TestWebhookEndpointsGetAutoPaging()
        {
            var options = new WebhookEndpointListOptions { Limit = 3 };
            var service = new WebhookEndpointService(this.StripeClient);
            var webhookEndpoint = service.ListAutoPaging(options).First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/webhook_endpoints",
                "limit=3");
        }

        [Fact]
        public async Task TestWebhookEndpointsGetAutoPagingAsync()
        {
            var options = new WebhookEndpointListOptions { Limit = 3 };
            var service = new WebhookEndpointService(this.StripeClient);
            var webhookEndpoint = await service.ListAutoPagingAsync(options)
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/webhook_endpoints",
                "limit=3");
        }

        [Fact]
        public void TestWebhookEndpointsGet2()
        {
            var service = new WebhookEndpointService(this.StripeClient);
            WebhookEndpoint webhookEndpoint = service.Get("we_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/webhook_endpoints/we_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestWebhookEndpointsGet2Async()
        {
            var service = new WebhookEndpointService(this.StripeClient);
            WebhookEndpoint webhookEndpoint = await service.GetAsync(
                "we_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/webhook_endpoints/we_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestWebhookEndpointsPost()
        {
            var options = new WebhookEndpointCreateOptions
            {
                Url = "https://example.com/my/webhook/endpoint",
                EnabledEvents = new List<string>
                {
                    "charge.failed",
                    "charge.succeeded",
                },
            };
            var service = new WebhookEndpointService(this.StripeClient);
            WebhookEndpoint webhookEndpoint = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/webhook_endpoints");
        }

        [Fact]
        public async Task TestWebhookEndpointsPostAsync()
        {
            var options = new WebhookEndpointCreateOptions
            {
                Url = "https://example.com/my/webhook/endpoint",
                EnabledEvents = new List<string>
                {
                    "charge.failed",
                    "charge.succeeded",
                },
            };
            var service = new WebhookEndpointService(this.StripeClient);
            WebhookEndpoint webhookEndpoint = await service.CreateAsync(
                options);
            this.AssertRequest(HttpMethod.Post, "/v1/webhook_endpoints");
        }

        [Fact]
        public void TestWebhookEndpointsPost2()
        {
            var options = new WebhookEndpointUpdateOptions
            {
                Url = "https://example.com/new_endpoint",
            };
            var service = new WebhookEndpointService(this.StripeClient);
            WebhookEndpoint webhookEndpoint = service.Update(
                "we_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/webhook_endpoints/we_xxxxxxxxxxxxx");
        }

        [Fact]
        public async Task TestWebhookEndpointsPost2Async()
        {
            var options = new WebhookEndpointUpdateOptions
            {
                Url = "https://example.com/new_endpoint",
            };
            var service = new WebhookEndpointService(this.StripeClient);
            WebhookEndpoint webhookEndpoint = await service.UpdateAsync(
                "we_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/webhook_endpoints/we_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestV2BillingMeterEventPost()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/billing/meter_events",
                (HttpStatusCode)200,
                "{\"object\":\"v2.billing.meter_event\",\"created\":\"1970-01-12T21:42:34.472Z\",\"event_name\":\"event_name\",\"identifier\":\"identifier\",\"livemode\":true,\"payload\":{\"key\":\"payload\"},\"timestamp\":\"1970-01-01T15:18:46.294Z\"}");
            var options = new Stripe.V2.Billing.MeterEventCreateOptions
            {
                EventName = "event_name",
                Payload = new Dictionary<string, string>
                {
                    { "key", "payload" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Billing.MeterEvents;
            Stripe.V2.Billing.MeterEvent meterEvent = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v2/billing/meter_events");
        }

        [Fact]
        public async Task TestV2BillingMeterEventPostAsync()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/billing/meter_events",
                (HttpStatusCode)200,
                "{\"object\":\"v2.billing.meter_event\",\"created\":\"1970-01-12T21:42:34.472Z\",\"event_name\":\"event_name\",\"identifier\":\"identifier\",\"livemode\":true,\"payload\":{\"key\":\"payload\"},\"timestamp\":\"1970-01-01T15:18:46.294Z\"}");
            var options = new Stripe.V2.Billing.MeterEventCreateOptions
            {
                EventName = "event_name",
                Payload = new Dictionary<string, string>
                {
                    { "key", "payload" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Billing.MeterEvents;
            Stripe.V2.Billing.MeterEvent meterEvent = await service.CreateAsync(
                options);
            this.AssertRequest(HttpMethod.Post, "/v2/billing/meter_events");
        }

        [Fact]
        public void TestV2BillingMeterEventAdjustmentPost()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/billing/meter_event_adjustments",
                (HttpStatusCode)200,
                "{\"object\":\"v2.billing.meter_event_adjustment\",\"cancel\":{\"identifier\":\"identifier\"},\"created\":\"1970-01-12T21:42:34.472Z\",\"event_name\":\"event_name\",\"id\":\"obj_123\",\"livemode\":true,\"status\":\"complete\",\"type\":\"cancel\"}");
            var options = new Stripe.V2.Billing.MeterEventAdjustmentCreateOptions
            {
                Cancel = new Stripe.V2.Billing.MeterEventAdjustmentCreateCancelOptions
                {
                    Identifier = "identifier",
                },
                EventName = "event_name",
                Type = "cancel",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Billing.MeterEventAdjustments;
            Stripe.V2.Billing.MeterEventAdjustment meterEventAdjustment = service
                .Create(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/billing/meter_event_adjustments");
        }

        [Fact]
        public async Task TestV2BillingMeterEventAdjustmentPostAsync()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/billing/meter_event_adjustments",
                (HttpStatusCode)200,
                "{\"object\":\"v2.billing.meter_event_adjustment\",\"cancel\":{\"identifier\":\"identifier\"},\"created\":\"1970-01-12T21:42:34.472Z\",\"event_name\":\"event_name\",\"id\":\"obj_123\",\"livemode\":true,\"status\":\"complete\",\"type\":\"cancel\"}");
            var options = new Stripe.V2.Billing.MeterEventAdjustmentCreateOptions
            {
                Cancel = new Stripe.V2.Billing.MeterEventAdjustmentCreateCancelOptions
                {
                    Identifier = "identifier",
                },
                EventName = "event_name",
                Type = "cancel",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Billing.MeterEventAdjustments;
            Stripe.V2.Billing.MeterEventAdjustment meterEventAdjustment = await service
                .CreateAsync(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/billing/meter_event_adjustments");
        }

        [Fact]
        public void TestV2BillingMeterEventSessionPost()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/billing/meter_event_session",
                (HttpStatusCode)200,
                "{\"object\":\"v2.billing.meter_event_session\",\"authentication_token\":\"authentication_token\",\"created\":\"1970-01-12T21:42:34.472Z\",\"expires_at\":\"1970-01-10T15:36:51.170Z\",\"id\":\"obj_123\",\"livemode\":true}");
            var options = new Stripe.V2.Billing.MeterEventSessionCreateOptions();
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Billing.MeterEventSession;
            Stripe.V2.Billing.MeterEventSession meterEventSession = service
                .Create(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/billing/meter_event_session");
        }

        [Fact]
        public async Task TestV2BillingMeterEventSessionPostAsync()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/billing/meter_event_session",
                (HttpStatusCode)200,
                "{\"object\":\"v2.billing.meter_event_session\",\"authentication_token\":\"authentication_token\",\"created\":\"1970-01-12T21:42:34.472Z\",\"expires_at\":\"1970-01-10T15:36:51.170Z\",\"id\":\"obj_123\",\"livemode\":true}");
            var options = new Stripe.V2.Billing.MeterEventSessionCreateOptions();
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Billing.MeterEventSession;
            Stripe.V2.Billing.MeterEventSession meterEventSession = await service
                .CreateAsync(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/billing/meter_event_session");
        }

        [Fact]
        public void TestV2BillingMeterEventStreamPost()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/billing/meter_event_stream",
                (HttpStatusCode)200,
                "{}");
            var options = new Stripe.V2.Billing.MeterEventStreamCreateOptions
            {
                Events = new List<Stripe.V2.Billing.MeterEventStreamCreateEventOptions>
                {
                    new Stripe.V2.Billing.MeterEventStreamCreateEventOptions
                    {
                        EventName = "event_name",
                        Identifier = "identifier",
                        Payload = new Dictionary<string, string>
                        {
                            { "key", "payload" },
                        },
                        Timestamp = DateTimeOffset.Parse(
                            "1970-01-01T15:18:46.294Z")
                            .UtcDateTime,
                    },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Billing.MeterEventStream;
            service.Create(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/billing/meter_event_stream");
        }

        [Fact]
        public async Task TestV2BillingMeterEventStreamPostAsync()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/billing/meter_event_stream",
                (HttpStatusCode)200,
                "{}");
            var options = new Stripe.V2.Billing.MeterEventStreamCreateOptions
            {
                Events = new List<Stripe.V2.Billing.MeterEventStreamCreateEventOptions>
                {
                    new Stripe.V2.Billing.MeterEventStreamCreateEventOptions
                    {
                        EventName = "event_name",
                        Identifier = "identifier",
                        Payload = new Dictionary<string, string>
                        {
                            { "key", "payload" },
                        },
                        Timestamp = DateTimeOffset.Parse(
                            "1970-01-01T15:18:46.294Z")
                            .UtcDateTime,
                    },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Billing.MeterEventStream;
            await service.CreateAsync(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/billing/meter_event_stream");
        }

        [Fact]
        public void TestV2CommerceProductCatalogImportGet()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/commerce/product_catalog/imports",
                (HttpStatusCode)200,
                "{\"data\":[{\"object\":\"v2.commerce.product_catalog_import\",\"created\":\"1970-01-12T21:42:34.472Z\",\"feed_type\":\"pricing\",\"id\":\"obj_123\",\"livemode\":true,\"metadata\":{\"key\":\"metadata\"},\"status\":\"awaiting_upload\"}],\"next_page_url\":null,\"previous_page_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Commerce.ProductCatalog.Imports;
            Stripe.V2.StripeList<Stripe.V2.Commerce.ProductCatalogImport> productCatalogImports = service
                .List();
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/commerce/product_catalog/imports");
        }

        [Fact]
        public async Task TestV2CommerceProductCatalogImportGetAsync()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/commerce/product_catalog/imports",
                (HttpStatusCode)200,
                "{\"data\":[{\"object\":\"v2.commerce.product_catalog_import\",\"created\":\"1970-01-12T21:42:34.472Z\",\"feed_type\":\"pricing\",\"id\":\"obj_123\",\"livemode\":true,\"metadata\":{\"key\":\"metadata\"},\"status\":\"awaiting_upload\"}],\"next_page_url\":null,\"previous_page_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Commerce.ProductCatalog.Imports;
            Stripe.V2.StripeList<Stripe.V2.Commerce.ProductCatalogImport> productCatalogImports = await service
                .ListAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/commerce/product_catalog/imports");
        }

        [Fact]
        public void TestV2CommerceProductCatalogImportGetAutoPaging()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/commerce/product_catalog/imports",
                (HttpStatusCode)200,
                "{\"data\":[{\"object\":\"v2.commerce.product_catalog_import\",\"created\":\"1970-01-12T21:42:34.472Z\",\"feed_type\":\"pricing\",\"id\":\"obj_123\",\"livemode\":true,\"metadata\":{\"key\":\"metadata\"},\"status\":\"awaiting_upload\"}],\"next_page_url\":null,\"previous_page_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Commerce.ProductCatalog.Imports;
            var productCatalogImport = service.ListAutoPaging().First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/commerce/product_catalog/imports");
        }

        [Fact]
        public async Task TestV2CommerceProductCatalogImportGetAutoPagingAsync()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/commerce/product_catalog/imports",
                (HttpStatusCode)200,
                "{\"data\":[{\"object\":\"v2.commerce.product_catalog_import\",\"created\":\"1970-01-12T21:42:34.472Z\",\"feed_type\":\"pricing\",\"id\":\"obj_123\",\"livemode\":true,\"metadata\":{\"key\":\"metadata\"},\"status\":\"awaiting_upload\"}],\"next_page_url\":null,\"previous_page_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Commerce.ProductCatalog.Imports;
            var productCatalogImport = await service.ListAutoPagingAsync()
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/commerce/product_catalog/imports");
        }

        [Fact]
        public void TestV2CommerceProductCatalogImportPost()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/commerce/product_catalog/imports",
                (HttpStatusCode)200,
                "{\"object\":\"v2.commerce.product_catalog_import\",\"created\":\"1970-01-12T21:42:34.472Z\",\"feed_type\":\"pricing\",\"id\":\"obj_123\",\"livemode\":true,\"metadata\":{\"key\":\"metadata\"},\"status\":\"awaiting_upload\"}");
            var options = new Stripe.V2.Commerce.ProductCatalog.ImportCreateOptions
            {
                FeedType = "pricing",
                Metadata = new Dictionary<string, string>
                {
                    { "key", "metadata" },
                },
                Mode = "upsert",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Commerce.ProductCatalog.Imports;
            Stripe.V2.Commerce.ProductCatalogImport productCatalogImport = service
                .Create(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/commerce/product_catalog/imports");
        }

        [Fact]
        public async Task TestV2CommerceProductCatalogImportPostAsync()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/commerce/product_catalog/imports",
                (HttpStatusCode)200,
                "{\"object\":\"v2.commerce.product_catalog_import\",\"created\":\"1970-01-12T21:42:34.472Z\",\"feed_type\":\"pricing\",\"id\":\"obj_123\",\"livemode\":true,\"metadata\":{\"key\":\"metadata\"},\"status\":\"awaiting_upload\"}");
            var options = new Stripe.V2.Commerce.ProductCatalog.ImportCreateOptions
            {
                FeedType = "pricing",
                Metadata = new Dictionary<string, string>
                {
                    { "key", "metadata" },
                },
                Mode = "upsert",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Commerce.ProductCatalog.Imports;
            Stripe.V2.Commerce.ProductCatalogImport productCatalogImport = await service
                .CreateAsync(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/commerce/product_catalog/imports");
        }

        [Fact]
        public void TestV2CommerceProductCatalogImportGet2()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/commerce/product_catalog/imports/id_123",
                (HttpStatusCode)200,
                "{\"object\":\"v2.commerce.product_catalog_import\",\"created\":\"1970-01-12T21:42:34.472Z\",\"feed_type\":\"pricing\",\"id\":\"obj_123\",\"livemode\":true,\"metadata\":{\"key\":\"metadata\"},\"status\":\"awaiting_upload\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Commerce.ProductCatalog.Imports;
            Stripe.V2.Commerce.ProductCatalogImport productCatalogImport = service
                .Get("id_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/commerce/product_catalog/imports/id_123");
        }

        [Fact]
        public async Task TestV2CommerceProductCatalogImportGet2Async()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/commerce/product_catalog/imports/id_123",
                (HttpStatusCode)200,
                "{\"object\":\"v2.commerce.product_catalog_import\",\"created\":\"1970-01-12T21:42:34.472Z\",\"feed_type\":\"pricing\",\"id\":\"obj_123\",\"livemode\":true,\"metadata\":{\"key\":\"metadata\"},\"status\":\"awaiting_upload\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Commerce.ProductCatalog.Imports;
            Stripe.V2.Commerce.ProductCatalogImport productCatalogImport = await service
                .GetAsync("id_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/commerce/product_catalog/imports/id_123");
        }

        [Fact]
        public void TestV2CoreAccountGet()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/accounts",
                (HttpStatusCode)200,
                "{\"data\":[{\"object\":\"v2.core.account\",\"applied_configurations\":[\"recipient\"],\"created\":\"1970-01-12T21:42:34.472Z\",\"id\":\"obj_123\",\"livemode\":true}],\"next_page_url\":null,\"previous_page_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts;
            Stripe.V2.StripeList<Stripe.V2.Core.Account> accounts = service
                .List();
            this.AssertRequest(HttpMethod.Get, "/v2/core/accounts");
        }

        [Fact]
        public async Task TestV2CoreAccountGetAsync()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/accounts",
                (HttpStatusCode)200,
                "{\"data\":[{\"object\":\"v2.core.account\",\"applied_configurations\":[\"recipient\"],\"created\":\"1970-01-12T21:42:34.472Z\",\"id\":\"obj_123\",\"livemode\":true}],\"next_page_url\":null,\"previous_page_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts;
            Stripe.V2.StripeList<Stripe.V2.Core.Account> accounts = await service
                .ListAsync();
            this.AssertRequest(HttpMethod.Get, "/v2/core/accounts");
        }

        [Fact]
        public void TestV2CoreAccountGetAutoPaging()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/accounts",
                (HttpStatusCode)200,
                "{\"data\":[{\"object\":\"v2.core.account\",\"applied_configurations\":[\"recipient\"],\"created\":\"1970-01-12T21:42:34.472Z\",\"id\":\"obj_123\",\"livemode\":true}],\"next_page_url\":null,\"previous_page_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts;
            var account = service.ListAutoPaging().First();
            this.AssertRequest(HttpMethod.Get, "/v2/core/accounts");
        }

        [Fact]
        public async Task TestV2CoreAccountGetAutoPagingAsync()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/accounts",
                (HttpStatusCode)200,
                "{\"data\":[{\"object\":\"v2.core.account\",\"applied_configurations\":[\"recipient\"],\"created\":\"1970-01-12T21:42:34.472Z\",\"id\":\"obj_123\",\"livemode\":true}],\"next_page_url\":null,\"previous_page_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts;
            var account = await service.ListAutoPagingAsync().FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v2/core/accounts");
        }

        [Fact]
        public void TestV2CoreAccountPost()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/accounts",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.account\",\"applied_configurations\":[\"recipient\"],\"created\":\"1970-01-12T21:42:34.472Z\",\"id\":\"obj_123\",\"livemode\":true}");
            var options = new Stripe.V2.Core.AccountCreateOptions();
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts;
            Stripe.V2.Core.Account account = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v2/core/accounts");
        }

        [Fact]
        public async Task TestV2CoreAccountPostAsync()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/accounts",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.account\",\"applied_configurations\":[\"recipient\"],\"created\":\"1970-01-12T21:42:34.472Z\",\"id\":\"obj_123\",\"livemode\":true}");
            var options = new Stripe.V2.Core.AccountCreateOptions();
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts;
            Stripe.V2.Core.Account account = await service.CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v2/core/accounts");
        }

        [Fact]
        public void TestV2CoreAccountGet2()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/accounts/id_123",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.account\",\"applied_configurations\":[\"recipient\"],\"created\":\"1970-01-12T21:42:34.472Z\",\"id\":\"obj_123\",\"livemode\":true}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts;
            Stripe.V2.Core.Account account = service.Get("id_123");
            this.AssertRequest(HttpMethod.Get, "/v2/core/accounts/id_123");
        }

        [Fact]
        public async Task TestV2CoreAccountGet2Async()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/accounts/id_123",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.account\",\"applied_configurations\":[\"recipient\"],\"created\":\"1970-01-12T21:42:34.472Z\",\"id\":\"obj_123\",\"livemode\":true}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts;
            Stripe.V2.Core.Account account = await service.GetAsync("id_123");
            this.AssertRequest(HttpMethod.Get, "/v2/core/accounts/id_123");
        }

        [Fact]
        public void TestV2CoreAccountPost2()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/accounts/id_123",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.account\",\"applied_configurations\":[\"recipient\"],\"created\":\"1970-01-12T21:42:34.472Z\",\"id\":\"obj_123\",\"livemode\":true}");
            var options = new Stripe.V2.Core.AccountUpdateOptions();
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts;
            Stripe.V2.Core.Account account = service.Update("id_123", options);
            this.AssertRequest(HttpMethod.Post, "/v2/core/accounts/id_123");
        }

        [Fact]
        public async Task TestV2CoreAccountPost2Async()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/accounts/id_123",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.account\",\"applied_configurations\":[\"recipient\"],\"created\":\"1970-01-12T21:42:34.472Z\",\"id\":\"obj_123\",\"livemode\":true}");
            var options = new Stripe.V2.Core.AccountUpdateOptions();
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts;
            Stripe.V2.Core.Account account = await service.UpdateAsync(
                "id_123",
                options);
            this.AssertRequest(HttpMethod.Post, "/v2/core/accounts/id_123");
        }

        [Fact]
        public void TestV2CoreAccountPost3()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/accounts/id_123/close",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.account\",\"applied_configurations\":[\"recipient\"],\"created\":\"1970-01-12T21:42:34.472Z\",\"id\":\"obj_123\",\"livemode\":true}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts;
            Stripe.V2.Core.Account account = service.Close("id_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/core/accounts/id_123/close");
        }

        [Fact]
        public async Task TestV2CoreAccountPost3Async()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/accounts/id_123/close",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.account\",\"applied_configurations\":[\"recipient\"],\"created\":\"1970-01-12T21:42:34.472Z\",\"id\":\"obj_123\",\"livemode\":true}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts;
            Stripe.V2.Core.Account account = await service.CloseAsync("id_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/core/accounts/id_123/close");
        }

        [Fact]
        public void TestV2CoreAccountsPersonGet()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/accounts/account_id_123/persons",
                (HttpStatusCode)200,
                "{\"data\":[{\"object\":\"v2.core.account_person\",\"account\":\"account\",\"created\":\"1970-01-12T21:42:34.472Z\",\"id\":\"obj_123\",\"livemode\":true,\"updated\":\"1970-01-03T17:07:10.277Z\"}],\"next_page_url\":null,\"previous_page_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts.Persons;
            Stripe.V2.StripeList<Stripe.V2.Core.AccountPerson> accountPersons = service
                .List("account_id_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/core/accounts/account_id_123/persons");
        }

        [Fact]
        public async Task TestV2CoreAccountsPersonGetAsync()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/accounts/account_id_123/persons",
                (HttpStatusCode)200,
                "{\"data\":[{\"object\":\"v2.core.account_person\",\"account\":\"account\",\"created\":\"1970-01-12T21:42:34.472Z\",\"id\":\"obj_123\",\"livemode\":true,\"updated\":\"1970-01-03T17:07:10.277Z\"}],\"next_page_url\":null,\"previous_page_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts.Persons;
            Stripe.V2.StripeList<Stripe.V2.Core.AccountPerson> accountPersons = await service
                .ListAsync("account_id_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/core/accounts/account_id_123/persons");
        }

        [Fact]
        public void TestV2CoreAccountsPersonGetAutoPaging()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/accounts/account_id_123/persons",
                (HttpStatusCode)200,
                "{\"data\":[{\"object\":\"v2.core.account_person\",\"account\":\"account\",\"created\":\"1970-01-12T21:42:34.472Z\",\"id\":\"obj_123\",\"livemode\":true,\"updated\":\"1970-01-03T17:07:10.277Z\"}],\"next_page_url\":null,\"previous_page_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts.Persons;
            var accountPerson = service.ListAutoPaging("account_id_123")
                .First();
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/core/accounts/account_id_123/persons");
        }

        [Fact]
        public async Task TestV2CoreAccountsPersonGetAutoPagingAsync()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/accounts/account_id_123/persons",
                (HttpStatusCode)200,
                "{\"data\":[{\"object\":\"v2.core.account_person\",\"account\":\"account\",\"created\":\"1970-01-12T21:42:34.472Z\",\"id\":\"obj_123\",\"livemode\":true,\"updated\":\"1970-01-03T17:07:10.277Z\"}],\"next_page_url\":null,\"previous_page_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts.Persons;
            var accountPerson = await service.ListAutoPagingAsync(
                "account_id_123")
                .FirstAsync();
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/core/accounts/account_id_123/persons");
        }

        [Fact]
        public void TestV2CoreAccountsPersonPost()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/accounts/account_id_123/persons",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.account_person\",\"account\":\"account\",\"created\":\"1970-01-12T21:42:34.472Z\",\"id\":\"obj_123\",\"livemode\":true,\"updated\":\"1970-01-03T17:07:10.277Z\"}");
            var options = new Stripe.V2.Core.Accounts.PersonCreateOptions();
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts.Persons;
            Stripe.V2.Core.AccountPerson accountPerson = service.Create(
                "account_id_123",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/core/accounts/account_id_123/persons");
        }

        [Fact]
        public async Task TestV2CoreAccountsPersonPostAsync()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/accounts/account_id_123/persons",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.account_person\",\"account\":\"account\",\"created\":\"1970-01-12T21:42:34.472Z\",\"id\":\"obj_123\",\"livemode\":true,\"updated\":\"1970-01-03T17:07:10.277Z\"}");
            var options = new Stripe.V2.Core.Accounts.PersonCreateOptions();
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts.Persons;
            Stripe.V2.Core.AccountPerson accountPerson = await service
                .CreateAsync("account_id_123", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/core/accounts/account_id_123/persons");
        }

        [Fact]
        public void TestV2CoreAccountsPersonDelete()
        {
            this.StubRequest(
                HttpMethod.Delete,
                "/v2/core/accounts/account_id_123/persons/id_123",
                (HttpStatusCode)200,
                "{\"id\":\"abc_123\",\"object\":\"some.object.tag\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts.Persons;
            Stripe.V2.DeletedObject deleted = service.Delete(
                "account_id_123",
                "id_123");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v2/core/accounts/account_id_123/persons/id_123");
        }

        [Fact]
        public async Task TestV2CoreAccountsPersonDeleteAsync()
        {
            this.StubRequest(
                HttpMethod.Delete,
                "/v2/core/accounts/account_id_123/persons/id_123",
                (HttpStatusCode)200,
                "{\"id\":\"abc_123\",\"object\":\"some.object.tag\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts.Persons;
            Stripe.V2.DeletedObject deleted = await service.DeleteAsync(
                "account_id_123",
                "id_123");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v2/core/accounts/account_id_123/persons/id_123");
        }

        [Fact]
        public void TestV2CoreAccountsPersonGet2()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/accounts/account_id_123/persons/id_123",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.account_person\",\"account\":\"account\",\"created\":\"1970-01-12T21:42:34.472Z\",\"id\":\"obj_123\",\"livemode\":true,\"updated\":\"1970-01-03T17:07:10.277Z\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts.Persons;
            Stripe.V2.Core.AccountPerson accountPerson = service.Get(
                "account_id_123",
                "id_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/core/accounts/account_id_123/persons/id_123");
        }

        [Fact]
        public async Task TestV2CoreAccountsPersonGet2Async()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/accounts/account_id_123/persons/id_123",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.account_person\",\"account\":\"account\",\"created\":\"1970-01-12T21:42:34.472Z\",\"id\":\"obj_123\",\"livemode\":true,\"updated\":\"1970-01-03T17:07:10.277Z\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts.Persons;
            Stripe.V2.Core.AccountPerson accountPerson = await service.GetAsync(
                "account_id_123",
                "id_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/core/accounts/account_id_123/persons/id_123");
        }

        [Fact]
        public void TestV2CoreAccountsPersonPost2()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/accounts/account_id_123/persons/id_123",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.account_person\",\"account\":\"account\",\"created\":\"1970-01-12T21:42:34.472Z\",\"id\":\"obj_123\",\"livemode\":true,\"updated\":\"1970-01-03T17:07:10.277Z\"}");
            var options = new Stripe.V2.Core.Accounts.PersonUpdateOptions();
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts.Persons;
            Stripe.V2.Core.AccountPerson accountPerson = service.Update(
                "account_id_123",
                "id_123",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/core/accounts/account_id_123/persons/id_123");
        }

        [Fact]
        public async Task TestV2CoreAccountsPersonPost2Async()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/accounts/account_id_123/persons/id_123",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.account_person\",\"account\":\"account\",\"created\":\"1970-01-12T21:42:34.472Z\",\"id\":\"obj_123\",\"livemode\":true,\"updated\":\"1970-01-03T17:07:10.277Z\"}");
            var options = new Stripe.V2.Core.Accounts.PersonUpdateOptions();
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts.Persons;
            Stripe.V2.Core.AccountPerson accountPerson = await service
                .UpdateAsync("account_id_123", "id_123", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/core/accounts/account_id_123/persons/id_123");
        }

        [Fact]
        public void TestV2CoreAccountsPersonTokenPost()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/accounts/account_id_123/person_tokens",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.account_person_token\",\"created\":\"1970-01-12T21:42:34.472Z\",\"expires_at\":\"1970-01-10T15:36:51.170Z\",\"id\":\"obj_123\",\"livemode\":true,\"used\":true}");
            var options = new Stripe.V2.Core.Accounts.PersonTokenCreateOptions();
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts.PersonTokens;
            Stripe.V2.Core.AccountPersonToken accountPersonToken = service
                .Create("account_id_123", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/core/accounts/account_id_123/person_tokens");
        }

        [Fact]
        public async Task TestV2CoreAccountsPersonTokenPostAsync()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/accounts/account_id_123/person_tokens",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.account_person_token\",\"created\":\"1970-01-12T21:42:34.472Z\",\"expires_at\":\"1970-01-10T15:36:51.170Z\",\"id\":\"obj_123\",\"livemode\":true,\"used\":true}");
            var options = new Stripe.V2.Core.Accounts.PersonTokenCreateOptions();
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts.PersonTokens;
            Stripe.V2.Core.AccountPersonToken accountPersonToken = await service
                .CreateAsync("account_id_123", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/core/accounts/account_id_123/person_tokens");
        }

        [Fact]
        public void TestV2CoreAccountsPersonTokenGet()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/accounts/account_id_123/person_tokens/id_123",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.account_person_token\",\"created\":\"1970-01-12T21:42:34.472Z\",\"expires_at\":\"1970-01-10T15:36:51.170Z\",\"id\":\"obj_123\",\"livemode\":true,\"used\":true}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts.PersonTokens;
            Stripe.V2.Core.AccountPersonToken accountPersonToken = service.Get(
                "account_id_123",
                "id_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/core/accounts/account_id_123/person_tokens/id_123");
        }

        [Fact]
        public async Task TestV2CoreAccountsPersonTokenGetAsync()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/accounts/account_id_123/person_tokens/id_123",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.account_person_token\",\"created\":\"1970-01-12T21:42:34.472Z\",\"expires_at\":\"1970-01-10T15:36:51.170Z\",\"id\":\"obj_123\",\"livemode\":true,\"used\":true}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts.PersonTokens;
            Stripe.V2.Core.AccountPersonToken accountPersonToken = await service
                .GetAsync("account_id_123", "id_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/core/accounts/account_id_123/person_tokens/id_123");
        }

        [Fact]
        public void TestV2CoreAccountLinkPost()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/account_links",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.account_link\",\"account\":\"account\",\"created\":\"1970-01-12T21:42:34.472Z\",\"expires_at\":\"1970-01-10T15:36:51.170Z\",\"livemode\":true,\"url\":\"url\",\"use_case\":{\"type\":\"account_onboarding\"}}");
            var options = new Stripe.V2.Core.AccountLinkCreateOptions
            {
                Account = "account",
                UseCase = new Stripe.V2.Core.AccountLinkCreateUseCaseOptions
                {
                    AccountOnboarding = new Stripe.V2.Core.AccountLinkCreateUseCaseAccountOnboardingOptions
                    {
                        CollectionOptions = new Stripe.V2.Core.AccountLinkCreateUseCaseAccountOnboardingCollectionOptionsOptions
                        {
                            Fields = "eventually_due",
                            FutureRequirements = "include",
                        },
                        Configurations = new List<string> { "merchant" },
                        RefreshUrl = "refresh_url",
                        ReturnUrl = "return_url",
                    },
                    AccountUpdate = new Stripe.V2.Core.AccountLinkCreateUseCaseAccountUpdateOptions
                    {
                        CollectionOptions = new Stripe.V2.Core.AccountLinkCreateUseCaseAccountUpdateCollectionOptionsOptions
                        {
                            Fields = "eventually_due",
                            FutureRequirements = "include",
                        },
                        Configurations = new List<string> { "merchant" },
                        RefreshUrl = "refresh_url",
                        ReturnUrl = "return_url",
                    },
                    Type = "account_onboarding",
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.AccountLinks;
            Stripe.V2.Core.AccountLink accountLink = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v2/core/account_links");
        }

        [Fact]
        public async Task TestV2CoreAccountLinkPostAsync()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/account_links",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.account_link\",\"account\":\"account\",\"created\":\"1970-01-12T21:42:34.472Z\",\"expires_at\":\"1970-01-10T15:36:51.170Z\",\"livemode\":true,\"url\":\"url\",\"use_case\":{\"type\":\"account_onboarding\"}}");
            var options = new Stripe.V2.Core.AccountLinkCreateOptions
            {
                Account = "account",
                UseCase = new Stripe.V2.Core.AccountLinkCreateUseCaseOptions
                {
                    AccountOnboarding = new Stripe.V2.Core.AccountLinkCreateUseCaseAccountOnboardingOptions
                    {
                        CollectionOptions = new Stripe.V2.Core.AccountLinkCreateUseCaseAccountOnboardingCollectionOptionsOptions
                        {
                            Fields = "eventually_due",
                            FutureRequirements = "include",
                        },
                        Configurations = new List<string> { "merchant" },
                        RefreshUrl = "refresh_url",
                        ReturnUrl = "return_url",
                    },
                    AccountUpdate = new Stripe.V2.Core.AccountLinkCreateUseCaseAccountUpdateOptions
                    {
                        CollectionOptions = new Stripe.V2.Core.AccountLinkCreateUseCaseAccountUpdateCollectionOptionsOptions
                        {
                            Fields = "eventually_due",
                            FutureRequirements = "include",
                        },
                        Configurations = new List<string> { "merchant" },
                        RefreshUrl = "refresh_url",
                        ReturnUrl = "return_url",
                    },
                    Type = "account_onboarding",
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.AccountLinks;
            Stripe.V2.Core.AccountLink accountLink = await service.CreateAsync(
                options);
            this.AssertRequest(HttpMethod.Post, "/v2/core/account_links");
        }

        [Fact]
        public void TestV2CoreAccountTokenPost()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/account_tokens",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.account_token\",\"created\":\"1970-01-12T21:42:34.472Z\",\"expires_at\":\"1970-01-10T15:36:51.170Z\",\"id\":\"obj_123\",\"livemode\":true,\"used\":true}");
            var options = new Stripe.V2.Core.AccountTokenCreateOptions();
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.AccountTokens;
            Stripe.V2.Core.AccountToken accountToken = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v2/core/account_tokens");
        }

        [Fact]
        public async Task TestV2CoreAccountTokenPostAsync()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/account_tokens",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.account_token\",\"created\":\"1970-01-12T21:42:34.472Z\",\"expires_at\":\"1970-01-10T15:36:51.170Z\",\"id\":\"obj_123\",\"livemode\":true,\"used\":true}");
            var options = new Stripe.V2.Core.AccountTokenCreateOptions();
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.AccountTokens;
            Stripe.V2.Core.AccountToken accountToken = await service
                .CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v2/core/account_tokens");
        }

        [Fact]
        public void TestV2CoreAccountTokenGet()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/account_tokens/id_123",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.account_token\",\"created\":\"1970-01-12T21:42:34.472Z\",\"expires_at\":\"1970-01-10T15:36:51.170Z\",\"id\":\"obj_123\",\"livemode\":true,\"used\":true}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.AccountTokens;
            Stripe.V2.Core.AccountToken accountToken = service.Get("id_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/core/account_tokens/id_123");
        }

        [Fact]
        public async Task TestV2CoreAccountTokenGetAsync()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/account_tokens/id_123",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.account_token\",\"created\":\"1970-01-12T21:42:34.472Z\",\"expires_at\":\"1970-01-10T15:36:51.170Z\",\"id\":\"obj_123\",\"livemode\":true,\"used\":true}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.AccountTokens;
            Stripe.V2.Core.AccountToken accountToken = await service.GetAsync(
                "id_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/core/account_tokens/id_123");
        }

        [Fact]
        public void TestV2CoreEventGet()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/events",
                (HttpStatusCode)200,
                "{\"data\":[{\"object\":\"v2.core.event\",\"created\":\"1970-01-12T21:42:34.472Z\",\"id\":\"obj_123\",\"livemode\":true,\"type\":\"type\"}],\"next_page_url\":null,\"previous_page_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Events;
            Stripe.V2.StripeList<Stripe.V2.Core.Event> events = service.List();
            this.AssertRequest(HttpMethod.Get, "/v2/core/events");
        }

        [Fact]
        public async Task TestV2CoreEventGetAsync()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/events",
                (HttpStatusCode)200,
                "{\"data\":[{\"object\":\"v2.core.event\",\"created\":\"1970-01-12T21:42:34.472Z\",\"id\":\"obj_123\",\"livemode\":true,\"type\":\"type\"}],\"next_page_url\":null,\"previous_page_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Events;
            Stripe.V2.StripeList<Stripe.V2.Core.Event> events = await service
                .ListAsync();
            this.AssertRequest(HttpMethod.Get, "/v2/core/events");
        }

        [Fact]
        public void TestV2CoreEventGetAutoPaging()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/events",
                (HttpStatusCode)200,
                "{\"data\":[{\"object\":\"v2.core.event\",\"created\":\"1970-01-12T21:42:34.472Z\",\"id\":\"obj_123\",\"livemode\":true,\"type\":\"type\"}],\"next_page_url\":null,\"previous_page_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Events;
            var result = service.ListAutoPaging().First();
            this.AssertRequest(HttpMethod.Get, "/v2/core/events");
        }

        [Fact]
        public async Task TestV2CoreEventGetAutoPagingAsync()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/events",
                (HttpStatusCode)200,
                "{\"data\":[{\"object\":\"v2.core.event\",\"created\":\"1970-01-12T21:42:34.472Z\",\"id\":\"obj_123\",\"livemode\":true,\"type\":\"type\"}],\"next_page_url\":null,\"previous_page_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Events;
            var result = await service.ListAutoPagingAsync().FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v2/core/events");
        }

        [Fact]
        public void TestV2CoreEventGet2()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/events/id_123",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.event\",\"created\":\"1970-01-12T21:42:34.472Z\",\"id\":\"obj_123\",\"livemode\":true,\"type\":\"type\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Events;
            Stripe.V2.Core.Event result = service.Get("id_123");
            this.AssertRequest(HttpMethod.Get, "/v2/core/events/id_123");
        }

        [Fact]
        public async Task TestV2CoreEventGet2Async()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/events/id_123",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.event\",\"created\":\"1970-01-12T21:42:34.472Z\",\"id\":\"obj_123\",\"livemode\":true,\"type\":\"type\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Events;
            Stripe.V2.Core.Event result = await service.GetAsync("id_123");
            this.AssertRequest(HttpMethod.Get, "/v2/core/events/id_123");
        }

        [Fact]
        public void TestV2CoreEventDestinationGet()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/event_destinations",
                (HttpStatusCode)200,
                "{\"data\":[{\"object\":\"v2.core.event_destination\",\"created\":\"1970-01-12T21:42:34.472Z\",\"description\":\"description\",\"enabled_events\":[\"enabled_events\"],\"event_payload\":\"thin\",\"id\":\"obj_123\",\"livemode\":true,\"name\":\"name\",\"status\":\"disabled\",\"type\":\"amazon_eventbridge\",\"updated\":\"1970-01-03T17:07:10.277Z\"}],\"next_page_url\":null,\"previous_page_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.EventDestinations;
            Stripe.V2.StripeList<Stripe.V2.Core.EventDestination> eventDestinations = service
                .List();
            this.AssertRequest(HttpMethod.Get, "/v2/core/event_destinations");
        }

        [Fact]
        public async Task TestV2CoreEventDestinationGetAsync()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/event_destinations",
                (HttpStatusCode)200,
                "{\"data\":[{\"object\":\"v2.core.event_destination\",\"created\":\"1970-01-12T21:42:34.472Z\",\"description\":\"description\",\"enabled_events\":[\"enabled_events\"],\"event_payload\":\"thin\",\"id\":\"obj_123\",\"livemode\":true,\"name\":\"name\",\"status\":\"disabled\",\"type\":\"amazon_eventbridge\",\"updated\":\"1970-01-03T17:07:10.277Z\"}],\"next_page_url\":null,\"previous_page_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.EventDestinations;
            Stripe.V2.StripeList<Stripe.V2.Core.EventDestination> eventDestinations = await service
                .ListAsync();
            this.AssertRequest(HttpMethod.Get, "/v2/core/event_destinations");
        }

        [Fact]
        public void TestV2CoreEventDestinationGetAutoPaging()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/event_destinations",
                (HttpStatusCode)200,
                "{\"data\":[{\"object\":\"v2.core.event_destination\",\"created\":\"1970-01-12T21:42:34.472Z\",\"description\":\"description\",\"enabled_events\":[\"enabled_events\"],\"event_payload\":\"thin\",\"id\":\"obj_123\",\"livemode\":true,\"name\":\"name\",\"status\":\"disabled\",\"type\":\"amazon_eventbridge\",\"updated\":\"1970-01-03T17:07:10.277Z\"}],\"next_page_url\":null,\"previous_page_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.EventDestinations;
            var eventDestination = service.ListAutoPaging().First();
            this.AssertRequest(HttpMethod.Get, "/v2/core/event_destinations");
        }

        [Fact]
        public async Task TestV2CoreEventDestinationGetAutoPagingAsync()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/event_destinations",
                (HttpStatusCode)200,
                "{\"data\":[{\"object\":\"v2.core.event_destination\",\"created\":\"1970-01-12T21:42:34.472Z\",\"description\":\"description\",\"enabled_events\":[\"enabled_events\"],\"event_payload\":\"thin\",\"id\":\"obj_123\",\"livemode\":true,\"name\":\"name\",\"status\":\"disabled\",\"type\":\"amazon_eventbridge\",\"updated\":\"1970-01-03T17:07:10.277Z\"}],\"next_page_url\":null,\"previous_page_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.EventDestinations;
            var eventDestination = await service.ListAutoPagingAsync()
                .FirstAsync();
            this.AssertRequest(HttpMethod.Get, "/v2/core/event_destinations");
        }

        [Fact]
        public void TestV2CoreEventDestinationPost()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/event_destinations",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.event_destination\",\"created\":\"1970-01-12T21:42:34.472Z\",\"description\":\"description\",\"enabled_events\":[\"enabled_events\"],\"event_payload\":\"thin\",\"id\":\"obj_123\",\"livemode\":true,\"name\":\"name\",\"status\":\"disabled\",\"type\":\"amazon_eventbridge\",\"updated\":\"1970-01-03T17:07:10.277Z\"}");
            var options = new Stripe.V2.Core.EventDestinationCreateOptions
            {
                EnabledEvents = new List<string> { "enabled_events" },
                EventPayload = "thin",
                Name = "name",
                Type = "amazon_eventbridge",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.EventDestinations;
            Stripe.V2.Core.EventDestination eventDestination = service.Create(
                options);
            this.AssertRequest(HttpMethod.Post, "/v2/core/event_destinations");
        }

        [Fact]
        public async Task TestV2CoreEventDestinationPostAsync()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/event_destinations",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.event_destination\",\"created\":\"1970-01-12T21:42:34.472Z\",\"description\":\"description\",\"enabled_events\":[\"enabled_events\"],\"event_payload\":\"thin\",\"id\":\"obj_123\",\"livemode\":true,\"name\":\"name\",\"status\":\"disabled\",\"type\":\"amazon_eventbridge\",\"updated\":\"1970-01-03T17:07:10.277Z\"}");
            var options = new Stripe.V2.Core.EventDestinationCreateOptions
            {
                EnabledEvents = new List<string> { "enabled_events" },
                EventPayload = "thin",
                Name = "name",
                Type = "amazon_eventbridge",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.EventDestinations;
            Stripe.V2.Core.EventDestination eventDestination = await service
                .CreateAsync(options);
            this.AssertRequest(HttpMethod.Post, "/v2/core/event_destinations");
        }

        [Fact]
        public void TestV2CoreEventDestinationDelete()
        {
            this.StubRequest(
                HttpMethod.Delete,
                "/v2/core/event_destinations/id_123",
                (HttpStatusCode)200,
                "{\"id\":\"abc_123\",\"object\":\"some.object.tag\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.EventDestinations;
            Stripe.V2.DeletedObject deleted = service.Delete("id_123");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v2/core/event_destinations/id_123");
        }

        [Fact]
        public async Task TestV2CoreEventDestinationDeleteAsync()
        {
            this.StubRequest(
                HttpMethod.Delete,
                "/v2/core/event_destinations/id_123",
                (HttpStatusCode)200,
                "{\"id\":\"abc_123\",\"object\":\"some.object.tag\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.EventDestinations;
            Stripe.V2.DeletedObject deleted = await service.DeleteAsync(
                "id_123");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v2/core/event_destinations/id_123");
        }

        [Fact]
        public void TestV2CoreEventDestinationGet2()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/event_destinations/id_123",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.event_destination\",\"created\":\"1970-01-12T21:42:34.472Z\",\"description\":\"description\",\"enabled_events\":[\"enabled_events\"],\"event_payload\":\"thin\",\"id\":\"obj_123\",\"livemode\":true,\"name\":\"name\",\"status\":\"disabled\",\"type\":\"amazon_eventbridge\",\"updated\":\"1970-01-03T17:07:10.277Z\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.EventDestinations;
            Stripe.V2.Core.EventDestination eventDestination = service.Get(
                "id_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/core/event_destinations/id_123");
        }

        [Fact]
        public async Task TestV2CoreEventDestinationGet2Async()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/event_destinations/id_123",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.event_destination\",\"created\":\"1970-01-12T21:42:34.472Z\",\"description\":\"description\",\"enabled_events\":[\"enabled_events\"],\"event_payload\":\"thin\",\"id\":\"obj_123\",\"livemode\":true,\"name\":\"name\",\"status\":\"disabled\",\"type\":\"amazon_eventbridge\",\"updated\":\"1970-01-03T17:07:10.277Z\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.EventDestinations;
            Stripe.V2.Core.EventDestination eventDestination = await service
                .GetAsync("id_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/core/event_destinations/id_123");
        }

        [Fact]
        public void TestV2CoreEventDestinationPost2()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/event_destinations/id_123",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.event_destination\",\"created\":\"1970-01-12T21:42:34.472Z\",\"description\":\"description\",\"enabled_events\":[\"enabled_events\"],\"event_payload\":\"thin\",\"id\":\"obj_123\",\"livemode\":true,\"name\":\"name\",\"status\":\"disabled\",\"type\":\"amazon_eventbridge\",\"updated\":\"1970-01-03T17:07:10.277Z\"}");
            var options = new Stripe.V2.Core.EventDestinationUpdateOptions();
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.EventDestinations;
            Stripe.V2.Core.EventDestination eventDestination = service.Update(
                "id_123",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/core/event_destinations/id_123");
        }

        [Fact]
        public async Task TestV2CoreEventDestinationPost2Async()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/event_destinations/id_123",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.event_destination\",\"created\":\"1970-01-12T21:42:34.472Z\",\"description\":\"description\",\"enabled_events\":[\"enabled_events\"],\"event_payload\":\"thin\",\"id\":\"obj_123\",\"livemode\":true,\"name\":\"name\",\"status\":\"disabled\",\"type\":\"amazon_eventbridge\",\"updated\":\"1970-01-03T17:07:10.277Z\"}");
            var options = new Stripe.V2.Core.EventDestinationUpdateOptions();
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.EventDestinations;
            Stripe.V2.Core.EventDestination eventDestination = await service
                .UpdateAsync("id_123", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/core/event_destinations/id_123");
        }

        [Fact]
        public void TestV2CoreEventDestinationPost3()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/event_destinations/id_123/disable",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.event_destination\",\"created\":\"1970-01-12T21:42:34.472Z\",\"description\":\"description\",\"enabled_events\":[\"enabled_events\"],\"event_payload\":\"thin\",\"id\":\"obj_123\",\"livemode\":true,\"name\":\"name\",\"status\":\"disabled\",\"type\":\"amazon_eventbridge\",\"updated\":\"1970-01-03T17:07:10.277Z\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.EventDestinations;
            Stripe.V2.Core.EventDestination eventDestination = service.Disable(
                "id_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/core/event_destinations/id_123/disable");
        }

        [Fact]
        public async Task TestV2CoreEventDestinationPost3Async()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/event_destinations/id_123/disable",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.event_destination\",\"created\":\"1970-01-12T21:42:34.472Z\",\"description\":\"description\",\"enabled_events\":[\"enabled_events\"],\"event_payload\":\"thin\",\"id\":\"obj_123\",\"livemode\":true,\"name\":\"name\",\"status\":\"disabled\",\"type\":\"amazon_eventbridge\",\"updated\":\"1970-01-03T17:07:10.277Z\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.EventDestinations;
            Stripe.V2.Core.EventDestination eventDestination = await service
                .DisableAsync("id_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/core/event_destinations/id_123/disable");
        }

        [Fact]
        public void TestV2CoreEventDestinationPost4()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/event_destinations/id_123/enable",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.event_destination\",\"created\":\"1970-01-12T21:42:34.472Z\",\"description\":\"description\",\"enabled_events\":[\"enabled_events\"],\"event_payload\":\"thin\",\"id\":\"obj_123\",\"livemode\":true,\"name\":\"name\",\"status\":\"disabled\",\"type\":\"amazon_eventbridge\",\"updated\":\"1970-01-03T17:07:10.277Z\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.EventDestinations;
            Stripe.V2.Core.EventDestination eventDestination = service.Enable(
                "id_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/core/event_destinations/id_123/enable");
        }

        [Fact]
        public async Task TestV2CoreEventDestinationPost4Async()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/event_destinations/id_123/enable",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.event_destination\",\"created\":\"1970-01-12T21:42:34.472Z\",\"description\":\"description\",\"enabled_events\":[\"enabled_events\"],\"event_payload\":\"thin\",\"id\":\"obj_123\",\"livemode\":true,\"name\":\"name\",\"status\":\"disabled\",\"type\":\"amazon_eventbridge\",\"updated\":\"1970-01-03T17:07:10.277Z\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.EventDestinations;
            Stripe.V2.Core.EventDestination eventDestination = await service
                .EnableAsync("id_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/core/event_destinations/id_123/enable");
        }

        [Fact]
        public void TestV2CoreEventDestinationPost5()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/event_destinations/id_123/ping",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.event\",\"created\":\"1970-01-12T21:42:34.472Z\",\"id\":\"obj_123\",\"livemode\":true,\"type\":\"type\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.EventDestinations;
            Stripe.V2.Core.Event result = service.Ping("id_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/core/event_destinations/id_123/ping");
        }

        [Fact]
        public async Task TestV2CoreEventDestinationPost5Async()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/event_destinations/id_123/ping",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.event\",\"created\":\"1970-01-12T21:42:34.472Z\",\"id\":\"obj_123\",\"livemode\":true,\"type\":\"type\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.EventDestinations;
            Stripe.V2.Core.Event result = await service.PingAsync("id_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/core/event_destinations/id_123/ping");
        }

        [Fact]
        public void TestRateLimitError()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/accounts",
                (HttpStatusCode)400,
                "{\"error\":{\"type\":\"rate_limit\",\"code\":\"account_rate_limit_exceeded\"}}");
            var exception = Assert.Throws<Stripe.V2.RateLimitException>(
            () =>
            {
                var client = new StripeClient(this.Requestor);
                var service = client.V2.Core.Accounts;
                Stripe.V2.StripeList<Stripe.V2.Core.Account> accounts = service
                    .List();
            });
            this.AssertRequest(HttpMethod.Get, "/v2/core/accounts");
        }

        [Fact]
        public async Task TestRateLimitErrorAsync()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/accounts",
                (HttpStatusCode)400,
                "{\"error\":{\"type\":\"rate_limit\",\"code\":\"account_rate_limit_exceeded\"}}");
            var exception = await Assert.ThrowsAsync<Stripe.V2.RateLimitException>(
            async () =>
            {
                var client = new StripeClient(this.Requestor);
                var service = client.V2.Core.Accounts;
                Stripe.V2.StripeList<Stripe.V2.Core.Account> accounts = await service
                    .ListAsync();
            });
            this.AssertRequest(HttpMethod.Get, "/v2/core/accounts");
        }

        [Fact]
        public void TestRateLimitErrorAutoPaging()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/accounts",
                (HttpStatusCode)400,
                "{\"error\":{\"type\":\"rate_limit\",\"code\":\"account_rate_limit_exceeded\"}}");
            var exception = Assert.Throws<Stripe.V2.RateLimitException>(
            () =>
            {
                var client = new StripeClient(this.Requestor);
                var service = client.V2.Core.Accounts;
                var account = service.ListAutoPaging().First();
            });
            this.AssertRequest(HttpMethod.Get, "/v2/core/accounts");
        }

        [Fact]
        public async Task TestRateLimitErrorAutoPagingAsync()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/accounts",
                (HttpStatusCode)400,
                "{\"error\":{\"type\":\"rate_limit\",\"code\":\"account_rate_limit_exceeded\"}}");
            var exception = await Assert.ThrowsAsync<Stripe.V2.RateLimitException>(
            async () =>
            {
                var client = new StripeClient(this.Requestor);
                var service = client.V2.Core.Accounts;
                var account = await service.ListAutoPagingAsync().FirstAsync();
            });
            this.AssertRequest(HttpMethod.Get, "/v2/core/accounts");
        }

        [Fact]
        public void TestTemporarySessionExpiredError()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/billing/meter_event_stream",
                (HttpStatusCode)400,
                "{\"error\":{\"type\":\"temporary_session_expired\",\"code\":\"billing_meter_event_session_expired\"}}");
            var exception = Assert.Throws<Stripe.V2.TemporarySessionExpiredException>(
            () =>
            {
                var options = new Stripe.V2.Billing.MeterEventStreamCreateOptions
                {
                    Events = new List<Stripe.V2.Billing.MeterEventStreamCreateEventOptions>
                {
                    new Stripe.V2.Billing.MeterEventStreamCreateEventOptions
                    {
                        EventName = "event_name",
                        Payload = new Dictionary<string, string>
                        {
                            { "key", "payload" },
                        },
                    },
                },
                };
                var client = new StripeClient(this.Requestor);
                var service = client.V2.Billing.MeterEventStream;
                service.Create(options);
            });
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/billing/meter_event_stream");
        }

        [Fact]
        public async Task TestTemporarySessionExpiredErrorAsync()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/billing/meter_event_stream",
                (HttpStatusCode)400,
                "{\"error\":{\"type\":\"temporary_session_expired\",\"code\":\"billing_meter_event_session_expired\"}}");
            var exception = await Assert.ThrowsAsync<Stripe.V2.TemporarySessionExpiredException>(
            async () =>
            {
                var options = new Stripe.V2.Billing.MeterEventStreamCreateOptions
                {
                    Events = new List<Stripe.V2.Billing.MeterEventStreamCreateEventOptions>
                {
                    new Stripe.V2.Billing.MeterEventStreamCreateEventOptions
                    {
                        EventName = "event_name",
                        Payload = new Dictionary<string, string>
                        {
                            { "key", "payload" },
                        },
                    },
                },
                };
                var client = new StripeClient(this.Requestor);
                var service = client.V2.Billing.MeterEventStream;
                await service.CreateAsync(options);
            });
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/billing/meter_event_stream");
        }
    }
}
