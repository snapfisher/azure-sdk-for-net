// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Common;
using Microsoft.WindowsAzure.Common.Internals;
using Microsoft.WindowsAzure.Management.ExpressRoute;
using Microsoft.WindowsAzure.Management.ExpressRoute.Models;

namespace Microsoft.WindowsAzure.Management.ExpressRoute
{
    /// <summary>
    /// The Express Route API provides programmatic access to the functionality
    /// needed by the customer to set up Dedicated Circuits and Dedicated
    /// Circuit Links. The Express Route Customer API is a REST API. All API
    /// operations are performed over SSL and mutually authenticated using
    /// X.509 v3 certificates.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460799.aspx for
    /// more information)
    /// </summary>
    public partial class ExpressRouteManagementClient : ServiceClient<ExpressRouteManagementClient>, Microsoft.WindowsAzure.Management.ExpressRoute.IExpressRouteManagementClient
    {
        private Uri _baseUri;
        
        /// <summary>
        /// The URI used as the base for all golden gate requests.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
        }
        
        private SubscriptionCloudCredentials _credentials;
        
        /// <summary>
        /// The customer subscription ID forms part of the URI for every call
        /// that you make to the Express Route Gateway Manager.
        /// </summary>
        public SubscriptionCloudCredentials Credentials
        {
            get { return this._credentials; }
        }
        
        private IBorderGatewayProtocolPeeringOperations _borderGatewayProtocolPeerings;
        
        public virtual IBorderGatewayProtocolPeeringOperations BorderGatewayProtocolPeerings
        {
            get { return this._borderGatewayProtocolPeerings; }
        }
        
        private ICrossConnectionOperations _crossConnections;
        
        public virtual ICrossConnectionOperations CrossConnections
        {
            get { return this._crossConnections; }
        }
        
        private IDedicatedCircuitLinkOperations _dedicatedCircuitLinks;
        
        public virtual IDedicatedCircuitLinkOperations DedicatedCircuitLinks
        {
            get { return this._dedicatedCircuitLinks; }
        }
        
        private IDedicatedCircuitOperations _dedicatedCircuits;
        
        public virtual IDedicatedCircuitOperations DedicatedCircuits
        {
            get { return this._dedicatedCircuits; }
        }
        
        private IDedicatedCircuitServiceProviderOperations _dedicatedCircuitServiceProviders;
        
        public virtual IDedicatedCircuitServiceProviderOperations DedicatedCircuitServiceProviders
        {
            get { return this._dedicatedCircuitServiceProviders; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ExpressRouteManagementClient
        /// class.
        /// </summary>
        private ExpressRouteManagementClient()
            : base()
        {
            this._borderGatewayProtocolPeerings = new BorderGatewayProtocolPeeringOperations(this);
            this._crossConnections = new CrossConnectionOperations(this);
            this._dedicatedCircuitLinks = new DedicatedCircuitLinkOperations(this);
            this._dedicatedCircuits = new DedicatedCircuitOperations(this);
            this._dedicatedCircuitServiceProviders = new DedicatedCircuitServiceProviderOperations(this);
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the ExpressRouteManagementClient
        /// class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. The customer subscription ID forms part of the URI for
        /// every call that you make to the Express Route Gateway Manager.
        /// </param>
        /// <param name='baseUri'>
        /// Required. The URI used as the base for all golden gate requests.
        /// </param>
        public ExpressRouteManagementClient(SubscriptionCloudCredentials credentials, Uri baseUri)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the ExpressRouteManagementClient
        /// class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. The customer subscription ID forms part of the URI for
        /// every call that you make to the Express Route Gateway Manager.
        /// </param>
        public ExpressRouteManagementClient(SubscriptionCloudCredentials credentials)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.core.windows.net");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// The Get Express Route operation status gets information on the
        /// status of Express Route operations in Windows Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154112.aspx
        /// for more information)
        /// </summary>
        /// <param name='operationId'>
        /// Required. The id  of the operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        public async System.Threading.Tasks.Task<Microsoft.WindowsAzure.Management.ExpressRoute.Models.ExpressRouteOperationStatusResponse> GetOperationStatusAsync(string operationId, CancellationToken cancellationToken)
        {
            // Validate
            if (operationId == null)
            {
                throw new ArgumentNullException("operationId");
            }
            
            // Tracing
            bool shouldTrace = CloudContext.Configuration.Tracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = Tracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("operationId", operationId);
                Tracing.Enter(invocationId, this, "GetOperationStatusAsync", tracingParameters);
            }
            
            // Construct URL
            string baseUrl = this.BaseUri.AbsoluteUri;
            string url = "/" + this.Credentials.SubscriptionId.Trim() + "/services/networking/operation/" + operationId.Trim();
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("x-ms-version", "2011-10-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        Tracing.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        Tracing.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false), CloudExceptionType.Xml);
                        if (shouldTrace)
                        {
                            Tracing.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    ExpressRouteOperationStatusResponse result = null;
                    // Deserialize Response
                    cancellationToken.ThrowIfCancellationRequested();
                    string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    result = new ExpressRouteOperationStatusResponse();
                    XDocument responseDoc = XDocument.Parse(responseContent);
                    
                    XElement gatewayOperationElement = responseDoc.Element(XName.Get("GatewayOperation", "http://schemas.microsoft.com/windowsazure"));
                    if (gatewayOperationElement != null && gatewayOperationElement.IsEmpty == false)
                    {
                        XElement idElement = gatewayOperationElement.Element(XName.Get("ID", "http://schemas.microsoft.com/windowsazure"));
                        if (idElement != null && idElement.IsEmpty == false)
                        {
                            string idInstance = idElement.Value;
                            result.Id = idInstance;
                        }
                        
                        XElement statusElement = gatewayOperationElement.Element(XName.Get("Status", "http://schemas.microsoft.com/windowsazure"));
                        if (statusElement != null && statusElement.IsEmpty == false)
                        {
                            ExpressRouteOperationStatus statusInstance = ((ExpressRouteOperationStatus)Enum.Parse(typeof(ExpressRouteOperationStatus), statusElement.Value, true));
                            result.Status = statusInstance;
                        }
                        
                        XElement httpStatusCodeElement = gatewayOperationElement.Element(XName.Get("HttpStatusCode", "http://schemas.microsoft.com/windowsazure"));
                        if (httpStatusCodeElement != null && httpStatusCodeElement.IsEmpty == false)
                        {
                            HttpStatusCode httpStatusCodeInstance = ((HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), httpStatusCodeElement.Value, true));
                            result.HttpStatusCode = httpStatusCodeInstance;
                        }
                        
                        XElement dataElement = gatewayOperationElement.Element(XName.Get("Data", "http://schemas.microsoft.com/windowsazure"));
                        if (dataElement != null && dataElement.IsEmpty == false)
                        {
                            string dataInstance = dataElement.Value;
                            result.Data = dataInstance;
                        }
                        
                        XElement errorElement = gatewayOperationElement.Element(XName.Get("Error", "http://schemas.microsoft.com/windowsazure"));
                        if (errorElement != null && errorElement.IsEmpty == false)
                        {
                            ExpressRouteOperationStatusResponse.ErrorDetails errorInstance = new ExpressRouteOperationStatusResponse.ErrorDetails();
                            result.Error = errorInstance;
                            
                            XElement codeElement = errorElement.Element(XName.Get("Code", "http://schemas.microsoft.com/windowsazure"));
                            if (codeElement != null && codeElement.IsEmpty == false)
                            {
                                string codeInstance = codeElement.Value;
                                errorInstance.Code = codeInstance;
                            }
                            
                            XElement messageElement = errorElement.Element(XName.Get("Message", "http://schemas.microsoft.com/windowsazure"));
                            if (messageElement != null && messageElement.IsEmpty == false)
                            {
                                string messageInstance = messageElement.Value;
                                errorInstance.Message = messageInstance;
                            }
                        }
                    }
                    
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        Tracing.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Parse enum values for type BgpPeeringAccessType.
        /// </summary>
        /// <param name='value'>
        /// The value to parse.
        /// </param>
        /// <returns>
        /// The enum value.
        /// </returns>
        internal static BgpPeeringAccessType ParseBgpPeeringAccessType(string value)
        {
            if ("private".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return BgpPeeringAccessType.Private;
            }
            if ("public".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return BgpPeeringAccessType.Public;
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Convert an enum of type BgpPeeringAccessType to a string.
        /// </summary>
        /// <param name='value'>
        /// The value to convert to a string.
        /// </param>
        /// <returns>
        /// The enum value as a string.
        /// </returns>
        internal static string BgpPeeringAccessTypeToString(BgpPeeringAccessType value)
        {
            if (value == BgpPeeringAccessType.Private)
            {
                return "private";
            }
            if (value == BgpPeeringAccessType.Public)
            {
                return "public";
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Parse enum values for type UpdateCrossConnectionOperation.
        /// </summary>
        /// <param name='value'>
        /// The value to parse.
        /// </param>
        /// <returns>
        /// The enum value.
        /// </returns>
        internal static UpdateCrossConnectionOperation ParseUpdateCrossConnectionOperation(string value)
        {
            if ("NotifyCrossConnectionProvisioned".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return UpdateCrossConnectionOperation.NotifyCrossConnectionProvisioned;
            }
            if ("NotifyCrossConnectionNotProvisioned".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return UpdateCrossConnectionOperation.NotifyCrossConnectionNotProvisioned;
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Convert an enum of type UpdateCrossConnectionOperation to a string.
        /// </summary>
        /// <param name='value'>
        /// The value to convert to a string.
        /// </param>
        /// <returns>
        /// The enum value as a string.
        /// </returns>
        internal static string UpdateCrossConnectionOperationToString(UpdateCrossConnectionOperation value)
        {
            if (value == UpdateCrossConnectionOperation.NotifyCrossConnectionProvisioned)
            {
                return "NotifyCrossConnectionProvisioned";
            }
            if (value == UpdateCrossConnectionOperation.NotifyCrossConnectionNotProvisioned)
            {
                return "NotifyCrossConnectionNotProvisioned";
            }
            throw new ArgumentOutOfRangeException("value");
        }
    }
}
