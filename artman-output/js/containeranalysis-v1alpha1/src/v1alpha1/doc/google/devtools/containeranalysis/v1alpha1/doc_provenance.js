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

// Note: this file is purely for documentation. Any contents are not expected
// to be loaded as the JS file.

/**
 * Provenance of a build. Contains all information needed to verify the full
 * details about the build from source to completion.
 *
 * @property {string} id
 *   Unique identifier of the build.
 *
 * @property {string} projectId
 *   ID of the project.
 *
 * @property {Object[]} commands
 *   Commands requested by the build.
 *
 *   This object should have the same structure as [Command]{@link google.devtools.containeranalysis.v1alpha1.Command}
 *
 * @property {Object[]} builtArtifacts
 *   Output of the build.
 *
 *   This object should have the same structure as [Artifact]{@link google.devtools.containeranalysis.v1alpha1.Artifact}
 *
 * @property {Object} createTime
 *   Time at which the build was created.
 *
 *   This object should have the same structure as [Timestamp]{@link google.protobuf.Timestamp}
 *
 * @property {Object} startTime
 *   Time at which execution of the build was started.
 *
 *   This object should have the same structure as [Timestamp]{@link google.protobuf.Timestamp}
 *
 * @property {Object} finishTime
 *   Time at which execution of the build was finished.
 *
 *   This object should have the same structure as [Timestamp]{@link google.protobuf.Timestamp}
 *
 * @property {string} creator
 *   E-mail address of the user who initiated this build. Note that this was the
 *   user's e-mail address at the time the build was initiated; this address may
 *   not represent the same end-user for all time.
 *
 * @property {string} logsBucket
 *   Google Cloud Storage bucket where logs were written.
 *
 * @property {Object} sourceProvenance
 *   Details of the Source input to the build.
 *
 *   This object should have the same structure as [Source]{@link google.devtools.containeranalysis.v1alpha1.Source}
 *
 * @property {string} triggerId
 *   Trigger identifier if the build was triggered automatically; empty if not.
 *
 * @property {Object.<string, string>} buildOptions
 *   Special options applied to this build. This is a catch-all field where
 *   build providers can enter any desired additional details.
 *
 * @property {string} builderVersion
 *   Version string of the builder at the time this build was executed.
 *
 * @typedef BuildProvenance
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.BuildProvenance definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/provenance.proto}
 */
const BuildProvenance = {
  // This is for documentation. Actual contents will be loaded by gRPC.
};

/**
 * Source describes the location of the source used for the build.
 *
 * @property {Object} storageSource
 *   If provided, get the source from this location in in Google Cloud
 *   Storage.
 *
 *   This object should have the same structure as [StorageSource]{@link google.devtools.containeranalysis.v1alpha1.StorageSource}
 *
 * @property {Object} repoSource
 *   If provided, get source from this location in a Cloud Repo.
 *
 *   This object should have the same structure as [RepoSource]{@link google.devtools.containeranalysis.v1alpha1.RepoSource}
 *
 * @property {Object} artifactStorageSource
 *   If provided, the input binary artifacts for the build came from this
 *   location.
 *
 *   This object should have the same structure as [StorageSource]{@link google.devtools.containeranalysis.v1alpha1.StorageSource}
 *
 * @property {Object.<string, Object>} fileHashes
 *   Hash(es) of the build source, which can be used to verify that the original
 *   source integrity was maintained in the build.
 *
 *   The keys to this map are file paths used as build source and the values
 *   contain the hash values for those files.
 *
 *   If the build source came in a single package such as a gzipped tarfile
 *   (.tar.gz), the FileHash will be for the single path to that file.
 *
 * @property {Object} context
 *   If provided, the source code used for the build came from this location.
 *
 *   This object should have the same structure as [SourceContext]{@link google.devtools.containeranalysis.v1alpha1.SourceContext}
 *
 * @property {Object[]} additionalContexts
 *   If provided, some of the source code used for the build may be found in
 *   these locations, in the case where the source repository had multiple
 *   remotes or submodules. This list will not include the context specified in
 *   the context field.
 *
 *   This object should have the same structure as [SourceContext]{@link google.devtools.containeranalysis.v1alpha1.SourceContext}
 *
 * @typedef Source
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.Source definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/provenance.proto}
 */
const Source = {
  // This is for documentation. Actual contents will be loaded by gRPC.
};

/**
 * Container message for hashes of byte content of files, used in Source
 * messages to verify integrity of source input to the build.
 *
 * @property {Object[]} fileHash
 *   Collection of file hashes.
 *
 *   This object should have the same structure as [Hash]{@link google.devtools.containeranalysis.v1alpha1.Hash}
 *
 * @typedef FileHashes
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.FileHashes definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/provenance.proto}
 */
const FileHashes = {
  // This is for documentation. Actual contents will be loaded by gRPC.
};

/**
 * Container message for hash values.
 *
 * @property {number} type
 *   The type of hash that was performed.
 *
 *   The number should be among the values of [HashType]{@link google.devtools.containeranalysis.v1alpha1.HashType}
 *
 * @property {Buffer} value
 *   The hash value.
 *
 * @typedef Hash
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.Hash definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/provenance.proto}
 */
const Hash = {
  // This is for documentation. Actual contents will be loaded by gRPC.

  /**
   * Specifies the hash algorithm, if any.
   *
   * @enum {number}
   * @memberof google.devtools.containeranalysis.v1alpha1
   */
  HashType: {

    /**
     * No hash requested.
     */
    NONE: 0,

    /**
     * A sha256 hash.
     */
    SHA256: 1
  }
};

/**
 * StorageSource describes the location of the source in an archive file in
 * Google Cloud Storage.
 *
 * @property {string} bucket
 *   Google Cloud Storage bucket containing source (see [Bucket Name
 *   Requirements]
 *   (https://cloud.google.com/storage/docs/bucket-naming#requirements)).
 *
 * @property {string} object
 *   Google Cloud Storage object containing source.
 *
 * @property {number} generation
 *   Google Cloud Storage generation for the object.
 *
 * @typedef StorageSource
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.StorageSource definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/provenance.proto}
 */
const StorageSource = {
  // This is for documentation. Actual contents will be loaded by gRPC.
};

/**
 * RepoSource describes the location of the source in a Google Cloud Source
 * Repository.
 *
 * @property {string} projectId
 *   ID of the project that owns the repo.
 *
 * @property {string} repoName
 *   Name of the repo.
 *
 * @property {string} branchName
 *   Name of the branch to build.
 *
 * @property {string} tagName
 *   Name of the tag to build.
 *
 * @property {string} commitSha
 *   Explicit commit SHA to build.
 *
 * @typedef RepoSource
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.RepoSource definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/provenance.proto}
 */
const RepoSource = {
  // This is for documentation. Actual contents will be loaded by gRPC.
};

/**
 * Command describes a step performed as part of the build pipeline.
 *
 * @property {string} name
 *   Name of the command, as presented on the command line, or if the command is
 *   packaged as a Docker container, as presented to `docker pull`.
 *
 * @property {string[]} env
 *   Environment variables set before running this Command.
 *
 * @property {string[]} args
 *   Command-line arguments used when executing this Command.
 *
 * @property {string} dir
 *   Working directory (relative to project source root) used when running
 *   this Command.
 *
 * @property {string} id
 *   Optional unique identifier for this Command, used in wait_for to reference
 *   this Command as a dependency.
 *
 * @property {string[]} waitFor
 *   The ID(s) of the Command(s) that this Command depends on.
 *
 * @typedef Command
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.Command definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/provenance.proto}
 */
const Command = {
  // This is for documentation. Actual contents will be loaded by gRPC.
};

/**
 * Artifact describes a build product.
 *
 * @property {string} name
 *   Name of the artifact. This may be the path to a binary or jar file, or in
 *   the case of a container build, the name used to push the container image to
 *   Google Container Registry, as presented to `docker push`.
 *
 *   This field is deprecated in favor of the plural `names` field; it continues
 *   to exist here to allow existing BuildProvenance serialized to json in
 *   google.devtools.containeranalysis.v1alpha1.BuildDetails.provenance_bytes to
 *   deserialize back into proto.
 *
 * @property {string} checksum
 *   Hash or checksum value of a binary, or Docker Registry 2.0 digest of a
 *   container.
 *
 * @property {string} id
 *   Artifact ID, if any; for container images, this will be a URL by digest
 *   like gcr.io/projectID/imagename@sha256:123456
 *
 * @property {string[]} names
 *   Related artifact names. This may be the path to a binary or jar file, or in
 *   the case of a container build, the name used to push the container image to
 *   Google Container Registry, as presented to `docker push`. Note that a
 *   single Artifact ID can have multiple names, for example if two tags are
 *   applied to one image.
 *
 * @typedef Artifact
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.Artifact definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/provenance.proto}
 */
const Artifact = {
  // This is for documentation. Actual contents will be loaded by gRPC.
};