<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/devtools/containeranalysis/v1alpha1/containeranalysis.proto

namespace Google\Devtools\Containeranalysis\V1alpha1\PgpSignedAttestation;

use UnexpectedValueException;

/**
 * Type (for example schema) of the attestation payload that was signed.
 *
 * Protobuf type <code>google.devtools.containeranalysis.v1alpha1.PgpSignedAttestation.ContentType</code>
 */
class ContentType
{
    /**
     * `ContentType` is not set.
     *
     * Generated from protobuf enum <code>CONTENT_TYPE_UNSPECIFIED = 0;</code>
     */
    const CONTENT_TYPE_UNSPECIFIED = 0;
    /**
     * Atomic format attestation signature. See
     * https://github.com/containers/image/blob/8a5d2f82a6e3263290c8e0276c3e0f64e77723e7/docs/atomic-signature.md
     * The payload extracted from `signature` is a JSON blob conforming to the
     * linked schema.
     *
     * Generated from protobuf enum <code>SIMPLE_SIGNING_JSON = 1;</code>
     */
    const SIMPLE_SIGNING_JSON = 1;

    private static $valueToName = [
        self::CONTENT_TYPE_UNSPECIFIED => 'CONTENT_TYPE_UNSPECIFIED',
        self::SIMPLE_SIGNING_JSON => 'SIMPLE_SIGNING_JSON',
    ];

    public static function name($value)
    {
        if (!isset(self::$valueToName[$value])) {
            throw new UnexpectedValueException(sprintf(
                    'Enum %s has no name defined for value %s', __CLASS__, $value));
        }
        return self::$valueToName[$value];
    }


    public static function value($name)
    {
        $const = __CLASS__ . '::' . strtoupper($name);
        if (!defined($const)) {
            throw new UnexpectedValueException(sprintf(
                    'Enum %s has no value defined for name %s', __CLASS__, $name));
        }
        return constant($const);
    }
}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(ContentType::class, \Google\Devtools\Containeranalysis\V1alpha1\PgpSignedAttestation_ContentType::class);

