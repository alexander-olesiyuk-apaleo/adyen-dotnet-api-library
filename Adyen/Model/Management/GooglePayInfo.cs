/*
* Management API
*
*
* The version of the OpenAPI document: 1
* Contact: developer-experience@adyen.com
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
    /// GooglePayInfo
    /// </summary>
    [DataContract(Name = "GooglePayInfo")]
    public partial class GooglePayInfo : IEquatable<GooglePayInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooglePayInfo" /> class.
        /// </summary>
        /// <param name="merchantId">Google Pay [Merchant ID](https://support.google.com/paymentscenter/answer/7163092?hl&#x3D;en). Character length and limitations: 16 alphanumeric characters or 20 numeric characters..</param>
        public GooglePayInfo(string merchantId = default(string))
        {
            this.MerchantId = merchantId;
        }

        /// <summary>
        /// Google Pay [Merchant ID](https://support.google.com/paymentscenter/answer/7163092?hl&#x3D;en). Character length and limitations: 16 alphanumeric characters or 20 numeric characters.
        /// </summary>
        /// <value>Google Pay [Merchant ID](https://support.google.com/paymentscenter/answer/7163092?hl&#x3D;en). Character length and limitations: 16 alphanumeric characters or 20 numeric characters.</value>
        [DataMember(Name = "merchantId", EmitDefaultValue = false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GooglePayInfo {\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
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
            return this.Equals(input as GooglePayInfo);
        }

        /// <summary>
        /// Returns true if GooglePayInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of GooglePayInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GooglePayInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
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
                if (this.MerchantId != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantId.GetHashCode();
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
            // MerchantId (string) maxLength
            if (this.MerchantId != null && this.MerchantId.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantId, length must be less than 20.", new [] { "MerchantId" });
            }

            // MerchantId (string) minLength
            if (this.MerchantId != null && this.MerchantId.Length < 16)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantId, length must be greater than 16.", new [] { "MerchantId" });
            }

            yield break;
        }
    }

}
