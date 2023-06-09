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
    /// ListStoresResponse
    /// </summary>
    [DataContract(Name = "ListStoresResponse")]
    public partial class ListStoresResponse : IEquatable<ListStoresResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListStoresResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListStoresResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListStoresResponse" /> class.
        /// </summary>
        /// <param name="links">links.</param>
        /// <param name="data">List of stores.</param>
        /// <param name="itemsTotal">Total number of items. (required).</param>
        /// <param name="pagesTotal">Total number of pages. (required).</param>
        public ListStoresResponse(PaginationLinks links = default(PaginationLinks), List<Store> data = default(List<Store>), int? itemsTotal = default(int?), int? pagesTotal = default(int?))
        {
            this.ItemsTotal = itemsTotal;
            this.PagesTotal = pagesTotal;
            this.Links = links;
            this.Data = data;
        }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "_links", EmitDefaultValue = false)]
        public PaginationLinks Links { get; set; }

        /// <summary>
        /// List of stores
        /// </summary>
        /// <value>List of stores</value>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public List<Store> Data { get; set; }

        /// <summary>
        /// Total number of items.
        /// </summary>
        /// <value>Total number of items.</value>
        [DataMember(Name = "itemsTotal", IsRequired = false, EmitDefaultValue = false)]
        public int? ItemsTotal { get; set; }

        /// <summary>
        /// Total number of pages.
        /// </summary>
        /// <value>Total number of pages.</value>
        [DataMember(Name = "pagesTotal", IsRequired = false, EmitDefaultValue = false)]
        public int? PagesTotal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListStoresResponse {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  ItemsTotal: ").Append(ItemsTotal).Append("\n");
            sb.Append("  PagesTotal: ").Append(PagesTotal).Append("\n");
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
            return this.Equals(input as ListStoresResponse);
        }

        /// <summary>
        /// Returns true if ListStoresResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ListStoresResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListStoresResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) && 
                (
                    this.ItemsTotal == input.ItemsTotal ||
                    this.ItemsTotal.Equals(input.ItemsTotal)
                ) && 
                (
                    this.PagesTotal == input.PagesTotal ||
                    this.PagesTotal.Equals(input.PagesTotal)
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
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ItemsTotal.GetHashCode();
                hashCode = (hashCode * 59) + this.PagesTotal.GetHashCode();
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