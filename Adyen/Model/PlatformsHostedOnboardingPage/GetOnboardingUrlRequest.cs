/*
* Hosted onboarding API
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

namespace Adyen.Model.PlatformsHostedOnboardingPage
{
    /// <summary>
    /// GetOnboardingUrlRequest
    /// </summary>
    [DataContract(Name = "GetOnboardingUrlRequest")]
    public partial class GetOnboardingUrlRequest : IEquatable<GetOnboardingUrlRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetOnboardingUrlRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetOnboardingUrlRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetOnboardingUrlRequest" /> class.
        /// </summary>
        /// <param name="accountHolderCode">The account holder code you provided when you created the account holder. (required).</param>
        /// <param name="collectInformation">collectInformation.</param>
        /// <param name="editMode">Indicates if editing checks is allowed even if all the checks have passed..</param>
        /// <param name="mobileOAuthCallbackUrl">The URL to which the account holder is redirected after completing an OAuth authentication with a bank through Trustly/PayMyBank..</param>
        /// <param name="platformName">The platform name which will show up in the welcome page..</param>
        /// <param name="returnUrl">The URL where the account holder will be redirected back to after they complete the onboarding, or if their session times out. Maximum length of 500 characters. If you don&#39;t provide this, the account holder will be redirected back to the default return URL configured in your platform account..</param>
        /// <param name="shopperLocale">The language to be used in the page, specified by a combination of a language and country code. For example, **pt-BR**.   If not specified in the request or if the language is not supported, the page uses the browser language. If the browser language is not supported, the page uses **en-US** by default.  For a list of supported languages, refer to [Change the page language](https://docs.adyen.com/marketplaces-and-platforms/classic/hosted-onboarding-page/customize-experience#change-page-language)..</param>
        /// <param name="showPages">showPages.</param>
        public GetOnboardingUrlRequest(string accountHolderCode = default(string), CollectInformation collectInformation = default(CollectInformation), bool? editMode = default(bool?), string mobileOAuthCallbackUrl = default(string), string platformName = default(string), string returnUrl = default(string), string shopperLocale = default(string), ShowPages showPages = default(ShowPages))
        {
            this.AccountHolderCode = accountHolderCode;
            this.CollectInformation = collectInformation;
            this.EditMode = editMode;
            this.MobileOAuthCallbackUrl = mobileOAuthCallbackUrl;
            this.PlatformName = platformName;
            this.ReturnUrl = returnUrl;
            this.ShopperLocale = shopperLocale;
            this.ShowPages = showPages;
        }

        /// <summary>
        /// The account holder code you provided when you created the account holder.
        /// </summary>
        /// <value>The account holder code you provided when you created the account holder.</value>
        [DataMember(Name = "accountHolderCode", IsRequired = false, EmitDefaultValue = false)]
        public string AccountHolderCode { get; set; }

        /// <summary>
        /// Gets or Sets CollectInformation
        /// </summary>
        [DataMember(Name = "collectInformation", EmitDefaultValue = false)]
        public CollectInformation CollectInformation { get; set; }

        /// <summary>
        /// Indicates if editing checks is allowed even if all the checks have passed.
        /// </summary>
        /// <value>Indicates if editing checks is allowed even if all the checks have passed.</value>
        [DataMember(Name = "editMode", EmitDefaultValue = false)]
        public bool? EditMode { get; set; }

        /// <summary>
        /// The URL to which the account holder is redirected after completing an OAuth authentication with a bank through Trustly/PayMyBank.
        /// </summary>
        /// <value>The URL to which the account holder is redirected after completing an OAuth authentication with a bank through Trustly/PayMyBank.</value>
        [DataMember(Name = "mobileOAuthCallbackUrl", EmitDefaultValue = false)]
        public string MobileOAuthCallbackUrl { get; set; }

        /// <summary>
        /// The platform name which will show up in the welcome page.
        /// </summary>
        /// <value>The platform name which will show up in the welcome page.</value>
        [DataMember(Name = "platformName", EmitDefaultValue = false)]
        public string PlatformName { get; set; }

        /// <summary>
        /// The URL where the account holder will be redirected back to after they complete the onboarding, or if their session times out. Maximum length of 500 characters. If you don&#39;t provide this, the account holder will be redirected back to the default return URL configured in your platform account.
        /// </summary>
        /// <value>The URL where the account holder will be redirected back to after they complete the onboarding, or if their session times out. Maximum length of 500 characters. If you don&#39;t provide this, the account holder will be redirected back to the default return URL configured in your platform account.</value>
        [DataMember(Name = "returnUrl", EmitDefaultValue = false)]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// The language to be used in the page, specified by a combination of a language and country code. For example, **pt-BR**.   If not specified in the request or if the language is not supported, the page uses the browser language. If the browser language is not supported, the page uses **en-US** by default.  For a list of supported languages, refer to [Change the page language](https://docs.adyen.com/marketplaces-and-platforms/classic/hosted-onboarding-page/customize-experience#change-page-language).
        /// </summary>
        /// <value>The language to be used in the page, specified by a combination of a language and country code. For example, **pt-BR**.   If not specified in the request or if the language is not supported, the page uses the browser language. If the browser language is not supported, the page uses **en-US** by default.  For a list of supported languages, refer to [Change the page language](https://docs.adyen.com/marketplaces-and-platforms/classic/hosted-onboarding-page/customize-experience#change-page-language).</value>
        [DataMember(Name = "shopperLocale", EmitDefaultValue = false)]
        public string ShopperLocale { get; set; }

        /// <summary>
        /// Gets or Sets ShowPages
        /// </summary>
        [DataMember(Name = "showPages", EmitDefaultValue = false)]
        public ShowPages ShowPages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetOnboardingUrlRequest {\n");
            sb.Append("  AccountHolderCode: ").Append(AccountHolderCode).Append("\n");
            sb.Append("  CollectInformation: ").Append(CollectInformation).Append("\n");
            sb.Append("  EditMode: ").Append(EditMode).Append("\n");
            sb.Append("  MobileOAuthCallbackUrl: ").Append(MobileOAuthCallbackUrl).Append("\n");
            sb.Append("  PlatformName: ").Append(PlatformName).Append("\n");
            sb.Append("  ReturnUrl: ").Append(ReturnUrl).Append("\n");
            sb.Append("  ShopperLocale: ").Append(ShopperLocale).Append("\n");
            sb.Append("  ShowPages: ").Append(ShowPages).Append("\n");
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
            return this.Equals(input as GetOnboardingUrlRequest);
        }

        /// <summary>
        /// Returns true if GetOnboardingUrlRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetOnboardingUrlRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetOnboardingUrlRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountHolderCode == input.AccountHolderCode ||
                    (this.AccountHolderCode != null &&
                    this.AccountHolderCode.Equals(input.AccountHolderCode))
                ) && 
                (
                    this.CollectInformation == input.CollectInformation ||
                    (this.CollectInformation != null &&
                    this.CollectInformation.Equals(input.CollectInformation))
                ) && 
                (
                    this.EditMode == input.EditMode ||
                    this.EditMode.Equals(input.EditMode)
                ) && 
                (
                    this.MobileOAuthCallbackUrl == input.MobileOAuthCallbackUrl ||
                    (this.MobileOAuthCallbackUrl != null &&
                    this.MobileOAuthCallbackUrl.Equals(input.MobileOAuthCallbackUrl))
                ) && 
                (
                    this.PlatformName == input.PlatformName ||
                    (this.PlatformName != null &&
                    this.PlatformName.Equals(input.PlatformName))
                ) && 
                (
                    this.ReturnUrl == input.ReturnUrl ||
                    (this.ReturnUrl != null &&
                    this.ReturnUrl.Equals(input.ReturnUrl))
                ) && 
                (
                    this.ShopperLocale == input.ShopperLocale ||
                    (this.ShopperLocale != null &&
                    this.ShopperLocale.Equals(input.ShopperLocale))
                ) && 
                (
                    this.ShowPages == input.ShowPages ||
                    (this.ShowPages != null &&
                    this.ShowPages.Equals(input.ShowPages))
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
                if (this.AccountHolderCode != null)
                {
                    hashCode = (hashCode * 59) + this.AccountHolderCode.GetHashCode();
                }
                if (this.CollectInformation != null)
                {
                    hashCode = (hashCode * 59) + this.CollectInformation.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EditMode.GetHashCode();
                if (this.MobileOAuthCallbackUrl != null)
                {
                    hashCode = (hashCode * 59) + this.MobileOAuthCallbackUrl.GetHashCode();
                }
                if (this.PlatformName != null)
                {
                    hashCode = (hashCode * 59) + this.PlatformName.GetHashCode();
                }
                if (this.ReturnUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ReturnUrl.GetHashCode();
                }
                if (this.ShopperLocale != null)
                {
                    hashCode = (hashCode * 59) + this.ShopperLocale.GetHashCode();
                }
                if (this.ShowPages != null)
                {
                    hashCode = (hashCode * 59) + this.ShowPages.GetHashCode();
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
