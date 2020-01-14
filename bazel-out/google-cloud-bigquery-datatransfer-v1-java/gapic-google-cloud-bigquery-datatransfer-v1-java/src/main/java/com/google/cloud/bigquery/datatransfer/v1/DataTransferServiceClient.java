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
package com.google.cloud.bigquery.datatransfer.v1;

import com.google.api.core.BetaApi;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.api.pathtemplate.PathTemplate;
import com.google.cloud.bigquery.datatransfer.v1.stub.DataTransferServiceStub;
import com.google.cloud.bigquery.datatransfer.v1.stub.DataTransferServiceStubSettings;
import com.google.protobuf.Empty;
import java.io.IOException;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND SERVICE
/**
 * Service Description: The Google BigQuery Data Transfer Service API enables BigQuery users to
 * configure the transfer of their data from other Google Products into BigQuery. This service
 * contains methods that are end user exposed. It backs up the frontend.
 *
 * <p>This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * <pre>
 * <code>
 * try (DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.create()) {
 *   GetDataSourceRequest request = GetDataSourceRequest.newBuilder().build();
 *   DataSource response = dataTransferServiceClient.getDataSource(request);
 * }
 * </code>
 * </pre>
 *
 * <p>Note: close() needs to be called on the dataTransferServiceClient object to clean up resources
 * such as threads. In the example above, try-with-resources is used, which automatically calls
 * close().
 *
 * <p>The surface of this class includes several types of Java methods for each of the API's
 * methods:
 *
 * <ol>
 *   <li> A "flattened" method. With this type of method, the fields of the request type have been
 *       converted into function parameters. It may be the case that not all fields are available as
 *       parameters, and not every API method will have a flattened method entry point.
 *   <li> A "request object" method. This type of method only takes one parameter, a request object,
 *       which must be constructed before the call. Not every API method will have a request object
 *       method.
 *   <li> A "callable" method. This type of method takes no parameters and returns an immutable API
 *       callable object, which can be used to initiate calls to the service.
 * </ol>
 *
 * <p>See the individual methods for example code.
 *
 * <p>Many parameters require resource names to be formatted in a particular way. To assist with
 * these names, this class includes a format method for each type of name, and additionally a parse
 * method to extract the individual identifiers contained within names that are returned.
 *
 * <p>This class can be customized by passing in a custom instance of DataTransferServiceSettings to
 * create(). For example:
 *
 * <p>To customize credentials:
 *
 * <pre>
 * <code>
 * DataTransferServiceSettings dataTransferServiceSettings =
 *     DataTransferServiceSettings.newBuilder()
 *         .setCredentialsProvider(FixedCredentialsProvider.create(myCredentials))
 *         .build();
 * DataTransferServiceClient dataTransferServiceClient =
 *     DataTransferServiceClient.create(dataTransferServiceSettings);
 * </code>
 * </pre>
 *
 * To customize the endpoint:
 *
 * <pre>
 * <code>
 * DataTransferServiceSettings dataTransferServiceSettings =
 *     DataTransferServiceSettings.newBuilder().setEndpoint(myEndpoint).build();
 * DataTransferServiceClient dataTransferServiceClient =
 *     DataTransferServiceClient.create(dataTransferServiceSettings);
 * </code>
 * </pre>
 */
@Generated("by gapic-generator")
@BetaApi
public class DataTransferServiceClient implements BackgroundResource {
  private final DataTransferServiceSettings settings;
  private final DataTransferServiceStub stub;

  private static final PathTemplate LOCATION_PATH_TEMPLATE =
      PathTemplate.createWithoutUrlEncoding("projects/{project}/locations/{location}");

  /**
   * Formats a string containing the fully-qualified path to represent a location resource.
   *
   * @deprecated Use the {@link LocationName} class instead.
   */
  @Deprecated
  public static final String formatLocationName(String project, String location) {
    return LOCATION_PATH_TEMPLATE.instantiate(
        "project", project,
        "location", location);
  }

  /**
   * Parses the project from the given fully-qualified path which represents a location resource.
   *
   * @deprecated Use the {@link LocationName} class instead.
   */
  @Deprecated
  public static final String parseProjectFromLocationName(String locationName) {
    return LOCATION_PATH_TEMPLATE.parse(locationName).get("project");
  }

  /**
   * Parses the location from the given fully-qualified path which represents a location resource.
   *
   * @deprecated Use the {@link LocationName} class instead.
   */
  @Deprecated
  public static final String parseLocationFromLocationName(String locationName) {
    return LOCATION_PATH_TEMPLATE.parse(locationName).get("location");
  }

  /** Constructs an instance of DataTransferServiceClient with default settings. */
  public static final DataTransferServiceClient create() throws IOException {
    return create(DataTransferServiceSettings.newBuilder().build());
  }

  /**
   * Constructs an instance of DataTransferServiceClient, using the given settings. The channels are
   * created based on the settings passed in, or defaults for any settings that are not set.
   */
  public static final DataTransferServiceClient create(DataTransferServiceSettings settings)
      throws IOException {
    return new DataTransferServiceClient(settings);
  }

  /**
   * Constructs an instance of DataTransferServiceClient, using the given stub for making calls.
   * This is for advanced usage - prefer to use DataTransferServiceSettings}.
   */
  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public static final DataTransferServiceClient create(DataTransferServiceStub stub) {
    return new DataTransferServiceClient(stub);
  }

  /**
   * Constructs an instance of DataTransferServiceClient, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected DataTransferServiceClient(DataTransferServiceSettings settings) throws IOException {
    this.settings = settings;
    this.stub = ((DataTransferServiceStubSettings) settings.getStubSettings()).createStub();
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  protected DataTransferServiceClient(DataTransferServiceStub stub) {
    this.settings = null;
    this.stub = stub;
  }

  public final DataTransferServiceSettings getSettings() {
    return settings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public DataTransferServiceStub getStub() {
    return stub;
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Retrieves a supported data source and returns its settings, which can be used for UI rendering.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.create()) {
   *   GetDataSourceRequest request = GetDataSourceRequest.newBuilder().build();
   *   DataSource response = dataTransferServiceClient.getDataSource(request);
   * }
   * </code></pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final DataSource getDataSource(GetDataSourceRequest request) {
    return getDataSourceCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Retrieves a supported data source and returns its settings, which can be used for UI rendering.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.create()) {
   *   GetDataSourceRequest request = GetDataSourceRequest.newBuilder().build();
   *   ApiFuture&lt;DataSource&gt; future = dataTransferServiceClient.getDataSourceCallable().futureCall(request);
   *   // Do something
   *   DataSource response = future.get();
   * }
   * </code></pre>
   */
  public final UnaryCallable<GetDataSourceRequest, DataSource> getDataSourceCallable() {
    return stub.getDataSourceCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Lists supported data sources and returns their settings, which can be used for UI rendering.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.create()) {
   *   ListDataSourcesRequest request = ListDataSourcesRequest.newBuilder().build();
   *   ListDataSourcesResponse response = dataTransferServiceClient.listDataSources(request);
   * }
   * </code></pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListDataSourcesResponse listDataSources(ListDataSourcesRequest request) {
    return listDataSourcesCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Lists supported data sources and returns their settings, which can be used for UI rendering.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.create()) {
   *   ListDataSourcesRequest request = ListDataSourcesRequest.newBuilder().build();
   *   ApiFuture&lt;ListDataSourcesResponse&gt; future = dataTransferServiceClient.listDataSourcesCallable().futureCall(request);
   *   // Do something
   *   ListDataSourcesResponse response = future.get();
   * }
   * </code></pre>
   */
  public final UnaryCallable<ListDataSourcesRequest, ListDataSourcesResponse>
      listDataSourcesCallable() {
    return stub.listDataSourcesCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Creates a new data transfer configuration.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.create()) {
   *   CreateTransferConfigRequest request = CreateTransferConfigRequest.newBuilder().build();
   *   TransferConfig response = dataTransferServiceClient.createTransferConfig(request);
   * }
   * </code></pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final TransferConfig createTransferConfig(CreateTransferConfigRequest request) {
    return createTransferConfigCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Creates a new data transfer configuration.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.create()) {
   *   CreateTransferConfigRequest request = CreateTransferConfigRequest.newBuilder().build();
   *   ApiFuture&lt;TransferConfig&gt; future = dataTransferServiceClient.createTransferConfigCallable().futureCall(request);
   *   // Do something
   *   TransferConfig response = future.get();
   * }
   * </code></pre>
   */
  public final UnaryCallable<CreateTransferConfigRequest, TransferConfig>
      createTransferConfigCallable() {
    return stub.createTransferConfigCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Updates a data transfer configuration. All fields must be set, even if they are not updated.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.create()) {
   *   UpdateTransferConfigRequest request = UpdateTransferConfigRequest.newBuilder().build();
   *   TransferConfig response = dataTransferServiceClient.updateTransferConfig(request);
   * }
   * </code></pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final TransferConfig updateTransferConfig(UpdateTransferConfigRequest request) {
    return updateTransferConfigCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Updates a data transfer configuration. All fields must be set, even if they are not updated.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.create()) {
   *   UpdateTransferConfigRequest request = UpdateTransferConfigRequest.newBuilder().build();
   *   ApiFuture&lt;TransferConfig&gt; future = dataTransferServiceClient.updateTransferConfigCallable().futureCall(request);
   *   // Do something
   *   TransferConfig response = future.get();
   * }
   * </code></pre>
   */
  public final UnaryCallable<UpdateTransferConfigRequest, TransferConfig>
      updateTransferConfigCallable() {
    return stub.updateTransferConfigCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Deletes a data transfer configuration, including any associated transfer runs and logs.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.create()) {
   *   DeleteTransferConfigRequest request = DeleteTransferConfigRequest.newBuilder().build();
   *   dataTransferServiceClient.deleteTransferConfig(request);
   * }
   * </code></pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final void deleteTransferConfig(DeleteTransferConfigRequest request) {
    deleteTransferConfigCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Deletes a data transfer configuration, including any associated transfer runs and logs.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.create()) {
   *   DeleteTransferConfigRequest request = DeleteTransferConfigRequest.newBuilder().build();
   *   ApiFuture&lt;Void&gt; future = dataTransferServiceClient.deleteTransferConfigCallable().futureCall(request);
   *   // Do something
   *   future.get();
   * }
   * </code></pre>
   */
  public final UnaryCallable<DeleteTransferConfigRequest, Empty> deleteTransferConfigCallable() {
    return stub.deleteTransferConfigCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Returns information about a data transfer config.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.create()) {
   *   GetTransferConfigRequest request = GetTransferConfigRequest.newBuilder().build();
   *   TransferConfig response = dataTransferServiceClient.getTransferConfig(request);
   * }
   * </code></pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final TransferConfig getTransferConfig(GetTransferConfigRequest request) {
    return getTransferConfigCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Returns information about a data transfer config.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.create()) {
   *   GetTransferConfigRequest request = GetTransferConfigRequest.newBuilder().build();
   *   ApiFuture&lt;TransferConfig&gt; future = dataTransferServiceClient.getTransferConfigCallable().futureCall(request);
   *   // Do something
   *   TransferConfig response = future.get();
   * }
   * </code></pre>
   */
  public final UnaryCallable<GetTransferConfigRequest, TransferConfig> getTransferConfigCallable() {
    return stub.getTransferConfigCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Returns information about all data transfers in the project.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.create()) {
   *   ListTransferConfigsRequest request = ListTransferConfigsRequest.newBuilder().build();
   *   ListTransferConfigsResponse response = dataTransferServiceClient.listTransferConfigs(request);
   * }
   * </code></pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListTransferConfigsResponse listTransferConfigs(ListTransferConfigsRequest request) {
    return listTransferConfigsCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Returns information about all data transfers in the project.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.create()) {
   *   ListTransferConfigsRequest request = ListTransferConfigsRequest.newBuilder().build();
   *   ApiFuture&lt;ListTransferConfigsResponse&gt; future = dataTransferServiceClient.listTransferConfigsCallable().futureCall(request);
   *   // Do something
   *   ListTransferConfigsResponse response = future.get();
   * }
   * </code></pre>
   */
  public final UnaryCallable<ListTransferConfigsRequest, ListTransferConfigsResponse>
      listTransferConfigsCallable() {
    return stub.listTransferConfigsCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Creates transfer runs for a time range [start_time, end_time]. For each date - or whatever
   * granularity the data source supports - in the range, one transfer run is created. Note that
   * runs are created per UTC time in the time range. DEPRECATED: use StartManualTransferRuns
   * instead.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.create()) {
   *   ScheduleTransferRunsRequest request = ScheduleTransferRunsRequest.newBuilder().build();
   *   ScheduleTransferRunsResponse response = dataTransferServiceClient.scheduleTransferRuns(request);
   * }
   * </code></pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ScheduleTransferRunsResponse scheduleTransferRuns(
      ScheduleTransferRunsRequest request) {
    return scheduleTransferRunsCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Creates transfer runs for a time range [start_time, end_time]. For each date - or whatever
   * granularity the data source supports - in the range, one transfer run is created. Note that
   * runs are created per UTC time in the time range. DEPRECATED: use StartManualTransferRuns
   * instead.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.create()) {
   *   ScheduleTransferRunsRequest request = ScheduleTransferRunsRequest.newBuilder().build();
   *   ApiFuture&lt;ScheduleTransferRunsResponse&gt; future = dataTransferServiceClient.scheduleTransferRunsCallable().futureCall(request);
   *   // Do something
   *   ScheduleTransferRunsResponse response = future.get();
   * }
   * </code></pre>
   */
  public final UnaryCallable<ScheduleTransferRunsRequest, ScheduleTransferRunsResponse>
      scheduleTransferRunsCallable() {
    return stub.scheduleTransferRunsCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Start manual transfer runs to be executed now with schedule_time equal to current time. The
   * transfer runs can be created for a time range where the run_time is between start_time
   * (inclusive) and end_time (exclusive), or for a specific run_time.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.create()) {
   *   StartManualTransferRunsRequest request = StartManualTransferRunsRequest.newBuilder().build();
   *   StartManualTransferRunsResponse response = dataTransferServiceClient.startManualTransferRuns(request);
   * }
   * </code></pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final StartManualTransferRunsResponse startManualTransferRuns(
      StartManualTransferRunsRequest request) {
    return startManualTransferRunsCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Start manual transfer runs to be executed now with schedule_time equal to current time. The
   * transfer runs can be created for a time range where the run_time is between start_time
   * (inclusive) and end_time (exclusive), or for a specific run_time.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.create()) {
   *   StartManualTransferRunsRequest request = StartManualTransferRunsRequest.newBuilder().build();
   *   ApiFuture&lt;StartManualTransferRunsResponse&gt; future = dataTransferServiceClient.startManualTransferRunsCallable().futureCall(request);
   *   // Do something
   *   StartManualTransferRunsResponse response = future.get();
   * }
   * </code></pre>
   */
  public final UnaryCallable<StartManualTransferRunsRequest, StartManualTransferRunsResponse>
      startManualTransferRunsCallable() {
    return stub.startManualTransferRunsCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Returns information about the particular transfer run.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.create()) {
   *   GetTransferRunRequest request = GetTransferRunRequest.newBuilder().build();
   *   TransferRun response = dataTransferServiceClient.getTransferRun(request);
   * }
   * </code></pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final TransferRun getTransferRun(GetTransferRunRequest request) {
    return getTransferRunCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Returns information about the particular transfer run.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.create()) {
   *   GetTransferRunRequest request = GetTransferRunRequest.newBuilder().build();
   *   ApiFuture&lt;TransferRun&gt; future = dataTransferServiceClient.getTransferRunCallable().futureCall(request);
   *   // Do something
   *   TransferRun response = future.get();
   * }
   * </code></pre>
   */
  public final UnaryCallable<GetTransferRunRequest, TransferRun> getTransferRunCallable() {
    return stub.getTransferRunCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Deletes the specified transfer run.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.create()) {
   *   DeleteTransferRunRequest request = DeleteTransferRunRequest.newBuilder().build();
   *   dataTransferServiceClient.deleteTransferRun(request);
   * }
   * </code></pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final void deleteTransferRun(DeleteTransferRunRequest request) {
    deleteTransferRunCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Deletes the specified transfer run.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.create()) {
   *   DeleteTransferRunRequest request = DeleteTransferRunRequest.newBuilder().build();
   *   ApiFuture&lt;Void&gt; future = dataTransferServiceClient.deleteTransferRunCallable().futureCall(request);
   *   // Do something
   *   future.get();
   * }
   * </code></pre>
   */
  public final UnaryCallable<DeleteTransferRunRequest, Empty> deleteTransferRunCallable() {
    return stub.deleteTransferRunCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Returns information about running and completed jobs.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.create()) {
   *   ListTransferRunsRequest request = ListTransferRunsRequest.newBuilder().build();
   *   ListTransferRunsResponse response = dataTransferServiceClient.listTransferRuns(request);
   * }
   * </code></pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListTransferRunsResponse listTransferRuns(ListTransferRunsRequest request) {
    return listTransferRunsCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Returns information about running and completed jobs.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.create()) {
   *   ListTransferRunsRequest request = ListTransferRunsRequest.newBuilder().build();
   *   ApiFuture&lt;ListTransferRunsResponse&gt; future = dataTransferServiceClient.listTransferRunsCallable().futureCall(request);
   *   // Do something
   *   ListTransferRunsResponse response = future.get();
   * }
   * </code></pre>
   */
  public final UnaryCallable<ListTransferRunsRequest, ListTransferRunsResponse>
      listTransferRunsCallable() {
    return stub.listTransferRunsCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Returns user facing log messages for the data transfer run.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.create()) {
   *   ListTransferLogsRequest request = ListTransferLogsRequest.newBuilder().build();
   *   ListTransferLogsResponse response = dataTransferServiceClient.listTransferLogs(request);
   * }
   * </code></pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListTransferLogsResponse listTransferLogs(ListTransferLogsRequest request) {
    return listTransferLogsCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Returns user facing log messages for the data transfer run.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.create()) {
   *   ListTransferLogsRequest request = ListTransferLogsRequest.newBuilder().build();
   *   ApiFuture&lt;ListTransferLogsResponse&gt; future = dataTransferServiceClient.listTransferLogsCallable().futureCall(request);
   *   // Do something
   *   ListTransferLogsResponse response = future.get();
   * }
   * </code></pre>
   */
  public final UnaryCallable<ListTransferLogsRequest, ListTransferLogsResponse>
      listTransferLogsCallable() {
    return stub.listTransferLogsCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Returns true if valid credentials exist for the given data source and requesting user. Some
   * data sources doesn't support service account, so we need to talk to them on behalf of the end
   * user. This API just checks whether we have OAuth token for the particular user, which is a
   * pre-requisite before user can create a transfer config.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.create()) {
   *   CheckValidCredsRequest request = CheckValidCredsRequest.newBuilder().build();
   *   CheckValidCredsResponse response = dataTransferServiceClient.checkValidCreds(request);
   * }
   * </code></pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final CheckValidCredsResponse checkValidCreds(CheckValidCredsRequest request) {
    return checkValidCredsCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Returns true if valid credentials exist for the given data source and requesting user. Some
   * data sources doesn't support service account, so we need to talk to them on behalf of the end
   * user. This API just checks whether we have OAuth token for the particular user, which is a
   * pre-requisite before user can create a transfer config.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.create()) {
   *   CheckValidCredsRequest request = CheckValidCredsRequest.newBuilder().build();
   *   ApiFuture&lt;CheckValidCredsResponse&gt; future = dataTransferServiceClient.checkValidCredsCallable().futureCall(request);
   *   // Do something
   *   CheckValidCredsResponse response = future.get();
   * }
   * </code></pre>
   */
  public final UnaryCallable<CheckValidCredsRequest, CheckValidCredsResponse>
      checkValidCredsCallable() {
    return stub.checkValidCredsCallable();
  }

  @Override
  public final void close() {
    stub.close();
  }

  @Override
  public void shutdown() {
    stub.shutdown();
  }

  @Override
  public boolean isShutdown() {
    return stub.isShutdown();
  }

  @Override
  public boolean isTerminated() {
    return stub.isTerminated();
  }

  @Override
  public void shutdownNow() {
    stub.shutdownNow();
  }

  @Override
  public boolean awaitTermination(long duration, TimeUnit unit) throws InterruptedException {
    return stub.awaitTermination(duration, unit);
  }
}
