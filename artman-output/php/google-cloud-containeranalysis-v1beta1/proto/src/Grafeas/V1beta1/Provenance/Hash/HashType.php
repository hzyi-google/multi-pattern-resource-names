<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/devtools/containeranalysis/v1beta1/provenance/provenance.proto

namespace Grafeas\V1beta1\Provenance\Hash;

use UnexpectedValueException;

/**
 * Specifies the hash algorithm, if any.
 *
 * Protobuf type <code>grafeas.v1beta1.provenance.Hash.HashType</code>
 */
class HashType
{
    /**
     * Unknown.
     *
     * Generated from protobuf enum <code>HASH_TYPE_UNSPECIFIED = 0;</code>
     */
    const HASH_TYPE_UNSPECIFIED = 0;
    /**
     * A SHA-256 hash.
     *
     * Generated from protobuf enum <code>SHA256 = 1;</code>
     */
    const SHA256 = 1;

    private static $valueToName = [
        self::HASH_TYPE_UNSPECIFIED => 'HASH_TYPE_UNSPECIFIED',
        self::SHA256 => 'SHA256',
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
class_alias(HashType::class, \Grafeas\V1beta1\Provenance\Hash_HashType::class);

