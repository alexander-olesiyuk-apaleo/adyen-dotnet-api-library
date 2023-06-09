/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 70
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

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// ResponsePaymentMethod
    /// </summary>
    [DataContract(Name = "ResponsePaymentMethod")]
    public partial class ResponsePaymentMethod : IEquatable<ResponsePaymentMethod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsePaymentMethod" /> class.
        /// </summary>
        /// <param name="brand">The card brand that the shopper used to pay. Only returned if &#x60;paymentMethod.type&#x60; is **scheme**..</param>
        /// <param name="type">The &#x60;paymentMethod.type&#x60; value used in the request..</param>
        public ResponsePaymentMethod(string brand = default(string), string type = default(string))
        {
            this.Brand = brand;
            this.Type = type;
        }

        /// <summary>
        /// The card brand that the shopper used to pay. Only returned if &#x60;paymentMethod.type&#x60; is **scheme**.
        /// </summary>
        /// <value>The card brand that the shopper used to pay. Only returned if &#x60;paymentMethod.type&#x60; is **scheme**.</value>
        [DataMember(Name = "brand", EmitDefaultValue = false)]
        public string Brand { get; set; }

        /// <summary>
        /// The &#x60;paymentMethod.type&#x60; value used in the request.
        /// </summary>
        /// <value>The &#x60;paymentMethod.type&#x60; value used in the request.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResponsePaymentMethod {\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
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
            return this.Equals(input as ResponsePaymentMethod);
        }

        /// <summary>
        /// Returns true if ResponsePaymentMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of ResponsePaymentMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponsePaymentMethod input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Brand == input.Brand ||
                    (this.Brand != null &&
                    this.Brand.Equals(input.Brand))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Brand != null)
                {
                    hashCode = (hashCode * 59) + this.Brand.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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