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
package com.google.cloud.devtools.containeranalysis.v1alpha1.stub;

import static com.google.cloud.devtools.containeranalysis.v1alpha1.ContainerAnalysisClient.ListNoteOccurrencesPagedResponse;
import static com.google.cloud.devtools.containeranalysis.v1alpha1.ContainerAnalysisClient.ListNotesPagedResponse;
import static com.google.cloud.devtools.containeranalysis.v1alpha1.ContainerAnalysisClient.ListOccurrencesPagedResponse;

import com.google.api.core.BetaApi;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.core.BackgroundResourceAggregation;
import com.google.api.gax.grpc.GrpcCallSettings;
import com.google.api.gax.grpc.GrpcStubCallableFactory;
import com.google.api.gax.rpc.ClientContext;
import com.google.api.gax.rpc.RequestParamsExtractor;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.common.collect.ImmutableMap;
import com.google.containeranalysis.v1alpha1.CreateNoteRequest;
import com.google.containeranalysis.v1alpha1.CreateOccurrenceRequest;
import com.google.containeranalysis.v1alpha1.CreateOperationRequest;
import com.google.containeranalysis.v1alpha1.DeleteNoteRequest;
import com.google.containeranalysis.v1alpha1.DeleteOccurrenceRequest;
import com.google.containeranalysis.v1alpha1.GetNoteRequest;
import com.google.containeranalysis.v1alpha1.GetOccurrenceNoteRequest;
import com.google.containeranalysis.v1alpha1.GetOccurrenceRequest;
import com.google.containeranalysis.v1alpha1.GetScanConfigRequest;
import com.google.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryRequest;
import com.google.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryResponse;
import com.google.containeranalysis.v1alpha1.ListNoteOccurrencesRequest;
import com.google.containeranalysis.v1alpha1.ListNoteOccurrencesResponse;
import com.google.containeranalysis.v1alpha1.ListNotesRequest;
import com.google.containeranalysis.v1alpha1.ListNotesResponse;
import com.google.containeranalysis.v1alpha1.ListOccurrencesRequest;
import com.google.containeranalysis.v1alpha1.ListOccurrencesResponse;
import com.google.containeranalysis.v1alpha1.ListScanConfigsRequest;
import com.google.containeranalysis.v1alpha1.ListScanConfigsResponse;
import com.google.containeranalysis.v1alpha1.Note;
import com.google.containeranalysis.v1alpha1.Occurrence;
import com.google.containeranalysis.v1alpha1.ScanConfig;
import com.google.containeranalysis.v1alpha1.UpdateNoteRequest;
import com.google.containeranalysis.v1alpha1.UpdateOccurrenceRequest;
import com.google.containeranalysis.v1alpha1.UpdateOperationRequest;
import com.google.containeranalysis.v1alpha1.UpdateScanConfigRequest;
import com.google.iam.v1.GetIamPolicyRequest;
import com.google.iam.v1.Policy;
import com.google.iam.v1.SetIamPolicyRequest;
import com.google.iam.v1.TestIamPermissionsRequest;
import com.google.iam.v1.TestIamPermissionsResponse;
import com.google.longrunning.Operation;
import com.google.protobuf.Empty;
import io.grpc.MethodDescriptor;
import io.grpc.protobuf.ProtoUtils;
import java.io.IOException;
import java.util.Map;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS
/**
 * gRPC stub implementation for Container Analysis API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@Generated("by gapic-generator")
@BetaApi("A restructuring of stub classes is planned, so this may break in the future")
public class GrpcContainerAnalysisStub extends ContainerAnalysisStub {

  private static final MethodDescriptor<GetOccurrenceRequest, Occurrence>
      getOccurrenceMethodDescriptor =
          MethodDescriptor.<GetOccurrenceRequest, Occurrence>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.devtools.containeranalysis.v1alpha1.ContainerAnalysis/GetOccurrence")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(GetOccurrenceRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(Occurrence.getDefaultInstance()))
              .build();
  private static final MethodDescriptor<ListOccurrencesRequest, ListOccurrencesResponse>
      listOccurrencesMethodDescriptor =
          MethodDescriptor.<ListOccurrencesRequest, ListOccurrencesResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.devtools.containeranalysis.v1alpha1.ContainerAnalysis/ListOccurrences")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(ListOccurrencesRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(ListOccurrencesResponse.getDefaultInstance()))
              .build();
  private static final MethodDescriptor<DeleteOccurrenceRequest, Empty>
      deleteOccurrenceMethodDescriptor =
          MethodDescriptor.<DeleteOccurrenceRequest, Empty>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.devtools.containeranalysis.v1alpha1.ContainerAnalysis/DeleteOccurrence")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(DeleteOccurrenceRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(Empty.getDefaultInstance()))
              .build();
  private static final MethodDescriptor<CreateOccurrenceRequest, Occurrence>
      createOccurrenceMethodDescriptor =
          MethodDescriptor.<CreateOccurrenceRequest, Occurrence>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.devtools.containeranalysis.v1alpha1.ContainerAnalysis/CreateOccurrence")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(CreateOccurrenceRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(Occurrence.getDefaultInstance()))
              .build();
  private static final MethodDescriptor<UpdateOccurrenceRequest, Occurrence>
      updateOccurrenceMethodDescriptor =
          MethodDescriptor.<UpdateOccurrenceRequest, Occurrence>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.devtools.containeranalysis.v1alpha1.ContainerAnalysis/UpdateOccurrence")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(UpdateOccurrenceRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(Occurrence.getDefaultInstance()))
              .build();
  private static final MethodDescriptor<GetOccurrenceNoteRequest, Note>
      getOccurrenceNoteMethodDescriptor =
          MethodDescriptor.<GetOccurrenceNoteRequest, Note>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.devtools.containeranalysis.v1alpha1.ContainerAnalysis/GetOccurrenceNote")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(GetOccurrenceNoteRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(Note.getDefaultInstance()))
              .build();
  private static final MethodDescriptor<GetNoteRequest, Note> getNoteMethodDescriptor =
      MethodDescriptor.<GetNoteRequest, Note>newBuilder()
          .setType(MethodDescriptor.MethodType.UNARY)
          .setFullMethodName("google.devtools.containeranalysis.v1alpha1.ContainerAnalysis/GetNote")
          .setRequestMarshaller(ProtoUtils.marshaller(GetNoteRequest.getDefaultInstance()))
          .setResponseMarshaller(ProtoUtils.marshaller(Note.getDefaultInstance()))
          .build();
  private static final MethodDescriptor<ListNotesRequest, ListNotesResponse>
      listNotesMethodDescriptor =
          MethodDescriptor.<ListNotesRequest, ListNotesResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.devtools.containeranalysis.v1alpha1.ContainerAnalysis/ListNotes")
              .setRequestMarshaller(ProtoUtils.marshaller(ListNotesRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(ListNotesResponse.getDefaultInstance()))
              .build();
  private static final MethodDescriptor<DeleteNoteRequest, Empty> deleteNoteMethodDescriptor =
      MethodDescriptor.<DeleteNoteRequest, Empty>newBuilder()
          .setType(MethodDescriptor.MethodType.UNARY)
          .setFullMethodName(
              "google.devtools.containeranalysis.v1alpha1.ContainerAnalysis/DeleteNote")
          .setRequestMarshaller(ProtoUtils.marshaller(DeleteNoteRequest.getDefaultInstance()))
          .setResponseMarshaller(ProtoUtils.marshaller(Empty.getDefaultInstance()))
          .build();
  private static final MethodDescriptor<CreateNoteRequest, Note> createNoteMethodDescriptor =
      MethodDescriptor.<CreateNoteRequest, Note>newBuilder()
          .setType(MethodDescriptor.MethodType.UNARY)
          .setFullMethodName(
              "google.devtools.containeranalysis.v1alpha1.ContainerAnalysis/CreateNote")
          .setRequestMarshaller(ProtoUtils.marshaller(CreateNoteRequest.getDefaultInstance()))
          .setResponseMarshaller(ProtoUtils.marshaller(Note.getDefaultInstance()))
          .build();
  private static final MethodDescriptor<UpdateNoteRequest, Note> updateNoteMethodDescriptor =
      MethodDescriptor.<UpdateNoteRequest, Note>newBuilder()
          .setType(MethodDescriptor.MethodType.UNARY)
          .setFullMethodName(
              "google.devtools.containeranalysis.v1alpha1.ContainerAnalysis/UpdateNote")
          .setRequestMarshaller(ProtoUtils.marshaller(UpdateNoteRequest.getDefaultInstance()))
          .setResponseMarshaller(ProtoUtils.marshaller(Note.getDefaultInstance()))
          .build();
  private static final MethodDescriptor<ListNoteOccurrencesRequest, ListNoteOccurrencesResponse>
      listNoteOccurrencesMethodDescriptor =
          MethodDescriptor.<ListNoteOccurrencesRequest, ListNoteOccurrencesResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.devtools.containeranalysis.v1alpha1.ContainerAnalysis/ListNoteOccurrences")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(ListNoteOccurrencesRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(ListNoteOccurrencesResponse.getDefaultInstance()))
              .build();
  private static final MethodDescriptor<
          GetVulnzOccurrencesSummaryRequest, GetVulnzOccurrencesSummaryResponse>
      getVulnzOccurrencesSummaryMethodDescriptor =
          MethodDescriptor
              .<GetVulnzOccurrencesSummaryRequest, GetVulnzOccurrencesSummaryResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.devtools.containeranalysis.v1alpha1.ContainerAnalysis/GetVulnzOccurrencesSummary")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(GetVulnzOccurrencesSummaryRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(GetVulnzOccurrencesSummaryResponse.getDefaultInstance()))
              .build();
  private static final MethodDescriptor<SetIamPolicyRequest, Policy> setIamPolicyMethodDescriptor =
      MethodDescriptor.<SetIamPolicyRequest, Policy>newBuilder()
          .setType(MethodDescriptor.MethodType.UNARY)
          .setFullMethodName(
              "google.devtools.containeranalysis.v1alpha1.ContainerAnalysis/SetIamPolicy")
          .setRequestMarshaller(ProtoUtils.marshaller(SetIamPolicyRequest.getDefaultInstance()))
          .setResponseMarshaller(ProtoUtils.marshaller(Policy.getDefaultInstance()))
          .build();
  private static final MethodDescriptor<GetIamPolicyRequest, Policy> getIamPolicyMethodDescriptor =
      MethodDescriptor.<GetIamPolicyRequest, Policy>newBuilder()
          .setType(MethodDescriptor.MethodType.UNARY)
          .setFullMethodName(
              "google.devtools.containeranalysis.v1alpha1.ContainerAnalysis/GetIamPolicy")
          .setRequestMarshaller(ProtoUtils.marshaller(GetIamPolicyRequest.getDefaultInstance()))
          .setResponseMarshaller(ProtoUtils.marshaller(Policy.getDefaultInstance()))
          .build();
  private static final MethodDescriptor<TestIamPermissionsRequest, TestIamPermissionsResponse>
      testIamPermissionsMethodDescriptor =
          MethodDescriptor.<TestIamPermissionsRequest, TestIamPermissionsResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.devtools.containeranalysis.v1alpha1.ContainerAnalysis/TestIamPermissions")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(TestIamPermissionsRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(TestIamPermissionsResponse.getDefaultInstance()))
              .build();
  private static final MethodDescriptor<CreateOperationRequest, Operation>
      createOperationMethodDescriptor =
          MethodDescriptor.<CreateOperationRequest, Operation>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.devtools.containeranalysis.v1alpha1.ContainerAnalysis/CreateOperation")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(CreateOperationRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(Operation.getDefaultInstance()))
              .build();
  private static final MethodDescriptor<UpdateOperationRequest, Operation>
      updateOperationMethodDescriptor =
          MethodDescriptor.<UpdateOperationRequest, Operation>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.devtools.containeranalysis.v1alpha1.ContainerAnalysis/UpdateOperation")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(UpdateOperationRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(Operation.getDefaultInstance()))
              .build();
  private static final MethodDescriptor<GetScanConfigRequest, ScanConfig>
      getScanConfigMethodDescriptor =
          MethodDescriptor.<GetScanConfigRequest, ScanConfig>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.devtools.containeranalysis.v1alpha1.ContainerAnalysis/GetScanConfig")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(GetScanConfigRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(ScanConfig.getDefaultInstance()))
              .build();
  private static final MethodDescriptor<ListScanConfigsRequest, ListScanConfigsResponse>
      listScanConfigsMethodDescriptor =
          MethodDescriptor.<ListScanConfigsRequest, ListScanConfigsResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.devtools.containeranalysis.v1alpha1.ContainerAnalysis/ListScanConfigs")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(ListScanConfigsRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(ListScanConfigsResponse.getDefaultInstance()))
              .build();
  private static final MethodDescriptor<UpdateScanConfigRequest, ScanConfig>
      updateScanConfigMethodDescriptor =
          MethodDescriptor.<UpdateScanConfigRequest, ScanConfig>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.devtools.containeranalysis.v1alpha1.ContainerAnalysis/UpdateScanConfig")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(UpdateScanConfigRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(ScanConfig.getDefaultInstance()))
              .build();

  private final BackgroundResource backgroundResources;

  private final UnaryCallable<GetOccurrenceRequest, Occurrence> getOccurrenceCallable;
  private final UnaryCallable<ListOccurrencesRequest, ListOccurrencesResponse>
      listOccurrencesCallable;
  private final UnaryCallable<ListOccurrencesRequest, ListOccurrencesPagedResponse>
      listOccurrencesPagedCallable;
  private final UnaryCallable<DeleteOccurrenceRequest, Empty> deleteOccurrenceCallable;
  private final UnaryCallable<CreateOccurrenceRequest, Occurrence> createOccurrenceCallable;
  private final UnaryCallable<UpdateOccurrenceRequest, Occurrence> updateOccurrenceCallable;
  private final UnaryCallable<GetOccurrenceNoteRequest, Note> getOccurrenceNoteCallable;
  private final UnaryCallable<GetNoteRequest, Note> getNoteCallable;
  private final UnaryCallable<ListNotesRequest, ListNotesResponse> listNotesCallable;
  private final UnaryCallable<ListNotesRequest, ListNotesPagedResponse> listNotesPagedCallable;
  private final UnaryCallable<DeleteNoteRequest, Empty> deleteNoteCallable;
  private final UnaryCallable<CreateNoteRequest, Note> createNoteCallable;
  private final UnaryCallable<UpdateNoteRequest, Note> updateNoteCallable;
  private final UnaryCallable<ListNoteOccurrencesRequest, ListNoteOccurrencesResponse>
      listNoteOccurrencesCallable;
  private final UnaryCallable<ListNoteOccurrencesRequest, ListNoteOccurrencesPagedResponse>
      listNoteOccurrencesPagedCallable;
  private final UnaryCallable<GetVulnzOccurrencesSummaryRequest, GetVulnzOccurrencesSummaryResponse>
      getVulnzOccurrencesSummaryCallable;
  private final UnaryCallable<SetIamPolicyRequest, Policy> setIamPolicyCallable;
  private final UnaryCallable<GetIamPolicyRequest, Policy> getIamPolicyCallable;
  private final UnaryCallable<TestIamPermissionsRequest, TestIamPermissionsResponse>
      testIamPermissionsCallable;
  private final UnaryCallable<CreateOperationRequest, Operation> createOperationCallable;
  private final UnaryCallable<UpdateOperationRequest, Operation> updateOperationCallable;
  private final UnaryCallable<GetScanConfigRequest, ScanConfig> getScanConfigCallable;
  private final UnaryCallable<ListScanConfigsRequest, ListScanConfigsResponse>
      listScanConfigsCallable;
  private final UnaryCallable<UpdateScanConfigRequest, ScanConfig> updateScanConfigCallable;

  private final GrpcStubCallableFactory callableFactory;

  public static final GrpcContainerAnalysisStub create(ContainerAnalysisStubSettings settings)
      throws IOException {
    return new GrpcContainerAnalysisStub(settings, ClientContext.create(settings));
  }

  public static final GrpcContainerAnalysisStub create(ClientContext clientContext)
      throws IOException {
    return new GrpcContainerAnalysisStub(
        ContainerAnalysisStubSettings.newBuilder().build(), clientContext);
  }

  public static final GrpcContainerAnalysisStub create(
      ClientContext clientContext, GrpcStubCallableFactory callableFactory) throws IOException {
    return new GrpcContainerAnalysisStub(
        ContainerAnalysisStubSettings.newBuilder().build(), clientContext, callableFactory);
  }

  /**
   * Constructs an instance of GrpcContainerAnalysisStub, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected GrpcContainerAnalysisStub(
      ContainerAnalysisStubSettings settings, ClientContext clientContext) throws IOException {
    this(settings, clientContext, new GrpcContainerAnalysisCallableFactory());
  }

  /**
   * Constructs an instance of GrpcContainerAnalysisStub, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected GrpcContainerAnalysisStub(
      ContainerAnalysisStubSettings settings,
      ClientContext clientContext,
      GrpcStubCallableFactory callableFactory)
      throws IOException {
    this.callableFactory = callableFactory;

    GrpcCallSettings<GetOccurrenceRequest, Occurrence> getOccurrenceTransportSettings =
        GrpcCallSettings.<GetOccurrenceRequest, Occurrence>newBuilder()
            .setMethodDescriptor(getOccurrenceMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<GetOccurrenceRequest>() {
                  @Override
                  public Map<String, String> extract(GetOccurrenceRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("name", String.valueOf(request.getName()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<ListOccurrencesRequest, ListOccurrencesResponse>
        listOccurrencesTransportSettings =
            GrpcCallSettings.<ListOccurrencesRequest, ListOccurrencesResponse>newBuilder()
                .setMethodDescriptor(listOccurrencesMethodDescriptor)
                .setParamsExtractor(
                    new RequestParamsExtractor<ListOccurrencesRequest>() {
                      @Override
                      public Map<String, String> extract(ListOccurrencesRequest request) {
                        ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                        params.put("parent", String.valueOf(request.getParent()));
                        return params.build();
                      }
                    })
                .build();
    GrpcCallSettings<DeleteOccurrenceRequest, Empty> deleteOccurrenceTransportSettings =
        GrpcCallSettings.<DeleteOccurrenceRequest, Empty>newBuilder()
            .setMethodDescriptor(deleteOccurrenceMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<DeleteOccurrenceRequest>() {
                  @Override
                  public Map<String, String> extract(DeleteOccurrenceRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("name", String.valueOf(request.getName()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<CreateOccurrenceRequest, Occurrence> createOccurrenceTransportSettings =
        GrpcCallSettings.<CreateOccurrenceRequest, Occurrence>newBuilder()
            .setMethodDescriptor(createOccurrenceMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<CreateOccurrenceRequest>() {
                  @Override
                  public Map<String, String> extract(CreateOccurrenceRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("parent", String.valueOf(request.getParent()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<UpdateOccurrenceRequest, Occurrence> updateOccurrenceTransportSettings =
        GrpcCallSettings.<UpdateOccurrenceRequest, Occurrence>newBuilder()
            .setMethodDescriptor(updateOccurrenceMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<UpdateOccurrenceRequest>() {
                  @Override
                  public Map<String, String> extract(UpdateOccurrenceRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("name", String.valueOf(request.getName()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<GetOccurrenceNoteRequest, Note> getOccurrenceNoteTransportSettings =
        GrpcCallSettings.<GetOccurrenceNoteRequest, Note>newBuilder()
            .setMethodDescriptor(getOccurrenceNoteMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<GetOccurrenceNoteRequest>() {
                  @Override
                  public Map<String, String> extract(GetOccurrenceNoteRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("name", String.valueOf(request.getName()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<GetNoteRequest, Note> getNoteTransportSettings =
        GrpcCallSettings.<GetNoteRequest, Note>newBuilder()
            .setMethodDescriptor(getNoteMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<GetNoteRequest>() {
                  @Override
                  public Map<String, String> extract(GetNoteRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("name", String.valueOf(request.getName()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<ListNotesRequest, ListNotesResponse> listNotesTransportSettings =
        GrpcCallSettings.<ListNotesRequest, ListNotesResponse>newBuilder()
            .setMethodDescriptor(listNotesMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<ListNotesRequest>() {
                  @Override
                  public Map<String, String> extract(ListNotesRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("parent", String.valueOf(request.getParent()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<DeleteNoteRequest, Empty> deleteNoteTransportSettings =
        GrpcCallSettings.<DeleteNoteRequest, Empty>newBuilder()
            .setMethodDescriptor(deleteNoteMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<DeleteNoteRequest>() {
                  @Override
                  public Map<String, String> extract(DeleteNoteRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("name", String.valueOf(request.getName()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<CreateNoteRequest, Note> createNoteTransportSettings =
        GrpcCallSettings.<CreateNoteRequest, Note>newBuilder()
            .setMethodDescriptor(createNoteMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<CreateNoteRequest>() {
                  @Override
                  public Map<String, String> extract(CreateNoteRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("parent", String.valueOf(request.getParent()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<UpdateNoteRequest, Note> updateNoteTransportSettings =
        GrpcCallSettings.<UpdateNoteRequest, Note>newBuilder()
            .setMethodDescriptor(updateNoteMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<UpdateNoteRequest>() {
                  @Override
                  public Map<String, String> extract(UpdateNoteRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("name", String.valueOf(request.getName()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<ListNoteOccurrencesRequest, ListNoteOccurrencesResponse>
        listNoteOccurrencesTransportSettings =
            GrpcCallSettings.<ListNoteOccurrencesRequest, ListNoteOccurrencesResponse>newBuilder()
                .setMethodDescriptor(listNoteOccurrencesMethodDescriptor)
                .setParamsExtractor(
                    new RequestParamsExtractor<ListNoteOccurrencesRequest>() {
                      @Override
                      public Map<String, String> extract(ListNoteOccurrencesRequest request) {
                        ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                        params.put("name", String.valueOf(request.getName()));
                        return params.build();
                      }
                    })
                .build();
    GrpcCallSettings<GetVulnzOccurrencesSummaryRequest, GetVulnzOccurrencesSummaryResponse>
        getVulnzOccurrencesSummaryTransportSettings =
            GrpcCallSettings
                .<GetVulnzOccurrencesSummaryRequest, GetVulnzOccurrencesSummaryResponse>newBuilder()
                .setMethodDescriptor(getVulnzOccurrencesSummaryMethodDescriptor)
                .setParamsExtractor(
                    new RequestParamsExtractor<GetVulnzOccurrencesSummaryRequest>() {
                      @Override
                      public Map<String, String> extract(
                          GetVulnzOccurrencesSummaryRequest request) {
                        ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                        params.put("parent", String.valueOf(request.getParent()));
                        return params.build();
                      }
                    })
                .build();
    GrpcCallSettings<SetIamPolicyRequest, Policy> setIamPolicyTransportSettings =
        GrpcCallSettings.<SetIamPolicyRequest, Policy>newBuilder()
            .setMethodDescriptor(setIamPolicyMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<SetIamPolicyRequest>() {
                  @Override
                  public Map<String, String> extract(SetIamPolicyRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("resource", String.valueOf(request.getResource()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<GetIamPolicyRequest, Policy> getIamPolicyTransportSettings =
        GrpcCallSettings.<GetIamPolicyRequest, Policy>newBuilder()
            .setMethodDescriptor(getIamPolicyMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<GetIamPolicyRequest>() {
                  @Override
                  public Map<String, String> extract(GetIamPolicyRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("resource", String.valueOf(request.getResource()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<TestIamPermissionsRequest, TestIamPermissionsResponse>
        testIamPermissionsTransportSettings =
            GrpcCallSettings.<TestIamPermissionsRequest, TestIamPermissionsResponse>newBuilder()
                .setMethodDescriptor(testIamPermissionsMethodDescriptor)
                .setParamsExtractor(
                    new RequestParamsExtractor<TestIamPermissionsRequest>() {
                      @Override
                      public Map<String, String> extract(TestIamPermissionsRequest request) {
                        ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                        params.put("resource", String.valueOf(request.getResource()));
                        return params.build();
                      }
                    })
                .build();
    GrpcCallSettings<CreateOperationRequest, Operation> createOperationTransportSettings =
        GrpcCallSettings.<CreateOperationRequest, Operation>newBuilder()
            .setMethodDescriptor(createOperationMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<CreateOperationRequest>() {
                  @Override
                  public Map<String, String> extract(CreateOperationRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("parent", String.valueOf(request.getParent()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<UpdateOperationRequest, Operation> updateOperationTransportSettings =
        GrpcCallSettings.<UpdateOperationRequest, Operation>newBuilder()
            .setMethodDescriptor(updateOperationMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<UpdateOperationRequest>() {
                  @Override
                  public Map<String, String> extract(UpdateOperationRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("name", String.valueOf(request.getName()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<GetScanConfigRequest, ScanConfig> getScanConfigTransportSettings =
        GrpcCallSettings.<GetScanConfigRequest, ScanConfig>newBuilder()
            .setMethodDescriptor(getScanConfigMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<GetScanConfigRequest>() {
                  @Override
                  public Map<String, String> extract(GetScanConfigRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("name", String.valueOf(request.getName()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<ListScanConfigsRequest, ListScanConfigsResponse>
        listScanConfigsTransportSettings =
            GrpcCallSettings.<ListScanConfigsRequest, ListScanConfigsResponse>newBuilder()
                .setMethodDescriptor(listScanConfigsMethodDescriptor)
                .setParamsExtractor(
                    new RequestParamsExtractor<ListScanConfigsRequest>() {
                      @Override
                      public Map<String, String> extract(ListScanConfigsRequest request) {
                        ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                        params.put("parent", String.valueOf(request.getParent()));
                        return params.build();
                      }
                    })
                .build();
    GrpcCallSettings<UpdateScanConfigRequest, ScanConfig> updateScanConfigTransportSettings =
        GrpcCallSettings.<UpdateScanConfigRequest, ScanConfig>newBuilder()
            .setMethodDescriptor(updateScanConfigMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<UpdateScanConfigRequest>() {
                  @Override
                  public Map<String, String> extract(UpdateScanConfigRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("name", String.valueOf(request.getName()));
                    return params.build();
                  }
                })
            .build();

    this.getOccurrenceCallable =
        callableFactory.createUnaryCallable(
            getOccurrenceTransportSettings, settings.getOccurrenceSettings(), clientContext);
    this.listOccurrencesCallable =
        callableFactory.createUnaryCallable(
            listOccurrencesTransportSettings, settings.listOccurrencesSettings(), clientContext);
    this.listOccurrencesPagedCallable =
        callableFactory.createPagedCallable(
            listOccurrencesTransportSettings, settings.listOccurrencesSettings(), clientContext);
    this.deleteOccurrenceCallable =
        callableFactory.createUnaryCallable(
            deleteOccurrenceTransportSettings, settings.deleteOccurrenceSettings(), clientContext);
    this.createOccurrenceCallable =
        callableFactory.createUnaryCallable(
            createOccurrenceTransportSettings, settings.createOccurrenceSettings(), clientContext);
    this.updateOccurrenceCallable =
        callableFactory.createUnaryCallable(
            updateOccurrenceTransportSettings, settings.updateOccurrenceSettings(), clientContext);
    this.getOccurrenceNoteCallable =
        callableFactory.createUnaryCallable(
            getOccurrenceNoteTransportSettings,
            settings.getOccurrenceNoteSettings(),
            clientContext);
    this.getNoteCallable =
        callableFactory.createUnaryCallable(
            getNoteTransportSettings, settings.getNoteSettings(), clientContext);
    this.listNotesCallable =
        callableFactory.createUnaryCallable(
            listNotesTransportSettings, settings.listNotesSettings(), clientContext);
    this.listNotesPagedCallable =
        callableFactory.createPagedCallable(
            listNotesTransportSettings, settings.listNotesSettings(), clientContext);
    this.deleteNoteCallable =
        callableFactory.createUnaryCallable(
            deleteNoteTransportSettings, settings.deleteNoteSettings(), clientContext);
    this.createNoteCallable =
        callableFactory.createUnaryCallable(
            createNoteTransportSettings, settings.createNoteSettings(), clientContext);
    this.updateNoteCallable =
        callableFactory.createUnaryCallable(
            updateNoteTransportSettings, settings.updateNoteSettings(), clientContext);
    this.listNoteOccurrencesCallable =
        callableFactory.createUnaryCallable(
            listNoteOccurrencesTransportSettings,
            settings.listNoteOccurrencesSettings(),
            clientContext);
    this.listNoteOccurrencesPagedCallable =
        callableFactory.createPagedCallable(
            listNoteOccurrencesTransportSettings,
            settings.listNoteOccurrencesSettings(),
            clientContext);
    this.getVulnzOccurrencesSummaryCallable =
        callableFactory.createUnaryCallable(
            getVulnzOccurrencesSummaryTransportSettings,
            settings.getVulnzOccurrencesSummarySettings(),
            clientContext);
    this.setIamPolicyCallable =
        callableFactory.createUnaryCallable(
            setIamPolicyTransportSettings, settings.setIamPolicySettings(), clientContext);
    this.getIamPolicyCallable =
        callableFactory.createUnaryCallable(
            getIamPolicyTransportSettings, settings.getIamPolicySettings(), clientContext);
    this.testIamPermissionsCallable =
        callableFactory.createUnaryCallable(
            testIamPermissionsTransportSettings,
            settings.testIamPermissionsSettings(),
            clientContext);
    this.createOperationCallable =
        callableFactory.createUnaryCallable(
            createOperationTransportSettings, settings.createOperationSettings(), clientContext);
    this.updateOperationCallable =
        callableFactory.createUnaryCallable(
            updateOperationTransportSettings, settings.updateOperationSettings(), clientContext);
    this.getScanConfigCallable =
        callableFactory.createUnaryCallable(
            getScanConfigTransportSettings, settings.getScanConfigSettings(), clientContext);
    this.listScanConfigsCallable =
        callableFactory.createUnaryCallable(
            listScanConfigsTransportSettings, settings.listScanConfigsSettings(), clientContext);
    this.updateScanConfigCallable =
        callableFactory.createUnaryCallable(
            updateScanConfigTransportSettings, settings.updateScanConfigSettings(), clientContext);

    backgroundResources = new BackgroundResourceAggregation(clientContext.getBackgroundResources());
  }

  public UnaryCallable<GetOccurrenceRequest, Occurrence> getOccurrenceCallable() {
    return getOccurrenceCallable;
  }

  public UnaryCallable<ListOccurrencesRequest, ListOccurrencesPagedResponse>
      listOccurrencesPagedCallable() {
    return listOccurrencesPagedCallable;
  }

  public UnaryCallable<ListOccurrencesRequest, ListOccurrencesResponse> listOccurrencesCallable() {
    return listOccurrencesCallable;
  }

  public UnaryCallable<DeleteOccurrenceRequest, Empty> deleteOccurrenceCallable() {
    return deleteOccurrenceCallable;
  }

  public UnaryCallable<CreateOccurrenceRequest, Occurrence> createOccurrenceCallable() {
    return createOccurrenceCallable;
  }

  public UnaryCallable<UpdateOccurrenceRequest, Occurrence> updateOccurrenceCallable() {
    return updateOccurrenceCallable;
  }

  public UnaryCallable<GetOccurrenceNoteRequest, Note> getOccurrenceNoteCallable() {
    return getOccurrenceNoteCallable;
  }

  public UnaryCallable<GetNoteRequest, Note> getNoteCallable() {
    return getNoteCallable;
  }

  public UnaryCallable<ListNotesRequest, ListNotesPagedResponse> listNotesPagedCallable() {
    return listNotesPagedCallable;
  }

  public UnaryCallable<ListNotesRequest, ListNotesResponse> listNotesCallable() {
    return listNotesCallable;
  }

  public UnaryCallable<DeleteNoteRequest, Empty> deleteNoteCallable() {
    return deleteNoteCallable;
  }

  public UnaryCallable<CreateNoteRequest, Note> createNoteCallable() {
    return createNoteCallable;
  }

  public UnaryCallable<UpdateNoteRequest, Note> updateNoteCallable() {
    return updateNoteCallable;
  }

  public UnaryCallable<ListNoteOccurrencesRequest, ListNoteOccurrencesPagedResponse>
      listNoteOccurrencesPagedCallable() {
    return listNoteOccurrencesPagedCallable;
  }

  public UnaryCallable<ListNoteOccurrencesRequest, ListNoteOccurrencesResponse>
      listNoteOccurrencesCallable() {
    return listNoteOccurrencesCallable;
  }

  public UnaryCallable<GetVulnzOccurrencesSummaryRequest, GetVulnzOccurrencesSummaryResponse>
      getVulnzOccurrencesSummaryCallable() {
    return getVulnzOccurrencesSummaryCallable;
  }

  public UnaryCallable<SetIamPolicyRequest, Policy> setIamPolicyCallable() {
    return setIamPolicyCallable;
  }

  public UnaryCallable<GetIamPolicyRequest, Policy> getIamPolicyCallable() {
    return getIamPolicyCallable;
  }

  public UnaryCallable<TestIamPermissionsRequest, TestIamPermissionsResponse>
      testIamPermissionsCallable() {
    return testIamPermissionsCallable;
  }

  public UnaryCallable<CreateOperationRequest, Operation> createOperationCallable() {
    return createOperationCallable;
  }

  public UnaryCallable<UpdateOperationRequest, Operation> updateOperationCallable() {
    return updateOperationCallable;
  }

  public UnaryCallable<GetScanConfigRequest, ScanConfig> getScanConfigCallable() {
    return getScanConfigCallable;
  }

  public UnaryCallable<ListScanConfigsRequest, ListScanConfigsResponse> listScanConfigsCallable() {
    return listScanConfigsCallable;
  }

  public UnaryCallable<UpdateScanConfigRequest, ScanConfig> updateScanConfigCallable() {
    return updateScanConfigCallable;
  }

  @Override
  public final void close() {
    shutdown();
  }

  @Override
  public void shutdown() {
    backgroundResources.shutdown();
  }

  @Override
  public boolean isShutdown() {
    return backgroundResources.isShutdown();
  }

  @Override
  public boolean isTerminated() {
    return backgroundResources.isTerminated();
  }

  @Override
  public void shutdownNow() {
    backgroundResources.shutdownNow();
  }

  @Override
  public boolean awaitTermination(long duration, TimeUnit unit) throws InterruptedException {
    return backgroundResources.awaitTermination(duration, unit);
  }
}
