using System;
using System.Collections.Generic;

namespace Stripe.Tests.Xunit
{
    public class plans_fixture : IDisposable
    {
        public StripePlanCreateOptions PlanCreateOptions { get; set; }
        public StripePlanUpdateOptions PlanUpdateOptions { get; set; }

        public StripePlan Plan { get; set; }
        public StripePlan PlanRetrieved { get; set; }
        public StripePlan PlanUpdated { get; set; }
        public StripeDeleted PlanDeleted { get; set; }
        public StripeList<StripePlan> PlansList { get; }

        public plans_fixture()
        {
            PlanCreateOptions = new StripePlanCreateOptions() {
                // Add a space at the end to ensure the ID is properly URL encoded
                // when passed in the URL for other methods
                Id = "test-plan-" + Guid.NewGuid().ToString() + " ",
                Nickname = "plan-name",
                Amount = 5000,
                Currency = "usd",
                Interval = "month",
                Product = new StripePlanProductCreateOptions
                {
                    Name = "Test Product",
                    StatementDescriptor = "TEST THIS PRODUCT"
                },
            };

            PlanUpdateOptions = new StripePlanUpdateOptions {
              Nickname = "plan-name-2"
            };

            var service = new StripePlanService(Cache.ApiKey);
            Plan = service.Create(PlanCreateOptions);
            PlanRetrieved = service.Get(Plan.Id);
            PlanUpdated = service.Update(Plan.Id, PlanUpdateOptions);
            PlansList = service.List();
            PlanDeleted = service.Delete(Plan.Id);
        }

        public void Dispose() { }
    }

    public class add_plan_to_product_fixture : IDisposable
    {
        public StripeProductCreateOptions ProductCreateOptions { get; set; }
        public StripePlanCreateOptions PlanCreateOptions { get; set; }

        public StripeProduct Product{ get; set; }
        public StripePlan Plan { get; set; }
        public StripePlan PlanRetrieved { get; set; }

        public add_plan_to_product_fixture()
        {
            ProductCreateOptions = new StripeProductCreateOptions
            {
                Name = $"test-product-{ Guid.NewGuid() }",
                Type = "service"
            };

            var productService = new StripeProductService(Cache.ApiKey);
            Product = productService.Create(ProductCreateOptions);

            PlanCreateOptions = new StripePlanCreateOptions() {
                Nickname = "plan-name",
                Amount = 5000,
                Currency = "usd",
                Interval = "month",
                ProductId = Product.Id
            };

            var planService = new StripePlanService(Cache.ApiKey);
            Plan = planService.Create(PlanCreateOptions);
            PlanRetrieved = planService.Get(Plan.Id);
        }

        public void Dispose() { }
    }
}
