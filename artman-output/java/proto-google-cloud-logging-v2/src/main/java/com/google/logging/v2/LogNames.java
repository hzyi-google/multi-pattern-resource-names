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

package com.google.logging.v2;

import com.google.api.resourcenames.ResourceName;

/**
 * AUTO-GENERATED DOCUMENTATION AND CLASS
 *
 * @deprecated This resource name class will be removed in the next major version.
 */
@javax.annotation.Generated("by GAPIC protoc plugin")
@Deprecated
public class LogNames {
  private LogNames() {}

  public static LogName parse(String resourceNameString) {
    if (ProjectLogName.isParsableFrom(resourceNameString)) {
      return ProjectLogName.parse(resourceNameString);
    }
    if (OrganizationLogName.isParsableFrom(resourceNameString)) {
      return OrganizationLogName.parse(resourceNameString);
    }
    if (FolderLogName.isParsableFrom(resourceNameString)) {
      return FolderLogName.parse(resourceNameString);
    }
    if (BillingLogName.isParsableFrom(resourceNameString)) {
      return BillingLogName.parse(resourceNameString);
    }
    return UntypedLogName.parse(resourceNameString);
  }
}
