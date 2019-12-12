# Copyright 2019 Google LLC
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     https://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

module Grafeas
  module V1beta1
    module Provenance
      # Provenance of a build. Contains all information needed to verify the full
      # details about the build from source to completion.
      # @!attribute [rw] id
      #   @return [String]
      #     Unique identifier of the build.
      # @!attribute [rw] project_id
      #   @return [String]
      #     ID of the project.
      # @!attribute [rw] commands
      #   @return [Array<Grafeas::V1beta1::Provenance::Command>]
      #     Commands requested by the build.
      # @!attribute [rw] built_artifacts
      #   @return [Array<Grafeas::V1beta1::Provenance::Artifact>]
      #     Output of the build.
      # @!attribute [rw] create_time
      #   @return [Google::Protobuf::Timestamp]
      #     Time at which the build was created.
      # @!attribute [rw] start_time
      #   @return [Google::Protobuf::Timestamp]
      #     Time at which execution of the build was started.
      # @!attribute [rw] end_time
      #   @return [Google::Protobuf::Timestamp]
      #     Time at which execution of the build was finished.
      # @!attribute [rw] creator
      #   @return [String]
      #     E-mail address of the user who initiated this build. Note that this was the
      #     user's e-mail address at the time the build was initiated; this address may
      #     not represent the same end-user for all time.
      # @!attribute [rw] logs_uri
      #   @return [String]
      #     URI where any logs for this provenance were written.
      # @!attribute [rw] source_provenance
      #   @return [Grafeas::V1beta1::Provenance::Source]
      #     Details of the Source input to the build.
      # @!attribute [rw] trigger_id
      #   @return [String]
      #     Trigger identifier if the build was triggered automatically; empty if not.
      # @!attribute [rw] build_options
      #   @return [Hash{String => String}]
      #     Special options applied to this build. This is a catch-all field where
      #     build providers can enter any desired additional details.
      # @!attribute [rw] builder_version
      #   @return [String]
      #     Version string of the builder at the time this build was executed.
      class BuildProvenance; end

      # Source describes the location of the source used for the build.
      # @!attribute [rw] artifact_storage_source_uri
      #   @return [String]
      #     If provided, the input binary artifacts for the build came from this
      #     location.
      # @!attribute [rw] file_hashes
      #   @return [Hash{String => Grafeas::V1beta1::Provenance::FileHashes}]
      #     Hash(es) of the build source, which can be used to verify that the original
      #     source integrity was maintained in the build.
      #
      #     The keys to this map are file paths used as build source and the values
      #     contain the hash values for those files.
      #
      #     If the build source came in a single package such as a gzipped tarfile
      #     (.tar.gz), the FileHash will be for the single path to that file.
      # @!attribute [rw] context
      #   @return [Grafeas::V1beta1::Source::SourceContext]
      #     If provided, the source code used for the build came from this location.
      # @!attribute [rw] additional_contexts
      #   @return [Array<Grafeas::V1beta1::Source::SourceContext>]
      #     If provided, some of the source code used for the build may be found in
      #     these locations, in the case where the source repository had multiple
      #     remotes or submodules. This list will not include the context specified in
      #     the context field.
      class Source; end

      # Container message for hashes of byte content of files, used in Source
      # messages to verify integrity of source input to the build.
      # @!attribute [rw] file_hash
      #   @return [Array<Grafeas::V1beta1::Provenance::Hash>]
      #     Collection of file hashes.
      class FileHashes; end

      # Container message for hash values.
      # @!attribute [rw] type
      #   @return [Grafeas::V1beta1::Provenance::Hash::HashType]
      #     The type of hash that was performed.
      # @!attribute [rw] value
      #   @return [String]
      #     The hash value.
      class Hash
        # Specifies the hash algorithm, if any.
        module HashType
          # Unknown.
          HASH_TYPE_UNSPECIFIED = 0

          # A SHA-256 hash.
          SHA256 = 1
        end
      end

      # Command describes a step performed as part of the build pipeline.
      # @!attribute [rw] name
      #   @return [String]
      #     Name of the command, as presented on the command line, or if the command is
      #     packaged as a Docker container, as presented to `docker pull`.
      # @!attribute [rw] env
      #   @return [Array<String>]
      #     Environment variables set before running this command.
      # @!attribute [rw] args
      #   @return [Array<String>]
      #     Command-line arguments used when executing this command.
      # @!attribute [rw] dir
      #   @return [String]
      #     Working directory (relative to project source root) used when running this
      #     command.
      # @!attribute [rw] id
      #   @return [String]
      #     Optional unique identifier for this command, used in wait_for to reference
      #     this command as a dependency.
      # @!attribute [rw] wait_for
      #   @return [Array<String>]
      #     The ID(s) of the command(s) that this command depends on.
      class Command; end

      # Artifact describes a build product.
      # @!attribute [rw] checksum
      #   @return [String]
      #     Hash or checksum value of a binary, or Docker Registry 2.0 digest of a
      #     container.
      # @!attribute [rw] id
      #   @return [String]
      #     Artifact ID, if any; for container images, this will be a URL by digest
      #     like `gcr.io/projectID/imagename@sha256:123456`.
      # @!attribute [rw] names
      #   @return [Array<String>]
      #     Related artifact names. This may be the path to a binary or jar file, or in
      #     the case of a container build, the name used to push the container image to
      #     Google Container Registry, as presented to `docker push`. Note that a
      #     single Artifact ID can have multiple names, for example if two tags are
      #     applied to one image.
      class Artifact; end
    end
  end
end