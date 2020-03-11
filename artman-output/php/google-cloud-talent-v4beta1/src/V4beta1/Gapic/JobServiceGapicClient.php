<?php
/*
 * Copyright 2020 Google LLC
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     https://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

/*
 * GENERATED CODE WARNING
 * This file was generated from the file
 * https://github.com/google/googleapis/blob/master/google/cloud/talent/v4beta1/job_service.proto
 * and updates to that file get reflected here through a refresh process.
 *
 * @experimental
 */

namespace Google\Cloud\Talent\V4beta1\Gapic;

use Google\ApiCore\ApiException;
use Google\ApiCore\CredentialsWrapper;
use Google\ApiCore\GapicClientTrait;
use Google\ApiCore\LongRunning\OperationsClient;
use Google\ApiCore\OperationResponse;
use Google\ApiCore\PathTemplate;
use Google\ApiCore\RequestParamsHeaderDescriptor;
use Google\ApiCore\RetrySettings;
use Google\ApiCore\Transport\TransportInterface;
use Google\ApiCore\ValidationException;
use Google\Auth\FetchAuthTokenInterface;
use Google\Cloud\Talent\V4beta1\BatchCreateJobsRequest;
use Google\Cloud\Talent\V4beta1\BatchDeleteJobsRequest;
use Google\Cloud\Talent\V4beta1\BatchUpdateJobsRequest;
use Google\Cloud\Talent\V4beta1\CreateJobRequest;
use Google\Cloud\Talent\V4beta1\DeleteJobRequest;
use Google\Cloud\Talent\V4beta1\GetJobRequest;
use Google\Cloud\Talent\V4beta1\HistogramQuery;
use Google\Cloud\Talent\V4beta1\Job;
use Google\Cloud\Talent\V4beta1\JobOperationResult;
use Google\Cloud\Talent\V4beta1\JobQuery;
use Google\Cloud\Talent\V4beta1\JobView;
use Google\Cloud\Talent\V4beta1\ListJobsRequest;
use Google\Cloud\Talent\V4beta1\ListJobsResponse;
use Google\Cloud\Talent\V4beta1\RequestMetadata;
use Google\Cloud\Talent\V4beta1\SearchJobsRequest;
use Google\Cloud\Talent\V4beta1\SearchJobsRequest\CustomRankingInfo;
use Google\Cloud\Talent\V4beta1\SearchJobsRequest\DiversificationLevel;
use Google\Cloud\Talent\V4beta1\SearchJobsRequest\SearchMode;
use Google\Cloud\Talent\V4beta1\SearchJobsResponse;
use Google\Cloud\Talent\V4beta1\UpdateJobRequest;
use Google\LongRunning\Operation;
use Google\Protobuf\FieldMask;
use Google\Protobuf\GPBEmpty;

/**
 * Service Description: A service handles job management, including job CRUD, enumeration and search.
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $jobServiceClient = new JobServiceClient();
 * try {
 *     $name = '';
 *     $jobServiceClient->deleteJob($name);
 * } finally {
 *     $jobServiceClient->close();
 * }
 * ```
 *
 * Many parameters require resource names to be formatted in a particular way. To assist
 * with these names, this class includes a format method for each type of name, and additionally
 * a parseName method to extract the individual identifiers contained within formatted names
 * that are returned by the API.
 *
 * @experimental
 */
class JobServiceGapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'google.cloud.talent.v4beta1.JobService';

    /**
     * The default address of the service.
     */
    const SERVICE_ADDRESS = 'jobs.googleapis.com';

    /**
     * The default port of the service.
     */
    const DEFAULT_SERVICE_PORT = 443;

    /**
     * The name of the code generator, to be included in the agent header.
     */
    const CODEGEN_NAME = 'gapic';

    /**
     * The default scopes required by the service.
     */
    public static $serviceScopes = [
        'https://www.googleapis.com/auth/cloud-platform',
        'https://www.googleapis.com/auth/jobs',
    ];
    private static $companyNameTemplate;
    private static $companyWithoutTenantNameTemplate;
    private static $jobNameTemplate;
    private static $jobWithoutTenantNameTemplate;
    private static $projectNameTemplate;
    private static $tenantNameTemplate;
    private static $pathTemplateMap;

    private $operationsClient;

    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS.':'.self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__.'/../resources/job_service_client_config.json',
            'descriptorsConfigPath' => __DIR__.'/../resources/job_service_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__.'/../resources/job_service_grpc_config.json',
            'credentialsConfig' => [
                'scopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__.'/../resources/job_service_rest_client_config.php',
                ],
            ],
        ];
    }

    private static function getCompanyNameTemplate()
    {
        if (null == self::$companyNameTemplate) {
            self::$companyNameTemplate = new PathTemplate('projects/{project}/tenants/{tenant}/companies/{company}');
        }

        return self::$companyNameTemplate;
    }

    private static function getCompanyWithoutTenantNameTemplate()
    {
        if (null == self::$companyWithoutTenantNameTemplate) {
            self::$companyWithoutTenantNameTemplate = new PathTemplate('projects/{project}/companies/{company}');
        }

        return self::$companyWithoutTenantNameTemplate;
    }

    private static function getJobNameTemplate()
    {
        if (null == self::$jobNameTemplate) {
            self::$jobNameTemplate = new PathTemplate('projects/{project}/tenants/{tenant}/jobs/{jobs}');
        }

        return self::$jobNameTemplate;
    }

    private static function getJobWithoutTenantNameTemplate()
    {
        if (null == self::$jobWithoutTenantNameTemplate) {
            self::$jobWithoutTenantNameTemplate = new PathTemplate('projects/{project}/jobs/{jobs}');
        }

        return self::$jobWithoutTenantNameTemplate;
    }

    private static function getProjectNameTemplate()
    {
        if (null == self::$projectNameTemplate) {
            self::$projectNameTemplate = new PathTemplate('projects/{project}');
        }

        return self::$projectNameTemplate;
    }

    private static function getTenantNameTemplate()
    {
        if (null == self::$tenantNameTemplate) {
            self::$tenantNameTemplate = new PathTemplate('projects/{project}/tenants/{tenant}');
        }

        return self::$tenantNameTemplate;
    }

    private static function getPathTemplateMap()
    {
        if (null == self::$pathTemplateMap) {
            self::$pathTemplateMap = [
                'company' => self::getCompanyNameTemplate(),
                'companyWithoutTenant' => self::getCompanyWithoutTenantNameTemplate(),
                'job' => self::getJobNameTemplate(),
                'jobWithoutTenant' => self::getJobWithoutTenantNameTemplate(),
                'project' => self::getProjectNameTemplate(),
                'tenant' => self::getTenantNameTemplate(),
            ];
        }

        return self::$pathTemplateMap;
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a company resource.
     *
     * @param string $project
     * @param string $tenant
     * @param string $company
     *
     * @return string The formatted company resource.
     *
     * @deprecated Multi-pattern resource names will have unified formatting functions.
     *             This helper function will be deleted in the next major version.
     */
    public static function companyName($project, $tenant, $company)
    {
        return self::getCompanyNameTemplate()->render([
            'project' => $project,
            'tenant' => $tenant,
            'company' => $company,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a company_without_tenant resource.
     *
     * @param string $project
     * @param string $company
     *
     * @return string The formatted company_without_tenant resource.
     *
     * @deprecated Multi-pattern resource names will have unified formatting functions.
     *             This helper function will be deleted in the next major version.
     */
    public static function companyWithoutTenantName($project, $company)
    {
        return self::getCompanyWithoutTenantNameTemplate()->render([
            'project' => $project,
            'company' => $company,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a job resource.
     *
     * @param string $project
     * @param string $tenant
     * @param string $jobs
     *
     * @return string The formatted job resource.
     *
     * @deprecated Multi-pattern resource names will have unified formatting functions.
     *             This helper function will be deleted in the next major version.
     */
    public static function jobName($project, $tenant, $jobs)
    {
        return self::getJobNameTemplate()->render([
            'project' => $project,
            'tenant' => $tenant,
            'jobs' => $jobs,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a job_without_tenant resource.
     *
     * @param string $project
     * @param string $jobs
     *
     * @return string The formatted job_without_tenant resource.
     *
     * @deprecated Multi-pattern resource names will have unified formatting functions.
     *             This helper function will be deleted in the next major version.
     */
    public static function jobWithoutTenantName($project, $jobs)
    {
        return self::getJobWithoutTenantNameTemplate()->render([
            'project' => $project,
            'jobs' => $jobs,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a project resource.
     *
     * @param string $project
     *
     * @return string The formatted project resource.
     * @experimental
     */
    public static function projectName($project)
    {
        return self::getProjectNameTemplate()->render([
            'project' => $project,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a tenant resource.
     *
     * @param string $project
     * @param string $tenant
     *
     * @return string The formatted tenant resource.
     * @experimental
     */
    public static function tenantName($project, $tenant)
    {
        return self::getTenantNameTemplate()->render([
            'project' => $project,
            'tenant' => $tenant,
        ]);
    }

    /**
     * Parses a formatted name string and returns an associative array of the components in the name.
     * The following name formats are supported:
     * Template: Pattern
     * - company: projects/{project}/tenants/{tenant}/companies/{company}
     * - companyWithoutTenant: projects/{project}/companies/{company}
     * - job: projects/{project}/tenants/{tenant}/jobs/{jobs}
     * - jobWithoutTenant: projects/{project}/jobs/{jobs}
     * - project: projects/{project}
     * - tenant: projects/{project}/tenants/{tenant}.
     *
     * The optional $template argument can be supplied to specify a particular pattern, and must
     * match one of the templates listed above. If no $template argument is provided, or if the
     * $template argument does not match one of the templates listed, then parseName will check
     * each of the supported templates, and return the first match.
     *
     * @param string $formattedName The formatted name string
     * @param string $template      Optional name of template to match
     *
     * @return array An associative array from name component IDs to component values.
     *
     * @throws ValidationException If $formattedName could not be matched.
     * @experimental
     */
    public static function parseName($formattedName, $template = null)
    {
        $templateMap = self::getPathTemplateMap();

        if ($template) {
            if (!isset($templateMap[$template])) {
                throw new ValidationException("Template name $template does not exist");
            }

            return $templateMap[$template]->match($formattedName);
        }

        foreach ($templateMap as $templateName => $pathTemplate) {
            try {
                return $pathTemplate->match($formattedName);
            } catch (ValidationException $ex) {
                // Swallow the exception to continue trying other path templates
            }
        }
        throw new ValidationException("Input did not match any known format. Input: $formattedName");
    }

    /**
     * Return an OperationsClient object with the same endpoint as $this.
     *
     * @return OperationsClient
     * @experimental
     */
    public function getOperationsClient()
    {
        return $this->operationsClient;
    }

    /**
     * Resume an existing long running operation that was previously started
     * by a long running API method. If $methodName is not provided, or does
     * not match a long running API method, then the operation can still be
     * resumed, but the OperationResponse object will not deserialize the
     * final response.
     *
     * @param string $operationName The name of the long running operation
     * @param string $methodName    The name of the method used to start the operation
     *
     * @return OperationResponse
     * @experimental
     */
    public function resumeOperation($operationName, $methodName = null)
    {
        $options = isset($this->descriptors[$methodName]['longRunning'])
            ? $this->descriptors[$methodName]['longRunning']
            : [];
        $operation = new OperationResponse($operationName, $this->getOperationsClient(), $options);
        $operation->reload();

        return $operation;
    }

    /**
     * Constructor.
     *
     * @param array $options {
     *                       Optional. Options for configuring the service API wrapper.
     *
     *     @type string $serviceAddress
     *           The address of the API remote host. May optionally include the port, formatted
     *           as "<uri>:<port>". Default 'jobs.googleapis.com:443'.
     *     @type string|array|FetchAuthTokenInterface|CredentialsWrapper $credentials
     *           The credentials to be used by the client to authorize API calls. This option
     *           accepts either a path to a credentials file, or a decoded credentials file as a
     *           PHP array.
     *           *Advanced usage*: In addition, this option can also accept a pre-constructed
     *           {@see \Google\Auth\FetchAuthTokenInterface} object or
     *           {@see \Google\ApiCore\CredentialsWrapper} object. Note that when one of these
     *           objects are provided, any settings in $credentialsConfig will be ignored.
     *     @type array $credentialsConfig
     *           Options used to configure credentials, including auth token caching, for the client.
     *           For a full list of supporting configuration options, see
     *           {@see \Google\ApiCore\CredentialsWrapper::build()}.
     *     @type bool $disableRetries
     *           Determines whether or not retries defined by the client configuration should be
     *           disabled. Defaults to `false`.
     *     @type string|array $clientConfig
     *           Client method configuration, including retry settings. This option can be either a
     *           path to a JSON file, or a PHP array containing the decoded JSON data.
     *           By default this settings points to the default client config file, which is provided
     *           in the resources folder.
     *     @type string|TransportInterface $transport
     *           The transport used for executing network requests. May be either the string `rest`
     *           or `grpc`. Defaults to `grpc` if gRPC support is detected on the system.
     *           *Advanced usage*: Additionally, it is possible to pass in an already instantiated
     *           {@see \Google\ApiCore\Transport\TransportInterface} object. Note that when this
     *           object is provided, any settings in $transportConfig, and any $serviceAddress
     *           setting, will be ignored.
     *     @type array $transportConfig
     *           Configuration options that will be used to construct the transport. Options for
     *           each supported transport type should be passed in a key for that transport. For
     *           example:
     *           $transportConfig = [
     *               'grpc' => [...],
     *               'rest' => [...]
     *           ];
     *           See the {@see \Google\ApiCore\Transport\GrpcTransport::build()} and
     *           {@see \Google\ApiCore\Transport\RestTransport::build()} methods for the
     *           supported options.
     * }
     *
     * @throws ValidationException
     * @experimental
     */
    public function __construct(array $options = [])
    {
        $clientOptions = $this->buildClientOptions($options);
        $this->setClientOptions($clientOptions);
        $this->operationsClient = $this->createOperationsClient($clientOptions);
    }

    /**
     * Deletes the specified job.
     *
     * Typically, the job becomes unsearchable within 10 seconds, but it may take
     * up to 5 minutes.
     *
     * Sample code:
     * ```
     * $jobServiceClient = new JobServiceClient();
     * try {
     *     $name = '';
     *     $jobServiceClient->deleteJob($name);
     * } finally {
     *     $jobServiceClient->close();
     * }
     * ```
     *
     * @param string $name Required. The resource name of the job to be deleted.
     *
     * The format is
     * "projects/{project_id}/tenants/{tenant_id}/jobs/{job_id}". For
     * example, "projects/foo/tenants/bar/jobs/baz".
     *
     * If tenant id is unspecified, the default tenant is used. For
     * example, "projects/foo/jobs/bar".
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function deleteJob($name, array $optionalArgs = [])
    {
        $request = new DeleteJobRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'DeleteJob',
            GPBEmpty::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Creates a new job.
     *
     * Typically, the job becomes searchable within 10 seconds, but it may take
     * up to 5 minutes.
     *
     * Sample code:
     * ```
     * $jobServiceClient = new JobServiceClient();
     * try {
     *     $formattedParent = $jobServiceClient->projectName('[PROJECT]');
     *     $job = new Job();
     *     $response = $jobServiceClient->createJob($formattedParent, $job);
     * } finally {
     *     $jobServiceClient->close();
     * }
     * ```
     *
     * @param string $parent Required. The resource name of the tenant under which the job is created.
     *
     * The format is "projects/{project_id}/tenants/{tenant_id}". For example,
     * "projects/foo/tenant/bar". If tenant id is unspecified a default tenant
     * is created. For example, "projects/foo".
     * @param Job   $job          Required. The Job to be created.
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Talent\V4beta1\Job
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function createJob($parent, $job, array $optionalArgs = [])
    {
        $request = new CreateJobRequest();
        $request->setParent($parent);
        $request->setJob($job);

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'CreateJob',
            Job::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Begins executing a batch create jobs operation.
     *
     * Sample code:
     * ```
     * $jobServiceClient = new JobServiceClient();
     * try {
     *     $formattedParent = $jobServiceClient->projectName('[PROJECT]');
     *     $jobs = [];
     *     $operationResponse = $jobServiceClient->batchCreateJobs($formattedParent, $jobs);
     *     $operationResponse->pollUntilComplete();
     *     if ($operationResponse->operationSucceeded()) {
     *         $result = $operationResponse->getResult();
     *         // doSomethingWith($result)
     *     } else {
     *         $error = $operationResponse->getError();
     *         // handleError($error)
     *     }
     *
     *
     *     // Alternatively:
     *
     *     // start the operation, keep the operation name, and resume later
     *     $operationResponse = $jobServiceClient->batchCreateJobs($formattedParent, $jobs);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $jobServiceClient->resumeOperation($operationName, 'batchCreateJobs');
     *     while (!$newOperationResponse->isDone()) {
     *         // ... do other work
     *         $newOperationResponse->reload();
     *     }
     *     if ($newOperationResponse->operationSucceeded()) {
     *       $result = $newOperationResponse->getResult();
     *       // doSomethingWith($result)
     *     } else {
     *       $error = $newOperationResponse->getError();
     *       // handleError($error)
     *     }
     * } finally {
     *     $jobServiceClient->close();
     * }
     * ```
     *
     * @param string $parent Required. The resource name of the tenant under which the job is created.
     *
     * The format is "projects/{project_id}/tenants/{tenant_id}". For example,
     * "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
     * is created. For example, "projects/foo".
     * @param Job[] $jobs         Required. The jobs to be created.
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\ApiCore\OperationResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function batchCreateJobs($parent, $jobs, array $optionalArgs = [])
    {
        $request = new BatchCreateJobsRequest();
        $request->setParent($parent);
        $request->setJobs($jobs);

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'BatchCreateJobs',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Retrieves the specified job, whose status is OPEN or recently EXPIRED
     * within the last 90 days.
     *
     * Sample code:
     * ```
     * $jobServiceClient = new JobServiceClient();
     * try {
     *     $name = '';
     *     $response = $jobServiceClient->getJob($name);
     * } finally {
     *     $jobServiceClient->close();
     * }
     * ```
     *
     * @param string $name Required. The resource name of the job to retrieve.
     *
     * The format is
     * "projects/{project_id}/tenants/{tenant_id}/jobs/{job_id}". For
     * example, "projects/foo/tenants/bar/jobs/baz".
     *
     * If tenant id is unspecified, the default tenant is used. For
     * example, "projects/foo/jobs/bar".
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Talent\V4beta1\Job
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getJob($name, array $optionalArgs = [])
    {
        $request = new GetJobRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetJob',
            Job::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Updates specified job.
     *
     * Typically, updated contents become visible in search results within 10
     * seconds, but it may take up to 5 minutes.
     *
     * Sample code:
     * ```
     * $jobServiceClient = new JobServiceClient();
     * try {
     *     $job = new Job();
     *     $response = $jobServiceClient->updateJob($job);
     * } finally {
     *     $jobServiceClient->close();
     * }
     * ```
     *
     * @param Job   $job          Required. The Job to be updated.
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type FieldMask $updateMask
     *          Strongly recommended for the best service experience.
     *
     *          If [update_mask][google.cloud.talent.v4beta1.UpdateJobRequest.update_mask] is provided, only the specified fields in
     *          [job][google.cloud.talent.v4beta1.UpdateJobRequest.job] are updated. Otherwise all the fields are updated.
     *
     *          A field mask to restrict the fields that are updated. Only
     *          top level fields of [Job][google.cloud.talent.v4beta1.Job] are supported.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Talent\V4beta1\Job
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function updateJob($job, array $optionalArgs = [])
    {
        $request = new UpdateJobRequest();
        $request->setJob($job);
        if (isset($optionalArgs['updateMask'])) {
            $request->setUpdateMask($optionalArgs['updateMask']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'job.name' => $request->getJob()->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'UpdateJob',
            Job::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Begins executing a batch update jobs operation.
     *
     * Sample code:
     * ```
     * $jobServiceClient = new JobServiceClient();
     * try {
     *     $formattedParent = $jobServiceClient->projectName('[PROJECT]');
     *     $jobs = [];
     *     $operationResponse = $jobServiceClient->batchUpdateJobs($formattedParent, $jobs);
     *     $operationResponse->pollUntilComplete();
     *     if ($operationResponse->operationSucceeded()) {
     *         $result = $operationResponse->getResult();
     *         // doSomethingWith($result)
     *     } else {
     *         $error = $operationResponse->getError();
     *         // handleError($error)
     *     }
     *
     *
     *     // Alternatively:
     *
     *     // start the operation, keep the operation name, and resume later
     *     $operationResponse = $jobServiceClient->batchUpdateJobs($formattedParent, $jobs);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $jobServiceClient->resumeOperation($operationName, 'batchUpdateJobs');
     *     while (!$newOperationResponse->isDone()) {
     *         // ... do other work
     *         $newOperationResponse->reload();
     *     }
     *     if ($newOperationResponse->operationSucceeded()) {
     *       $result = $newOperationResponse->getResult();
     *       // doSomethingWith($result)
     *     } else {
     *       $error = $newOperationResponse->getError();
     *       // handleError($error)
     *     }
     * } finally {
     *     $jobServiceClient->close();
     * }
     * ```
     *
     * @param string $parent Required. The resource name of the tenant under which the job is created.
     *
     * The format is "projects/{project_id}/tenants/{tenant_id}". For example,
     * "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
     * is created. For example, "projects/foo".
     * @param Job[] $jobs         Required. The jobs to be updated.
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type FieldMask $updateMask
     *          Strongly recommended for the best service experience. Be aware that it will
     *          also increase latency when checking the status of a batch operation.
     *
     *          If [update_mask][google.cloud.talent.v4beta1.BatchUpdateJobsRequest.update_mask] is provided, only the specified fields in
     *          [Job][google.cloud.talent.v4beta1.Job] are updated. Otherwise all the fields are updated.
     *
     *          A field mask to restrict the fields that are updated. Only
     *          top level fields of [Job][google.cloud.talent.v4beta1.Job] are supported.
     *
     *          If [update_mask][google.cloud.talent.v4beta1.BatchUpdateJobsRequest.update_mask] is provided, The [Job][google.cloud.talent.v4beta1.Job] inside
     *          [JobResult][google.cloud.talent.v4beta1.JobOperationResult.JobResult]
     *          will only contains fields that is updated, plus the Id of the Job.
     *          Otherwise,  [Job][google.cloud.talent.v4beta1.Job] will include all fields, which can yield a very
     *          large response.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\ApiCore\OperationResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function batchUpdateJobs($parent, $jobs, array $optionalArgs = [])
    {
        $request = new BatchUpdateJobsRequest();
        $request->setParent($parent);
        $request->setJobs($jobs);
        if (isset($optionalArgs['updateMask'])) {
            $request->setUpdateMask($optionalArgs['updateMask']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'BatchUpdateJobs',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Deletes a list of [Job][google.cloud.talent.v4beta1.Job]s by filter.
     *
     * Sample code:
     * ```
     * $jobServiceClient = new JobServiceClient();
     * try {
     *     $formattedParent = $jobServiceClient->projectName('[PROJECT]');
     *     $filter = '';
     *     $jobServiceClient->batchDeleteJobs($formattedParent, $filter);
     * } finally {
     *     $jobServiceClient->close();
     * }
     * ```
     *
     * @param string $parent Required. The resource name of the tenant under which the job is created.
     *
     * The format is "projects/{project_id}/tenants/{tenant_id}". For example,
     * "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
     * is created. For example, "projects/foo".
     * @param string $filter Required. The filter string specifies the jobs to be deleted.
     *
     * Supported operator: =, AND
     *
     * The fields eligible for filtering are:
     *
     * * `companyName` (Required)
     * * `requisitionId` (Required)
     *
     * Sample Query: companyName = "projects/foo/companies/bar" AND
     * requisitionId = "req-1"
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function batchDeleteJobs($parent, $filter, array $optionalArgs = [])
    {
        $request = new BatchDeleteJobsRequest();
        $request->setParent($parent);
        $request->setFilter($filter);

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'BatchDeleteJobs',
            GPBEmpty::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Lists jobs by filter.
     *
     * Sample code:
     * ```
     * $jobServiceClient = new JobServiceClient();
     * try {
     *     $formattedParent = $jobServiceClient->projectName('[PROJECT]');
     *     $filter = '';
     *     // Iterate over pages of elements
     *     $pagedResponse = $jobServiceClient->listJobs($formattedParent, $filter);
     *     foreach ($pagedResponse->iteratePages() as $page) {
     *         foreach ($page as $element) {
     *             // doSomethingWith($element);
     *         }
     *     }
     *
     *
     *     // Alternatively:
     *
     *     // Iterate through all elements
     *     $pagedResponse = $jobServiceClient->listJobs($formattedParent, $filter);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $jobServiceClient->close();
     * }
     * ```
     *
     * @param string $parent Required. The resource name of the tenant under which the job is created.
     *
     * The format is "projects/{project_id}/tenants/{tenant_id}". For example,
     * "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
     * is created. For example, "projects/foo".
     * @param string $filter Required. The filter string specifies the jobs to be enumerated.
     *
     * Supported operator: =, AND
     *
     * The fields eligible for filtering are:
     *
     * * `companyName` (Required)
     * * `requisitionId`
     * * `status` Available values: OPEN, EXPIRED, ALL. Defaults to
     * OPEN if no value is specified.
     *
     * Sample Query:
     *
     * * companyName = "projects/foo/tenants/bar/companies/baz"
     * * companyName = "projects/foo/tenants/bar/companies/baz" AND
     * requisitionId = "req-1"
     * * companyName = "projects/foo/tenants/bar/companies/baz" AND
     * status = "EXPIRED"
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $pageToken
     *          A page token is used to specify a page of values to be returned.
     *          If no page token is specified (the default), the first page
     *          of values will be returned. Any page token used here must have
     *          been generated by a previous call to the API.
     *     @type int $pageSize
     *          The maximum number of resources contained in the underlying API
     *          response. The API may return fewer values in a page, even if
     *          there are additional values to be retrieved.
     *     @type int $jobView
     *          The desired job attributes returned for jobs in the
     *          search response. Defaults to [JobView.JOB_VIEW_FULL][google.cloud.talent.v4beta1.JobView.JOB_VIEW_FULL] if no value is
     *          specified.
     *          For allowed values, use constants defined on {@see \Google\Cloud\Talent\V4beta1\JobView}
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\ApiCore\PagedListResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function listJobs($parent, $filter, array $optionalArgs = [])
    {
        $request = new ListJobsRequest();
        $request->setParent($parent);
        $request->setFilter($filter);
        if (isset($optionalArgs['pageToken'])) {
            $request->setPageToken($optionalArgs['pageToken']);
        }
        if (isset($optionalArgs['pageSize'])) {
            $request->setPageSize($optionalArgs['pageSize']);
        }
        if (isset($optionalArgs['jobView'])) {
            $request->setJobView($optionalArgs['jobView']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->getPagedListResponse(
            'ListJobs',
            $optionalArgs,
            ListJobsResponse::class,
            $request
        );
    }

    /**
     * Searches for jobs using the provided [SearchJobsRequest][google.cloud.talent.v4beta1.SearchJobsRequest].
     *
     * This call constrains the [visibility][google.cloud.talent.v4beta1.Job.visibility] of jobs
     * present in the database, and only returns jobs that the caller has
     * permission to search against.
     *
     * Sample code:
     * ```
     * $jobServiceClient = new JobServiceClient();
     * try {
     *     $formattedParent = $jobServiceClient->projectName('[PROJECT]');
     *     $requestMetadata = new RequestMetadata();
     *     // Iterate over pages of elements
     *     $pagedResponse = $jobServiceClient->searchJobs($formattedParent, $requestMetadata);
     *     foreach ($pagedResponse->iteratePages() as $page) {
     *         foreach ($page as $element) {
     *             // doSomethingWith($element);
     *         }
     *     }
     *
     *
     *     // Alternatively:
     *
     *     // Iterate through all elements
     *     $pagedResponse = $jobServiceClient->searchJobs($formattedParent, $requestMetadata);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $jobServiceClient->close();
     * }
     * ```
     *
     * @param string $parent Required. The resource name of the tenant to search within.
     *
     * The format is "projects/{project_id}/tenants/{tenant_id}". For example,
     * "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
     * is created. For example, "projects/foo".
     * @param RequestMetadata $requestMetadata Required. The meta information collected about the job searcher, used to improve the
     *                                         search quality of the service. The identifiers (such as `user_id`) are
     *                                         provided by users, and must be unique and consistent.
     * @param array           $optionalArgs    {
     *                                         Optional.
     *
     *     @type int $searchMode
     *          Mode of a search.
     *
     *          Defaults to [SearchMode.JOB_SEARCH][google.cloud.talent.v4beta1.SearchJobsRequest.SearchMode.JOB_SEARCH].
     *          For allowed values, use constants defined on {@see \Google\Cloud\Talent\V4beta1\SearchJobsRequest\SearchMode}
     *     @type JobQuery $jobQuery
     *          Query used to search against jobs, such as keyword, location filters, etc.
     *     @type bool $enableBroadening
     *          Controls whether to broaden the search when it produces sparse results.
     *          Broadened queries append results to the end of the matching results
     *          list.
     *
     *          Defaults to false.
     *     @type bool $requirePreciseResultSize
     *          Controls if the search job request requires the return of a precise
     *          count of the first 300 results. Setting this to `true` ensures
     *          consistency in the number of results per page. Best practice is to set this
     *          value to true if a client allows users to jump directly to a
     *          non-sequential search results page.
     *
     *          Enabling this flag may adversely impact performance.
     *
     *          Defaults to false.
     *     @type HistogramQuery[] $histogramQueries
     *          An expression specifies a histogram request against matching jobs.
     *
     *          Expression syntax is an aggregation function call with histogram facets and
     *          other options.
     *
     *          Available aggregation function calls are:
     *          * `count(string_histogram_facet)`: Count the number of matching entities,
     *          for each distinct attribute value.
     *          * `count(numeric_histogram_facet, list of buckets)`: Count the number of
     *          matching entities within each bucket.
     *
     *          Data types:
     *
     *          * Histogram facet: facet names with format [a-zA-Z][a-zA-Z0-9_]+.
     *          * String: string like "any string with backslash escape for quote(\")."
     *          * Number: whole number and floating point number like 10, -1 and -0.01.
     *          * List: list of elements with comma(,) separator surrounded by square
     *          brackets, for example, [1, 2, 3] and ["one", "two", "three"].
     *
     *          Built-in constants:
     *
     *          * MIN (minimum number similar to java Double.MIN_VALUE)
     *          * MAX (maximum number similar to java Double.MAX_VALUE)
     *
     *          Built-in functions:
     *
     *          * bucket(start, end[, label]): bucket built-in function creates a bucket
     *          with range of [start, end). Note that the end is exclusive, for example,
     *          bucket(1, MAX, "positive number") or bucket(1, 10).
     *
     *          Job histogram facets:
     *
     *          * company_display_name: histogram by [Job.company_display_name][google.cloud.talent.v4beta1.Job.company_display_name].
     *          * employment_type: histogram by [Job.employment_types][google.cloud.talent.v4beta1.Job.employment_types], for example,
     *            "FULL_TIME", "PART_TIME".
     *          * company_size: histogram by [CompanySize][google.cloud.talent.v4beta1.CompanySize], for example, "SMALL",
     *          "MEDIUM", "BIG".
     *          * publish_time_in_month: histogram by the [Job.posting_publish_time][google.cloud.talent.v4beta1.Job.posting_publish_time]
     *            in months.
     *            Must specify list of numeric buckets in spec.
     *          * publish_time_in_year: histogram by the [Job.posting_publish_time][google.cloud.talent.v4beta1.Job.posting_publish_time]
     *            in years.
     *            Must specify list of numeric buckets in spec.
     *          * degree_types: histogram by the [Job.degree_types][google.cloud.talent.v4beta1.Job.degree_types], for example,
     *            "Bachelors", "Masters".
     *          * job_level: histogram by the [Job.job_level][google.cloud.talent.v4beta1.Job.job_level], for example, "Entry
     *            Level".
     *          * country: histogram by the country code of jobs, for example, "US", "FR".
     *          * admin1: histogram by the admin1 code of jobs, which is a global
     *            placeholder referring to the state, province, or the particular term a
     *            country uses to define the geographic structure below the country level,
     *            for example, "CA", "IL".
     *          * city: histogram by a combination of the "city name, admin1 code". For
     *            example,  "Mountain View, CA", "New York, NY".
     *          * admin1_country: histogram by a combination of the "admin1 code, country",
     *            for example, "CA, US", "IL, US".
     *          * city_coordinate: histogram by the city center's GPS coordinates (latitude
     *            and longitude), for example, 37.4038522,-122.0987765. Since the
     *            coordinates of a city center can change, customers may need to refresh
     *            them periodically.
     *          * locale: histogram by the [Job.language_code][google.cloud.talent.v4beta1.Job.language_code], for example, "en-US",
     *            "fr-FR".
     *          * language: histogram by the language subtag of the [Job.language_code][google.cloud.talent.v4beta1.Job.language_code],
     *            for example, "en", "fr".
     *          * category: histogram by the [JobCategory][google.cloud.talent.v4beta1.JobCategory], for example,
     *            "COMPUTER_AND_IT", "HEALTHCARE".
     *          * base_compensation_unit: histogram by the
     *            [CompensationInfo.CompensationUnit][google.cloud.talent.v4beta1.CompensationInfo.CompensationUnit] of base
     *            salary, for example, "WEEKLY", "MONTHLY".
     *          * base_compensation: histogram by the base salary. Must specify list of
     *            numeric buckets to group results by.
     *          * annualized_base_compensation: histogram by the base annualized salary.
     *            Must specify list of numeric buckets to group results by.
     *          * annualized_total_compensation: histogram by the total annualized salary.
     *            Must specify list of numeric buckets to group results by.
     *          * string_custom_attribute: histogram by string [Job.custom_attributes][google.cloud.talent.v4beta1.Job.custom_attributes].
     *            Values can be accessed via square bracket notations like
     *            string_custom_attribute["key1"].
     *          * numeric_custom_attribute: histogram by numeric [Job.custom_attributes][google.cloud.talent.v4beta1.Job.custom_attributes].
     *            Values can be accessed via square bracket notations like
     *            numeric_custom_attribute["key1"]. Must specify list of numeric buckets to
     *            group results by.
     *
     *          Example expressions:
     *
     *          * `count(admin1)`
     *          * `count(base_compensation, [bucket(1000, 10000), bucket(10000, 100000),
     *          bucket(100000, MAX)])`
     *          * `count(string_custom_attribute["some-string-custom-attribute"])`
     *          * `count(numeric_custom_attribute["some-numeric-custom-attribute"],
     *            [bucket(MIN, 0, "negative"), bucket(0, MAX, "non-negative"])`
     *     @type int $jobView
     *          The desired job attributes returned for jobs in the search response.
     *          Defaults to [JobView.JOB_VIEW_SMALL][google.cloud.talent.v4beta1.JobView.JOB_VIEW_SMALL] if no value is specified.
     *          For allowed values, use constants defined on {@see \Google\Cloud\Talent\V4beta1\JobView}
     *     @type int $offset
     *          An integer that specifies the current offset (that is, starting result
     *          location, amongst the jobs deemed by the API as relevant) in search
     *          results. This field is only considered if [page_token][google.cloud.talent.v4beta1.SearchJobsRequest.page_token] is unset.
     *
     *          The maximum allowed value is 5000. Otherwise an error is thrown.
     *
     *          For example, 0 means to  return results starting from the first matching
     *          job, and 10 means to return from the 11th job. This can be used for
     *          pagination, (for example, pageSize = 10 and offset = 10 means to return
     *          from the second page).
     *     @type int $pageSize
     *          The maximum number of resources contained in the underlying API
     *          response. The API may return fewer values in a page, even if
     *          there are additional values to be retrieved.
     *     @type string $pageToken
     *          A page token is used to specify a page of values to be returned.
     *          If no page token is specified (the default), the first page
     *          of values will be returned. Any page token used here must have
     *          been generated by a previous call to the API.
     *     @type string $orderBy
     *          The criteria determining how search results are sorted. Default is
     *          `"relevance desc"`.
     *
     *          Supported options are:
     *
     *          * `"relevance desc"`: By relevance descending, as determined by the API
     *            algorithms. Relevance thresholding of query results is only available
     *            with this ordering.
     *          * `"posting_publish_time desc"`: By [Job.posting_publish_time][google.cloud.talent.v4beta1.Job.posting_publish_time]
     *            descending.
     *          * `"posting_update_time desc"`: By [Job.posting_update_time][google.cloud.talent.v4beta1.Job.posting_update_time]
     *            descending.
     *          * `"title"`: By [Job.title][google.cloud.talent.v4beta1.Job.title] ascending.
     *          * `"title desc"`: By [Job.title][google.cloud.talent.v4beta1.Job.title] descending.
     *          * `"annualized_base_compensation"`: By job's
     *            [CompensationInfo.annualized_base_compensation_range][google.cloud.talent.v4beta1.CompensationInfo.annualized_base_compensation_range] ascending. Jobs
     *            whose annualized base compensation is unspecified are put at the end of
     *            search results.
     *          * `"annualized_base_compensation desc"`: By job's
     *            [CompensationInfo.annualized_base_compensation_range][google.cloud.talent.v4beta1.CompensationInfo.annualized_base_compensation_range] descending. Jobs
     *            whose annualized base compensation is unspecified are put at the end of
     *            search results.
     *          * `"annualized_total_compensation"`: By job's
     *            [CompensationInfo.annualized_total_compensation_range][google.cloud.talent.v4beta1.CompensationInfo.annualized_total_compensation_range] ascending. Jobs
     *            whose annualized base compensation is unspecified are put at the end of
     *            search results.
     *          * `"annualized_total_compensation desc"`: By job's
     *            [CompensationInfo.annualized_total_compensation_range][google.cloud.talent.v4beta1.CompensationInfo.annualized_total_compensation_range] descending. Jobs
     *            whose annualized base compensation is unspecified are put at the end of
     *            search results.
     *          * `"custom_ranking desc"`: By the relevance score adjusted to the
     *            [SearchJobsRequest.CustomRankingInfo.ranking_expression][google.cloud.talent.v4beta1.SearchJobsRequest.CustomRankingInfo.ranking_expression] with weight
     *            factor assigned by
     *            [SearchJobsRequest.CustomRankingInfo.importance_level][google.cloud.talent.v4beta1.SearchJobsRequest.CustomRankingInfo.importance_level] in descending
     *            order.
     *          * Location sorting: Use the special syntax to order jobs by distance:<br>
     *            `"distance_from('Hawaii')"`: Order by distance from Hawaii.<br>
     *            `"distance_from(19.89, 155.5)"`: Order by distance from a coordinate.<br>
     *            `"distance_from('Hawaii'), distance_from('Puerto Rico')"`: Order by
     *            multiple locations. See details below.<br>
     *            `"distance_from('Hawaii'), distance_from(19.89, 155.5)"`: Order by
     *            multiple locations. See details below.<br>
     *            The string can have a maximum of 256 characters. When multiple distance
     *            centers are provided, a job that is close to any of the distance centers
     *            would have a high rank. When a job has multiple locations, the job
     *            location closest to one of the distance centers will be used. Jobs that
     *            don't have locations will be ranked at the bottom. Distance is calculated
     *            with a precision of 11.3 meters (37.4 feet). Diversification strategy is
     *            still applied unless explicitly disabled in
     *            [diversification_level][google.cloud.talent.v4beta1.SearchJobsRequest.diversification_level].
     *     @type int $diversificationLevel
     *          Controls whether highly similar jobs are returned next to each other in
     *          the search results. Jobs are identified as highly similar based on
     *          their titles, job categories, and locations. Highly similar results are
     *          clustered so that only one representative job of the cluster is
     *          displayed to the job seeker higher up in the results, with the other jobs
     *          being displayed lower down in the results.
     *
     *          Defaults to [DiversificationLevel.SIMPLE][google.cloud.talent.v4beta1.SearchJobsRequest.DiversificationLevel.SIMPLE] if no value
     *          is specified.
     *          For allowed values, use constants defined on {@see \Google\Cloud\Talent\V4beta1\SearchJobsRequest\DiversificationLevel}
     *     @type CustomRankingInfo $customRankingInfo
     *          Controls over how job documents get ranked on top of existing relevance
     *          score (determined by API algorithm).
     *     @type bool $disableKeywordMatch
     *          Controls whether to disable exact keyword match on [Job.title][google.cloud.talent.v4beta1.Job.title],
     *          [Job.description][google.cloud.talent.v4beta1.Job.description], [Job.company_display_name][google.cloud.talent.v4beta1.Job.company_display_name], [Job.addresses][google.cloud.talent.v4beta1.Job.addresses],
     *          [Job.qualifications][google.cloud.talent.v4beta1.Job.qualifications]. When disable keyword match is turned off, a
     *          keyword match returns jobs that do not match given category filters when
     *          there are matching keywords. For example, for the query "program manager,"
     *          a result is returned even if the job posting has the title "software
     *          developer," which doesn't fall into "program manager" ontology, but does
     *          have "program manager" appearing in its description.
     *
     *          For queries like "cloud" that don't contain title or
     *          location specific ontology, jobs with "cloud" keyword matches are returned
     *          regardless of this flag's value.
     *
     *          Use [Company.keyword_searchable_job_custom_attributes][google.cloud.talent.v4beta1.Company.keyword_searchable_job_custom_attributes] if
     *          company-specific globally matched custom field/attribute string values are
     *          needed. Enabling keyword match improves recall of subsequent search
     *          requests.
     *
     *          Defaults to false.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\ApiCore\PagedListResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function searchJobs($parent, $requestMetadata, array $optionalArgs = [])
    {
        $request = new SearchJobsRequest();
        $request->setParent($parent);
        $request->setRequestMetadata($requestMetadata);
        if (isset($optionalArgs['searchMode'])) {
            $request->setSearchMode($optionalArgs['searchMode']);
        }
        if (isset($optionalArgs['jobQuery'])) {
            $request->setJobQuery($optionalArgs['jobQuery']);
        }
        if (isset($optionalArgs['enableBroadening'])) {
            $request->setEnableBroadening($optionalArgs['enableBroadening']);
        }
        if (isset($optionalArgs['requirePreciseResultSize'])) {
            $request->setRequirePreciseResultSize($optionalArgs['requirePreciseResultSize']);
        }
        if (isset($optionalArgs['histogramQueries'])) {
            $request->setHistogramQueries($optionalArgs['histogramQueries']);
        }
        if (isset($optionalArgs['jobView'])) {
            $request->setJobView($optionalArgs['jobView']);
        }
        if (isset($optionalArgs['offset'])) {
            $request->setOffset($optionalArgs['offset']);
        }
        if (isset($optionalArgs['pageSize'])) {
            $request->setPageSize($optionalArgs['pageSize']);
        }
        if (isset($optionalArgs['pageToken'])) {
            $request->setPageToken($optionalArgs['pageToken']);
        }
        if (isset($optionalArgs['orderBy'])) {
            $request->setOrderBy($optionalArgs['orderBy']);
        }
        if (isset($optionalArgs['diversificationLevel'])) {
            $request->setDiversificationLevel($optionalArgs['diversificationLevel']);
        }
        if (isset($optionalArgs['customRankingInfo'])) {
            $request->setCustomRankingInfo($optionalArgs['customRankingInfo']);
        }
        if (isset($optionalArgs['disableKeywordMatch'])) {
            $request->setDisableKeywordMatch($optionalArgs['disableKeywordMatch']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->getPagedListResponse(
            'SearchJobs',
            $optionalArgs,
            SearchJobsResponse::class,
            $request
        );
    }

    /**
     * Searches for jobs using the provided [SearchJobsRequest][google.cloud.talent.v4beta1.SearchJobsRequest].
     *
     * This API call is intended for the use case of targeting passive job
     * seekers (for example, job seekers who have signed up to receive email
     * alerts about potential job opportunities), and has different algorithmic
     * adjustments that are targeted to passive job seekers.
     *
     * This call constrains the [visibility][google.cloud.talent.v4beta1.Job.visibility] of jobs
     * present in the database, and only returns jobs the caller has
     * permission to search against.
     *
     * Sample code:
     * ```
     * $jobServiceClient = new JobServiceClient();
     * try {
     *     $formattedParent = $jobServiceClient->projectName('[PROJECT]');
     *     $requestMetadata = new RequestMetadata();
     *     // Iterate over pages of elements
     *     $pagedResponse = $jobServiceClient->searchJobsForAlert($formattedParent, $requestMetadata);
     *     foreach ($pagedResponse->iteratePages() as $page) {
     *         foreach ($page as $element) {
     *             // doSomethingWith($element);
     *         }
     *     }
     *
     *
     *     // Alternatively:
     *
     *     // Iterate through all elements
     *     $pagedResponse = $jobServiceClient->searchJobsForAlert($formattedParent, $requestMetadata);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $jobServiceClient->close();
     * }
     * ```
     *
     * @param string $parent Required. The resource name of the tenant to search within.
     *
     * The format is "projects/{project_id}/tenants/{tenant_id}". For example,
     * "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
     * is created. For example, "projects/foo".
     * @param RequestMetadata $requestMetadata Required. The meta information collected about the job searcher, used to improve the
     *                                         search quality of the service. The identifiers (such as `user_id`) are
     *                                         provided by users, and must be unique and consistent.
     * @param array           $optionalArgs    {
     *                                         Optional.
     *
     *     @type int $searchMode
     *          Mode of a search.
     *
     *          Defaults to [SearchMode.JOB_SEARCH][google.cloud.talent.v4beta1.SearchJobsRequest.SearchMode.JOB_SEARCH].
     *          For allowed values, use constants defined on {@see \Google\Cloud\Talent\V4beta1\SearchJobsRequest\SearchMode}
     *     @type JobQuery $jobQuery
     *          Query used to search against jobs, such as keyword, location filters, etc.
     *     @type bool $enableBroadening
     *          Controls whether to broaden the search when it produces sparse results.
     *          Broadened queries append results to the end of the matching results
     *          list.
     *
     *          Defaults to false.
     *     @type bool $requirePreciseResultSize
     *          Controls if the search job request requires the return of a precise
     *          count of the first 300 results. Setting this to `true` ensures
     *          consistency in the number of results per page. Best practice is to set this
     *          value to true if a client allows users to jump directly to a
     *          non-sequential search results page.
     *
     *          Enabling this flag may adversely impact performance.
     *
     *          Defaults to false.
     *     @type HistogramQuery[] $histogramQueries
     *          An expression specifies a histogram request against matching jobs.
     *
     *          Expression syntax is an aggregation function call with histogram facets and
     *          other options.
     *
     *          Available aggregation function calls are:
     *          * `count(string_histogram_facet)`: Count the number of matching entities,
     *          for each distinct attribute value.
     *          * `count(numeric_histogram_facet, list of buckets)`: Count the number of
     *          matching entities within each bucket.
     *
     *          Data types:
     *
     *          * Histogram facet: facet names with format [a-zA-Z][a-zA-Z0-9_]+.
     *          * String: string like "any string with backslash escape for quote(\")."
     *          * Number: whole number and floating point number like 10, -1 and -0.01.
     *          * List: list of elements with comma(,) separator surrounded by square
     *          brackets, for example, [1, 2, 3] and ["one", "two", "three"].
     *
     *          Built-in constants:
     *
     *          * MIN (minimum number similar to java Double.MIN_VALUE)
     *          * MAX (maximum number similar to java Double.MAX_VALUE)
     *
     *          Built-in functions:
     *
     *          * bucket(start, end[, label]): bucket built-in function creates a bucket
     *          with range of [start, end). Note that the end is exclusive, for example,
     *          bucket(1, MAX, "positive number") or bucket(1, 10).
     *
     *          Job histogram facets:
     *
     *          * company_display_name: histogram by [Job.company_display_name][google.cloud.talent.v4beta1.Job.company_display_name].
     *          * employment_type: histogram by [Job.employment_types][google.cloud.talent.v4beta1.Job.employment_types], for example,
     *            "FULL_TIME", "PART_TIME".
     *          * company_size: histogram by [CompanySize][google.cloud.talent.v4beta1.CompanySize], for example, "SMALL",
     *          "MEDIUM", "BIG".
     *          * publish_time_in_month: histogram by the [Job.posting_publish_time][google.cloud.talent.v4beta1.Job.posting_publish_time]
     *            in months.
     *            Must specify list of numeric buckets in spec.
     *          * publish_time_in_year: histogram by the [Job.posting_publish_time][google.cloud.talent.v4beta1.Job.posting_publish_time]
     *            in years.
     *            Must specify list of numeric buckets in spec.
     *          * degree_types: histogram by the [Job.degree_types][google.cloud.talent.v4beta1.Job.degree_types], for example,
     *            "Bachelors", "Masters".
     *          * job_level: histogram by the [Job.job_level][google.cloud.talent.v4beta1.Job.job_level], for example, "Entry
     *            Level".
     *          * country: histogram by the country code of jobs, for example, "US", "FR".
     *          * admin1: histogram by the admin1 code of jobs, which is a global
     *            placeholder referring to the state, province, or the particular term a
     *            country uses to define the geographic structure below the country level,
     *            for example, "CA", "IL".
     *          * city: histogram by a combination of the "city name, admin1 code". For
     *            example,  "Mountain View, CA", "New York, NY".
     *          * admin1_country: histogram by a combination of the "admin1 code, country",
     *            for example, "CA, US", "IL, US".
     *          * city_coordinate: histogram by the city center's GPS coordinates (latitude
     *            and longitude), for example, 37.4038522,-122.0987765. Since the
     *            coordinates of a city center can change, customers may need to refresh
     *            them periodically.
     *          * locale: histogram by the [Job.language_code][google.cloud.talent.v4beta1.Job.language_code], for example, "en-US",
     *            "fr-FR".
     *          * language: histogram by the language subtag of the [Job.language_code][google.cloud.talent.v4beta1.Job.language_code],
     *            for example, "en", "fr".
     *          * category: histogram by the [JobCategory][google.cloud.talent.v4beta1.JobCategory], for example,
     *            "COMPUTER_AND_IT", "HEALTHCARE".
     *          * base_compensation_unit: histogram by the
     *            [CompensationInfo.CompensationUnit][google.cloud.talent.v4beta1.CompensationInfo.CompensationUnit] of base
     *            salary, for example, "WEEKLY", "MONTHLY".
     *          * base_compensation: histogram by the base salary. Must specify list of
     *            numeric buckets to group results by.
     *          * annualized_base_compensation: histogram by the base annualized salary.
     *            Must specify list of numeric buckets to group results by.
     *          * annualized_total_compensation: histogram by the total annualized salary.
     *            Must specify list of numeric buckets to group results by.
     *          * string_custom_attribute: histogram by string [Job.custom_attributes][google.cloud.talent.v4beta1.Job.custom_attributes].
     *            Values can be accessed via square bracket notations like
     *            string_custom_attribute["key1"].
     *          * numeric_custom_attribute: histogram by numeric [Job.custom_attributes][google.cloud.talent.v4beta1.Job.custom_attributes].
     *            Values can be accessed via square bracket notations like
     *            numeric_custom_attribute["key1"]. Must specify list of numeric buckets to
     *            group results by.
     *
     *          Example expressions:
     *
     *          * `count(admin1)`
     *          * `count(base_compensation, [bucket(1000, 10000), bucket(10000, 100000),
     *          bucket(100000, MAX)])`
     *          * `count(string_custom_attribute["some-string-custom-attribute"])`
     *          * `count(numeric_custom_attribute["some-numeric-custom-attribute"],
     *            [bucket(MIN, 0, "negative"), bucket(0, MAX, "non-negative"])`
     *     @type int $jobView
     *          The desired job attributes returned for jobs in the search response.
     *          Defaults to [JobView.JOB_VIEW_SMALL][google.cloud.talent.v4beta1.JobView.JOB_VIEW_SMALL] if no value is specified.
     *          For allowed values, use constants defined on {@see \Google\Cloud\Talent\V4beta1\JobView}
     *     @type int $offset
     *          An integer that specifies the current offset (that is, starting result
     *          location, amongst the jobs deemed by the API as relevant) in search
     *          results. This field is only considered if [page_token][google.cloud.talent.v4beta1.SearchJobsRequest.page_token] is unset.
     *
     *          The maximum allowed value is 5000. Otherwise an error is thrown.
     *
     *          For example, 0 means to  return results starting from the first matching
     *          job, and 10 means to return from the 11th job. This can be used for
     *          pagination, (for example, pageSize = 10 and offset = 10 means to return
     *          from the second page).
     *     @type int $pageSize
     *          The maximum number of resources contained in the underlying API
     *          response. The API may return fewer values in a page, even if
     *          there are additional values to be retrieved.
     *     @type string $pageToken
     *          A page token is used to specify a page of values to be returned.
     *          If no page token is specified (the default), the first page
     *          of values will be returned. Any page token used here must have
     *          been generated by a previous call to the API.
     *     @type string $orderBy
     *          The criteria determining how search results are sorted. Default is
     *          `"relevance desc"`.
     *
     *          Supported options are:
     *
     *          * `"relevance desc"`: By relevance descending, as determined by the API
     *            algorithms. Relevance thresholding of query results is only available
     *            with this ordering.
     *          * `"posting_publish_time desc"`: By [Job.posting_publish_time][google.cloud.talent.v4beta1.Job.posting_publish_time]
     *            descending.
     *          * `"posting_update_time desc"`: By [Job.posting_update_time][google.cloud.talent.v4beta1.Job.posting_update_time]
     *            descending.
     *          * `"title"`: By [Job.title][google.cloud.talent.v4beta1.Job.title] ascending.
     *          * `"title desc"`: By [Job.title][google.cloud.talent.v4beta1.Job.title] descending.
     *          * `"annualized_base_compensation"`: By job's
     *            [CompensationInfo.annualized_base_compensation_range][google.cloud.talent.v4beta1.CompensationInfo.annualized_base_compensation_range] ascending. Jobs
     *            whose annualized base compensation is unspecified are put at the end of
     *            search results.
     *          * `"annualized_base_compensation desc"`: By job's
     *            [CompensationInfo.annualized_base_compensation_range][google.cloud.talent.v4beta1.CompensationInfo.annualized_base_compensation_range] descending. Jobs
     *            whose annualized base compensation is unspecified are put at the end of
     *            search results.
     *          * `"annualized_total_compensation"`: By job's
     *            [CompensationInfo.annualized_total_compensation_range][google.cloud.talent.v4beta1.CompensationInfo.annualized_total_compensation_range] ascending. Jobs
     *            whose annualized base compensation is unspecified are put at the end of
     *            search results.
     *          * `"annualized_total_compensation desc"`: By job's
     *            [CompensationInfo.annualized_total_compensation_range][google.cloud.talent.v4beta1.CompensationInfo.annualized_total_compensation_range] descending. Jobs
     *            whose annualized base compensation is unspecified are put at the end of
     *            search results.
     *          * `"custom_ranking desc"`: By the relevance score adjusted to the
     *            [SearchJobsRequest.CustomRankingInfo.ranking_expression][google.cloud.talent.v4beta1.SearchJobsRequest.CustomRankingInfo.ranking_expression] with weight
     *            factor assigned by
     *            [SearchJobsRequest.CustomRankingInfo.importance_level][google.cloud.talent.v4beta1.SearchJobsRequest.CustomRankingInfo.importance_level] in descending
     *            order.
     *          * Location sorting: Use the special syntax to order jobs by distance:<br>
     *            `"distance_from('Hawaii')"`: Order by distance from Hawaii.<br>
     *            `"distance_from(19.89, 155.5)"`: Order by distance from a coordinate.<br>
     *            `"distance_from('Hawaii'), distance_from('Puerto Rico')"`: Order by
     *            multiple locations. See details below.<br>
     *            `"distance_from('Hawaii'), distance_from(19.89, 155.5)"`: Order by
     *            multiple locations. See details below.<br>
     *            The string can have a maximum of 256 characters. When multiple distance
     *            centers are provided, a job that is close to any of the distance centers
     *            would have a high rank. When a job has multiple locations, the job
     *            location closest to one of the distance centers will be used. Jobs that
     *            don't have locations will be ranked at the bottom. Distance is calculated
     *            with a precision of 11.3 meters (37.4 feet). Diversification strategy is
     *            still applied unless explicitly disabled in
     *            [diversification_level][google.cloud.talent.v4beta1.SearchJobsRequest.diversification_level].
     *     @type int $diversificationLevel
     *          Controls whether highly similar jobs are returned next to each other in
     *          the search results. Jobs are identified as highly similar based on
     *          their titles, job categories, and locations. Highly similar results are
     *          clustered so that only one representative job of the cluster is
     *          displayed to the job seeker higher up in the results, with the other jobs
     *          being displayed lower down in the results.
     *
     *          Defaults to [DiversificationLevel.SIMPLE][google.cloud.talent.v4beta1.SearchJobsRequest.DiversificationLevel.SIMPLE] if no value
     *          is specified.
     *          For allowed values, use constants defined on {@see \Google\Cloud\Talent\V4beta1\SearchJobsRequest\DiversificationLevel}
     *     @type CustomRankingInfo $customRankingInfo
     *          Controls over how job documents get ranked on top of existing relevance
     *          score (determined by API algorithm).
     *     @type bool $disableKeywordMatch
     *          Controls whether to disable exact keyword match on [Job.title][google.cloud.talent.v4beta1.Job.title],
     *          [Job.description][google.cloud.talent.v4beta1.Job.description], [Job.company_display_name][google.cloud.talent.v4beta1.Job.company_display_name], [Job.addresses][google.cloud.talent.v4beta1.Job.addresses],
     *          [Job.qualifications][google.cloud.talent.v4beta1.Job.qualifications]. When disable keyword match is turned off, a
     *          keyword match returns jobs that do not match given category filters when
     *          there are matching keywords. For example, for the query "program manager,"
     *          a result is returned even if the job posting has the title "software
     *          developer," which doesn't fall into "program manager" ontology, but does
     *          have "program manager" appearing in its description.
     *
     *          For queries like "cloud" that don't contain title or
     *          location specific ontology, jobs with "cloud" keyword matches are returned
     *          regardless of this flag's value.
     *
     *          Use [Company.keyword_searchable_job_custom_attributes][google.cloud.talent.v4beta1.Company.keyword_searchable_job_custom_attributes] if
     *          company-specific globally matched custom field/attribute string values are
     *          needed. Enabling keyword match improves recall of subsequent search
     *          requests.
     *
     *          Defaults to false.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\ApiCore\PagedListResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function searchJobsForAlert($parent, $requestMetadata, array $optionalArgs = [])
    {
        $request = new SearchJobsRequest();
        $request->setParent($parent);
        $request->setRequestMetadata($requestMetadata);
        if (isset($optionalArgs['searchMode'])) {
            $request->setSearchMode($optionalArgs['searchMode']);
        }
        if (isset($optionalArgs['jobQuery'])) {
            $request->setJobQuery($optionalArgs['jobQuery']);
        }
        if (isset($optionalArgs['enableBroadening'])) {
            $request->setEnableBroadening($optionalArgs['enableBroadening']);
        }
        if (isset($optionalArgs['requirePreciseResultSize'])) {
            $request->setRequirePreciseResultSize($optionalArgs['requirePreciseResultSize']);
        }
        if (isset($optionalArgs['histogramQueries'])) {
            $request->setHistogramQueries($optionalArgs['histogramQueries']);
        }
        if (isset($optionalArgs['jobView'])) {
            $request->setJobView($optionalArgs['jobView']);
        }
        if (isset($optionalArgs['offset'])) {
            $request->setOffset($optionalArgs['offset']);
        }
        if (isset($optionalArgs['pageSize'])) {
            $request->setPageSize($optionalArgs['pageSize']);
        }
        if (isset($optionalArgs['pageToken'])) {
            $request->setPageToken($optionalArgs['pageToken']);
        }
        if (isset($optionalArgs['orderBy'])) {
            $request->setOrderBy($optionalArgs['orderBy']);
        }
        if (isset($optionalArgs['diversificationLevel'])) {
            $request->setDiversificationLevel($optionalArgs['diversificationLevel']);
        }
        if (isset($optionalArgs['customRankingInfo'])) {
            $request->setCustomRankingInfo($optionalArgs['customRankingInfo']);
        }
        if (isset($optionalArgs['disableKeywordMatch'])) {
            $request->setDisableKeywordMatch($optionalArgs['disableKeywordMatch']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->getPagedListResponse(
            'SearchJobsForAlert',
            $optionalArgs,
            SearchJobsResponse::class,
            $request
        );
    }
}
