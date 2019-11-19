<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/bigquery/datatransfer/v1/transfer.proto

namespace Google\Cloud\BigQuery\DataTransfer\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Represents a data transfer run.
 *
 * Generated from protobuf message <code>google.cloud.bigquery.datatransfer.v1.TransferRun</code>
 */
class TransferRun extends \Google\Protobuf\Internal\Message
{
    /**
     * The resource name of the transfer run.
     * Transfer run names have the form
     * `projects/{project_id}/locations/{location}/transferConfigs/{config_id}/runs/{run_id}`.
     * The name is ignored when creating a transfer run.
     *
     * Generated from protobuf field <code>string name = 1;</code>
     */
    private $name = '';
    /**
     * Minimum time after which a transfer run can be started.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp schedule_time = 3;</code>
     */
    private $schedule_time = null;
    /**
     * For batch transfer runs, specifies the date and time of the data should be
     * ingested.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp run_time = 10;</code>
     */
    private $run_time = null;
    /**
     * Status of the transfer run.
     *
     * Generated from protobuf field <code>.google.rpc.Status error_status = 21;</code>
     */
    private $error_status = null;
    /**
     * Output only. Time when transfer run was started.
     * Parameter ignored by server for input requests.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp start_time = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    private $start_time = null;
    /**
     * Output only. Time when transfer run ended.
     * Parameter ignored by server for input requests.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp end_time = 5 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    private $end_time = null;
    /**
     * Output only. Last time the data transfer run state was updated.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp update_time = 6 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    private $update_time = null;
    /**
     * Output only. Data transfer specific parameters.
     *
     * Generated from protobuf field <code>.google.protobuf.Struct params = 9 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    private $params = null;
    /**
     * Output only. Data source id.
     *
     * Generated from protobuf field <code>string data_source_id = 7 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    private $data_source_id = '';
    /**
     * Data transfer run state. Ignored for input requests.
     *
     * Generated from protobuf field <code>.google.cloud.bigquery.datatransfer.v1.TransferState state = 8;</code>
     */
    private $state = 0;
    /**
     * Deprecated. Unique ID of the user on whose behalf transfer is done.
     *
     * Generated from protobuf field <code>int64 user_id = 11;</code>
     */
    private $user_id = 0;
    /**
     * Output only. Describes the schedule of this transfer run if it was
     * created as part of a regular schedule. For batch transfer runs that are
     * scheduled manually, this is empty.
     * NOTE: the system might choose to delay the schedule depending on the
     * current load, so `schedule_time` doesn't always match this.
     *
     * Generated from protobuf field <code>string schedule = 12 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    private $schedule = '';
    protected $destination;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           The resource name of the transfer run.
     *           Transfer run names have the form
     *           `projects/{project_id}/locations/{location}/transferConfigs/{config_id}/runs/{run_id}`.
     *           The name is ignored when creating a transfer run.
     *     @type \Google\Protobuf\Timestamp $schedule_time
     *           Minimum time after which a transfer run can be started.
     *     @type \Google\Protobuf\Timestamp $run_time
     *           For batch transfer runs, specifies the date and time of the data should be
     *           ingested.
     *     @type \Google\Rpc\Status $error_status
     *           Status of the transfer run.
     *     @type \Google\Protobuf\Timestamp $start_time
     *           Output only. Time when transfer run was started.
     *           Parameter ignored by server for input requests.
     *     @type \Google\Protobuf\Timestamp $end_time
     *           Output only. Time when transfer run ended.
     *           Parameter ignored by server for input requests.
     *     @type \Google\Protobuf\Timestamp $update_time
     *           Output only. Last time the data transfer run state was updated.
     *     @type \Google\Protobuf\Struct $params
     *           Output only. Data transfer specific parameters.
     *     @type string $destination_dataset_id
     *           Output only. The BigQuery target dataset id.
     *     @type string $data_source_id
     *           Output only. Data source id.
     *     @type int $state
     *           Data transfer run state. Ignored for input requests.
     *     @type int|string $user_id
     *           Deprecated. Unique ID of the user on whose behalf transfer is done.
     *     @type string $schedule
     *           Output only. Describes the schedule of this transfer run if it was
     *           created as part of a regular schedule. For batch transfer runs that are
     *           scheduled manually, this is empty.
     *           NOTE: the system might choose to delay the schedule depending on the
     *           current load, so `schedule_time` doesn't always match this.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Bigquery\Datatransfer\V1\Transfer::initOnce();
        parent::__construct($data);
    }

    /**
     * The resource name of the transfer run.
     * Transfer run names have the form
     * `projects/{project_id}/locations/{location}/transferConfigs/{config_id}/runs/{run_id}`.
     * The name is ignored when creating a transfer run.
     *
     * Generated from protobuf field <code>string name = 1;</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * The resource name of the transfer run.
     * Transfer run names have the form
     * `projects/{project_id}/locations/{location}/transferConfigs/{config_id}/runs/{run_id}`.
     * The name is ignored when creating a transfer run.
     *
     * Generated from protobuf field <code>string name = 1;</code>
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
     * Minimum time after which a transfer run can be started.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp schedule_time = 3;</code>
     * @return \Google\Protobuf\Timestamp
     */
    public function getScheduleTime()
    {
        return $this->schedule_time;
    }

    /**
     * Minimum time after which a transfer run can be started.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp schedule_time = 3;</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setScheduleTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->schedule_time = $var;

        return $this;
    }

    /**
     * For batch transfer runs, specifies the date and time of the data should be
     * ingested.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp run_time = 10;</code>
     * @return \Google\Protobuf\Timestamp
     */
    public function getRunTime()
    {
        return $this->run_time;
    }

    /**
     * For batch transfer runs, specifies the date and time of the data should be
     * ingested.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp run_time = 10;</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setRunTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->run_time = $var;

        return $this;
    }

    /**
     * Status of the transfer run.
     *
     * Generated from protobuf field <code>.google.rpc.Status error_status = 21;</code>
     * @return \Google\Rpc\Status
     */
    public function getErrorStatus()
    {
        return $this->error_status;
    }

    /**
     * Status of the transfer run.
     *
     * Generated from protobuf field <code>.google.rpc.Status error_status = 21;</code>
     * @param \Google\Rpc\Status $var
     * @return $this
     */
    public function setErrorStatus($var)
    {
        GPBUtil::checkMessage($var, \Google\Rpc\Status::class);
        $this->error_status = $var;

        return $this;
    }

    /**
     * Output only. Time when transfer run was started.
     * Parameter ignored by server for input requests.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp start_time = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Protobuf\Timestamp
     */
    public function getStartTime()
    {
        return $this->start_time;
    }

    /**
     * Output only. Time when transfer run was started.
     * Parameter ignored by server for input requests.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp start_time = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setStartTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->start_time = $var;

        return $this;
    }

    /**
     * Output only. Time when transfer run ended.
     * Parameter ignored by server for input requests.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp end_time = 5 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Protobuf\Timestamp
     */
    public function getEndTime()
    {
        return $this->end_time;
    }

    /**
     * Output only. Time when transfer run ended.
     * Parameter ignored by server for input requests.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp end_time = 5 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setEndTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->end_time = $var;

        return $this;
    }

    /**
     * Output only. Last time the data transfer run state was updated.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp update_time = 6 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Protobuf\Timestamp
     */
    public function getUpdateTime()
    {
        return $this->update_time;
    }

    /**
     * Output only. Last time the data transfer run state was updated.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp update_time = 6 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setUpdateTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->update_time = $var;

        return $this;
    }

    /**
     * Output only. Data transfer specific parameters.
     *
     * Generated from protobuf field <code>.google.protobuf.Struct params = 9 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Protobuf\Struct
     */
    public function getParams()
    {
        return $this->params;
    }

    /**
     * Output only. Data transfer specific parameters.
     *
     * Generated from protobuf field <code>.google.protobuf.Struct params = 9 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Protobuf\Struct $var
     * @return $this
     */
    public function setParams($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Struct::class);
        $this->params = $var;

        return $this;
    }

    /**
     * Output only. The BigQuery target dataset id.
     *
     * Generated from protobuf field <code>string destination_dataset_id = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return string
     */
    public function getDestinationDatasetId()
    {
        return $this->readOneof(2);
    }

    /**
     * Output only. The BigQuery target dataset id.
     *
     * Generated from protobuf field <code>string destination_dataset_id = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param string $var
     * @return $this
     */
    public function setDestinationDatasetId($var)
    {
        GPBUtil::checkString($var, True);
        $this->writeOneof(2, $var);

        return $this;
    }

    /**
     * Output only. Data source id.
     *
     * Generated from protobuf field <code>string data_source_id = 7 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return string
     */
    public function getDataSourceId()
    {
        return $this->data_source_id;
    }

    /**
     * Output only. Data source id.
     *
     * Generated from protobuf field <code>string data_source_id = 7 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param string $var
     * @return $this
     */
    public function setDataSourceId($var)
    {
        GPBUtil::checkString($var, True);
        $this->data_source_id = $var;

        return $this;
    }

    /**
     * Data transfer run state. Ignored for input requests.
     *
     * Generated from protobuf field <code>.google.cloud.bigquery.datatransfer.v1.TransferState state = 8;</code>
     * @return int
     */
    public function getState()
    {
        return $this->state;
    }

    /**
     * Data transfer run state. Ignored for input requests.
     *
     * Generated from protobuf field <code>.google.cloud.bigquery.datatransfer.v1.TransferState state = 8;</code>
     * @param int $var
     * @return $this
     */
    public function setState($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\BigQuery\DataTransfer\V1\TransferState::class);
        $this->state = $var;

        return $this;
    }

    /**
     * Deprecated. Unique ID of the user on whose behalf transfer is done.
     *
     * Generated from protobuf field <code>int64 user_id = 11;</code>
     * @return int|string
     */
    public function getUserId()
    {
        return $this->user_id;
    }

    /**
     * Deprecated. Unique ID of the user on whose behalf transfer is done.
     *
     * Generated from protobuf field <code>int64 user_id = 11;</code>
     * @param int|string $var
     * @return $this
     */
    public function setUserId($var)
    {
        GPBUtil::checkInt64($var);
        $this->user_id = $var;

        return $this;
    }

    /**
     * Output only. Describes the schedule of this transfer run if it was
     * created as part of a regular schedule. For batch transfer runs that are
     * scheduled manually, this is empty.
     * NOTE: the system might choose to delay the schedule depending on the
     * current load, so `schedule_time` doesn't always match this.
     *
     * Generated from protobuf field <code>string schedule = 12 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return string
     */
    public function getSchedule()
    {
        return $this->schedule;
    }

    /**
     * Output only. Describes the schedule of this transfer run if it was
     * created as part of a regular schedule. For batch transfer runs that are
     * scheduled manually, this is empty.
     * NOTE: the system might choose to delay the schedule depending on the
     * current load, so `schedule_time` doesn't always match this.
     *
     * Generated from protobuf field <code>string schedule = 12 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param string $var
     * @return $this
     */
    public function setSchedule($var)
    {
        GPBUtil::checkString($var, True);
        $this->schedule = $var;

        return $this;
    }

    /**
     * @return string
     */
    public function getDestination()
    {
        return $this->whichOneof("destination");
    }

}

