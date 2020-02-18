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

/**
 * @namespace google
 */
/**
 * @namespace google.cloud
 */
/**
 * @namespace google.cloud.logging
 */
/**
 * @namespace google.cloud.logging.v2
 */

'use strict';

// Import the clients for each version supported by this package.
const gapic = Object.freeze({
  v2: require('./v2'),
});

/**
 * The `@google-cloud/logging` package has the following named exports:
 *
 * - `MetricsServiceV2Client` - Reference to
 *   {@link v2.MetricsServiceV2Client}
 * - `ConfigServiceV2Client` - Reference to
 *   {@link v2.ConfigServiceV2Client}
 * - `LoggingServiceV2Client` - Reference to
 *   {@link v2.LoggingServiceV2Client}
 * - `v2` - This is used for selecting or pinning a
 *   particular backend service version. It exports:
 *     - `MetricsServiceV2Client` - Reference to
 *       {@link v2.MetricsServiceV2Client}
 *     - `ConfigServiceV2Client` - Reference to
 *       {@link v2.ConfigServiceV2Client}
 *     - `LoggingServiceV2Client` - Reference to
 *       {@link v2.LoggingServiceV2Client}
 *
 * @module {object} @google-cloud/logging
 * @alias nodejs-logging
 *
 * @example <caption>Install the client library with <a href="https://www.npmjs.com/">npm</a>:</caption>
 * npm install --save @google-cloud/logging
 *
 * @example <caption>Import the client library:</caption>
 * const logging = require('@google-cloud/logging');
 *
 * @example <caption>Create a client that uses <a href="https://goo.gl/64dyYX">Application Default Credentials (ADC)</a>:</caption>
 * const client = new logging.MetricsServiceV2Client();
 *
 * @example <caption>Create a client with <a href="https://goo.gl/RXp6VL">explicit credentials</a>:</caption>
 * const client = new logging.MetricsServiceV2Client({
 *   projectId: 'your-project-id',
 *   keyFilename: '/path/to/keyfile.json',
 * });
 */

/**
 * @type {object}
 * @property {constructor} MetricsServiceV2Client
 *   Reference to {@link v2.MetricsServiceV2Client}
 * @property {constructor} ConfigServiceV2Client
 *   Reference to {@link v2.ConfigServiceV2Client}
 * @property {constructor} LoggingServiceV2Client
 *   Reference to {@link v2.LoggingServiceV2Client}
 */
module.exports = gapic.v2;

/**
 * @type {object}
 * @property {constructor} MetricsServiceV2Client
 *   Reference to {@link v2.MetricsServiceV2Client}
 * @property {constructor} ConfigServiceV2Client
 *   Reference to {@link v2.ConfigServiceV2Client}
 * @property {constructor} LoggingServiceV2Client
 *   Reference to {@link v2.LoggingServiceV2Client}
 */
module.exports.v2 = gapic.v2;

// Alias `module.exports` as `module.exports.default`, for future-proofing.
module.exports.default = Object.assign({}, module.exports);
