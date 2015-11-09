using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeManagedAccountUpdateOptions
    {
        #region General Account Properties
        
        [JsonProperty("business_name")]
        public string BusinessName { get; set; }

        //business_logo is mentioned but cannot find information on its use/implementation
        //[JsonProperty("business_logo")]
        //public string BusinessLogo { get; set; }

        [JsonProperty("business_primary_color")]
        public string BusinessPrimaryColor { get; set; }

        [JsonProperty("business_url")]
        public string BusinessUrl { get; set; }

        [JsonProperty("currencies_supported")]
        public string[] CurrenciesSupported { get; set; }

        [JsonProperty("default_currency")]
        public string DefaultCurrency { get; set; }
        
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("support_email")]
        public string SupportEmail { get; set; }

        [JsonProperty("support_phone")]
        public string SupportPhone { get; set; }

        [JsonProperty("support_url")]
        public string SupportUrl { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }
        
        #endregion

        #region Managed Account Properties

        [JsonProperty("debit_negative_balances")]
        public bool DebitNegativeBalances { get; set; }

        [JsonProperty("decline_charge_on[cvc_failure]")]
        public bool DeclineChargeOnCvcFailure { get; set; }

        [JsonProperty("decline_charge_on[avs_failure]")]
        public bool DeclineChargeOnAvsFailure { get; set; }

        //ToDo: implement External Accounts.  Can be one of the following:  ID from stripe.js or an object (bank account or card)
        //[JsonProperty("external_accounts")]

        #region Legal Entity
        [JsonProperty("legal_entity[business_name]")]
        public string LegalEntityBusinessName { get; set; }

        [JsonProperty("legal_entity[business_tax_id]")]
        public string LegalEntityBusinessTaxId { get; set; }

        [JsonProperty("legal_entity[business_vat_id]")]
        public string LegalEntityBusinessVatId { get; set; }

        [JsonProperty("legal_entity[address][line1]")]
        public string LegalEntityAddressLine1 { get; set; }

        [JsonProperty("legal_entity[address][line2]")]
        public string LegalEntityAddressLine2 { get; set; }

        [JsonProperty("legal_entity[address][city]")]
        public string LegalEntityAddressCity { get; set; }

        [JsonProperty("legal_entity[address][state]")]
        public string LegalEntityAddressState { get; set; }

        [JsonProperty("legal_entity[address][postal_code]")]
        public string LegalEntityAddressPostalCode { get; set; }

        [JsonProperty("legal_entity[address][country]")]
        public string LegalEntityAddressCountry { get; set; }

        [JsonProperty("legal_entity[personal_id_number]")]
        public string LegalEntityPersonalIdNumber { get; set; }

        [JsonProperty("legal_entity[ssn_last_4]")]
        public int? LegalEntityRepSSN4 { get; set; }

        [JsonProperty("legal_entity[first_name]")]
        public string LegalEntityRepFirstName { get; set; }

        [JsonProperty("legal_entity[last_name]")]
        public string LegalEntityRepLastName { get; set; }

        [JsonProperty("legal_entity[dob][day]")]
        public int? LegalEntityRepDobDay { get; set; }

        [JsonProperty("legal_entity[dob][month]")]
        public int? LegalEntityRepDobMonth { get; set; }

        [JsonProperty("legal_entity[dob][year]")]
        public int? LegalEntityRepDobYear { get; set; }

        [JsonProperty("legal_entity[personal_address][line1]")]
        public string LegalEntityPersonalAddressLine1 { get; set; }

        [JsonProperty("legal_entity[personal_address][line2]")]
        public string LegalEntityPersonalAddressLine2 { get; set; }

        [JsonProperty("legal_entity[personal_address][city]")]
        public string LegalEntityPersonalAddressCity { get; set; }

        [JsonProperty("legal_entity[personal_address][state]")]
        public string LegalEntityPersonalAddressState { get; set; }

        [JsonProperty("legal_entity[personal_address][postal_code]")]
        public string LegalEntityPersonalAddressPostalCode { get; set; }

        [JsonProperty("legal_entity[personal_address][country]")]
        public string LegalEntityPersonalAddressCountry { get; set; }

        [JsonProperty("legal_entity[type]")]
        public string LegalEntityType { get; set; }

        [JsonProperty("legal_entity[verification][document]")]
        public string LegalEntityVerificationDocumentId { get; set; }

        //By default set additional owners to blank
        [JsonProperty("legal_entity[additional_owners]")]
        public string AdditionalOwners { get; set; } = "";

        #region Additional Owners
        //Implementing the ability to have three owners of the legal entity
        //Additional Owners are only required for EU countries as of November 2015.

        //Legal Entity - Owner1
        [JsonProperty("legal_entity[additional_owners][0][first_name]")]
        public string LegalEntityOwnerOneFirstName { get; set; }

        [JsonProperty("legal_entity[additional_owners][0][last_name]")]
        public string LegalEntityOwnerOneLastName { get; set; }

        [JsonProperty("legal_entity[additional_owners][0][dob][day]")]
        public int? LegalEntityOwnerOneDobDay { get; set; }

        [JsonProperty("legal_entity[additional_owners][0][dob][month]")]
        public int? LegalEntityOwnerOneDobMonth { get; set; }

        [JsonProperty("legal_entity[additional_owners][0][dob][year]")]
        public int? LegalEntityOwnerOneDobYear { get; set; }

        [JsonProperty("legal_entity[additional_owners][0][address][line1]")]
        public string LegalEntityOwnerOneAddressLine1 { get; set; }

        [JsonProperty("legal_entity[additional_owners][0][address][line2]")]
        public string LegalEntityOwnerOneAddressLine2 { get; set; }

        [JsonProperty("legal_entity[additional_owners][0][address][city]")]
        public string LegalEntityOwnerOneAddressCity { get; set; }

        [JsonProperty("legal_entity[additional_owners][0][address][state]")]
        public string LegalEntityOwnerOneAddressState { get; set; }

        [JsonProperty("legal_entity[additional_owners][0][address][postal_code]")]
        public string LegalEntityOwnerOneAddressPostalCode { get; set; }

        [JsonProperty("legal_entity[additional_owners][0][address][country]")]
        public string LegalEntityOwnerOneAddressCountry { get; set; }
        
        [JsonProperty("legal_entity[additional_owners][0][verification][document]")]
        public string LegalEntityOwnerOneVerificationDocumentId { get; set; }        

        //Legal Entity - Owner 2
        [JsonProperty("legal_entity[additional_owners][1][first_name]")]
        public string LegalEntityOwnerTwoFirstName { get; set; }

        [JsonProperty("legal_entity[additional_owners][1][last_name]")]
        public string LegalEntityOwnerTwoLastName { get; set; }

        [JsonProperty("legal_entity[additional_owners][1][dob][day]")]
        public int? LegalEntityOwnerTwoDobDay { get; set; }

        [JsonProperty("legal_entity[additional_owners][1][dob][month]")]
        public int? LegalEntityOwnerTwoDobMonth { get; set; }

        [JsonProperty("legal_entity[additional_owners][1][dob][year]")]
        public int? LegalEntityOwnerTwoDobYear { get; set; }

        [JsonProperty("legal_entity[additional_owners][1][address][line1]")]
        public string LegalEntityOwnerTwoAddressLine1 { get; set; }

        [JsonProperty("legal_entity[additional_owners][1][address][line2]")]
        public string LegalEntityOwnerTwoAddressLine2 { get; set; }

        [JsonProperty("legal_entity[additional_owners][1][address][city]")]
        public string LegalEntityOwnerTwoAddressCity { get; set; }

        [JsonProperty("legal_entity[additional_owners][1][address][state]")]
        public string LegalEntityOwnerTwoAddressState { get; set; }

        [JsonProperty("legal_entity[additional_owners][1][address][postal_code]")]
        public string LegalEntityOwnerTwoAddressPostalCode { get; set; }

        [JsonProperty("legal_entity[additional_owners][1][address][country]")]
        public string LegalEntityOwnerTwoAddressCountry { get; set; }
        
        [JsonProperty("legal_entity[additional_owners][1][verification][document]")]
        public string LegalEntityOwnerTwoVerificationDocumentId { get; set; }
        
        //Legal Entity - Owner 3 
        [JsonProperty("legal_entity[additional_owners][2][first_name]")]
        public string LegalEntityOwnerThreeFirstName { get; set; }

        [JsonProperty("legal_entity[additional_owners][2][last_name]")]
        public string LegalEntityOwnerThreeLastName { get; set; }

        [JsonProperty("legal_entity[additional_owners][2][dob][day]")]
        public int? LegalEntityOwnerThreeDobDay { get; set; }

        [JsonProperty("legal_entity[additional_owners][2][dob][month]")]
        public int? LegalEntityOwnerThreeDobMonth { get; set; }

        [JsonProperty("legal_entity[additional_owners][2][dob][year]")]
        public int? LegalEntityOwnerThreeDobYear { get; set; }

        [JsonProperty("legal_entity[additional_owners][2][address][line1]")]
        public string LegalEntityOwnerThreeAddressLine1 { get; set; }

        [JsonProperty("legal_entity[additional_owners][2][address][line2]")]
        public string LegalEntityOwnerThreeAddressLine2 { get; set; }

        [JsonProperty("legal_entity[additional_owners][2][address][city]")]
        public string LegalEntityOwnerThreeAddressCity { get; set; }

        [JsonProperty("legal_entity[additional_owners][2][address][state]")]
        public string LegalEntityOwnerThreeAddressState { get; set; }

        [JsonProperty("legal_entity[additional_owners][2][address][postal_code]")]
        public string LegalEntityOwnerThreeAddressPostalCode { get; set; }

        [JsonProperty("legal_entity[additional_owners][2][address][country]")]
        public string LegalEntityOwnerThreeAddressCountry { get; set; }

        [JsonProperty("legal_entity[additional_owners][2][verification][document]")]
        public string LegalEntityOwnerThreeVerificationDocumentId { get; set; }

        #endregion

        #endregion

        [JsonProperty("product_description")]
        public string ProductDescription { get; set; }

        [JsonProperty("tos_acceptance[date]")]
        public DateTime TosAcceptanceDate { get; set; }

        [JsonProperty("tos_acceptance[ip]")]
        public string TosAcceptanceIp { get; set; }

        [JsonProperty("tos_acceptance[user_agent]")]
        public string TosAcceptanceUserAgent { get; set; }

        [JsonProperty("transfer_schedule[delay_days]")]
        public int? TransferScheduleDelayDays { get; set; }

        [JsonProperty("transfer_schedule[interval]")]
        public string TransferScheduleInterval { get; set; }

        [JsonProperty("transfer_schedule[monthly_anchor]")]
        public int? TransferScheduleMonthlyAnchor { get; set; }

        [JsonProperty("transfer_schedule[weekly_anchor]")]
        public string TransferScheduleWeeklyAnchor { get; set; }

        #endregion
    }
}
