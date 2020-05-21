/* 
 * Marketing Cloud REST API
 *
 * Marketing Cloud's REST API is our newest API. It supports multi-channel use cases, is much more lightweight and easy to use than our SOAP API, and is getting more comprehensive with every release.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: mc_sdk@salesforce.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = SalesforceCore.Client.SwaggerDateConverter;

namespace SalesforceCore.Model
{
    /// <summary>
    /// SendDefinitionToSingleRecipientResponse
    /// </summary>
    [DataContract]
    public partial class SendDefinitionToSingleRecipientResponse :  IEquatable<SendDefinitionToSingleRecipientResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendDefinitionToSingleRecipientResponse" /> class.
        /// </summary>
        /// <param name="requestId">The ID of the request.</param>
        /// <param name="errorcode">The specific error code.</param>
        /// <param name="responses">responses.</param>
        public SendDefinitionToSingleRecipientResponse(string requestId = default(string), decimal? errorcode = default(decimal?), List<SendDefinitionResponseItem> responses = default(List<SendDefinitionResponseItem>))
        {
            this.RequestId = requestId;
            this.Errorcode = errorcode;
            this.Responses = responses;
        }
        
        /// <summary>
        /// The ID of the request
        /// </summary>
        /// <value>The ID of the request</value>
        [DataMember(Name="requestId", EmitDefaultValue=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The specific error code
        /// </summary>
        /// <value>The specific error code</value>
        [DataMember(Name="errorcode", EmitDefaultValue=false)]
        public decimal? Errorcode { get; set; }

        /// <summary>
        /// Gets or Sets Responses
        /// </summary>
        [DataMember(Name="responses", EmitDefaultValue=false)]
        public List<SendDefinitionResponseItem> Responses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendDefinitionToSingleRecipientResponse {\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  Errorcode: ").Append(Errorcode).Append("\n");
            sb.Append("  Responses: ").Append(Responses).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SendDefinitionToSingleRecipientResponse);
        }

        /// <summary>
        /// Returns true if SendDefinitionToSingleRecipientResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SendDefinitionToSingleRecipientResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendDefinitionToSingleRecipientResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.Errorcode == input.Errorcode ||
                    (this.Errorcode != null &&
                    this.Errorcode.Equals(input.Errorcode))
                ) && 
                (
                    this.Responses == input.Responses ||
                    this.Responses != null &&
                    this.Responses.SequenceEqual(input.Responses)
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
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.Errorcode != null)
                    hashCode = hashCode * 59 + this.Errorcode.GetHashCode();
                if (this.Responses != null)
                    hashCode = hashCode * 59 + this.Responses.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
