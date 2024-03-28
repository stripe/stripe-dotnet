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
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/account_links");
        }

        [Fact]
        public void TestAccountsCapabilitiesGet()
        {
            var service = new CapabilityService(this.StripeClient);
            StripeList<Capability> capabilities = service.List(
                "acct_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/accounts/acct_xxxxxxxxxxxxx/capabilities");
        }

        [Fact]
        public void TestAccountsCapabilitiesGet2()
        {
            var service = new CapabilityService(this.StripeClient);
            service.Get("acct_xxxxxxxxxxxxx", "card_payments");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/accounts/acct_xxxxxxxxxxxxx/capabilities/card_payments");
        }

        [Fact]
        public void TestAccountsCapabilitiesPost()
        {
            var options = new CapabilityUpdateOptions { Requested = true };
            var service = new CapabilityService(this.StripeClient);
            service.Update("acct_xxxxxxxxxxxxx", "card_payments", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/accounts/acct_xxxxxxxxxxxxx/capabilities/card_payments");
        }

        [Fact]
        public void TestAccountsDelete()
        {
            var service = new AccountService(this.StripeClient);
            service.Delete("acct_xxxxxxxxxxxxx");
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
            service.Get("acct_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/accounts/acct_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestAccountsLoginLinksPost()
        {
            var service = new LoginLinkService(this.StripeClient);
            service.Create("acct_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/accounts/acct_xxxxxxxxxxxxx/login_links");
        }

        [Fact]
        public void TestAccountsPersonsDelete()
        {
            var service = new PersonService(this.StripeClient);
            service.Delete("acct_xxxxxxxxxxxxx", "person_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/accounts/acct_xxxxxxxxxxxxx/persons/person_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestAccountsPersonsGet()
        {
            var options = new PersonListOptions { Limit = 3 };
            var service = new PersonService(this.StripeClient);
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
            var service = new PersonService(this.StripeClient);
            service.Get("acct_xxxxxxxxxxxxx", "person_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/accounts/acct_xxxxxxxxxxxxx/persons/person_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestAccountsPersonsPost()
        {
            var options = new PersonCreateOptions
            {
                FirstName = "Jane",
                LastName = "Diaz",
            };
            var service = new PersonService(this.StripeClient);
            service.Create("acct_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/accounts/acct_xxxxxxxxxxxxx/persons");
        }

        [Fact]
        public void TestAccountsPersonsPost2()
        {
            var options = new PersonUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new PersonService(this.StripeClient);
            service.Update(
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
            service.Create(options);
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
            service.Update("acct_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/accounts/acct_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestAccountsRejectPost()
        {
            var options = new AccountRejectOptions { Reason = "fraud" };
            var service = new AccountService(this.StripeClient);
            service.Reject("acct_xxxxxxxxxxxxx", options);
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
            service.Get("fee_xxxxxxxxxxxxx");
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
            service.Get("fee_xxxxxxxxxxxxx", "fr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/application_fees/fee_xxxxxxxxxxxxx/refunds/fr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestApplicationFeesRefundsPost()
        {
            var service = new ApplicationFeeRefundService(this.StripeClient);
            service.Create("fee_xxxxxxxxxxxxx");
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
            service.Update("fee_xxxxxxxxxxxxx", "fr_xxxxxxxxxxxxx", options);
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
            service.DeleteWhere(options);
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
            service.Find(options);
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
            service.Create(options);
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
            service.Create(options);
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
            service.Get("txn_xxxxxxxxxxxxx");
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
            service.Get("bpc_xxxxxxxxxxxxx");
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
            service.Create(options);
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
            service.Update("bpc_xxxxxxxxxxxxx", options);
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
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/billing_portal/sessions");
        }

        [Fact]
        public void TestChargesCapturePost()
        {
            var service = new ChargeService(this.StripeClient);
            service.Capture("ch_xxxxxxxxxxxxx");
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
            service.Get("ch_xxxxxxxxxxxxx");
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
            service.Create(options);
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
            service.Update("ch_xxxxxxxxxxxxx", options);
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
            service.Search(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/charges/search",
                "query=amount%3E999%20AND%20metadata%5B%27order_id%27%5D%3A%276735%27");
        }

        [Fact]
        public void TestCheckoutSessionsExpirePost()
        {
            var service = new Stripe.Checkout.SessionService(this.StripeClient);
            service.Expire("sess_xyz");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/checkout/sessions/sess_xyz/expire");
        }

        [Fact]
        public void TestCheckoutSessionsExpirePost2()
        {
            var service = new Stripe.Checkout.SessionService(this.StripeClient);
            service.Expire("cs_test_xxxxxxxxxxxxx");
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
            service.Get("cs_test_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/checkout/sessions/cs_test_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestCheckoutSessionsLineItemsGet()
        {
            var service = new Stripe.Checkout.SessionService(this.StripeClient);
            StripeList<LineItem> lineItems = service.ListLineItems("sess_xyz");
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
            service.Create(options);
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
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/checkout/sessions");
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
            service.Get("US");
            this.AssertRequest(HttpMethod.Get, "/v1/country_specs/US");
        }

        [Fact]
        public void TestCouponsDelete()
        {
            var service = new CouponService(this.StripeClient);
            service.Delete("Z4OV52SU");
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
            service.Get("Z4OV52SU");
            this.AssertRequest(HttpMethod.Get, "/v1/coupons/Z4OV52SU");
        }

        [Fact]
        public void TestCouponsPost()
        {
            var options = new CouponCreateOptions
            {
                PercentOff = 25.5M,
                Duration = "repeating",
                DurationInMonths = 3,
            };
            var service = new CouponService(this.StripeClient);
            service.Create(options);
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
            service.Update("Z4OV52SU", options);
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
            service.Create(options);
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
            service.Preview(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/credit_notes/preview",
                "invoice=in_xxxxxxxxxxxxx&lines[0][type]=invoice_line_item&lines[0][invoice_line_item]=il_xxxxxxxxxxxxx&lines[0][quantity]=1");
        }

        [Fact]
        public void TestCreditNotesVoidPost()
        {
            var service = new CreditNoteService(this.StripeClient);
            service.VoidCreditNote("cn_xxxxxxxxxxxxx");
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
            service.Create(options);
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
            service.Get("cus_xxxxxxxxxxxxx", "cbtxn_xxxxxxxxxxxxx");
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
            service.Create("cus_xxxxxxxxxxxxx", options);
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
            service.Update("cus_xxxxxxxxxxxxx", "cbtxn_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/customers/cus_xxxxxxxxxxxxx/balance_transactions/cbtxn_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestCustomersCashBalanceGet()
        {
            var service = new CashBalanceService(this.StripeClient);
            service.Get("cus_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_123/cash_balance");
        }

        [Fact]
        public void TestCustomersCashBalancePost()
        {
            var options = new CashBalanceUpdateOptions
            {
                Settings = new CashBalanceSettingsOptions
                {
                    ReconciliationMode = "manual",
                },
            };
            var service = new CashBalanceService(this.StripeClient);
            service.Update("cus_123", options);
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
            service.Delete("cus_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/customers/cus_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestCustomersFundingInstructionsPost()
        {
            var options = new CustomerCreateFundingInstructionsOptions
            {
                BankTransfer = new CustomerBankTransferOptions
                {
                    RequestedAddressTypes = new List<string> { "zengin" },
                    Type = "jp_bank_transfer",
                },
                Currency = "usd",
                FundingType = "bank_transfer",
            };
            var service = new CustomerService(this.StripeClient);
            service.CreateFundingInstructions("cus_123", options);
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
            service.Get("cus_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestCustomersPaymentMethodsGet()
        {
            var options = new CustomerListPaymentMethodsOptions
            {
                Type = "card",
            };
            var service = new CustomerService(this.StripeClient);
            StripeList<PaymentMethod> paymentMethods = service
                .ListPaymentMethods("cus_xyz", options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_xyz/payment_methods",
                "type=card");
        }

        [Fact]
        public void TestCustomersPaymentMethodsGet2()
        {
            var options = new CustomerListPaymentMethodsOptions
            {
                Type = "card",
            };
            var service = new CustomerService(this.StripeClient);
            StripeList<PaymentMethod> paymentMethods = service
                .ListPaymentMethods("cus_xxxxxxxxxxxxx", options);
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
            service.Create(options);
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
            service.Update("cus_xxxxxxxxxxxxx", options);
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
            service.Search(options);
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
            service.Search(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/search",
                "query=name%3A%27fakename%27%20AND%20metadata%5B%27foo%27%5D%3A%27bar%27");
        }

        [Fact]
        public void TestCustomersTaxIdsDelete()
        {
            var service = new TaxIdService(this.StripeClient);
            service.Delete("cus_xxxxxxxxxxxxx", "txi_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/customers/cus_xxxxxxxxxxxxx/tax_ids/txi_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestCustomersTaxIdsGet()
        {
            var options = new TaxIdListOptions { Limit = 3 };
            var service = new TaxIdService(this.StripeClient);
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
            var service = new TaxIdService(this.StripeClient);
            service.Get("cus_xxxxxxxxxxxxx", "txi_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_xxxxxxxxxxxxx/tax_ids/txi_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestCustomersTaxIdsPost()
        {
            var options = new TaxIdCreateOptions
            {
                Type = "eu_vat",
                Value = "DE123456789",
            };
            var service = new TaxIdService(this.StripeClient);
            service.Create("cus_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/customers/cus_xxxxxxxxxxxxx/tax_ids");
        }

        [Fact]
        public void TestDisputesClosePost()
        {
            var service = new DisputeService(this.StripeClient);
            service.Close("dp_xxxxxxxxxxxxx");
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
            service.Get("dp_xxxxxxxxxxxxx");
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
            service.Update("dp_xxxxxxxxxxxxx", options);
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
            service.Get("evt_xxxxxxxxxxxxx");
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
            service.Get("link_xxxxxxxxxxxxx");
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
            service.Create(options);
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
            service.Update("link_xxxxxxxxxxxxx", options);
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
            service.Get("file_xxxxxxxxxxxxx");
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
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/files");
        }

        [Fact]
        public void TestFinancialConnectionsAccountsDisconnectPost()
        {
            var service = new Stripe.FinancialConnections.AccountService(
                this.StripeClient);
            service.Disconnect("fca_xyz");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/financial_connections/accounts/fca_xyz/disconnect");
        }

        [Fact]
        public void TestFinancialConnectionsAccountsDisconnectPost2()
        {
            var service = new Stripe.FinancialConnections.AccountService(
                this.StripeClient);
            service.Disconnect("fca_xxxxxxxxxxxxx");
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
            service.Get("fca_xyz");
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
            service.Get("fca_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/accounts/fca_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestFinancialConnectionsAccountsOwnersGet()
        {
            var options = new Stripe.FinancialConnections.AccountListOwnersOptions
            {
                Ownership = "fcaowns_xyz",
            };
            var service = new Stripe.FinancialConnections.AccountService(
                this.StripeClient);
            StripeList<Stripe.FinancialConnections.AccountOwner> accountOwners = service
                .ListOwners("fca_xyz", options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/accounts/fca_xyz/owners",
                "ownership=fcaowns_xyz");
        }

        [Fact]
        public void TestFinancialConnectionsAccountsOwnersGet2()
        {
            var options = new Stripe.FinancialConnections.AccountListOwnersOptions
            {
                Limit = 3,
                Ownership = "fcaowns_xxxxxxxxxxxxx",
            };
            var service = new Stripe.FinancialConnections.AccountService(
                this.StripeClient);
            StripeList<Stripe.FinancialConnections.AccountOwner> accountOwners = service
                .ListOwners("fca_xxxxxxxxxxxxx", options);
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
            service.Refresh("fca_xyz", options);
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
            service.Subscribe("fa_123", options);
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
            service.Unsubscribe("fa_123", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/financial_connections/accounts/fa_123/unsubscribe");
        }

        [Fact]
        public void TestFinancialConnectionsSessionsGet()
        {
            var service = new Stripe.FinancialConnections.SessionService(
                this.StripeClient);
            service.Get("fcsess_xyz");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/sessions/fcsess_xyz");
        }

        [Fact]
        public void TestFinancialConnectionsSessionsGet2()
        {
            var service = new Stripe.FinancialConnections.SessionService(
                this.StripeClient);
            service.Get("fcsess_xxxxxxxxxxxxx");
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
            service.Create(options);
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
            service.Create(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/financial_connections/sessions");
        }

        [Fact]
        public void TestFinancialConnectionsTransactionsGet()
        {
            var service = new Stripe.FinancialConnections.TransactionService(
                this.StripeClient);
            service.Get("tr_123");
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
            service.Get("vr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/identity/verification_reports/vr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIdentityVerificationSessionsCancelPost()
        {
            var service = new Stripe.Identity.VerificationSessionService(
                this.StripeClient);
            service.Cancel("vs_xxxxxxxxxxxxx");
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
            service.Get("vs_xxxxxxxxxxxxx");
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
            service.Create(options);
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
            service.Update("vs_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/identity/verification_sessions/vs_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIdentityVerificationSessionsRedactPost()
        {
            var service = new Stripe.Identity.VerificationSessionService(
                this.StripeClient);
            service.Redact("vs_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/identity/verification_sessions/vs_xxxxxxxxxxxxx/redact");
        }

        [Fact]
        public void TestInvoiceitemsDelete()
        {
            var service = new InvoiceItemService(this.StripeClient);
            service.Delete("ii_xxxxxxxxxxxxx");
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
            service.Get("ii_xxxxxxxxxxxxx");
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
                Price = "price_xxxxxxxxxxxxx",
            };
            var service = new InvoiceItemService(this.StripeClient);
            service.Create(options);
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
            service.Update("ii_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/invoiceitems/ii_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestInvoicesDelete()
        {
            var service = new InvoiceService(this.StripeClient);
            service.Delete("in_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/invoices/in_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestInvoicesFinalizePost()
        {
            var service = new InvoiceService(this.StripeClient);
            service.FinalizeInvoice("in_xxxxxxxxxxxxx");
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
            service.Get("in_xxxxxxxxxxxxx");
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
            service.Get("in_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/invoices/in_xxxxxxxxxxxxx",
                "expand[]=customer");
        }

        [Fact]
        public void TestInvoicesMarkUncollectiblePost()
        {
            var service = new InvoiceService(this.StripeClient);
            service.MarkUncollectible("in_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/invoices/in_xxxxxxxxxxxxx/mark_uncollectible");
        }

        [Fact]
        public void TestInvoicesPayPost()
        {
            var service = new InvoiceService(this.StripeClient);
            service.Pay("in_xxxxxxxxxxxxx");
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
            service.Create(options);
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
            service.Update("in_xxxxxxxxxxxxx", options);
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
            service.Search(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/invoices/search",
                "query=total%3E999%20AND%20metadata%5B%27order_id%27%5D%3A%276735%27");
        }

        [Fact]
        public void TestInvoicesSendPost()
        {
            var service = new InvoiceService(this.StripeClient);
            service.SendInvoice("in_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/invoices/in_xxxxxxxxxxxxx/send");
        }

        [Fact]
        public void TestInvoicesUpcomingGet()
        {
            var options = new UpcomingInvoiceOptions
            {
                Customer = "cus_9utnxg47pWjV1e",
            };
            var service = new InvoiceService(this.StripeClient);
            service.Upcoming(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/invoices/upcoming",
                "customer=cus_9utnxg47pWjV1e");
        }

        [Fact]
        public void TestInvoicesVoidPost()
        {
            var service = new InvoiceService(this.StripeClient);
            service.VoidInvoice("in_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/invoices/in_xxxxxxxxxxxxx/void");
        }

        [Fact]
        public void TestIssuingAuthorizationsApprovePost()
        {
            var service = new Stripe.Issuing.AuthorizationService(
                this.StripeClient);
            service.Approve("iauth_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/issuing/authorizations/iauth_xxxxxxxxxxxxx/approve");
        }

        [Fact]
        public void TestIssuingAuthorizationsDeclinePost()
        {
            var service = new Stripe.Issuing.AuthorizationService(
                this.StripeClient);
            service.Decline("iauth_xxxxxxxxxxxxx");
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
            service.Get("iauth_xxxxxxxxxxxxx");
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
            service.Update("iauth_xxxxxxxxxxxxx", options);
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
            service.Get("ich_xxxxxxxxxxxxx");
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
            service.Create(options);
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
            service.Update("ich_xxxxxxxxxxxxx", options);
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
            service.Get("ic_xxxxxxxxxxxxx");
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
            service.Create(options);
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
            service.Update("ic_xxxxxxxxxxxxx", options);
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
            service.Get("idp_xxxxxxxxxxxxx");
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
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/issuing/disputes");
        }

        [Fact]
        public void TestIssuingDisputesSubmitPost()
        {
            var service = new Stripe.Issuing.DisputeService(this.StripeClient);
            service.Submit("idp_xxxxxxxxxxxxx");
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
            service.Get("pd_xyz");
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
            service.Create(options);
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
            service.Update("pd_xyz", options);
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
            service.Get("pb_xyz");
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
            service.Get("ipi_xxxxxxxxxxxxx");
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
            service.Update("ipi_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/issuing/transactions/ipi_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestMandatesGet()
        {
            var service = new MandateService(this.StripeClient);
            service.Get("mandate_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/mandates/mandate_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPaymentIntentsApplyCustomerBalancePost()
        {
            var service = new PaymentIntentService(this.StripeClient);
            service.ApplyCustomerBalance("pi_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_intents/pi_xxxxxxxxxxxxx/apply_customer_balance");
        }

        [Fact]
        public void TestPaymentIntentsCancelPost()
        {
            var service = new PaymentIntentService(this.StripeClient);
            service.Cancel("pi_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_intents/pi_xxxxxxxxxxxxx/cancel");
        }

        [Fact]
        public void TestPaymentIntentsCapturePost()
        {
            var service = new PaymentIntentService(this.StripeClient);
            service.Capture("pi_xxxxxxxxxxxxx");
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
            service.Confirm("pi_xxxxxxxxxxxxx", options);
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
            service.Get("pi_xxxxxxxxxxxxx");
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
            service.IncrementAuthorization("pi_xxxxxxxxxxxxx", options);
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
            service.Create(options);
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
            service.Create(options);
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
            service.Update("pi_xxxxxxxxxxxxx", options);
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
            service.Create(options);
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
            service.Search(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_intents/search",
                "query=status%3A%27succeeded%27%20AND%20metadata%5B%27order_id%27%5D%3A%276735%27");
        }

        [Fact]
        public void TestPaymentIntentsVerifyMicrodepositsPost()
        {
            var service = new PaymentIntentService(this.StripeClient);
            service.VerifyMicrodeposits("pi_xxxxxxxxxxxxx");
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
            service.VerifyMicrodeposits("pi_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_intents/pi_xxxxxxxxxxxxx/verify_microdeposits");
        }

        [Fact]
        public void TestPaymentLinksGet()
        {
            var service = new PaymentLinkService(this.StripeClient);
            service.Get("pl_xyz");
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
            service.Get("plink_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_links/plink_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPaymentLinksLineItemsGet()
        {
            var service = new PaymentLinkService(this.StripeClient);
            StripeList<LineItem> lineItems = service.ListLineItems("pl_xyz");
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
            service.Create(options);
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
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/payment_links");
        }

        [Fact]
        public void TestPaymentLinksPost3()
        {
            var options = new PaymentLinkUpdateOptions { Active = false };
            var service = new PaymentLinkService(this.StripeClient);
            service.Update("plink_xxxxxxxxxxxxx", options);
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
            service.Get("foo");
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
            service.Create(options);
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
            service.Update("foo", options);
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
            service.Attach("pm_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_methods/pm_xxxxxxxxxxxxx/attach");
        }

        [Fact]
        public void TestPaymentMethodsDetachPost()
        {
            var service = new PaymentMethodService(this.StripeClient);
            service.Detach("pm_xxxxxxxxxxxxx");
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
            service.Get("pm_xxxxxxxxxxxxx");
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
            service.Create(options);
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
            service.Update("pm_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_methods/pm_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPayoutsCancelPost()
        {
            var service = new PayoutService(this.StripeClient);
            service.Cancel("po_xxxxxxxxxxxxx");
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
            service.Get("po_xxxxxxxxxxxxx");
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
            service.Create(options);
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
            service.Update("po_xxxxxxxxxxxxx", options);
            this.AssertRequest(HttpMethod.Post, "/v1/payouts/po_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPayoutsReversePost()
        {
            var service = new PayoutService(this.StripeClient);
            service.Reverse("po_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payouts/po_xxxxxxxxxxxxx/reverse");
        }

        [Fact]
        public void TestPlansDelete()
        {
            var service = new PlanService(this.StripeClient);
            service.Delete("price_xxxxxxxxxxxxx");
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
            service.Get("price_xxxxxxxxxxxxx");
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
            service.Create(options);
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
            service.Create(options);
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
            service.Update("price_xxxxxxxxxxxxx", options);
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
            service.Get("price_xxxxxxxxxxxxx");
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
            service.Create(options);
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
            service.Create(options);
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
            service.Update("price_xxxxxxxxxxxxx", options);
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
            service.Search(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/prices/search",
                "query=active%3A%27true%27%20AND%20metadata%5B%27order_id%27%5D%3A%276735%27");
        }

        [Fact]
        public void TestProductsDelete()
        {
            var service = new ProductService(this.StripeClient);
            service.Delete("prod_xxxxxxxxxxxxx");
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
            service.Get("prod_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/products/prod_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestProductsPost()
        {
            var options = new ProductCreateOptions { Name = "Gold Special" };
            var service = new ProductService(this.StripeClient);
            service.Create(options);
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
            service.Update("prod_xxxxxxxxxxxxx", options);
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
            service.Search(options);
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
            service.Get("promo_xxxxxxxxxxxxx");
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
            service.Create(options);
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
            service.Update("promo_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/promotion_codes/promo_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestQuotesAcceptPost()
        {
            var service = new QuoteService(this.StripeClient);
            service.Accept("qt_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/quotes/qt_xxxxxxxxxxxxx/accept");
        }

        [Fact]
        public void TestQuotesCancelPost()
        {
            var service = new QuoteService(this.StripeClient);
            service.Cancel("qt_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/quotes/qt_xxxxxxxxxxxxx/cancel");
        }

        [Fact]
        public void TestQuotesFinalizePost()
        {
            var service = new QuoteService(this.StripeClient);
            service.FinalizeQuote("qt_xxxxxxxxxxxxx");
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
            service.Get("qt_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/quotes/qt_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestQuotesLineItemsGet()
        {
            var service = new QuoteService(this.StripeClient);
            StripeList<LineItem> lineItems = service.ListLineItems(
                "qt_xxxxxxxxxxxxx");
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
            service.Create(options);
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
            service.Update("qt_xxxxxxxxxxxxx", options);
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
        public void TestRadarEarlyFraudWarningsGet2()
        {
            var service = new Stripe.Radar.EarlyFraudWarningService(
                this.StripeClient);
            service.Get("issfr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/radar/early_fraud_warnings/issfr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestRadarValueListItemsDelete()
        {
            var service = new Stripe.Radar.ValueListItemService(
                this.StripeClient);
            service.Delete("rsli_xxxxxxxxxxxxx");
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
            service.Get("rsli_xxxxxxxxxxxxx");
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
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/radar/value_list_items");
        }

        [Fact]
        public void TestRadarValueListsDelete()
        {
            var service = new Stripe.Radar.ValueListService(this.StripeClient);
            service.Delete("rsl_xxxxxxxxxxxxx");
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
            service.Get("rsl_xxxxxxxxxxxxx");
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
            service.Create(options);
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
            service.Update("rsl_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/radar/value_lists/rsl_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestRefundsCancelPost()
        {
            var service = new RefundService(this.StripeClient);
            service.Cancel("re_xxxxxxxxxxxxx");
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
            service.Get("re_xxxxxxxxxxxxx");
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
            service.Create(options);
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
            service.Update("re_xxxxxxxxxxxxx", options);
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
            service.Get("frr_xxxxxxxxxxxxx");
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
            service.Create(options);
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
            service.Get("balance.summary.1");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/reporting/report_types/balance.summary.1");
        }

        [Fact]
        public void TestReviewsApprovePost()
        {
            var service = new ReviewService(this.StripeClient);
            service.Approve("prv_xxxxxxxxxxxxx");
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
            service.Get("prv_xxxxxxxxxxxxx");
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
            service.Cancel("seti_xxxxxxxxxxxxx");
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
            service.Confirm("seti_xxxxxxxxxxxxx", options);
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
            service.Get("seti_xxxxxxxxxxxxx");
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
            service.Create(options);
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
            service.Update("seti_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/setup_intents/seti_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSetupIntentsVerifyMicrodepositsPost()
        {
            var service = new SetupIntentService(this.StripeClient);
            service.VerifyMicrodeposits("seti_xxxxxxxxxxxxx");
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
            service.VerifyMicrodeposits("seti_xxxxxxxxxxxxx", options);
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
            service.Get("shr_xxxxxxxxxxxxx");
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
            service.Create(options);
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
            service.Create(options);
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
            service.Update("shr_xxxxxxxxxxxxx", options);
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
            service.Get("sqr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/sigma/scheduled_query_runs/sqr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSourcesGet()
        {
            var service = new SourceService(this.StripeClient);
            service.Get("src_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/sources/src_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSourcesGet2()
        {
            var service = new SourceService(this.StripeClient);
            service.Get("src_xxxxxxxxxxxxx");
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
            service.Update("src_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/sources/src_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSubscriptionItemsDelete()
        {
            var service = new SubscriptionItemService(this.StripeClient);
            service.Delete("si_xxxxxxxxxxxxx");
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
            service.Get("si_xxxxxxxxxxxxx");
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
            service.Create(options);
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
            service.Update("si_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/subscription_items/si_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSubscriptionItemsUsageRecordSummariesGet()
        {
            var options = new UsageRecordSummaryListOptions { Limit = 3 };
            var service = new UsageRecordSummaryService(this.StripeClient);
            StripeList<UsageRecordSummary> usageRecordSummaries = service.List(
                "si_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/subscription_items/si_xxxxxxxxxxxxx/usage_record_summaries",
                "limit=3");
        }

        [Fact]
        public void TestSubscriptionItemsUsageRecordsPost()
        {
            var options = new UsageRecordCreateOptions
            {
                Quantity = 100,
                Timestamp = DateTimeOffset.FromUnixTimeSeconds(1571252444)
                    .UtcDateTime,
            };
            var service = new UsageRecordService(this.StripeClient);
            service.Create("si_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/subscription_items/si_xxxxxxxxxxxxx/usage_records");
        }

        [Fact]
        public void TestSubscriptionSchedulesCancelPost()
        {
            var service = new SubscriptionScheduleService(this.StripeClient);
            service.Cancel("sub_sched_xxxxxxxxxxxxx");
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
            service.Get("sub_sched_xxxxxxxxxxxxx");
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
            service.Create(options);
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
            service.Update("sub_sched_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/subscription_schedules/sub_sched_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSubscriptionSchedulesReleasePost()
        {
            var service = new SubscriptionScheduleService(this.StripeClient);
            service.Release("sub_sched_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/subscription_schedules/sub_sched_xxxxxxxxxxxxx/release");
        }

        [Fact]
        public void TestSubscriptionsDelete()
        {
            var service = new SubscriptionService(this.StripeClient);
            service.Cancel("sub_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/subscriptions/sub_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSubscriptionsDiscountDelete()
        {
            var service = new DiscountService(this.StripeClient);
            service.DeleteSubscriptionDiscount("sub_xyz");
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
            service.Get("sub_xxxxxxxxxxxxx");
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
            service.Create(options);
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
            service.Update("sub_xxxxxxxxxxxxx", options);
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
            service.Search(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/subscriptions/search",
                "query=status%3A%27active%27%20AND%20metadata%5B%27order_id%27%5D%3A%276735%27");
        }

        [Fact]
        public void TestTaxCalculationsLineItemsGet()
        {
            var service = new Stripe.Tax.CalculationService(this.StripeClient);
            StripeList<Stripe.Tax.CalculationLineItem> calculationLineItems = service
                .ListLineItems("xxx");
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
            service.Create(options);
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
            service.Get("txcd_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/tax_codes/txcd_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTaxIdsDelete()
        {
            var service = new TaxIdService(this.StripeClient);
            service.Delete("taxid_123");
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
            service.Get("taxid_123");
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
            service.Create(options);
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
            service.Get("txr_xxxxxxxxxxxxx");
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
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/tax_rates");
        }

        [Fact]
        public void TestTaxRatesPost2()
        {
            var options = new TaxRateUpdateOptions { Active = false };
            var service = new TaxRateService(this.StripeClient);
            service.Update("txr_xxxxxxxxxxxxx", options);
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
            service.Create(options);
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
            service.Update("taxreg_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/tax/registrations/taxreg_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTaxSettingsGet()
        {
            var options = new Stripe.Tax.SettingsGetOptions();
            var service = new Stripe.Tax.SettingsService(this.StripeClient);
            service.Get(options);
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
            service.Update(options);
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
            service.CreateFromCalculation(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/tax/transactions/create_from_calculation");
        }

        [Fact]
        public void TestTerminalConfigurationsDelete()
        {
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            service.Delete("uc_123");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/terminal/configurations/uc_123");
        }

        [Fact]
        public void TestTerminalConfigurationsDelete2()
        {
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            service.Delete("tmc_xxxxxxxxxxxxx");
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
            service.Get("uc_123");
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
            service.Get("tmc_xxxxxxxxxxxxx");
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
            service.Create(options);
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
            service.Update("uc_123", options);
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
            service.Create(options);
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
            service.Update("tmc_xxxxxxxxxxxxx", options);
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
            service.Create(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/terminal/connection_tokens");
        }

        [Fact]
        public void TestTerminalLocationsDelete()
        {
            var service = new Stripe.Terminal.LocationService(
                this.StripeClient);
            service.Delete("tml_xxxxxxxxxxxxx");
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
            service.Get("tml_xxxxxxxxxxxxx");
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
            service.Create(options);
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
            service.Update("tml_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/terminal/locations/tml_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTerminalReadersCancelActionPost()
        {
            var service = new Stripe.Terminal.ReaderService(this.StripeClient);
            service.CancelAction("tmr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/terminal/readers/tmr_xxxxxxxxxxxxx/cancel_action");
        }

        [Fact]
        public void TestTerminalReadersDelete()
        {
            var service = new Stripe.Terminal.ReaderService(this.StripeClient);
            service.Delete("tmr_xxxxxxxxxxxxx");
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
            service.Get("tmr_xxxxxxxxxxxxx");
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
            service.Create(options);
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
            service.Update("tmr_xxxxxxxxxxxxx", options);
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
            service.ProcessPaymentIntent("tmr_xxxxxxxxxxxxx", options);
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
                CustomerConsentCollected = true,
            };
            var service = new Stripe.Terminal.ReaderService(this.StripeClient);
            service.ProcessSetupIntent("tmr_xxxxxxxxxxxxx", options);
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
            service.FundCashBalance("cus_123", options);
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
                        VolumeDecimal = 10M,
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
            service.Capture("example_authorization", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/authorizations/example_authorization/capture");
        }

        [Fact]
        public void TestTestHelpersIssuingAuthorizationsExpirePost()
        {
            var service = new Stripe.TestHelpers.Issuing.AuthorizationService(
                this.StripeClient);
            service.Expire("example_authorization");
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
            service.Increment("example_authorization", options);
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
            service.Create(options);
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
            service.Reverse("example_authorization", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/authorizations/example_authorization/reverse");
        }

        [Fact]
        public void TestTestHelpersIssuingCardsShippingDeliverPost()
        {
            var service = new Stripe.TestHelpers.Issuing.CardService(
                this.StripeClient);
            service.DeliverCard("card_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/cards/card_123/shipping/deliver");
        }

        [Fact]
        public void TestTestHelpersIssuingCardsShippingFailPost()
        {
            var service = new Stripe.TestHelpers.Issuing.CardService(
                this.StripeClient);
            service.FailCard("card_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/cards/card_123/shipping/fail");
        }

        [Fact]
        public void TestTestHelpersIssuingCardsShippingReturnPost()
        {
            var service = new Stripe.TestHelpers.Issuing.CardService(
                this.StripeClient);
            service.ReturnCard("card_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/cards/card_123/shipping/return");
        }

        [Fact]
        public void TestTestHelpersIssuingCardsShippingShipPost()
        {
            var service = new Stripe.TestHelpers.Issuing.CardService(
                this.StripeClient);
            service.ShipCard("card_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/cards/card_123/shipping/ship");
        }

        [Fact]
        public void TestTestHelpersIssuingPersonalizationDesignsActivatePost()
        {
            var service = new Stripe.TestHelpers.Issuing.PersonalizationDesignService(
                this.StripeClient);
            service.Activate("pd_xyz");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/personalization_designs/pd_xyz/activate");
        }

        [Fact]
        public void TestTestHelpersIssuingPersonalizationDesignsDeactivatePost()
        {
            var service = new Stripe.TestHelpers.Issuing.PersonalizationDesignService(
                this.StripeClient);
            service.Deactivate("pd_xyz");
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
            service.Reject("pd_xyz", options);
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
                        VolumeDecimal = 10M,
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
            service.CreateForceCapture(options);
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
                        VolumeDecimal = 10M,
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
            service.CreateUnlinkedRefund(options);
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
            service.Refund("example_transaction", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/transactions/example_transaction/refund");
        }

        [Fact]
        public void TestTestHelpersRefundsExpirePost()
        {
            var service = new Stripe.TestHelpers.RefundService(
                this.StripeClient);
            service.Expire("re_123");
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
            service.Advance("clock_xyz", options);
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
            service.Advance("clock_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/test_clocks/clock_xxxxxxxxxxxxx/advance");
        }

        [Fact]
        public void TestTestHelpersTestClocksDelete()
        {
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            service.Delete("clock_xyz");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/test_helpers/test_clocks/clock_xyz");
        }

        [Fact]
        public void TestTestHelpersTestClocksDelete2()
        {
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            service.Delete("clock_xxxxxxxxxxxxx");
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
            service.Get("clock_xyz");
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
            service.Get("clock_xxxxxxxxxxxxx");
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
            service.Create(options);
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
            service.Create(options);
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
            service.Fail("ibt_123", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/treasury/inbound_transfers/ibt_123/fail");
        }

        [Fact]
        public void TestTestHelpersTreasuryInboundTransfersReturnPost()
        {
            var service = new Stripe.TestHelpers.Treasury.InboundTransferService(
                this.StripeClient);
            service.ReturnInboundTransfer("ibt_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/treasury/inbound_transfers/ibt_123/return");
        }

        [Fact]
        public void TestTestHelpersTreasuryInboundTransfersSucceedPost()
        {
            var service = new Stripe.TestHelpers.Treasury.InboundTransferService(
                this.StripeClient);
            service.Succeed("ibt_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/treasury/inbound_transfers/ibt_123/succeed");
        }

        [Fact]
        public void TestTestHelpersTreasuryOutboundTransfersFailPost()
        {
            var service = new Stripe.TestHelpers.Treasury.OutboundTransferService(
                this.StripeClient);
            service.Fail("obt_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/treasury/outbound_transfers/obt_123/fail");
        }

        [Fact]
        public void TestTestHelpersTreasuryOutboundTransfersPostPost()
        {
            var service = new Stripe.TestHelpers.Treasury.OutboundTransferService(
                this.StripeClient);
            service.Post("obt_123");
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
            service.ReturnOutboundTransfer("obt_123", options);
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
            service.Create(options);
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
            service.Create(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/treasury/received_debits");
        }

        [Fact]
        public void TestTokensGet()
        {
            var service = new TokenService(this.StripeClient);
            service.Get("tok_xxxx");
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
            service.Create(options);
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
            service.Create(options);
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
            service.Create(options);
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
            service.Create(options);
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
            service.Create(options);
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
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/tokens");
        }

        [Fact]
        public void TestTopupsCancelPost()
        {
            var service = new TopupService(this.StripeClient);
            service.Cancel("tu_xxxxxxxxxxxxx");
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
            service.Get("tu_xxxxxxxxxxxxx");
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
            service.Create(options);
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
            service.Update("tu_xxxxxxxxxxxxx", options);
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
            service.Get("tr_xxxxxxxxxxxxx");
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
            service.Create(options);
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
            service.Update("tr_xxxxxxxxxxxxx", options);
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
            service.Get("tr_xxxxxxxxxxxxx", "trr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/transfers/tr_xxxxxxxxxxxxx/reversals/trr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTransfersReversalsPost()
        {
            var options = new TransferReversalCreateOptions { Amount = 100 };
            var service = new TransferReversalService(this.StripeClient);
            service.Create("tr_xxxxxxxxxxxxx", options);
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
            service.Update("tr_xxxxxxxxxxxxx", "trr_xxxxxxxxxxxxx", options);
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
            service.Get("credrev_xxxxxxxxxxxxx");
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
            service.Create(options);
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
            service.Get("debrev_xxxxxxxxxxxxx");
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
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/treasury/debit_reversals");
        }

        [Fact]
        public void TestTreasuryFinancialAccountsFeaturesGet()
        {
            var service = new Stripe.Treasury.FinancialAccountService(
                this.StripeClient);
            service.RetrieveFeatures("fa_xxxxxxxxxxxxx");
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
            service.Get("fa_xxxxxxxxxxxxx");
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
            service.Create(options);
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
            service.Update("fa_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/treasury/financial_accounts/fa_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryInboundTransfersCancelPost()
        {
            var service = new Stripe.Treasury.InboundTransferService(
                this.StripeClient);
            service.Cancel("ibt_xxxxxxxxxxxxx");
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
            service.Get("ibt_xxxxxxxxxxxxx");
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
            service.Create(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/treasury/inbound_transfers");
        }

        [Fact]
        public void TestTreasuryOutboundPaymentsCancelPost()
        {
            var service = new Stripe.Treasury.OutboundPaymentService(
                this.StripeClient);
            service.Cancel("bot_xxxxxxxxxxxxx");
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
            service.Get("bot_xxxxxxxxxxxxx");
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
            service.Create(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/treasury/outbound_payments");
        }

        [Fact]
        public void TestTreasuryOutboundTransfersCancelPost()
        {
            var service = new Stripe.Treasury.OutboundTransferService(
                this.StripeClient);
            service.Cancel("obt_xxxxxxxxxxxxx");
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
            service.Get("obt_xxxxxxxxxxxxx");
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
            service.Create(options);
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
            service.Get("rc_xxxxxxxxxxxxx");
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
            service.Get("rd_xxxxxxxxxxxxx");
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
            service.Get("trxne_xxxxxxxxxxxxx");
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
            service.Get("trxn_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/transactions/trxn_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestWebhookEndpointsDelete()
        {
            var service = new WebhookEndpointService(this.StripeClient);
            service.Delete("we_xxxxxxxxxxxxx");
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
            service.Get("we_xxxxxxxxxxxxx");
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
            service.Create(options);
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
            service.Update("we_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/webhook_endpoints/we_xxxxxxxxxxxxx");
        }
    }
}
