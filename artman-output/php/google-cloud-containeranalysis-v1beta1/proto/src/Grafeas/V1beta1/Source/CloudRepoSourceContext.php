<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/devtools/containeranalysis/v1beta1/source/source.proto

namespace Grafeas\V1beta1\Source;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A CloudRepoSourceContext denotes a particular revision in a Google Cloud
 * Source Repo.
 *
 * Generated from protobuf message <code>grafeas.v1beta1.source.CloudRepoSourceContext</code>
 */
class CloudRepoSourceContext extends \Google\Protobuf\Internal\Message
{
    /**
     * The ID of the repo.
     *
     * Generated from protobuf field <code>.grafeas.v1beta1.source.RepoId repo_id = 1;</code>
     */
    protected $repo_id = null;
    protected $revision;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Grafeas\V1beta1\Source\RepoId $repo_id
     *           The ID of the repo.
     *     @type string $revision_id
     *           A revision ID.
     *     @type \Grafeas\V1beta1\Source\AliasContext $alias_context
     *           An alias, which may be a branch or tag.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Devtools\Containeranalysis\V1Beta1\Source\Source::initOnce();
        parent::__construct($data);
    }

    /**
     * The ID of the repo.
     *
     * Generated from protobuf field <code>.grafeas.v1beta1.source.RepoId repo_id = 1;</code>
     * @return \Grafeas\V1beta1\Source\RepoId
     */
    public function getRepoId()
    {
        return $this->repo_id;
    }

    /**
     * The ID of the repo.
     *
     * Generated from protobuf field <code>.grafeas.v1beta1.source.RepoId repo_id = 1;</code>
     * @param \Grafeas\V1beta1\Source\RepoId $var
     * @return $this
     */
    public function setRepoId($var)
    {
        GPBUtil::checkMessage($var, \Grafeas\V1beta1\Source\RepoId::class);
        $this->repo_id = $var;

        return $this;
    }

    /**
     * A revision ID.
     *
     * Generated from protobuf field <code>string revision_id = 2;</code>
     * @return string
     */
    public function getRevisionId()
    {
        return $this->readOneof(2);
    }

    /**
     * A revision ID.
     *
     * Generated from protobuf field <code>string revision_id = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setRevisionId($var)
    {
        GPBUtil::checkString($var, True);
        $this->writeOneof(2, $var);

        return $this;
    }

    /**
     * An alias, which may be a branch or tag.
     *
     * Generated from protobuf field <code>.grafeas.v1beta1.source.AliasContext alias_context = 3;</code>
     * @return \Grafeas\V1beta1\Source\AliasContext
     */
    public function getAliasContext()
    {
        return $this->readOneof(3);
    }

    /**
     * An alias, which may be a branch or tag.
     *
     * Generated from protobuf field <code>.grafeas.v1beta1.source.AliasContext alias_context = 3;</code>
     * @param \Grafeas\V1beta1\Source\AliasContext $var
     * @return $this
     */
    public function setAliasContext($var)
    {
        GPBUtil::checkMessage($var, \Grafeas\V1beta1\Source\AliasContext::class);
        $this->writeOneof(3, $var);

        return $this;
    }

    /**
     * @return string
     */
    public function getRevision()
    {
        return $this->whichOneof("revision");
    }

}

