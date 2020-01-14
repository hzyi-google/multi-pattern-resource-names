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
 * https://github.com/google/googleapis/blob/master/google/cloud/bigquery/datatransfer/v1/datatransfer.proto
 * and updates to that file get reflected here through a refresh process.
 *
 * @experimental
 */

namespace Google\Cloud\BigQuery\DataTransfer\V1\Gapic;

use Google\ApiCore\ApiException;
use Google\ApiCore\CredentialsWrapper;
use Google\ApiCore\GapicClientTrait;
use Google\ApiCore\PathTemplate;
use Google\ApiCore\RequestParamsHeaderDescriptor;
use Google\ApiCore\RetrySettings;
use Google\ApiCore\Transport\TransportInterface;
use Google\ApiCore\ValidationException;
use Google\Auth\FetchAuthTokenInterface;
use Google\Cloud\BigQuery\DataTransfer\V1\CheckValidCredsRequest;
use Google\Cloud\BigQuery\DataTransfer\V1\CheckValidCredsResponse;
use Google\Cloud\BigQuery\DataTransfer\V1\CreateTransferConfigRequest;
use Google\Cloud\BigQuery\DataTransfer\V1\DataSource;
use Google\Cloud\BigQuery\DataTransfer\V1\DeleteTransferConfigRequest;
use Google\Cloud\BigQuery\DataTransfer\V1\DeleteTransferRunRequest;
use Google\Cloud\BigQuery\DataTransfer\V1\GetDataSourceRequest;
use Google\Cloud\BigQuery\DataTransfer\V1\GetTransferConfigRequest;
use Google\Cloud\BigQuery\DataTransfer\V1\GetTransferRunRequest;
use Google\Cloud\BigQuery\DataTransfer\V1\ListDataSourcesRequest;
use Google\Cloud\BigQuery\DataTransfer\V1\ListDataSourcesResponse;
use Google\Cloud\BigQuery\DataTransfer\V1\ListTransferConfigsRequest;
use Google\Cloud\BigQuery\DataTransfer\V1\ListTransferConfigsResponse;
use Google\Cloud\BigQuery\DataTransfer\V1\ListTransferLogsRequest;
use Google\Cloud\BigQuery\DataTransfer\V1\ListTransferLogsResponse;
use Google\Cloud\BigQuery\DataTransfer\V1\ListTransferRunsRequest;
use Google\Cloud\BigQuery\DataTransfer\V1\ListTransferRunsRequest\RunAttempt;
use Google\Cloud\BigQuery\DataTransfer\V1\ListTransferRunsResponse;
use Google\Cloud\BigQuery\DataTransfer\V1\ScheduleTransferRunsRequest;
use Google\Cloud\BigQuery\DataTransfer\V1\ScheduleTransferRunsResponse;
use Google\Cloud\BigQuery\DataTransfer\V1\StartManualTransferRunsRequest;
use Google\Cloud\BigQuery\DataTransfer\V1\StartManualTransferRunsRequest\TimeRange;
use Google\Cloud\BigQuery\DataTransfer\V1\StartManualTransferRunsResponse;
use Google\Cloud\BigQuery\DataTransfer\V1\TransferConfig;
use Google\Cloud\BigQuery\DataTransfer\V1\TransferRun;
use Google\Cloud\BigQuery\DataTransfer\V1\UpdateTransferConfigRequest;
use Google\Protobuf\FieldMask;
use Google\Protobuf\GPBEmpty;
use Google\Protobuf\Timestamp;

/**
 * Service Description: The Google BigQuery Data Transfer Service API enables BigQuery users to
 * configure the transfer of their data from other Google Products into
 * BigQuery. This service contains methods that are end user exposed. It backs
 * up the frontend.
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $dataTransferServiceClient = new DataTransferServiceClient();
 * try {
 *     $response = $dataTransferServiceClient->getDataSource();
 * } finally {
 *     $dataTransferServiceClient->close();
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
class DataTransferServiceGapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'google.cloud.bigquery.datatransfer.v1.DataTransferService';

    /**
     * The default address of the service.
     */
    const SERVICE_ADDRESS = 'bigquerydatatransfer.googleapis.com';

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
    private static $locationNameTemplate;
    private static $pathTemplateMap;

    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS.':'.self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__.'/../resources/data_transfer_service_client_config.json',
            'descriptorsConfigPath' => __DIR__.'/../resources/data_transfer_service_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__.'/../resources/data_transfer_service_grpc_config.json',
            'credentialsConfig' => [
                'scopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__.'/../resources/data_transfer_service_rest_client_config.php',
                ],
            ],
        ];
    }

    private static function getLocationNameTemplate()
    {
        if (null == self::$locationNameTemplate) {
            self::$locationNameTemplate = new PathTemplate('projects/{project}/locations/{location}');
        }

        return self::$locationNameTemplate;
    }

    private static function getPathTemplateMap()
    {
        if (null == self::$pathTemplateMap) {
            self::$pathTemplateMap = [
                'location' => self::getLocationNameTemplate(),
            ];
        }

        return self::$pathTemplateMap;
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
     * Parses a formatted name string and returns an associative array of the components in the name.
     * The following name formats are supported:
     * Template: Pattern
     * - location: projects/{project}/locations/{location}.
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
     *           as "<uri>:<port>". Default 'bigquerydatatransfer.googleapis.com:443'.
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
     * Retrieves a supported data source and returns its settings,
     * which can be used for UI rendering.
     *
     * Sample code:
     * ```
     * $dataTransferServiceClient = new DataTransferServiceClient();
     * try {
     *     $response = $dataTransferServiceClient->getDataSource();
     * } finally {
     *     $dataTransferServiceClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $name
     *          Required. The field will contain name of the resource requested, for example:
     *          `projects/{project_id}/dataSources/{data_source_id}` or
     *          `projects/{project_id}/locations/{location_id}/dataSources/{data_source_id}`
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\BigQuery\DataTransfer\V1\DataSource
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getDataSource(array $optionalArgs = [])
    {
        $request = new GetDataSourceRequest();
        if (isset($optionalArgs['name'])) {
            $request->setName($optionalArgs['name']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetDataSource',
            DataSource::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Lists supported data sources and returns their settings,
     * which can be used for UI rendering.
     *
     * Sample code:
     * ```
     * $dataTransferServiceClient = new DataTransferServiceClient();
     * try {
     *     $response = $dataTransferServiceClient->listDataSources();
     * } finally {
     *     $dataTransferServiceClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $parent
     *          Required. The BigQuery project id for which data sources should be returned.
     *          Must be in the form: `projects/{project_id}` or
     *          `projects/{project_id}/locations/{location_id}
     *     @type string $pageToken
     *          Pagination token, which can be used to request a specific page
     *          of `ListDataSourcesRequest` list results. For multiple-page
     *          results, `ListDataSourcesResponse` outputs
     *          a `next_page` token, which can be used as the
     *          `page_token` value to request the next page of list results.
     *     @type int $pageSize
     *          Page size. The default page size is the maximum value of 1000 results.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\BigQuery\DataTransfer\V1\ListDataSourcesResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function listDataSources(array $optionalArgs = [])
    {
        $request = new ListDataSourcesRequest();
        if (isset($optionalArgs['parent'])) {
            $request->setParent($optionalArgs['parent']);
        }
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

        return $this->startCall(
            'ListDataSources',
            ListDataSourcesResponse::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Creates a new data transfer configuration.
     *
     * Sample code:
     * ```
     * $dataTransferServiceClient = new DataTransferServiceClient();
     * try {
     *     $response = $dataTransferServiceClient->createTransferConfig();
     * } finally {
     *     $dataTransferServiceClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $parent
     *          Required. The BigQuery project id where the transfer configuration should be created.
     *          Must be in the format projects/{project_id}/locations/{location_id} or
     *          projects/{project_id}. If specified location and location of the
     *          destination bigquery dataset do not match - the request will fail.
     *     @type TransferConfig $transferConfig
     *          Required. Data transfer configuration to create.
     *     @type string $authorizationCode
     *          Optional OAuth2 authorization code to use with this transfer configuration.
     *          This is required if new credentials are needed, as indicated by
     *          `CheckValidCreds`.
     *          In order to obtain authorization_code, please make a
     *          request to
     *          https://www.gstatic.com/bigquerydatatransfer/oauthz/auth?client_id=<datatransferapiclientid>&scope=<data_source_scopes>&redirect_uri=<redirect_uri>
     *
     *          * client_id should be OAuth client_id of BigQuery DTS API for the given
     *            data source returned by ListDataSources method.
     *          * data_source_scopes are the scopes returned by ListDataSources method.
     *          * redirect_uri is an optional parameter. If not specified, then
     *            authorization code is posted to the opener of authorization flow window.
     *            Otherwise it will be sent to the redirect uri. A special value of
     *            urn:ietf:wg:oauth:2.0:oob means that authorization code should be
     *            returned in the title bar of the browser, with the page text prompting
     *            the user to copy the code and paste it in the application.
     *     @type string $versionInfo
     *          Optional version info. If users want to find a very recent access token,
     *          that is, immediately after approving access, users have to set the
     *          version_info claim in the token request. To obtain the version_info, users
     *          must use the "none+gsession" response type. which be return a
     *          version_info back in the authorization response which be be put in a JWT
     *          claim in the token request.
     *     @type string $serviceAccountName
     *          Optional service account name. If this field is set, transfer config will
     *          be created with this service account credentials. It requires that
     *          requesting user calling this API has permissions to act as this service
     *          account.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\BigQuery\DataTransfer\V1\TransferConfig
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function createTransferConfig(array $optionalArgs = [])
    {
        $request = new CreateTransferConfigRequest();
        if (isset($optionalArgs['parent'])) {
            $request->setParent($optionalArgs['parent']);
        }
        if (isset($optionalArgs['transferConfig'])) {
            $request->setTransferConfig($optionalArgs['transferConfig']);
        }
        if (isset($optionalArgs['authorizationCode'])) {
            $request->setAuthorizationCode($optionalArgs['authorizationCode']);
        }
        if (isset($optionalArgs['versionInfo'])) {
            $request->setVersionInfo($optionalArgs['versionInfo']);
        }
        if (isset($optionalArgs['serviceAccountName'])) {
            $request->setServiceAccountName($optionalArgs['serviceAccountName']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'CreateTransferConfig',
            TransferConfig::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Updates a data transfer configuration.
     * All fields must be set, even if they are not updated.
     *
     * Sample code:
     * ```
     * $dataTransferServiceClient = new DataTransferServiceClient();
     * try {
     *     $response = $dataTransferServiceClient->updateTransferConfig();
     * } finally {
     *     $dataTransferServiceClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type TransferConfig $transferConfig
     *          Required. Data transfer configuration to create.
     *     @type string $authorizationCode
     *          Optional OAuth2 authorization code to use with this transfer configuration.
     *          If it is provided, the transfer configuration will be associated with the
     *          authorizing user.
     *          In order to obtain authorization_code, please make a
     *          request to
     *          https://www.gstatic.com/bigquerydatatransfer/oauthz/auth?client_id=<datatransferapiclientid>&scope=<data_source_scopes>&redirect_uri=<redirect_uri>
     *
     *          * client_id should be OAuth client_id of BigQuery DTS API for the given
     *            data source returned by ListDataSources method.
     *          * data_source_scopes are the scopes returned by ListDataSources method.
     *          * redirect_uri is an optional parameter. If not specified, then
     *            authorization code is posted to the opener of authorization flow window.
     *            Otherwise it will be sent to the redirect uri. A special value of
     *            urn:ietf:wg:oauth:2.0:oob means that authorization code should be
     *            returned in the title bar of the browser, with the page text prompting
     *            the user to copy the code and paste it in the application.
     *     @type FieldMask $updateMask
     *          Required. Required list of fields to be updated in this request.
     *     @type string $versionInfo
     *          Optional version info. If users want to find a very recent access token,
     *          that is, immediately after approving access, users have to set the
     *          version_info claim in the token request. To obtain the version_info, users
     *          must use the "none+gsession" response type. which be return a
     *          version_info back in the authorization response which be be put in a JWT
     *          claim in the token request.
     *     @type string $serviceAccountName
     *          Optional service account name. If this field is set and
     *          "service_account_name" is set in update_mask, transfer config will be
     *          updated to use this service account credentials. It requires that
     *          requesting user calling this API has permissions to act as this service
     *          account.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\BigQuery\DataTransfer\V1\TransferConfig
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function updateTransferConfig(array $optionalArgs = [])
    {
        $request = new UpdateTransferConfigRequest();
        if (isset($optionalArgs['transferConfig'])) {
            $request->setTransferConfig($optionalArgs['transferConfig']);
        }
        if (isset($optionalArgs['authorizationCode'])) {
            $request->setAuthorizationCode($optionalArgs['authorizationCode']);
        }
        if (isset($optionalArgs['updateMask'])) {
            $request->setUpdateMask($optionalArgs['updateMask']);
        }
        if (isset($optionalArgs['versionInfo'])) {
            $request->setVersionInfo($optionalArgs['versionInfo']);
        }
        if (isset($optionalArgs['serviceAccountName'])) {
            $request->setServiceAccountName($optionalArgs['serviceAccountName']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'transfer_config.name' => $request->getTransferConfig()->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'UpdateTransferConfig',
            TransferConfig::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Deletes a data transfer configuration,
     * including any associated transfer runs and logs.
     *
     * Sample code:
     * ```
     * $dataTransferServiceClient = new DataTransferServiceClient();
     * try {
     *     $dataTransferServiceClient->deleteTransferConfig();
     * } finally {
     *     $dataTransferServiceClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $name
     *          Required. The field will contain name of the resource requested, for example:
     *          `projects/{project_id}/transferConfigs/{config_id}` or
     *          `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`
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
    public function deleteTransferConfig(array $optionalArgs = [])
    {
        $request = new DeleteTransferConfigRequest();
        if (isset($optionalArgs['name'])) {
            $request->setName($optionalArgs['name']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'DeleteTransferConfig',
            GPBEmpty::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Returns information about a data transfer config.
     *
     * Sample code:
     * ```
     * $dataTransferServiceClient = new DataTransferServiceClient();
     * try {
     *     $response = $dataTransferServiceClient->getTransferConfig();
     * } finally {
     *     $dataTransferServiceClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $name
     *          Required. The field will contain name of the resource requested, for example:
     *          `projects/{project_id}/transferConfigs/{config_id}` or
     *          `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\BigQuery\DataTransfer\V1\TransferConfig
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getTransferConfig(array $optionalArgs = [])
    {
        $request = new GetTransferConfigRequest();
        if (isset($optionalArgs['name'])) {
            $request->setName($optionalArgs['name']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetTransferConfig',
            TransferConfig::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Returns information about all data transfers in the project.
     *
     * Sample code:
     * ```
     * $dataTransferServiceClient = new DataTransferServiceClient();
     * try {
     *     $response = $dataTransferServiceClient->listTransferConfigs();
     * } finally {
     *     $dataTransferServiceClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $parent
     *          Required. The BigQuery project id for which data sources
     *          should be returned: `projects/{project_id}` or
     *          `projects/{project_id}/locations/{location_id}`
     *     @type string[] $dataSourceIds
     *          When specified, only configurations of requested data sources are returned.
     *     @type string $pageToken
     *          Pagination token, which can be used to request a specific page
     *          of `ListTransfersRequest` list results. For multiple-page
     *          results, `ListTransfersResponse` outputs
     *          a `next_page` token, which can be used as the
     *          `page_token` value to request the next page of list results.
     *     @type int $pageSize
     *          Page size. The default page size is the maximum value of 1000 results.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\BigQuery\DataTransfer\V1\ListTransferConfigsResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function listTransferConfigs(array $optionalArgs = [])
    {
        $request = new ListTransferConfigsRequest();
        if (isset($optionalArgs['parent'])) {
            $request->setParent($optionalArgs['parent']);
        }
        if (isset($optionalArgs['dataSourceIds'])) {
            $request->setDataSourceIds($optionalArgs['dataSourceIds']);
        }
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

        return $this->startCall(
            'ListTransferConfigs',
            ListTransferConfigsResponse::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Creates transfer runs for a time range [start_time, end_time].
     * For each date - or whatever granularity the data source supports - in the
     * range, one transfer run is created.
     * Note that runs are created per UTC time in the time range.
     * DEPRECATED: use StartManualTransferRuns instead.
     *
     * Sample code:
     * ```
     * $dataTransferServiceClient = new DataTransferServiceClient();
     * try {
     *     $response = $dataTransferServiceClient->scheduleTransferRuns();
     * } finally {
     *     $dataTransferServiceClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $parent
     *          Required. Transfer configuration name in the form:
     *          `projects/{project_id}/transferConfigs/{config_id}` or
     *          `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`.
     *     @type Timestamp $startTime
     *          Required. Start time of the range of transfer runs. For example,
     *          `"2017-05-25T00:00:00+00:00"`.
     *     @type Timestamp $endTime
     *          Required. End time of the range of transfer runs. For example,
     *          `"2017-05-30T00:00:00+00:00"`.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\BigQuery\DataTransfer\V1\ScheduleTransferRunsResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function scheduleTransferRuns(array $optionalArgs = [])
    {
        $request = new ScheduleTransferRunsRequest();
        if (isset($optionalArgs['parent'])) {
            $request->setParent($optionalArgs['parent']);
        }
        if (isset($optionalArgs['startTime'])) {
            $request->setStartTime($optionalArgs['startTime']);
        }
        if (isset($optionalArgs['endTime'])) {
            $request->setEndTime($optionalArgs['endTime']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'ScheduleTransferRuns',
            ScheduleTransferRunsResponse::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Start manual transfer runs to be executed now with schedule_time equal to
     * current time. The transfer runs can be created for a time range where the
     * run_time is between start_time (inclusive) and end_time (exclusive), or for
     * a specific run_time.
     *
     * Sample code:
     * ```
     * $dataTransferServiceClient = new DataTransferServiceClient();
     * try {
     *     $response = $dataTransferServiceClient->startManualTransferRuns();
     * } finally {
     *     $dataTransferServiceClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $parent
     *          Transfer configuration name in the form:
     *          `projects/{project_id}/transferConfigs/{config_id}` or
     *          `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`.
     *     @type TimeRange $requestedTimeRange
     *          Time range for the transfer runs that should be started.
     *     @type Timestamp $requestedRunTime
     *          Specific run_time for a transfer run to be started. The
     *          requested_run_time must not be in the future.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\BigQuery\DataTransfer\V1\StartManualTransferRunsResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function startManualTransferRuns(array $optionalArgs = [])
    {
        $request = new StartManualTransferRunsRequest();
        if (isset($optionalArgs['parent'])) {
            $request->setParent($optionalArgs['parent']);
        }
        if (isset($optionalArgs['requestedTimeRange'])) {
            $request->setRequestedTimeRange($optionalArgs['requestedTimeRange']);
        }
        if (isset($optionalArgs['requestedRunTime'])) {
            $request->setRequestedRunTime($optionalArgs['requestedRunTime']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'StartManualTransferRuns',
            StartManualTransferRunsResponse::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Returns information about the particular transfer run.
     *
     * Sample code:
     * ```
     * $dataTransferServiceClient = new DataTransferServiceClient();
     * try {
     *     $response = $dataTransferServiceClient->getTransferRun();
     * } finally {
     *     $dataTransferServiceClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $name
     *          Required. The field will contain name of the resource requested, for example:
     *          `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}` or
     *          `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}/runs/{run_id}`
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\BigQuery\DataTransfer\V1\TransferRun
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getTransferRun(array $optionalArgs = [])
    {
        $request = new GetTransferRunRequest();
        if (isset($optionalArgs['name'])) {
            $request->setName($optionalArgs['name']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetTransferRun',
            TransferRun::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Deletes the specified transfer run.
     *
     * Sample code:
     * ```
     * $dataTransferServiceClient = new DataTransferServiceClient();
     * try {
     *     $dataTransferServiceClient->deleteTransferRun();
     * } finally {
     *     $dataTransferServiceClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $name
     *          Required. The field will contain name of the resource requested, for example:
     *          `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}` or
     *          `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}/runs/{run_id}`
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
    public function deleteTransferRun(array $optionalArgs = [])
    {
        $request = new DeleteTransferRunRequest();
        if (isset($optionalArgs['name'])) {
            $request->setName($optionalArgs['name']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'DeleteTransferRun',
            GPBEmpty::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Returns information about running and completed jobs.
     *
     * Sample code:
     * ```
     * $dataTransferServiceClient = new DataTransferServiceClient();
     * try {
     *     $response = $dataTransferServiceClient->listTransferRuns();
     * } finally {
     *     $dataTransferServiceClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $parent
     *          Required. Name of transfer configuration for which transfer runs should be retrieved.
     *          Format of transfer configuration resource name is:
     *          `projects/{project_id}/transferConfigs/{config_id}` or
     *          `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`.
     *     @type int[] $states
     *          When specified, only transfer runs with requested states are returned.
     *          For allowed values, use constants defined on {@see \Google\Cloud\BigQuery\DataTransfer\V1\TransferState}
     *     @type string $pageToken
     *          Pagination token, which can be used to request a specific page
     *          of `ListTransferRunsRequest` list results. For multiple-page
     *          results, `ListTransferRunsResponse` outputs
     *          a `next_page` token, which can be used as the
     *          `page_token` value to request the next page of list results.
     *     @type int $pageSize
     *          Page size. The default page size is the maximum value of 1000 results.
     *     @type int $runAttempt
     *          Indicates how run attempts are to be pulled.
     *          For allowed values, use constants defined on {@see \Google\Cloud\BigQuery\DataTransfer\V1\ListTransferRunsRequest\RunAttempt}
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\BigQuery\DataTransfer\V1\ListTransferRunsResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function listTransferRuns(array $optionalArgs = [])
    {
        $request = new ListTransferRunsRequest();
        if (isset($optionalArgs['parent'])) {
            $request->setParent($optionalArgs['parent']);
        }
        if (isset($optionalArgs['states'])) {
            $request->setStates($optionalArgs['states']);
        }
        if (isset($optionalArgs['pageToken'])) {
            $request->setPageToken($optionalArgs['pageToken']);
        }
        if (isset($optionalArgs['pageSize'])) {
            $request->setPageSize($optionalArgs['pageSize']);
        }
        if (isset($optionalArgs['runAttempt'])) {
            $request->setRunAttempt($optionalArgs['runAttempt']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'ListTransferRuns',
            ListTransferRunsResponse::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Returns user facing log messages for the data transfer run.
     *
     * Sample code:
     * ```
     * $dataTransferServiceClient = new DataTransferServiceClient();
     * try {
     *     $response = $dataTransferServiceClient->listTransferLogs();
     * } finally {
     *     $dataTransferServiceClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $parent
     *          Required. Transfer run name in the form:
     *          `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}` or
     *          `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}/runs/{run_id}`
     *     @type string $pageToken
     *          Pagination token, which can be used to request a specific page
     *          of `ListTransferLogsRequest` list results. For multiple-page
     *          results, `ListTransferLogsResponse` outputs
     *          a `next_page` token, which can be used as the
     *          `page_token` value to request the next page of list results.
     *     @type int $pageSize
     *          Page size. The default page size is the maximum value of 1000 results.
     *     @type int[] $messageTypes
     *          Message types to return. If not populated - INFO, WARNING and ERROR
     *          messages are returned.
     *          For allowed values, use constants defined on {@see \Google\Cloud\BigQuery\DataTransfer\V1\TransferMessage\MessageSeverity}
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\BigQuery\DataTransfer\V1\ListTransferLogsResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function listTransferLogs(array $optionalArgs = [])
    {
        $request = new ListTransferLogsRequest();
        if (isset($optionalArgs['parent'])) {
            $request->setParent($optionalArgs['parent']);
        }
        if (isset($optionalArgs['pageToken'])) {
            $request->setPageToken($optionalArgs['pageToken']);
        }
        if (isset($optionalArgs['pageSize'])) {
            $request->setPageSize($optionalArgs['pageSize']);
        }
        if (isset($optionalArgs['messageTypes'])) {
            $request->setMessageTypes($optionalArgs['messageTypes']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'ListTransferLogs',
            ListTransferLogsResponse::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Returns true if valid credentials exist for the given data source and
     * requesting user.
     * Some data sources doesn't support service account, so we need to talk to
     * them on behalf of the end user. This API just checks whether we have OAuth
     * token for the particular user, which is a pre-requisite before user can
     * create a transfer config.
     *
     * Sample code:
     * ```
     * $dataTransferServiceClient = new DataTransferServiceClient();
     * try {
     *     $response = $dataTransferServiceClient->checkValidCreds();
     * } finally {
     *     $dataTransferServiceClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $name
     *          Required. The data source in the form:
     *          `projects/{project_id}/dataSources/{data_source_id}` or
     *          `projects/{project_id}/locations/{location_id}/dataSources/{data_source_id}`.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\BigQuery\DataTransfer\V1\CheckValidCredsResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function checkValidCreds(array $optionalArgs = [])
    {
        $request = new CheckValidCredsRequest();
        if (isset($optionalArgs['name'])) {
            $request->setName($optionalArgs['name']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'CheckValidCreds',
            CheckValidCredsResponse::class,
            $optionalArgs,
            $request
        )->wait();
    }
}
