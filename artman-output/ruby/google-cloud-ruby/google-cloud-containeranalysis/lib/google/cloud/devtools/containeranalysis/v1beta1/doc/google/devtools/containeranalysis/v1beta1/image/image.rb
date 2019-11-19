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
    module Image
      # Layer holds metadata specific to a layer of a Docker image.
      # @!attribute [rw] directive
      #   @return [Grafeas::V1beta1::Image::Layer::Directive]
      #     The recovered Dockerfile directive used to construct this layer.
      # @!attribute [rw] arguments
      #   @return [String]
      #     The recovered arguments to the Dockerfile directive.
      class Layer
        # Instructions from Dockerfile.
        module Directive
          # Default value for unsupported/missing directive.
          DIRECTIVE_UNSPECIFIED = 0

          # https://docs.docker.com/reference/builder/#maintainer
          MAINTAINER = 1

          # https://docs.docker.com/reference/builder/#run
          RUN = 2

          # https://docs.docker.com/reference/builder/#cmd
          CMD = 3

          # https://docs.docker.com/reference/builder/#label
          LABEL = 4

          # https://docs.docker.com/reference/builder/#expose
          EXPOSE = 5

          # https://docs.docker.com/reference/builder/#env
          ENV = 6

          # https://docs.docker.com/reference/builder/#add
          ADD = 7

          # https://docs.docker.com/reference/builder/#copy
          COPY = 8

          # https://docs.docker.com/reference/builder/#entrypoint
          ENTRYPOINT = 9

          # https://docs.docker.com/reference/builder/#volume
          VOLUME = 10

          # https://docs.docker.com/reference/builder/#user
          USER = 11

          # https://docs.docker.com/reference/builder/#workdir
          WORKDIR = 12

          # https://docs.docker.com/reference/builder/#arg
          ARG = 13

          # https://docs.docker.com/reference/builder/#onbuild
          ONBUILD = 14

          # https://docs.docker.com/reference/builder/#stopsignal
          STOPSIGNAL = 15

          # https://docs.docker.com/reference/builder/#healthcheck
          HEALTHCHECK = 16

          # https://docs.docker.com/reference/builder/#shell
          SHELL = 17
        end
      end

      # A set of properties that uniquely identify a given Docker image.
      # @!attribute [rw] v1_name
      #   @return [String]
      #     The layer-id of the final layer in the Docker image's v1 representation.
      # @!attribute [rw] v2_blob
      #   @return [Array<String>]
      #     The ordered list of v2 blobs that represent a given image.
      # @!attribute [rw] v2_name
      #   @return [String]
      #     Output only. The name of the image's v2 blobs computed via:
      #       [bottom] := v2_blob[bottom]
      #       [N] := sha256(v2_blob[N] + " " + v2_name[N+1])
      #     Only the name of the final blob is kept.
      class Fingerprint; end

      # Basis describes the base image portion (Note) of the DockerImage
      # relationship. Linked occurrences are derived from this or an
      # equivalent image via:
      #   FROM <Basis.resource_url>
      # Or an equivalent reference, e.g. a tag of the resource_url.
      # @!attribute [rw] resource_url
      #   @return [String]
      #     The resource_url for the resource representing the basis of
      #     associated occurrence images.
      # @!attribute [rw] fingerprint
      #   @return [Grafeas::V1beta1::Image::Fingerprint]
      #     The fingerprint of the base image.
      class Basis; end

      # Details of an image occurrence.
      # @!attribute [rw] derived_image
      #   @return [Grafeas::V1beta1::Image::Derived]
      #     The child image derived from the base image.
      class Details; end

      # Derived describes the derived image portion (Occurrence) of the DockerImage
      # relationship. This image would be produced from a Dockerfile with FROM
      # <DockerImage.Basis in attached Note>.
      # @!attribute [rw] fingerprint
      #   @return [Grafeas::V1beta1::Image::Fingerprint]
      #     The fingerprint of the derived image.
      # @!attribute [rw] distance
      #   @return [Integer]
      #     Output only. The number of layers by which this image differs from the
      #     associated image basis.
      # @!attribute [rw] layer_info
      #   @return [Array<Grafeas::V1beta1::Image::Layer>]
      #     This contains layer-specific metadata, if populated it has length
      #     "distance" and is ordered with [distance] being the layer immediately
      #     following the base image and [1] being the final layer.
      # @!attribute [rw] base_resource_url
      #   @return [String]
      #     Output only. This contains the base image URL for the derived image
      #     occurrence.
      class Derived; end
    end
  end
end