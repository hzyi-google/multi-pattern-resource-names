<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/devtools/containeranalysis/v1beta1/common/common.proto

namespace Grafeas\V1beta1;

use UnexpectedValueException;

/**
 * Kind represents the kinds of notes supported.
 *
 * Protobuf type <code>grafeas.v1beta1.NoteKind</code>
 */
class NoteKind
{
    /**
     * Unknown.
     *
     * Generated from protobuf enum <code>NOTE_KIND_UNSPECIFIED = 0;</code>
     */
    const NOTE_KIND_UNSPECIFIED = 0;
    /**
     * The note and occurrence represent a package vulnerability.
     *
     * Generated from protobuf enum <code>VULNERABILITY = 1;</code>
     */
    const VULNERABILITY = 1;
    /**
     * The note and occurrence assert build provenance.
     *
     * Generated from protobuf enum <code>BUILD = 2;</code>
     */
    const BUILD = 2;
    /**
     * This represents an image basis relationship.
     *
     * Generated from protobuf enum <code>IMAGE = 3;</code>
     */
    const IMAGE = 3;
    /**
     * This represents a package installed via a package manager.
     *
     * Generated from protobuf enum <code>PACKAGE = 4;</code>
     */
    const PACKAGE = 4;
    /**
     * The note and occurrence track deployment events.
     *
     * Generated from protobuf enum <code>DEPLOYMENT = 5;</code>
     */
    const DEPLOYMENT = 5;
    /**
     * The note and occurrence track the initial discovery status of a resource.
     *
     * Generated from protobuf enum <code>DISCOVERY = 6;</code>
     */
    const DISCOVERY = 6;
    /**
     * This represents a logical "role" that can attest to artifacts.
     *
     * Generated from protobuf enum <code>ATTESTATION = 7;</code>
     */
    const ATTESTATION = 7;

    private static $valueToName = [
        self::NOTE_KIND_UNSPECIFIED => 'NOTE_KIND_UNSPECIFIED',
        self::VULNERABILITY => 'VULNERABILITY',
        self::BUILD => 'BUILD',
        self::IMAGE => 'IMAGE',
        self::PACKAGE => 'PACKAGE',
        self::DEPLOYMENT => 'DEPLOYMENT',
        self::DISCOVERY => 'DISCOVERY',
        self::ATTESTATION => 'ATTESTATION',
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

