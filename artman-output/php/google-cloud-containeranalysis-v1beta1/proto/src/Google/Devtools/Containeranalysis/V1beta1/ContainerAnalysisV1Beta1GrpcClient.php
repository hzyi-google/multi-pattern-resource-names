<?php
// GENERATED CODE -- DO NOT EDIT!

// Original file comments:
// Copyright 2019 Google LLC.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
//
namespace Google\Devtools\Containeranalysis\V1beta1;

/**
 * Retrieves analysis results of Cloud components such as Docker container
 * images. The Container Analysis API is an implementation of the
 * [Grafeas](grafeas.io) API.
 *
 * Analysis results are stored as a series of occurrences. An `Occurrence`
 * contains information about a specific analysis instance on a resource. An
 * occurrence refers to a `Note`. A note contains details describing the
 * analysis and is generally stored in a separate project, called a `Provider`.
 * Multiple occurrences can refer to the same note.
 *
 * For example, an SSL vulnerability could affect multiple images. In this case,
 * there would be one note for the vulnerability and an occurrence for each
 * image with the vulnerability referring to that note.
 */
class ContainerAnalysisV1Beta1GrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Sets the access control policy on the specified note or occurrence.
     * Requires `containeranalysis.notes.setIamPolicy` or
     * `containeranalysis.occurrences.setIamPolicy` permission if the resource is
     * a note or an occurrence, respectively.
     *
     * The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
     * notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
     * occurrences.
     * @param \Google\Cloud\Iam\V1\SetIamPolicyRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     */
    public function SetIamPolicy(\Google\Cloud\Iam\V1\SetIamPolicyRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.devtools.containeranalysis.v1beta1.ContainerAnalysisV1Beta1/SetIamPolicy',
        $argument,
        ['\Google\Cloud\Iam\V1\Policy', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets the access control policy for a note or an occurrence resource.
     * Requires `containeranalysis.notes.setIamPolicy` or
     * `containeranalysis.occurrences.setIamPolicy` permission if the resource is
     * a note or occurrence, respectively.
     *
     * The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
     * notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
     * occurrences.
     * @param \Google\Cloud\Iam\V1\GetIamPolicyRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     */
    public function GetIamPolicy(\Google\Cloud\Iam\V1\GetIamPolicyRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.devtools.containeranalysis.v1beta1.ContainerAnalysisV1Beta1/GetIamPolicy',
        $argument,
        ['\Google\Cloud\Iam\V1\Policy', 'decode'],
        $metadata, $options);
    }

    /**
     * Returns the permissions that a caller has on the specified note or
     * occurrence. Requires list permission on the project (for example,
     * `containeranalysis.notes.list`).
     *
     * The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
     * notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
     * occurrences.
     * @param \Google\Cloud\Iam\V1\TestIamPermissionsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     */
    public function TestIamPermissions(\Google\Cloud\Iam\V1\TestIamPermissionsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.devtools.containeranalysis.v1beta1.ContainerAnalysisV1Beta1/TestIamPermissions',
        $argument,
        ['\Google\Cloud\Iam\V1\TestIamPermissionsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets the specified scan configuration.
     * @param \Google\Devtools\Containeranalysis\V1beta1\GetScanConfigRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     */
    public function GetScanConfig(\Google\Devtools\Containeranalysis\V1beta1\GetScanConfigRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.devtools.containeranalysis.v1beta1.ContainerAnalysisV1Beta1/GetScanConfig',
        $argument,
        ['\Google\Devtools\Containeranalysis\V1beta1\ScanConfig', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists scan configurations for the specified project.
     * @param \Google\Devtools\Containeranalysis\V1beta1\ListScanConfigsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     */
    public function ListScanConfigs(\Google\Devtools\Containeranalysis\V1beta1\ListScanConfigsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.devtools.containeranalysis.v1beta1.ContainerAnalysisV1Beta1/ListScanConfigs',
        $argument,
        ['\Google\Devtools\Containeranalysis\V1beta1\ListScanConfigsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates the specified scan configuration.
     * @param \Google\Devtools\Containeranalysis\V1beta1\UpdateScanConfigRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     */
    public function UpdateScanConfig(\Google\Devtools\Containeranalysis\V1beta1\UpdateScanConfigRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.devtools.containeranalysis.v1beta1.ContainerAnalysisV1Beta1/UpdateScanConfig',
        $argument,
        ['\Google\Devtools\Containeranalysis\V1beta1\ScanConfig', 'decode'],
        $metadata, $options);
    }

}