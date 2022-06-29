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
    /// FileResponse
    /// </summary>
    [DataContract(Name = "FileResponse")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class FileResponse : IOpenApiTyped, IEquatable<FileResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FileResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileResponse" /> class.
        /// </summary>
        /// <param name="fileUrl">URL to the file..</param>
        /// <param name="expiresAt">When the link expires..</param>
        public FileResponse(string fileUrl = default(string), int expiresAt = default(int))
        {
            
            this.FileUrl = fileUrl;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// URL to the file.
        /// </summary>
        /// <value>URL to the file.</value>
        [DataMember(Name = "file_url", EmitDefaultValue = true)]
        public string FileUrl { get; set; }

        /// <summary>
        /// When the link expires.
        /// </summary>
        /// <value>When the link expires.</value>
        [DataMember(Name = "expires_at", EmitDefaultValue = true)]
        public int ExpiresAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FileResponse {\n");
            sb.Append("  FileUrl: ").Append(FileUrl).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
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
            return this.Equals(input as FileResponse);
        }

        /// <summary>
        /// Returns true if FileResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of FileResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FileUrl == input.FileUrl ||
                    (this.FileUrl != null &&
                    this.FileUrl.Equals(input.FileUrl))
                ) && 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    this.ExpiresAt.Equals(input.ExpiresAt)
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
                if (this.FileUrl != null)
                {
                    hashCode = (hashCode * 59) + this.FileUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExpiresAt.GetHashCode();
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "file_url",
                Property = "FileUrl",
                Type = "string",
                Value = FileUrl,
            });
            types.Add(new OpenApiType(){
                Name = "expires_at",
                Property = "ExpiresAt",
                Type = "int",
                Value = ExpiresAt,
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
