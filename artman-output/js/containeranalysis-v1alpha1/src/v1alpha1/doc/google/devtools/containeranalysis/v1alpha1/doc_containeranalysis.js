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
 * `Occurrence` includes information about analysis occurrences for an image.
 *
 * @property {string} name
 *   Output only. The name of the `Occurrence` in the form
 *   "projects/{project_id}/occurrences/{OCCURRENCE_ID}"
 *
 * @property {string} resourceUrl
 *   The unique URL of the image or the container for which the `Occurrence`
 *   applies. For example, https://gcr.io/project/image@sha256:foo This field
 *   can be used as a filter in list requests.
 *
 * @property {Object} resource
 *   The resource for which the `Occurrence` applies.
 *
 *   This object should have the same structure as [Resource]{@link google.devtools.containeranalysis.v1alpha1.Resource}
 *
 * @property {string} noteName
 *   An analysis note associated with this image, in the form
 *   "providers/{provider_id}/notes/{NOTE_ID}"
 *   This field can be used as a filter in list requests.
 *
 * @property {number} kind
 *   Output only. This explicitly denotes which of the `Occurrence` details are
 *   specified. This field can be used as a filter in list requests.
 *
 *   The number should be among the values of [Kind]{@link google.devtools.containeranalysis.v1alpha1.Kind}
 *
 * @property {Object} vulnerabilityDetails
 *   Details of a security vulnerability note.
 *
 *   This object should have the same structure as [VulnerabilityDetails]{@link google.devtools.containeranalysis.v1alpha1.VulnerabilityDetails}
 *
 * @property {Object} buildDetails
 *   Build details for a verifiable build.
 *
 *   This object should have the same structure as [BuildDetails]{@link google.devtools.containeranalysis.v1alpha1.BuildDetails}
 *
 * @property {Object} derivedImage
 *   Describes how this resource derives from the basis
 *   in the associated note.
 *
 *   This object should have the same structure as [Derived]{@link google.devtools.containeranalysis.v1alpha1.Derived}
 *
 * @property {Object} installation
 *   Describes the installation of a package on the linked resource.
 *
 *   This object should have the same structure as [Installation]{@link google.devtools.containeranalysis.v1alpha1.Installation}
 *
 * @property {Object} deployment
 *   Describes the deployment of an artifact on a runtime.
 *
 *   This object should have the same structure as [Deployment]{@link google.devtools.containeranalysis.v1alpha1.Deployment}
 *
 * @property {Object} discovered
 *   Describes the initial scan status for this resource.
 *
 *   This object should have the same structure as [Discovered]{@link google.devtools.containeranalysis.v1alpha1.Discovered}
 *
 * @property {Object} attestation
 *   Describes an attestation of an artifact.
 *
 *   This object should have the same structure as [Attestation]{@link google.devtools.containeranalysis.v1alpha1.Attestation}
 *
 * @property {string} remediation
 *   A description of actions that can be taken to remedy the `Note`
 *
 * @property {Object} createTime
 *   Output only. The time this `Occurrence` was created.
 *
 *   This object should have the same structure as [Timestamp]{@link google.protobuf.Timestamp}
 *
 * @property {Object} updateTime
 *   Output only. The time this `Occurrence` was last updated.
 *
 *   This object should have the same structure as [Timestamp]{@link google.protobuf.Timestamp}
 *
 * @typedef Occurrence
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.Occurrence definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
 */
const Occurrence = {
  // This is for documentation. Actual contents will be loaded by gRPC.
};

/**
 * Resource is an entity that can have metadata. E.g., a Docker image.
 *
 * @property {string} name
 *   The name of the resource. E.g., the name of a Docker image - "Debian".
 *
 * @property {string} uri
 *   The unique URI of the resource. E.g.,
 *   "https://gcr.io/project/image@sha256:foo" for a Docker image.
 *
 * @property {Object} contentHash
 *   The hash of the resource content. E.g., the Docker digest.
 *
 *   This object should have the same structure as [Hash]{@link google.devtools.containeranalysis.v1alpha1.Hash}
 *
 * @typedef Resource
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.Resource definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
 */
const Resource = {
  // This is for documentation. Actual contents will be loaded by gRPC.
};

/**
 * Provides a detailed description of a `Note`.
 *
 * @property {string} name
 *   The name of the note in the form
 *   "providers/{provider_id}/notes/{NOTE_ID}"
 *
 * @property {string} shortDescription
 *   A one sentence description of this `Note`.
 *
 * @property {string} longDescription
 *   A detailed description of this `Note`.
 *
 * @property {number} kind
 *   Output only. This explicitly denotes which kind of note is specified. This
 *   field can be used as a filter in list requests.
 *
 *   The number should be among the values of [Kind]{@link google.devtools.containeranalysis.v1alpha1.Kind}
 *
 * @property {Object} vulnerabilityType
 *   A package vulnerability type of note.
 *
 *   This object should have the same structure as [VulnerabilityType]{@link google.devtools.containeranalysis.v1alpha1.VulnerabilityType}
 *
 * @property {Object} buildType
 *   Build provenance type for a verifiable build.
 *
 *   This object should have the same structure as [BuildType]{@link google.devtools.containeranalysis.v1alpha1.BuildType}
 *
 * @property {Object} baseImage
 *   A note describing a base image.
 *
 *   This object should have the same structure as [Basis]{@link google.devtools.containeranalysis.v1alpha1.Basis}
 *
 * @property {Object} package
 *   A note describing a package hosted by various package managers.
 *
 *   This object should have the same structure as [Package]{@link google.devtools.containeranalysis.v1alpha1.Package}
 *
 * @property {Object} deployable
 *   A note describing something that can be deployed.
 *
 *   This object should have the same structure as [Deployable]{@link google.devtools.containeranalysis.v1alpha1.Deployable}
 *
 * @property {Object} discovery
 *   A note describing a provider/analysis type.
 *
 *   This object should have the same structure as [Discovery]{@link google.devtools.containeranalysis.v1alpha1.Discovery}
 *
 * @property {Object} attestationAuthority
 *   A note describing an attestation role.
 *
 *   This object should have the same structure as [AttestationAuthority]{@link google.devtools.containeranalysis.v1alpha1.AttestationAuthority}
 *
 * @property {Object[]} relatedUrl
 *   URLs associated with this note
 *
 *   This object should have the same structure as [RelatedUrl]{@link google.devtools.containeranalysis.v1alpha1.RelatedUrl}
 *
 * @property {Object} expirationTime
 *   Time of expiration for this note, null if note does not expire.
 *
 *   This object should have the same structure as [Timestamp]{@link google.protobuf.Timestamp}
 *
 * @property {Object} createTime
 *   Output only. The time this note was created. This field can be used as a
 *   filter in list requests.
 *
 *   This object should have the same structure as [Timestamp]{@link google.protobuf.Timestamp}
 *
 * @property {Object} updateTime
 *   Output only. The time this note was last updated. This field can be used as
 *   a filter in list requests.
 *
 *   This object should have the same structure as [Timestamp]{@link google.protobuf.Timestamp}
 *
 * @typedef Note
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.Note definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
 */
const Note = {
  // This is for documentation. Actual contents will be loaded by gRPC.

  /**
   * Metadata for any related URL information
   *
   * @property {string} url
   *   Specific URL to associate with the note
   *
   * @property {string} label
   *   Label to describe usage of the URL
   *
   * @typedef RelatedUrl
   * @memberof google.devtools.containeranalysis.v1alpha1
   * @see [google.devtools.containeranalysis.v1alpha1.Note.RelatedUrl definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
   */
  RelatedUrl: {
    // This is for documentation. Actual contents will be loaded by gRPC.
  },

  /**
   * This must be 1:1 with members of our oneofs, it can be used for filtering
   * Note and Occurrence on their kind.
   *
   * @enum {number}
   * @memberof google.devtools.containeranalysis.v1alpha1
   */
  Kind: {

    /**
     * Unknown
     */
    KIND_UNSPECIFIED: 0,

    /**
     * The note and occurrence represent a package vulnerability.
     */
    PACKAGE_VULNERABILITY: 2,

    /**
     * The note and occurrence assert build provenance.
     */
    BUILD_DETAILS: 3,

    /**
     * This represents an image basis relationship.
     */
    IMAGE_BASIS: 4,

    /**
     * This represents a package installed via a package manager.
     */
    PACKAGE_MANAGER: 5,

    /**
     * The note and occurrence track deployment events.
     */
    DEPLOYABLE: 6,

    /**
     * The note and occurrence track the initial discovery status of a resource.
     */
    DISCOVERY: 7,

    /**
     * This represents a logical "role" that can attest to artifacts.
     */
    ATTESTATION_AUTHORITY: 8
  }
};

/**
 * An artifact that can be deployed in some runtime.
 *
 * @property {string[]} resourceUri
 *   Resource URI for the artifact being deployed.
 *
 * @typedef Deployable
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.Deployable definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
 */
const Deployable = {
  // This is for documentation. Actual contents will be loaded by gRPC.

  /**
   * The period during which some deployable was active in a runtime.
   *
   * @property {string} userEmail
   *   Identity of the user that triggered this deployment.
   *
   * @property {Object} deployTime
   *   Beginning of the lifetime of this deployment.
   *
   *   This object should have the same structure as [Timestamp]{@link google.protobuf.Timestamp}
   *
   * @property {Object} undeployTime
   *   End of the lifetime of this deployment.
   *
   *   This object should have the same structure as [Timestamp]{@link google.protobuf.Timestamp}
   *
   * @property {string} config
   *   Configuration used to create this deployment.
   *
   * @property {string} address
   *   Address of the runtime element hosting this deployment.
   *
   * @property {string[]} resourceUri
   *   Output only. Resource URI for the artifact being deployed taken from the
   *   deployable field with the same name.
   *
   * @property {number} platform
   *   Platform hosting this deployment.
   *
   *   The number should be among the values of [Platform]{@link google.devtools.containeranalysis.v1alpha1.Platform}
   *
   * @typedef Deployment
   * @memberof google.devtools.containeranalysis.v1alpha1
   * @see [google.devtools.containeranalysis.v1alpha1.Deployable.Deployment definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
   */
  Deployment: {
    // This is for documentation. Actual contents will be loaded by gRPC.

    /**
     * Types of platforms.
     *
     * @enum {number}
     * @memberof google.devtools.containeranalysis.v1alpha1
     */
    Platform: {

      /**
       * Unknown
       */
      PLATFORM_UNSPECIFIED: 0,

      /**
       * Google Container Engine
       */
      GKE: 1,

      /**
       * Google App Engine: Flexible Environment
       */
      FLEX: 2,

      /**
       * Custom user-defined platform
       */
      CUSTOM: 3
    }
  }
};

/**
 * A note that indicates a type of analysis a provider would perform. This note
 * exists in a provider's project. A `Discovery` occurrence is created in a
 * consumer's project at the start of analysis. The occurrence's operation will
 * indicate the status of the analysis. Absence of an occurrence linked to this
 * note for a resource indicates that analysis hasn't started.
 *
 * @property {number} analysisKind
 *   The kind of analysis that is handled by this discovery.
 *
 *   The number should be among the values of [Kind]{@link google.devtools.containeranalysis.v1alpha1.Kind}
 *
 * @typedef Discovery
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.Discovery definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
 */
const Discovery = {
  // This is for documentation. Actual contents will be loaded by gRPC.

  /**
   * Provides information about the scan status of a discovered resource.
   *
   * @property {Object} operation
   *   Output only. An operation that indicates the status of the current scan.
   *
   *   This object should have the same structure as [Operation]{@link google.longrunning.Operation}
   *
   * @property {number} analysisStatus
   *   The status of discovery for the resource.
   *
   *   The number should be among the values of [AnalysisStatus]{@link google.devtools.containeranalysis.v1alpha1.AnalysisStatus}
   *
   * @property {Object} analysisStatusError
   *   When an error is encountered this will contain a LocalizedMessage under
   *   details to show to the user. The LocalizedMessage output only and
   *   populated by the API.
   *
   *   This object should have the same structure as [Status]{@link google.rpc.Status}
   *
   * @typedef Discovered
   * @memberof google.devtools.containeranalysis.v1alpha1
   * @see [google.devtools.containeranalysis.v1alpha1.Discovery.Discovered definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
   */
  Discovered: {
    // This is for documentation. Actual contents will be loaded by gRPC.

    /**
     * Analysis status for a resource.
     *
     * @enum {number}
     * @memberof google.devtools.containeranalysis.v1alpha1
     */
    AnalysisStatus: {

      /**
       * Unknown
       */
      ANALYSIS_STATUS_UNSPECIFIED: 0,

      /**
       * Resource is known but no action has been taken yet.
       */
      PENDING: 1,

      /**
       * Resource is being analyzed.
       */
      SCANNING: 2,

      /**
       * Analysis has finished successfully.
       */
      FINISHED_SUCCESS: 3,

      /**
       * Analysis has finished unsuccessfully, the analysis itself is in a bad
       * state.
       */
      FINISHED_FAILED: 4,

      /**
       * Analysis will not happen, the resource is not supported.
       */
      UNSUPPORTED_RESOURCE: 5
    }
  }
};

/**
 * Note holding the version of the provider's builder and the signature of
 * the provenance message in linked BuildDetails.
 *
 * @property {string} builderVersion
 *   Version of the builder which produced this Note.
 *
 * @property {Object} signature
 *   Signature of the build in Occurrences pointing to the Note containing this
 *   `BuilderDetails`.
 *
 *   This object should have the same structure as [BuildSignature]{@link google.devtools.containeranalysis.v1alpha1.BuildSignature}
 *
 * @typedef BuildType
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.BuildType definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
 */
const BuildType = {
  // This is for documentation. Actual contents will be loaded by gRPC.
};

/**
 * Message encapsulating the signature of the verified build.
 *
 * @property {string} publicKey
 *   Public key of the builder which can be used to verify that the related
 *   findings are valid and unchanged. If `key_type` is empty, this defaults
 *   to PEM encoded public keys.
 *
 *   This field may be empty if `key_id` references an external key.
 *
 *   For Cloud Build based signatures, this is a PEM encoded public
 *   key. To verify the Cloud Build signature, place the contents of
 *   this field into a file (public.pem). The signature field is base64-decoded
 *   into its binary representation in signature.bin, and the provenance bytes
 *   from `BuildDetails` are base64-decoded into a binary representation in
 *   signed.bin. OpenSSL can then verify the signature:
 *   `openssl sha256 -verify public.pem -signature signature.bin signed.bin`
 *
 * @property {string} signature
 *   Signature of the related `BuildProvenance`, encoded in a base64 string.
 *
 * @property {string} keyId
 *   An Id for the key used to sign. This could be either an Id for the key
 *   stored in `public_key` (such as the Id or fingerprint for a PGP key, or the
 *   CN for a cert), or a reference to an external key (such as a reference to a
 *   key in Cloud Key Management Service).
 *
 * @property {number} keyType
 *   The type of the key, either stored in `public_key` or referenced in
 *   `key_id`
 *
 *   The number should be among the values of [KeyType]{@link google.devtools.containeranalysis.v1alpha1.KeyType}
 *
 * @typedef BuildSignature
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.BuildSignature definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
 */
const BuildSignature = {
  // This is for documentation. Actual contents will be loaded by gRPC.

  /**
   * Public key formats
   *
   * @enum {number}
   * @memberof google.devtools.containeranalysis.v1alpha1
   */
  KeyType: {

    /**
     * `KeyType` is not set.
     */
    KEY_TYPE_UNSPECIFIED: 0,

    /**
     * `PGP ASCII Armored` public key.
     */
    PGP_ASCII_ARMORED: 1,

    /**
     * `PKIX PEM` public key.
     */
    PKIX_PEM: 2
  }
};

/**
 * An attestation wrapper with a PGP-compatible signature.
 * This message only supports `ATTACHED` signatures, where the payload that is
 * signed is included alongside the signature itself in the same file.
 *
 * @property {string} signature
 *   The raw content of the signature, as output by GNU Privacy Guard (GPG) or
 *   equivalent.  Since this message only supports attached signatures, the
 *   payload that was signed must be attached. While the signature format
 *   supported is dependent on the verification implementation, currently only
 *   ASCII-armored (`--armor` to gpg), non-clearsigned (`--sign` rather than
 *   `--clearsign` to gpg) are supported. Concretely, `gpg --sign --armor
 *   --output=signature.gpg payload.json` will create the signature content
 *   expected in this field in `signature.gpg` for the `payload.json`
 *   attestation payload.
 *
 * @property {number} contentType
 *   Type (for example schema) of the attestation payload that was signed.
 *   The verifier must ensure that the provided type is one that the verifier
 *   supports, and that the attestation payload is a valid instantiation of that
 *   type (for example by validating a JSON schema).
 *
 *   The number should be among the values of [ContentType]{@link google.devtools.containeranalysis.v1alpha1.ContentType}
 *
 * @property {string} pgpKeyId
 *   The cryptographic fingerprint of the key used to generate the signature,
 *   as output by, e.g. `gpg --list-keys`. This should be the version 4, full
 *   160-bit fingerprint, expressed as a 40 character hexadecimal string. See
 *   https://tools.ietf.org/html/rfc4880#section-12.2 for details.
 *   Implementations may choose to acknowledge "LONG", "SHORT", or other
 *   abbreviated key IDs, but only the full fingerprint is guaranteed to work.
 *   In gpg, the full fingerprint can be retrieved from the `fpr` field
 *   returned when calling --list-keys with --with-colons.  For example:
 *   ```
 *   gpg --with-colons --with-fingerprint --force-v4-certs \
 *       --list-keys attester@example.com
 *   tru::1:1513631572:0:3:1:5
 *   pub:...<SNIP>...
 *   fpr:::::::::24FF6481B76AC91E66A00AC657A93A81EF3AE6FB:
 *   ```
 *   Above, the fingerprint is `24FF6481B76AC91E66A00AC657A93A81EF3AE6FB`.
 *
 * @typedef PgpSignedAttestation
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.PgpSignedAttestation definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
 */
const PgpSignedAttestation = {
  // This is for documentation. Actual contents will be loaded by gRPC.

  /**
   * Type (for example schema) of the attestation payload that was signed.
   *
   * @enum {number}
   * @memberof google.devtools.containeranalysis.v1alpha1
   */
  ContentType: {

    /**
     * `ContentType` is not set.
     */
    CONTENT_TYPE_UNSPECIFIED: 0,

    /**
     * Atomic format attestation signature. See
     * https://github.com/containers/image/blob/8a5d2f82a6e3263290c8e0276c3e0f64e77723e7/docs/atomic-signature.md
     * The payload extracted from `signature` is a JSON blob conforming to the
     * linked schema.
     */
    SIMPLE_SIGNING_JSON: 1
  }
};

/**
 * Note kind that represents a logical attestation "role" or "authority".  For
 * example, an organization might have one `AttestationAuthority` for "QA" and
 * one for "build".  This Note is intended to act strictly as a grouping
 * mechanism for the attached Occurrences (Attestations).  This grouping
 * mechanism also provides a security boundary, since IAM ACLs gate the ability
 * for a principle to attach an Occurrence to a given Note.  It also provides a
 * single point of lookup to find all attached Attestation Occurrences, even if
 * they don't all live in the same project.
 *
 * @property {Object} hint
 *   This object should have the same structure as [AttestationAuthorityHint]{@link google.devtools.containeranalysis.v1alpha1.AttestationAuthorityHint}
 *
 * @typedef AttestationAuthority
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.AttestationAuthority definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
 */
const AttestationAuthority = {
  // This is for documentation. Actual contents will be loaded by gRPC.

  /**
   * This submessage provides human-readable hints about the purpose of the
   * AttestationAuthority.  Because the name of a Note acts as its resource
   * reference, it is important to disambiguate the canonical name of the Note
   * (which might be a UUID for security purposes) from "readable" names more
   * suitable for debug output.  Note that these hints should NOT be used to
   * look up AttestationAuthorities in security sensitive contexts, such as when
   * looking up Attestations to verify.
   *
   * @property {string} humanReadableName
   *   The human readable name of this Attestation Authority, for example "qa".
   *
   * @typedef AttestationAuthorityHint
   * @memberof google.devtools.containeranalysis.v1alpha1
   * @see [google.devtools.containeranalysis.v1alpha1.AttestationAuthority.AttestationAuthorityHint definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
   */
  AttestationAuthorityHint: {
    // This is for documentation. Actual contents will be loaded by gRPC.
  },

  /**
   * Occurrence that represents a single "attestation".  The authenticity of an
   * Attestation can be verified using the attached signature. If the verifier
   * trusts the public key of the signer, then verifying the signature is
   * sufficient to establish trust.  In this circumstance, the
   * AttestationAuthority to which this Attestation is attached is primarily
   * useful for look-up (how to find this Attestation if you already know the
   * Authority and artifact to be verified) and intent (which authority was this
   * attestation intended to sign for).
   *
   * @property {Object} pgpSignedAttestation
   *   This object should have the same structure as [PgpSignedAttestation]{@link google.devtools.containeranalysis.v1alpha1.PgpSignedAttestation}
   *
   * @typedef Attestation
   * @memberof google.devtools.containeranalysis.v1alpha1
   * @see [google.devtools.containeranalysis.v1alpha1.AttestationAuthority.Attestation definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
   */
  Attestation: {
    // This is for documentation. Actual contents will be loaded by gRPC.
  }
};

/**
 * Message encapsulating build provenance details.
 *
 * @property {Object} provenance
 *   The actual provenance
 *
 *   This object should have the same structure as [BuildProvenance]{@link google.devtools.containeranalysis.v1alpha1.BuildProvenance}
 *
 * @property {string} provenanceBytes
 *   Serialized JSON representation of the provenance, used in generating the
 *   `BuildSignature` in the corresponding Result. After verifying the
 *   signature, `provenance_bytes` can be unmarshalled and compared to the
 *   provenance to confirm that it is unchanged. A base64-encoded string
 *   representation of the provenance bytes is used for the signature in order
 *   to interoperate with openssl which expects this format for signature
 *   verification.
 *
 *   The serialized form is captured both to avoid ambiguity in how the
 *   provenance is marshalled to json as well to prevent incompatibilities with
 *   future changes.
 *
 * @typedef BuildDetails
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.BuildDetails definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
 */
const BuildDetails = {
  // This is for documentation. Actual contents will be loaded by gRPC.
};

/**
 * Indicates various scans and whether they are turned on or off.
 *
 * @property {string} name
 *   Output only. The name of the ScanConfig in the form
 *   “projects/{project_id}/ScanConfigs/{ScanConfig_id}".
 *
 * @property {string} description
 *   Output only. A human-readable description of what the `ScanConfig` does.
 *
 * @property {boolean} enabled
 *   Indicates whether the Scan is enabled.
 *
 * @typedef ScanConfig
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.ScanConfig definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
 */
const ScanConfig = {
  // This is for documentation. Actual contents will be loaded by gRPC.
};

/**
 * Request to get a Occurrence.
 *
 * @property {string} name
 *   The name of the occurrence of the form
 *   "projects/{project_id}/occurrences/{OCCURRENCE_ID}"
 *
 * @typedef GetOccurrenceRequest
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.GetOccurrenceRequest definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
 */
const GetOccurrenceRequest = {
  // This is for documentation. Actual contents will be loaded by gRPC.
};

/**
 * Request to list occurrences.
 *
 * @property {string} name
 *   The name field contains the project Id. For example:
 *   "projects/{project_id}
 *   @Deprecated
 *
 * @property {string} parent
 *   This contains the project Id for example: projects/{project_id}.
 *
 * @property {string} filter
 *   The filter expression.
 *
 * @property {number} pageSize
 *   Number of occurrences to return in the list.
 *
 * @property {string} pageToken
 *   Token to provide to skip to a particular spot in the list.
 *
 * @property {number} kind
 *   The kind of occurrences to filter on.
 *
 *   The number should be among the values of [Kind]{@link google.devtools.containeranalysis.v1alpha1.Kind}
 *
 * @typedef ListOccurrencesRequest
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.ListOccurrencesRequest definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
 */
const ListOccurrencesRequest = {
  // This is for documentation. Actual contents will be loaded by gRPC.
};

/**
 * Response including listed active occurrences.
 *
 * @property {Object[]} occurrences
 *   The occurrences requested.
 *
 *   This object should have the same structure as [Occurrence]{@link google.devtools.containeranalysis.v1alpha1.Occurrence}
 *
 * @property {string} nextPageToken
 *   The next pagination token in the list response. It should be used as
 *   `page_token` for the following request. An empty value means no more
 *   results.
 *
 * @typedef ListOccurrencesResponse
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.ListOccurrencesResponse definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
 */
const ListOccurrencesResponse = {
  // This is for documentation. Actual contents will be loaded by gRPC.
};

/**
 * Request to delete a occurrence
 *
 * @property {string} name
 *   The name of the occurrence in the form of
 *   "projects/{project_id}/occurrences/{OCCURRENCE_ID}"
 *
 * @typedef DeleteOccurrenceRequest
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.DeleteOccurrenceRequest definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
 */
const DeleteOccurrenceRequest = {
  // This is for documentation. Actual contents will be loaded by gRPC.
};

/**
 * Request to insert a new occurrence.
 *
 * @property {string} name
 *   The name of the project.  Should be of the form "projects/{project_id}".
 *   @Deprecated
 *
 * @property {string} parent
 *   This field contains the project Id for example: "projects/{project_id}"
 *
 * @property {Object} occurrence
 *   The occurrence to be inserted
 *
 *   This object should have the same structure as [Occurrence]{@link google.devtools.containeranalysis.v1alpha1.Occurrence}
 *
 * @typedef CreateOccurrenceRequest
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.CreateOccurrenceRequest definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
 */
const CreateOccurrenceRequest = {
  // This is for documentation. Actual contents will be loaded by gRPC.
};

/**
 * Request to update an existing occurrence
 *
 * @property {string} name
 *   The name of the occurrence.
 *   Should be of the form "projects/{project_id}/occurrences/{OCCURRENCE_ID}".
 *
 * @property {Object} occurrence
 *   The updated occurrence.
 *
 *   This object should have the same structure as [Occurrence]{@link google.devtools.containeranalysis.v1alpha1.Occurrence}
 *
 * @property {Object} updateMask
 *   The fields to update.
 *
 *   This object should have the same structure as [FieldMask]{@link google.protobuf.FieldMask}
 *
 * @typedef UpdateOccurrenceRequest
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.UpdateOccurrenceRequest definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
 */
const UpdateOccurrenceRequest = {
  // This is for documentation. Actual contents will be loaded by gRPC.
};

/**
 * Request to get a Note.
 *
 * @property {string} name
 *   The name of the note in the form of
 *   "providers/{provider_id}/notes/{NOTE_ID}"
 *
 * @typedef GetNoteRequest
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.GetNoteRequest definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
 */
const GetNoteRequest = {
  // This is for documentation. Actual contents will be loaded by gRPC.
};

/**
 * Request to get the note to which this occurrence is attached.
 *
 * @property {string} name
 *   The name of the occurrence in the form
 *   "projects/{project_id}/occurrences/{OCCURRENCE_ID}"
 *
 * @typedef GetOccurrenceNoteRequest
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.GetOccurrenceNoteRequest definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
 */
const GetOccurrenceNoteRequest = {
  // This is for documentation. Actual contents will be loaded by gRPC.
};

/**
 * Request to list notes.
 *
 * @property {string} name
 *   The name field will contain the project Id for example:
 *   "providers/{provider_id}
 *   @Deprecated
 *
 * @property {string} parent
 *   This field contains the project Id for example: "projects/{PROJECT_ID}".
 *
 * @property {string} filter
 *   The filter expression.
 *
 * @property {number} pageSize
 *   Number of notes to return in the list.
 *
 * @property {string} pageToken
 *   Token to provide to skip to a particular spot in the list.
 *
 * @typedef ListNotesRequest
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.ListNotesRequest definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
 */
const ListNotesRequest = {
  // This is for documentation. Actual contents will be loaded by gRPC.
};

/**
 * Response including listed notes.
 *
 * @property {Object[]} notes
 *   The occurrences requested
 *
 *   This object should have the same structure as [Note]{@link google.devtools.containeranalysis.v1alpha1.Note}
 *
 * @property {string} nextPageToken
 *   The next pagination token in the list response. It should be used as
 *   page_token for the following request. An empty value means no more result.
 *
 * @typedef ListNotesResponse
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.ListNotesResponse definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
 */
const ListNotesResponse = {
  // This is for documentation. Actual contents will be loaded by gRPC.
};

/**
 * Request to delete a note
 *
 * @property {string} name
 *   The name of the note in the form of
 *   "providers/{provider_id}/notes/{NOTE_ID}"
 *
 * @typedef DeleteNoteRequest
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.DeleteNoteRequest definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
 */
const DeleteNoteRequest = {
  // This is for documentation. Actual contents will be loaded by gRPC.
};

/**
 * Request to insert a new note
 *
 * @property {string} name
 *   The name of the project.
 *   Should be of the form "providers/{provider_id}".
 *   @Deprecated
 *
 * @property {string} parent
 *   This field contains the project Id for example:
 *   "projects/{project_id}
 *
 * @property {string} noteId
 *   The ID to use for this note.
 *
 * @property {Object} note
 *   The Note to be inserted
 *
 *   This object should have the same structure as [Note]{@link google.devtools.containeranalysis.v1alpha1.Note}
 *
 * @typedef CreateNoteRequest
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.CreateNoteRequest definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
 */
const CreateNoteRequest = {
  // This is for documentation. Actual contents will be loaded by gRPC.
};

/**
 * Request to update an existing note
 *
 * @property {string} name
 *   The name of the note.
 *   Should be of the form "projects/{provider_id}/notes/{note_id}".
 *
 * @property {Object} note
 *   The updated note.
 *
 *   This object should have the same structure as [Note]{@link google.devtools.containeranalysis.v1alpha1.Note}
 *
 * @property {Object} updateMask
 *   The fields to update.
 *
 *   This object should have the same structure as [FieldMask]{@link google.protobuf.FieldMask}
 *
 * @typedef UpdateNoteRequest
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.UpdateNoteRequest definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
 */
const UpdateNoteRequest = {
  // This is for documentation. Actual contents will be loaded by gRPC.
};

/**
 * Request to list occurrences.
 *
 * @property {string} name
 *   The name field will contain the note name for example:
 *     "provider/{provider_id}/notes/{note_id}"
 *
 * @property {string} filter
 *   The filter expression.
 *
 * @property {number} pageSize
 *   Number of notes to return in the list.
 *
 * @property {string} pageToken
 *   Token to provide to skip to a particular spot in the list.
 *
 * @typedef ListNoteOccurrencesRequest
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.ListNoteOccurrencesRequest definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
 */
const ListNoteOccurrencesRequest = {
  // This is for documentation. Actual contents will be loaded by gRPC.
};

/**
 * Response including listed occurrences for a note.
 *
 * @property {Object[]} occurrences
 *   The occurrences attached to the specified note.
 *
 *   This object should have the same structure as [Occurrence]{@link google.devtools.containeranalysis.v1alpha1.Occurrence}
 *
 * @property {string} nextPageToken
 *   Token to receive the next page of notes.
 *
 * @typedef ListNoteOccurrencesResponse
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.ListNoteOccurrencesResponse definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
 */
const ListNoteOccurrencesResponse = {
  // This is for documentation. Actual contents will be loaded by gRPC.
};

/**
 * Request for creating an operation
 *
 * @property {string} parent
 *   The project Id that this operation should be created under.
 *
 * @property {string} operationId
 *   The ID to use for this operation.
 *
 * @property {Object} operation
 *   The operation to create.
 *
 *   This object should have the same structure as [Operation]{@link google.longrunning.Operation}
 *
 * @typedef CreateOperationRequest
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.CreateOperationRequest definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
 */
const CreateOperationRequest = {
  // This is for documentation. Actual contents will be loaded by gRPC.
};

/**
 * Request for updating an existing operation
 *
 * @property {string} name
 *   The name of the Operation.
 *   Should be of the form "projects/{provider_id}/operations/{operation_id}".
 *
 * @property {Object} operation
 *   The operation to create.
 *
 *   This object should have the same structure as [Operation]{@link google.longrunning.Operation}
 *
 * @property {Object} updateMask
 *   This object should have the same structure as [FieldMask]{@link google.protobuf.FieldMask}
 *
 * @typedef UpdateOperationRequest
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.UpdateOperationRequest definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
 */
const UpdateOperationRequest = {
  // This is for documentation. Actual contents will be loaded by gRPC.
};

/**
 * Metadata for all operations used and required for all operations
 * that created by Container Analysis Providers
 *
 * @property {Object} createTime
 *   Output only. The time this operation was created.
 *
 *   This object should have the same structure as [Timestamp]{@link google.protobuf.Timestamp}
 *
 * @property {Object} endTime
 *   Output only. The time that this operation was marked completed or failed.
 *
 *   This object should have the same structure as [Timestamp]{@link google.protobuf.Timestamp}
 *
 * @typedef OperationMetadata
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.OperationMetadata definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
 */
const OperationMetadata = {
  // This is for documentation. Actual contents will be loaded by gRPC.
};

/**
 * Request to get the vulnz summary for some set of vulnerability Occurrences.
 *
 * @property {string} parent
 *   This contains the project Id for example: projects/{project_id}
 *
 * @property {string} filter
 *   The filter expression.
 *
 * @typedef GetVulnzOccurrencesSummaryRequest
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryRequest definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
 */
const GetVulnzOccurrencesSummaryRequest = {
  // This is for documentation. Actual contents will be loaded by gRPC.
};

/**
 * A summary of how many vulnz occurrences there are per severity type.
 * counts by groups, or if we should have different summary messages
 * like this.
 *
 * @property {Object[]} counts
 *   A map of how many occurrences were found for each severity.
 *
 *   This object should have the same structure as [SeverityCount]{@link google.devtools.containeranalysis.v1alpha1.SeverityCount}
 *
 * @typedef GetVulnzOccurrencesSummaryResponse
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryResponse definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
 */
const GetVulnzOccurrencesSummaryResponse = {
  // This is for documentation. Actual contents will be loaded by gRPC.

  /**
   * The number of occurrences created for a specific severity.
   *
   * @property {number} severity
   *   The severity of the occurrences.
   *
   *   The number should be among the values of [Severity]{@link google.devtools.containeranalysis.v1alpha1.Severity}
   *
   * @property {number} count
   *   The number of occurrences with the severity.
   *
   * @typedef SeverityCount
   * @memberof google.devtools.containeranalysis.v1alpha1
   * @see [google.devtools.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryResponse.SeverityCount definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
   */
  SeverityCount: {
    // This is for documentation. Actual contents will be loaded by gRPC.
  }
};

/**
 * Request to get a ScanConfig.
 *
 * @property {string} name
 *   The name of the ScanConfig in the form
 *   projects/{project_id}/scan_configs/{ScanConfig_id}
 *   instead.
 *
 * @typedef GetScanConfigRequest
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.GetScanConfigRequest definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
 */
const GetScanConfigRequest = {
  // This is for documentation. Actual contents will be loaded by gRPC.
};

/**
 * Request to list the available scan configurations.
 *
 * @property {string} parent
 *   This containers the project Id i.e.: projects/{project_id}
 *   instead.
 *
 * @property {string} filter
 *   The filter expression.
 *
 * @property {number} pageSize
 *   The number of items to return.
 *
 * @property {string} pageToken
 *   The page token to use for the next request.
 *
 * @typedef ListScanConfigsRequest
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.ListScanConfigsRequest definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
 */
const ListScanConfigsRequest = {
  // This is for documentation. Actual contents will be loaded by gRPC.
};

/**
 * A list of ScanConfigs for the project.
 *
 * @property {Object[]} scanConfigs
 *   The set of scan configs
 *
 *   This object should have the same structure as [ScanConfig]{@link google.devtools.containeranalysis.v1alpha1.ScanConfig}
 *
 * @property {string} nextPageToken
 *   A page token to pass in order to get more scans.
 *
 * @typedef ListScanConfigsResponse
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.ListScanConfigsResponse definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
 */
const ListScanConfigsResponse = {
  // This is for documentation. Actual contents will be loaded by gRPC.
};

/**
 * A request to update a ScanConfig.
 *
 * @property {string} name
 *   The scan config to update of the form
 *   projects/{project_id}/scan_configs/{ScanConfig_id}
 *   instead.
 *
 * @property {Object} scanConfig
 *   The new scan configuration
 *
 *   This object should have the same structure as [ScanConfig]{@link google.devtools.containeranalysis.v1alpha1.ScanConfig}
 *
 * @property {Object} updateMask
 *   This object should have the same structure as [FieldMask]{@link google.protobuf.FieldMask}
 *
 * @typedef UpdateScanConfigRequest
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.UpdateScanConfigRequest definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/containeranalysis.proto}
 */
const UpdateScanConfigRequest = {
  // This is for documentation. Actual contents will be loaded by gRPC.
};