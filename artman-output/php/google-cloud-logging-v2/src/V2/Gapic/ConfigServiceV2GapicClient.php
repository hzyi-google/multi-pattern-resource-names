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
 * https://github.com/google/googleapis/blob/master/google/logging/v2/logging_config.proto
 * and updates to that file get reflected here through a refresh process.
 *
 * @experimental
 */

namespace Google\Cloud\Logging\V2\Gapic;

use Google\ApiCore\ApiException;
use Google\ApiCore\CredentialsWrapper;
use Google\ApiCore\GapicClientTrait;
use Google\ApiCore\PathTemplate;
use Google\ApiCore\RequestParamsHeaderDescriptor;
use Google\ApiCore\RetrySettings;
use Google\ApiCore\Transport\TransportInterface;
use Google\ApiCore\ValidationException;
use Google\Auth\FetchAuthTokenInterface;
use Google\Cloud\Logging\V2\CmekSettings;
use Google\Cloud\Logging\V2\CreateExclusionRequest;
use Google\Cloud\Logging\V2\CreateSinkRequest;
use Google\Cloud\Logging\V2\DeleteExclusionRequest;
use Google\Cloud\Logging\V2\DeleteSinkRequest;
use Google\Cloud\Logging\V2\GetBucketRequest;
use Google\Cloud\Logging\V2\GetCmekSettingsRequest;
use Google\Cloud\Logging\V2\GetExclusionRequest;
use Google\Cloud\Logging\V2\GetSinkRequest;
use Google\Cloud\Logging\V2\ListBucketsRequest;
use Google\Cloud\Logging\V2\ListBucketsResponse;
use Google\Cloud\Logging\V2\ListExclusionsRequest;
use Google\Cloud\Logging\V2\ListExclusionsResponse;
use Google\Cloud\Logging\V2\ListSinksRequest;
use Google\Cloud\Logging\V2\ListSinksResponse;
use Google\Cloud\Logging\V2\LogBucket;
use Google\Cloud\Logging\V2\LogExclusion;
use Google\Cloud\Logging\V2\LogSink;
use Google\Cloud\Logging\V2\UpdateBucketRequest;
use Google\Cloud\Logging\V2\UpdateCmekSettingsRequest;
use Google\Cloud\Logging\V2\UpdateExclusionRequest;
use Google\Cloud\Logging\V2\UpdateSinkRequest;
use Google\Protobuf\FieldMask;
use Google\Protobuf\GPBEmpty;

/**
 * Service Description: Service for configuring sinks used to route log entries.
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $configServiceV2Client = new ConfigServiceV2Client();
 * try {
 *     $formattedParent = $configServiceV2Client->locationName('[PROJECT]', '[LOCATION]');
 *     // Iterate over pages of elements
 *     $pagedResponse = $configServiceV2Client->listBuckets($formattedParent);
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
 *     $pagedResponse = $configServiceV2Client->listBuckets($formattedParent);
 *     foreach ($pagedResponse->iterateAllElements() as $element) {
 *         // doSomethingWith($element);
 *     }
 * } finally {
 *     $configServiceV2Client->close();
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
class ConfigServiceV2GapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'google.logging.v2.ConfigServiceV2';

    /**
     * The default address of the service.
     */
    const SERVICE_ADDRESS = 'logging.googleapis.com';

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
        'https://www.googleapis.com/auth/cloud-platform.read-only',
        'https://www.googleapis.com/auth/logging.admin',
        'https://www.googleapis.com/auth/logging.read',
        'https://www.googleapis.com/auth/logging.write',
    ];
    private static $billingAccountNameTemplate;
    private static $billingAccountLocationNameTemplate;
    private static $folderNameTemplate;
    private static $folderLocationNameTemplate;
    private static $locationNameTemplate;
    private static $organizationNameTemplate;
    private static $organizationLocationNameTemplate;
    private static $projectNameTemplate;
    private static $pathTemplateMap;

    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS.':'.self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__.'/../resources/config_service_v2_client_config.json',
            'descriptorsConfigPath' => __DIR__.'/../resources/config_service_v2_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__.'/../resources/config_service_v2_grpc_config.json',
            'credentialsConfig' => [
                'scopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__.'/../resources/config_service_v2_rest_client_config.php',
                ],
            ],
        ];
    }

    private static function getBillingAccountNameTemplate()
    {
        if (null == self::$billingAccountNameTemplate) {
            self::$billingAccountNameTemplate = new PathTemplate('billingAccounts/{billing_account}');
        }

        return self::$billingAccountNameTemplate;
    }

    private static function getBillingAccountLocationNameTemplate()
    {
        if (null == self::$billingAccountLocationNameTemplate) {
            self::$billingAccountLocationNameTemplate = new PathTemplate('billingAccounts/{billing_account}/locations/{location}');
        }

        return self::$billingAccountLocationNameTemplate;
    }

    private static function getFolderNameTemplate()
    {
        if (null == self::$folderNameTemplate) {
            self::$folderNameTemplate = new PathTemplate('folders/{folder}');
        }

        return self::$folderNameTemplate;
    }

    private static function getFolderLocationNameTemplate()
    {
        if (null == self::$folderLocationNameTemplate) {
            self::$folderLocationNameTemplate = new PathTemplate('folders/{folder}/locations/{location}');
        }

        return self::$folderLocationNameTemplate;
    }

    private static function getLocationNameTemplate()
    {
        if (null == self::$locationNameTemplate) {
            self::$locationNameTemplate = new PathTemplate('projects/{project}/locations/{location}');
        }

        return self::$locationNameTemplate;
    }

    private static function getOrganizationNameTemplate()
    {
        if (null == self::$organizationNameTemplate) {
            self::$organizationNameTemplate = new PathTemplate('organizations/{organization}');
        }

        return self::$organizationNameTemplate;
    }

    private static function getOrganizationLocationNameTemplate()
    {
        if (null == self::$organizationLocationNameTemplate) {
            self::$organizationLocationNameTemplate = new PathTemplate('organizations/{organization}/locations/{location}');
        }

        return self::$organizationLocationNameTemplate;
    }

    private static function getProjectNameTemplate()
    {
        if (null == self::$projectNameTemplate) {
            self::$projectNameTemplate = new PathTemplate('projects/{project}');
        }

        return self::$projectNameTemplate;
    }

    private static function getPathTemplateMap()
    {
        if (null == self::$pathTemplateMap) {
            self::$pathTemplateMap = [
                'billingAccount' => self::getBillingAccountNameTemplate(),
                'billingAccountLocation' => self::getBillingAccountLocationNameTemplate(),
                'folder' => self::getFolderNameTemplate(),
                'folderLocation' => self::getFolderLocationNameTemplate(),
                'location' => self::getLocationNameTemplate(),
                'organization' => self::getOrganizationNameTemplate(),
                'organizationLocation' => self::getOrganizationLocationNameTemplate(),
                'project' => self::getProjectNameTemplate(),
            ];
        }

        return self::$pathTemplateMap;
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a billing_account resource.
     *
     * @param string $billingAccount
     *
     * @return string The formatted billing_account resource.
     * @experimental
     */
    public static function billingAccountName($billingAccount)
    {
        return self::getBillingAccountNameTemplate()->render([
            'billing_account' => $billingAccount,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a billing_account_location resource.
     *
     * @param string $billingAccount
     * @param string $location
     *
     * @return string The formatted billing_account_location resource.
     * @experimental
     */
    public static function billingAccountLocationName($billingAccount, $location)
    {
        return self::getBillingAccountLocationNameTemplate()->render([
            'billing_account' => $billingAccount,
            'location' => $location,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a folder resource.
     *
     * @param string $folder
     *
     * @return string The formatted folder resource.
     * @experimental
     */
    public static function folderName($folder)
    {
        return self::getFolderNameTemplate()->render([
            'folder' => $folder,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a folder_location resource.
     *
     * @param string $folder
     * @param string $location
     *
     * @return string The formatted folder_location resource.
     * @experimental
     */
    public static function folderLocationName($folder, $location)
    {
        return self::getFolderLocationNameTemplate()->render([
            'folder' => $folder,
            'location' => $location,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a location resource.
     *
     * @param string $project
     * @param string $location
     *
     * @return string The formatted location resource.
     * @experimental
     */
    public static function locationName($project, $location)
    {
        return self::getLocationNameTemplate()->render([
            'project' => $project,
            'location' => $location,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a organization resource.
     *
     * @param string $organization
     *
     * @return string The formatted organization resource.
     * @experimental
     */
    public static function organizationName($organization)
    {
        return self::getOrganizationNameTemplate()->render([
            'organization' => $organization,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a organization_location resource.
     *
     * @param string $organization
     * @param string $location
     *
     * @return string The formatted organization_location resource.
     * @experimental
     */
    public static function organizationLocationName($organization, $location)
    {
        return self::getOrganizationLocationNameTemplate()->render([
            'organization' => $organization,
            'location' => $location,
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
     * Parses a formatted name string and returns an associative array of the components in the name.
     * The following name formats are supported:
     * Template: Pattern
     * - billingAccount: billingAccounts/{billing_account}
     * - billingAccountLocation: billingAccounts/{billing_account}/locations/{location}
     * - folder: folders/{folder}
     * - folderLocation: folders/{folder}/locations/{location}
     * - location: projects/{project}/locations/{location}
     * - organization: organizations/{organization}
     * - organizationLocation: organizations/{organization}/locations/{location}
     * - project: projects/{project}.
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
     * Constructor.
     *
     * @param array $options {
     *                       Optional. Options for configuring the service API wrapper.
     *
     *     @type string $serviceAddress
     *           The address of the API remote host. May optionally include the port, formatted
     *           as "<uri>:<port>". Default 'logging.googleapis.com:443'.
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
    }

    /**
     * Lists buckets (Beta).
     *
     * Sample code:
     * ```
     * $configServiceV2Client = new ConfigServiceV2Client();
     * try {
     *     $formattedParent = $configServiceV2Client->locationName('[PROJECT]', '[LOCATION]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $configServiceV2Client->listBuckets($formattedParent);
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
     *     $pagedResponse = $configServiceV2Client->listBuckets($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $configServiceV2Client->close();
     * }
     * ```
     *
     * @param string $parent Required. The parent resource whose buckets are to be listed:
     *
     *     "projects/[PROJECT_ID]/locations/[LOCATION_ID]"
     *     "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]"
     *     "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]"
     *     "folders/[FOLDER_ID]/locations/[LOCATION_ID]"
     *
     * Note: The locations portion of the resource must be specified, but
     * supplying the character `-` in place of [LOCATION_ID] will return all
     * buckets.
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
    public function listBuckets($parent, array $optionalArgs = [])
    {
        $request = new ListBucketsRequest();
        $request->setParent($parent);
        if (isset($optionalArgs['pageToken'])) {
            $request->setPageToken($optionalArgs['pageToken']);
        }
        if (isset($optionalArgs['pageSize'])) {
            $request->setPageSize($optionalArgs['pageSize']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->getPagedListResponse(
            'ListBuckets',
            $optionalArgs,
            ListBucketsResponse::class,
            $request
        );
    }

    /**
     * Gets a bucket (Beta).
     *
     * Sample code:
     * ```
     * $configServiceV2Client = new ConfigServiceV2Client();
     * try {
     *     $name = '';
     *     $response = $configServiceV2Client->getBucket($name);
     * } finally {
     *     $configServiceV2Client->close();
     * }
     * ```
     *
     * @param string $name Required. The resource name of the bucket:
     *
     *     "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
     *     "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
     *     "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
     *     "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
     *
     * Example:
     * `"projects/my-project-id/locations/my-location/buckets/my-bucket-id"`.
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
     * @return \Google\Cloud\Logging\V2\LogBucket
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getBucket($name, array $optionalArgs = [])
    {
        $request = new GetBucketRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetBucket',
            LogBucket::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Updates a bucket. This method replaces the following fields in the
     * existing bucket with values from the new bucket: `retention_period`.
     *
     * If the retention period is decreased and the bucket is locked,
     * FAILED_PRECONDITION will be returned.
     *
     * If the bucket has a LifecycleState of DELETE_REQUESTED, FAILED_PRECONDITION
     * will be returned.
     *
     * A buckets region may not be modified after it is created.
     * This method is in Beta.
     *
     * Sample code:
     * ```
     * $configServiceV2Client = new ConfigServiceV2Client();
     * try {
     *     $name = '';
     *     $bucket = new LogBucket();
     *     $updateMask = new FieldMask();
     *     $response = $configServiceV2Client->updateBucket($name, $bucket, $updateMask);
     * } finally {
     *     $configServiceV2Client->close();
     * }
     * ```
     *
     * @param string $name Required. The full resource name of the bucket to update.
     *
     *     "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
     *     "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
     *     "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
     *     "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
     *
     * Example:
     * `"projects/my-project-id/locations/my-location/buckets/my-bucket-id"`. Also
     * requires permission "resourcemanager.projects.updateLiens" to set the
     * locked property
     * @param LogBucket $bucket     Required. The updated bucket.
     * @param FieldMask $updateMask Required. Field mask that specifies the fields in `bucket` that need an update. A
     *                              bucket field will be overwritten if, and only if, it is in the update
     *                              mask. `name` and output only fields cannot be updated.
     *
     * For a detailed `FieldMask` definition, see
     * https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMask
     *
     * Example: `updateMask=retention_days`.
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
     * @return \Google\Cloud\Logging\V2\LogBucket
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function updateBucket($name, $bucket, $updateMask, array $optionalArgs = [])
    {
        $request = new UpdateBucketRequest();
        $request->setName($name);
        $request->setBucket($bucket);
        $request->setUpdateMask($updateMask);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'UpdateBucket',
            LogBucket::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Lists sinks.
     *
     * Sample code:
     * ```
     * $configServiceV2Client = new ConfigServiceV2Client();
     * try {
     *     $formattedParent = $configServiceV2Client->projectName('[PROJECT]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $configServiceV2Client->listSinks($formattedParent);
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
     *     $pagedResponse = $configServiceV2Client->listSinks($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $configServiceV2Client->close();
     * }
     * ```
     *
     * @param string $parent Required. The parent resource whose sinks are to be listed:
     *
     *     "projects/[PROJECT_ID]"
     *     "organizations/[ORGANIZATION_ID]"
     *     "billingAccounts/[BILLING_ACCOUNT_ID]"
     *     "folders/[FOLDER_ID]"
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
    public function listSinks($parent, array $optionalArgs = [])
    {
        $request = new ListSinksRequest();
        $request->setParent($parent);
        if (isset($optionalArgs['pageToken'])) {
            $request->setPageToken($optionalArgs['pageToken']);
        }
        if (isset($optionalArgs['pageSize'])) {
            $request->setPageSize($optionalArgs['pageSize']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->getPagedListResponse(
            'ListSinks',
            $optionalArgs,
            ListSinksResponse::class,
            $request
        );
    }

    /**
     * Gets a sink.
     *
     * Sample code:
     * ```
     * $configServiceV2Client = new ConfigServiceV2Client();
     * try {
     *     $sinkName = '';
     *     $response = $configServiceV2Client->getSink($sinkName);
     * } finally {
     *     $configServiceV2Client->close();
     * }
     * ```
     *
     * @param string $sinkName Required. The resource name of the sink:
     *
     *     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
     *     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
     *     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
     *     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
     *
     * Example: `"projects/my-project-id/sinks/my-sink-id"`.
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
     * @return \Google\Cloud\Logging\V2\LogSink
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getSink($sinkName, array $optionalArgs = [])
    {
        $request = new GetSinkRequest();
        $request->setSinkName($sinkName);

        $requestParams = new RequestParamsHeaderDescriptor([
          'sink_name' => $request->getSinkName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetSink',
            LogSink::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Creates a sink that exports specified log entries to a destination. The
     * export of newly-ingested log entries begins immediately, unless the sink's
     * `writer_identity` is not permitted to write to the destination. A sink can
     * export log entries only from the resource owning the sink.
     *
     * Sample code:
     * ```
     * $configServiceV2Client = new ConfigServiceV2Client();
     * try {
     *     $formattedParent = $configServiceV2Client->projectName('[PROJECT]');
     *     $sink = new LogSink();
     *     $response = $configServiceV2Client->createSink($formattedParent, $sink);
     * } finally {
     *     $configServiceV2Client->close();
     * }
     * ```
     *
     * @param string $parent Required. The resource in which to create the sink:
     *
     *     "projects/[PROJECT_ID]"
     *     "organizations/[ORGANIZATION_ID]"
     *     "billingAccounts/[BILLING_ACCOUNT_ID]"
     *     "folders/[FOLDER_ID]"
     *
     * Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
     * @param LogSink $sink         Required. The new sink, whose `name` parameter is a sink identifier that
     *                              is not already in use.
     * @param array   $optionalArgs {
     *                              Optional.
     *
     *     @type bool $uniqueWriterIdentity
     *          Optional. Determines the kind of IAM identity returned as `writer_identity`
     *          in the new sink. If this value is omitted or set to false, and if the
     *          sink's parent is a project, then the value returned as `writer_identity` is
     *          the same group or service account used by Logging before the addition of
     *          writer identities to this API. The sink's destination must be in the same
     *          project as the sink itself.
     *
     *          If this field is set to true, or if the sink is owned by a non-project
     *          resource such as an organization, then the value of `writer_identity` will
     *          be a unique service account used only for exports from the new sink. For
     *          more information, see `writer_identity` in [LogSink][google.logging.v2.LogSink].
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Logging\V2\LogSink
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function createSink($parent, $sink, array $optionalArgs = [])
    {
        $request = new CreateSinkRequest();
        $request->setParent($parent);
        $request->setSink($sink);
        if (isset($optionalArgs['uniqueWriterIdentity'])) {
            $request->setUniqueWriterIdentity($optionalArgs['uniqueWriterIdentity']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'CreateSink',
            LogSink::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Updates a sink. This method replaces the following fields in the existing
     * sink with values from the new sink: `destination`, and `filter`.
     *
     * The updated sink might also have a new `writer_identity`; see the
     * `unique_writer_identity` field.
     *
     * Sample code:
     * ```
     * $configServiceV2Client = new ConfigServiceV2Client();
     * try {
     *     $sinkName = '';
     *     $sink = new LogSink();
     *     $response = $configServiceV2Client->updateSink($sinkName, $sink);
     * } finally {
     *     $configServiceV2Client->close();
     * }
     * ```
     *
     * @param string $sinkName Required. The full resource name of the sink to update, including the parent
     *                         resource and the sink identifier:
     *
     *     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
     *     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
     *     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
     *     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
     *
     * Example: `"projects/my-project-id/sinks/my-sink-id"`.
     * @param LogSink $sink         Required. The updated sink, whose name is the same identifier that appears as part
     *                              of `sink_name`.
     * @param array   $optionalArgs {
     *                              Optional.
     *
     *     @type bool $uniqueWriterIdentity
     *          Optional. See [sinks.create][google.logging.v2.ConfigServiceV2.CreateSink]
     *          for a description of this field. When updating a sink, the effect of this
     *          field on the value of `writer_identity` in the updated sink depends on both
     *          the old and new values of this field:
     *
     *          +   If the old and new values of this field are both false or both true,
     *              then there is no change to the sink's `writer_identity`.
     *          +   If the old value is false and the new value is true, then
     *              `writer_identity` is changed to a unique service account.
     *          +   It is an error if the old value is true and the new value is
     *              set to false or defaulted to false.
     *     @type FieldMask $updateMask
     *          Optional. Field mask that specifies the fields in `sink` that need
     *          an update. A sink field will be overwritten if, and only if, it is
     *          in the update mask. `name` and output only fields cannot be updated.
     *
     *          An empty updateMask is temporarily treated as using the following mask
     *          for backwards compatibility purposes:
     *            destination,filter,includeChildren
     *          At some point in the future, behavior will be removed and specifying an
     *          empty updateMask will be an error.
     *
     *          For a detailed `FieldMask` definition, see
     *          https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMask
     *
     *          Example: `updateMask=filter`.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Logging\V2\LogSink
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function updateSink($sinkName, $sink, array $optionalArgs = [])
    {
        $request = new UpdateSinkRequest();
        $request->setSinkName($sinkName);
        $request->setSink($sink);
        if (isset($optionalArgs['uniqueWriterIdentity'])) {
            $request->setUniqueWriterIdentity($optionalArgs['uniqueWriterIdentity']);
        }
        if (isset($optionalArgs['updateMask'])) {
            $request->setUpdateMask($optionalArgs['updateMask']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'sink_name' => $request->getSinkName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'UpdateSink',
            LogSink::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Deletes a sink. If the sink has a unique `writer_identity`, then that
     * service account is also deleted.
     *
     * Sample code:
     * ```
     * $configServiceV2Client = new ConfigServiceV2Client();
     * try {
     *     $sinkName = '';
     *     $configServiceV2Client->deleteSink($sinkName);
     * } finally {
     *     $configServiceV2Client->close();
     * }
     * ```
     *
     * @param string $sinkName Required. The full resource name of the sink to delete, including the parent
     *                         resource and the sink identifier:
     *
     *     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
     *     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
     *     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
     *     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
     *
     * Example: `"projects/my-project-id/sinks/my-sink-id"`.
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
    public function deleteSink($sinkName, array $optionalArgs = [])
    {
        $request = new DeleteSinkRequest();
        $request->setSinkName($sinkName);

        $requestParams = new RequestParamsHeaderDescriptor([
          'sink_name' => $request->getSinkName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'DeleteSink',
            GPBEmpty::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Lists all the exclusions in a parent resource.
     *
     * Sample code:
     * ```
     * $configServiceV2Client = new ConfigServiceV2Client();
     * try {
     *     $formattedParent = $configServiceV2Client->projectName('[PROJECT]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $configServiceV2Client->listExclusions($formattedParent);
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
     *     $pagedResponse = $configServiceV2Client->listExclusions($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $configServiceV2Client->close();
     * }
     * ```
     *
     * @param string $parent Required. The parent resource whose exclusions are to be listed.
     *
     *     "projects/[PROJECT_ID]"
     *     "organizations/[ORGANIZATION_ID]"
     *     "billingAccounts/[BILLING_ACCOUNT_ID]"
     *     "folders/[FOLDER_ID]"
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
    public function listExclusions($parent, array $optionalArgs = [])
    {
        $request = new ListExclusionsRequest();
        $request->setParent($parent);
        if (isset($optionalArgs['pageToken'])) {
            $request->setPageToken($optionalArgs['pageToken']);
        }
        if (isset($optionalArgs['pageSize'])) {
            $request->setPageSize($optionalArgs['pageSize']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->getPagedListResponse(
            'ListExclusions',
            $optionalArgs,
            ListExclusionsResponse::class,
            $request
        );
    }

    /**
     * Gets the description of an exclusion.
     *
     * Sample code:
     * ```
     * $configServiceV2Client = new ConfigServiceV2Client();
     * try {
     *     $name = '';
     *     $response = $configServiceV2Client->getExclusion($name);
     * } finally {
     *     $configServiceV2Client->close();
     * }
     * ```
     *
     * @param string $name Required. The resource name of an existing exclusion:
     *
     *     "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
     *     "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
     *     "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
     *     "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
     *
     * Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
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
     * @return \Google\Cloud\Logging\V2\LogExclusion
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getExclusion($name, array $optionalArgs = [])
    {
        $request = new GetExclusionRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetExclusion',
            LogExclusion::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Creates a new exclusion in a specified parent resource.
     * Only log entries belonging to that resource can be excluded.
     * You can have up to 10 exclusions in a resource.
     *
     * Sample code:
     * ```
     * $configServiceV2Client = new ConfigServiceV2Client();
     * try {
     *     $formattedParent = $configServiceV2Client->projectName('[PROJECT]');
     *     $exclusion = new LogExclusion();
     *     $response = $configServiceV2Client->createExclusion($formattedParent, $exclusion);
     * } finally {
     *     $configServiceV2Client->close();
     * }
     * ```
     *
     * @param string $parent Required. The parent resource in which to create the exclusion:
     *
     *     "projects/[PROJECT_ID]"
     *     "organizations/[ORGANIZATION_ID]"
     *     "billingAccounts/[BILLING_ACCOUNT_ID]"
     *     "folders/[FOLDER_ID]"
     *
     * Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
     * @param LogExclusion $exclusion    Required. The new exclusion, whose `name` parameter is an exclusion name
     *                                   that is not already used in the parent resource.
     * @param array        $optionalArgs {
     *                                   Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Logging\V2\LogExclusion
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function createExclusion($parent, $exclusion, array $optionalArgs = [])
    {
        $request = new CreateExclusionRequest();
        $request->setParent($parent);
        $request->setExclusion($exclusion);

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'CreateExclusion',
            LogExclusion::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Changes one or more properties of an existing exclusion.
     *
     * Sample code:
     * ```
     * $configServiceV2Client = new ConfigServiceV2Client();
     * try {
     *     $name = '';
     *     $exclusion = new LogExclusion();
     *     $updateMask = new FieldMask();
     *     $response = $configServiceV2Client->updateExclusion($name, $exclusion, $updateMask);
     * } finally {
     *     $configServiceV2Client->close();
     * }
     * ```
     *
     * @param string $name Required. The resource name of the exclusion to update:
     *
     *     "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
     *     "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
     *     "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
     *     "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
     *
     * Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
     * @param LogExclusion $exclusion  Required. New values for the existing exclusion. Only the fields specified in
     *                                 `update_mask` are relevant.
     * @param FieldMask    $updateMask Required. A non-empty list of fields to change in the existing exclusion. New values
     *                                 for the fields are taken from the corresponding fields in the
     *                                 [LogExclusion][google.logging.v2.LogExclusion] included in this request. Fields not mentioned in
     *                                 `update_mask` are not changed and are ignored in the request.
     *
     * For example, to change the filter and description of an exclusion,
     * specify an `update_mask` of `"filter,description"`.
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
     * @return \Google\Cloud\Logging\V2\LogExclusion
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function updateExclusion($name, $exclusion, $updateMask, array $optionalArgs = [])
    {
        $request = new UpdateExclusionRequest();
        $request->setName($name);
        $request->setExclusion($exclusion);
        $request->setUpdateMask($updateMask);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'UpdateExclusion',
            LogExclusion::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Deletes an exclusion.
     *
     * Sample code:
     * ```
     * $configServiceV2Client = new ConfigServiceV2Client();
     * try {
     *     $name = '';
     *     $configServiceV2Client->deleteExclusion($name);
     * } finally {
     *     $configServiceV2Client->close();
     * }
     * ```
     *
     * @param string $name Required. The resource name of an existing exclusion to delete:
     *
     *     "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
     *     "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
     *     "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
     *     "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
     *
     * Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
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
    public function deleteExclusion($name, array $optionalArgs = [])
    {
        $request = new DeleteExclusionRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'DeleteExclusion',
            GPBEmpty::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Gets the Logs Router CMEK settings for the given resource.
     *
     * Note: CMEK for the Logs Router can currently only be configured for GCP
     * organizations. Once configured, it applies to all projects and folders in
     * the GCP organization.
     *
     * See [Enabling CMEK for Logs
     * Router](https://cloud.google.com/logging/docs/routing/managed-encryption) for more information.
     *
     * Sample code:
     * ```
     * $configServiceV2Client = new ConfigServiceV2Client();
     * try {
     *     $name = '';
     *     $response = $configServiceV2Client->getCmekSettings($name);
     * } finally {
     *     $configServiceV2Client->close();
     * }
     * ```
     *
     * @param string $name Required. The resource for which to retrieve CMEK settings.
     *
     *     "projects/[PROJECT_ID]/cmekSettings"
     *     "organizations/[ORGANIZATION_ID]/cmekSettings"
     *     "billingAccounts/[BILLING_ACCOUNT_ID]/cmekSettings"
     *     "folders/[FOLDER_ID]/cmekSettings"
     *
     * Example: `"organizations/12345/cmekSettings"`.
     *
     * Note: CMEK for the Logs Router can currently only be configured for GCP
     * organizations. Once configured, it applies to all projects and folders in
     * the GCP organization.
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
     * @return \Google\Cloud\Logging\V2\CmekSettings
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getCmekSettings($name, array $optionalArgs = [])
    {
        $request = new GetCmekSettingsRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetCmekSettings',
            CmekSettings::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Updates the Logs Router CMEK settings for the given resource.
     *
     * Note: CMEK for the Logs Router can currently only be configured for GCP
     * organizations. Once configured, it applies to all projects and folders in
     * the GCP organization.
     *
     * [UpdateCmekSettings][google.logging.v2.ConfigServiceV2.UpdateCmekSettings]
     * will fail if 1) `kms_key_name` is invalid, or 2) the associated service
     * account does not have the required
     * `roles/cloudkms.cryptoKeyEncrypterDecrypter` role assigned for the key, or
     * 3) access to the key is disabled.
     *
     * See [Enabling CMEK for Logs
     * Router](https://cloud.google.com/logging/docs/routing/managed-encryption) for more information.
     *
     * Sample code:
     * ```
     * $configServiceV2Client = new ConfigServiceV2Client();
     * try {
     *     $name = '';
     *     $cmekSettings = new CmekSettings();
     *     $response = $configServiceV2Client->updateCmekSettings($name, $cmekSettings);
     * } finally {
     *     $configServiceV2Client->close();
     * }
     * ```
     *
     * @param string $name Required. The resource name for the CMEK settings to update.
     *
     *     "projects/[PROJECT_ID]/cmekSettings"
     *     "organizations/[ORGANIZATION_ID]/cmekSettings"
     *     "billingAccounts/[BILLING_ACCOUNT_ID]/cmekSettings"
     *     "folders/[FOLDER_ID]/cmekSettings"
     *
     * Example: `"organizations/12345/cmekSettings"`.
     *
     * Note: CMEK for the Logs Router can currently only be configured for GCP
     * organizations. Once configured, it applies to all projects and folders in
     * the GCP organization.
     * @param CmekSettings $cmekSettings Required. The CMEK settings to update.
     *
     * See [Enabling CMEK for Logs
     * Router](https://cloud.google.com/logging/docs/routing/managed-encryption) for more information.
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type FieldMask $updateMask
     *          Optional. Field mask identifying which fields from `cmek_settings` should
     *          be updated. A field will be overwritten if and only if it is in the update
     *          mask. Output only fields cannot be updated.
     *
     *          See [FieldMask][google.protobuf.FieldMask] for more information.
     *
     *          Example: `"updateMask=kmsKeyName"`
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Logging\V2\CmekSettings
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function updateCmekSettings($name, $cmekSettings, array $optionalArgs = [])
    {
        $request = new UpdateCmekSettingsRequest();
        $request->setName($name);
        $request->setCmekSettings($cmekSettings);
        if (isset($optionalArgs['updateMask'])) {
            $request->setUpdateMask($optionalArgs['updateMask']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'UpdateCmekSettings',
            CmekSettings::class,
            $optionalArgs,
            $request
        )->wait();
    }
}
