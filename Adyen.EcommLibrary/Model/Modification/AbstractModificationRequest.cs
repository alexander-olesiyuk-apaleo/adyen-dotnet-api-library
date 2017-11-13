﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Adyen.EcommLibrary.Model.Modification
{
    [DataContract]
    public class AbstractModificationRequest : IValidatableObject
    {
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        [DataMember(Name = "authorisationCode", EmitDefaultValue = false)]
        public string AuthorisationCode { get; set; }

        [DataMember(Name = "originalReference", EmitDefaultValue = false)]
        public string OriginalReference { get; set; }

        [DataMember(Name = "merchantAccount", EmitDefaultValue = false)]
        public string MerchantAccount { get; set; }

        [DataMember(Name = "additionalData", EmitDefaultValue = false)]
        public string AdditionalData { get; set; }
        
        public override string ToString()
        {
            var sb = new StringBuilder();
           
            sb.Append("  Reference:  ").Append(Reference).Append("\n");
            sb.Append("  OriginalReference: ").Append(OriginalReference).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
            sb.Append("  AuthorisationCode: ").Append(AuthorisationCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            return this.Equals(obj as AbstractModificationRequest);
        }

        /// <summary>
        /// Returns true if ModificationRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ModificationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbstractModificationRequest other)
        {
            if (other == null)
                return false;

            return
                (
                    this.Reference == other.Reference ||
                    this.Reference != null &&
                    this.Reference.Equals(other.Reference)
                ) &&
                (
                    this.OriginalReference == other.OriginalReference ||
                    this.OriginalReference != null &&
                    this.OriginalReference.Equals(other.OriginalReference)
                ) &&
                (
                    this.MerchantAccount == other.MerchantAccount ||
                    this.MerchantAccount != null &&
                    this.MerchantAccount.Equals(other.MerchantAccount)
                ) &&
                (
                    this.AuthorisationCode == other.AuthorisationCode ||
                    this.AuthorisationCode != null &&
                    this.AuthorisationCode.Equals(other.AuthorisationCode)
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
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Reference != null)
                    hash = hash * 59 + this.Reference.GetHashCode();
                if (this.OriginalReference != null)
                    hash = hash * 59 + this.OriginalReference.GetHashCode();
                if (this.AuthorisationCode != null)
                    hash = hash * 59 + this.AuthorisationCode.GetHashCode();
                if (this.MerchantAccount != null)
                    hash = hash * 59 + this.MerchantAccount.GetHashCode();
                if (this.AdditionalData != null)
                    hash = hash * 59 + this.AdditionalData.GetHashCode();
                if (this.AuthorisationCode != null)
                    hash = hash * 59 + this.AuthorisationCode.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
