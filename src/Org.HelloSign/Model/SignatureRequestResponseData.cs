/*
 * HelloSign API
 *
 * HelloSign v3 API
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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.HelloSign.Client.OpenAPIDateConverter;

namespace Org.HelloSign.Model
{
    /// <summary>
    /// An array of form field objects containing the name, value, and type of each textbox or checkmark field filled in by the signers.
    /// </summary>
    [DataContract(Name = "SignatureRequestResponseData")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class SignatureRequestResponseData : IOpenApiTyped, IEquatable<SignatureRequestResponseData>, IValidatableObject
    {
        /// <summary>
        /// - &#x60;text&#x60;: A text input field - &#x60;checkbox&#x60;: A yes/no checkbox - &#x60;date_signed&#x60;: A date - &#x60;dropdown&#x60;: An input field for dropdowns - &#x60;initials&#x60;: An input field for initials - &#x60;radio&#x60;: An input field for radios - &#x60;signature&#x60;: A signature input field - &#x60;text-merge&#x60;: A text field that has default text set by the api - &#x60;checkbox-merge&#x60;: A checkbox field that has default value set by the api
        /// </summary>
        /// <value>- &#x60;text&#x60;: A text input field - &#x60;checkbox&#x60;: A yes/no checkbox - &#x60;date_signed&#x60;: A date - &#x60;dropdown&#x60;: An input field for dropdowns - &#x60;initials&#x60;: An input field for initials - &#x60;radio&#x60;: An input field for radios - &#x60;signature&#x60;: A signature input field - &#x60;text-merge&#x60;: A text field that has default text set by the api - &#x60;checkbox-merge&#x60;: A checkbox field that has default value set by the api</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Text for value: text
            /// </summary>
            [EnumMember(Value = "text")]
            Text = 1,

            /// <summary>
            /// Enum Checkbox for value: checkbox
            /// </summary>
            [EnumMember(Value = "checkbox")]
            Checkbox = 2,

            /// <summary>
            /// Enum DateSigned for value: date_signed
            /// </summary>
            [EnumMember(Value = "date_signed")]
            DateSigned = 3,

            /// <summary>
            /// Enum Dropdown for value: dropdown
            /// </summary>
            [EnumMember(Value = "dropdown")]
            Dropdown = 4,

            /// <summary>
            /// Enum Initials for value: initials
            /// </summary>
            [EnumMember(Value = "initials")]
            Initials = 5,

            /// <summary>
            /// Enum Radio for value: radio
            /// </summary>
            [EnumMember(Value = "radio")]
            Radio = 6,

            /// <summary>
            /// Enum Signature for value: signature
            /// </summary>
            [EnumMember(Value = "signature")]
            Signature = 7,

            /// <summary>
            /// Enum TextMerge for value: text-merge
            /// </summary>
            [EnumMember(Value = "text-merge")]
            TextMerge = 8,

            /// <summary>
            /// Enum CheckboxMerge for value: checkbox-merge
            /// </summary>
            [EnumMember(Value = "checkbox-merge")]
            CheckboxMerge = 9

        }


        /// <summary>
        /// - &#x60;text&#x60;: A text input field - &#x60;checkbox&#x60;: A yes/no checkbox - &#x60;date_signed&#x60;: A date - &#x60;dropdown&#x60;: An input field for dropdowns - &#x60;initials&#x60;: An input field for initials - &#x60;radio&#x60;: An input field for radios - &#x60;signature&#x60;: A signature input field - &#x60;text-merge&#x60;: A text field that has default text set by the api - &#x60;checkbox-merge&#x60;: A checkbox field that has default value set by the api
        /// </summary>
        /// <value>- &#x60;text&#x60;: A text input field - &#x60;checkbox&#x60;: A yes/no checkbox - &#x60;date_signed&#x60;: A date - &#x60;dropdown&#x60;: An input field for dropdowns - &#x60;initials&#x60;: An input field for initials - &#x60;radio&#x60;: An input field for radios - &#x60;signature&#x60;: A signature input field - &#x60;text-merge&#x60;: A text field that has default text set by the api - &#x60;checkbox-merge&#x60;: A checkbox field that has default value set by the api</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureRequestResponseData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SignatureRequestResponseData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureRequestResponseData" /> class.
        /// </summary>
        /// <param name="apiId">The unique ID for this field..</param>
        /// <param name="signatureId">The ID of the signature to which this response is linked..</param>
        /// <param name="name">The name of the form field..</param>
        /// <param name="value">The value of the form field..</param>
        /// <param name="required">A boolean value denoting if this field is required..</param>
        /// <param name="type">- &#x60;text&#x60;: A text input field - &#x60;checkbox&#x60;: A yes/no checkbox - &#x60;date_signed&#x60;: A date - &#x60;dropdown&#x60;: An input field for dropdowns - &#x60;initials&#x60;: An input field for initials - &#x60;radio&#x60;: An input field for radios - &#x60;signature&#x60;: A signature input field - &#x60;text-merge&#x60;: A text field that has default text set by the api - &#x60;checkbox-merge&#x60;: A checkbox field that has default value set by the api.</param>
        public SignatureRequestResponseData(string apiId = default(string), string signatureId = default(string), string name = default(string), string value = default(string), bool required = default(bool), TypeEnum? type = default(TypeEnum?))
        {
            
            this.ApiId = apiId;
            this.SignatureId = signatureId;
            this.Name = name;
            this.Value = value;
            this.Required = required;
            this.Type = type;
        }

        /// <summary>
        /// The unique ID for this field.
        /// </summary>
        /// <value>The unique ID for this field.</value>
        [DataMember(Name = "api_id", EmitDefaultValue = true)]
        public string ApiId { get; set; }

        /// <summary>
        /// The ID of the signature to which this response is linked.
        /// </summary>
        /// <value>The ID of the signature to which this response is linked.</value>
        [DataMember(Name = "signature_id", EmitDefaultValue = true)]
        public string SignatureId { get; set; }

        /// <summary>
        /// The name of the form field.
        /// </summary>
        /// <value>The name of the form field.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The value of the form field.
        /// </summary>
        /// <value>The value of the form field.</value>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// A boolean value denoting if this field is required.
        /// </summary>
        /// <value>A boolean value denoting if this field is required.</value>
        [DataMember(Name = "required", EmitDefaultValue = true)]
        public bool Required { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SignatureRequestResponseData {\n");
            sb.Append("  ApiId: ").Append(ApiId).Append("\n");
            sb.Append("  SignatureId: ").Append(SignatureId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
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
            return this.Equals(input as SignatureRequestResponseData);
        }

        /// <summary>
        /// Returns true if SignatureRequestResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of SignatureRequestResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignatureRequestResponseData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApiId == input.ApiId ||
                    (this.ApiId != null &&
                    this.ApiId.Equals(input.ApiId))
                ) && 
                (
                    this.SignatureId == input.SignatureId ||
                    (this.SignatureId != null &&
                    this.SignatureId.Equals(input.SignatureId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Required == input.Required ||
                    this.Required.Equals(input.Required)
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
                if (this.ApiId != null)
                {
                    hashCode = (hashCode * 59) + this.ApiId.GetHashCode();
                }
                if (this.SignatureId != null)
                {
                    hashCode = (hashCode * 59) + this.SignatureId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Required.GetHashCode();
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "api_id",
                Property = "ApiId",
                Type = "string",
                Value = ApiId,
            });
            types.Add(new OpenApiType(){
                Name = "signature_id",
                Property = "SignatureId",
                Type = "string",
                Value = SignatureId,
            });
            types.Add(new OpenApiType(){
                Name = "name",
                Property = "Name",
                Type = "string",
                Value = Name,
            });
            types.Add(new OpenApiType(){
                Name = "value",
                Property = "Value",
                Type = "string",
                Value = Value,
            });
            types.Add(new OpenApiType(){
                Name = "required",
                Property = "Required",
                Type = "bool",
                Value = Required,
            });
            types.Add(new OpenApiType(){
                Name = "type",
                Property = "Type",
                Type = "string",
                Value = Type,
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
            yield break;
        }
    }

}
