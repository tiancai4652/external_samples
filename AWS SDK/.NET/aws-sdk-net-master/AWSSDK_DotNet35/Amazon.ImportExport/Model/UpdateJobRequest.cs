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
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ImportExport.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateJob operation.
    /// <para> You use this operation to change the parameters specified in the original manifest file by supplying a new manifest file. The
    /// manifest file attached to this request replaces the original manifest file. You can only use the operation after a CreateJob request but
    /// before the data transfer starts and you can only use it on jobs you own. </para>
    /// </summary>
    public partial class UpdateJobRequest : AmazonWebServiceRequest
    {
        private string jobId;
        private string manifest;
        private JobType jobType;
        private bool? validateOnly;

        /// <summary>
        /// A unique identifier which refers to a particular job.
        ///  
        /// </summary>
        public string JobId
        {
            get { return this.jobId; }
            set { this.jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this.jobId != null;
        }

        /// <summary>
        /// The UTF-8 encoded text of the manifest file.
        ///  
        /// </summary>
        public string Manifest
        {
            get { return this.manifest; }
            set { this.manifest = value; }
        }

        // Check to see if Manifest property is set
        internal bool IsSetManifest()
        {
            return this.manifest != null;
        }

        /// <summary>
        /// Specifies whether the job to initiate is an import or export job.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>Import, Export</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public JobType JobType
        {
            get { return this.jobType; }
            set { this.jobType = value; }
        }

        // Check to see if JobType property is set
        internal bool IsSetJobType()
        {
            return this.jobType != null;
        }

        /// <summary>
        /// Validate the manifest and parameter values in the request but do not actually create a job.
        ///  
        /// </summary>
        public bool ValidateOnly
        {
            get { return this.validateOnly ?? default(bool); }
            set { this.validateOnly = value; }
        }

        // Check to see if ValidateOnly property is set
        internal bool IsSetValidateOnly()
        {
            return this.validateOnly.HasValue;
        }

    }
}
    
