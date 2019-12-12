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

/**
 * @namespace google
 */
/**
 * @namespace google.cloud
 */
/**
 * @namespace google.cloud.pubsub
 */
/**
 * @namespace google.cloud.pubsub.v1
 */

'use strict';

// Import the clients for each version supported by this package.
const gapic = Object.freeze({
  v1: require('./v1'),
});

/**
 * The `@google-cloud/pubsub` package has the following named exports:
 *
 * - `PublisherClient` - Reference to
 *   {@link v1.PublisherClient}
 * - `SubscriberClient` - Reference to
 *   {@link v1.SubscriberClient}
 * - `v1` - This is used for selecting or pinning a
 *   particular backend service version. It exports:
 *     - `PublisherClient` - Reference to
 *       {@link v1.PublisherClient}
 *     - `SubscriberClient` - Reference to
 *       {@link v1.SubscriberClient}
 *
 * @module {object} @google-cloud/pubsub
 * @alias nodejs-pubsub
 *
 * @example <caption>Install the client library with <a href="https://www.npmjs.com/">npm</a>:</caption>
 * npm install --save @google-cloud/pubsub
 *
 * @example <caption>Import the client library:</caption>
 * const pubsub = require('@google-cloud/pubsub');
 *
 * @example <caption>Create a client that uses <a href="https://goo.gl/64dyYX">Application Default Credentials (ADC)</a>:</caption>
 * const client = new pubsub.PublisherClient();
 *
 * @example <caption>Create a client with <a href="https://goo.gl/RXp6VL">explicit credentials</a>:</caption>
 * const client = new pubsub.PublisherClient({
 *   projectId: 'your-project-id',
 *   keyFilename: '/path/to/keyfile.json',
 * });
 */

/**
 * @type {object}
 * @property {constructor} PublisherClient
 *   Reference to {@link v1.PublisherClient}
 * @property {constructor} SubscriberClient
 *   Reference to {@link v1.SubscriberClient}
 */
module.exports = gapic.v1;

/**
 * @type {object}
 * @property {constructor} PublisherClient
 *   Reference to {@link v1.PublisherClient}
 * @property {constructor} SubscriberClient
 *   Reference to {@link v1.SubscriberClient}
 */
module.exports.v1 = gapic.v1;

// Alias `module.exports` as `module.exports.default`, for future-proofing.
module.exports.default = Object.assign({}, module.exports);
