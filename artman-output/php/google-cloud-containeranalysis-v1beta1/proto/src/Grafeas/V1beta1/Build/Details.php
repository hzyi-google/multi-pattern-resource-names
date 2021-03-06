<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/devtools/containeranalysis/v1beta1/build/build.proto

namespace Grafeas\V1beta1\Build;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Details of a build occurrence.
 *
 * Generated from protobuf message <code>grafeas.v1beta1.build.Details</code>
 */
class Details extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The actual provenance for the build.
     *
     * Generated from protobuf field <code>.grafeas.v1beta1.provenance.BuildProvenance provenance = 1;</code>
     */
    protected $provenance = null;
    /**
     * Serialized JSON representation of the provenance, used in generating the
     * build signature in the corresponding build note. After verifying the
     * signature, `provenance_bytes` can be unmarshalled and compared to the
     * provenance to confirm that it is unchanged. A base64-encoded string
     * representation of the provenance bytes is used for the signature in order
     * to interoperate with openssl which expects this format for signature
     * verification.
     * The serialized form is captured both to avoid ambiguity in how the
     * provenance is marshalled to json as well to prevent incompatibilities with
     * future changes.
     *
     * Generated from protobuf field <code>string provenance_bytes = 2;</code>
     */
    protected $provenance_bytes = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Grafeas\V1beta1\Provenance\BuildProvenance $provenance
     *           Required. The actual provenance for the build.
     *     @type string $provenance_bytes
     *           Serialized JSON representation of the provenance, used in generating the
     *           build signature in the corresponding build note. After verifying the
     *           signature, `provenance_bytes` can be unmarshalled and compared to the
     *           provenance to confirm that it is unchanged. A base64-encoded string
     *           representation of the provenance bytes is used for the signature in order
     *           to interoperate with openssl which expects this format for signature
     *           verification.
     *           The serialized form is captured both to avoid ambiguity in how the
     *           provenance is marshalled to json as well to prevent incompatibilities with
     *           future changes.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Devtools\Containeranalysis\V1Beta1\Build\Build::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The actual provenance for the build.
     *
     * Generated from protobuf field <code>.grafeas.v1beta1.provenance.BuildProvenance provenance = 1;</code>
     * @return \Grafeas\V1beta1\Provenance\BuildProvenance
     */
    public function getProvenance()
    {
        return $this->provenance;
    }

    /**
     * Required. The actual provenance for the build.
     *
     * Generated from protobuf field <code>.grafeas.v1beta1.provenance.BuildProvenance provenance = 1;</code>
     * @param \Grafeas\V1beta1\Provenance\BuildProvenance $var
     * @return $this
     */
    public function setProvenance($var)
    {
        GPBUtil::checkMessage($var, \Grafeas\V1beta1\Provenance\BuildProvenance::class);
        $this->provenance = $var;

        return $this;
    }

    /**
     * Serialized JSON representation of the provenance, used in generating the
     * build signature in the corresponding build note. After verifying the
     * signature, `provenance_bytes` can be unmarshalled and compared to the
     * provenance to confirm that it is unchanged. A base64-encoded string
     * representation of the provenance bytes is used for the signature in order
     * to interoperate with openssl which expects this format for signature
     * verification.
     * The serialized form is captured both to avoid ambiguity in how the
     * provenance is marshalled to json as well to prevent incompatibilities with
     * future changes.
     *
     * Generated from protobuf field <code>string provenance_bytes = 2;</code>
     * @return string
     */
    public function getProvenanceBytes()
    {
        return $this->provenance_bytes;
    }

    /**
     * Serialized JSON representation of the provenance, used in generating the
     * build signature in the corresponding build note. After verifying the
     * signature, `provenance_bytes` can be unmarshalled and compared to the
     * provenance to confirm that it is unchanged. A base64-encoded string
     * representation of the provenance bytes is used for the signature in order
     * to interoperate with openssl which expects this format for signature
     * verification.
     * The serialized form is captured both to avoid ambiguity in how the
     * provenance is marshalled to json as well to prevent incompatibilities with
     * future changes.
     *
     * Generated from protobuf field <code>string provenance_bytes = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setProvenanceBytes($var)
    {
        GPBUtil::checkString($var, True);
        $this->provenance_bytes = $var;

        return $this;
    }

}

