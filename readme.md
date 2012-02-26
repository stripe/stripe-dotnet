Stripe.net
==========

Stripe.net is a full service .net api for http://stripe.com. It includes support for Plans, Tokens, Customers, 
Charges, Subscriptions, Invoices, and Events.

For more information about the examples below, you can visit https://stripe.com/docs/api for a full reference.


Quick Start
-----------

Add a reference to Stripe.net.dll (You can find a pre-compiled version in the build folder of this repository)

Add an AppSetting with your api key


	<appSettings>
	...
		<add key="StripeApiKey" value="[your api key here]" />
	...
	</appSettings>


Use the library :)

Examples
========

Plans
-----

### Creating a plan

If your site has multiple offerings, plans are perfect. You can create as many plans as you want and then just assign customers to those plans later on.

	var myPlan = new StripePlanCreateOptions();
	myPlan.AmountInCents = 1000;	// all amounts on Stripe are in cents
	myPlan.Currency = "usd";		// "usd" only supported right now
	myPlan.Interval = "month";		// "month" or "year"
	myPlan.Name = "Bronze";
	myPlan.TrialPeriodDays = 30;	// amount of time that will lapse before the customer is billed

	var planService = new StripePlanService();
	StripePlan response = planService.Create(myPlan);

The returned StripePlan entity above will have a unique Id. You will want to persist this for later. When you create a customer you will be able to assign them 
to a plan id (or not)

### Retrieving a plan

	var planService = new StripePlanService();
	StripePlan response = planService.Get(*planId*);

### Deleting a plan

	var planService = new StripePlanService();
	planService.Delete(*planId*);

### List all plans

	var planService = new StripePlanService();
	IEnumerable<StripePlan> response = planService.List(); // can optionally pass count (defaults to 10) and offset

Coupons (queue-pons not coo-pons)
---------------------------------

### Creating a coupon

	var myCoupon = new StripeCouponCreateOptions();
	myCoupon.Id = "HOLIDAY10OFF";
	myCoupon.PercentOff = "10";
	myCoupon.Duration = "repeating";	// "forever", "once", or "repeating"
	myCoupon.DurationInMonths = 3;		// valid when "repeating" only

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
	IEnumerable<StripeCoupon> response = couponService.List();	// can optionally pass count (defaults to 10) and offset

Tokens
------

### Creating a token

A token can be used anywhere on Stripe where you would normally pass a card. Once it's created, it can be used on a
customer or a charge, but only used once.

	var myToken = new StripeTokenCreateOptions();
	myToken.CardAddressCountry = "US";
	myToken.CardAddressLine1 = "24 Portal St";
	myToken.CardAddressLine2 = "Unit B";
	myToken.CardAddressState = "NC";
	myToken.CardAddressZip = "27617";
	myToken.CardCvc = "1223";
	myToken.CardExpirationMonth = "10";
	myToken.CardExpirationYear = "2012";
	myToken.CardName = "Gabe Newell";
	myToken.CardNumber = "4242424242424242";
	myToken.AmountInCents = 5153;
	myToken.Currency = "usd";

	var tokenService = new StripeTokenService();
	StripeToken stripeToken = tokenService.Create(myToken);

Tokens are very useful if you don't want to store the customers credit card information on your servers (very good for pci compliance).

### Retrieving a token

	var tokenService = new StripeTokenService();
	StripeToken stripeToken = tokenService.Get(*tokenId*);

Customers
---------

### Creating a customer

When creating a customer, you can specify any plan they are on, any coupons that will apply, 
a credit card or token, and various meta data.

	var myCustomer = new StripeCustomerCreateOptions()

	// set these properties if it makes you happy
	myCustomer.Email = "pork@email.com";
	myCustomer.Description = "Johnny Tenderloin (pork@email.com)";

	// set these properties if using a card
	myCustomer.CardNumber = "4242424242424242";
	myCustomer.CardExpirationYear = "2012"
	myCustomer.CardExpirationMonth = "10";
	myCustomer.CardAddressCountry = "US";				// optional
	myCustomer.CardAddressLine1 = "24 Beef Flank St";	// optional
	myCustomer.CardAddressLine2 = "Apt 24";				// optional
	myCustomer.CardAddressState = "NC";					// optional
	myCustomer.CardAddressZip = "27617";				// optional
	myCustomer.CardName = "Joe Meatballs";				// optional
	myCustomer.CardCvc = "1223";						// optional

	// set this property if using a token
	myCustomer.TokenId = *tokenId*;

	myCustomer.Plan = *planId*;								// only if you have a plan
	myCustomer.Coupon = *couponId*;							// only if you have a coupon
	myCustomer.TrialEnd = DateTime.UtcNow.AddMonths(1);		// when the customers trial ends (overrides the plan if applicable)

	var customerService = new StripeCustomerService();
	StripeCustomer stripeCustomer = customerService.Create(myCustomer);

Don't let this be intimidating - all of these fields are optional. You could just create a customer with an email if you wanted.

### Updating a customer

	var myCustomer = new StripeCustomerUpdateOptions()

	// set these properties if it makes you happy
	myCustomer.Email = "pork@email.com";
	myCustomer.Description = "Johnny Tenderloin (pork@email.com)";

	// set these properties if using a card
	myCustomer.CardNumber = "4242424242424242";
	myCustomer.CardExpirationYear = "2012";
	myCustomer.CardExpirationMonth = "10";
	myCustomer.CardAddressCountry = "US";				// optional
	myCustomer.CardAddressLine1 = "24 Beef Flank St";	// optional
	myCustomer.CardAddressLine2 = "Apt 24";				// optional
	myCustomer.CardAddressState = "NC";					// optional
	myCustomer.CardAddressZip = "27617";				// optional
	myCustomer.CardName = "Joe Meatballs";				// optional
	myCustomer.CardCvc = "1223";						// optional

	// set this property if using a token
	myCustomer.TokenId = *tokenId*;

	myCustomer.Coupon = *couponId*;		// only if you have a coupon

	var customerService = new StripeCustomerService();
	StripeCustomer stripeCustomer = customerService.Update(*customerId*, myCustomer);

### Retrieving a customer

	var customerService = new StripeCustomerService();
	StripeCustomer stripeCustomer = customerService.Get(*customerId*);

### Deleting a customer

Customers that are deleted can still be retrieved through the api. The Deleted property will be set to true if they are deleted.

	var customerService = new StripeCustomerService();
	customerService.Delete(*customerId*);

### List all customers

	var customerService = new StripeCustomerService();
	IEnumerable<StripeCustomer> response = customerService.List(); // can optionally pass count (defaults to 10) and offset

### Updating a customer subscription

	var myUpdatedSubscription = new StripeCustomerUpdateSubscriptionOptions()

	// set these properties if using a card
	myUpdatedSubscription.CardNumber = "4242424242424242";
	myUpdatedSubscription.CardExpirationYear = "2012";
	myUpdatedSubscription.CardExpirationMonth = "10";
	myUpdatedSubscription.CardAddressCountry = "US";				// optional
	myUpdatedSubscription.CardAddressLine1 = "24 Beef Flank St";	// optional
	myUpdatedSubscription.CardAddressLine2 = "Apt 24";				// optional
	myUpdatedSubscription.CardAddressState = "NC";					// optional
	myUpdatedSubscription.CardAddressZip = "27617";					// optional
	myUpdatedSubscription.CardName = "Joe Meatballs";				// optional
	myUpdatedSubscription.CardCvc = "1223";							// optional

	// set this property if using a token
	myUpdatedSubscription.TokenId = *tokenId*;

	myUpdatedSubscription.PlanId = *planId*;			
	myUpdatedSubscription.CouponId = *couponId*;
	myUpdatedSubscription.TrialEnd = DateTime.UtcNow.AddMonths(1);

	var customerService = new StripeCustomerService();
	StripeSubscription = customerService.UpdateSubscription(*customerId*, myUpdatedSubscription);

### Canceling a customer subscription

	var customerService = new StripeCustomerService();
	StripeSubscription = customerService.CancelSubscription(*customerId*);	// you can optionally pass cancelAtPeriodEnd instead of immediately cancelling 

Charges
-------

### Creating a charge

When creating a charge you can use either a card, customer, or a token. Only one is allowed.

	var myCharge = new StripeChargeCreateOptions();
	
	// always set these properties
	myCharge.AmountInCents = 5153;
	myCharge.Currency = "usd";

	// set this if you want to
	myCharge.Description = "Charge it like it's hot";

	// set these properties if using a card
	myCharge.CardNumber = "4242424242424242";
	myCharge.CardExpirationYear = "2012";
	myCharge.CardExpirationMonth = "10";
	myCharge.CardAddressCountry = "US";				// optional
	myCharge.CardAddressLine1 = "24 Beef Flank St";	// optional
	myCharge.CardAddressLine2 = "Apt 24";			// optional
	myCharge.CardAddressState = "NC";				// optional
	myCharge.CardAddressZip = "27617";				// optional
	myCharge.CardName = "Joe Meatballs";			// optional
	myCharge.CardCvc = "1223";						// optional

	// set this property if using a customer
	myCharge.CustomerId = *customerId*;
	
	// set this property if using a token
	myCharge.TokenId = *tokenId*;

	var chargeService = new StripeChargeService();
	StripeCharge stripeCharge = chargeService.Create(myCharge);

### Retrieving a charge

	var chargeService = new StripeChargeService();
	StripeCharge stripeCharge = chargeService.Get(*chargeId*);

### Refunding a charge
	
If you do not specify an amountInCents, the entire charge is refunded. The StripeCharge entity has properties for "Refunded" (bool) and RefundedAmountInCents.

	var chargeService = new StripeChargeService();
	StripeCharge stripeCharge = chargeService.Refund(*chargeId*, *amountInCents*);

### List all charges

	var chargeService = new StripeChargeService();
	IEnumerable<StripeCharge> response = chargeService.List();	// can optionally pass count (defaults to 10), offset, and a customerId to get charges for a single customer

Invoices
--------

### Retrieving an invoice

	var invoiceService = new StripeInvoiceService();
	StripeInvoice response = invoiceService.Get(*invoiceId*);

### Retrieving an upcoming invoice (for a single customer)

	var invoiceService = new StripeInvoiceService();
	StripeInvoice response = invoiceService.Upcoming(*customerId*);

### List all invoices

	var invoiceService = new StripeInvoiceService();
	IEnumerable<StripeInvoice> response = invoiceService.List(); // can optionally pass count (defaults to 10), offset, and a customerid

Invoice Items
-------------

### Creating an invoice item

Any invoice items you create for a customer will be added to their bill.

	var myItem = new StripeInvoiceItemCreateOptions();
	myItem.AmountInCents = 1000;		// all amounts on Stripe are in cents
	myItem.Currency = "usd";			// "usd" only supported right now
	myItem.CustomerId = *customerId*;
	myItem.Description = "na";			// not required

	var invoiceItemService = new StripeInvoiceItemService();
	StripeInvoiceItem response = invoiceItemService.Create(myItem);

### Retrieving an invoice item

	var invoiceItemService = new StripeInvoiceItemService();
	StripeInvoiceItem response = invoiceItemService.Get(*invoiceItemId*);

### Updating an invoice item

	var myUpdatedItem = new StripeInvoiceItemUpdateOptions();
	myUpdatedItem.AmountInCents = 1010;		// all amounts on Stripe are in cents
	myUpdatedItem.Currency = "usd";			// "usd" only supported right now
	myUpdatedItem.Description = "test";		// not required

	var invoiceItemService = new StripeInvoiceItemService();
	StripeInvoiceItem response = invoiceItemService.Update(*invoiceItemId*, myUpdatedItem);

### Deleting an invoice item

	var invoiceItemService = new StripeInvoiceItemService();
	invoiceItemService.Delete(*invoiceItemId*);

### List all invoice items

	var invoiceItemService = new StripeInvoiceItemService();
	IEnumerable<StripeInvoiceItem> response = invoiceItemService.List(); // can optionally pass count (defaults to 10), offset, and a customerid

Errors
------

Any errors that occur on any of the services will throw a StripeException with the message returned from Stripe. It is a good idea to run your service calls in a try and catch StripeException.

The StripeException contains and HttpStatusCode and a StripeError entity. The StripeError entity contains the type, message, code and param. For more infomation, review the Errors section
of stripe here: https://stripe.com/docs/api#errors