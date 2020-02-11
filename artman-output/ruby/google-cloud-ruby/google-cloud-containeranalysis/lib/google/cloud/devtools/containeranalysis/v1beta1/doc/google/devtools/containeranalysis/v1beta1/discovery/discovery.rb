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

module Grafeas
  module V1beta1
    module Discovery
      # A note that indicates a type of analysis a provider would perform. This note
      # exists in a provider's project. A `Discovery` occurrence is created in a
      # consumer's project at the start of analysis.
      # @!attribute [rw] analysis_kind
      #   @return [Grafeas::V1beta1::NoteKind]
      #     Required. Immutable. The kind of analysis that is handled by this
      #     discovery.
      class Discovery; end

      # Details of a discovery occurrence.
      # @!attribute [rw] discovered
      #   @return [Grafeas::V1beta1::Discovery::Discovered]
      #     Required. Analysis status for the discovered resource.
      class Details; end

      # Provides information about the analysis status of a discovered resource.
      # @!attribute [rw] continuous_analysis
      #   @return [Grafeas::V1beta1::Discovery::Discovered::ContinuousAnalysis]
      #     Whether the resource is continuously analyzed.
      # @!attribute [rw] last_analysis_time
      #   @return [Google::Protobuf::Timestamp]
      #     The last time continuous analysis was done for this resource.
      # @!attribute [rw] analysis_status
      #   @return [Grafeas::V1beta1::Discovery::Discovered::AnalysisStatus]
      #     The status of discovery for the resource.
      # @!attribute [rw] analysis_status_error
      #   @return [Google::Rpc::Status]
      #     When an error is encountered this will contain a LocalizedMessage under
      #     details to show to the user. The LocalizedMessage is output only and
      #     populated by the API.
      class Discovered
        # Analysis status for a resource. Currently for initial analysis only (not
        # updated in continuous analysis).
        module AnalysisStatus
          # Unknown.
          ANALYSIS_STATUS_UNSPECIFIED = 0

          # Resource is known but no action has been taken yet.
          PENDING = 1

          # Resource is being analyzed.
          SCANNING = 2

          # Analysis has finished successfully.
          FINISHED_SUCCESS = 3

          # Analysis has finished unsuccessfully, the analysis itself is in a bad
          # state.
          FINISHED_FAILED = 4

          # The resource is known not to be supported
          FINISHED_UNSUPPORTED = 5
        end

        # Whether the resource is continuously analyzed.
        module ContinuousAnalysis
          # Unknown.
          CONTINUOUS_ANALYSIS_UNSPECIFIED = 0

          # The resource is continuously analyzed.
          ACTIVE = 1

          # The resource is ignored for continuous analysis.
          INACTIVE = 2
        end
      end
    end
  end
end