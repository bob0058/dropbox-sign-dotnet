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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.HelloSign.Client.OpenAPIDateConverter;

namespace Org.HelloSign.Model
{
    /// <summary>
    /// An array of form field objects containing the name, value, and type of each textbox or checkmark field filled in by the signers.
    /// </summary>
    [DataContract(Name = "SignatureRequestResponseData")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueCheckbox), "SignatureRequestResponseDataValueCheckbox")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueCheckboxMerge), "SignatureRequestResponseDataValueCheckboxMerge")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueDateSigned), "SignatureRequestResponseDataValueDateSigned")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueDropdown), "SignatureRequestResponseDataValueDropdown")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueInitials), "SignatureRequestResponseDataValueInitials")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueRadio), "SignatureRequestResponseDataValueRadio")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueSignature), "SignatureRequestResponseDataValueSignature")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueText), "SignatureRequestResponseDataValueText")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueTextMerge), "SignatureRequestResponseDataValueTextMerge")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueCheckbox), "checkbox")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueCheckboxMerge), "checkbox-merge")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueDateSigned), "date_signed")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueDropdown), "dropdown")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueInitials), "initials")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueRadio), "radio")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueSignature), "signature")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueText), "text")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueTextMerge), "text-merge")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class SignatureRequestResponseData : IOpenApiTyped, IEquatable<SignatureRequestResponseData>, IValidatableObject
    {
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
        /// <param name="required">A boolean value denoting if this field is required..</param>
        /// <param name="type">type.</param>
        public SignatureRequestResponseData(string apiId = default(string), string signatureId = default(string), string name = default(string), bool required = default(bool), string type = default(string))
        {
            
            this.ApiId = apiId;
            this.SignatureId = signatureId;
            this.Name = name;
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
        /// A boolean value denoting if this field is required.
        /// </summary>
        /// <value>A boolean value denoting if this field is required.</value>
        [DataMember(Name = "required", EmitDefaultValue = true)]
        public bool Required { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

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
                    this.Required == input.Required ||
                    this.Required.Equals(input.Required)
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
                hashCode = (hashCode * 59) + this.Required.GetHashCode();
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
