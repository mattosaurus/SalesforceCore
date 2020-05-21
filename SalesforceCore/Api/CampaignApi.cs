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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using RestSharp.Authenticators;
using SalesforceCore.Authentication;
using SalesforceCore.Client;
using SalesforceCore.Model;

namespace SalesforceCore.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICampaignApi
    {
        #region Synchronous Operations
        /// <summary>
        /// createCampaign
        /// </summary>
        /// <remarks>
        /// Creates a campaign.
        /// </remarks>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JSON Parameters</param>
        /// <returns>Campaign</returns>
        Campaign CreateCampaign (Campaign body);

        /// <summary>
        /// createCampaign
        /// </summary>
        /// <remarks>
        /// Creates a campaign.
        /// </remarks>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JSON Parameters</param>
        /// <returns>ApiResponse of Campaign</returns>
        ApiResponse<Campaign> CreateCampaignWithHttpInfo (Campaign body);
        /// <summary>
        /// deleteCampaignById
        /// </summary>
        /// <remarks>
        /// Deletes a campaign.
        /// </remarks>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the campaign to delete</param>
        /// <returns></returns>
        void DeleteCampaignById (string id);

        /// <summary>
        /// deleteCampaignById
        /// </summary>
        /// <remarks>
        /// Deletes a campaign.
        /// </remarks>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the campaign to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteCampaignByIdWithHttpInfo (string id);
        /// <summary>
        /// getCampaignById
        /// </summary>
        /// <remarks>
        /// Retrieves a campaign.
        /// </remarks>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Campaign ID</param>
        /// <returns>Campaign</returns>
        Campaign GetCampaignById (string id);

        /// <summary>
        /// getCampaignById
        /// </summary>
        /// <remarks>
        /// Retrieves a campaign.
        /// </remarks>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Campaign ID</param>
        /// <returns>ApiResponse of Campaign</returns>
        ApiResponse<Campaign> GetCampaignByIdWithHttpInfo (string id);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// createCampaign
        /// </summary>
        /// <remarks>
        /// Creates a campaign.
        /// </remarks>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JSON Parameters</param>
        /// <returns>Task of Campaign</returns>
        System.Threading.Tasks.Task<Campaign> CreateCampaignAsync (Campaign body);

        /// <summary>
        /// createCampaign
        /// </summary>
        /// <remarks>
        /// Creates a campaign.
        /// </remarks>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JSON Parameters</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        System.Threading.Tasks.Task<ApiResponse<Campaign>> CreateCampaignAsyncWithHttpInfo (Campaign body);
        /// <summary>
        /// deleteCampaignById
        /// </summary>
        /// <remarks>
        /// Deletes a campaign.
        /// </remarks>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the campaign to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteCampaignByIdAsync (string id);

        /// <summary>
        /// deleteCampaignById
        /// </summary>
        /// <remarks>
        /// Deletes a campaign.
        /// </remarks>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the campaign to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCampaignByIdAsyncWithHttpInfo (string id);
        /// <summary>
        /// getCampaignById
        /// </summary>
        /// <remarks>
        /// Retrieves a campaign.
        /// </remarks>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Campaign ID</param>
        /// <returns>Task of Campaign</returns>
        System.Threading.Tasks.Task<Campaign> GetCampaignByIdAsync (string id);

        /// <summary>
        /// getCampaignById
        /// </summary>
        /// <remarks>
        /// Retrieves a campaign.
        /// </remarks>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Campaign ID</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        System.Threading.Tasks.Task<ApiResponse<Campaign>> GetCampaignByIdAsyncWithHttpInfo (string id);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CampaignApi : BaseApi, ICampaignApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignApi"/> class.
        /// </summary>
        /// <returns></returns>
        internal CampaignApi(string authBaseUrl, string clientId, string clientSecret, string accountId, string scope)
            : base(authBaseUrl, clientId, clientSecret, accountId, scope)
        {
        }

        /// <summary>
        /// createCampaign Creates a campaign.
        /// </summary>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JSON Parameters</param>
        /// <returns>Campaign</returns>
        public Campaign CreateCampaign (Campaign body)
        {
             ApiResponse<Campaign> localVarResponse = CreateCampaignWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// createCampaign Creates a campaign.
        /// </summary>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JSON Parameters</param>
        /// <returns>ApiResponse of Campaign</returns>
        public ApiResponse< Campaign > CreateCampaignWithHttpInfo (Campaign body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CampaignApi->CreateCampaign");

            var localVarPath = "/hub/v1/campaigns";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateCampaign", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Campaign>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Campaign) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Campaign)));
        }

        /// <summary>
        /// createCampaign Creates a campaign.
        /// </summary>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JSON Parameters</param>
        /// <returns>Task of Campaign</returns>
        public async System.Threading.Tasks.Task<Campaign> CreateCampaignAsync (Campaign body)
        {
             ApiResponse<Campaign> localVarResponse = await CreateCampaignAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// createCampaign Creates a campaign.
        /// </summary>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JSON Parameters</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Campaign>> CreateCampaignAsyncWithHttpInfo (Campaign body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CampaignApi->CreateCampaign");

            var localVarPath = "/hub/v1/campaigns";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateCampaign", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Campaign>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Campaign) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Campaign)));
        }

        /// <summary>
        /// deleteCampaignById Deletes a campaign.
        /// </summary>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the campaign to delete</param>
        /// <returns></returns>
        public void DeleteCampaignById (string id)
        {
             DeleteCampaignByIdWithHttpInfo(id);
        }

        /// <summary>
        /// deleteCampaignById Deletes a campaign.
        /// </summary>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the campaign to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteCampaignByIdWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CampaignApi->DeleteCampaignById");

            var localVarPath = "/hub/v1/campaigns/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteCampaignById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// deleteCampaignById Deletes a campaign.
        /// </summary>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the campaign to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteCampaignByIdAsync (string id)
        {
             await DeleteCampaignByIdAsyncWithHttpInfo(id);

        }

        /// <summary>
        /// deleteCampaignById Deletes a campaign.
        /// </summary>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the campaign to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCampaignByIdAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CampaignApi->DeleteCampaignById");

            var localVarPath = "/hub/v1/campaigns/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteCampaignById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// getCampaignById Retrieves a campaign.
        /// </summary>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Campaign ID</param>
        /// <returns>Campaign</returns>
        public Campaign GetCampaignById (string id)
        {
             ApiResponse<Campaign> localVarResponse = GetCampaignByIdWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// getCampaignById Retrieves a campaign.
        /// </summary>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Campaign ID</param>
        /// <returns>ApiResponse of Campaign</returns>
        public ApiResponse< Campaign > GetCampaignByIdWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CampaignApi->GetCampaignById");

            var localVarPath = "/hub/v1/campaigns/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCampaignById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Campaign>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Campaign) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Campaign)));
        }

        /// <summary>
        /// getCampaignById Retrieves a campaign.
        /// </summary>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Campaign ID</param>
        /// <returns>Task of Campaign</returns>
        public async System.Threading.Tasks.Task<Campaign> GetCampaignByIdAsync (string id)
        {
             ApiResponse<Campaign> localVarResponse = await GetCampaignByIdAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// getCampaignById Retrieves a campaign.
        /// </summary>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Campaign ID</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Campaign>> GetCampaignByIdAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CampaignApi->GetCampaignById");

            var localVarPath = "/hub/v1/campaigns/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCampaignById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Campaign>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Campaign) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Campaign)));
        }

    }
}