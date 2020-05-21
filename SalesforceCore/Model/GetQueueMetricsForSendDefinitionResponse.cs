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
    /// GetQueueMetricsForSendDefinitionResponse
    /// </summary>
    [DataContract]
    public partial class GetQueueMetricsForSendDefinitionResponse :  IEquatable<GetQueueMetricsForSendDefinitionResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetQueueMetricsForSendDefinitionResponse" /> class.
        /// </summary>
        /// <param name="requestId">The ID of the request.</param>
        /// <param name="count">Number of pages.</param>
        /// <param name="ageSeconds">Number of seconds.</param>
        public GetQueueMetricsForSendDefinitionResponse(string requestId = default(string), decimal? count = default(decimal?), decimal? ageSeconds = default(decimal?))
        {
            this.RequestId = requestId;
            this.Count = count;
            this.AgeSeconds = ageSeconds;
        }
        
        /// <summary>
        /// The ID of the request
        /// </summary>
        /// <value>The ID of the request</value>
        [DataMember(Name="requestId", EmitDefaultValue=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Number of pages
        /// </summary>
        /// <value>Number of pages</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public decimal? Count { get; set; }

        /// <summary>
        /// Number of seconds
        /// </summary>
        /// <value>Number of seconds</value>
        [DataMember(Name="ageSeconds", EmitDefaultValue=false)]
        public decimal? AgeSeconds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetQueueMetricsForSendDefinitionResponse {\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  AgeSeconds: ").Append(AgeSeconds).Append("\n");
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
            return this.Equals(input as GetQueueMetricsForSendDefinitionResponse);
        }

        /// <summary>
        /// Returns true if GetQueueMetricsForSendDefinitionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetQueueMetricsForSendDefinitionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetQueueMetricsForSendDefinitionResponse input)
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
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.AgeSeconds == input.AgeSeconds ||
                    (this.AgeSeconds != null &&
                    this.AgeSeconds.Equals(input.AgeSeconds))
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
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.AgeSeconds != null)
                    hashCode = hashCode * 59 + this.AgeSeconds.GetHashCode();
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
