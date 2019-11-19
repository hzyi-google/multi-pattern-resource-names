<?php
/*
 * Copyright 2019 Google LLC
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
 * https://github.com/google/googleapis/blob/master/google/devtools/containeranalysis/v1beta1/containeranalysis.proto
 * and updates to that file get reflected here through a refresh process.
 *
 * @experimental
 */

namespace Google\Cloud\Devtools\Containeranalysis\V1beta1\Gapic;

use Google\ApiCore\ApiException;
use Google\ApiCore\CredentialsWrapper;
use Google\ApiCore\GapicClientTrait;
use Google\ApiCore\PathTemplate;
use Google\ApiCore\RequestParamsHeaderDescriptor;
use Google\ApiCore\RetrySettings;
use Google\ApiCore\Transport\TransportInterface;
use Google\ApiCore\ValidationException;
use Google\Auth\FetchAuthTokenInterface;
use Google\Cloud\Iam\V1\GetIamPolicyRequest;
use Google\Cloud\Iam\V1\GetPolicyOptions;
use Google\Cloud\Iam\V1\Policy;
use Google\Cloud\Iam\V1\SetIamPolicyRequest;
use Google\Cloud\Iam\V1\TestIamPermissionsRequest;
use Google\Cloud\Iam\V1\TestIamPermissionsResponse;
use Google\Devtools\Containeranalysis\V1beta1\ContainerAnalysisV1Beta1GrpcClient;
use Google\Devtools\Containeranalysis\V1beta1\GetScanConfigRequest;
use Google\Devtools\Containeranalysis\V1beta1\ListScanConfigsRequest;
use Google\Devtools\Containeranalysis\V1beta1\ListScanConfigsResponse;
use Google\Devtools\Containeranalysis\V1beta1\ScanConfig;
use Google\Devtools\Containeranalysis\V1beta1\UpdateScanConfigRequest;

/**
 * Service Description: Retrieves analysis results of Cloud components such as Docker container
 * images. The Container Analysis API is an implementation of the
 * [Grafeas](https://cloud.google.comgrafeas.io) API.
 *
 * Analysis results are stored as a series of occurrences. An `Occurrence`
 * contains information about a specific analysis instance on a resource. An
 * occurrence refers to a `Note`. A note contains details describing the
 * analysis and is generally stored in a separate project, called a `Provider`.
 * Multiple occurrences can refer to the same note.
 *
 * For example, an SSL vulnerability could affect multiple images. In this case,
 * there would be one note for the vulnerability and an occurrence for each
 * image with the vulnerability referring to that note.
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $containerAnalysisV1Beta1Client = new ContainerAnalysisV1Beta1Client();
 * try {
 *     $formattedResource = $containerAnalysisV1Beta1Client->noteName('[PROJECT]', '[NOTE]');
 *     $policy = new Policy();
 *     $response = $containerAnalysisV1Beta1Client->setIamPolicy($formattedResource, $policy);
 * } finally {
 *     $containerAnalysisV1Beta1Client->close();
 * }
 * ```
 *
 * Many parameters require resource names to be formatted in a particular way. To assist
 * with these names, this class includes a format method for each type of name, and additionally
 * a parseName method to extract the individual identifiers contained within formatted names
 * that are returned by the API.
 * @experimental
 */
class ContainerAnalysisV1Beta1GapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'google.devtools.containeranalysis.v1beta1.ContainerAnalysisV1Beta1';

    /**
     * The default address of the service.
     */
    const SERVICE_ADDRESS = 'containeranalysis.googleapis.com';

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
    ];
    private static $noteNameTemplate;
    private static $occurrenceNameTemplate;
    private static $projectNameTemplate;
    private static $scanConfigNameTemplate;
    private static $pathTemplateMap;


    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS . ':' . self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__ . '/../resources/container_analysis_v1_beta1_client_config.json',
            'descriptorsConfigPath' => __DIR__ . '/../resources/container_analysis_v1_beta1_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__ . '/../resources/container_analysis_v1_beta1_grpc_config.json',
            'credentialsConfig' => [
                'scopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__ . '/../resources/container_analysis_v1_beta1_rest_client_config.php',
                ]
            ]
        ];
    }

    private static function getNoteNameTemplate()
    {
        if (self::$noteNameTemplate == null) {
            self::$noteNameTemplate = new PathTemplate('projects/{project}/notes/{note}');
        }

        return self::$noteNameTemplate;
    }

    private static function getOccurrenceNameTemplate()
    {
        if (self::$occurrenceNameTemplate == null) {
            self::$occurrenceNameTemplate = new PathTemplate('projects/{project}/occurrences/{occurrence}');
        }

        return self::$occurrenceNameTemplate;
    }

    private static function getProjectNameTemplate()
    {
        if (self::$projectNameTemplate == null) {
            self::$projectNameTemplate = new PathTemplate('projects/{project}');
        }

        return self::$projectNameTemplate;
    }

    private static function getScanConfigNameTemplate()
    {
        if (self::$scanConfigNameTemplate == null) {
            self::$scanConfigNameTemplate = new PathTemplate('projects/{project}/scanConfigs/{scan_config}');
        }

        return self::$scanConfigNameTemplate;
    }


    private static function getPathTemplateMap()
    {
        if (self::$pathTemplateMap == null) {
            self::$pathTemplateMap = [
                'note' => self::getNoteNameTemplate(),
                'occurrence' => self::getOccurrenceNameTemplate(),
                'project' => self::getProjectNameTemplate(),
                'scanConfig' => self::getScanConfigNameTemplate(),
            ];
        }
        return self::$pathTemplateMap;
    }
    /**
     * Formats a string containing the fully-qualified path to represent
     * a note resource.
     *
     * @param string $project
     * @param string $note
     * @return string The formatted note resource.
     * @experimental
     */
    public static function noteName($project, $note)
    {
        return self::getNoteNameTemplate()->render([
            'project' => $project,
            'note' => $note,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a occurrence resource.
     *
     * @param string $project
     * @param string $occurrence
     * @return string The formatted occurrence resource.
     * @experimental
     */
    public static function occurrenceName($project, $occurrence)
    {
        return self::getOccurrenceNameTemplate()->render([
            'project' => $project,
            'occurrence' => $occurrence,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a project resource.
     *
     * @param string $project
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
     * a scan_config resource.
     *
     * @param string $project
     * @param string $scanConfig
     * @return string The formatted scan_config resource.
     * @experimental
     */
    public static function scanConfigName($project, $scanConfig)
    {
        return self::getScanConfigNameTemplate()->render([
            'project' => $project,
            'scan_config' => $scanConfig,
        ]);
    }

    /**
     * Parses a formatted name string and returns an associative array of the components in the name.
     * The following name formats are supported:
     * Template: Pattern
     * - note: projects/{project}/notes/{note}
     * - occurrence: projects/{project}/occurrences/{occurrence}
     * - project: projects/{project}
     * - scanConfig: projects/{project}/scanConfigs/{scan_config}
     *
     * The optional $template argument can be supplied to specify a particular pattern, and must
     * match one of the templates listed above. If no $template argument is provided, or if the
     * $template argument does not match one of the templates listed, then parseName will check
     * each of the supported templates, and return the first match.
     *
     * @param string $formattedName The formatted name string
     * @param string $template Optional name of template to match
     * @return array An associative array from name component IDs to component values.
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
     * Constructor.
     *
     * @param array $options {
     *     Optional. Options for configuring the service API wrapper.
     *     @type string $serviceAddress
     *           The address of the API remote host. May optionally include the port, formatted
     *           as "<uri>:<port>". Default 'containeranalysis.googleapis.com:443'.
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
     * @throws ValidationException
     * @experimental
     */
    public function __construct(array $options = [])
    {
        $clientOptions = $this->buildClientOptions($options);
        $this->setClientOptions($clientOptions);
    }

    /**
     * Sets the access control policy on the specified note or occurrence.
     * Requires `containeranalysis.notes.setIamPolicy` or
     * `containeranalysis.occurrences.setIamPolicy` permission if the resource is
     * a note or an occurrence, respectively.
     *
     * The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
     * notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
     * occurrences.
     *
     * Sample code:
     * ```
     * $containerAnalysisV1Beta1Client = new ContainerAnalysisV1Beta1Client();
     * try {
     *     $formattedResource = $containerAnalysisV1Beta1Client->noteName('[PROJECT]', '[NOTE]');
     *     $policy = new Policy();
     *     $response = $containerAnalysisV1Beta1Client->setIamPolicy($formattedResource, $policy);
     * } finally {
     *     $containerAnalysisV1Beta1Client->close();
     * }
     * ```
     *
     * @param string $resource REQUIRED: The resource for which the policy is being specified.
     * See the operation documentation for the appropriate value for this field.
     * @param Policy $policy REQUIRED: The complete policy to be applied to the `resource`. The size of
     * the policy is limited to a few 10s of KB. An empty policy is a
     * valid policy but certain Cloud Platform services (such as Projects)
     * might reject them.
     * @param array $optionalArgs {
     *     Optional.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Iam\V1\Policy
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function setIamPolicy($resource, $policy, array $optionalArgs = [])
    {
        $request = new SetIamPolicyRequest();
        $request->setResource($resource);
        $request->setPolicy($policy);

        $requestParams = new RequestParamsHeaderDescriptor([
          'resource' => $request->getResource(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'SetIamPolicy',
            Policy::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Gets the access control policy for a note or an occurrence resource.
     * Requires `containeranalysis.notes.setIamPolicy` or
     * `containeranalysis.occurrences.setIamPolicy` permission if the resource is
     * a note or occurrence, respectively.
     *
     * The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
     * notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
     * occurrences.
     *
     * Sample code:
     * ```
     * $containerAnalysisV1Beta1Client = new ContainerAnalysisV1Beta1Client();
     * try {
     *     $formattedResource = $containerAnalysisV1Beta1Client->noteName('[PROJECT]', '[NOTE]');
     *     $response = $containerAnalysisV1Beta1Client->getIamPolicy($formattedResource);
     * } finally {
     *     $containerAnalysisV1Beta1Client->close();
     * }
     * ```
     *
     * @param string $resource REQUIRED: The resource for which the policy is being requested.
     * See the operation documentation for the appropriate value for this field.
     * @param array $optionalArgs {
     *     Optional.
     *     @type GetPolicyOptions $options
     *          OPTIONAL: A `GetPolicyOptions` object for specifying options to
     *          `GetIamPolicy`. This field is only used by Cloud IAM.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Iam\V1\Policy
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getIamPolicy($resource, array $optionalArgs = [])
    {
        $request = new GetIamPolicyRequest();
        $request->setResource($resource);
        if (isset($optionalArgs['options'])) {
            $request->setOptions($optionalArgs['options']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'resource' => $request->getResource(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetIamPolicy',
            Policy::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Returns the permissions that a caller has on the specified note or
     * occurrence. Requires list permission on the project (for example,
     * `containeranalysis.notes.list`).
     *
     * The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
     * notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
     * occurrences.
     *
     * Sample code:
     * ```
     * $containerAnalysisV1Beta1Client = new ContainerAnalysisV1Beta1Client();
     * try {
     *     $formattedResource = $containerAnalysisV1Beta1Client->noteName('[PROJECT]', '[NOTE]');
     *     $permissions = [];
     *     $response = $containerAnalysisV1Beta1Client->testIamPermissions($formattedResource, $permissions);
     * } finally {
     *     $containerAnalysisV1Beta1Client->close();
     * }
     * ```
     *
     * @param string $resource REQUIRED: The resource for which the policy detail is being requested.
     * See the operation documentation for the appropriate value for this field.
     * @param string[] $permissions The set of permissions to check for the `resource`. Permissions with
     * wildcards (such as '*' or 'storage.*') are not allowed. For more
     * information see
     * [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
     * @param array $optionalArgs {
     *     Optional.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Iam\V1\TestIamPermissionsResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function testIamPermissions($resource, $permissions, array $optionalArgs = [])
    {
        $request = new TestIamPermissionsRequest();
        $request->setResource($resource);
        $request->setPermissions($permissions);

        $requestParams = new RequestParamsHeaderDescriptor([
          'resource' => $request->getResource(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'TestIamPermissions',
            TestIamPermissionsResponse::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Gets the specified scan configuration.
     *
     * Sample code:
     * ```
     * $containerAnalysisV1Beta1Client = new ContainerAnalysisV1Beta1Client();
     * try {
     *     $formattedName = $containerAnalysisV1Beta1Client->scanConfigName('[PROJECT]', '[SCAN_CONFIG]');
     *     $response = $containerAnalysisV1Beta1Client->getScanConfig($formattedName);
     * } finally {
     *     $containerAnalysisV1Beta1Client->close();
     * }
     * ```
     *
     * @param string $name The name of the scan configuration in the form of
     * `projects/[PROJECT_ID]/scanConfigs/[SCAN_CONFIG_ID]`.
     * @param array $optionalArgs {
     *     Optional.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Devtools\Containeranalysis\V1beta1\ScanConfig
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getScanConfig($name, array $optionalArgs = [])
    {
        $request = new GetScanConfigRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetScanConfig',
            ScanConfig::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Lists scan configurations for the specified project.
     *
     * Sample code:
     * ```
     * $containerAnalysisV1Beta1Client = new ContainerAnalysisV1Beta1Client();
     * try {
     *     $formattedParent = $containerAnalysisV1Beta1Client->projectName('[PROJECT]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $containerAnalysisV1Beta1Client->listScanConfigs($formattedParent);
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
     *     $pagedResponse = $containerAnalysisV1Beta1Client->listScanConfigs($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $containerAnalysisV1Beta1Client->close();
     * }
     * ```
     *
     * @param string $parent The name of the project to list scan configurations for in the form of
     * `projects/[PROJECT_ID]`.
     * @param array $optionalArgs {
     *     Optional.
     *     @type string $filter
     *          The filter expression.
     *     @type int $pageSize
     *          The maximum number of resources contained in the underlying API
     *          response. The API may return fewer values in a page, even if
     *          there are additional values to be retrieved.
     *     @type string $pageToken
     *          A page token is used to specify a page of values to be returned.
     *          If no page token is specified (the default), the first page
     *          of values will be returned. Any page token used here must have
     *          been generated by a previous call to the API.
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
    public function listScanConfigs($parent, array $optionalArgs = [])
    {
        $request = new ListScanConfigsRequest();
        $request->setParent($parent);
        if (isset($optionalArgs['filter'])) {
            $request->setFilter($optionalArgs['filter']);
        }
        if (isset($optionalArgs['pageSize'])) {
            $request->setPageSize($optionalArgs['pageSize']);
        }
        if (isset($optionalArgs['pageToken'])) {
            $request->setPageToken($optionalArgs['pageToken']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->getPagedListResponse(
            'ListScanConfigs',
            $optionalArgs,
            ListScanConfigsResponse::class,
            $request
        );
    }

    /**
     * Updates the specified scan configuration.
     *
     * Sample code:
     * ```
     * $containerAnalysisV1Beta1Client = new ContainerAnalysisV1Beta1Client();
     * try {
     *     $formattedName = $containerAnalysisV1Beta1Client->scanConfigName('[PROJECT]', '[SCAN_CONFIG]');
     *     $scanConfig = new ScanConfig();
     *     $response = $containerAnalysisV1Beta1Client->updateScanConfig($formattedName, $scanConfig);
     * } finally {
     *     $containerAnalysisV1Beta1Client->close();
     * }
     * ```
     *
     * @param string $name The name of the scan configuration in the form of
     * `projects/[PROJECT_ID]/scanConfigs/[SCAN_CONFIG_ID]`.
     * @param ScanConfig $scanConfig The updated scan configuration.
     * @param array $optionalArgs {
     *     Optional.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Devtools\Containeranalysis\V1beta1\ScanConfig
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function updateScanConfig($name, $scanConfig, array $optionalArgs = [])
    {
        $request = new UpdateScanConfigRequest();
        $request->setName($name);
        $request->setScanConfig($scanConfig);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'UpdateScanConfig',
            ScanConfig::class,
            $optionalArgs,
            $request
        )->wait();
    }
}
