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
    using System.Net;
    using System.Collections.Generic;
    using ThirdParty.Json.LitJson;
    using Amazon.Glacier.Model;
    using Amazon.Runtime;
    using Amazon.Runtime.Internal;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.Glacier.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// Response Unmarshaller for DescribeVault operation
      /// </summary>
      internal class DescribeVaultResponseUnmarshaller : JsonResponseUnmarshaller
      {
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
          DescribeVaultResponse response = new DescribeVaultResponse();          
          
          context.Read();
          
          UnmarshallResult(context,response);
          return response;
        }
        
        private static void UnmarshallResult(JsonUnmarshallerContext context,DescribeVaultResponse response)
        {
          
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("VaultARN", targetDepth))
              {
                context.Read();
                response.VaultARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VaultName", targetDepth))
              {
                context.Read();
                response.VaultName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CreationDate", targetDepth))
              {
                context.Read();
                response.CreationDate = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("LastInventoryDate", targetDepth))
              {
                context.Read();
                response.LastInventoryDate = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("NumberOfArchives", targetDepth))
              {
                context.Read();
                response.NumberOfArchives = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SizeInBytes", targetDepth))
              {
                context.Read();
                response.SizeInBytes = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {                   
                    return;
                }
            }
                        
            return;
        }                        
        
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
          ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);                    
          
          if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
          {
            return new ResourceNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
          }
  
          if (errorResponse.Code != null && errorResponse.Code.Equals("MissingParameterValueException"))
          {
            return new MissingParameterValueException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
          }
  
          if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceUnavailableException"))
          {
            return new ServiceUnavailableException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
          }
  
          if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidParameterValueException"))
          {
            return new InvalidParameterValueException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
          }
  
          return new AmazonGlacierException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static DescribeVaultResponseUnmarshaller instance;
        public static DescribeVaultResponseUnmarshaller GetInstance()
        {
          if (instance == null)
          {
            instance = new DescribeVaultResponseUnmarshaller();
          }
          return instance;
        }
  
      }
    }
  
