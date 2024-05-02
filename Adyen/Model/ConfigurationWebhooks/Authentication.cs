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
    /// Authentication
    /// </summary>
    [DataContract(Name = "Authentication")]
    public partial class Authentication : IEquatable<Authentication>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Authentication" /> class.
        /// </summary>
        /// <param name="email">The email address where the one-time password (OTP) is sent..</param>
        /// <param name="password">The password used for 3D Secure password-based authentication. The value must be between 1 to 30 characters and must only contain the following supported characters.  * Characters between **a-z**, **A-Z**, and **0-9**  * Special characters: **äöüßÄÖÜ+-*_/ç%()&#x3D;?!~#&#39;\&quot;,;:$&amp;àùòâôûáúó**.</param>
        /// <param name="phone">phone.</param>
        public Authentication(string email = default(string), string password = default(string), Phone phone = default(Phone))
        {
            this.Email = email;
            this.Password = password;
            this.Phone = phone;
        }

        /// <summary>
        /// The email address where the one-time password (OTP) is sent.
        /// </summary>
        /// <value>The email address where the one-time password (OTP) is sent.</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// The password used for 3D Secure password-based authentication. The value must be between 1 to 30 characters and must only contain the following supported characters.  * Characters between **a-z**, **A-Z**, and **0-9**  * Special characters: **äöüßÄÖÜ+-*_/ç%()&#x3D;?!~#&#39;\&quot;,;:$&amp;àùòâôûáúó**
        /// </summary>
        /// <value>The password used for 3D Secure password-based authentication. The value must be between 1 to 30 characters and must only contain the following supported characters.  * Characters between **a-z**, **A-Z**, and **0-9**  * Special characters: **äöüßÄÖÜ+-*_/ç%()&#x3D;?!~#&#39;\&quot;,;:$&amp;àùòâôûáúó**</value>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public Phone Phone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Authentication {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
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
            return this.Equals(input as Authentication);
        }

        /// <summary>
        /// Returns true if Authentication instances are equal
        /// </summary>
        /// <param name="input">Instance of Authentication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Authentication input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
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
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
                }
                if (this.Phone != null)
                {
                    hashCode = (hashCode * 59) + this.Phone.GetHashCode();
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
            // Password (string) maxLength
            if (this.Password != null && this.Password.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Password, length must be less than 30.", new [] { "Password" });
            }

            // Password (string) minLength
            if (this.Password != null && this.Password.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Password, length must be greater than 1.", new [] { "Password" });
            }

            yield break;
        }
    }

}
