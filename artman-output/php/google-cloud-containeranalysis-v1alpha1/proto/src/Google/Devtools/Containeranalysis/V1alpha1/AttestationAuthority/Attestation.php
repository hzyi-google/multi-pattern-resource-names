<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/devtools/containeranalysis/v1alpha1/containeranalysis.proto

namespace Google\Devtools\Containeranalysis\V1alpha1\AttestationAuthority;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

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
 * Generated from protobuf message <code>google.devtools.containeranalysis.v1alpha1.AttestationAuthority.Attestation</code>
 */
class Attestation extends \Google\Protobuf\Internal\Message
{
    protected $signature;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Devtools\Containeranalysis\V1alpha1\PgpSignedAttestation $pgp_signed_attestation
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Devtools\Containeranalysis\V1Alpha1\Containeranalysis::initOnce();
        parent::__construct($data);
    }

    /**
     * Generated from protobuf field <code>.google.devtools.containeranalysis.v1alpha1.PgpSignedAttestation pgp_signed_attestation = 1;</code>
     * @return \Google\Devtools\Containeranalysis\V1alpha1\PgpSignedAttestation
     */
    public function getPgpSignedAttestation()
    {
        return $this->readOneof(1);
    }

    /**
     * Generated from protobuf field <code>.google.devtools.containeranalysis.v1alpha1.PgpSignedAttestation pgp_signed_attestation = 1;</code>
     * @param \Google\Devtools\Containeranalysis\V1alpha1\PgpSignedAttestation $var
     * @return $this
     */
    public function setPgpSignedAttestation($var)
    {
        GPBUtil::checkMessage($var, \Google\Devtools\Containeranalysis\V1alpha1\PgpSignedAttestation::class);
        $this->writeOneof(1, $var);

        return $this;
    }

    /**
     * @return string
     */
    public function getSignature()
    {
        return $this->whichOneof("signature");
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(Attestation::class, \Google\Devtools\Containeranalysis\V1alpha1\AttestationAuthority_Attestation::class);

