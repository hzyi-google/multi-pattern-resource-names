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

'use strict';

const gapicConfig = require('./job_service_client_config.json');
const gax = require('google-gax');
const path = require('path');

const VERSION = require('../../package.json').version;

/**
 * A service handles job management, including job CRUD, enumeration and search.
 *
 * @class
 * @memberof v4beta1
 */
class JobServiceClient {
  /**
   * Construct an instance of JobServiceClient.
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
      companyPathTemplate: new gaxModule.PathTemplate(
        'projects/{project}/tenants/{tenant}/companies/{company}'
      ),
      companyWithoutTenantPathTemplate: new gaxModule.PathTemplate(
        'projects/{project}/companies/{company}'
      ),
      jobPathTemplate: new gaxModule.PathTemplate(
        'projects/{project}/tenants/{tenant}/jobs/{jobs}'
      ),
      jobWithoutTenantPathTemplate: new gaxModule.PathTemplate(
        'projects/{project}/jobs/{jobs}'
      ),
      projectPathTemplate: new gaxModule.PathTemplate(
        'projects/{project}'
      ),
      tenantPathTemplate: new gaxModule.PathTemplate(
        'projects/{project}/tenants/{tenant}'
      ),
    };

    // Some of the methods on this service return "paged" results,
    // (e.g. 50 results at a time, with tokens to get subsequent
    // pages). Denote the keys used for pagination and results.
    this._descriptors.page = {
      listJobs: new gaxModule.PageDescriptor(
        'pageToken',
        'nextPageToken',
        'jobs'
      ),
      searchJobs: new gaxModule.PageDescriptor(
        'pageToken',
        'nextPageToken',
        'matchingJobs'
      ),
      searchJobsForAlert: new gaxModule.PageDescriptor(
        'pageToken',
        'nextPageToken',
        'matchingJobs'
      ),
    };

    const protoFilesRoot = opts.fallback ?
      gaxModule.protobuf.Root.fromJSON(require("../../protos/protos.json")) :
      gaxModule.protobuf.loadSync(nodejsProtoPath);

    // This API contains "long-running operations", which return a
    // an Operation object that allows for tracking of the operation,
    // rather than holding a request open.
    this.operationsClient = new gaxModule.lro({
      auth: gaxGrpc.auth,
      grpc: gaxGrpc.grpc,
    }).operationsClient(opts);

    const batchCreateJobsResponse = protoFilesRoot.lookup(
      'google.cloud.talent.v4beta1.JobOperationResult'
    );
    const batchCreateJobsMetadata = protoFilesRoot.lookup(
      'google.cloud.talent.v4beta1.BatchOperationMetadata'
    );
    const batchUpdateJobsResponse = protoFilesRoot.lookup(
      'google.cloud.talent.v4beta1.JobOperationResult'
    );
    const batchUpdateJobsMetadata = protoFilesRoot.lookup(
      'google.cloud.talent.v4beta1.BatchOperationMetadata'
    );

    this._descriptors.longrunning = {
      batchCreateJobs: new gaxModule.LongrunningDescriptor(
        this.operationsClient,
        batchCreateJobsResponse.decode.bind(batchCreateJobsResponse),
        batchCreateJobsMetadata.decode.bind(batchCreateJobsMetadata)
      ),
      batchUpdateJobs: new gaxModule.LongrunningDescriptor(
        this.operationsClient,
        batchUpdateJobsResponse.decode.bind(batchUpdateJobsResponse),
        batchUpdateJobsMetadata.decode.bind(batchUpdateJobsMetadata)
      ),
    };

    // Put together the default options sent with requests.
    const defaults = gaxGrpc.constructSettings(
      'google.cloud.talent.v4beta1.JobService',
      gapicConfig,
      opts.clientConfig,
      {'x-goog-api-client': clientHeader.join(' ')}
    );

    // Set up a dictionary of "inner API calls"; the core implementation
    // of calling the API is handled in `google-gax`, with this code
    // merely providing the destination and request information.
    this._innerApiCalls = {};

    // Put together the "service stub" for
    // google.cloud.talent.v4beta1.JobService.
    const jobServiceStub = gaxGrpc.createStub(
      opts.fallback ?
        protos.lookupService('google.cloud.talent.v4beta1.JobService') :
        protos.google.cloud.talent.v4beta1.JobService,
      opts
    );

    // Iterate over each of the methods that the service provides
    // and create an API call method for each.
    const jobServiceStubMethods = [
      'deleteJob',
      'createJob',
      'batchCreateJobs',
      'getJob',
      'updateJob',
      'batchUpdateJobs',
      'batchDeleteJobs',
      'listJobs',
      'searchJobs',
      'searchJobsForAlert',
    ];
    for (const methodName of jobServiceStubMethods) {
      const innerCallPromise = jobServiceStub.then(
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
        this._descriptors.page[methodName] || this._descriptors.longrunning[methodName]
      );
    }
  }

  /**
   * The DNS address for this API service.
   */
  static get servicePath() {
    return 'jobs.googleapis.com';
  }

  /**
   * The DNS address for this API service - same as servicePath(),
   * exists for compatibility reasons.
   */
  static get apiEndpoint() {
    return 'jobs.googleapis.com';
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
      'https://www.googleapis.com/auth/jobs',
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
   * Deletes the specified job.
   *
   * Typically, the job becomes unsearchable within 10 seconds, but it may take
   * up to 5 minutes.
   *
   * @param {Object} request
   *   The request object that will be sent.
   * @param {string} request.name
   *   Required. The resource name of the job to be deleted.
   *
   *   The format is
   *   "projects/{project_id}/tenants/{tenant_id}/jobs/{job_id}". For
   *   example, "projects/foo/tenants/bar/jobs/baz".
   *
   *   If tenant id is unspecified, the default tenant is used. For
   *   example, "projects/foo/jobs/bar".
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
   * const talent = require('@google-cloud/talent');
   *
   * const client = new talent.v4beta1.JobServiceClient({
   *   // optional auth parameters.
   * });
   *
   * const name = '';
   * client.deleteJob({name: name}).catch(err => {
   *   console.error(err);
   * });
   */
  deleteJob(request, options, callback) {
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

    return this._innerApiCalls.deleteJob(request, options, callback);
  }

  /**
   * Creates a new job.
   *
   * Typically, the job becomes searchable within 10 seconds, but it may take
   * up to 5 minutes.
   *
   * @param {Object} request
   *   The request object that will be sent.
   * @param {string} request.parent
   *   Required. The resource name of the tenant under which the job is created.
   *
   *   The format is "projects/{project_id}/tenants/{tenant_id}". For example,
   *   "projects/foo/tenant/bar". If tenant id is unspecified a default tenant
   *   is created. For example, "projects/foo".
   * @param {Object} request.job
   *   Required. The Job to be created.
   *
   *   This object should have the same structure as [Job]{@link google.cloud.talent.v4beta1.Job}
   * @param {Object} [options]
   *   Optional parameters. You can override the default settings for this call, e.g, timeout,
   *   retries, paginations, etc. See [gax.CallOptions]{@link https://googleapis.github.io/gax-nodejs/interfaces/CallOptions.html} for the details.
   * @param {function(?Error, ?Object)} [callback]
   *   The function which will be called with the result of the API call.
   *
   *   The second parameter to the callback is an object representing [Job]{@link google.cloud.talent.v4beta1.Job}.
   * @returns {Promise} - The promise which resolves to an array.
   *   The first element of the array is an object representing [Job]{@link google.cloud.talent.v4beta1.Job}.
   *   The promise has a method named "cancel" which cancels the ongoing API call.
   *
   * @example
   *
   * const talent = require('@google-cloud/talent');
   *
   * const client = new talent.v4beta1.JobServiceClient({
   *   // optional auth parameters.
   * });
   *
   * const formattedParent = client.projectPath('[PROJECT]');
   * const job = {};
   * const request = {
   *   parent: formattedParent,
   *   job: job,
   * };
   * client.createJob(request)
   *   .then(responses => {
   *     const response = responses[0];
   *     // doThingsWith(response)
   *   })
   *   .catch(err => {
   *     console.error(err);
   *   });
   */
  createJob(request, options, callback) {
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

    return this._innerApiCalls.createJob(request, options, callback);
  }

  /**
   * Begins executing a batch create jobs operation.
   *
   * @param {Object} request
   *   The request object that will be sent.
   * @param {string} request.parent
   *   Required. The resource name of the tenant under which the job is created.
   *
   *   The format is "projects/{project_id}/tenants/{tenant_id}". For example,
   *   "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
   *   is created. For example, "projects/foo".
   * @param {Object[]} request.jobs
   *   Required. The jobs to be created.
   *
   *   This object should have the same structure as [Job]{@link google.cloud.talent.v4beta1.Job}
   * @param {Object} [options]
   *   Optional parameters. You can override the default settings for this call, e.g, timeout,
   *   retries, paginations, etc. See [gax.CallOptions]{@link https://googleapis.github.io/gax-nodejs/interfaces/CallOptions.html} for the details.
   * @param {function(?Error, ?Object)} [callback]
   *   The function which will be called with the result of the API call.
   *
   *   The second parameter to the callback is a [gax.Operation]{@link https://googleapis.github.io/gax-nodejs/classes/Operation.html} object.
   * @returns {Promise} - The promise which resolves to an array.
   *   The first element of the array is a [gax.Operation]{@link https://googleapis.github.io/gax-nodejs/classes/Operation.html} object.
   *   The promise has a method named "cancel" which cancels the ongoing API call.
   *
   * @example
   *
   * const talent = require('@google-cloud/talent');
   *
   * const client = new talent.v4beta1.JobServiceClient({
   *   // optional auth parameters.
   * });
   *
   * const formattedParent = client.projectPath('[PROJECT]');
   * const jobs = [];
   * const request = {
   *   parent: formattedParent,
   *   jobs: jobs,
   * };
   *
   * // Handle the operation using the promise pattern.
   * client.batchCreateJobs(request)
   *   .then(responses => {
   *     const [operation, initialApiResponse] = responses;
   *
   *     // Operation#promise starts polling for the completion of the LRO.
   *     return operation.promise();
   *   })
   *   .then(responses => {
   *     const result = responses[0];
   *     const metadata = responses[1];
   *     const finalApiResponse = responses[2];
   *   })
   *   .catch(err => {
   *     console.error(err);
   *   });
   *
   * const formattedParent = client.projectPath('[PROJECT]');
   * const jobs = [];
   * const request = {
   *   parent: formattedParent,
   *   jobs: jobs,
   * };
   *
   * // Handle the operation using the event emitter pattern.
   * client.batchCreateJobs(request)
   *   .then(responses => {
   *     const [operation, initialApiResponse] = responses;
   *
   *     // Adding a listener for the "complete" event starts polling for the
   *     // completion of the operation.
   *     operation.on('complete', (result, metadata, finalApiResponse) => {
   *       // doSomethingWith(result);
   *     });
   *
   *     // Adding a listener for the "progress" event causes the callback to be
   *     // called on any change in metadata when the operation is polled.
   *     operation.on('progress', (metadata, apiResponse) => {
   *       // doSomethingWith(metadata)
   *     });
   *
   *     // Adding a listener for the "error" event handles any errors found during polling.
   *     operation.on('error', err => {
   *       // throw(err);
   *     });
   *   })
   *   .catch(err => {
   *     console.error(err);
   *   });
   *
   * const formattedParent = client.projectPath('[PROJECT]');
   * const jobs = [];
   * const request = {
   *   parent: formattedParent,
   *   jobs: jobs,
   * };
   *
   * // Handle the operation using the await pattern.
   * const [operation] = await client.batchCreateJobs(request);
   *
   * const [response] = await operation.promise();
   */
  batchCreateJobs(request, options, callback) {
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

    return this._innerApiCalls.batchCreateJobs(request, options, callback);
  }

  /**
   * Retrieves the specified job, whose status is OPEN or recently EXPIRED
   * within the last 90 days.
   *
   * @param {Object} request
   *   The request object that will be sent.
   * @param {string} request.name
   *   Required. The resource name of the job to retrieve.
   *
   *   The format is
   *   "projects/{project_id}/tenants/{tenant_id}/jobs/{job_id}". For
   *   example, "projects/foo/tenants/bar/jobs/baz".
   *
   *   If tenant id is unspecified, the default tenant is used. For
   *   example, "projects/foo/jobs/bar".
   * @param {Object} [options]
   *   Optional parameters. You can override the default settings for this call, e.g, timeout,
   *   retries, paginations, etc. See [gax.CallOptions]{@link https://googleapis.github.io/gax-nodejs/interfaces/CallOptions.html} for the details.
   * @param {function(?Error, ?Object)} [callback]
   *   The function which will be called with the result of the API call.
   *
   *   The second parameter to the callback is an object representing [Job]{@link google.cloud.talent.v4beta1.Job}.
   * @returns {Promise} - The promise which resolves to an array.
   *   The first element of the array is an object representing [Job]{@link google.cloud.talent.v4beta1.Job}.
   *   The promise has a method named "cancel" which cancels the ongoing API call.
   *
   * @example
   *
   * const talent = require('@google-cloud/talent');
   *
   * const client = new talent.v4beta1.JobServiceClient({
   *   // optional auth parameters.
   * });
   *
   * const name = '';
   * client.getJob({name: name})
   *   .then(responses => {
   *     const response = responses[0];
   *     // doThingsWith(response)
   *   })
   *   .catch(err => {
   *     console.error(err);
   *   });
   */
  getJob(request, options, callback) {
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

    return this._innerApiCalls.getJob(request, options, callback);
  }

  /**
   * Updates specified job.
   *
   * Typically, updated contents become visible in search results within 10
   * seconds, but it may take up to 5 minutes.
   *
   * @param {Object} request
   *   The request object that will be sent.
   * @param {Object} request.job
   *   Required. The Job to be updated.
   *
   *   This object should have the same structure as [Job]{@link google.cloud.talent.v4beta1.Job}
   * @param {Object} [request.updateMask]
   *   Strongly recommended for the best service experience.
   *
   *   If update_mask is provided, only the specified fields in
   *   job are updated. Otherwise all the fields are updated.
   *
   *   A field mask to restrict the fields that are updated. Only
   *   top level fields of Job are supported.
   *
   *   This object should have the same structure as [FieldMask]{@link google.protobuf.FieldMask}
   * @param {Object} [options]
   *   Optional parameters. You can override the default settings for this call, e.g, timeout,
   *   retries, paginations, etc. See [gax.CallOptions]{@link https://googleapis.github.io/gax-nodejs/interfaces/CallOptions.html} for the details.
   * @param {function(?Error, ?Object)} [callback]
   *   The function which will be called with the result of the API call.
   *
   *   The second parameter to the callback is an object representing [Job]{@link google.cloud.talent.v4beta1.Job}.
   * @returns {Promise} - The promise which resolves to an array.
   *   The first element of the array is an object representing [Job]{@link google.cloud.talent.v4beta1.Job}.
   *   The promise has a method named "cancel" which cancels the ongoing API call.
   *
   * @example
   *
   * const talent = require('@google-cloud/talent');
   *
   * const client = new talent.v4beta1.JobServiceClient({
   *   // optional auth parameters.
   * });
   *
   * const job = {};
   * client.updateJob({job: job})
   *   .then(responses => {
   *     const response = responses[0];
   *     // doThingsWith(response)
   *   })
   *   .catch(err => {
   *     console.error(err);
   *   });
   */
  updateJob(request, options, callback) {
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
        'job.name': request.job.name
      });

    return this._innerApiCalls.updateJob(request, options, callback);
  }

  /**
   * Begins executing a batch update jobs operation.
   *
   * @param {Object} request
   *   The request object that will be sent.
   * @param {string} request.parent
   *   Required. The resource name of the tenant under which the job is created.
   *
   *   The format is "projects/{project_id}/tenants/{tenant_id}". For example,
   *   "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
   *   is created. For example, "projects/foo".
   * @param {Object[]} request.jobs
   *   Required. The jobs to be updated.
   *
   *   This object should have the same structure as [Job]{@link google.cloud.talent.v4beta1.Job}
   * @param {Object} [request.updateMask]
   *   Strongly recommended for the best service experience. Be aware that it will
   *   also increase latency when checking the status of a batch operation.
   *
   *   If update_mask is provided, only the specified fields in
   *   Job are updated. Otherwise all the fields are updated.
   *
   *   A field mask to restrict the fields that are updated. Only
   *   top level fields of Job are supported.
   *
   *   If update_mask is provided, The Job inside
   *   JobResult
   *   will only contains fields that is updated, plus the Id of the Job.
   *   Otherwise,  Job will include all fields, which can yield a very
   *   large response.
   *
   *   This object should have the same structure as [FieldMask]{@link google.protobuf.FieldMask}
   * @param {Object} [options]
   *   Optional parameters. You can override the default settings for this call, e.g, timeout,
   *   retries, paginations, etc. See [gax.CallOptions]{@link https://googleapis.github.io/gax-nodejs/interfaces/CallOptions.html} for the details.
   * @param {function(?Error, ?Object)} [callback]
   *   The function which will be called with the result of the API call.
   *
   *   The second parameter to the callback is a [gax.Operation]{@link https://googleapis.github.io/gax-nodejs/classes/Operation.html} object.
   * @returns {Promise} - The promise which resolves to an array.
   *   The first element of the array is a [gax.Operation]{@link https://googleapis.github.io/gax-nodejs/classes/Operation.html} object.
   *   The promise has a method named "cancel" which cancels the ongoing API call.
   *
   * @example
   *
   * const talent = require('@google-cloud/talent');
   *
   * const client = new talent.v4beta1.JobServiceClient({
   *   // optional auth parameters.
   * });
   *
   * const formattedParent = client.projectPath('[PROJECT]');
   * const jobs = [];
   * const request = {
   *   parent: formattedParent,
   *   jobs: jobs,
   * };
   *
   * // Handle the operation using the promise pattern.
   * client.batchUpdateJobs(request)
   *   .then(responses => {
   *     const [operation, initialApiResponse] = responses;
   *
   *     // Operation#promise starts polling for the completion of the LRO.
   *     return operation.promise();
   *   })
   *   .then(responses => {
   *     const result = responses[0];
   *     const metadata = responses[1];
   *     const finalApiResponse = responses[2];
   *   })
   *   .catch(err => {
   *     console.error(err);
   *   });
   *
   * const formattedParent = client.projectPath('[PROJECT]');
   * const jobs = [];
   * const request = {
   *   parent: formattedParent,
   *   jobs: jobs,
   * };
   *
   * // Handle the operation using the event emitter pattern.
   * client.batchUpdateJobs(request)
   *   .then(responses => {
   *     const [operation, initialApiResponse] = responses;
   *
   *     // Adding a listener for the "complete" event starts polling for the
   *     // completion of the operation.
   *     operation.on('complete', (result, metadata, finalApiResponse) => {
   *       // doSomethingWith(result);
   *     });
   *
   *     // Adding a listener for the "progress" event causes the callback to be
   *     // called on any change in metadata when the operation is polled.
   *     operation.on('progress', (metadata, apiResponse) => {
   *       // doSomethingWith(metadata)
   *     });
   *
   *     // Adding a listener for the "error" event handles any errors found during polling.
   *     operation.on('error', err => {
   *       // throw(err);
   *     });
   *   })
   *   .catch(err => {
   *     console.error(err);
   *   });
   *
   * const formattedParent = client.projectPath('[PROJECT]');
   * const jobs = [];
   * const request = {
   *   parent: formattedParent,
   *   jobs: jobs,
   * };
   *
   * // Handle the operation using the await pattern.
   * const [operation] = await client.batchUpdateJobs(request);
   *
   * const [response] = await operation.promise();
   */
  batchUpdateJobs(request, options, callback) {
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

    return this._innerApiCalls.batchUpdateJobs(request, options, callback);
  }

  /**
   * Deletes a list of Jobs by filter.
   *
   * @param {Object} request
   *   The request object that will be sent.
   * @param {string} request.parent
   *   Required. The resource name of the tenant under which the job is created.
   *
   *   The format is "projects/{project_id}/tenants/{tenant_id}". For example,
   *   "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
   *   is created. For example, "projects/foo".
   * @param {string} request.filter
   *   Required. The filter string specifies the jobs to be deleted.
   *
   *   Supported operator: =, AND
   *
   *   The fields eligible for filtering are:
   *
   *   * `companyName` (Required)
   *   * `requisitionId` (Required)
   *
   *   Sample Query: companyName = "projects/foo/companies/bar" AND
   *   requisitionId = "req-1"
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
   * const talent = require('@google-cloud/talent');
   *
   * const client = new talent.v4beta1.JobServiceClient({
   *   // optional auth parameters.
   * });
   *
   * const formattedParent = client.projectPath('[PROJECT]');
   * const filter = '';
   * const request = {
   *   parent: formattedParent,
   *   filter: filter,
   * };
   * client.batchDeleteJobs(request).catch(err => {
   *   console.error(err);
   * });
   */
  batchDeleteJobs(request, options, callback) {
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

    return this._innerApiCalls.batchDeleteJobs(request, options, callback);
  }

  /**
   * Lists jobs by filter.
   *
   * @param {Object} request
   *   The request object that will be sent.
   * @param {string} request.parent
   *   Required. The resource name of the tenant under which the job is created.
   *
   *   The format is "projects/{project_id}/tenants/{tenant_id}". For example,
   *   "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
   *   is created. For example, "projects/foo".
   * @param {string} request.filter
   *   Required. The filter string specifies the jobs to be enumerated.
   *
   *   Supported operator: =, AND
   *
   *   The fields eligible for filtering are:
   *
   *   * `companyName` (Required)
   *   * `requisitionId`
   *   * `status` Available values: OPEN, EXPIRED, ALL. Defaults to
   *   OPEN if no value is specified.
   *
   *   Sample Query:
   *
   *   * companyName = "projects/foo/tenants/bar/companies/baz"
   *   * companyName = "projects/foo/tenants/bar/companies/baz" AND
   *   requisitionId = "req-1"
   *   * companyName = "projects/foo/tenants/bar/companies/baz" AND
   *   status = "EXPIRED"
   * @param {number} [request.pageSize]
   *   The maximum number of resources contained in the underlying API
   *   response. If page streaming is performed per-resource, this
   *   parameter does not affect the return value. If page streaming is
   *   performed per-page, this determines the maximum number of
   *   resources in a page.
   * @param {number} [request.jobView]
   *   The desired job attributes returned for jobs in the
   *   search response. Defaults to JobView.JOB_VIEW_FULL if no value is
   *   specified.
   *
   *   The number should be among the values of [JobView]{@link google.cloud.talent.v4beta1.JobView}
   * @param {Object} [options]
   *   Optional parameters. You can override the default settings for this call, e.g, timeout,
   *   retries, paginations, etc. See [gax.CallOptions]{@link https://googleapis.github.io/gax-nodejs/interfaces/CallOptions.html} for the details.
   * @param {function(?Error, ?Array, ?Object, ?Object)} [callback]
   *   The function which will be called with the result of the API call.
   *
   *   The second parameter to the callback is Array of [Job]{@link google.cloud.talent.v4beta1.Job}.
   *
   *   When autoPaginate: false is specified through options, it contains the result
   *   in a single response. If the response indicates the next page exists, the third
   *   parameter is set to be used for the next request object. The fourth parameter keeps
   *   the raw response object of an object representing [ListJobsResponse]{@link google.cloud.talent.v4beta1.ListJobsResponse}.
   * @returns {Promise} - The promise which resolves to an array.
   *   The first element of the array is Array of [Job]{@link google.cloud.talent.v4beta1.Job}.
   *
   *   When autoPaginate: false is specified through options, the array has three elements.
   *   The first element is Array of [Job]{@link google.cloud.talent.v4beta1.Job} in a single response.
   *   The second element is the next request object if the response
   *   indicates the next page exists, or null. The third element is
   *   an object representing [ListJobsResponse]{@link google.cloud.talent.v4beta1.ListJobsResponse}.
   *
   *   The promise has a method named "cancel" which cancels the ongoing API call.
   *
   * @example
   *
   * const talent = require('@google-cloud/talent');
   *
   * const client = new talent.v4beta1.JobServiceClient({
   *   // optional auth parameters.
   * });
   *
   * // Iterate over all elements.
   * const formattedParent = client.projectPath('[PROJECT]');
   * const filter = '';
   * const request = {
   *   parent: formattedParent,
   *   filter: filter,
   * };
   *
   * client.listJobs(request)
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
   * const filter = '';
   * const request = {
   *   parent: formattedParent,
   *   filter: filter,
   * };
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
   *     return client.listJobs(nextRequest, options).then(callback);
   *   }
   * }
   * client.listJobs(request, options)
   *   .then(callback)
   *   .catch(err => {
   *     console.error(err);
   *   });
   */
  listJobs(request, options, callback) {
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

    return this._innerApiCalls.listJobs(request, options, callback);
  }

  /**
   * Equivalent to {@link listJobs}, but returns a NodeJS Stream object.
   *
   * This fetches the paged responses for {@link listJobs} continuously
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
   *   Required. The resource name of the tenant under which the job is created.
   *
   *   The format is "projects/{project_id}/tenants/{tenant_id}". For example,
   *   "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
   *   is created. For example, "projects/foo".
   * @param {string} request.filter
   *   Required. The filter string specifies the jobs to be enumerated.
   *
   *   Supported operator: =, AND
   *
   *   The fields eligible for filtering are:
   *
   *   * `companyName` (Required)
   *   * `requisitionId`
   *   * `status` Available values: OPEN, EXPIRED, ALL. Defaults to
   *   OPEN if no value is specified.
   *
   *   Sample Query:
   *
   *   * companyName = "projects/foo/tenants/bar/companies/baz"
   *   * companyName = "projects/foo/tenants/bar/companies/baz" AND
   *   requisitionId = "req-1"
   *   * companyName = "projects/foo/tenants/bar/companies/baz" AND
   *   status = "EXPIRED"
   * @param {number} [request.pageSize]
   *   The maximum number of resources contained in the underlying API
   *   response. If page streaming is performed per-resource, this
   *   parameter does not affect the return value. If page streaming is
   *   performed per-page, this determines the maximum number of
   *   resources in a page.
   * @param {number} [request.jobView]
   *   The desired job attributes returned for jobs in the
   *   search response. Defaults to JobView.JOB_VIEW_FULL if no value is
   *   specified.
   *
   *   The number should be among the values of [JobView]{@link google.cloud.talent.v4beta1.JobView}
   * @param {Object} [options]
   *   Optional parameters. You can override the default settings for this call, e.g, timeout,
   *   retries, paginations, etc. See [gax.CallOptions]{@link https://googleapis.github.io/gax-nodejs/interfaces/CallOptions.html} for the details.
   * @returns {Stream}
   *   An object stream which emits an object representing [Job]{@link google.cloud.talent.v4beta1.Job} on 'data' event.
   *
   * @example
   *
   * const talent = require('@google-cloud/talent');
   *
   * const client = new talent.v4beta1.JobServiceClient({
   *   // optional auth parameters.
   * });
   *
   * const formattedParent = client.projectPath('[PROJECT]');
   * const filter = '';
   * const request = {
   *   parent: formattedParent,
   *   filter: filter,
   * };
   * client.listJobsStream(request)
   *   .on('data', element => {
   *     // doThingsWith(element)
   *   }).on('error', err => {
   *     console.log(err);
   *   });
   */
  listJobsStream(request, options) {
    options = options || {};

    return this._descriptors.page.listJobs.createStream(
      this._innerApiCalls.listJobs,
      request,
      options
    );
  };

  /**
   * Searches for jobs using the provided SearchJobsRequest.
   *
   * This call constrains the visibility of jobs
   * present in the database, and only returns jobs that the caller has
   * permission to search against.
   *
   * @param {Object} request
   *   The request object that will be sent.
   * @param {string} request.parent
   *   Required. The resource name of the tenant to search within.
   *
   *   The format is "projects/{project_id}/tenants/{tenant_id}". For example,
   *   "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
   *   is created. For example, "projects/foo".
   * @param {Object} request.requestMetadata
   *   Required. The meta information collected about the job searcher, used to improve the
   *   search quality of the service. The identifiers (such as `user_id`) are
   *   provided by users, and must be unique and consistent.
   *
   *   This object should have the same structure as [RequestMetadata]{@link google.cloud.talent.v4beta1.RequestMetadata}
   * @param {number} [request.searchMode]
   *   Mode of a search.
   *
   *   Defaults to SearchMode.JOB_SEARCH.
   *
   *   The number should be among the values of [SearchMode]{@link google.cloud.talent.v4beta1.SearchMode}
   * @param {Object} [request.jobQuery]
   *   Query used to search against jobs, such as keyword, location filters, etc.
   *
   *   This object should have the same structure as [JobQuery]{@link google.cloud.talent.v4beta1.JobQuery}
   * @param {boolean} [request.enableBroadening]
   *   Controls whether to broaden the search when it produces sparse results.
   *   Broadened queries append results to the end of the matching results
   *   list.
   *
   *   Defaults to false.
   * @param {boolean} [request.requirePreciseResultSize]
   *   Controls if the search job request requires the return of a precise
   *   count of the first 300 results. Setting this to `true` ensures
   *   consistency in the number of results per page. Best practice is to set this
   *   value to true if a client allows users to jump directly to a
   *   non-sequential search results page.
   *
   *   Enabling this flag may adversely impact performance.
   *
   *   Defaults to false.
   * @param {Object[]} [request.histogramQueries]
   *   An expression specifies a histogram request against matching jobs.
   *
   *   Expression syntax is an aggregation function call with histogram facets and
   *   other options.
   *
   *   Available aggregation function calls are:
   *   * `count(string_histogram_facet)`: Count the number of matching entities,
   *   for each distinct attribute value.
   *   * `count(numeric_histogram_facet, list of buckets)`: Count the number of
   *   matching entities within each bucket.
   *
   *   Data types:
   *
   *   * Histogram facet: facet names with format [a-zA-Z][a-zA-Z0-9_]+.
   *   * String: string like "any string with backslash escape for quote(\")."
   *   * Number: whole number and floating point number like 10, -1 and -0.01.
   *   * List: list of elements with comma(,) separator surrounded by square
   *   brackets, for example, [1, 2, 3] and ["one", "two", "three"].
   *
   *   Built-in constants:
   *
   *   * MIN (minimum number similar to java Double.MIN_VALUE)
   *   * MAX (maximum number similar to java Double.MAX_VALUE)
   *
   *   Built-in functions:
   *
   *   * bucket(start, end[, label]): bucket built-in function creates a bucket
   *   with range of start, end). Note that the end is exclusive, for example,
   *   bucket(1, MAX, "positive number") or bucket(1, 10).
   *
   *   Job histogram facets:
   *
   *   * company_display_name: histogram by [Job.company_display_name.
   *   * employment_type: histogram by Job.employment_types, for example,
   *     "FULL_TIME", "PART_TIME".
   *   * company_size: histogram by CompanySize, for example, "SMALL",
   *   "MEDIUM", "BIG".
   *   * publish_time_in_month: histogram by the Job.posting_publish_time
   *     in months.
   *     Must specify list of numeric buckets in spec.
   *   * publish_time_in_year: histogram by the Job.posting_publish_time
   *     in years.
   *     Must specify list of numeric buckets in spec.
   *   * degree_types: histogram by the Job.degree_types, for example,
   *     "Bachelors", "Masters".
   *   * job_level: histogram by the Job.job_level, for example, "Entry
   *     Level".
   *   * country: histogram by the country code of jobs, for example, "US", "FR".
   *   * admin1: histogram by the admin1 code of jobs, which is a global
   *     placeholder referring to the state, province, or the particular term a
   *     country uses to define the geographic structure below the country level,
   *     for example, "CA", "IL".
   *   * city: histogram by a combination of the "city name, admin1 code". For
   *     example,  "Mountain View, CA", "New York, NY".
   *   * admin1_country: histogram by a combination of the "admin1 code, country",
   *     for example, "CA, US", "IL, US".
   *   * city_coordinate: histogram by the city center's GPS coordinates (latitude
   *     and longitude), for example, 37.4038522,-122.0987765. Since the
   *     coordinates of a city center can change, customers may need to refresh
   *     them periodically.
   *   * locale: histogram by the Job.language_code, for example, "en-US",
   *     "fr-FR".
   *   * language: histogram by the language subtag of the Job.language_code,
   *     for example, "en", "fr".
   *   * category: histogram by the JobCategory, for example,
   *     "COMPUTER_AND_IT", "HEALTHCARE".
   *   * base_compensation_unit: histogram by the
   *     CompensationInfo.CompensationUnit of base
   *     salary, for example, "WEEKLY", "MONTHLY".
   *   * base_compensation: histogram by the base salary. Must specify list of
   *     numeric buckets to group results by.
   *   * annualized_base_compensation: histogram by the base annualized salary.
   *     Must specify list of numeric buckets to group results by.
   *   * annualized_total_compensation: histogram by the total annualized salary.
   *     Must specify list of numeric buckets to group results by.
   *   * string_custom_attribute: histogram by string Job.custom_attributes.
   *     Values can be accessed via square bracket notations like
   *     string_custom_attribute["key1"].
   *   * numeric_custom_attribute: histogram by numeric Job.custom_attributes.
   *     Values can be accessed via square bracket notations like
   *     numeric_custom_attribute["key1"]. Must specify list of numeric buckets to
   *     group results by.
   *
   *   Example expressions:
   *
   *   * `count(admin1)`
   *   * `count(base_compensation, [bucket(1000, 10000), bucket(10000, 100000),
   *   bucket(100000, MAX)])`
   *   * `count(string_custom_attribute["some-string-custom-attribute"])`
   *   * `count(numeric_custom_attribute["some-numeric-custom-attribute"],
   *     [bucket(MIN, 0, "negative"), bucket(0, MAX, "non-negative"])`
   *
   *   This object should have the same structure as [HistogramQuery]{@link google.cloud.talent.v4beta1.HistogramQuery}
   * @param {number} [request.jobView]
   *   The desired job attributes returned for jobs in the search response.
   *   Defaults to JobView.JOB_VIEW_SMALL if no value is specified.
   *
   *   The number should be among the values of [JobView]{@link google.cloud.talent.v4beta1.JobView}
   * @param {number} [request.offset]
   *   An integer that specifies the current offset (that is, starting result
   *   location, amongst the jobs deemed by the API as relevant) in search
   *   results. This field is only considered if page_token is unset.
   *
   *   The maximum allowed value is 5000. Otherwise an error is thrown.
   *
   *   For example, 0 means to  return results starting from the first matching
   *   job, and 10 means to return from the 11th job. This can be used for
   *   pagination, (for example, pageSize = 10 and offset = 10 means to return
   *   from the second page).
   * @param {number} [request.pageSize]
   *   The maximum number of resources contained in the underlying API
   *   response. If page streaming is performed per-resource, this
   *   parameter does not affect the return value. If page streaming is
   *   performed per-page, this determines the maximum number of
   *   resources in a page.
   * @param {string} [request.orderBy]
   *   The criteria determining how search results are sorted. Default is
   *   `"relevance desc"`.
   *
   *   Supported options are:
   *
   *   * `"relevance desc"`: By relevance descending, as determined by the API
   *     algorithms. Relevance thresholding of query results is only available
   *     with this ordering.
   *   * `"posting_publish_time desc"`: By Job.posting_publish_time
   *     descending.
   *   * `"posting_update_time desc"`: By Job.posting_update_time
   *     descending.
   *   * `"title"`: By Job.title ascending.
   *   * `"title desc"`: By Job.title descending.
   *   * `"annualized_base_compensation"`: By job's
   *     CompensationInfo.annualized_base_compensation_range ascending. Jobs
   *     whose annualized base compensation is unspecified are put at the end of
   *     search results.
   *   * `"annualized_base_compensation desc"`: By job's
   *     CompensationInfo.annualized_base_compensation_range descending. Jobs
   *     whose annualized base compensation is unspecified are put at the end of
   *     search results.
   *   * `"annualized_total_compensation"`: By job's
   *     CompensationInfo.annualized_total_compensation_range ascending. Jobs
   *     whose annualized base compensation is unspecified are put at the end of
   *     search results.
   *   * `"annualized_total_compensation desc"`: By job's
   *     CompensationInfo.annualized_total_compensation_range descending. Jobs
   *     whose annualized base compensation is unspecified are put at the end of
   *     search results.
   *   * `"custom_ranking desc"`: By the relevance score adjusted to the
   *     SearchJobsRequest.CustomRankingInfo.ranking_expression with weight
   *     factor assigned by
   *     SearchJobsRequest.CustomRankingInfo.importance_level in descending
   *     order.
   *   * Location sorting: Use the special syntax to order jobs by distance:<br>
   *     `"distance_from('Hawaii')"`: Order by distance from Hawaii.<br>
   *     `"distance_from(19.89, 155.5)"`: Order by distance from a coordinate.<br>
   *     `"distance_from('Hawaii'), distance_from('Puerto Rico')"`: Order by
   *     multiple locations. See details below.<br>
   *     `"distance_from('Hawaii'), distance_from(19.89, 155.5)"`: Order by
   *     multiple locations. See details below.<br>
   *     The string can have a maximum of 256 characters. When multiple distance
   *     centers are provided, a job that is close to any of the distance centers
   *     would have a high rank. When a job has multiple locations, the job
   *     location closest to one of the distance centers will be used. Jobs that
   *     don't have locations will be ranked at the bottom. Distance is calculated
   *     with a precision of 11.3 meters (37.4 feet). Diversification strategy is
   *     still applied unless explicitly disabled in
   *     diversification_level.
   * @param {number} [request.diversificationLevel]
   *   Controls whether highly similar jobs are returned next to each other in
   *   the search results. Jobs are identified as highly similar based on
   *   their titles, job categories, and locations. Highly similar results are
   *   clustered so that only one representative job of the cluster is
   *   displayed to the job seeker higher up in the results, with the other jobs
   *   being displayed lower down in the results.
   *
   *   Defaults to DiversificationLevel.SIMPLE if no value
   *   is specified.
   *
   *   The number should be among the values of [DiversificationLevel]{@link google.cloud.talent.v4beta1.DiversificationLevel}
   * @param {Object} [request.customRankingInfo]
   *   Controls over how job documents get ranked on top of existing relevance
   *   score (determined by API algorithm).
   *
   *   This object should have the same structure as [CustomRankingInfo]{@link google.cloud.talent.v4beta1.CustomRankingInfo}
   * @param {boolean} [request.disableKeywordMatch]
   *   Controls whether to disable exact keyword match on Job.title,
   *   Job.description, Job.company_display_name, Job.addresses,
   *   Job.qualifications. When disable keyword match is turned off, a
   *   keyword match returns jobs that do not match given category filters when
   *   there are matching keywords. For example, for the query "program manager,"
   *   a result is returned even if the job posting has the title "software
   *   developer," which doesn't fall into "program manager" ontology, but does
   *   have "program manager" appearing in its description.
   *
   *   For queries like "cloud" that don't contain title or
   *   location specific ontology, jobs with "cloud" keyword matches are returned
   *   regardless of this flag's value.
   *
   *   Use Company.keyword_searchable_job_custom_attributes if
   *   company-specific globally matched custom field/attribute string values are
   *   needed. Enabling keyword match improves recall of subsequent search
   *   requests.
   *
   *   Defaults to false.
   * @param {Object} [options]
   *   Optional parameters. You can override the default settings for this call, e.g, timeout,
   *   retries, paginations, etc. See [gax.CallOptions]{@link https://googleapis.github.io/gax-nodejs/interfaces/CallOptions.html} for the details.
   * @param {function(?Error, ?Array, ?Object, ?Object)} [callback]
   *   The function which will be called with the result of the API call.
   *
   *   The second parameter to the callback is Array of [MatchingJob]{@link google.cloud.talent.v4beta1.MatchingJob}.
   *
   *   When autoPaginate: false is specified through options, it contains the result
   *   in a single response. If the response indicates the next page exists, the third
   *   parameter is set to be used for the next request object. The fourth parameter keeps
   *   the raw response object of an object representing [SearchJobsResponse]{@link google.cloud.talent.v4beta1.SearchJobsResponse}.
   * @returns {Promise} - The promise which resolves to an array.
   *   The first element of the array is Array of [MatchingJob]{@link google.cloud.talent.v4beta1.MatchingJob}.
   *
   *   When autoPaginate: false is specified through options, the array has three elements.
   *   The first element is Array of [MatchingJob]{@link google.cloud.talent.v4beta1.MatchingJob} in a single response.
   *   The second element is the next request object if the response
   *   indicates the next page exists, or null. The third element is
   *   an object representing [SearchJobsResponse]{@link google.cloud.talent.v4beta1.SearchJobsResponse}.
   *
   *   The promise has a method named "cancel" which cancels the ongoing API call.
   *
   * @example
   *
   * const talent = require('@google-cloud/talent');
   *
   * const client = new talent.v4beta1.JobServiceClient({
   *   // optional auth parameters.
   * });
   *
   * // Iterate over all elements.
   * const formattedParent = client.projectPath('[PROJECT]');
   * const requestMetadata = {};
   * const request = {
   *   parent: formattedParent,
   *   requestMetadata: requestMetadata,
   * };
   *
   * client.searchJobs(request)
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
   * const requestMetadata = {};
   * const request = {
   *   parent: formattedParent,
   *   requestMetadata: requestMetadata,
   * };
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
   *     return client.searchJobs(nextRequest, options).then(callback);
   *   }
   * }
   * client.searchJobs(request, options)
   *   .then(callback)
   *   .catch(err => {
   *     console.error(err);
   *   });
   */
  searchJobs(request, options, callback) {
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

    return this._innerApiCalls.searchJobs(request, options, callback);
  }

  /**
   * Equivalent to {@link searchJobs}, but returns a NodeJS Stream object.
   *
   * This fetches the paged responses for {@link searchJobs} continuously
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
   *   Required. The resource name of the tenant to search within.
   *
   *   The format is "projects/{project_id}/tenants/{tenant_id}". For example,
   *   "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
   *   is created. For example, "projects/foo".
   * @param {Object} request.requestMetadata
   *   Required. The meta information collected about the job searcher, used to improve the
   *   search quality of the service. The identifiers (such as `user_id`) are
   *   provided by users, and must be unique and consistent.
   *
   *   This object should have the same structure as [RequestMetadata]{@link google.cloud.talent.v4beta1.RequestMetadata}
   * @param {number} [request.searchMode]
   *   Mode of a search.
   *
   *   Defaults to SearchMode.JOB_SEARCH.
   *
   *   The number should be among the values of [SearchMode]{@link google.cloud.talent.v4beta1.SearchMode}
   * @param {Object} [request.jobQuery]
   *   Query used to search against jobs, such as keyword, location filters, etc.
   *
   *   This object should have the same structure as [JobQuery]{@link google.cloud.talent.v4beta1.JobQuery}
   * @param {boolean} [request.enableBroadening]
   *   Controls whether to broaden the search when it produces sparse results.
   *   Broadened queries append results to the end of the matching results
   *   list.
   *
   *   Defaults to false.
   * @param {boolean} [request.requirePreciseResultSize]
   *   Controls if the search job request requires the return of a precise
   *   count of the first 300 results. Setting this to `true` ensures
   *   consistency in the number of results per page. Best practice is to set this
   *   value to true if a client allows users to jump directly to a
   *   non-sequential search results page.
   *
   *   Enabling this flag may adversely impact performance.
   *
   *   Defaults to false.
   * @param {Object[]} [request.histogramQueries]
   *   An expression specifies a histogram request against matching jobs.
   *
   *   Expression syntax is an aggregation function call with histogram facets and
   *   other options.
   *
   *   Available aggregation function calls are:
   *   * `count(string_histogram_facet)`: Count the number of matching entities,
   *   for each distinct attribute value.
   *   * `count(numeric_histogram_facet, list of buckets)`: Count the number of
   *   matching entities within each bucket.
   *
   *   Data types:
   *
   *   * Histogram facet: facet names with format [a-zA-Z][a-zA-Z0-9_]+.
   *   * String: string like "any string with backslash escape for quote(\")."
   *   * Number: whole number and floating point number like 10, -1 and -0.01.
   *   * List: list of elements with comma(,) separator surrounded by square
   *   brackets, for example, [1, 2, 3] and ["one", "two", "three"].
   *
   *   Built-in constants:
   *
   *   * MIN (minimum number similar to java Double.MIN_VALUE)
   *   * MAX (maximum number similar to java Double.MAX_VALUE)
   *
   *   Built-in functions:
   *
   *   * bucket(start, end[, label]): bucket built-in function creates a bucket
   *   with range of start, end). Note that the end is exclusive, for example,
   *   bucket(1, MAX, "positive number") or bucket(1, 10).
   *
   *   Job histogram facets:
   *
   *   * company_display_name: histogram by [Job.company_display_name.
   *   * employment_type: histogram by Job.employment_types, for example,
   *     "FULL_TIME", "PART_TIME".
   *   * company_size: histogram by CompanySize, for example, "SMALL",
   *   "MEDIUM", "BIG".
   *   * publish_time_in_month: histogram by the Job.posting_publish_time
   *     in months.
   *     Must specify list of numeric buckets in spec.
   *   * publish_time_in_year: histogram by the Job.posting_publish_time
   *     in years.
   *     Must specify list of numeric buckets in spec.
   *   * degree_types: histogram by the Job.degree_types, for example,
   *     "Bachelors", "Masters".
   *   * job_level: histogram by the Job.job_level, for example, "Entry
   *     Level".
   *   * country: histogram by the country code of jobs, for example, "US", "FR".
   *   * admin1: histogram by the admin1 code of jobs, which is a global
   *     placeholder referring to the state, province, or the particular term a
   *     country uses to define the geographic structure below the country level,
   *     for example, "CA", "IL".
   *   * city: histogram by a combination of the "city name, admin1 code". For
   *     example,  "Mountain View, CA", "New York, NY".
   *   * admin1_country: histogram by a combination of the "admin1 code, country",
   *     for example, "CA, US", "IL, US".
   *   * city_coordinate: histogram by the city center's GPS coordinates (latitude
   *     and longitude), for example, 37.4038522,-122.0987765. Since the
   *     coordinates of a city center can change, customers may need to refresh
   *     them periodically.
   *   * locale: histogram by the Job.language_code, for example, "en-US",
   *     "fr-FR".
   *   * language: histogram by the language subtag of the Job.language_code,
   *     for example, "en", "fr".
   *   * category: histogram by the JobCategory, for example,
   *     "COMPUTER_AND_IT", "HEALTHCARE".
   *   * base_compensation_unit: histogram by the
   *     CompensationInfo.CompensationUnit of base
   *     salary, for example, "WEEKLY", "MONTHLY".
   *   * base_compensation: histogram by the base salary. Must specify list of
   *     numeric buckets to group results by.
   *   * annualized_base_compensation: histogram by the base annualized salary.
   *     Must specify list of numeric buckets to group results by.
   *   * annualized_total_compensation: histogram by the total annualized salary.
   *     Must specify list of numeric buckets to group results by.
   *   * string_custom_attribute: histogram by string Job.custom_attributes.
   *     Values can be accessed via square bracket notations like
   *     string_custom_attribute["key1"].
   *   * numeric_custom_attribute: histogram by numeric Job.custom_attributes.
   *     Values can be accessed via square bracket notations like
   *     numeric_custom_attribute["key1"]. Must specify list of numeric buckets to
   *     group results by.
   *
   *   Example expressions:
   *
   *   * `count(admin1)`
   *   * `count(base_compensation, [bucket(1000, 10000), bucket(10000, 100000),
   *   bucket(100000, MAX)])`
   *   * `count(string_custom_attribute["some-string-custom-attribute"])`
   *   * `count(numeric_custom_attribute["some-numeric-custom-attribute"],
   *     [bucket(MIN, 0, "negative"), bucket(0, MAX, "non-negative"])`
   *
   *   This object should have the same structure as [HistogramQuery]{@link google.cloud.talent.v4beta1.HistogramQuery}
   * @param {number} [request.jobView]
   *   The desired job attributes returned for jobs in the search response.
   *   Defaults to JobView.JOB_VIEW_SMALL if no value is specified.
   *
   *   The number should be among the values of [JobView]{@link google.cloud.talent.v4beta1.JobView}
   * @param {number} [request.offset]
   *   An integer that specifies the current offset (that is, starting result
   *   location, amongst the jobs deemed by the API as relevant) in search
   *   results. This field is only considered if page_token is unset.
   *
   *   The maximum allowed value is 5000. Otherwise an error is thrown.
   *
   *   For example, 0 means to  return results starting from the first matching
   *   job, and 10 means to return from the 11th job. This can be used for
   *   pagination, (for example, pageSize = 10 and offset = 10 means to return
   *   from the second page).
   * @param {number} [request.pageSize]
   *   The maximum number of resources contained in the underlying API
   *   response. If page streaming is performed per-resource, this
   *   parameter does not affect the return value. If page streaming is
   *   performed per-page, this determines the maximum number of
   *   resources in a page.
   * @param {string} [request.orderBy]
   *   The criteria determining how search results are sorted. Default is
   *   `"relevance desc"`.
   *
   *   Supported options are:
   *
   *   * `"relevance desc"`: By relevance descending, as determined by the API
   *     algorithms. Relevance thresholding of query results is only available
   *     with this ordering.
   *   * `"posting_publish_time desc"`: By Job.posting_publish_time
   *     descending.
   *   * `"posting_update_time desc"`: By Job.posting_update_time
   *     descending.
   *   * `"title"`: By Job.title ascending.
   *   * `"title desc"`: By Job.title descending.
   *   * `"annualized_base_compensation"`: By job's
   *     CompensationInfo.annualized_base_compensation_range ascending. Jobs
   *     whose annualized base compensation is unspecified are put at the end of
   *     search results.
   *   * `"annualized_base_compensation desc"`: By job's
   *     CompensationInfo.annualized_base_compensation_range descending. Jobs
   *     whose annualized base compensation is unspecified are put at the end of
   *     search results.
   *   * `"annualized_total_compensation"`: By job's
   *     CompensationInfo.annualized_total_compensation_range ascending. Jobs
   *     whose annualized base compensation is unspecified are put at the end of
   *     search results.
   *   * `"annualized_total_compensation desc"`: By job's
   *     CompensationInfo.annualized_total_compensation_range descending. Jobs
   *     whose annualized base compensation is unspecified are put at the end of
   *     search results.
   *   * `"custom_ranking desc"`: By the relevance score adjusted to the
   *     SearchJobsRequest.CustomRankingInfo.ranking_expression with weight
   *     factor assigned by
   *     SearchJobsRequest.CustomRankingInfo.importance_level in descending
   *     order.
   *   * Location sorting: Use the special syntax to order jobs by distance:<br>
   *     `"distance_from('Hawaii')"`: Order by distance from Hawaii.<br>
   *     `"distance_from(19.89, 155.5)"`: Order by distance from a coordinate.<br>
   *     `"distance_from('Hawaii'), distance_from('Puerto Rico')"`: Order by
   *     multiple locations. See details below.<br>
   *     `"distance_from('Hawaii'), distance_from(19.89, 155.5)"`: Order by
   *     multiple locations. See details below.<br>
   *     The string can have a maximum of 256 characters. When multiple distance
   *     centers are provided, a job that is close to any of the distance centers
   *     would have a high rank. When a job has multiple locations, the job
   *     location closest to one of the distance centers will be used. Jobs that
   *     don't have locations will be ranked at the bottom. Distance is calculated
   *     with a precision of 11.3 meters (37.4 feet). Diversification strategy is
   *     still applied unless explicitly disabled in
   *     diversification_level.
   * @param {number} [request.diversificationLevel]
   *   Controls whether highly similar jobs are returned next to each other in
   *   the search results. Jobs are identified as highly similar based on
   *   their titles, job categories, and locations. Highly similar results are
   *   clustered so that only one representative job of the cluster is
   *   displayed to the job seeker higher up in the results, with the other jobs
   *   being displayed lower down in the results.
   *
   *   Defaults to DiversificationLevel.SIMPLE if no value
   *   is specified.
   *
   *   The number should be among the values of [DiversificationLevel]{@link google.cloud.talent.v4beta1.DiversificationLevel}
   * @param {Object} [request.customRankingInfo]
   *   Controls over how job documents get ranked on top of existing relevance
   *   score (determined by API algorithm).
   *
   *   This object should have the same structure as [CustomRankingInfo]{@link google.cloud.talent.v4beta1.CustomRankingInfo}
   * @param {boolean} [request.disableKeywordMatch]
   *   Controls whether to disable exact keyword match on Job.title,
   *   Job.description, Job.company_display_name, Job.addresses,
   *   Job.qualifications. When disable keyword match is turned off, a
   *   keyword match returns jobs that do not match given category filters when
   *   there are matching keywords. For example, for the query "program manager,"
   *   a result is returned even if the job posting has the title "software
   *   developer," which doesn't fall into "program manager" ontology, but does
   *   have "program manager" appearing in its description.
   *
   *   For queries like "cloud" that don't contain title or
   *   location specific ontology, jobs with "cloud" keyword matches are returned
   *   regardless of this flag's value.
   *
   *   Use Company.keyword_searchable_job_custom_attributes if
   *   company-specific globally matched custom field/attribute string values are
   *   needed. Enabling keyword match improves recall of subsequent search
   *   requests.
   *
   *   Defaults to false.
   * @param {Object} [options]
   *   Optional parameters. You can override the default settings for this call, e.g, timeout,
   *   retries, paginations, etc. See [gax.CallOptions]{@link https://googleapis.github.io/gax-nodejs/interfaces/CallOptions.html} for the details.
   * @returns {Stream}
   *   An object stream which emits an object representing [MatchingJob]{@link google.cloud.talent.v4beta1.MatchingJob} on 'data' event.
   *
   * @example
   *
   * const talent = require('@google-cloud/talent');
   *
   * const client = new talent.v4beta1.JobServiceClient({
   *   // optional auth parameters.
   * });
   *
   * const formattedParent = client.projectPath('[PROJECT]');
   * const requestMetadata = {};
   * const request = {
   *   parent: formattedParent,
   *   requestMetadata: requestMetadata,
   * };
   * client.searchJobsStream(request)
   *   .on('data', element => {
   *     // doThingsWith(element)
   *   }).on('error', err => {
   *     console.log(err);
   *   });
   */
  searchJobsStream(request, options) {
    options = options || {};

    return this._descriptors.page.searchJobs.createStream(
      this._innerApiCalls.searchJobs,
      request,
      options
    );
  };

  /**
   * Searches for jobs using the provided SearchJobsRequest.
   *
   * This API call is intended for the use case of targeting passive job
   * seekers (for example, job seekers who have signed up to receive email
   * alerts about potential job opportunities), and has different algorithmic
   * adjustments that are targeted to passive job seekers.
   *
   * This call constrains the visibility of jobs
   * present in the database, and only returns jobs the caller has
   * permission to search against.
   *
   * @param {Object} request
   *   The request object that will be sent.
   * @param {string} request.parent
   *   Required. The resource name of the tenant to search within.
   *
   *   The format is "projects/{project_id}/tenants/{tenant_id}". For example,
   *   "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
   *   is created. For example, "projects/foo".
   * @param {Object} request.requestMetadata
   *   Required. The meta information collected about the job searcher, used to improve the
   *   search quality of the service. The identifiers (such as `user_id`) are
   *   provided by users, and must be unique and consistent.
   *
   *   This object should have the same structure as [RequestMetadata]{@link google.cloud.talent.v4beta1.RequestMetadata}
   * @param {number} [request.searchMode]
   *   Mode of a search.
   *
   *   Defaults to SearchMode.JOB_SEARCH.
   *
   *   The number should be among the values of [SearchMode]{@link google.cloud.talent.v4beta1.SearchMode}
   * @param {Object} [request.jobQuery]
   *   Query used to search against jobs, such as keyword, location filters, etc.
   *
   *   This object should have the same structure as [JobQuery]{@link google.cloud.talent.v4beta1.JobQuery}
   * @param {boolean} [request.enableBroadening]
   *   Controls whether to broaden the search when it produces sparse results.
   *   Broadened queries append results to the end of the matching results
   *   list.
   *
   *   Defaults to false.
   * @param {boolean} [request.requirePreciseResultSize]
   *   Controls if the search job request requires the return of a precise
   *   count of the first 300 results. Setting this to `true` ensures
   *   consistency in the number of results per page. Best practice is to set this
   *   value to true if a client allows users to jump directly to a
   *   non-sequential search results page.
   *
   *   Enabling this flag may adversely impact performance.
   *
   *   Defaults to false.
   * @param {Object[]} [request.histogramQueries]
   *   An expression specifies a histogram request against matching jobs.
   *
   *   Expression syntax is an aggregation function call with histogram facets and
   *   other options.
   *
   *   Available aggregation function calls are:
   *   * `count(string_histogram_facet)`: Count the number of matching entities,
   *   for each distinct attribute value.
   *   * `count(numeric_histogram_facet, list of buckets)`: Count the number of
   *   matching entities within each bucket.
   *
   *   Data types:
   *
   *   * Histogram facet: facet names with format [a-zA-Z][a-zA-Z0-9_]+.
   *   * String: string like "any string with backslash escape for quote(\")."
   *   * Number: whole number and floating point number like 10, -1 and -0.01.
   *   * List: list of elements with comma(,) separator surrounded by square
   *   brackets, for example, [1, 2, 3] and ["one", "two", "three"].
   *
   *   Built-in constants:
   *
   *   * MIN (minimum number similar to java Double.MIN_VALUE)
   *   * MAX (maximum number similar to java Double.MAX_VALUE)
   *
   *   Built-in functions:
   *
   *   * bucket(start, end[, label]): bucket built-in function creates a bucket
   *   with range of start, end). Note that the end is exclusive, for example,
   *   bucket(1, MAX, "positive number") or bucket(1, 10).
   *
   *   Job histogram facets:
   *
   *   * company_display_name: histogram by [Job.company_display_name.
   *   * employment_type: histogram by Job.employment_types, for example,
   *     "FULL_TIME", "PART_TIME".
   *   * company_size: histogram by CompanySize, for example, "SMALL",
   *   "MEDIUM", "BIG".
   *   * publish_time_in_month: histogram by the Job.posting_publish_time
   *     in months.
   *     Must specify list of numeric buckets in spec.
   *   * publish_time_in_year: histogram by the Job.posting_publish_time
   *     in years.
   *     Must specify list of numeric buckets in spec.
   *   * degree_types: histogram by the Job.degree_types, for example,
   *     "Bachelors", "Masters".
   *   * job_level: histogram by the Job.job_level, for example, "Entry
   *     Level".
   *   * country: histogram by the country code of jobs, for example, "US", "FR".
   *   * admin1: histogram by the admin1 code of jobs, which is a global
   *     placeholder referring to the state, province, or the particular term a
   *     country uses to define the geographic structure below the country level,
   *     for example, "CA", "IL".
   *   * city: histogram by a combination of the "city name, admin1 code". For
   *     example,  "Mountain View, CA", "New York, NY".
   *   * admin1_country: histogram by a combination of the "admin1 code, country",
   *     for example, "CA, US", "IL, US".
   *   * city_coordinate: histogram by the city center's GPS coordinates (latitude
   *     and longitude), for example, 37.4038522,-122.0987765. Since the
   *     coordinates of a city center can change, customers may need to refresh
   *     them periodically.
   *   * locale: histogram by the Job.language_code, for example, "en-US",
   *     "fr-FR".
   *   * language: histogram by the language subtag of the Job.language_code,
   *     for example, "en", "fr".
   *   * category: histogram by the JobCategory, for example,
   *     "COMPUTER_AND_IT", "HEALTHCARE".
   *   * base_compensation_unit: histogram by the
   *     CompensationInfo.CompensationUnit of base
   *     salary, for example, "WEEKLY", "MONTHLY".
   *   * base_compensation: histogram by the base salary. Must specify list of
   *     numeric buckets to group results by.
   *   * annualized_base_compensation: histogram by the base annualized salary.
   *     Must specify list of numeric buckets to group results by.
   *   * annualized_total_compensation: histogram by the total annualized salary.
   *     Must specify list of numeric buckets to group results by.
   *   * string_custom_attribute: histogram by string Job.custom_attributes.
   *     Values can be accessed via square bracket notations like
   *     string_custom_attribute["key1"].
   *   * numeric_custom_attribute: histogram by numeric Job.custom_attributes.
   *     Values can be accessed via square bracket notations like
   *     numeric_custom_attribute["key1"]. Must specify list of numeric buckets to
   *     group results by.
   *
   *   Example expressions:
   *
   *   * `count(admin1)`
   *   * `count(base_compensation, [bucket(1000, 10000), bucket(10000, 100000),
   *   bucket(100000, MAX)])`
   *   * `count(string_custom_attribute["some-string-custom-attribute"])`
   *   * `count(numeric_custom_attribute["some-numeric-custom-attribute"],
   *     [bucket(MIN, 0, "negative"), bucket(0, MAX, "non-negative"])`
   *
   *   This object should have the same structure as [HistogramQuery]{@link google.cloud.talent.v4beta1.HistogramQuery}
   * @param {number} [request.jobView]
   *   The desired job attributes returned for jobs in the search response.
   *   Defaults to JobView.JOB_VIEW_SMALL if no value is specified.
   *
   *   The number should be among the values of [JobView]{@link google.cloud.talent.v4beta1.JobView}
   * @param {number} [request.offset]
   *   An integer that specifies the current offset (that is, starting result
   *   location, amongst the jobs deemed by the API as relevant) in search
   *   results. This field is only considered if page_token is unset.
   *
   *   The maximum allowed value is 5000. Otherwise an error is thrown.
   *
   *   For example, 0 means to  return results starting from the first matching
   *   job, and 10 means to return from the 11th job. This can be used for
   *   pagination, (for example, pageSize = 10 and offset = 10 means to return
   *   from the second page).
   * @param {number} [request.pageSize]
   *   The maximum number of resources contained in the underlying API
   *   response. If page streaming is performed per-resource, this
   *   parameter does not affect the return value. If page streaming is
   *   performed per-page, this determines the maximum number of
   *   resources in a page.
   * @param {string} [request.orderBy]
   *   The criteria determining how search results are sorted. Default is
   *   `"relevance desc"`.
   *
   *   Supported options are:
   *
   *   * `"relevance desc"`: By relevance descending, as determined by the API
   *     algorithms. Relevance thresholding of query results is only available
   *     with this ordering.
   *   * `"posting_publish_time desc"`: By Job.posting_publish_time
   *     descending.
   *   * `"posting_update_time desc"`: By Job.posting_update_time
   *     descending.
   *   * `"title"`: By Job.title ascending.
   *   * `"title desc"`: By Job.title descending.
   *   * `"annualized_base_compensation"`: By job's
   *     CompensationInfo.annualized_base_compensation_range ascending. Jobs
   *     whose annualized base compensation is unspecified are put at the end of
   *     search results.
   *   * `"annualized_base_compensation desc"`: By job's
   *     CompensationInfo.annualized_base_compensation_range descending. Jobs
   *     whose annualized base compensation is unspecified are put at the end of
   *     search results.
   *   * `"annualized_total_compensation"`: By job's
   *     CompensationInfo.annualized_total_compensation_range ascending. Jobs
   *     whose annualized base compensation is unspecified are put at the end of
   *     search results.
   *   * `"annualized_total_compensation desc"`: By job's
   *     CompensationInfo.annualized_total_compensation_range descending. Jobs
   *     whose annualized base compensation is unspecified are put at the end of
   *     search results.
   *   * `"custom_ranking desc"`: By the relevance score adjusted to the
   *     SearchJobsRequest.CustomRankingInfo.ranking_expression with weight
   *     factor assigned by
   *     SearchJobsRequest.CustomRankingInfo.importance_level in descending
   *     order.
   *   * Location sorting: Use the special syntax to order jobs by distance:<br>
   *     `"distance_from('Hawaii')"`: Order by distance from Hawaii.<br>
   *     `"distance_from(19.89, 155.5)"`: Order by distance from a coordinate.<br>
   *     `"distance_from('Hawaii'), distance_from('Puerto Rico')"`: Order by
   *     multiple locations. See details below.<br>
   *     `"distance_from('Hawaii'), distance_from(19.89, 155.5)"`: Order by
   *     multiple locations. See details below.<br>
   *     The string can have a maximum of 256 characters. When multiple distance
   *     centers are provided, a job that is close to any of the distance centers
   *     would have a high rank. When a job has multiple locations, the job
   *     location closest to one of the distance centers will be used. Jobs that
   *     don't have locations will be ranked at the bottom. Distance is calculated
   *     with a precision of 11.3 meters (37.4 feet). Diversification strategy is
   *     still applied unless explicitly disabled in
   *     diversification_level.
   * @param {number} [request.diversificationLevel]
   *   Controls whether highly similar jobs are returned next to each other in
   *   the search results. Jobs are identified as highly similar based on
   *   their titles, job categories, and locations. Highly similar results are
   *   clustered so that only one representative job of the cluster is
   *   displayed to the job seeker higher up in the results, with the other jobs
   *   being displayed lower down in the results.
   *
   *   Defaults to DiversificationLevel.SIMPLE if no value
   *   is specified.
   *
   *   The number should be among the values of [DiversificationLevel]{@link google.cloud.talent.v4beta1.DiversificationLevel}
   * @param {Object} [request.customRankingInfo]
   *   Controls over how job documents get ranked on top of existing relevance
   *   score (determined by API algorithm).
   *
   *   This object should have the same structure as [CustomRankingInfo]{@link google.cloud.talent.v4beta1.CustomRankingInfo}
   * @param {boolean} [request.disableKeywordMatch]
   *   Controls whether to disable exact keyword match on Job.title,
   *   Job.description, Job.company_display_name, Job.addresses,
   *   Job.qualifications. When disable keyword match is turned off, a
   *   keyword match returns jobs that do not match given category filters when
   *   there are matching keywords. For example, for the query "program manager,"
   *   a result is returned even if the job posting has the title "software
   *   developer," which doesn't fall into "program manager" ontology, but does
   *   have "program manager" appearing in its description.
   *
   *   For queries like "cloud" that don't contain title or
   *   location specific ontology, jobs with "cloud" keyword matches are returned
   *   regardless of this flag's value.
   *
   *   Use Company.keyword_searchable_job_custom_attributes if
   *   company-specific globally matched custom field/attribute string values are
   *   needed. Enabling keyword match improves recall of subsequent search
   *   requests.
   *
   *   Defaults to false.
   * @param {Object} [options]
   *   Optional parameters. You can override the default settings for this call, e.g, timeout,
   *   retries, paginations, etc. See [gax.CallOptions]{@link https://googleapis.github.io/gax-nodejs/interfaces/CallOptions.html} for the details.
   * @param {function(?Error, ?Array, ?Object, ?Object)} [callback]
   *   The function which will be called with the result of the API call.
   *
   *   The second parameter to the callback is Array of [MatchingJob]{@link google.cloud.talent.v4beta1.MatchingJob}.
   *
   *   When autoPaginate: false is specified through options, it contains the result
   *   in a single response. If the response indicates the next page exists, the third
   *   parameter is set to be used for the next request object. The fourth parameter keeps
   *   the raw response object of an object representing [SearchJobsResponse]{@link google.cloud.talent.v4beta1.SearchJobsResponse}.
   * @returns {Promise} - The promise which resolves to an array.
   *   The first element of the array is Array of [MatchingJob]{@link google.cloud.talent.v4beta1.MatchingJob}.
   *
   *   When autoPaginate: false is specified through options, the array has three elements.
   *   The first element is Array of [MatchingJob]{@link google.cloud.talent.v4beta1.MatchingJob} in a single response.
   *   The second element is the next request object if the response
   *   indicates the next page exists, or null. The third element is
   *   an object representing [SearchJobsResponse]{@link google.cloud.talent.v4beta1.SearchJobsResponse}.
   *
   *   The promise has a method named "cancel" which cancels the ongoing API call.
   *
   * @example
   *
   * const talent = require('@google-cloud/talent');
   *
   * const client = new talent.v4beta1.JobServiceClient({
   *   // optional auth parameters.
   * });
   *
   * // Iterate over all elements.
   * const formattedParent = client.projectPath('[PROJECT]');
   * const requestMetadata = {};
   * const request = {
   *   parent: formattedParent,
   *   requestMetadata: requestMetadata,
   * };
   *
   * client.searchJobsForAlert(request)
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
   * const requestMetadata = {};
   * const request = {
   *   parent: formattedParent,
   *   requestMetadata: requestMetadata,
   * };
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
   *     return client.searchJobsForAlert(nextRequest, options).then(callback);
   *   }
   * }
   * client.searchJobsForAlert(request, options)
   *   .then(callback)
   *   .catch(err => {
   *     console.error(err);
   *   });
   */
  searchJobsForAlert(request, options, callback) {
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

    return this._innerApiCalls.searchJobsForAlert(request, options, callback);
  }

  /**
   * Equivalent to {@link searchJobsForAlert}, but returns a NodeJS Stream object.
   *
   * This fetches the paged responses for {@link searchJobsForAlert} continuously
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
   *   Required. The resource name of the tenant to search within.
   *
   *   The format is "projects/{project_id}/tenants/{tenant_id}". For example,
   *   "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
   *   is created. For example, "projects/foo".
   * @param {Object} request.requestMetadata
   *   Required. The meta information collected about the job searcher, used to improve the
   *   search quality of the service. The identifiers (such as `user_id`) are
   *   provided by users, and must be unique and consistent.
   *
   *   This object should have the same structure as [RequestMetadata]{@link google.cloud.talent.v4beta1.RequestMetadata}
   * @param {number} [request.searchMode]
   *   Mode of a search.
   *
   *   Defaults to SearchMode.JOB_SEARCH.
   *
   *   The number should be among the values of [SearchMode]{@link google.cloud.talent.v4beta1.SearchMode}
   * @param {Object} [request.jobQuery]
   *   Query used to search against jobs, such as keyword, location filters, etc.
   *
   *   This object should have the same structure as [JobQuery]{@link google.cloud.talent.v4beta1.JobQuery}
   * @param {boolean} [request.enableBroadening]
   *   Controls whether to broaden the search when it produces sparse results.
   *   Broadened queries append results to the end of the matching results
   *   list.
   *
   *   Defaults to false.
   * @param {boolean} [request.requirePreciseResultSize]
   *   Controls if the search job request requires the return of a precise
   *   count of the first 300 results. Setting this to `true` ensures
   *   consistency in the number of results per page. Best practice is to set this
   *   value to true if a client allows users to jump directly to a
   *   non-sequential search results page.
   *
   *   Enabling this flag may adversely impact performance.
   *
   *   Defaults to false.
   * @param {Object[]} [request.histogramQueries]
   *   An expression specifies a histogram request against matching jobs.
   *
   *   Expression syntax is an aggregation function call with histogram facets and
   *   other options.
   *
   *   Available aggregation function calls are:
   *   * `count(string_histogram_facet)`: Count the number of matching entities,
   *   for each distinct attribute value.
   *   * `count(numeric_histogram_facet, list of buckets)`: Count the number of
   *   matching entities within each bucket.
   *
   *   Data types:
   *
   *   * Histogram facet: facet names with format [a-zA-Z][a-zA-Z0-9_]+.
   *   * String: string like "any string with backslash escape for quote(\")."
   *   * Number: whole number and floating point number like 10, -1 and -0.01.
   *   * List: list of elements with comma(,) separator surrounded by square
   *   brackets, for example, [1, 2, 3] and ["one", "two", "three"].
   *
   *   Built-in constants:
   *
   *   * MIN (minimum number similar to java Double.MIN_VALUE)
   *   * MAX (maximum number similar to java Double.MAX_VALUE)
   *
   *   Built-in functions:
   *
   *   * bucket(start, end[, label]): bucket built-in function creates a bucket
   *   with range of start, end). Note that the end is exclusive, for example,
   *   bucket(1, MAX, "positive number") or bucket(1, 10).
   *
   *   Job histogram facets:
   *
   *   * company_display_name: histogram by [Job.company_display_name.
   *   * employment_type: histogram by Job.employment_types, for example,
   *     "FULL_TIME", "PART_TIME".
   *   * company_size: histogram by CompanySize, for example, "SMALL",
   *   "MEDIUM", "BIG".
   *   * publish_time_in_month: histogram by the Job.posting_publish_time
   *     in months.
   *     Must specify list of numeric buckets in spec.
   *   * publish_time_in_year: histogram by the Job.posting_publish_time
   *     in years.
   *     Must specify list of numeric buckets in spec.
   *   * degree_types: histogram by the Job.degree_types, for example,
   *     "Bachelors", "Masters".
   *   * job_level: histogram by the Job.job_level, for example, "Entry
   *     Level".
   *   * country: histogram by the country code of jobs, for example, "US", "FR".
   *   * admin1: histogram by the admin1 code of jobs, which is a global
   *     placeholder referring to the state, province, or the particular term a
   *     country uses to define the geographic structure below the country level,
   *     for example, "CA", "IL".
   *   * city: histogram by a combination of the "city name, admin1 code". For
   *     example,  "Mountain View, CA", "New York, NY".
   *   * admin1_country: histogram by a combination of the "admin1 code, country",
   *     for example, "CA, US", "IL, US".
   *   * city_coordinate: histogram by the city center's GPS coordinates (latitude
   *     and longitude), for example, 37.4038522,-122.0987765. Since the
   *     coordinates of a city center can change, customers may need to refresh
   *     them periodically.
   *   * locale: histogram by the Job.language_code, for example, "en-US",
   *     "fr-FR".
   *   * language: histogram by the language subtag of the Job.language_code,
   *     for example, "en", "fr".
   *   * category: histogram by the JobCategory, for example,
   *     "COMPUTER_AND_IT", "HEALTHCARE".
   *   * base_compensation_unit: histogram by the
   *     CompensationInfo.CompensationUnit of base
   *     salary, for example, "WEEKLY", "MONTHLY".
   *   * base_compensation: histogram by the base salary. Must specify list of
   *     numeric buckets to group results by.
   *   * annualized_base_compensation: histogram by the base annualized salary.
   *     Must specify list of numeric buckets to group results by.
   *   * annualized_total_compensation: histogram by the total annualized salary.
   *     Must specify list of numeric buckets to group results by.
   *   * string_custom_attribute: histogram by string Job.custom_attributes.
   *     Values can be accessed via square bracket notations like
   *     string_custom_attribute["key1"].
   *   * numeric_custom_attribute: histogram by numeric Job.custom_attributes.
   *     Values can be accessed via square bracket notations like
   *     numeric_custom_attribute["key1"]. Must specify list of numeric buckets to
   *     group results by.
   *
   *   Example expressions:
   *
   *   * `count(admin1)`
   *   * `count(base_compensation, [bucket(1000, 10000), bucket(10000, 100000),
   *   bucket(100000, MAX)])`
   *   * `count(string_custom_attribute["some-string-custom-attribute"])`
   *   * `count(numeric_custom_attribute["some-numeric-custom-attribute"],
   *     [bucket(MIN, 0, "negative"), bucket(0, MAX, "non-negative"])`
   *
   *   This object should have the same structure as [HistogramQuery]{@link google.cloud.talent.v4beta1.HistogramQuery}
   * @param {number} [request.jobView]
   *   The desired job attributes returned for jobs in the search response.
   *   Defaults to JobView.JOB_VIEW_SMALL if no value is specified.
   *
   *   The number should be among the values of [JobView]{@link google.cloud.talent.v4beta1.JobView}
   * @param {number} [request.offset]
   *   An integer that specifies the current offset (that is, starting result
   *   location, amongst the jobs deemed by the API as relevant) in search
   *   results. This field is only considered if page_token is unset.
   *
   *   The maximum allowed value is 5000. Otherwise an error is thrown.
   *
   *   For example, 0 means to  return results starting from the first matching
   *   job, and 10 means to return from the 11th job. This can be used for
   *   pagination, (for example, pageSize = 10 and offset = 10 means to return
   *   from the second page).
   * @param {number} [request.pageSize]
   *   The maximum number of resources contained in the underlying API
   *   response. If page streaming is performed per-resource, this
   *   parameter does not affect the return value. If page streaming is
   *   performed per-page, this determines the maximum number of
   *   resources in a page.
   * @param {string} [request.orderBy]
   *   The criteria determining how search results are sorted. Default is
   *   `"relevance desc"`.
   *
   *   Supported options are:
   *
   *   * `"relevance desc"`: By relevance descending, as determined by the API
   *     algorithms. Relevance thresholding of query results is only available
   *     with this ordering.
   *   * `"posting_publish_time desc"`: By Job.posting_publish_time
   *     descending.
   *   * `"posting_update_time desc"`: By Job.posting_update_time
   *     descending.
   *   * `"title"`: By Job.title ascending.
   *   * `"title desc"`: By Job.title descending.
   *   * `"annualized_base_compensation"`: By job's
   *     CompensationInfo.annualized_base_compensation_range ascending. Jobs
   *     whose annualized base compensation is unspecified are put at the end of
   *     search results.
   *   * `"annualized_base_compensation desc"`: By job's
   *     CompensationInfo.annualized_base_compensation_range descending. Jobs
   *     whose annualized base compensation is unspecified are put at the end of
   *     search results.
   *   * `"annualized_total_compensation"`: By job's
   *     CompensationInfo.annualized_total_compensation_range ascending. Jobs
   *     whose annualized base compensation is unspecified are put at the end of
   *     search results.
   *   * `"annualized_total_compensation desc"`: By job's
   *     CompensationInfo.annualized_total_compensation_range descending. Jobs
   *     whose annualized base compensation is unspecified are put at the end of
   *     search results.
   *   * `"custom_ranking desc"`: By the relevance score adjusted to the
   *     SearchJobsRequest.CustomRankingInfo.ranking_expression with weight
   *     factor assigned by
   *     SearchJobsRequest.CustomRankingInfo.importance_level in descending
   *     order.
   *   * Location sorting: Use the special syntax to order jobs by distance:<br>
   *     `"distance_from('Hawaii')"`: Order by distance from Hawaii.<br>
   *     `"distance_from(19.89, 155.5)"`: Order by distance from a coordinate.<br>
   *     `"distance_from('Hawaii'), distance_from('Puerto Rico')"`: Order by
   *     multiple locations. See details below.<br>
   *     `"distance_from('Hawaii'), distance_from(19.89, 155.5)"`: Order by
   *     multiple locations. See details below.<br>
   *     The string can have a maximum of 256 characters. When multiple distance
   *     centers are provided, a job that is close to any of the distance centers
   *     would have a high rank. When a job has multiple locations, the job
   *     location closest to one of the distance centers will be used. Jobs that
   *     don't have locations will be ranked at the bottom. Distance is calculated
   *     with a precision of 11.3 meters (37.4 feet). Diversification strategy is
   *     still applied unless explicitly disabled in
   *     diversification_level.
   * @param {number} [request.diversificationLevel]
   *   Controls whether highly similar jobs are returned next to each other in
   *   the search results. Jobs are identified as highly similar based on
   *   their titles, job categories, and locations. Highly similar results are
   *   clustered so that only one representative job of the cluster is
   *   displayed to the job seeker higher up in the results, with the other jobs
   *   being displayed lower down in the results.
   *
   *   Defaults to DiversificationLevel.SIMPLE if no value
   *   is specified.
   *
   *   The number should be among the values of [DiversificationLevel]{@link google.cloud.talent.v4beta1.DiversificationLevel}
   * @param {Object} [request.customRankingInfo]
   *   Controls over how job documents get ranked on top of existing relevance
   *   score (determined by API algorithm).
   *
   *   This object should have the same structure as [CustomRankingInfo]{@link google.cloud.talent.v4beta1.CustomRankingInfo}
   * @param {boolean} [request.disableKeywordMatch]
   *   Controls whether to disable exact keyword match on Job.title,
   *   Job.description, Job.company_display_name, Job.addresses,
   *   Job.qualifications. When disable keyword match is turned off, a
   *   keyword match returns jobs that do not match given category filters when
   *   there are matching keywords. For example, for the query "program manager,"
   *   a result is returned even if the job posting has the title "software
   *   developer," which doesn't fall into "program manager" ontology, but does
   *   have "program manager" appearing in its description.
   *
   *   For queries like "cloud" that don't contain title or
   *   location specific ontology, jobs with "cloud" keyword matches are returned
   *   regardless of this flag's value.
   *
   *   Use Company.keyword_searchable_job_custom_attributes if
   *   company-specific globally matched custom field/attribute string values are
   *   needed. Enabling keyword match improves recall of subsequent search
   *   requests.
   *
   *   Defaults to false.
   * @param {Object} [options]
   *   Optional parameters. You can override the default settings for this call, e.g, timeout,
   *   retries, paginations, etc. See [gax.CallOptions]{@link https://googleapis.github.io/gax-nodejs/interfaces/CallOptions.html} for the details.
   * @returns {Stream}
   *   An object stream which emits an object representing [MatchingJob]{@link google.cloud.talent.v4beta1.MatchingJob} on 'data' event.
   *
   * @example
   *
   * const talent = require('@google-cloud/talent');
   *
   * const client = new talent.v4beta1.JobServiceClient({
   *   // optional auth parameters.
   * });
   *
   * const formattedParent = client.projectPath('[PROJECT]');
   * const requestMetadata = {};
   * const request = {
   *   parent: formattedParent,
   *   requestMetadata: requestMetadata,
   * };
   * client.searchJobsForAlertStream(request)
   *   .on('data', element => {
   *     // doThingsWith(element)
   *   }).on('error', err => {
   *     console.log(err);
   *   });
   */
  searchJobsForAlertStream(request, options) {
    options = options || {};

    return this._descriptors.page.searchJobsForAlert.createStream(
      this._innerApiCalls.searchJobsForAlert,
      request,
      options
    );
  };

  // --------------------
  // -- Path templates --
  // --------------------

  /**
   * @deprecated Multi-pattern resource names will have unified formatting and parsing helper functions. This helper function will be deleted in the next major version.
   * Return a fully-qualified company resource name string.
   *
   * @param {String} project
   * @param {String} tenant
   * @param {String} company
   * @returns {String}
   */
  companyPath(project, tenant, company) {
    return this._pathTemplates.companyPathTemplate.render({
      project: project,
      tenant: tenant,
      company: company,
    });
  }

  /**
   * @deprecated Multi-pattern resource names will have unified formatting and parsing helper functions. This helper function will be deleted in the next major version.
   * Return a fully-qualified company_without_tenant resource name string.
   *
   * @param {String} project
   * @param {String} company
   * @returns {String}
   */
  companyWithoutTenantPath(project, company) {
    return this._pathTemplates.companyWithoutTenantPathTemplate.render({
      project: project,
      company: company,
    });
  }

  /**
   * @deprecated Multi-pattern resource names will have unified formatting and parsing helper functions. This helper function will be deleted in the next major version.
   * Return a fully-qualified job resource name string.
   *
   * @param {String} project
   * @param {String} tenant
   * @param {String} jobs
   * @returns {String}
   */
  jobPath(project, tenant, jobs) {
    return this._pathTemplates.jobPathTemplate.render({
      project: project,
      tenant: tenant,
      jobs: jobs,
    });
  }

  /**
   * @deprecated Multi-pattern resource names will have unified formatting and parsing helper functions. This helper function will be deleted in the next major version.
   * Return a fully-qualified job_without_tenant resource name string.
   *
   * @param {String} project
   * @param {String} jobs
   * @returns {String}
   */
  jobWithoutTenantPath(project, jobs) {
    return this._pathTemplates.jobWithoutTenantPathTemplate.render({
      project: project,
      jobs: jobs,
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
   * Return a fully-qualified tenant resource name string.
   *
   * @param {String} project
   * @param {String} tenant
   * @returns {String}
   */
  tenantPath(project, tenant) {
    return this._pathTemplates.tenantPathTemplate.render({
      project: project,
      tenant: tenant,
    });
  }

  /**
   * @deprecated Multi-pattern resource names will have unified formatting and parsing helper functions. This helper function will be deleted in the next major version.
   * Parse the companyName from a company resource.
   *
   * @param {String} companyName
   *   A fully-qualified path representing a company resources.
   * @returns {String} - A string representing the project.
   */
  matchProjectFromCompanyName(companyName) {
    return this._pathTemplates.companyPathTemplate
      .match(companyName)
      .project;
  }

  /**
   * @deprecated Multi-pattern resource names will have unified formatting and parsing helper functions. This helper function will be deleted in the next major version.
   * Parse the companyName from a company resource.
   *
   * @param {String} companyName
   *   A fully-qualified path representing a company resources.
   * @returns {String} - A string representing the tenant.
   */
  matchTenantFromCompanyName(companyName) {
    return this._pathTemplates.companyPathTemplate
      .match(companyName)
      .tenant;
  }

  /**
   * @deprecated Multi-pattern resource names will have unified formatting and parsing helper functions. This helper function will be deleted in the next major version.
   * Parse the companyName from a company resource.
   *
   * @param {String} companyName
   *   A fully-qualified path representing a company resources.
   * @returns {String} - A string representing the company.
   */
  matchCompanyFromCompanyName(companyName) {
    return this._pathTemplates.companyPathTemplate
      .match(companyName)
      .company;
  }

  /**
   * @deprecated Multi-pattern resource names will have unified formatting and parsing helper functions. This helper function will be deleted in the next major version.
   * Parse the companyWithoutTenantName from a company_without_tenant resource.
   *
   * @param {String} companyWithoutTenantName
   *   A fully-qualified path representing a company_without_tenant resources.
   * @returns {String} - A string representing the project.
   */
  matchProjectFromCompanyWithoutTenantName(companyWithoutTenantName) {
    return this._pathTemplates.companyWithoutTenantPathTemplate
      .match(companyWithoutTenantName)
      .project;
  }

  /**
   * @deprecated Multi-pattern resource names will have unified formatting and parsing helper functions. This helper function will be deleted in the next major version.
   * Parse the companyWithoutTenantName from a company_without_tenant resource.
   *
   * @param {String} companyWithoutTenantName
   *   A fully-qualified path representing a company_without_tenant resources.
   * @returns {String} - A string representing the company.
   */
  matchCompanyFromCompanyWithoutTenantName(companyWithoutTenantName) {
    return this._pathTemplates.companyWithoutTenantPathTemplate
      .match(companyWithoutTenantName)
      .company;
  }

  /**
   * @deprecated Multi-pattern resource names will have unified formatting and parsing helper functions. This helper function will be deleted in the next major version.
   * Parse the jobName from a job resource.
   *
   * @param {String} jobName
   *   A fully-qualified path representing a job resources.
   * @returns {String} - A string representing the project.
   */
  matchProjectFromJobName(jobName) {
    return this._pathTemplates.jobPathTemplate
      .match(jobName)
      .project;
  }

  /**
   * @deprecated Multi-pattern resource names will have unified formatting and parsing helper functions. This helper function will be deleted in the next major version.
   * Parse the jobName from a job resource.
   *
   * @param {String} jobName
   *   A fully-qualified path representing a job resources.
   * @returns {String} - A string representing the tenant.
   */
  matchTenantFromJobName(jobName) {
    return this._pathTemplates.jobPathTemplate
      .match(jobName)
      .tenant;
  }

  /**
   * @deprecated Multi-pattern resource names will have unified formatting and parsing helper functions. This helper function will be deleted in the next major version.
   * Parse the jobName from a job resource.
   *
   * @param {String} jobName
   *   A fully-qualified path representing a job resources.
   * @returns {String} - A string representing the jobs.
   */
  matchJobsFromJobName(jobName) {
    return this._pathTemplates.jobPathTemplate
      .match(jobName)
      .jobs;
  }

  /**
   * @deprecated Multi-pattern resource names will have unified formatting and parsing helper functions. This helper function will be deleted in the next major version.
   * Parse the jobWithoutTenantName from a job_without_tenant resource.
   *
   * @param {String} jobWithoutTenantName
   *   A fully-qualified path representing a job_without_tenant resources.
   * @returns {String} - A string representing the project.
   */
  matchProjectFromJobWithoutTenantName(jobWithoutTenantName) {
    return this._pathTemplates.jobWithoutTenantPathTemplate
      .match(jobWithoutTenantName)
      .project;
  }

  /**
   * @deprecated Multi-pattern resource names will have unified formatting and parsing helper functions. This helper function will be deleted in the next major version.
   * Parse the jobWithoutTenantName from a job_without_tenant resource.
   *
   * @param {String} jobWithoutTenantName
   *   A fully-qualified path representing a job_without_tenant resources.
   * @returns {String} - A string representing the jobs.
   */
  matchJobsFromJobWithoutTenantName(jobWithoutTenantName) {
    return this._pathTemplates.jobWithoutTenantPathTemplate
      .match(jobWithoutTenantName)
      .jobs;
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

  /**
   * Parse the tenantName from a tenant resource.
   *
   * @param {String} tenantName
   *   A fully-qualified path representing a tenant resources.
   * @returns {String} - A string representing the project.
   */
  matchProjectFromTenantName(tenantName) {
    return this._pathTemplates.tenantPathTemplate
      .match(tenantName)
      .project;
  }

  /**
   * Parse the tenantName from a tenant resource.
   *
   * @param {String} tenantName
   *   A fully-qualified path representing a tenant resources.
   * @returns {String} - A string representing the tenant.
   */
  matchTenantFromTenantName(tenantName) {
    return this._pathTemplates.tenantPathTemplate
      .match(tenantName)
      .tenant;
  }
}


module.exports = JobServiceClient;
