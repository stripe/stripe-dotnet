// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class TaxService : Service
    {
        private Tax.AssociationService associations;
        private Tax.CalculationService calculations;
        private Tax.FormService forms;
        private Tax.RegistrationService registrations;
        private Tax.SettingsService settings;
        private Tax.TransactionService transactions;

        internal TaxService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal TaxService(IStripeClient client)
            : base(client)
        {
        }

        public virtual Tax.AssociationService Associations => this.associations ??= new Tax.AssociationService(
            this.Requestor);

        public virtual Tax.CalculationService Calculations => this.calculations ??= new Tax.CalculationService(
            this.Requestor);

        public virtual Tax.FormService Forms => this.forms ??= new Tax.FormService(
            this.Requestor);

        public virtual Tax.RegistrationService Registrations => this.registrations ??= new Tax.RegistrationService(
            this.Requestor);

        public virtual Tax.SettingsService Settings => this.settings ??= new Tax.SettingsService(
            this.Requestor);

        public virtual Tax.TransactionService Transactions => this.transactions ??= new Tax.TransactionService(
            this.Requestor);
    }
}
