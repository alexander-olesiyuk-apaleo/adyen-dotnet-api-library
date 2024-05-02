/*
* Configuration webhooks
*
*
* The version of the OpenAPI document: 2
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

namespace Adyen.Model.ConfigurationWebhooks
{
    /// <summary>
    /// CapabilityProblem
    /// </summary>
    [DataContract(Name = "CapabilityProblem")]
    public partial class CapabilityProblem : IEquatable<CapabilityProblem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CapabilityProblem" /> class.
        /// </summary>
        /// <param name="entity">entity.</param>
        /// <param name="verificationErrors">Contains information about the verification error..</param>
        public CapabilityProblem(CapabilityProblemEntity entity = default(CapabilityProblemEntity), List<VerificationError> verificationErrors = default(List<VerificationError>))
        {
            this.Entity = entity;
            this.VerificationErrors = verificationErrors;
        }

        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name = "entity", EmitDefaultValue = false)]
        public CapabilityProblemEntity Entity { get; set; }

        /// <summary>
        /// Contains information about the verification error.
        /// </summary>
        /// <value>Contains information about the verification error.</value>
        [DataMember(Name = "verificationErrors", EmitDefaultValue = false)]
        public List<VerificationError> VerificationErrors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CapabilityProblem {\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  VerificationErrors: ").Append(VerificationErrors).Append("\n");
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
            return this.Equals(input as CapabilityProblem);
        }

        /// <summary>
        /// Returns true if CapabilityProblem instances are equal
        /// </summary>
        /// <param name="input">Instance of CapabilityProblem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CapabilityProblem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Entity == input.Entity ||
                    (this.Entity != null &&
                    this.Entity.Equals(input.Entity))
                ) && 
                (
                    this.VerificationErrors == input.VerificationErrors ||
                    this.VerificationErrors != null &&
                    input.VerificationErrors != null &&
                    this.VerificationErrors.SequenceEqual(input.VerificationErrors)
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
                if (this.Entity != null)
                {
                    hashCode = (hashCode * 59) + this.Entity.GetHashCode();
                }
                if (this.VerificationErrors != null)
                {
                    hashCode = (hashCode * 59) + this.VerificationErrors.GetHashCode();
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
