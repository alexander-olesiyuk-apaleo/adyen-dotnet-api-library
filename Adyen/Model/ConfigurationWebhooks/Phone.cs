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
    /// Phone
    /// </summary>
    [DataContract(Name = "Phone")]
    public partial class Phone : IEquatable<Phone>, IValidatableObject
    {
        /// <summary>
        /// Type of phone number. Possible values:  **Landline**, **Mobile**. 
        /// </summary>
        /// <value>Type of phone number. Possible values:  **Landline**, **Mobile**. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Landline for value: landline
            /// </summary>
            [EnumMember(Value = "landline")]
            Landline = 1,

            /// <summary>
            /// Enum Mobile for value: mobile
            /// </summary>
            [EnumMember(Value = "mobile")]
            Mobile = 2

        }


        /// <summary>
        /// Type of phone number. Possible values:  **Landline**, **Mobile**. 
        /// </summary>
        /// <value>Type of phone number. Possible values:  **Landline**, **Mobile**. </value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Phone" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Phone() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Phone" /> class.
        /// </summary>
        /// <param name="number">The full phone number provided as a single string.  For example, **\&quot;0031 6 11 22 33 44\&quot;**, **\&quot;+316/1122-3344\&quot;**,    or **\&quot;(0031) 611223344\&quot;**. (required).</param>
        /// <param name="type">Type of phone number. Possible values:  **Landline**, **Mobile**.  (required).</param>
        public Phone(string number = default(string), TypeEnum type = default(TypeEnum))
        {
            this.Number = number;
            this.Type = type;
        }

        /// <summary>
        /// The full phone number provided as a single string.  For example, **\&quot;0031 6 11 22 33 44\&quot;**, **\&quot;+316/1122-3344\&quot;**,    or **\&quot;(0031) 611223344\&quot;**.
        /// </summary>
        /// <value>The full phone number provided as a single string.  For example, **\&quot;0031 6 11 22 33 44\&quot;**, **\&quot;+316/1122-3344\&quot;**,    or **\&quot;(0031) 611223344\&quot;**.</value>
        [DataMember(Name = "number", IsRequired = false, EmitDefaultValue = false)]
        public string Number { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Phone {\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
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
            return this.Equals(input as Phone);
        }

        /// <summary>
        /// Returns true if Phone instances are equal
        /// </summary>
        /// <param name="input">Instance of Phone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Phone input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
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
                if (this.Number != null)
                {
                    hashCode = (hashCode * 59) + this.Number.GetHashCode();
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
