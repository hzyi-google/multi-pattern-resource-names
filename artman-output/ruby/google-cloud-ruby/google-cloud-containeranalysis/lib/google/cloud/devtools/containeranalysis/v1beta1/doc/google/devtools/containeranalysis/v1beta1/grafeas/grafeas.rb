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
    # An instance of an analysis type that has been found on a resource.
    # @!attribute [rw] name
    #   @return [String]
    #     Output only. The name of the occurrence in the form of
    #     `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
    # @!attribute [rw] resource
    #   @return [Grafeas::V1beta1::Resource]
    #     Required. Immutable. The resource for which the occurrence applies.
    # @!attribute [rw] note_name
    #   @return [String]
    #     Required. Immutable. The analysis note associated with this occurrence, in
    #     the form of `projects[PROVIDER_ID]/notes/[NOTE_ID]`. This field can be used
    #     as a filter in list requests.
    # @!attribute [rw] kind
    #   @return [Grafeas::V1beta1::NoteKind]
    #     Output only. This explicitly denotes which of the occurrence details are
    #     specified. This field can be used as a filter in list requests.
    # @!attribute [rw] remediation
    #   @return [String]
    #     A description of actions that can be taken to remedy the note.
    # @!attribute [rw] create_time
    #   @return [Google::Protobuf::Timestamp]
    #     Output only. The time this occurrence was created.
    # @!attribute [rw] update_time
    #   @return [Google::Protobuf::Timestamp]
    #     Output only. The time this occurrence was last updated.
    # @!attribute [rw] vulnerability
    #   @return [Grafeas::V1beta1::Vulnerability::Details]
    #     Describes a security vulnerability.
    # @!attribute [rw] build
    #   @return [Grafeas::V1beta1::Build::Details]
    #     Describes a verifiable build.
    # @!attribute [rw] derived_image
    #   @return [Grafeas::V1beta1::Image::Details]
    #     Describes how this resource derives from the basis in the associated
    #     note.
    # @!attribute [rw] installation
    #   @return [Grafeas::V1beta1::Package::Details]
    #     Describes the installation of a package on the linked resource.
    # @!attribute [rw] deployment
    #   @return [Grafeas::V1beta1::Deployment::Details]
    #     Describes the deployment of an artifact on a runtime.
    # @!attribute [rw] discovered
    #   @return [Grafeas::V1beta1::Discovery::Details]
    #     Describes when a resource was discovered.
    # @!attribute [rw] attestation
    #   @return [Grafeas::V1beta1::Attestation::Details]
    #     Describes an attestation of an artifact.
    class Occurrence; end

    # An entity that can have metadata. For example, a Docker image.
    # @!attribute [rw] name
    #   @return [String]
    #     The name of the resource. For example, the name of a Docker image -
    #     "Debian".
    # @!attribute [rw] uri
    #   @return [String]
    #     The unique URI of the resource. For example,
    #     `https://gcr.io/project/image@sha256:foo` for a Docker image.
    # @!attribute [rw] content_hash
    #   @return [Grafeas::V1beta1::Provenance::Hash]
    #     The hash of the resource content. For example, the Docker digest.
    class Resource; end

    # A type of analysis that can be done for a resource.
    # @!attribute [rw] name
    #   @return [String]
    #     Output only. The name of the note in the form of
    #     `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
    # @!attribute [rw] short_description
    #   @return [String]
    #     A one sentence description of this note.
    # @!attribute [rw] long_description
    #   @return [String]
    #     A detailed description of this note.
    # @!attribute [rw] kind
    #   @return [Grafeas::V1beta1::NoteKind]
    #     Output only. The type of analysis. This field can be used as a filter in
    #     list requests.
    # @!attribute [rw] related_url
    #   @return [Array<Grafeas::V1beta1::RelatedUrl>]
    #     URLs associated with this note.
    # @!attribute [rw] expiration_time
    #   @return [Google::Protobuf::Timestamp]
    #     Time of expiration for this note. Empty if note does not expire.
    # @!attribute [rw] create_time
    #   @return [Google::Protobuf::Timestamp]
    #     Output only. The time this note was created. This field can be used as a
    #     filter in list requests.
    # @!attribute [rw] update_time
    #   @return [Google::Protobuf::Timestamp]
    #     Output only. The time this note was last updated. This field can be used as
    #     a filter in list requests.
    # @!attribute [rw] related_note_names
    #   @return [Array<String>]
    #     Other notes related to this note.
    # @!attribute [rw] vulnerability
    #   @return [Grafeas::V1beta1::Vulnerability::Vulnerability]
    #     A note describing a package vulnerability.
    # @!attribute [rw] build
    #   @return [Grafeas::V1beta1::Build::Build]
    #     A note describing build provenance for a verifiable build.
    # @!attribute [rw] base_image
    #   @return [Grafeas::V1beta1::Image::Basis]
    #     A note describing a base image.
    # @!attribute [rw] package
    #   @return [Grafeas::V1beta1::Package::Package]
    #     A note describing a package hosted by various package managers.
    # @!attribute [rw] deployable
    #   @return [Grafeas::V1beta1::Deployment::Deployable]
    #     A note describing something that can be deployed.
    # @!attribute [rw] discovery
    #   @return [Grafeas::V1beta1::Discovery::Discovery]
    #     A note describing the initial analysis of a resource.
    # @!attribute [rw] attestation_authority
    #   @return [Grafeas::V1beta1::Attestation::Authority]
    #     A note describing an attestation role.
    class Note; end

    # Request to get an occurrence.
    # @!attribute [rw] name
    #   @return [String]
    #     The name of the occurrence in the form of
    #     `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
    class GetOccurrenceRequest; end

    # Request to list occurrences.
    # @!attribute [rw] parent
    #   @return [String]
    #     The name of the project to list occurrences for in the form of
    #     `projects/[PROJECT_ID]`.
    # @!attribute [rw] filter
    #   @return [String]
    #     The filter expression.
    # @!attribute [rw] page_size
    #   @return [Integer]
    #     Number of occurrences to return in the list.
    # @!attribute [rw] page_token
    #   @return [String]
    #     Token to provide to skip to a particular spot in the list.
    class ListOccurrencesRequest; end

    # Response for listing occurrences.
    # @!attribute [rw] occurrences
    #   @return [Array<Grafeas::V1beta1::Occurrence>]
    #     The occurrences requested.
    # @!attribute [rw] next_page_token
    #   @return [String]
    #     The next pagination token in the list response. It should be used as
    #     `page_token` for the following request. An empty value means no more
    #     results.
    class ListOccurrencesResponse; end

    # Request to delete a occurrence.
    # @!attribute [rw] name
    #   @return [String]
    #     The name of the occurrence in the form of
    #     `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
    class DeleteOccurrenceRequest; end

    # Request to create a new occurrence.
    # @!attribute [rw] parent
    #   @return [String]
    #     The name of the project in the form of `projects/[PROJECT_ID]`, under which
    #     the occurrence is to be created.
    # @!attribute [rw] occurrence
    #   @return [Grafeas::V1beta1::Occurrence]
    #     The occurrence to create.
    class CreateOccurrenceRequest; end

    # Request to update an occurrence.
    # @!attribute [rw] name
    #   @return [String]
    #     The name of the occurrence in the form of
    #     `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
    # @!attribute [rw] occurrence
    #   @return [Grafeas::V1beta1::Occurrence]
    #     The updated occurrence.
    # @!attribute [rw] update_mask
    #   @return [Google::Protobuf::FieldMask]
    #     The fields to update.
    class UpdateOccurrenceRequest; end

    # Request to get a note.
    # @!attribute [rw] name
    #   @return [String]
    #     The name of the note in the form of
    #     `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
    class GetNoteRequest; end

    # Request to get the note to which the specified occurrence is attached.
    # @!attribute [rw] name
    #   @return [String]
    #     The name of the occurrence in the form of
    #     `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
    class GetOccurrenceNoteRequest; end

    # Request to list notes.
    # @!attribute [rw] parent
    #   @return [String]
    #     The name of the project to list notes for in the form of
    #     `projects/[PROJECT_ID]`.
    # @!attribute [rw] filter
    #   @return [String]
    #     The filter expression.
    # @!attribute [rw] page_size
    #   @return [Integer]
    #     Number of notes to return in the list.
    # @!attribute [rw] page_token
    #   @return [String]
    #     Token to provide to skip to a particular spot in the list.
    class ListNotesRequest; end

    # Response for listing notes.
    # @!attribute [rw] notes
    #   @return [Array<Grafeas::V1beta1::Note>]
    #     The notes requested.
    # @!attribute [rw] next_page_token
    #   @return [String]
    #     The next pagination token in the list response. It should be used as
    #     `page_token` for the following request. An empty value means no more
    #     results.
    class ListNotesResponse; end

    # Request to delete a note.
    # @!attribute [rw] name
    #   @return [String]
    #     The name of the note in the form of
    #     `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
    class DeleteNoteRequest; end

    # Request to create a new note.
    # @!attribute [rw] parent
    #   @return [String]
    #     The name of the project in the form of `projects/[PROJECT_ID]`, under which
    #     the note is to be created.
    # @!attribute [rw] note_id
    #   @return [String]
    #     The ID to use for this note.
    # @!attribute [rw] note
    #   @return [Grafeas::V1beta1::Note]
    #     The note to create.
    class CreateNoteRequest; end

    # Request to update a note.
    # @!attribute [rw] name
    #   @return [String]
    #     The name of the note in the form of
    #     `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
    # @!attribute [rw] note
    #   @return [Grafeas::V1beta1::Note]
    #     The updated note.
    # @!attribute [rw] update_mask
    #   @return [Google::Protobuf::FieldMask]
    #     The fields to update.
    class UpdateNoteRequest; end

    # Request to list occurrences for a note.
    # @!attribute [rw] name
    #   @return [String]
    #     The name of the note to list occurrences for in the form of
    #     `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
    # @!attribute [rw] filter
    #   @return [String]
    #     The filter expression.
    # @!attribute [rw] page_size
    #   @return [Integer]
    #     Number of occurrences to return in the list.
    # @!attribute [rw] page_token
    #   @return [String]
    #     Token to provide to skip to a particular spot in the list.
    class ListNoteOccurrencesRequest; end

    # Response for listing occurrences for a note.
    # @!attribute [rw] occurrences
    #   @return [Array<Grafeas::V1beta1::Occurrence>]
    #     The occurrences attached to the specified note.
    # @!attribute [rw] next_page_token
    #   @return [String]
    #     Token to provide to skip to a particular spot in the list.
    class ListNoteOccurrencesResponse; end

    # Request to create notes in batch.
    # @!attribute [rw] parent
    #   @return [String]
    #     The name of the project in the form of `projects/[PROJECT_ID]`, under which
    #     the notes are to be created.
    # @!attribute [rw] notes
    #   @return [Hash{String => Grafeas::V1beta1::Note}]
    #     The notes to create.
    class BatchCreateNotesRequest; end

    # Response for creating notes in batch.
    # @!attribute [rw] notes
    #   @return [Array<Grafeas::V1beta1::Note>]
    #     The notes that were created.
    class BatchCreateNotesResponse; end

    # Request to create occurrences in batch.
    # @!attribute [rw] parent
    #   @return [String]
    #     The name of the project in the form of `projects/[PROJECT_ID]`, under which
    #     the occurrences are to be created.
    # @!attribute [rw] occurrences
    #   @return [Array<Grafeas::V1beta1::Occurrence>]
    #     The occurrences to create.
    class BatchCreateOccurrencesRequest; end

    # Response for creating occurrences in batch.
    # @!attribute [rw] occurrences
    #   @return [Array<Grafeas::V1beta1::Occurrence>]
    #     The occurrences that were created.
    class BatchCreateOccurrencesResponse; end

    # Request to get a vulnerability summary for some set of occurrences.
    # @!attribute [rw] parent
    #   @return [String]
    #     The name of the project to get a vulnerability summary for in the form of
    #     `projects/[PROJECT_ID]`.
    # @!attribute [rw] filter
    #   @return [String]
    #     The filter expression.
    class GetVulnerabilityOccurrencesSummaryRequest; end

    # A summary of how many vulnerability occurrences there are per resource and
    # severity type.
    # @!attribute [rw] counts
    #   @return [Array<Grafeas::V1beta1::VulnerabilityOccurrencesSummary::FixableTotalByDigest>]
    #     A listing by resource of the number of fixable and total vulnerabilities.
    class VulnerabilityOccurrencesSummary
      # Per resource and severity counts of fixable and total vulnerabilites.
      # @!attribute [rw] resource
      #   @return [Grafeas::V1beta1::Resource]
      #     The affected resource.
      # @!attribute [rw] severity
      #   @return [Grafeas::V1beta1::Vulnerability::Severity]
      #     The severity for this count. SEVERITY_UNSPECIFIED indicates total across
      #     all severities.
      # @!attribute [rw] fixable_count
      #   @return [Integer]
      #     The number of fixable vulnerabilities associated with this resource.
      # @!attribute [rw] total_count
      #   @return [Integer]
      #     The total number of vulnerabilities associated with this resource.
      class FixableTotalByDigest; end
    end
  end
end