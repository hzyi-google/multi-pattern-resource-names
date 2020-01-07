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

package com.google.cloud.bigquery.datatransfer.v1;

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
public class ParentName implements ResourceName {
  
  @Deprecated
  protected ParentName() { }

  private static final PathTemplate PROJECT_PATH_TEMPLATE =
      PathTemplate.createWithoutUrlEncoding("projects/{project}");
  private static final PathTemplate PROJECT_LOCATION_PATH_TEMPLATE =
      PathTemplate.createWithoutUrlEncoding("projects/{project}/locations/{location}");

  private volatile Map<String, String> fieldValuesMap;
  private PathTemplate pathTemplate;
  private String fixedValue;

  private String project;
  private String location;

  public String getProject() {
    return project;
  }

  public String getLocation() {
    return location;
  }


  private ParentName(Builder builder) {
    project = Preconditions.checkNotNull(builder.getProject());
    pathTemplate = PROJECT_PATH_TEMPLATE;
  }

  private ParentName(ProjectLocationBuilder builder) {
    project = Preconditions.checkNotNull(builder.getProject());
    location = Preconditions.checkNotNull(builder.getLocation());
    pathTemplate = PROJECT_LOCATION_PATH_TEMPLATE;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public static Builder newProjectBuilder() {
  	return new Builder();
  }

  public static ProjectLocationBuilder newProjectLocationBuilder() {
  	return new ProjectLocationBuilder();
  }

  public Builder toBuilder() {
		return new Builder(this);
	}
		
  public static ParentName of(String project) {
  	return newProjectBuilder()
        .setProject(project)
        .build();
  }

  public static ParentName ofProjectName(String project) {
    return newProjectBuilder()
        .setProject(project)
        .build();
  }

  public static ParentName ofProjectLocationName(String project, String location) {
    return newProjectLocationBuilder()
        .setProject(project)
        .setLocation(location)
        .build();
  }

	public static String format(String project) {
  	return newBuilder()
        .setProject(project)
        .build()
        .toString();
  }

  public static String formatProjectName(String project) {
  	return newBuilder()
        .setProject(project)
        .build()
        .toString();
  }

  public static String formatProjectLocationName(String project, String location) {
  	return newProjectLocationBuilder()
        .setProject(project)
        .setLocation(location)
        .build()
        .toString();
  }

  public static ParentName parse(String formattedString) {
  	if (formattedString.isEmpty()) {
  		return null;
  	}
  	if (PROJECT_PATH_TEMPLATE.matches(formattedString)) {
  		Map<String, String> matchMap = PROJECT_PATH_TEMPLATE.match(formattedString);
  		return ofProjectName(
  		    matchMap.get("project"));
  	} else if (PROJECT_LOCATION_PATH_TEMPLATE.matches(formattedString)) {
  		Map<String, String> matchMap = PROJECT_LOCATION_PATH_TEMPLATE.match(formattedString);
  		return ofProjectLocationName(
  		    matchMap.get("project"), 
  		    matchMap.get("location"));
  	}
  	throw new ValidationException("JobName.parse: formattedString not in valid format");
  }

  @BetaApi("The method will be renamed to parseList after subclasses of this class are removed.")
  public static List<ParentName> parse(List<String> formattedStrings) {
    List<ParentName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  @BetaApi("The method will be renamed to toStringList after subclasses of this class are removed.")
  public static List<String> toStrings(List<ParentName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (ParentName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
  	return PROJECT_PATH_TEMPLATE.matches(formattedString)    
  	    || PROJECT_LOCATION_PATH_TEMPLATE.matches(formattedString);
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
        	if (location != null) {
        		fieldMapBuilder.put("location", location);
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

  /** Builder for projects/{project}. */
  public static class Builder {

    private String project;

    public String getProject() {
      return project;
    }

    public Builder setProject(String project) {
      this.project = project;
      return this;
    }

    protected Builder() { }

    private Builder(ParentName parentName) {
    	  Preconditions.checkArgument(
    	      parentName.pathTemplate == PROJECT_PATH_TEMPLATE,
    		    "toBuilder is only supported when ParentName has the pattern of "
    		    + "projects/{project}.");
      project = parentName.project;
    }

    public ParentName build() {
      return new ParentName(this);
    }
  }

  /** Builder for projects/{project}/locations/{location}. */
  public static class ProjectLocationBuilder {

    private String project;
    private String location;

    public String getProject() {
      return project;
    }

    public String getLocation() {
      return location;
    }

    public ProjectLocationBuilder setProject(String project) {
      this.project = project;
      return this;
    }

    public ProjectLocationBuilder setLocation(String location) {
      this.location = location;
      return this;
    }

    private ProjectLocationBuilder() { }

    public ParentName build() {
      return new ParentName(this);
    }
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o instanceof ParentName) {
      ParentName that = (ParentName) o;
      return (Objects.equals(this.project, that.project))
          && (Objects.equals(this.location, that.location));
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
    h ^= Objects.hashCode(location);
    return h;
  }
}
