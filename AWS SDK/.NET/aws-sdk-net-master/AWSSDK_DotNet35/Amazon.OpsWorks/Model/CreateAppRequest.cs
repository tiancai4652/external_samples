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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the CreateApp operation.
    /// <para>Creates an app for a specified stack. For more information, see <a
    /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingapps-creating.html" >Creating Apps</a> .</para> <para> <b>Required
    /// Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an attached policy that explicitly
    /// grants permissions. For more information on user permissions, see <a
    /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
    /// </summary>
    public partial class CreateAppRequest : AmazonOpsWorksRequest
    {
        private string stackId;
        private string shortname;
        private string name;
        private string description;
        private AppType type;
        private Source appSource;
        private List<string> domains = new List<string>();
        private bool? enableSsl;
        private SslConfiguration sslConfiguration;
        private Dictionary<string,string> attributes = new Dictionary<string,string>();


        /// <summary>
        /// The stack ID.
        ///  
        /// </summary>
        public string StackId
        {
            get { return this.stackId; }
            set { this.stackId = value; }
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this.stackId != null;
        }

        /// <summary>
        /// The app's short name.
        ///  
        /// </summary>
        public string Shortname
        {
            get { return this.shortname; }
            set { this.shortname = value; }
        }

        // Check to see if Shortname property is set
        internal bool IsSetShortname()
        {
            return this.shortname != null;
        }

        /// <summary>
        /// The app name.
        ///  
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// A description of the app.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

        /// <summary>
        /// The app type. Each supported type is associated with a particular layer. For example, PHP applications are associated with a PHP layer. AWS
        /// OpsWorks deploys an application to those instances that are members of the corresponding layer.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>rails, php, nodejs, static, other</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public AppType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this.type != null;
        }

        /// <summary>
        /// A <c>Source</c> object that specifies the app repository.
        ///  
        /// </summary>
        public Source AppSource
        {
            get { return this.appSource; }
            set { this.appSource = value; }
        }

        // Check to see if AppSource property is set
        internal bool IsSetAppSource()
        {
            return this.appSource != null;
        }

        /// <summary>
        /// The app virtual host settings, with multiple domains separated by commas. For example: <c>'www.example.com, example.com'</c>
        ///  
        /// </summary>
        public List<string> Domains
        {
            get { return this.domains; }
            set { this.domains = value; }
        }

        // Check to see if Domains property is set
        internal bool IsSetDomains()
        {
            return this.domains.Count > 0;
        }

        /// <summary>
        /// Whether to enable SSL for the app.
        ///  
        /// </summary>
        public bool EnableSsl
        {
            get { return this.enableSsl ?? default(bool); }
            set { this.enableSsl = value; }
        }

        // Check to see if EnableSsl property is set
        internal bool IsSetEnableSsl()
        {
            return this.enableSsl.HasValue;
        }

        /// <summary>
        /// An <c>SslConfiguration</c> object with the SSL configuration.
        ///  
        /// </summary>
        public SslConfiguration SslConfiguration
        {
            get { return this.sslConfiguration; }
            set { this.sslConfiguration = value; }
        }

        // Check to see if SslConfiguration property is set
        internal bool IsSetSslConfiguration()
        {
            return this.sslConfiguration != null;
        }

        /// <summary>
        /// One or more user-defined key/value pairs to be added to the stack attributes bag.
        ///  
        /// </summary>
        public Dictionary<string,string> Attributes
        {
            get { return this.attributes; }
            set { this.attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this.attributes != null;
        }

    }
}
    
