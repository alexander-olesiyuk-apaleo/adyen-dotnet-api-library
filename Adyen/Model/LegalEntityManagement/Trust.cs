/*
* Legal Entity Management API
*
*
* The version of the OpenAPI document: 3
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Adyen.ApiSerialization.OpenAPIDateConverter;

namespace Adyen.Model.LegalEntityManagement
{
    /// <summary>
    /// Trust
    /// </summary>
    [DataContract(Name = "Trust")]
    public partial class Trust : IEquatable<Trust>, IValidatableObject
    {
        /// <summary>
        /// Type of trust.  See possible values for trusts in [Australia](https://docs.adyen.com/platforms/verification-requirements/?tab&#x3D;trust_3_4#trust-types-in-australia) and [New Zealand](https://docs.adyen.com/platforms/verification-requirements/?tab&#x3D;trust_3_4#trust-types-in-new-zealand).
        /// </summary>
        /// <value>Type of trust.  See possible values for trusts in [Australia](https://docs.adyen.com/platforms/verification-requirements/?tab&#x3D;trust_3_4#trust-types-in-australia) and [New Zealand](https://docs.adyen.com/platforms/verification-requirements/?tab&#x3D;trust_3_4#trust-types-in-new-zealand).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum BusinessTrust for value: businessTrust
            /// </summary>
            [EnumMember(Value = "businessTrust")]
            BusinessTrust = 1,

            /// <summary>
            /// Enum CashManagementTrust for value: cashManagementTrust
            /// </summary>
            [EnumMember(Value = "cashManagementTrust")]
            CashManagementTrust = 2,

            /// <summary>
            /// Enum CharitableTrust for value: charitableTrust
            /// </summary>
            [EnumMember(Value = "charitableTrust")]
            CharitableTrust = 3,

            /// <summary>
            /// Enum CorporateUnitTrust for value: corporateUnitTrust
            /// </summary>
            [EnumMember(Value = "corporateUnitTrust")]
            CorporateUnitTrust = 4,

            /// <summary>
            /// Enum DeceasedEstate for value: deceasedEstate
            /// </summary>
            [EnumMember(Value = "deceasedEstate")]
            DeceasedEstate = 5,

            /// <summary>
            /// Enum DiscretionaryTrust for value: discretionaryTrust
            /// </summary>
            [EnumMember(Value = "discretionaryTrust")]
            DiscretionaryTrust = 6,

            /// <summary>
            /// Enum DiscretionaryInvestmentTrust for value: discretionaryInvestmentTrust
            /// </summary>
            [EnumMember(Value = "discretionaryInvestmentTrust")]
            DiscretionaryInvestmentTrust = 7,

            /// <summary>
            /// Enum DiscretionaryServicesManagementTrust for value: discretionaryServicesManagementTrust
            /// </summary>
            [EnumMember(Value = "discretionaryServicesManagementTrust")]
            DiscretionaryServicesManagementTrust = 8,

            /// <summary>
            /// Enum DiscretionaryTradingTrust for value: discretionaryTradingTrust
            /// </summary>
            [EnumMember(Value = "discretionaryTradingTrust")]
            DiscretionaryTradingTrust = 9,

            /// <summary>
            /// Enum FamilyTrust for value: familyTrust
            /// </summary>
            [EnumMember(Value = "familyTrust")]
            FamilyTrust = 10,

            /// <summary>
            /// Enum FirstHomeSaverAccountsTrust for value: firstHomeSaverAccountsTrust
            /// </summary>
            [EnumMember(Value = "firstHomeSaverAccountsTrust")]
            FirstHomeSaverAccountsTrust = 11,

            /// <summary>
            /// Enum FixedTrust for value: fixedTrust
            /// </summary>
            [EnumMember(Value = "fixedTrust")]
            FixedTrust = 12,

            /// <summary>
            /// Enum FixedUnitTrust for value: fixedUnitTrust
            /// </summary>
            [EnumMember(Value = "fixedUnitTrust")]
            FixedUnitTrust = 13,

            /// <summary>
            /// Enum HybridTrust for value: hybridTrust
            /// </summary>
            [EnumMember(Value = "hybridTrust")]
            HybridTrust = 14,

            /// <summary>
            /// Enum ListedPublicUnitTrust for value: listedPublicUnitTrust
            /// </summary>
            [EnumMember(Value = "listedPublicUnitTrust")]
            ListedPublicUnitTrust = 15,

            /// <summary>
            /// Enum OtherTrust for value: otherTrust
            /// </summary>
            [EnumMember(Value = "otherTrust")]
            OtherTrust = 16,

            /// <summary>
            /// Enum PooledSuperannuationTrust for value: pooledSuperannuationTrust
            /// </summary>
            [EnumMember(Value = "pooledSuperannuationTrust")]
            PooledSuperannuationTrust = 17,

            /// <summary>
            /// Enum PublicTradingTrust for value: publicTradingTrust
            /// </summary>
            [EnumMember(Value = "publicTradingTrust")]
            PublicTradingTrust = 18,

            /// <summary>
            /// Enum UnlistedPublicUnitTrust for value: unlistedPublicUnitTrust
            /// </summary>
            [EnumMember(Value = "unlistedPublicUnitTrust")]
            UnlistedPublicUnitTrust = 19

        }


        /// <summary>
        /// Type of trust.  See possible values for trusts in [Australia](https://docs.adyen.com/platforms/verification-requirements/?tab&#x3D;trust_3_4#trust-types-in-australia) and [New Zealand](https://docs.adyen.com/platforms/verification-requirements/?tab&#x3D;trust_3_4#trust-types-in-new-zealand).
        /// </summary>
        /// <value>Type of trust.  See possible values for trusts in [Australia](https://docs.adyen.com/platforms/verification-requirements/?tab&#x3D;trust_3_4#trust-types-in-australia) and [New Zealand](https://docs.adyen.com/platforms/verification-requirements/?tab&#x3D;trust_3_4#trust-types-in-new-zealand).</value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// The reason for not providing a VAT number.  Possible values: **industryExemption**, **belowTaxThreshold**.
        /// </summary>
        /// <value>The reason for not providing a VAT number.  Possible values: **industryExemption**, **belowTaxThreshold**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VatAbsenceReasonEnum
        {
            /// <summary>
            /// Enum IndustryExemption for value: industryExemption
            /// </summary>
            [EnumMember(Value = "industryExemption")]
            IndustryExemption = 1,

            /// <summary>
            /// Enum BelowTaxThreshold for value: belowTaxThreshold
            /// </summary>
            [EnumMember(Value = "belowTaxThreshold")]
            BelowTaxThreshold = 2

        }


        /// <summary>
        /// The reason for not providing a VAT number.  Possible values: **industryExemption**, **belowTaxThreshold**.
        /// </summary>
        /// <value>The reason for not providing a VAT number.  Possible values: **industryExemption**, **belowTaxThreshold**.</value>
        [DataMember(Name = "vatAbsenceReason", EmitDefaultValue = false)]
        public VatAbsenceReasonEnum? VatAbsenceReason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Trust" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Trust() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Trust" /> class.
        /// </summary>
        /// <param name="countryOfGoverningLaw">The two-character [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code of the governing country. (required).</param>
        /// <param name="dateOfIncorporation">The date when the legal arrangement was incorporated in YYYY-MM-DD format..</param>
        /// <param name="description">A short description about the trust. Only applicable for charitable trusts in New Zealand..</param>
        /// <param name="doingBusinessAs">The registered name, if different from the &#x60;name&#x60;..</param>
        /// <param name="name">The legal name. (required).</param>
        /// <param name="principalPlaceOfBusiness">principalPlaceOfBusiness.</param>
        /// <param name="registeredAddress">registeredAddress (required).</param>
        /// <param name="registrationNumber">The registration number..</param>
        /// <param name="taxInformation">The tax information of the entity..</param>
        /// <param name="type">Type of trust.  See possible values for trusts in [Australia](https://docs.adyen.com/platforms/verification-requirements/?tab&#x3D;trust_3_4#trust-types-in-australia) and [New Zealand](https://docs.adyen.com/platforms/verification-requirements/?tab&#x3D;trust_3_4#trust-types-in-new-zealand). (required).</param>
        /// <param name="undefinedBeneficiaryInfo">The undefined beneficiary information of the entity..</param>
        /// <param name="vatAbsenceReason">The reason for not providing a VAT number.  Possible values: **industryExemption**, **belowTaxThreshold**..</param>
        /// <param name="vatNumber">The VAT number..</param>
        public Trust(string countryOfGoverningLaw = default(string), string dateOfIncorporation = default(string), string description = default(string), string doingBusinessAs = default(string), string name = default(string), Address principalPlaceOfBusiness = default(Address), Address registeredAddress = default(Address), string registrationNumber = default(string), List<TaxInformation> taxInformation = default(List<TaxInformation>), TypeEnum type = default(TypeEnum), List<UndefinedBeneficiary> undefinedBeneficiaryInfo = default(List<UndefinedBeneficiary>), VatAbsenceReasonEnum? vatAbsenceReason = default(VatAbsenceReasonEnum?), string vatNumber = default(string))
        {
            this.CountryOfGoverningLaw = countryOfGoverningLaw;
            this.Name = name;
            this.RegisteredAddress = registeredAddress;
            this.Type = type;
            this.DateOfIncorporation = dateOfIncorporation;
            this.Description = description;
            this.DoingBusinessAs = doingBusinessAs;
            this.PrincipalPlaceOfBusiness = principalPlaceOfBusiness;
            this.RegistrationNumber = registrationNumber;
            this.TaxInformation = taxInformation;
            this.UndefinedBeneficiaryInfo = undefinedBeneficiaryInfo;
            this.VatAbsenceReason = vatAbsenceReason;
            this.VatNumber = vatNumber;
        }

        /// <summary>
        /// The two-character [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code of the governing country.
        /// </summary>
        /// <value>The two-character [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code of the governing country.</value>
        [DataMember(Name = "countryOfGoverningLaw", IsRequired = false, EmitDefaultValue = false)]
        public string CountryOfGoverningLaw { get; set; }

        /// <summary>
        /// The date when the legal arrangement was incorporated in YYYY-MM-DD format.
        /// </summary>
        /// <value>The date when the legal arrangement was incorporated in YYYY-MM-DD format.</value>
        [DataMember(Name = "dateOfIncorporation", EmitDefaultValue = false)]
        public string DateOfIncorporation { get; set; }

        /// <summary>
        /// A short description about the trust. Only applicable for charitable trusts in New Zealand.
        /// </summary>
        /// <value>A short description about the trust. Only applicable for charitable trusts in New Zealand.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The registered name, if different from the &#x60;name&#x60;.
        /// </summary>
        /// <value>The registered name, if different from the &#x60;name&#x60;.</value>
        [DataMember(Name = "doingBusinessAs", EmitDefaultValue = false)]
        public string DoingBusinessAs { get; set; }

        /// <summary>
        /// The legal name.
        /// </summary>
        /// <value>The legal name.</value>
        [DataMember(Name = "name", IsRequired = false, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets PrincipalPlaceOfBusiness
        /// </summary>
        [DataMember(Name = "principalPlaceOfBusiness", EmitDefaultValue = false)]
        public Address PrincipalPlaceOfBusiness { get; set; }

        /// <summary>
        /// Gets or Sets RegisteredAddress
        /// </summary>
        [DataMember(Name = "registeredAddress", IsRequired = false, EmitDefaultValue = false)]
        public Address RegisteredAddress { get; set; }

        /// <summary>
        /// The registration number.
        /// </summary>
        /// <value>The registration number.</value>
        [DataMember(Name = "registrationNumber", EmitDefaultValue = false)]
        public string RegistrationNumber { get; set; }

        /// <summary>
        /// The tax information of the entity.
        /// </summary>
        /// <value>The tax information of the entity.</value>
        [DataMember(Name = "taxInformation", EmitDefaultValue = false)]
        public List<TaxInformation> TaxInformation { get; set; }

        /// <summary>
        /// The undefined beneficiary information of the entity.
        /// </summary>
        /// <value>The undefined beneficiary information of the entity.</value>
        [DataMember(Name = "undefinedBeneficiaryInfo", EmitDefaultValue = false)]
        public List<UndefinedBeneficiary> UndefinedBeneficiaryInfo { get; set; }

        /// <summary>
        /// The VAT number.
        /// </summary>
        /// <value>The VAT number.</value>
        [DataMember(Name = "vatNumber", EmitDefaultValue = false)]
        public string VatNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Trust {\n");
            sb.Append("  CountryOfGoverningLaw: ").Append(CountryOfGoverningLaw).Append("\n");
            sb.Append("  DateOfIncorporation: ").Append(DateOfIncorporation).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DoingBusinessAs: ").Append(DoingBusinessAs).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PrincipalPlaceOfBusiness: ").Append(PrincipalPlaceOfBusiness).Append("\n");
            sb.Append("  RegisteredAddress: ").Append(RegisteredAddress).Append("\n");
            sb.Append("  RegistrationNumber: ").Append(RegistrationNumber).Append("\n");
            sb.Append("  TaxInformation: ").Append(TaxInformation).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UndefinedBeneficiaryInfo: ").Append(UndefinedBeneficiaryInfo).Append("\n");
            sb.Append("  VatAbsenceReason: ").Append(VatAbsenceReason).Append("\n");
            sb.Append("  VatNumber: ").Append(VatNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Trust);
        }

        /// <summary>
        /// Returns true if Trust instances are equal
        /// </summary>
        /// <param name="input">Instance of Trust to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Trust input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CountryOfGoverningLaw == input.CountryOfGoverningLaw ||
                    (this.CountryOfGoverningLaw != null &&
                    this.CountryOfGoverningLaw.Equals(input.CountryOfGoverningLaw))
                ) && 
                (
                    this.DateOfIncorporation == input.DateOfIncorporation ||
                    (this.DateOfIncorporation != null &&
                    this.DateOfIncorporation.Equals(input.DateOfIncorporation))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DoingBusinessAs == input.DoingBusinessAs ||
                    (this.DoingBusinessAs != null &&
                    this.DoingBusinessAs.Equals(input.DoingBusinessAs))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PrincipalPlaceOfBusiness == input.PrincipalPlaceOfBusiness ||
                    (this.PrincipalPlaceOfBusiness != null &&
                    this.PrincipalPlaceOfBusiness.Equals(input.PrincipalPlaceOfBusiness))
                ) && 
                (
                    this.RegisteredAddress == input.RegisteredAddress ||
                    (this.RegisteredAddress != null &&
                    this.RegisteredAddress.Equals(input.RegisteredAddress))
                ) && 
                (
                    this.RegistrationNumber == input.RegistrationNumber ||
                    (this.RegistrationNumber != null &&
                    this.RegistrationNumber.Equals(input.RegistrationNumber))
                ) && 
                (
                    this.TaxInformation == input.TaxInformation ||
                    this.TaxInformation != null &&
                    input.TaxInformation != null &&
                    this.TaxInformation.SequenceEqual(input.TaxInformation)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.UndefinedBeneficiaryInfo == input.UndefinedBeneficiaryInfo ||
                    this.UndefinedBeneficiaryInfo != null &&
                    input.UndefinedBeneficiaryInfo != null &&
                    this.UndefinedBeneficiaryInfo.SequenceEqual(input.UndefinedBeneficiaryInfo)
                ) && 
                (
                    this.VatAbsenceReason == input.VatAbsenceReason ||
                    this.VatAbsenceReason.Equals(input.VatAbsenceReason)
                ) && 
                (
                    this.VatNumber == input.VatNumber ||
                    (this.VatNumber != null &&
                    this.VatNumber.Equals(input.VatNumber))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.CountryOfGoverningLaw != null)
                {
                    hashCode = (hashCode * 59) + this.CountryOfGoverningLaw.GetHashCode();
                }
                if (this.DateOfIncorporation != null)
                {
                    hashCode = (hashCode * 59) + this.DateOfIncorporation.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.DoingBusinessAs != null)
                {
                    hashCode = (hashCode * 59) + this.DoingBusinessAs.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.PrincipalPlaceOfBusiness != null)
                {
                    hashCode = (hashCode * 59) + this.PrincipalPlaceOfBusiness.GetHashCode();
                }
                if (this.RegisteredAddress != null)
                {
                    hashCode = (hashCode * 59) + this.RegisteredAddress.GetHashCode();
                }
                if (this.RegistrationNumber != null)
                {
                    hashCode = (hashCode * 59) + this.RegistrationNumber.GetHashCode();
                }
                if (this.TaxInformation != null)
                {
                    hashCode = (hashCode * 59) + this.TaxInformation.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.UndefinedBeneficiaryInfo != null)
                {
                    hashCode = (hashCode * 59) + this.UndefinedBeneficiaryInfo.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VatAbsenceReason.GetHashCode();
                if (this.VatNumber != null)
                {
                    hashCode = (hashCode * 59) + this.VatNumber.GetHashCode();
                }
                return hashCode;
            }
        }
        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
