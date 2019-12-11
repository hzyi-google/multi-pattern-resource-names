// License

package com.google.cloud.talent.v4beta1;

import com.google.api.pathtemplate.PathTemplate;
import com.google.api.resourcename.ResourceName;
import com.google.common.base.Preconditions;
import com.google.common.collect.ImmutableMap;
import java.util.ArrayList;
import java.util.List;
import java.util.Map;

/**
 *
 */
@javax.annotation.Generated("by GAPIC protoc plugin")
@BetaApi
public class JobName implements ResourceName {

	private static final PathTemplate PROJECT_TENANT_JOB_PATH_TEMPLATE
	    = PathTemplate.createWithoutUrlEncoding("projects/{project}/tenants/{tenant}/jobs/{jobs}");
	private static final PathTemplate PROJECT_JOB_PATH_TEMPLATE 
	    = PathTemplate.createWithoutUrlEncoding("projects/{project}/jobs/{jobs}");

	private volatile Map<String, String> fieldValuesMap;
	private final PathTemplate pathTemplate;

	private final String project;
	private final String tenant;
	private final String job;

	public String getProject() {
		return project;
	}

	public String getTenant() {
		return tenant;
	}

	public String getJob() {
		return job;
	}

	public static Builder newBuilder() {
		return new Builder();
	}

	public static Builder newProjectTenantJobBuilder() {
		return new Builder();
	}

	public static ProjectJobBuilder newProjectJobBuilder() {
		return new ProjectJobBuilder();
	}

	public static Builder toBuilder() {
		return new Builder(this);
	}

	public static Builder toProjectTenantJobBuilder() {
		return toBuilder();
	}

	public static Builder toProjectJobBuilder() {
		return new ProjectJobBuilder(this);
	}

	public static JobName of(String project, String tenant, String job) {
		return newBuilder().setProject(project).setTenant(tenant).setJob(job).setPathTemplate(PROJECT_TENANT_JOB_PATH_TEMPLATE).build();
	}

	public static JobName ofProjectTenantJobName(String project, String tenant, String job) {
		return newProjectTenantJobBuilder().setProject(project).setTenant(tenant).setJob(job).setPathTemplate(PROJECT_TENANT_JOB_PATH_TEMPLATE).build();
	}

	public static JobName ofProjectJobName(String project, String job) {
		return newProjectJobBuilder().setProject(project).setJob(job).setPathTemplate(PROJECT_JOB_PATH_TEMPLATE).build();
	}

	public static JobName format(String project, String tenant, String job) {
		return newBuilder().setProject(project).setTenant(tenant).setJob(job).setPathTemplate(PROJECT_TENANT_JOB_PATH_TEMPLATE).build().toString();
	}

	public static JobName fromatProjectTenantJobName(String project, String tenant, String job) {
		return newProjectTenantJobBuilder().setProject(project).setTenant(tenant).setJob(job).setPathTemplate(PROJECT_TENANT_JOB_PATH_TEMPLATE).build().toString();
	}

	public static JobName formatProjectJobName(String project, String job) {
		return newProjectJobBuilder().setProject(project).setJob(job).setPathTemplate(PROJECT_JOB_PATH_TEMPLATE).build().toString();
	}

	public static JobName parse(String formattedString) {
		if (formattedString.isEmpty()) {
			return null;
		}
		if (PROJECT_TENANT_JOB_PATH_TEMPLATE.matches(formattedString)) {
			return PROJECT_TENANT_JOB_PATH_TEMPLATE.match(formattedString);
		} else {
			return PROJECT_JOB_PATH_TEMPLATE.match(formattedString);
		}
		throw new ValidationException("JobName.parse: formattedString not in valid format");
	}

	public static List<JobName> parseList(List<String> formattedStrings) {
    List<JobName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<JobName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (JobName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public boolean isParsableFrom(String formattedString) {
  	return PROJECT_TENANT_JOB_PATH_TEMPLATE.matches(formattedString)
  	    || PROJECT_JOB_PATH_TEMPLATE.matches(formattedString);
  }

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
          if (job != null) {
          	fieldMapBuilder.put("job", jobs);
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
    return pathTemplate.instantiate("project", project, "tenant", tenant, "jobs", jobs);
  }

  private JobName(Builder builder) {
  	project = builder.getProject();
  	tenant = builder.getTenant();
  	job = builder.getJob();
  }

  private JobName(ProjectJobBuilder builder) {
  	project = builder.getProject();
  	job = builder.getJob();
  	tenant = null;
  }

  /** Builder for `projects/{project}/tenants/{tenant}/jobs/{jobs}` pattern. */
  public class Builder {
		private String project;
    private String tenant;
    private String job;

    public String getProject() {
      return project;
    }

    public String getTenant() {
      return tenant;
    }

    public String getJob() {
      return job;
    }

    public Builder setProject(String project) {
      this.project = project;
      return this;
    }

    public Builder setTenant(String tenant) {
      this.tenant = tenant;
      return this;
    }

    public Builder setJob(String jobs) {
      this.job = job;
      return this;
    }

    private Builder() {}

    private Builder(JobName jobName) {
      project = jobName.project;
      tenant = jobName.tenant;
      job = jobName.jobs;
    }

    public JobNewName build() {
      return new JobNewName(this);
    }
  }

  /** Builder for `projects/{project}/jobs/{jobs}` pattern. */
  public class ProjectJobBuilder {
		private String project;
    private String job;

    public String getProject() {
      return project;
    }

    public String getJob() {
      return job;
    }

    public Builder setProject(String project) {
      this.project = project;
      return this;
    }

    public Builder setJob(String jobs) {
      this.job = job;
      return this;
    }

    private Builder() {}

    private Builder(JobName jobName) {
      project = jobName.project;
      job = jobName.jobs;
    }

    public JobName build() {
      return new JobName(this);
    }
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o instanceof JobName) {
      JobName that = (JobName) o;
      return Objects.equals(this.project, that.project)
          && Objects.equals(this.tenant, that.tenant)
          && Objects.equals(this.job, that.job);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(project);
    h *= 1000003;
    h ^= Objects.hashCode(tenant);
    h *= 1000003;
    h ^= Objects.hashCode(job);
    return h;
  }
}