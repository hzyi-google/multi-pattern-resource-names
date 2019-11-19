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

module Google
  module Cloud
    module Securitycenter
      module V1beta1
        # User specified security marks that are attached to the parent Cloud Security
        # Command Center (Cloud SCC) resource. Security marks are scoped within a Cloud
        # SCC organization -- they can be modified and viewed by all users who have
        # proper permissions on the organization.
        # @!attribute [rw] name
        #   @return [String]
        #     The relative resource name of the SecurityMarks. See:
        #     https://cloud.google.com/apis/design/resource_names#relative_resource_name
        #     Examples:
        #     "organizations/123/assets/456/securityMarks"
        #     "organizations/123/sources/456/findings/789/securityMarks".
        # @!attribute [rw] marks
        #   @return [Hash{String => String}]
        #     Mutable user specified security marks belonging to the parent resource.
        #     Constraints are as follows:
        #     * Keys and values are treated as case insensitive
        #       * Keys must be alphanumeric and between 1 - 256 characters (inclusive)
        #       * Values have leading and trailing whitespace trimmed, remaining
        #         characters must be between 1 - 4096 characters (inclusive)
        class SecurityMarks; end
      end
    end
  end
end