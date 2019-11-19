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
 * https://github.com/google/googleapis/blob/master/google/devtools/containeranalysis/v1beta1/grafeas/grafeas.proto
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
use Google\Protobuf\FieldMask;
use Google\Protobuf\GPBEmpty;
use Grafeas\V1beta1\BatchCreateNotesRequest;
use Grafeas\V1beta1\BatchCreateNotesRequest\NotesEntry;
use Grafeas\V1beta1\BatchCreateNotesResponse;
use Grafeas\V1beta1\BatchCreateOccurrencesRequest;
use Grafeas\V1beta1\BatchCreateOccurrencesResponse;
use Grafeas\V1beta1\CreateNoteRequest;
use Grafeas\V1beta1\CreateOccurrenceRequest;
use Grafeas\V1beta1\DeleteNoteRequest;
use Grafeas\V1beta1\DeleteOccurrenceRequest;
use Grafeas\V1beta1\GetNoteRequest;
use Grafeas\V1beta1\GetOccurrenceNoteRequest;
use Grafeas\V1beta1\GetOccurrenceRequest;
use Grafeas\V1beta1\GetVulnerabilityOccurrencesSummaryRequest;
use Grafeas\V1beta1\GrafeasV1Beta1GrpcClient;
use Grafeas\V1beta1\ListNoteOccurrencesRequest;
use Grafeas\V1beta1\ListNoteOccurrencesResponse;
use Grafeas\V1beta1\ListNotesRequest;
use Grafeas\V1beta1\ListNotesResponse;
use Grafeas\V1beta1\ListOccurrencesRequest;
use Grafeas\V1beta1\ListOccurrencesResponse;
use Grafeas\V1beta1\Note;
use Grafeas\V1beta1\Occurrence;
use Grafeas\V1beta1\UpdateNoteRequest;
use Grafeas\V1beta1\UpdateOccurrenceRequest;
use Grafeas\V1beta1\VulnerabilityOccurrencesSummary;

/**
 * Service Description: [Grafeas](https://cloud.google.comgrafeas.io) API.
 *
 * Retrieves analysis results of Cloud components such as Docker container
 * images.
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
 * $grafeasV1Beta1Client = new GrafeasV1Beta1Client();
 * try {
 *     $formattedName = $grafeasV1Beta1Client->occurrenceName('[PROJECT]', '[OCCURRENCE]');
 *     $response = $grafeasV1Beta1Client->getOccurrence($formattedName);
 * } finally {
 *     $grafeasV1Beta1Client->close();
 * }
 * ```
 *
 * Many parameters require resource names to be formatted in a particular way. To assist
 * with these names, this class includes a format method for each type of name, and additionally
 * a parseName method to extract the individual identifiers contained within formatted names
 * that are returned by the API.
 * @experimental
 */
class GrafeasV1Beta1GapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'grafeas.v1beta1.GrafeasV1Beta1';

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
    private static $pathTemplateMap;


    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS . ':' . self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__ . '/../resources/grafeas_v1_beta1_client_config.json',
            'descriptorsConfigPath' => __DIR__ . '/../resources/grafeas_v1_beta1_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__ . '/../resources/grafeas_v1_beta1_grpc_config.json',
            'credentialsConfig' => [
                'scopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__ . '/../resources/grafeas_v1_beta1_rest_client_config.php',
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


    private static function getPathTemplateMap()
    {
        if (self::$pathTemplateMap == null) {
            self::$pathTemplateMap = [
                'note' => self::getNoteNameTemplate(),
                'occurrence' => self::getOccurrenceNameTemplate(),
                'project' => self::getProjectNameTemplate(),
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
     * Parses a formatted name string and returns an associative array of the components in the name.
     * The following name formats are supported:
     * Template: Pattern
     * - note: projects/{project}/notes/{note}
     * - occurrence: projects/{project}/occurrences/{occurrence}
     * - project: projects/{project}
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
     * Gets the specified occurrence.
     *
     * Sample code:
     * ```
     * $grafeasV1Beta1Client = new GrafeasV1Beta1Client();
     * try {
     *     $formattedName = $grafeasV1Beta1Client->occurrenceName('[PROJECT]', '[OCCURRENCE]');
     *     $response = $grafeasV1Beta1Client->getOccurrence($formattedName);
     * } finally {
     *     $grafeasV1Beta1Client->close();
     * }
     * ```
     *
     * @param string $name The name of the occurrence in the form of
     * `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
     * @param array $optionalArgs {
     *     Optional.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Grafeas\V1beta1\Occurrence
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getOccurrence($name, array $optionalArgs = [])
    {
        $request = new GetOccurrenceRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetOccurrence',
            Occurrence::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Lists occurrences for the specified project.
     *
     * Sample code:
     * ```
     * $grafeasV1Beta1Client = new GrafeasV1Beta1Client();
     * try {
     *     $formattedParent = $grafeasV1Beta1Client->projectName('[PROJECT]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $grafeasV1Beta1Client->listOccurrences($formattedParent);
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
     *     $pagedResponse = $grafeasV1Beta1Client->listOccurrences($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $grafeasV1Beta1Client->close();
     * }
     * ```
     *
     * @param string $parent The name of the project to list occurrences for in the form of
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
    public function listOccurrences($parent, array $optionalArgs = [])
    {
        $request = new ListOccurrencesRequest();
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
            'ListOccurrences',
            $optionalArgs,
            ListOccurrencesResponse::class,
            $request
        );
    }

    /**
     * Deletes the specified occurrence. For example, use this method to delete an
     * occurrence when the occurrence is no longer applicable for the given
     * resource.
     *
     * Sample code:
     * ```
     * $grafeasV1Beta1Client = new GrafeasV1Beta1Client();
     * try {
     *     $formattedName = $grafeasV1Beta1Client->occurrenceName('[PROJECT]', '[OCCURRENCE]');
     *     $grafeasV1Beta1Client->deleteOccurrence($formattedName);
     * } finally {
     *     $grafeasV1Beta1Client->close();
     * }
     * ```
     *
     * @param string $name The name of the occurrence in the form of
     * `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
     * @param array $optionalArgs {
     *     Optional.
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
    public function deleteOccurrence($name, array $optionalArgs = [])
    {
        $request = new DeleteOccurrenceRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'DeleteOccurrence',
            GPBEmpty::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Creates a new occurrence.
     *
     * Sample code:
     * ```
     * $grafeasV1Beta1Client = new GrafeasV1Beta1Client();
     * try {
     *     $formattedParent = $grafeasV1Beta1Client->projectName('[PROJECT]');
     *     $occurrence = new Occurrence();
     *     $response = $grafeasV1Beta1Client->createOccurrence($formattedParent, $occurrence);
     * } finally {
     *     $grafeasV1Beta1Client->close();
     * }
     * ```
     *
     * @param string $parent The name of the project in the form of `projects/[PROJECT_ID]`, under which
     * the occurrence is to be created.
     * @param Occurrence $occurrence The occurrence to create.
     * @param array $optionalArgs {
     *     Optional.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Grafeas\V1beta1\Occurrence
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function createOccurrence($parent, $occurrence, array $optionalArgs = [])
    {
        $request = new CreateOccurrenceRequest();
        $request->setParent($parent);
        $request->setOccurrence($occurrence);

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'CreateOccurrence',
            Occurrence::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Creates new occurrences in batch.
     *
     * Sample code:
     * ```
     * $grafeasV1Beta1Client = new GrafeasV1Beta1Client();
     * try {
     *     $formattedParent = $grafeasV1Beta1Client->projectName('[PROJECT]');
     *     $occurrences = [];
     *     $response = $grafeasV1Beta1Client->batchCreateOccurrences($formattedParent, $occurrences);
     * } finally {
     *     $grafeasV1Beta1Client->close();
     * }
     * ```
     *
     * @param string $parent The name of the project in the form of `projects/[PROJECT_ID]`, under which
     * the occurrences are to be created.
     * @param Occurrence[] $occurrences The occurrences to create.
     * @param array $optionalArgs {
     *     Optional.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Grafeas\V1beta1\BatchCreateOccurrencesResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function batchCreateOccurrences($parent, $occurrences, array $optionalArgs = [])
    {
        $request = new BatchCreateOccurrencesRequest();
        $request->setParent($parent);
        $request->setOccurrences($occurrences);

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'BatchCreateOccurrences',
            BatchCreateOccurrencesResponse::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Updates the specified occurrence.
     *
     * Sample code:
     * ```
     * $grafeasV1Beta1Client = new GrafeasV1Beta1Client();
     * try {
     *     $formattedName = $grafeasV1Beta1Client->occurrenceName('[PROJECT]', '[OCCURRENCE]');
     *     $occurrence = new Occurrence();
     *     $response = $grafeasV1Beta1Client->updateOccurrence($formattedName, $occurrence);
     * } finally {
     *     $grafeasV1Beta1Client->close();
     * }
     * ```
     *
     * @param string $name The name of the occurrence in the form of
     * `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
     * @param Occurrence $occurrence The updated occurrence.
     * @param array $optionalArgs {
     *     Optional.
     *     @type FieldMask $updateMask
     *          The fields to update.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Grafeas\V1beta1\Occurrence
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function updateOccurrence($name, $occurrence, array $optionalArgs = [])
    {
        $request = new UpdateOccurrenceRequest();
        $request->setName($name);
        $request->setOccurrence($occurrence);
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
            'UpdateOccurrence',
            Occurrence::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Gets the note attached to the specified occurrence. Consumer projects can
     * use this method to get a note that belongs to a provider project.
     *
     * Sample code:
     * ```
     * $grafeasV1Beta1Client = new GrafeasV1Beta1Client();
     * try {
     *     $formattedName = $grafeasV1Beta1Client->occurrenceName('[PROJECT]', '[OCCURRENCE]');
     *     $response = $grafeasV1Beta1Client->getOccurrenceNote($formattedName);
     * } finally {
     *     $grafeasV1Beta1Client->close();
     * }
     * ```
     *
     * @param string $name The name of the occurrence in the form of
     * `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
     * @param array $optionalArgs {
     *     Optional.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Grafeas\V1beta1\Note
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getOccurrenceNote($name, array $optionalArgs = [])
    {
        $request = new GetOccurrenceNoteRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetOccurrenceNote',
            Note::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Gets the specified note.
     *
     * Sample code:
     * ```
     * $grafeasV1Beta1Client = new GrafeasV1Beta1Client();
     * try {
     *     $formattedName = $grafeasV1Beta1Client->noteName('[PROJECT]', '[NOTE]');
     *     $response = $grafeasV1Beta1Client->getNote($formattedName);
     * } finally {
     *     $grafeasV1Beta1Client->close();
     * }
     * ```
     *
     * @param string $name The name of the note in the form of
     * `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
     * @param array $optionalArgs {
     *     Optional.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Grafeas\V1beta1\Note
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getNote($name, array $optionalArgs = [])
    {
        $request = new GetNoteRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetNote',
            Note::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Lists notes for the specified project.
     *
     * Sample code:
     * ```
     * $grafeasV1Beta1Client = new GrafeasV1Beta1Client();
     * try {
     *     $formattedParent = $grafeasV1Beta1Client->projectName('[PROJECT]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $grafeasV1Beta1Client->listNotes($formattedParent);
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
     *     $pagedResponse = $grafeasV1Beta1Client->listNotes($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $grafeasV1Beta1Client->close();
     * }
     * ```
     *
     * @param string $parent The name of the project to list notes for in the form of
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
    public function listNotes($parent, array $optionalArgs = [])
    {
        $request = new ListNotesRequest();
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
            'ListNotes',
            $optionalArgs,
            ListNotesResponse::class,
            $request
        );
    }

    /**
     * Deletes the specified note.
     *
     * Sample code:
     * ```
     * $grafeasV1Beta1Client = new GrafeasV1Beta1Client();
     * try {
     *     $formattedName = $grafeasV1Beta1Client->noteName('[PROJECT]', '[NOTE]');
     *     $grafeasV1Beta1Client->deleteNote($formattedName);
     * } finally {
     *     $grafeasV1Beta1Client->close();
     * }
     * ```
     *
     * @param string $name The name of the note in the form of
     * `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
     * @param array $optionalArgs {
     *     Optional.
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
    public function deleteNote($name, array $optionalArgs = [])
    {
        $request = new DeleteNoteRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'DeleteNote',
            GPBEmpty::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Creates a new note.
     *
     * Sample code:
     * ```
     * $grafeasV1Beta1Client = new GrafeasV1Beta1Client();
     * try {
     *     $formattedParent = $grafeasV1Beta1Client->projectName('[PROJECT]');
     *     $noteId = '';
     *     $note = new Note();
     *     $response = $grafeasV1Beta1Client->createNote($formattedParent, $noteId, $note);
     * } finally {
     *     $grafeasV1Beta1Client->close();
     * }
     * ```
     *
     * @param string $parent The name of the project in the form of `projects/[PROJECT_ID]`, under which
     * the note is to be created.
     * @param string $noteId The ID to use for this note.
     * @param Note $note The note to create.
     * @param array $optionalArgs {
     *     Optional.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Grafeas\V1beta1\Note
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function createNote($parent, $noteId, $note, array $optionalArgs = [])
    {
        $request = new CreateNoteRequest();
        $request->setParent($parent);
        $request->setNoteId($noteId);
        $request->setNote($note);

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'CreateNote',
            Note::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Creates new notes in batch.
     *
     * Sample code:
     * ```
     * $grafeasV1Beta1Client = new GrafeasV1Beta1Client();
     * try {
     *     $formattedParent = $grafeasV1Beta1Client->projectName('[PROJECT]');
     *     $notes = [];
     *     $response = $grafeasV1Beta1Client->batchCreateNotes($formattedParent, $notes);
     * } finally {
     *     $grafeasV1Beta1Client->close();
     * }
     * ```
     *
     * @param string $parent The name of the project in the form of `projects/[PROJECT_ID]`, under which
     * the notes are to be created.
     * @param array $notes The notes to create.
     * @param array $optionalArgs {
     *     Optional.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Grafeas\V1beta1\BatchCreateNotesResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function batchCreateNotes($parent, $notes, array $optionalArgs = [])
    {
        $request = new BatchCreateNotesRequest();
        $request->setParent($parent);
        $request->setNotes($notes);

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'BatchCreateNotes',
            BatchCreateNotesResponse::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Updates the specified note.
     *
     * Sample code:
     * ```
     * $grafeasV1Beta1Client = new GrafeasV1Beta1Client();
     * try {
     *     $formattedName = $grafeasV1Beta1Client->noteName('[PROJECT]', '[NOTE]');
     *     $note = new Note();
     *     $response = $grafeasV1Beta1Client->updateNote($formattedName, $note);
     * } finally {
     *     $grafeasV1Beta1Client->close();
     * }
     * ```
     *
     * @param string $name The name of the note in the form of
     * `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
     * @param Note $note The updated note.
     * @param array $optionalArgs {
     *     Optional.
     *     @type FieldMask $updateMask
     *          The fields to update.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Grafeas\V1beta1\Note
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function updateNote($name, $note, array $optionalArgs = [])
    {
        $request = new UpdateNoteRequest();
        $request->setName($name);
        $request->setNote($note);
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
            'UpdateNote',
            Note::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Lists occurrences referencing the specified note. Provider projects can use
     * this method to get all occurrences across consumer projects referencing the
     * specified note.
     *
     * Sample code:
     * ```
     * $grafeasV1Beta1Client = new GrafeasV1Beta1Client();
     * try {
     *     $formattedName = $grafeasV1Beta1Client->noteName('[PROJECT]', '[NOTE]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $grafeasV1Beta1Client->listNoteOccurrences($formattedName);
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
     *     $pagedResponse = $grafeasV1Beta1Client->listNoteOccurrences($formattedName);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $grafeasV1Beta1Client->close();
     * }
     * ```
     *
     * @param string $name The name of the note to list occurrences for in the form of
     * `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
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
    public function listNoteOccurrences($name, array $optionalArgs = [])
    {
        $request = new ListNoteOccurrencesRequest();
        $request->setName($name);
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
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->getPagedListResponse(
            'ListNoteOccurrences',
            $optionalArgs,
            ListNoteOccurrencesResponse::class,
            $request
        );
    }

    /**
     * Gets a summary of the number and severity of occurrences.
     *
     * Sample code:
     * ```
     * $grafeasV1Beta1Client = new GrafeasV1Beta1Client();
     * try {
     *     $formattedParent = $grafeasV1Beta1Client->projectName('[PROJECT]');
     *     $response = $grafeasV1Beta1Client->getVulnerabilityOccurrencesSummary($formattedParent);
     * } finally {
     *     $grafeasV1Beta1Client->close();
     * }
     * ```
     *
     * @param string $parent The name of the project to get a vulnerability summary for in the form of
     * `projects/[PROJECT_ID]`.
     * @param array $optionalArgs {
     *     Optional.
     *     @type string $filter
     *          The filter expression.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Grafeas\V1beta1\VulnerabilityOccurrencesSummary
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getVulnerabilityOccurrencesSummary($parent, array $optionalArgs = [])
    {
        $request = new GetVulnerabilityOccurrencesSummaryRequest();
        $request->setParent($parent);
        if (isset($optionalArgs['filter'])) {
            $request->setFilter($optionalArgs['filter']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetVulnerabilityOccurrencesSummary',
            VulnerabilityOccurrencesSummary::class,
            $optionalArgs,
            $request
        )->wait();
    }
}
