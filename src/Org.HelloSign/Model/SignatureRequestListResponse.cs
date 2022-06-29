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
    /// SignatureRequestListResponse
    /// </summary>
    [DataContract(Name = "SignatureRequestListResponse")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class SignatureRequestListResponse : IOpenApiTyped, IEquatable<SignatureRequestListResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureRequestListResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SignatureRequestListResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureRequestListResponse" /> class.
        /// </summary>
        /// <param name="signatureRequests">Contains information about signature requests..</param>
        /// <param name="listInfo">listInfo.</param>
        /// <param name="warnings">A list of warnings..</param>
        public SignatureRequestListResponse(List<SignatureRequestResponse> signatureRequests = default(List<SignatureRequestResponse>), ListInfoResponse listInfo = default(ListInfoResponse), List<WarningResponse> warnings = default(List<WarningResponse>))
        {
            
            this.SignatureRequests = signatureRequests;
            this.ListInfo = listInfo;
            this.Warnings = warnings;
        }

        /// <summary>
        /// Contains information about signature requests.
        /// </summary>
        /// <value>Contains information about signature requests.</value>
        [DataMember(Name = "signature_requests", EmitDefaultValue = true)]
        public List<SignatureRequestResponse> SignatureRequests { get; set; }

        /// <summary>
        /// Gets or Sets ListInfo
        /// </summary>
        [DataMember(Name = "list_info", EmitDefaultValue = true)]
        public ListInfoResponse ListInfo { get; set; }

        /// <summary>
        /// A list of warnings.
        /// </summary>
        /// <value>A list of warnings.</value>
        [DataMember(Name = "warnings", EmitDefaultValue = true)]
        public List<WarningResponse> Warnings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SignatureRequestListResponse {\n");
            sb.Append("  SignatureRequests: ").Append(SignatureRequests).Append("\n");
            sb.Append("  ListInfo: ").Append(ListInfo).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
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
            return this.Equals(input as SignatureRequestListResponse);
        }

        /// <summary>
        /// Returns true if SignatureRequestListResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SignatureRequestListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignatureRequestListResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SignatureRequests == input.SignatureRequests ||
                    this.SignatureRequests != null &&
                    input.SignatureRequests != null &&
                    this.SignatureRequests.SequenceEqual(input.SignatureRequests)
                ) && 
                (
                    this.ListInfo == input.ListInfo ||
                    (this.ListInfo != null &&
                    this.ListInfo.Equals(input.ListInfo))
                ) && 
                (
                    this.Warnings == input.Warnings ||
                    this.Warnings != null &&
                    input.Warnings != null &&
                    this.Warnings.SequenceEqual(input.Warnings)
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
                if (this.SignatureRequests != null)
                {
                    hashCode = (hashCode * 59) + this.SignatureRequests.GetHashCode();
                }
                if (this.ListInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ListInfo.GetHashCode();
                }
                if (this.Warnings != null)
                {
                    hashCode = (hashCode * 59) + this.Warnings.GetHashCode();
                }
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "signature_requests",
                Property = "SignatureRequests",
                Type = "List<SignatureRequestResponse>",
                Value = SignatureRequests,
            });
            types.Add(new OpenApiType(){
                Name = "list_info",
                Property = "ListInfo",
                Type = "ListInfoResponse",
                Value = ListInfo,
            });
            types.Add(new OpenApiType(){
                Name = "warnings",
                Property = "Warnings",
                Type = "List<WarningResponse>",
                Value = Warnings,
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
