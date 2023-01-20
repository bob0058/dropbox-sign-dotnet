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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Dropbox.Sign.Client.OpenAPIDateConverter;

namespace Dropbox.Sign.Model
{
    /// <summary>
    /// SubUnclaimedDraftTemplateSigner
    /// </summary>
    [DataContract(Name = "SubUnclaimedDraftTemplateSigner")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class SubUnclaimedDraftTemplateSigner : IOpenApiTyped, IEquatable<SubUnclaimedDraftTemplateSigner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubUnclaimedDraftTemplateSigner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubUnclaimedDraftTemplateSigner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubUnclaimedDraftTemplateSigner" /> class.
        /// </summary>
        /// <param name="role">Must match an existing role in chosen Template(s). (required).</param>
        /// <param name="name">The name of the signer filling the role of &#x60;role&#x60;. (required).</param>
        /// <param name="emailAddress">The email address of the signer filling the role of &#x60;role&#x60;. (required).</param>
        public SubUnclaimedDraftTemplateSigner(string role = default(string), string name = default(string), string emailAddress = default(string))
        {
            
            // to ensure "role" is required (not null)
            if (role == null)
            {
                throw new ArgumentNullException("role is a required property for SubUnclaimedDraftTemplateSigner and cannot be null");
            }
            this.Role = role;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for SubUnclaimedDraftTemplateSigner and cannot be null");
            }
            this.Name = name;
            // to ensure "emailAddress" is required (not null)
            if (emailAddress == null)
            {
                throw new ArgumentNullException("emailAddress is a required property for SubUnclaimedDraftTemplateSigner and cannot be null");
            }
            this.EmailAddress = emailAddress;
        }

        /// <summary>
        /// Attempt to instantiate and hydrate a new instance of this class
        /// </summary>
        /// <param name="jsonData">String of JSON data representing target object</param>
        public static SubUnclaimedDraftTemplateSigner Init(string jsonData)
        {
            var obj = JsonConvert.DeserializeObject<SubUnclaimedDraftTemplateSigner>(jsonData);

            if (obj == null)
            {
                throw new Exception("Unable to deserialize JSON to instance of SubUnclaimedDraftTemplateSigner");
            }

            return obj;
        }

        /// <summary>
        /// Must match an existing role in chosen Template(s).
        /// </summary>
        /// <value>Must match an existing role in chosen Template(s).</value>
        [DataMember(Name = "role", IsRequired = true, EmitDefaultValue = true)]
        public string Role { get; set; }

        /// <summary>
        /// The name of the signer filling the role of &#x60;role&#x60;.
        /// </summary>
        /// <value>The name of the signer filling the role of &#x60;role&#x60;.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The email address of the signer filling the role of &#x60;role&#x60;.
        /// </summary>
        /// <value>The email address of the signer filling the role of &#x60;role&#x60;.</value>
        [DataMember(Name = "email_address", IsRequired = true, EmitDefaultValue = true)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubUnclaimedDraftTemplateSigner {\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
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
            return this.Equals(input as SubUnclaimedDraftTemplateSigner);
        }

        /// <summary>
        /// Returns true if SubUnclaimedDraftTemplateSigner instances are equal
        /// </summary>
        /// <param name="input">Instance of SubUnclaimedDraftTemplateSigner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubUnclaimedDraftTemplateSigner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
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
                if (this.Role != null)
                {
                    hashCode = (hashCode * 59) + this.Role.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.EmailAddress != null)
                {
                    hashCode = (hashCode * 59) + this.EmailAddress.GetHashCode();
                }
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "role",
                Property = "Role",
                Type = "string",
                Value = Role,
            });
            types.Add(new OpenApiType(){
                Name = "name",
                Property = "Name",
                Type = "string",
                Value = Name,
            });
            types.Add(new OpenApiType(){
                Name = "email_address",
                Property = "EmailAddress",
                Type = "string",
                Value = EmailAddress,
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
