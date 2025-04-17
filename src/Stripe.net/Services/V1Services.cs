// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class V1Services : Service
    {
        private AccountService accounts;
        private AccountLinkService accountLinks;
        private AccountNoticeService accountNotices;
        private AccountSessionService accountSessions;
        private ApplePayDomainService applePayDomains;
        private ApplicationFeeService applicationFees;
        private AppsService apps;
        private BalanceService balance;
        private BalanceSettingsService balanceSettings;
        private BalanceTransactionService balanceTransactions;
        private BankAccountService bankAccounts;
        private BillingService billing;
        private BillingPortalService billingPortal;
        private CapitalService capital;
        private CardService cards;
        private ChargeService charges;
        private CheckoutService checkout;
        private ClimateService climate;
        private ConfirmationTokenService confirmationTokens;
        private TestHelpersService testHelpers;
        private CountrySpecService countrySpecs;
        private CouponService coupons;
        private CreditNoteService creditNotes;
        private CustomerService customers;
        private CustomerSessionService customerSessions;
        private DisputeService disputes;
        private EntitlementsService entitlements;
        private EphemeralKeyService ephemeralKeys;
        private EventService events;
        private FileService files;
        private FileLinkService fileLinks;
        private FinancialConnectionsService financialConnections;
        private ForwardingService forwarding;
        private FxQuoteService fxQuotes;
        private GiftCardsService giftCards;
        private IdentityService identity;
        private InvoiceService invoices;
        private InvoiceRenderingTemplateService invoiceRenderingTemplates;
        private InvoiceItemService invoiceItems;
        private IssuingService issuing;
        private MandateService mandates;
        private MarginService margins;
        private OrderService orders;
        private PaymentAttemptRecordService paymentAttemptRecords;
        private PaymentIntentService paymentIntents;
        private PaymentLinkService paymentLinks;
        private PaymentMethodService paymentMethods;
        private PaymentMethodConfigurationService paymentMethodConfigurations;
        private PaymentMethodDomainService paymentMethodDomains;
        private PaymentRecordService paymentRecords;
        private PayoutService payouts;
        private PlanService plans;
        private PriceService prices;
        private PrivacyService privacy;
        private ProductService products;
        private PromotionCodeService promotionCodes;
        private QuoteService quotes;
        private RadarService radar;
        private RefundService refunds;
        private ReportingService reporting;
        private ReviewService reviews;
        private SigmaService sigma;
        private SetupAttemptService setupAttempts;
        private SetupIntentService setupIntents;
        private ShippingRateService shippingRates;
        private SourceService sources;
        private SubscriptionService subscriptions;
        private SubscriptionItemService subscriptionItems;
        private SubscriptionScheduleService subscriptionSchedules;
        private TaxService tax;
        private TaxCodeService taxCodes;
        private TaxIdService taxIds;
        private TaxRateService taxRates;
        private TerminalService terminal;
        private TokenService tokens;
        private TopupService topups;
        private TransferService transfers;
        private TreasuryService treasury;
        private WebhookEndpointService webhookEndpoints;
        private ExternalAccountService externalAccounts;

        internal V1Services(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal V1Services(IStripeClient client)
            : base(client)
        {
        }

        public virtual AccountService Accounts => this.accounts ??= new AccountService(
            this.Requestor);

        public virtual AccountLinkService AccountLinks => this.accountLinks ??= new AccountLinkService(
            this.Requestor);

        public virtual AccountNoticeService AccountNotices => this.accountNotices ??= new AccountNoticeService(
            this.Requestor);

        public virtual AccountSessionService AccountSessions => this.accountSessions ??= new AccountSessionService(
            this.Requestor);

        public virtual ApplePayDomainService ApplePayDomains => this.applePayDomains ??= new ApplePayDomainService(
            this.Requestor);

        public virtual ApplicationFeeService ApplicationFees => this.applicationFees ??= new ApplicationFeeService(
            this.Requestor);

        public virtual AppsService Apps => this.apps ??= new AppsService(
            this.Requestor);

        public virtual BalanceService Balance => this.balance ??= new BalanceService(
            this.Requestor);

        public virtual BalanceSettingsService BalanceSettings => this.balanceSettings ??= new BalanceSettingsService(
            this.Requestor);

        public virtual BalanceTransactionService BalanceTransactions => this.balanceTransactions ??= new BalanceTransactionService(
            this.Requestor);

        public virtual BankAccountService BankAccounts => this.bankAccounts ??= new BankAccountService(
            this.Requestor);

        public virtual BillingService Billing => this.billing ??= new BillingService(
            this.Requestor);

        public virtual BillingPortalService BillingPortal => this.billingPortal ??= new BillingPortalService(
            this.Requestor);

        public virtual CapitalService Capital => this.capital ??= new CapitalService(
            this.Requestor);

        public virtual CardService Cards => this.cards ??= new CardService(
            this.Requestor);

        public virtual ChargeService Charges => this.charges ??= new ChargeService(
            this.Requestor);

        public virtual CheckoutService Checkout => this.checkout ??= new CheckoutService(
            this.Requestor);

        public virtual ClimateService Climate => this.climate ??= new ClimateService(
            this.Requestor);

        public virtual ConfirmationTokenService ConfirmationTokens => this.confirmationTokens ??= new ConfirmationTokenService(
            this.Requestor);

        public virtual TestHelpersService TestHelpers => this.testHelpers ??= new TestHelpersService(
            this.Requestor);

        public virtual CountrySpecService CountrySpecs => this.countrySpecs ??= new CountrySpecService(
            this.Requestor);

        public virtual CouponService Coupons => this.coupons ??= new CouponService(
            this.Requestor);

        public virtual CreditNoteService CreditNotes => this.creditNotes ??= new CreditNoteService(
            this.Requestor);

        public virtual CustomerService Customers => this.customers ??= new CustomerService(
            this.Requestor);

        public virtual CustomerSessionService CustomerSessions => this.customerSessions ??= new CustomerSessionService(
            this.Requestor);

        public virtual DisputeService Disputes => this.disputes ??= new DisputeService(
            this.Requestor);

        public virtual EntitlementsService Entitlements => this.entitlements ??= new EntitlementsService(
            this.Requestor);

        public virtual EphemeralKeyService EphemeralKeys => this.ephemeralKeys ??= new EphemeralKeyService(
            this.Requestor);

        public virtual EventService Events => this.events ??= new EventService(
            this.Requestor);

        public virtual FileService Files => this.files ??= new FileService(
            this.Requestor);

        public virtual FileLinkService FileLinks => this.fileLinks ??= new FileLinkService(
            this.Requestor);

        public virtual FinancialConnectionsService FinancialConnections => this.financialConnections ??= new FinancialConnectionsService(
            this.Requestor);

        public virtual ForwardingService Forwarding => this.forwarding ??= new ForwardingService(
            this.Requestor);

        public virtual FxQuoteService FxQuotes => this.fxQuotes ??= new FxQuoteService(
            this.Requestor);

        public virtual GiftCardsService GiftCards => this.giftCards ??= new GiftCardsService(
            this.Requestor);

        public virtual IdentityService Identity => this.identity ??= new IdentityService(
            this.Requestor);

        public virtual InvoiceService Invoices => this.invoices ??= new InvoiceService(
            this.Requestor);

        public virtual InvoiceRenderingTemplateService InvoiceRenderingTemplates => this.invoiceRenderingTemplates ??= new InvoiceRenderingTemplateService(
            this.Requestor);

        public virtual InvoiceItemService InvoiceItems => this.invoiceItems ??= new InvoiceItemService(
            this.Requestor);

        public virtual IssuingService Issuing => this.issuing ??= new IssuingService(
            this.Requestor);

        public virtual MandateService Mandates => this.mandates ??= new MandateService(
            this.Requestor);

        public virtual MarginService Margins => this.margins ??= new MarginService(
            this.Requestor);

        public virtual OrderService Orders => this.orders ??= new OrderService(
            this.Requestor);

        public virtual PaymentAttemptRecordService PaymentAttemptRecords => this.paymentAttemptRecords ??= new PaymentAttemptRecordService(
            this.Requestor);

        public virtual PaymentIntentService PaymentIntents => this.paymentIntents ??= new PaymentIntentService(
            this.Requestor);

        public virtual PaymentLinkService PaymentLinks => this.paymentLinks ??= new PaymentLinkService(
            this.Requestor);

        public virtual PaymentMethodService PaymentMethods => this.paymentMethods ??= new PaymentMethodService(
            this.Requestor);

        public virtual PaymentMethodConfigurationService PaymentMethodConfigurations => this.paymentMethodConfigurations ??= new PaymentMethodConfigurationService(
            this.Requestor);

        public virtual PaymentMethodDomainService PaymentMethodDomains => this.paymentMethodDomains ??= new PaymentMethodDomainService(
            this.Requestor);

        public virtual PaymentRecordService PaymentRecords => this.paymentRecords ??= new PaymentRecordService(
            this.Requestor);

        public virtual PayoutService Payouts => this.payouts ??= new PayoutService(
            this.Requestor);

        public virtual PlanService Plans => this.plans ??= new PlanService(
            this.Requestor);

        public virtual PriceService Prices => this.prices ??= new PriceService(
            this.Requestor);

        public virtual PrivacyService Privacy => this.privacy ??= new PrivacyService(
            this.Requestor);

        public virtual ProductService Products => this.products ??= new ProductService(
            this.Requestor);

        public virtual PromotionCodeService PromotionCodes => this.promotionCodes ??= new PromotionCodeService(
            this.Requestor);

        public virtual QuoteService Quotes => this.quotes ??= new QuoteService(
            this.Requestor);

        public virtual RadarService Radar => this.radar ??= new RadarService(
            this.Requestor);

        public virtual RefundService Refunds => this.refunds ??= new RefundService(
            this.Requestor);

        public virtual ReportingService Reporting => this.reporting ??= new ReportingService(
            this.Requestor);

        public virtual ReviewService Reviews => this.reviews ??= new ReviewService(
            this.Requestor);

        public virtual SigmaService Sigma => this.sigma ??= new SigmaService(
            this.Requestor);

        public virtual SetupAttemptService SetupAttempts => this.setupAttempts ??= new SetupAttemptService(
            this.Requestor);

        public virtual SetupIntentService SetupIntents => this.setupIntents ??= new SetupIntentService(
            this.Requestor);

        public virtual ShippingRateService ShippingRates => this.shippingRates ??= new ShippingRateService(
            this.Requestor);

        public virtual SourceService Sources => this.sources ??= new SourceService(
            this.Requestor);

        public virtual SubscriptionService Subscriptions => this.subscriptions ??= new SubscriptionService(
            this.Requestor);

        public virtual SubscriptionItemService SubscriptionItems => this.subscriptionItems ??= new SubscriptionItemService(
            this.Requestor);

        public virtual SubscriptionScheduleService SubscriptionSchedules => this.subscriptionSchedules ??= new SubscriptionScheduleService(
            this.Requestor);

        public virtual TaxService Tax => this.tax ??= new TaxService(
            this.Requestor);

        public virtual TaxCodeService TaxCodes => this.taxCodes ??= new TaxCodeService(
            this.Requestor);

        public virtual TaxIdService TaxIds => this.taxIds ??= new TaxIdService(
            this.Requestor);

        public virtual TaxRateService TaxRates => this.taxRates ??= new TaxRateService(
            this.Requestor);

        public virtual TerminalService Terminal => this.terminal ??= new TerminalService(
            this.Requestor);

        public virtual TokenService Tokens => this.tokens ??= new TokenService(
            this.Requestor);

        public virtual TopupService Topups => this.topups ??= new TopupService(
            this.Requestor);

        public virtual TransferService Transfers => this.transfers ??= new TransferService(
            this.Requestor);

        public virtual TreasuryService Treasury => this.treasury ??= new TreasuryService(
            this.Requestor);

        public virtual WebhookEndpointService WebhookEndpoints => this.webhookEndpoints ??= new WebhookEndpointService(
            this.Requestor);

        public virtual ExternalAccountService ExternalAccounts => this.externalAccounts ??= new ExternalAccountService(
            this.Requestor);
    }
}
