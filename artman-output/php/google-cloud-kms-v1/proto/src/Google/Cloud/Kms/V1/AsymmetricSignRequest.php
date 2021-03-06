<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/kms/v1/service.proto

namespace Google\Cloud\Kms\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request message for [KeyManagementService.AsymmetricSign][google.cloud.kms.v1.KeyManagementService.AsymmetricSign].
 *
 * Generated from protobuf message <code>google.cloud.kms.v1.AsymmetricSignRequest</code>
 */
class AsymmetricSignRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The resource name of the [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] to use for signing.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $name = '';
    /**
     * Required. The digest of the data to sign. The digest must be produced with
     * the same digest algorithm as specified by the key version's
     * [algorithm][google.cloud.kms.v1.CryptoKeyVersion.algorithm].
     *
     * Generated from protobuf field <code>.google.cloud.kms.v1.Digest digest = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $digest = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           Required. The resource name of the [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] to use for signing.
     *     @type \Google\Cloud\Kms\V1\Digest $digest
     *           Required. The digest of the data to sign. The digest must be produced with
     *           the same digest algorithm as specified by the key version's
     *           [algorithm][google.cloud.kms.v1.CryptoKeyVersion.algorithm].
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Kms\V1\Service::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The resource name of the [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] to use for signing.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Required. The resource name of the [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] to use for signing.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setName($var)
    {
        GPBUtil::checkString($var, True);
        $this->name = $var;

        return $this;
    }

    /**
     * Required. The digest of the data to sign. The digest must be produced with
     * the same digest algorithm as specified by the key version's
     * [algorithm][google.cloud.kms.v1.CryptoKeyVersion.algorithm].
     *
     * Generated from protobuf field <code>.google.cloud.kms.v1.Digest digest = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\Kms\V1\Digest
     */
    public function getDigest()
    {
        return $this->digest;
    }

    /**
     * Required. The digest of the data to sign. The digest must be produced with
     * the same digest algorithm as specified by the key version's
     * [algorithm][google.cloud.kms.v1.CryptoKeyVersion.algorithm].
     *
     * Generated from protobuf field <code>.google.cloud.kms.v1.Digest digest = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\Kms\V1\Digest $var
     * @return $this
     */
    public function setDigest($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Kms\V1\Digest::class);
        $this->digest = $var;

        return $this;
    }

}

