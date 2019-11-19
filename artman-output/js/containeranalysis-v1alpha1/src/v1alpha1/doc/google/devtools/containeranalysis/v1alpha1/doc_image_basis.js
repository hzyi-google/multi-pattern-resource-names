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
 * DockerImage holds types defining base image notes
 * and derived image occurrences.
 * @typedef DockerImage
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.DockerImage definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/image_basis.proto}
 */
const DockerImage = {
  // This is for documentation. Actual contents will be loaded by gRPC.

  /**
   * Layer holds metadata specific to a layer of a Docker image.
   *
   * @property {number} directive
   *   The recovered Dockerfile directive used to construct this layer.
   *
   *   The number should be among the values of [Directive]{@link google.devtools.containeranalysis.v1alpha1.Directive}
   *
   * @property {string} arguments
   *   The recovered arguments to the Dockerfile directive.
   *
   * @typedef Layer
   * @memberof google.devtools.containeranalysis.v1alpha1
   * @see [google.devtools.containeranalysis.v1alpha1.DockerImage.Layer definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/image_basis.proto}
   */
  Layer: {
    // This is for documentation. Actual contents will be loaded by gRPC.

    /**
     * Instructions from dockerfile
     *
     * @enum {number}
     * @memberof google.devtools.containeranalysis.v1alpha1
     */
    Directive: {

      /**
       * Default value for unsupported/missing directive
       */
      DIRECTIVE_UNSPECIFIED: 0,

      /**
       * https://docs.docker.com/reference/builder/#maintainer
       */
      MAINTAINER: 1,

      /**
       * https://docs.docker.com/reference/builder/#run
       */
      RUN: 2,

      /**
       * https://docs.docker.com/reference/builder/#cmd
       */
      CMD: 3,

      /**
       * https://docs.docker.com/reference/builder/#label
       */
      LABEL: 4,

      /**
       * https://docs.docker.com/reference/builder/#expose
       */
      EXPOSE: 5,

      /**
       * https://docs.docker.com/reference/builder/#env
       */
      ENV: 6,

      /**
       * https://docs.docker.com/reference/builder/#add
       */
      ADD: 7,

      /**
       * https://docs.docker.com/reference/builder/#copy
       */
      COPY: 8,

      /**
       * https://docs.docker.com/reference/builder/#entrypoint
       */
      ENTRYPOINT: 9,

      /**
       * https://docs.docker.com/reference/builder/#volume
       */
      VOLUME: 10,

      /**
       * https://docs.docker.com/reference/builder/#user
       */
      USER: 11,

      /**
       * https://docs.docker.com/reference/builder/#workdir
       */
      WORKDIR: 12,

      /**
       * https://docs.docker.com/reference/builder/#arg
       */
      ARG: 13,

      /**
       * https://docs.docker.com/reference/builder/#onbuild
       */
      ONBUILD: 14,

      /**
       * https://docs.docker.com/reference/builder/#stopsignal
       */
      STOPSIGNAL: 15,

      /**
       * https://docs.docker.com/reference/builder/#healthcheck
       */
      HEALTHCHECK: 16,

      /**
       * https://docs.docker.com/reference/builder/#shell
       */
      SHELL: 17
    }
  },

  /**
   * A set of properties that uniquely identify a given Docker image.
   *
   * @property {string} v1Name
   *   The layer-id of the final layer in the Docker image's v1
   *   representation.
   *   This field can be used as a filter in list requests.
   *
   * @property {string[]} v2Blob
   *   The ordered list of v2 blobs that represent a given image.
   *
   * @property {string} v2Name
   *   Output only. The name of the image's v2 blobs computed via:
   *     [bottom] := v2_blob[bottom]
   *     [N] := sha256(v2_blob[N] + " " + v2_name[N+1])
   *   Only the name of the final blob is kept.
   *   This field can be used as a filter in list requests.
   *
   * @typedef Fingerprint
   * @memberof google.devtools.containeranalysis.v1alpha1
   * @see [google.devtools.containeranalysis.v1alpha1.DockerImage.Fingerprint definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/image_basis.proto}
   */
  Fingerprint: {
    // This is for documentation. Actual contents will be loaded by gRPC.
  },

  /**
   * Basis describes the base image portion (Note) of the DockerImage
   * relationship.  Linked occurrences are derived from this or an
   * equivalent image via:
   *   FROM <Basis.resource_url>
   * Or an equivalent reference, e.g. a tag of the resource_url.
   *
   * @property {string} resourceUrl
   *   The resource_url for the resource representing the basis of
   *   associated occurrence images.
   *
   * @property {Object} fingerprint
   *   The fingerprint of the base image.
   *
   *   This object should have the same structure as [Fingerprint]{@link google.devtools.containeranalysis.v1alpha1.Fingerprint}
   *
   * @typedef Basis
   * @memberof google.devtools.containeranalysis.v1alpha1
   * @see [google.devtools.containeranalysis.v1alpha1.DockerImage.Basis definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/image_basis.proto}
   */
  Basis: {
    // This is for documentation. Actual contents will be loaded by gRPC.
  },

  /**
   * Derived describes the derived image portion (Occurrence) of the
   * DockerImage relationship.  This image would be produced from a Dockerfile
   * with FROM <DockerImage.Basis in attached Note>.
   *
   * @property {Object} fingerprint
   *   The fingerprint of the derived image.
   *
   *   This object should have the same structure as [Fingerprint]{@link google.devtools.containeranalysis.v1alpha1.Fingerprint}
   *
   * @property {number} distance
   *   Output only. The number of layers by which this image differs from the
   *   associated image basis.
   *
   * @property {Object[]} layerInfo
   *   This contains layer-specific metadata, if populated it has length
   *   "distance" and is ordered with [distance] being the layer immediately
   *   following the base image and [1] being the final layer.
   *
   *   This object should have the same structure as [Layer]{@link google.devtools.containeranalysis.v1alpha1.Layer}
   *
   * @property {string} baseResourceUrl
   *   Output only. This contains the base image URL for the derived image
   *   occurrence.
   *
   * @typedef Derived
   * @memberof google.devtools.containeranalysis.v1alpha1
   * @see [google.devtools.containeranalysis.v1alpha1.DockerImage.Derived definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/image_basis.proto}
   */
  Derived: {
    // This is for documentation. Actual contents will be loaded by gRPC.
  }
};