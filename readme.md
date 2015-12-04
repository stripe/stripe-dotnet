## stripe.net

I am no longer using semantic naming in this project. I do not want to have a 17.0 version of stripe.net. From now on, major changes will be a major
release, and minor changes will be a minor release. If you want to know more, view the [release notes](https://github.com/jaymedavis/stripe.net/releases).

###**If you would like to submit a pull request.**
First, thank you! It is a lot of work to learn someone else's codebase, so I appreciate it. Here are a few things that would help me out:
* Do not submit pull requests for more than one fix. Keep them small and focused.
* Please code review yourself. There are a lot of pull requests with typos and mistakes. Don't worry, we all do it. But a code review of yourself will help. :)
* Please review the diff in GitHub that I will see before I merge your pull requests. If it's hard for you to tell what the differences are, it's going to be hard for me too.

Quick Start
-----------

It is recommended that you install Stripe.net via NuGet. If you wish to build it yourself, just run build.cmd.

Add a reference to Stripe.net.dll.

Next you will need to provide Stripe.net with your api key. There are 4 ways to do this:

a) Add an AppSetting with your api key to your config (this is the easiest way and will work throughout the app on every request)

	<appSettings>
	...
		<add key="StripeApiKey" value="[your api key here]" />
	...
	</appSettings>

b) In your application initialization, call this method (this is a programmatic way, but you only have to do it once during startup)

	StripeConfiguration.SetApiKey("[your api key here]");

c) In any of the service constructors, you can optionally pass the api key (will be assigned that apikey for the life of the service instance).

	var planService = new StripePlanService("[your api key here]");

d) In any of the service calls, you can pass a [StripeRequestOptions](#striperequestoptions) object with the apikey specified.

	var planService = new StripePlanService();
	planService.Get(*planId*, new StripeRequestOptions() { ApiKey = "[your api key here]" });

Stripe Architecture
-------------------
Watch the 2 minute video below to get a high level overview of the Stripe Architecture in a .NET project and understand how all the pieces fit together.  

<a href="https://www.youtube.com/watch?v=BQg267TuJ0M&feature=youtu.be&t=7s&related=0" target="_blank">
<img src="http://i.imgur.com/NBU9pWk.png?1" alt="Stripe .NET Architecture"></img>
</a>

Stripe API Version
------------------

stripe.net forces a version of the Stripe API for which it was designed. You can find out the latest version supported by viewing StripeConfiguration.cs under the Infrastructure folder. If you *are not* using Stripe Event objects (which are most commonly used in webhooks) then you need to do nothing for stripe.net to be compatible with the Stripe API.  

If you *are* using Stripe Events then you will need to email Stripe support and ask them to set your API version (you can see this in your Stripe Dashboard) to the one specified in stripe.net's StripeConfiguration.cs file.

See the video below for more information about stripe.net versions and how they correspond with Stripe API versions.

<a href="https://youtu.be/c6dJRc9V_Ls?t=51s&related=0" target="_blank">
<img src="http://i.imgur.com/eArdtRE.png?1" alt="Stripe API and Stripe.NET Versions"></img>
</a>

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

The returned StripePlan entity above will have a unique Id. You will want to persist this for later. When you create a customer you will be able to assign them
to a plan id (or not)

### Updating a plan

	var myPlan = new StripePlanUpdateOptions();

	myPlan.Name = "NEW Plan YO!";

	var planService = new StripePlanService();
	StripePlan response = planService.Update(*planId*, myPlan);

### Retrieving a plan

	var planService = new StripePlanService();
	StripePlan response = planService.Get(*planId*);

### Deleting a plan

	var planService = new StripePlanService();
	planService.Delete(*planId*);

### List all plans

	var planService = new StripePlanService();
	IEnumerable<StripePlan> response = planService.List(); // optional StripeListOptions

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

### Retrieving a coupon

	var couponService = new StripeCouponService();
	StripeCoupon response = couponService.Get(*couponId*);

### Deleting a coupon

	var couponService = new StripeCouponService();
	couponService.Delete(*couponId*);

### List all coupons

	var couponService = new StripeCouponService();
	IEnumerable<StripeCoupon> response = couponService.List();  // optional StripeListOptions

[StripeListOptions](#stripelistoptions-paging) for paging

Tokens
------

### Creating a token

A token can be used anywhere on Stripe where you would normally pass a card. Once it's created, it can be used on a
customer or a charge, but only used once.

	var myToken = new StripeTokenCreateOptions();

	// if you need this...
	myToken.Card = new StripeCreditCardOptions()
	{
		// set these properties if passing full card details (do not
		// set these properties if you set TokenId)
		Number = "4242424242424242",
		ExpirationYear = "2022",
		ExpirationMonth = "10",
		AddressCountry = "US",                // optional
		AddressLine1 = "24 Beef Flank St",    // optional
		AddressLine2 = "Apt 24",              // optional
		AddressCity = "Biggie Smalls",        // optional
		AddressState = "NC",                  // optional
		AddressZip = "27617",                 // optional
		Name = "Joe Meatballs",               // optional
		Cvc = "1223"                          // optional
	};

	// set this property if using a customer (stripe connect only)
	myToken.CustomerId = *customerId*;

	var tokenService = new StripeTokenService();
	StripeToken stripeToken = tokenService.Create(myToken);

Tokens are very useful if you don't want to store the customers credit card information on your servers (pci compliance).

### Retrieving a token

	var tokenService = new StripeTokenService();
	StripeToken stripeToken = tokenService.Get(*tokenId*);

Customers
---------

### Creating a customer

When creating a customer, you can specify any plan they are on, any coupons that will apply,
a credit card or token, and various meta data.

	var myCustomer = new StripeCustomerCreateOptions();

	// set these properties if it makes you happy
	myCustomer.Email = "pork@email.com";
	myCustomer.Description = "Johnny Tenderloin (pork@email.com)";

	// setting up the card
	myCustomer.Source = new StripeSourceOptions()
	{
		// set this property if using a token
		TokenId = *tokenId*,

		// set these properties if passing full card details (do not
		// set these properties if you set TokenId)
		Object = "card",
		Number = "4242424242424242",
		ExpirationYear = "2022",
		ExpirationMonth = "10",
		AddressCountry = "US",                // optional
		AddressLine1 = "24 Beef Flank St",    // optional
		AddressLine2 = "Apt 24",              // optional
		AddressCity = "Biggie Smalls",        // optional
		AddressState = "NC",                  // optional
		AddressZip = "27617",                 // optional
		Name = "Joe Meatballs",               // optional
		Cvc = "1223"                          // optional
	};

	myCustomer.PlanId = *planId*;                          // only if you have a plan
	myCustomer.TaxPercent = 20;                            // only if you are passing a plan, this tax percent will be added to the price.
	myCustomer.Coupon = *couponId*;                        // only if you have a coupon
	myCustomer.TrialEnd = DateTime.UtcNow.AddMonths(1);    // when the customers trial ends (overrides the plan if applicable)
	myCustomer.Quantity = 1;                               // optional, defaults to 1

	var customerService = new StripeCustomerService();
	StripeCustomer stripeCustomer = customerService.Create(myCustomer);

Don't let this be intimidating - all of these fields are optional. You could just create a customer with an email if you wanted.

### Updating a customer

	var myCustomer = new StripeCustomerUpdateOptions();

	// set these properties if it makes you happy
	myCustomer.Email = "pork@email.com";
	myCustomer.Description = "Johnny Tenderloin (pork@email.com)";

	// setting up the card
	myCustomer.Source = new StripeSourceOptions()
	{
		// set this property if using a token
		TokenId = *tokenId*,

		// set these properties if passing full card details (do not
		// set these properties if you set TokenId)
		Object = "card",
		Number = "4242424242424242",
		ExpirationYear = "2022",
		ExpirationMonth = "10",
		AddressCountry = "US",                // optional
		AddressLine1 = "24 Beef Flank St",    // optional
		AddressLine2 = "Apt 24",              // optional
		AddressCity = "Biggie Smalls",        // optional
		AddressState = "NC",                  // optional
		AddressZip = "27617",                 // optional
		Name = "Joe Meatballs",               // optional
		Cvc = "1223"                          // optional
	};

	// this will set the default card to use for this customer
	myCustomer.DefaultSource = *cardId*;

	myCustomer.Coupon = *couponId*;    // only if you have a coupon

	var customerService = new StripeCustomerService();
	StripeCustomer stripeCustomer = customerService.Update(*customerId*, myCustomer);

### Retrieving a customer

	var customerService = new StripeCustomerService();
	StripeCustomer stripeCustomer = customerService.Get(*customerId*);

### Deleting a customer

	See Stripe's documentation on deleting a customer for more information.

	var customerService = new StripeCustomerService();
	customerService.Delete(*customerId*);

### List all customers

	var customerService = new StripeCustomerService();
	IEnumerable<StripeCustomer> response = customerService.List(); // optional StripeCustomerListOptions

StripeCustomerListOptions supports [StripeListOptions](#stripelistoptions-paging) for paging, and a [StripeDateFilter](#stripedatefilter-date-filtering) for date filtering

Subscriptions
-------------

### Creating a subscription

	var subscriptionService = new StripeSubscriptionService();
	StripeSubscription stripeSubscription = subscriptionService.Create(*customerId*, *planId*); // optional StripeSubscriptionCreateOptions

### Updating a subscription

	var subscriptionService = new StripeSubscriptionService();
	StripeSubscription stripeSubscription = subscriptionService.Update(*customerId*, *subscriptionId*); // optional StripeSubscriptionUpdateOptions

### Retrieving a subscription

	var subscriptionService = new StripeSubscriptionService();
	StripeSubscription stripeSubscription = subscriptionService.Get(*customerId*, *subscriptionId*);

### Canceling a subscription

	var subscriptionService = new StripeSubscriptionService();
	subscriptionService.Cancel(*customerId*, *subscriptionId*); // optional cancelAtPeriodEnd flag

### List all subscriptions for a customer

	var subscriptionService = new StripeSubscriptionService();
	IEnumerable<StripeSubscription> response = subscriptionService.List(*customerId*); // optional StripeListOptions

[StripeListOptions](#stripelistoptions-paging) for paging

Cards
-----

### Creating a card

When creating a card you can use either a card or a token

	var myCard = new StripeCardCreateOptions();

	// setting up the card
	myCard.Source = new StripeSourceOptions()
	{
		// set this property if using a token
		TokenId = *tokenId*,

		// set these properties if passing full card details (do not
		// set these properties if you set TokenId)
		Object = "card",
		Number = "4242424242424242",
		ExpirationYear = "2022",
		ExpirationMonth = "10",
		AddressCountry = "US",                // optional
		AddressLine1 = "24 Beef Flank St",    // optional
		AddressLine2 = "Apt 24",              // optional
		AddressCity = "Biggie Smalls",        // optional
		AddressState = "NC",                  // optional
		AddressZip = "27617",                 // optional
		Name = "Joe Meatballs",               // optional
		Cvc = "1223"                          // optional
	};

	var cardService = new StripeCardService();
	StripeCard stripeCard = cardService.Create(*customerId*, myCard); // optional isRecipient

### Retrieving a card

	var cardService = new StripeCardService();
	StripeCard stripeCard = cardService.Get(*customerId*, *cardId*); // optional isRecipient

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
	StripeCard stripeCard = cardService.Update(*customerId*, *cardId*, myCard); // optional isRecipient

### Deleting a card

	var cardService = new StripeCardService();
	cardService.Delete(*customerId*, *cardId*); // optional isRecipient

### List all cards

	var cardService = new StripeCardService();
	IEnumerable<StripeCard> response = cardService.List(*customerId*); // optional StripeListOptions and isRecipient

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

	// setting up the card
	myCharge.Source = new StripeSourceOptions()
	{
		// set this property if using a token
		TokenId = *tokenId*,

		// set these properties if passing full card details (do not
		// set these properties if you set TokenId)
		Object = "card",
		Number = "4242424242424242",
		ExpirationYear = "2022",
		ExpirationMonth = "10",
		AddressCountry = "US",                // optional
		AddressLine1 = "24 Beef Flank St",    // optional
		AddressLine2 = "Apt 24",              // optional
		AddressCity = "Biggie Smalls",        // optional
		AddressState = "NC",                  // optional
		AddressZip = "27617",                 // optional
		Name = "Joe Meatballs",               // optional
		Cvc = "1223"                          // optional
	};

	// set this property if using a customer
	myCharge.CustomerId = *customerId*;

	// set this if you have your own application fees (you must have your application configured first within Stripe)
	myCharge.ApplicationFee = 25;

	// (not required) set this to false if you don't want to capture the charge yet - requires you call capture later
	myCharge.Capture = true;

	var chargeService = new StripeChargeService();
	StripeCharge stripeCharge = chargeService.Create(myCharge);

### Retrieving a charge

	var chargeService = new StripeChargeService();
	StripeCharge stripeCharge = chargeService.Get(*chargeId*);

### Capturing a charge

If you set a charge to capture = false, you use this to capture the charge later. *amount* and *applicationFee* are not required.

	var chargeService = new StripeChargeService();
	StripeCharge stripeCharge = chargeService.Capture(*chargeId*, *amount*, *applicationFee*);

### List all charges

	var chargeService = new StripeChargeService();
	IEnumerable<StripeCharge> response = chargeService.List(); // optional StripeChargeListOptions

StripeChargeListOptions supports a CustomerId, [StripeListOptions](#stripelistoptions-paging) for paging, and a [StripeDateFilter](#stripedatefilter-date-filtering) for date filtering

Invoices
--------

### Retrieving an invoice

	var invoiceService = new StripeInvoiceService();
	StripeInvoice response = invoiceService.Get(*invoiceId*);

### Retrieving an upcoming invoice (for a single customer)

	var invoiceService = new StripeInvoiceService();
	StripeInvoice response = invoiceService.Upcoming(*customerId*);

### Create a customer invoice

	var invoiceService = new StripeInvoiceService();
	StripeInvoice response = invoiceService.Create(*customerId*); // optional StripeInvoiceCreateOptions

### Updating a customer invoice

	var stripeInvoiceUpdateOptions = new StripeInvoiceUpdateOptions();
	stripeInvoiceUpdateOptions.Closed = true;

	var invoiceService = new StripeInvoiceService();
	StripeInvoice response = invoiceService.Update(*invoiceId*, stripeInvoiceUpdateOptions);

### Paying an invoice

	var invoiceService = new StripeInvoiceService();
	StripeInvoice response = invoiceService.Pay(*invoiceId*);

### List all invoices

	var invoiceService = new StripeInvoiceService();
	IEnumerable<StripeInvoice> response = invoiceService.List(); // optional StripeInvoiceListOptions

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

### Retrieving an invoice item

	var invoiceItemService = new StripeInvoiceItemService();
	StripeInvoiceItem response = invoiceItemService.Get(*invoiceItemId*);

### Updating an invoice item

	var myUpdatedItem = new StripeInvoiceItemUpdateOptions();
	myUpdatedItem.Amount = 1010;
	myUpdatedItem.Currency = "usd";        // "usd" only supported right now
	myUpdatedItem.Description = "test";    // not required

	var invoiceItemService = new StripeInvoiceItemService();
	StripeInvoiceItem response = invoiceItemService.Update(*invoiceItemId*, myUpdatedItem);

### Deleting an invoice item

	var invoiceItemService = new StripeInvoiceItemService();
	invoiceItemService.Delete(*invoiceItemId*);

### List all invoice items

	var invoiceItemService = new StripeInvoiceItemService();
	IEnumerable<StripeInvoiceItem> response = invoiceItemService.List(); // optional StripeInvoiceItemListOptions

StripeInvoiceItemListOptions supports a CustomerId, [StripeListOptions](#stripelistoptions-paging) for paging, and a [StripeDateFilter](#stripedatefilter-date-filtering) for date filtering

Account
-------

### Retrieving your account

	var accountService = new StripeAccountService();
	StripeAccount response = accountService.Get();

Balance
-------

### Retrieving your account balance

	var balanceService = new StripeBalanceService();
	StripeBalance response = balanceService.Get();

### Retrieving a specific balance transaction

	var balanceService = new StripeBalanceService();
	StripeBalanceTransaction transaction = balanceService.Get(*balanceTransactionId*);

### Listing balance transactions

	var balanceService = new StripeBalanceService();
	IEnumerable<StripeBalanceTransaction> balanceTransactions = balanceService.List(); // optional StripeBalanceTransactionListOptions

StripeBalanceTransactionListOptions supports filtering by a [StripeDateFilter](#stripedatefilter-date-filtering) for date created, a [StripeDateFilter](#stripedatefilter-date-filtering) for date available, currency, source, transfer, type, and supports [StripeListOptions](#stripelistoptions-paging) for paging

Disputes
--------

### Updating a dispute

	var disputeService = new StripeDisputeService();

	// providing the dispute reason is optional
	StripeDispute stripeDispute = disputeService.Update(*chargeId*, "customer ate the donut before I charged them, so they said it was free");

Recipients
----------

### Creating a recipient

	var myRecipient = new StripeRecipientCreateOptions();
	myRecipient.Name = "Bacon Industries Limited";
	myRecipient.Type = "individual";                                        // "corporation" is also valid here.
	myRecipient.TaxId = "000000000";                                        // optional
	myRecipient.Email = "bacon@example.com";                                // optional
	myRecipient.Description = "Bacon Industries Ltd. (bacon@example.com)";  //optional

	// if you need this...
	myRecipient.Card = new StripeCreditCardOptions()
	{
		// set this property if using a token
		TokenId = *tokenId*,

		// set these properties if passing full card details (do not
		// set these properties if you set TokenId)
		Number = "4242424242424242",
		ExpirationYear = "2022",
		ExpirationMonth = "10",
		AddressCountry = "US",                // optional
		AddressLine1 = "24 Beef Flank St",    // optional
		AddressLine2 = "Apt 24",              // optional
		AddressCity = "Biggie Smalls",        // optional
		AddressState = "NC",                  // optional
		AddressZip = "27617",                 // optional
		Name = "Joe Meatballs",               // optional
		Cvc = "1223"                          // optional
	}

	var recipientService = new StripeRecipientService();
	StripeRecipient stripeRecipient = recipientService.Create(myRecipient);

### Updating a recipient

	var myRecipient = new StripeRecipientUpdateOptions();
	myRecipient.Name = "Bacon Industries Limited";
	myRecipient.TaxId = "000000000";                                        // optional
	myRecipient.Email = "bacon@example.com";                                // optional
	myRecipient.Description = "Bacon Industries Ltd. (bacon@example.com)";  // optional

	// if you need this...
	myRecipient.Card = new StripeCreditCardOptions()
	{
		// set this property if using a token
		TokenId = *tokenId*,

		// set these properties if passing full card details (do not
		// set these properties if you set TokenId)
		Number = "4242424242424242",
		ExpirationYear = "2022",
		ExpirationMonth = "10",
		AddressCountry = "US",                // optional
		AddressLine1 = "24 Beef Flank St",    // optional
		AddressLine2 = "Apt 24",              // optional
		AddressCity = "Biggie Smalls",        // optional
		AddressState = "NC",                  // optional
		AddressZip = "27617",                 // optional
		Name = "Joe Meatballs",               // optional
		Cvc = "1223"                          // optional
	}

	var recipientService = new StripeRecipientService();
	StripeRecipient stripeRecipient = recipientService.Update(*recipientId*, myRecipient);

### Retrieving a recipient

	var recipientService = new StripeRecipientService();
	StripeRecipient stripeRecipient = recipientService.Get(*recipientId*);

### Deleting a recipient

	var recipientService = new StripeRecipientService();
	recipientService.Deleted(*recipientId*);

### List all recipients

	var recipientService = new StripeRecipientService();
	IEnumerable<StripeRecipient> response = recipientService.List(); // optional StripeRecipientListOptions

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

### Retrieving a transfer

	var transferService = new StripeTransferService();
	StripeTransfer stripeTransfer = transferService.Get(*transferId*);

### Cancel a transfer

	var transferService = new StripeTransferService();
	StripeTransfer stripeTransfer = transferService.Cancel(*transferId*);

### List all transfers

	var transferService = new StripeTransferService();
	IEnumerable<StripeTransfer> response = transferService.List(); // optional StripeTransferListOptions

StripeTransferListOptions supports a RecipientId, Status ('pending', 'paid' or 'failed'), [StripeListOptions](#stripelistoptions-paging) for paging, and a [StripeDateFilter](#stripedatefilter-date-filtering) for date filtering (on both the created and date fields)

Application Fees
----------------

If you do not specify an amount, the entire application fee is refunded.

### Retrieving an application fee

	var feeService = new StripeApplicationFeeService();
	StripeApplicationFee stripeApplicationFee = feeService.Get(*applicationFeeId*);

### Refunding an application fee

	var feeService = new StripeApplicationFeeService();
	StripeApplicationFee stripeApplicationFee = feeService.Refund(*applicationFeeId*, *amount*);

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

Stripe sends Events (via webhooks) whenever an associated action occurs. The list of events Stripe sends is documented here: https://stripe.com/docs/api#event_types

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
					case StripeEvents.ChargeRefunded:  // all of the types available are listed in StripeEvents
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

The Stripe Connect documentation can be a little intimidating, so I am going to try to break it down a little. Stripe Connect gives you the ability to accept money on behalf of other accounts, 
and access or modify connected accounts depending on permissions.

1) The first thing you need to do is [register your platform](https://dashboard.stripe.com/account/applications/settings) with Stripe Connect. Stripe.net at this time only supports 
[Standalone Accounts](https://stripe.com/docs/connect/standalone-accounts), which is very useful because it supports every country Stripe supports. Managed Accounts are a 
valuable service as well, but they are not available in Stripe.net yet.

2) The next thing to do, is have another party connect to your site. To do this, put a link on your site which will start the authorization process, or you can use a 
[Stripe Connect Button](https://stripe.com/about/resources). Your link will need to contain some querystring parameters:

	response_type: code
	client_id:     *your client id from the stripe connect dashboard*
	scope:         read_only (default), or read_write (lets you modify their data as well) // this is optional and defaults to read_only
	redirect_uri:  this is optional, and will return the user to this page when the connection is complete
	other options are available and you can learn more about them with the [Connect OAuth Reference](https://stripe.com/docs/connect/reference)

3) When the user clicks the link on your site, they will be prompted to authorize the connection. At this point, they can create a new Stripe account or setup the connection with an existing account.

Your link will look something like this:

	https://connect.stripe.com/oauth/authorize?response_type=code&client_id=*your_client_id_from_the_stripe_connect_dashboard&scope=read_write

4) The link above will return a code when the setup is complete (and also return back to your redirect_uri if specified). With this code, you can make a request to Stripe to get the StripeUserId for accessing
their account.

In Stripe.net, you can accomplish this with the following code:

	var stripeOAuthTokenService = new StripeOAuthTokenService();
	var stripeOAuthTokeCreateOptions = new StripeOAuthTokenCreateOptions()
	{
		ClientSecret = ConfigurationManager.AppSettings["StripeApiKey"],
		Code = *the code returned from above*,
		GrantType = "authorization_code"
	};

	StripeOAuthToken stripeOAuthToken = stripeOAuthTokenService.Create(_stripeOAuthTokeCreateOptions);

5) You're done! Whenever you need to access the connected account, you simply need the StripeUserId from the StripeOAuthToken to be passed as part of the [StripeRequestOptions](#striperequestoptions) 
which all service calls now support as an optional parameter.

For example, to get the plans on the connected account, you could run the following code:

	var planService = new StripePlanService();
	StripePlan response = planService.List(null /* StripeListOptions */, new StripeRequestOptions() { StripeConnectAccountId = *the StripeUserId on the StripeOAuthToken above* });

Depending on if your permissions are read_write or read_only, you can do anything on the connected account you can do on your own account just by passing the StripeUserId as
part of StripeRequestOptions.

StripeRequestOptions
--------------------

All of the service methods accept an optional StripeRequestOptions object. This is used if you need an [Idempotency Key](https://stripe.com/docs/api?lang=curl#idempotent_requests), 
if you are using Stripe Connect, or if you want to pass the ApiKey on each method.

	var requestOptions = new StripeRequestOptions();
	requestOptions.ApiKey = *optional*;              // this is not required unless you choose to pass the apikey on every service call
	requestOptions.IdempotencyKey = "some string";   // this is for Idempotent Requests - https://stripe.com/docs/api?lang=curl#idempotent_requests
	requestOptions.StripeConnectAccountId = "acct_*" // if you are using Stripe Connect and want to issue a request on the connected account

Errors
------

Any errors that occur on any of the services will throw a StripeException with the message returned from Stripe. It is a good idea to run your service calls in a try and catch StripeException.

The StripeException contains and HttpStatusCode and a StripeError entity. The StripeError entity contains the type, message, code and param. For more infomation, review the Errors section
of stripe here: https://stripe.com/docs/api#errors
