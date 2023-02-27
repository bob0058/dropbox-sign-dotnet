/*
 * Dropbox Sign API
 *
 * Dropbox Sign v3 API
 *
 * The version of the OpenAPI document: 3.0.0
 * Contact: apisupport@hellosign.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Dropbox.Sign.Client.OpenAPIDateConverter;

namespace Dropbox.Sign.Model
{
    /// <summary>
    /// This class extends &#x60;TemplateResponseDocumentFormFieldBase&#x60;
    /// </summary>
    [DataContract(Name = "TemplateResponseDocumentFormFieldText")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(TemplateResponseDocumentFormFieldCheckbox), "checkbox")]
    [JsonSubtypes.KnownSubType(typeof(TemplateResponseDocumentFormFieldDateSigned), "date_signed")]
    [JsonSubtypes.KnownSubType(typeof(TemplateResponseDocumentFormFieldDropdown), "dropdown")]
    [JsonSubtypes.KnownSubType(typeof(TemplateResponseDocumentFormFieldHyperlink), "hyperlink")]
    [JsonSubtypes.KnownSubType(typeof(TemplateResponseDocumentFormFieldInitials), "initials")]
    [JsonSubtypes.KnownSubType(typeof(TemplateResponseDocumentFormFieldRadio), "radio")]
    [JsonSubtypes.KnownSubType(typeof(TemplateResponseDocumentFormFieldSignature), "signature")]
    [JsonSubtypes.KnownSubType(typeof(TemplateResponseDocumentFormFieldText), "text")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class TemplateResponseDocumentFormFieldText : TemplateResponseDocumentFormFieldBase, IOpenApiTyped, IEquatable<TemplateResponseDocumentFormFieldText>, IValidatableObject
    {
        /// <summary>
        /// Each text field may contain a &#x60;validation_type&#x60; parameter. Check out the list of [validation types](https://faq.hellosign.com/hc/en-us/articles/217115577) to learn more about the possible values.
        /// </summary>
        /// <value>Each text field may contain a &#x60;validation_type&#x60; parameter. Check out the list of [validation types](https://faq.hellosign.com/hc/en-us/articles/217115577) to learn more about the possible values.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ValidationTypeEnum
        {
            /// <summary>
            /// Enum NumbersOnly for value: numbers_only
            /// </summary>
            [EnumMember(Value = "numbers_only")]
            NumbersOnly = 1,

            /// <summary>
            /// Enum LettersOnly for value: letters_only
            /// </summary>
            [EnumMember(Value = "letters_only")]
            LettersOnly = 2,

            /// <summary>
            /// Enum PhoneNumber for value: phone_number
            /// </summary>
            [EnumMember(Value = "phone_number")]
            PhoneNumber = 3,

            /// <summary>
            /// Enum BankRoutingNumber for value: bank_routing_number
            /// </summary>
            [EnumMember(Value = "bank_routing_number")]
            BankRoutingNumber = 4,

            /// <summary>
            /// Enum BankAccountNumber for value: bank_account_number
            /// </summary>
            [EnumMember(Value = "bank_account_number")]
            BankAccountNumber = 5,

            /// <summary>
            /// Enum EmailAddress for value: email_address
            /// </summary>
            [EnumMember(Value = "email_address")]
            EmailAddress = 6,

            /// <summary>
            /// Enum ZipCode for value: zip_code
            /// </summary>
            [EnumMember(Value = "zip_code")]
            ZipCode = 7,

            /// <summary>
            /// Enum SocialSecurityNumber for value: social_security_number
            /// </summary>
            [EnumMember(Value = "social_security_number")]
            SocialSecurityNumber = 8,

            /// <summary>
            /// Enum EmployerIdentificationNumber for value: employer_identification_number
            /// </summary>
            [EnumMember(Value = "employer_identification_number")]
            EmployerIdentificationNumber = 9,

            /// <summary>
            /// Enum CustomRegex for value: custom_regex
            /// </summary>
            [EnumMember(Value = "custom_regex")]
            CustomRegex = 10

        }


        /// <summary>
        /// Each text field may contain a &#x60;validation_type&#x60; parameter. Check out the list of [validation types](https://faq.hellosign.com/hc/en-us/articles/217115577) to learn more about the possible values.
        /// </summary>
        /// <value>Each text field may contain a &#x60;validation_type&#x60; parameter. Check out the list of [validation types](https://faq.hellosign.com/hc/en-us/articles/217115577) to learn more about the possible values.</value>
        [DataMember(Name = "validation_type", EmitDefaultValue = true)]
        public ValidationTypeEnum? ValidationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateResponseDocumentFormFieldText" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TemplateResponseDocumentFormFieldText() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateResponseDocumentFormFieldText" /> class.
        /// </summary>
        /// <param name="type">The type of this form field. See [field types](/api/reference/constants/#field-types).  * Text Field uses &#x60;TemplateResponseDocumentFormFieldText&#x60; * Dropdown Field uses &#x60;TemplateResponseDocumentFormFieldDropdown&#x60; * Hyperlink Field uses &#x60;TemplateResponseDocumentFormFieldHyperlink&#x60; * Checkbox Field uses &#x60;TemplateResponseDocumentFormFieldCheckbox&#x60; * Radio Field uses &#x60;TemplateResponseDocumentFormFieldRadio&#x60; * Signature Field uses &#x60;TemplateResponseDocumentFormFieldSignature&#x60; * Date Signed Field uses &#x60;TemplateResponseDocumentFormFieldDateSigned&#x60; * Initials Field uses &#x60;TemplateResponseDocumentFormFieldInitials&#x60; (required) (default to &quot;text&quot;).</param>
        /// <param name="avgTextLength">avgTextLength.</param>
        /// <param name="isMultiline">Whether this form field is multiline text..</param>
        /// <param name="originalFontSize">Original font size used in this form field&#39;s text..</param>
        /// <param name="fontFamily">Font family used in this form field&#39;s text..</param>
        /// <param name="validationType">Each text field may contain a &#x60;validation_type&#x60; parameter. Check out the list of [validation types](https://faq.hellosign.com/hc/en-us/articles/217115577) to learn more about the possible values..</param>
        /// <param name="apiId">A unique id for the form field..</param>
        /// <param name="name">The name of the form field..</param>
        /// <param name="signer">The signer of the Form Field..</param>
        /// <param name="x">The horizontal offset in pixels for this form field..</param>
        /// <param name="y">The vertical offset in pixels for this form field..</param>
        /// <param name="width">The width in pixels of this form field..</param>
        /// <param name="height">The height in pixels of this form field..</param>
        /// <param name="required">Boolean showing whether or not this field is required..</param>
        /// <param name="group">The name of the group this field is in. If this field is not a group, this defaults to &#x60;null&#x60; except for Radio fields..</param>
        /// <param name="fontSize">Final font size used by this form field..</param>
        public TemplateResponseDocumentFormFieldText(string type = "text", TemplateResponseFieldAvgTextLength avgTextLength = default(TemplateResponseFieldAvgTextLength), bool isMultiline = default(bool), int originalFontSize = default(int), string fontFamily = default(string), ValidationTypeEnum? validationType = default(ValidationTypeEnum?), string apiId = default(string), string name = default(string), string signer = default(string), int x = default(int), int y = default(int), int width = default(int), int height = default(int), bool required = default(bool), string group = default(string), int fontSize = default(int))
        {
            this.ApiId = apiId;
            this.Name = name;
            this.Signer = signer;
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
            this.Required = required;
            this.Group = group;
            this.FontSize = fontSize;
            
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for TemplateResponseDocumentFormFieldText and cannot be null");
            }
            this.Type = type;
            this.AvgTextLength = avgTextLength;
            this.IsMultiline = isMultiline;
            this.OriginalFontSize = originalFontSize;
            this.FontFamily = fontFamily;
            this.ValidationType = validationType;
        }

        /// <summary>
        /// Attempt to instantiate and hydrate a new instance of this class
        /// </summary>
        /// <param name="jsonData">String of JSON data representing target object</param>
        public static TemplateResponseDocumentFormFieldText Init(string jsonData)
        {
            var obj = JsonConvert.DeserializeObject<TemplateResponseDocumentFormFieldText>(jsonData);

            if (obj == null)
            {
                throw new Exception("Unable to deserialize JSON to instance of TemplateResponseDocumentFormFieldText");
            }

            return obj;
        }

        /// <summary>
        /// The type of this form field. See [field types](/api/reference/constants/#field-types).  * Text Field uses &#x60;TemplateResponseDocumentFormFieldText&#x60; * Dropdown Field uses &#x60;TemplateResponseDocumentFormFieldDropdown&#x60; * Hyperlink Field uses &#x60;TemplateResponseDocumentFormFieldHyperlink&#x60; * Checkbox Field uses &#x60;TemplateResponseDocumentFormFieldCheckbox&#x60; * Radio Field uses &#x60;TemplateResponseDocumentFormFieldRadio&#x60; * Signature Field uses &#x60;TemplateResponseDocumentFormFieldSignature&#x60; * Date Signed Field uses &#x60;TemplateResponseDocumentFormFieldDateSigned&#x60; * Initials Field uses &#x60;TemplateResponseDocumentFormFieldInitials&#x60;
        /// </summary>
        /// <value>The type of this form field. See [field types](/api/reference/constants/#field-types).  * Text Field uses &#x60;TemplateResponseDocumentFormFieldText&#x60; * Dropdown Field uses &#x60;TemplateResponseDocumentFormFieldDropdown&#x60; * Hyperlink Field uses &#x60;TemplateResponseDocumentFormFieldHyperlink&#x60; * Checkbox Field uses &#x60;TemplateResponseDocumentFormFieldCheckbox&#x60; * Radio Field uses &#x60;TemplateResponseDocumentFormFieldRadio&#x60; * Signature Field uses &#x60;TemplateResponseDocumentFormFieldSignature&#x60; * Date Signed Field uses &#x60;TemplateResponseDocumentFormFieldDateSigned&#x60; * Initials Field uses &#x60;TemplateResponseDocumentFormFieldInitials&#x60;</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets AvgTextLength
        /// </summary>
        [DataMember(Name = "avg_text_length", EmitDefaultValue = true)]
        public TemplateResponseFieldAvgTextLength AvgTextLength { get; set; }

        /// <summary>
        /// Whether this form field is multiline text.
        /// </summary>
        /// <value>Whether this form field is multiline text.</value>
        [DataMember(Name = "isMultiline", EmitDefaultValue = true)]
        public bool IsMultiline { get; set; }

        /// <summary>
        /// Original font size used in this form field&#39;s text.
        /// </summary>
        /// <value>Original font size used in this form field&#39;s text.</value>
        [DataMember(Name = "originalFontSize", EmitDefaultValue = true)]
        public int OriginalFontSize { get; set; }

        /// <summary>
        /// Font family used in this form field&#39;s text.
        /// </summary>
        /// <value>Font family used in this form field&#39;s text.</value>
        [DataMember(Name = "fontFamily", EmitDefaultValue = true)]
        public string FontFamily { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TemplateResponseDocumentFormFieldText {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AvgTextLength: ").Append(AvgTextLength).Append("\n");
            sb.Append("  IsMultiline: ").Append(IsMultiline).Append("\n");
            sb.Append("  OriginalFontSize: ").Append(OriginalFontSize).Append("\n");
            sb.Append("  FontFamily: ").Append(FontFamily).Append("\n");
            sb.Append("  ValidationType: ").Append(ValidationType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as TemplateResponseDocumentFormFieldText);
        }

        /// <summary>
        /// Returns true if TemplateResponseDocumentFormFieldText instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateResponseDocumentFormFieldText to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateResponseDocumentFormFieldText input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.AvgTextLength == input.AvgTextLength ||
                    (this.AvgTextLength != null &&
                    this.AvgTextLength.Equals(input.AvgTextLength))
                ) && base.Equals(input) && 
                (
                    this.IsMultiline == input.IsMultiline ||
                    this.IsMultiline.Equals(input.IsMultiline)
                ) && base.Equals(input) && 
                (
                    this.OriginalFontSize == input.OriginalFontSize ||
                    this.OriginalFontSize.Equals(input.OriginalFontSize)
                ) && base.Equals(input) && 
                (
                    this.FontFamily == input.FontFamily ||
                    (this.FontFamily != null &&
                    this.FontFamily.Equals(input.FontFamily))
                ) && base.Equals(input) && 
                (
                    this.ValidationType == input.ValidationType ||
                    this.ValidationType.Equals(input.ValidationType)
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
                int hashCode = base.GetHashCode();
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.AvgTextLength != null)
                {
                    hashCode = (hashCode * 59) + this.AvgTextLength.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsMultiline.GetHashCode();
                hashCode = (hashCode * 59) + this.OriginalFontSize.GetHashCode();
                if (this.FontFamily != null)
                {
                    hashCode = (hashCode * 59) + this.FontFamily.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ValidationType.GetHashCode();
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "type",
                Property = "Type",
                Type = "string",
                Value = Type,
            });
            types.Add(new OpenApiType(){
                Name = "avg_text_length",
                Property = "AvgTextLength",
                Type = "TemplateResponseFieldAvgTextLength",
                Value = AvgTextLength,
            });
            types.Add(new OpenApiType(){
                Name = "isMultiline",
                Property = "IsMultiline",
                Type = "bool",
                Value = IsMultiline,
            });
            types.Add(new OpenApiType(){
                Name = "originalFontSize",
                Property = "OriginalFontSize",
                Type = "int",
                Value = OriginalFontSize,
            });
            types.Add(new OpenApiType(){
                Name = "fontFamily",
                Property = "FontFamily",
                Type = "string",
                Value = FontFamily,
            });
            types.Add(new OpenApiType(){
                Name = "validation_type",
                Property = "ValidationType",
                Type = "string",
                Value = ValidationType,
            });

            return types;
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach (var x in BaseValidate(validationContext))
            {
                yield return x;
            }
            yield break;
        }
    }

}