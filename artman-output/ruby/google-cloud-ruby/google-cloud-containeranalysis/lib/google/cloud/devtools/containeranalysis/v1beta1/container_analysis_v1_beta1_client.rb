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
#
# EDITING INSTRUCTIONS
# This file was generated from the file
# https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1beta1/containeranalysis.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/devtools/containeranalysis/v1beta1/containeranalysis_pb"
require "google/cloud/devtools/containeranalysis/v1beta1/credentials"

module Google
  module Cloud
    module Devtools
      module Containeranalysis
        module V1beta1
          # Retrieves analysis results of Cloud components such as Docker container
          # images. The Container Analysis API is an implementation of the
          # [Grafeas](https://cloud.google.comgrafeas.io) API.
          #
          # Analysis results are stored as a series of occurrences. An `Occurrence`
          # contains information about a specific analysis instance on a resource. An
          # occurrence refers to a `Note`. A note contains details describing the
          # analysis and is generally stored in a separate project, called a `Provider`.
          # Multiple occurrences can refer to the same note.
          #
          # For example, an SSL vulnerability could affect multiple images. In this case,
          # there would be one note for the vulnerability and an occurrence for each
          # image with the vulnerability referring to that note.
          #
          # @!attribute [r] container_analysis_v1_beta1_stub
          #   @return [Google::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1::Stub]
          class ContainerAnalysisV1Beta1Client
            attr_reader :container_analysis_v1_beta1_stub

            # The default address of the service.
            SERVICE_ADDRESS = "containeranalysis.googleapis.com".freeze

            # The default port of the service.
            DEFAULT_SERVICE_PORT = 443

            # The default set of gRPC interceptors.
            GRPC_INTERCEPTORS = []

            DEFAULT_TIMEOUT = 30

            PAGE_DESCRIPTORS = {
              "list_scan_configs" => Google::Gax::PageDescriptor.new(
                "page_token",
                "next_page_token",
                "scan_configs")
            }.freeze

            private_constant :PAGE_DESCRIPTORS

            # The scopes needed to make gRPC calls to all of the methods defined in
            # this service.
            ALL_SCOPES = [
              "https://www.googleapis.com/auth/cloud-platform"
            ].freeze


            NOTE_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/notes/{note}"
            )

            private_constant :NOTE_PATH_TEMPLATE

            OCCURRENCE_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/occurrences/{occurrence}"
            )

            private_constant :OCCURRENCE_PATH_TEMPLATE

            PROJECT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}"
            )

            private_constant :PROJECT_PATH_TEMPLATE

            SCAN_CONFIG_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/scanConfigs/{scan_config}"
            )

            private_constant :SCAN_CONFIG_PATH_TEMPLATE

            # Returns a fully-qualified note resource name string.
            # @param project [String]
            # @param note [String]
            # @return [String]
            def self.note_path project, note
              NOTE_PATH_TEMPLATE.render(
                :"project" => project,
                :"note" => note
              )
            end

            # Returns a fully-qualified occurrence resource name string.
            # @param project [String]
            # @param occurrence [String]
            # @return [String]
            def self.occurrence_path project, occurrence
              OCCURRENCE_PATH_TEMPLATE.render(
                :"project" => project,
                :"occurrence" => occurrence
              )
            end

            # Returns a fully-qualified project resource name string.
            # @param project [String]
            # @return [String]
            def self.project_path project
              PROJECT_PATH_TEMPLATE.render(
                :"project" => project
              )
            end

            # Returns a fully-qualified scan_config resource name string.
            # @param project [String]
            # @param scan_config [String]
            # @return [String]
            def self.scan_config_path project, scan_config
              SCAN_CONFIG_PATH_TEMPLATE.render(
                :"project" => project,
                :"scan_config" => scan_config
              )
            end

            # @param credentials [Google::Auth::Credentials, String, Hash, GRPC::Core::Channel, GRPC::Core::ChannelCredentials, Proc]
            #   Provides the means for authenticating requests made by the client. This parameter can
            #   be many types.
            #   A `Google::Auth::Credentials` uses a the properties of its represented keyfile for
            #   authenticating requests made by this client.
            #   A `String` will be treated as the path to the keyfile to be used for the construction of
            #   credentials for this client.
            #   A `Hash` will be treated as the contents of a keyfile to be used for the construction of
            #   credentials for this client.
            #   A `GRPC::Core::Channel` will be used to make calls through.
            #   A `GRPC::Core::ChannelCredentials` for the setting up the RPC client. The channel credentials
            #   should already be composed with a `GRPC::Core::CallCredentials` object.
            #   A `Proc` will be used as an updater_proc for the Grpc channel. The proc transforms the
            #   metadata for requests, generally, to give OAuth credentials.
            # @param scopes [Array<String>]
            #   The OAuth scopes for this service. This parameter is ignored if
            #   an updater_proc is supplied.
            # @param client_config [Hash]
            #   A Hash for call options for each method. See
            #   Google::Gax#construct_settings for the structure of
            #   this data. Falls back to the default config if not specified
            #   or the specified config is missing data points.
            # @param timeout [Numeric]
            #   The default timeout, in seconds, for calls made through this client.
            # @param metadata [Hash]
            #   Default metadata to be sent with each request. This can be overridden on a per call basis.
            # @param exception_transformer [Proc]
            #   An optional proc that intercepts any exceptions raised during an API call to inject
            #   custom error handling.
            def initialize \
                credentials: nil,
                scopes: ALL_SCOPES,
                client_config: {},
                timeout: DEFAULT_TIMEOUT,
                metadata: nil,
                exception_transformer: nil,
                lib_name: nil,
                lib_version: ""
              # These require statements are intentionally placed here to initialize
              # the gRPC module only when it's required.
              # See https://github.com/googleapis/toolkit/issues/446
              require "google/gax/grpc"
              require "google/devtools/containeranalysis/v1beta1/containeranalysis_services_pb"

              credentials ||= Google::Cloud::Devtools::Containeranalysis::V1beta1::Credentials.default

              if credentials.is_a?(String) || credentials.is_a?(Hash)
                updater_proc = Google::Cloud::Devtools::Containeranalysis::V1beta1::Credentials.new(credentials).updater_proc
              end
              if credentials.is_a?(GRPC::Core::Channel)
                channel = credentials
              end
              if credentials.is_a?(GRPC::Core::ChannelCredentials)
                chan_creds = credentials
              end
              if credentials.is_a?(Proc)
                updater_proc = credentials
              end
              if credentials.is_a?(Google::Auth::Credentials)
                updater_proc = credentials.updater_proc
              end

              package_version = Gem.loaded_specs['google-cloud-devtools-containeranalysis'].version.version

              google_api_client = "gl-ruby/#{RUBY_VERSION}"
              google_api_client << " #{lib_name}/#{lib_version}" if lib_name
              google_api_client << " gapic/#{package_version} gax/#{Google::Gax::VERSION}"
              google_api_client << " grpc/#{GRPC::VERSION}"
              google_api_client.freeze

              headers = { :"x-goog-api-client" => google_api_client }
              headers.merge!(metadata) unless metadata.nil?
              client_config_file = Pathname.new(__dir__).join(
                "container_analysis_v1_beta1_client_config.json"
              )
              defaults = client_config_file.open do |f|
                Google::Gax.construct_settings(
                  "google.devtools.containeranalysis.v1beta1.ContainerAnalysisV1Beta1",
                  JSON.parse(f.read),
                  client_config,
                  Google::Gax::Grpc::STATUS_CODE_NAMES,
                  timeout,
                  page_descriptors: PAGE_DESCRIPTORS,
                  errors: Google::Gax::Grpc::API_ERRORS,
                  metadata: headers
                )
              end

              # Allow overriding the service path/port in subclasses.
              service_path = self.class::SERVICE_ADDRESS
              port = self.class::DEFAULT_SERVICE_PORT
              interceptors = self.class::GRPC_INTERCEPTORS
              @container_analysis_v1_beta1_stub = Google::Gax::Grpc.create_stub(
                service_path,
                port,
                chan_creds: chan_creds,
                channel: channel,
                updater_proc: updater_proc,
                scopes: scopes,
                interceptors: interceptors,
                &Google::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1::Stub.method(:new)
              )

              @set_iam_policy = Google::Gax.create_api_call(
                @container_analysis_v1_beta1_stub.method(:set_iam_policy),
                defaults["set_iam_policy"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'resource' => request.resource}
                end
              )
              @get_iam_policy = Google::Gax.create_api_call(
                @container_analysis_v1_beta1_stub.method(:get_iam_policy),
                defaults["get_iam_policy"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'resource' => request.resource}
                end
              )
              @test_iam_permissions = Google::Gax.create_api_call(
                @container_analysis_v1_beta1_stub.method(:test_iam_permissions),
                defaults["test_iam_permissions"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'resource' => request.resource}
                end
              )
              @get_scan_config = Google::Gax.create_api_call(
                @container_analysis_v1_beta1_stub.method(:get_scan_config),
                defaults["get_scan_config"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @list_scan_configs = Google::Gax.create_api_call(
                @container_analysis_v1_beta1_stub.method(:list_scan_configs),
                defaults["list_scan_configs"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @update_scan_config = Google::Gax.create_api_call(
                @container_analysis_v1_beta1_stub.method(:update_scan_config),
                defaults["update_scan_config"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
            end

            # Service calls

            # Sets the access control policy on the specified note or occurrence.
            # Requires `containeranalysis.notes.setIamPolicy` or
            # `containeranalysis.occurrences.setIamPolicy` permission if the resource is
            # a note or an occurrence, respectively.
            #
            # The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
            # notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
            # occurrences.
            #
            # @param resource [String]
            #   REQUIRED: The resource for which the policy is being specified.
            #   See the operation documentation for the appropriate value for this field.
            # @param policy [Google::Iam::V1::Policy | Hash]
            #   REQUIRED: The complete policy to be applied to the `resource`. The size of
            #   the policy is limited to a few 10s of KB. An empty policy is a
            #   valid policy but certain Cloud Platform services (such as Projects)
            #   might reject them.
            #   A hash of the same form as `Google::Iam::V1::Policy`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Iam::V1::Policy]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Iam::V1::Policy]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/devtools/containeranalysis"
            #
            #   container_analysis_v1_beta1_client = Google::Cloud::Devtools::Containeranalysis::ContainerAnalysisV1Beta1.new(version: :v1beta1)
            #   formatted_resource = Google::Cloud::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1Client.note_path("[PROJECT]", "[NOTE]")
            #
            #   # TODO: Initialize `policy`:
            #   policy = {}
            #   response = container_analysis_v1_beta1_client.set_iam_policy(formatted_resource, policy)

            def set_iam_policy \
                resource,
                policy,
                options: nil,
                &block
              req = {
                resource: resource,
                policy: policy
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Iam::V1::SetIamPolicyRequest)
              @set_iam_policy.call(req, options, &block)
            end

            # Gets the access control policy for a note or an occurrence resource.
            # Requires `containeranalysis.notes.setIamPolicy` or
            # `containeranalysis.occurrences.setIamPolicy` permission if the resource is
            # a note or occurrence, respectively.
            #
            # The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
            # notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
            # occurrences.
            #
            # @param resource [String]
            #   REQUIRED: The resource for which the policy is being requested.
            #   See the operation documentation for the appropriate value for this field.
            # @param options_ [Google::Iam::V1::GetPolicyOptions | Hash]
            #   OPTIONAL: A `GetPolicyOptions` object for specifying options to
            #   `GetIamPolicy`. This field is only used by Cloud IAM.
            #   A hash of the same form as `Google::Iam::V1::GetPolicyOptions`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Iam::V1::Policy]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Iam::V1::Policy]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/devtools/containeranalysis"
            #
            #   container_analysis_v1_beta1_client = Google::Cloud::Devtools::Containeranalysis::ContainerAnalysisV1Beta1.new(version: :v1beta1)
            #   formatted_resource = Google::Cloud::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1Client.note_path("[PROJECT]", "[NOTE]")
            #   response = container_analysis_v1_beta1_client.get_iam_policy(formatted_resource)

            def get_iam_policy \
                resource,
                options_: nil,
                options: nil,
                &block
              req = {
                resource: resource,
                options: options_
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Iam::V1::GetIamPolicyRequest)
              @get_iam_policy.call(req, options, &block)
            end

            # Returns the permissions that a caller has on the specified note or
            # occurrence. Requires list permission on the project (for example,
            # `containeranalysis.notes.list`).
            #
            # The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
            # notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
            # occurrences.
            #
            # @param resource [String]
            #   REQUIRED: The resource for which the policy detail is being requested.
            #   See the operation documentation for the appropriate value for this field.
            # @param permissions [Array<String>]
            #   The set of permissions to check for the `resource`. Permissions with
            #   wildcards (such as '*' or 'storage.*') are not allowed. For more
            #   information see
            #   [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Iam::V1::TestIamPermissionsResponse]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Iam::V1::TestIamPermissionsResponse]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/devtools/containeranalysis"
            #
            #   container_analysis_v1_beta1_client = Google::Cloud::Devtools::Containeranalysis::ContainerAnalysisV1Beta1.new(version: :v1beta1)
            #   formatted_resource = Google::Cloud::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1Client.note_path("[PROJECT]", "[NOTE]")
            #
            #   # TODO: Initialize `permissions`:
            #   permissions = []
            #   response = container_analysis_v1_beta1_client.test_iam_permissions(formatted_resource, permissions)

            def test_iam_permissions \
                resource,
                permissions,
                options: nil,
                &block
              req = {
                resource: resource,
                permissions: permissions
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Iam::V1::TestIamPermissionsRequest)
              @test_iam_permissions.call(req, options, &block)
            end

            # Gets the specified scan configuration.
            #
            # @param name [String]
            #   The name of the scan configuration in the form of
            #   `projects/[PROJECT_ID]/scanConfigs/[SCAN_CONFIG_ID]`.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Devtools::Containeranalysis::V1beta1::ScanConfig]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Devtools::Containeranalysis::V1beta1::ScanConfig]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/devtools/containeranalysis"
            #
            #   container_analysis_v1_beta1_client = Google::Cloud::Devtools::Containeranalysis::ContainerAnalysisV1Beta1.new(version: :v1beta1)
            #   formatted_name = Google::Cloud::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1Client.scan_config_path("[PROJECT]", "[SCAN_CONFIG]")
            #   response = container_analysis_v1_beta1_client.get_scan_config(formatted_name)

            def get_scan_config \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Devtools::Containeranalysis::V1beta1::GetScanConfigRequest)
              @get_scan_config.call(req, options, &block)
            end

            # Lists scan configurations for the specified project.
            #
            # @param parent [String]
            #   The name of the project to list scan configurations for in the form of
            #   `projects/[PROJECT_ID]`.
            # @param filter [String]
            #   The filter expression.
            # @param page_size [Integer]
            #   The maximum number of resources contained in the underlying API
            #   response. If page streaming is performed per-resource, this
            #   parameter does not affect the return value. If page streaming is
            #   performed per-page, this determines the maximum number of
            #   resources in a page.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Gax::PagedEnumerable<Google::Devtools::Containeranalysis::V1beta1::ScanConfig>]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Gax::PagedEnumerable<Google::Devtools::Containeranalysis::V1beta1::ScanConfig>]
            #   An enumerable of Google::Devtools::Containeranalysis::V1beta1::ScanConfig instances.
            #   See Google::Gax::PagedEnumerable documentation for other
            #   operations such as per-page iteration or access to the response
            #   object.
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/devtools/containeranalysis"
            #
            #   container_analysis_v1_beta1_client = Google::Cloud::Devtools::Containeranalysis::ContainerAnalysisV1Beta1.new(version: :v1beta1)
            #   formatted_parent = Google::Cloud::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1Client.project_path("[PROJECT]")
            #
            #   # Iterate over all results.
            #   container_analysis_v1_beta1_client.list_scan_configs(formatted_parent).each do |element|
            #     # Process element.
            #   end
            #
            #   # Or iterate over results one page at a time.
            #   container_analysis_v1_beta1_client.list_scan_configs(formatted_parent).each_page do |page|
            #     # Process each page at a time.
            #     page.each do |element|
            #       # Process element.
            #     end
            #   end

            def list_scan_configs \
                parent,
                filter: nil,
                page_size: nil,
                options: nil,
                &block
              req = {
                parent: parent,
                filter: filter,
                page_size: page_size
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Devtools::Containeranalysis::V1beta1::ListScanConfigsRequest)
              @list_scan_configs.call(req, options, &block)
            end

            # Updates the specified scan configuration.
            #
            # @param name [String]
            #   The name of the scan configuration in the form of
            #   `projects/[PROJECT_ID]/scanConfigs/[SCAN_CONFIG_ID]`.
            # @param scan_config [Google::Devtools::Containeranalysis::V1beta1::ScanConfig | Hash]
            #   The updated scan configuration.
            #   A hash of the same form as `Google::Devtools::Containeranalysis::V1beta1::ScanConfig`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Devtools::Containeranalysis::V1beta1::ScanConfig]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Devtools::Containeranalysis::V1beta1::ScanConfig]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/devtools/containeranalysis"
            #
            #   container_analysis_v1_beta1_client = Google::Cloud::Devtools::Containeranalysis::ContainerAnalysisV1Beta1.new(version: :v1beta1)
            #   formatted_name = Google::Cloud::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1Client.scan_config_path("[PROJECT]", "[SCAN_CONFIG]")
            #
            #   # TODO: Initialize `scan_config`:
            #   scan_config = {}
            #   response = container_analysis_v1_beta1_client.update_scan_config(formatted_name, scan_config)

            def update_scan_config \
                name,
                scan_config,
                options: nil,
                &block
              req = {
                name: name,
                scan_config: scan_config
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Devtools::Containeranalysis::V1beta1::UpdateScanConfigRequest)
              @update_scan_config.call(req, options, &block)
            end
          end
        end
      end
    end
  end
end
