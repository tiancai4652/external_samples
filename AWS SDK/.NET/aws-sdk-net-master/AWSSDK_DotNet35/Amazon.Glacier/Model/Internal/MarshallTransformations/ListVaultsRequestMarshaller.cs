/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glacier.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glacier.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// List Vaults Request Marshaller
    /// </summary>       
    internal class ListVaultsRequestMarshaller : IMarshaller<IRequest, ListVaultsRequest> 
    {
        

        public IRequest Marshall(ListVaultsRequest listVaultsRequest) 
        {

            IRequest request = new DefaultRequest(listVaultsRequest, "AmazonGlacier");
            string target = "Glacier.ListVaults";
            request.Headers["X-Amz-Target"] = target;
            request.HttpMethod = "GET";
              
            string uriResourcePath = "/{accountId}/vaults?marker={marker};limit={limit}"; 
            if(listVaultsRequest.IsSetAccountId())
                uriResourcePath = uriResourcePath.Replace("{accountId}", StringUtils.FromString(listVaultsRequest.AccountId) ); 
            else
                uriResourcePath = uriResourcePath.Replace("{accountId}", "" ); 
            if(listVaultsRequest.IsSetMarker())
                uriResourcePath = uriResourcePath.Replace("{marker}", StringUtils.FromString(listVaultsRequest.Marker) ); 
            else
                uriResourcePath = uriResourcePath.Replace("{marker}", "" ); 
            if(listVaultsRequest.IsSetLimit())
                uriResourcePath = uriResourcePath.Replace("{limit}", StringUtils.FromInt(listVaultsRequest.Limit) ); 
            else
                uriResourcePath = uriResourcePath.Replace("{limit}", "" ); 
            
            if (uriResourcePath.Contains("?")) 
            {
                int queryPosition = uriResourcePath.IndexOf("?", StringComparison.OrdinalIgnoreCase);
                string queryString = uriResourcePath.Substring(queryPosition + 1);
                uriResourcePath    = uriResourcePath.Substring(0, queryPosition);
        
                foreach (string s in queryString.Split('&', ';')) 
                {
                    string[] nameValuePair = s.Split('=');
                    if (nameValuePair.Length == 2 && nameValuePair[1].Length > 0) 
                    {
                        request.Parameters.Add(nameValuePair[0], nameValuePair[1]);
                    }
                    else
                    {
                        request.Parameters.Add(nameValuePair[0], null);
                    }
                }
            }
            
            request.ResourcePath = uriResourcePath;
            
        
            request.UseQueryString = true;
        

            return request;
        }
    }
}
