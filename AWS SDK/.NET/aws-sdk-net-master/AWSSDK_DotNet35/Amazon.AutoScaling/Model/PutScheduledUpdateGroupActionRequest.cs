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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the PutScheduledUpdateGroupAction operation.
    /// <para> Creates or updates a scheduled scaling action for an Auto Scaling group. When updating a scheduled scaling action, if you leave a
    /// parameter unspecified, the corresponding value remains unchanged in the affected Auto Scaling group. </para> <para>For information on
    /// creating or updating a scheduled action for your Auto Scaling group, see <a
    /// href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/schedule_time.html" >Scale Based on a Schedule</a> .</para>
    /// <para><b>NOTE:</b> Auto Scaling supports the date and time expressed in "YYYY-MM-DDThh:mm:ssZ" format in UTC/GMT only. </para>
    /// </summary>
    public partial class PutScheduledUpdateGroupActionRequest : AmazonAutoScalingRequest
    {
        private string autoScalingGroupName;
        private string scheduledActionName;
        private DateTime? time;
        private DateTime? startTime;
        private DateTime? endTime;
        private string recurrence;
        private int? minSize;
        private int? maxSize;
        private int? desiredCapacity;


        /// <summary>
        /// The name or ARN of the Auto Scaling group.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1600</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AutoScalingGroupName
        {
            get { return this.autoScalingGroupName; }
            set { this.autoScalingGroupName = value; }
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this.autoScalingGroupName != null;
        }

        /// <summary>
        /// The name of this scaling action.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ScheduledActionName
        {
            get { return this.scheduledActionName; }
            set { this.scheduledActionName = value; }
        }

        // Check to see if ScheduledActionName property is set
        internal bool IsSetScheduledActionName()
        {
            return this.scheduledActionName != null;
        }

        /// <summary>
        /// <c>Time</c> is deprecated. The time for this action to start. <c>Time</c> is an alias for <c>StartTime</c> and can be specified instead of
        /// <c>StartTime</c>, or vice versa. If both <c>Time</c> and <c>StartTime</c> are specified, their values should be identical. Otherwise,
        /// <c>PutScheduledUpdateGroupAction</c> will return an error.
        ///  
        /// </summary>
        public DateTime Time
        {
            get { return this.time ?? default(DateTime); }
            set { this.time = value; }
        }

        // Check to see if Time property is set
        internal bool IsSetTime()
        {
            return this.time.HasValue;
        }

        /// <summary>
        /// The time for this action to start, as in <c>--start-time 2010-06-01T00:00:00Z</c>. If you try to schedule your action in the past, Auto
        /// Scaling returns an error message. When <c>StartTime</c> and <c>EndTime</c> are specified with <c>Recurrence</c>, they form the boundaries of
        /// when the recurring action will start and stop.
        ///  
        /// </summary>
        public DateTime StartTime
        {
            get { return this.startTime ?? default(DateTime); }
            set { this.startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this.startTime.HasValue;
        }

        /// <summary>
        /// The time for this action to end.
        ///  
        /// </summary>
        public DateTime EndTime
        {
            get { return this.endTime ?? default(DateTime); }
            set { this.endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this.endTime.HasValue;
        }

        /// <summary>
        /// The time when recurring future actions will start. Start time is specified by the user following the Unix cron syntax format. For
        /// information about cron syntax, go to <a href="http://en.wikipedia.org/wiki/Cron">Wikipedia, The Free Encyclopedia</a>. When <c>StartTime</c>
        /// and <c>EndTime</c> are specified with <c>Recurrence</c>, they form the boundaries of when the recurring action will start and stop.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Recurrence
        {
            get { return this.recurrence; }
            set { this.recurrence = value; }
        }

        // Check to see if Recurrence property is set
        internal bool IsSetRecurrence()
        {
            return this.recurrence != null;
        }

        /// <summary>
        /// The minimum size for the new Auto Scaling group.
        ///  
        /// </summary>
        public int MinSize
        {
            get { return this.minSize ?? default(int); }
            set { this.minSize = value; }
        }

        // Check to see if MinSize property is set
        internal bool IsSetMinSize()
        {
            return this.minSize.HasValue;
        }

        /// <summary>
        /// The maximum size for the Auto Scaling group.
        ///  
        /// </summary>
        public int MaxSize
        {
            get { return this.maxSize ?? default(int); }
            set { this.maxSize = value; }
        }

        // Check to see if MaxSize property is set
        internal bool IsSetMaxSize()
        {
            return this.maxSize.HasValue;
        }

        /// <summary>
        /// The number of Amazon EC2 instances that should be running in the group.
        ///  
        /// </summary>
        public int DesiredCapacity
        {
            get { return this.desiredCapacity ?? default(int); }
            set { this.desiredCapacity = value; }
        }

        // Check to see if DesiredCapacity property is set
        internal bool IsSetDesiredCapacity()
        {
            return this.desiredCapacity.HasValue;
        }

    }
}
    
