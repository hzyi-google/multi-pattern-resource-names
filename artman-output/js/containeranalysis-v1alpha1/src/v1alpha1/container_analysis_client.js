// Copyright 2019 Google LLC
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

'use strict';

const gapicConfig = require('./container_analysis_client_config.json');
const gax = require('google-gax');
const path = require('path');

const VERSION = require('../../package.json').version;

/**
 * Retrieves the results of vulnerability scanning of cloud components such as
 * container images. The Container Analysis API is an implementation of the
 * [Grafeas](https://cloud.google.comgrafeas.io) API.
 *
 * The vulnerability results are stored as a series of Occurrences.
 * An `Occurrence` contains information about a specific vulnerability in a
 * resource. An `Occurrence` references a `Note`. A `Note` contains details
 * about the vulnerability and is stored in a stored in a separate project.
 * Multiple `Occurrences` can reference the same `Note`. For example, an SSL
 * vulnerability could affect multiple packages in an image. In this case,
 * there would be one `Note` for the vulnerability and an `Occurrence` for
 * each package with the vulnerability referencing that `Note`.
 *
 * @class
 * @memberof v1alpha1
 */
class ContainerAnalysisClient {
  /**
   * Construct an instance of ContainerAnalysisClient.
   *
   * @param {object} [options] - The configuration object. See the subsequent
   *   parameters for more details.
   * @param {object} [options.credentials] - Credentials object.
   * @param {string} [options.credentials.client_email]
   * @param {string} [options.credentials.private_key]
   * @param {string} [options.email] - Account email address. Required when
   *     using a .pem or .p12 keyFilename.
   * @param {string} [options.keyFilename] - Full path to the a .json, .pem, or
   *     .p12 key downloaded from the Google Developers Console. If you provide
   *     a path to a JSON file, the projectId option below is not necessary.
   *     NOTE: .pem and .p12 require you to specify options.email as well.
   * @param {number} [options.port] - The port on which to connect to
   *     the remote host.
   * @param {string} [options.projectId] - The project ID from the Google
   *     Developer's Console, e.g. 'grape-spaceship-123'. We will also check
   *     the environment variable GCLOUD_PROJECT for your project ID. If your
   *     app is running in an environment which supports
   *     {@link https://developers.google.com/identity/protocols/application-default-credentials Application Default Credentials},
   *     your project ID will be detected automatically.
   * @param {function} [options.promise] - Custom promise module to use instead
   *     of native Promises.
   * @param {string} [options.apiEndpoint] - The domain name of the
   *     API remote host.
   */
  constructor(opts) {
    opts = opts || {};
    this._descriptors = {};

    if (global.isBrowser) {
      // If we're in browser, we use gRPC fallback.
      opts.fallback = true;
    }

    // If we are in browser, we are already using fallback because of the
    // "browser" field in package.json.
    // But if we were explicitly requested to use fallback, let's do it now.
    const gaxModule = !global.isBrowser && opts.fallback ? gax.fallback : gax;

    const servicePath =
      opts.servicePath ||
      opts.apiEndpoint ||
      this.constructor.servicePath;

    // Ensure that options include the service address and port.
    opts = Object.assign(
      {
        clientConfig: {},
        port: this.constructor.port,
        servicePath,
      },
      opts
    );

    // Create a `gaxGrpc` object, with any grpc-specific options
    // sent to the client.
    opts.scopes = this.constructor.scopes;
    const gaxGrpc = new gaxModule.GrpcClient(opts);

    // Save the auth object to the client, for use by other methods.
    this.auth = gaxGrpc.auth;

    // Determine the client header string.
    const clientHeader = [];

    if (typeof process !== 'undefined' && 'versions' in process) {
      clientHeader.push(`gl-node/${process.versions.node}`);
    }
    clientHeader.push(`gax/${gaxModule.version}`);
    if (opts.fallback) {
      clientHeader.push(`gl-web/${gaxModule.version}`);
    } else {
      clientHeader.push(`grpc/${gaxGrpc.grpcVersion}`);
    }
    clientHeader.push(`gapic/${VERSION}`);
    if (opts.libName && opts.libVersion) {
      clientHeader.push(`${opts.libName}/${opts.libVersion}`);
    }

    // Load the applicable protos.
    // For Node.js, pass the path to JSON proto file.
    // For browsers, pass the JSON content.

    const nodejsProtoPath = path.join(__dirname, '..', '..', 'protos', 'protos.json');
    const protos = gaxGrpc.loadProto(
      opts.fallback ?
        require("../../protos/protos.json") :
        nodejsProtoPath
    );

    // This API contains "path templates"; forward-slash-separated
    // identifiers to uniquely identify resources within the API.
    // Create useful helper objects for these.
    this._pathTemplates = {
      notePathTemplate: new gaxModule.PathTemplate(
        'projects/{project}/notes/{note}'
      ),
      occurrencePathTemplate: new gaxModule.PathTemplate(
        'projects/{project}/occurrences/{occurrence}'
      ),
      projectPathTemplate: new gaxModule.PathTemplate(
        'projects/{project}'
      ),
    };

    // Some of the methods on this service return "paged" results,
    // (e.g. 50 results at a time, with tokens to get subsequent
    // pages). Denote the keys used for pagination and results.
    this._descriptors.page = {
      listOccurrences: new gaxModule.PageDescriptor(
        'pageToken',
        'nextPageToken',
        'occurrences'
      ),
      listNotes: new gaxModule.PageDescriptor(
        'pageToken',
        'nextPageToken',
        'notes'
      ),
      listNoteOccurrences: new gaxModule.PageDescriptor(
        'pageToken',
        'nextPageToken',
        'occurrences'
      ),
    };

    // Put together the default options sent with requests.
    const defaults = gaxGrpc.constructSettings(
      'google.devtools.containeranalysis.v1alpha1.ContainerAnalysis',
      gapicConfig,
      opts.clientConfig,
      {'x-goog-api-client': clientHeader.join(' ')}
    );

    // Set up a dictionary of "inner API calls"; the core implementation
    // of calling the API is handled in `google-gax`, with this code
    // merely providing the destination and request information.
    this._innerApiCalls = {};

    // Put together the "service stub" for
    // google.devtools.containeranalysis.v1alpha1.ContainerAnalysis.
    const containerAnalysisStub = gaxGrpc.createStub(
      opts.fallback ?
        protos.lookupService('google.devtools.containeranalysis.v1alpha1.ContainerAnalysis') :
        protos.google.devtools.containeranalysis.v1alpha1.ContainerAnalysis,
      opts
    );

    // Iterate over each of the methods that the service provides
    // and create an API call method for each.
    const containerAnalysisStubMethods = [
      'getOccurrence',
      'listOccurrences',
      'deleteOccurrence',
      'createOccurrence',
      'updateOccurrence',
      'getOccurrenceNote',
      'getNote',
      'listNotes',
      'deleteNote',
      'createNote',
      'updateNote',
      'listNoteOccurrences',
      'getVulnzOccurrencesSummary',
      'setIamPolicy',
      'getIamPolicy',
      'testIamPermissions',
      'createOperation',
      'updateOperation',
      'getScanConfig',
      'listScanConfigs',
      'updateScanConfig',
    ];
    for (const methodName of containerAnalysisStubMethods) {
      const innerCallPromise = containerAnalysisStub.then(
        stub => (...args) => {
          return stub[methodName].apply(stub, args);
        },
        err => () => {
          throw err;
        }
      );
      this._innerApiCalls[methodName] = gaxModule.createApiCall(
        innerCallPromise,
        defaults[methodName],
        this._descriptors.page[methodName]
      );
    }
  }

  /**
   * The DNS address for this API service.
   */
  static get servicePath() {
    return 'containeranalysis.googleapis.com';
  }

  /**
   * The DNS address for this API service - same as servicePath(),
   * exists for compatibility reasons.
   */
  static get apiEndpoint() {
    return 'containeranalysis.googleapis.com';
  }

  /**
   * The port for this API service.
   */
  static get port() {
    return 443;
  }

  /**
   * The scopes needed to make gRPC calls for every method defined
   * in this service.
   */
  static get scopes() {
    return [
      'https://www.googleapis.com/auth/cloud-platform',
    ];
  }

  /**
   * Return the project ID used by this class.
   * @param {function(Error, string)} callback - the callback to
   *   be called with the current project Id.
   */
  getProjectId(callback) {
    return this.auth.getProjectId(callback);
  }

  // -------------------
  // -- Service calls --
  // -------------------

  /**
   * Returns the requested `Occurrence`.
   *
   * @param {Object} request
   *   The request object that will be sent.
   * @param {string} request.name
   *   The name of the occurrence of the form
   *   "projects/{project_id}/occurrences/{OCCURRENCE_ID}"
   * @param {Object} [options]
   *   Optional parameters. You can override the default settings for this call, e.g, timeout,
   *   retries, paginations, etc. See [gax.CallOptions]{@link https://googleapis.github.io/gax-nodejs/interfaces/CallOptions.html} for the details.
   * @param {function(?Error, ?Object)} [callback]
   *   The function which will be called with the result of the API call.
   *
   *   The second parameter to the callback is an object representing [Occurrence]{@link google.devtools.containeranalysis.v1alpha1.Occurrence}.
   * @returns {Promise} - The promise which resolves to an array.
   *   The first element of the array is an object representing [Occurrence]{@link google.devtools.containeranalysis.v1alpha1.Occurrence}.
   *   The promise has a method named "cancel" which cancels the ongoing API call.
   *
   * @example
   *
   * const containeranalysis = require('containeranalysis.v1alpha1');
   *
   * const client = new containeranalysis.v1alpha1.ContainerAnalysisClient({
   *   // optional auth parameters.
   * });
   *
   * const formattedName = client.occurrencePath('[PROJECT]', '[OCCURRENCE]');
   * client.getOccurrence({name: formattedName})
   *   .then(responses => {
   *     const response = responses[0];
   *     // doThingsWith(response)
   *   })
   *   .catch(err => {
   *     console.error(err);
   *   });
   */
  getOccurrence(request, options, callback) {
    if (options instanceof Function && callback === undefined) {
      callback = options;
      options = {};
    }
    request = request || {};
    options = options || {};
    options.otherArgs = options.otherArgs || {};
    options.otherArgs.headers = options.otherArgs.headers || {};
    options.otherArgs.headers['x-goog-request-params'] =
      gax.routingHeader.fromParams({
        'name': request.name
      });

    return this._innerApiCalls.getOccurrence(request, options, callback);
  }

  /**
   * Lists active `Occurrences` for a given project matching the filters.
   *
   * @param {Object} request
   *   The request object that will be sent.
   * @param {string} request.parent
   *   This contains the project Id for example: projects/{project_id}.
   * @param {string} [request.name]
   *   The name field contains the project Id. For example:
   *   "projects/{project_id}
   *   @Deprecated
   * @param {string} [request.filter]
   *   The filter expression.
   * @param {number} [request.pageSize]
   *   The maximum number of resources contained in the underlying API
   *   response. If page streaming is performed per-resource, this
   *   parameter does not affect the return value. If page streaming is
   *   performed per-page, this determines the maximum number of
   *   resources in a page.
   * @param {number} [request.kind]
   *   The kind of occurrences to filter on.
   *
   *   The number should be among the values of [Kind]{@link google.devtools.containeranalysis.v1alpha1.Kind}
   * @param {Object} [options]
   *   Optional parameters. You can override the default settings for this call, e.g, timeout,
   *   retries, paginations, etc. See [gax.CallOptions]{@link https://googleapis.github.io/gax-nodejs/interfaces/CallOptions.html} for the details.
   * @param {function(?Error, ?Array, ?Object, ?Object)} [callback]
   *   The function which will be called with the result of the API call.
   *
   *   The second parameter to the callback is Array of [Occurrence]{@link google.devtools.containeranalysis.v1alpha1.Occurrence}.
   *
   *   When autoPaginate: false is specified through options, it contains the result
   *   in a single response. If the response indicates the next page exists, the third
   *   parameter is set to be used for the next request object. The fourth parameter keeps
   *   the raw response object of an object representing [ListOccurrencesResponse]{@link google.devtools.containeranalysis.v1alpha1.ListOccurrencesResponse}.
   * @returns {Promise} - The promise which resolves to an array.
   *   The first element of the array is Array of [Occurrence]{@link google.devtools.containeranalysis.v1alpha1.Occurrence}.
   *
   *   When autoPaginate: false is specified through options, the array has three elements.
   *   The first element is Array of [Occurrence]{@link google.devtools.containeranalysis.v1alpha1.Occurrence} in a single response.
   *   The second element is the next request object if the response
   *   indicates the next page exists, or null. The third element is
   *   an object representing [ListOccurrencesResponse]{@link google.devtools.containeranalysis.v1alpha1.ListOccurrencesResponse}.
   *
   *   The promise has a method named "cancel" which cancels the ongoing API call.
   *
   * @example
   *
   * const containeranalysis = require('containeranalysis.v1alpha1');
   *
   * const client = new containeranalysis.v1alpha1.ContainerAnalysisClient({
   *   // optional auth parameters.
   * });
   *
   * // Iterate over all elements.
   * const formattedParent = client.projectPath('[PROJECT]');
   *
   * client.listOccurrences({parent: formattedParent})
   *   .then(responses => {
   *     const resources = responses[0];
   *     for (const resource of resources) {
   *       // doThingsWith(resource)
   *     }
   *   })
   *   .catch(err => {
   *     console.error(err);
   *   });
   *
   * // Or obtain the paged response.
   * const formattedParent = client.projectPath('[PROJECT]');
   *
   *
   * const options = {autoPaginate: false};
   * const callback = responses => {
   *   // The actual resources in a response.
   *   const resources = responses[0];
   *   // The next request if the response shows that there are more responses.
   *   const nextRequest = responses[1];
   *   // The actual response object, if necessary.
   *   // const rawResponse = responses[2];
   *   for (const resource of resources) {
   *     // doThingsWith(resource);
   *   }
   *   if (nextRequest) {
   *     // Fetch the next page.
   *     return client.listOccurrences(nextRequest, options).then(callback);
   *   }
   * }
   * client.listOccurrences({parent: formattedParent}, options)
   *   .then(callback)
   *   .catch(err => {
   *     console.error(err);
   *   });
   */
  listOccurrences(request, options, callback) {
    if (options instanceof Function && callback === undefined) {
      callback = options;
      options = {};
    }
    request = request || {};
    options = options || {};
    options.otherArgs = options.otherArgs || {};
    options.otherArgs.headers = options.otherArgs.headers || {};
    options.otherArgs.headers['x-goog-request-params'] =
      gax.routingHeader.fromParams({
        'parent': request.parent
      });

    return this._innerApiCalls.listOccurrences(request, options, callback);
  }

  /**
   * Equivalent to {@link listOccurrences}, but returns a NodeJS Stream object.
   *
   * This fetches the paged responses for {@link listOccurrences} continuously
   * and invokes the callback registered for 'data' event for each element in the
   * responses.
   *
   * The returned object has 'end' method when no more elements are required.
   *
   * autoPaginate option will be ignored.
   *
   * @see {@link https://nodejs.org/api/stream.html}
   *
   * @param {Object} request
   *   The request object that will be sent.
   * @param {string} request.parent
   *   This contains the project Id for example: projects/{project_id}.
   * @param {string} [request.name]
   *   The name field contains the project Id. For example:
   *   "projects/{project_id}
   *   @Deprecated
   * @param {string} [request.filter]
   *   The filter expression.
   * @param {number} [request.pageSize]
   *   The maximum number of resources contained in the underlying API
   *   response. If page streaming is performed per-resource, this
   *   parameter does not affect the return value. If page streaming is
   *   performed per-page, this determines the maximum number of
   *   resources in a page.
   * @param {number} [request.kind]
   *   The kind of occurrences to filter on.
   *
   *   The number should be among the values of [Kind]{@link google.devtools.containeranalysis.v1alpha1.Kind}
   * @param {Object} [options]
   *   Optional parameters. You can override the default settings for this call, e.g, timeout,
   *   retries, paginations, etc. See [gax.CallOptions]{@link https://googleapis.github.io/gax-nodejs/interfaces/CallOptions.html} for the details.
   * @returns {Stream}
   *   An object stream which emits an object representing [Occurrence]{@link google.devtools.containeranalysis.v1alpha1.Occurrence} on 'data' event.
   *
   * @example
   *
   * const containeranalysis = require('containeranalysis.v1alpha1');
   *
   * const client = new containeranalysis.v1alpha1.ContainerAnalysisClient({
   *   // optional auth parameters.
   * });
   *
   * const formattedParent = client.projectPath('[PROJECT]');
   * client.listOccurrencesStream({parent: formattedParent})
   *   .on('data', element => {
   *     // doThingsWith(element)
   *   }).on('error', err => {
   *     console.log(err);
   *   });
   */
  listOccurrencesStream(request, options) {
    options = options || {};

    return this._descriptors.page.listOccurrences.createStream(
      this._innerApiCalls.listOccurrences,
      request,
      options
    );
  };

  /**
   * Deletes the given `Occurrence` from the system. Use this when
   * an `Occurrence` is no longer applicable for the given resource.
   *
   * @param {Object} request
   *   The request object that will be sent.
   * @param {string} request.name
   *   The name of the occurrence in the form of
   *   "projects/{project_id}/occurrences/{OCCURRENCE_ID}"
   * @param {Object} [options]
   *   Optional parameters. You can override the default settings for this call, e.g, timeout,
   *   retries, paginations, etc. See [gax.CallOptions]{@link https://googleapis.github.io/gax-nodejs/interfaces/CallOptions.html} for the details.
   * @param {function(?Error)} [callback]
   *   The function which will be called with the result of the API call.
   * @returns {Promise} - The promise which resolves when API call finishes.
   *   The promise has a method named "cancel" which cancels the ongoing API call.
   *
   * @example
   *
   * const containeranalysis = require('containeranalysis.v1alpha1');
   *
   * const client = new containeranalysis.v1alpha1.ContainerAnalysisClient({
   *   // optional auth parameters.
   * });
   *
   * const formattedName = client.occurrencePath('[PROJECT]', '[OCCURRENCE]');
   * client.deleteOccurrence({name: formattedName}).catch(err => {
   *   console.error(err);
   * });
   */
  deleteOccurrence(request, options, callback) {
    if (options instanceof Function && callback === undefined) {
      callback = options;
      options = {};
    }
    request = request || {};
    options = options || {};
    options.otherArgs = options.otherArgs || {};
    options.otherArgs.headers = options.otherArgs.headers || {};
    options.otherArgs.headers['x-goog-request-params'] =
      gax.routingHeader.fromParams({
        'name': request.name
      });

    return this._innerApiCalls.deleteOccurrence(request, options, callback);
  }

  /**
   * Creates a new `Occurrence`. Use this method to create `Occurrences`
   * for a resource.
   *
   * @param {Object} request
   *   The request object that will be sent.
   * @param {string} request.parent
   *   This field contains the project Id for example: "projects/{project_id}"
   * @param {Object} request.occurrence
   *   The occurrence to be inserted
   *
   *   This object should have the same structure as [Occurrence]{@link google.devtools.containeranalysis.v1alpha1.Occurrence}
   * @param {string} [request.name]
   *   The name of the project.  Should be of the form "projects/{project_id}".
   *   @Deprecated
   * @param {Object} [options]
   *   Optional parameters. You can override the default settings for this call, e.g, timeout,
   *   retries, paginations, etc. See [gax.CallOptions]{@link https://googleapis.github.io/gax-nodejs/interfaces/CallOptions.html} for the details.
   * @param {function(?Error, ?Object)} [callback]
   *   The function which will be called with the result of the API call.
   *
   *   The second parameter to the callback is an object representing [Occurrence]{@link google.devtools.containeranalysis.v1alpha1.Occurrence}.
   * @returns {Promise} - The promise which resolves to an array.
   *   The first element of the array is an object representing [Occurrence]{@link google.devtools.containeranalysis.v1alpha1.Occurrence}.
   *   The promise has a method named "cancel" which cancels the ongoing API call.
   *
   * @example
   *
   * const containeranalysis = require('containeranalysis.v1alpha1');
   *
   * const client = new containeranalysis.v1alpha1.ContainerAnalysisClient({
   *   // optional auth parameters.
   * });
   *
   * const formattedParent = client.projectPath('[PROJECT]');
   * const occurrence = {};
   * const request = {
   *   parent: formattedParent,
   *   occurrence: occurrence,
   * };
   * client.createOccurrence(request)
   *   .then(responses => {
   *     const response = responses[0];
   *     // doThingsWith(response)
   *   })
   *   .catch(err => {
   *     console.error(err);
   *   });
   */
  createOccurrence(request, options, callback) {
    if (options instanceof Function && callback === undefined) {
      callback = options;
      options = {};
    }
    request = request || {};
    options = options || {};
    options.otherArgs = options.otherArgs || {};
    options.otherArgs.headers = options.otherArgs.headers || {};
    options.otherArgs.headers['x-goog-request-params'] =
      gax.routingHeader.fromParams({
        'parent': request.parent
      });

    return this._innerApiCalls.createOccurrence(request, options, callback);
  }

  /**
   * Updates an existing occurrence.
   *
   * @param {Object} request
   *   The request object that will be sent.
   * @param {string} request.name
   *   The name of the occurrence.
   *   Should be of the form "projects/{project_id}/occurrences/{OCCURRENCE_ID}".
   * @param {Object} request.occurrence
   *   The updated occurrence.
   *
   *   This object should have the same structure as [Occurrence]{@link google.devtools.containeranalysis.v1alpha1.Occurrence}
   * @param {Object} [request.updateMask]
   *   The fields to update.
   *
   *   This object should have the same structure as [FieldMask]{@link google.protobuf.FieldMask}
   * @param {Object} [options]
   *   Optional parameters. You can override the default settings for this call, e.g, timeout,
   *   retries, paginations, etc. See [gax.CallOptions]{@link https://googleapis.github.io/gax-nodejs/interfaces/CallOptions.html} for the details.
   * @param {function(?Error, ?Object)} [callback]
   *   The function which will be called with the result of the API call.
   *
   *   The second parameter to the callback is an object representing [Occurrence]{@link google.devtools.containeranalysis.v1alpha1.Occurrence}.
   * @returns {Promise} - The promise which resolves to an array.
   *   The first element of the array is an object representing [Occurrence]{@link google.devtools.containeranalysis.v1alpha1.Occurrence}.
   *   The promise has a method named "cancel" which cancels the ongoing API call.
   *
   * @example
   *
   * const containeranalysis = require('containeranalysis.v1alpha1');
   *
   * const client = new containeranalysis.v1alpha1.ContainerAnalysisClient({
   *   // optional auth parameters.
   * });
   *
   * const formattedName = client.occurrencePath('[PROJECT]', '[OCCURRENCE]');
   * const occurrence = {};
   * const request = {
   *   name: formattedName,
   *   occurrence: occurrence,
   * };
   * client.updateOccurrence(request)
   *   .then(responses => {
   *     const response = responses[0];
   *     // doThingsWith(response)
   *   })
   *   .catch(err => {
   *     console.error(err);
   *   });
   */
  updateOccurrence(request, options, callback) {
    if (options instanceof Function && callback === undefined) {
      callback = options;
      options = {};
    }
    request = request || {};
    options = options || {};
    options.otherArgs = options.otherArgs || {};
    options.otherArgs.headers = options.otherArgs.headers || {};
    options.otherArgs.headers['x-goog-request-params'] =
      gax.routingHeader.fromParams({
        'name': request.name
      });

    return this._innerApiCalls.updateOccurrence(request, options, callback);
  }

  /**
   * Gets the `Note` attached to the given `Occurrence`.
   *
   * @param {Object} request
   *   The request object that will be sent.
   * @param {string} request.name
   *   The name of the occurrence in the form
   *   "projects/{project_id}/occurrences/{OCCURRENCE_ID}"
   * @param {Object} [options]
   *   Optional parameters. You can override the default settings for this call, e.g, timeout,
   *   retries, paginations, etc. See [gax.CallOptions]{@link https://googleapis.github.io/gax-nodejs/interfaces/CallOptions.html} for the details.
   * @param {function(?Error, ?Object)} [callback]
   *   The function which will be called with the result of the API call.
   *
   *   The second parameter to the callback is an object representing [Note]{@link google.devtools.containeranalysis.v1alpha1.Note}.
   * @returns {Promise} - The promise which resolves to an array.
   *   The first element of the array is an object representing [Note]{@link google.devtools.containeranalysis.v1alpha1.Note}.
   *   The promise has a method named "cancel" which cancels the ongoing API call.
   *
   * @example
   *
   * const containeranalysis = require('containeranalysis.v1alpha1');
   *
   * const client = new containeranalysis.v1alpha1.ContainerAnalysisClient({
   *   // optional auth parameters.
   * });
   *
   * const formattedName = client.occurrencePath('[PROJECT]', '[OCCURRENCE]');
   * client.getOccurrenceNote({name: formattedName})
   *   .then(responses => {
   *     const response = responses[0];
   *     // doThingsWith(response)
   *   })
   *   .catch(err => {
   *     console.error(err);
   *   });
   */
  getOccurrenceNote(request, options, callback) {
    if (options instanceof Function && callback === undefined) {
      callback = options;
      options = {};
    }
    request = request || {};
    options = options || {};
    options.otherArgs = options.otherArgs || {};
    options.otherArgs.headers = options.otherArgs.headers || {};
    options.otherArgs.headers['x-goog-request-params'] =
      gax.routingHeader.fromParams({
        'name': request.name
      });

    return this._innerApiCalls.getOccurrenceNote(request, options, callback);
  }

  /**
   * Returns the requested `Note`.
   *
   * @param {Object} request
   *   The request object that will be sent.
   * @param {string} request.name
   *   The name of the note in the form of
   *   "providers/{provider_id}/notes/{NOTE_ID}"
   * @param {Object} [options]
   *   Optional parameters. You can override the default settings for this call, e.g, timeout,
   *   retries, paginations, etc. See [gax.CallOptions]{@link https://googleapis.github.io/gax-nodejs/interfaces/CallOptions.html} for the details.
   * @param {function(?Error, ?Object)} [callback]
   *   The function which will be called with the result of the API call.
   *
   *   The second parameter to the callback is an object representing [Note]{@link google.devtools.containeranalysis.v1alpha1.Note}.
   * @returns {Promise} - The promise which resolves to an array.
   *   The first element of the array is an object representing [Note]{@link google.devtools.containeranalysis.v1alpha1.Note}.
   *   The promise has a method named "cancel" which cancels the ongoing API call.
   *
   * @example
   *
   * const containeranalysis = require('containeranalysis.v1alpha1');
   *
   * const client = new containeranalysis.v1alpha1.ContainerAnalysisClient({
   *   // optional auth parameters.
   * });
   *
   * const formattedName = client.notePath('[PROJECT]', '[NOTE]');
   * client.getNote({name: formattedName})
   *   .then(responses => {
   *     const response = responses[0];
   *     // doThingsWith(response)
   *   })
   *   .catch(err => {
   *     console.error(err);
   *   });
   */
  getNote(request, options, callback) {
    if (options instanceof Function && callback === undefined) {
      callback = options;
      options = {};
    }
    request = request || {};
    options = options || {};
    options.otherArgs = options.otherArgs || {};
    options.otherArgs.headers = options.otherArgs.headers || {};
    options.otherArgs.headers['x-goog-request-params'] =
      gax.routingHeader.fromParams({
        'name': request.name
      });

    return this._innerApiCalls.getNote(request, options, callback);
  }

  /**
   * Lists all `Notes` for a given project.
   *
   * @param {Object} request
   *   The request object that will be sent.
   * @param {string} request.parent
   *   This field contains the project Id for example: "projects/{PROJECT_ID}".
   * @param {string} [request.name]
   *   The name field will contain the project Id for example:
   *   "providers/{provider_id}
   *   @Deprecated
   * @param {string} [request.filter]
   *   The filter expression.
   * @param {number} [request.pageSize]
   *   The maximum number of resources contained in the underlying API
   *   response. If page streaming is performed per-resource, this
   *   parameter does not affect the return value. If page streaming is
   *   performed per-page, this determines the maximum number of
   *   resources in a page.
   * @param {Object} [options]
   *   Optional parameters. You can override the default settings for this call, e.g, timeout,
   *   retries, paginations, etc. See [gax.CallOptions]{@link https://googleapis.github.io/gax-nodejs/interfaces/CallOptions.html} for the details.
   * @param {function(?Error, ?Array, ?Object, ?Object)} [callback]
   *   The function which will be called with the result of the API call.
   *
   *   The second parameter to the callback is Array of [Note]{@link google.devtools.containeranalysis.v1alpha1.Note}.
   *
   *   When autoPaginate: false is specified through options, it contains the result
   *   in a single response. If the response indicates the next page exists, the third
   *   parameter is set to be used for the next request object. The fourth parameter keeps
   *   the raw response object of an object representing [ListNotesResponse]{@link google.devtools.containeranalysis.v1alpha1.ListNotesResponse}.
   * @returns {Promise} - The promise which resolves to an array.
   *   The first element of the array is Array of [Note]{@link google.devtools.containeranalysis.v1alpha1.Note}.
   *
   *   When autoPaginate: false is specified through options, the array has three elements.
   *   The first element is Array of [Note]{@link google.devtools.containeranalysis.v1alpha1.Note} in a single response.
   *   The second element is the next request object if the response
   *   indicates the next page exists, or null. The third element is
   *   an object representing [ListNotesResponse]{@link google.devtools.containeranalysis.v1alpha1.ListNotesResponse}.
   *
   *   The promise has a method named "cancel" which cancels the ongoing API call.
   *
   * @example
   *
   * const containeranalysis = require('containeranalysis.v1alpha1');
   *
   * const client = new containeranalysis.v1alpha1.ContainerAnalysisClient({
   *   // optional auth parameters.
   * });
   *
   * // Iterate over all elements.
   * const formattedParent = client.projectPath('[PROJECT]');
   *
   * client.listNotes({parent: formattedParent})
   *   .then(responses => {
   *     const resources = responses[0];
   *     for (const resource of resources) {
   *       // doThingsWith(resource)
   *     }
   *   })
   *   .catch(err => {
   *     console.error(err);
   *   });
   *
   * // Or obtain the paged response.
   * const formattedParent = client.projectPath('[PROJECT]');
   *
   *
   * const options = {autoPaginate: false};
   * const callback = responses => {
   *   // The actual resources in a response.
   *   const resources = responses[0];
   *   // The next request if the response shows that there are more responses.
   *   const nextRequest = responses[1];
   *   // The actual response object, if necessary.
   *   // const rawResponse = responses[2];
   *   for (const resource of resources) {
   *     // doThingsWith(resource);
   *   }
   *   if (nextRequest) {
   *     // Fetch the next page.
   *     return client.listNotes(nextRequest, options).then(callback);
   *   }
   * }
   * client.listNotes({parent: formattedParent}, options)
   *   .then(callback)
   *   .catch(err => {
   *     console.error(err);
   *   });
   */
  listNotes(request, options, callback) {
    if (options instanceof Function && callback === undefined) {
      callback = options;
      options = {};
    }
    request = request || {};
    options = options || {};
    options.otherArgs = options.otherArgs || {};
    options.otherArgs.headers = options.otherArgs.headers || {};
    options.otherArgs.headers['x-goog-request-params'] =
      gax.routingHeader.fromParams({
        'parent': request.parent
      });

    return this._innerApiCalls.listNotes(request, options, callback);
  }

  /**
   * Equivalent to {@link listNotes}, but returns a NodeJS Stream object.
   *
   * This fetches the paged responses for {@link listNotes} continuously
   * and invokes the callback registered for 'data' event for each element in the
   * responses.
   *
   * The returned object has 'end' method when no more elements are required.
   *
   * autoPaginate option will be ignored.
   *
   * @see {@link https://nodejs.org/api/stream.html}
   *
   * @param {Object} request
   *   The request object that will be sent.
   * @param {string} request.parent
   *   This field contains the project Id for example: "projects/{PROJECT_ID}".
   * @param {string} [request.name]
   *   The name field will contain the project Id for example:
   *   "providers/{provider_id}
   *   @Deprecated
   * @param {string} [request.filter]
   *   The filter expression.
   * @param {number} [request.pageSize]
   *   The maximum number of resources contained in the underlying API
   *   response. If page streaming is performed per-resource, this
   *   parameter does not affect the return value. If page streaming is
   *   performed per-page, this determines the maximum number of
   *   resources in a page.
   * @param {Object} [options]
   *   Optional parameters. You can override the default settings for this call, e.g, timeout,
   *   retries, paginations, etc. See [gax.CallOptions]{@link https://googleapis.github.io/gax-nodejs/interfaces/CallOptions.html} for the details.
   * @returns {Stream}
   *   An object stream which emits an object representing [Note]{@link google.devtools.containeranalysis.v1alpha1.Note} on 'data' event.
   *
   * @example
   *
   * const containeranalysis = require('containeranalysis.v1alpha1');
   *
   * const client = new containeranalysis.v1alpha1.ContainerAnalysisClient({
   *   // optional auth parameters.
   * });
   *
   * const formattedParent = client.projectPath('[PROJECT]');
   * client.listNotesStream({parent: formattedParent})
   *   .on('data', element => {
   *     // doThingsWith(element)
   *   }).on('error', err => {
   *     console.log(err);
   *   });
   */
  listNotesStream(request, options) {
    options = options || {};

    return this._descriptors.page.listNotes.createStream(
      this._innerApiCalls.listNotes,
      request,
      options
    );
  };

  /**
   * Deletes the given `Note` from the system.
   *
   * @param {Object} request
   *   The request object that will be sent.
   * @param {string} request.name
   *   The name of the note in the form of
   *   "providers/{provider_id}/notes/{NOTE_ID}"
   * @param {Object} [options]
   *   Optional parameters. You can override the default settings for this call, e.g, timeout,
   *   retries, paginations, etc. See [gax.CallOptions]{@link https://googleapis.github.io/gax-nodejs/interfaces/CallOptions.html} for the details.
   * @param {function(?Error)} [callback]
   *   The function which will be called with the result of the API call.
   * @returns {Promise} - The promise which resolves when API call finishes.
   *   The promise has a method named "cancel" which cancels the ongoing API call.
   *
   * @example
   *
   * const containeranalysis = require('containeranalysis.v1alpha1');
   *
   * const client = new containeranalysis.v1alpha1.ContainerAnalysisClient({
   *   // optional auth parameters.
   * });
   *
   * const formattedName = client.notePath('[PROJECT]', '[NOTE]');
   * client.deleteNote({name: formattedName}).catch(err => {
   *   console.error(err);
   * });
   */
  deleteNote(request, options, callback) {
    if (options instanceof Function && callback === undefined) {
      callback = options;
      options = {};
    }
    request = request || {};
    options = options || {};
    options.otherArgs = options.otherArgs || {};
    options.otherArgs.headers = options.otherArgs.headers || {};
    options.otherArgs.headers['x-goog-request-params'] =
      gax.routingHeader.fromParams({
        'name': request.name
      });

    return this._innerApiCalls.deleteNote(request, options, callback);
  }

  /**
   * Creates a new `Note`.
   *
   * @param {Object} request
   *   The request object that will be sent.
   * @param {string} request.parent
   *   This field contains the project Id for example:
   *   "projects/{project_id}
   * @param {string} request.noteId
   *   The ID to use for this note.
   * @param {Object} request.note
   *   The Note to be inserted
   *
   *   This object should have the same structure as [Note]{@link google.devtools.containeranalysis.v1alpha1.Note}
   * @param {string} [request.name]
   *   The name of the project.
   *   Should be of the form "providers/{provider_id}".
   *   @Deprecated
   * @param {Object} [options]
   *   Optional parameters. You can override the default settings for this call, e.g, timeout,
   *   retries, paginations, etc. See [gax.CallOptions]{@link https://googleapis.github.io/gax-nodejs/interfaces/CallOptions.html} for the details.
   * @param {function(?Error, ?Object)} [callback]
   *   The function which will be called with the result of the API call.
   *
   *   The second parameter to the callback is an object representing [Note]{@link google.devtools.containeranalysis.v1alpha1.Note}.
   * @returns {Promise} - The promise which resolves to an array.
   *   The first element of the array is an object representing [Note]{@link google.devtools.containeranalysis.v1alpha1.Note}.
   *   The promise has a method named "cancel" which cancels the ongoing API call.
   *
   * @example
   *
   * const containeranalysis = require('containeranalysis.v1alpha1');
   *
   * const client = new containeranalysis.v1alpha1.ContainerAnalysisClient({
   *   // optional auth parameters.
   * });
   *
   * const formattedParent = client.projectPath('[PROJECT]');
   * const noteId = '';
   * const note = {};
   * const request = {
   *   parent: formattedParent,
   *   noteId: noteId,
   *   note: note,
   * };
   * client.createNote(request)
   *   .then(responses => {
   *     const response = responses[0];
   *     // doThingsWith(response)
   *   })
   *   .catch(err => {
   *     console.error(err);
   *   });
   */
  createNote(request, options, callback) {
    if (options instanceof Function && callback === undefined) {
      callback = options;
      options = {};
    }
    request = request || {};
    options = options || {};
    options.otherArgs = options.otherArgs || {};
    options.otherArgs.headers = options.otherArgs.headers || {};
    options.otherArgs.headers['x-goog-request-params'] =
      gax.routingHeader.fromParams({
        'parent': request.parent
      });

    return this._innerApiCalls.createNote(request, options, callback);
  }

  /**
   * Updates an existing `Note`.
   *
   * @param {Object} request
   *   The request object that will be sent.
   * @param {string} request.name
   *   The name of the note.
   *   Should be of the form "projects/{provider_id}/notes/{note_id}".
   * @param {Object} request.note
   *   The updated note.
   *
   *   This object should have the same structure as [Note]{@link google.devtools.containeranalysis.v1alpha1.Note}
   * @param {Object} [request.updateMask]
   *   The fields to update.
   *
   *   This object should have the same structure as [FieldMask]{@link google.protobuf.FieldMask}
   * @param {Object} [options]
   *   Optional parameters. You can override the default settings for this call, e.g, timeout,
   *   retries, paginations, etc. See [gax.CallOptions]{@link https://googleapis.github.io/gax-nodejs/interfaces/CallOptions.html} for the details.
   * @param {function(?Error, ?Object)} [callback]
   *   The function which will be called with the result of the API call.
   *
   *   The second parameter to the callback is an object representing [Note]{@link google.devtools.containeranalysis.v1alpha1.Note}.
   * @returns {Promise} - The promise which resolves to an array.
   *   The first element of the array is an object representing [Note]{@link google.devtools.containeranalysis.v1alpha1.Note}.
   *   The promise has a method named "cancel" which cancels the ongoing API call.
   *
   * @example
   *
   * const containeranalysis = require('containeranalysis.v1alpha1');
   *
   * const client = new containeranalysis.v1alpha1.ContainerAnalysisClient({
   *   // optional auth parameters.
   * });
   *
   * const formattedName = client.notePath('[PROJECT]', '[NOTE]');
   * const note = {};
   * const request = {
   *   name: formattedName,
   *   note: note,
   * };
   * client.updateNote(request)
   *   .then(responses => {
   *     const response = responses[0];
   *     // doThingsWith(response)
   *   })
   *   .catch(err => {
   *     console.error(err);
   *   });
   */
  updateNote(request, options, callback) {
    if (options instanceof Function && callback === undefined) {
      callback = options;
      options = {};
    }
    request = request || {};
    options = options || {};
    options.otherArgs = options.otherArgs || {};
    options.otherArgs.headers = options.otherArgs.headers || {};
    options.otherArgs.headers['x-goog-request-params'] =
      gax.routingHeader.fromParams({
        'name': request.name
      });

    return this._innerApiCalls.updateNote(request, options, callback);
  }

  /**
   * Lists `Occurrences` referencing the specified `Note`. Use this method to
   * get all occurrences referencing your `Note` across all your customer
   * projects.
   *
   * @param {Object} request
   *   The request object that will be sent.
   * @param {string} request.name
   *   The name field will contain the note name for example:
   *     "provider/{provider_id}/notes/{note_id}"
   * @param {string} [request.filter]
   *   The filter expression.
   * @param {number} [request.pageSize]
   *   The maximum number of resources contained in the underlying API
   *   response. If page streaming is performed per-resource, this
   *   parameter does not affect the return value. If page streaming is
   *   performed per-page, this determines the maximum number of
   *   resources in a page.
   * @param {Object} [options]
   *   Optional parameters. You can override the default settings for this call, e.g, timeout,
   *   retries, paginations, etc. See [gax.CallOptions]{@link https://googleapis.github.io/gax-nodejs/interfaces/CallOptions.html} for the details.
   * @param {function(?Error, ?Array, ?Object, ?Object)} [callback]
   *   The function which will be called with the result of the API call.
   *
   *   The second parameter to the callback is Array of [Occurrence]{@link google.devtools.containeranalysis.v1alpha1.Occurrence}.
   *
   *   When autoPaginate: false is specified through options, it contains the result
   *   in a single response. If the response indicates the next page exists, the third
   *   parameter is set to be used for the next request object. The fourth parameter keeps
   *   the raw response object of an object representing [ListNoteOccurrencesResponse]{@link google.devtools.containeranalysis.v1alpha1.ListNoteOccurrencesResponse}.
   * @returns {Promise} - The promise which resolves to an array.
   *   The first element of the array is Array of [Occurrence]{@link google.devtools.containeranalysis.v1alpha1.Occurrence}.
   *
   *   When autoPaginate: false is specified through options, the array has three elements.
   *   The first element is Array of [Occurrence]{@link google.devtools.containeranalysis.v1alpha1.Occurrence} in a single response.
   *   The second element is the next request object if the response
   *   indicates the next page exists, or null. The third element is
   *   an object representing [ListNoteOccurrencesResponse]{@link google.devtools.containeranalysis.v1alpha1.ListNoteOccurrencesResponse}.
   *
   *   The promise has a method named "cancel" which cancels the ongoing API call.
   *
   * @example
   *
   * const containeranalysis = require('containeranalysis.v1alpha1');
   *
   * const client = new containeranalysis.v1alpha1.ContainerAnalysisClient({
   *   // optional auth parameters.
   * });
   *
   * // Iterate over all elements.
   * const formattedName = client.notePath('[PROJECT]', '[NOTE]');
   *
   * client.listNoteOccurrences({name: formattedName})
   *   .then(responses => {
   *     const resources = responses[0];
   *     for (const resource of resources) {
   *       // doThingsWith(resource)
   *     }
   *   })
   *   .catch(err => {
   *     console.error(err);
   *   });
   *
   * // Or obtain the paged response.
   * const formattedName = client.notePath('[PROJECT]', '[NOTE]');
   *
   *
   * const options = {autoPaginate: false};
   * const callback = responses => {
   *   // The actual resources in a response.
   *   const resources = responses[0];
   *   // The next request if the response shows that there are more responses.
   *   const nextRequest = responses[1];
   *   // The actual response object, if necessary.
   *   // const rawResponse = responses[2];
   *   for (const resource of resources) {
   *     // doThingsWith(resource);
   *   }
   *   if (nextRequest) {
   *     // Fetch the next page.
   *     return client.listNoteOccurrences(nextRequest, options).then(callback);
   *   }
   * }
   * client.listNoteOccurrences({name: formattedName}, options)
   *   .then(callback)
   *   .catch(err => {
   *     console.error(err);
   *   });
   */
  listNoteOccurrences(request, options, callback) {
    if (options instanceof Function && callback === undefined) {
      callback = options;
      options = {};
    }
    request = request || {};
    options = options || {};
    options.otherArgs = options.otherArgs || {};
    options.otherArgs.headers = options.otherArgs.headers || {};
    options.otherArgs.headers['x-goog-request-params'] =
      gax.routingHeader.fromParams({
        'name': request.name
      });

    return this._innerApiCalls.listNoteOccurrences(request, options, callback);
  }

  /**
   * Equivalent to {@link listNoteOccurrences}, but returns a NodeJS Stream object.
   *
   * This fetches the paged responses for {@link listNoteOccurrences} continuously
   * and invokes the callback registered for 'data' event for each element in the
   * responses.
   *
   * The returned object has 'end' method when no more elements are required.
   *
   * autoPaginate option will be ignored.
   *
   * @see {@link https://nodejs.org/api/stream.html}
   *
   * @param {Object} request
   *   The request object that will be sent.
   * @param {string} request.name
   *   The name field will contain the note name for example:
   *     "provider/{provider_id}/notes/{note_id}"
   * @param {string} [request.filter]
   *   The filter expression.
   * @param {number} [request.pageSize]
   *   The maximum number of resources contained in the underlying API
   *   response. If page streaming is performed per-resource, this
   *   parameter does not affect the return value. If page streaming is
   *   performed per-page, this determines the maximum number of
   *   resources in a page.
   * @param {Object} [options]
   *   Optional parameters. You can override the default settings for this call, e.g, timeout,
   *   retries, paginations, etc. See [gax.CallOptions]{@link https://googleapis.github.io/gax-nodejs/interfaces/CallOptions.html} for the details.
   * @returns {Stream}
   *   An object stream which emits an object representing [Occurrence]{@link google.devtools.containeranalysis.v1alpha1.Occurrence} on 'data' event.
   *
   * @example
   *
   * const containeranalysis = require('containeranalysis.v1alpha1');
   *
   * const client = new containeranalysis.v1alpha1.ContainerAnalysisClient({
   *   // optional auth parameters.
   * });
   *
   * const formattedName = client.notePath('[PROJECT]', '[NOTE]');
   * client.listNoteOccurrencesStream({name: formattedName})
   *   .on('data', element => {
   *     // doThingsWith(element)
   *   }).on('error', err => {
   *     console.log(err);
   *   });
   */
  listNoteOccurrencesStream(request, options) {
    options = options || {};

    return this._descriptors.page.listNoteOccurrences.createStream(
      this._innerApiCalls.listNoteOccurrences,
      request,
      options
    );
  };

  /**
   * Gets a summary of the number and severity of occurrences.
   *
   * @param {Object} request
   *   The request object that will be sent.
   * @param {string} request.parent
   *   This contains the project Id for example: projects/{project_id}
   * @param {string} [request.filter]
   *   The filter expression.
   * @param {Object} [options]
   *   Optional parameters. You can override the default settings for this call, e.g, timeout,
   *   retries, paginations, etc. See [gax.CallOptions]{@link https://googleapis.github.io/gax-nodejs/interfaces/CallOptions.html} for the details.
   * @param {function(?Error, ?Object)} [callback]
   *   The function which will be called with the result of the API call.
   *
   *   The second parameter to the callback is an object representing [GetVulnzOccurrencesSummaryResponse]{@link google.devtools.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryResponse}.
   * @returns {Promise} - The promise which resolves to an array.
   *   The first element of the array is an object representing [GetVulnzOccurrencesSummaryResponse]{@link google.devtools.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryResponse}.
   *   The promise has a method named "cancel" which cancels the ongoing API call.
   *
   * @example
   *
   * const containeranalysis = require('containeranalysis.v1alpha1');
   *
   * const client = new containeranalysis.v1alpha1.ContainerAnalysisClient({
   *   // optional auth parameters.
   * });
   *
   * const formattedParent = client.projectPath('[PROJECT]');
   * client.getVulnzOccurrencesSummary({parent: formattedParent})
   *   .then(responses => {
   *     const response = responses[0];
   *     // doThingsWith(response)
   *   })
   *   .catch(err => {
   *     console.error(err);
   *   });
   */
  getVulnzOccurrencesSummary(request, options, callback) {
    if (options instanceof Function && callback === undefined) {
      callback = options;
      options = {};
    }
    request = request || {};
    options = options || {};
    options.otherArgs = options.otherArgs || {};
    options.otherArgs.headers = options.otherArgs.headers || {};
    options.otherArgs.headers['x-goog-request-params'] =
      gax.routingHeader.fromParams({
        'parent': request.parent
      });

    return this._innerApiCalls.getVulnzOccurrencesSummary(request, options, callback);
  }

  /**
   * Sets the access control policy on the specified `Note` or `Occurrence`.
   * Requires `containeranalysis.notes.setIamPolicy` or
   * `containeranalysis.occurrences.setIamPolicy` permission if the resource is
   * a `Note` or an `Occurrence`, respectively.
   * Attempting to call this method without these permissions will result in a `
   * `PERMISSION_DENIED` error.
   * Attempting to call this method on a non-existent resource will result in a
   * `NOT_FOUND` error if the user has `containeranalysis.notes.list` permission
   * on a `Note` or `containeranalysis.occurrences.list` on an `Occurrence`, or
   * a `PERMISSION_DENIED` error otherwise. The resource takes the following
   * formats: `projects/{projectid}/occurrences/{occurrenceid}` for occurrences
   * and projects/{projectid}/notes/{noteid} for notes
   *
   * @param {Object} request
   *   The request object that will be sent.
   * @param {string} request.resource
   *   REQUIRED: The resource for which the policy is being specified.
   *   See the operation documentation for the appropriate value for this field.
   * @param {Object} request.policy
   *   REQUIRED: The complete policy to be applied to the `resource`. The size of
   *   the policy is limited to a few 10s of KB. An empty policy is a
   *   valid policy but certain Cloud Platform services (such as Projects)
   *   might reject them.
   *
   *   This object should have the same structure as [Policy]{@link google.iam.v1.Policy}
   * @param {Object} [options]
   *   Optional parameters. You can override the default settings for this call, e.g, timeout,
   *   retries, paginations, etc. See [gax.CallOptions]{@link https://googleapis.github.io/gax-nodejs/interfaces/CallOptions.html} for the details.
   * @param {function(?Error, ?Object)} [callback]
   *   The function which will be called with the result of the API call.
   *
   *   The second parameter to the callback is an object representing [Policy]{@link google.iam.v1.Policy}.
   * @returns {Promise} - The promise which resolves to an array.
   *   The first element of the array is an object representing [Policy]{@link google.iam.v1.Policy}.
   *   The promise has a method named "cancel" which cancels the ongoing API call.
   *
   * @example
   *
   * const containeranalysis = require('containeranalysis.v1alpha1');
   *
   * const client = new containeranalysis.v1alpha1.ContainerAnalysisClient({
   *   // optional auth parameters.
   * });
   *
   * const formattedResource = client.notePath('[PROJECT]', '[NOTE]');
   * const policy = {};
   * const request = {
   *   resource: formattedResource,
   *   policy: policy,
   * };
   * client.setIamPolicy(request)
   *   .then(responses => {
   *     const response = responses[0];
   *     // doThingsWith(response)
   *   })
   *   .catch(err => {
   *     console.error(err);
   *   });
   */
  setIamPolicy(request, options, callback) {
    if (options instanceof Function && callback === undefined) {
      callback = options;
      options = {};
    }
    request = request || {};
    options = options || {};
    options.otherArgs = options.otherArgs || {};
    options.otherArgs.headers = options.otherArgs.headers || {};
    options.otherArgs.headers['x-goog-request-params'] =
      gax.routingHeader.fromParams({
        'resource': request.resource
      });

    return this._innerApiCalls.setIamPolicy(request, options, callback);
  }

  /**
   * Gets the access control policy for a note or an `Occurrence` resource.
   * Requires `containeranalysis.notes.setIamPolicy` or
   * `containeranalysis.occurrences.setIamPolicy` permission if the resource is
   * a note or occurrence, respectively.
   * Attempting to call this method on a resource without the required
   * permission will result in a `PERMISSION_DENIED` error. Attempting to call
   * this method on a non-existent resource will result in a `NOT_FOUND` error
   * if the user has list permission on the project, or a `PERMISSION_DENIED`
   * error otherwise. The resource takes the following formats:
   * `projects/{PROJECT_ID}/occurrences/{OCCURRENCE_ID}` for occurrences and
   * projects/{PROJECT_ID}/notes/{NOTE_ID} for notes
   *
   * @param {Object} request
   *   The request object that will be sent.
   * @param {string} request.resource
   *   REQUIRED: The resource for which the policy is being requested.
   *   See the operation documentation for the appropriate value for this field.
   * @param {Object} [request.options]
   *   OPTIONAL: A `GetPolicyOptions` object for specifying options to
   *   `GetIamPolicy`. This field is only used by Cloud IAM.
   *
   *   This object should have the same structure as [GetPolicyOptions]{@link google.iam.v1.GetPolicyOptions}
   * @param {Object} [options]
   *   Optional parameters. You can override the default settings for this call, e.g, timeout,
   *   retries, paginations, etc. See [gax.CallOptions]{@link https://googleapis.github.io/gax-nodejs/interfaces/CallOptions.html} for the details.
   * @param {function(?Error, ?Object)} [callback]
   *   The function which will be called with the result of the API call.
   *
   *   The second parameter to the callback is an object representing [Policy]{@link google.iam.v1.Policy}.
   * @returns {Promise} - The promise which resolves to an array.
   *   The first element of the array is an object representing [Policy]{@link google.iam.v1.Policy}.
   *   The promise has a method named "cancel" which cancels the ongoing API call.
   *
   * @example
   *
   * const containeranalysis = require('containeranalysis.v1alpha1');
   *
   * const client = new containeranalysis.v1alpha1.ContainerAnalysisClient({
   *   // optional auth parameters.
   * });
   *
   * const formattedResource = client.notePath('[PROJECT]', '[NOTE]');
   * client.getIamPolicy({resource: formattedResource})
   *   .then(responses => {
   *     const response = responses[0];
   *     // doThingsWith(response)
   *   })
   *   .catch(err => {
   *     console.error(err);
   *   });
   */
  getIamPolicy(request, options, callback) {
    if (options instanceof Function && callback === undefined) {
      callback = options;
      options = {};
    }
    request = request || {};
    options = options || {};
    options.otherArgs = options.otherArgs || {};
    options.otherArgs.headers = options.otherArgs.headers || {};
    options.otherArgs.headers['x-goog-request-params'] =
      gax.routingHeader.fromParams({
        'resource': request.resource
      });

    return this._innerApiCalls.getIamPolicy(request, options, callback);
  }

  /**
   * Returns the permissions that a caller has on the specified note or
   * occurrence resource. Requires list permission on the project (for example,
   * "storage.objects.list" on the containing bucket for testing permission of
   * an object). Attempting to call this method on a non-existent resource will
   * result in a `NOT_FOUND` error if the user has list permission on the
   * project, or a `PERMISSION_DENIED` error otherwise. The resource takes the
   * following formats: `projects/{PROJECT_ID}/occurrences/{OCCURRENCE_ID}` for
   * `Occurrences` and `projects/{PROJECT_ID}/notes/{NOTE_ID}` for `Notes`
   *
   * @param {Object} request
   *   The request object that will be sent.
   * @param {string} request.resource
   *   REQUIRED: The resource for which the policy detail is being requested.
   *   See the operation documentation for the appropriate value for this field.
   * @param {string[]} request.permissions
   *   The set of permissions to check for the `resource`. Permissions with
   *   wildcards (such as '*' or 'storage.*') are not allowed. For more
   *   information see
   *   [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
   * @param {Object} [options]
   *   Optional parameters. You can override the default settings for this call, e.g, timeout,
   *   retries, paginations, etc. See [gax.CallOptions]{@link https://googleapis.github.io/gax-nodejs/interfaces/CallOptions.html} for the details.
   * @param {function(?Error, ?Object)} [callback]
   *   The function which will be called with the result of the API call.
   *
   *   The second parameter to the callback is an object representing [TestIamPermissionsResponse]{@link google.iam.v1.TestIamPermissionsResponse}.
   * @returns {Promise} - The promise which resolves to an array.
   *   The first element of the array is an object representing [TestIamPermissionsResponse]{@link google.iam.v1.TestIamPermissionsResponse}.
   *   The promise has a method named "cancel" which cancels the ongoing API call.
   *
   * @example
   *
   * const containeranalysis = require('containeranalysis.v1alpha1');
   *
   * const client = new containeranalysis.v1alpha1.ContainerAnalysisClient({
   *   // optional auth parameters.
   * });
   *
   * const formattedResource = client.notePath('[PROJECT]', '[NOTE]');
   * const permissions = [];
   * const request = {
   *   resource: formattedResource,
   *   permissions: permissions,
   * };
   * client.testIamPermissions(request)
   *   .then(responses => {
   *     const response = responses[0];
   *     // doThingsWith(response)
   *   })
   *   .catch(err => {
   *     console.error(err);
   *   });
   */
  testIamPermissions(request, options, callback) {
    if (options instanceof Function && callback === undefined) {
      callback = options;
      options = {};
    }
    request = request || {};
    options = options || {};
    options.otherArgs = options.otherArgs || {};
    options.otherArgs.headers = options.otherArgs.headers || {};
    options.otherArgs.headers['x-goog-request-params'] =
      gax.routingHeader.fromParams({
        'resource': request.resource
      });

    return this._innerApiCalls.testIamPermissions(request, options, callback);
  }

  /**
   * Creates a new `Operation`.
   *
   * @param {Object} request
   *   The request object that will be sent.
   * @param {string} [request.parent]
   *   The project Id that this operation should be created under.
   * @param {string} [request.operationId]
   *   The ID to use for this operation.
   * @param {Object} [request.operation]
   *   The operation to create.
   *
   *   This object should have the same structure as [Operation]{@link google.longrunning.Operation}
   * @param {Object} [options]
   *   Optional parameters. You can override the default settings for this call, e.g, timeout,
   *   retries, paginations, etc. See [gax.CallOptions]{@link https://googleapis.github.io/gax-nodejs/interfaces/CallOptions.html} for the details.
   * @param {function(?Error, ?Object)} [callback]
   *   The function which will be called with the result of the API call.
   *
   *   The second parameter to the callback is an object representing [Operation]{@link google.longrunning.Operation}.
   * @returns {Promise} - The promise which resolves to an array.
   *   The first element of the array is an object representing [Operation]{@link google.longrunning.Operation}.
   *   The promise has a method named "cancel" which cancels the ongoing API call.
   *
   * @example
   *
   * const containeranalysis = require('containeranalysis.v1alpha1');
   *
   * const client = new containeranalysis.v1alpha1.ContainerAnalysisClient({
   *   // optional auth parameters.
   * });
   *
   *
   * client.createOperation({})
   *   .then(responses => {
   *     const response = responses[0];
   *     // doThingsWith(response)
   *   })
   *   .catch(err => {
   *     console.error(err);
   *   });
   */
  createOperation(request, options, callback) {
    if (options instanceof Function && callback === undefined) {
      callback = options;
      options = {};
    }
    request = request || {};
    options = options || {};
    options.otherArgs = options.otherArgs || {};
    options.otherArgs.headers = options.otherArgs.headers || {};
    options.otherArgs.headers['x-goog-request-params'] =
      gax.routingHeader.fromParams({
        'parent': request.parent
      });

    return this._innerApiCalls.createOperation(request, options, callback);
  }

  /**
   * Updates an existing operation returns an error if operation
   *  does not exist. The only valid operations are to update mark the done bit
   * change the result.
   *
   * @param {Object} request
   *   The request object that will be sent.
   * @param {string} [request.name]
   *   The name of the Operation.
   *   Should be of the form "projects/{provider_id}/operations/{operation_id}".
   * @param {Object} [request.operation]
   *   The operation to create.
   *
   *   This object should have the same structure as [Operation]{@link google.longrunning.Operation}
   * @param {Object} [request.updateMask]
   *   This object should have the same structure as [FieldMask]{@link google.protobuf.FieldMask}
   * @param {Object} [options]
   *   Optional parameters. You can override the default settings for this call, e.g, timeout,
   *   retries, paginations, etc. See [gax.CallOptions]{@link https://googleapis.github.io/gax-nodejs/interfaces/CallOptions.html} for the details.
   * @param {function(?Error, ?Object)} [callback]
   *   The function which will be called with the result of the API call.
   *
   *   The second parameter to the callback is an object representing [Operation]{@link google.longrunning.Operation}.
   * @returns {Promise} - The promise which resolves to an array.
   *   The first element of the array is an object representing [Operation]{@link google.longrunning.Operation}.
   *   The promise has a method named "cancel" which cancels the ongoing API call.
   *
   * @example
   *
   * const containeranalysis = require('containeranalysis.v1alpha1');
   *
   * const client = new containeranalysis.v1alpha1.ContainerAnalysisClient({
   *   // optional auth parameters.
   * });
   *
   *
   * client.updateOperation({})
   *   .then(responses => {
   *     const response = responses[0];
   *     // doThingsWith(response)
   *   })
   *   .catch(err => {
   *     console.error(err);
   *   });
   */
  updateOperation(request, options, callback) {
    if (options instanceof Function && callback === undefined) {
      callback = options;
      options = {};
    }
    request = request || {};
    options = options || {};
    options.otherArgs = options.otherArgs || {};
    options.otherArgs.headers = options.otherArgs.headers || {};
    options.otherArgs.headers['x-goog-request-params'] =
      gax.routingHeader.fromParams({
        'name': request.name
      });

    return this._innerApiCalls.updateOperation(request, options, callback);
  }

  /**
   * Gets a specific scan configuration for a project.
   *
   * @param {Object} request
   *   The request object that will be sent.
   * @param {string} [request.name]
   *   The name of the ScanConfig in the form
   *   projects/{project_id}/scan_configs/{ScanConfig_id}
   *   instead.
   * @param {Object} [options]
   *   Optional parameters. You can override the default settings for this call, e.g, timeout,
   *   retries, paginations, etc. See [gax.CallOptions]{@link https://googleapis.github.io/gax-nodejs/interfaces/CallOptions.html} for the details.
   * @param {function(?Error, ?Object)} [callback]
   *   The function which will be called with the result of the API call.
   *
   *   The second parameter to the callback is an object representing [ScanConfig]{@link google.devtools.containeranalysis.v1alpha1.ScanConfig}.
   * @returns {Promise} - The promise which resolves to an array.
   *   The first element of the array is an object representing [ScanConfig]{@link google.devtools.containeranalysis.v1alpha1.ScanConfig}.
   *   The promise has a method named "cancel" which cancels the ongoing API call.
   *
   * @example
   *
   * const containeranalysis = require('containeranalysis.v1alpha1');
   *
   * const client = new containeranalysis.v1alpha1.ContainerAnalysisClient({
   *   // optional auth parameters.
   * });
   *
   *
   * client.getScanConfig({})
   *   .then(responses => {
   *     const response = responses[0];
   *     // doThingsWith(response)
   *   })
   *   .catch(err => {
   *     console.error(err);
   *   });
   */
  getScanConfig(request, options, callback) {
    if (options instanceof Function && callback === undefined) {
      callback = options;
      options = {};
    }
    request = request || {};
    options = options || {};
    options.otherArgs = options.otherArgs || {};
    options.otherArgs.headers = options.otherArgs.headers || {};
    options.otherArgs.headers['x-goog-request-params'] =
      gax.routingHeader.fromParams({
        'name': request.name
      });

    return this._innerApiCalls.getScanConfig(request, options, callback);
  }

  /**
   * Lists scan configurations for a project.
   *
   * @param {Object} request
   *   The request object that will be sent.
   * @param {string} [request.parent]
   *   This containers the project Id i.e.: projects/{project_id}
   *   instead.
   * @param {string} [request.filter]
   *   The filter expression.
   * @param {number} [request.pageSize]
   *   The number of items to return.
   * @param {string} [request.pageToken]
   *   The page token to use for the next request.
   * @param {Object} [options]
   *   Optional parameters. You can override the default settings for this call, e.g, timeout,
   *   retries, paginations, etc. See [gax.CallOptions]{@link https://googleapis.github.io/gax-nodejs/interfaces/CallOptions.html} for the details.
   * @param {function(?Error, ?Object)} [callback]
   *   The function which will be called with the result of the API call.
   *
   *   The second parameter to the callback is an object representing [ListScanConfigsResponse]{@link google.devtools.containeranalysis.v1alpha1.ListScanConfigsResponse}.
   * @returns {Promise} - The promise which resolves to an array.
   *   The first element of the array is an object representing [ListScanConfigsResponse]{@link google.devtools.containeranalysis.v1alpha1.ListScanConfigsResponse}.
   *   The promise has a method named "cancel" which cancels the ongoing API call.
   *
   * @example
   *
   * const containeranalysis = require('containeranalysis.v1alpha1');
   *
   * const client = new containeranalysis.v1alpha1.ContainerAnalysisClient({
   *   // optional auth parameters.
   * });
   *
   *
   * client.listScanConfigs({})
   *   .then(responses => {
   *     const response = responses[0];
   *     // doThingsWith(response)
   *   })
   *   .catch(err => {
   *     console.error(err);
   *   });
   */
  listScanConfigs(request, options, callback) {
    if (options instanceof Function && callback === undefined) {
      callback = options;
      options = {};
    }
    request = request || {};
    options = options || {};
    options.otherArgs = options.otherArgs || {};
    options.otherArgs.headers = options.otherArgs.headers || {};
    options.otherArgs.headers['x-goog-request-params'] =
      gax.routingHeader.fromParams({
        'parent': request.parent
      });

    return this._innerApiCalls.listScanConfigs(request, options, callback);
  }

  /**
   * Updates the scan configuration to a new value.
   *
   * @param {Object} request
   *   The request object that will be sent.
   * @param {string} [request.name]
   *   The scan config to update of the form
   *   projects/{project_id}/scan_configs/{ScanConfig_id}
   *   instead.
   * @param {Object} [request.scanConfig]
   *   The new scan configuration
   *
   *   This object should have the same structure as [ScanConfig]{@link google.devtools.containeranalysis.v1alpha1.ScanConfig}
   * @param {Object} [request.updateMask]
   *   This object should have the same structure as [FieldMask]{@link google.protobuf.FieldMask}
   * @param {Object} [options]
   *   Optional parameters. You can override the default settings for this call, e.g, timeout,
   *   retries, paginations, etc. See [gax.CallOptions]{@link https://googleapis.github.io/gax-nodejs/interfaces/CallOptions.html} for the details.
   * @param {function(?Error, ?Object)} [callback]
   *   The function which will be called with the result of the API call.
   *
   *   The second parameter to the callback is an object representing [ScanConfig]{@link google.devtools.containeranalysis.v1alpha1.ScanConfig}.
   * @returns {Promise} - The promise which resolves to an array.
   *   The first element of the array is an object representing [ScanConfig]{@link google.devtools.containeranalysis.v1alpha1.ScanConfig}.
   *   The promise has a method named "cancel" which cancels the ongoing API call.
   *
   * @example
   *
   * const containeranalysis = require('containeranalysis.v1alpha1');
   *
   * const client = new containeranalysis.v1alpha1.ContainerAnalysisClient({
   *   // optional auth parameters.
   * });
   *
   *
   * client.updateScanConfig({})
   *   .then(responses => {
   *     const response = responses[0];
   *     // doThingsWith(response)
   *   })
   *   .catch(err => {
   *     console.error(err);
   *   });
   */
  updateScanConfig(request, options, callback) {
    if (options instanceof Function && callback === undefined) {
      callback = options;
      options = {};
    }
    request = request || {};
    options = options || {};
    options.otherArgs = options.otherArgs || {};
    options.otherArgs.headers = options.otherArgs.headers || {};
    options.otherArgs.headers['x-goog-request-params'] =
      gax.routingHeader.fromParams({
        'name': request.name
      });

    return this._innerApiCalls.updateScanConfig(request, options, callback);
  }

  // --------------------
  // -- Path templates --
  // --------------------

  /**
   * Return a fully-qualified note resource name string.
   *
   * @param {String} project
   * @param {String} note
   * @returns {String}
   */
  notePath(project, note) {
    return this._pathTemplates.notePathTemplate.render({
      project: project,
      note: note,
    });
  }

  /**
   * Return a fully-qualified occurrence resource name string.
   *
   * @param {String} project
   * @param {String} occurrence
   * @returns {String}
   */
  occurrencePath(project, occurrence) {
    return this._pathTemplates.occurrencePathTemplate.render({
      project: project,
      occurrence: occurrence,
    });
  }

  /**
   * Return a fully-qualified project resource name string.
   *
   * @param {String} project
   * @returns {String}
   */
  projectPath(project) {
    return this._pathTemplates.projectPathTemplate.render({
      project: project,
    });
  }

  /**
   * Parse the noteName from a note resource.
   *
   * @param {String} noteName
   *   A fully-qualified path representing a note resources.
   * @returns {String} - A string representing the project.
   */
  matchProjectFromNoteName(noteName) {
    return this._pathTemplates.notePathTemplate
      .match(noteName)
      .project;
  }

  /**
   * Parse the noteName from a note resource.
   *
   * @param {String} noteName
   *   A fully-qualified path representing a note resources.
   * @returns {String} - A string representing the note.
   */
  matchNoteFromNoteName(noteName) {
    return this._pathTemplates.notePathTemplate
      .match(noteName)
      .note;
  }

  /**
   * Parse the occurrenceName from a occurrence resource.
   *
   * @param {String} occurrenceName
   *   A fully-qualified path representing a occurrence resources.
   * @returns {String} - A string representing the project.
   */
  matchProjectFromOccurrenceName(occurrenceName) {
    return this._pathTemplates.occurrencePathTemplate
      .match(occurrenceName)
      .project;
  }

  /**
   * Parse the occurrenceName from a occurrence resource.
   *
   * @param {String} occurrenceName
   *   A fully-qualified path representing a occurrence resources.
   * @returns {String} - A string representing the occurrence.
   */
  matchOccurrenceFromOccurrenceName(occurrenceName) {
    return this._pathTemplates.occurrencePathTemplate
      .match(occurrenceName)
      .occurrence;
  }

  /**
   * Parse the projectName from a project resource.
   *
   * @param {String} projectName
   *   A fully-qualified path representing a project resources.
   * @returns {String} - A string representing the project.
   */
  matchProjectFromProjectName(projectName) {
    return this._pathTemplates.projectPathTemplate
      .match(projectName)
      .project;
  }
}


module.exports = ContainerAnalysisClient;
