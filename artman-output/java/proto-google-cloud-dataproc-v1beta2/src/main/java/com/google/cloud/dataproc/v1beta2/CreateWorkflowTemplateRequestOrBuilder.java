// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/dataproc/v1beta2/workflow_templates.proto

package com.google.cloud.dataproc.v1beta2;

public interface CreateWorkflowTemplateRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.dataproc.v1beta2.CreateWorkflowTemplateRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The resource name of the region or location, as described
   * in https://cloud.google.com/apis/design/resource_names.
   * * For `projects.regions.workflowTemplates,create`, the resource name of the
   *   region has the following format:
   *   `projects/{project_id}/regions/{region}`
   * * For `projects.locations.workflowTemplates.create`, the resource name of
   *   the location has the following format:
   *   `projects/{project_id}/locations/{location}`
   * </pre>
   *
   * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The parent.
   */
  java.lang.String getParent();
  /**
   * <pre>
   * Required. The resource name of the region or location, as described
   * in https://cloud.google.com/apis/design/resource_names.
   * * For `projects.regions.workflowTemplates,create`, the resource name of the
   *   region has the following format:
   *   `projects/{project_id}/regions/{region}`
   * * For `projects.locations.workflowTemplates.create`, the resource name of
   *   the location has the following format:
   *   `projects/{project_id}/locations/{location}`
   * </pre>
   *
   * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The bytes for parent.
   */
  com.google.protobuf.ByteString
      getParentBytes();

  /**
   * <pre>
   * Required. The Dataproc workflow template to create.
   * </pre>
   *
   * <code>.google.cloud.dataproc.v1beta2.WorkflowTemplate template = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return Whether the template field is set.
   */
  boolean hasTemplate();
  /**
   * <pre>
   * Required. The Dataproc workflow template to create.
   * </pre>
   *
   * <code>.google.cloud.dataproc.v1beta2.WorkflowTemplate template = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The template.
   */
  com.google.cloud.dataproc.v1beta2.WorkflowTemplate getTemplate();
  /**
   * <pre>
   * Required. The Dataproc workflow template to create.
   * </pre>
   *
   * <code>.google.cloud.dataproc.v1beta2.WorkflowTemplate template = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  com.google.cloud.dataproc.v1beta2.WorkflowTemplateOrBuilder getTemplateOrBuilder();
}
