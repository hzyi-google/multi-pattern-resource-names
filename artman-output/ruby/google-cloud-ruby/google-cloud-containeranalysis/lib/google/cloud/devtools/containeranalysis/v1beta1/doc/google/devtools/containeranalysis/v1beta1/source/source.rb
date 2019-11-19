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
    module Source
      # A SourceContext is a reference to a tree of files. A SourceContext together
      # with a path point to a unique revision of a single file or directory.
      # @!attribute [rw] cloud_repo
      #   @return [Grafeas::V1beta1::Source::CloudRepoSourceContext]
      #     A SourceContext referring to a revision in a Google Cloud Source Repo.
      # @!attribute [rw] gerrit
      #   @return [Grafeas::V1beta1::Source::GerritSourceContext]
      #     A SourceContext referring to a Gerrit project.
      # @!attribute [rw] git
      #   @return [Grafeas::V1beta1::Source::GitSourceContext]
      #     A SourceContext referring to any third party Git repo (e.g., GitHub).
      # @!attribute [rw] labels
      #   @return [Hash{String => String}]
      #     Labels with user defined metadata.
      class SourceContext; end

      # An alias to a repo revision.
      # @!attribute [rw] kind
      #   @return [Grafeas::V1beta1::Source::AliasContext::Kind]
      #     The alias kind.
      # @!attribute [rw] name
      #   @return [String]
      #     The alias name.
      class AliasContext
        # The type of an alias.
        module Kind
          # Unknown.
          KIND_UNSPECIFIED = 0

          # Git tag.
          FIXED = 1

          # Git branch.
          MOVABLE = 2

          # Used to specify non-standard aliases. For example, if a Git repo has a
          # ref named "refs/foo/bar".
          OTHER = 4
        end
      end

      # A CloudRepoSourceContext denotes a particular revision in a Google Cloud
      # Source Repo.
      # @!attribute [rw] repo_id
      #   @return [Grafeas::V1beta1::Source::RepoId]
      #     The ID of the repo.
      # @!attribute [rw] revision_id
      #   @return [String]
      #     A revision ID.
      # @!attribute [rw] alias_context
      #   @return [Grafeas::V1beta1::Source::AliasContext]
      #     An alias, which may be a branch or tag.
      class CloudRepoSourceContext; end

      # A SourceContext referring to a Gerrit project.
      # @!attribute [rw] host_uri
      #   @return [String]
      #     The URI of a running Gerrit instance.
      # @!attribute [rw] gerrit_project
      #   @return [String]
      #     The full project name within the host. Projects may be nested, so
      #     "project/subproject" is a valid project name. The "repo name" is the
      #     hostURI/project.
      # @!attribute [rw] revision_id
      #   @return [String]
      #     A revision (commit) ID.
      # @!attribute [rw] alias_context
      #   @return [Grafeas::V1beta1::Source::AliasContext]
      #     An alias, which may be a branch or tag.
      class GerritSourceContext; end

      # A GitSourceContext denotes a particular revision in a third party Git
      # repository (e.g., GitHub).
      # @!attribute [rw] url
      #   @return [String]
      #     Git repository URL.
      # @!attribute [rw] revision_id
      #   @return [String]
      #     Git commit hash.
      class GitSourceContext; end

      # A unique identifier for a Cloud Repo.
      # @!attribute [rw] project_repo_id
      #   @return [Grafeas::V1beta1::Source::ProjectRepoId]
      #     A combination of a project ID and a repo name.
      # @!attribute [rw] uid
      #   @return [String]
      #     A server-assigned, globally unique identifier.
      class RepoId; end

      # Selects a repo using a Google Cloud Platform project ID (e.g.,
      # winged-cargo-31) and a repo name within that project.
      # @!attribute [rw] project_id
      #   @return [String]
      #     The ID of the project.
      # @!attribute [rw] repo_name
      #   @return [String]
      #     The name of the repo. Leave empty for the default repo.
      class ProjectRepoId; end
    end
  end
end