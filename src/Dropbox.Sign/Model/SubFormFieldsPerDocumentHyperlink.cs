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
    /// This class extends &#x60;SubFormFieldsPerDocumentBase&#x60;.
    /// </summary>
    [DataContract(Name = "SubFormFieldsPerDocumentHyperlink")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(SubFormFieldsPerDocumentCheckbox), "checkbox")]
    [JsonSubtypes.KnownSubType(typeof(SubFormFieldsPerDocumentCheckboxMerge), "checkbox-merge")]
    [JsonSubtypes.KnownSubType(typeof(SubFormFieldsPerDocumentDateSigned), "date_signed")]
    [JsonSubtypes.KnownSubType(typeof(SubFormFieldsPerDocumentDropdown), "dropdown")]
    [JsonSubtypes.KnownSubType(typeof(SubFormFieldsPerDocumentHyperlink), "hyperlink")]
    [JsonSubtypes.KnownSubType(typeof(SubFormFieldsPerDocumentInitials), "initials")]
    [JsonSubtypes.KnownSubType(typeof(SubFormFieldsPerDocumentRadio), "radio")]
    [JsonSubtypes.KnownSubType(typeof(SubFormFieldsPerDocumentSignature), "signature")]
    [JsonSubtypes.KnownSubType(typeof(SubFormFieldsPerDocumentText), "text")]
    [JsonSubtypes.KnownSubType(typeof(SubFormFieldsPerDocumentTextMerge), "text-merge")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class SubFormFieldsPerDocumentHyperlink : SubFormFieldsPerDocumentBase, IOpenApiTyped, IEquatable<SubFormFieldsPerDocumentHyperlink>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubFormFieldsPerDocumentHyperlink" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubFormFieldsPerDocumentHyperlink() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubFormFieldsPerDocumentHyperlink" /> class.
        /// </summary>
        /// <param name="type">A hyperlink field. Use the &#x60;SubFormFieldsPerDocumentHyperlink&#x60; class. (required) (default to &quot;hyperlink&quot;).</param>
        /// <param name="content">Link Text. (required).</param>
        /// <param name="contentUrl">Link URL. (required).</param>
        /// <param name="documentIndex">Represents the integer index of the &#x60;file&#x60; or &#x60;file_url&#x60; document the field should be attached to. (required).</param>
        /// <param name="apiId">An identifier for the field that is unique across all documents in the request. (required).</param>
        /// <param name="height">Size of the field in pixels. (required).</param>
        /// <param name="name">Display name for the field..</param>
        /// <param name="page">Page in the document where the field should be placed (requires documents be PDF files).  - When the page number parameter is supplied, the API will use the new coordinate system. - Check out the differences between both [coordinate systems](https://faq.hellosign.com/hc/en-us/articles/217115577) and how to use them..</param>
        /// <param name="required">Whether this field is required. (required).</param>
        /// <param name="signer">Signer index identified by the offset in the signers parameter (0-based indexing), indicating which signer should fill out the field.  **NOTE**: If type is &#x60;text-merge&#x60; or &#x60;checkbox-merge&#x60;, you must set this to sender in order to use pre-filled data. (required).</param>
        /// <param name="width">Size of the field in pixels. (required).</param>
        /// <param name="x">Location coordinates of the field in pixels. (required).</param>
        /// <param name="y">Location coordinates of the field in pixels. (required).</param>
        public SubFormFieldsPerDocumentHyperlink(string type = "hyperlink", string content = default(string), string contentUrl = default(string), int documentIndex = default(int), string apiId = default(string), int height = default(int), string name = default(string), int? page = default(int?), bool required = default(bool), string signer = default(string), int width = default(int), int x = default(int), int y = default(int))
        {
            this.DocumentIndex = documentIndex;
            this.ApiId = apiId;
            this.Height = height;
            this.Required = required;
            this.Signer = signer;
            this.Width = width;
            this.X = x;
            this.Y = y;
            this.Name = name;
            this.Page = page;
            
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for SubFormFieldsPerDocumentHyperlink and cannot be null");
            }
            this.Type = type;
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new ArgumentNullException("content is a required property for SubFormFieldsPerDocumentHyperlink and cannot be null");
            }
            this.Content = content;
            // to ensure "contentUrl" is required (not null)
            if (contentUrl == null)
            {
                throw new ArgumentNullException("contentUrl is a required property for SubFormFieldsPerDocumentHyperlink and cannot be null");
            }
            this.ContentUrl = contentUrl;
        }

        /// <summary>
        /// Attempt to instantiate and hydrate a new instance of this class
        /// </summary>
        /// <param name="jsonData">String of JSON data representing target object</param>
        public static SubFormFieldsPerDocumentHyperlink Init(string jsonData)
        {
            var obj = JsonConvert.DeserializeObject<SubFormFieldsPerDocumentHyperlink>(jsonData);

            if (obj == null)
            {
                throw new Exception("Unable to deserialize JSON to instance of SubFormFieldsPerDocumentHyperlink");
            }

            return obj;
        }

        /// <summary>
        /// A hyperlink field. Use the &#x60;SubFormFieldsPerDocumentHyperlink&#x60; class.
        /// </summary>
        /// <value>A hyperlink field. Use the &#x60;SubFormFieldsPerDocumentHyperlink&#x60; class.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Link Text.
        /// </summary>
        /// <value>Link Text.</value>
        [DataMember(Name = "content", IsRequired = true, EmitDefaultValue = true)]
        public string Content { get; set; }

        /// <summary>
        /// Link URL.
        /// </summary>
        /// <value>Link URL.</value>
        [DataMember(Name = "content_url", IsRequired = true, EmitDefaultValue = true)]
        public string ContentUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubFormFieldsPerDocumentHyperlink {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  ContentUrl: ").Append(ContentUrl).Append("\n");
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
            return this.Equals(input as SubFormFieldsPerDocumentHyperlink);
        }

        /// <summary>
        /// Returns true if SubFormFieldsPerDocumentHyperlink instances are equal
        /// </summary>
        /// <param name="input">Instance of SubFormFieldsPerDocumentHyperlink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubFormFieldsPerDocumentHyperlink input)
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
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && base.Equals(input) && 
                (
                    this.ContentUrl == input.ContentUrl ||
                    (this.ContentUrl != null &&
                    this.ContentUrl.Equals(input.ContentUrl))
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
                if (this.Content != null)
                {
                    hashCode = (hashCode * 59) + this.Content.GetHashCode();
                }
                if (this.ContentUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ContentUrl.GetHashCode();
                }
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
                Name = "content",
                Property = "Content",
                Type = "string",
                Value = Content,
            });
            types.Add(new OpenApiType(){
                Name = "content_url",
                Property = "ContentUrl",
                Type = "string",
                Value = ContentUrl,
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
