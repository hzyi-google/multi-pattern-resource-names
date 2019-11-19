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
    # Metadata for any related URL information.
    # @!attribute [rw] url
    #   @return [String]
    #     Specific URL associated with the resource.
    # @!attribute [rw] label
    #   @return [String]
    #     Label to describe usage of the URL.
    class RelatedUrl; end

    # Kind represents the kinds of notes supported.
    module NoteKind
      # Unknown.
      NOTE_KIND_UNSPECIFIED = 0

      # The note and occurrence represent a package vulnerability.
      VULNERABILITY = 1

      # The note and occurrence assert build provenance.
      BUILD = 2

      # This represents an image basis relationship.
      IMAGE = 3

      # This represents a package installed via a package manager.
      PACKAGE = 4

      # The note and occurrence track deployment events.
      DEPLOYMENT = 5

      # The note and occurrence track the initial discovery status of a resource.
      DISCOVERY = 6

      # This represents a logical "role" that can attest to artifacts.
      ATTESTATION = 7
    end
  end
end