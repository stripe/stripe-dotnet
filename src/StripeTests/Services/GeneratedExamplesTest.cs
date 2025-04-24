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
        public void TestAccountsDelete()
        {
            var service = new AccountService(this.StripeClient);
            Account deleted = service.Delete("acct_xxxxxxxxxxxxx");
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
        public void TestAccountsGet2()
        {
            var service = new AccountService(this.StripeClient);
            Account account = service.Get("acct_xxxxxxxxxxxxx");
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
        public void TestApplicationFeesGet2()
        {
            var service = new ApplicationFeeService(this.StripeClient);
            ApplicationFee applicationFee = service.Get("fee_xxxxxxxxxxxxx");
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
        public void TestChargesCapturePost()
        {
            var service = new ChargeService(this.StripeClient);
            Charge charge = service.Capture("ch_xxxxxxxxxxxxx");
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
        public void TestChargesGet2()
        {
            var service = new ChargeService(this.StripeClient);
            Charge charge = service.Get("ch_xxxxxxxxxxxxx");
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
        public void TestCheckoutSessionsExpirePost()
        {
            var service = new Stripe.Checkout.SessionService(this.StripeClient);
            Stripe.Checkout.Session session = service.Expire("sess_xyz");
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
        public void TestCoreEventsGet()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/events/ll_123",
                HttpStatusCode.OK,
                "{\"id\":\"obj_123\",\"object\":\"v2.core.event\",\"context\":\"context\",\"created\":\"1970-01-12T21:42:34.472Z\",\"livemode\":true,\"reason\":{\"type\":\"request\",\"request\":{\"id\":\"obj_123\",\"idempotency_key\":\"idempotency_key\"}},\"type\":\"type\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Events;
            Stripe.V2.Event result = service.Get("ll_123");
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
        public void TestCountrySpecsGet2()
        {
            var service = new CountrySpecService(this.StripeClient);
            CountrySpec countrySpec = service.Get("US");
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
        public void TestCouponsGet()
        {
            var options = new CouponListOptions { Limit = 3 };
            var service = new CouponService(this.StripeClient);
            StripeList<Coupon> coupons = service.List(options);
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
        public void TestCreditNotesGet()
        {
            var options = new CreditNoteListOptions { Limit = 3 };
            var service = new CreditNoteService(this.StripeClient);
            StripeList<CreditNote> creditNotes = service.List(options);
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
        public void TestCreditNotesVoidPost()
        {
            var service = new CreditNoteService(this.StripeClient);
            CreditNote creditNote = service.VoidCreditNote("cn_xxxxxxxxxxxxx");
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
        public void TestCustomersCashBalanceGet()
        {
            var service = new CustomerCashBalanceService(this.StripeClient);
            CashBalance cashBalance = service.Get("cus_123");
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
        public void TestCustomersDelete()
        {
            var service = new CustomerService(this.StripeClient);
            Customer deleted = service.Delete("cus_xxxxxxxxxxxxx");
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
        public void TestCustomersGet()
        {
            var options = new CustomerListOptions { Limit = 3 };
            var service = new CustomerService(this.StripeClient);
            StripeList<Customer> customers = service.List(options);
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
        public void TestCustomersGet3()
        {
            var service = new CustomerService(this.StripeClient);
            Customer customer = service.Get("cus_xxxxxxxxxxxxx");
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
        public void TestCustomersTaxIdsGet2()
        {
            var service = new CustomerTaxIdService(this.StripeClient);
            TaxId taxId = service.Get("cus_xxxxxxxxxxxxx", "txi_xxxxxxxxxxxxx");
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
        public void TestDisputesClosePost()
        {
            var service = new DisputeService(this.StripeClient);
            Dispute dispute = service.Close("dp_xxxxxxxxxxxxx");
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
        public void TestDisputesGet2()
        {
            var service = new DisputeService(this.StripeClient);
            Dispute dispute = service.Get("dp_xxxxxxxxxxxxx");
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
        public void TestEventsGet()
        {
            var options = new EventListOptions { Limit = 3 };
            var service = new EventService(this.StripeClient);
            StripeList<Event> events = service.List(options);
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
        public void TestFileLinksGet()
        {
            var options = new FileLinkListOptions { Limit = 3 };
            var service = new FileLinkService(this.StripeClient);
            StripeList<FileLink> fileLinks = service.List(options);
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
        public void TestFilesGet()
        {
            var options = new FileListOptions { Limit = 3 };
            var service = new FileService(this.StripeClient);
            StripeList<File> files = service.List(options);
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
        public void TestFilesPost()
        {
            var options = new FileCreateOptions
            {
                Purpose = "account_requirement",
                File = new System.IO.MemoryStream(
                    System.Text.Encoding.UTF8.GetBytes("File contents")),
            };
            var service = new FileService(this.StripeClient);
            File file = service.Create(options);
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
        public void TestInvoiceitemsDelete()
        {
            var service = new InvoiceItemService(this.StripeClient);
            InvoiceItem deleted = service.Delete("ii_xxxxxxxxxxxxx");
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
        public void TestInvoiceitemsGet2()
        {
            var service = new InvoiceItemService(this.StripeClient);
            InvoiceItem invoiceItem = service.Get("ii_xxxxxxxxxxxxx");
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
        public void TestInvoicesDelete()
        {
            var service = new InvoiceService(this.StripeClient);
            Invoice deleted = service.Delete("in_xxxxxxxxxxxxx");
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
        public void TestInvoicesGet()
        {
            var options = new InvoiceListOptions { Limit = 3 };
            var service = new InvoiceService(this.StripeClient);
            StripeList<Invoice> invoices = service.List(options);
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
        public void TestInvoicesMarkUncollectiblePost()
        {
            var service = new InvoiceService(this.StripeClient);
            Invoice invoice = service.MarkUncollectible("in_xxxxxxxxxxxxx");
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
        public void TestInvoicesSendPost()
        {
            var service = new InvoiceService(this.StripeClient);
            Invoice invoice = service.SendInvoice("in_xxxxxxxxxxxxx");
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
        public void TestIssuingCardsGet()
        {
            var options = new Stripe.Issuing.CardListOptions { Limit = 3 };
            var service = new Stripe.Issuing.CardService(this.StripeClient);
            StripeList<Stripe.Issuing.Card> cards = service.List(options);
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
        public void TestIssuingDisputesGet2()
        {
            var service = new Stripe.Issuing.DisputeService(this.StripeClient);
            Stripe.Issuing.Dispute dispute = service.Get("idp_xxxxxxxxxxxxx");
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
        public void TestIssuingPhysicalBundlesGet()
        {
            var service = new Stripe.Issuing.PhysicalBundleService(
                this.StripeClient);
            StripeList<Stripe.Issuing.PhysicalBundle> physicalBundles = service
                .List();
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
        public void TestMandatesGet()
        {
            var service = new MandateService(this.StripeClient);
            Mandate mandate = service.Get("mandate_xxxxxxxxxxxxx");
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
        public void TestPaymentIntentsCancelPost()
        {
            var service = new PaymentIntentService(this.StripeClient);
            PaymentIntent paymentIntent = service.Cancel("pi_xxxxxxxxxxxxx");
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
        public void TestPaymentIntentsGet2()
        {
            var service = new PaymentIntentService(this.StripeClient);
            PaymentIntent paymentIntent = service.Get("pi_xxxxxxxxxxxxx");
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
        public void TestPaymentLinksGet()
        {
            var service = new PaymentLinkService(this.StripeClient);
            PaymentLink paymentLink = service.Get("pl_xyz");
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
        public void TestPaymentLinksGet3()
        {
            var service = new PaymentLinkService(this.StripeClient);
            PaymentLink paymentLink = service.Get("plink_xxxxxxxxxxxxx");
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
        public void TestPaymentMethodsDetachPost()
        {
            var service = new PaymentMethodService(this.StripeClient);
            PaymentMethod paymentMethod = service.Detach("pm_xxxxxxxxxxxxx");
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
        public void TestPaymentMethodsGet2()
        {
            var service = new PaymentMethodService(this.StripeClient);
            PaymentMethod paymentMethod = service.Get("pm_xxxxxxxxxxxxx");
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
        public void TestPayoutsCancelPost()
        {
            var service = new PayoutService(this.StripeClient);
            Payout payout = service.Cancel("po_xxxxxxxxxxxxx");
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
        public void TestPayoutsGet2()
        {
            var service = new PayoutService(this.StripeClient);
            Payout payout = service.Get("po_xxxxxxxxxxxxx");
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
        public void TestPayoutsReversePost()
        {
            var service = new PayoutService(this.StripeClient);
            Payout payout = service.Reverse("po_xxxxxxxxxxxxx");
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
        public void TestPlansGet()
        {
            var options = new PlanListOptions { Limit = 3 };
            var service = new PlanService(this.StripeClient);
            StripeList<Plan> plans = service.List(options);
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
        public void TestPricesGet()
        {
            var options = new PriceListOptions { Limit = 3 };
            var service = new PriceService(this.StripeClient);
            StripeList<Price> prices = service.List(options);
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
        public void TestProductsDelete()
        {
            var service = new ProductService(this.StripeClient);
            Product deleted = service.Delete("prod_xxxxxxxxxxxxx");
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
        public void TestProductsGet2()
        {
            var service = new ProductService(this.StripeClient);
            Product product = service.Get("prod_xxxxxxxxxxxxx");
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
        public void TestPromotionCodesGet2()
        {
            var service = new PromotionCodeService(this.StripeClient);
            PromotionCode promotionCode = service.Get("promo_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/promotion_codes/promo_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPromotionCodesPost()
        {
            var options = new PromotionCodeCreateOptions
            {
                Coupon = "Z4OV52SU",
            };
            var service = new PromotionCodeService(this.StripeClient);
            PromotionCode promotionCode = service.Create(options);
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
        public void TestQuotesAcceptPost()
        {
            var service = new QuoteService(this.StripeClient);
            Quote quote = service.Accept("qt_xxxxxxxxxxxxx");
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
        public void TestQuotesFinalizePost()
        {
            var service = new QuoteService(this.StripeClient);
            Quote quote = service.FinalizeQuote("qt_xxxxxxxxxxxxx");
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
        public void TestQuotesGet2()
        {
            var service = new QuoteService(this.StripeClient);
            Quote quote = service.Get("qt_xxxxxxxxxxxxx");
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
        public void TestQuotesPdfGet()
        {
            var service = new QuoteService(this.StripeClient);
            service.Pdf("qt_xxxxxxxxxxxxx");
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
        public void TestQuotesPreviewInvoicesLinesGet()
        {
            var service = new QuoteService(this.StripeClient);
            StripeList<InvoiceLineItem> invoiceLineItems = service
                .ListPreviewInvoiceLines("qt_xyz", "in_xyz");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/quotes/qt_xyz/preview_invoices/in_xyz/lines");
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
        public void TestRadarValueListsGet2()
        {
            var service = new Stripe.Radar.ValueListService(this.StripeClient);
            Stripe.Radar.ValueList valueList = service.Get("rsl_xxxxxxxxxxxxx");
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
        public void TestRefundsCancelPost()
        {
            var service = new RefundService(this.StripeClient);
            Refund refund = service.Cancel("re_xxxxxxxxxxxxx");
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
        public void TestRefundsGet2()
        {
            var service = new RefundService(this.StripeClient);
            Refund refund = service.Get("re_xxxxxxxxxxxxx");
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
        public void TestReportingReportTypesGet()
        {
            var service = new Stripe.Reporting.ReportTypeService(
                this.StripeClient);
            StripeList<Stripe.Reporting.ReportType> reportTypes = service
                .List();
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
        public void TestReviewsApprovePost()
        {
            var service = new ReviewService(this.StripeClient);
            Review review = service.Approve("prv_xxxxxxxxxxxxx");
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
        public void TestReviewsGet2()
        {
            var service = new ReviewService(this.StripeClient);
            Review review = service.Get("prv_xxxxxxxxxxxxx");
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
        public void TestSetupIntentsCancelPost()
        {
            var service = new SetupIntentService(this.StripeClient);
            SetupIntent setupIntent = service.Cancel("seti_xxxxxxxxxxxxx");
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
        public void TestSetupIntentsGet()
        {
            var options = new SetupIntentListOptions { Limit = 3 };
            var service = new SetupIntentService(this.StripeClient);
            StripeList<SetupIntent> setupIntents = service.List(options);
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
        public void TestShippingRatesGet()
        {
            var service = new ShippingRateService(this.StripeClient);
            StripeList<ShippingRate> shippingRates = service.List();
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
        public void TestShippingRatesGet3()
        {
            var service = new ShippingRateService(this.StripeClient);
            ShippingRate shippingRate = service.Get("shr_xxxxxxxxxxxxx");
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
        public void TestSourcesGet()
        {
            var service = new SourceService(this.StripeClient);
            Source source = service.Get("src_xxxxxxxxxxxxx");
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
        public void TestSubscriptionItemsDelete()
        {
            var service = new SubscriptionItemService(this.StripeClient);
            SubscriptionItem deleted = service.Delete("si_xxxxxxxxxxxxx");
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
        public void TestSubscriptionItemsGet2()
        {
            var service = new SubscriptionItemService(this.StripeClient);
            SubscriptionItem subscriptionItem = service.Get("si_xxxxxxxxxxxxx");
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
                        Iterations = 12,
                    },
                },
            };
            var service = new SubscriptionScheduleService(this.StripeClient);
            SubscriptionSchedule subscriptionSchedule = service.Create(options);
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
        public void TestSubscriptionsDelete()
        {
            var service = new SubscriptionService(this.StripeClient);
            Subscription subscription = service.Cancel("sub_xxxxxxxxxxxxx");
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
        public void TestSubscriptionsGet()
        {
            var options = new SubscriptionListOptions { Limit = 3 };
            var service = new SubscriptionService(this.StripeClient);
            StripeList<Subscription> subscriptions = service.List(options);
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
        public void TestTaxCodesGet()
        {
            var options = new TaxCodeListOptions { Limit = 3 };
            var service = new TaxCodeService(this.StripeClient);
            StripeList<TaxCode> taxCodes = service.List(options);
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
        public void TestTaxFormsPdfGet()
        {
            var service = new Stripe.Tax.FormService(this.StripeClient);
            service.Pdf("form_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/tax/forms/form_xxxxxxxxxxxxx/pdf");
        }

        [Fact]
        public void TestTaxIdsDelete()
        {
            var service = new TaxIdService(this.StripeClient);
            TaxId deleted = service.Delete("taxid_123");
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
        public void TestTaxIdsGet2()
        {
            var service = new TaxIdService(this.StripeClient);
            TaxId taxId = service.Get("taxid_123");
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
        public void TestTaxRatesGet()
        {
            var options = new TaxRateListOptions { Limit = 3 };
            var service = new TaxRateService(this.StripeClient);
            StripeList<TaxRate> taxRates = service.List(options);
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
        public void TestTaxSettingsGet()
        {
            var options = new Stripe.Tax.SettingsGetOptions();
            var service = new Stripe.Tax.SettingsService(this.StripeClient);
            Stripe.Tax.Settings settings = service.Get(options);
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
        public void TestTerminalConfigurationsGet()
        {
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            StripeList<Stripe.Terminal.Configuration> configurations = service
                .List();
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
        public void TestTerminalReadersGet2()
        {
            var service = new Stripe.Terminal.ReaderService(this.StripeClient);
            Stripe.Terminal.Reader reader = service.Get("tmr_xxxxxxxxxxxxx");
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
        public void TestTestHelpersTestClocksGet()
        {
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            StripeList<Stripe.TestHelpers.TestClock> testClocks = service
                .List();
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
        public void TestTokensGet()
        {
            var service = new TokenService(this.StripeClient);
            Token token = service.Get("tok_xxxx");
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
        public void TestTopupsCancelPost()
        {
            var service = new TopupService(this.StripeClient);
            Topup topup = service.Cancel("tu_xxxxxxxxxxxxx");
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
        public void TestTopupsGet2()
        {
            var service = new TopupService(this.StripeClient);
            Topup topup = service.Get("tu_xxxxxxxxxxxxx");
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
        public void TestTransfersGet()
        {
            var options = new TransferListOptions { Limit = 3 };
            var service = new TransferService(this.StripeClient);
            StripeList<Transfer> transfers = service.List(options);
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
        public void TestWebhookEndpointsDelete()
        {
            var service = new WebhookEndpointService(this.StripeClient);
            WebhookEndpoint deleted = service.Delete("we_xxxxxxxxxxxxx");
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
        public void TestWebhookEndpointsGet2()
        {
            var service = new WebhookEndpointService(this.StripeClient);
            WebhookEndpoint webhookEndpoint = service.Get("we_xxxxxxxxxxxxx");
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
        public void TestV2CoreAccountPost()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/accounts/id_123/close",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.core.account\",\"applied_configurations\":[\"recipient\"],\"configuration\":null,\"contact_email\":null,\"created\":\"1970-01-12T21:42:34.472Z\",\"dashboard\":null,\"defaults\":null,\"display_name\":null,\"identity\":null,\"livemode\":true,\"metadata\":null,\"requirements\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts;
            Stripe.V2.Core.Account account = service.Close("id_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/core/accounts/id_123/close");
        }

        [Fact]
        public void TestV2CoreAccountPost2()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/accounts",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.core.account\",\"applied_configurations\":[\"recipient\"],\"configuration\":null,\"contact_email\":null,\"created\":\"1970-01-12T21:42:34.472Z\",\"dashboard\":null,\"defaults\":null,\"display_name\":null,\"identity\":null,\"livemode\":true,\"metadata\":null,\"requirements\":null}");
            var options = new Stripe.V2.Core.AccountCreateOptions();
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts;
            Stripe.V2.Core.Account account = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v2/core/accounts");
        }

        [Fact]
        public void TestV2CoreAccountGet()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/accounts",
                (HttpStatusCode)200,
                "{\"data\":[{\"id\":\"obj_123\",\"object\":\"v2.core.account\",\"applied_configurations\":[\"recipient\"],\"configuration\":null,\"contact_email\":null,\"created\":\"1970-01-12T21:42:34.472Z\",\"dashboard\":null,\"defaults\":null,\"display_name\":null,\"identity\":null,\"livemode\":true,\"metadata\":null,\"requirements\":null}],\"next_page_url\":null,\"previous_page_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts;
            Stripe.V2.StripeList<Stripe.V2.Core.Account> accounts = service
                .List();
            this.AssertRequest(HttpMethod.Get, "/v2/core/accounts");
        }

        [Fact]
        public void TestV2CoreAccountGet2()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/accounts/id_123",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.core.account\",\"applied_configurations\":[\"recipient\"],\"configuration\":null,\"contact_email\":null,\"created\":\"1970-01-12T21:42:34.472Z\",\"dashboard\":null,\"defaults\":null,\"display_name\":null,\"identity\":null,\"livemode\":true,\"metadata\":null,\"requirements\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts;
            Stripe.V2.Core.Account account = service.Get("id_123");
            this.AssertRequest(HttpMethod.Get, "/v2/core/accounts/id_123");
        }

        [Fact]
        public void TestV2CoreAccountPost3()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/accounts/id_123",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.core.account\",\"applied_configurations\":[\"recipient\"],\"configuration\":null,\"contact_email\":null,\"created\":\"1970-01-12T21:42:34.472Z\",\"dashboard\":null,\"defaults\":null,\"display_name\":null,\"identity\":null,\"livemode\":true,\"metadata\":null,\"requirements\":null}");
            var options = new Stripe.V2.Core.AccountUpdateOptions();
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts;
            Stripe.V2.Core.Account account = service.Update("id_123", options);
            this.AssertRequest(HttpMethod.Post, "/v2/core/accounts/id_123");
        }

        [Fact]
        public void TestV2CoreAccountsPersonPost()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/accounts/account_id_123/persons",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.core.account_person\",\"account\":\"account\",\"additional_addresses\":null,\"additional_names\":null,\"additional_terms_of_service\":null,\"address\":null,\"created\":\"1970-01-12T21:42:34.472Z\",\"date_of_birth\":null,\"documents\":null,\"email\":null,\"given_name\":null,\"id_numbers\":null,\"legal_gender\":null,\"livemode\":true,\"metadata\":null,\"nationalities\":null,\"phone\":null,\"political_exposure\":null,\"relationship\":null,\"script_addresses\":null,\"script_names\":null,\"surname\":null,\"updated\":\"1970-01-03T17:07:10.277Z\"}");
            var options = new Stripe.V2.Core.Accounts.PersonCreateOptions();
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts.Persons;
            Stripe.V2.Core.Person person = service.Create(
                "account_id_123",
                options);
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
                "{\"id\":\"obj_123\",\"object\":\"v2.core.account_person\",\"account\":\"account\",\"additional_addresses\":null,\"additional_names\":null,\"additional_terms_of_service\":null,\"address\":null,\"created\":\"1970-01-12T21:42:34.472Z\",\"date_of_birth\":null,\"documents\":null,\"email\":null,\"given_name\":null,\"id_numbers\":null,\"legal_gender\":null,\"livemode\":true,\"metadata\":null,\"nationalities\":null,\"phone\":null,\"political_exposure\":null,\"relationship\":null,\"script_addresses\":null,\"script_names\":null,\"surname\":null,\"updated\":\"1970-01-03T17:07:10.277Z\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts.Persons;
            Stripe.V2.Core.Person deleted = service.Delete(
                "account_id_123",
                "id_123");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v2/core/accounts/account_id_123/persons/id_123");
        }

        [Fact]
        public void TestV2CoreAccountsPersonGet()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/accounts/account_id_123/persons",
                (HttpStatusCode)200,
                "{\"data\":[{\"id\":\"obj_123\",\"object\":\"v2.core.account_person\",\"account\":\"account\",\"additional_addresses\":null,\"additional_names\":null,\"additional_terms_of_service\":null,\"address\":null,\"created\":\"1970-01-12T21:42:34.472Z\",\"date_of_birth\":null,\"documents\":null,\"email\":null,\"given_name\":null,\"id_numbers\":null,\"legal_gender\":null,\"livemode\":true,\"metadata\":null,\"nationalities\":null,\"phone\":null,\"political_exposure\":null,\"relationship\":null,\"script_addresses\":null,\"script_names\":null,\"surname\":null,\"updated\":\"1970-01-03T17:07:10.277Z\"}],\"next_page_url\":null,\"previous_page_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts.Persons;
            Stripe.V2.StripeList<Stripe.V2.Core.Person> persons = service.List(
                "account_id_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/core/accounts/account_id_123/persons");
        }

        [Fact]
        public void TestV2CoreAccountsPersonGet2()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/accounts/account_id_123/persons/id_123",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.core.account_person\",\"account\":\"account\",\"additional_addresses\":null,\"additional_names\":null,\"additional_terms_of_service\":null,\"address\":null,\"created\":\"1970-01-12T21:42:34.472Z\",\"date_of_birth\":null,\"documents\":null,\"email\":null,\"given_name\":null,\"id_numbers\":null,\"legal_gender\":null,\"livemode\":true,\"metadata\":null,\"nationalities\":null,\"phone\":null,\"political_exposure\":null,\"relationship\":null,\"script_addresses\":null,\"script_names\":null,\"surname\":null,\"updated\":\"1970-01-03T17:07:10.277Z\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts.Persons;
            Stripe.V2.Core.Person person = service.Get(
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
                "{\"id\":\"obj_123\",\"object\":\"v2.core.account_person\",\"account\":\"account\",\"additional_addresses\":null,\"additional_names\":null,\"additional_terms_of_service\":null,\"address\":null,\"created\":\"1970-01-12T21:42:34.472Z\",\"date_of_birth\":null,\"documents\":null,\"email\":null,\"given_name\":null,\"id_numbers\":null,\"legal_gender\":null,\"livemode\":true,\"metadata\":null,\"nationalities\":null,\"phone\":null,\"political_exposure\":null,\"relationship\":null,\"script_addresses\":null,\"script_names\":null,\"surname\":null,\"updated\":\"1970-01-03T17:07:10.277Z\"}");
            var options = new Stripe.V2.Core.Accounts.PersonUpdateOptions();
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Accounts.Persons;
            Stripe.V2.Core.Person person = service.Update(
                "account_id_123",
                "id_123",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/core/accounts/account_id_123/persons/id_123");
        }

        [Fact]
        public void TestV2CoreAccountLinkPost()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/account_links",
                (HttpStatusCode)200,
                "{\"object\":\"v2.core.account_link\",\"account\":\"account\",\"created\":\"1970-01-12T21:42:34.472Z\",\"expires_at\":\"1970-01-10T15:36:51.170Z\",\"livemode\":true,\"url\":\"url\",\"use_case\":{\"type\":\"account_onboarding\",\"account_onboarding\":null,\"account_update\":null}}");
            var options = new Stripe.V2.Core.AccountLinkCreateOptions
            {
                Account = "account",
                UseCase = new Stripe.V2.Core.AccountLinkCreateUseCaseOptions
                {
                    Type = "account_onboarding",
                    AccountOnboarding = new Stripe.V2.Core.AccountLinkCreateUseCaseAccountOnboardingOptions
                    {
                        Configurations = new List<string> { "recipient" },
                        RefreshUrl = "refresh_url",
                        ReturnUrl = "return_url",
                    },
                    AccountUpdate = new Stripe.V2.Core.AccountLinkCreateUseCaseAccountUpdateOptions
                    {
                        Configurations = new List<string> { "recipient" },
                        RefreshUrl = "refresh_url",
                        ReturnUrl = "return_url",
                    },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.AccountLinks;
            Stripe.V2.Core.AccountLink accountLink = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v2/core/account_links");
        }

        [Fact]
        public void TestV2CoreEventDestinationPost()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/event_destinations",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.core.event_destination\",\"amazon_eventbridge\":null,\"created\":\"1970-01-12T21:42:34.472Z\",\"description\":\"description\",\"enabled_events\":[\"enabled_events\"],\"event_payload\":\"thin\",\"events_from\":null,\"livemode\":true,\"metadata\":null,\"name\":\"name\",\"snapshot_api_version\":null,\"status\":\"disabled\",\"status_details\":null,\"type\":\"amazon_eventbridge\",\"updated\":\"1970-01-03T17:07:10.277Z\",\"webhook_endpoint\":null}");
            var options = new Stripe.V2.Core.EventDestinationCreateOptions
            {
                EnabledEvents = new List<string> { "enabled_events" },
                EventPayload = "thin",
                Name = "name",
                Type = "amazon_eventbridge",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.EventDestinations;
            Stripe.V2.EventDestination eventDestination = service.Create(
                options);
            this.AssertRequest(HttpMethod.Post, "/v2/core/event_destinations");
        }

        [Fact]
        public void TestV2CoreEventDestinationDelete()
        {
            this.StubRequest(
                HttpMethod.Delete,
                "/v2/core/event_destinations/id_123",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.core.event_destination\",\"amazon_eventbridge\":null,\"created\":\"1970-01-12T21:42:34.472Z\",\"description\":\"description\",\"enabled_events\":[\"enabled_events\"],\"event_payload\":\"thin\",\"events_from\":null,\"livemode\":true,\"metadata\":null,\"name\":\"name\",\"snapshot_api_version\":null,\"status\":\"disabled\",\"status_details\":null,\"type\":\"amazon_eventbridge\",\"updated\":\"1970-01-03T17:07:10.277Z\",\"webhook_endpoint\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.EventDestinations;
            Stripe.V2.EventDestination deleted = service.Delete("id_123");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v2/core/event_destinations/id_123");
        }

        [Fact]
        public void TestV2CoreEventDestinationPost2()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/event_destinations/id_123/disable",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.core.event_destination\",\"amazon_eventbridge\":null,\"created\":\"1970-01-12T21:42:34.472Z\",\"description\":\"description\",\"enabled_events\":[\"enabled_events\"],\"event_payload\":\"thin\",\"events_from\":null,\"livemode\":true,\"metadata\":null,\"name\":\"name\",\"snapshot_api_version\":null,\"status\":\"disabled\",\"status_details\":null,\"type\":\"amazon_eventbridge\",\"updated\":\"1970-01-03T17:07:10.277Z\",\"webhook_endpoint\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.EventDestinations;
            Stripe.V2.EventDestination eventDestination = service.Disable(
                "id_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/core/event_destinations/id_123/disable");
        }

        [Fact]
        public void TestV2CoreEventDestinationPost3()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/event_destinations/id_123/enable",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.core.event_destination\",\"amazon_eventbridge\":null,\"created\":\"1970-01-12T21:42:34.472Z\",\"description\":\"description\",\"enabled_events\":[\"enabled_events\"],\"event_payload\":\"thin\",\"events_from\":null,\"livemode\":true,\"metadata\":null,\"name\":\"name\",\"snapshot_api_version\":null,\"status\":\"disabled\",\"status_details\":null,\"type\":\"amazon_eventbridge\",\"updated\":\"1970-01-03T17:07:10.277Z\",\"webhook_endpoint\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.EventDestinations;
            Stripe.V2.EventDestination eventDestination = service.Enable(
                "id_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/core/event_destinations/id_123/enable");
        }

        [Fact]
        public void TestV2CoreEventDestinationGet()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/event_destinations",
                (HttpStatusCode)200,
                "{\"data\":[{\"id\":\"obj_123\",\"object\":\"v2.core.event_destination\",\"amazon_eventbridge\":null,\"created\":\"1970-01-12T21:42:34.472Z\",\"description\":\"description\",\"enabled_events\":[\"enabled_events\"],\"event_payload\":\"thin\",\"events_from\":null,\"livemode\":true,\"metadata\":null,\"name\":\"name\",\"snapshot_api_version\":null,\"status\":\"disabled\",\"status_details\":null,\"type\":\"amazon_eventbridge\",\"updated\":\"1970-01-03T17:07:10.277Z\",\"webhook_endpoint\":null}],\"next_page_url\":null,\"previous_page_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.EventDestinations;
            Stripe.V2.StripeList<Stripe.V2.EventDestination> eventDestinations = service
                .List();
            this.AssertRequest(HttpMethod.Get, "/v2/core/event_destinations");
        }

        [Fact]
        public void TestV2CoreEventDestinationPost4()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/event_destinations/id_123/ping",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.core.event\",\"context\":null,\"created\":\"1970-01-12T21:42:34.472Z\",\"livemode\":true,\"reason\":null,\"type\":\"type\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.EventDestinations;
            Stripe.V2.Event result = service.Ping("id_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/core/event_destinations/id_123/ping");
        }

        [Fact]
        public void TestV2CoreEventDestinationGet2()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/event_destinations/id_123",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.core.event_destination\",\"amazon_eventbridge\":null,\"created\":\"1970-01-12T21:42:34.472Z\",\"description\":\"description\",\"enabled_events\":[\"enabled_events\"],\"event_payload\":\"thin\",\"events_from\":null,\"livemode\":true,\"metadata\":null,\"name\":\"name\",\"snapshot_api_version\":null,\"status\":\"disabled\",\"status_details\":null,\"type\":\"amazon_eventbridge\",\"updated\":\"1970-01-03T17:07:10.277Z\",\"webhook_endpoint\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.EventDestinations;
            Stripe.V2.EventDestination eventDestination = service.Get("id_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/core/event_destinations/id_123");
        }

        [Fact]
        public void TestV2CoreEventDestinationPost5()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/event_destinations/id_123",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.core.event_destination\",\"amazon_eventbridge\":null,\"created\":\"1970-01-12T21:42:34.472Z\",\"description\":\"description\",\"enabled_events\":[\"enabled_events\"],\"event_payload\":\"thin\",\"events_from\":null,\"livemode\":true,\"metadata\":null,\"name\":\"name\",\"snapshot_api_version\":null,\"status\":\"disabled\",\"status_details\":null,\"type\":\"amazon_eventbridge\",\"updated\":\"1970-01-03T17:07:10.277Z\",\"webhook_endpoint\":null}");
            var options = new Stripe.V2.Core.EventDestinationUpdateOptions();
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.EventDestinations;
            Stripe.V2.EventDestination eventDestination = service.Update(
                "id_123",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/core/event_destinations/id_123");
        }

        [Fact]
        public void TestV2CoreEventGet()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/events",
                (HttpStatusCode)200,
                "{\"data\":[{\"id\":\"obj_123\",\"object\":\"v2.core.event\",\"context\":null,\"created\":\"1970-01-12T21:42:34.472Z\",\"livemode\":true,\"reason\":null,\"type\":\"type\"}],\"next_page_url\":null,\"previous_page_url\":null}",
                "object_id=object_id");
            var options = new Stripe.V2.Core.EventListOptions
            {
                ObjectId = "object_id",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Events;
            Stripe.V2.StripeList<Stripe.V2.Event> events = service.List(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/core/events",
                "object_id=object_id");
        }

        [Fact]
        public void TestV2CoreEventGet2()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/events/id_123",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.core.event\",\"context\":null,\"created\":\"1970-01-12T21:42:34.472Z\",\"livemode\":true,\"reason\":null,\"type\":\"type\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Events;
            Stripe.V2.Event result = service.Get("id_123");
            this.AssertRequest(HttpMethod.Get, "/v2/core/events/id_123");
        }

        [Fact]
        public void TestV2CoreVaultGbBankAccountPost()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/vault/gb_bank_accounts/id_123/acknowledge_confirmation_of_payee",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.core.vault.gb_bank_account\",\"archived\":true,\"bank_account_type\":\"savings\",\"bank_name\":\"bank_name\",\"confirmation_of_payee\":{\"result\":{\"created\":\"1970-01-12T21:42:34.472Z\",\"match_result\":\"unavailable\",\"matched\":{\"business_type\":null,\"name\":null},\"message\":\"message\",\"provided\":{\"business_type\":\"personal\",\"name\":\"name\"}},\"status\":\"awaiting_acknowledgement\"},\"created\":\"1970-01-12T21:42:34.472Z\",\"last4\":\"last4\",\"livemode\":true,\"sort_code\":\"sort_code\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Vault.GbBankAccounts;
            Stripe.V2.Core.Vault.GbBankAccount gbBankAccount = service
                .AcknowledgeConfirmationOfPayee("id_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/core/vault/gb_bank_accounts/id_123/acknowledge_confirmation_of_payee");
        }

        [Fact]
        public void TestV2CoreVaultGbBankAccountPost2()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/vault/gb_bank_accounts/id_123/archive",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.core.vault.gb_bank_account\",\"archived\":true,\"bank_account_type\":\"savings\",\"bank_name\":\"bank_name\",\"confirmation_of_payee\":{\"result\":{\"created\":\"1970-01-12T21:42:34.472Z\",\"match_result\":\"unavailable\",\"matched\":{\"business_type\":null,\"name\":null},\"message\":\"message\",\"provided\":{\"business_type\":\"personal\",\"name\":\"name\"}},\"status\":\"awaiting_acknowledgement\"},\"created\":\"1970-01-12T21:42:34.472Z\",\"last4\":\"last4\",\"livemode\":true,\"sort_code\":\"sort_code\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Vault.GbBankAccounts;
            Stripe.V2.Core.Vault.GbBankAccount gbBankAccount = service.Archive(
                "id_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/core/vault/gb_bank_accounts/id_123/archive");
        }

        [Fact]
        public void TestV2CoreVaultGbBankAccountPost3()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/vault/gb_bank_accounts",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.core.vault.gb_bank_account\",\"archived\":true,\"bank_account_type\":\"savings\",\"bank_name\":\"bank_name\",\"confirmation_of_payee\":{\"result\":{\"created\":\"1970-01-12T21:42:34.472Z\",\"match_result\":\"unavailable\",\"matched\":{\"business_type\":null,\"name\":null},\"message\":\"message\",\"provided\":{\"business_type\":\"personal\",\"name\":\"name\"}},\"status\":\"awaiting_acknowledgement\"},\"created\":\"1970-01-12T21:42:34.472Z\",\"last4\":\"last4\",\"livemode\":true,\"sort_code\":\"sort_code\"}");
            var options = new Stripe.V2.Core.Vault.GbBankAccountCreateOptions
            {
                AccountNumber = "account_number",
                SortCode = "sort_code",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Vault.GbBankAccounts;
            Stripe.V2.Core.Vault.GbBankAccount gbBankAccount = service.Create(
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/core/vault/gb_bank_accounts");
        }

        [Fact]
        public void TestV2CoreVaultGbBankAccountPost4()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/vault/gb_bank_accounts/id_123/initiate_confirmation_of_payee",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.core.vault.gb_bank_account\",\"archived\":true,\"bank_account_type\":\"savings\",\"bank_name\":\"bank_name\",\"confirmation_of_payee\":{\"result\":{\"created\":\"1970-01-12T21:42:34.472Z\",\"match_result\":\"unavailable\",\"matched\":{\"business_type\":null,\"name\":null},\"message\":\"message\",\"provided\":{\"business_type\":\"personal\",\"name\":\"name\"}},\"status\":\"awaiting_acknowledgement\"},\"created\":\"1970-01-12T21:42:34.472Z\",\"last4\":\"last4\",\"livemode\":true,\"sort_code\":\"sort_code\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Vault.GbBankAccounts;
            Stripe.V2.Core.Vault.GbBankAccount gbBankAccount = service
                .InitiateConfirmationOfPayee("id_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/core/vault/gb_bank_accounts/id_123/initiate_confirmation_of_payee");
        }

        [Fact]
        public void TestV2CoreVaultGbBankAccountGet()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/vault/gb_bank_accounts/id_123",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.core.vault.gb_bank_account\",\"archived\":true,\"bank_account_type\":\"savings\",\"bank_name\":\"bank_name\",\"confirmation_of_payee\":{\"result\":{\"created\":\"1970-01-12T21:42:34.472Z\",\"match_result\":\"unavailable\",\"matched\":{\"business_type\":null,\"name\":null},\"message\":\"message\",\"provided\":{\"business_type\":\"personal\",\"name\":\"name\"}},\"status\":\"awaiting_acknowledgement\"},\"created\":\"1970-01-12T21:42:34.472Z\",\"last4\":\"last4\",\"livemode\":true,\"sort_code\":\"sort_code\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Vault.GbBankAccounts;
            Stripe.V2.Core.Vault.GbBankAccount gbBankAccount = service.Get(
                "id_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/core/vault/gb_bank_accounts/id_123");
        }

        [Fact]
        public void TestV2CoreVaultUsBankAccountPost()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/vault/us_bank_accounts/id_123/archive",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.core.vault.us_bank_account\",\"archived\":true,\"bank_account_type\":\"savings\",\"bank_name\":\"bank_name\",\"created\":\"1970-01-12T21:42:34.472Z\",\"fedwire_routing_number\":null,\"last4\":\"last4\",\"livemode\":true,\"routing_number\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Vault.UsBankAccounts;
            Stripe.V2.Core.Vault.UsBankAccount usBankAccount = service.Archive(
                "id_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/core/vault/us_bank_accounts/id_123/archive");
        }

        [Fact]
        public void TestV2CoreVaultUsBankAccountPost2()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/vault/us_bank_accounts",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.core.vault.us_bank_account\",\"archived\":true,\"bank_account_type\":\"savings\",\"bank_name\":\"bank_name\",\"created\":\"1970-01-12T21:42:34.472Z\",\"fedwire_routing_number\":null,\"last4\":\"last4\",\"livemode\":true,\"routing_number\":null}");
            var options = new Stripe.V2.Core.Vault.UsBankAccountCreateOptions
            {
                AccountNumber = "account_number",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Vault.UsBankAccounts;
            Stripe.V2.Core.Vault.UsBankAccount usBankAccount = service.Create(
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/core/vault/us_bank_accounts");
        }

        [Fact]
        public void TestV2CoreVaultUsBankAccountGet()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/core/vault/us_bank_accounts/id_123",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.core.vault.us_bank_account\",\"archived\":true,\"bank_account_type\":\"savings\",\"bank_name\":\"bank_name\",\"created\":\"1970-01-12T21:42:34.472Z\",\"fedwire_routing_number\":null,\"last4\":\"last4\",\"livemode\":true,\"routing_number\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Vault.UsBankAccounts;
            Stripe.V2.Core.Vault.UsBankAccount usBankAccount = service.Get(
                "id_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/core/vault/us_bank_accounts/id_123");
        }

        [Fact]
        public void TestV2CoreVaultUsBankAccountPost3()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/vault/us_bank_accounts/id_123",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.core.vault.us_bank_account\",\"archived\":true,\"bank_account_type\":\"savings\",\"bank_name\":\"bank_name\",\"created\":\"1970-01-12T21:42:34.472Z\",\"fedwire_routing_number\":null,\"last4\":\"last4\",\"livemode\":true,\"routing_number\":null}");
            var options = new Stripe.V2.Core.Vault.UsBankAccountUpdateOptions();
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Vault.UsBankAccounts;
            Stripe.V2.Core.Vault.UsBankAccount usBankAccount = service.Update(
                "id_123",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/core/vault/us_bank_accounts/id_123");
        }

        [Fact]
        public void TestV2MoneyManagementAdjustmentGet()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/money_management/adjustments",
                (HttpStatusCode)200,
                "{\"data\":[{\"id\":\"obj_123\",\"object\":\"v2.money_management.adjustment\",\"adjusted_flow\":null,\"amount\":{\"currency\":\"USD\",\"value\":96},\"created\":\"1970-01-12T21:42:34.472Z\",\"description\":null,\"financial_account\":\"financial_account\",\"livemode\":true,\"receipt_url\":null}],\"next_page_url\":null,\"previous_page_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.Adjustments;
            Stripe.V2.StripeList<Stripe.V2.MoneyManagement.Adjustment> adjustments = service
                .List();
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/money_management/adjustments");
        }

        [Fact]
        public void TestV2MoneyManagementAdjustmentGet2()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/money_management/adjustments/id_123",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.money_management.adjustment\",\"adjusted_flow\":null,\"amount\":{\"currency\":\"USD\",\"value\":96},\"created\":\"1970-01-12T21:42:34.472Z\",\"description\":null,\"financial_account\":\"financial_account\",\"livemode\":true,\"receipt_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.Adjustments;
            Stripe.V2.MoneyManagement.Adjustment adjustment = service.Get(
                "id_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/money_management/adjustments/id_123");
        }

        [Fact]
        public void TestV2MoneyManagementFinancialAccountGet()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/money_management/financial_accounts",
                (HttpStatusCode)200,
                "{\"data\":[{\"id\":\"obj_123\",\"object\":\"v2.money_management.financial_account\",\"balance\":{\"available\":{\"undefined\":{\"currency\":\"USD\",\"value\":35}},\"inbound_pending\":{\"undefined\":{\"currency\":\"USD\",\"value\":11}},\"outbound_pending\":{\"undefined\":{\"currency\":\"USD\",\"value\":60}}},\"country\":\"ec\",\"created\":\"1970-01-12T21:42:34.472Z\",\"description\":null,\"livemode\":true,\"other\":null,\"status\":\"closed\",\"storage\":null,\"type\":\"other\"}],\"next_page_url\":null,\"previous_page_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.FinancialAccounts;
            Stripe.V2.StripeList<Stripe.V2.MoneyManagement.FinancialAccount> financialAccounts = service
                .List();
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/money_management/financial_accounts");
        }

        [Fact]
        public void TestV2MoneyManagementFinancialAccountGet2()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/money_management/financial_accounts/id_123",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.money_management.financial_account\",\"balance\":{\"available\":{\"undefined\":{\"currency\":\"USD\",\"value\":35}},\"inbound_pending\":{\"undefined\":{\"currency\":\"USD\",\"value\":11}},\"outbound_pending\":{\"undefined\":{\"currency\":\"USD\",\"value\":60}}},\"country\":\"ec\",\"created\":\"1970-01-12T21:42:34.472Z\",\"description\":null,\"livemode\":true,\"other\":null,\"status\":\"closed\",\"storage\":null,\"type\":\"other\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.FinancialAccounts;
            Stripe.V2.MoneyManagement.FinancialAccount financialAccount = service
                .Get("id_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/money_management/financial_accounts/id_123");
        }

        [Fact]
        public void TestV2MoneyManagementFinancialAddressPost()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/money_management/financial_addresses",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.money_management.financial_address\",\"created\":\"1970-01-12T21:42:34.472Z\",\"credentials\":null,\"currency\":\"stn\",\"financial_account\":\"financial_account\",\"livemode\":true,\"status\":\"failed\"}");
            var options = new Stripe.V2.MoneyManagement.FinancialAddressCreateOptions
            {
                Currency = "stn",
                FinancialAccount = "financial_account",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.FinancialAddresses;
            Stripe.V2.MoneyManagement.FinancialAddress financialAddress = service
                .Create(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/money_management/financial_addresses");
        }

        [Fact]
        public void TestV2MoneyManagementFinancialAddressGet()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/money_management/financial_addresses",
                (HttpStatusCode)200,
                "{\"data\":[{\"id\":\"obj_123\",\"object\":\"v2.money_management.financial_address\",\"created\":\"1970-01-12T21:42:34.472Z\",\"credentials\":null,\"currency\":\"stn\",\"financial_account\":\"financial_account\",\"livemode\":true,\"status\":\"failed\"}],\"next_page_url\":null,\"previous_page_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.FinancialAddresses;
            Stripe.V2.StripeList<Stripe.V2.MoneyManagement.FinancialAddress> financialAddresses = service
                .List();
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/money_management/financial_addresses");
        }

        [Fact]
        public void TestV2MoneyManagementFinancialAddressGet2()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/money_management/financial_addresses/id_123",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.money_management.financial_address\",\"created\":\"1970-01-12T21:42:34.472Z\",\"credentials\":null,\"currency\":\"stn\",\"financial_account\":\"financial_account\",\"livemode\":true,\"status\":\"failed\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.FinancialAddresses;
            Stripe.V2.MoneyManagement.FinancialAddress financialAddress = service
                .Get("id_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/money_management/financial_addresses/id_123");
        }

        [Fact]
        public void TestV2MoneyManagementInboundTransferPost()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/money_management/inbound_transfers",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.money_management.inbound_transfer\",\"amount\":{\"currency\":\"USD\",\"value\":96},\"created\":\"1970-01-12T21:42:34.472Z\",\"description\":\"description\",\"from\":{\"debited\":{\"currency\":\"USD\",\"value\":55},\"payment_method\":{\"type\":\"type\",\"us_bank_account\":null}},\"livemode\":true,\"receipt_url\":null,\"to\":{\"credited\":{\"currency\":\"USD\",\"value\":68},\"financial_account\":\"financial_account\"},\"transfer_history\":[{\"created\":\"1970-01-12T21:42:34.472Z\",\"effective_at\":\"1970-01-03T20:38:28.043Z\",\"id\":\"obj_123\",\"level\":\"canonical\",\"type\":\"bank_debit_failed\",\"bank_debit_failed\":null,\"bank_debit_processing\":null,\"bank_debit_queued\":null,\"bank_debit_returned\":null,\"bank_debit_succeeded\":null}]}");
            var options = new Stripe.V2.MoneyManagement.InboundTransferCreateOptions
            {
                Amount = new Stripe.V2.Amount { Currency = "USD", Value = 96 },
                From = new Stripe.V2.MoneyManagement.InboundTransferCreateFromOptions
                {
                    Currency = "currency",
                    PaymentMethod = "payment_method",
                },
                To = new Stripe.V2.MoneyManagement.InboundTransferCreateToOptions
                {
                    Currency = "currency",
                    FinancialAccount = "financial_account",
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.InboundTransfers;
            Stripe.V2.MoneyManagement.InboundTransfer inboundTransfer = service
                .Create(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/money_management/inbound_transfers");
        }

        [Fact]
        public void TestV2MoneyManagementInboundTransferGet()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/money_management/inbound_transfers",
                (HttpStatusCode)200,
                "{\"data\":[{\"id\":\"obj_123\",\"object\":\"v2.money_management.inbound_transfer\",\"amount\":{\"currency\":\"USD\",\"value\":96},\"created\":\"1970-01-12T21:42:34.472Z\",\"description\":\"description\",\"from\":{\"debited\":{\"currency\":\"USD\",\"value\":55},\"payment_method\":{\"type\":\"type\",\"us_bank_account\":null}},\"livemode\":true,\"receipt_url\":null,\"to\":{\"credited\":{\"currency\":\"USD\",\"value\":68},\"financial_account\":\"financial_account\"},\"transfer_history\":[{\"created\":\"1970-01-12T21:42:34.472Z\",\"effective_at\":\"1970-01-03T20:38:28.043Z\",\"id\":\"obj_123\",\"level\":\"canonical\",\"type\":\"bank_debit_failed\",\"bank_debit_failed\":null,\"bank_debit_processing\":null,\"bank_debit_queued\":null,\"bank_debit_returned\":null,\"bank_debit_succeeded\":null}]}],\"next_page_url\":null,\"previous_page_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.InboundTransfers;
            Stripe.V2.StripeList<Stripe.V2.MoneyManagement.InboundTransfer> inboundTransfers = service
                .List();
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/money_management/inbound_transfers");
        }

        [Fact]
        public void TestV2MoneyManagementInboundTransferGet2()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/money_management/inbound_transfers/id_123",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.money_management.inbound_transfer\",\"amount\":{\"currency\":\"USD\",\"value\":96},\"created\":\"1970-01-12T21:42:34.472Z\",\"description\":\"description\",\"from\":{\"debited\":{\"currency\":\"USD\",\"value\":55},\"payment_method\":{\"type\":\"type\",\"us_bank_account\":null}},\"livemode\":true,\"receipt_url\":null,\"to\":{\"credited\":{\"currency\":\"USD\",\"value\":68},\"financial_account\":\"financial_account\"},\"transfer_history\":[{\"created\":\"1970-01-12T21:42:34.472Z\",\"effective_at\":\"1970-01-03T20:38:28.043Z\",\"id\":\"obj_123\",\"level\":\"canonical\",\"type\":\"bank_debit_failed\",\"bank_debit_failed\":null,\"bank_debit_processing\":null,\"bank_debit_queued\":null,\"bank_debit_returned\":null,\"bank_debit_succeeded\":null}]}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.InboundTransfers;
            Stripe.V2.MoneyManagement.InboundTransfer inboundTransfer = service
                .Get("id_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/money_management/inbound_transfers/id_123");
        }

        [Fact]
        public void TestV2MoneyManagementOutboundPaymentPost()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/money_management/outbound_payments/id_123/cancel",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.money_management.outbound_payment\",\"amount\":{\"currency\":\"USD\",\"value\":96},\"cancelable\":true,\"created\":\"1970-01-12T21:42:34.472Z\",\"delivery_options\":null,\"description\":null,\"expected_arrival_date\":null,\"from\":{\"debited\":{\"currency\":\"USD\",\"value\":55},\"financial_account\":\"financial_account\"},\"livemode\":true,\"metadata\":null,\"outbound_payment_quote\":null,\"receipt_url\":null,\"recipient_notification\":{\"setting\":\"configured\"},\"statement_descriptor\":\"statement_descriptor\",\"status\":\"canceled\",\"status_details\":null,\"status_transitions\":null,\"to\":{\"credited\":{\"currency\":\"USD\",\"value\":68},\"payout_method\":\"payout_method\",\"recipient\":\"recipient\"},\"trace_id\":{\"status\":\"pending\",\"value\":null}}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.OutboundPayments;
            Stripe.V2.MoneyManagement.OutboundPayment outboundPayment = service
                .Cancel("id_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/money_management/outbound_payments/id_123/cancel");
        }

        [Fact]
        public void TestV2MoneyManagementOutboundPaymentPost2()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/money_management/outbound_payments",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.money_management.outbound_payment\",\"amount\":{\"currency\":\"USD\",\"value\":96},\"cancelable\":true,\"created\":\"1970-01-12T21:42:34.472Z\",\"delivery_options\":null,\"description\":null,\"expected_arrival_date\":null,\"from\":{\"debited\":{\"currency\":\"USD\",\"value\":55},\"financial_account\":\"financial_account\"},\"livemode\":true,\"metadata\":null,\"outbound_payment_quote\":null,\"receipt_url\":null,\"recipient_notification\":{\"setting\":\"configured\"},\"statement_descriptor\":\"statement_descriptor\",\"status\":\"canceled\",\"status_details\":null,\"status_transitions\":null,\"to\":{\"credited\":{\"currency\":\"USD\",\"value\":68},\"payout_method\":\"payout_method\",\"recipient\":\"recipient\"},\"trace_id\":{\"status\":\"pending\",\"value\":null}}");
            var options = new Stripe.V2.MoneyManagement.OutboundPaymentCreateOptions
            {
                Amount = new Stripe.V2.Amount { Currency = "USD", Value = 96 },
                From = new Stripe.V2.MoneyManagement.OutboundPaymentCreateFromOptions
                {
                    Currency = "currency",
                    FinancialAccount = "financial_account",
                },
                To = new Stripe.V2.MoneyManagement.OutboundPaymentCreateToOptions
                {
                    Currency = "currency",
                    PayoutMethod = "payout_method",
                    Recipient = "recipient",
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.OutboundPayments;
            Stripe.V2.MoneyManagement.OutboundPayment outboundPayment = service
                .Create(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/money_management/outbound_payments");
        }

        [Fact]
        public void TestV2MoneyManagementOutboundPaymentGet()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/money_management/outbound_payments",
                (HttpStatusCode)200,
                "{\"data\":[{\"id\":\"obj_123\",\"object\":\"v2.money_management.outbound_payment\",\"amount\":{\"currency\":\"USD\",\"value\":96},\"cancelable\":true,\"created\":\"1970-01-12T21:42:34.472Z\",\"delivery_options\":null,\"description\":null,\"expected_arrival_date\":null,\"from\":{\"debited\":{\"currency\":\"USD\",\"value\":55},\"financial_account\":\"financial_account\"},\"livemode\":true,\"metadata\":null,\"outbound_payment_quote\":null,\"receipt_url\":null,\"recipient_notification\":{\"setting\":\"configured\"},\"statement_descriptor\":\"statement_descriptor\",\"status\":\"canceled\",\"status_details\":null,\"status_transitions\":null,\"to\":{\"credited\":{\"currency\":\"USD\",\"value\":68},\"payout_method\":\"payout_method\",\"recipient\":\"recipient\"},\"trace_id\":{\"status\":\"pending\",\"value\":null}}],\"next_page_url\":null,\"previous_page_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.OutboundPayments;
            Stripe.V2.StripeList<Stripe.V2.MoneyManagement.OutboundPayment> outboundPayments = service
                .List();
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/money_management/outbound_payments");
        }

        [Fact]
        public void TestV2MoneyManagementOutboundPaymentGet2()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/money_management/outbound_payments/id_123",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.money_management.outbound_payment\",\"amount\":{\"currency\":\"USD\",\"value\":96},\"cancelable\":true,\"created\":\"1970-01-12T21:42:34.472Z\",\"delivery_options\":null,\"description\":null,\"expected_arrival_date\":null,\"from\":{\"debited\":{\"currency\":\"USD\",\"value\":55},\"financial_account\":\"financial_account\"},\"livemode\":true,\"metadata\":null,\"outbound_payment_quote\":null,\"receipt_url\":null,\"recipient_notification\":{\"setting\":\"configured\"},\"statement_descriptor\":\"statement_descriptor\",\"status\":\"canceled\",\"status_details\":null,\"status_transitions\":null,\"to\":{\"credited\":{\"currency\":\"USD\",\"value\":68},\"payout_method\":\"payout_method\",\"recipient\":\"recipient\"},\"trace_id\":{\"status\":\"pending\",\"value\":null}}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.OutboundPayments;
            Stripe.V2.MoneyManagement.OutboundPayment outboundPayment = service
                .Get("id_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/money_management/outbound_payments/id_123");
        }

        [Fact]
        public void TestV2MoneyManagementOutboundPaymentQuotePost()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/money_management/outbound_payment_quotes",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.money_management.outbound_payment_quote\",\"amount\":{\"currency\":\"USD\",\"value\":96},\"created\":\"1970-01-12T21:42:34.472Z\",\"delivery_options\":null,\"estimated_fees\":[{\"amount\":{\"currency\":\"USD\",\"value\":96},\"type\":\"cross_border_payout_fee\"}],\"from\":{\"debited\":{\"currency\":\"USD\",\"value\":55},\"financial_account\":\"financial_account\"},\"fx_quote\":{\"lock_duration\":\"five_minutes\",\"lock_expires_at\":\"1970-01-18T15:15:29.586Z\",\"lock_status\":\"active\",\"rates\":{\"undefined\":{\"exchange_rate\":\"exchange_rate\"}},\"to_currency\":\"to_currency\"},\"livemode\":true,\"to\":{\"credited\":{\"currency\":\"USD\",\"value\":68},\"payout_method\":\"payout_method\",\"recipient\":\"recipient\"}}");
            var options = new Stripe.V2.MoneyManagement.OutboundPaymentQuoteCreateOptions
            {
                Amount = new Stripe.V2.Amount { Currency = "USD", Value = 96 },
                From = new Stripe.V2.MoneyManagement.OutboundPaymentQuoteCreateFromOptions
                {
                    Currency = "currency",
                    FinancialAccount = "financial_account",
                },
                To = new Stripe.V2.MoneyManagement.OutboundPaymentQuoteCreateToOptions
                {
                    Currency = "currency",
                    PayoutMethod = "payout_method",
                    Recipient = "recipient",
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.OutboundPaymentQuotes;
            Stripe.V2.MoneyManagement.OutboundPaymentQuote outboundPaymentQuote = service
                .Create(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/money_management/outbound_payment_quotes");
        }

        [Fact]
        public void TestV2MoneyManagementOutboundPaymentQuoteGet()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/money_management/outbound_payment_quotes/id_123",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.money_management.outbound_payment_quote\",\"amount\":{\"currency\":\"USD\",\"value\":96},\"created\":\"1970-01-12T21:42:34.472Z\",\"delivery_options\":null,\"estimated_fees\":[{\"amount\":{\"currency\":\"USD\",\"value\":96},\"type\":\"cross_border_payout_fee\"}],\"from\":{\"debited\":{\"currency\":\"USD\",\"value\":55},\"financial_account\":\"financial_account\"},\"fx_quote\":{\"lock_duration\":\"five_minutes\",\"lock_expires_at\":\"1970-01-18T15:15:29.586Z\",\"lock_status\":\"active\",\"rates\":{\"undefined\":{\"exchange_rate\":\"exchange_rate\"}},\"to_currency\":\"to_currency\"},\"livemode\":true,\"to\":{\"credited\":{\"currency\":\"USD\",\"value\":68},\"payout_method\":\"payout_method\",\"recipient\":\"recipient\"}}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.OutboundPaymentQuotes;
            Stripe.V2.MoneyManagement.OutboundPaymentQuote outboundPaymentQuote = service
                .Get("id_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/money_management/outbound_payment_quotes/id_123");
        }

        [Fact]
        public void TestV2MoneyManagementOutboundTransferPost()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/money_management/outbound_transfers/id_123/cancel",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.money_management.outbound_transfer\",\"amount\":{\"currency\":\"USD\",\"value\":96},\"cancelable\":true,\"created\":\"1970-01-12T21:42:34.472Z\",\"delivery_options\":null,\"description\":null,\"expected_arrival_date\":null,\"from\":{\"debited\":{\"currency\":\"USD\",\"value\":55},\"financial_account\":\"financial_account\"},\"livemode\":true,\"metadata\":null,\"receipt_url\":null,\"statement_descriptor\":\"statement_descriptor\",\"status\":\"canceled\",\"status_details\":null,\"status_transitions\":null,\"to\":{\"credited\":{\"currency\":\"USD\",\"value\":68},\"payout_method\":\"payout_method\"},\"trace_id\":{\"status\":\"pending\",\"value\":null}}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.OutboundTransfers;
            Stripe.V2.MoneyManagement.OutboundTransfer outboundTransfer = service
                .Cancel("id_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/money_management/outbound_transfers/id_123/cancel");
        }

        [Fact]
        public void TestV2MoneyManagementOutboundTransferPost2()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/money_management/outbound_transfers",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.money_management.outbound_transfer\",\"amount\":{\"currency\":\"USD\",\"value\":96},\"cancelable\":true,\"created\":\"1970-01-12T21:42:34.472Z\",\"delivery_options\":null,\"description\":null,\"expected_arrival_date\":null,\"from\":{\"debited\":{\"currency\":\"USD\",\"value\":55},\"financial_account\":\"financial_account\"},\"livemode\":true,\"metadata\":null,\"receipt_url\":null,\"statement_descriptor\":\"statement_descriptor\",\"status\":\"canceled\",\"status_details\":null,\"status_transitions\":null,\"to\":{\"credited\":{\"currency\":\"USD\",\"value\":68},\"payout_method\":\"payout_method\"},\"trace_id\":{\"status\":\"pending\",\"value\":null}}");
            var options = new Stripe.V2.MoneyManagement.OutboundTransferCreateOptions
            {
                Amount = new Stripe.V2.Amount { Currency = "USD", Value = 96 },
                From = new Stripe.V2.MoneyManagement.OutboundTransferCreateFromOptions
                {
                    Currency = "currency",
                    FinancialAccount = "financial_account",
                },
                To = new Stripe.V2.MoneyManagement.OutboundTransferCreateToOptions
                {
                    Currency = "currency",
                    PayoutMethod = "payout_method",
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.OutboundTransfers;
            Stripe.V2.MoneyManagement.OutboundTransfer outboundTransfer = service
                .Create(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/money_management/outbound_transfers");
        }

        [Fact]
        public void TestV2MoneyManagementOutboundTransferGet()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/money_management/outbound_transfers",
                (HttpStatusCode)200,
                "{\"data\":[{\"id\":\"obj_123\",\"object\":\"v2.money_management.outbound_transfer\",\"amount\":{\"currency\":\"USD\",\"value\":96},\"cancelable\":true,\"created\":\"1970-01-12T21:42:34.472Z\",\"delivery_options\":null,\"description\":null,\"expected_arrival_date\":null,\"from\":{\"debited\":{\"currency\":\"USD\",\"value\":55},\"financial_account\":\"financial_account\"},\"livemode\":true,\"metadata\":null,\"receipt_url\":null,\"statement_descriptor\":\"statement_descriptor\",\"status\":\"canceled\",\"status_details\":null,\"status_transitions\":null,\"to\":{\"credited\":{\"currency\":\"USD\",\"value\":68},\"payout_method\":\"payout_method\"},\"trace_id\":{\"status\":\"pending\",\"value\":null}}],\"next_page_url\":null,\"previous_page_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.OutboundTransfers;
            Stripe.V2.StripeList<Stripe.V2.MoneyManagement.OutboundTransfer> outboundTransfers = service
                .List();
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/money_management/outbound_transfers");
        }

        [Fact]
        public void TestV2MoneyManagementOutboundTransferGet2()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/money_management/outbound_transfers/id_123",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.money_management.outbound_transfer\",\"amount\":{\"currency\":\"USD\",\"value\":96},\"cancelable\":true,\"created\":\"1970-01-12T21:42:34.472Z\",\"delivery_options\":null,\"description\":null,\"expected_arrival_date\":null,\"from\":{\"debited\":{\"currency\":\"USD\",\"value\":55},\"financial_account\":\"financial_account\"},\"livemode\":true,\"metadata\":null,\"receipt_url\":null,\"statement_descriptor\":\"statement_descriptor\",\"status\":\"canceled\",\"status_details\":null,\"status_transitions\":null,\"to\":{\"credited\":{\"currency\":\"USD\",\"value\":68},\"payout_method\":\"payout_method\"},\"trace_id\":{\"status\":\"pending\",\"value\":null}}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.OutboundTransfers;
            Stripe.V2.MoneyManagement.OutboundTransfer outboundTransfer = service
                .Get("id_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/money_management/outbound_transfers/id_123");
        }

        [Fact]
        public void TestV2MoneyManagementOutboundSetupIntentPost()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/money_management/outbound_setup_intents/id_123/cancel",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.money_management.outbound_setup_intent\",\"created\":\"1970-01-12T21:42:34.472Z\",\"livemode\":true,\"next_action\":null,\"payout_method\":{\"id\":\"obj_123\",\"object\":\"v2.money_management.payout_method\",\"available_payout_speeds\":[\"standard\"],\"bank_account\":null,\"card\":null,\"created\":\"1970-01-12T21:42:34.472Z\",\"latest_outbound_setup_intent\":null,\"livemode\":true,\"type\":\"bank_account\",\"usage_status\":{\"payments\":\"requires_action\",\"transfers\":\"invalid\"}},\"status\":\"requires_payout_method\",\"usage_intent\":\"payment\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.OutboundSetupIntents;
            Stripe.V2.MoneyManagement.OutboundSetupIntent outboundSetupIntent = service
                .Cancel("id_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/money_management/outbound_setup_intents/id_123/cancel");
        }

        [Fact]
        public void TestV2MoneyManagementOutboundSetupIntentPost2()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/money_management/outbound_setup_intents",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.money_management.outbound_setup_intent\",\"created\":\"1970-01-12T21:42:34.472Z\",\"livemode\":true,\"next_action\":null,\"payout_method\":{\"id\":\"obj_123\",\"object\":\"v2.money_management.payout_method\",\"available_payout_speeds\":[\"standard\"],\"bank_account\":null,\"card\":null,\"created\":\"1970-01-12T21:42:34.472Z\",\"latest_outbound_setup_intent\":null,\"livemode\":true,\"type\":\"bank_account\",\"usage_status\":{\"payments\":\"requires_action\",\"transfers\":\"invalid\"}},\"status\":\"requires_payout_method\",\"usage_intent\":\"payment\"}");
            var options = new Stripe.V2.MoneyManagement.OutboundSetupIntentCreateOptions();
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.OutboundSetupIntents;
            Stripe.V2.MoneyManagement.OutboundSetupIntent outboundSetupIntent = service
                .Create(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/money_management/outbound_setup_intents");
        }

        [Fact]
        public void TestV2MoneyManagementOutboundSetupIntentGet()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/money_management/outbound_setup_intents",
                (HttpStatusCode)200,
                "{\"data\":[{\"id\":\"obj_123\",\"object\":\"v2.money_management.outbound_setup_intent\",\"created\":\"1970-01-12T21:42:34.472Z\",\"livemode\":true,\"next_action\":null,\"payout_method\":{\"id\":\"obj_123\",\"object\":\"v2.money_management.payout_method\",\"available_payout_speeds\":[\"standard\"],\"bank_account\":null,\"card\":null,\"created\":\"1970-01-12T21:42:34.472Z\",\"latest_outbound_setup_intent\":null,\"livemode\":true,\"type\":\"bank_account\",\"usage_status\":{\"payments\":\"requires_action\",\"transfers\":\"invalid\"}},\"status\":\"requires_payout_method\",\"usage_intent\":\"payment\"}],\"next_page_url\":null,\"previous_page_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.OutboundSetupIntents;
            Stripe.V2.StripeList<Stripe.V2.MoneyManagement.OutboundSetupIntent> outboundSetupIntents = service
                .List();
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/money_management/outbound_setup_intents");
        }

        [Fact]
        public void TestV2MoneyManagementOutboundSetupIntentGet2()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/money_management/outbound_setup_intents/id_123",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.money_management.outbound_setup_intent\",\"created\":\"1970-01-12T21:42:34.472Z\",\"livemode\":true,\"next_action\":null,\"payout_method\":{\"id\":\"obj_123\",\"object\":\"v2.money_management.payout_method\",\"available_payout_speeds\":[\"standard\"],\"bank_account\":null,\"card\":null,\"created\":\"1970-01-12T21:42:34.472Z\",\"latest_outbound_setup_intent\":null,\"livemode\":true,\"type\":\"bank_account\",\"usage_status\":{\"payments\":\"requires_action\",\"transfers\":\"invalid\"}},\"status\":\"requires_payout_method\",\"usage_intent\":\"payment\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.OutboundSetupIntents;
            Stripe.V2.MoneyManagement.OutboundSetupIntent outboundSetupIntent = service
                .Get("id_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/money_management/outbound_setup_intents/id_123");
        }

        [Fact]
        public void TestV2MoneyManagementOutboundSetupIntentPost3()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/money_management/outbound_setup_intents/id_123",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.money_management.outbound_setup_intent\",\"created\":\"1970-01-12T21:42:34.472Z\",\"livemode\":true,\"next_action\":null,\"payout_method\":{\"id\":\"obj_123\",\"object\":\"v2.money_management.payout_method\",\"available_payout_speeds\":[\"standard\"],\"bank_account\":null,\"card\":null,\"created\":\"1970-01-12T21:42:34.472Z\",\"latest_outbound_setup_intent\":null,\"livemode\":true,\"type\":\"bank_account\",\"usage_status\":{\"payments\":\"requires_action\",\"transfers\":\"invalid\"}},\"status\":\"requires_payout_method\",\"usage_intent\":\"payment\"}");
            var options = new Stripe.V2.MoneyManagement.OutboundSetupIntentUpdateOptions();
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.OutboundSetupIntents;
            Stripe.V2.MoneyManagement.OutboundSetupIntent outboundSetupIntent = service
                .Update("id_123", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/money_management/outbound_setup_intents/id_123");
        }

        [Fact]
        public void TestV2MoneyManagementPayoutMethodPost()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/money_management/payout_methods/id_123/archive",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.money_management.payout_method\",\"available_payout_speeds\":[\"standard\"],\"bank_account\":null,\"card\":null,\"created\":\"1970-01-12T21:42:34.472Z\",\"latest_outbound_setup_intent\":null,\"livemode\":true,\"type\":\"bank_account\",\"usage_status\":{\"payments\":\"requires_action\",\"transfers\":\"invalid\"}}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.PayoutMethods;
            Stripe.V2.MoneyManagement.PayoutMethod payoutMethod = service
                .Archive("id_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/money_management/payout_methods/id_123/archive");
        }

        [Fact]
        public void TestV2MoneyManagementPayoutMethodGet()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/money_management/payout_methods",
                (HttpStatusCode)200,
                "{\"data\":[{\"id\":\"obj_123\",\"object\":\"v2.money_management.payout_method\",\"available_payout_speeds\":[\"standard\"],\"bank_account\":null,\"card\":null,\"created\":\"1970-01-12T21:42:34.472Z\",\"latest_outbound_setup_intent\":null,\"livemode\":true,\"type\":\"bank_account\",\"usage_status\":{\"payments\":\"requires_action\",\"transfers\":\"invalid\"}}],\"next_page_url\":null,\"previous_page_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.PayoutMethods;
            Stripe.V2.StripeList<Stripe.V2.MoneyManagement.PayoutMethod> payoutMethods = service
                .List();
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/money_management/payout_methods");
        }

        [Fact]
        public void TestV2MoneyManagementPayoutMethodGet2()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/money_management/payout_methods/id_123",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.money_management.payout_method\",\"available_payout_speeds\":[\"standard\"],\"bank_account\":null,\"card\":null,\"created\":\"1970-01-12T21:42:34.472Z\",\"latest_outbound_setup_intent\":null,\"livemode\":true,\"type\":\"bank_account\",\"usage_status\":{\"payments\":\"requires_action\",\"transfers\":\"invalid\"}}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.PayoutMethods;
            Stripe.V2.MoneyManagement.PayoutMethod payoutMethod = service.Get(
                "id_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/money_management/payout_methods/id_123");
        }

        [Fact]
        public void TestV2MoneyManagementPayoutMethodPost2()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/money_management/payout_methods/id_123/unarchive",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.money_management.payout_method\",\"available_payout_speeds\":[\"standard\"],\"bank_account\":null,\"card\":null,\"created\":\"1970-01-12T21:42:34.472Z\",\"latest_outbound_setup_intent\":null,\"livemode\":true,\"type\":\"bank_account\",\"usage_status\":{\"payments\":\"requires_action\",\"transfers\":\"invalid\"}}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.PayoutMethods;
            Stripe.V2.MoneyManagement.PayoutMethod payoutMethod = service
                .Unarchive("id_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/money_management/payout_methods/id_123/unarchive");
        }

        [Fact]
        public void TestV2MoneyManagementPayoutMethodsBankAccountSpecGet()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/money_management/payout_methods_bank_account_spec",
                (HttpStatusCode)200,
                "{\"object\":\"v2.money_management.payout_methods_bank_account_spec\",\"countries\":{\"undefined\":{\"fields\":[{\"local_name\":\"local_name\",\"local_name_human\":{\"content\":\"content\",\"localization_key\":\"localization_key\"},\"max_length\":1111390753,\"min_length\":711577229,\"placeholder\":\"placeholder\",\"stripe_name\":\"stripe_name\",\"validation_regex\":\"validation_regex\"}]}},\"livemode\":true}");
            var client = new StripeClient(this.Requestor);
            var service = client
                .V2
                .MoneyManagement
                .PayoutMethodsBankAccountSpec;
            Stripe.V2.MoneyManagement.PayoutMethodsBankAccountSpec payoutMethodsBankAccountSpec = service
                .Get();
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/money_management/payout_methods_bank_account_spec");
        }

        [Fact]
        public void TestV2MoneyManagementReceivedCreditGet()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/money_management/received_credits",
                (HttpStatusCode)200,
                "{\"data\":[{\"id\":\"obj_123\",\"object\":\"v2.money_management.received_credit\",\"amount\":{\"currency\":\"USD\",\"value\":96},\"balance_transfer\":null,\"bank_transfer\":null,\"card_spend\":null,\"created\":\"1970-01-12T21:42:34.472Z\",\"description\":null,\"financial_account\":\"financial_account\",\"livemode\":true,\"receipt_url\":null,\"status\":\"returned\",\"status_details\":null,\"status_transitions\":null,\"type\":\"card_spend\"}],\"next_page_url\":null,\"previous_page_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.ReceivedCredits;
            Stripe.V2.StripeList<Stripe.V2.MoneyManagement.ReceivedCredit> receivedCredits = service
                .List();
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/money_management/received_credits");
        }

        [Fact]
        public void TestV2MoneyManagementReceivedCreditGet2()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/money_management/received_credits/id_123",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.money_management.received_credit\",\"amount\":{\"currency\":\"USD\",\"value\":96},\"balance_transfer\":null,\"bank_transfer\":null,\"card_spend\":null,\"created\":\"1970-01-12T21:42:34.472Z\",\"description\":null,\"financial_account\":\"financial_account\",\"livemode\":true,\"receipt_url\":null,\"status\":\"returned\",\"status_details\":null,\"status_transitions\":null,\"type\":\"card_spend\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.ReceivedCredits;
            Stripe.V2.MoneyManagement.ReceivedCredit receivedCredit = service
                .Get("id_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/money_management/received_credits/id_123");
        }

        [Fact]
        public void TestV2MoneyManagementReceivedDebitGet()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/money_management/received_debits",
                (HttpStatusCode)200,
                "{\"data\":[{\"id\":\"obj_123\",\"object\":\"v2.money_management.received_debit\",\"amount\":{\"currency\":\"USD\",\"value\":96},\"bank_transfer\":null,\"card_spend\":null,\"created\":\"1970-01-12T21:42:34.472Z\",\"description\":null,\"financial_account\":\"financial_account\",\"livemode\":true,\"receipt_url\":null,\"status\":\"canceled\",\"status_details\":null,\"status_transitions\":null,\"type\":\"bank_transfer\"}],\"next_page_url\":null,\"previous_page_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.ReceivedDebits;
            Stripe.V2.StripeList<Stripe.V2.MoneyManagement.ReceivedDebit> receivedDebits = service
                .List();
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/money_management/received_debits");
        }

        [Fact]
        public void TestV2MoneyManagementReceivedDebitGet2()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/money_management/received_debits/id_123",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.money_management.received_debit\",\"amount\":{\"currency\":\"USD\",\"value\":96},\"bank_transfer\":null,\"card_spend\":null,\"created\":\"1970-01-12T21:42:34.472Z\",\"description\":null,\"financial_account\":\"financial_account\",\"livemode\":true,\"receipt_url\":null,\"status\":\"canceled\",\"status_details\":null,\"status_transitions\":null,\"type\":\"bank_transfer\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.ReceivedDebits;
            Stripe.V2.MoneyManagement.ReceivedDebit receivedDebit = service.Get(
                "id_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/money_management/received_debits/id_123");
        }

        [Fact]
        public void TestV2MoneyManagementTransactionGet()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/money_management/transactions",
                (HttpStatusCode)200,
                "{\"data\":[{\"id\":\"obj_123\",\"object\":\"v2.money_management.transaction\",\"amount\":{\"currency\":\"USD\",\"value\":96},\"balance_impact\":{\"available\":{\"currency\":\"USD\",\"value\":35},\"inbound_pending\":{\"currency\":\"USD\",\"value\":11},\"outbound_pending\":{\"currency\":\"USD\",\"value\":60}},\"category\":\"return\",\"created\":\"1970-01-12T21:42:34.472Z\",\"financial_account\":\"financial_account\",\"flow\":{\"type\":\"outbound_payment\",\"adjustment\":null,\"fee_transaction\":null,\"inbound_transfer\":null,\"outbound_payment\":null,\"outbound_transfer\":null,\"received_credit\":null,\"received_debit\":null},\"livemode\":true,\"status\":\"pending\",\"status_transitions\":{\"posted_at\":null,\"void_at\":null}}],\"next_page_url\":null,\"previous_page_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.Transactions;
            Stripe.V2.StripeList<Stripe.V2.MoneyManagement.Transaction> transactions = service
                .List();
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/money_management/transactions");
        }

        [Fact]
        public void TestV2MoneyManagementTransactionGet2()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/money_management/transactions/id_123",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.money_management.transaction\",\"amount\":{\"currency\":\"USD\",\"value\":96},\"balance_impact\":{\"available\":{\"currency\":\"USD\",\"value\":35},\"inbound_pending\":{\"currency\":\"USD\",\"value\":11},\"outbound_pending\":{\"currency\":\"USD\",\"value\":60}},\"category\":\"return\",\"created\":\"1970-01-12T21:42:34.472Z\",\"financial_account\":\"financial_account\",\"flow\":{\"type\":\"outbound_payment\",\"adjustment\":null,\"fee_transaction\":null,\"inbound_transfer\":null,\"outbound_payment\":null,\"outbound_transfer\":null,\"received_credit\":null,\"received_debit\":null},\"livemode\":true,\"status\":\"pending\",\"status_transitions\":{\"posted_at\":null,\"void_at\":null}}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.Transactions;
            Stripe.V2.MoneyManagement.Transaction transaction = service.Get(
                "id_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/money_management/transactions/id_123");
        }

        [Fact]
        public void TestV2MoneyManagementTransactionEntryGet()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/money_management/transaction_entries",
                (HttpStatusCode)200,
                "{\"data\":[{\"id\":\"obj_123\",\"object\":\"v2.money_management.transaction_entry\",\"balance_impact\":{\"available\":{\"currency\":\"USD\",\"value\":35},\"inbound_pending\":{\"currency\":\"USD\",\"value\":11},\"outbound_pending\":{\"currency\":\"USD\",\"value\":60}},\"created\":\"1970-01-12T21:42:34.472Z\",\"effective_at\":\"1970-01-03T20:38:28.043Z\",\"livemode\":true,\"transaction\":\"transaction\",\"transaction_details\":{\"category\":\"return\",\"financial_account\":\"financial_account\",\"flow\":{\"type\":\"outbound_payment\",\"adjustment\":null,\"fee_transaction\":null,\"inbound_transfer\":null,\"outbound_payment\":null,\"outbound_transfer\":null,\"received_credit\":null,\"received_debit\":null}}}],\"next_page_url\":null,\"previous_page_url\":null}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.TransactionEntries;
            Stripe.V2.StripeList<Stripe.V2.MoneyManagement.TransactionEntry> transactionEntries = service
                .List();
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/money_management/transaction_entries");
        }

        [Fact]
        public void TestV2MoneyManagementTransactionEntryGet2()
        {
            this.StubRequest(
                HttpMethod.Get,
                "/v2/money_management/transaction_entries/id_123",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.money_management.transaction_entry\",\"balance_impact\":{\"available\":{\"currency\":\"USD\",\"value\":35},\"inbound_pending\":{\"currency\":\"USD\",\"value\":11},\"outbound_pending\":{\"currency\":\"USD\",\"value\":60}},\"created\":\"1970-01-12T21:42:34.472Z\",\"effective_at\":\"1970-01-03T20:38:28.043Z\",\"livemode\":true,\"transaction\":\"transaction\",\"transaction_details\":{\"category\":\"return\",\"financial_account\":\"financial_account\",\"flow\":{\"type\":\"outbound_payment\",\"adjustment\":null,\"fee_transaction\":null,\"inbound_transfer\":null,\"outbound_payment\":null,\"outbound_transfer\":null,\"received_credit\":null,\"received_debit\":null}}}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.TransactionEntries;
            Stripe.V2.MoneyManagement.TransactionEntry transactionEntry = service
                .Get("id_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v2/money_management/transaction_entries/id_123");
        }

        [Fact]
        public void TestV2BillingMeterEventSessionPost()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/billing/meter_event_session",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.billing.meter_event_session\",\"authentication_token\":\"authentication_token\",\"created\":\"1970-01-12T21:42:34.472Z\",\"expires_at\":\"1970-01-10T15:36:51.170Z\",\"livemode\":true}");
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
        public void TestV2BillingMeterEventAdjustmentPost()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/billing/meter_event_adjustments",
                (HttpStatusCode)200,
                "{\"id\":\"obj_123\",\"object\":\"v2.billing.meter_event_adjustment\",\"cancel\":{\"identifier\":\"identifier\"},\"created\":\"1970-01-12T21:42:34.472Z\",\"event_name\":\"event_name\",\"livemode\":true,\"status\":\"complete\",\"type\":\"cancel\"}");
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
                            { "undefined", "payload" },
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
        public void TestV2BillingMeterEventPost()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/billing/meter_events",
                (HttpStatusCode)200,
                "{\"object\":\"v2.billing.meter_event\",\"created\":\"1970-01-12T21:42:34.472Z\",\"event_name\":\"event_name\",\"identifier\":\"identifier\",\"livemode\":true,\"payload\":{\"undefined\":\"payload\"},\"timestamp\":\"1970-01-01T15:18:46.294Z\"}");
            var options = new Stripe.V2.Billing.MeterEventCreateOptions
            {
                EventName = "event_name",
                Payload = new Dictionary<string, string>
                {
                    { "undefined", "payload" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Billing.MeterEvents;
            Stripe.V2.Billing.MeterEvent meterEvent = service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v2/billing/meter_events");
        }

        [Fact]
        public void TestV2TestHelpersFinancialAddressPost()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/test_helpers/financial_addresses/id_123/credit",
                (HttpStatusCode)200,
                "{\"object\":\"financial_address_credit_simulation\",\"livemode\":true,\"status\":\"status\"}");
            var options = new Stripe.V2.TestHelpers.FinancialAddressCreditOptions
            {
                Amount = new Stripe.V2.Amount { Currency = "USD", Value = 96 },
                Network = "rtp",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V2.TestHelpers.FinancialAddresses;
            Stripe.V2.FinancialAddressCreditSimulation financialAddressCreditSimulation = service
                .Credit("id_123", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/test_helpers/financial_addresses/id_123/credit");
        }

        [Fact]
        public void TestV2TestHelpersFinancialAddressPost2()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/test_helpers/financial_addresses/id_123/generate_microdeposits",
                (HttpStatusCode)200,
                "{\"object\":\"financial_address_generated_microdeposits\",\"amounts\":[{\"currency\":\"USD\",\"value\":1}],\"livemode\":true,\"status\":\"accepted\"}");
            var client = new StripeClient(this.Requestor);
            var service = client.V2.TestHelpers.FinancialAddresses;
            Stripe.V2.FinancialAddressGeneratedMicrodeposits financialAddressGeneratedMicrodeposits = service
                .GenerateMicrodeposits("id_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/test_helpers/financial_addresses/id_123/generate_microdeposits");
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
                            { "undefined", "payload" },
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
        public void TestFinancialAccountNotOpenError()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/money_management/financial_addresses",
                (HttpStatusCode)400,
                "{\"error\":{\"type\":\"financial_account_not_open\",\"code\":\"financial_account_not_in_open_status\"}}");
            var exception = Assert.Throws<Stripe.V2.FinancialAccountNotOpenException>(
            () =>
            {
            var options = new Stripe.V2.MoneyManagement.FinancialAddressCreateOptions
            {
                Currency = "stn",
                FinancialAccount = "financial_account",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.FinancialAddresses;
            Stripe.V2.MoneyManagement.FinancialAddress financialAddress = service
                .Create(options);
            });
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/money_management/financial_addresses");
        }

        [Fact]
        public void TestBlockedByStripeError()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/vault/us_bank_accounts",
                (HttpStatusCode)400,
                "{\"error\":{\"type\":\"blocked_by_stripe\",\"code\":\"inbound_transfer_not_allowed\"}}");
            var exception = Assert.Throws<Stripe.V2.BlockedByStripeException>(
            () =>
            {
            var options = new Stripe.V2.Core.Vault.UsBankAccountCreateOptions
            {
                AccountNumber = "account_number",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Vault.UsBankAccounts;
            Stripe.V2.Core.Vault.UsBankAccount usBankAccount = service.Create(
                options);
            });
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/core/vault/us_bank_accounts");
        }

        [Fact]
        public void TestAlreadyCanceledError()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/money_management/outbound_payments/id_123/cancel",
                (HttpStatusCode)400,
                "{\"error\":{\"type\":\"already_canceled\",\"code\":\"outbound_payment_already_canceled\"}}");
            var exception = Assert.Throws<Stripe.V2.AlreadyCanceledException>(
            () =>
            {
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.OutboundPayments;
            Stripe.V2.MoneyManagement.OutboundPayment outboundPayment = service
                .Cancel("id_123");
            });
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/money_management/outbound_payments/id_123/cancel");
        }

        [Fact]
        public void TestNotCancelableError()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/money_management/outbound_payments/id_123/cancel",
                (HttpStatusCode)400,
                "{\"error\":{\"type\":\"not_cancelable\",\"code\":\"outbound_payment_not_cancelable\"}}");
            var exception = Assert.Throws<Stripe.V2.NotCancelableException>(
            () =>
            {
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.OutboundPayments;
            Stripe.V2.MoneyManagement.OutboundPayment outboundPayment = service
                .Cancel("id_123");
            });
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/money_management/outbound_payments/id_123/cancel");
        }

        [Fact]
        public void TestInsufficientFundsError()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/money_management/outbound_payments",
                (HttpStatusCode)400,
                "{\"error\":{\"type\":\"insufficient_funds\",\"code\":\"outbound_payment_insufficient_funds\"}}");
            var exception = Assert.Throws<Stripe.V2.InsufficientFundsException>(
            () =>
            {
            var options = new Stripe.V2.MoneyManagement.OutboundPaymentCreateOptions
            {
                Amount = new Stripe.V2.Amount { Currency = "USD", Value = 96 },
                From = new Stripe.V2.MoneyManagement.OutboundPaymentCreateFromOptions
                {
                    Currency = "currency",
                    FinancialAccount = "financial_account",
                },
                To = new Stripe.V2.MoneyManagement.OutboundPaymentCreateToOptions
                {
                    Recipient = "recipient",
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.OutboundPayments;
            Stripe.V2.MoneyManagement.OutboundPayment outboundPayment = service
                .Create(options);
            });
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/money_management/outbound_payments");
        }

        [Fact]
        public void TestQuotaExceededError()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/vault/us_bank_accounts",
                (HttpStatusCode)400,
                "{\"error\":{\"type\":\"quota_exceeded\",\"code\":\"outbound_payment_recipient_amount_limit_exceeded\"}}");
            var exception = Assert.Throws<Stripe.V2.QuotaExceededException>(
            () =>
            {
            var options = new Stripe.V2.Core.Vault.UsBankAccountCreateOptions
            {
                AccountNumber = "account_number",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Vault.UsBankAccounts;
            Stripe.V2.Core.Vault.UsBankAccount usBankAccount = service.Create(
                options);
            });
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/core/vault/us_bank_accounts");
        }

        [Fact]
        public void TestRecipientNotNotifiableError()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/money_management/outbound_payments",
                (HttpStatusCode)400,
                "{\"error\":{\"type\":\"recipient_not_notifiable\",\"code\":\"outbound_payment_recipient_email_does_not_exist\"}}");
            var exception = Assert.Throws<Stripe.V2.RecipientNotNotifiableException>(
            () =>
            {
            var options = new Stripe.V2.MoneyManagement.OutboundPaymentCreateOptions
            {
                Amount = new Stripe.V2.Amount { Currency = "USD", Value = 96 },
                From = new Stripe.V2.MoneyManagement.OutboundPaymentCreateFromOptions
                {
                    Currency = "currency",
                    FinancialAccount = "financial_account",
                },
                To = new Stripe.V2.MoneyManagement.OutboundPaymentCreateToOptions
                {
                    Recipient = "recipient",
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.OutboundPayments;
            Stripe.V2.MoneyManagement.OutboundPayment outboundPayment = service
                .Create(options);
            });
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/money_management/outbound_payments");
        }

        [Fact]
        public void TestFeatureNotEnabledError()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/money_management/outbound_payments",
                (HttpStatusCode)400,
                "{\"error\":{\"type\":\"feature_not_enabled\",\"code\":\"outbound_payment_recipient_feature_not_active\"}}");
            var exception = Assert.Throws<Stripe.V2.FeatureNotEnabledException>(
            () =>
            {
            var options = new Stripe.V2.MoneyManagement.OutboundPaymentCreateOptions
            {
                Amount = new Stripe.V2.Amount { Currency = "USD", Value = 96 },
                From = new Stripe.V2.MoneyManagement.OutboundPaymentCreateFromOptions
                {
                    Currency = "currency",
                    FinancialAccount = "financial_account",
                },
                To = new Stripe.V2.MoneyManagement.OutboundPaymentCreateToOptions
                {
                    Recipient = "recipient",
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.OutboundPayments;
            Stripe.V2.MoneyManagement.OutboundPayment outboundPayment = service
                .Create(options);
            });
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/money_management/outbound_payments");
        }

        [Fact]
        public void TestInvalidPayoutMethodError()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/money_management/outbound_setup_intents",
                (HttpStatusCode)400,
                "{\"error\":{\"type\":\"invalid_payout_method\",\"code\":\"invalid_payout_method\"}}");
            var exception = Assert.Throws<Stripe.V2.InvalidPayoutMethodException>(
            () =>
            {
            var options = new Stripe.V2.MoneyManagement.OutboundSetupIntentCreateOptions();
            var client = new StripeClient(this.Requestor);
            var service = client.V2.MoneyManagement.OutboundSetupIntents;
            Stripe.V2.MoneyManagement.OutboundSetupIntent outboundSetupIntent = service
                .Create(options);
            });
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/money_management/outbound_setup_intents");
        }

        [Fact]
        public void TestControlledByDashboardError()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/vault/us_bank_accounts/id_123/archive",
                (HttpStatusCode)400,
                "{\"error\":{\"type\":\"controlled_by_dashboard\",\"code\":\"bank_account_cannot_be_archived\"}}");
            var exception = Assert.Throws<Stripe.V2.ControlledByDashboardException>(
            () =>
            {
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Vault.UsBankAccounts;
            Stripe.V2.Core.Vault.UsBankAccount usBankAccount = service.Archive(
                "id_123");
            });
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/core/vault/us_bank_accounts/id_123/archive");
        }

        [Fact]
        public void TestInvalidPaymentMethodError()
        {
            this.StubRequest(
                HttpMethod.Post,
                "/v2/core/vault/us_bank_accounts",
                (HttpStatusCode)400,
                "{\"error\":{\"type\":\"invalid_payment_method\",\"code\":\"invalid_us_bank_account\"}}");
            var exception = Assert.Throws<Stripe.V2.InvalidPaymentMethodException>(
            () =>
            {
            var options = new Stripe.V2.Core.Vault.UsBankAccountCreateOptions
            {
                AccountNumber = "account_number",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V2.Core.Vault.UsBankAccounts;
            Stripe.V2.Core.Vault.UsBankAccount usBankAccount = service.Create(
                options);
            });
            this.AssertRequest(
                HttpMethod.Post,
                "/v2/core/vault/us_bank_accounts");
        }
    }
}
