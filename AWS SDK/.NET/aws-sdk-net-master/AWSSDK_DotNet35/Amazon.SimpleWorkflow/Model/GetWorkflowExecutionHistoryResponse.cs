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
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;
namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Returns information about the GetWorkflowExecutionHistory response and response metadata.
    /// </summary>
    public class GetWorkflowExecutionHistoryResponse : GetWorkflowExecutionHistoryResult
    {
        /// 
        /// Gets and sets the GetWorkflowExecutionHistoryResult property.
        /// Contains the result of a successful invocation of the GetWorkflowExecutionHistory
        /// action.
        /// 
        [Obsolete(@"This property has been deprecated. All properties of the GetWorkflowExecutionHistoryResult class are now available on the GetWorkflowExecutionHistoryResponse class. You should use the properties on GetWorkflowExecutionHistoryResponse instead of accessing them through GetWorkflowExecutionHistoryResult.")]
        public GetWorkflowExecutionHistoryResult GetWorkflowExecutionHistoryResult
        {
            get
            {
                return this;
            }
        }
    }
}
    
