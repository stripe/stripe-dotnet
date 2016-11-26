![Stripe](https://stripe.com/img/navigation/logo.png?2)  
[![Build status](https://ci.appveyor.com/api/projects/status/5kje1md0hltqfpyh/branch/master?svg=true)](https://ci.appveyor.com/project/JaymeDavis/stripe-net/branch/master)

**Stripe Services**

[3D Secure](#) (needs documentation)  
[Accounts](#accounts)  
[Application Fees](#application-fees)  
[Application Fee Refunds](#) (needs documentation)  
[Balance](#balance)  
[Bank Accounts](#bank-accounts)  
[Cards](#cards)  
[Charges](#charges)  
[Connect](#stripe-connect)  
[Country Specs](#country-specs)  
[Coupons](#coupons)  
[Customers](#customers)  
[Discounts](#) (needs documentation)  
[Disputes](#disputes)  
[Events](#events)  
[Errors](#errors)  
[Expandable Properties](#expandable-properties)  
[File Uploads](#file-uploads)  
[Invoices](#invoices)  
[Invoice Items](#invoice-items)  
[Metadata](#metadata)  
[OAuth](#stripe-connect) (see stripe connect)  
[Plans](#plans)  
[Radar](#radar)  
[Recipients](#recipients)  
[Refunds](#refunds)  
[Subscriptions](#subscriptions)  
[Tokens](#tokens)  
[Transfers](#transfers)  

**Stripe.net Concepts**

[StripeDateFilter](#stripedatefilter-date-filtering)  
[StripeListOptions](#stripelistoptions-paging)  
[StripeResponse](#stripe-response)  
[StripeRequestOptions](#striperequestoptions)  

Support
-------
Search [issues](https://github.com/jaymedavis/stripe.net/issues) and [pull requests](https://github.com/jaymedavis/stripe.net/pulls) to see if your issue has already been reported.
If it has, please leave a comment or a [reaction](https://github.com/blog/2119-add-reactions-to-pull-requests-issues-and-comments).
[Create a new issue](https://github.com/jaymedavis/stripe.net/issues/new) if your question is still not answered. :)

Quick Start
-----------

It is recommended that you install Stripe.net via NuGet `nuget install Stripe.net`.

Next you will need to provide Stripe.net with your api key. There are 4 ways to do this:

a) Add an AppSetting with your api key to your config (this is the easiest way and will work throughout the app on every request) - will not work on portable platforms

```xml
	<appSettings>
	...
		<add key="StripeApiKey" value="[your api key here]" />
	...
	</appSettings>
```

b) In your application initialization, call this method (this is a programmatic way, but you only have to do it once during startup)

```csharp
	StripeConfiguration.SetApiKey("[your api key here]");
```

c) In any of the service constructors, you can optionally pass the api key (will be assigned that apikey for the life of the service instance).

```csharp
	var planService = new StripePlanService("[your api key here]");
```

d) In any of the service calls, you can pass a [StripeRequestOptions](#striperequestoptions) object with the apikey specified.

```csharp
	var planService = new StripePlanService();
	planService.Get(*planId*, new StripeRequestOptions() { ApiKey = "[your api key here]" });
```

** If you are using Xamarin/Mono, you may want to provide your own HttpMessageHandler. You can do so by passing an instance to StripeConfiguration.HttpMessageHandler on your application's startup. See [this thread](https://github.com/jaymedavis/stripe.net/issues/567) for details.

Additional Learning
-------------------

There is a course made by Craig McKeachie - find it here:

[![Training](https://www.pluralsight.com/content/dam/pluralsight/newsroom/brand-assets/logos/pluralsight-logo-hor-black-1@2x.png)](https://app.pluralsight.com/library/courses/stripe-fundamentals-with-asp-net-mvc)

Stripe Response
---------------

The [`StripeResponse`](./src/Stripe/Infrastructure/public/StripeResponse.cs) object is a property (with the same name) attached to all entities in Stripe.net when they are returned from a service call.

e.g. `var charge = new StripeChargeService().Create(...)` - when you access `charge.StripeResponse`, this object will be available. The object is documented below with useful tips on each property.

```csharp
	public class StripeResponse
	{
		// ResponseJson will always tell you the complete json Stripe returned to Stripe.net.
		// this will be the same as the ObjectJson when you execute a create/get/delete call. 
		// however, if you execute a List() method, the ResponseJson will have the full api result 
		// from Stripe (a charge list with 10 charges, for example).
		public string ResponseJson { get; set; }
		
		// when you call a List() method, the object json is the object in the response array that represents
		// the entity. The ResponseJson will be the full array returned from Stripe on every entity, however, 
		// since that was the full response from Stripe. ObjectJson is always the same as ResponseJson when 
		// you are doing a regular create/get/delete, because you are dealing with a single object.
		public string ObjectJson { get; set; }

		// this is the request id of the call, as seen in the Stripe dashboard. I would recommend logging 
		// this and/or saving it to your database. this is very useful to help you find your request 
		// in the dashboard, or ask Stripe a question about your api call
		public string RequestId { get; set; }

		// this is the request date and time of the call. I would also recommend logging this and/or 
		// saving it to your database, as it tells you when Stripe processed the request.
		public DateTime RequestDate { get; set; }
	}
```

Accounts
--------
### Creating an account

When creating an account, you can create a standalone or managed account. Standalone accounts are managed by Stripe and the account owner directly. Managed accounts are handled by your platform. See the Stripe documentation for more information.

Since Stripe returns `ExternalAccounts` as a single array (contains StripeCard's and/or StripeBankAccount's), that type is a dynamic StripeList. These are split up as `ExternalCards` and `ExternalBankAccounts` for your convenience.

```csharp
	var account = new StripeAccountCreateOptions();
	account.Email = "jayme@yoyoyo.com"  // this is required if it is not a managed account. the user is emailed on standalone accounts,
	                                    // it's only used for reference on managed accounts
	account.Managed = false;            // set this to true if you want a managed account (email is not required if this is set to true)

	// a few optional settings
	account.Country = "US"                                 // defaults to your country
	account.BusinessName = "Jayme Davis' GitHub, Inc";
	account.BusinessUrl = "http://github.com/jaymedavis";

	var accountService = new StripeAccountService();
	StripeAccount response = accountService.Create(account);
```

### Retrieving an account

```csharp
	var accountService = new StripeAccountService();
	StripeAccount response = accountService.Get(*accountId*);
```

### Updating an account

Updating an account has almost all the same available properties as creating an account.

```csharp
	var myAccount = new StripeAccountUpdateOptions();
	account.BusinessUrl = "http://twitter.com/jaymed";

	var accountService = new StripeAccountService();
	StripeAccount response = accountService.Update(*accountId*, myAccount);
```

### Deleting an account

```csharp
	var accountService = new StripeAccountService();
	accountService.Delete(*accountId*);
```

Application Fees
----------------

If you do not specify an amount, the entire application fee is refunded.

### Retrieving an application fee

```csharp
	var feeService = new StripeApplicationFeeService();
	StripeApplicationFee stripeApplicationFee = feeService.Get(*applicationFeeId*);
```

### Refunding an application fee

```csharp
	var feeService = new StripeApplicationFeeService();
	StripeApplicationFee stripeApplicationFee = feeService.Refund(*applicationFeeId*, *amount*);
```

Balance
-------

### Retrieving your account balance

```csharp
	var balanceService = new StripeBalanceService();
	StripeBalance response = balanceService.Get();
```

### Retrieving a specific balance transaction

```csharp
	var balanceService = new StripeBalanceService();
	StripeBalanceTransaction transaction = balanceService.Get(*balanceTransactionId*);
```

### Listing balance transactions

```csharp
	var balanceService = new StripeBalanceService();
	IEnumerable<StripeBalanceTransaction> balanceTransactions = balanceService.List(); // optional StripeBalanceTransactionListOptions
```

StripeBalanceTransactionListOptions supports filtering by a [StripeDateFilter](#stripedatefilter-date-filtering) for date created, a [StripeDateFilter](#stripedatefilter-date-filtering) for date available, currency, source, transfer, type, and supports [StripeListOptions](#stripelistoptions-paging) for paging

Bank Accounts
-------------

### Creating a bank account

When creating a bank account you can use either bank account details or a token (ONE OR THE OTHER, NOT BOTH)

With a token:

```csharp
	var myBankAccount = new BankAccountCreateOptions();

	myBankAccount.SourceToken = *tokenId*;

	var bankAccountService = new BankAccountService();
	CustomerBankAccount bankAccount = bankAccountService.Create(*customerId*, myBankAccount);
```

With a bank account:

```csharp
	var myBankAccount = new BankAccountCreateOptions
	{
		SourceBankAccount = new SourceBankAccount()
		{
			AccountNumber = "000123456789",
			Country = "US",
			Currency = "usd",
			AccountHolderName = "Frank",
			AccountHolderType = BankAccountHolderType.Company,
			RoutingNumber = "110000000",
			Metadata = new Dictionary<string, string>
			{
				{ "Name", "Ray Barone" },
				{ "OftenSays", "Thatttttt's right" }
			}
		}
	};

	var bankAccountService = new BankAccountService();
	CustomerBankAccount bankAccount = bankAccountService.Create(*customerId*, myBankAccount);
```

### Retrieving a bank account

```csharp
	var bankAccountService = new BankAccountService();
	CustomerBankAccount bankAccount = bankAccountService.Get(*customerId*, *bankAccountId*);
```

### Updating a bank account

```csharp
	var myBankAccount = new BankAccountUpdateOptions()
	{
		AccountHolderName = "Robert",
		AccountHolderType = BankAccountHolderType.Individual,
		Metadata = new Dictionary<string, string>()
		{
			{ "Name", "Frank Barone" },
			{ "OftenSays", "Holy Crap" }
		}
	};

	var bankAccountService = new BankAccountService();
	CustomerBankAccount bankAccount = bankAccountService.Update(*customerId*, *bankAccountId*, myBankAccount);
```

### Deleting a bank account

```csharp
	var bankAccountService = new BankAccountService();
	bankAccountService.Delete(*customerId*, *bankAccountId*);
```

### List all bank account

```csharp
	var bankAccountService = new BankAccountService();
	IEnumerable<CustomerBankAccount> response = bankAccountService.List(*customerId*); // optional StripeListOptions
```

[StripeListOptions](#stripelistoptions-paging) for paging

### Verify a bank account

The Verify function is also available. You pass it to the two values sent to the user's account.

Cards
-----

### Creating a card

When creating a card you can use either a card or a token

With a token:

```csharp
	var myCard = new StripeCardCreateOptions();

	myCard.SourceToken = *tokenId*;

	var cardService = new StripeCardService();
	StripeCard stripeCard = cardService.Create(*customerId*, myCard); // optional isRecipient
```

With a card:

```csharp
	var myCard = new StripeCardCreateOptions();

	// setting up the card
	myCard.SourceCard = new SourceCard()
	{
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
```

### Retrieving a card

```csharp
	var cardService = new StripeCardService();
	StripeCard stripeCard = cardService.Get(*customerId*, *cardId*); // optional isRecipient
```

### Updating a card

```csharp
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
```

### Deleting a card

```csharp
	var cardService = new StripeCardService();
	cardService.Delete(*customerId*, *cardId*); // optional isRecipient
```

### List all cards

```csharp
	var cardService = new StripeCardService();
	IEnumerable<StripeCard> response = cardService.List(*customerId*); // optional StripeListOptions and isRecipient
```

[StripeListOptions](#stripelistoptions-paging) for paging

Charges
-------

### Creating a charge

When creating a charge you can use either a card, customer, or a token/existing source. Only one is allowed.

With a token (or an existing source):

```csharp
	var myCharge = new StripeChargeCreateOptions();

	// always set these properties
	myCharge.Amount = 5153;
	myCharge.Currency = "usd";

	// set this if you want to
	myCharge.Description = "Charge it like it's hot";

	myCharge.SourceTokenOrExistingSourceId = *tokenId or existingSourceId*;

	// set this property if using a customer - this MUST be set if you are using an existing source!
	myCharge.CustomerId = *customerId*;

	// set this if you have your own application fees (you must have your application configured first within Stripe)
	myCharge.ApplicationFee = 25;

	// (not required) set this to false if you don't want to capture the charge yet - requires you call capture later
	myCharge.Capture = true;

	var chargeService = new StripeChargeService();
	StripeCharge stripeCharge = chargeService.Create(myCharge);
```

With a card:

```csharp
	// setting up the card
	var myCharge = new StripeChargeCreateOptions();

	// always set these properties
	myCharge.Amount = 5153;
	myCharge.Currency = "usd";

	// set this if you want to
	myCharge.Description = "Charge it like it's hot";

	myCharge.SourceCard = new SourceCard()
	{
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
```

### Retrieving a charge

```csharp
	var chargeService = new StripeChargeService();
	StripeCharge stripeCharge = chargeService.Get(*chargeId*);
```

### Capturing a charge

If you set a charge to capture = false, you use this to capture the charge later. *amount* and *applicationFee* are not required.

```csharp
	var chargeService = new StripeChargeService();
	StripeCharge stripeCharge = chargeService.Capture(*chargeId*, *amount*, *applicationFee*);
```

### List all charges

```csharp
	var chargeService = new StripeChargeService();
	IEnumerable<StripeCharge> response = chargeService.List(); // optional StripeChargeListOptions
```

StripeChargeListOptions supports a CustomerId, [StripeListOptions](#stripelistoptions-paging) for paging, and a [StripeDateFilter](#stripedatefilter-date-filtering) for date filtering

Stripe Connect
--------------

The Stripe Connect documentation can be a little intimidating, so I am going to try to break it down a little. Stripe Connect gives you the ability to accept money on behalf of other accounts,
and access or modify connected accounts depending on permissions.

1) The first thing you need to do is [register your platform](https://dashboard.stripe.com/account/applications/settings) with Stripe Connect.

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

```csharp
	var stripeOAuthTokenService = new StripeOAuthTokenService();
	var _stripeOAuthTokenCreateOptions = new StripeOAuthTokenCreateOptions()
	{
		ClientSecret = ConfigurationManager.AppSettings["StripeApiKey"],
		Code = *the code returned from above*,
		GrantType = "authorization_code"
	};

	StripeOAuthToken stripeOAuthToken = stripeOAuthTokenService.Create(_stripeOAuthTokenCreateOptions);
```

5) You're done! Whenever you need to access the connected account, you simply need the StripeUserId from the StripeOAuthToken to be passed as part of the [StripeRequestOptions](#striperequestoptions)
which all service calls now support as an optional parameter.

For example, to get the plans on the connected account, you could run the following code:

```csharp
	var planService = new StripePlanService();
	StripePlan response = planService.List(null /* StripeListOptions */, new StripeRequestOptions() { StripeConnectAccountId = *the StripeUserId on the StripeOAuthToken above* });
```

Depending on if your permissions are read_write or read_only, you can do anything on the connected account you can do on your own account just by passing the StripeUserId as
part of StripeRequestOptions.

Country Specs
-------------

Each account's country can have different rules for required fields, payment methods, and currencies. The CountrySpecService allows you to receive this metadata.

### Retrieving a CountrySpec

```csharp
	var countrySpecService = new CountrySpecService();
	CountrySpec spec = countrySpecService.Get("US");
```

### List all CountrySpec's

```csharp
	var countrySpecService = new CountrySpecService();
	CountrySpec spec = countrySpecService.List();
```

[StripeListOptions](#stripelistoptions-paging) for paging

Coupons
-------

### Creating a coupon

```csharp
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
```

### Retrieving a coupon

```csharp
	var couponService = new StripeCouponService();
	StripeCoupon response = couponService.Get(*couponId*);
```

### Deleting a coupon

```csharp
	var couponService = new StripeCouponService();
	couponService.Delete(*couponId*);
```

### List all coupons

```csharp
	var couponService = new StripeCouponService();
	IEnumerable<StripeCoupon> response = couponService.List();  // optional StripeListOptions
```

[StripeListOptions](#stripelistoptions-paging) for paging

Customers
---------

### Creating a customer

When creating a customer, you can specify any plan they are on, any coupons that will apply,
a credit card or token, and various meta data.

With a token:

```csharp
	var myCustomer = new StripeCustomerCreateOptions();
	myCustomer.Email = "pork@email.com";
	myCustomer.Description = "Johnny Tenderloin (pork@email.com)";

    myCustomer.SourceToken = *token*;

	myCustomer.PlanId = *planId*;                          // only if you have a plan
	myCustomer.TaxPercent = 20;                            // only if you are passing a plan, this tax percent will be added to the price.
	myCustomer.Coupon = *couponId*;                        // only if you have a coupon
	myCustomer.TrialEnd = DateTime.UtcNow.AddMonths(1);    // when the customers trial ends (overrides the plan if applicable)
	myCustomer.Quantity = 1;                               // optional, defaults to 1

	var customerService = new StripeCustomerService();
	StripeCustomer stripeCustomer = customerService.Create(myCustomer);
```

With a card:

```csharp
	var myCustomer = new StripeCustomerCreateOptions();
	myCustomer.Email = "pork@email.com";
	myCustomer.Description = "Johnny Tenderloin (pork@email.com)";

	// setting up the card
	myCustomer.SourceCard = new SourceCard()
	{
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
```

Don't let this be intimidating - all of these fields are optional. You could just create a customer with an email if you wanted.

### Updating a customer

With a token:

```csharp
	var myCustomer = new StripeCustomerUpdateOptions();
	myCustomer.Email = "pork@email.com";
	myCustomer.Description = "Johnny Tenderloin (pork@email.com)";

    myCustomer.SourceToken = *token*;

	myCustomer.Coupon = *couponId*;    // only if you have a coupon

	var customerService = new StripeCustomerService();
	StripeCustomer stripeCustomer = customerService.Update(*customerId*, myCustomer);
```

With a card:

```csharp
	var myCustomer = new StripeCustomerUpdateOptions();
	myCustomer.Email = "pork@email.com";
	myCustomer.Description = "Johnny Tenderloin (pork@email.com)";

	// setting up the card
	myCustomer.Source = new SourceCard()
	{
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

	myCustomer.Coupon = *couponId*;    // only if you have a coupon

	var customerService = new StripeCustomerService();
	StripeCustomer stripeCustomer = customerService.Update(*customerId*, myCustomer);
```

If you want to set the default source, just add:

```csharp
	myCustomer.DefaultSource = *sourceId*;
```

### Retrieving a customer

```csharp
	var customerService = new StripeCustomerService();
	StripeCustomer stripeCustomer = customerService.Get(*customerId*);
```

### Deleting a customer

	See Stripe's documentation on deleting a customer for more information.

```csharp
	var customerService = new StripeCustomerService();
	customerService.Delete(*customerId*);
```

### List all customers

```csharp
	var customerService = new StripeCustomerService();
	IEnumerable<StripeCustomer> response = customerService.List(); // optional StripeCustomerListOptions
```

StripeCustomerListOptions supports [StripeListOptions](#stripelistoptions-paging) for paging, and a [StripeDateFilter](#stripedatefilter-date-filtering) for date filtering

Disputes
--------

### Updating a dispute

```csharp
	var disputeService = new StripeDisputeService();

	// providing the dispute reason is optional
	StripeDispute stripeDispute = disputeService.Update(*chargeId*, "customer ate the donut before I charged them, so they said it was free");
```
Events
------

Stripe sends Events (via webhooks) whenever an associated action occurs. The list of events Stripe sends is documented here: https://stripe.com/docs/api#event_types

### Receiving events from Stripe

1) In your application, create a handler that looks something like the below:

```csharp
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
```

2) Create a StripeHandler.ashx in the root of your website (or wherever) that looks like this:

```xml
	<%@ WebHandler Language="C#" Class="StripeHandler" CodeBehind="StripeHandler.cs" %>
```

3) Login to Stripe and go to Account Settings, webhooks - from here, you can setup the url that points to your StripeHandler.ashx for testing.

Whenever an Event is received, StripeEventUtility.ParseEvent(json) will convert the response into a *StripeEvent* object.

### Retrieving an event

If you have the id and you want to retrieve the event

```csharp
	var eventService = new StripeEventService();
	StripeEvent response = eventService.Get(*eventId*)
```

### List all events

You can list events in the same way everything else works in Stripe.net.

```csharp
	var eventService = new StripeEventService();
	IEnumerable<StripeEvent> response = eventService.List(); // optional StripeEventListOptions
```

StripeEventListOptions supports a type, [StripeListOptions](#stripelistoptions-paging) for paging, and a [StripeDateFilter](#stripedatefilter-date-filtering) for date filtering

Errors
------

Any errors that occur on any of the services will throw a StripeException with the message returned from Stripe. It is a good idea to run your service calls in a try and catch StripeException.

The StripeException contains and HttpStatusCode and a StripeError entity. The StripeError entity contains the type, message, code and param. For more infomation, review the Errors section
of stripe here: https://stripe.com/docs/api#errors

Expandable Properties
---------------------

Many of the services support *expandable* properties. Setting an expandable property to true means you want the entire object back instead of just the id.

For example:

```csharp
	var chargeService = new StripeChargeService();
	chargeService.ExpandBalanceTransaction = true;
	chargeService.ExpandCustomer = true;
	chargeService.ExpandInvoice = true;

	StripeCharge stripeCharge = chargeService.Get(*chargeId*);
```

When the StripeCharge is returned, the Customer, BalanceTransaction, and Invoice properties will be hydrated objects.

File Uploads
------------

### Creating a file upload

When setting the Purpose of a file, all available options are listed as constants in [StripeFilePurpose](src/Stripe/Constants/StripeFilePurpose.cs).

```csharp
	var fileService = new StripeFileUploadService();

	StripeFileUpload file = _fileService.Create("logo.png", *fileStream*, StripeFilePurpose.BusinessLogo);
```

In order to determine the mime type, your filename must end with one of the following extensions: jpeg, jpg, pdf, or png.

### Retrieving a file upload

```csharp
	var fileService = new StripeFileUploadService();
	StripeRefund refund = fileService.Get(*fileUploadId*);
```

### List all file uploads

```csharp
	var fileService = new StripeFileUploadService();
	IEnumerable<StripeFileUpload> response = fileService.List(); // optional StripeFileUploadListOptions
```

StripeFileUploadListOptions supports a Purpose, [StripeListOptions](#stripelistoptions-paging) for paging, and a [StripeDateFilter](#stripedatefilter-date-filtering) for date filtering

Invoices
--------

### Retrieving an invoice

```csharp
	var invoiceService = new StripeInvoiceService();
	StripeInvoice response = invoiceService.Get(*invoiceId*);
```

### Retrieving an upcoming invoice (for a single customer)

```csharp
	var invoiceService = new StripeInvoiceService();
	StripeInvoice response = invoiceService.Upcoming(*customerId*);
```

### Create a customer invoice

```csharp
	var invoiceService = new StripeInvoiceService();
	StripeInvoice response = invoiceService.Create(*customerId*); // optional StripeInvoiceCreateOptions
```

### Updating a customer invoice

```csharp
	var stripeInvoiceUpdateOptions = new StripeInvoiceUpdateOptions();
	stripeInvoiceUpdateOptions.Closed = true;

	var invoiceService = new StripeInvoiceService();
	StripeInvoice response = invoiceService.Update(*invoiceId*, stripeInvoiceUpdateOptions);
```

### Paying an invoice

```csharp
	var invoiceService = new StripeInvoiceService();
	StripeInvoice response = invoiceService.Pay(*invoiceId*);
```

### List all invoices

```csharp
	var invoiceService = new StripeInvoiceService();
	IEnumerable<StripeInvoice> response = invoiceService.List(); // optional StripeInvoiceListOptions
```

StripeInvoiceListOptions supports a CustomerId, [StripeListOptions](#stripelistoptions-paging) for paging, and a [StripeDateFilter](#stripedatefilter-date-filtering) for date filtering

Invoice Items
-------------

### Creating an invoice item

Any invoice items you create for a customer will be added to their bill.

```csharp
	var myItem = new StripeInvoiceItemCreateOptions();
	myItem.Amount = 1000;
	myItem.Currency = "usd";            // "usd" only supported right now
	myItem.CustomerId = *customerId*;
	myItem.Description = "na";          // not required

	var invoiceItemService = new StripeInvoiceItemService();
	StripeInvoiceItem response = invoiceItemService.Create(myItem);
```

### Retrieving an invoice item

```csharp
	var invoiceItemService = new StripeInvoiceItemService();
	StripeInvoiceItem response = invoiceItemService.Get(*invoiceItemId*);
```

### Updating an invoice item

```csharp
	var myUpdatedItem = new StripeInvoiceItemUpdateOptions();
	myUpdatedItem.Amount = 1010;
	myUpdatedItem.Currency = "usd";        // "usd" only supported right now
	myUpdatedItem.Description = "test";    // not required

	var invoiceItemService = new StripeInvoiceItemService();
	StripeInvoiceItem response = invoiceItemService.Update(*invoiceItemId*, myUpdatedItem);
```

### Deleting an invoice item

```csharp
	var invoiceItemService = new StripeInvoiceItemService();
	invoiceItemService.Delete(*invoiceItemId*);
```

### List all invoice items

```csharp
	var invoiceItemService = new StripeInvoiceItemService();
	IEnumerable<StripeInvoiceItem> response = invoiceItemService.List(); // optional StripeInvoiceItemListOptions
```

StripeInvoiceItemListOptions supports a CustomerId, [StripeListOptions](#stripelistoptions-paging) for paging, and a [StripeDateFilter](#stripedatefilter-date-filtering) for date filtering

Metadata
--------

Various calls allow attaching metadata to them such as [Creating a Customer](#creating-a-customer) and [Creating a Charge](#creating-a-charge).

To delete metadata you can call the update operation and pass an empty string (`String.Empty`) or `null` for each value you want to delete.

Plans
-----

### Creating a plan

If your site has multiple offerings, plans are perfect. You can create as many plans as you want and then just assign customers to those plans later on.

```csharp
	var myPlan = new StripePlanCreateOptions();
	myPlan.Id = "hi, im unique!";
	myPlan.Amount = 1000;           // all amounts on Stripe are in cents, pence, etc
	myPlan.Currency = "usd";        // "usd" only supported right now
	myPlan.Interval = "month";      // "month" or "year"
	myPlan.IntervalCount = 1;       // optional
	myPlan.Name = "Bronze";
	myPlan.TrialPeriodDays = 30;    // amount of time that will lapse before the customer is billed

	var planService = new StripePlanService();
	StripePlan response = planService.Create(myPlan);
```

The returned StripePlan entity above will have a unique Id. You will want to persist this for later. When you create a customer you will be able to assign them
to a plan id (or not)

### Updating a plan

```csharp
	var myPlan = new StripePlanUpdateOptions();

	myPlan.Name = "NEW Plan YO!";

	var planService = new StripePlanService();
	StripePlan response = planService.Update(*planId*, myPlan);
```

### Retrieving a plan

```csharp
	var planService = new StripePlanService();
	StripePlan response = planService.Get(*planId*);
```

### Deleting a plan

```csharp
	var planService = new StripePlanService();
	planService.Delete(*planId*);
```

### List all plans

```csharp
	var planService = new StripePlanService();
	IEnumerable<StripePlan> response = planService.List(); // optional StripeListOptions
```

[StripeListOptions](#stripelistoptions-paging) for paging

Radar
-----

Radar is a suite of products from Stripe that learns (and improves) from their network of businesses to identify and prevent fraud. I recommend [reading more about Radar](https://stripe.com/radar), and 
checking out [how it works](https://stripe.com/radar/guide#stripe-radar-and-the-stripe-network). The Stripe dashboard allows you to add rules for when to block or review payments. You can also enable 
or disable these rules as needed.

In Stripe.net, once a payment has been processed via Radar, it adds the `Review` property on StripeCharge. In a nutshell, if your review's Open property is set to true, you will need to take action. 

Some example code (in test mode) that will create and expand a review:

```csharp
	// a token from expiration month "06", expiration year "2020", and card "4000000000009235"
	var token = "tkn_12345"; 
	
	var service = new StripeChargeService();
	
	// Review is an expandable property. If you don't expand it on your service, it will only populate ReviewId!
	service.ExpandReview = true;
	
	var charge = service.Create(new StripeChargeCreateOptions { SourceTokenOrExistingSourceId = token });
	Console.WriteLine(_charge.Review);
```

**Read the docs for the radar review object to see the reasons a review is open or closed [here](https://stripe.com/docs/api#reviews)**

Recipients
----------

**Note: recipients have been deprecated by Stripe - please use [Stripe Connnect](https://stripe.com/docs/connect) instead**

### Creating a recipient

```csharp
	var myRecipient = new StripeRecipientCreateOptions();
	myRecipient.Name = "Bacon Industries Limited";
	myRecipient.Type = "individual";                                        // "corporation" is also valid here.
	myRecipient.TaxId = "000000000";                                        // optional
	myRecipient.Email = "bacon@example.com";                                // optional
	myRecipient.Description = "Bacon Industries Ltd. (bacon@example.com)";  //optional

	// create a token OR card via SourceToken or SourceCard (see above examples)

	var recipientService = new StripeRecipientService();
	StripeRecipient stripeRecipient = recipientService.Create(myRecipient);
```

### Updating a recipient

```csharp
	var myRecipient = new StripeRecipientUpdateOptions();
	myRecipient.Name = "Bacon Industries Limited";
	myRecipient.TaxId = "000000000";                                        // optional
	myRecipient.Email = "bacon@example.com";                                // optional
	myRecipient.Description = "Bacon Industries Ltd. (bacon@example.com)";  // optional

	// update a token OR card via SourceToken or SourceCard (see above examples)

	var recipientService = new StripeRecipientService();
	StripeRecipient stripeRecipient = recipientService.Update(*recipientId*, myRecipient);
```

### Retrieving a recipient

```csharp
	var recipientService = new StripeRecipientService();
	StripeRecipient stripeRecipient = recipientService.Get(*recipientId*);
```

### Deleting a recipient

```csharp
	var recipientService = new StripeRecipientService();
	recipientService.Deleted(*recipientId*);
```

### List all recipients

```csharp
	var recipientService = new StripeRecipientService();
	IEnumerable<StripeRecipient> response = recipientService.List(); // optional StripeRecipientListOptions
```

StripeRecipientListOptions supports a verified flag and [StripeListOptions](#stripelistoptions-paging) for paging

Refunds
-------

### Creating a refund

```csharp
	var refundService = new StripeRefundService();

	StripeRefund refund = refundService.Create(*chargeId*, new StripeRefundCreateOptions()
	{
		Amount = 300,
		Reason = StripeRefundReasons.Fradulent
	});
```

You can also specify Metadata, RefundApplicationFee (Connect Only), and ReverseTransfer (Connect Only)

### Retrieving a refund

```csharp
	var refundService = new StripeRefundService();
	StripeRefund refund = refundService.Get(*refundId*);
```

### Updating a refund

```csharp
	var refundService = new StripeRefundService();
	StripeRefund refund =
		refundService.Update(*refundId*, new StripeRefundUpdateOptions()
			{
				Metadata = new Dictionary<string, string>() {{ "SomeKey", "SomeValue" }}
			});
```

### List all refunds

```csharp
	var refundService = new StripeRefundService();
	IEnumerable<StripeRefund> response = refundService.List(); // optional StripeRefundListOptions
```

StripeRefundListOptions supports ChargeId and [StripeListOptions](#stripelistoptions-paging) for paging

Subscriptions
-------------

### Creating a subscription

```csharp
	var subscriptionService = new StripeSubscriptionService();
	StripeSubscription stripeSubscription = subscriptionService.Create(*customerId*, *planId*); // optional StripeSubscriptionCreateOptions
```

### Updating a subscription

```csharp
	var subscriptionService = new StripeSubscriptionService();
	StripeSubscription stripeSubscription = subscriptionService.Update(*customerId*, *subscriptionId*); // optional StripeSubscriptionUpdateOptions
```

### Retrieving a subscription

```csharp
	var subscriptionService = new StripeSubscriptionService();
	StripeSubscription stripeSubscription = subscriptionService.Get(*customerId*, *subscriptionId*);
```

### Canceling a subscription

```csharp
	var subscriptionService = new StripeSubscriptionService();
	subscriptionService.Cancel(*customerId*, *subscriptionId*); // optional cancelAtPeriodEnd flag
```

### List all subscriptions for a customer

```csharp
	var subscriptionService = new StripeSubscriptionService();
	IEnumerable<StripeSubscription> response = subscriptionService.List(*customerId*); // optional StripeListOptions
```

[StripeListOptions](#stripelistoptions-paging) for paging

Tokens
------

### Creating a token

A token can be used anywhere on Stripe where you would normally pass a card.
Once it's created, it can be used on a customer or a charge, but only used once.

For production usage, you'll almost always want to create tokens with either
[stripe.js](https://stripe.com/docs/tutorials/forms) or
[Checkout](https://stripe.com/docs/tutorials/checkout), but it can be useful
to create tokens with Stripe.net for testing.

You generally wouldn't want to use stripe.net to create tokens in production,
since creating tokens with your server offers almost no security or compliance
benefits - it still involves passing raw card data through your server.
If you're OK with the additional compliance burden, it's usually still simpler
to pass card data directly to the API.
However, there are occasionally situations where it would make sense to create
tokens on your server.

```csharp
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
```

### Retrieving a token

```csharp
	var tokenService = new StripeTokenService();
	StripeToken stripeToken = tokenService.Get(*tokenId*);
```

Transfers
---------

### Creating a transfer to a recipient

```csharp
	var myTransfer = new StripeTransferCreateOptions();
	myTransfer.Amount = 100;
	myTransfer.Currency = "usd";
	myTransfer.Recipient = "*recipientId*";          // can also be "self" if you want to send to your own account
	myTransfer.Description = "Sales Week #42";       // optional
	myTransfer.StatementDescription = "Commissions"; // optional

	var transferService = new StripeTransferService();
	StripeTransfer stripeTransfer = transferService.Create(myTransfer);
```

### Retrieving a transfer

```csharp
	var transferService = new StripeTransferService();
	StripeTransfer stripeTransfer = transferService.Get(*transferId*);
```

### Cancel a transfer

```csharp
	var transferService = new StripeTransferService();
	StripeTransfer stripeTransfer = transferService.Cancel(*transferId*);
```

### List all transfers

```csharp
	var transferService = new StripeTransferService();
	IEnumerable<StripeTransfer> response = transferService.List(); // optional StripeTransferListOptions
```

StripeTransferListOptions supports a RecipientId, Status ('pending', 'paid' or 'failed'), [StripeListOptions](#stripelistoptions-paging) for paging, and a [StripeDateFilter](#stripedatefilter-date-filtering) for date filtering (on both the created and date fields)

StripeDateFilter (date filtering)
---------------------------------

Many of the List methods support parameters to filter by date. To use this, use the `StripeDateFilter` class. You can combine the filters to make complex queries. Some examples are:

```csharp
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
```

StripeListOptions (paging)
--------------------------

All Stripe List methods support paging, using `limit`, `starting_after` and `ending_before` properties.  If you do not specify any options, `limit` will default to 10. Some examples of retrieving paged data from the StripeChargeService:

```csharp
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
```

StripeRequestOptions
--------------------

All of the service methods accept an optional StripeRequestOptions object. This is used if you need an [Idempotency Key](https://stripe.com/docs/api?lang=curl#idempotent_requests),
if you are using Stripe Connect, or if you want to pass the ApiKey on each method.

```csharp
	var requestOptions = new StripeRequestOptions();
	requestOptions.ApiKey = *optional*;              // this is not required unless you choose to pass the apikey on every service call
	requestOptions.IdempotencyKey = "some string";   // this is for Idempotent Requests - https://stripe.com/docs/api?lang=curl#idempotent_requests
	requestOptions.StripeConnectAccountId = "acct_*" // if you are using Stripe Connect and want to issue a request on the connected account
```
