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
package com.google.cloud.bigquery.datatransfer.v1.stub;

import com.google.api.core.ApiFunction;
import com.google.api.core.BetaApi;
import com.google.api.gax.core.GaxProperties;
import com.google.api.gax.core.GoogleCredentialsProvider;
import com.google.api.gax.core.InstantiatingExecutorProvider;
import com.google.api.gax.grpc.GaxGrpcProperties;
import com.google.api.gax.grpc.GrpcTransportChannel;
import com.google.api.gax.grpc.InstantiatingGrpcChannelProvider;
import com.google.api.gax.retrying.RetrySettings;
import com.google.api.gax.rpc.ApiClientHeaderProvider;
import com.google.api.gax.rpc.ClientContext;
import com.google.api.gax.rpc.StatusCode;
import com.google.api.gax.rpc.StubSettings;
import com.google.api.gax.rpc.TransportChannelProvider;
import com.google.api.gax.rpc.UnaryCallSettings;
import com.google.cloud.bigquery.datatransfer.v1.CheckValidCredsRequest;
import com.google.cloud.bigquery.datatransfer.v1.CheckValidCredsResponse;
import com.google.cloud.bigquery.datatransfer.v1.CreateTransferConfigRequest;
import com.google.cloud.bigquery.datatransfer.v1.DataSource;
import com.google.cloud.bigquery.datatransfer.v1.DeleteTransferConfigRequest;
import com.google.cloud.bigquery.datatransfer.v1.DeleteTransferRunRequest;
import com.google.cloud.bigquery.datatransfer.v1.GetDataSourceRequest;
import com.google.cloud.bigquery.datatransfer.v1.GetTransferConfigRequest;
import com.google.cloud.bigquery.datatransfer.v1.GetTransferRunRequest;
import com.google.cloud.bigquery.datatransfer.v1.ListDataSourcesRequest;
import com.google.cloud.bigquery.datatransfer.v1.ListDataSourcesResponse;
import com.google.cloud.bigquery.datatransfer.v1.ListTransferConfigsRequest;
import com.google.cloud.bigquery.datatransfer.v1.ListTransferConfigsResponse;
import com.google.cloud.bigquery.datatransfer.v1.ListTransferLogsRequest;
import com.google.cloud.bigquery.datatransfer.v1.ListTransferLogsResponse;
import com.google.cloud.bigquery.datatransfer.v1.ListTransferRunsRequest;
import com.google.cloud.bigquery.datatransfer.v1.ListTransferRunsResponse;
import com.google.cloud.bigquery.datatransfer.v1.ScheduleTransferRunsRequest;
import com.google.cloud.bigquery.datatransfer.v1.ScheduleTransferRunsResponse;
import com.google.cloud.bigquery.datatransfer.v1.StartManualTransferRunsRequest;
import com.google.cloud.bigquery.datatransfer.v1.StartManualTransferRunsResponse;
import com.google.cloud.bigquery.datatransfer.v1.TransferConfig;
import com.google.cloud.bigquery.datatransfer.v1.TransferRun;
import com.google.cloud.bigquery.datatransfer.v1.UpdateTransferConfigRequest;
import com.google.common.collect.ImmutableList;
import com.google.common.collect.ImmutableMap;
import com.google.common.collect.ImmutableSet;
import com.google.common.collect.Lists;
import com.google.protobuf.Empty;
import java.io.IOException;
import java.util.List;
import javax.annotation.Generated;
import org.threeten.bp.Duration;

// AUTO-GENERATED DOCUMENTATION AND CLASS
/**
 * Settings class to configure an instance of {@link DataTransferServiceStub}.
 *
 * <p>The default instance has everything set to sensible defaults:
 *
 * <ul>
 *   <li>The default service address (bigquerydatatransfer.googleapis.com) and default port (443)
 *       are used.
 *   <li>Credentials are acquired automatically through Application Default Credentials.
 *   <li>Retries are configured for idempotent methods but not for non-idempotent methods.
 * </ul>
 *
 * <p>The builder of this class is recursive, so contained classes are themselves builders. When
 * build() is called, the tree of builders is called to create the complete settings object.
 *
 * <p>For example, to set the total timeout of getDataSource to 30 seconds:
 *
 * <pre>
 * <code>
 * DataTransferServiceStubSettings.Builder dataTransferServiceSettingsBuilder =
 *     DataTransferServiceStubSettings.newBuilder();
 * dataTransferServiceSettingsBuilder.getDataSourceSettings().getRetrySettings().toBuilder()
 *     .setTotalTimeout(Duration.ofSeconds(30));
 * DataTransferServiceStubSettings dataTransferServiceSettings = dataTransferServiceSettingsBuilder.build();
 * </code>
 * </pre>
 */
@Generated("by gapic-generator")
@BetaApi
public class DataTransferServiceStubSettings extends StubSettings<DataTransferServiceStubSettings> {
  /** The default scopes of the service. */
  private static final ImmutableList<String> DEFAULT_SERVICE_SCOPES =
      ImmutableList.<String>builder().add("https://www.googleapis.com/auth/cloud-platform").build();

  private final UnaryCallSettings<GetDataSourceRequest, DataSource> getDataSourceSettings;
  private final UnaryCallSettings<ListDataSourcesRequest, ListDataSourcesResponse>
      listDataSourcesSettings;
  private final UnaryCallSettings<CreateTransferConfigRequest, TransferConfig>
      createTransferConfigSettings;
  private final UnaryCallSettings<UpdateTransferConfigRequest, TransferConfig>
      updateTransferConfigSettings;
  private final UnaryCallSettings<DeleteTransferConfigRequest, Empty> deleteTransferConfigSettings;
  private final UnaryCallSettings<GetTransferConfigRequest, TransferConfig>
      getTransferConfigSettings;
  private final UnaryCallSettings<ListTransferConfigsRequest, ListTransferConfigsResponse>
      listTransferConfigsSettings;
  private final UnaryCallSettings<ScheduleTransferRunsRequest, ScheduleTransferRunsResponse>
      scheduleTransferRunsSettings;
  private final UnaryCallSettings<StartManualTransferRunsRequest, StartManualTransferRunsResponse>
      startManualTransferRunsSettings;
  private final UnaryCallSettings<GetTransferRunRequest, TransferRun> getTransferRunSettings;
  private final UnaryCallSettings<DeleteTransferRunRequest, Empty> deleteTransferRunSettings;
  private final UnaryCallSettings<ListTransferRunsRequest, ListTransferRunsResponse>
      listTransferRunsSettings;
  private final UnaryCallSettings<ListTransferLogsRequest, ListTransferLogsResponse>
      listTransferLogsSettings;
  private final UnaryCallSettings<CheckValidCredsRequest, CheckValidCredsResponse>
      checkValidCredsSettings;

  /** Returns the object with the settings used for calls to getDataSource. */
  public UnaryCallSettings<GetDataSourceRequest, DataSource> getDataSourceSettings() {
    return getDataSourceSettings;
  }

  /** Returns the object with the settings used for calls to listDataSources. */
  public UnaryCallSettings<ListDataSourcesRequest, ListDataSourcesResponse>
      listDataSourcesSettings() {
    return listDataSourcesSettings;
  }

  /** Returns the object with the settings used for calls to createTransferConfig. */
  public UnaryCallSettings<CreateTransferConfigRequest, TransferConfig>
      createTransferConfigSettings() {
    return createTransferConfigSettings;
  }

  /** Returns the object with the settings used for calls to updateTransferConfig. */
  public UnaryCallSettings<UpdateTransferConfigRequest, TransferConfig>
      updateTransferConfigSettings() {
    return updateTransferConfigSettings;
  }

  /** Returns the object with the settings used for calls to deleteTransferConfig. */
  public UnaryCallSettings<DeleteTransferConfigRequest, Empty> deleteTransferConfigSettings() {
    return deleteTransferConfigSettings;
  }

  /** Returns the object with the settings used for calls to getTransferConfig. */
  public UnaryCallSettings<GetTransferConfigRequest, TransferConfig> getTransferConfigSettings() {
    return getTransferConfigSettings;
  }

  /** Returns the object with the settings used for calls to listTransferConfigs. */
  public UnaryCallSettings<ListTransferConfigsRequest, ListTransferConfigsResponse>
      listTransferConfigsSettings() {
    return listTransferConfigsSettings;
  }

  /** Returns the object with the settings used for calls to scheduleTransferRuns. */
  public UnaryCallSettings<ScheduleTransferRunsRequest, ScheduleTransferRunsResponse>
      scheduleTransferRunsSettings() {
    return scheduleTransferRunsSettings;
  }

  /** Returns the object with the settings used for calls to startManualTransferRuns. */
  public UnaryCallSettings<StartManualTransferRunsRequest, StartManualTransferRunsResponse>
      startManualTransferRunsSettings() {
    return startManualTransferRunsSettings;
  }

  /** Returns the object with the settings used for calls to getTransferRun. */
  public UnaryCallSettings<GetTransferRunRequest, TransferRun> getTransferRunSettings() {
    return getTransferRunSettings;
  }

  /** Returns the object with the settings used for calls to deleteTransferRun. */
  public UnaryCallSettings<DeleteTransferRunRequest, Empty> deleteTransferRunSettings() {
    return deleteTransferRunSettings;
  }

  /** Returns the object with the settings used for calls to listTransferRuns. */
  public UnaryCallSettings<ListTransferRunsRequest, ListTransferRunsResponse>
      listTransferRunsSettings() {
    return listTransferRunsSettings;
  }

  /** Returns the object with the settings used for calls to listTransferLogs. */
  public UnaryCallSettings<ListTransferLogsRequest, ListTransferLogsResponse>
      listTransferLogsSettings() {
    return listTransferLogsSettings;
  }

  /** Returns the object with the settings used for calls to checkValidCreds. */
  public UnaryCallSettings<CheckValidCredsRequest, CheckValidCredsResponse>
      checkValidCredsSettings() {
    return checkValidCredsSettings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public DataTransferServiceStub createStub() throws IOException {
    if (getTransportChannelProvider()
        .getTransportName()
        .equals(GrpcTransportChannel.getGrpcTransportName())) {
      return GrpcDataTransferServiceStub.create(this);
    } else {
      throw new UnsupportedOperationException(
          "Transport not supported: " + getTransportChannelProvider().getTransportName());
    }
  }

  /** Returns a builder for the default ExecutorProvider for this service. */
  public static InstantiatingExecutorProvider.Builder defaultExecutorProviderBuilder() {
    return InstantiatingExecutorProvider.newBuilder();
  }

  /** Returns the default service endpoint. */
  public static String getDefaultEndpoint() {
    return "bigquerydatatransfer.googleapis.com:443";
  }

  /** Returns the default service scopes. */
  public static List<String> getDefaultServiceScopes() {
    return DEFAULT_SERVICE_SCOPES;
  }

  /** Returns a builder for the default credentials for this service. */
  public static GoogleCredentialsProvider.Builder defaultCredentialsProviderBuilder() {
    return GoogleCredentialsProvider.newBuilder().setScopesToApply(DEFAULT_SERVICE_SCOPES);
  }

  /** Returns a builder for the default ChannelProvider for this service. */
  public static InstantiatingGrpcChannelProvider.Builder defaultGrpcTransportProviderBuilder() {
    return InstantiatingGrpcChannelProvider.newBuilder()
        .setMaxInboundMessageSize(Integer.MAX_VALUE);
  }

  public static TransportChannelProvider defaultTransportChannelProvider() {
    return defaultGrpcTransportProviderBuilder().build();
  }

  @BetaApi("The surface for customizing headers is not stable yet and may change in the future.")
  public static ApiClientHeaderProvider.Builder defaultApiClientHeaderProviderBuilder() {
    return ApiClientHeaderProvider.newBuilder()
        .setGeneratedLibToken(
            "gapic", GaxProperties.getLibraryVersion(DataTransferServiceStubSettings.class))
        .setTransportToken(
            GaxGrpcProperties.getGrpcTokenName(), GaxGrpcProperties.getGrpcVersion());
  }

  /** Returns a new builder for this class. */
  public static Builder newBuilder() {
    return Builder.createDefault();
  }

  /** Returns a new builder for this class. */
  public static Builder newBuilder(ClientContext clientContext) {
    return new Builder(clientContext);
  }

  /** Returns a builder containing all the values of this settings class. */
  public Builder toBuilder() {
    return new Builder(this);
  }

  protected DataTransferServiceStubSettings(Builder settingsBuilder) throws IOException {
    super(settingsBuilder);

    getDataSourceSettings = settingsBuilder.getDataSourceSettings().build();
    listDataSourcesSettings = settingsBuilder.listDataSourcesSettings().build();
    createTransferConfigSettings = settingsBuilder.createTransferConfigSettings().build();
    updateTransferConfigSettings = settingsBuilder.updateTransferConfigSettings().build();
    deleteTransferConfigSettings = settingsBuilder.deleteTransferConfigSettings().build();
    getTransferConfigSettings = settingsBuilder.getTransferConfigSettings().build();
    listTransferConfigsSettings = settingsBuilder.listTransferConfigsSettings().build();
    scheduleTransferRunsSettings = settingsBuilder.scheduleTransferRunsSettings().build();
    startManualTransferRunsSettings = settingsBuilder.startManualTransferRunsSettings().build();
    getTransferRunSettings = settingsBuilder.getTransferRunSettings().build();
    deleteTransferRunSettings = settingsBuilder.deleteTransferRunSettings().build();
    listTransferRunsSettings = settingsBuilder.listTransferRunsSettings().build();
    listTransferLogsSettings = settingsBuilder.listTransferLogsSettings().build();
    checkValidCredsSettings = settingsBuilder.checkValidCredsSettings().build();
  }

  /** Builder for DataTransferServiceStubSettings. */
  public static class Builder
      extends StubSettings.Builder<DataTransferServiceStubSettings, Builder> {
    private final ImmutableList<UnaryCallSettings.Builder<?, ?>> unaryMethodSettingsBuilders;

    private final UnaryCallSettings.Builder<GetDataSourceRequest, DataSource> getDataSourceSettings;
    private final UnaryCallSettings.Builder<ListDataSourcesRequest, ListDataSourcesResponse>
        listDataSourcesSettings;
    private final UnaryCallSettings.Builder<CreateTransferConfigRequest, TransferConfig>
        createTransferConfigSettings;
    private final UnaryCallSettings.Builder<UpdateTransferConfigRequest, TransferConfig>
        updateTransferConfigSettings;
    private final UnaryCallSettings.Builder<DeleteTransferConfigRequest, Empty>
        deleteTransferConfigSettings;
    private final UnaryCallSettings.Builder<GetTransferConfigRequest, TransferConfig>
        getTransferConfigSettings;
    private final UnaryCallSettings.Builder<ListTransferConfigsRequest, ListTransferConfigsResponse>
        listTransferConfigsSettings;
    private final UnaryCallSettings.Builder<
            ScheduleTransferRunsRequest, ScheduleTransferRunsResponse>
        scheduleTransferRunsSettings;
    private final UnaryCallSettings.Builder<
            StartManualTransferRunsRequest, StartManualTransferRunsResponse>
        startManualTransferRunsSettings;
    private final UnaryCallSettings.Builder<GetTransferRunRequest, TransferRun>
        getTransferRunSettings;
    private final UnaryCallSettings.Builder<DeleteTransferRunRequest, Empty>
        deleteTransferRunSettings;
    private final UnaryCallSettings.Builder<ListTransferRunsRequest, ListTransferRunsResponse>
        listTransferRunsSettings;
    private final UnaryCallSettings.Builder<ListTransferLogsRequest, ListTransferLogsResponse>
        listTransferLogsSettings;
    private final UnaryCallSettings.Builder<CheckValidCredsRequest, CheckValidCredsResponse>
        checkValidCredsSettings;

    private static final ImmutableMap<String, ImmutableSet<StatusCode.Code>>
        RETRYABLE_CODE_DEFINITIONS;

    static {
      ImmutableMap.Builder<String, ImmutableSet<StatusCode.Code>> definitions =
          ImmutableMap.builder();
      definitions.put(
          "idempotent",
          ImmutableSet.copyOf(
              Lists.<StatusCode.Code>newArrayList(
                  StatusCode.Code.DEADLINE_EXCEEDED, StatusCode.Code.UNAVAILABLE)));
      definitions.put("non_idempotent", ImmutableSet.copyOf(Lists.<StatusCode.Code>newArrayList()));
      RETRYABLE_CODE_DEFINITIONS = definitions.build();
    }

    private static final ImmutableMap<String, RetrySettings> RETRY_PARAM_DEFINITIONS;

    static {
      ImmutableMap.Builder<String, RetrySettings> definitions = ImmutableMap.builder();
      RetrySettings settings = null;
      settings =
          RetrySettings.newBuilder()
              .setInitialRetryDelay(Duration.ofMillis(100L))
              .setRetryDelayMultiplier(1.3)
              .setMaxRetryDelay(Duration.ofMillis(60000L))
              .setInitialRpcTimeout(Duration.ofMillis(20000L))
              .setRpcTimeoutMultiplier(1.0)
              .setMaxRpcTimeout(Duration.ofMillis(20000L))
              .setTotalTimeout(Duration.ofMillis(600000L))
              .build();
      definitions.put("default", settings);
      RETRY_PARAM_DEFINITIONS = definitions.build();
    }

    protected Builder() {
      this((ClientContext) null);
    }

    protected Builder(ClientContext clientContext) {
      super(clientContext);

      getDataSourceSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();

      listDataSourcesSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();

      createTransferConfigSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();

      updateTransferConfigSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();

      deleteTransferConfigSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();

      getTransferConfigSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();

      listTransferConfigsSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();

      scheduleTransferRunsSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();

      startManualTransferRunsSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();

      getTransferRunSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();

      deleteTransferRunSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();

      listTransferRunsSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();

      listTransferLogsSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();

      checkValidCredsSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();

      unaryMethodSettingsBuilders =
          ImmutableList.<UnaryCallSettings.Builder<?, ?>>of(
              getDataSourceSettings,
              listDataSourcesSettings,
              createTransferConfigSettings,
              updateTransferConfigSettings,
              deleteTransferConfigSettings,
              getTransferConfigSettings,
              listTransferConfigsSettings,
              scheduleTransferRunsSettings,
              startManualTransferRunsSettings,
              getTransferRunSettings,
              deleteTransferRunSettings,
              listTransferRunsSettings,
              listTransferLogsSettings,
              checkValidCredsSettings);

      initDefaults(this);
    }

    private static Builder createDefault() {
      Builder builder = new Builder((ClientContext) null);
      builder.setTransportChannelProvider(defaultTransportChannelProvider());
      builder.setCredentialsProvider(defaultCredentialsProviderBuilder().build());
      builder.setInternalHeaderProvider(defaultApiClientHeaderProviderBuilder().build());
      builder.setEndpoint(getDefaultEndpoint());
      return initDefaults(builder);
    }

    private static Builder initDefaults(Builder builder) {

      builder
          .getDataSourceSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("idempotent"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("default"));

      builder
          .listDataSourcesSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("idempotent"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("default"));

      builder
          .createTransferConfigSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("non_idempotent"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("default"));

      builder
          .updateTransferConfigSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("non_idempotent"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("default"));

      builder
          .deleteTransferConfigSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("non_idempotent"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("default"));

      builder
          .getTransferConfigSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("idempotent"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("default"));

      builder
          .listTransferConfigsSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("idempotent"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("default"));

      builder
          .scheduleTransferRunsSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("non_idempotent"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("default"));

      builder
          .startManualTransferRunsSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("non_idempotent"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("default"));

      builder
          .getTransferRunSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("idempotent"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("default"));

      builder
          .deleteTransferRunSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("non_idempotent"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("default"));

      builder
          .listTransferRunsSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("idempotent"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("default"));

      builder
          .listTransferLogsSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("idempotent"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("default"));

      builder
          .checkValidCredsSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("non_idempotent"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("default"));

      return builder;
    }

    protected Builder(DataTransferServiceStubSettings settings) {
      super(settings);

      getDataSourceSettings = settings.getDataSourceSettings.toBuilder();
      listDataSourcesSettings = settings.listDataSourcesSettings.toBuilder();
      createTransferConfigSettings = settings.createTransferConfigSettings.toBuilder();
      updateTransferConfigSettings = settings.updateTransferConfigSettings.toBuilder();
      deleteTransferConfigSettings = settings.deleteTransferConfigSettings.toBuilder();
      getTransferConfigSettings = settings.getTransferConfigSettings.toBuilder();
      listTransferConfigsSettings = settings.listTransferConfigsSettings.toBuilder();
      scheduleTransferRunsSettings = settings.scheduleTransferRunsSettings.toBuilder();
      startManualTransferRunsSettings = settings.startManualTransferRunsSettings.toBuilder();
      getTransferRunSettings = settings.getTransferRunSettings.toBuilder();
      deleteTransferRunSettings = settings.deleteTransferRunSettings.toBuilder();
      listTransferRunsSettings = settings.listTransferRunsSettings.toBuilder();
      listTransferLogsSettings = settings.listTransferLogsSettings.toBuilder();
      checkValidCredsSettings = settings.checkValidCredsSettings.toBuilder();

      unaryMethodSettingsBuilders =
          ImmutableList.<UnaryCallSettings.Builder<?, ?>>of(
              getDataSourceSettings,
              listDataSourcesSettings,
              createTransferConfigSettings,
              updateTransferConfigSettings,
              deleteTransferConfigSettings,
              getTransferConfigSettings,
              listTransferConfigsSettings,
              scheduleTransferRunsSettings,
              startManualTransferRunsSettings,
              getTransferRunSettings,
              deleteTransferRunSettings,
              listTransferRunsSettings,
              listTransferLogsSettings,
              checkValidCredsSettings);
    }

    // NEXT_MAJOR_VER: remove 'throws Exception'
    /**
     * Applies the given settings updater function to all of the unary API methods in this service.
     *
     * <p>Note: This method does not support applying settings to streaming methods.
     */
    public Builder applyToAllUnaryMethods(
        ApiFunction<UnaryCallSettings.Builder<?, ?>, Void> settingsUpdater) throws Exception {
      super.applyToAllUnaryMethods(unaryMethodSettingsBuilders, settingsUpdater);
      return this;
    }

    public ImmutableList<UnaryCallSettings.Builder<?, ?>> unaryMethodSettingsBuilders() {
      return unaryMethodSettingsBuilders;
    }

    /** Returns the builder for the settings used for calls to getDataSource. */
    public UnaryCallSettings.Builder<GetDataSourceRequest, DataSource> getDataSourceSettings() {
      return getDataSourceSettings;
    }

    /** Returns the builder for the settings used for calls to listDataSources. */
    public UnaryCallSettings.Builder<ListDataSourcesRequest, ListDataSourcesResponse>
        listDataSourcesSettings() {
      return listDataSourcesSettings;
    }

    /** Returns the builder for the settings used for calls to createTransferConfig. */
    public UnaryCallSettings.Builder<CreateTransferConfigRequest, TransferConfig>
        createTransferConfigSettings() {
      return createTransferConfigSettings;
    }

    /** Returns the builder for the settings used for calls to updateTransferConfig. */
    public UnaryCallSettings.Builder<UpdateTransferConfigRequest, TransferConfig>
        updateTransferConfigSettings() {
      return updateTransferConfigSettings;
    }

    /** Returns the builder for the settings used for calls to deleteTransferConfig. */
    public UnaryCallSettings.Builder<DeleteTransferConfigRequest, Empty>
        deleteTransferConfigSettings() {
      return deleteTransferConfigSettings;
    }

    /** Returns the builder for the settings used for calls to getTransferConfig. */
    public UnaryCallSettings.Builder<GetTransferConfigRequest, TransferConfig>
        getTransferConfigSettings() {
      return getTransferConfigSettings;
    }

    /** Returns the builder for the settings used for calls to listTransferConfigs. */
    public UnaryCallSettings.Builder<ListTransferConfigsRequest, ListTransferConfigsResponse>
        listTransferConfigsSettings() {
      return listTransferConfigsSettings;
    }

    /** Returns the builder for the settings used for calls to scheduleTransferRuns. */
    public UnaryCallSettings.Builder<ScheduleTransferRunsRequest, ScheduleTransferRunsResponse>
        scheduleTransferRunsSettings() {
      return scheduleTransferRunsSettings;
    }

    /** Returns the builder for the settings used for calls to startManualTransferRuns. */
    public UnaryCallSettings.Builder<
            StartManualTransferRunsRequest, StartManualTransferRunsResponse>
        startManualTransferRunsSettings() {
      return startManualTransferRunsSettings;
    }

    /** Returns the builder for the settings used for calls to getTransferRun. */
    public UnaryCallSettings.Builder<GetTransferRunRequest, TransferRun> getTransferRunSettings() {
      return getTransferRunSettings;
    }

    /** Returns the builder for the settings used for calls to deleteTransferRun. */
    public UnaryCallSettings.Builder<DeleteTransferRunRequest, Empty> deleteTransferRunSettings() {
      return deleteTransferRunSettings;
    }

    /** Returns the builder for the settings used for calls to listTransferRuns. */
    public UnaryCallSettings.Builder<ListTransferRunsRequest, ListTransferRunsResponse>
        listTransferRunsSettings() {
      return listTransferRunsSettings;
    }

    /** Returns the builder for the settings used for calls to listTransferLogs. */
    public UnaryCallSettings.Builder<ListTransferLogsRequest, ListTransferLogsResponse>
        listTransferLogsSettings() {
      return listTransferLogsSettings;
    }

    /** Returns the builder for the settings used for calls to checkValidCreds. */
    public UnaryCallSettings.Builder<CheckValidCredsRequest, CheckValidCredsResponse>
        checkValidCredsSettings() {
      return checkValidCredsSettings;
    }

    @Override
    public DataTransferServiceStubSettings build() throws IOException {
      return new DataTransferServiceStubSettings(this);
    }
  }
}
