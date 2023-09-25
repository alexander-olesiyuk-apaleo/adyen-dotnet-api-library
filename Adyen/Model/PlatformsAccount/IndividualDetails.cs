/*
* Account API
*
*
* The version of the OpenAPI document: 6
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

namespace Adyen.Model.PlatformsAccount
{
    /// <summary>
    /// IndividualDetails
    /// </summary>
    [DataContract(Name = "IndividualDetails")]
    public partial class IndividualDetails : IEquatable<IndividualDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndividualDetails" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="personalData">personalData.</param>
        public IndividualDetails(ViasName name = default(ViasName), ViasPersonalData personalData = default(ViasPersonalData))
        {
            this.Name = name;
            this.PersonalData = personalData;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public ViasName Name { get; set; }

        /// <summary>
        /// Gets or Sets PersonalData
        /// </summary>
        [DataMember(Name = "personalData", EmitDefaultValue = false)]
        public ViasPersonalData PersonalData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IndividualDetails {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PersonalData: ").Append(PersonalData).Append("\n");
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
            return this.Equals(input as IndividualDetails);
        }

        /// <summary>
        /// Returns true if IndividualDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of IndividualDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IndividualDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PersonalData == input.PersonalData ||
                    (this.PersonalData != null &&
                    this.PersonalData.Equals(input.PersonalData))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.PersonalData != null)
                {
                    hashCode = (hashCode * 59) + this.PersonalData.GetHashCode();
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
