![Stripe.net](http://i.imgur.com/70TIMws.png)
##**If you need immediate support or  code changes, read this first.**

Stripe.net is under active development. Keeping the library in stable condition and working with the community takes a lot of time and commitment. I value code changes being well crafted, tests being in place when necessary, and consistency. Pull requests generally take more time than they appear. Sometimes pieces are missing, such as readme updates or tests. I also receive a lot of support email. I wish I had the time to talk to each and every one of you, but I have other commitments.

So I've decided to offer paid plans for people who have requested immediate support, expediting pull requests, or adding features immediately. Keep in mind with my other commitments, these will have to be handled in the evenings or on the weekends. If you are interested, contact me about availability.

Depending on how complex the request is, I am negotiable on the rate. If support help takes me 10 minutes, it will obviously be much cheaper than if it takes an hour. Same goes with a code change, if it's a simple pull request or code change and will not take me long to test and perform a build, it will obviously be much cheaper than if I have to spend 8 hours on the change.

Don't want to pay anything for upgrades or support? You don't have to! The codebase will remain open source and all issues and pull requests will be handled as they always have been. If you are waiting for your feature to be included, you are always welcome to fork the codebase, add your changes, and use that fork until I can get it merged into the main repository. If you absolutely cannot wait and need it on nuget immediately, contact me and I can provide you with a quote.

##**If you would like to submit a pull request.**
First, thank you! It is a lot of work to learn someone else's codebase, so I appreciate it. Here are a few things that would help me out:
* Do not submit pull requests for more than one fix. Keep them small and focused.
* Please code review yourself. There are a lot of pull requests with typos and mistakes. Don't worry, we all do it. But a code review of yourself will help. :)
* Please review the diff in GitHub that I will see before I merge your pull requests. If it's hard for you to tell what the differences are, it's going to be hard for me too.
<br><br><br>
![Donate](https://pledgie.com/campaigns/22262.png)

Quick Start
-----------

It is recommended that you install Stripe.net via NuGet. If you wish to build it yourself via build.cmd, you will need
ruby installed along with the gems albacore and zip.

Add a reference to Stripe.net.dll.

Next you will need to provide Stripe.net with your api key. There are 3 ways to do this: Choose one.

a) Add an AppSetting with your api key to your config (this is the easiest way)

	<appSettings>
	...
		<add key="StripeApiKey" value="[your api key here]" />
	...
	</appSettings>

b) In your application initialization, call (this is a programmatic way, but you only have to do it once during startup)

	StripeConfiguration.SetApiKey("[your api key here]");

c) In any of the service constructors documented below, you can optionally pass the api key (not recommended for single app/single key use). i.e...

	var planService = new StripePlanService("[your api key here]");

Use the library :)

Examples
========

Plans
-----

### Creating a plan

If your site has multiple offerings, plans are perfect. You can create as many plans as you want and then just assign customers to those plans later on.

	var myPlan = new StripePlanCreateOptions();
	myPlan.Amount = 1000;           // all amounts on Stripe are in cents, pence, etc
	myPlan.Currency = "usd";        // "usd" only supported right now
	myPlan.Interval = "month";      // "month" or "year"
	myPlan.IntervalCount = 1;       // optional
	myPlan.Name = "Bronze";
	myPlan.TrialPeriodDays = 30;    // amount of time that will lapse before the customer is billed

	var planService = new StripePlanService();
	StripePlan response = planService.Create(myPlan);

	// async version:
	StripePlan response = await planService.CreateAsync(myPlan);

The returned StripePlan entity above will have a unique Id. You will want to persist this for later. When you create a customer you will be able to assign them
to a plan id (or not)

### Updating a plan

	var myPlan = new StripePlanUpdateOptions();

	myPlan.Name = "NEW Plan YO!";

	var planService = new StripePlanService();
	StripePlan response = planService.Update(*planId*, myPlan);

	// async version:
	StripePlan response = await planService.UpdateAsync(*planId*, myPlan);

### Retrieving a plan

	var planService = new StripePlanService();
	StripePlan response = planService.Get(*planId*);

	// async version:
	StripePlan response = await planService.GetAsync(*planId*);

### Deleting a plan

	var planService = new StripePlanService();
	planService.Delete(*planId*);

	// async version: 
	await planService.DeleteAsync(*planId*);

### List all plans

	var planService = new StripePlanService();
	IEnumerable<StripePlan> response = planService.List(); // optional StripeListOptions

	// async version:
	IEnumerable<StripePlan> response = await planService.ListAsync(); // optional StripeListOptions

[StripeListOptions](#stripelistoptions-paging) for paging

Coupons (queue-pons not coo-pons)
---------------------------------

### Creating a coupon

	var myCoupon = new StripeCouponCreateOptions();
	myCoupon.Id = "HOLIDAY10OFF";
	myCoupon.PercentOff = "10";
	myCoupon.Duration = "repeating";    // "forever", "once", or "repeating"
	myCoupon.DurationInMonths = 3;      // valid when "repeating" only

	// set these if you want to
	myCoupon.MaxRedemptions = 100;
	myCoupon.RedeemBy = '12/31/2012';

	var couponService = new StripeCouponService();
	StripeCoupon response = couponService.Create(myCoupon);

	// async version:
	StripeCoupon response = await couponService.CreateAsync(myCoupon);

### Retrieving a coupon

	var couponService = new StripeCouponService();
	StripeCoupon response = couponService.Get(*couponId*);

	// async version:
	StripeCoupon response = await couponService.GetAsync(*couponId*);

### Deleting a coupon

	var couponService = new StripeCouponService();
	couponService.Delete(*couponId*);

	// async version:
	await couponService.DeleteAsync(*couponId*);

### List all coupons

	var couponService = new StripeCouponService();
	IEnumerable<StripeCoupon> response = couponService.List();  // optional StripeListOptions

	// async version:
	IEnumerable<StripeCoupon> response = await couponService.ListAsync();  // optional StripeListOptions

[StripeListOptions](#stripelistoptions-paging) for paging

Tokens
------

### Creating a token

A token can be used anywhere on Stripe where you would normally pass a card. Once it's created, it can be used on a
customer or a charge, but only used once.

	var myToken = new StripeTokenCreateOptions();

	// set these properties if using a card
	myToken.CardAddressCountry = "US";
	myToken.CardAddressLine1 = "24 Portal St";
	myToken.CardAddressLine2 = "Unit B";
	myToken.CardAddressCity = "Biggie Smalls";
	myToken.CardAddressState = "NC";
	myToken.CardAddressZip = "27617";
	myToken.CardCvc = "1223";
	myToken.CardExpirationMonth = "10";
	myToken.CardExpirationYear = "2012";
	myToken.CardName = "Gabe Newell";
	myToken.CardNumber = "4242424242424242";

	// set this property if using a customer (stripe connect only)
	myToken.CustomerId = *customerId*;

	var tokenService = new StripeTokenService();
	StripeToken stripeToken = tokenService.Create(myToken);

	// async version:
	StripeToken stripeToken = await tokenService.CreateAsync(myToken);

Tokens are very useful if you don't want to store the customers credit card information on your servers (pci compliance).

### Retrieving a token

	var tokenService = new StripeTokenService();
	StripeToken stripeToken = tokenService.Get(*tokenId*);

	// async version:
	StripeToken stripeToken = await tokenService.GetAsync(*tokenId*);

Customers
---------

### Creating a customer

When creating a customer, you can specify any plan they are on, any coupons that will apply,
a credit card or token, and various meta data.

	var myCustomer = new StripeCustomerCreateOptions();

	// set these properties if it makes you happy
	myCustomer.Email = "pork@email.com";
	myCustomer.Description = "Johnny Tenderloin (pork@email.com)";

	// set this property if using a token
	myCustomer.TokenId = *tokenId*;

	// set these properties if passing full card details (do not
	// set these properties if you have set TokenId)
	myCustomer.CardNumber = "4242424242424242";
	myCustomer.CardExpirationYear = "2012";
	myCustomer.CardExpirationMonth = "10";
	myCustomer.CardAddressCountry = "US";                // optional
	myCustomer.CardAddressLine1 = "24 Beef Flank St";    // optional
	myCustomer.CardAddressLine2 = "Apt 24";              // optional
	myCustomer.CardAddressCity = "Biggie Smalls";        // optional
	myCustomer.CardAddressState = "NC";                  // optional
	myCustomer.CardAddressZip = "27617";                 // optional
	myCustomer.CardName = "Joe Meatballs";               // optional
	myCustomer.CardCvc = "1223";                         // optional


	myCustomer.PlanId = *planId*;                          // only if you have a plan
	myCustomer.Coupon = *couponId*;                        // only if you have a coupon
	myCustomer.TrialEnd = DateTime.UtcNow.AddMonths(1);    // when the customers trial ends (overrides the plan if applicable)
	myCustomer.Quantity = 1;                               // optional, defaults to 1

	var customerService = new StripeCustomerService();
	StripeCustomer stripeCustomer = customerService.Create(myCustomer);

	// async version:
	StripeCustomer stripeCustomer = await customerService.CreateAsync(myCustomer);

Don't let this be intimidating - all of these fields are optional. You could just create a customer with an email if you wanted.

### Updating a customer

	var myCustomer = new StripeCustomerUpdateOptions();

	// set these properties if it makes you happy
	myCustomer.Email = "pork@email.com";
	myCustomer.Description = "Johnny Tenderloin (pork@email.com)";

	// set this property if using a token
	myCustomer.TokenId = *tokenId*;

	// set these properties if passing full card details
	// (do not set these properties if you have set TokenId)
	myCustomer.CardNumber = "4242424242424242";
	myCustomer.CardExpirationYear = "2012";
	myCustomer.CardExpirationMonth = "10";
	myCustomer.CardAddressCountry = "US";                // optional
	myCustomer.CardAddressLine1 = "24 Beef Flank St";    // optional
	myCustomer.CardAddressLine2 = "Apt 24";              // optional
	myCustomer.CardAddressState = "NC";                  // optional
	myCustomer.CardAddressZip = "27617";                 // optional
	myCustomer.CardName = "Joe Meatballs";               // optional
	myCustomer.CardCvc = "1223";                         // optional

	// this will set the default card to use for this customer
	myCustomer.DefaultCard = *cardId*;

	myCustomer.Coupon = *couponId*;    // only if you have a coupon

	var customerService = new StripeCustomerService();
	StripeCustomer stripeCustomer = customerService.Update(*customerId*, myCustomer);

	// async version:
	StripeCustomer stripeCustomer = await customerService.UpdateAsync(*customerId*, myCustomer);

### Retrieving a customer

	var customerService = new StripeCustomerService();
	StripeCustomer stripeCustomer = customerService.Get(*customerId*);

	// async version:
	StripeCustomer stripeCustomer = await customerService.GetAsync(*customerId*);

### Deleting a customer

	See Stripe's documentation on deleting a customer for more information.

	var customerService = new StripeCustomerService();
	customerService.Delete(*customerId*);

	// async version:
	await customerService.DeleteAsync(*customerId*);

### List all customers

	var customerService = new StripeCustomerService();
	IEnumerable<StripeCustomer> response = customerService.List(); // optional StripeCustomerListOptions

	// async version:
	IEnumerable<StripeCustomer> response = await customerService.ListAsync(); // optional StripeCustomerListOptions

StripeCustomerListOptions supports [StripeListOptions](#stripelistoptions-paging) for paging, and a [StripeDateFilter](#stripedatefilter-date-filtering) for date filtering

Subscriptions
-------------

### Creating a subscription

	var subscriptionService = new StripeSubscriptionService();
	StripeSubscription stripeSubscription = subscriptionService.Create(*customerId*, *planId*); // optional StripeSubscriptionCreateOptions

	// async version:
	StripeSubscription stripeSubscription = await subscriptionService.CreateAsync(*customerId*, *planId*); // optional StripeSubscriptionCreateOptions

### Updating a subscription

	var subscriptionService = new StripeSubscriptionService();
	StripeSubscription stripeSubscription = subscriptionService.Update(*customerId*, *subscriptionId*); // optional StripeSubscriptionUpdateOptions

	// async version:
	StripeSubscription stripeSubscription = await subscriptionService.UpdateAsync(*customerId*, *subscriptionId*); // optional StripeSubscriptionUpdateOptions

### Retrieving a subscription

	var subscriptionService = new StripeSubscriptionService();
	StripeSubscription stripeSubscription = subscriptionService.Get(*subscriptionId*);

	// async version:
	StripeSubscription stripeSubscription = await subscriptionService.GetAsync(*subscriptionId*);

### Canceling a subscription

	var subscriptionService = new StripeSubscriptionService();
	subscriptionService.Cancel(*customerId*, *subscriptionId*); // optional cancelAtPeriodEnd flag

	// async version:
	await subscriptionService.CancelAsync(*customerId*, *subscriptionId*); // optional cancelAtPeriodEnd flag

### List all subscriptions for a customer

	var subscriptionService = new StripeSubscriptionService();
	IEnumerable<StripeSubscription> response = customerService.List(*customerId*); // optional StripeListOptions

	// async version:
	IEnumerable<StripeSubscription> response = await customerService.ListAsync(*customerId*); // optional StripeListOptions

[StripeListOptions](#stripelistoptions-paging) for paging

Cards
-----

### Creating a card

When creating a card you can use either a card or a token

	var myCard = new StripeCardCreateOptions();

	// set these properties if using a card
	myCard.CardNumber = "4242424242424242";
	myCard.CardExpirationYear = "2015";
	myCard.CardExpirationMonth = "10";
	myCard.CardAddressCountry = "US";               // optional
	myCard.CardAddressLine1 = "24 Beef Flank St"    // optional
	myCard.CardAddressLine2 = "Apt 24";             // optional
	myCard.CardAddressState = "NC";                 // optional
	myCard.CardAddressZip = "27617";                // optional
	myCard.CardName = "Joey Pepperoni Smith";       // optional
	myCard.CardCvc = "1223";                        // optional

	// set this property if using a token
	myCard.TokenId = *tokenId*;

	var cardService = new StripeCardService();
	StripeCard stripeCard = cardService.Create(*customerId*, myCard);

	// async version:
	StripeCard stripeCard = await cardService.CreateAsync(*customerId*, myCard);

### Retrieving a card

	var cardService = new StripeCardService();
	StripeCard stripeCard = cardService.Get(*customerId*, *cardId*);

	// async version:
	StripeCard stripeCard = await cardService.GetAsync(*customerId*, *cardId*);

### Updating a card

	var myCard = new StripeCardUpdateOptions();

	myCard.Name = "Cardy MyCardson"
	myCard.ExpirationYear = "2016";
	myCard.ExpirationMonth = "10";
	myCard.AddressCountry = "US";
	myCard.AddressLine1 = "1234 ComeOnBabySayYouLoveMe St";
	myCard.AddressLine2 = "";
	myCard.AddressState = "NC";
	myCard.AddressCity = "Raleigh"
	myCard.AddressZip = "27617";

	var cardService = new StripeCardService();
	StripeCard stripeCard = cardService.Update(*customerId*, *cardId*, myCard);

	// async version:
	StripeCard stripeCard = await cardService.UpdateAsync(*customerId*, *cardId*, myCard);

### Deleting a card

	var cardService = new StripeCardService();
	cardService.Delete(*customerId*, *cardId*);

	// async version:
	await cardService.DeleteAsync(*customerId*, *cardId*);

### List all cards

	var cardService = new StripeCardService();
	IEnumerable<StripeCard> response = cardService.List(*customerId*); // optional StripeListOptions

	// async version:
	IEnumerable<StripeCard> response = await cardService.ListAsync(*customerId*); // optional StripeListOptions

[StripeListOptions](#stripelistoptions-paging) for paging

Charges
-------

### Creating a charge

When creating a charge you can use either a card, customer, or a token. Only one is allowed.

	var myCharge = new StripeChargeCreateOptions();

	// always set these properties
	myCharge.Amount = 5153;
	myCharge.Currency = "usd";

	// set this if you want to
	myCharge.Description = "Charge it like it's hot";

	// set this property if using a token
	myCharge.TokenId = *tokenId*;

	// set these properties if passing full card details
	// (do not set these properties if you have set a TokenId)
	myCharge.CardNumber = "4242424242424242";
	myCharge.CardExpirationYear = "2012";
	myCharge.CardExpirationMonth = "10";
	myCharge.CardAddressCountry = "US";               // optional
	myCharge.CardAddressLine1 = "24 Beef Flank St"    // optional
	myCharge.CardAddressLine2 = "Apt 24";             // optional
	myCharge.CardAddressState = "NC";                 // optional
	myCharge.CardAddressZip = "27617";                // optional
	myCharge.CardName = "Joe Meatballs";              // optional
	myCharge.CardCvc = "1223";                        // optional

	// set this property if using a customer
	myCharge.CustomerId = *customerId*;

	// if using a customer, you may also set this property to charge
	// a card other than the customer's default card
	myCharge.Card = *cardId*;

	// set this if you have your own application fees (you must have your application configured first within Stripe)
	myCharge.ApplicationFee = 25;

	// (not required) set this to false if you don't want to capture the charge yet - requires you call capture later
	myCharge.Capture = true;

	var chargeService = new StripeChargeService();
	StripeCharge stripeCharge = chargeService.Create(myCharge);

	// async version: 
	StripeCharge stripeCharge = await chargeService.CreateAsync(myCharge);

### Retrieving a charge

	var chargeService = new StripeChargeService();
	StripeCharge stripeCharge = chargeService.Get(*chargeId*);

	// async version:
	StripeCharge stripeCharge = await chargeService.GetAsync(*chargeId*);

### Refunding a charge

If you do not specify an amount, the entire charge is refunded. The StripeCharge entity has properties for "Refunded" (bool) and RefundedAmount.

	var chargeService = new StripeChargeService();
	StripeCharge stripeCharge = chargeService.Refund(*chargeId*, *amount*, *refundApplicationFee*);

	// async version:
	StripeCharge stripeCharge = await chargeService.RefundAsync(*chargeId*, *amount*, *refundApplicationFee*);

### Capturing a charge

If you set a charge to capture = false, you use this to capture the charge later. *amount* and *applicationFee* are not required.

	var chargeService = new StripeChargeService();
	StripeCharge stripeCharge = chargeService.Capture(*chargeId*, *amount*, *applicationFee*);

	// async version:
	StripeCharge stripeCharge = await chargeService.CaptureAsync(*chargeId*, *amount*, *applicationFee*);

### List all charges

	var chargeService = new StripeChargeService();
	IEnumerable<StripeCharge> response = chargeService.List(); // optional StripeChargeListOptions

	// async version: 
	IEnumerable<StripeCharge> response = await chargeService.ListAsync(); // optional StripeChargeListOptions

StripeChargeListOptions supports a CustomerId, [StripeListOptions](#stripelistoptions-paging) for paging, and a [StripeDateFilter](#stripedatefilter-date-filtering) for date filtering

Invoices
--------

### Retrieving an invoice

	var invoiceService = new StripeInvoiceService();
	StripeInvoice response = invoiceService.Get(*invoiceId*);

	// async version:
	StripeInvoice response = await invoiceService.GetAsync(*invoiceId*);

### Retrieving an upcoming invoice (for a single customer)

	var invoiceService = new StripeInvoiceService();
	StripeInvoice response = invoiceService.Upcoming(*customerId*);

	// async version:
	StripeInvoice response = await invoiceService.UpcomingAsync(*customerId*);

### Create a customer invoice

	var invoiceService = new StripeInvoiceService();
	StripeInvoice response = invoiceService.Create(*customerId*);

	// async version:
	StripeInvoice response = await invoiceService.CreateAsync(*customerId*);

### Updating a customer invoice

	var stripeInvoiceUpdateOptions = new StripeInvoiceUpdateOptions();
	stripeInvoiceUpdateOptions.Closed = true;

	var invoiceService = new StripeInvoiceService();
	StripeInvoice response = invoiceService.Update(stripeInvoiceUpdateOptions);

	// async version:
	StripeInvoice response = await invoiceService.UpdateAsync(stripeInvoiceUpdateOptions);

### Paying an invoice

	var invoiceService = new StripeInvoiceService();
	StripeInvoice response = invoiceService.Pay(*invoiceId*);

	// async version:
	StripeInvoice response = await invoiceService.PayAsync(*invoiceId*);

### List all invoices

	var invoiceService = new StripeInvoiceService();
	IEnumerable<StripeInvoice> response = invoiceService.List(); // optional StripeInvoiceListOptions

	// async version:
	IEnumerable<StripeInvoice> response = await invoiceService.ListAsync(); // optional StripeInvoiceListOptions

StripeInvoiceListOptions supports a CustomerId, [StripeListOptions](#stripelistoptions-paging) for paging, and a [StripeDateFilter](#stripedatefilter-date-filtering) for date filtering

Invoice Items
-------------

### Creating an invoice item

Any invoice items you create for a customer will be added to their bill.

	var myItem = new StripeInvoiceItemCreateOptions();
	myItem.Amount = 1000;
	myItem.Currency = "usd";            // "usd" only supported right now
	myItem.CustomerId = *customerId*;
	myItem.Description = "na";          // not required

	var invoiceItemService = new StripeInvoiceItemService();
	StripeInvoiceItem response = invoiceItemService.Create(myItem);

	// async version:
	StripeInvoiceItem response = await invoiceItemService.CreateAsync(myItem);

### Retrieving an invoice item

	var invoiceItemService = new StripeInvoiceItemService();
	StripeInvoiceItem response = invoiceItemService.Get(*invoiceItemId*);

	// async version:
	StripeInvoiceItem response = await invoiceItemService.GetAsync(*invoiceItemId*);

### Updating an invoice item

	var myUpdatedItem = new StripeInvoiceItemUpdateOptions();
	myUpdatedItem.Amount = 1010;
	myUpdatedItem.Currency = "usd";        // "usd" only supported right now
	myUpdatedItem.Description = "test";    // not required

	var invoiceItemService = new StripeInvoiceItemService();
	StripeInvoiceItem response = invoiceItemService.Update(*invoiceItemId*, myUpdatedItem);

	// async version:
	StripeInvoiceItem response = await invoiceItemService.UpdateAsync(*invoiceItemId*, myUpdatedItem);

### Deleting an invoice item

	var invoiceItemService = new StripeInvoiceItemService();
	invoiceItemService.Delete(*invoiceItemId*);

	// async version:
	await invoiceItemService.DeleteAsync(*invoiceItemId*);

### List all invoice items

	var invoiceItemService = new StripeInvoiceItemService();
	IEnumerable<StripeInvoiceItem> response = invoiceItemService.List(); // optional StripeInvoiceItemListOptions

	// async version:
	IEnumerable<StripeInvoiceItem> response = await invoiceItemService.ListAsync(); // optional StripeInvoiceItemListOptions

StripeInvoiceItemListOptions supports a CustomerId, [StripeListOptions](#stripelistoptions-paging) for paging, and a [StripeDateFilter](#stripedatefilter-date-filtering) for date filtering

Account
-------

### Retrieving your account

	var accountService = new StripeAccountService();
	StripeAccount response = accountService.Get();

	// async version:
	StripeAccount response = await accountService.GetAsync();

Balance
-------

### Retrieving your account balance

	var balanceService = new StripeBalanceService();
	StripeBalance response = balanceService.Get();

	// async version:
	StripeBalance response = await balanceService.GetAsync();

### Retrieving a specific balance transaction

	var balanceService = new StripeBalanceService();
	StripeBalanceTransaction transaction = balanceService.Get(*balanceTransactionId*);

	// async version:
	StripeBalanceTransaction transaction = await balanceService.GetAsync(*balanceTransactionId*);

### Listing balance transactions

	var balanceService = new StripeBalanceService();
	IEnumerable<StripeBalanceTransaction> balanceTransactions = balanceService.List(); // optional StripeBalanceTransactionListOptions

	// async version:
	IEnumerable<StripeBalanceTransaction> balanceTransactions = await balanceService.ListAsync(); // optional StripeBalanceTransactionListOptions

StripeBalanceTransactionListOptions supports filtering by a [StripeDateFilter](#stripedatefilter-date-filtering) for date created, a [StripeDateFilter](#stripedatefilter-date-filtering) for date available, currency, source, transfer, type, and supports [StripeListOptions](#stripelistoptions-paging) for paging

Disputes
--------

### Updating a dispute

	var disputeService = new StripeDisputeService();

	// providing the dispute reason is optional
	StripeDispute stripeDispute = disputeService.Update(*chargeId*, "customer ate the donut before I charged them, so they said it was free");

	// async version:
	StripeDispute stripeDispute = await disputeService.UpdateAsync(*chargeId*, "customer ate the donut before I charged them, so they said it was free");

Recipients
----------

### Creating a recipient

	var myRecipient = new StripeRecipientCreateOptions();
	myRecipient.Name = "Bacon Industries Limited";
	myRecipient.Type = "individual";                                        // "corporation" is also valid here.
	myRecipient.TaxId = "000000000";                                        // optional
	myRecipient.Email = "bacon@example.com";                                // optional
	myRecipient.Description = "Bacon Industries Ltd. (bacon@example.com)";  //optional

	// optional - you must specify all 3 values if you use a bank account
	myRecipient.BankAccountCountry = "US";
	myRecipient.BankAccountRoutingNumber = "110000000";
	myRecipient.BankAccountNumber = "000123456789";

	var recipientService = new StripeRecipientService();
	StripeRecipient stripeRecipient = recipientService.Create(myRecipient);

	// async version:
	StripeRecipient stripeRecipient = await recipientService.CreateAsync(myRecipient);

### Updating a recipient

	var myRecipient = new StripeRecipientUpdateOptions();
	myRecipient.Name = "Bacon Industries Limited";
	myRecipient.TaxId = "000000000";                                        // optional
	myRecipient.Email = "bacon@example.com";                                // optional
	myRecipient.Description = "Bacon Industries Ltd. (bacon@example.com)";  // optional

	// optional - you must specify all 3 values if you use a bank account
	myRecipient.BankAccountCountry = "US";
	myRecipient.BankAccountRoutingNumber = "110000000";
	myRecipient.BankAccountNumber = "000123456789";

	var recipientService = new StripeRecipientService();
	StripeRecipient stripeRecipient = recipientService.Update(*recipientId*, myRecipient);

	// async version:
	StripeRecipient stripeRecipient = await recipientService.UpdateAsync(*recipientId*, myRecipient);

### Retrieving a recipient

	var recipientService = new StripeRecipientService();
	StripeRecipient stripeRecipient = recipientService.Get(*recipientId*);

	// async version:
	StripeRecipient stripeRecipient = await recipientService.GetAsync(*recipientId*);

### Deleting a recipient

	var recipientService = new StripeRecipientService();
	recipientService.Deleted(*recipientId*);

	// async version:
	await recipientService.DeletedAsync(*recipientId*);

### List all recipients

	var recipientService = new StripeRecipientService();
	IEnumerable<StripeRecipient> response = recipientService.List(); // optional StripeRecipientListOptions

	// async version:
	IEnumerable<StripeRecipient> response = await recipientService.ListAsync(); // optional StripeRecipientListOptions

StripeRecipientListOptions supports a verified flag and [StripeListOptions](#stripelistoptions-paging) for paging

Transfers
---------

### Creating a transfer to a recipient

	var myTransfer = new StripeTransferCreateOptions();
	myTransfer.Amount = 100;
	myTransfer.Currency = "usd";
	myTransfer.Recipient = "*recipientId*";          // can also be "self" if you want to send to your own account
	myTransfer.Description = "Sales Week #42";       // optional
	myTransfer.StatementDescription = "Commissions"; // optional

	var transferService = new StripeTransferService();
	StripeTransfer stripeTransfer = transferService.Create(myTransfer);

	// async version:
	StripeTransfer stripeTransfer = await transferService.CreateAsync(myTransfer);

### Retrieving a transfer

	var transferService = new StripeTransferService();
	StripeTransfer stripeTransfer = transferService.Get(*transferId*);

	// async version:
	StripeTransfer stripeTransfer = await transferService.GetAsync(*transferId*);

### Cancel a transfer

	var transferService = new StripeTransferService();
	StripeTransfer stripeTransfer = transferService.Cancel(*transferId*);

	// async version:
	StripeTransfer stripeTransfer = await transferService.CancelAsync(*transferId*);

### List all transfers

	var transferService = new StripeTransferService();
	IEnumerable<StripeTransfer> response = transferService.List(); // optional StripeTransferListOptions

	// async version:
	IEnumerable<StripeTransfer> response = await transferService.ListAsync(); // optional StripeTransferListOptions

StripeTransferListOptions supports a RecipientId, Status ('pending', 'paid' or 'failed'), [StripeListOptions](#stripelistoptions-paging) for paging, and a [StripeDateFilter](#stripedatefilter-date-filtering) for date filtering (on both the created and date fields)

Application Fees
----------------

If you do not specify an amount, the entire application fee is refunded.

### Retrieving an application fee

	var feeService = new StripeApplicationFeeService();
	StripeApplicationFee stripeApplicationFee = feeService.Get(*applicationFeeId*);

	// async version:
	StripeApplicationFee stripeApplicationFee = await feeService.GetAsync(*applicationFeeId*);

### Refunding an application fee

	var feeService = new StripeApplicationFeeService();
	StripeApplicationFee stripeApplicationFee = feeService.Refund(*applicationFeeId*, *amount*);

	// async version:
	StripeApplicationFee stripeApplicationFee = await feeService.RefundAsync(*applicationFeeId*, *amount*);

StripeListOptions (paging)
--------------------------

All Stripe List methods support paging, using `limit`, `starting_after` and `ending_before` properties.  If you do not specify any options, `limit` will default to 10. Some examples of retrieving paged data from the StripeChargeService:

	var chargeService = new StripeChargeService();

	// get the first five results
	IEnumerable<StripeCharge> firstPage = chargeService.List(new StripeChargeListOptions {
  	Limit = 5
	});

	// get the next five results
	IEnumerable<StripeCharge> nextPage = chargeService.List(new StripeChargeListOptions {
  	Limit = 5,
    StartingAfter = firstPage.Last().Id
	});

	// get the previous five results again
	IEnumerable<StripeCharge> previousPage = chargeService.List(new StripeChargeListOptions {
		Limit = 5,
		EndingBefore = nextPage.First().Id
	});

StripeDateFilter (date filtering)
---------------------------------

Many of the List methods support parameters to filter by date. To use this, use the `StripeDateFilter` class. You can combine the filters to make complex queries. Some examples are:

	var chargeService = new StripeChargeService();

	var chargesToday = chargeService.List(new StripeChargeListOptions {
		Created = new StripeDateFilter { GreaterThanOrEqual = DateTime.UtcNow.Date }
	});

	var chargesYesterday = chargeService.List(new StripeChargeListOptions {
		Created = new StripeDateFilter {
			GreaterThanOrEqual = DateTime.Now.AddDays(-1).Date,
			LessThan = DateTime.Now.Date
		}
	});

Expandable Properties
---------------------

Many of the services support *expandable* properties. Setting an expandable property to true means you want the entire object back instead of just the id.

For example:

	var chargeService = new StripeChargeService();
	chargeService.ExpandBalanceTransaction = true;
	chargeService.ExpandCustomer = true;
	chargeService.ExpandInvoice = true;

	StripeCharge stripeCharge = chargeService.Get(*chargeId*);

When the StripeCharge is returned, the Customer, BalanceTransaction, and Invoice properties will be hydrated objects.

Events
------

Stripe sends Events (or webhooks) whenever an associated action occurs. The list of events Stripe sends is documented here: https://stripe.com/docs/api#event_types

### Receiving events from Stripe

1) In your application, create a handler that looks something like the below:

	namespace TheBestApplicationEverCreated
	{
		public class StripeHandler : IHttpHandler
		{
			public bool IsReusable
			{
				get { return true; }
			}

			public void ProcessRequest(HttpContext context)
			{
				var json = new StreamReader(context.Request.InputStream).ReadToEnd();

				var stripeEvent = StripeEventUtility.ParseEvent(json);

				switch (stripeEvent.Type)
				{
					case "charge.refunded":  // take a look at all the types here: https://stripe.com/docs/api#event_types
						var stripeCharge = Stripe.Mapper<StripeCharge>.MapFromJson(stripeEvent.Data.Object.ToString());
						break;
				}
			}
		}
	}

2) Create a StripeHandler.ashx in the root of your website (or wherever) that looks like this:

	<%@ WebHandler Language="C#" Class="StripeHandler" CodeBehind="StripeHandler.cs" %>

3) Login to Stripe and go to Account Settings, webhooks - from here, you can setup the url that points to your StripeHandler.ashx for testing.

Whenever an Event is received, StripeEventUtility.ParseEvent(json) will convert the response into a *StripeEvent* object.

### Retrieving an event

If you have the id and you want to retrieve the event

	var eventService = new StripeEventService();
	StripeEvent response = eventService.Get(*eventId*)

### List all events

You can list events in the same way everything else works in Stripe.net.

	var eventService = new StripeEventService();
	IEnumerable<StripeEvent> response = eventService.List(); // optional StripeEventListOptions

StripeEventListOptions supports a type, [StripeListOptions](#stripelistoptions-paging) for paging, and a [StripeDateFilter](#stripedatefilter-date-filtering) for date filtering

Stripe Connect
--------------

For information about how to use Stripe Connect, see this comment https://github.com/jaymedavis/stripe.net/pull/43#issuecomment-10903921

Errors
------

Any errors that occur on any of the services will throw a StripeException with the message returned from Stripe. It is a good idea to run your service calls in a try and catch StripeException.

The StripeException contains and HttpStatusCode and a StripeError entity. The StripeError entity contains the type, message, code and param. For more infomation, review the Errors section
of stripe here: https://stripe.com/docs/api#errors

Async Support
-------------

All methods have Async versions that are non-blocking so that you can use them on web applications for higher throughput, or GUI applications to prevent the UI from locking up while waiting on a response. Async versions are not available in the .NET 3.5 build.
