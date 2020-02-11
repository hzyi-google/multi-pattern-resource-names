# Copyright 2020 Google LLC
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

module Google
  module Devtools
    module Containeranalysis
      module V1beta1
        # A scan configuration specifies whether Cloud components in a project have a
        # particular type of analysis being run. For example, it can configure whether
        # vulnerability scanning is being done on Docker images or not.
        # @!attribute [rw] name
        #   @return [String]
        #     Output only. The name of the scan configuration in the form of
        #     `projects/[PROJECT_ID]/scanConfigs/[SCAN_CONFIG_ID]`.
        # @!attribute [rw] description
        #   @return [String]
        #     Output only. A human-readable description of what the scan configuration
        #     does.
        # @!attribute [rw] enabled
        #   @return [true, false]
        #     Whether the scan is enabled.
        # @!attribute [rw] create_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. The time this scan config was created.
        # @!attribute [rw] update_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. The time this scan config was last updated.
        class ScanConfig; end

        # Request to get a scan configuration.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the scan configuration in the form of
        #     `projects/[PROJECT_ID]/scanConfigs/[SCAN_CONFIG_ID]`.
        class GetScanConfigRequest; end

        # Request to list scan configurations.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The name of the project to list scan configurations for in the form of
        #     `projects/[PROJECT_ID]`.
        # @!attribute [rw] filter
        #   @return [String]
        #     Required. The filter expression.
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     The number of scan configs to return in the list.
        # @!attribute [rw] page_token
        #   @return [String]
        #     Token to provide to skip to a particular spot in the list.
        class ListScanConfigsRequest; end

        # Response for listing scan configurations.
        # @!attribute [rw] scan_configs
        #   @return [Array<Google::Devtools::Containeranalysis::V1beta1::ScanConfig>]
        #     The scan configurations requested.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     The next pagination token in the list response. It should be used as
        #     `page_token` for the following request. An empty value means no more
        #     results.
        class ListScanConfigsResponse; end

        # A request to update a scan configuration.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the scan configuration in the form of
        #     `projects/[PROJECT_ID]/scanConfigs/[SCAN_CONFIG_ID]`.
        # @!attribute [rw] scan_config
        #   @return [Google::Devtools::Containeranalysis::V1beta1::ScanConfig]
        #     Required. The updated scan configuration.
        class UpdateScanConfigRequest; end
      end
    end
  end
end