/*
 * Copyright 2018 Google LLC
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except
 * in compliance with the License. You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software distributed under the License
 * is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and limitations under
 * the License.
 */

package com.google.cloud.talent.v4beta1;

import com.google.common.base.Preconditions;
import com.google.common.collect.ImmutableMap;
import com.google.api.core.BetaApi;
import com.google.api.pathtemplate.PathTemplate;
import com.google.api.pathtemplate.ValidationException;
import com.google.api.resourcenames.ResourceName;
import java.util.Map;
import java.util.ArrayList;
import java.util.List;
import java.util.Objects;

/**
 * AUTO-GENERATED DOCUMENTATION AND CLASS
 */
@javax.annotation.Generated("by GAPIC protoc plugin")
public class TenantOrProjectName implements ResourceName {
  
  @Deprecated
  protected TenantOrProjectName() { }

  private static final PathTemplate PROJECT_TENANT_PATH_TEMPLATE =
      PathTemplate.createWithoutUrlEncoding("projects/{project}/tenants/{tenant}");
  private static final PathTemplate PROJECT_PATH_TEMPLATE =
      PathTemplate.createWithoutUrlEncoding("projects/{project}");

  private volatile Map<String, String> fieldValuesMap;
  private PathTemplate pathTemplate;
  private String fixedValue;

  private String project;
  private String tenant;

  public String getProject() {
    return project;
  }

  public String getTenant() {
    return tenant;
  }


  private TenantOrProjectName(Builder builder) {
    project = Preconditions.checkNotNull(builder.getProject());
    tenant = Preconditions.checkNotNull(builder.getTenant());
    pathTemplate = PROJECT_TENANT_PATH_TEMPLATE;
  }

  private TenantOrProjectName(ProjectBuilder builder) {
    project = Preconditions.checkNotNull(builder.getProject());
    pathTemplate = PROJECT_PATH_TEMPLATE;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  @BetaApi("The per-pattern Builders are not stable yet and may be changed in the future.")
  public static Builder newProjectTenantBuilder() {
    return new Builder();
  }

  @BetaApi("The per-pattern Builders are not stable yet and may be changed in the future.")
  public static ProjectBuilder newProjectBuilder() {
    return new ProjectBuilder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }
  
  public static TenantOrProjectName of(String project, String tenant) {
    return newProjectTenantBuilder()
        .setProject(project)
        .setTenant(tenant)
        .build();
  }

  @BetaApi("The static create methods are not stable yet and may be changed in the future.")
  public static TenantOrProjectName ofProjectTenantName(String project, String tenant) {
    return newProjectTenantBuilder()
        .setProject(project)
        .setTenant(tenant)
        .build();
  }

  @BetaApi("The static create methods are not stable yet and may be changed in the future.")
  public static TenantOrProjectName ofProjectName(String project) {
    return newProjectBuilder()
        .setProject(project)
        .build();
  }

  public static String format(String project, String tenant) {
    return newBuilder()
        .setProject(project)
        .setTenant(tenant)
        .build()
        .toString();
  }

  @BetaApi("The static format methods are not stable yet and may be changed in the future.")
  public static String formatProjectTenantName(String project, String tenant) {
    return newBuilder()
        .setProject(project)
        .setTenant(tenant)
        .build()
        .toString();
  }

  @BetaApi("The static format methods are not stable yet and may be changed in the future.")
  public static String formatProjectName(String project) {
    return newProjectBuilder()
        .setProject(project)
        .build()
        .toString();
  }

  public static TenantOrProjectName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    if (PROJECT_TENANT_PATH_TEMPLATE.matches(formattedString)) {
      Map<String, String> matchMap = PROJECT_TENANT_PATH_TEMPLATE.match(formattedString);
      return ofProjectTenantName(
          matchMap.get("project"), 
          matchMap.get("tenant"));
    } else if (PROJECT_PATH_TEMPLATE.matches(formattedString)) {
      Map<String, String> matchMap = PROJECT_PATH_TEMPLATE.match(formattedString);
      return ofProjectName(
          matchMap.get("project"));
    }
    throw new ValidationException("JobName.parse: formattedString not in valid format");
  }

  @BetaApi("The method will be renamed to parseList after subclasses of this class are removed.")
  public static List<TenantOrProjectName> parse(List<String> formattedStrings) {
    List<TenantOrProjectName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  @BetaApi("The method will be renamed to toStringList after subclasses of this class are removed.")
  public static List<String> toStrings(List<TenantOrProjectName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (TenantOrProjectName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return PROJECT_TENANT_PATH_TEMPLATE.matches(formattedString)    
        || PROJECT_PATH_TEMPLATE.matches(formattedString);
  }
  
  @Override
  public Map<String, String> getFieldValuesMap() {
    if (fieldValuesMap == null) {
      synchronized (this) {
        if (fieldValuesMap == null) {
          ImmutableMap.Builder<String, String> fieldMapBuilder = ImmutableMap.builder();
          if (project != null) {
            fieldMapBuilder.put("project", project);
          }
          if (tenant != null) {
            fieldMapBuilder.put("tenant", tenant);
          }
          fieldValuesMap = fieldMapBuilder.build();
        }
      }
    }
    return fieldValuesMap;
  }

  public String getFieldValue(String fieldName) {
    return getFieldValuesMap().get(fieldName);
  }

  @Override
  public String toString() {
    return fixedValue != null ? fixedValue : pathTemplate.instantiate(getFieldValuesMap());
  }

  /** Builder for projects/{project}/tenants/{tenant}. */
  public static class Builder {

    private String project;
    private String tenant;

    protected Builder() { }

    public String getProject() {
      return project;
    }

    public String getTenant() {
      return tenant;
    }

    public Builder setProject(String project) {
      this.project = project;
      return this;
    }

    public Builder setTenant(String tenant) {
      this.tenant = tenant;
      return this;
    }

    private Builder(TenantOrProjectName tenantOrProjectName) {
        Preconditions.checkArgument(
            tenantOrProjectName.pathTemplate == PROJECT_TENANT_PATH_TEMPLATE,
            "toBuilder is only supported when TenantOrProjectName has the pattern of "
            + "projects/{project}/tenants/{tenant}.");
      project = tenantOrProjectName.project;
      tenant = tenantOrProjectName.tenant;
    }

    public TenantOrProjectName build() {
      return new TenantOrProjectName(this);
    }
  }

  /** Builder for projects/{project}. */
  @BetaApi("The per-pattern Builders are not stable yet and may be changed in the future.")
  public static class ProjectBuilder {

    private String project;

    private ProjectBuilder() { }

    public String getProject() {
      return project;
    }

    public ProjectBuilder setProject(String project) {
      this.project = project;
      return this;
    }

    public TenantOrProjectName build() {
      return new TenantOrProjectName(this);
    }
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      TenantOrProjectName that = (TenantOrProjectName) o;
      return (Objects.equals(this.project, that.project))
          && (Objects.equals(this.tenant, that.tenant));
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(fixedValue);
    h *= 1000003;
    h ^= Objects.hashCode(project);
    h *= 1000003;
    h ^= Objects.hashCode(tenant);
    return h;
  }
}
