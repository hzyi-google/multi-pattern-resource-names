// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Cloud.Talent.V4Beta1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Talent.V4Beta1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using Moq;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Threading.Tasks;
    using Xunit;

    /// <summary>Generated unit tests</summary>
    public class GeneratedJobServiceClientTest
    {
        [Fact]
        public void DeleteJob()
        {
            Mock<JobService.JobServiceClient> mockGrpcClient = new Mock<JobService.JobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteJobRequest expectedRequest = new DeleteJobRequest
            {
                JobNameOneof = "name3373707",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteJob(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            string name = "name3373707";
            client.DeleteJob(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteJobAsync()
        {
            Mock<JobService.JobServiceClient> mockGrpcClient = new Mock<JobService.JobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteJobRequest expectedRequest = new DeleteJobRequest
            {
                JobNameOneof = "name3373707",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteJobAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            string name = "name3373707";
            await client.DeleteJobAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteJob2()
        {
            Mock<JobService.JobServiceClient> mockGrpcClient = new Mock<JobService.JobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobNameOneof = "name3373707",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteJob(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteJob(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteJobAsync2()
        {
            Mock<JobService.JobServiceClient> mockGrpcClient = new Mock<JobService.JobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobNameOneof = "name3373707",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteJobAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteJobAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateJob()
        {
            Mock<JobService.JobServiceClient> mockGrpcClient = new Mock<JobService.JobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateJobRequest expectedRequest = new CreateJobRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                JobNameOneof = "name3373707",
                CompanyAsCompanyNameOneof = CompanyNameOneof.From(new CompanyWithoutTenantName("[PROJECT]", "[COMPANY]")),
                RequisitionId = "requisitionId980224926",
                Title = "title110371416",
                Description = "description-1724546052",
                Department = "department848184146",
                Incentives = "incentives-1262874520",
                LanguageCode = "languageCode-412800396",
                PromotionValue = 353413845,
                Qualifications = "qualifications1903501412",
                Responsibilities = "responsibilities-926952660",
                CompanyDisplayName = "companyDisplayName1982424170",
            };
            mockGrpcClient.Setup(x => x.CreateJob(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName parent = new ProjectName("[PROJECT]");
            Job job = new Job();
            Job response = client.CreateJob(parent, job);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateJobAsync()
        {
            Mock<JobService.JobServiceClient> mockGrpcClient = new Mock<JobService.JobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateJobRequest expectedRequest = new CreateJobRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                JobNameOneof = "name3373707",
                CompanyAsCompanyNameOneof = CompanyNameOneof.From(new CompanyWithoutTenantName("[PROJECT]", "[COMPANY]")),
                RequisitionId = "requisitionId980224926",
                Title = "title110371416",
                Description = "description-1724546052",
                Department = "department848184146",
                Incentives = "incentives-1262874520",
                LanguageCode = "languageCode-412800396",
                PromotionValue = 353413845,
                Qualifications = "qualifications1903501412",
                Responsibilities = "responsibilities-926952660",
                CompanyDisplayName = "companyDisplayName1982424170",
            };
            mockGrpcClient.Setup(x => x.CreateJobAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Job>(Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName parent = new ProjectName("[PROJECT]");
            Job job = new Job();
            Job response = await client.CreateJobAsync(parent, job);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateJob2()
        {
            Mock<JobService.JobServiceClient> mockGrpcClient = new Mock<JobService.JobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                JobNameOneof = "name3373707",
                CompanyAsCompanyNameOneof = CompanyNameOneof.From(new CompanyWithoutTenantName("[PROJECT]", "[COMPANY]")),
                RequisitionId = "requisitionId980224926",
                Title = "title110371416",
                Description = "description-1724546052",
                Department = "department848184146",
                Incentives = "incentives-1262874520",
                LanguageCode = "languageCode-412800396",
                PromotionValue = 353413845,
                Qualifications = "qualifications1903501412",
                Responsibilities = "responsibilities-926952660",
                CompanyDisplayName = "companyDisplayName1982424170",
            };
            mockGrpcClient.Setup(x => x.CreateJob(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job response = client.CreateJob(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateJobAsync2()
        {
            Mock<JobService.JobServiceClient> mockGrpcClient = new Mock<JobService.JobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                JobNameOneof = "name3373707",
                CompanyAsCompanyNameOneof = CompanyNameOneof.From(new CompanyWithoutTenantName("[PROJECT]", "[COMPANY]")),
                RequisitionId = "requisitionId980224926",
                Title = "title110371416",
                Description = "description-1724546052",
                Department = "department848184146",
                Incentives = "incentives-1262874520",
                LanguageCode = "languageCode-412800396",
                PromotionValue = 353413845,
                Qualifications = "qualifications1903501412",
                Responsibilities = "responsibilities-926952660",
                CompanyDisplayName = "companyDisplayName1982424170",
            };
            mockGrpcClient.Setup(x => x.CreateJobAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Job>(Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job response = await client.CreateJobAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetJob()
        {
            Mock<JobService.JobServiceClient> mockGrpcClient = new Mock<JobService.JobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetJobRequest expectedRequest = new GetJobRequest
            {
                JobNameOneof = "name3373707",
            };
            Job expectedResponse = new Job
            {
                JobNameOneof = "name2-1052831874",
                CompanyAsCompanyNameOneof = CompanyNameOneof.From(new CompanyWithoutTenantName("[PROJECT]", "[COMPANY]")),
                RequisitionId = "requisitionId980224926",
                Title = "title110371416",
                Description = "description-1724546052",
                Department = "department848184146",
                Incentives = "incentives-1262874520",
                LanguageCode = "languageCode-412800396",
                PromotionValue = 353413845,
                Qualifications = "qualifications1903501412",
                Responsibilities = "responsibilities-926952660",
                CompanyDisplayName = "companyDisplayName1982424170",
            };
            mockGrpcClient.Setup(x => x.GetJob(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            string name = "name3373707";
            Job response = client.GetJob(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetJobAsync()
        {
            Mock<JobService.JobServiceClient> mockGrpcClient = new Mock<JobService.JobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetJobRequest expectedRequest = new GetJobRequest
            {
                JobNameOneof = "name3373707",
            };
            Job expectedResponse = new Job
            {
                JobNameOneof = "name2-1052831874",
                CompanyAsCompanyNameOneof = CompanyNameOneof.From(new CompanyWithoutTenantName("[PROJECT]", "[COMPANY]")),
                RequisitionId = "requisitionId980224926",
                Title = "title110371416",
                Description = "description-1724546052",
                Department = "department848184146",
                Incentives = "incentives-1262874520",
                LanguageCode = "languageCode-412800396",
                PromotionValue = 353413845,
                Qualifications = "qualifications1903501412",
                Responsibilities = "responsibilities-926952660",
                CompanyDisplayName = "companyDisplayName1982424170",
            };
            mockGrpcClient.Setup(x => x.GetJobAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Job>(Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            string name = "name3373707";
            Job response = await client.GetJobAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetJob2()
        {
            Mock<JobService.JobServiceClient> mockGrpcClient = new Mock<JobService.JobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetJobRequest request = new GetJobRequest
            {
                JobNameOneof = "name3373707",
            };
            Job expectedResponse = new Job
            {
                JobNameOneof = "name2-1052831874",
                CompanyAsCompanyNameOneof = CompanyNameOneof.From(new CompanyWithoutTenantName("[PROJECT]", "[COMPANY]")),
                RequisitionId = "requisitionId980224926",
                Title = "title110371416",
                Description = "description-1724546052",
                Department = "department848184146",
                Incentives = "incentives-1262874520",
                LanguageCode = "languageCode-412800396",
                PromotionValue = 353413845,
                Qualifications = "qualifications1903501412",
                Responsibilities = "responsibilities-926952660",
                CompanyDisplayName = "companyDisplayName1982424170",
            };
            mockGrpcClient.Setup(x => x.GetJob(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job response = client.GetJob(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetJobAsync2()
        {
            Mock<JobService.JobServiceClient> mockGrpcClient = new Mock<JobService.JobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetJobRequest request = new GetJobRequest
            {
                JobNameOneof = "name3373707",
            };
            Job expectedResponse = new Job
            {
                JobNameOneof = "name2-1052831874",
                CompanyAsCompanyNameOneof = CompanyNameOneof.From(new CompanyWithoutTenantName("[PROJECT]", "[COMPANY]")),
                RequisitionId = "requisitionId980224926",
                Title = "title110371416",
                Description = "description-1724546052",
                Department = "department848184146",
                Incentives = "incentives-1262874520",
                LanguageCode = "languageCode-412800396",
                PromotionValue = 353413845,
                Qualifications = "qualifications1903501412",
                Responsibilities = "responsibilities-926952660",
                CompanyDisplayName = "companyDisplayName1982424170",
            };
            mockGrpcClient.Setup(x => x.GetJobAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Job>(Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job response = await client.GetJobAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateJob()
        {
            Mock<JobService.JobServiceClient> mockGrpcClient = new Mock<JobService.JobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateJobRequest expectedRequest = new UpdateJobRequest
            {
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                JobNameOneof = "name3373707",
                CompanyAsCompanyNameOneof = CompanyNameOneof.From(new CompanyWithoutTenantName("[PROJECT]", "[COMPANY]")),
                RequisitionId = "requisitionId980224926",
                Title = "title110371416",
                Description = "description-1724546052",
                Department = "department848184146",
                Incentives = "incentives-1262874520",
                LanguageCode = "languageCode-412800396",
                PromotionValue = 353413845,
                Qualifications = "qualifications1903501412",
                Responsibilities = "responsibilities-926952660",
                CompanyDisplayName = "companyDisplayName1982424170",
            };
            mockGrpcClient.Setup(x => x.UpdateJob(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job job = new Job();
            Job response = client.UpdateJob(job);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateJobAsync()
        {
            Mock<JobService.JobServiceClient> mockGrpcClient = new Mock<JobService.JobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateJobRequest expectedRequest = new UpdateJobRequest
            {
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                JobNameOneof = "name3373707",
                CompanyAsCompanyNameOneof = CompanyNameOneof.From(new CompanyWithoutTenantName("[PROJECT]", "[COMPANY]")),
                RequisitionId = "requisitionId980224926",
                Title = "title110371416",
                Description = "description-1724546052",
                Department = "department848184146",
                Incentives = "incentives-1262874520",
                LanguageCode = "languageCode-412800396",
                PromotionValue = 353413845,
                Qualifications = "qualifications1903501412",
                Responsibilities = "responsibilities-926952660",
                CompanyDisplayName = "companyDisplayName1982424170",
            };
            mockGrpcClient.Setup(x => x.UpdateJobAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Job>(Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job job = new Job();
            Job response = await client.UpdateJobAsync(job);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateJob2()
        {
            Mock<JobService.JobServiceClient> mockGrpcClient = new Mock<JobService.JobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateJobRequest request = new UpdateJobRequest
            {
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                JobNameOneof = "name3373707",
                CompanyAsCompanyNameOneof = CompanyNameOneof.From(new CompanyWithoutTenantName("[PROJECT]", "[COMPANY]")),
                RequisitionId = "requisitionId980224926",
                Title = "title110371416",
                Description = "description-1724546052",
                Department = "department848184146",
                Incentives = "incentives-1262874520",
                LanguageCode = "languageCode-412800396",
                PromotionValue = 353413845,
                Qualifications = "qualifications1903501412",
                Responsibilities = "responsibilities-926952660",
                CompanyDisplayName = "companyDisplayName1982424170",
            };
            mockGrpcClient.Setup(x => x.UpdateJob(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job response = client.UpdateJob(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateJobAsync2()
        {
            Mock<JobService.JobServiceClient> mockGrpcClient = new Mock<JobService.JobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateJobRequest request = new UpdateJobRequest
            {
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                JobNameOneof = "name3373707",
                CompanyAsCompanyNameOneof = CompanyNameOneof.From(new CompanyWithoutTenantName("[PROJECT]", "[COMPANY]")),
                RequisitionId = "requisitionId980224926",
                Title = "title110371416",
                Description = "description-1724546052",
                Department = "department848184146",
                Incentives = "incentives-1262874520",
                LanguageCode = "languageCode-412800396",
                PromotionValue = 353413845,
                Qualifications = "qualifications1903501412",
                Responsibilities = "responsibilities-926952660",
                CompanyDisplayName = "companyDisplayName1982424170",
            };
            mockGrpcClient.Setup(x => x.UpdateJobAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Job>(Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job response = await client.UpdateJobAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void BatchDeleteJobs()
        {
            Mock<JobService.JobServiceClient> mockGrpcClient = new Mock<JobService.JobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            BatchDeleteJobsRequest expectedRequest = new BatchDeleteJobsRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Filter = "filter-1274492040",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.BatchDeleteJobs(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName parent = new ProjectName("[PROJECT]");
            string filter = "filter-1274492040";
            client.BatchDeleteJobs(parent, filter);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task BatchDeleteJobsAsync()
        {
            Mock<JobService.JobServiceClient> mockGrpcClient = new Mock<JobService.JobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            BatchDeleteJobsRequest expectedRequest = new BatchDeleteJobsRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Filter = "filter-1274492040",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.BatchDeleteJobsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName parent = new ProjectName("[PROJECT]");
            string filter = "filter-1274492040";
            await client.BatchDeleteJobsAsync(parent, filter);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void BatchDeleteJobs2()
        {
            Mock<JobService.JobServiceClient> mockGrpcClient = new Mock<JobService.JobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            BatchDeleteJobsRequest request = new BatchDeleteJobsRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Filter = "filter-1274492040",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.BatchDeleteJobs(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            client.BatchDeleteJobs(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task BatchDeleteJobsAsync2()
        {
            Mock<JobService.JobServiceClient> mockGrpcClient = new Mock<JobService.JobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            BatchDeleteJobsRequest request = new BatchDeleteJobsRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Filter = "filter-1274492040",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.BatchDeleteJobsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            await client.BatchDeleteJobsAsync(request);
            mockGrpcClient.VerifyAll();
        }

    }
}
