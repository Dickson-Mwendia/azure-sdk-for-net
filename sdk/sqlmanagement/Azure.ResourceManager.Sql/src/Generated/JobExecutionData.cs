// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the JobExecution data model. </summary>
    public partial class JobExecutionData : Resource
    {
        /// <summary> Initializes a new instance of JobExecutionData. </summary>
        public JobExecutionData()
        {
        }

        /// <summary> Initializes a new instance of JobExecutionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="jobVersion"> The job version number. </param>
        /// <param name="stepName"> The job step name. </param>
        /// <param name="stepId"> The job step id. </param>
        /// <param name="jobExecutionId"> The unique identifier of the job execution. </param>
        /// <param name="lifecycle"> The detailed state of the job execution. </param>
        /// <param name="provisioningState"> The ARM provisioning state of the job execution. </param>
        /// <param name="createTime"> The time that the job execution was created. </param>
        /// <param name="startTime"> The time that the job execution started. </param>
        /// <param name="endTime"> The time that the job execution completed. </param>
        /// <param name="currentAttempts"> Number of times the job execution has been attempted. </param>
        /// <param name="currentAttemptStartTime"> Start time of the current attempt. </param>
        /// <param name="lastMessage"> The last status or error message. </param>
        /// <param name="target"> The target that this execution is executed on. </param>
        internal JobExecutionData(ResourceIdentifier id, string name, ResourceType type, int? jobVersion, string stepName, int? stepId, Guid? jobExecutionId, JobExecutionLifecycle? lifecycle, ProvisioningState? provisioningState, DateTimeOffset? createTime, DateTimeOffset? startTime, DateTimeOffset? endTime, int? currentAttempts, DateTimeOffset? currentAttemptStartTime, string lastMessage, JobExecutionTarget target) : base(id, name, type)
        {
            JobVersion = jobVersion;
            StepName = stepName;
            StepId = stepId;
            JobExecutionId = jobExecutionId;
            Lifecycle = lifecycle;
            ProvisioningState = provisioningState;
            CreateTime = createTime;
            StartTime = startTime;
            EndTime = endTime;
            CurrentAttempts = currentAttempts;
            CurrentAttemptStartTime = currentAttemptStartTime;
            LastMessage = lastMessage;
            Target = target;
        }

        /// <summary> The job version number. </summary>
        public int? JobVersion { get; }
        /// <summary> The job step name. </summary>
        public string StepName { get; }
        /// <summary> The job step id. </summary>
        public int? StepId { get; }
        /// <summary> The unique identifier of the job execution. </summary>
        public Guid? JobExecutionId { get; }
        /// <summary> The detailed state of the job execution. </summary>
        public JobExecutionLifecycle? Lifecycle { get; }
        /// <summary> The ARM provisioning state of the job execution. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The time that the job execution was created. </summary>
        public DateTimeOffset? CreateTime { get; }
        /// <summary> The time that the job execution started. </summary>
        public DateTimeOffset? StartTime { get; }
        /// <summary> The time that the job execution completed. </summary>
        public DateTimeOffset? EndTime { get; }
        /// <summary> Number of times the job execution has been attempted. </summary>
        public int? CurrentAttempts { get; set; }
        /// <summary> Start time of the current attempt. </summary>
        public DateTimeOffset? CurrentAttemptStartTime { get; }
        /// <summary> The last status or error message. </summary>
        public string LastMessage { get; }
        /// <summary> The target that this execution is executed on. </summary>
        public JobExecutionTarget Target { get; }
    }
}
