<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/talent/v4beta1/profile_service.proto

namespace Google\Cloud\Talent\V4beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Profile entry with metadata inside [SearchProfilesResponse][google.cloud.talent.v4beta1.SearchProfilesResponse].
 *
 * Generated from protobuf message <code>google.cloud.talent.v4beta1.SummarizedProfile</code>
 */
class SummarizedProfile extends \Google\Protobuf\Internal\Message
{
    /**
     * A list of profiles that are linked by [Profile.group_id][google.cloud.talent.v4beta1.Profile.group_id].
     *
     * Generated from protobuf field <code>repeated .google.cloud.talent.v4beta1.Profile profiles = 1;</code>
     */
    private $profiles;
    /**
     * A profile summary shows the profile summary and how the profile matches the
     * search query.
     * In profile summary, the profiles with the same [Profile.group_id][google.cloud.talent.v4beta1.Profile.group_id] are
     * merged together. Among profiles, same education/employment records may be
     * slightly different but they are merged into one with best efforts.
     * For example, in one profile the school name is "UC Berkeley" and the field
     * study is "Computer Science" and in another one the school name is
     * "University of California at Berkeley" and the field study is "CS". The API
     * merges these two inputs into one and selects one value for each field. For
     * example, the school name in summary is set to "University of California at
     * Berkeley" and the field of study is set to "Computer Science".
     *
     * Generated from protobuf field <code>.google.cloud.talent.v4beta1.Profile summary = 2;</code>
     */
    protected $summary = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Talent\V4beta1\Profile[]|\Google\Protobuf\Internal\RepeatedField $profiles
     *           A list of profiles that are linked by [Profile.group_id][google.cloud.talent.v4beta1.Profile.group_id].
     *     @type \Google\Cloud\Talent\V4beta1\Profile $summary
     *           A profile summary shows the profile summary and how the profile matches the
     *           search query.
     *           In profile summary, the profiles with the same [Profile.group_id][google.cloud.talent.v4beta1.Profile.group_id] are
     *           merged together. Among profiles, same education/employment records may be
     *           slightly different but they are merged into one with best efforts.
     *           For example, in one profile the school name is "UC Berkeley" and the field
     *           study is "Computer Science" and in another one the school name is
     *           "University of California at Berkeley" and the field study is "CS". The API
     *           merges these two inputs into one and selects one value for each field. For
     *           example, the school name in summary is set to "University of California at
     *           Berkeley" and the field of study is set to "Computer Science".
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Talent\V4Beta1\ProfileService::initOnce();
        parent::__construct($data);
    }

    /**
     * A list of profiles that are linked by [Profile.group_id][google.cloud.talent.v4beta1.Profile.group_id].
     *
     * Generated from protobuf field <code>repeated .google.cloud.talent.v4beta1.Profile profiles = 1;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getProfiles()
    {
        return $this->profiles;
    }

    /**
     * A list of profiles that are linked by [Profile.group_id][google.cloud.talent.v4beta1.Profile.group_id].
     *
     * Generated from protobuf field <code>repeated .google.cloud.talent.v4beta1.Profile profiles = 1;</code>
     * @param \Google\Cloud\Talent\V4beta1\Profile[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setProfiles($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\Talent\V4beta1\Profile::class);
        $this->profiles = $arr;

        return $this;
    }

    /**
     * A profile summary shows the profile summary and how the profile matches the
     * search query.
     * In profile summary, the profiles with the same [Profile.group_id][google.cloud.talent.v4beta1.Profile.group_id] are
     * merged together. Among profiles, same education/employment records may be
     * slightly different but they are merged into one with best efforts.
     * For example, in one profile the school name is "UC Berkeley" and the field
     * study is "Computer Science" and in another one the school name is
     * "University of California at Berkeley" and the field study is "CS". The API
     * merges these two inputs into one and selects one value for each field. For
     * example, the school name in summary is set to "University of California at
     * Berkeley" and the field of study is set to "Computer Science".
     *
     * Generated from protobuf field <code>.google.cloud.talent.v4beta1.Profile summary = 2;</code>
     * @return \Google\Cloud\Talent\V4beta1\Profile
     */
    public function getSummary()
    {
        return $this->summary;
    }

    /**
     * A profile summary shows the profile summary and how the profile matches the
     * search query.
     * In profile summary, the profiles with the same [Profile.group_id][google.cloud.talent.v4beta1.Profile.group_id] are
     * merged together. Among profiles, same education/employment records may be
     * slightly different but they are merged into one with best efforts.
     * For example, in one profile the school name is "UC Berkeley" and the field
     * study is "Computer Science" and in another one the school name is
     * "University of California at Berkeley" and the field study is "CS". The API
     * merges these two inputs into one and selects one value for each field. For
     * example, the school name in summary is set to "University of California at
     * Berkeley" and the field of study is set to "Computer Science".
     *
     * Generated from protobuf field <code>.google.cloud.talent.v4beta1.Profile summary = 2;</code>
     * @param \Google\Cloud\Talent\V4beta1\Profile $var
     * @return $this
     */
    public function setSummary($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Talent\V4beta1\Profile::class);
        $this->summary = $var;

        return $this;
    }

}
