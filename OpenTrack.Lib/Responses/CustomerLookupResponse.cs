//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.17929.
// 
namespace OpenTrack.Responses {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class CustomerLookupResponse {
        
        private CustomerLookupResponseCustomer[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Customer", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CustomerLookupResponseCustomer[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class CustomerLookupResponseCustomer {
        
        private string companyNumberField;
        
        private string customerNumberField;
        
        private string typeCodeField;
        
        private string lastNameField;
        
        private string firstNameField;
        
        private string middleNameField;
        
        private string salutationField;
        
        private string genderField;
        
        private string languageField;
        
        private string address1Field;
        
        private string address2Field;
        
        private string address3Field;
        
        private string cityField;
        
        private string countyField;
        
        private string stateCodeField;
        
        private string zipCodeField;
        
        private string phoneNumberField;
        
        private string businessPhoneField;
        
        private string businessExtField;
        
        private string faxNumberField;
        
        private string birthDateField;
        
        private string driversLicenseField;
        
        private string contactField;
        
        private string preferredContactField;
        
        private string mailCodeField;
        
        private string taxExmptNumberField;
        
        private string assignedSalespersonField;
        
        private string customerTypeField;
        
        private string preferredPhoneField;
        
        private string cellPhoneField;
        
        private string pagePhoneField;
        
        private string otherPhoneField;
        
        private string otherPhoneDescField;
        
        private string email1Field;
        
        private string email2Field;
        
        private string optionalFieldField;
        
        private string allowContactByPostalField;
        
        private string allowContactByPhoneField;
        
        private string allowContactByEmailField;
        
        private string businessPhoneExtensionField;
        
        private string internationalBusinessPhoneField;
        
        private string internationalCellPhoneField;
        
        private string externalCrossReferenceKeyField;
        
        private string internationalFaxNumberField;
        
        private string internationalOtherPhoneField;
        
        private string internationalHomePhoneField;
        
        private string customerPreferredNameField;
        
        private string internationalPagerPhoneField;
        
        private string preferredLanguageField;
        
        private string internationalZipCodeField;
        
        private string lastChangeDateField;
        
        private CustomerLookupResponseCustomerVehiclesVIN[] vehiclesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CompanyNumber {
            get {
                return this.companyNumberField;
            }
            set {
                this.companyNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CustomerNumber {
            get {
                return this.customerNumberField;
            }
            set {
                this.customerNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TypeCode {
            get {
                return this.typeCodeField;
            }
            set {
                this.typeCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LastName {
            get {
                return this.lastNameField;
            }
            set {
                this.lastNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FirstName {
            get {
                return this.firstNameField;
            }
            set {
                this.firstNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MiddleName {
            get {
                return this.middleNameField;
            }
            set {
                this.middleNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Salutation {
            get {
                return this.salutationField;
            }
            set {
                this.salutationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Gender {
            get {
                return this.genderField;
            }
            set {
                this.genderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Address1 {
            get {
                return this.address1Field;
            }
            set {
                this.address1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Address2 {
            get {
                return this.address2Field;
            }
            set {
                this.address2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Address3 {
            get {
                return this.address3Field;
            }
            set {
                this.address3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string City {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string County {
            get {
                return this.countyField;
            }
            set {
                this.countyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string StateCode {
            get {
                return this.stateCodeField;
            }
            set {
                this.stateCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ZipCode {
            get {
                return this.zipCodeField;
            }
            set {
                this.zipCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PhoneNumber {
            get {
                return this.phoneNumberField;
            }
            set {
                this.phoneNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BusinessPhone {
            get {
                return this.businessPhoneField;
            }
            set {
                this.businessPhoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BusinessExt {
            get {
                return this.businessExtField;
            }
            set {
                this.businessExtField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FaxNumber {
            get {
                return this.faxNumberField;
            }
            set {
                this.faxNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BirthDate {
            get {
                return this.birthDateField;
            }
            set {
                this.birthDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DriversLicense {
            get {
                return this.driversLicenseField;
            }
            set {
                this.driversLicenseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Contact {
            get {
                return this.contactField;
            }
            set {
                this.contactField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PreferredContact {
            get {
                return this.preferredContactField;
            }
            set {
                this.preferredContactField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MailCode {
            get {
                return this.mailCodeField;
            }
            set {
                this.mailCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TaxExmptNumber {
            get {
                return this.taxExmptNumberField;
            }
            set {
                this.taxExmptNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AssignedSalesperson {
            get {
                return this.assignedSalespersonField;
            }
            set {
                this.assignedSalespersonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CustomerType {
            get {
                return this.customerTypeField;
            }
            set {
                this.customerTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PreferredPhone {
            get {
                return this.preferredPhoneField;
            }
            set {
                this.preferredPhoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CellPhone {
            get {
                return this.cellPhoneField;
            }
            set {
                this.cellPhoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PagePhone {
            get {
                return this.pagePhoneField;
            }
            set {
                this.pagePhoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OtherPhone {
            get {
                return this.otherPhoneField;
            }
            set {
                this.otherPhoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OtherPhoneDesc {
            get {
                return this.otherPhoneDescField;
            }
            set {
                this.otherPhoneDescField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Email1 {
            get {
                return this.email1Field;
            }
            set {
                this.email1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Email2 {
            get {
                return this.email2Field;
            }
            set {
                this.email2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OptionalField {
            get {
                return this.optionalFieldField;
            }
            set {
                this.optionalFieldField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AllowContactByPostal {
            get {
                return this.allowContactByPostalField;
            }
            set {
                this.allowContactByPostalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AllowContactByPhone {
            get {
                return this.allowContactByPhoneField;
            }
            set {
                this.allowContactByPhoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AllowContactByEmail {
            get {
                return this.allowContactByEmailField;
            }
            set {
                this.allowContactByEmailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BusinessPhoneExtension {
            get {
                return this.businessPhoneExtensionField;
            }
            set {
                this.businessPhoneExtensionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string InternationalBusinessPhone {
            get {
                return this.internationalBusinessPhoneField;
            }
            set {
                this.internationalBusinessPhoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string InternationalCellPhone {
            get {
                return this.internationalCellPhoneField;
            }
            set {
                this.internationalCellPhoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ExternalCrossReferenceKey {
            get {
                return this.externalCrossReferenceKeyField;
            }
            set {
                this.externalCrossReferenceKeyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string InternationalFaxNumber {
            get {
                return this.internationalFaxNumberField;
            }
            set {
                this.internationalFaxNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string InternationalOtherPhone {
            get {
                return this.internationalOtherPhoneField;
            }
            set {
                this.internationalOtherPhoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string InternationalHomePhone {
            get {
                return this.internationalHomePhoneField;
            }
            set {
                this.internationalHomePhoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CustomerPreferredName {
            get {
                return this.customerPreferredNameField;
            }
            set {
                this.customerPreferredNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string InternationalPagerPhone {
            get {
                return this.internationalPagerPhoneField;
            }
            set {
                this.internationalPagerPhoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PreferredLanguage {
            get {
                return this.preferredLanguageField;
            }
            set {
                this.preferredLanguageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string InternationalZipCode {
            get {
                return this.internationalZipCodeField;
            }
            set {
                this.internationalZipCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LastChangeDate {
            get {
                return this.lastChangeDateField;
            }
            set {
                this.lastChangeDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("VIN", typeof(CustomerLookupResponseCustomerVehiclesVIN), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CustomerLookupResponseCustomerVehiclesVIN[] Vehicles {
            get {
                return this.vehiclesField;
            }
            set {
                this.vehiclesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class CustomerLookupResponseCustomerVehiclesVIN {
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
}
