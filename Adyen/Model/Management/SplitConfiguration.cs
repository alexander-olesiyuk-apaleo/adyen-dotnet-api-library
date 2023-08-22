/*
* Management API
*
*
* The version of the OpenAPI document: 1
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

namespace Adyen.Model.Management
{
    /// <summary>
    /// SplitConfiguration
    /// </summary>
    [DataContract(Name = "SplitConfiguration")]
    public partial class SplitConfiguration : IEquatable<SplitConfiguration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SplitConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SplitConfiguration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SplitConfiguration" /> class.
        /// </summary>
        /// <param name="description">Your description for the split configuration. (required).</param>
        /// <param name="rules">Array of rules that define the split configuration behavior. (required).</param>
        public SplitConfiguration(string description = default(string), List<SplitConfigurationRule> rules = default(List<SplitConfigurationRule>))
        {
            this.Description = description;
            this.Rules = rules;
        }

        /// <summary>
        /// Your description for the split configuration.
        /// </summary>
        /// <value>Your description for the split configuration.</value>
        [DataMember(Name = "description", IsRequired = false, EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Array of rules that define the split configuration behavior.
        /// </summary>
        /// <value>Array of rules that define the split configuration behavior.</value>
        [DataMember(Name = "rules", IsRequired = false, EmitDefaultValue = false)]
        public List<SplitConfigurationRule> Rules { get; set; }

        /// <summary>
        /// Unique identifier of the split configuration.
        /// </summary>
        /// <value>Unique identifier of the split configuration.</value>
        [DataMember(Name = "splitConfigurationId", EmitDefaultValue = false)]
        public string SplitConfigurationId { get; private set; }

        /// <summary>
        /// List of stores to which the split configuration applies.
        /// </summary>
        /// <value>List of stores to which the split configuration applies.</value>
        [DataMember(Name = "stores", EmitDefaultValue = false)]
        public List<string> Stores { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SplitConfiguration {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Rules: ").Append(Rules).Append("\n");
            sb.Append("  SplitConfigurationId: ").Append(SplitConfigurationId).Append("\n");
            sb.Append("  Stores: ").Append(Stores).Append("\n");
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
            return this.Equals(input as SplitConfiguration);
        }

        /// <summary>
        /// Returns true if SplitConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of SplitConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SplitConfiguration input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Rules == input.Rules ||
                    this.Rules != null &&
                    input.Rules != null &&
                    this.Rules.SequenceEqual(input.Rules)
                ) && 
                (
                    this.SplitConfigurationId == input.SplitConfigurationId ||
                    (this.SplitConfigurationId != null &&
                    this.SplitConfigurationId.Equals(input.SplitConfigurationId))
                ) && 
                (
                    this.Stores == input.Stores ||
                    this.Stores != null &&
                    input.Stores != null &&
                    this.Stores.SequenceEqual(input.Stores)
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Rules != null)
                {
                    hashCode = (hashCode * 59) + this.Rules.GetHashCode();
                }
                if (this.SplitConfigurationId != null)
                {
                    hashCode = (hashCode * 59) + this.SplitConfigurationId.GetHashCode();
                }
                if (this.Stores != null)
                {
                    hashCode = (hashCode * 59) + this.Stores.GetHashCode();
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
            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 300)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 300.", new [] { "Description" });
            }

            yield break;
        }
    }

}