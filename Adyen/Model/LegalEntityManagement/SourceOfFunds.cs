/*
* Legal Entity Management API
*
*
* The version of the OpenAPI document: 3
* 
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
    /// SourceOfFunds
    /// </summary>
    [DataContract(Name = "SourceOfFunds")]
    public partial class SourceOfFunds : IEquatable<SourceOfFunds>, IValidatableObject
    {
        /// <summary>
        /// The type of the source of funds. Possible value: **business**.
        /// </summary>
        /// <value>The type of the source of funds. Possible value: **business**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Business for value: business
            /// </summary>
            [EnumMember(Value = "business")]
            Business = 1

        }


        /// <summary>
        /// The type of the source of funds. Possible value: **business**.
        /// </summary>
        /// <value>The type of the source of funds. Possible value: **business**.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceOfFunds" /> class.
        /// </summary>
        /// <param name="acquiringBusinessLineId">The unique identifier of the business line that will be the source of funds.This must be a business line for a **receivePayments** or **receiveFromPlatformPayments** capability..</param>
        /// <param name="adyenProcessedFunds">Indicates whether the funds are coming from transactions processed by Adyen. If **false**, a &#x60;description&#x60; is required..</param>
        /// <param name="description">Text describing the source of funds. For example, for &#x60;type&#x60; **business**, provide a description of where the business transactions come from, such as payments through bank transfer. Required when &#x60;adyenProcessedFunds&#x60; is **false**..</param>
        /// <param name="type">The type of the source of funds. Possible value: **business**..</param>
        public SourceOfFunds(string acquiringBusinessLineId = default(string), bool adyenProcessedFunds = default(bool), string description = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.AcquiringBusinessLineId = acquiringBusinessLineId;
            this.AdyenProcessedFunds = adyenProcessedFunds;
            this.Description = description;
            this.Type = type;
        }

        /// <summary>
        /// The unique identifier of the business line that will be the source of funds.This must be a business line for a **receivePayments** or **receiveFromPlatformPayments** capability.
        /// </summary>
        /// <value>The unique identifier of the business line that will be the source of funds.This must be a business line for a **receivePayments** or **receiveFromPlatformPayments** capability.</value>
        [DataMember(Name = "acquiringBusinessLineId", EmitDefaultValue = false)]
        [Obsolete]
        public string AcquiringBusinessLineId { get; set; }

        /// <summary>
        /// Indicates whether the funds are coming from transactions processed by Adyen. If **false**, a &#x60;description&#x60; is required.
        /// </summary>
        /// <value>Indicates whether the funds are coming from transactions processed by Adyen. If **false**, a &#x60;description&#x60; is required.</value>
        [DataMember(Name = "adyenProcessedFunds", EmitDefaultValue = false)]
        public bool AdyenProcessedFunds { get; set; }

        /// <summary>
        /// Text describing the source of funds. For example, for &#x60;type&#x60; **business**, provide a description of where the business transactions come from, such as payments through bank transfer. Required when &#x60;adyenProcessedFunds&#x60; is **false**.
        /// </summary>
        /// <value>Text describing the source of funds. For example, for &#x60;type&#x60; **business**, provide a description of where the business transactions come from, such as payments through bank transfer. Required when &#x60;adyenProcessedFunds&#x60; is **false**.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SourceOfFunds {\n");
            sb.Append("  AcquiringBusinessLineId: ").Append(AcquiringBusinessLineId).Append("\n");
            sb.Append("  AdyenProcessedFunds: ").Append(AdyenProcessedFunds).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as SourceOfFunds);
        }

        /// <summary>
        /// Returns true if SourceOfFunds instances are equal
        /// </summary>
        /// <param name="input">Instance of SourceOfFunds to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SourceOfFunds input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AcquiringBusinessLineId == input.AcquiringBusinessLineId ||
                    (this.AcquiringBusinessLineId != null &&
                    this.AcquiringBusinessLineId.Equals(input.AcquiringBusinessLineId))
                ) && 
                (
                    this.AdyenProcessedFunds == input.AdyenProcessedFunds ||
                    this.AdyenProcessedFunds.Equals(input.AdyenProcessedFunds)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.AcquiringBusinessLineId != null)
                {
                    hashCode = (hashCode * 59) + this.AcquiringBusinessLineId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AdyenProcessedFunds.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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