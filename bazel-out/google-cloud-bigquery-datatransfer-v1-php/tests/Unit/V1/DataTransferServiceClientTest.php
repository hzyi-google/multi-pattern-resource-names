<?php
/*
 * Copyright 2019 Google LLC
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     https://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

/*
 * GENERATED CODE WARNING
 * This file was automatically generated - do not edit!
 */

namespace Google\Cloud\BigQuery\DataTransfer\Tests\Unit\V1;

use Google\Cloud\BigQuery\DataTransfer\V1\DataTransferServiceClient;
use Google\ApiCore\ApiException;
use Google\ApiCore\CredentialsWrapper;
use Google\ApiCore\Testing\GeneratedTest;
use Google\ApiCore\Testing\MockTransport;
use Google\Cloud\BigQuery\DataTransfer\V1\CheckValidCredsResponse;
use Google\Cloud\BigQuery\DataTransfer\V1\DataSource;
use Google\Cloud\BigQuery\DataTransfer\V1\ListDataSourcesResponse;
use Google\Cloud\BigQuery\DataTransfer\V1\ListTransferConfigsResponse;
use Google\Cloud\BigQuery\DataTransfer\V1\ListTransferLogsResponse;
use Google\Cloud\BigQuery\DataTransfer\V1\ListTransferRunsResponse;
use Google\Cloud\BigQuery\DataTransfer\V1\ScheduleTransferRunsResponse;
use Google\Cloud\BigQuery\DataTransfer\V1\StartManualTransferRunsResponse;
use Google\Cloud\BigQuery\DataTransfer\V1\TransferConfig;
use Google\Cloud\BigQuery\DataTransfer\V1\TransferRun;
use Google\Protobuf\Any;
use Google\Protobuf\GPBEmpty;
use Google\Rpc\Code;
use stdClass;

/**
 * @group datatransfer
 * @group gapic
 */
class DataTransferServiceClientTest extends GeneratedTest
{
    /**
     * @return TransportInterface
     */
    private function createTransport($deserialize = null)
    {
        return new MockTransport($deserialize);
    }

    /**
     * @return CredentialsWrapper
     */
    private function createCredentials()
    {
        return $this->getMockBuilder(CredentialsWrapper::class)
            ->disableOriginalConstructor()
            ->getMock();
    }

    /**
     * @return DataTransferServiceClient
     */
    private function createClient(array $options = [])
    {
        $options += [
            'credentials' => $this->createCredentials(),
        ];

        return new DataTransferServiceClient($options);
    }

    /**
     * @test
     */
    public function getDataSourceTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient(['transport' => $transport]);

        $this->assertTrue($transport->isExhausted());

        // Mock response
        $name = 'name3373707';
        $dataSourceId = 'dataSourceId-1015796374';
        $displayName = 'displayName1615086568';
        $description = 'description-1724546052';
        $clientId = 'clientId-1904089585';
        $supportsMultipleTransfers = true;
        $updateDeadlineSeconds = 991471694;
        $defaultSchedule = 'defaultSchedule-800168235';
        $supportsCustomSchedule = true;
        $helpUrl = 'helpUrl-789431439';
        $defaultDataRefreshWindowDays = 1804935157;
        $manualRunsDisabled = true;
        $expectedResponse = new DataSource();
        $expectedResponse->setName($name);
        $expectedResponse->setDataSourceId($dataSourceId);
        $expectedResponse->setDisplayName($displayName);
        $expectedResponse->setDescription($description);
        $expectedResponse->setClientId($clientId);
        $expectedResponse->setSupportsMultipleTransfers($supportsMultipleTransfers);
        $expectedResponse->setUpdateDeadlineSeconds($updateDeadlineSeconds);
        $expectedResponse->setDefaultSchedule($defaultSchedule);
        $expectedResponse->setSupportsCustomSchedule($supportsCustomSchedule);
        $expectedResponse->setHelpUrl($helpUrl);
        $expectedResponse->setDefaultDataRefreshWindowDays($defaultDataRefreshWindowDays);
        $expectedResponse->setManualRunsDisabled($manualRunsDisabled);
        $transport->addResponse($expectedResponse);

        $response = $client->getDataSource();
        $this->assertEquals($expectedResponse, $response);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.bigquery.datatransfer.v1.DataTransferService/GetDataSource', $actualFuncCall);

        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function getDataSourceExceptionTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient(['transport' => $transport]);

        $this->assertTrue($transport->isExhausted());

        $status = new stdClass();
        $status->code = Code::DATA_LOSS;
        $status->details = 'internal error';

        $expectedExceptionMessage = json_encode([
           'message' => 'internal error',
           'code' => Code::DATA_LOSS,
           'status' => 'DATA_LOSS',
           'details' => [],
        ], JSON_PRETTY_PRINT);
        $transport->addResponse(null, $status);

        try {
            $client->getDataSource();
            // If the $client method call did not throw, fail the test
            $this->fail('Expected an ApiException, but no exception was thrown.');
        } catch (ApiException $ex) {
            $this->assertEquals($status->code, $ex->getCode());
            $this->assertEquals($expectedExceptionMessage, $ex->getMessage());
        }

        // Call popReceivedCalls to ensure the stub is exhausted
        $transport->popReceivedCalls();
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function listDataSourcesTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient(['transport' => $transport]);

        $this->assertTrue($transport->isExhausted());

        // Mock response
        $nextPageToken = 'nextPageToken-1530815211';
        $expectedResponse = new ListDataSourcesResponse();
        $expectedResponse->setNextPageToken($nextPageToken);
        $transport->addResponse($expectedResponse);

        $response = $client->listDataSources();
        $this->assertEquals($expectedResponse, $response);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.bigquery.datatransfer.v1.DataTransferService/ListDataSources', $actualFuncCall);

        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function listDataSourcesExceptionTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient(['transport' => $transport]);

        $this->assertTrue($transport->isExhausted());

        $status = new stdClass();
        $status->code = Code::DATA_LOSS;
        $status->details = 'internal error';

        $expectedExceptionMessage = json_encode([
           'message' => 'internal error',
           'code' => Code::DATA_LOSS,
           'status' => 'DATA_LOSS',
           'details' => [],
        ], JSON_PRETTY_PRINT);
        $transport->addResponse(null, $status);

        try {
            $client->listDataSources();
            // If the $client method call did not throw, fail the test
            $this->fail('Expected an ApiException, but no exception was thrown.');
        } catch (ApiException $ex) {
            $this->assertEquals($status->code, $ex->getCode());
            $this->assertEquals($expectedExceptionMessage, $ex->getMessage());
        }

        // Call popReceivedCalls to ensure the stub is exhausted
        $transport->popReceivedCalls();
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function createTransferConfigTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient(['transport' => $transport]);

        $this->assertTrue($transport->isExhausted());

        // Mock response
        $name = 'name3373707';
        $destinationDatasetId = 'destinationDatasetId1541564179';
        $displayName = 'displayName1615086568';
        $dataSourceId = 'dataSourceId-1015796374';
        $schedule = 'schedule-697920873';
        $dataRefreshWindowDays = 327632845;
        $disabled = true;
        $userId = 147132913;
        $datasetRegion = 'datasetRegion959248539';
        $notificationPubsubTopic = 'notificationPubsubTopic1794281191';
        $expectedResponse = new TransferConfig();
        $expectedResponse->setName($name);
        $expectedResponse->setDestinationDatasetId($destinationDatasetId);
        $expectedResponse->setDisplayName($displayName);
        $expectedResponse->setDataSourceId($dataSourceId);
        $expectedResponse->setSchedule($schedule);
        $expectedResponse->setDataRefreshWindowDays($dataRefreshWindowDays);
        $expectedResponse->setDisabled($disabled);
        $expectedResponse->setUserId($userId);
        $expectedResponse->setDatasetRegion($datasetRegion);
        $expectedResponse->setNotificationPubsubTopic($notificationPubsubTopic);
        $transport->addResponse($expectedResponse);

        $response = $client->createTransferConfig();
        $this->assertEquals($expectedResponse, $response);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.bigquery.datatransfer.v1.DataTransferService/CreateTransferConfig', $actualFuncCall);

        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function createTransferConfigExceptionTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient(['transport' => $transport]);

        $this->assertTrue($transport->isExhausted());

        $status = new stdClass();
        $status->code = Code::DATA_LOSS;
        $status->details = 'internal error';

        $expectedExceptionMessage = json_encode([
           'message' => 'internal error',
           'code' => Code::DATA_LOSS,
           'status' => 'DATA_LOSS',
           'details' => [],
        ], JSON_PRETTY_PRINT);
        $transport->addResponse(null, $status);

        try {
            $client->createTransferConfig();
            // If the $client method call did not throw, fail the test
            $this->fail('Expected an ApiException, but no exception was thrown.');
        } catch (ApiException $ex) {
            $this->assertEquals($status->code, $ex->getCode());
            $this->assertEquals($expectedExceptionMessage, $ex->getMessage());
        }

        // Call popReceivedCalls to ensure the stub is exhausted
        $transport->popReceivedCalls();
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function updateTransferConfigTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient(['transport' => $transport]);

        $this->assertTrue($transport->isExhausted());

        // Mock response
        $name = 'name3373707';
        $destinationDatasetId = 'destinationDatasetId1541564179';
        $displayName = 'displayName1615086568';
        $dataSourceId = 'dataSourceId-1015796374';
        $schedule = 'schedule-697920873';
        $dataRefreshWindowDays = 327632845;
        $disabled = true;
        $userId = 147132913;
        $datasetRegion = 'datasetRegion959248539';
        $notificationPubsubTopic = 'notificationPubsubTopic1794281191';
        $expectedResponse = new TransferConfig();
        $expectedResponse->setName($name);
        $expectedResponse->setDestinationDatasetId($destinationDatasetId);
        $expectedResponse->setDisplayName($displayName);
        $expectedResponse->setDataSourceId($dataSourceId);
        $expectedResponse->setSchedule($schedule);
        $expectedResponse->setDataRefreshWindowDays($dataRefreshWindowDays);
        $expectedResponse->setDisabled($disabled);
        $expectedResponse->setUserId($userId);
        $expectedResponse->setDatasetRegion($datasetRegion);
        $expectedResponse->setNotificationPubsubTopic($notificationPubsubTopic);
        $transport->addResponse($expectedResponse);

        $response = $client->updateTransferConfig();
        $this->assertEquals($expectedResponse, $response);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.bigquery.datatransfer.v1.DataTransferService/UpdateTransferConfig', $actualFuncCall);

        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function updateTransferConfigExceptionTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient(['transport' => $transport]);

        $this->assertTrue($transport->isExhausted());

        $status = new stdClass();
        $status->code = Code::DATA_LOSS;
        $status->details = 'internal error';

        $expectedExceptionMessage = json_encode([
           'message' => 'internal error',
           'code' => Code::DATA_LOSS,
           'status' => 'DATA_LOSS',
           'details' => [],
        ], JSON_PRETTY_PRINT);
        $transport->addResponse(null, $status);

        try {
            $client->updateTransferConfig();
            // If the $client method call did not throw, fail the test
            $this->fail('Expected an ApiException, but no exception was thrown.');
        } catch (ApiException $ex) {
            $this->assertEquals($status->code, $ex->getCode());
            $this->assertEquals($expectedExceptionMessage, $ex->getMessage());
        }

        // Call popReceivedCalls to ensure the stub is exhausted
        $transport->popReceivedCalls();
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function deleteTransferConfigTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient(['transport' => $transport]);

        $this->assertTrue($transport->isExhausted());

        // Mock response
        $expectedResponse = new GPBEmpty();
        $transport->addResponse($expectedResponse);

        $client->deleteTransferConfig();
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.bigquery.datatransfer.v1.DataTransferService/DeleteTransferConfig', $actualFuncCall);

        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function deleteTransferConfigExceptionTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient(['transport' => $transport]);

        $this->assertTrue($transport->isExhausted());

        $status = new stdClass();
        $status->code = Code::DATA_LOSS;
        $status->details = 'internal error';

        $expectedExceptionMessage = json_encode([
           'message' => 'internal error',
           'code' => Code::DATA_LOSS,
           'status' => 'DATA_LOSS',
           'details' => [],
        ], JSON_PRETTY_PRINT);
        $transport->addResponse(null, $status);

        try {
            $client->deleteTransferConfig();
            // If the $client method call did not throw, fail the test
            $this->fail('Expected an ApiException, but no exception was thrown.');
        } catch (ApiException $ex) {
            $this->assertEquals($status->code, $ex->getCode());
            $this->assertEquals($expectedExceptionMessage, $ex->getMessage());
        }

        // Call popReceivedCalls to ensure the stub is exhausted
        $transport->popReceivedCalls();
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function getTransferConfigTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient(['transport' => $transport]);

        $this->assertTrue($transport->isExhausted());

        // Mock response
        $name = 'name3373707';
        $destinationDatasetId = 'destinationDatasetId1541564179';
        $displayName = 'displayName1615086568';
        $dataSourceId = 'dataSourceId-1015796374';
        $schedule = 'schedule-697920873';
        $dataRefreshWindowDays = 327632845;
        $disabled = true;
        $userId = 147132913;
        $datasetRegion = 'datasetRegion959248539';
        $notificationPubsubTopic = 'notificationPubsubTopic1794281191';
        $expectedResponse = new TransferConfig();
        $expectedResponse->setName($name);
        $expectedResponse->setDestinationDatasetId($destinationDatasetId);
        $expectedResponse->setDisplayName($displayName);
        $expectedResponse->setDataSourceId($dataSourceId);
        $expectedResponse->setSchedule($schedule);
        $expectedResponse->setDataRefreshWindowDays($dataRefreshWindowDays);
        $expectedResponse->setDisabled($disabled);
        $expectedResponse->setUserId($userId);
        $expectedResponse->setDatasetRegion($datasetRegion);
        $expectedResponse->setNotificationPubsubTopic($notificationPubsubTopic);
        $transport->addResponse($expectedResponse);

        $response = $client->getTransferConfig();
        $this->assertEquals($expectedResponse, $response);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.bigquery.datatransfer.v1.DataTransferService/GetTransferConfig', $actualFuncCall);

        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function getTransferConfigExceptionTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient(['transport' => $transport]);

        $this->assertTrue($transport->isExhausted());

        $status = new stdClass();
        $status->code = Code::DATA_LOSS;
        $status->details = 'internal error';

        $expectedExceptionMessage = json_encode([
           'message' => 'internal error',
           'code' => Code::DATA_LOSS,
           'status' => 'DATA_LOSS',
           'details' => [],
        ], JSON_PRETTY_PRINT);
        $transport->addResponse(null, $status);

        try {
            $client->getTransferConfig();
            // If the $client method call did not throw, fail the test
            $this->fail('Expected an ApiException, but no exception was thrown.');
        } catch (ApiException $ex) {
            $this->assertEquals($status->code, $ex->getCode());
            $this->assertEquals($expectedExceptionMessage, $ex->getMessage());
        }

        // Call popReceivedCalls to ensure the stub is exhausted
        $transport->popReceivedCalls();
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function listTransferConfigsTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient(['transport' => $transport]);

        $this->assertTrue($transport->isExhausted());

        // Mock response
        $nextPageToken = 'nextPageToken-1530815211';
        $expectedResponse = new ListTransferConfigsResponse();
        $expectedResponse->setNextPageToken($nextPageToken);
        $transport->addResponse($expectedResponse);

        $response = $client->listTransferConfigs();
        $this->assertEquals($expectedResponse, $response);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.bigquery.datatransfer.v1.DataTransferService/ListTransferConfigs', $actualFuncCall);

        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function listTransferConfigsExceptionTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient(['transport' => $transport]);

        $this->assertTrue($transport->isExhausted());

        $status = new stdClass();
        $status->code = Code::DATA_LOSS;
        $status->details = 'internal error';

        $expectedExceptionMessage = json_encode([
           'message' => 'internal error',
           'code' => Code::DATA_LOSS,
           'status' => 'DATA_LOSS',
           'details' => [],
        ], JSON_PRETTY_PRINT);
        $transport->addResponse(null, $status);

        try {
            $client->listTransferConfigs();
            // If the $client method call did not throw, fail the test
            $this->fail('Expected an ApiException, but no exception was thrown.');
        } catch (ApiException $ex) {
            $this->assertEquals($status->code, $ex->getCode());
            $this->assertEquals($expectedExceptionMessage, $ex->getMessage());
        }

        // Call popReceivedCalls to ensure the stub is exhausted
        $transport->popReceivedCalls();
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function scheduleTransferRunsTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient(['transport' => $transport]);

        $this->assertTrue($transport->isExhausted());

        // Mock response
        $expectedResponse = new ScheduleTransferRunsResponse();
        $transport->addResponse($expectedResponse);

        $response = $client->scheduleTransferRuns();
        $this->assertEquals($expectedResponse, $response);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.bigquery.datatransfer.v1.DataTransferService/ScheduleTransferRuns', $actualFuncCall);

        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function scheduleTransferRunsExceptionTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient(['transport' => $transport]);

        $this->assertTrue($transport->isExhausted());

        $status = new stdClass();
        $status->code = Code::DATA_LOSS;
        $status->details = 'internal error';

        $expectedExceptionMessage = json_encode([
           'message' => 'internal error',
           'code' => Code::DATA_LOSS,
           'status' => 'DATA_LOSS',
           'details' => [],
        ], JSON_PRETTY_PRINT);
        $transport->addResponse(null, $status);

        try {
            $client->scheduleTransferRuns();
            // If the $client method call did not throw, fail the test
            $this->fail('Expected an ApiException, but no exception was thrown.');
        } catch (ApiException $ex) {
            $this->assertEquals($status->code, $ex->getCode());
            $this->assertEquals($expectedExceptionMessage, $ex->getMessage());
        }

        // Call popReceivedCalls to ensure the stub is exhausted
        $transport->popReceivedCalls();
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function startManualTransferRunsTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient(['transport' => $transport]);

        $this->assertTrue($transport->isExhausted());

        // Mock response
        $expectedResponse = new StartManualTransferRunsResponse();
        $transport->addResponse($expectedResponse);

        $response = $client->startManualTransferRuns();
        $this->assertEquals($expectedResponse, $response);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.bigquery.datatransfer.v1.DataTransferService/StartManualTransferRuns', $actualFuncCall);

        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function startManualTransferRunsExceptionTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient(['transport' => $transport]);

        $this->assertTrue($transport->isExhausted());

        $status = new stdClass();
        $status->code = Code::DATA_LOSS;
        $status->details = 'internal error';

        $expectedExceptionMessage = json_encode([
           'message' => 'internal error',
           'code' => Code::DATA_LOSS,
           'status' => 'DATA_LOSS',
           'details' => [],
        ], JSON_PRETTY_PRINT);
        $transport->addResponse(null, $status);

        try {
            $client->startManualTransferRuns();
            // If the $client method call did not throw, fail the test
            $this->fail('Expected an ApiException, but no exception was thrown.');
        } catch (ApiException $ex) {
            $this->assertEquals($status->code, $ex->getCode());
            $this->assertEquals($expectedExceptionMessage, $ex->getMessage());
        }

        // Call popReceivedCalls to ensure the stub is exhausted
        $transport->popReceivedCalls();
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function getTransferRunTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient(['transport' => $transport]);

        $this->assertTrue($transport->isExhausted());

        // Mock response
        $name = 'name3373707';
        $destinationDatasetId = 'destinationDatasetId1541564179';
        $dataSourceId = 'dataSourceId-1015796374';
        $userId = 147132913;
        $schedule = 'schedule-697920873';
        $notificationPubsubTopic = 'notificationPubsubTopic1794281191';
        $expectedResponse = new TransferRun();
        $expectedResponse->setName($name);
        $expectedResponse->setDestinationDatasetId($destinationDatasetId);
        $expectedResponse->setDataSourceId($dataSourceId);
        $expectedResponse->setUserId($userId);
        $expectedResponse->setSchedule($schedule);
        $expectedResponse->setNotificationPubsubTopic($notificationPubsubTopic);
        $transport->addResponse($expectedResponse);

        $response = $client->getTransferRun();
        $this->assertEquals($expectedResponse, $response);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.bigquery.datatransfer.v1.DataTransferService/GetTransferRun', $actualFuncCall);

        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function getTransferRunExceptionTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient(['transport' => $transport]);

        $this->assertTrue($transport->isExhausted());

        $status = new stdClass();
        $status->code = Code::DATA_LOSS;
        $status->details = 'internal error';

        $expectedExceptionMessage = json_encode([
           'message' => 'internal error',
           'code' => Code::DATA_LOSS,
           'status' => 'DATA_LOSS',
           'details' => [],
        ], JSON_PRETTY_PRINT);
        $transport->addResponse(null, $status);

        try {
            $client->getTransferRun();
            // If the $client method call did not throw, fail the test
            $this->fail('Expected an ApiException, but no exception was thrown.');
        } catch (ApiException $ex) {
            $this->assertEquals($status->code, $ex->getCode());
            $this->assertEquals($expectedExceptionMessage, $ex->getMessage());
        }

        // Call popReceivedCalls to ensure the stub is exhausted
        $transport->popReceivedCalls();
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function deleteTransferRunTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient(['transport' => $transport]);

        $this->assertTrue($transport->isExhausted());

        // Mock response
        $expectedResponse = new GPBEmpty();
        $transport->addResponse($expectedResponse);

        $client->deleteTransferRun();
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.bigquery.datatransfer.v1.DataTransferService/DeleteTransferRun', $actualFuncCall);

        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function deleteTransferRunExceptionTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient(['transport' => $transport]);

        $this->assertTrue($transport->isExhausted());

        $status = new stdClass();
        $status->code = Code::DATA_LOSS;
        $status->details = 'internal error';

        $expectedExceptionMessage = json_encode([
           'message' => 'internal error',
           'code' => Code::DATA_LOSS,
           'status' => 'DATA_LOSS',
           'details' => [],
        ], JSON_PRETTY_PRINT);
        $transport->addResponse(null, $status);

        try {
            $client->deleteTransferRun();
            // If the $client method call did not throw, fail the test
            $this->fail('Expected an ApiException, but no exception was thrown.');
        } catch (ApiException $ex) {
            $this->assertEquals($status->code, $ex->getCode());
            $this->assertEquals($expectedExceptionMessage, $ex->getMessage());
        }

        // Call popReceivedCalls to ensure the stub is exhausted
        $transport->popReceivedCalls();
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function listTransferRunsTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient(['transport' => $transport]);

        $this->assertTrue($transport->isExhausted());

        // Mock response
        $nextPageToken = 'nextPageToken-1530815211';
        $expectedResponse = new ListTransferRunsResponse();
        $expectedResponse->setNextPageToken($nextPageToken);
        $transport->addResponse($expectedResponse);

        $response = $client->listTransferRuns();
        $this->assertEquals($expectedResponse, $response);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.bigquery.datatransfer.v1.DataTransferService/ListTransferRuns', $actualFuncCall);

        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function listTransferRunsExceptionTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient(['transport' => $transport]);

        $this->assertTrue($transport->isExhausted());

        $status = new stdClass();
        $status->code = Code::DATA_LOSS;
        $status->details = 'internal error';

        $expectedExceptionMessage = json_encode([
           'message' => 'internal error',
           'code' => Code::DATA_LOSS,
           'status' => 'DATA_LOSS',
           'details' => [],
        ], JSON_PRETTY_PRINT);
        $transport->addResponse(null, $status);

        try {
            $client->listTransferRuns();
            // If the $client method call did not throw, fail the test
            $this->fail('Expected an ApiException, but no exception was thrown.');
        } catch (ApiException $ex) {
            $this->assertEquals($status->code, $ex->getCode());
            $this->assertEquals($expectedExceptionMessage, $ex->getMessage());
        }

        // Call popReceivedCalls to ensure the stub is exhausted
        $transport->popReceivedCalls();
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function listTransferLogsTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient(['transport' => $transport]);

        $this->assertTrue($transport->isExhausted());

        // Mock response
        $nextPageToken = 'nextPageToken-1530815211';
        $expectedResponse = new ListTransferLogsResponse();
        $expectedResponse->setNextPageToken($nextPageToken);
        $transport->addResponse($expectedResponse);

        $response = $client->listTransferLogs();
        $this->assertEquals($expectedResponse, $response);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.bigquery.datatransfer.v1.DataTransferService/ListTransferLogs', $actualFuncCall);

        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function listTransferLogsExceptionTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient(['transport' => $transport]);

        $this->assertTrue($transport->isExhausted());

        $status = new stdClass();
        $status->code = Code::DATA_LOSS;
        $status->details = 'internal error';

        $expectedExceptionMessage = json_encode([
           'message' => 'internal error',
           'code' => Code::DATA_LOSS,
           'status' => 'DATA_LOSS',
           'details' => [],
        ], JSON_PRETTY_PRINT);
        $transport->addResponse(null, $status);

        try {
            $client->listTransferLogs();
            // If the $client method call did not throw, fail the test
            $this->fail('Expected an ApiException, but no exception was thrown.');
        } catch (ApiException $ex) {
            $this->assertEquals($status->code, $ex->getCode());
            $this->assertEquals($expectedExceptionMessage, $ex->getMessage());
        }

        // Call popReceivedCalls to ensure the stub is exhausted
        $transport->popReceivedCalls();
        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function checkValidCredsTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient(['transport' => $transport]);

        $this->assertTrue($transport->isExhausted());

        // Mock response
        $hasValidCreds = false;
        $expectedResponse = new CheckValidCredsResponse();
        $expectedResponse->setHasValidCreds($hasValidCreds);
        $transport->addResponse($expectedResponse);

        $response = $client->checkValidCreds();
        $this->assertEquals($expectedResponse, $response);
        $actualRequests = $transport->popReceivedCalls();
        $this->assertSame(1, count($actualRequests));
        $actualFuncCall = $actualRequests[0]->getFuncCall();
        $actualRequestObject = $actualRequests[0]->getRequestObject();
        $this->assertSame('/google.cloud.bigquery.datatransfer.v1.DataTransferService/CheckValidCreds', $actualFuncCall);

        $this->assertTrue($transport->isExhausted());
    }

    /**
     * @test
     */
    public function checkValidCredsExceptionTest()
    {
        $transport = $this->createTransport();
        $client = $this->createClient(['transport' => $transport]);

        $this->assertTrue($transport->isExhausted());

        $status = new stdClass();
        $status->code = Code::DATA_LOSS;
        $status->details = 'internal error';

        $expectedExceptionMessage = json_encode([
           'message' => 'internal error',
           'code' => Code::DATA_LOSS,
           'status' => 'DATA_LOSS',
           'details' => [],
        ], JSON_PRETTY_PRINT);
        $transport->addResponse(null, $status);

        try {
            $client->checkValidCreds();
            // If the $client method call did not throw, fail the test
            $this->fail('Expected an ApiException, but no exception was thrown.');
        } catch (ApiException $ex) {
            $this->assertEquals($status->code, $ex->getCode());
            $this->assertEquals($expectedExceptionMessage, $ex->getMessage());
        }

        // Call popReceivedCalls to ensure the stub is exhausted
        $transport->popReceivedCalls();
        $this->assertTrue($transport->isExhausted());
    }
}
