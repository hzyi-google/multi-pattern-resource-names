import * as $protobuf from "protobufjs";
/** Namespace google. */
export namespace google {

    /** Namespace devtools. */
    namespace devtools {

        /** Namespace containeranalysis. */
        namespace containeranalysis {

            /** Namespace v1alpha1. */
            namespace v1alpha1 {

                /** Represents a ContainerAnalysis */
                class ContainerAnalysis extends $protobuf.rpc.Service {

                    /**
                     * Constructs a new ContainerAnalysis service.
                     * @param rpcImpl RPC implementation
                     * @param [requestDelimited=false] Whether requests are length-delimited
                     * @param [responseDelimited=false] Whether responses are length-delimited
                     */
                    constructor(rpcImpl: $protobuf.RPCImpl, requestDelimited?: boolean, responseDelimited?: boolean);

                    /**
                     * Creates new ContainerAnalysis service using the specified rpc implementation.
                     * @param rpcImpl RPC implementation
                     * @param [requestDelimited=false] Whether requests are length-delimited
                     * @param [responseDelimited=false] Whether responses are length-delimited
                     * @returns RPC service. Useful where requests and/or responses are streamed.
                     */
                    public static create(rpcImpl: $protobuf.RPCImpl, requestDelimited?: boolean, responseDelimited?: boolean): ContainerAnalysis;

                    /**
                     * Calls GetOccurrence.
                     * @param request GetOccurrenceRequest message or plain object
                     * @param callback Node-style callback called with the error, if any, and Occurrence
                     */
                    public getOccurrence(request: google.devtools.containeranalysis.v1alpha1.IGetOccurrenceRequest, callback: google.devtools.containeranalysis.v1alpha1.ContainerAnalysis.GetOccurrenceCallback): void;

                    /**
                     * Calls GetOccurrence.
                     * @param request GetOccurrenceRequest message or plain object
                     * @returns Promise
                     */
                    public getOccurrence(request: google.devtools.containeranalysis.v1alpha1.IGetOccurrenceRequest): Promise<google.devtools.containeranalysis.v1alpha1.Occurrence>;

                    /**
                     * Calls ListOccurrences.
                     * @param request ListOccurrencesRequest message or plain object
                     * @param callback Node-style callback called with the error, if any, and ListOccurrencesResponse
                     */
                    public listOccurrences(request: google.devtools.containeranalysis.v1alpha1.IListOccurrencesRequest, callback: google.devtools.containeranalysis.v1alpha1.ContainerAnalysis.ListOccurrencesCallback): void;

                    /**
                     * Calls ListOccurrences.
                     * @param request ListOccurrencesRequest message or plain object
                     * @returns Promise
                     */
                    public listOccurrences(request: google.devtools.containeranalysis.v1alpha1.IListOccurrencesRequest): Promise<google.devtools.containeranalysis.v1alpha1.ListOccurrencesResponse>;

                    /**
                     * Calls DeleteOccurrence.
                     * @param request DeleteOccurrenceRequest message or plain object
                     * @param callback Node-style callback called with the error, if any, and Empty
                     */
                    public deleteOccurrence(request: google.devtools.containeranalysis.v1alpha1.IDeleteOccurrenceRequest, callback: google.devtools.containeranalysis.v1alpha1.ContainerAnalysis.DeleteOccurrenceCallback): void;

                    /**
                     * Calls DeleteOccurrence.
                     * @param request DeleteOccurrenceRequest message or plain object
                     * @returns Promise
                     */
                    public deleteOccurrence(request: google.devtools.containeranalysis.v1alpha1.IDeleteOccurrenceRequest): Promise<google.protobuf.Empty>;

                    /**
                     * Calls CreateOccurrence.
                     * @param request CreateOccurrenceRequest message or plain object
                     * @param callback Node-style callback called with the error, if any, and Occurrence
                     */
                    public createOccurrence(request: google.devtools.containeranalysis.v1alpha1.ICreateOccurrenceRequest, callback: google.devtools.containeranalysis.v1alpha1.ContainerAnalysis.CreateOccurrenceCallback): void;

                    /**
                     * Calls CreateOccurrence.
                     * @param request CreateOccurrenceRequest message or plain object
                     * @returns Promise
                     */
                    public createOccurrence(request: google.devtools.containeranalysis.v1alpha1.ICreateOccurrenceRequest): Promise<google.devtools.containeranalysis.v1alpha1.Occurrence>;

                    /**
                     * Calls UpdateOccurrence.
                     * @param request UpdateOccurrenceRequest message or plain object
                     * @param callback Node-style callback called with the error, if any, and Occurrence
                     */
                    public updateOccurrence(request: google.devtools.containeranalysis.v1alpha1.IUpdateOccurrenceRequest, callback: google.devtools.containeranalysis.v1alpha1.ContainerAnalysis.UpdateOccurrenceCallback): void;

                    /**
                     * Calls UpdateOccurrence.
                     * @param request UpdateOccurrenceRequest message or plain object
                     * @returns Promise
                     */
                    public updateOccurrence(request: google.devtools.containeranalysis.v1alpha1.IUpdateOccurrenceRequest): Promise<google.devtools.containeranalysis.v1alpha1.Occurrence>;

                    /**
                     * Calls GetOccurrenceNote.
                     * @param request GetOccurrenceNoteRequest message or plain object
                     * @param callback Node-style callback called with the error, if any, and Note
                     */
                    public getOccurrenceNote(request: google.devtools.containeranalysis.v1alpha1.IGetOccurrenceNoteRequest, callback: google.devtools.containeranalysis.v1alpha1.ContainerAnalysis.GetOccurrenceNoteCallback): void;

                    /**
                     * Calls GetOccurrenceNote.
                     * @param request GetOccurrenceNoteRequest message or plain object
                     * @returns Promise
                     */
                    public getOccurrenceNote(request: google.devtools.containeranalysis.v1alpha1.IGetOccurrenceNoteRequest): Promise<google.devtools.containeranalysis.v1alpha1.Note>;

                    /**
                     * Calls GetNote.
                     * @param request GetNoteRequest message or plain object
                     * @param callback Node-style callback called with the error, if any, and Note
                     */
                    public getNote(request: google.devtools.containeranalysis.v1alpha1.IGetNoteRequest, callback: google.devtools.containeranalysis.v1alpha1.ContainerAnalysis.GetNoteCallback): void;

                    /**
                     * Calls GetNote.
                     * @param request GetNoteRequest message or plain object
                     * @returns Promise
                     */
                    public getNote(request: google.devtools.containeranalysis.v1alpha1.IGetNoteRequest): Promise<google.devtools.containeranalysis.v1alpha1.Note>;

                    /**
                     * Calls ListNotes.
                     * @param request ListNotesRequest message or plain object
                     * @param callback Node-style callback called with the error, if any, and ListNotesResponse
                     */
                    public listNotes(request: google.devtools.containeranalysis.v1alpha1.IListNotesRequest, callback: google.devtools.containeranalysis.v1alpha1.ContainerAnalysis.ListNotesCallback): void;

                    /**
                     * Calls ListNotes.
                     * @param request ListNotesRequest message or plain object
                     * @returns Promise
                     */
                    public listNotes(request: google.devtools.containeranalysis.v1alpha1.IListNotesRequest): Promise<google.devtools.containeranalysis.v1alpha1.ListNotesResponse>;

                    /**
                     * Calls DeleteNote.
                     * @param request DeleteNoteRequest message or plain object
                     * @param callback Node-style callback called with the error, if any, and Empty
                     */
                    public deleteNote(request: google.devtools.containeranalysis.v1alpha1.IDeleteNoteRequest, callback: google.devtools.containeranalysis.v1alpha1.ContainerAnalysis.DeleteNoteCallback): void;

                    /**
                     * Calls DeleteNote.
                     * @param request DeleteNoteRequest message or plain object
                     * @returns Promise
                     */
                    public deleteNote(request: google.devtools.containeranalysis.v1alpha1.IDeleteNoteRequest): Promise<google.protobuf.Empty>;

                    /**
                     * Calls CreateNote.
                     * @param request CreateNoteRequest message or plain object
                     * @param callback Node-style callback called with the error, if any, and Note
                     */
                    public createNote(request: google.devtools.containeranalysis.v1alpha1.ICreateNoteRequest, callback: google.devtools.containeranalysis.v1alpha1.ContainerAnalysis.CreateNoteCallback): void;

                    /**
                     * Calls CreateNote.
                     * @param request CreateNoteRequest message or plain object
                     * @returns Promise
                     */
                    public createNote(request: google.devtools.containeranalysis.v1alpha1.ICreateNoteRequest): Promise<google.devtools.containeranalysis.v1alpha1.Note>;

                    /**
                     * Calls UpdateNote.
                     * @param request UpdateNoteRequest message or plain object
                     * @param callback Node-style callback called with the error, if any, and Note
                     */
                    public updateNote(request: google.devtools.containeranalysis.v1alpha1.IUpdateNoteRequest, callback: google.devtools.containeranalysis.v1alpha1.ContainerAnalysis.UpdateNoteCallback): void;

                    /**
                     * Calls UpdateNote.
                     * @param request UpdateNoteRequest message or plain object
                     * @returns Promise
                     */
                    public updateNote(request: google.devtools.containeranalysis.v1alpha1.IUpdateNoteRequest): Promise<google.devtools.containeranalysis.v1alpha1.Note>;

                    /**
                     * Calls ListNoteOccurrences.
                     * @param request ListNoteOccurrencesRequest message or plain object
                     * @param callback Node-style callback called with the error, if any, and ListNoteOccurrencesResponse
                     */
                    public listNoteOccurrences(request: google.devtools.containeranalysis.v1alpha1.IListNoteOccurrencesRequest, callback: google.devtools.containeranalysis.v1alpha1.ContainerAnalysis.ListNoteOccurrencesCallback): void;

                    /**
                     * Calls ListNoteOccurrences.
                     * @param request ListNoteOccurrencesRequest message or plain object
                     * @returns Promise
                     */
                    public listNoteOccurrences(request: google.devtools.containeranalysis.v1alpha1.IListNoteOccurrencesRequest): Promise<google.devtools.containeranalysis.v1alpha1.ListNoteOccurrencesResponse>;

                    /**
                     * Calls GetVulnzOccurrencesSummary.
                     * @param request GetVulnzOccurrencesSummaryRequest message or plain object
                     * @param callback Node-style callback called with the error, if any, and GetVulnzOccurrencesSummaryResponse
                     */
                    public getVulnzOccurrencesSummary(request: google.devtools.containeranalysis.v1alpha1.IGetVulnzOccurrencesSummaryRequest, callback: google.devtools.containeranalysis.v1alpha1.ContainerAnalysis.GetVulnzOccurrencesSummaryCallback): void;

                    /**
                     * Calls GetVulnzOccurrencesSummary.
                     * @param request GetVulnzOccurrencesSummaryRequest message or plain object
                     * @returns Promise
                     */
                    public getVulnzOccurrencesSummary(request: google.devtools.containeranalysis.v1alpha1.IGetVulnzOccurrencesSummaryRequest): Promise<google.devtools.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryResponse>;

                    /**
                     * Calls SetIamPolicy.
                     * @param request SetIamPolicyRequest message or plain object
                     * @param callback Node-style callback called with the error, if any, and Policy
                     */
                    public setIamPolicy(request: google.iam.v1.ISetIamPolicyRequest, callback: google.devtools.containeranalysis.v1alpha1.ContainerAnalysis.SetIamPolicyCallback): void;

                    /**
                     * Calls SetIamPolicy.
                     * @param request SetIamPolicyRequest message or plain object
                     * @returns Promise
                     */
                    public setIamPolicy(request: google.iam.v1.ISetIamPolicyRequest): Promise<google.iam.v1.Policy>;

                    /**
                     * Calls GetIamPolicy.
                     * @param request GetIamPolicyRequest message or plain object
                     * @param callback Node-style callback called with the error, if any, and Policy
                     */
                    public getIamPolicy(request: google.iam.v1.IGetIamPolicyRequest, callback: google.devtools.containeranalysis.v1alpha1.ContainerAnalysis.GetIamPolicyCallback): void;

                    /**
                     * Calls GetIamPolicy.
                     * @param request GetIamPolicyRequest message or plain object
                     * @returns Promise
                     */
                    public getIamPolicy(request: google.iam.v1.IGetIamPolicyRequest): Promise<google.iam.v1.Policy>;

                    /**
                     * Calls TestIamPermissions.
                     * @param request TestIamPermissionsRequest message or plain object
                     * @param callback Node-style callback called with the error, if any, and TestIamPermissionsResponse
                     */
                    public testIamPermissions(request: google.iam.v1.ITestIamPermissionsRequest, callback: google.devtools.containeranalysis.v1alpha1.ContainerAnalysis.TestIamPermissionsCallback): void;

                    /**
                     * Calls TestIamPermissions.
                     * @param request TestIamPermissionsRequest message or plain object
                     * @returns Promise
                     */
                    public testIamPermissions(request: google.iam.v1.ITestIamPermissionsRequest): Promise<google.iam.v1.TestIamPermissionsResponse>;

                    /**
                     * Calls CreateOperation.
                     * @param request CreateOperationRequest message or plain object
                     * @param callback Node-style callback called with the error, if any, and Operation
                     */
                    public createOperation(request: google.devtools.containeranalysis.v1alpha1.ICreateOperationRequest, callback: google.devtools.containeranalysis.v1alpha1.ContainerAnalysis.CreateOperationCallback): void;

                    /**
                     * Calls CreateOperation.
                     * @param request CreateOperationRequest message or plain object
                     * @returns Promise
                     */
                    public createOperation(request: google.devtools.containeranalysis.v1alpha1.ICreateOperationRequest): Promise<google.longrunning.Operation>;

                    /**
                     * Calls UpdateOperation.
                     * @param request UpdateOperationRequest message or plain object
                     * @param callback Node-style callback called with the error, if any, and Operation
                     */
                    public updateOperation(request: google.devtools.containeranalysis.v1alpha1.IUpdateOperationRequest, callback: google.devtools.containeranalysis.v1alpha1.ContainerAnalysis.UpdateOperationCallback): void;

                    /**
                     * Calls UpdateOperation.
                     * @param request UpdateOperationRequest message or plain object
                     * @returns Promise
                     */
                    public updateOperation(request: google.devtools.containeranalysis.v1alpha1.IUpdateOperationRequest): Promise<google.longrunning.Operation>;

                    /**
                     * Calls GetScanConfig.
                     * @param request GetScanConfigRequest message or plain object
                     * @param callback Node-style callback called with the error, if any, and ScanConfig
                     */
                    public getScanConfig(request: google.devtools.containeranalysis.v1alpha1.IGetScanConfigRequest, callback: google.devtools.containeranalysis.v1alpha1.ContainerAnalysis.GetScanConfigCallback): void;

                    /**
                     * Calls GetScanConfig.
                     * @param request GetScanConfigRequest message or plain object
                     * @returns Promise
                     */
                    public getScanConfig(request: google.devtools.containeranalysis.v1alpha1.IGetScanConfigRequest): Promise<google.devtools.containeranalysis.v1alpha1.ScanConfig>;

                    /**
                     * Calls ListScanConfigs.
                     * @param request ListScanConfigsRequest message or plain object
                     * @param callback Node-style callback called with the error, if any, and ListScanConfigsResponse
                     */
                    public listScanConfigs(request: google.devtools.containeranalysis.v1alpha1.IListScanConfigsRequest, callback: google.devtools.containeranalysis.v1alpha1.ContainerAnalysis.ListScanConfigsCallback): void;

                    /**
                     * Calls ListScanConfigs.
                     * @param request ListScanConfigsRequest message or plain object
                     * @returns Promise
                     */
                    public listScanConfigs(request: google.devtools.containeranalysis.v1alpha1.IListScanConfigsRequest): Promise<google.devtools.containeranalysis.v1alpha1.ListScanConfigsResponse>;

                    /**
                     * Calls UpdateScanConfig.
                     * @param request UpdateScanConfigRequest message or plain object
                     * @param callback Node-style callback called with the error, if any, and ScanConfig
                     */
                    public updateScanConfig(request: google.devtools.containeranalysis.v1alpha1.IUpdateScanConfigRequest, callback: google.devtools.containeranalysis.v1alpha1.ContainerAnalysis.UpdateScanConfigCallback): void;

                    /**
                     * Calls UpdateScanConfig.
                     * @param request UpdateScanConfigRequest message or plain object
                     * @returns Promise
                     */
                    public updateScanConfig(request: google.devtools.containeranalysis.v1alpha1.IUpdateScanConfigRequest): Promise<google.devtools.containeranalysis.v1alpha1.ScanConfig>;
                }

                namespace ContainerAnalysis {

                    /**
                     * Callback as used by {@link google.devtools.containeranalysis.v1alpha1.ContainerAnalysis#getOccurrence}.
                     * @param error Error, if any
                     * @param [response] Occurrence
                     */
                    type GetOccurrenceCallback = (error: (Error|null), response?: google.devtools.containeranalysis.v1alpha1.Occurrence) => void;

                    /**
                     * Callback as used by {@link google.devtools.containeranalysis.v1alpha1.ContainerAnalysis#listOccurrences}.
                     * @param error Error, if any
                     * @param [response] ListOccurrencesResponse
                     */
                    type ListOccurrencesCallback = (error: (Error|null), response?: google.devtools.containeranalysis.v1alpha1.ListOccurrencesResponse) => void;

                    /**
                     * Callback as used by {@link google.devtools.containeranalysis.v1alpha1.ContainerAnalysis#deleteOccurrence}.
                     * @param error Error, if any
                     * @param [response] Empty
                     */
                    type DeleteOccurrenceCallback = (error: (Error|null), response?: google.protobuf.Empty) => void;

                    /**
                     * Callback as used by {@link google.devtools.containeranalysis.v1alpha1.ContainerAnalysis#createOccurrence}.
                     * @param error Error, if any
                     * @param [response] Occurrence
                     */
                    type CreateOccurrenceCallback = (error: (Error|null), response?: google.devtools.containeranalysis.v1alpha1.Occurrence) => void;

                    /**
                     * Callback as used by {@link google.devtools.containeranalysis.v1alpha1.ContainerAnalysis#updateOccurrence}.
                     * @param error Error, if any
                     * @param [response] Occurrence
                     */
                    type UpdateOccurrenceCallback = (error: (Error|null), response?: google.devtools.containeranalysis.v1alpha1.Occurrence) => void;

                    /**
                     * Callback as used by {@link google.devtools.containeranalysis.v1alpha1.ContainerAnalysis#getOccurrenceNote}.
                     * @param error Error, if any
                     * @param [response] Note
                     */
                    type GetOccurrenceNoteCallback = (error: (Error|null), response?: google.devtools.containeranalysis.v1alpha1.Note) => void;

                    /**
                     * Callback as used by {@link google.devtools.containeranalysis.v1alpha1.ContainerAnalysis#getNote}.
                     * @param error Error, if any
                     * @param [response] Note
                     */
                    type GetNoteCallback = (error: (Error|null), response?: google.devtools.containeranalysis.v1alpha1.Note) => void;

                    /**
                     * Callback as used by {@link google.devtools.containeranalysis.v1alpha1.ContainerAnalysis#listNotes}.
                     * @param error Error, if any
                     * @param [response] ListNotesResponse
                     */
                    type ListNotesCallback = (error: (Error|null), response?: google.devtools.containeranalysis.v1alpha1.ListNotesResponse) => void;

                    /**
                     * Callback as used by {@link google.devtools.containeranalysis.v1alpha1.ContainerAnalysis#deleteNote}.
                     * @param error Error, if any
                     * @param [response] Empty
                     */
                    type DeleteNoteCallback = (error: (Error|null), response?: google.protobuf.Empty) => void;

                    /**
                     * Callback as used by {@link google.devtools.containeranalysis.v1alpha1.ContainerAnalysis#createNote}.
                     * @param error Error, if any
                     * @param [response] Note
                     */
                    type CreateNoteCallback = (error: (Error|null), response?: google.devtools.containeranalysis.v1alpha1.Note) => void;

                    /**
                     * Callback as used by {@link google.devtools.containeranalysis.v1alpha1.ContainerAnalysis#updateNote}.
                     * @param error Error, if any
                     * @param [response] Note
                     */
                    type UpdateNoteCallback = (error: (Error|null), response?: google.devtools.containeranalysis.v1alpha1.Note) => void;

                    /**
                     * Callback as used by {@link google.devtools.containeranalysis.v1alpha1.ContainerAnalysis#listNoteOccurrences}.
                     * @param error Error, if any
                     * @param [response] ListNoteOccurrencesResponse
                     */
                    type ListNoteOccurrencesCallback = (error: (Error|null), response?: google.devtools.containeranalysis.v1alpha1.ListNoteOccurrencesResponse) => void;

                    /**
                     * Callback as used by {@link google.devtools.containeranalysis.v1alpha1.ContainerAnalysis#getVulnzOccurrencesSummary}.
                     * @param error Error, if any
                     * @param [response] GetVulnzOccurrencesSummaryResponse
                     */
                    type GetVulnzOccurrencesSummaryCallback = (error: (Error|null), response?: google.devtools.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryResponse) => void;

                    /**
                     * Callback as used by {@link google.devtools.containeranalysis.v1alpha1.ContainerAnalysis#setIamPolicy}.
                     * @param error Error, if any
                     * @param [response] Policy
                     */
                    type SetIamPolicyCallback = (error: (Error|null), response?: google.iam.v1.Policy) => void;

                    /**
                     * Callback as used by {@link google.devtools.containeranalysis.v1alpha1.ContainerAnalysis#getIamPolicy}.
                     * @param error Error, if any
                     * @param [response] Policy
                     */
                    type GetIamPolicyCallback = (error: (Error|null), response?: google.iam.v1.Policy) => void;

                    /**
                     * Callback as used by {@link google.devtools.containeranalysis.v1alpha1.ContainerAnalysis#testIamPermissions}.
                     * @param error Error, if any
                     * @param [response] TestIamPermissionsResponse
                     */
                    type TestIamPermissionsCallback = (error: (Error|null), response?: google.iam.v1.TestIamPermissionsResponse) => void;

                    /**
                     * Callback as used by {@link google.devtools.containeranalysis.v1alpha1.ContainerAnalysis#createOperation}.
                     * @param error Error, if any
                     * @param [response] Operation
                     */
                    type CreateOperationCallback = (error: (Error|null), response?: google.longrunning.Operation) => void;

                    /**
                     * Callback as used by {@link google.devtools.containeranalysis.v1alpha1.ContainerAnalysis#updateOperation}.
                     * @param error Error, if any
                     * @param [response] Operation
                     */
                    type UpdateOperationCallback = (error: (Error|null), response?: google.longrunning.Operation) => void;

                    /**
                     * Callback as used by {@link google.devtools.containeranalysis.v1alpha1.ContainerAnalysis#getScanConfig}.
                     * @param error Error, if any
                     * @param [response] ScanConfig
                     */
                    type GetScanConfigCallback = (error: (Error|null), response?: google.devtools.containeranalysis.v1alpha1.ScanConfig) => void;

                    /**
                     * Callback as used by {@link google.devtools.containeranalysis.v1alpha1.ContainerAnalysis#listScanConfigs}.
                     * @param error Error, if any
                     * @param [response] ListScanConfigsResponse
                     */
                    type ListScanConfigsCallback = (error: (Error|null), response?: google.devtools.containeranalysis.v1alpha1.ListScanConfigsResponse) => void;

                    /**
                     * Callback as used by {@link google.devtools.containeranalysis.v1alpha1.ContainerAnalysis#updateScanConfig}.
                     * @param error Error, if any
                     * @param [response] ScanConfig
                     */
                    type UpdateScanConfigCallback = (error: (Error|null), response?: google.devtools.containeranalysis.v1alpha1.ScanConfig) => void;
                }

                /** Properties of an Occurrence. */
                interface IOccurrence {

                    /** Occurrence name */
                    name?: (string|null);

                    /** Occurrence resourceUrl */
                    resourceUrl?: (string|null);

                    /** Occurrence resource */
                    resource?: (google.devtools.containeranalysis.v1alpha1.IResource|null);

                    /** Occurrence noteName */
                    noteName?: (string|null);

                    /** Occurrence kind */
                    kind?: (google.devtools.containeranalysis.v1alpha1.Note.Kind|null);

                    /** Occurrence vulnerabilityDetails */
                    vulnerabilityDetails?: (google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IVulnerabilityDetails|null);

                    /** Occurrence buildDetails */
                    buildDetails?: (google.devtools.containeranalysis.v1alpha1.IBuildDetails|null);

                    /** Occurrence derivedImage */
                    derivedImage?: (google.devtools.containeranalysis.v1alpha1.DockerImage.IDerived|null);

                    /** Occurrence installation */
                    installation?: (google.devtools.containeranalysis.v1alpha1.PackageManager.IInstallation|null);

                    /** Occurrence deployment */
                    deployment?: (google.devtools.containeranalysis.v1alpha1.Deployable.IDeployment|null);

                    /** Occurrence discovered */
                    discovered?: (google.devtools.containeranalysis.v1alpha1.Discovery.IDiscovered|null);

                    /** Occurrence attestation */
                    attestation?: (google.devtools.containeranalysis.v1alpha1.AttestationAuthority.IAttestation|null);

                    /** Occurrence remediation */
                    remediation?: (string|null);

                    /** Occurrence createTime */
                    createTime?: (google.protobuf.ITimestamp|null);

                    /** Occurrence updateTime */
                    updateTime?: (google.protobuf.ITimestamp|null);
                }

                /** Represents an Occurrence. */
                class Occurrence implements IOccurrence {

                    /**
                     * Constructs a new Occurrence.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IOccurrence);

                    /** Occurrence name. */
                    public name: string;

                    /** Occurrence resourceUrl. */
                    public resourceUrl: string;

                    /** Occurrence resource. */
                    public resource?: (google.devtools.containeranalysis.v1alpha1.IResource|null);

                    /** Occurrence noteName. */
                    public noteName: string;

                    /** Occurrence kind. */
                    public kind: google.devtools.containeranalysis.v1alpha1.Note.Kind;

                    /** Occurrence vulnerabilityDetails. */
                    public vulnerabilityDetails?: (google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IVulnerabilityDetails|null);

                    /** Occurrence buildDetails. */
                    public buildDetails?: (google.devtools.containeranalysis.v1alpha1.IBuildDetails|null);

                    /** Occurrence derivedImage. */
                    public derivedImage?: (google.devtools.containeranalysis.v1alpha1.DockerImage.IDerived|null);

                    /** Occurrence installation. */
                    public installation?: (google.devtools.containeranalysis.v1alpha1.PackageManager.IInstallation|null);

                    /** Occurrence deployment. */
                    public deployment?: (google.devtools.containeranalysis.v1alpha1.Deployable.IDeployment|null);

                    /** Occurrence discovered. */
                    public discovered?: (google.devtools.containeranalysis.v1alpha1.Discovery.IDiscovered|null);

                    /** Occurrence attestation. */
                    public attestation?: (google.devtools.containeranalysis.v1alpha1.AttestationAuthority.IAttestation|null);

                    /** Occurrence remediation. */
                    public remediation: string;

                    /** Occurrence createTime. */
                    public createTime?: (google.protobuf.ITimestamp|null);

                    /** Occurrence updateTime. */
                    public updateTime?: (google.protobuf.ITimestamp|null);

                    /** Occurrence details. */
                    public details?: ("vulnerabilityDetails"|"buildDetails"|"derivedImage"|"installation"|"deployment"|"discovered"|"attestation");

                    /**
                     * Creates a new Occurrence instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns Occurrence instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IOccurrence): google.devtools.containeranalysis.v1alpha1.Occurrence;

                    /**
                     * Encodes the specified Occurrence message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.Occurrence.verify|verify} messages.
                     * @param message Occurrence message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IOccurrence, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified Occurrence message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.Occurrence.verify|verify} messages.
                     * @param message Occurrence message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IOccurrence, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes an Occurrence message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns Occurrence
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.Occurrence;

                    /**
                     * Decodes an Occurrence message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns Occurrence
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.Occurrence;

                    /**
                     * Verifies an Occurrence message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates an Occurrence message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns Occurrence
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.Occurrence;

                    /**
                     * Creates a plain object from an Occurrence message. Also converts values to other types if specified.
                     * @param message Occurrence
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.Occurrence, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this Occurrence to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of a Resource. */
                interface IResource {

                    /** Resource name */
                    name?: (string|null);

                    /** Resource uri */
                    uri?: (string|null);

                    /** Resource contentHash */
                    contentHash?: (google.devtools.containeranalysis.v1alpha1.IHash|null);
                }

                /** Represents a Resource. */
                class Resource implements IResource {

                    /**
                     * Constructs a new Resource.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IResource);

                    /** Resource name. */
                    public name: string;

                    /** Resource uri. */
                    public uri: string;

                    /** Resource contentHash. */
                    public contentHash?: (google.devtools.containeranalysis.v1alpha1.IHash|null);

                    /**
                     * Creates a new Resource instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns Resource instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IResource): google.devtools.containeranalysis.v1alpha1.Resource;

                    /**
                     * Encodes the specified Resource message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.Resource.verify|verify} messages.
                     * @param message Resource message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IResource, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified Resource message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.Resource.verify|verify} messages.
                     * @param message Resource message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IResource, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a Resource message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns Resource
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.Resource;

                    /**
                     * Decodes a Resource message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns Resource
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.Resource;

                    /**
                     * Verifies a Resource message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a Resource message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns Resource
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.Resource;

                    /**
                     * Creates a plain object from a Resource message. Also converts values to other types if specified.
                     * @param message Resource
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.Resource, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this Resource to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of a Note. */
                interface INote {

                    /** Note name */
                    name?: (string|null);

                    /** Note shortDescription */
                    shortDescription?: (string|null);

                    /** Note longDescription */
                    longDescription?: (string|null);

                    /** Note kind */
                    kind?: (google.devtools.containeranalysis.v1alpha1.Note.Kind|null);

                    /** Note vulnerabilityType */
                    vulnerabilityType?: (google.devtools.containeranalysis.v1alpha1.IVulnerabilityType|null);

                    /** Note buildType */
                    buildType?: (google.devtools.containeranalysis.v1alpha1.IBuildType|null);

                    /** Note baseImage */
                    baseImage?: (google.devtools.containeranalysis.v1alpha1.DockerImage.IBasis|null);

                    /** Note package */
                    "package"?: (google.devtools.containeranalysis.v1alpha1.PackageManager.IPackage|null);

                    /** Note deployable */
                    deployable?: (google.devtools.containeranalysis.v1alpha1.IDeployable|null);

                    /** Note discovery */
                    discovery?: (google.devtools.containeranalysis.v1alpha1.IDiscovery|null);

                    /** Note attestationAuthority */
                    attestationAuthority?: (google.devtools.containeranalysis.v1alpha1.IAttestationAuthority|null);

                    /** Note relatedUrl */
                    relatedUrl?: (google.devtools.containeranalysis.v1alpha1.Note.IRelatedUrl[]|null);

                    /** Note expirationTime */
                    expirationTime?: (google.protobuf.ITimestamp|null);

                    /** Note createTime */
                    createTime?: (google.protobuf.ITimestamp|null);

                    /** Note updateTime */
                    updateTime?: (google.protobuf.ITimestamp|null);
                }

                /** Represents a Note. */
                class Note implements INote {

                    /**
                     * Constructs a new Note.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.INote);

                    /** Note name. */
                    public name: string;

                    /** Note shortDescription. */
                    public shortDescription: string;

                    /** Note longDescription. */
                    public longDescription: string;

                    /** Note kind. */
                    public kind: google.devtools.containeranalysis.v1alpha1.Note.Kind;

                    /** Note vulnerabilityType. */
                    public vulnerabilityType?: (google.devtools.containeranalysis.v1alpha1.IVulnerabilityType|null);

                    /** Note buildType. */
                    public buildType?: (google.devtools.containeranalysis.v1alpha1.IBuildType|null);

                    /** Note baseImage. */
                    public baseImage?: (google.devtools.containeranalysis.v1alpha1.DockerImage.IBasis|null);

                    /** Note package. */
                    public package?: (google.devtools.containeranalysis.v1alpha1.PackageManager.IPackage|null);

                    /** Note deployable. */
                    public deployable?: (google.devtools.containeranalysis.v1alpha1.IDeployable|null);

                    /** Note discovery. */
                    public discovery?: (google.devtools.containeranalysis.v1alpha1.IDiscovery|null);

                    /** Note attestationAuthority. */
                    public attestationAuthority?: (google.devtools.containeranalysis.v1alpha1.IAttestationAuthority|null);

                    /** Note relatedUrl. */
                    public relatedUrl: google.devtools.containeranalysis.v1alpha1.Note.IRelatedUrl[];

                    /** Note expirationTime. */
                    public expirationTime?: (google.protobuf.ITimestamp|null);

                    /** Note createTime. */
                    public createTime?: (google.protobuf.ITimestamp|null);

                    /** Note updateTime. */
                    public updateTime?: (google.protobuf.ITimestamp|null);

                    /** Note noteType. */
                    public noteType?: ("vulnerabilityType"|"buildType"|"baseImage"|"package"|"deployable"|"discovery"|"attestationAuthority");

                    /**
                     * Creates a new Note instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns Note instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.INote): google.devtools.containeranalysis.v1alpha1.Note;

                    /**
                     * Encodes the specified Note message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.Note.verify|verify} messages.
                     * @param message Note message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.INote, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified Note message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.Note.verify|verify} messages.
                     * @param message Note message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.INote, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a Note message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns Note
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.Note;

                    /**
                     * Decodes a Note message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns Note
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.Note;

                    /**
                     * Verifies a Note message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a Note message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns Note
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.Note;

                    /**
                     * Creates a plain object from a Note message. Also converts values to other types if specified.
                     * @param message Note
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.Note, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this Note to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                namespace Note {

                    /** Properties of a RelatedUrl. */
                    interface IRelatedUrl {

                        /** RelatedUrl url */
                        url?: (string|null);

                        /** RelatedUrl label */
                        label?: (string|null);
                    }

                    /** Represents a RelatedUrl. */
                    class RelatedUrl implements IRelatedUrl {

                        /**
                         * Constructs a new RelatedUrl.
                         * @param [properties] Properties to set
                         */
                        constructor(properties?: google.devtools.containeranalysis.v1alpha1.Note.IRelatedUrl);

                        /** RelatedUrl url. */
                        public url: string;

                        /** RelatedUrl label. */
                        public label: string;

                        /**
                         * Creates a new RelatedUrl instance using the specified properties.
                         * @param [properties] Properties to set
                         * @returns RelatedUrl instance
                         */
                        public static create(properties?: google.devtools.containeranalysis.v1alpha1.Note.IRelatedUrl): google.devtools.containeranalysis.v1alpha1.Note.RelatedUrl;

                        /**
                         * Encodes the specified RelatedUrl message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.Note.RelatedUrl.verify|verify} messages.
                         * @param message RelatedUrl message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encode(message: google.devtools.containeranalysis.v1alpha1.Note.IRelatedUrl, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Encodes the specified RelatedUrl message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.Note.RelatedUrl.verify|verify} messages.
                         * @param message RelatedUrl message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.Note.IRelatedUrl, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Decodes a RelatedUrl message from the specified reader or buffer.
                         * @param reader Reader or buffer to decode from
                         * @param [length] Message length if known beforehand
                         * @returns RelatedUrl
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.Note.RelatedUrl;

                        /**
                         * Decodes a RelatedUrl message from the specified reader or buffer, length delimited.
                         * @param reader Reader or buffer to decode from
                         * @returns RelatedUrl
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.Note.RelatedUrl;

                        /**
                         * Verifies a RelatedUrl message.
                         * @param message Plain object to verify
                         * @returns `null` if valid, otherwise the reason why it is not
                         */
                        public static verify(message: { [k: string]: any }): (string|null);

                        /**
                         * Creates a RelatedUrl message from a plain object. Also converts values to their respective internal types.
                         * @param object Plain object
                         * @returns RelatedUrl
                         */
                        public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.Note.RelatedUrl;

                        /**
                         * Creates a plain object from a RelatedUrl message. Also converts values to other types if specified.
                         * @param message RelatedUrl
                         * @param [options] Conversion options
                         * @returns Plain object
                         */
                        public static toObject(message: google.devtools.containeranalysis.v1alpha1.Note.RelatedUrl, options?: $protobuf.IConversionOptions): { [k: string]: any };

                        /**
                         * Converts this RelatedUrl to JSON.
                         * @returns JSON object
                         */
                        public toJSON(): { [k: string]: any };
                    }

                    /** Kind enum. */
                    enum Kind {
                        KIND_UNSPECIFIED = 0,
                        PACKAGE_VULNERABILITY = 2,
                        BUILD_DETAILS = 3,
                        IMAGE_BASIS = 4,
                        PACKAGE_MANAGER = 5,
                        DEPLOYABLE = 6,
                        DISCOVERY = 7,
                        ATTESTATION_AUTHORITY = 8
                    }
                }

                /** Properties of a Deployable. */
                interface IDeployable {

                    /** Deployable resourceUri */
                    resourceUri?: (string[]|null);
                }

                /** Represents a Deployable. */
                class Deployable implements IDeployable {

                    /**
                     * Constructs a new Deployable.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IDeployable);

                    /** Deployable resourceUri. */
                    public resourceUri: string[];

                    /**
                     * Creates a new Deployable instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns Deployable instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IDeployable): google.devtools.containeranalysis.v1alpha1.Deployable;

                    /**
                     * Encodes the specified Deployable message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.Deployable.verify|verify} messages.
                     * @param message Deployable message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IDeployable, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified Deployable message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.Deployable.verify|verify} messages.
                     * @param message Deployable message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IDeployable, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a Deployable message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns Deployable
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.Deployable;

                    /**
                     * Decodes a Deployable message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns Deployable
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.Deployable;

                    /**
                     * Verifies a Deployable message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a Deployable message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns Deployable
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.Deployable;

                    /**
                     * Creates a plain object from a Deployable message. Also converts values to other types if specified.
                     * @param message Deployable
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.Deployable, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this Deployable to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                namespace Deployable {

                    /** Properties of a Deployment. */
                    interface IDeployment {

                        /** Deployment userEmail */
                        userEmail?: (string|null);

                        /** Deployment deployTime */
                        deployTime?: (google.protobuf.ITimestamp|null);

                        /** Deployment undeployTime */
                        undeployTime?: (google.protobuf.ITimestamp|null);

                        /** Deployment config */
                        config?: (string|null);

                        /** Deployment address */
                        address?: (string|null);

                        /** Deployment resourceUri */
                        resourceUri?: (string[]|null);

                        /** Deployment platform */
                        platform?: (google.devtools.containeranalysis.v1alpha1.Deployable.Deployment.Platform|null);
                    }

                    /** Represents a Deployment. */
                    class Deployment implements IDeployment {

                        /**
                         * Constructs a new Deployment.
                         * @param [properties] Properties to set
                         */
                        constructor(properties?: google.devtools.containeranalysis.v1alpha1.Deployable.IDeployment);

                        /** Deployment userEmail. */
                        public userEmail: string;

                        /** Deployment deployTime. */
                        public deployTime?: (google.protobuf.ITimestamp|null);

                        /** Deployment undeployTime. */
                        public undeployTime?: (google.protobuf.ITimestamp|null);

                        /** Deployment config. */
                        public config: string;

                        /** Deployment address. */
                        public address: string;

                        /** Deployment resourceUri. */
                        public resourceUri: string[];

                        /** Deployment platform. */
                        public platform: google.devtools.containeranalysis.v1alpha1.Deployable.Deployment.Platform;

                        /**
                         * Creates a new Deployment instance using the specified properties.
                         * @param [properties] Properties to set
                         * @returns Deployment instance
                         */
                        public static create(properties?: google.devtools.containeranalysis.v1alpha1.Deployable.IDeployment): google.devtools.containeranalysis.v1alpha1.Deployable.Deployment;

                        /**
                         * Encodes the specified Deployment message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.Deployable.Deployment.verify|verify} messages.
                         * @param message Deployment message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encode(message: google.devtools.containeranalysis.v1alpha1.Deployable.IDeployment, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Encodes the specified Deployment message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.Deployable.Deployment.verify|verify} messages.
                         * @param message Deployment message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.Deployable.IDeployment, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Decodes a Deployment message from the specified reader or buffer.
                         * @param reader Reader or buffer to decode from
                         * @param [length] Message length if known beforehand
                         * @returns Deployment
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.Deployable.Deployment;

                        /**
                         * Decodes a Deployment message from the specified reader or buffer, length delimited.
                         * @param reader Reader or buffer to decode from
                         * @returns Deployment
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.Deployable.Deployment;

                        /**
                         * Verifies a Deployment message.
                         * @param message Plain object to verify
                         * @returns `null` if valid, otherwise the reason why it is not
                         */
                        public static verify(message: { [k: string]: any }): (string|null);

                        /**
                         * Creates a Deployment message from a plain object. Also converts values to their respective internal types.
                         * @param object Plain object
                         * @returns Deployment
                         */
                        public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.Deployable.Deployment;

                        /**
                         * Creates a plain object from a Deployment message. Also converts values to other types if specified.
                         * @param message Deployment
                         * @param [options] Conversion options
                         * @returns Plain object
                         */
                        public static toObject(message: google.devtools.containeranalysis.v1alpha1.Deployable.Deployment, options?: $protobuf.IConversionOptions): { [k: string]: any };

                        /**
                         * Converts this Deployment to JSON.
                         * @returns JSON object
                         */
                        public toJSON(): { [k: string]: any };
                    }

                    namespace Deployment {

                        /** Platform enum. */
                        enum Platform {
                            PLATFORM_UNSPECIFIED = 0,
                            GKE = 1,
                            FLEX = 2,
                            CUSTOM = 3
                        }
                    }
                }

                /** Properties of a Discovery. */
                interface IDiscovery {

                    /** Discovery analysisKind */
                    analysisKind?: (google.devtools.containeranalysis.v1alpha1.Note.Kind|null);
                }

                /** Represents a Discovery. */
                class Discovery implements IDiscovery {

                    /**
                     * Constructs a new Discovery.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IDiscovery);

                    /** Discovery analysisKind. */
                    public analysisKind: google.devtools.containeranalysis.v1alpha1.Note.Kind;

                    /**
                     * Creates a new Discovery instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns Discovery instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IDiscovery): google.devtools.containeranalysis.v1alpha1.Discovery;

                    /**
                     * Encodes the specified Discovery message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.Discovery.verify|verify} messages.
                     * @param message Discovery message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IDiscovery, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified Discovery message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.Discovery.verify|verify} messages.
                     * @param message Discovery message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IDiscovery, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a Discovery message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns Discovery
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.Discovery;

                    /**
                     * Decodes a Discovery message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns Discovery
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.Discovery;

                    /**
                     * Verifies a Discovery message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a Discovery message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns Discovery
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.Discovery;

                    /**
                     * Creates a plain object from a Discovery message. Also converts values to other types if specified.
                     * @param message Discovery
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.Discovery, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this Discovery to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                namespace Discovery {

                    /** Properties of a Discovered. */
                    interface IDiscovered {

                        /** Discovered operation */
                        operation?: (google.longrunning.IOperation|null);

                        /** Discovered analysisStatus */
                        analysisStatus?: (google.devtools.containeranalysis.v1alpha1.Discovery.Discovered.AnalysisStatus|null);

                        /** Discovered analysisStatusError */
                        analysisStatusError?: (google.rpc.IStatus|null);
                    }

                    /** Represents a Discovered. */
                    class Discovered implements IDiscovered {

                        /**
                         * Constructs a new Discovered.
                         * @param [properties] Properties to set
                         */
                        constructor(properties?: google.devtools.containeranalysis.v1alpha1.Discovery.IDiscovered);

                        /** Discovered operation. */
                        public operation?: (google.longrunning.IOperation|null);

                        /** Discovered analysisStatus. */
                        public analysisStatus: google.devtools.containeranalysis.v1alpha1.Discovery.Discovered.AnalysisStatus;

                        /** Discovered analysisStatusError. */
                        public analysisStatusError?: (google.rpc.IStatus|null);

                        /**
                         * Creates a new Discovered instance using the specified properties.
                         * @param [properties] Properties to set
                         * @returns Discovered instance
                         */
                        public static create(properties?: google.devtools.containeranalysis.v1alpha1.Discovery.IDiscovered): google.devtools.containeranalysis.v1alpha1.Discovery.Discovered;

                        /**
                         * Encodes the specified Discovered message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.Discovery.Discovered.verify|verify} messages.
                         * @param message Discovered message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encode(message: google.devtools.containeranalysis.v1alpha1.Discovery.IDiscovered, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Encodes the specified Discovered message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.Discovery.Discovered.verify|verify} messages.
                         * @param message Discovered message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.Discovery.IDiscovered, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Decodes a Discovered message from the specified reader or buffer.
                         * @param reader Reader or buffer to decode from
                         * @param [length] Message length if known beforehand
                         * @returns Discovered
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.Discovery.Discovered;

                        /**
                         * Decodes a Discovered message from the specified reader or buffer, length delimited.
                         * @param reader Reader or buffer to decode from
                         * @returns Discovered
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.Discovery.Discovered;

                        /**
                         * Verifies a Discovered message.
                         * @param message Plain object to verify
                         * @returns `null` if valid, otherwise the reason why it is not
                         */
                        public static verify(message: { [k: string]: any }): (string|null);

                        /**
                         * Creates a Discovered message from a plain object. Also converts values to their respective internal types.
                         * @param object Plain object
                         * @returns Discovered
                         */
                        public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.Discovery.Discovered;

                        /**
                         * Creates a plain object from a Discovered message. Also converts values to other types if specified.
                         * @param message Discovered
                         * @param [options] Conversion options
                         * @returns Plain object
                         */
                        public static toObject(message: google.devtools.containeranalysis.v1alpha1.Discovery.Discovered, options?: $protobuf.IConversionOptions): { [k: string]: any };

                        /**
                         * Converts this Discovered to JSON.
                         * @returns JSON object
                         */
                        public toJSON(): { [k: string]: any };
                    }

                    namespace Discovered {

                        /** AnalysisStatus enum. */
                        enum AnalysisStatus {
                            ANALYSIS_STATUS_UNSPECIFIED = 0,
                            PENDING = 1,
                            SCANNING = 2,
                            FINISHED_SUCCESS = 3,
                            FINISHED_FAILED = 4,
                            UNSUPPORTED_RESOURCE = 5
                        }
                    }
                }

                /** Properties of a BuildType. */
                interface IBuildType {

                    /** BuildType builderVersion */
                    builderVersion?: (string|null);

                    /** BuildType signature */
                    signature?: (google.devtools.containeranalysis.v1alpha1.IBuildSignature|null);
                }

                /** Represents a BuildType. */
                class BuildType implements IBuildType {

                    /**
                     * Constructs a new BuildType.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IBuildType);

                    /** BuildType builderVersion. */
                    public builderVersion: string;

                    /** BuildType signature. */
                    public signature?: (google.devtools.containeranalysis.v1alpha1.IBuildSignature|null);

                    /**
                     * Creates a new BuildType instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns BuildType instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IBuildType): google.devtools.containeranalysis.v1alpha1.BuildType;

                    /**
                     * Encodes the specified BuildType message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.BuildType.verify|verify} messages.
                     * @param message BuildType message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IBuildType, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified BuildType message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.BuildType.verify|verify} messages.
                     * @param message BuildType message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IBuildType, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a BuildType message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns BuildType
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.BuildType;

                    /**
                     * Decodes a BuildType message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns BuildType
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.BuildType;

                    /**
                     * Verifies a BuildType message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a BuildType message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns BuildType
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.BuildType;

                    /**
                     * Creates a plain object from a BuildType message. Also converts values to other types if specified.
                     * @param message BuildType
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.BuildType, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this BuildType to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of a BuildSignature. */
                interface IBuildSignature {

                    /** BuildSignature publicKey */
                    publicKey?: (string|null);

                    /** BuildSignature signature */
                    signature?: (string|null);

                    /** BuildSignature keyId */
                    keyId?: (string|null);

                    /** BuildSignature keyType */
                    keyType?: (google.devtools.containeranalysis.v1alpha1.BuildSignature.KeyType|null);
                }

                /** Represents a BuildSignature. */
                class BuildSignature implements IBuildSignature {

                    /**
                     * Constructs a new BuildSignature.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IBuildSignature);

                    /** BuildSignature publicKey. */
                    public publicKey: string;

                    /** BuildSignature signature. */
                    public signature: string;

                    /** BuildSignature keyId. */
                    public keyId: string;

                    /** BuildSignature keyType. */
                    public keyType: google.devtools.containeranalysis.v1alpha1.BuildSignature.KeyType;

                    /**
                     * Creates a new BuildSignature instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns BuildSignature instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IBuildSignature): google.devtools.containeranalysis.v1alpha1.BuildSignature;

                    /**
                     * Encodes the specified BuildSignature message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.BuildSignature.verify|verify} messages.
                     * @param message BuildSignature message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IBuildSignature, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified BuildSignature message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.BuildSignature.verify|verify} messages.
                     * @param message BuildSignature message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IBuildSignature, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a BuildSignature message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns BuildSignature
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.BuildSignature;

                    /**
                     * Decodes a BuildSignature message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns BuildSignature
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.BuildSignature;

                    /**
                     * Verifies a BuildSignature message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a BuildSignature message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns BuildSignature
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.BuildSignature;

                    /**
                     * Creates a plain object from a BuildSignature message. Also converts values to other types if specified.
                     * @param message BuildSignature
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.BuildSignature, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this BuildSignature to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                namespace BuildSignature {

                    /** KeyType enum. */
                    enum KeyType {
                        KEY_TYPE_UNSPECIFIED = 0,
                        PGP_ASCII_ARMORED = 1,
                        PKIX_PEM = 2
                    }
                }

                /** Properties of a PgpSignedAttestation. */
                interface IPgpSignedAttestation {

                    /** PgpSignedAttestation signature */
                    signature?: (string|null);

                    /** PgpSignedAttestation contentType */
                    contentType?: (google.devtools.containeranalysis.v1alpha1.PgpSignedAttestation.ContentType|null);

                    /** PgpSignedAttestation pgpKeyId */
                    pgpKeyId?: (string|null);
                }

                /** Represents a PgpSignedAttestation. */
                class PgpSignedAttestation implements IPgpSignedAttestation {

                    /**
                     * Constructs a new PgpSignedAttestation.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IPgpSignedAttestation);

                    /** PgpSignedAttestation signature. */
                    public signature: string;

                    /** PgpSignedAttestation contentType. */
                    public contentType: google.devtools.containeranalysis.v1alpha1.PgpSignedAttestation.ContentType;

                    /** PgpSignedAttestation pgpKeyId. */
                    public pgpKeyId: string;

                    /** PgpSignedAttestation keyId. */
                    public keyId?: "pgpKeyId";

                    /**
                     * Creates a new PgpSignedAttestation instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns PgpSignedAttestation instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IPgpSignedAttestation): google.devtools.containeranalysis.v1alpha1.PgpSignedAttestation;

                    /**
                     * Encodes the specified PgpSignedAttestation message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.PgpSignedAttestation.verify|verify} messages.
                     * @param message PgpSignedAttestation message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IPgpSignedAttestation, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified PgpSignedAttestation message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.PgpSignedAttestation.verify|verify} messages.
                     * @param message PgpSignedAttestation message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IPgpSignedAttestation, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a PgpSignedAttestation message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns PgpSignedAttestation
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.PgpSignedAttestation;

                    /**
                     * Decodes a PgpSignedAttestation message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns PgpSignedAttestation
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.PgpSignedAttestation;

                    /**
                     * Verifies a PgpSignedAttestation message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a PgpSignedAttestation message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns PgpSignedAttestation
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.PgpSignedAttestation;

                    /**
                     * Creates a plain object from a PgpSignedAttestation message. Also converts values to other types if specified.
                     * @param message PgpSignedAttestation
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.PgpSignedAttestation, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this PgpSignedAttestation to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                namespace PgpSignedAttestation {

                    /** ContentType enum. */
                    enum ContentType {
                        CONTENT_TYPE_UNSPECIFIED = 0,
                        SIMPLE_SIGNING_JSON = 1
                    }
                }

                /** Properties of an AttestationAuthority. */
                interface IAttestationAuthority {

                    /** AttestationAuthority hint */
                    hint?: (google.devtools.containeranalysis.v1alpha1.AttestationAuthority.IAttestationAuthorityHint|null);
                }

                /** Represents an AttestationAuthority. */
                class AttestationAuthority implements IAttestationAuthority {

                    /**
                     * Constructs a new AttestationAuthority.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IAttestationAuthority);

                    /** AttestationAuthority hint. */
                    public hint?: (google.devtools.containeranalysis.v1alpha1.AttestationAuthority.IAttestationAuthorityHint|null);

                    /**
                     * Creates a new AttestationAuthority instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns AttestationAuthority instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IAttestationAuthority): google.devtools.containeranalysis.v1alpha1.AttestationAuthority;

                    /**
                     * Encodes the specified AttestationAuthority message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.AttestationAuthority.verify|verify} messages.
                     * @param message AttestationAuthority message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IAttestationAuthority, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified AttestationAuthority message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.AttestationAuthority.verify|verify} messages.
                     * @param message AttestationAuthority message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IAttestationAuthority, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes an AttestationAuthority message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns AttestationAuthority
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.AttestationAuthority;

                    /**
                     * Decodes an AttestationAuthority message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns AttestationAuthority
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.AttestationAuthority;

                    /**
                     * Verifies an AttestationAuthority message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates an AttestationAuthority message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns AttestationAuthority
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.AttestationAuthority;

                    /**
                     * Creates a plain object from an AttestationAuthority message. Also converts values to other types if specified.
                     * @param message AttestationAuthority
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.AttestationAuthority, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this AttestationAuthority to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                namespace AttestationAuthority {

                    /** Properties of an AttestationAuthorityHint. */
                    interface IAttestationAuthorityHint {

                        /** AttestationAuthorityHint humanReadableName */
                        humanReadableName?: (string|null);
                    }

                    /** Represents an AttestationAuthorityHint. */
                    class AttestationAuthorityHint implements IAttestationAuthorityHint {

                        /**
                         * Constructs a new AttestationAuthorityHint.
                         * @param [properties] Properties to set
                         */
                        constructor(properties?: google.devtools.containeranalysis.v1alpha1.AttestationAuthority.IAttestationAuthorityHint);

                        /** AttestationAuthorityHint humanReadableName. */
                        public humanReadableName: string;

                        /**
                         * Creates a new AttestationAuthorityHint instance using the specified properties.
                         * @param [properties] Properties to set
                         * @returns AttestationAuthorityHint instance
                         */
                        public static create(properties?: google.devtools.containeranalysis.v1alpha1.AttestationAuthority.IAttestationAuthorityHint): google.devtools.containeranalysis.v1alpha1.AttestationAuthority.AttestationAuthorityHint;

                        /**
                         * Encodes the specified AttestationAuthorityHint message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.AttestationAuthority.AttestationAuthorityHint.verify|verify} messages.
                         * @param message AttestationAuthorityHint message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encode(message: google.devtools.containeranalysis.v1alpha1.AttestationAuthority.IAttestationAuthorityHint, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Encodes the specified AttestationAuthorityHint message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.AttestationAuthority.AttestationAuthorityHint.verify|verify} messages.
                         * @param message AttestationAuthorityHint message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.AttestationAuthority.IAttestationAuthorityHint, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Decodes an AttestationAuthorityHint message from the specified reader or buffer.
                         * @param reader Reader or buffer to decode from
                         * @param [length] Message length if known beforehand
                         * @returns AttestationAuthorityHint
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.AttestationAuthority.AttestationAuthorityHint;

                        /**
                         * Decodes an AttestationAuthorityHint message from the specified reader or buffer, length delimited.
                         * @param reader Reader or buffer to decode from
                         * @returns AttestationAuthorityHint
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.AttestationAuthority.AttestationAuthorityHint;

                        /**
                         * Verifies an AttestationAuthorityHint message.
                         * @param message Plain object to verify
                         * @returns `null` if valid, otherwise the reason why it is not
                         */
                        public static verify(message: { [k: string]: any }): (string|null);

                        /**
                         * Creates an AttestationAuthorityHint message from a plain object. Also converts values to their respective internal types.
                         * @param object Plain object
                         * @returns AttestationAuthorityHint
                         */
                        public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.AttestationAuthority.AttestationAuthorityHint;

                        /**
                         * Creates a plain object from an AttestationAuthorityHint message. Also converts values to other types if specified.
                         * @param message AttestationAuthorityHint
                         * @param [options] Conversion options
                         * @returns Plain object
                         */
                        public static toObject(message: google.devtools.containeranalysis.v1alpha1.AttestationAuthority.AttestationAuthorityHint, options?: $protobuf.IConversionOptions): { [k: string]: any };

                        /**
                         * Converts this AttestationAuthorityHint to JSON.
                         * @returns JSON object
                         */
                        public toJSON(): { [k: string]: any };
                    }

                    /** Properties of an Attestation. */
                    interface IAttestation {

                        /** Attestation pgpSignedAttestation */
                        pgpSignedAttestation?: (google.devtools.containeranalysis.v1alpha1.IPgpSignedAttestation|null);
                    }

                    /** Represents an Attestation. */
                    class Attestation implements IAttestation {

                        /**
                         * Constructs a new Attestation.
                         * @param [properties] Properties to set
                         */
                        constructor(properties?: google.devtools.containeranalysis.v1alpha1.AttestationAuthority.IAttestation);

                        /** Attestation pgpSignedAttestation. */
                        public pgpSignedAttestation?: (google.devtools.containeranalysis.v1alpha1.IPgpSignedAttestation|null);

                        /** Attestation signature. */
                        public signature?: "pgpSignedAttestation";

                        /**
                         * Creates a new Attestation instance using the specified properties.
                         * @param [properties] Properties to set
                         * @returns Attestation instance
                         */
                        public static create(properties?: google.devtools.containeranalysis.v1alpha1.AttestationAuthority.IAttestation): google.devtools.containeranalysis.v1alpha1.AttestationAuthority.Attestation;

                        /**
                         * Encodes the specified Attestation message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.AttestationAuthority.Attestation.verify|verify} messages.
                         * @param message Attestation message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encode(message: google.devtools.containeranalysis.v1alpha1.AttestationAuthority.IAttestation, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Encodes the specified Attestation message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.AttestationAuthority.Attestation.verify|verify} messages.
                         * @param message Attestation message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.AttestationAuthority.IAttestation, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Decodes an Attestation message from the specified reader or buffer.
                         * @param reader Reader or buffer to decode from
                         * @param [length] Message length if known beforehand
                         * @returns Attestation
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.AttestationAuthority.Attestation;

                        /**
                         * Decodes an Attestation message from the specified reader or buffer, length delimited.
                         * @param reader Reader or buffer to decode from
                         * @returns Attestation
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.AttestationAuthority.Attestation;

                        /**
                         * Verifies an Attestation message.
                         * @param message Plain object to verify
                         * @returns `null` if valid, otherwise the reason why it is not
                         */
                        public static verify(message: { [k: string]: any }): (string|null);

                        /**
                         * Creates an Attestation message from a plain object. Also converts values to their respective internal types.
                         * @param object Plain object
                         * @returns Attestation
                         */
                        public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.AttestationAuthority.Attestation;

                        /**
                         * Creates a plain object from an Attestation message. Also converts values to other types if specified.
                         * @param message Attestation
                         * @param [options] Conversion options
                         * @returns Plain object
                         */
                        public static toObject(message: google.devtools.containeranalysis.v1alpha1.AttestationAuthority.Attestation, options?: $protobuf.IConversionOptions): { [k: string]: any };

                        /**
                         * Converts this Attestation to JSON.
                         * @returns JSON object
                         */
                        public toJSON(): { [k: string]: any };
                    }
                }

                /** Properties of a BuildDetails. */
                interface IBuildDetails {

                    /** BuildDetails provenance */
                    provenance?: (google.devtools.containeranalysis.v1alpha1.IBuildProvenance|null);

                    /** BuildDetails provenanceBytes */
                    provenanceBytes?: (string|null);
                }

                /** Represents a BuildDetails. */
                class BuildDetails implements IBuildDetails {

                    /**
                     * Constructs a new BuildDetails.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IBuildDetails);

                    /** BuildDetails provenance. */
                    public provenance?: (google.devtools.containeranalysis.v1alpha1.IBuildProvenance|null);

                    /** BuildDetails provenanceBytes. */
                    public provenanceBytes: string;

                    /**
                     * Creates a new BuildDetails instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns BuildDetails instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IBuildDetails): google.devtools.containeranalysis.v1alpha1.BuildDetails;

                    /**
                     * Encodes the specified BuildDetails message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.BuildDetails.verify|verify} messages.
                     * @param message BuildDetails message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IBuildDetails, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified BuildDetails message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.BuildDetails.verify|verify} messages.
                     * @param message BuildDetails message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IBuildDetails, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a BuildDetails message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns BuildDetails
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.BuildDetails;

                    /**
                     * Decodes a BuildDetails message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns BuildDetails
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.BuildDetails;

                    /**
                     * Verifies a BuildDetails message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a BuildDetails message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns BuildDetails
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.BuildDetails;

                    /**
                     * Creates a plain object from a BuildDetails message. Also converts values to other types if specified.
                     * @param message BuildDetails
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.BuildDetails, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this BuildDetails to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of a ScanConfig. */
                interface IScanConfig {

                    /** ScanConfig name */
                    name?: (string|null);

                    /** ScanConfig description */
                    description?: (string|null);

                    /** ScanConfig enabled */
                    enabled?: (boolean|null);
                }

                /** Represents a ScanConfig. */
                class ScanConfig implements IScanConfig {

                    /**
                     * Constructs a new ScanConfig.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IScanConfig);

                    /** ScanConfig name. */
                    public name: string;

                    /** ScanConfig description. */
                    public description: string;

                    /** ScanConfig enabled. */
                    public enabled: boolean;

                    /**
                     * Creates a new ScanConfig instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns ScanConfig instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IScanConfig): google.devtools.containeranalysis.v1alpha1.ScanConfig;

                    /**
                     * Encodes the specified ScanConfig message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.ScanConfig.verify|verify} messages.
                     * @param message ScanConfig message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IScanConfig, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified ScanConfig message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.ScanConfig.verify|verify} messages.
                     * @param message ScanConfig message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IScanConfig, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a ScanConfig message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns ScanConfig
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.ScanConfig;

                    /**
                     * Decodes a ScanConfig message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns ScanConfig
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.ScanConfig;

                    /**
                     * Verifies a ScanConfig message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a ScanConfig message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns ScanConfig
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.ScanConfig;

                    /**
                     * Creates a plain object from a ScanConfig message. Also converts values to other types if specified.
                     * @param message ScanConfig
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.ScanConfig, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this ScanConfig to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of a GetOccurrenceRequest. */
                interface IGetOccurrenceRequest {

                    /** GetOccurrenceRequest name */
                    name?: (string|null);
                }

                /** Represents a GetOccurrenceRequest. */
                class GetOccurrenceRequest implements IGetOccurrenceRequest {

                    /**
                     * Constructs a new GetOccurrenceRequest.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IGetOccurrenceRequest);

                    /** GetOccurrenceRequest name. */
                    public name: string;

                    /**
                     * Creates a new GetOccurrenceRequest instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns GetOccurrenceRequest instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IGetOccurrenceRequest): google.devtools.containeranalysis.v1alpha1.GetOccurrenceRequest;

                    /**
                     * Encodes the specified GetOccurrenceRequest message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.GetOccurrenceRequest.verify|verify} messages.
                     * @param message GetOccurrenceRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IGetOccurrenceRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified GetOccurrenceRequest message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.GetOccurrenceRequest.verify|verify} messages.
                     * @param message GetOccurrenceRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IGetOccurrenceRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a GetOccurrenceRequest message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns GetOccurrenceRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.GetOccurrenceRequest;

                    /**
                     * Decodes a GetOccurrenceRequest message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns GetOccurrenceRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.GetOccurrenceRequest;

                    /**
                     * Verifies a GetOccurrenceRequest message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a GetOccurrenceRequest message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns GetOccurrenceRequest
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.GetOccurrenceRequest;

                    /**
                     * Creates a plain object from a GetOccurrenceRequest message. Also converts values to other types if specified.
                     * @param message GetOccurrenceRequest
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.GetOccurrenceRequest, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this GetOccurrenceRequest to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of a ListOccurrencesRequest. */
                interface IListOccurrencesRequest {

                    /** ListOccurrencesRequest name */
                    name?: (string|null);

                    /** ListOccurrencesRequest parent */
                    parent?: (string|null);

                    /** ListOccurrencesRequest filter */
                    filter?: (string|null);

                    /** ListOccurrencesRequest pageSize */
                    pageSize?: (number|null);

                    /** ListOccurrencesRequest pageToken */
                    pageToken?: (string|null);

                    /** ListOccurrencesRequest kind */
                    kind?: (google.devtools.containeranalysis.v1alpha1.Note.Kind|null);
                }

                /** Represents a ListOccurrencesRequest. */
                class ListOccurrencesRequest implements IListOccurrencesRequest {

                    /**
                     * Constructs a new ListOccurrencesRequest.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IListOccurrencesRequest);

                    /** ListOccurrencesRequest name. */
                    public name: string;

                    /** ListOccurrencesRequest parent. */
                    public parent: string;

                    /** ListOccurrencesRequest filter. */
                    public filter: string;

                    /** ListOccurrencesRequest pageSize. */
                    public pageSize: number;

                    /** ListOccurrencesRequest pageToken. */
                    public pageToken: string;

                    /** ListOccurrencesRequest kind. */
                    public kind: google.devtools.containeranalysis.v1alpha1.Note.Kind;

                    /**
                     * Creates a new ListOccurrencesRequest instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns ListOccurrencesRequest instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IListOccurrencesRequest): google.devtools.containeranalysis.v1alpha1.ListOccurrencesRequest;

                    /**
                     * Encodes the specified ListOccurrencesRequest message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.ListOccurrencesRequest.verify|verify} messages.
                     * @param message ListOccurrencesRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IListOccurrencesRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified ListOccurrencesRequest message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.ListOccurrencesRequest.verify|verify} messages.
                     * @param message ListOccurrencesRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IListOccurrencesRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a ListOccurrencesRequest message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns ListOccurrencesRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.ListOccurrencesRequest;

                    /**
                     * Decodes a ListOccurrencesRequest message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns ListOccurrencesRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.ListOccurrencesRequest;

                    /**
                     * Verifies a ListOccurrencesRequest message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a ListOccurrencesRequest message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns ListOccurrencesRequest
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.ListOccurrencesRequest;

                    /**
                     * Creates a plain object from a ListOccurrencesRequest message. Also converts values to other types if specified.
                     * @param message ListOccurrencesRequest
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.ListOccurrencesRequest, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this ListOccurrencesRequest to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of a ListOccurrencesResponse. */
                interface IListOccurrencesResponse {

                    /** ListOccurrencesResponse occurrences */
                    occurrences?: (google.devtools.containeranalysis.v1alpha1.IOccurrence[]|null);

                    /** ListOccurrencesResponse nextPageToken */
                    nextPageToken?: (string|null);
                }

                /** Represents a ListOccurrencesResponse. */
                class ListOccurrencesResponse implements IListOccurrencesResponse {

                    /**
                     * Constructs a new ListOccurrencesResponse.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IListOccurrencesResponse);

                    /** ListOccurrencesResponse occurrences. */
                    public occurrences: google.devtools.containeranalysis.v1alpha1.IOccurrence[];

                    /** ListOccurrencesResponse nextPageToken. */
                    public nextPageToken: string;

                    /**
                     * Creates a new ListOccurrencesResponse instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns ListOccurrencesResponse instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IListOccurrencesResponse): google.devtools.containeranalysis.v1alpha1.ListOccurrencesResponse;

                    /**
                     * Encodes the specified ListOccurrencesResponse message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.ListOccurrencesResponse.verify|verify} messages.
                     * @param message ListOccurrencesResponse message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IListOccurrencesResponse, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified ListOccurrencesResponse message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.ListOccurrencesResponse.verify|verify} messages.
                     * @param message ListOccurrencesResponse message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IListOccurrencesResponse, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a ListOccurrencesResponse message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns ListOccurrencesResponse
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.ListOccurrencesResponse;

                    /**
                     * Decodes a ListOccurrencesResponse message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns ListOccurrencesResponse
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.ListOccurrencesResponse;

                    /**
                     * Verifies a ListOccurrencesResponse message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a ListOccurrencesResponse message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns ListOccurrencesResponse
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.ListOccurrencesResponse;

                    /**
                     * Creates a plain object from a ListOccurrencesResponse message. Also converts values to other types if specified.
                     * @param message ListOccurrencesResponse
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.ListOccurrencesResponse, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this ListOccurrencesResponse to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of a DeleteOccurrenceRequest. */
                interface IDeleteOccurrenceRequest {

                    /** DeleteOccurrenceRequest name */
                    name?: (string|null);
                }

                /** Represents a DeleteOccurrenceRequest. */
                class DeleteOccurrenceRequest implements IDeleteOccurrenceRequest {

                    /**
                     * Constructs a new DeleteOccurrenceRequest.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IDeleteOccurrenceRequest);

                    /** DeleteOccurrenceRequest name. */
                    public name: string;

                    /**
                     * Creates a new DeleteOccurrenceRequest instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns DeleteOccurrenceRequest instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IDeleteOccurrenceRequest): google.devtools.containeranalysis.v1alpha1.DeleteOccurrenceRequest;

                    /**
                     * Encodes the specified DeleteOccurrenceRequest message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.DeleteOccurrenceRequest.verify|verify} messages.
                     * @param message DeleteOccurrenceRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IDeleteOccurrenceRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified DeleteOccurrenceRequest message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.DeleteOccurrenceRequest.verify|verify} messages.
                     * @param message DeleteOccurrenceRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IDeleteOccurrenceRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a DeleteOccurrenceRequest message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns DeleteOccurrenceRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.DeleteOccurrenceRequest;

                    /**
                     * Decodes a DeleteOccurrenceRequest message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns DeleteOccurrenceRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.DeleteOccurrenceRequest;

                    /**
                     * Verifies a DeleteOccurrenceRequest message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a DeleteOccurrenceRequest message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns DeleteOccurrenceRequest
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.DeleteOccurrenceRequest;

                    /**
                     * Creates a plain object from a DeleteOccurrenceRequest message. Also converts values to other types if specified.
                     * @param message DeleteOccurrenceRequest
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.DeleteOccurrenceRequest, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this DeleteOccurrenceRequest to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of a CreateOccurrenceRequest. */
                interface ICreateOccurrenceRequest {

                    /** CreateOccurrenceRequest name */
                    name?: (string|null);

                    /** CreateOccurrenceRequest parent */
                    parent?: (string|null);

                    /** CreateOccurrenceRequest occurrence */
                    occurrence?: (google.devtools.containeranalysis.v1alpha1.IOccurrence|null);
                }

                /** Represents a CreateOccurrenceRequest. */
                class CreateOccurrenceRequest implements ICreateOccurrenceRequest {

                    /**
                     * Constructs a new CreateOccurrenceRequest.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.ICreateOccurrenceRequest);

                    /** CreateOccurrenceRequest name. */
                    public name: string;

                    /** CreateOccurrenceRequest parent. */
                    public parent: string;

                    /** CreateOccurrenceRequest occurrence. */
                    public occurrence?: (google.devtools.containeranalysis.v1alpha1.IOccurrence|null);

                    /**
                     * Creates a new CreateOccurrenceRequest instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns CreateOccurrenceRequest instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.ICreateOccurrenceRequest): google.devtools.containeranalysis.v1alpha1.CreateOccurrenceRequest;

                    /**
                     * Encodes the specified CreateOccurrenceRequest message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.CreateOccurrenceRequest.verify|verify} messages.
                     * @param message CreateOccurrenceRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.ICreateOccurrenceRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified CreateOccurrenceRequest message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.CreateOccurrenceRequest.verify|verify} messages.
                     * @param message CreateOccurrenceRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.ICreateOccurrenceRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a CreateOccurrenceRequest message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns CreateOccurrenceRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.CreateOccurrenceRequest;

                    /**
                     * Decodes a CreateOccurrenceRequest message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns CreateOccurrenceRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.CreateOccurrenceRequest;

                    /**
                     * Verifies a CreateOccurrenceRequest message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a CreateOccurrenceRequest message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns CreateOccurrenceRequest
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.CreateOccurrenceRequest;

                    /**
                     * Creates a plain object from a CreateOccurrenceRequest message. Also converts values to other types if specified.
                     * @param message CreateOccurrenceRequest
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.CreateOccurrenceRequest, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this CreateOccurrenceRequest to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of an UpdateOccurrenceRequest. */
                interface IUpdateOccurrenceRequest {

                    /** UpdateOccurrenceRequest name */
                    name?: (string|null);

                    /** UpdateOccurrenceRequest occurrence */
                    occurrence?: (google.devtools.containeranalysis.v1alpha1.IOccurrence|null);

                    /** UpdateOccurrenceRequest updateMask */
                    updateMask?: (google.protobuf.IFieldMask|null);
                }

                /** Represents an UpdateOccurrenceRequest. */
                class UpdateOccurrenceRequest implements IUpdateOccurrenceRequest {

                    /**
                     * Constructs a new UpdateOccurrenceRequest.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IUpdateOccurrenceRequest);

                    /** UpdateOccurrenceRequest name. */
                    public name: string;

                    /** UpdateOccurrenceRequest occurrence. */
                    public occurrence?: (google.devtools.containeranalysis.v1alpha1.IOccurrence|null);

                    /** UpdateOccurrenceRequest updateMask. */
                    public updateMask?: (google.protobuf.IFieldMask|null);

                    /**
                     * Creates a new UpdateOccurrenceRequest instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns UpdateOccurrenceRequest instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IUpdateOccurrenceRequest): google.devtools.containeranalysis.v1alpha1.UpdateOccurrenceRequest;

                    /**
                     * Encodes the specified UpdateOccurrenceRequest message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.UpdateOccurrenceRequest.verify|verify} messages.
                     * @param message UpdateOccurrenceRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IUpdateOccurrenceRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified UpdateOccurrenceRequest message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.UpdateOccurrenceRequest.verify|verify} messages.
                     * @param message UpdateOccurrenceRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IUpdateOccurrenceRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes an UpdateOccurrenceRequest message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns UpdateOccurrenceRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.UpdateOccurrenceRequest;

                    /**
                     * Decodes an UpdateOccurrenceRequest message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns UpdateOccurrenceRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.UpdateOccurrenceRequest;

                    /**
                     * Verifies an UpdateOccurrenceRequest message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates an UpdateOccurrenceRequest message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns UpdateOccurrenceRequest
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.UpdateOccurrenceRequest;

                    /**
                     * Creates a plain object from an UpdateOccurrenceRequest message. Also converts values to other types if specified.
                     * @param message UpdateOccurrenceRequest
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.UpdateOccurrenceRequest, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this UpdateOccurrenceRequest to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of a GetNoteRequest. */
                interface IGetNoteRequest {

                    /** GetNoteRequest name */
                    name?: (string|null);
                }

                /** Represents a GetNoteRequest. */
                class GetNoteRequest implements IGetNoteRequest {

                    /**
                     * Constructs a new GetNoteRequest.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IGetNoteRequest);

                    /** GetNoteRequest name. */
                    public name: string;

                    /**
                     * Creates a new GetNoteRequest instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns GetNoteRequest instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IGetNoteRequest): google.devtools.containeranalysis.v1alpha1.GetNoteRequest;

                    /**
                     * Encodes the specified GetNoteRequest message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.GetNoteRequest.verify|verify} messages.
                     * @param message GetNoteRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IGetNoteRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified GetNoteRequest message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.GetNoteRequest.verify|verify} messages.
                     * @param message GetNoteRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IGetNoteRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a GetNoteRequest message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns GetNoteRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.GetNoteRequest;

                    /**
                     * Decodes a GetNoteRequest message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns GetNoteRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.GetNoteRequest;

                    /**
                     * Verifies a GetNoteRequest message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a GetNoteRequest message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns GetNoteRequest
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.GetNoteRequest;

                    /**
                     * Creates a plain object from a GetNoteRequest message. Also converts values to other types if specified.
                     * @param message GetNoteRequest
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.GetNoteRequest, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this GetNoteRequest to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of a GetOccurrenceNoteRequest. */
                interface IGetOccurrenceNoteRequest {

                    /** GetOccurrenceNoteRequest name */
                    name?: (string|null);
                }

                /** Represents a GetOccurrenceNoteRequest. */
                class GetOccurrenceNoteRequest implements IGetOccurrenceNoteRequest {

                    /**
                     * Constructs a new GetOccurrenceNoteRequest.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IGetOccurrenceNoteRequest);

                    /** GetOccurrenceNoteRequest name. */
                    public name: string;

                    /**
                     * Creates a new GetOccurrenceNoteRequest instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns GetOccurrenceNoteRequest instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IGetOccurrenceNoteRequest): google.devtools.containeranalysis.v1alpha1.GetOccurrenceNoteRequest;

                    /**
                     * Encodes the specified GetOccurrenceNoteRequest message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.GetOccurrenceNoteRequest.verify|verify} messages.
                     * @param message GetOccurrenceNoteRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IGetOccurrenceNoteRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified GetOccurrenceNoteRequest message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.GetOccurrenceNoteRequest.verify|verify} messages.
                     * @param message GetOccurrenceNoteRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IGetOccurrenceNoteRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a GetOccurrenceNoteRequest message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns GetOccurrenceNoteRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.GetOccurrenceNoteRequest;

                    /**
                     * Decodes a GetOccurrenceNoteRequest message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns GetOccurrenceNoteRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.GetOccurrenceNoteRequest;

                    /**
                     * Verifies a GetOccurrenceNoteRequest message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a GetOccurrenceNoteRequest message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns GetOccurrenceNoteRequest
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.GetOccurrenceNoteRequest;

                    /**
                     * Creates a plain object from a GetOccurrenceNoteRequest message. Also converts values to other types if specified.
                     * @param message GetOccurrenceNoteRequest
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.GetOccurrenceNoteRequest, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this GetOccurrenceNoteRequest to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of a ListNotesRequest. */
                interface IListNotesRequest {

                    /** ListNotesRequest name */
                    name?: (string|null);

                    /** ListNotesRequest parent */
                    parent?: (string|null);

                    /** ListNotesRequest filter */
                    filter?: (string|null);

                    /** ListNotesRequest pageSize */
                    pageSize?: (number|null);

                    /** ListNotesRequest pageToken */
                    pageToken?: (string|null);
                }

                /** Represents a ListNotesRequest. */
                class ListNotesRequest implements IListNotesRequest {

                    /**
                     * Constructs a new ListNotesRequest.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IListNotesRequest);

                    /** ListNotesRequest name. */
                    public name: string;

                    /** ListNotesRequest parent. */
                    public parent: string;

                    /** ListNotesRequest filter. */
                    public filter: string;

                    /** ListNotesRequest pageSize. */
                    public pageSize: number;

                    /** ListNotesRequest pageToken. */
                    public pageToken: string;

                    /**
                     * Creates a new ListNotesRequest instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns ListNotesRequest instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IListNotesRequest): google.devtools.containeranalysis.v1alpha1.ListNotesRequest;

                    /**
                     * Encodes the specified ListNotesRequest message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.ListNotesRequest.verify|verify} messages.
                     * @param message ListNotesRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IListNotesRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified ListNotesRequest message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.ListNotesRequest.verify|verify} messages.
                     * @param message ListNotesRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IListNotesRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a ListNotesRequest message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns ListNotesRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.ListNotesRequest;

                    /**
                     * Decodes a ListNotesRequest message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns ListNotesRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.ListNotesRequest;

                    /**
                     * Verifies a ListNotesRequest message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a ListNotesRequest message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns ListNotesRequest
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.ListNotesRequest;

                    /**
                     * Creates a plain object from a ListNotesRequest message. Also converts values to other types if specified.
                     * @param message ListNotesRequest
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.ListNotesRequest, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this ListNotesRequest to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of a ListNotesResponse. */
                interface IListNotesResponse {

                    /** ListNotesResponse notes */
                    notes?: (google.devtools.containeranalysis.v1alpha1.INote[]|null);

                    /** ListNotesResponse nextPageToken */
                    nextPageToken?: (string|null);
                }

                /** Represents a ListNotesResponse. */
                class ListNotesResponse implements IListNotesResponse {

                    /**
                     * Constructs a new ListNotesResponse.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IListNotesResponse);

                    /** ListNotesResponse notes. */
                    public notes: google.devtools.containeranalysis.v1alpha1.INote[];

                    /** ListNotesResponse nextPageToken. */
                    public nextPageToken: string;

                    /**
                     * Creates a new ListNotesResponse instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns ListNotesResponse instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IListNotesResponse): google.devtools.containeranalysis.v1alpha1.ListNotesResponse;

                    /**
                     * Encodes the specified ListNotesResponse message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.ListNotesResponse.verify|verify} messages.
                     * @param message ListNotesResponse message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IListNotesResponse, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified ListNotesResponse message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.ListNotesResponse.verify|verify} messages.
                     * @param message ListNotesResponse message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IListNotesResponse, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a ListNotesResponse message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns ListNotesResponse
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.ListNotesResponse;

                    /**
                     * Decodes a ListNotesResponse message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns ListNotesResponse
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.ListNotesResponse;

                    /**
                     * Verifies a ListNotesResponse message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a ListNotesResponse message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns ListNotesResponse
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.ListNotesResponse;

                    /**
                     * Creates a plain object from a ListNotesResponse message. Also converts values to other types if specified.
                     * @param message ListNotesResponse
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.ListNotesResponse, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this ListNotesResponse to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of a DeleteNoteRequest. */
                interface IDeleteNoteRequest {

                    /** DeleteNoteRequest name */
                    name?: (string|null);
                }

                /** Represents a DeleteNoteRequest. */
                class DeleteNoteRequest implements IDeleteNoteRequest {

                    /**
                     * Constructs a new DeleteNoteRequest.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IDeleteNoteRequest);

                    /** DeleteNoteRequest name. */
                    public name: string;

                    /**
                     * Creates a new DeleteNoteRequest instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns DeleteNoteRequest instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IDeleteNoteRequest): google.devtools.containeranalysis.v1alpha1.DeleteNoteRequest;

                    /**
                     * Encodes the specified DeleteNoteRequest message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.DeleteNoteRequest.verify|verify} messages.
                     * @param message DeleteNoteRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IDeleteNoteRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified DeleteNoteRequest message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.DeleteNoteRequest.verify|verify} messages.
                     * @param message DeleteNoteRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IDeleteNoteRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a DeleteNoteRequest message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns DeleteNoteRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.DeleteNoteRequest;

                    /**
                     * Decodes a DeleteNoteRequest message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns DeleteNoteRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.DeleteNoteRequest;

                    /**
                     * Verifies a DeleteNoteRequest message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a DeleteNoteRequest message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns DeleteNoteRequest
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.DeleteNoteRequest;

                    /**
                     * Creates a plain object from a DeleteNoteRequest message. Also converts values to other types if specified.
                     * @param message DeleteNoteRequest
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.DeleteNoteRequest, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this DeleteNoteRequest to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of a CreateNoteRequest. */
                interface ICreateNoteRequest {

                    /** CreateNoteRequest name */
                    name?: (string|null);

                    /** CreateNoteRequest parent */
                    parent?: (string|null);

                    /** CreateNoteRequest noteId */
                    noteId?: (string|null);

                    /** CreateNoteRequest note */
                    note?: (google.devtools.containeranalysis.v1alpha1.INote|null);
                }

                /** Represents a CreateNoteRequest. */
                class CreateNoteRequest implements ICreateNoteRequest {

                    /**
                     * Constructs a new CreateNoteRequest.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.ICreateNoteRequest);

                    /** CreateNoteRequest name. */
                    public name: string;

                    /** CreateNoteRequest parent. */
                    public parent: string;

                    /** CreateNoteRequest noteId. */
                    public noteId: string;

                    /** CreateNoteRequest note. */
                    public note?: (google.devtools.containeranalysis.v1alpha1.INote|null);

                    /**
                     * Creates a new CreateNoteRequest instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns CreateNoteRequest instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.ICreateNoteRequest): google.devtools.containeranalysis.v1alpha1.CreateNoteRequest;

                    /**
                     * Encodes the specified CreateNoteRequest message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.CreateNoteRequest.verify|verify} messages.
                     * @param message CreateNoteRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.ICreateNoteRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified CreateNoteRequest message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.CreateNoteRequest.verify|verify} messages.
                     * @param message CreateNoteRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.ICreateNoteRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a CreateNoteRequest message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns CreateNoteRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.CreateNoteRequest;

                    /**
                     * Decodes a CreateNoteRequest message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns CreateNoteRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.CreateNoteRequest;

                    /**
                     * Verifies a CreateNoteRequest message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a CreateNoteRequest message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns CreateNoteRequest
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.CreateNoteRequest;

                    /**
                     * Creates a plain object from a CreateNoteRequest message. Also converts values to other types if specified.
                     * @param message CreateNoteRequest
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.CreateNoteRequest, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this CreateNoteRequest to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of an UpdateNoteRequest. */
                interface IUpdateNoteRequest {

                    /** UpdateNoteRequest name */
                    name?: (string|null);

                    /** UpdateNoteRequest note */
                    note?: (google.devtools.containeranalysis.v1alpha1.INote|null);

                    /** UpdateNoteRequest updateMask */
                    updateMask?: (google.protobuf.IFieldMask|null);
                }

                /** Represents an UpdateNoteRequest. */
                class UpdateNoteRequest implements IUpdateNoteRequest {

                    /**
                     * Constructs a new UpdateNoteRequest.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IUpdateNoteRequest);

                    /** UpdateNoteRequest name. */
                    public name: string;

                    /** UpdateNoteRequest note. */
                    public note?: (google.devtools.containeranalysis.v1alpha1.INote|null);

                    /** UpdateNoteRequest updateMask. */
                    public updateMask?: (google.protobuf.IFieldMask|null);

                    /**
                     * Creates a new UpdateNoteRequest instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns UpdateNoteRequest instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IUpdateNoteRequest): google.devtools.containeranalysis.v1alpha1.UpdateNoteRequest;

                    /**
                     * Encodes the specified UpdateNoteRequest message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.UpdateNoteRequest.verify|verify} messages.
                     * @param message UpdateNoteRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IUpdateNoteRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified UpdateNoteRequest message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.UpdateNoteRequest.verify|verify} messages.
                     * @param message UpdateNoteRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IUpdateNoteRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes an UpdateNoteRequest message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns UpdateNoteRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.UpdateNoteRequest;

                    /**
                     * Decodes an UpdateNoteRequest message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns UpdateNoteRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.UpdateNoteRequest;

                    /**
                     * Verifies an UpdateNoteRequest message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates an UpdateNoteRequest message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns UpdateNoteRequest
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.UpdateNoteRequest;

                    /**
                     * Creates a plain object from an UpdateNoteRequest message. Also converts values to other types if specified.
                     * @param message UpdateNoteRequest
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.UpdateNoteRequest, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this UpdateNoteRequest to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of a ListNoteOccurrencesRequest. */
                interface IListNoteOccurrencesRequest {

                    /** ListNoteOccurrencesRequest name */
                    name?: (string|null);

                    /** ListNoteOccurrencesRequest filter */
                    filter?: (string|null);

                    /** ListNoteOccurrencesRequest pageSize */
                    pageSize?: (number|null);

                    /** ListNoteOccurrencesRequest pageToken */
                    pageToken?: (string|null);
                }

                /** Represents a ListNoteOccurrencesRequest. */
                class ListNoteOccurrencesRequest implements IListNoteOccurrencesRequest {

                    /**
                     * Constructs a new ListNoteOccurrencesRequest.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IListNoteOccurrencesRequest);

                    /** ListNoteOccurrencesRequest name. */
                    public name: string;

                    /** ListNoteOccurrencesRequest filter. */
                    public filter: string;

                    /** ListNoteOccurrencesRequest pageSize. */
                    public pageSize: number;

                    /** ListNoteOccurrencesRequest pageToken. */
                    public pageToken: string;

                    /**
                     * Creates a new ListNoteOccurrencesRequest instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns ListNoteOccurrencesRequest instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IListNoteOccurrencesRequest): google.devtools.containeranalysis.v1alpha1.ListNoteOccurrencesRequest;

                    /**
                     * Encodes the specified ListNoteOccurrencesRequest message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.ListNoteOccurrencesRequest.verify|verify} messages.
                     * @param message ListNoteOccurrencesRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IListNoteOccurrencesRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified ListNoteOccurrencesRequest message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.ListNoteOccurrencesRequest.verify|verify} messages.
                     * @param message ListNoteOccurrencesRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IListNoteOccurrencesRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a ListNoteOccurrencesRequest message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns ListNoteOccurrencesRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.ListNoteOccurrencesRequest;

                    /**
                     * Decodes a ListNoteOccurrencesRequest message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns ListNoteOccurrencesRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.ListNoteOccurrencesRequest;

                    /**
                     * Verifies a ListNoteOccurrencesRequest message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a ListNoteOccurrencesRequest message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns ListNoteOccurrencesRequest
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.ListNoteOccurrencesRequest;

                    /**
                     * Creates a plain object from a ListNoteOccurrencesRequest message. Also converts values to other types if specified.
                     * @param message ListNoteOccurrencesRequest
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.ListNoteOccurrencesRequest, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this ListNoteOccurrencesRequest to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of a ListNoteOccurrencesResponse. */
                interface IListNoteOccurrencesResponse {

                    /** ListNoteOccurrencesResponse occurrences */
                    occurrences?: (google.devtools.containeranalysis.v1alpha1.IOccurrence[]|null);

                    /** ListNoteOccurrencesResponse nextPageToken */
                    nextPageToken?: (string|null);
                }

                /** Represents a ListNoteOccurrencesResponse. */
                class ListNoteOccurrencesResponse implements IListNoteOccurrencesResponse {

                    /**
                     * Constructs a new ListNoteOccurrencesResponse.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IListNoteOccurrencesResponse);

                    /** ListNoteOccurrencesResponse occurrences. */
                    public occurrences: google.devtools.containeranalysis.v1alpha1.IOccurrence[];

                    /** ListNoteOccurrencesResponse nextPageToken. */
                    public nextPageToken: string;

                    /**
                     * Creates a new ListNoteOccurrencesResponse instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns ListNoteOccurrencesResponse instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IListNoteOccurrencesResponse): google.devtools.containeranalysis.v1alpha1.ListNoteOccurrencesResponse;

                    /**
                     * Encodes the specified ListNoteOccurrencesResponse message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.ListNoteOccurrencesResponse.verify|verify} messages.
                     * @param message ListNoteOccurrencesResponse message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IListNoteOccurrencesResponse, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified ListNoteOccurrencesResponse message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.ListNoteOccurrencesResponse.verify|verify} messages.
                     * @param message ListNoteOccurrencesResponse message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IListNoteOccurrencesResponse, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a ListNoteOccurrencesResponse message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns ListNoteOccurrencesResponse
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.ListNoteOccurrencesResponse;

                    /**
                     * Decodes a ListNoteOccurrencesResponse message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns ListNoteOccurrencesResponse
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.ListNoteOccurrencesResponse;

                    /**
                     * Verifies a ListNoteOccurrencesResponse message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a ListNoteOccurrencesResponse message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns ListNoteOccurrencesResponse
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.ListNoteOccurrencesResponse;

                    /**
                     * Creates a plain object from a ListNoteOccurrencesResponse message. Also converts values to other types if specified.
                     * @param message ListNoteOccurrencesResponse
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.ListNoteOccurrencesResponse, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this ListNoteOccurrencesResponse to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of a CreateOperationRequest. */
                interface ICreateOperationRequest {

                    /** CreateOperationRequest parent */
                    parent?: (string|null);

                    /** CreateOperationRequest operationId */
                    operationId?: (string|null);

                    /** CreateOperationRequest operation */
                    operation?: (google.longrunning.IOperation|null);
                }

                /** Represents a CreateOperationRequest. */
                class CreateOperationRequest implements ICreateOperationRequest {

                    /**
                     * Constructs a new CreateOperationRequest.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.ICreateOperationRequest);

                    /** CreateOperationRequest parent. */
                    public parent: string;

                    /** CreateOperationRequest operationId. */
                    public operationId: string;

                    /** CreateOperationRequest operation. */
                    public operation?: (google.longrunning.IOperation|null);

                    /**
                     * Creates a new CreateOperationRequest instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns CreateOperationRequest instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.ICreateOperationRequest): google.devtools.containeranalysis.v1alpha1.CreateOperationRequest;

                    /**
                     * Encodes the specified CreateOperationRequest message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.CreateOperationRequest.verify|verify} messages.
                     * @param message CreateOperationRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.ICreateOperationRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified CreateOperationRequest message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.CreateOperationRequest.verify|verify} messages.
                     * @param message CreateOperationRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.ICreateOperationRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a CreateOperationRequest message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns CreateOperationRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.CreateOperationRequest;

                    /**
                     * Decodes a CreateOperationRequest message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns CreateOperationRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.CreateOperationRequest;

                    /**
                     * Verifies a CreateOperationRequest message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a CreateOperationRequest message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns CreateOperationRequest
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.CreateOperationRequest;

                    /**
                     * Creates a plain object from a CreateOperationRequest message. Also converts values to other types if specified.
                     * @param message CreateOperationRequest
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.CreateOperationRequest, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this CreateOperationRequest to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of an UpdateOperationRequest. */
                interface IUpdateOperationRequest {

                    /** UpdateOperationRequest name */
                    name?: (string|null);

                    /** UpdateOperationRequest operation */
                    operation?: (google.longrunning.IOperation|null);

                    /** UpdateOperationRequest updateMask */
                    updateMask?: (google.protobuf.IFieldMask|null);
                }

                /** Represents an UpdateOperationRequest. */
                class UpdateOperationRequest implements IUpdateOperationRequest {

                    /**
                     * Constructs a new UpdateOperationRequest.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IUpdateOperationRequest);

                    /** UpdateOperationRequest name. */
                    public name: string;

                    /** UpdateOperationRequest operation. */
                    public operation?: (google.longrunning.IOperation|null);

                    /** UpdateOperationRequest updateMask. */
                    public updateMask?: (google.protobuf.IFieldMask|null);

                    /**
                     * Creates a new UpdateOperationRequest instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns UpdateOperationRequest instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IUpdateOperationRequest): google.devtools.containeranalysis.v1alpha1.UpdateOperationRequest;

                    /**
                     * Encodes the specified UpdateOperationRequest message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.UpdateOperationRequest.verify|verify} messages.
                     * @param message UpdateOperationRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IUpdateOperationRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified UpdateOperationRequest message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.UpdateOperationRequest.verify|verify} messages.
                     * @param message UpdateOperationRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IUpdateOperationRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes an UpdateOperationRequest message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns UpdateOperationRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.UpdateOperationRequest;

                    /**
                     * Decodes an UpdateOperationRequest message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns UpdateOperationRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.UpdateOperationRequest;

                    /**
                     * Verifies an UpdateOperationRequest message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates an UpdateOperationRequest message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns UpdateOperationRequest
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.UpdateOperationRequest;

                    /**
                     * Creates a plain object from an UpdateOperationRequest message. Also converts values to other types if specified.
                     * @param message UpdateOperationRequest
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.UpdateOperationRequest, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this UpdateOperationRequest to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of an OperationMetadata. */
                interface IOperationMetadata {

                    /** OperationMetadata createTime */
                    createTime?: (google.protobuf.ITimestamp|null);

                    /** OperationMetadata endTime */
                    endTime?: (google.protobuf.ITimestamp|null);
                }

                /** Represents an OperationMetadata. */
                class OperationMetadata implements IOperationMetadata {

                    /**
                     * Constructs a new OperationMetadata.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IOperationMetadata);

                    /** OperationMetadata createTime. */
                    public createTime?: (google.protobuf.ITimestamp|null);

                    /** OperationMetadata endTime. */
                    public endTime?: (google.protobuf.ITimestamp|null);

                    /**
                     * Creates a new OperationMetadata instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns OperationMetadata instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IOperationMetadata): google.devtools.containeranalysis.v1alpha1.OperationMetadata;

                    /**
                     * Encodes the specified OperationMetadata message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.OperationMetadata.verify|verify} messages.
                     * @param message OperationMetadata message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IOperationMetadata, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified OperationMetadata message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.OperationMetadata.verify|verify} messages.
                     * @param message OperationMetadata message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IOperationMetadata, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes an OperationMetadata message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns OperationMetadata
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.OperationMetadata;

                    /**
                     * Decodes an OperationMetadata message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns OperationMetadata
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.OperationMetadata;

                    /**
                     * Verifies an OperationMetadata message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates an OperationMetadata message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns OperationMetadata
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.OperationMetadata;

                    /**
                     * Creates a plain object from an OperationMetadata message. Also converts values to other types if specified.
                     * @param message OperationMetadata
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.OperationMetadata, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this OperationMetadata to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of a GetVulnzOccurrencesSummaryRequest. */
                interface IGetVulnzOccurrencesSummaryRequest {

                    /** GetVulnzOccurrencesSummaryRequest parent */
                    parent?: (string|null);

                    /** GetVulnzOccurrencesSummaryRequest filter */
                    filter?: (string|null);
                }

                /** Represents a GetVulnzOccurrencesSummaryRequest. */
                class GetVulnzOccurrencesSummaryRequest implements IGetVulnzOccurrencesSummaryRequest {

                    /**
                     * Constructs a new GetVulnzOccurrencesSummaryRequest.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IGetVulnzOccurrencesSummaryRequest);

                    /** GetVulnzOccurrencesSummaryRequest parent. */
                    public parent: string;

                    /** GetVulnzOccurrencesSummaryRequest filter. */
                    public filter: string;

                    /**
                     * Creates a new GetVulnzOccurrencesSummaryRequest instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns GetVulnzOccurrencesSummaryRequest instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IGetVulnzOccurrencesSummaryRequest): google.devtools.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryRequest;

                    /**
                     * Encodes the specified GetVulnzOccurrencesSummaryRequest message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryRequest.verify|verify} messages.
                     * @param message GetVulnzOccurrencesSummaryRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IGetVulnzOccurrencesSummaryRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified GetVulnzOccurrencesSummaryRequest message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryRequest.verify|verify} messages.
                     * @param message GetVulnzOccurrencesSummaryRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IGetVulnzOccurrencesSummaryRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a GetVulnzOccurrencesSummaryRequest message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns GetVulnzOccurrencesSummaryRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryRequest;

                    /**
                     * Decodes a GetVulnzOccurrencesSummaryRequest message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns GetVulnzOccurrencesSummaryRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryRequest;

                    /**
                     * Verifies a GetVulnzOccurrencesSummaryRequest message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a GetVulnzOccurrencesSummaryRequest message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns GetVulnzOccurrencesSummaryRequest
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryRequest;

                    /**
                     * Creates a plain object from a GetVulnzOccurrencesSummaryRequest message. Also converts values to other types if specified.
                     * @param message GetVulnzOccurrencesSummaryRequest
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryRequest, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this GetVulnzOccurrencesSummaryRequest to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of a GetVulnzOccurrencesSummaryResponse. */
                interface IGetVulnzOccurrencesSummaryResponse {

                    /** GetVulnzOccurrencesSummaryResponse counts */
                    counts?: (google.devtools.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryResponse.ISeverityCount[]|null);
                }

                /** Represents a GetVulnzOccurrencesSummaryResponse. */
                class GetVulnzOccurrencesSummaryResponse implements IGetVulnzOccurrencesSummaryResponse {

                    /**
                     * Constructs a new GetVulnzOccurrencesSummaryResponse.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IGetVulnzOccurrencesSummaryResponse);

                    /** GetVulnzOccurrencesSummaryResponse counts. */
                    public counts: google.devtools.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryResponse.ISeverityCount[];

                    /**
                     * Creates a new GetVulnzOccurrencesSummaryResponse instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns GetVulnzOccurrencesSummaryResponse instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IGetVulnzOccurrencesSummaryResponse): google.devtools.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryResponse;

                    /**
                     * Encodes the specified GetVulnzOccurrencesSummaryResponse message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryResponse.verify|verify} messages.
                     * @param message GetVulnzOccurrencesSummaryResponse message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IGetVulnzOccurrencesSummaryResponse, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified GetVulnzOccurrencesSummaryResponse message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryResponse.verify|verify} messages.
                     * @param message GetVulnzOccurrencesSummaryResponse message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IGetVulnzOccurrencesSummaryResponse, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a GetVulnzOccurrencesSummaryResponse message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns GetVulnzOccurrencesSummaryResponse
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryResponse;

                    /**
                     * Decodes a GetVulnzOccurrencesSummaryResponse message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns GetVulnzOccurrencesSummaryResponse
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryResponse;

                    /**
                     * Verifies a GetVulnzOccurrencesSummaryResponse message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a GetVulnzOccurrencesSummaryResponse message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns GetVulnzOccurrencesSummaryResponse
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryResponse;

                    /**
                     * Creates a plain object from a GetVulnzOccurrencesSummaryResponse message. Also converts values to other types if specified.
                     * @param message GetVulnzOccurrencesSummaryResponse
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryResponse, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this GetVulnzOccurrencesSummaryResponse to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                namespace GetVulnzOccurrencesSummaryResponse {

                    /** Properties of a SeverityCount. */
                    interface ISeverityCount {

                        /** SeverityCount severity */
                        severity?: (google.devtools.containeranalysis.v1alpha1.VulnerabilityType.Severity|null);

                        /** SeverityCount count */
                        count?: (number|Long|null);
                    }

                    /** Represents a SeverityCount. */
                    class SeverityCount implements ISeverityCount {

                        /**
                         * Constructs a new SeverityCount.
                         * @param [properties] Properties to set
                         */
                        constructor(properties?: google.devtools.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryResponse.ISeverityCount);

                        /** SeverityCount severity. */
                        public severity: google.devtools.containeranalysis.v1alpha1.VulnerabilityType.Severity;

                        /** SeverityCount count. */
                        public count: (number|Long);

                        /**
                         * Creates a new SeverityCount instance using the specified properties.
                         * @param [properties] Properties to set
                         * @returns SeverityCount instance
                         */
                        public static create(properties?: google.devtools.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryResponse.ISeverityCount): google.devtools.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryResponse.SeverityCount;

                        /**
                         * Encodes the specified SeverityCount message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryResponse.SeverityCount.verify|verify} messages.
                         * @param message SeverityCount message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encode(message: google.devtools.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryResponse.ISeverityCount, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Encodes the specified SeverityCount message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryResponse.SeverityCount.verify|verify} messages.
                         * @param message SeverityCount message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryResponse.ISeverityCount, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Decodes a SeverityCount message from the specified reader or buffer.
                         * @param reader Reader or buffer to decode from
                         * @param [length] Message length if known beforehand
                         * @returns SeverityCount
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryResponse.SeverityCount;

                        /**
                         * Decodes a SeverityCount message from the specified reader or buffer, length delimited.
                         * @param reader Reader or buffer to decode from
                         * @returns SeverityCount
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryResponse.SeverityCount;

                        /**
                         * Verifies a SeverityCount message.
                         * @param message Plain object to verify
                         * @returns `null` if valid, otherwise the reason why it is not
                         */
                        public static verify(message: { [k: string]: any }): (string|null);

                        /**
                         * Creates a SeverityCount message from a plain object. Also converts values to their respective internal types.
                         * @param object Plain object
                         * @returns SeverityCount
                         */
                        public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryResponse.SeverityCount;

                        /**
                         * Creates a plain object from a SeverityCount message. Also converts values to other types if specified.
                         * @param message SeverityCount
                         * @param [options] Conversion options
                         * @returns Plain object
                         */
                        public static toObject(message: google.devtools.containeranalysis.v1alpha1.GetVulnzOccurrencesSummaryResponse.SeverityCount, options?: $protobuf.IConversionOptions): { [k: string]: any };

                        /**
                         * Converts this SeverityCount to JSON.
                         * @returns JSON object
                         */
                        public toJSON(): { [k: string]: any };
                    }
                }

                /** Properties of a GetScanConfigRequest. */
                interface IGetScanConfigRequest {

                    /** GetScanConfigRequest name */
                    name?: (string|null);
                }

                /** Represents a GetScanConfigRequest. */
                class GetScanConfigRequest implements IGetScanConfigRequest {

                    /**
                     * Constructs a new GetScanConfigRequest.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IGetScanConfigRequest);

                    /** GetScanConfigRequest name. */
                    public name: string;

                    /**
                     * Creates a new GetScanConfigRequest instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns GetScanConfigRequest instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IGetScanConfigRequest): google.devtools.containeranalysis.v1alpha1.GetScanConfigRequest;

                    /**
                     * Encodes the specified GetScanConfigRequest message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.GetScanConfigRequest.verify|verify} messages.
                     * @param message GetScanConfigRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IGetScanConfigRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified GetScanConfigRequest message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.GetScanConfigRequest.verify|verify} messages.
                     * @param message GetScanConfigRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IGetScanConfigRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a GetScanConfigRequest message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns GetScanConfigRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.GetScanConfigRequest;

                    /**
                     * Decodes a GetScanConfigRequest message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns GetScanConfigRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.GetScanConfigRequest;

                    /**
                     * Verifies a GetScanConfigRequest message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a GetScanConfigRequest message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns GetScanConfigRequest
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.GetScanConfigRequest;

                    /**
                     * Creates a plain object from a GetScanConfigRequest message. Also converts values to other types if specified.
                     * @param message GetScanConfigRequest
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.GetScanConfigRequest, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this GetScanConfigRequest to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of a ListScanConfigsRequest. */
                interface IListScanConfigsRequest {

                    /** ListScanConfigsRequest parent */
                    parent?: (string|null);

                    /** ListScanConfigsRequest filter */
                    filter?: (string|null);

                    /** ListScanConfigsRequest pageSize */
                    pageSize?: (number|null);

                    /** ListScanConfigsRequest pageToken */
                    pageToken?: (string|null);
                }

                /** Represents a ListScanConfigsRequest. */
                class ListScanConfigsRequest implements IListScanConfigsRequest {

                    /**
                     * Constructs a new ListScanConfigsRequest.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IListScanConfigsRequest);

                    /** ListScanConfigsRequest parent. */
                    public parent: string;

                    /** ListScanConfigsRequest filter. */
                    public filter: string;

                    /** ListScanConfigsRequest pageSize. */
                    public pageSize: number;

                    /** ListScanConfigsRequest pageToken. */
                    public pageToken: string;

                    /**
                     * Creates a new ListScanConfigsRequest instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns ListScanConfigsRequest instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IListScanConfigsRequest): google.devtools.containeranalysis.v1alpha1.ListScanConfigsRequest;

                    /**
                     * Encodes the specified ListScanConfigsRequest message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.ListScanConfigsRequest.verify|verify} messages.
                     * @param message ListScanConfigsRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IListScanConfigsRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified ListScanConfigsRequest message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.ListScanConfigsRequest.verify|verify} messages.
                     * @param message ListScanConfigsRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IListScanConfigsRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a ListScanConfigsRequest message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns ListScanConfigsRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.ListScanConfigsRequest;

                    /**
                     * Decodes a ListScanConfigsRequest message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns ListScanConfigsRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.ListScanConfigsRequest;

                    /**
                     * Verifies a ListScanConfigsRequest message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a ListScanConfigsRequest message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns ListScanConfigsRequest
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.ListScanConfigsRequest;

                    /**
                     * Creates a plain object from a ListScanConfigsRequest message. Also converts values to other types if specified.
                     * @param message ListScanConfigsRequest
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.ListScanConfigsRequest, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this ListScanConfigsRequest to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of a ListScanConfigsResponse. */
                interface IListScanConfigsResponse {

                    /** ListScanConfigsResponse scanConfigs */
                    scanConfigs?: (google.devtools.containeranalysis.v1alpha1.IScanConfig[]|null);

                    /** ListScanConfigsResponse nextPageToken */
                    nextPageToken?: (string|null);
                }

                /** Represents a ListScanConfigsResponse. */
                class ListScanConfigsResponse implements IListScanConfigsResponse {

                    /**
                     * Constructs a new ListScanConfigsResponse.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IListScanConfigsResponse);

                    /** ListScanConfigsResponse scanConfigs. */
                    public scanConfigs: google.devtools.containeranalysis.v1alpha1.IScanConfig[];

                    /** ListScanConfigsResponse nextPageToken. */
                    public nextPageToken: string;

                    /**
                     * Creates a new ListScanConfigsResponse instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns ListScanConfigsResponse instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IListScanConfigsResponse): google.devtools.containeranalysis.v1alpha1.ListScanConfigsResponse;

                    /**
                     * Encodes the specified ListScanConfigsResponse message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.ListScanConfigsResponse.verify|verify} messages.
                     * @param message ListScanConfigsResponse message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IListScanConfigsResponse, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified ListScanConfigsResponse message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.ListScanConfigsResponse.verify|verify} messages.
                     * @param message ListScanConfigsResponse message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IListScanConfigsResponse, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a ListScanConfigsResponse message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns ListScanConfigsResponse
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.ListScanConfigsResponse;

                    /**
                     * Decodes a ListScanConfigsResponse message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns ListScanConfigsResponse
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.ListScanConfigsResponse;

                    /**
                     * Verifies a ListScanConfigsResponse message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a ListScanConfigsResponse message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns ListScanConfigsResponse
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.ListScanConfigsResponse;

                    /**
                     * Creates a plain object from a ListScanConfigsResponse message. Also converts values to other types if specified.
                     * @param message ListScanConfigsResponse
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.ListScanConfigsResponse, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this ListScanConfigsResponse to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of an UpdateScanConfigRequest. */
                interface IUpdateScanConfigRequest {

                    /** UpdateScanConfigRequest name */
                    name?: (string|null);

                    /** UpdateScanConfigRequest scanConfig */
                    scanConfig?: (google.devtools.containeranalysis.v1alpha1.IScanConfig|null);

                    /** UpdateScanConfigRequest updateMask */
                    updateMask?: (google.protobuf.IFieldMask|null);
                }

                /** Represents an UpdateScanConfigRequest. */
                class UpdateScanConfigRequest implements IUpdateScanConfigRequest {

                    /**
                     * Constructs a new UpdateScanConfigRequest.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IUpdateScanConfigRequest);

                    /** UpdateScanConfigRequest name. */
                    public name: string;

                    /** UpdateScanConfigRequest scanConfig. */
                    public scanConfig?: (google.devtools.containeranalysis.v1alpha1.IScanConfig|null);

                    /** UpdateScanConfigRequest updateMask. */
                    public updateMask?: (google.protobuf.IFieldMask|null);

                    /**
                     * Creates a new UpdateScanConfigRequest instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns UpdateScanConfigRequest instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IUpdateScanConfigRequest): google.devtools.containeranalysis.v1alpha1.UpdateScanConfigRequest;

                    /**
                     * Encodes the specified UpdateScanConfigRequest message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.UpdateScanConfigRequest.verify|verify} messages.
                     * @param message UpdateScanConfigRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IUpdateScanConfigRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified UpdateScanConfigRequest message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.UpdateScanConfigRequest.verify|verify} messages.
                     * @param message UpdateScanConfigRequest message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IUpdateScanConfigRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes an UpdateScanConfigRequest message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns UpdateScanConfigRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.UpdateScanConfigRequest;

                    /**
                     * Decodes an UpdateScanConfigRequest message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns UpdateScanConfigRequest
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.UpdateScanConfigRequest;

                    /**
                     * Verifies an UpdateScanConfigRequest message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates an UpdateScanConfigRequest message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns UpdateScanConfigRequest
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.UpdateScanConfigRequest;

                    /**
                     * Creates a plain object from an UpdateScanConfigRequest message. Also converts values to other types if specified.
                     * @param message UpdateScanConfigRequest
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.UpdateScanConfigRequest, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this UpdateScanConfigRequest to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of a PackageManager. */
                interface IPackageManager {
                }

                /** Represents a PackageManager. */
                class PackageManager implements IPackageManager {

                    /**
                     * Constructs a new PackageManager.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IPackageManager);

                    /**
                     * Creates a new PackageManager instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns PackageManager instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IPackageManager): google.devtools.containeranalysis.v1alpha1.PackageManager;

                    /**
                     * Encodes the specified PackageManager message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.PackageManager.verify|verify} messages.
                     * @param message PackageManager message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IPackageManager, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified PackageManager message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.PackageManager.verify|verify} messages.
                     * @param message PackageManager message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IPackageManager, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a PackageManager message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns PackageManager
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.PackageManager;

                    /**
                     * Decodes a PackageManager message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns PackageManager
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.PackageManager;

                    /**
                     * Verifies a PackageManager message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a PackageManager message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns PackageManager
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.PackageManager;

                    /**
                     * Creates a plain object from a PackageManager message. Also converts values to other types if specified.
                     * @param message PackageManager
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.PackageManager, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this PackageManager to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                namespace PackageManager {

                    /** Properties of a Distribution. */
                    interface IDistribution {

                        /** Distribution cpeUri */
                        cpeUri?: (string|null);

                        /** Distribution architecture */
                        architecture?: (google.devtools.containeranalysis.v1alpha1.PackageManager.Architecture|null);

                        /** Distribution latestVersion */
                        latestVersion?: (google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IVersion|null);

                        /** Distribution maintainer */
                        maintainer?: (string|null);

                        /** Distribution url */
                        url?: (string|null);

                        /** Distribution description */
                        description?: (string|null);
                    }

                    /** Represents a Distribution. */
                    class Distribution implements IDistribution {

                        /**
                         * Constructs a new Distribution.
                         * @param [properties] Properties to set
                         */
                        constructor(properties?: google.devtools.containeranalysis.v1alpha1.PackageManager.IDistribution);

                        /** Distribution cpeUri. */
                        public cpeUri: string;

                        /** Distribution architecture. */
                        public architecture: google.devtools.containeranalysis.v1alpha1.PackageManager.Architecture;

                        /** Distribution latestVersion. */
                        public latestVersion?: (google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IVersion|null);

                        /** Distribution maintainer. */
                        public maintainer: string;

                        /** Distribution url. */
                        public url: string;

                        /** Distribution description. */
                        public description: string;

                        /**
                         * Creates a new Distribution instance using the specified properties.
                         * @param [properties] Properties to set
                         * @returns Distribution instance
                         */
                        public static create(properties?: google.devtools.containeranalysis.v1alpha1.PackageManager.IDistribution): google.devtools.containeranalysis.v1alpha1.PackageManager.Distribution;

                        /**
                         * Encodes the specified Distribution message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.PackageManager.Distribution.verify|verify} messages.
                         * @param message Distribution message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encode(message: google.devtools.containeranalysis.v1alpha1.PackageManager.IDistribution, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Encodes the specified Distribution message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.PackageManager.Distribution.verify|verify} messages.
                         * @param message Distribution message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.PackageManager.IDistribution, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Decodes a Distribution message from the specified reader or buffer.
                         * @param reader Reader or buffer to decode from
                         * @param [length] Message length if known beforehand
                         * @returns Distribution
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.PackageManager.Distribution;

                        /**
                         * Decodes a Distribution message from the specified reader or buffer, length delimited.
                         * @param reader Reader or buffer to decode from
                         * @returns Distribution
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.PackageManager.Distribution;

                        /**
                         * Verifies a Distribution message.
                         * @param message Plain object to verify
                         * @returns `null` if valid, otherwise the reason why it is not
                         */
                        public static verify(message: { [k: string]: any }): (string|null);

                        /**
                         * Creates a Distribution message from a plain object. Also converts values to their respective internal types.
                         * @param object Plain object
                         * @returns Distribution
                         */
                        public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.PackageManager.Distribution;

                        /**
                         * Creates a plain object from a Distribution message. Also converts values to other types if specified.
                         * @param message Distribution
                         * @param [options] Conversion options
                         * @returns Plain object
                         */
                        public static toObject(message: google.devtools.containeranalysis.v1alpha1.PackageManager.Distribution, options?: $protobuf.IConversionOptions): { [k: string]: any };

                        /**
                         * Converts this Distribution to JSON.
                         * @returns JSON object
                         */
                        public toJSON(): { [k: string]: any };
                    }

                    /** Properties of a Location. */
                    interface ILocation {

                        /** Location cpeUri */
                        cpeUri?: (string|null);

                        /** Location version */
                        version?: (google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IVersion|null);

                        /** Location path */
                        path?: (string|null);
                    }

                    /** Represents a Location. */
                    class Location implements ILocation {

                        /**
                         * Constructs a new Location.
                         * @param [properties] Properties to set
                         */
                        constructor(properties?: google.devtools.containeranalysis.v1alpha1.PackageManager.ILocation);

                        /** Location cpeUri. */
                        public cpeUri: string;

                        /** Location version. */
                        public version?: (google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IVersion|null);

                        /** Location path. */
                        public path: string;

                        /**
                         * Creates a new Location instance using the specified properties.
                         * @param [properties] Properties to set
                         * @returns Location instance
                         */
                        public static create(properties?: google.devtools.containeranalysis.v1alpha1.PackageManager.ILocation): google.devtools.containeranalysis.v1alpha1.PackageManager.Location;

                        /**
                         * Encodes the specified Location message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.PackageManager.Location.verify|verify} messages.
                         * @param message Location message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encode(message: google.devtools.containeranalysis.v1alpha1.PackageManager.ILocation, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Encodes the specified Location message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.PackageManager.Location.verify|verify} messages.
                         * @param message Location message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.PackageManager.ILocation, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Decodes a Location message from the specified reader or buffer.
                         * @param reader Reader or buffer to decode from
                         * @param [length] Message length if known beforehand
                         * @returns Location
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.PackageManager.Location;

                        /**
                         * Decodes a Location message from the specified reader or buffer, length delimited.
                         * @param reader Reader or buffer to decode from
                         * @returns Location
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.PackageManager.Location;

                        /**
                         * Verifies a Location message.
                         * @param message Plain object to verify
                         * @returns `null` if valid, otherwise the reason why it is not
                         */
                        public static verify(message: { [k: string]: any }): (string|null);

                        /**
                         * Creates a Location message from a plain object. Also converts values to their respective internal types.
                         * @param object Plain object
                         * @returns Location
                         */
                        public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.PackageManager.Location;

                        /**
                         * Creates a plain object from a Location message. Also converts values to other types if specified.
                         * @param message Location
                         * @param [options] Conversion options
                         * @returns Plain object
                         */
                        public static toObject(message: google.devtools.containeranalysis.v1alpha1.PackageManager.Location, options?: $protobuf.IConversionOptions): { [k: string]: any };

                        /**
                         * Converts this Location to JSON.
                         * @returns JSON object
                         */
                        public toJSON(): { [k: string]: any };
                    }

                    /** Properties of a Package. */
                    interface IPackage {

                        /** Package name */
                        name?: (string|null);

                        /** Package distribution */
                        distribution?: (google.devtools.containeranalysis.v1alpha1.PackageManager.IDistribution[]|null);
                    }

                    /** Represents a Package. */
                    class Package implements IPackage {

                        /**
                         * Constructs a new Package.
                         * @param [properties] Properties to set
                         */
                        constructor(properties?: google.devtools.containeranalysis.v1alpha1.PackageManager.IPackage);

                        /** Package name. */
                        public name: string;

                        /** Package distribution. */
                        public distribution: google.devtools.containeranalysis.v1alpha1.PackageManager.IDistribution[];

                        /**
                         * Creates a new Package instance using the specified properties.
                         * @param [properties] Properties to set
                         * @returns Package instance
                         */
                        public static create(properties?: google.devtools.containeranalysis.v1alpha1.PackageManager.IPackage): google.devtools.containeranalysis.v1alpha1.PackageManager.Package;

                        /**
                         * Encodes the specified Package message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.PackageManager.Package.verify|verify} messages.
                         * @param message Package message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encode(message: google.devtools.containeranalysis.v1alpha1.PackageManager.IPackage, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Encodes the specified Package message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.PackageManager.Package.verify|verify} messages.
                         * @param message Package message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.PackageManager.IPackage, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Decodes a Package message from the specified reader or buffer.
                         * @param reader Reader or buffer to decode from
                         * @param [length] Message length if known beforehand
                         * @returns Package
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.PackageManager.Package;

                        /**
                         * Decodes a Package message from the specified reader or buffer, length delimited.
                         * @param reader Reader or buffer to decode from
                         * @returns Package
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.PackageManager.Package;

                        /**
                         * Verifies a Package message.
                         * @param message Plain object to verify
                         * @returns `null` if valid, otherwise the reason why it is not
                         */
                        public static verify(message: { [k: string]: any }): (string|null);

                        /**
                         * Creates a Package message from a plain object. Also converts values to their respective internal types.
                         * @param object Plain object
                         * @returns Package
                         */
                        public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.PackageManager.Package;

                        /**
                         * Creates a plain object from a Package message. Also converts values to other types if specified.
                         * @param message Package
                         * @param [options] Conversion options
                         * @returns Plain object
                         */
                        public static toObject(message: google.devtools.containeranalysis.v1alpha1.PackageManager.Package, options?: $protobuf.IConversionOptions): { [k: string]: any };

                        /**
                         * Converts this Package to JSON.
                         * @returns JSON object
                         */
                        public toJSON(): { [k: string]: any };
                    }

                    /** Properties of an Installation. */
                    interface IInstallation {

                        /** Installation name */
                        name?: (string|null);

                        /** Installation location */
                        location?: (google.devtools.containeranalysis.v1alpha1.PackageManager.ILocation[]|null);
                    }

                    /** Represents an Installation. */
                    class Installation implements IInstallation {

                        /**
                         * Constructs a new Installation.
                         * @param [properties] Properties to set
                         */
                        constructor(properties?: google.devtools.containeranalysis.v1alpha1.PackageManager.IInstallation);

                        /** Installation name. */
                        public name: string;

                        /** Installation location. */
                        public location: google.devtools.containeranalysis.v1alpha1.PackageManager.ILocation[];

                        /**
                         * Creates a new Installation instance using the specified properties.
                         * @param [properties] Properties to set
                         * @returns Installation instance
                         */
                        public static create(properties?: google.devtools.containeranalysis.v1alpha1.PackageManager.IInstallation): google.devtools.containeranalysis.v1alpha1.PackageManager.Installation;

                        /**
                         * Encodes the specified Installation message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.PackageManager.Installation.verify|verify} messages.
                         * @param message Installation message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encode(message: google.devtools.containeranalysis.v1alpha1.PackageManager.IInstallation, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Encodes the specified Installation message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.PackageManager.Installation.verify|verify} messages.
                         * @param message Installation message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.PackageManager.IInstallation, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Decodes an Installation message from the specified reader or buffer.
                         * @param reader Reader or buffer to decode from
                         * @param [length] Message length if known beforehand
                         * @returns Installation
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.PackageManager.Installation;

                        /**
                         * Decodes an Installation message from the specified reader or buffer, length delimited.
                         * @param reader Reader or buffer to decode from
                         * @returns Installation
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.PackageManager.Installation;

                        /**
                         * Verifies an Installation message.
                         * @param message Plain object to verify
                         * @returns `null` if valid, otherwise the reason why it is not
                         */
                        public static verify(message: { [k: string]: any }): (string|null);

                        /**
                         * Creates an Installation message from a plain object. Also converts values to their respective internal types.
                         * @param object Plain object
                         * @returns Installation
                         */
                        public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.PackageManager.Installation;

                        /**
                         * Creates a plain object from an Installation message. Also converts values to other types if specified.
                         * @param message Installation
                         * @param [options] Conversion options
                         * @returns Plain object
                         */
                        public static toObject(message: google.devtools.containeranalysis.v1alpha1.PackageManager.Installation, options?: $protobuf.IConversionOptions): { [k: string]: any };

                        /**
                         * Converts this Installation to JSON.
                         * @returns JSON object
                         */
                        public toJSON(): { [k: string]: any };
                    }

                    /** Architecture enum. */
                    enum Architecture {
                        ARCHITECTURE_UNSPECIFIED = 0,
                        X86 = 1,
                        X64 = 2
                    }
                }

                /** Properties of a VulnerabilityType. */
                interface IVulnerabilityType {

                    /** VulnerabilityType cvssScore */
                    cvssScore?: (number|null);

                    /** VulnerabilityType severity */
                    severity?: (google.devtools.containeranalysis.v1alpha1.VulnerabilityType.Severity|null);

                    /** VulnerabilityType details */
                    details?: (google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IDetail[]|null);
                }

                /** Represents a VulnerabilityType. */
                class VulnerabilityType implements IVulnerabilityType {

                    /**
                     * Constructs a new VulnerabilityType.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IVulnerabilityType);

                    /** VulnerabilityType cvssScore. */
                    public cvssScore: number;

                    /** VulnerabilityType severity. */
                    public severity: google.devtools.containeranalysis.v1alpha1.VulnerabilityType.Severity;

                    /** VulnerabilityType details. */
                    public details: google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IDetail[];

                    /**
                     * Creates a new VulnerabilityType instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns VulnerabilityType instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IVulnerabilityType): google.devtools.containeranalysis.v1alpha1.VulnerabilityType;

                    /**
                     * Encodes the specified VulnerabilityType message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.VulnerabilityType.verify|verify} messages.
                     * @param message VulnerabilityType message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IVulnerabilityType, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified VulnerabilityType message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.VulnerabilityType.verify|verify} messages.
                     * @param message VulnerabilityType message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IVulnerabilityType, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a VulnerabilityType message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns VulnerabilityType
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.VulnerabilityType;

                    /**
                     * Decodes a VulnerabilityType message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns VulnerabilityType
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.VulnerabilityType;

                    /**
                     * Verifies a VulnerabilityType message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a VulnerabilityType message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns VulnerabilityType
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.VulnerabilityType;

                    /**
                     * Creates a plain object from a VulnerabilityType message. Also converts values to other types if specified.
                     * @param message VulnerabilityType
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.VulnerabilityType, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this VulnerabilityType to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                namespace VulnerabilityType {

                    /** Properties of a Version. */
                    interface IVersion {

                        /** Version epoch */
                        epoch?: (number|null);

                        /** Version name */
                        name?: (string|null);

                        /** Version revision */
                        revision?: (string|null);

                        /** Version kind */
                        kind?: (google.devtools.containeranalysis.v1alpha1.VulnerabilityType.Version.VersionKind|null);
                    }

                    /** Represents a Version. */
                    class Version implements IVersion {

                        /**
                         * Constructs a new Version.
                         * @param [properties] Properties to set
                         */
                        constructor(properties?: google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IVersion);

                        /** Version epoch. */
                        public epoch: number;

                        /** Version name. */
                        public name: string;

                        /** Version revision. */
                        public revision: string;

                        /** Version kind. */
                        public kind: google.devtools.containeranalysis.v1alpha1.VulnerabilityType.Version.VersionKind;

                        /**
                         * Creates a new Version instance using the specified properties.
                         * @param [properties] Properties to set
                         * @returns Version instance
                         */
                        public static create(properties?: google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IVersion): google.devtools.containeranalysis.v1alpha1.VulnerabilityType.Version;

                        /**
                         * Encodes the specified Version message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.VulnerabilityType.Version.verify|verify} messages.
                         * @param message Version message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encode(message: google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IVersion, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Encodes the specified Version message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.VulnerabilityType.Version.verify|verify} messages.
                         * @param message Version message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IVersion, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Decodes a Version message from the specified reader or buffer.
                         * @param reader Reader or buffer to decode from
                         * @param [length] Message length if known beforehand
                         * @returns Version
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.VulnerabilityType.Version;

                        /**
                         * Decodes a Version message from the specified reader or buffer, length delimited.
                         * @param reader Reader or buffer to decode from
                         * @returns Version
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.VulnerabilityType.Version;

                        /**
                         * Verifies a Version message.
                         * @param message Plain object to verify
                         * @returns `null` if valid, otherwise the reason why it is not
                         */
                        public static verify(message: { [k: string]: any }): (string|null);

                        /**
                         * Creates a Version message from a plain object. Also converts values to their respective internal types.
                         * @param object Plain object
                         * @returns Version
                         */
                        public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.VulnerabilityType.Version;

                        /**
                         * Creates a plain object from a Version message. Also converts values to other types if specified.
                         * @param message Version
                         * @param [options] Conversion options
                         * @returns Plain object
                         */
                        public static toObject(message: google.devtools.containeranalysis.v1alpha1.VulnerabilityType.Version, options?: $protobuf.IConversionOptions): { [k: string]: any };

                        /**
                         * Converts this Version to JSON.
                         * @returns JSON object
                         */
                        public toJSON(): { [k: string]: any };
                    }

                    namespace Version {

                        /** VersionKind enum. */
                        enum VersionKind {
                            NORMAL = 0,
                            MINIMUM = 1,
                            MAXIMUM = 2
                        }
                    }

                    /** Properties of a Detail. */
                    interface IDetail {

                        /** Detail cpeUri */
                        cpeUri?: (string|null);

                        /** Detail package */
                        "package"?: (string|null);

                        /** Detail minAffectedVersion */
                        minAffectedVersion?: (google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IVersion|null);

                        /** Detail maxAffectedVersion */
                        maxAffectedVersion?: (google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IVersion|null);

                        /** Detail severityName */
                        severityName?: (string|null);

                        /** Detail description */
                        description?: (string|null);

                        /** Detail fixedLocation */
                        fixedLocation?: (google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IVulnerabilityLocation|null);

                        /** Detail packageType */
                        packageType?: (string|null);

                        /** Detail isObsolete */
                        isObsolete?: (boolean|null);
                    }

                    /** Represents a Detail. */
                    class Detail implements IDetail {

                        /**
                         * Constructs a new Detail.
                         * @param [properties] Properties to set
                         */
                        constructor(properties?: google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IDetail);

                        /** Detail cpeUri. */
                        public cpeUri: string;

                        /** Detail package. */
                        public package: string;

                        /** Detail minAffectedVersion. */
                        public minAffectedVersion?: (google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IVersion|null);

                        /** Detail maxAffectedVersion. */
                        public maxAffectedVersion?: (google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IVersion|null);

                        /** Detail severityName. */
                        public severityName: string;

                        /** Detail description. */
                        public description: string;

                        /** Detail fixedLocation. */
                        public fixedLocation?: (google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IVulnerabilityLocation|null);

                        /** Detail packageType. */
                        public packageType: string;

                        /** Detail isObsolete. */
                        public isObsolete: boolean;

                        /**
                         * Creates a new Detail instance using the specified properties.
                         * @param [properties] Properties to set
                         * @returns Detail instance
                         */
                        public static create(properties?: google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IDetail): google.devtools.containeranalysis.v1alpha1.VulnerabilityType.Detail;

                        /**
                         * Encodes the specified Detail message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.VulnerabilityType.Detail.verify|verify} messages.
                         * @param message Detail message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encode(message: google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IDetail, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Encodes the specified Detail message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.VulnerabilityType.Detail.verify|verify} messages.
                         * @param message Detail message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IDetail, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Decodes a Detail message from the specified reader or buffer.
                         * @param reader Reader or buffer to decode from
                         * @param [length] Message length if known beforehand
                         * @returns Detail
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.VulnerabilityType.Detail;

                        /**
                         * Decodes a Detail message from the specified reader or buffer, length delimited.
                         * @param reader Reader or buffer to decode from
                         * @returns Detail
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.VulnerabilityType.Detail;

                        /**
                         * Verifies a Detail message.
                         * @param message Plain object to verify
                         * @returns `null` if valid, otherwise the reason why it is not
                         */
                        public static verify(message: { [k: string]: any }): (string|null);

                        /**
                         * Creates a Detail message from a plain object. Also converts values to their respective internal types.
                         * @param object Plain object
                         * @returns Detail
                         */
                        public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.VulnerabilityType.Detail;

                        /**
                         * Creates a plain object from a Detail message. Also converts values to other types if specified.
                         * @param message Detail
                         * @param [options] Conversion options
                         * @returns Plain object
                         */
                        public static toObject(message: google.devtools.containeranalysis.v1alpha1.VulnerabilityType.Detail, options?: $protobuf.IConversionOptions): { [k: string]: any };

                        /**
                         * Converts this Detail to JSON.
                         * @returns JSON object
                         */
                        public toJSON(): { [k: string]: any };
                    }

                    /** Properties of a VulnerabilityDetails. */
                    interface IVulnerabilityDetails {

                        /** VulnerabilityDetails type */
                        type?: (string|null);

                        /** VulnerabilityDetails severity */
                        severity?: (google.devtools.containeranalysis.v1alpha1.VulnerabilityType.Severity|null);

                        /** VulnerabilityDetails cvssScore */
                        cvssScore?: (number|null);

                        /** VulnerabilityDetails packageIssue */
                        packageIssue?: (google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IPackageIssue[]|null);
                    }

                    /** Represents a VulnerabilityDetails. */
                    class VulnerabilityDetails implements IVulnerabilityDetails {

                        /**
                         * Constructs a new VulnerabilityDetails.
                         * @param [properties] Properties to set
                         */
                        constructor(properties?: google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IVulnerabilityDetails);

                        /** VulnerabilityDetails type. */
                        public type: string;

                        /** VulnerabilityDetails severity. */
                        public severity: google.devtools.containeranalysis.v1alpha1.VulnerabilityType.Severity;

                        /** VulnerabilityDetails cvssScore. */
                        public cvssScore: number;

                        /** VulnerabilityDetails packageIssue. */
                        public packageIssue: google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IPackageIssue[];

                        /**
                         * Creates a new VulnerabilityDetails instance using the specified properties.
                         * @param [properties] Properties to set
                         * @returns VulnerabilityDetails instance
                         */
                        public static create(properties?: google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IVulnerabilityDetails): google.devtools.containeranalysis.v1alpha1.VulnerabilityType.VulnerabilityDetails;

                        /**
                         * Encodes the specified VulnerabilityDetails message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.VulnerabilityType.VulnerabilityDetails.verify|verify} messages.
                         * @param message VulnerabilityDetails message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encode(message: google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IVulnerabilityDetails, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Encodes the specified VulnerabilityDetails message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.VulnerabilityType.VulnerabilityDetails.verify|verify} messages.
                         * @param message VulnerabilityDetails message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IVulnerabilityDetails, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Decodes a VulnerabilityDetails message from the specified reader or buffer.
                         * @param reader Reader or buffer to decode from
                         * @param [length] Message length if known beforehand
                         * @returns VulnerabilityDetails
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.VulnerabilityType.VulnerabilityDetails;

                        /**
                         * Decodes a VulnerabilityDetails message from the specified reader or buffer, length delimited.
                         * @param reader Reader or buffer to decode from
                         * @returns VulnerabilityDetails
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.VulnerabilityType.VulnerabilityDetails;

                        /**
                         * Verifies a VulnerabilityDetails message.
                         * @param message Plain object to verify
                         * @returns `null` if valid, otherwise the reason why it is not
                         */
                        public static verify(message: { [k: string]: any }): (string|null);

                        /**
                         * Creates a VulnerabilityDetails message from a plain object. Also converts values to their respective internal types.
                         * @param object Plain object
                         * @returns VulnerabilityDetails
                         */
                        public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.VulnerabilityType.VulnerabilityDetails;

                        /**
                         * Creates a plain object from a VulnerabilityDetails message. Also converts values to other types if specified.
                         * @param message VulnerabilityDetails
                         * @param [options] Conversion options
                         * @returns Plain object
                         */
                        public static toObject(message: google.devtools.containeranalysis.v1alpha1.VulnerabilityType.VulnerabilityDetails, options?: $protobuf.IConversionOptions): { [k: string]: any };

                        /**
                         * Converts this VulnerabilityDetails to JSON.
                         * @returns JSON object
                         */
                        public toJSON(): { [k: string]: any };
                    }

                    /** Properties of a PackageIssue. */
                    interface IPackageIssue {

                        /** PackageIssue affectedLocation */
                        affectedLocation?: (google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IVulnerabilityLocation|null);

                        /** PackageIssue fixedLocation */
                        fixedLocation?: (google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IVulnerabilityLocation|null);

                        /** PackageIssue severityName */
                        severityName?: (string|null);
                    }

                    /** Represents a PackageIssue. */
                    class PackageIssue implements IPackageIssue {

                        /**
                         * Constructs a new PackageIssue.
                         * @param [properties] Properties to set
                         */
                        constructor(properties?: google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IPackageIssue);

                        /** PackageIssue affectedLocation. */
                        public affectedLocation?: (google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IVulnerabilityLocation|null);

                        /** PackageIssue fixedLocation. */
                        public fixedLocation?: (google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IVulnerabilityLocation|null);

                        /** PackageIssue severityName. */
                        public severityName: string;

                        /**
                         * Creates a new PackageIssue instance using the specified properties.
                         * @param [properties] Properties to set
                         * @returns PackageIssue instance
                         */
                        public static create(properties?: google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IPackageIssue): google.devtools.containeranalysis.v1alpha1.VulnerabilityType.PackageIssue;

                        /**
                         * Encodes the specified PackageIssue message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.VulnerabilityType.PackageIssue.verify|verify} messages.
                         * @param message PackageIssue message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encode(message: google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IPackageIssue, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Encodes the specified PackageIssue message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.VulnerabilityType.PackageIssue.verify|verify} messages.
                         * @param message PackageIssue message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IPackageIssue, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Decodes a PackageIssue message from the specified reader or buffer.
                         * @param reader Reader or buffer to decode from
                         * @param [length] Message length if known beforehand
                         * @returns PackageIssue
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.VulnerabilityType.PackageIssue;

                        /**
                         * Decodes a PackageIssue message from the specified reader or buffer, length delimited.
                         * @param reader Reader or buffer to decode from
                         * @returns PackageIssue
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.VulnerabilityType.PackageIssue;

                        /**
                         * Verifies a PackageIssue message.
                         * @param message Plain object to verify
                         * @returns `null` if valid, otherwise the reason why it is not
                         */
                        public static verify(message: { [k: string]: any }): (string|null);

                        /**
                         * Creates a PackageIssue message from a plain object. Also converts values to their respective internal types.
                         * @param object Plain object
                         * @returns PackageIssue
                         */
                        public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.VulnerabilityType.PackageIssue;

                        /**
                         * Creates a plain object from a PackageIssue message. Also converts values to other types if specified.
                         * @param message PackageIssue
                         * @param [options] Conversion options
                         * @returns Plain object
                         */
                        public static toObject(message: google.devtools.containeranalysis.v1alpha1.VulnerabilityType.PackageIssue, options?: $protobuf.IConversionOptions): { [k: string]: any };

                        /**
                         * Converts this PackageIssue to JSON.
                         * @returns JSON object
                         */
                        public toJSON(): { [k: string]: any };
                    }

                    /** Properties of a VulnerabilityLocation. */
                    interface IVulnerabilityLocation {

                        /** VulnerabilityLocation cpeUri */
                        cpeUri?: (string|null);

                        /** VulnerabilityLocation package */
                        "package"?: (string|null);

                        /** VulnerabilityLocation version */
                        version?: (google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IVersion|null);
                    }

                    /** Represents a VulnerabilityLocation. */
                    class VulnerabilityLocation implements IVulnerabilityLocation {

                        /**
                         * Constructs a new VulnerabilityLocation.
                         * @param [properties] Properties to set
                         */
                        constructor(properties?: google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IVulnerabilityLocation);

                        /** VulnerabilityLocation cpeUri. */
                        public cpeUri: string;

                        /** VulnerabilityLocation package. */
                        public package: string;

                        /** VulnerabilityLocation version. */
                        public version?: (google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IVersion|null);

                        /**
                         * Creates a new VulnerabilityLocation instance using the specified properties.
                         * @param [properties] Properties to set
                         * @returns VulnerabilityLocation instance
                         */
                        public static create(properties?: google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IVulnerabilityLocation): google.devtools.containeranalysis.v1alpha1.VulnerabilityType.VulnerabilityLocation;

                        /**
                         * Encodes the specified VulnerabilityLocation message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.VulnerabilityType.VulnerabilityLocation.verify|verify} messages.
                         * @param message VulnerabilityLocation message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encode(message: google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IVulnerabilityLocation, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Encodes the specified VulnerabilityLocation message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.VulnerabilityType.VulnerabilityLocation.verify|verify} messages.
                         * @param message VulnerabilityLocation message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.VulnerabilityType.IVulnerabilityLocation, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Decodes a VulnerabilityLocation message from the specified reader or buffer.
                         * @param reader Reader or buffer to decode from
                         * @param [length] Message length if known beforehand
                         * @returns VulnerabilityLocation
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.VulnerabilityType.VulnerabilityLocation;

                        /**
                         * Decodes a VulnerabilityLocation message from the specified reader or buffer, length delimited.
                         * @param reader Reader or buffer to decode from
                         * @returns VulnerabilityLocation
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.VulnerabilityType.VulnerabilityLocation;

                        /**
                         * Verifies a VulnerabilityLocation message.
                         * @param message Plain object to verify
                         * @returns `null` if valid, otherwise the reason why it is not
                         */
                        public static verify(message: { [k: string]: any }): (string|null);

                        /**
                         * Creates a VulnerabilityLocation message from a plain object. Also converts values to their respective internal types.
                         * @param object Plain object
                         * @returns VulnerabilityLocation
                         */
                        public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.VulnerabilityType.VulnerabilityLocation;

                        /**
                         * Creates a plain object from a VulnerabilityLocation message. Also converts values to other types if specified.
                         * @param message VulnerabilityLocation
                         * @param [options] Conversion options
                         * @returns Plain object
                         */
                        public static toObject(message: google.devtools.containeranalysis.v1alpha1.VulnerabilityType.VulnerabilityLocation, options?: $protobuf.IConversionOptions): { [k: string]: any };

                        /**
                         * Converts this VulnerabilityLocation to JSON.
                         * @returns JSON object
                         */
                        public toJSON(): { [k: string]: any };
                    }

                    /** Severity enum. */
                    enum Severity {
                        SEVERITY_UNSPECIFIED = 0,
                        MINIMAL = 1,
                        LOW = 2,
                        MEDIUM = 3,
                        HIGH = 4,
                        CRITICAL = 5
                    }
                }

                /** Properties of a DockerImage. */
                interface IDockerImage {
                }

                /** Represents a DockerImage. */
                class DockerImage implements IDockerImage {

                    /**
                     * Constructs a new DockerImage.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IDockerImage);

                    /**
                     * Creates a new DockerImage instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns DockerImage instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IDockerImage): google.devtools.containeranalysis.v1alpha1.DockerImage;

                    /**
                     * Encodes the specified DockerImage message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.DockerImage.verify|verify} messages.
                     * @param message DockerImage message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IDockerImage, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified DockerImage message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.DockerImage.verify|verify} messages.
                     * @param message DockerImage message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IDockerImage, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a DockerImage message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns DockerImage
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.DockerImage;

                    /**
                     * Decodes a DockerImage message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns DockerImage
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.DockerImage;

                    /**
                     * Verifies a DockerImage message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a DockerImage message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns DockerImage
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.DockerImage;

                    /**
                     * Creates a plain object from a DockerImage message. Also converts values to other types if specified.
                     * @param message DockerImage
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.DockerImage, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this DockerImage to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                namespace DockerImage {

                    /** Properties of a Layer. */
                    interface ILayer {

                        /** Layer directive */
                        directive?: (google.devtools.containeranalysis.v1alpha1.DockerImage.Layer.Directive|null);

                        /** Layer arguments */
                        "arguments"?: (string|null);
                    }

                    /** Represents a Layer. */
                    class Layer implements ILayer {

                        /**
                         * Constructs a new Layer.
                         * @param [properties] Properties to set
                         */
                        constructor(properties?: google.devtools.containeranalysis.v1alpha1.DockerImage.ILayer);

                        /** Layer directive. */
                        public directive: google.devtools.containeranalysis.v1alpha1.DockerImage.Layer.Directive;

                        /** Layer arguments. */
                        public arguments: string;

                        /**
                         * Creates a new Layer instance using the specified properties.
                         * @param [properties] Properties to set
                         * @returns Layer instance
                         */
                        public static create(properties?: google.devtools.containeranalysis.v1alpha1.DockerImage.ILayer): google.devtools.containeranalysis.v1alpha1.DockerImage.Layer;

                        /**
                         * Encodes the specified Layer message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.DockerImage.Layer.verify|verify} messages.
                         * @param message Layer message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encode(message: google.devtools.containeranalysis.v1alpha1.DockerImage.ILayer, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Encodes the specified Layer message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.DockerImage.Layer.verify|verify} messages.
                         * @param message Layer message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.DockerImage.ILayer, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Decodes a Layer message from the specified reader or buffer.
                         * @param reader Reader or buffer to decode from
                         * @param [length] Message length if known beforehand
                         * @returns Layer
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.DockerImage.Layer;

                        /**
                         * Decodes a Layer message from the specified reader or buffer, length delimited.
                         * @param reader Reader or buffer to decode from
                         * @returns Layer
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.DockerImage.Layer;

                        /**
                         * Verifies a Layer message.
                         * @param message Plain object to verify
                         * @returns `null` if valid, otherwise the reason why it is not
                         */
                        public static verify(message: { [k: string]: any }): (string|null);

                        /**
                         * Creates a Layer message from a plain object. Also converts values to their respective internal types.
                         * @param object Plain object
                         * @returns Layer
                         */
                        public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.DockerImage.Layer;

                        /**
                         * Creates a plain object from a Layer message. Also converts values to other types if specified.
                         * @param message Layer
                         * @param [options] Conversion options
                         * @returns Plain object
                         */
                        public static toObject(message: google.devtools.containeranalysis.v1alpha1.DockerImage.Layer, options?: $protobuf.IConversionOptions): { [k: string]: any };

                        /**
                         * Converts this Layer to JSON.
                         * @returns JSON object
                         */
                        public toJSON(): { [k: string]: any };
                    }

                    namespace Layer {

                        /** Directive enum. */
                        enum Directive {
                            DIRECTIVE_UNSPECIFIED = 0,
                            MAINTAINER = 1,
                            RUN = 2,
                            CMD = 3,
                            LABEL = 4,
                            EXPOSE = 5,
                            ENV = 6,
                            ADD = 7,
                            COPY = 8,
                            ENTRYPOINT = 9,
                            VOLUME = 10,
                            USER = 11,
                            WORKDIR = 12,
                            ARG = 13,
                            ONBUILD = 14,
                            STOPSIGNAL = 15,
                            HEALTHCHECK = 16,
                            SHELL = 17
                        }
                    }

                    /** Properties of a Fingerprint. */
                    interface IFingerprint {

                        /** Fingerprint v1Name */
                        v1Name?: (string|null);

                        /** Fingerprint v2Blob */
                        v2Blob?: (string[]|null);

                        /** Fingerprint v2Name */
                        v2Name?: (string|null);
                    }

                    /** Represents a Fingerprint. */
                    class Fingerprint implements IFingerprint {

                        /**
                         * Constructs a new Fingerprint.
                         * @param [properties] Properties to set
                         */
                        constructor(properties?: google.devtools.containeranalysis.v1alpha1.DockerImage.IFingerprint);

                        /** Fingerprint v1Name. */
                        public v1Name: string;

                        /** Fingerprint v2Blob. */
                        public v2Blob: string[];

                        /** Fingerprint v2Name. */
                        public v2Name: string;

                        /**
                         * Creates a new Fingerprint instance using the specified properties.
                         * @param [properties] Properties to set
                         * @returns Fingerprint instance
                         */
                        public static create(properties?: google.devtools.containeranalysis.v1alpha1.DockerImage.IFingerprint): google.devtools.containeranalysis.v1alpha1.DockerImage.Fingerprint;

                        /**
                         * Encodes the specified Fingerprint message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.DockerImage.Fingerprint.verify|verify} messages.
                         * @param message Fingerprint message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encode(message: google.devtools.containeranalysis.v1alpha1.DockerImage.IFingerprint, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Encodes the specified Fingerprint message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.DockerImage.Fingerprint.verify|verify} messages.
                         * @param message Fingerprint message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.DockerImage.IFingerprint, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Decodes a Fingerprint message from the specified reader or buffer.
                         * @param reader Reader or buffer to decode from
                         * @param [length] Message length if known beforehand
                         * @returns Fingerprint
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.DockerImage.Fingerprint;

                        /**
                         * Decodes a Fingerprint message from the specified reader or buffer, length delimited.
                         * @param reader Reader or buffer to decode from
                         * @returns Fingerprint
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.DockerImage.Fingerprint;

                        /**
                         * Verifies a Fingerprint message.
                         * @param message Plain object to verify
                         * @returns `null` if valid, otherwise the reason why it is not
                         */
                        public static verify(message: { [k: string]: any }): (string|null);

                        /**
                         * Creates a Fingerprint message from a plain object. Also converts values to their respective internal types.
                         * @param object Plain object
                         * @returns Fingerprint
                         */
                        public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.DockerImage.Fingerprint;

                        /**
                         * Creates a plain object from a Fingerprint message. Also converts values to other types if specified.
                         * @param message Fingerprint
                         * @param [options] Conversion options
                         * @returns Plain object
                         */
                        public static toObject(message: google.devtools.containeranalysis.v1alpha1.DockerImage.Fingerprint, options?: $protobuf.IConversionOptions): { [k: string]: any };

                        /**
                         * Converts this Fingerprint to JSON.
                         * @returns JSON object
                         */
                        public toJSON(): { [k: string]: any };
                    }

                    /** Properties of a Basis. */
                    interface IBasis {

                        /** Basis resourceUrl */
                        resourceUrl?: (string|null);

                        /** Basis fingerprint */
                        fingerprint?: (google.devtools.containeranalysis.v1alpha1.DockerImage.IFingerprint|null);
                    }

                    /** Represents a Basis. */
                    class Basis implements IBasis {

                        /**
                         * Constructs a new Basis.
                         * @param [properties] Properties to set
                         */
                        constructor(properties?: google.devtools.containeranalysis.v1alpha1.DockerImage.IBasis);

                        /** Basis resourceUrl. */
                        public resourceUrl: string;

                        /** Basis fingerprint. */
                        public fingerprint?: (google.devtools.containeranalysis.v1alpha1.DockerImage.IFingerprint|null);

                        /**
                         * Creates a new Basis instance using the specified properties.
                         * @param [properties] Properties to set
                         * @returns Basis instance
                         */
                        public static create(properties?: google.devtools.containeranalysis.v1alpha1.DockerImage.IBasis): google.devtools.containeranalysis.v1alpha1.DockerImage.Basis;

                        /**
                         * Encodes the specified Basis message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.DockerImage.Basis.verify|verify} messages.
                         * @param message Basis message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encode(message: google.devtools.containeranalysis.v1alpha1.DockerImage.IBasis, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Encodes the specified Basis message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.DockerImage.Basis.verify|verify} messages.
                         * @param message Basis message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.DockerImage.IBasis, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Decodes a Basis message from the specified reader or buffer.
                         * @param reader Reader or buffer to decode from
                         * @param [length] Message length if known beforehand
                         * @returns Basis
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.DockerImage.Basis;

                        /**
                         * Decodes a Basis message from the specified reader or buffer, length delimited.
                         * @param reader Reader or buffer to decode from
                         * @returns Basis
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.DockerImage.Basis;

                        /**
                         * Verifies a Basis message.
                         * @param message Plain object to verify
                         * @returns `null` if valid, otherwise the reason why it is not
                         */
                        public static verify(message: { [k: string]: any }): (string|null);

                        /**
                         * Creates a Basis message from a plain object. Also converts values to their respective internal types.
                         * @param object Plain object
                         * @returns Basis
                         */
                        public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.DockerImage.Basis;

                        /**
                         * Creates a plain object from a Basis message. Also converts values to other types if specified.
                         * @param message Basis
                         * @param [options] Conversion options
                         * @returns Plain object
                         */
                        public static toObject(message: google.devtools.containeranalysis.v1alpha1.DockerImage.Basis, options?: $protobuf.IConversionOptions): { [k: string]: any };

                        /**
                         * Converts this Basis to JSON.
                         * @returns JSON object
                         */
                        public toJSON(): { [k: string]: any };
                    }

                    /** Properties of a Derived. */
                    interface IDerived {

                        /** Derived fingerprint */
                        fingerprint?: (google.devtools.containeranalysis.v1alpha1.DockerImage.IFingerprint|null);

                        /** Derived distance */
                        distance?: (number|null);

                        /** Derived layerInfo */
                        layerInfo?: (google.devtools.containeranalysis.v1alpha1.DockerImage.ILayer[]|null);

                        /** Derived baseResourceUrl */
                        baseResourceUrl?: (string|null);
                    }

                    /** Represents a Derived. */
                    class Derived implements IDerived {

                        /**
                         * Constructs a new Derived.
                         * @param [properties] Properties to set
                         */
                        constructor(properties?: google.devtools.containeranalysis.v1alpha1.DockerImage.IDerived);

                        /** Derived fingerprint. */
                        public fingerprint?: (google.devtools.containeranalysis.v1alpha1.DockerImage.IFingerprint|null);

                        /** Derived distance. */
                        public distance: number;

                        /** Derived layerInfo. */
                        public layerInfo: google.devtools.containeranalysis.v1alpha1.DockerImage.ILayer[];

                        /** Derived baseResourceUrl. */
                        public baseResourceUrl: string;

                        /**
                         * Creates a new Derived instance using the specified properties.
                         * @param [properties] Properties to set
                         * @returns Derived instance
                         */
                        public static create(properties?: google.devtools.containeranalysis.v1alpha1.DockerImage.IDerived): google.devtools.containeranalysis.v1alpha1.DockerImage.Derived;

                        /**
                         * Encodes the specified Derived message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.DockerImage.Derived.verify|verify} messages.
                         * @param message Derived message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encode(message: google.devtools.containeranalysis.v1alpha1.DockerImage.IDerived, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Encodes the specified Derived message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.DockerImage.Derived.verify|verify} messages.
                         * @param message Derived message or plain object to encode
                         * @param [writer] Writer to encode to
                         * @returns Writer
                         */
                        public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.DockerImage.IDerived, writer?: $protobuf.Writer): $protobuf.Writer;

                        /**
                         * Decodes a Derived message from the specified reader or buffer.
                         * @param reader Reader or buffer to decode from
                         * @param [length] Message length if known beforehand
                         * @returns Derived
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.DockerImage.Derived;

                        /**
                         * Decodes a Derived message from the specified reader or buffer, length delimited.
                         * @param reader Reader or buffer to decode from
                         * @returns Derived
                         * @throws {Error} If the payload is not a reader or valid buffer
                         * @throws {$protobuf.util.ProtocolError} If required fields are missing
                         */
                        public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.DockerImage.Derived;

                        /**
                         * Verifies a Derived message.
                         * @param message Plain object to verify
                         * @returns `null` if valid, otherwise the reason why it is not
                         */
                        public static verify(message: { [k: string]: any }): (string|null);

                        /**
                         * Creates a Derived message from a plain object. Also converts values to their respective internal types.
                         * @param object Plain object
                         * @returns Derived
                         */
                        public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.DockerImage.Derived;

                        /**
                         * Creates a plain object from a Derived message. Also converts values to other types if specified.
                         * @param message Derived
                         * @param [options] Conversion options
                         * @returns Plain object
                         */
                        public static toObject(message: google.devtools.containeranalysis.v1alpha1.DockerImage.Derived, options?: $protobuf.IConversionOptions): { [k: string]: any };

                        /**
                         * Converts this Derived to JSON.
                         * @returns JSON object
                         */
                        public toJSON(): { [k: string]: any };
                    }
                }

                /** Properties of a BuildProvenance. */
                interface IBuildProvenance {

                    /** BuildProvenance id */
                    id?: (string|null);

                    /** BuildProvenance projectId */
                    projectId?: (string|null);

                    /** BuildProvenance commands */
                    commands?: (google.devtools.containeranalysis.v1alpha1.ICommand[]|null);

                    /** BuildProvenance builtArtifacts */
                    builtArtifacts?: (google.devtools.containeranalysis.v1alpha1.IArtifact[]|null);

                    /** BuildProvenance createTime */
                    createTime?: (google.protobuf.ITimestamp|null);

                    /** BuildProvenance startTime */
                    startTime?: (google.protobuf.ITimestamp|null);

                    /** BuildProvenance finishTime */
                    finishTime?: (google.protobuf.ITimestamp|null);

                    /** BuildProvenance creator */
                    creator?: (string|null);

                    /** BuildProvenance logsBucket */
                    logsBucket?: (string|null);

                    /** BuildProvenance sourceProvenance */
                    sourceProvenance?: (google.devtools.containeranalysis.v1alpha1.ISource|null);

                    /** BuildProvenance triggerId */
                    triggerId?: (string|null);

                    /** BuildProvenance buildOptions */
                    buildOptions?: ({ [k: string]: string }|null);

                    /** BuildProvenance builderVersion */
                    builderVersion?: (string|null);
                }

                /** Represents a BuildProvenance. */
                class BuildProvenance implements IBuildProvenance {

                    /**
                     * Constructs a new BuildProvenance.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IBuildProvenance);

                    /** BuildProvenance id. */
                    public id: string;

                    /** BuildProvenance projectId. */
                    public projectId: string;

                    /** BuildProvenance commands. */
                    public commands: google.devtools.containeranalysis.v1alpha1.ICommand[];

                    /** BuildProvenance builtArtifacts. */
                    public builtArtifacts: google.devtools.containeranalysis.v1alpha1.IArtifact[];

                    /** BuildProvenance createTime. */
                    public createTime?: (google.protobuf.ITimestamp|null);

                    /** BuildProvenance startTime. */
                    public startTime?: (google.protobuf.ITimestamp|null);

                    /** BuildProvenance finishTime. */
                    public finishTime?: (google.protobuf.ITimestamp|null);

                    /** BuildProvenance creator. */
                    public creator: string;

                    /** BuildProvenance logsBucket. */
                    public logsBucket: string;

                    /** BuildProvenance sourceProvenance. */
                    public sourceProvenance?: (google.devtools.containeranalysis.v1alpha1.ISource|null);

                    /** BuildProvenance triggerId. */
                    public triggerId: string;

                    /** BuildProvenance buildOptions. */
                    public buildOptions: { [k: string]: string };

                    /** BuildProvenance builderVersion. */
                    public builderVersion: string;

                    /**
                     * Creates a new BuildProvenance instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns BuildProvenance instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IBuildProvenance): google.devtools.containeranalysis.v1alpha1.BuildProvenance;

                    /**
                     * Encodes the specified BuildProvenance message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.BuildProvenance.verify|verify} messages.
                     * @param message BuildProvenance message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IBuildProvenance, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified BuildProvenance message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.BuildProvenance.verify|verify} messages.
                     * @param message BuildProvenance message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IBuildProvenance, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a BuildProvenance message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns BuildProvenance
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.BuildProvenance;

                    /**
                     * Decodes a BuildProvenance message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns BuildProvenance
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.BuildProvenance;

                    /**
                     * Verifies a BuildProvenance message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a BuildProvenance message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns BuildProvenance
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.BuildProvenance;

                    /**
                     * Creates a plain object from a BuildProvenance message. Also converts values to other types if specified.
                     * @param message BuildProvenance
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.BuildProvenance, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this BuildProvenance to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of a Source. */
                interface ISource {

                    /** Source storageSource */
                    storageSource?: (google.devtools.containeranalysis.v1alpha1.IStorageSource|null);

                    /** Source repoSource */
                    repoSource?: (google.devtools.containeranalysis.v1alpha1.IRepoSource|null);

                    /** Source artifactStorageSource */
                    artifactStorageSource?: (google.devtools.containeranalysis.v1alpha1.IStorageSource|null);

                    /** Source fileHashes */
                    fileHashes?: ({ [k: string]: google.devtools.containeranalysis.v1alpha1.IFileHashes }|null);

                    /** Source context */
                    context?: (google.devtools.containeranalysis.v1alpha1.ISourceContext|null);

                    /** Source additionalContexts */
                    additionalContexts?: (google.devtools.containeranalysis.v1alpha1.ISourceContext[]|null);
                }

                /** Represents a Source. */
                class Source implements ISource {

                    /**
                     * Constructs a new Source.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.ISource);

                    /** Source storageSource. */
                    public storageSource?: (google.devtools.containeranalysis.v1alpha1.IStorageSource|null);

                    /** Source repoSource. */
                    public repoSource?: (google.devtools.containeranalysis.v1alpha1.IRepoSource|null);

                    /** Source artifactStorageSource. */
                    public artifactStorageSource?: (google.devtools.containeranalysis.v1alpha1.IStorageSource|null);

                    /** Source fileHashes. */
                    public fileHashes: { [k: string]: google.devtools.containeranalysis.v1alpha1.IFileHashes };

                    /** Source context. */
                    public context?: (google.devtools.containeranalysis.v1alpha1.ISourceContext|null);

                    /** Source additionalContexts. */
                    public additionalContexts: google.devtools.containeranalysis.v1alpha1.ISourceContext[];

                    /** Source source. */
                    public source?: ("storageSource"|"repoSource");

                    /**
                     * Creates a new Source instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns Source instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.ISource): google.devtools.containeranalysis.v1alpha1.Source;

                    /**
                     * Encodes the specified Source message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.Source.verify|verify} messages.
                     * @param message Source message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.ISource, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified Source message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.Source.verify|verify} messages.
                     * @param message Source message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.ISource, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a Source message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns Source
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.Source;

                    /**
                     * Decodes a Source message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns Source
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.Source;

                    /**
                     * Verifies a Source message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a Source message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns Source
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.Source;

                    /**
                     * Creates a plain object from a Source message. Also converts values to other types if specified.
                     * @param message Source
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.Source, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this Source to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of a FileHashes. */
                interface IFileHashes {

                    /** FileHashes fileHash */
                    fileHash?: (google.devtools.containeranalysis.v1alpha1.IHash[]|null);
                }

                /** Represents a FileHashes. */
                class FileHashes implements IFileHashes {

                    /**
                     * Constructs a new FileHashes.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IFileHashes);

                    /** FileHashes fileHash. */
                    public fileHash: google.devtools.containeranalysis.v1alpha1.IHash[];

                    /**
                     * Creates a new FileHashes instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns FileHashes instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IFileHashes): google.devtools.containeranalysis.v1alpha1.FileHashes;

                    /**
                     * Encodes the specified FileHashes message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.FileHashes.verify|verify} messages.
                     * @param message FileHashes message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IFileHashes, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified FileHashes message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.FileHashes.verify|verify} messages.
                     * @param message FileHashes message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IFileHashes, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a FileHashes message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns FileHashes
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.FileHashes;

                    /**
                     * Decodes a FileHashes message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns FileHashes
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.FileHashes;

                    /**
                     * Verifies a FileHashes message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a FileHashes message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns FileHashes
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.FileHashes;

                    /**
                     * Creates a plain object from a FileHashes message. Also converts values to other types if specified.
                     * @param message FileHashes
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.FileHashes, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this FileHashes to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of a Hash. */
                interface IHash {

                    /** Hash type */
                    type?: (google.devtools.containeranalysis.v1alpha1.Hash.HashType|null);

                    /** Hash value */
                    value?: (Uint8Array|null);
                }

                /** Represents a Hash. */
                class Hash implements IHash {

                    /**
                     * Constructs a new Hash.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IHash);

                    /** Hash type. */
                    public type: google.devtools.containeranalysis.v1alpha1.Hash.HashType;

                    /** Hash value. */
                    public value: Uint8Array;

                    /**
                     * Creates a new Hash instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns Hash instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IHash): google.devtools.containeranalysis.v1alpha1.Hash;

                    /**
                     * Encodes the specified Hash message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.Hash.verify|verify} messages.
                     * @param message Hash message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IHash, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified Hash message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.Hash.verify|verify} messages.
                     * @param message Hash message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IHash, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a Hash message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns Hash
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.Hash;

                    /**
                     * Decodes a Hash message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns Hash
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.Hash;

                    /**
                     * Verifies a Hash message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a Hash message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns Hash
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.Hash;

                    /**
                     * Creates a plain object from a Hash message. Also converts values to other types if specified.
                     * @param message Hash
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.Hash, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this Hash to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                namespace Hash {

                    /** HashType enum. */
                    enum HashType {
                        NONE = 0,
                        SHA256 = 1
                    }
                }

                /** Properties of a StorageSource. */
                interface IStorageSource {

                    /** StorageSource bucket */
                    bucket?: (string|null);

                    /** StorageSource object */
                    object?: (string|null);

                    /** StorageSource generation */
                    generation?: (number|Long|null);
                }

                /** Represents a StorageSource. */
                class StorageSource implements IStorageSource {

                    /**
                     * Constructs a new StorageSource.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IStorageSource);

                    /** StorageSource bucket. */
                    public bucket: string;

                    /** StorageSource object. */
                    public object: string;

                    /** StorageSource generation. */
                    public generation: (number|Long);

                    /**
                     * Creates a new StorageSource instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns StorageSource instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IStorageSource): google.devtools.containeranalysis.v1alpha1.StorageSource;

                    /**
                     * Encodes the specified StorageSource message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.StorageSource.verify|verify} messages.
                     * @param message StorageSource message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IStorageSource, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified StorageSource message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.StorageSource.verify|verify} messages.
                     * @param message StorageSource message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IStorageSource, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a StorageSource message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns StorageSource
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.StorageSource;

                    /**
                     * Decodes a StorageSource message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns StorageSource
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.StorageSource;

                    /**
                     * Verifies a StorageSource message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a StorageSource message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns StorageSource
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.StorageSource;

                    /**
                     * Creates a plain object from a StorageSource message. Also converts values to other types if specified.
                     * @param message StorageSource
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.StorageSource, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this StorageSource to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of a RepoSource. */
                interface IRepoSource {

                    /** RepoSource projectId */
                    projectId?: (string|null);

                    /** RepoSource repoName */
                    repoName?: (string|null);

                    /** RepoSource branchName */
                    branchName?: (string|null);

                    /** RepoSource tagName */
                    tagName?: (string|null);

                    /** RepoSource commitSha */
                    commitSha?: (string|null);
                }

                /** Represents a RepoSource. */
                class RepoSource implements IRepoSource {

                    /**
                     * Constructs a new RepoSource.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IRepoSource);

                    /** RepoSource projectId. */
                    public projectId: string;

                    /** RepoSource repoName. */
                    public repoName: string;

                    /** RepoSource branchName. */
                    public branchName: string;

                    /** RepoSource tagName. */
                    public tagName: string;

                    /** RepoSource commitSha. */
                    public commitSha: string;

                    /** RepoSource revision. */
                    public revision?: ("branchName"|"tagName"|"commitSha");

                    /**
                     * Creates a new RepoSource instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns RepoSource instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IRepoSource): google.devtools.containeranalysis.v1alpha1.RepoSource;

                    /**
                     * Encodes the specified RepoSource message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.RepoSource.verify|verify} messages.
                     * @param message RepoSource message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IRepoSource, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified RepoSource message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.RepoSource.verify|verify} messages.
                     * @param message RepoSource message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IRepoSource, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a RepoSource message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns RepoSource
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.RepoSource;

                    /**
                     * Decodes a RepoSource message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns RepoSource
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.RepoSource;

                    /**
                     * Verifies a RepoSource message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a RepoSource message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns RepoSource
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.RepoSource;

                    /**
                     * Creates a plain object from a RepoSource message. Also converts values to other types if specified.
                     * @param message RepoSource
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.RepoSource, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this RepoSource to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of a Command. */
                interface ICommand {

                    /** Command name */
                    name?: (string|null);

                    /** Command env */
                    env?: (string[]|null);

                    /** Command args */
                    args?: (string[]|null);

                    /** Command dir */
                    dir?: (string|null);

                    /** Command id */
                    id?: (string|null);

                    /** Command waitFor */
                    waitFor?: (string[]|null);
                }

                /** Represents a Command. */
                class Command implements ICommand {

                    /**
                     * Constructs a new Command.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.ICommand);

                    /** Command name. */
                    public name: string;

                    /** Command env. */
                    public env: string[];

                    /** Command args. */
                    public args: string[];

                    /** Command dir. */
                    public dir: string;

                    /** Command id. */
                    public id: string;

                    /** Command waitFor. */
                    public waitFor: string[];

                    /**
                     * Creates a new Command instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns Command instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.ICommand): google.devtools.containeranalysis.v1alpha1.Command;

                    /**
                     * Encodes the specified Command message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.Command.verify|verify} messages.
                     * @param message Command message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.ICommand, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified Command message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.Command.verify|verify} messages.
                     * @param message Command message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.ICommand, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a Command message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns Command
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.Command;

                    /**
                     * Decodes a Command message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns Command
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.Command;

                    /**
                     * Verifies a Command message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a Command message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns Command
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.Command;

                    /**
                     * Creates a plain object from a Command message. Also converts values to other types if specified.
                     * @param message Command
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.Command, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this Command to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of an Artifact. */
                interface IArtifact {

                    /** Artifact name */
                    name?: (string|null);

                    /** Artifact checksum */
                    checksum?: (string|null);

                    /** Artifact id */
                    id?: (string|null);

                    /** Artifact names */
                    names?: (string[]|null);
                }

                /** Represents an Artifact. */
                class Artifact implements IArtifact {

                    /**
                     * Constructs a new Artifact.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IArtifact);

                    /** Artifact name. */
                    public name: string;

                    /** Artifact checksum. */
                    public checksum: string;

                    /** Artifact id. */
                    public id: string;

                    /** Artifact names. */
                    public names: string[];

                    /**
                     * Creates a new Artifact instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns Artifact instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IArtifact): google.devtools.containeranalysis.v1alpha1.Artifact;

                    /**
                     * Encodes the specified Artifact message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.Artifact.verify|verify} messages.
                     * @param message Artifact message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IArtifact, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified Artifact message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.Artifact.verify|verify} messages.
                     * @param message Artifact message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IArtifact, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes an Artifact message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns Artifact
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.Artifact;

                    /**
                     * Decodes an Artifact message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns Artifact
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.Artifact;

                    /**
                     * Verifies an Artifact message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates an Artifact message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns Artifact
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.Artifact;

                    /**
                     * Creates a plain object from an Artifact message. Also converts values to other types if specified.
                     * @param message Artifact
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.Artifact, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this Artifact to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of a SourceContext. */
                interface ISourceContext {

                    /** SourceContext cloudRepo */
                    cloudRepo?: (google.devtools.containeranalysis.v1alpha1.ICloudRepoSourceContext|null);

                    /** SourceContext gerrit */
                    gerrit?: (google.devtools.containeranalysis.v1alpha1.IGerritSourceContext|null);

                    /** SourceContext git */
                    git?: (google.devtools.containeranalysis.v1alpha1.IGitSourceContext|null);

                    /** SourceContext labels */
                    labels?: ({ [k: string]: string }|null);
                }

                /** Represents a SourceContext. */
                class SourceContext implements ISourceContext {

                    /**
                     * Constructs a new SourceContext.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.ISourceContext);

                    /** SourceContext cloudRepo. */
                    public cloudRepo?: (google.devtools.containeranalysis.v1alpha1.ICloudRepoSourceContext|null);

                    /** SourceContext gerrit. */
                    public gerrit?: (google.devtools.containeranalysis.v1alpha1.IGerritSourceContext|null);

                    /** SourceContext git. */
                    public git?: (google.devtools.containeranalysis.v1alpha1.IGitSourceContext|null);

                    /** SourceContext labels. */
                    public labels: { [k: string]: string };

                    /** SourceContext context. */
                    public context?: ("cloudRepo"|"gerrit"|"git");

                    /**
                     * Creates a new SourceContext instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns SourceContext instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.ISourceContext): google.devtools.containeranalysis.v1alpha1.SourceContext;

                    /**
                     * Encodes the specified SourceContext message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.SourceContext.verify|verify} messages.
                     * @param message SourceContext message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.ISourceContext, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified SourceContext message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.SourceContext.verify|verify} messages.
                     * @param message SourceContext message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.ISourceContext, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a SourceContext message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns SourceContext
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.SourceContext;

                    /**
                     * Decodes a SourceContext message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns SourceContext
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.SourceContext;

                    /**
                     * Verifies a SourceContext message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a SourceContext message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns SourceContext
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.SourceContext;

                    /**
                     * Creates a plain object from a SourceContext message. Also converts values to other types if specified.
                     * @param message SourceContext
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.SourceContext, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this SourceContext to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of an AliasContext. */
                interface IAliasContext {

                    /** AliasContext kind */
                    kind?: (google.devtools.containeranalysis.v1alpha1.AliasContext.Kind|null);

                    /** AliasContext name */
                    name?: (string|null);
                }

                /** Represents an AliasContext. */
                class AliasContext implements IAliasContext {

                    /**
                     * Constructs a new AliasContext.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IAliasContext);

                    /** AliasContext kind. */
                    public kind: google.devtools.containeranalysis.v1alpha1.AliasContext.Kind;

                    /** AliasContext name. */
                    public name: string;

                    /**
                     * Creates a new AliasContext instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns AliasContext instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IAliasContext): google.devtools.containeranalysis.v1alpha1.AliasContext;

                    /**
                     * Encodes the specified AliasContext message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.AliasContext.verify|verify} messages.
                     * @param message AliasContext message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IAliasContext, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified AliasContext message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.AliasContext.verify|verify} messages.
                     * @param message AliasContext message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IAliasContext, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes an AliasContext message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns AliasContext
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.AliasContext;

                    /**
                     * Decodes an AliasContext message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns AliasContext
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.AliasContext;

                    /**
                     * Verifies an AliasContext message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates an AliasContext message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns AliasContext
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.AliasContext;

                    /**
                     * Creates a plain object from an AliasContext message. Also converts values to other types if specified.
                     * @param message AliasContext
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.AliasContext, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this AliasContext to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                namespace AliasContext {

                    /** Kind enum. */
                    enum Kind {
                        KIND_UNSPECIFIED = 0,
                        FIXED = 1,
                        MOVABLE = 2,
                        OTHER = 4
                    }
                }

                /** Properties of a CloudRepoSourceContext. */
                interface ICloudRepoSourceContext {

                    /** CloudRepoSourceContext repoId */
                    repoId?: (google.devtools.containeranalysis.v1alpha1.IRepoId|null);

                    /** CloudRepoSourceContext revisionId */
                    revisionId?: (string|null);

                    /** CloudRepoSourceContext aliasContext */
                    aliasContext?: (google.devtools.containeranalysis.v1alpha1.IAliasContext|null);
                }

                /** Represents a CloudRepoSourceContext. */
                class CloudRepoSourceContext implements ICloudRepoSourceContext {

                    /**
                     * Constructs a new CloudRepoSourceContext.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.ICloudRepoSourceContext);

                    /** CloudRepoSourceContext repoId. */
                    public repoId?: (google.devtools.containeranalysis.v1alpha1.IRepoId|null);

                    /** CloudRepoSourceContext revisionId. */
                    public revisionId: string;

                    /** CloudRepoSourceContext aliasContext. */
                    public aliasContext?: (google.devtools.containeranalysis.v1alpha1.IAliasContext|null);

                    /** CloudRepoSourceContext revision. */
                    public revision?: ("revisionId"|"aliasContext");

                    /**
                     * Creates a new CloudRepoSourceContext instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns CloudRepoSourceContext instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.ICloudRepoSourceContext): google.devtools.containeranalysis.v1alpha1.CloudRepoSourceContext;

                    /**
                     * Encodes the specified CloudRepoSourceContext message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.CloudRepoSourceContext.verify|verify} messages.
                     * @param message CloudRepoSourceContext message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.ICloudRepoSourceContext, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified CloudRepoSourceContext message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.CloudRepoSourceContext.verify|verify} messages.
                     * @param message CloudRepoSourceContext message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.ICloudRepoSourceContext, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a CloudRepoSourceContext message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns CloudRepoSourceContext
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.CloudRepoSourceContext;

                    /**
                     * Decodes a CloudRepoSourceContext message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns CloudRepoSourceContext
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.CloudRepoSourceContext;

                    /**
                     * Verifies a CloudRepoSourceContext message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a CloudRepoSourceContext message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns CloudRepoSourceContext
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.CloudRepoSourceContext;

                    /**
                     * Creates a plain object from a CloudRepoSourceContext message. Also converts values to other types if specified.
                     * @param message CloudRepoSourceContext
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.CloudRepoSourceContext, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this CloudRepoSourceContext to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of a GerritSourceContext. */
                interface IGerritSourceContext {

                    /** GerritSourceContext hostUri */
                    hostUri?: (string|null);

                    /** GerritSourceContext gerritProject */
                    gerritProject?: (string|null);

                    /** GerritSourceContext revisionId */
                    revisionId?: (string|null);

                    /** GerritSourceContext aliasContext */
                    aliasContext?: (google.devtools.containeranalysis.v1alpha1.IAliasContext|null);
                }

                /** Represents a GerritSourceContext. */
                class GerritSourceContext implements IGerritSourceContext {

                    /**
                     * Constructs a new GerritSourceContext.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IGerritSourceContext);

                    /** GerritSourceContext hostUri. */
                    public hostUri: string;

                    /** GerritSourceContext gerritProject. */
                    public gerritProject: string;

                    /** GerritSourceContext revisionId. */
                    public revisionId: string;

                    /** GerritSourceContext aliasContext. */
                    public aliasContext?: (google.devtools.containeranalysis.v1alpha1.IAliasContext|null);

                    /** GerritSourceContext revision. */
                    public revision?: ("revisionId"|"aliasContext");

                    /**
                     * Creates a new GerritSourceContext instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns GerritSourceContext instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IGerritSourceContext): google.devtools.containeranalysis.v1alpha1.GerritSourceContext;

                    /**
                     * Encodes the specified GerritSourceContext message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.GerritSourceContext.verify|verify} messages.
                     * @param message GerritSourceContext message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IGerritSourceContext, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified GerritSourceContext message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.GerritSourceContext.verify|verify} messages.
                     * @param message GerritSourceContext message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IGerritSourceContext, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a GerritSourceContext message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns GerritSourceContext
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.GerritSourceContext;

                    /**
                     * Decodes a GerritSourceContext message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns GerritSourceContext
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.GerritSourceContext;

                    /**
                     * Verifies a GerritSourceContext message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a GerritSourceContext message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns GerritSourceContext
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.GerritSourceContext;

                    /**
                     * Creates a plain object from a GerritSourceContext message. Also converts values to other types if specified.
                     * @param message GerritSourceContext
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.GerritSourceContext, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this GerritSourceContext to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of a GitSourceContext. */
                interface IGitSourceContext {

                    /** GitSourceContext url */
                    url?: (string|null);

                    /** GitSourceContext revisionId */
                    revisionId?: (string|null);
                }

                /** Represents a GitSourceContext. */
                class GitSourceContext implements IGitSourceContext {

                    /**
                     * Constructs a new GitSourceContext.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IGitSourceContext);

                    /** GitSourceContext url. */
                    public url: string;

                    /** GitSourceContext revisionId. */
                    public revisionId: string;

                    /**
                     * Creates a new GitSourceContext instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns GitSourceContext instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IGitSourceContext): google.devtools.containeranalysis.v1alpha1.GitSourceContext;

                    /**
                     * Encodes the specified GitSourceContext message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.GitSourceContext.verify|verify} messages.
                     * @param message GitSourceContext message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IGitSourceContext, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified GitSourceContext message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.GitSourceContext.verify|verify} messages.
                     * @param message GitSourceContext message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IGitSourceContext, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a GitSourceContext message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns GitSourceContext
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.GitSourceContext;

                    /**
                     * Decodes a GitSourceContext message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns GitSourceContext
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.GitSourceContext;

                    /**
                     * Verifies a GitSourceContext message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a GitSourceContext message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns GitSourceContext
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.GitSourceContext;

                    /**
                     * Creates a plain object from a GitSourceContext message. Also converts values to other types if specified.
                     * @param message GitSourceContext
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.GitSourceContext, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this GitSourceContext to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of a RepoId. */
                interface IRepoId {

                    /** RepoId projectRepoId */
                    projectRepoId?: (google.devtools.containeranalysis.v1alpha1.IProjectRepoId|null);

                    /** RepoId uid */
                    uid?: (string|null);
                }

                /** Represents a RepoId. */
                class RepoId implements IRepoId {

                    /**
                     * Constructs a new RepoId.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IRepoId);

                    /** RepoId projectRepoId. */
                    public projectRepoId?: (google.devtools.containeranalysis.v1alpha1.IProjectRepoId|null);

                    /** RepoId uid. */
                    public uid: string;

                    /** RepoId id. */
                    public id?: ("projectRepoId"|"uid");

                    /**
                     * Creates a new RepoId instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns RepoId instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IRepoId): google.devtools.containeranalysis.v1alpha1.RepoId;

                    /**
                     * Encodes the specified RepoId message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.RepoId.verify|verify} messages.
                     * @param message RepoId message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IRepoId, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified RepoId message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.RepoId.verify|verify} messages.
                     * @param message RepoId message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IRepoId, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a RepoId message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns RepoId
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.RepoId;

                    /**
                     * Decodes a RepoId message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns RepoId
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.RepoId;

                    /**
                     * Verifies a RepoId message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a RepoId message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns RepoId
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.RepoId;

                    /**
                     * Creates a plain object from a RepoId message. Also converts values to other types if specified.
                     * @param message RepoId
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.RepoId, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this RepoId to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }

                /** Properties of a ProjectRepoId. */
                interface IProjectRepoId {

                    /** ProjectRepoId projectId */
                    projectId?: (string|null);

                    /** ProjectRepoId repoName */
                    repoName?: (string|null);
                }

                /** Represents a ProjectRepoId. */
                class ProjectRepoId implements IProjectRepoId {

                    /**
                     * Constructs a new ProjectRepoId.
                     * @param [properties] Properties to set
                     */
                    constructor(properties?: google.devtools.containeranalysis.v1alpha1.IProjectRepoId);

                    /** ProjectRepoId projectId. */
                    public projectId: string;

                    /** ProjectRepoId repoName. */
                    public repoName: string;

                    /**
                     * Creates a new ProjectRepoId instance using the specified properties.
                     * @param [properties] Properties to set
                     * @returns ProjectRepoId instance
                     */
                    public static create(properties?: google.devtools.containeranalysis.v1alpha1.IProjectRepoId): google.devtools.containeranalysis.v1alpha1.ProjectRepoId;

                    /**
                     * Encodes the specified ProjectRepoId message. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.ProjectRepoId.verify|verify} messages.
                     * @param message ProjectRepoId message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encode(message: google.devtools.containeranalysis.v1alpha1.IProjectRepoId, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Encodes the specified ProjectRepoId message, length delimited. Does not implicitly {@link google.devtools.containeranalysis.v1alpha1.ProjectRepoId.verify|verify} messages.
                     * @param message ProjectRepoId message or plain object to encode
                     * @param [writer] Writer to encode to
                     * @returns Writer
                     */
                    public static encodeDelimited(message: google.devtools.containeranalysis.v1alpha1.IProjectRepoId, writer?: $protobuf.Writer): $protobuf.Writer;

                    /**
                     * Decodes a ProjectRepoId message from the specified reader or buffer.
                     * @param reader Reader or buffer to decode from
                     * @param [length] Message length if known beforehand
                     * @returns ProjectRepoId
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.devtools.containeranalysis.v1alpha1.ProjectRepoId;

                    /**
                     * Decodes a ProjectRepoId message from the specified reader or buffer, length delimited.
                     * @param reader Reader or buffer to decode from
                     * @returns ProjectRepoId
                     * @throws {Error} If the payload is not a reader or valid buffer
                     * @throws {$protobuf.util.ProtocolError} If required fields are missing
                     */
                    public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.devtools.containeranalysis.v1alpha1.ProjectRepoId;

                    /**
                     * Verifies a ProjectRepoId message.
                     * @param message Plain object to verify
                     * @returns `null` if valid, otherwise the reason why it is not
                     */
                    public static verify(message: { [k: string]: any }): (string|null);

                    /**
                     * Creates a ProjectRepoId message from a plain object. Also converts values to their respective internal types.
                     * @param object Plain object
                     * @returns ProjectRepoId
                     */
                    public static fromObject(object: { [k: string]: any }): google.devtools.containeranalysis.v1alpha1.ProjectRepoId;

                    /**
                     * Creates a plain object from a ProjectRepoId message. Also converts values to other types if specified.
                     * @param message ProjectRepoId
                     * @param [options] Conversion options
                     * @returns Plain object
                     */
                    public static toObject(message: google.devtools.containeranalysis.v1alpha1.ProjectRepoId, options?: $protobuf.IConversionOptions): { [k: string]: any };

                    /**
                     * Converts this ProjectRepoId to JSON.
                     * @returns JSON object
                     */
                    public toJSON(): { [k: string]: any };
                }
            }
        }
    }

    /** Namespace api. */
    namespace api {

        /** Properties of a Http. */
        interface IHttp {

            /** Http rules */
            rules?: (google.api.IHttpRule[]|null);

            /** Http fullyDecodeReservedExpansion */
            fullyDecodeReservedExpansion?: (boolean|null);
        }

        /** Represents a Http. */
        class Http implements IHttp {

            /**
             * Constructs a new Http.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.api.IHttp);

            /** Http rules. */
            public rules: google.api.IHttpRule[];

            /** Http fullyDecodeReservedExpansion. */
            public fullyDecodeReservedExpansion: boolean;

            /**
             * Creates a new Http instance using the specified properties.
             * @param [properties] Properties to set
             * @returns Http instance
             */
            public static create(properties?: google.api.IHttp): google.api.Http;

            /**
             * Encodes the specified Http message. Does not implicitly {@link google.api.Http.verify|verify} messages.
             * @param message Http message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.api.IHttp, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified Http message, length delimited. Does not implicitly {@link google.api.Http.verify|verify} messages.
             * @param message Http message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.api.IHttp, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes a Http message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns Http
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.api.Http;

            /**
             * Decodes a Http message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns Http
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.api.Http;

            /**
             * Verifies a Http message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates a Http message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns Http
             */
            public static fromObject(object: { [k: string]: any }): google.api.Http;

            /**
             * Creates a plain object from a Http message. Also converts values to other types if specified.
             * @param message Http
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.api.Http, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this Http to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }

        /** Properties of a HttpRule. */
        interface IHttpRule {

            /** HttpRule selector */
            selector?: (string|null);

            /** HttpRule get */
            get?: (string|null);

            /** HttpRule put */
            put?: (string|null);

            /** HttpRule post */
            post?: (string|null);

            /** HttpRule delete */
            "delete"?: (string|null);

            /** HttpRule patch */
            patch?: (string|null);

            /** HttpRule custom */
            custom?: (google.api.ICustomHttpPattern|null);

            /** HttpRule body */
            body?: (string|null);

            /** HttpRule responseBody */
            responseBody?: (string|null);

            /** HttpRule additionalBindings */
            additionalBindings?: (google.api.IHttpRule[]|null);
        }

        /** Represents a HttpRule. */
        class HttpRule implements IHttpRule {

            /**
             * Constructs a new HttpRule.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.api.IHttpRule);

            /** HttpRule selector. */
            public selector: string;

            /** HttpRule get. */
            public get: string;

            /** HttpRule put. */
            public put: string;

            /** HttpRule post. */
            public post: string;

            /** HttpRule delete. */
            public delete: string;

            /** HttpRule patch. */
            public patch: string;

            /** HttpRule custom. */
            public custom?: (google.api.ICustomHttpPattern|null);

            /** HttpRule body. */
            public body: string;

            /** HttpRule responseBody. */
            public responseBody: string;

            /** HttpRule additionalBindings. */
            public additionalBindings: google.api.IHttpRule[];

            /** HttpRule pattern. */
            public pattern?: ("get"|"put"|"post"|"delete"|"patch"|"custom");

            /**
             * Creates a new HttpRule instance using the specified properties.
             * @param [properties] Properties to set
             * @returns HttpRule instance
             */
            public static create(properties?: google.api.IHttpRule): google.api.HttpRule;

            /**
             * Encodes the specified HttpRule message. Does not implicitly {@link google.api.HttpRule.verify|verify} messages.
             * @param message HttpRule message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.api.IHttpRule, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified HttpRule message, length delimited. Does not implicitly {@link google.api.HttpRule.verify|verify} messages.
             * @param message HttpRule message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.api.IHttpRule, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes a HttpRule message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns HttpRule
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.api.HttpRule;

            /**
             * Decodes a HttpRule message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns HttpRule
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.api.HttpRule;

            /**
             * Verifies a HttpRule message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates a HttpRule message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns HttpRule
             */
            public static fromObject(object: { [k: string]: any }): google.api.HttpRule;

            /**
             * Creates a plain object from a HttpRule message. Also converts values to other types if specified.
             * @param message HttpRule
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.api.HttpRule, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this HttpRule to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }

        /** Properties of a CustomHttpPattern. */
        interface ICustomHttpPattern {

            /** CustomHttpPattern kind */
            kind?: (string|null);

            /** CustomHttpPattern path */
            path?: (string|null);
        }

        /** Represents a CustomHttpPattern. */
        class CustomHttpPattern implements ICustomHttpPattern {

            /**
             * Constructs a new CustomHttpPattern.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.api.ICustomHttpPattern);

            /** CustomHttpPattern kind. */
            public kind: string;

            /** CustomHttpPattern path. */
            public path: string;

            /**
             * Creates a new CustomHttpPattern instance using the specified properties.
             * @param [properties] Properties to set
             * @returns CustomHttpPattern instance
             */
            public static create(properties?: google.api.ICustomHttpPattern): google.api.CustomHttpPattern;

            /**
             * Encodes the specified CustomHttpPattern message. Does not implicitly {@link google.api.CustomHttpPattern.verify|verify} messages.
             * @param message CustomHttpPattern message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.api.ICustomHttpPattern, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified CustomHttpPattern message, length delimited. Does not implicitly {@link google.api.CustomHttpPattern.verify|verify} messages.
             * @param message CustomHttpPattern message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.api.ICustomHttpPattern, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes a CustomHttpPattern message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns CustomHttpPattern
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.api.CustomHttpPattern;

            /**
             * Decodes a CustomHttpPattern message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns CustomHttpPattern
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.api.CustomHttpPattern;

            /**
             * Verifies a CustomHttpPattern message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates a CustomHttpPattern message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns CustomHttpPattern
             */
            public static fromObject(object: { [k: string]: any }): google.api.CustomHttpPattern;

            /**
             * Creates a plain object from a CustomHttpPattern message. Also converts values to other types if specified.
             * @param message CustomHttpPattern
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.api.CustomHttpPattern, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this CustomHttpPattern to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }
    }

    /** Namespace protobuf. */
    namespace protobuf {

        /** Properties of a FileDescriptorSet. */
        interface IFileDescriptorSet {

            /** FileDescriptorSet file */
            file?: (google.protobuf.IFileDescriptorProto[]|null);
        }

        /** Represents a FileDescriptorSet. */
        class FileDescriptorSet implements IFileDescriptorSet {

            /**
             * Constructs a new FileDescriptorSet.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.protobuf.IFileDescriptorSet);

            /** FileDescriptorSet file. */
            public file: google.protobuf.IFileDescriptorProto[];

            /**
             * Creates a new FileDescriptorSet instance using the specified properties.
             * @param [properties] Properties to set
             * @returns FileDescriptorSet instance
             */
            public static create(properties?: google.protobuf.IFileDescriptorSet): google.protobuf.FileDescriptorSet;

            /**
             * Encodes the specified FileDescriptorSet message. Does not implicitly {@link google.protobuf.FileDescriptorSet.verify|verify} messages.
             * @param message FileDescriptorSet message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.protobuf.IFileDescriptorSet, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified FileDescriptorSet message, length delimited. Does not implicitly {@link google.protobuf.FileDescriptorSet.verify|verify} messages.
             * @param message FileDescriptorSet message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.protobuf.IFileDescriptorSet, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes a FileDescriptorSet message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns FileDescriptorSet
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.protobuf.FileDescriptorSet;

            /**
             * Decodes a FileDescriptorSet message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns FileDescriptorSet
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.protobuf.FileDescriptorSet;

            /**
             * Verifies a FileDescriptorSet message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates a FileDescriptorSet message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns FileDescriptorSet
             */
            public static fromObject(object: { [k: string]: any }): google.protobuf.FileDescriptorSet;

            /**
             * Creates a plain object from a FileDescriptorSet message. Also converts values to other types if specified.
             * @param message FileDescriptorSet
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.protobuf.FileDescriptorSet, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this FileDescriptorSet to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }

        /** Properties of a FileDescriptorProto. */
        interface IFileDescriptorProto {

            /** FileDescriptorProto name */
            name?: (string|null);

            /** FileDescriptorProto package */
            "package"?: (string|null);

            /** FileDescriptorProto dependency */
            dependency?: (string[]|null);

            /** FileDescriptorProto publicDependency */
            publicDependency?: (number[]|null);

            /** FileDescriptorProto weakDependency */
            weakDependency?: (number[]|null);

            /** FileDescriptorProto messageType */
            messageType?: (google.protobuf.IDescriptorProto[]|null);

            /** FileDescriptorProto enumType */
            enumType?: (google.protobuf.IEnumDescriptorProto[]|null);

            /** FileDescriptorProto service */
            service?: (google.protobuf.IServiceDescriptorProto[]|null);

            /** FileDescriptorProto extension */
            extension?: (google.protobuf.IFieldDescriptorProto[]|null);

            /** FileDescriptorProto options */
            options?: (google.protobuf.IFileOptions|null);

            /** FileDescriptorProto sourceCodeInfo */
            sourceCodeInfo?: (google.protobuf.ISourceCodeInfo|null);

            /** FileDescriptorProto syntax */
            syntax?: (string|null);
        }

        /** Represents a FileDescriptorProto. */
        class FileDescriptorProto implements IFileDescriptorProto {

            /**
             * Constructs a new FileDescriptorProto.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.protobuf.IFileDescriptorProto);

            /** FileDescriptorProto name. */
            public name: string;

            /** FileDescriptorProto package. */
            public package: string;

            /** FileDescriptorProto dependency. */
            public dependency: string[];

            /** FileDescriptorProto publicDependency. */
            public publicDependency: number[];

            /** FileDescriptorProto weakDependency. */
            public weakDependency: number[];

            /** FileDescriptorProto messageType. */
            public messageType: google.protobuf.IDescriptorProto[];

            /** FileDescriptorProto enumType. */
            public enumType: google.protobuf.IEnumDescriptorProto[];

            /** FileDescriptorProto service. */
            public service: google.protobuf.IServiceDescriptorProto[];

            /** FileDescriptorProto extension. */
            public extension: google.protobuf.IFieldDescriptorProto[];

            /** FileDescriptorProto options. */
            public options?: (google.protobuf.IFileOptions|null);

            /** FileDescriptorProto sourceCodeInfo. */
            public sourceCodeInfo?: (google.protobuf.ISourceCodeInfo|null);

            /** FileDescriptorProto syntax. */
            public syntax: string;

            /**
             * Creates a new FileDescriptorProto instance using the specified properties.
             * @param [properties] Properties to set
             * @returns FileDescriptorProto instance
             */
            public static create(properties?: google.protobuf.IFileDescriptorProto): google.protobuf.FileDescriptorProto;

            /**
             * Encodes the specified FileDescriptorProto message. Does not implicitly {@link google.protobuf.FileDescriptorProto.verify|verify} messages.
             * @param message FileDescriptorProto message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.protobuf.IFileDescriptorProto, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified FileDescriptorProto message, length delimited. Does not implicitly {@link google.protobuf.FileDescriptorProto.verify|verify} messages.
             * @param message FileDescriptorProto message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.protobuf.IFileDescriptorProto, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes a FileDescriptorProto message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns FileDescriptorProto
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.protobuf.FileDescriptorProto;

            /**
             * Decodes a FileDescriptorProto message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns FileDescriptorProto
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.protobuf.FileDescriptorProto;

            /**
             * Verifies a FileDescriptorProto message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates a FileDescriptorProto message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns FileDescriptorProto
             */
            public static fromObject(object: { [k: string]: any }): google.protobuf.FileDescriptorProto;

            /**
             * Creates a plain object from a FileDescriptorProto message. Also converts values to other types if specified.
             * @param message FileDescriptorProto
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.protobuf.FileDescriptorProto, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this FileDescriptorProto to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }

        /** Properties of a DescriptorProto. */
        interface IDescriptorProto {

            /** DescriptorProto name */
            name?: (string|null);

            /** DescriptorProto field */
            field?: (google.protobuf.IFieldDescriptorProto[]|null);

            /** DescriptorProto extension */
            extension?: (google.protobuf.IFieldDescriptorProto[]|null);

            /** DescriptorProto nestedType */
            nestedType?: (google.protobuf.IDescriptorProto[]|null);

            /** DescriptorProto enumType */
            enumType?: (google.protobuf.IEnumDescriptorProto[]|null);

            /** DescriptorProto extensionRange */
            extensionRange?: (google.protobuf.DescriptorProto.IExtensionRange[]|null);

            /** DescriptorProto oneofDecl */
            oneofDecl?: (google.protobuf.IOneofDescriptorProto[]|null);

            /** DescriptorProto options */
            options?: (google.protobuf.IMessageOptions|null);

            /** DescriptorProto reservedRange */
            reservedRange?: (google.protobuf.DescriptorProto.IReservedRange[]|null);

            /** DescriptorProto reservedName */
            reservedName?: (string[]|null);
        }

        /** Represents a DescriptorProto. */
        class DescriptorProto implements IDescriptorProto {

            /**
             * Constructs a new DescriptorProto.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.protobuf.IDescriptorProto);

            /** DescriptorProto name. */
            public name: string;

            /** DescriptorProto field. */
            public field: google.protobuf.IFieldDescriptorProto[];

            /** DescriptorProto extension. */
            public extension: google.protobuf.IFieldDescriptorProto[];

            /** DescriptorProto nestedType. */
            public nestedType: google.protobuf.IDescriptorProto[];

            /** DescriptorProto enumType. */
            public enumType: google.protobuf.IEnumDescriptorProto[];

            /** DescriptorProto extensionRange. */
            public extensionRange: google.protobuf.DescriptorProto.IExtensionRange[];

            /** DescriptorProto oneofDecl. */
            public oneofDecl: google.protobuf.IOneofDescriptorProto[];

            /** DescriptorProto options. */
            public options?: (google.protobuf.IMessageOptions|null);

            /** DescriptorProto reservedRange. */
            public reservedRange: google.protobuf.DescriptorProto.IReservedRange[];

            /** DescriptorProto reservedName. */
            public reservedName: string[];

            /**
             * Creates a new DescriptorProto instance using the specified properties.
             * @param [properties] Properties to set
             * @returns DescriptorProto instance
             */
            public static create(properties?: google.protobuf.IDescriptorProto): google.protobuf.DescriptorProto;

            /**
             * Encodes the specified DescriptorProto message. Does not implicitly {@link google.protobuf.DescriptorProto.verify|verify} messages.
             * @param message DescriptorProto message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.protobuf.IDescriptorProto, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified DescriptorProto message, length delimited. Does not implicitly {@link google.protobuf.DescriptorProto.verify|verify} messages.
             * @param message DescriptorProto message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.protobuf.IDescriptorProto, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes a DescriptorProto message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns DescriptorProto
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.protobuf.DescriptorProto;

            /**
             * Decodes a DescriptorProto message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns DescriptorProto
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.protobuf.DescriptorProto;

            /**
             * Verifies a DescriptorProto message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates a DescriptorProto message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns DescriptorProto
             */
            public static fromObject(object: { [k: string]: any }): google.protobuf.DescriptorProto;

            /**
             * Creates a plain object from a DescriptorProto message. Also converts values to other types if specified.
             * @param message DescriptorProto
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.protobuf.DescriptorProto, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this DescriptorProto to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }

        namespace DescriptorProto {

            /** Properties of an ExtensionRange. */
            interface IExtensionRange {

                /** ExtensionRange start */
                start?: (number|null);

                /** ExtensionRange end */
                end?: (number|null);

                /** ExtensionRange options */
                options?: (google.protobuf.IExtensionRangeOptions|null);
            }

            /** Represents an ExtensionRange. */
            class ExtensionRange implements IExtensionRange {

                /**
                 * Constructs a new ExtensionRange.
                 * @param [properties] Properties to set
                 */
                constructor(properties?: google.protobuf.DescriptorProto.IExtensionRange);

                /** ExtensionRange start. */
                public start: number;

                /** ExtensionRange end. */
                public end: number;

                /** ExtensionRange options. */
                public options?: (google.protobuf.IExtensionRangeOptions|null);

                /**
                 * Creates a new ExtensionRange instance using the specified properties.
                 * @param [properties] Properties to set
                 * @returns ExtensionRange instance
                 */
                public static create(properties?: google.protobuf.DescriptorProto.IExtensionRange): google.protobuf.DescriptorProto.ExtensionRange;

                /**
                 * Encodes the specified ExtensionRange message. Does not implicitly {@link google.protobuf.DescriptorProto.ExtensionRange.verify|verify} messages.
                 * @param message ExtensionRange message or plain object to encode
                 * @param [writer] Writer to encode to
                 * @returns Writer
                 */
                public static encode(message: google.protobuf.DescriptorProto.IExtensionRange, writer?: $protobuf.Writer): $protobuf.Writer;

                /**
                 * Encodes the specified ExtensionRange message, length delimited. Does not implicitly {@link google.protobuf.DescriptorProto.ExtensionRange.verify|verify} messages.
                 * @param message ExtensionRange message or plain object to encode
                 * @param [writer] Writer to encode to
                 * @returns Writer
                 */
                public static encodeDelimited(message: google.protobuf.DescriptorProto.IExtensionRange, writer?: $protobuf.Writer): $protobuf.Writer;

                /**
                 * Decodes an ExtensionRange message from the specified reader or buffer.
                 * @param reader Reader or buffer to decode from
                 * @param [length] Message length if known beforehand
                 * @returns ExtensionRange
                 * @throws {Error} If the payload is not a reader or valid buffer
                 * @throws {$protobuf.util.ProtocolError} If required fields are missing
                 */
                public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.protobuf.DescriptorProto.ExtensionRange;

                /**
                 * Decodes an ExtensionRange message from the specified reader or buffer, length delimited.
                 * @param reader Reader or buffer to decode from
                 * @returns ExtensionRange
                 * @throws {Error} If the payload is not a reader or valid buffer
                 * @throws {$protobuf.util.ProtocolError} If required fields are missing
                 */
                public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.protobuf.DescriptorProto.ExtensionRange;

                /**
                 * Verifies an ExtensionRange message.
                 * @param message Plain object to verify
                 * @returns `null` if valid, otherwise the reason why it is not
                 */
                public static verify(message: { [k: string]: any }): (string|null);

                /**
                 * Creates an ExtensionRange message from a plain object. Also converts values to their respective internal types.
                 * @param object Plain object
                 * @returns ExtensionRange
                 */
                public static fromObject(object: { [k: string]: any }): google.protobuf.DescriptorProto.ExtensionRange;

                /**
                 * Creates a plain object from an ExtensionRange message. Also converts values to other types if specified.
                 * @param message ExtensionRange
                 * @param [options] Conversion options
                 * @returns Plain object
                 */
                public static toObject(message: google.protobuf.DescriptorProto.ExtensionRange, options?: $protobuf.IConversionOptions): { [k: string]: any };

                /**
                 * Converts this ExtensionRange to JSON.
                 * @returns JSON object
                 */
                public toJSON(): { [k: string]: any };
            }

            /** Properties of a ReservedRange. */
            interface IReservedRange {

                /** ReservedRange start */
                start?: (number|null);

                /** ReservedRange end */
                end?: (number|null);
            }

            /** Represents a ReservedRange. */
            class ReservedRange implements IReservedRange {

                /**
                 * Constructs a new ReservedRange.
                 * @param [properties] Properties to set
                 */
                constructor(properties?: google.protobuf.DescriptorProto.IReservedRange);

                /** ReservedRange start. */
                public start: number;

                /** ReservedRange end. */
                public end: number;

                /**
                 * Creates a new ReservedRange instance using the specified properties.
                 * @param [properties] Properties to set
                 * @returns ReservedRange instance
                 */
                public static create(properties?: google.protobuf.DescriptorProto.IReservedRange): google.protobuf.DescriptorProto.ReservedRange;

                /**
                 * Encodes the specified ReservedRange message. Does not implicitly {@link google.protobuf.DescriptorProto.ReservedRange.verify|verify} messages.
                 * @param message ReservedRange message or plain object to encode
                 * @param [writer] Writer to encode to
                 * @returns Writer
                 */
                public static encode(message: google.protobuf.DescriptorProto.IReservedRange, writer?: $protobuf.Writer): $protobuf.Writer;

                /**
                 * Encodes the specified ReservedRange message, length delimited. Does not implicitly {@link google.protobuf.DescriptorProto.ReservedRange.verify|verify} messages.
                 * @param message ReservedRange message or plain object to encode
                 * @param [writer] Writer to encode to
                 * @returns Writer
                 */
                public static encodeDelimited(message: google.protobuf.DescriptorProto.IReservedRange, writer?: $protobuf.Writer): $protobuf.Writer;

                /**
                 * Decodes a ReservedRange message from the specified reader or buffer.
                 * @param reader Reader or buffer to decode from
                 * @param [length] Message length if known beforehand
                 * @returns ReservedRange
                 * @throws {Error} If the payload is not a reader or valid buffer
                 * @throws {$protobuf.util.ProtocolError} If required fields are missing
                 */
                public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.protobuf.DescriptorProto.ReservedRange;

                /**
                 * Decodes a ReservedRange message from the specified reader or buffer, length delimited.
                 * @param reader Reader or buffer to decode from
                 * @returns ReservedRange
                 * @throws {Error} If the payload is not a reader or valid buffer
                 * @throws {$protobuf.util.ProtocolError} If required fields are missing
                 */
                public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.protobuf.DescriptorProto.ReservedRange;

                /**
                 * Verifies a ReservedRange message.
                 * @param message Plain object to verify
                 * @returns `null` if valid, otherwise the reason why it is not
                 */
                public static verify(message: { [k: string]: any }): (string|null);

                /**
                 * Creates a ReservedRange message from a plain object. Also converts values to their respective internal types.
                 * @param object Plain object
                 * @returns ReservedRange
                 */
                public static fromObject(object: { [k: string]: any }): google.protobuf.DescriptorProto.ReservedRange;

                /**
                 * Creates a plain object from a ReservedRange message. Also converts values to other types if specified.
                 * @param message ReservedRange
                 * @param [options] Conversion options
                 * @returns Plain object
                 */
                public static toObject(message: google.protobuf.DescriptorProto.ReservedRange, options?: $protobuf.IConversionOptions): { [k: string]: any };

                /**
                 * Converts this ReservedRange to JSON.
                 * @returns JSON object
                 */
                public toJSON(): { [k: string]: any };
            }
        }

        /** Properties of an ExtensionRangeOptions. */
        interface IExtensionRangeOptions {

            /** ExtensionRangeOptions uninterpretedOption */
            uninterpretedOption?: (google.protobuf.IUninterpretedOption[]|null);
        }

        /** Represents an ExtensionRangeOptions. */
        class ExtensionRangeOptions implements IExtensionRangeOptions {

            /**
             * Constructs a new ExtensionRangeOptions.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.protobuf.IExtensionRangeOptions);

            /** ExtensionRangeOptions uninterpretedOption. */
            public uninterpretedOption: google.protobuf.IUninterpretedOption[];

            /**
             * Creates a new ExtensionRangeOptions instance using the specified properties.
             * @param [properties] Properties to set
             * @returns ExtensionRangeOptions instance
             */
            public static create(properties?: google.protobuf.IExtensionRangeOptions): google.protobuf.ExtensionRangeOptions;

            /**
             * Encodes the specified ExtensionRangeOptions message. Does not implicitly {@link google.protobuf.ExtensionRangeOptions.verify|verify} messages.
             * @param message ExtensionRangeOptions message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.protobuf.IExtensionRangeOptions, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified ExtensionRangeOptions message, length delimited. Does not implicitly {@link google.protobuf.ExtensionRangeOptions.verify|verify} messages.
             * @param message ExtensionRangeOptions message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.protobuf.IExtensionRangeOptions, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes an ExtensionRangeOptions message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns ExtensionRangeOptions
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.protobuf.ExtensionRangeOptions;

            /**
             * Decodes an ExtensionRangeOptions message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns ExtensionRangeOptions
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.protobuf.ExtensionRangeOptions;

            /**
             * Verifies an ExtensionRangeOptions message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates an ExtensionRangeOptions message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns ExtensionRangeOptions
             */
            public static fromObject(object: { [k: string]: any }): google.protobuf.ExtensionRangeOptions;

            /**
             * Creates a plain object from an ExtensionRangeOptions message. Also converts values to other types if specified.
             * @param message ExtensionRangeOptions
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.protobuf.ExtensionRangeOptions, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this ExtensionRangeOptions to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }

        /** Properties of a FieldDescriptorProto. */
        interface IFieldDescriptorProto {

            /** FieldDescriptorProto name */
            name?: (string|null);

            /** FieldDescriptorProto number */
            number?: (number|null);

            /** FieldDescriptorProto label */
            label?: (google.protobuf.FieldDescriptorProto.Label|null);

            /** FieldDescriptorProto type */
            type?: (google.protobuf.FieldDescriptorProto.Type|null);

            /** FieldDescriptorProto typeName */
            typeName?: (string|null);

            /** FieldDescriptorProto extendee */
            extendee?: (string|null);

            /** FieldDescriptorProto defaultValue */
            defaultValue?: (string|null);

            /** FieldDescriptorProto oneofIndex */
            oneofIndex?: (number|null);

            /** FieldDescriptorProto jsonName */
            jsonName?: (string|null);

            /** FieldDescriptorProto options */
            options?: (google.protobuf.IFieldOptions|null);
        }

        /** Represents a FieldDescriptorProto. */
        class FieldDescriptorProto implements IFieldDescriptorProto {

            /**
             * Constructs a new FieldDescriptorProto.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.protobuf.IFieldDescriptorProto);

            /** FieldDescriptorProto name. */
            public name: string;

            /** FieldDescriptorProto number. */
            public number: number;

            /** FieldDescriptorProto label. */
            public label: google.protobuf.FieldDescriptorProto.Label;

            /** FieldDescriptorProto type. */
            public type: google.protobuf.FieldDescriptorProto.Type;

            /** FieldDescriptorProto typeName. */
            public typeName: string;

            /** FieldDescriptorProto extendee. */
            public extendee: string;

            /** FieldDescriptorProto defaultValue. */
            public defaultValue: string;

            /** FieldDescriptorProto oneofIndex. */
            public oneofIndex: number;

            /** FieldDescriptorProto jsonName. */
            public jsonName: string;

            /** FieldDescriptorProto options. */
            public options?: (google.protobuf.IFieldOptions|null);

            /**
             * Creates a new FieldDescriptorProto instance using the specified properties.
             * @param [properties] Properties to set
             * @returns FieldDescriptorProto instance
             */
            public static create(properties?: google.protobuf.IFieldDescriptorProto): google.protobuf.FieldDescriptorProto;

            /**
             * Encodes the specified FieldDescriptorProto message. Does not implicitly {@link google.protobuf.FieldDescriptorProto.verify|verify} messages.
             * @param message FieldDescriptorProto message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.protobuf.IFieldDescriptorProto, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified FieldDescriptorProto message, length delimited. Does not implicitly {@link google.protobuf.FieldDescriptorProto.verify|verify} messages.
             * @param message FieldDescriptorProto message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.protobuf.IFieldDescriptorProto, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes a FieldDescriptorProto message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns FieldDescriptorProto
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.protobuf.FieldDescriptorProto;

            /**
             * Decodes a FieldDescriptorProto message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns FieldDescriptorProto
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.protobuf.FieldDescriptorProto;

            /**
             * Verifies a FieldDescriptorProto message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates a FieldDescriptorProto message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns FieldDescriptorProto
             */
            public static fromObject(object: { [k: string]: any }): google.protobuf.FieldDescriptorProto;

            /**
             * Creates a plain object from a FieldDescriptorProto message. Also converts values to other types if specified.
             * @param message FieldDescriptorProto
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.protobuf.FieldDescriptorProto, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this FieldDescriptorProto to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }

        namespace FieldDescriptorProto {

            /** Type enum. */
            enum Type {
                TYPE_DOUBLE = 1,
                TYPE_FLOAT = 2,
                TYPE_INT64 = 3,
                TYPE_UINT64 = 4,
                TYPE_INT32 = 5,
                TYPE_FIXED64 = 6,
                TYPE_FIXED32 = 7,
                TYPE_BOOL = 8,
                TYPE_STRING = 9,
                TYPE_GROUP = 10,
                TYPE_MESSAGE = 11,
                TYPE_BYTES = 12,
                TYPE_UINT32 = 13,
                TYPE_ENUM = 14,
                TYPE_SFIXED32 = 15,
                TYPE_SFIXED64 = 16,
                TYPE_SINT32 = 17,
                TYPE_SINT64 = 18
            }

            /** Label enum. */
            enum Label {
                LABEL_OPTIONAL = 1,
                LABEL_REQUIRED = 2,
                LABEL_REPEATED = 3
            }
        }

        /** Properties of an OneofDescriptorProto. */
        interface IOneofDescriptorProto {

            /** OneofDescriptorProto name */
            name?: (string|null);

            /** OneofDescriptorProto options */
            options?: (google.protobuf.IOneofOptions|null);
        }

        /** Represents an OneofDescriptorProto. */
        class OneofDescriptorProto implements IOneofDescriptorProto {

            /**
             * Constructs a new OneofDescriptorProto.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.protobuf.IOneofDescriptorProto);

            /** OneofDescriptorProto name. */
            public name: string;

            /** OneofDescriptorProto options. */
            public options?: (google.protobuf.IOneofOptions|null);

            /**
             * Creates a new OneofDescriptorProto instance using the specified properties.
             * @param [properties] Properties to set
             * @returns OneofDescriptorProto instance
             */
            public static create(properties?: google.protobuf.IOneofDescriptorProto): google.protobuf.OneofDescriptorProto;

            /**
             * Encodes the specified OneofDescriptorProto message. Does not implicitly {@link google.protobuf.OneofDescriptorProto.verify|verify} messages.
             * @param message OneofDescriptorProto message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.protobuf.IOneofDescriptorProto, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified OneofDescriptorProto message, length delimited. Does not implicitly {@link google.protobuf.OneofDescriptorProto.verify|verify} messages.
             * @param message OneofDescriptorProto message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.protobuf.IOneofDescriptorProto, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes an OneofDescriptorProto message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns OneofDescriptorProto
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.protobuf.OneofDescriptorProto;

            /**
             * Decodes an OneofDescriptorProto message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns OneofDescriptorProto
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.protobuf.OneofDescriptorProto;

            /**
             * Verifies an OneofDescriptorProto message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates an OneofDescriptorProto message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns OneofDescriptorProto
             */
            public static fromObject(object: { [k: string]: any }): google.protobuf.OneofDescriptorProto;

            /**
             * Creates a plain object from an OneofDescriptorProto message. Also converts values to other types if specified.
             * @param message OneofDescriptorProto
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.protobuf.OneofDescriptorProto, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this OneofDescriptorProto to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }

        /** Properties of an EnumDescriptorProto. */
        interface IEnumDescriptorProto {

            /** EnumDescriptorProto name */
            name?: (string|null);

            /** EnumDescriptorProto value */
            value?: (google.protobuf.IEnumValueDescriptorProto[]|null);

            /** EnumDescriptorProto options */
            options?: (google.protobuf.IEnumOptions|null);

            /** EnumDescriptorProto reservedRange */
            reservedRange?: (google.protobuf.EnumDescriptorProto.IEnumReservedRange[]|null);

            /** EnumDescriptorProto reservedName */
            reservedName?: (string[]|null);
        }

        /** Represents an EnumDescriptorProto. */
        class EnumDescriptorProto implements IEnumDescriptorProto {

            /**
             * Constructs a new EnumDescriptorProto.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.protobuf.IEnumDescriptorProto);

            /** EnumDescriptorProto name. */
            public name: string;

            /** EnumDescriptorProto value. */
            public value: google.protobuf.IEnumValueDescriptorProto[];

            /** EnumDescriptorProto options. */
            public options?: (google.protobuf.IEnumOptions|null);

            /** EnumDescriptorProto reservedRange. */
            public reservedRange: google.protobuf.EnumDescriptorProto.IEnumReservedRange[];

            /** EnumDescriptorProto reservedName. */
            public reservedName: string[];

            /**
             * Creates a new EnumDescriptorProto instance using the specified properties.
             * @param [properties] Properties to set
             * @returns EnumDescriptorProto instance
             */
            public static create(properties?: google.protobuf.IEnumDescriptorProto): google.protobuf.EnumDescriptorProto;

            /**
             * Encodes the specified EnumDescriptorProto message. Does not implicitly {@link google.protobuf.EnumDescriptorProto.verify|verify} messages.
             * @param message EnumDescriptorProto message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.protobuf.IEnumDescriptorProto, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified EnumDescriptorProto message, length delimited. Does not implicitly {@link google.protobuf.EnumDescriptorProto.verify|verify} messages.
             * @param message EnumDescriptorProto message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.protobuf.IEnumDescriptorProto, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes an EnumDescriptorProto message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns EnumDescriptorProto
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.protobuf.EnumDescriptorProto;

            /**
             * Decodes an EnumDescriptorProto message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns EnumDescriptorProto
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.protobuf.EnumDescriptorProto;

            /**
             * Verifies an EnumDescriptorProto message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates an EnumDescriptorProto message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns EnumDescriptorProto
             */
            public static fromObject(object: { [k: string]: any }): google.protobuf.EnumDescriptorProto;

            /**
             * Creates a plain object from an EnumDescriptorProto message. Also converts values to other types if specified.
             * @param message EnumDescriptorProto
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.protobuf.EnumDescriptorProto, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this EnumDescriptorProto to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }

        namespace EnumDescriptorProto {

            /** Properties of an EnumReservedRange. */
            interface IEnumReservedRange {

                /** EnumReservedRange start */
                start?: (number|null);

                /** EnumReservedRange end */
                end?: (number|null);
            }

            /** Represents an EnumReservedRange. */
            class EnumReservedRange implements IEnumReservedRange {

                /**
                 * Constructs a new EnumReservedRange.
                 * @param [properties] Properties to set
                 */
                constructor(properties?: google.protobuf.EnumDescriptorProto.IEnumReservedRange);

                /** EnumReservedRange start. */
                public start: number;

                /** EnumReservedRange end. */
                public end: number;

                /**
                 * Creates a new EnumReservedRange instance using the specified properties.
                 * @param [properties] Properties to set
                 * @returns EnumReservedRange instance
                 */
                public static create(properties?: google.protobuf.EnumDescriptorProto.IEnumReservedRange): google.protobuf.EnumDescriptorProto.EnumReservedRange;

                /**
                 * Encodes the specified EnumReservedRange message. Does not implicitly {@link google.protobuf.EnumDescriptorProto.EnumReservedRange.verify|verify} messages.
                 * @param message EnumReservedRange message or plain object to encode
                 * @param [writer] Writer to encode to
                 * @returns Writer
                 */
                public static encode(message: google.protobuf.EnumDescriptorProto.IEnumReservedRange, writer?: $protobuf.Writer): $protobuf.Writer;

                /**
                 * Encodes the specified EnumReservedRange message, length delimited. Does not implicitly {@link google.protobuf.EnumDescriptorProto.EnumReservedRange.verify|verify} messages.
                 * @param message EnumReservedRange message or plain object to encode
                 * @param [writer] Writer to encode to
                 * @returns Writer
                 */
                public static encodeDelimited(message: google.protobuf.EnumDescriptorProto.IEnumReservedRange, writer?: $protobuf.Writer): $protobuf.Writer;

                /**
                 * Decodes an EnumReservedRange message from the specified reader or buffer.
                 * @param reader Reader or buffer to decode from
                 * @param [length] Message length if known beforehand
                 * @returns EnumReservedRange
                 * @throws {Error} If the payload is not a reader or valid buffer
                 * @throws {$protobuf.util.ProtocolError} If required fields are missing
                 */
                public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.protobuf.EnumDescriptorProto.EnumReservedRange;

                /**
                 * Decodes an EnumReservedRange message from the specified reader or buffer, length delimited.
                 * @param reader Reader or buffer to decode from
                 * @returns EnumReservedRange
                 * @throws {Error} If the payload is not a reader or valid buffer
                 * @throws {$protobuf.util.ProtocolError} If required fields are missing
                 */
                public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.protobuf.EnumDescriptorProto.EnumReservedRange;

                /**
                 * Verifies an EnumReservedRange message.
                 * @param message Plain object to verify
                 * @returns `null` if valid, otherwise the reason why it is not
                 */
                public static verify(message: { [k: string]: any }): (string|null);

                /**
                 * Creates an EnumReservedRange message from a plain object. Also converts values to their respective internal types.
                 * @param object Plain object
                 * @returns EnumReservedRange
                 */
                public static fromObject(object: { [k: string]: any }): google.protobuf.EnumDescriptorProto.EnumReservedRange;

                /**
                 * Creates a plain object from an EnumReservedRange message. Also converts values to other types if specified.
                 * @param message EnumReservedRange
                 * @param [options] Conversion options
                 * @returns Plain object
                 */
                public static toObject(message: google.protobuf.EnumDescriptorProto.EnumReservedRange, options?: $protobuf.IConversionOptions): { [k: string]: any };

                /**
                 * Converts this EnumReservedRange to JSON.
                 * @returns JSON object
                 */
                public toJSON(): { [k: string]: any };
            }
        }

        /** Properties of an EnumValueDescriptorProto. */
        interface IEnumValueDescriptorProto {

            /** EnumValueDescriptorProto name */
            name?: (string|null);

            /** EnumValueDescriptorProto number */
            number?: (number|null);

            /** EnumValueDescriptorProto options */
            options?: (google.protobuf.IEnumValueOptions|null);
        }

        /** Represents an EnumValueDescriptorProto. */
        class EnumValueDescriptorProto implements IEnumValueDescriptorProto {

            /**
             * Constructs a new EnumValueDescriptorProto.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.protobuf.IEnumValueDescriptorProto);

            /** EnumValueDescriptorProto name. */
            public name: string;

            /** EnumValueDescriptorProto number. */
            public number: number;

            /** EnumValueDescriptorProto options. */
            public options?: (google.protobuf.IEnumValueOptions|null);

            /**
             * Creates a new EnumValueDescriptorProto instance using the specified properties.
             * @param [properties] Properties to set
             * @returns EnumValueDescriptorProto instance
             */
            public static create(properties?: google.protobuf.IEnumValueDescriptorProto): google.protobuf.EnumValueDescriptorProto;

            /**
             * Encodes the specified EnumValueDescriptorProto message. Does not implicitly {@link google.protobuf.EnumValueDescriptorProto.verify|verify} messages.
             * @param message EnumValueDescriptorProto message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.protobuf.IEnumValueDescriptorProto, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified EnumValueDescriptorProto message, length delimited. Does not implicitly {@link google.protobuf.EnumValueDescriptorProto.verify|verify} messages.
             * @param message EnumValueDescriptorProto message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.protobuf.IEnumValueDescriptorProto, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes an EnumValueDescriptorProto message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns EnumValueDescriptorProto
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.protobuf.EnumValueDescriptorProto;

            /**
             * Decodes an EnumValueDescriptorProto message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns EnumValueDescriptorProto
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.protobuf.EnumValueDescriptorProto;

            /**
             * Verifies an EnumValueDescriptorProto message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates an EnumValueDescriptorProto message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns EnumValueDescriptorProto
             */
            public static fromObject(object: { [k: string]: any }): google.protobuf.EnumValueDescriptorProto;

            /**
             * Creates a plain object from an EnumValueDescriptorProto message. Also converts values to other types if specified.
             * @param message EnumValueDescriptorProto
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.protobuf.EnumValueDescriptorProto, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this EnumValueDescriptorProto to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }

        /** Properties of a ServiceDescriptorProto. */
        interface IServiceDescriptorProto {

            /** ServiceDescriptorProto name */
            name?: (string|null);

            /** ServiceDescriptorProto method */
            method?: (google.protobuf.IMethodDescriptorProto[]|null);

            /** ServiceDescriptorProto options */
            options?: (google.protobuf.IServiceOptions|null);
        }

        /** Represents a ServiceDescriptorProto. */
        class ServiceDescriptorProto implements IServiceDescriptorProto {

            /**
             * Constructs a new ServiceDescriptorProto.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.protobuf.IServiceDescriptorProto);

            /** ServiceDescriptorProto name. */
            public name: string;

            /** ServiceDescriptorProto method. */
            public method: google.protobuf.IMethodDescriptorProto[];

            /** ServiceDescriptorProto options. */
            public options?: (google.protobuf.IServiceOptions|null);

            /**
             * Creates a new ServiceDescriptorProto instance using the specified properties.
             * @param [properties] Properties to set
             * @returns ServiceDescriptorProto instance
             */
            public static create(properties?: google.protobuf.IServiceDescriptorProto): google.protobuf.ServiceDescriptorProto;

            /**
             * Encodes the specified ServiceDescriptorProto message. Does not implicitly {@link google.protobuf.ServiceDescriptorProto.verify|verify} messages.
             * @param message ServiceDescriptorProto message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.protobuf.IServiceDescriptorProto, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified ServiceDescriptorProto message, length delimited. Does not implicitly {@link google.protobuf.ServiceDescriptorProto.verify|verify} messages.
             * @param message ServiceDescriptorProto message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.protobuf.IServiceDescriptorProto, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes a ServiceDescriptorProto message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns ServiceDescriptorProto
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.protobuf.ServiceDescriptorProto;

            /**
             * Decodes a ServiceDescriptorProto message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns ServiceDescriptorProto
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.protobuf.ServiceDescriptorProto;

            /**
             * Verifies a ServiceDescriptorProto message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates a ServiceDescriptorProto message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns ServiceDescriptorProto
             */
            public static fromObject(object: { [k: string]: any }): google.protobuf.ServiceDescriptorProto;

            /**
             * Creates a plain object from a ServiceDescriptorProto message. Also converts values to other types if specified.
             * @param message ServiceDescriptorProto
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.protobuf.ServiceDescriptorProto, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this ServiceDescriptorProto to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }

        /** Properties of a MethodDescriptorProto. */
        interface IMethodDescriptorProto {

            /** MethodDescriptorProto name */
            name?: (string|null);

            /** MethodDescriptorProto inputType */
            inputType?: (string|null);

            /** MethodDescriptorProto outputType */
            outputType?: (string|null);

            /** MethodDescriptorProto options */
            options?: (google.protobuf.IMethodOptions|null);

            /** MethodDescriptorProto clientStreaming */
            clientStreaming?: (boolean|null);

            /** MethodDescriptorProto serverStreaming */
            serverStreaming?: (boolean|null);
        }

        /** Represents a MethodDescriptorProto. */
        class MethodDescriptorProto implements IMethodDescriptorProto {

            /**
             * Constructs a new MethodDescriptorProto.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.protobuf.IMethodDescriptorProto);

            /** MethodDescriptorProto name. */
            public name: string;

            /** MethodDescriptorProto inputType. */
            public inputType: string;

            /** MethodDescriptorProto outputType. */
            public outputType: string;

            /** MethodDescriptorProto options. */
            public options?: (google.protobuf.IMethodOptions|null);

            /** MethodDescriptorProto clientStreaming. */
            public clientStreaming: boolean;

            /** MethodDescriptorProto serverStreaming. */
            public serverStreaming: boolean;

            /**
             * Creates a new MethodDescriptorProto instance using the specified properties.
             * @param [properties] Properties to set
             * @returns MethodDescriptorProto instance
             */
            public static create(properties?: google.protobuf.IMethodDescriptorProto): google.protobuf.MethodDescriptorProto;

            /**
             * Encodes the specified MethodDescriptorProto message. Does not implicitly {@link google.protobuf.MethodDescriptorProto.verify|verify} messages.
             * @param message MethodDescriptorProto message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.protobuf.IMethodDescriptorProto, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified MethodDescriptorProto message, length delimited. Does not implicitly {@link google.protobuf.MethodDescriptorProto.verify|verify} messages.
             * @param message MethodDescriptorProto message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.protobuf.IMethodDescriptorProto, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes a MethodDescriptorProto message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns MethodDescriptorProto
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.protobuf.MethodDescriptorProto;

            /**
             * Decodes a MethodDescriptorProto message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns MethodDescriptorProto
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.protobuf.MethodDescriptorProto;

            /**
             * Verifies a MethodDescriptorProto message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates a MethodDescriptorProto message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns MethodDescriptorProto
             */
            public static fromObject(object: { [k: string]: any }): google.protobuf.MethodDescriptorProto;

            /**
             * Creates a plain object from a MethodDescriptorProto message. Also converts values to other types if specified.
             * @param message MethodDescriptorProto
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.protobuf.MethodDescriptorProto, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this MethodDescriptorProto to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }

        /** Properties of a FileOptions. */
        interface IFileOptions {

            /** FileOptions javaPackage */
            javaPackage?: (string|null);

            /** FileOptions javaOuterClassname */
            javaOuterClassname?: (string|null);

            /** FileOptions javaMultipleFiles */
            javaMultipleFiles?: (boolean|null);

            /** FileOptions javaGenerateEqualsAndHash */
            javaGenerateEqualsAndHash?: (boolean|null);

            /** FileOptions javaStringCheckUtf8 */
            javaStringCheckUtf8?: (boolean|null);

            /** FileOptions optimizeFor */
            optimizeFor?: (google.protobuf.FileOptions.OptimizeMode|null);

            /** FileOptions goPackage */
            goPackage?: (string|null);

            /** FileOptions ccGenericServices */
            ccGenericServices?: (boolean|null);

            /** FileOptions javaGenericServices */
            javaGenericServices?: (boolean|null);

            /** FileOptions pyGenericServices */
            pyGenericServices?: (boolean|null);

            /** FileOptions phpGenericServices */
            phpGenericServices?: (boolean|null);

            /** FileOptions deprecated */
            deprecated?: (boolean|null);

            /** FileOptions ccEnableArenas */
            ccEnableArenas?: (boolean|null);

            /** FileOptions objcClassPrefix */
            objcClassPrefix?: (string|null);

            /** FileOptions csharpNamespace */
            csharpNamespace?: (string|null);

            /** FileOptions swiftPrefix */
            swiftPrefix?: (string|null);

            /** FileOptions phpClassPrefix */
            phpClassPrefix?: (string|null);

            /** FileOptions phpNamespace */
            phpNamespace?: (string|null);

            /** FileOptions phpMetadataNamespace */
            phpMetadataNamespace?: (string|null);

            /** FileOptions rubyPackage */
            rubyPackage?: (string|null);

            /** FileOptions uninterpretedOption */
            uninterpretedOption?: (google.protobuf.IUninterpretedOption[]|null);
        }

        /** Represents a FileOptions. */
        class FileOptions implements IFileOptions {

            /**
             * Constructs a new FileOptions.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.protobuf.IFileOptions);

            /** FileOptions javaPackage. */
            public javaPackage: string;

            /** FileOptions javaOuterClassname. */
            public javaOuterClassname: string;

            /** FileOptions javaMultipleFiles. */
            public javaMultipleFiles: boolean;

            /** FileOptions javaGenerateEqualsAndHash. */
            public javaGenerateEqualsAndHash: boolean;

            /** FileOptions javaStringCheckUtf8. */
            public javaStringCheckUtf8: boolean;

            /** FileOptions optimizeFor. */
            public optimizeFor: google.protobuf.FileOptions.OptimizeMode;

            /** FileOptions goPackage. */
            public goPackage: string;

            /** FileOptions ccGenericServices. */
            public ccGenericServices: boolean;

            /** FileOptions javaGenericServices. */
            public javaGenericServices: boolean;

            /** FileOptions pyGenericServices. */
            public pyGenericServices: boolean;

            /** FileOptions phpGenericServices. */
            public phpGenericServices: boolean;

            /** FileOptions deprecated. */
            public deprecated: boolean;

            /** FileOptions ccEnableArenas. */
            public ccEnableArenas: boolean;

            /** FileOptions objcClassPrefix. */
            public objcClassPrefix: string;

            /** FileOptions csharpNamespace. */
            public csharpNamespace: string;

            /** FileOptions swiftPrefix. */
            public swiftPrefix: string;

            /** FileOptions phpClassPrefix. */
            public phpClassPrefix: string;

            /** FileOptions phpNamespace. */
            public phpNamespace: string;

            /** FileOptions phpMetadataNamespace. */
            public phpMetadataNamespace: string;

            /** FileOptions rubyPackage. */
            public rubyPackage: string;

            /** FileOptions uninterpretedOption. */
            public uninterpretedOption: google.protobuf.IUninterpretedOption[];

            /**
             * Creates a new FileOptions instance using the specified properties.
             * @param [properties] Properties to set
             * @returns FileOptions instance
             */
            public static create(properties?: google.protobuf.IFileOptions): google.protobuf.FileOptions;

            /**
             * Encodes the specified FileOptions message. Does not implicitly {@link google.protobuf.FileOptions.verify|verify} messages.
             * @param message FileOptions message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.protobuf.IFileOptions, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified FileOptions message, length delimited. Does not implicitly {@link google.protobuf.FileOptions.verify|verify} messages.
             * @param message FileOptions message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.protobuf.IFileOptions, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes a FileOptions message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns FileOptions
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.protobuf.FileOptions;

            /**
             * Decodes a FileOptions message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns FileOptions
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.protobuf.FileOptions;

            /**
             * Verifies a FileOptions message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates a FileOptions message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns FileOptions
             */
            public static fromObject(object: { [k: string]: any }): google.protobuf.FileOptions;

            /**
             * Creates a plain object from a FileOptions message. Also converts values to other types if specified.
             * @param message FileOptions
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.protobuf.FileOptions, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this FileOptions to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }

        namespace FileOptions {

            /** OptimizeMode enum. */
            enum OptimizeMode {
                SPEED = 1,
                CODE_SIZE = 2,
                LITE_RUNTIME = 3
            }
        }

        /** Properties of a MessageOptions. */
        interface IMessageOptions {

            /** MessageOptions messageSetWireFormat */
            messageSetWireFormat?: (boolean|null);

            /** MessageOptions noStandardDescriptorAccessor */
            noStandardDescriptorAccessor?: (boolean|null);

            /** MessageOptions deprecated */
            deprecated?: (boolean|null);

            /** MessageOptions mapEntry */
            mapEntry?: (boolean|null);

            /** MessageOptions uninterpretedOption */
            uninterpretedOption?: (google.protobuf.IUninterpretedOption[]|null);
        }

        /** Represents a MessageOptions. */
        class MessageOptions implements IMessageOptions {

            /**
             * Constructs a new MessageOptions.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.protobuf.IMessageOptions);

            /** MessageOptions messageSetWireFormat. */
            public messageSetWireFormat: boolean;

            /** MessageOptions noStandardDescriptorAccessor. */
            public noStandardDescriptorAccessor: boolean;

            /** MessageOptions deprecated. */
            public deprecated: boolean;

            /** MessageOptions mapEntry. */
            public mapEntry: boolean;

            /** MessageOptions uninterpretedOption. */
            public uninterpretedOption: google.protobuf.IUninterpretedOption[];

            /**
             * Creates a new MessageOptions instance using the specified properties.
             * @param [properties] Properties to set
             * @returns MessageOptions instance
             */
            public static create(properties?: google.protobuf.IMessageOptions): google.protobuf.MessageOptions;

            /**
             * Encodes the specified MessageOptions message. Does not implicitly {@link google.protobuf.MessageOptions.verify|verify} messages.
             * @param message MessageOptions message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.protobuf.IMessageOptions, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified MessageOptions message, length delimited. Does not implicitly {@link google.protobuf.MessageOptions.verify|verify} messages.
             * @param message MessageOptions message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.protobuf.IMessageOptions, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes a MessageOptions message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns MessageOptions
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.protobuf.MessageOptions;

            /**
             * Decodes a MessageOptions message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns MessageOptions
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.protobuf.MessageOptions;

            /**
             * Verifies a MessageOptions message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates a MessageOptions message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns MessageOptions
             */
            public static fromObject(object: { [k: string]: any }): google.protobuf.MessageOptions;

            /**
             * Creates a plain object from a MessageOptions message. Also converts values to other types if specified.
             * @param message MessageOptions
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.protobuf.MessageOptions, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this MessageOptions to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }

        /** Properties of a FieldOptions. */
        interface IFieldOptions {

            /** FieldOptions ctype */
            ctype?: (google.protobuf.FieldOptions.CType|null);

            /** FieldOptions packed */
            packed?: (boolean|null);

            /** FieldOptions jstype */
            jstype?: (google.protobuf.FieldOptions.JSType|null);

            /** FieldOptions lazy */
            lazy?: (boolean|null);

            /** FieldOptions deprecated */
            deprecated?: (boolean|null);

            /** FieldOptions weak */
            weak?: (boolean|null);

            /** FieldOptions uninterpretedOption */
            uninterpretedOption?: (google.protobuf.IUninterpretedOption[]|null);
        }

        /** Represents a FieldOptions. */
        class FieldOptions implements IFieldOptions {

            /**
             * Constructs a new FieldOptions.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.protobuf.IFieldOptions);

            /** FieldOptions ctype. */
            public ctype: google.protobuf.FieldOptions.CType;

            /** FieldOptions packed. */
            public packed: boolean;

            /** FieldOptions jstype. */
            public jstype: google.protobuf.FieldOptions.JSType;

            /** FieldOptions lazy. */
            public lazy: boolean;

            /** FieldOptions deprecated. */
            public deprecated: boolean;

            /** FieldOptions weak. */
            public weak: boolean;

            /** FieldOptions uninterpretedOption. */
            public uninterpretedOption: google.protobuf.IUninterpretedOption[];

            /**
             * Creates a new FieldOptions instance using the specified properties.
             * @param [properties] Properties to set
             * @returns FieldOptions instance
             */
            public static create(properties?: google.protobuf.IFieldOptions): google.protobuf.FieldOptions;

            /**
             * Encodes the specified FieldOptions message. Does not implicitly {@link google.protobuf.FieldOptions.verify|verify} messages.
             * @param message FieldOptions message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.protobuf.IFieldOptions, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified FieldOptions message, length delimited. Does not implicitly {@link google.protobuf.FieldOptions.verify|verify} messages.
             * @param message FieldOptions message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.protobuf.IFieldOptions, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes a FieldOptions message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns FieldOptions
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.protobuf.FieldOptions;

            /**
             * Decodes a FieldOptions message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns FieldOptions
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.protobuf.FieldOptions;

            /**
             * Verifies a FieldOptions message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates a FieldOptions message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns FieldOptions
             */
            public static fromObject(object: { [k: string]: any }): google.protobuf.FieldOptions;

            /**
             * Creates a plain object from a FieldOptions message. Also converts values to other types if specified.
             * @param message FieldOptions
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.protobuf.FieldOptions, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this FieldOptions to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }

        namespace FieldOptions {

            /** CType enum. */
            enum CType {
                STRING = 0,
                CORD = 1,
                STRING_PIECE = 2
            }

            /** JSType enum. */
            enum JSType {
                JS_NORMAL = 0,
                JS_STRING = 1,
                JS_NUMBER = 2
            }
        }

        /** Properties of an OneofOptions. */
        interface IOneofOptions {

            /** OneofOptions uninterpretedOption */
            uninterpretedOption?: (google.protobuf.IUninterpretedOption[]|null);
        }

        /** Represents an OneofOptions. */
        class OneofOptions implements IOneofOptions {

            /**
             * Constructs a new OneofOptions.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.protobuf.IOneofOptions);

            /** OneofOptions uninterpretedOption. */
            public uninterpretedOption: google.protobuf.IUninterpretedOption[];

            /**
             * Creates a new OneofOptions instance using the specified properties.
             * @param [properties] Properties to set
             * @returns OneofOptions instance
             */
            public static create(properties?: google.protobuf.IOneofOptions): google.protobuf.OneofOptions;

            /**
             * Encodes the specified OneofOptions message. Does not implicitly {@link google.protobuf.OneofOptions.verify|verify} messages.
             * @param message OneofOptions message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.protobuf.IOneofOptions, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified OneofOptions message, length delimited. Does not implicitly {@link google.protobuf.OneofOptions.verify|verify} messages.
             * @param message OneofOptions message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.protobuf.IOneofOptions, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes an OneofOptions message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns OneofOptions
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.protobuf.OneofOptions;

            /**
             * Decodes an OneofOptions message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns OneofOptions
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.protobuf.OneofOptions;

            /**
             * Verifies an OneofOptions message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates an OneofOptions message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns OneofOptions
             */
            public static fromObject(object: { [k: string]: any }): google.protobuf.OneofOptions;

            /**
             * Creates a plain object from an OneofOptions message. Also converts values to other types if specified.
             * @param message OneofOptions
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.protobuf.OneofOptions, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this OneofOptions to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }

        /** Properties of an EnumOptions. */
        interface IEnumOptions {

            /** EnumOptions allowAlias */
            allowAlias?: (boolean|null);

            /** EnumOptions deprecated */
            deprecated?: (boolean|null);

            /** EnumOptions uninterpretedOption */
            uninterpretedOption?: (google.protobuf.IUninterpretedOption[]|null);
        }

        /** Represents an EnumOptions. */
        class EnumOptions implements IEnumOptions {

            /**
             * Constructs a new EnumOptions.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.protobuf.IEnumOptions);

            /** EnumOptions allowAlias. */
            public allowAlias: boolean;

            /** EnumOptions deprecated. */
            public deprecated: boolean;

            /** EnumOptions uninterpretedOption. */
            public uninterpretedOption: google.protobuf.IUninterpretedOption[];

            /**
             * Creates a new EnumOptions instance using the specified properties.
             * @param [properties] Properties to set
             * @returns EnumOptions instance
             */
            public static create(properties?: google.protobuf.IEnumOptions): google.protobuf.EnumOptions;

            /**
             * Encodes the specified EnumOptions message. Does not implicitly {@link google.protobuf.EnumOptions.verify|verify} messages.
             * @param message EnumOptions message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.protobuf.IEnumOptions, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified EnumOptions message, length delimited. Does not implicitly {@link google.protobuf.EnumOptions.verify|verify} messages.
             * @param message EnumOptions message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.protobuf.IEnumOptions, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes an EnumOptions message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns EnumOptions
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.protobuf.EnumOptions;

            /**
             * Decodes an EnumOptions message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns EnumOptions
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.protobuf.EnumOptions;

            /**
             * Verifies an EnumOptions message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates an EnumOptions message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns EnumOptions
             */
            public static fromObject(object: { [k: string]: any }): google.protobuf.EnumOptions;

            /**
             * Creates a plain object from an EnumOptions message. Also converts values to other types if specified.
             * @param message EnumOptions
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.protobuf.EnumOptions, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this EnumOptions to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }

        /** Properties of an EnumValueOptions. */
        interface IEnumValueOptions {

            /** EnumValueOptions deprecated */
            deprecated?: (boolean|null);

            /** EnumValueOptions uninterpretedOption */
            uninterpretedOption?: (google.protobuf.IUninterpretedOption[]|null);
        }

        /** Represents an EnumValueOptions. */
        class EnumValueOptions implements IEnumValueOptions {

            /**
             * Constructs a new EnumValueOptions.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.protobuf.IEnumValueOptions);

            /** EnumValueOptions deprecated. */
            public deprecated: boolean;

            /** EnumValueOptions uninterpretedOption. */
            public uninterpretedOption: google.protobuf.IUninterpretedOption[];

            /**
             * Creates a new EnumValueOptions instance using the specified properties.
             * @param [properties] Properties to set
             * @returns EnumValueOptions instance
             */
            public static create(properties?: google.protobuf.IEnumValueOptions): google.protobuf.EnumValueOptions;

            /**
             * Encodes the specified EnumValueOptions message. Does not implicitly {@link google.protobuf.EnumValueOptions.verify|verify} messages.
             * @param message EnumValueOptions message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.protobuf.IEnumValueOptions, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified EnumValueOptions message, length delimited. Does not implicitly {@link google.protobuf.EnumValueOptions.verify|verify} messages.
             * @param message EnumValueOptions message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.protobuf.IEnumValueOptions, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes an EnumValueOptions message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns EnumValueOptions
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.protobuf.EnumValueOptions;

            /**
             * Decodes an EnumValueOptions message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns EnumValueOptions
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.protobuf.EnumValueOptions;

            /**
             * Verifies an EnumValueOptions message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates an EnumValueOptions message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns EnumValueOptions
             */
            public static fromObject(object: { [k: string]: any }): google.protobuf.EnumValueOptions;

            /**
             * Creates a plain object from an EnumValueOptions message. Also converts values to other types if specified.
             * @param message EnumValueOptions
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.protobuf.EnumValueOptions, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this EnumValueOptions to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }

        /** Properties of a ServiceOptions. */
        interface IServiceOptions {

            /** ServiceOptions deprecated */
            deprecated?: (boolean|null);

            /** ServiceOptions uninterpretedOption */
            uninterpretedOption?: (google.protobuf.IUninterpretedOption[]|null);

            /** ServiceOptions .google.api.defaultHost */
            ".google.api.defaultHost"?: (string|null);

            /** ServiceOptions .google.api.oauthScopes */
            ".google.api.oauthScopes"?: (string|null);
        }

        /** Represents a ServiceOptions. */
        class ServiceOptions implements IServiceOptions {

            /**
             * Constructs a new ServiceOptions.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.protobuf.IServiceOptions);

            /** ServiceOptions deprecated. */
            public deprecated: boolean;

            /** ServiceOptions uninterpretedOption. */
            public uninterpretedOption: google.protobuf.IUninterpretedOption[];

            /**
             * Creates a new ServiceOptions instance using the specified properties.
             * @param [properties] Properties to set
             * @returns ServiceOptions instance
             */
            public static create(properties?: google.protobuf.IServiceOptions): google.protobuf.ServiceOptions;

            /**
             * Encodes the specified ServiceOptions message. Does not implicitly {@link google.protobuf.ServiceOptions.verify|verify} messages.
             * @param message ServiceOptions message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.protobuf.IServiceOptions, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified ServiceOptions message, length delimited. Does not implicitly {@link google.protobuf.ServiceOptions.verify|verify} messages.
             * @param message ServiceOptions message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.protobuf.IServiceOptions, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes a ServiceOptions message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns ServiceOptions
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.protobuf.ServiceOptions;

            /**
             * Decodes a ServiceOptions message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns ServiceOptions
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.protobuf.ServiceOptions;

            /**
             * Verifies a ServiceOptions message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates a ServiceOptions message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns ServiceOptions
             */
            public static fromObject(object: { [k: string]: any }): google.protobuf.ServiceOptions;

            /**
             * Creates a plain object from a ServiceOptions message. Also converts values to other types if specified.
             * @param message ServiceOptions
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.protobuf.ServiceOptions, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this ServiceOptions to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }

        /** Properties of a MethodOptions. */
        interface IMethodOptions {

            /** MethodOptions deprecated */
            deprecated?: (boolean|null);

            /** MethodOptions idempotencyLevel */
            idempotencyLevel?: (google.protobuf.MethodOptions.IdempotencyLevel|null);

            /** MethodOptions uninterpretedOption */
            uninterpretedOption?: (google.protobuf.IUninterpretedOption[]|null);

            /** MethodOptions .google.api.http */
            ".google.api.http"?: (google.api.IHttpRule|null);

            /** MethodOptions .google.api.methodSignature */
            ".google.api.methodSignature"?: (string[]|null);

            /** MethodOptions .google.longrunning.operationInfo */
            ".google.longrunning.operationInfo"?: (google.longrunning.IOperationInfo|null);
        }

        /** Represents a MethodOptions. */
        class MethodOptions implements IMethodOptions {

            /**
             * Constructs a new MethodOptions.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.protobuf.IMethodOptions);

            /** MethodOptions deprecated. */
            public deprecated: boolean;

            /** MethodOptions idempotencyLevel. */
            public idempotencyLevel: google.protobuf.MethodOptions.IdempotencyLevel;

            /** MethodOptions uninterpretedOption. */
            public uninterpretedOption: google.protobuf.IUninterpretedOption[];

            /**
             * Creates a new MethodOptions instance using the specified properties.
             * @param [properties] Properties to set
             * @returns MethodOptions instance
             */
            public static create(properties?: google.protobuf.IMethodOptions): google.protobuf.MethodOptions;

            /**
             * Encodes the specified MethodOptions message. Does not implicitly {@link google.protobuf.MethodOptions.verify|verify} messages.
             * @param message MethodOptions message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.protobuf.IMethodOptions, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified MethodOptions message, length delimited. Does not implicitly {@link google.protobuf.MethodOptions.verify|verify} messages.
             * @param message MethodOptions message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.protobuf.IMethodOptions, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes a MethodOptions message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns MethodOptions
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.protobuf.MethodOptions;

            /**
             * Decodes a MethodOptions message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns MethodOptions
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.protobuf.MethodOptions;

            /**
             * Verifies a MethodOptions message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates a MethodOptions message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns MethodOptions
             */
            public static fromObject(object: { [k: string]: any }): google.protobuf.MethodOptions;

            /**
             * Creates a plain object from a MethodOptions message. Also converts values to other types if specified.
             * @param message MethodOptions
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.protobuf.MethodOptions, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this MethodOptions to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }

        namespace MethodOptions {

            /** IdempotencyLevel enum. */
            enum IdempotencyLevel {
                IDEMPOTENCY_UNKNOWN = 0,
                NO_SIDE_EFFECTS = 1,
                IDEMPOTENT = 2
            }
        }

        /** Properties of an UninterpretedOption. */
        interface IUninterpretedOption {

            /** UninterpretedOption name */
            name?: (google.protobuf.UninterpretedOption.INamePart[]|null);

            /** UninterpretedOption identifierValue */
            identifierValue?: (string|null);

            /** UninterpretedOption positiveIntValue */
            positiveIntValue?: (number|Long|null);

            /** UninterpretedOption negativeIntValue */
            negativeIntValue?: (number|Long|null);

            /** UninterpretedOption doubleValue */
            doubleValue?: (number|null);

            /** UninterpretedOption stringValue */
            stringValue?: (Uint8Array|null);

            /** UninterpretedOption aggregateValue */
            aggregateValue?: (string|null);
        }

        /** Represents an UninterpretedOption. */
        class UninterpretedOption implements IUninterpretedOption {

            /**
             * Constructs a new UninterpretedOption.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.protobuf.IUninterpretedOption);

            /** UninterpretedOption name. */
            public name: google.protobuf.UninterpretedOption.INamePart[];

            /** UninterpretedOption identifierValue. */
            public identifierValue: string;

            /** UninterpretedOption positiveIntValue. */
            public positiveIntValue: (number|Long);

            /** UninterpretedOption negativeIntValue. */
            public negativeIntValue: (number|Long);

            /** UninterpretedOption doubleValue. */
            public doubleValue: number;

            /** UninterpretedOption stringValue. */
            public stringValue: Uint8Array;

            /** UninterpretedOption aggregateValue. */
            public aggregateValue: string;

            /**
             * Creates a new UninterpretedOption instance using the specified properties.
             * @param [properties] Properties to set
             * @returns UninterpretedOption instance
             */
            public static create(properties?: google.protobuf.IUninterpretedOption): google.protobuf.UninterpretedOption;

            /**
             * Encodes the specified UninterpretedOption message. Does not implicitly {@link google.protobuf.UninterpretedOption.verify|verify} messages.
             * @param message UninterpretedOption message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.protobuf.IUninterpretedOption, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified UninterpretedOption message, length delimited. Does not implicitly {@link google.protobuf.UninterpretedOption.verify|verify} messages.
             * @param message UninterpretedOption message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.protobuf.IUninterpretedOption, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes an UninterpretedOption message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns UninterpretedOption
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.protobuf.UninterpretedOption;

            /**
             * Decodes an UninterpretedOption message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns UninterpretedOption
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.protobuf.UninterpretedOption;

            /**
             * Verifies an UninterpretedOption message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates an UninterpretedOption message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns UninterpretedOption
             */
            public static fromObject(object: { [k: string]: any }): google.protobuf.UninterpretedOption;

            /**
             * Creates a plain object from an UninterpretedOption message. Also converts values to other types if specified.
             * @param message UninterpretedOption
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.protobuf.UninterpretedOption, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this UninterpretedOption to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }

        namespace UninterpretedOption {

            /** Properties of a NamePart. */
            interface INamePart {

                /** NamePart namePart */
                namePart: string;

                /** NamePart isExtension */
                isExtension: boolean;
            }

            /** Represents a NamePart. */
            class NamePart implements INamePart {

                /**
                 * Constructs a new NamePart.
                 * @param [properties] Properties to set
                 */
                constructor(properties?: google.protobuf.UninterpretedOption.INamePart);

                /** NamePart namePart. */
                public namePart: string;

                /** NamePart isExtension. */
                public isExtension: boolean;

                /**
                 * Creates a new NamePart instance using the specified properties.
                 * @param [properties] Properties to set
                 * @returns NamePart instance
                 */
                public static create(properties?: google.protobuf.UninterpretedOption.INamePart): google.protobuf.UninterpretedOption.NamePart;

                /**
                 * Encodes the specified NamePart message. Does not implicitly {@link google.protobuf.UninterpretedOption.NamePart.verify|verify} messages.
                 * @param message NamePart message or plain object to encode
                 * @param [writer] Writer to encode to
                 * @returns Writer
                 */
                public static encode(message: google.protobuf.UninterpretedOption.INamePart, writer?: $protobuf.Writer): $protobuf.Writer;

                /**
                 * Encodes the specified NamePart message, length delimited. Does not implicitly {@link google.protobuf.UninterpretedOption.NamePart.verify|verify} messages.
                 * @param message NamePart message or plain object to encode
                 * @param [writer] Writer to encode to
                 * @returns Writer
                 */
                public static encodeDelimited(message: google.protobuf.UninterpretedOption.INamePart, writer?: $protobuf.Writer): $protobuf.Writer;

                /**
                 * Decodes a NamePart message from the specified reader or buffer.
                 * @param reader Reader or buffer to decode from
                 * @param [length] Message length if known beforehand
                 * @returns NamePart
                 * @throws {Error} If the payload is not a reader or valid buffer
                 * @throws {$protobuf.util.ProtocolError} If required fields are missing
                 */
                public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.protobuf.UninterpretedOption.NamePart;

                /**
                 * Decodes a NamePart message from the specified reader or buffer, length delimited.
                 * @param reader Reader or buffer to decode from
                 * @returns NamePart
                 * @throws {Error} If the payload is not a reader or valid buffer
                 * @throws {$protobuf.util.ProtocolError} If required fields are missing
                 */
                public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.protobuf.UninterpretedOption.NamePart;

                /**
                 * Verifies a NamePart message.
                 * @param message Plain object to verify
                 * @returns `null` if valid, otherwise the reason why it is not
                 */
                public static verify(message: { [k: string]: any }): (string|null);

                /**
                 * Creates a NamePart message from a plain object. Also converts values to their respective internal types.
                 * @param object Plain object
                 * @returns NamePart
                 */
                public static fromObject(object: { [k: string]: any }): google.protobuf.UninterpretedOption.NamePart;

                /**
                 * Creates a plain object from a NamePart message. Also converts values to other types if specified.
                 * @param message NamePart
                 * @param [options] Conversion options
                 * @returns Plain object
                 */
                public static toObject(message: google.protobuf.UninterpretedOption.NamePart, options?: $protobuf.IConversionOptions): { [k: string]: any };

                /**
                 * Converts this NamePart to JSON.
                 * @returns JSON object
                 */
                public toJSON(): { [k: string]: any };
            }
        }

        /** Properties of a SourceCodeInfo. */
        interface ISourceCodeInfo {

            /** SourceCodeInfo location */
            location?: (google.protobuf.SourceCodeInfo.ILocation[]|null);
        }

        /** Represents a SourceCodeInfo. */
        class SourceCodeInfo implements ISourceCodeInfo {

            /**
             * Constructs a new SourceCodeInfo.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.protobuf.ISourceCodeInfo);

            /** SourceCodeInfo location. */
            public location: google.protobuf.SourceCodeInfo.ILocation[];

            /**
             * Creates a new SourceCodeInfo instance using the specified properties.
             * @param [properties] Properties to set
             * @returns SourceCodeInfo instance
             */
            public static create(properties?: google.protobuf.ISourceCodeInfo): google.protobuf.SourceCodeInfo;

            /**
             * Encodes the specified SourceCodeInfo message. Does not implicitly {@link google.protobuf.SourceCodeInfo.verify|verify} messages.
             * @param message SourceCodeInfo message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.protobuf.ISourceCodeInfo, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified SourceCodeInfo message, length delimited. Does not implicitly {@link google.protobuf.SourceCodeInfo.verify|verify} messages.
             * @param message SourceCodeInfo message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.protobuf.ISourceCodeInfo, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes a SourceCodeInfo message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns SourceCodeInfo
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.protobuf.SourceCodeInfo;

            /**
             * Decodes a SourceCodeInfo message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns SourceCodeInfo
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.protobuf.SourceCodeInfo;

            /**
             * Verifies a SourceCodeInfo message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates a SourceCodeInfo message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns SourceCodeInfo
             */
            public static fromObject(object: { [k: string]: any }): google.protobuf.SourceCodeInfo;

            /**
             * Creates a plain object from a SourceCodeInfo message. Also converts values to other types if specified.
             * @param message SourceCodeInfo
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.protobuf.SourceCodeInfo, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this SourceCodeInfo to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }

        namespace SourceCodeInfo {

            /** Properties of a Location. */
            interface ILocation {

                /** Location path */
                path?: (number[]|null);

                /** Location span */
                span?: (number[]|null);

                /** Location leadingComments */
                leadingComments?: (string|null);

                /** Location trailingComments */
                trailingComments?: (string|null);

                /** Location leadingDetachedComments */
                leadingDetachedComments?: (string[]|null);
            }

            /** Represents a Location. */
            class Location implements ILocation {

                /**
                 * Constructs a new Location.
                 * @param [properties] Properties to set
                 */
                constructor(properties?: google.protobuf.SourceCodeInfo.ILocation);

                /** Location path. */
                public path: number[];

                /** Location span. */
                public span: number[];

                /** Location leadingComments. */
                public leadingComments: string;

                /** Location trailingComments. */
                public trailingComments: string;

                /** Location leadingDetachedComments. */
                public leadingDetachedComments: string[];

                /**
                 * Creates a new Location instance using the specified properties.
                 * @param [properties] Properties to set
                 * @returns Location instance
                 */
                public static create(properties?: google.protobuf.SourceCodeInfo.ILocation): google.protobuf.SourceCodeInfo.Location;

                /**
                 * Encodes the specified Location message. Does not implicitly {@link google.protobuf.SourceCodeInfo.Location.verify|verify} messages.
                 * @param message Location message or plain object to encode
                 * @param [writer] Writer to encode to
                 * @returns Writer
                 */
                public static encode(message: google.protobuf.SourceCodeInfo.ILocation, writer?: $protobuf.Writer): $protobuf.Writer;

                /**
                 * Encodes the specified Location message, length delimited. Does not implicitly {@link google.protobuf.SourceCodeInfo.Location.verify|verify} messages.
                 * @param message Location message or plain object to encode
                 * @param [writer] Writer to encode to
                 * @returns Writer
                 */
                public static encodeDelimited(message: google.protobuf.SourceCodeInfo.ILocation, writer?: $protobuf.Writer): $protobuf.Writer;

                /**
                 * Decodes a Location message from the specified reader or buffer.
                 * @param reader Reader or buffer to decode from
                 * @param [length] Message length if known beforehand
                 * @returns Location
                 * @throws {Error} If the payload is not a reader or valid buffer
                 * @throws {$protobuf.util.ProtocolError} If required fields are missing
                 */
                public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.protobuf.SourceCodeInfo.Location;

                /**
                 * Decodes a Location message from the specified reader or buffer, length delimited.
                 * @param reader Reader or buffer to decode from
                 * @returns Location
                 * @throws {Error} If the payload is not a reader or valid buffer
                 * @throws {$protobuf.util.ProtocolError} If required fields are missing
                 */
                public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.protobuf.SourceCodeInfo.Location;

                /**
                 * Verifies a Location message.
                 * @param message Plain object to verify
                 * @returns `null` if valid, otherwise the reason why it is not
                 */
                public static verify(message: { [k: string]: any }): (string|null);

                /**
                 * Creates a Location message from a plain object. Also converts values to their respective internal types.
                 * @param object Plain object
                 * @returns Location
                 */
                public static fromObject(object: { [k: string]: any }): google.protobuf.SourceCodeInfo.Location;

                /**
                 * Creates a plain object from a Location message. Also converts values to other types if specified.
                 * @param message Location
                 * @param [options] Conversion options
                 * @returns Plain object
                 */
                public static toObject(message: google.protobuf.SourceCodeInfo.Location, options?: $protobuf.IConversionOptions): { [k: string]: any };

                /**
                 * Converts this Location to JSON.
                 * @returns JSON object
                 */
                public toJSON(): { [k: string]: any };
            }
        }

        /** Properties of a GeneratedCodeInfo. */
        interface IGeneratedCodeInfo {

            /** GeneratedCodeInfo annotation */
            annotation?: (google.protobuf.GeneratedCodeInfo.IAnnotation[]|null);
        }

        /** Represents a GeneratedCodeInfo. */
        class GeneratedCodeInfo implements IGeneratedCodeInfo {

            /**
             * Constructs a new GeneratedCodeInfo.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.protobuf.IGeneratedCodeInfo);

            /** GeneratedCodeInfo annotation. */
            public annotation: google.protobuf.GeneratedCodeInfo.IAnnotation[];

            /**
             * Creates a new GeneratedCodeInfo instance using the specified properties.
             * @param [properties] Properties to set
             * @returns GeneratedCodeInfo instance
             */
            public static create(properties?: google.protobuf.IGeneratedCodeInfo): google.protobuf.GeneratedCodeInfo;

            /**
             * Encodes the specified GeneratedCodeInfo message. Does not implicitly {@link google.protobuf.GeneratedCodeInfo.verify|verify} messages.
             * @param message GeneratedCodeInfo message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.protobuf.IGeneratedCodeInfo, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified GeneratedCodeInfo message, length delimited. Does not implicitly {@link google.protobuf.GeneratedCodeInfo.verify|verify} messages.
             * @param message GeneratedCodeInfo message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.protobuf.IGeneratedCodeInfo, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes a GeneratedCodeInfo message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns GeneratedCodeInfo
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.protobuf.GeneratedCodeInfo;

            /**
             * Decodes a GeneratedCodeInfo message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns GeneratedCodeInfo
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.protobuf.GeneratedCodeInfo;

            /**
             * Verifies a GeneratedCodeInfo message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates a GeneratedCodeInfo message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns GeneratedCodeInfo
             */
            public static fromObject(object: { [k: string]: any }): google.protobuf.GeneratedCodeInfo;

            /**
             * Creates a plain object from a GeneratedCodeInfo message. Also converts values to other types if specified.
             * @param message GeneratedCodeInfo
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.protobuf.GeneratedCodeInfo, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this GeneratedCodeInfo to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }

        namespace GeneratedCodeInfo {

            /** Properties of an Annotation. */
            interface IAnnotation {

                /** Annotation path */
                path?: (number[]|null);

                /** Annotation sourceFile */
                sourceFile?: (string|null);

                /** Annotation begin */
                begin?: (number|null);

                /** Annotation end */
                end?: (number|null);
            }

            /** Represents an Annotation. */
            class Annotation implements IAnnotation {

                /**
                 * Constructs a new Annotation.
                 * @param [properties] Properties to set
                 */
                constructor(properties?: google.protobuf.GeneratedCodeInfo.IAnnotation);

                /** Annotation path. */
                public path: number[];

                /** Annotation sourceFile. */
                public sourceFile: string;

                /** Annotation begin. */
                public begin: number;

                /** Annotation end. */
                public end: number;

                /**
                 * Creates a new Annotation instance using the specified properties.
                 * @param [properties] Properties to set
                 * @returns Annotation instance
                 */
                public static create(properties?: google.protobuf.GeneratedCodeInfo.IAnnotation): google.protobuf.GeneratedCodeInfo.Annotation;

                /**
                 * Encodes the specified Annotation message. Does not implicitly {@link google.protobuf.GeneratedCodeInfo.Annotation.verify|verify} messages.
                 * @param message Annotation message or plain object to encode
                 * @param [writer] Writer to encode to
                 * @returns Writer
                 */
                public static encode(message: google.protobuf.GeneratedCodeInfo.IAnnotation, writer?: $protobuf.Writer): $protobuf.Writer;

                /**
                 * Encodes the specified Annotation message, length delimited. Does not implicitly {@link google.protobuf.GeneratedCodeInfo.Annotation.verify|verify} messages.
                 * @param message Annotation message or plain object to encode
                 * @param [writer] Writer to encode to
                 * @returns Writer
                 */
                public static encodeDelimited(message: google.protobuf.GeneratedCodeInfo.IAnnotation, writer?: $protobuf.Writer): $protobuf.Writer;

                /**
                 * Decodes an Annotation message from the specified reader or buffer.
                 * @param reader Reader or buffer to decode from
                 * @param [length] Message length if known beforehand
                 * @returns Annotation
                 * @throws {Error} If the payload is not a reader or valid buffer
                 * @throws {$protobuf.util.ProtocolError} If required fields are missing
                 */
                public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.protobuf.GeneratedCodeInfo.Annotation;

                /**
                 * Decodes an Annotation message from the specified reader or buffer, length delimited.
                 * @param reader Reader or buffer to decode from
                 * @returns Annotation
                 * @throws {Error} If the payload is not a reader or valid buffer
                 * @throws {$protobuf.util.ProtocolError} If required fields are missing
                 */
                public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.protobuf.GeneratedCodeInfo.Annotation;

                /**
                 * Verifies an Annotation message.
                 * @param message Plain object to verify
                 * @returns `null` if valid, otherwise the reason why it is not
                 */
                public static verify(message: { [k: string]: any }): (string|null);

                /**
                 * Creates an Annotation message from a plain object. Also converts values to their respective internal types.
                 * @param object Plain object
                 * @returns Annotation
                 */
                public static fromObject(object: { [k: string]: any }): google.protobuf.GeneratedCodeInfo.Annotation;

                /**
                 * Creates a plain object from an Annotation message. Also converts values to other types if specified.
                 * @param message Annotation
                 * @param [options] Conversion options
                 * @returns Plain object
                 */
                public static toObject(message: google.protobuf.GeneratedCodeInfo.Annotation, options?: $protobuf.IConversionOptions): { [k: string]: any };

                /**
                 * Converts this Annotation to JSON.
                 * @returns JSON object
                 */
                public toJSON(): { [k: string]: any };
            }
        }

        /** Properties of a Timestamp. */
        interface ITimestamp {

            /** Timestamp seconds */
            seconds?: (number|Long|null);

            /** Timestamp nanos */
            nanos?: (number|null);
        }

        /** Represents a Timestamp. */
        class Timestamp implements ITimestamp {

            /**
             * Constructs a new Timestamp.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.protobuf.ITimestamp);

            /** Timestamp seconds. */
            public seconds: (number|Long);

            /** Timestamp nanos. */
            public nanos: number;

            /**
             * Creates a new Timestamp instance using the specified properties.
             * @param [properties] Properties to set
             * @returns Timestamp instance
             */
            public static create(properties?: google.protobuf.ITimestamp): google.protobuf.Timestamp;

            /**
             * Encodes the specified Timestamp message. Does not implicitly {@link google.protobuf.Timestamp.verify|verify} messages.
             * @param message Timestamp message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.protobuf.ITimestamp, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified Timestamp message, length delimited. Does not implicitly {@link google.protobuf.Timestamp.verify|verify} messages.
             * @param message Timestamp message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.protobuf.ITimestamp, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes a Timestamp message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns Timestamp
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.protobuf.Timestamp;

            /**
             * Decodes a Timestamp message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns Timestamp
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.protobuf.Timestamp;

            /**
             * Verifies a Timestamp message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates a Timestamp message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns Timestamp
             */
            public static fromObject(object: { [k: string]: any }): google.protobuf.Timestamp;

            /**
             * Creates a plain object from a Timestamp message. Also converts values to other types if specified.
             * @param message Timestamp
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.protobuf.Timestamp, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this Timestamp to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }

        /** Properties of an Any. */
        interface IAny {

            /** Any type_url */
            type_url?: (string|null);

            /** Any value */
            value?: (Uint8Array|null);
        }

        /** Represents an Any. */
        class Any implements IAny {

            /**
             * Constructs a new Any.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.protobuf.IAny);

            /** Any type_url. */
            public type_url: string;

            /** Any value. */
            public value: Uint8Array;

            /**
             * Creates a new Any instance using the specified properties.
             * @param [properties] Properties to set
             * @returns Any instance
             */
            public static create(properties?: google.protobuf.IAny): google.protobuf.Any;

            /**
             * Encodes the specified Any message. Does not implicitly {@link google.protobuf.Any.verify|verify} messages.
             * @param message Any message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.protobuf.IAny, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified Any message, length delimited. Does not implicitly {@link google.protobuf.Any.verify|verify} messages.
             * @param message Any message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.protobuf.IAny, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes an Any message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns Any
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.protobuf.Any;

            /**
             * Decodes an Any message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns Any
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.protobuf.Any;

            /**
             * Verifies an Any message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates an Any message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns Any
             */
            public static fromObject(object: { [k: string]: any }): google.protobuf.Any;

            /**
             * Creates a plain object from an Any message. Also converts values to other types if specified.
             * @param message Any
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.protobuf.Any, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this Any to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }

        /** Properties of a Duration. */
        interface IDuration {

            /** Duration seconds */
            seconds?: (number|Long|null);

            /** Duration nanos */
            nanos?: (number|null);
        }

        /** Represents a Duration. */
        class Duration implements IDuration {

            /**
             * Constructs a new Duration.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.protobuf.IDuration);

            /** Duration seconds. */
            public seconds: (number|Long);

            /** Duration nanos. */
            public nanos: number;

            /**
             * Creates a new Duration instance using the specified properties.
             * @param [properties] Properties to set
             * @returns Duration instance
             */
            public static create(properties?: google.protobuf.IDuration): google.protobuf.Duration;

            /**
             * Encodes the specified Duration message. Does not implicitly {@link google.protobuf.Duration.verify|verify} messages.
             * @param message Duration message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.protobuf.IDuration, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified Duration message, length delimited. Does not implicitly {@link google.protobuf.Duration.verify|verify} messages.
             * @param message Duration message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.protobuf.IDuration, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes a Duration message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns Duration
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.protobuf.Duration;

            /**
             * Decodes a Duration message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns Duration
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.protobuf.Duration;

            /**
             * Verifies a Duration message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates a Duration message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns Duration
             */
            public static fromObject(object: { [k: string]: any }): google.protobuf.Duration;

            /**
             * Creates a plain object from a Duration message. Also converts values to other types if specified.
             * @param message Duration
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.protobuf.Duration, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this Duration to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }

        /** Properties of an Empty. */
        interface IEmpty {
        }

        /** Represents an Empty. */
        class Empty implements IEmpty {

            /**
             * Constructs a new Empty.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.protobuf.IEmpty);

            /**
             * Creates a new Empty instance using the specified properties.
             * @param [properties] Properties to set
             * @returns Empty instance
             */
            public static create(properties?: google.protobuf.IEmpty): google.protobuf.Empty;

            /**
             * Encodes the specified Empty message. Does not implicitly {@link google.protobuf.Empty.verify|verify} messages.
             * @param message Empty message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.protobuf.IEmpty, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified Empty message, length delimited. Does not implicitly {@link google.protobuf.Empty.verify|verify} messages.
             * @param message Empty message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.protobuf.IEmpty, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes an Empty message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns Empty
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.protobuf.Empty;

            /**
             * Decodes an Empty message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns Empty
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.protobuf.Empty;

            /**
             * Verifies an Empty message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates an Empty message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns Empty
             */
            public static fromObject(object: { [k: string]: any }): google.protobuf.Empty;

            /**
             * Creates a plain object from an Empty message. Also converts values to other types if specified.
             * @param message Empty
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.protobuf.Empty, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this Empty to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }

        /** Properties of a FieldMask. */
        interface IFieldMask {

            /** FieldMask paths */
            paths?: (string[]|null);
        }

        /** Represents a FieldMask. */
        class FieldMask implements IFieldMask {

            /**
             * Constructs a new FieldMask.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.protobuf.IFieldMask);

            /** FieldMask paths. */
            public paths: string[];

            /**
             * Creates a new FieldMask instance using the specified properties.
             * @param [properties] Properties to set
             * @returns FieldMask instance
             */
            public static create(properties?: google.protobuf.IFieldMask): google.protobuf.FieldMask;

            /**
             * Encodes the specified FieldMask message. Does not implicitly {@link google.protobuf.FieldMask.verify|verify} messages.
             * @param message FieldMask message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.protobuf.IFieldMask, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified FieldMask message, length delimited. Does not implicitly {@link google.protobuf.FieldMask.verify|verify} messages.
             * @param message FieldMask message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.protobuf.IFieldMask, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes a FieldMask message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns FieldMask
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.protobuf.FieldMask;

            /**
             * Decodes a FieldMask message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns FieldMask
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.protobuf.FieldMask;

            /**
             * Verifies a FieldMask message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates a FieldMask message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns FieldMask
             */
            public static fromObject(object: { [k: string]: any }): google.protobuf.FieldMask;

            /**
             * Creates a plain object from a FieldMask message. Also converts values to other types if specified.
             * @param message FieldMask
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.protobuf.FieldMask, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this FieldMask to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }
    }

    /** Namespace iam. */
    namespace iam {

        /** Namespace v1. */
        namespace v1 {

            /** Represents a IAMPolicy */
            class IAMPolicy extends $protobuf.rpc.Service {

                /**
                 * Constructs a new IAMPolicy service.
                 * @param rpcImpl RPC implementation
                 * @param [requestDelimited=false] Whether requests are length-delimited
                 * @param [responseDelimited=false] Whether responses are length-delimited
                 */
                constructor(rpcImpl: $protobuf.RPCImpl, requestDelimited?: boolean, responseDelimited?: boolean);

                /**
                 * Creates new IAMPolicy service using the specified rpc implementation.
                 * @param rpcImpl RPC implementation
                 * @param [requestDelimited=false] Whether requests are length-delimited
                 * @param [responseDelimited=false] Whether responses are length-delimited
                 * @returns RPC service. Useful where requests and/or responses are streamed.
                 */
                public static create(rpcImpl: $protobuf.RPCImpl, requestDelimited?: boolean, responseDelimited?: boolean): IAMPolicy;

                /**
                 * Calls SetIamPolicy.
                 * @param request SetIamPolicyRequest message or plain object
                 * @param callback Node-style callback called with the error, if any, and Policy
                 */
                public setIamPolicy(request: google.iam.v1.ISetIamPolicyRequest, callback: google.iam.v1.IAMPolicy.SetIamPolicyCallback): void;

                /**
                 * Calls SetIamPolicy.
                 * @param request SetIamPolicyRequest message or plain object
                 * @returns Promise
                 */
                public setIamPolicy(request: google.iam.v1.ISetIamPolicyRequest): Promise<google.iam.v1.Policy>;

                /**
                 * Calls GetIamPolicy.
                 * @param request GetIamPolicyRequest message or plain object
                 * @param callback Node-style callback called with the error, if any, and Policy
                 */
                public getIamPolicy(request: google.iam.v1.IGetIamPolicyRequest, callback: google.iam.v1.IAMPolicy.GetIamPolicyCallback): void;

                /**
                 * Calls GetIamPolicy.
                 * @param request GetIamPolicyRequest message or plain object
                 * @returns Promise
                 */
                public getIamPolicy(request: google.iam.v1.IGetIamPolicyRequest): Promise<google.iam.v1.Policy>;

                /**
                 * Calls TestIamPermissions.
                 * @param request TestIamPermissionsRequest message or plain object
                 * @param callback Node-style callback called with the error, if any, and TestIamPermissionsResponse
                 */
                public testIamPermissions(request: google.iam.v1.ITestIamPermissionsRequest, callback: google.iam.v1.IAMPolicy.TestIamPermissionsCallback): void;

                /**
                 * Calls TestIamPermissions.
                 * @param request TestIamPermissionsRequest message or plain object
                 * @returns Promise
                 */
                public testIamPermissions(request: google.iam.v1.ITestIamPermissionsRequest): Promise<google.iam.v1.TestIamPermissionsResponse>;
            }

            namespace IAMPolicy {

                /**
                 * Callback as used by {@link google.iam.v1.IAMPolicy#setIamPolicy}.
                 * @param error Error, if any
                 * @param [response] Policy
                 */
                type SetIamPolicyCallback = (error: (Error|null), response?: google.iam.v1.Policy) => void;

                /**
                 * Callback as used by {@link google.iam.v1.IAMPolicy#getIamPolicy}.
                 * @param error Error, if any
                 * @param [response] Policy
                 */
                type GetIamPolicyCallback = (error: (Error|null), response?: google.iam.v1.Policy) => void;

                /**
                 * Callback as used by {@link google.iam.v1.IAMPolicy#testIamPermissions}.
                 * @param error Error, if any
                 * @param [response] TestIamPermissionsResponse
                 */
                type TestIamPermissionsCallback = (error: (Error|null), response?: google.iam.v1.TestIamPermissionsResponse) => void;
            }

            /** Properties of a SetIamPolicyRequest. */
            interface ISetIamPolicyRequest {

                /** SetIamPolicyRequest resource */
                resource?: (string|null);

                /** SetIamPolicyRequest policy */
                policy?: (google.iam.v1.IPolicy|null);
            }

            /** Represents a SetIamPolicyRequest. */
            class SetIamPolicyRequest implements ISetIamPolicyRequest {

                /**
                 * Constructs a new SetIamPolicyRequest.
                 * @param [properties] Properties to set
                 */
                constructor(properties?: google.iam.v1.ISetIamPolicyRequest);

                /** SetIamPolicyRequest resource. */
                public resource: string;

                /** SetIamPolicyRequest policy. */
                public policy?: (google.iam.v1.IPolicy|null);

                /**
                 * Creates a new SetIamPolicyRequest instance using the specified properties.
                 * @param [properties] Properties to set
                 * @returns SetIamPolicyRequest instance
                 */
                public static create(properties?: google.iam.v1.ISetIamPolicyRequest): google.iam.v1.SetIamPolicyRequest;

                /**
                 * Encodes the specified SetIamPolicyRequest message. Does not implicitly {@link google.iam.v1.SetIamPolicyRequest.verify|verify} messages.
                 * @param message SetIamPolicyRequest message or plain object to encode
                 * @param [writer] Writer to encode to
                 * @returns Writer
                 */
                public static encode(message: google.iam.v1.ISetIamPolicyRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                /**
                 * Encodes the specified SetIamPolicyRequest message, length delimited. Does not implicitly {@link google.iam.v1.SetIamPolicyRequest.verify|verify} messages.
                 * @param message SetIamPolicyRequest message or plain object to encode
                 * @param [writer] Writer to encode to
                 * @returns Writer
                 */
                public static encodeDelimited(message: google.iam.v1.ISetIamPolicyRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                /**
                 * Decodes a SetIamPolicyRequest message from the specified reader or buffer.
                 * @param reader Reader or buffer to decode from
                 * @param [length] Message length if known beforehand
                 * @returns SetIamPolicyRequest
                 * @throws {Error} If the payload is not a reader or valid buffer
                 * @throws {$protobuf.util.ProtocolError} If required fields are missing
                 */
                public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.iam.v1.SetIamPolicyRequest;

                /**
                 * Decodes a SetIamPolicyRequest message from the specified reader or buffer, length delimited.
                 * @param reader Reader or buffer to decode from
                 * @returns SetIamPolicyRequest
                 * @throws {Error} If the payload is not a reader or valid buffer
                 * @throws {$protobuf.util.ProtocolError} If required fields are missing
                 */
                public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.iam.v1.SetIamPolicyRequest;

                /**
                 * Verifies a SetIamPolicyRequest message.
                 * @param message Plain object to verify
                 * @returns `null` if valid, otherwise the reason why it is not
                 */
                public static verify(message: { [k: string]: any }): (string|null);

                /**
                 * Creates a SetIamPolicyRequest message from a plain object. Also converts values to their respective internal types.
                 * @param object Plain object
                 * @returns SetIamPolicyRequest
                 */
                public static fromObject(object: { [k: string]: any }): google.iam.v1.SetIamPolicyRequest;

                /**
                 * Creates a plain object from a SetIamPolicyRequest message. Also converts values to other types if specified.
                 * @param message SetIamPolicyRequest
                 * @param [options] Conversion options
                 * @returns Plain object
                 */
                public static toObject(message: google.iam.v1.SetIamPolicyRequest, options?: $protobuf.IConversionOptions): { [k: string]: any };

                /**
                 * Converts this SetIamPolicyRequest to JSON.
                 * @returns JSON object
                 */
                public toJSON(): { [k: string]: any };
            }

            /** Properties of a GetIamPolicyRequest. */
            interface IGetIamPolicyRequest {

                /** GetIamPolicyRequest resource */
                resource?: (string|null);

                /** GetIamPolicyRequest options */
                options?: (google.iam.v1.IGetPolicyOptions|null);
            }

            /** Represents a GetIamPolicyRequest. */
            class GetIamPolicyRequest implements IGetIamPolicyRequest {

                /**
                 * Constructs a new GetIamPolicyRequest.
                 * @param [properties] Properties to set
                 */
                constructor(properties?: google.iam.v1.IGetIamPolicyRequest);

                /** GetIamPolicyRequest resource. */
                public resource: string;

                /** GetIamPolicyRequest options. */
                public options?: (google.iam.v1.IGetPolicyOptions|null);

                /**
                 * Creates a new GetIamPolicyRequest instance using the specified properties.
                 * @param [properties] Properties to set
                 * @returns GetIamPolicyRequest instance
                 */
                public static create(properties?: google.iam.v1.IGetIamPolicyRequest): google.iam.v1.GetIamPolicyRequest;

                /**
                 * Encodes the specified GetIamPolicyRequest message. Does not implicitly {@link google.iam.v1.GetIamPolicyRequest.verify|verify} messages.
                 * @param message GetIamPolicyRequest message or plain object to encode
                 * @param [writer] Writer to encode to
                 * @returns Writer
                 */
                public static encode(message: google.iam.v1.IGetIamPolicyRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                /**
                 * Encodes the specified GetIamPolicyRequest message, length delimited. Does not implicitly {@link google.iam.v1.GetIamPolicyRequest.verify|verify} messages.
                 * @param message GetIamPolicyRequest message or plain object to encode
                 * @param [writer] Writer to encode to
                 * @returns Writer
                 */
                public static encodeDelimited(message: google.iam.v1.IGetIamPolicyRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                /**
                 * Decodes a GetIamPolicyRequest message from the specified reader or buffer.
                 * @param reader Reader or buffer to decode from
                 * @param [length] Message length if known beforehand
                 * @returns GetIamPolicyRequest
                 * @throws {Error} If the payload is not a reader or valid buffer
                 * @throws {$protobuf.util.ProtocolError} If required fields are missing
                 */
                public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.iam.v1.GetIamPolicyRequest;

                /**
                 * Decodes a GetIamPolicyRequest message from the specified reader or buffer, length delimited.
                 * @param reader Reader or buffer to decode from
                 * @returns GetIamPolicyRequest
                 * @throws {Error} If the payload is not a reader or valid buffer
                 * @throws {$protobuf.util.ProtocolError} If required fields are missing
                 */
                public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.iam.v1.GetIamPolicyRequest;

                /**
                 * Verifies a GetIamPolicyRequest message.
                 * @param message Plain object to verify
                 * @returns `null` if valid, otherwise the reason why it is not
                 */
                public static verify(message: { [k: string]: any }): (string|null);

                /**
                 * Creates a GetIamPolicyRequest message from a plain object. Also converts values to their respective internal types.
                 * @param object Plain object
                 * @returns GetIamPolicyRequest
                 */
                public static fromObject(object: { [k: string]: any }): google.iam.v1.GetIamPolicyRequest;

                /**
                 * Creates a plain object from a GetIamPolicyRequest message. Also converts values to other types if specified.
                 * @param message GetIamPolicyRequest
                 * @param [options] Conversion options
                 * @returns Plain object
                 */
                public static toObject(message: google.iam.v1.GetIamPolicyRequest, options?: $protobuf.IConversionOptions): { [k: string]: any };

                /**
                 * Converts this GetIamPolicyRequest to JSON.
                 * @returns JSON object
                 */
                public toJSON(): { [k: string]: any };
            }

            /** Properties of a TestIamPermissionsRequest. */
            interface ITestIamPermissionsRequest {

                /** TestIamPermissionsRequest resource */
                resource?: (string|null);

                /** TestIamPermissionsRequest permissions */
                permissions?: (string[]|null);
            }

            /** Represents a TestIamPermissionsRequest. */
            class TestIamPermissionsRequest implements ITestIamPermissionsRequest {

                /**
                 * Constructs a new TestIamPermissionsRequest.
                 * @param [properties] Properties to set
                 */
                constructor(properties?: google.iam.v1.ITestIamPermissionsRequest);

                /** TestIamPermissionsRequest resource. */
                public resource: string;

                /** TestIamPermissionsRequest permissions. */
                public permissions: string[];

                /**
                 * Creates a new TestIamPermissionsRequest instance using the specified properties.
                 * @param [properties] Properties to set
                 * @returns TestIamPermissionsRequest instance
                 */
                public static create(properties?: google.iam.v1.ITestIamPermissionsRequest): google.iam.v1.TestIamPermissionsRequest;

                /**
                 * Encodes the specified TestIamPermissionsRequest message. Does not implicitly {@link google.iam.v1.TestIamPermissionsRequest.verify|verify} messages.
                 * @param message TestIamPermissionsRequest message or plain object to encode
                 * @param [writer] Writer to encode to
                 * @returns Writer
                 */
                public static encode(message: google.iam.v1.ITestIamPermissionsRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                /**
                 * Encodes the specified TestIamPermissionsRequest message, length delimited. Does not implicitly {@link google.iam.v1.TestIamPermissionsRequest.verify|verify} messages.
                 * @param message TestIamPermissionsRequest message or plain object to encode
                 * @param [writer] Writer to encode to
                 * @returns Writer
                 */
                public static encodeDelimited(message: google.iam.v1.ITestIamPermissionsRequest, writer?: $protobuf.Writer): $protobuf.Writer;

                /**
                 * Decodes a TestIamPermissionsRequest message from the specified reader or buffer.
                 * @param reader Reader or buffer to decode from
                 * @param [length] Message length if known beforehand
                 * @returns TestIamPermissionsRequest
                 * @throws {Error} If the payload is not a reader or valid buffer
                 * @throws {$protobuf.util.ProtocolError} If required fields are missing
                 */
                public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.iam.v1.TestIamPermissionsRequest;

                /**
                 * Decodes a TestIamPermissionsRequest message from the specified reader or buffer, length delimited.
                 * @param reader Reader or buffer to decode from
                 * @returns TestIamPermissionsRequest
                 * @throws {Error} If the payload is not a reader or valid buffer
                 * @throws {$protobuf.util.ProtocolError} If required fields are missing
                 */
                public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.iam.v1.TestIamPermissionsRequest;

                /**
                 * Verifies a TestIamPermissionsRequest message.
                 * @param message Plain object to verify
                 * @returns `null` if valid, otherwise the reason why it is not
                 */
                public static verify(message: { [k: string]: any }): (string|null);

                /**
                 * Creates a TestIamPermissionsRequest message from a plain object. Also converts values to their respective internal types.
                 * @param object Plain object
                 * @returns TestIamPermissionsRequest
                 */
                public static fromObject(object: { [k: string]: any }): google.iam.v1.TestIamPermissionsRequest;

                /**
                 * Creates a plain object from a TestIamPermissionsRequest message. Also converts values to other types if specified.
                 * @param message TestIamPermissionsRequest
                 * @param [options] Conversion options
                 * @returns Plain object
                 */
                public static toObject(message: google.iam.v1.TestIamPermissionsRequest, options?: $protobuf.IConversionOptions): { [k: string]: any };

                /**
                 * Converts this TestIamPermissionsRequest to JSON.
                 * @returns JSON object
                 */
                public toJSON(): { [k: string]: any };
            }

            /** Properties of a TestIamPermissionsResponse. */
            interface ITestIamPermissionsResponse {

                /** TestIamPermissionsResponse permissions */
                permissions?: (string[]|null);
            }

            /** Represents a TestIamPermissionsResponse. */
            class TestIamPermissionsResponse implements ITestIamPermissionsResponse {

                /**
                 * Constructs a new TestIamPermissionsResponse.
                 * @param [properties] Properties to set
                 */
                constructor(properties?: google.iam.v1.ITestIamPermissionsResponse);

                /** TestIamPermissionsResponse permissions. */
                public permissions: string[];

                /**
                 * Creates a new TestIamPermissionsResponse instance using the specified properties.
                 * @param [properties] Properties to set
                 * @returns TestIamPermissionsResponse instance
                 */
                public static create(properties?: google.iam.v1.ITestIamPermissionsResponse): google.iam.v1.TestIamPermissionsResponse;

                /**
                 * Encodes the specified TestIamPermissionsResponse message. Does not implicitly {@link google.iam.v1.TestIamPermissionsResponse.verify|verify} messages.
                 * @param message TestIamPermissionsResponse message or plain object to encode
                 * @param [writer] Writer to encode to
                 * @returns Writer
                 */
                public static encode(message: google.iam.v1.ITestIamPermissionsResponse, writer?: $protobuf.Writer): $protobuf.Writer;

                /**
                 * Encodes the specified TestIamPermissionsResponse message, length delimited. Does not implicitly {@link google.iam.v1.TestIamPermissionsResponse.verify|verify} messages.
                 * @param message TestIamPermissionsResponse message or plain object to encode
                 * @param [writer] Writer to encode to
                 * @returns Writer
                 */
                public static encodeDelimited(message: google.iam.v1.ITestIamPermissionsResponse, writer?: $protobuf.Writer): $protobuf.Writer;

                /**
                 * Decodes a TestIamPermissionsResponse message from the specified reader or buffer.
                 * @param reader Reader or buffer to decode from
                 * @param [length] Message length if known beforehand
                 * @returns TestIamPermissionsResponse
                 * @throws {Error} If the payload is not a reader or valid buffer
                 * @throws {$protobuf.util.ProtocolError} If required fields are missing
                 */
                public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.iam.v1.TestIamPermissionsResponse;

                /**
                 * Decodes a TestIamPermissionsResponse message from the specified reader or buffer, length delimited.
                 * @param reader Reader or buffer to decode from
                 * @returns TestIamPermissionsResponse
                 * @throws {Error} If the payload is not a reader or valid buffer
                 * @throws {$protobuf.util.ProtocolError} If required fields are missing
                 */
                public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.iam.v1.TestIamPermissionsResponse;

                /**
                 * Verifies a TestIamPermissionsResponse message.
                 * @param message Plain object to verify
                 * @returns `null` if valid, otherwise the reason why it is not
                 */
                public static verify(message: { [k: string]: any }): (string|null);

                /**
                 * Creates a TestIamPermissionsResponse message from a plain object. Also converts values to their respective internal types.
                 * @param object Plain object
                 * @returns TestIamPermissionsResponse
                 */
                public static fromObject(object: { [k: string]: any }): google.iam.v1.TestIamPermissionsResponse;

                /**
                 * Creates a plain object from a TestIamPermissionsResponse message. Also converts values to other types if specified.
                 * @param message TestIamPermissionsResponse
                 * @param [options] Conversion options
                 * @returns Plain object
                 */
                public static toObject(message: google.iam.v1.TestIamPermissionsResponse, options?: $protobuf.IConversionOptions): { [k: string]: any };

                /**
                 * Converts this TestIamPermissionsResponse to JSON.
                 * @returns JSON object
                 */
                public toJSON(): { [k: string]: any };
            }

            /** Properties of a GetPolicyOptions. */
            interface IGetPolicyOptions {

                /** GetPolicyOptions requestedPolicyVersion */
                requestedPolicyVersion?: (number|null);
            }

            /** Represents a GetPolicyOptions. */
            class GetPolicyOptions implements IGetPolicyOptions {

                /**
                 * Constructs a new GetPolicyOptions.
                 * @param [properties] Properties to set
                 */
                constructor(properties?: google.iam.v1.IGetPolicyOptions);

                /** GetPolicyOptions requestedPolicyVersion. */
                public requestedPolicyVersion: number;

                /**
                 * Creates a new GetPolicyOptions instance using the specified properties.
                 * @param [properties] Properties to set
                 * @returns GetPolicyOptions instance
                 */
                public static create(properties?: google.iam.v1.IGetPolicyOptions): google.iam.v1.GetPolicyOptions;

                /**
                 * Encodes the specified GetPolicyOptions message. Does not implicitly {@link google.iam.v1.GetPolicyOptions.verify|verify} messages.
                 * @param message GetPolicyOptions message or plain object to encode
                 * @param [writer] Writer to encode to
                 * @returns Writer
                 */
                public static encode(message: google.iam.v1.IGetPolicyOptions, writer?: $protobuf.Writer): $protobuf.Writer;

                /**
                 * Encodes the specified GetPolicyOptions message, length delimited. Does not implicitly {@link google.iam.v1.GetPolicyOptions.verify|verify} messages.
                 * @param message GetPolicyOptions message or plain object to encode
                 * @param [writer] Writer to encode to
                 * @returns Writer
                 */
                public static encodeDelimited(message: google.iam.v1.IGetPolicyOptions, writer?: $protobuf.Writer): $protobuf.Writer;

                /**
                 * Decodes a GetPolicyOptions message from the specified reader or buffer.
                 * @param reader Reader or buffer to decode from
                 * @param [length] Message length if known beforehand
                 * @returns GetPolicyOptions
                 * @throws {Error} If the payload is not a reader or valid buffer
                 * @throws {$protobuf.util.ProtocolError} If required fields are missing
                 */
                public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.iam.v1.GetPolicyOptions;

                /**
                 * Decodes a GetPolicyOptions message from the specified reader or buffer, length delimited.
                 * @param reader Reader or buffer to decode from
                 * @returns GetPolicyOptions
                 * @throws {Error} If the payload is not a reader or valid buffer
                 * @throws {$protobuf.util.ProtocolError} If required fields are missing
                 */
                public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.iam.v1.GetPolicyOptions;

                /**
                 * Verifies a GetPolicyOptions message.
                 * @param message Plain object to verify
                 * @returns `null` if valid, otherwise the reason why it is not
                 */
                public static verify(message: { [k: string]: any }): (string|null);

                /**
                 * Creates a GetPolicyOptions message from a plain object. Also converts values to their respective internal types.
                 * @param object Plain object
                 * @returns GetPolicyOptions
                 */
                public static fromObject(object: { [k: string]: any }): google.iam.v1.GetPolicyOptions;

                /**
                 * Creates a plain object from a GetPolicyOptions message. Also converts values to other types if specified.
                 * @param message GetPolicyOptions
                 * @param [options] Conversion options
                 * @returns Plain object
                 */
                public static toObject(message: google.iam.v1.GetPolicyOptions, options?: $protobuf.IConversionOptions): { [k: string]: any };

                /**
                 * Converts this GetPolicyOptions to JSON.
                 * @returns JSON object
                 */
                public toJSON(): { [k: string]: any };
            }

            /** Properties of a Policy. */
            interface IPolicy {

                /** Policy version */
                version?: (number|null);

                /** Policy bindings */
                bindings?: (google.iam.v1.IBinding[]|null);

                /** Policy etag */
                etag?: (Uint8Array|null);
            }

            /** Represents a Policy. */
            class Policy implements IPolicy {

                /**
                 * Constructs a new Policy.
                 * @param [properties] Properties to set
                 */
                constructor(properties?: google.iam.v1.IPolicy);

                /** Policy version. */
                public version: number;

                /** Policy bindings. */
                public bindings: google.iam.v1.IBinding[];

                /** Policy etag. */
                public etag: Uint8Array;

                /**
                 * Creates a new Policy instance using the specified properties.
                 * @param [properties] Properties to set
                 * @returns Policy instance
                 */
                public static create(properties?: google.iam.v1.IPolicy): google.iam.v1.Policy;

                /**
                 * Encodes the specified Policy message. Does not implicitly {@link google.iam.v1.Policy.verify|verify} messages.
                 * @param message Policy message or plain object to encode
                 * @param [writer] Writer to encode to
                 * @returns Writer
                 */
                public static encode(message: google.iam.v1.IPolicy, writer?: $protobuf.Writer): $protobuf.Writer;

                /**
                 * Encodes the specified Policy message, length delimited. Does not implicitly {@link google.iam.v1.Policy.verify|verify} messages.
                 * @param message Policy message or plain object to encode
                 * @param [writer] Writer to encode to
                 * @returns Writer
                 */
                public static encodeDelimited(message: google.iam.v1.IPolicy, writer?: $protobuf.Writer): $protobuf.Writer;

                /**
                 * Decodes a Policy message from the specified reader or buffer.
                 * @param reader Reader or buffer to decode from
                 * @param [length] Message length if known beforehand
                 * @returns Policy
                 * @throws {Error} If the payload is not a reader or valid buffer
                 * @throws {$protobuf.util.ProtocolError} If required fields are missing
                 */
                public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.iam.v1.Policy;

                /**
                 * Decodes a Policy message from the specified reader or buffer, length delimited.
                 * @param reader Reader or buffer to decode from
                 * @returns Policy
                 * @throws {Error} If the payload is not a reader or valid buffer
                 * @throws {$protobuf.util.ProtocolError} If required fields are missing
                 */
                public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.iam.v1.Policy;

                /**
                 * Verifies a Policy message.
                 * @param message Plain object to verify
                 * @returns `null` if valid, otherwise the reason why it is not
                 */
                public static verify(message: { [k: string]: any }): (string|null);

                /**
                 * Creates a Policy message from a plain object. Also converts values to their respective internal types.
                 * @param object Plain object
                 * @returns Policy
                 */
                public static fromObject(object: { [k: string]: any }): google.iam.v1.Policy;

                /**
                 * Creates a plain object from a Policy message. Also converts values to other types if specified.
                 * @param message Policy
                 * @param [options] Conversion options
                 * @returns Plain object
                 */
                public static toObject(message: google.iam.v1.Policy, options?: $protobuf.IConversionOptions): { [k: string]: any };

                /**
                 * Converts this Policy to JSON.
                 * @returns JSON object
                 */
                public toJSON(): { [k: string]: any };
            }

            /** Properties of a Binding. */
            interface IBinding {

                /** Binding role */
                role?: (string|null);

                /** Binding members */
                members?: (string[]|null);

                /** Binding condition */
                condition?: (google.type.IExpr|null);
            }

            /** Represents a Binding. */
            class Binding implements IBinding {

                /**
                 * Constructs a new Binding.
                 * @param [properties] Properties to set
                 */
                constructor(properties?: google.iam.v1.IBinding);

                /** Binding role. */
                public role: string;

                /** Binding members. */
                public members: string[];

                /** Binding condition. */
                public condition?: (google.type.IExpr|null);

                /**
                 * Creates a new Binding instance using the specified properties.
                 * @param [properties] Properties to set
                 * @returns Binding instance
                 */
                public static create(properties?: google.iam.v1.IBinding): google.iam.v1.Binding;

                /**
                 * Encodes the specified Binding message. Does not implicitly {@link google.iam.v1.Binding.verify|verify} messages.
                 * @param message Binding message or plain object to encode
                 * @param [writer] Writer to encode to
                 * @returns Writer
                 */
                public static encode(message: google.iam.v1.IBinding, writer?: $protobuf.Writer): $protobuf.Writer;

                /**
                 * Encodes the specified Binding message, length delimited. Does not implicitly {@link google.iam.v1.Binding.verify|verify} messages.
                 * @param message Binding message or plain object to encode
                 * @param [writer] Writer to encode to
                 * @returns Writer
                 */
                public static encodeDelimited(message: google.iam.v1.IBinding, writer?: $protobuf.Writer): $protobuf.Writer;

                /**
                 * Decodes a Binding message from the specified reader or buffer.
                 * @param reader Reader or buffer to decode from
                 * @param [length] Message length if known beforehand
                 * @returns Binding
                 * @throws {Error} If the payload is not a reader or valid buffer
                 * @throws {$protobuf.util.ProtocolError} If required fields are missing
                 */
                public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.iam.v1.Binding;

                /**
                 * Decodes a Binding message from the specified reader or buffer, length delimited.
                 * @param reader Reader or buffer to decode from
                 * @returns Binding
                 * @throws {Error} If the payload is not a reader or valid buffer
                 * @throws {$protobuf.util.ProtocolError} If required fields are missing
                 */
                public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.iam.v1.Binding;

                /**
                 * Verifies a Binding message.
                 * @param message Plain object to verify
                 * @returns `null` if valid, otherwise the reason why it is not
                 */
                public static verify(message: { [k: string]: any }): (string|null);

                /**
                 * Creates a Binding message from a plain object. Also converts values to their respective internal types.
                 * @param object Plain object
                 * @returns Binding
                 */
                public static fromObject(object: { [k: string]: any }): google.iam.v1.Binding;

                /**
                 * Creates a plain object from a Binding message. Also converts values to other types if specified.
                 * @param message Binding
                 * @param [options] Conversion options
                 * @returns Plain object
                 */
                public static toObject(message: google.iam.v1.Binding, options?: $protobuf.IConversionOptions): { [k: string]: any };

                /**
                 * Converts this Binding to JSON.
                 * @returns JSON object
                 */
                public toJSON(): { [k: string]: any };
            }

            /** Properties of a PolicyDelta. */
            interface IPolicyDelta {

                /** PolicyDelta bindingDeltas */
                bindingDeltas?: (google.iam.v1.IBindingDelta[]|null);

                /** PolicyDelta auditConfigDeltas */
                auditConfigDeltas?: (google.iam.v1.IAuditConfigDelta[]|null);
            }

            /** Represents a PolicyDelta. */
            class PolicyDelta implements IPolicyDelta {

                /**
                 * Constructs a new PolicyDelta.
                 * @param [properties] Properties to set
                 */
                constructor(properties?: google.iam.v1.IPolicyDelta);

                /** PolicyDelta bindingDeltas. */
                public bindingDeltas: google.iam.v1.IBindingDelta[];

                /** PolicyDelta auditConfigDeltas. */
                public auditConfigDeltas: google.iam.v1.IAuditConfigDelta[];

                /**
                 * Creates a new PolicyDelta instance using the specified properties.
                 * @param [properties] Properties to set
                 * @returns PolicyDelta instance
                 */
                public static create(properties?: google.iam.v1.IPolicyDelta): google.iam.v1.PolicyDelta;

                /**
                 * Encodes the specified PolicyDelta message. Does not implicitly {@link google.iam.v1.PolicyDelta.verify|verify} messages.
                 * @param message PolicyDelta message or plain object to encode
                 * @param [writer] Writer to encode to
                 * @returns Writer
                 */
                public static encode(message: google.iam.v1.IPolicyDelta, writer?: $protobuf.Writer): $protobuf.Writer;

                /**
                 * Encodes the specified PolicyDelta message, length delimited. Does not implicitly {@link google.iam.v1.PolicyDelta.verify|verify} messages.
                 * @param message PolicyDelta message or plain object to encode
                 * @param [writer] Writer to encode to
                 * @returns Writer
                 */
                public static encodeDelimited(message: google.iam.v1.IPolicyDelta, writer?: $protobuf.Writer): $protobuf.Writer;

                /**
                 * Decodes a PolicyDelta message from the specified reader or buffer.
                 * @param reader Reader or buffer to decode from
                 * @param [length] Message length if known beforehand
                 * @returns PolicyDelta
                 * @throws {Error} If the payload is not a reader or valid buffer
                 * @throws {$protobuf.util.ProtocolError} If required fields are missing
                 */
                public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.iam.v1.PolicyDelta;

                /**
                 * Decodes a PolicyDelta message from the specified reader or buffer, length delimited.
                 * @param reader Reader or buffer to decode from
                 * @returns PolicyDelta
                 * @throws {Error} If the payload is not a reader or valid buffer
                 * @throws {$protobuf.util.ProtocolError} If required fields are missing
                 */
                public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.iam.v1.PolicyDelta;

                /**
                 * Verifies a PolicyDelta message.
                 * @param message Plain object to verify
                 * @returns `null` if valid, otherwise the reason why it is not
                 */
                public static verify(message: { [k: string]: any }): (string|null);

                /**
                 * Creates a PolicyDelta message from a plain object. Also converts values to their respective internal types.
                 * @param object Plain object
                 * @returns PolicyDelta
                 */
                public static fromObject(object: { [k: string]: any }): google.iam.v1.PolicyDelta;

                /**
                 * Creates a plain object from a PolicyDelta message. Also converts values to other types if specified.
                 * @param message PolicyDelta
                 * @param [options] Conversion options
                 * @returns Plain object
                 */
                public static toObject(message: google.iam.v1.PolicyDelta, options?: $protobuf.IConversionOptions): { [k: string]: any };

                /**
                 * Converts this PolicyDelta to JSON.
                 * @returns JSON object
                 */
                public toJSON(): { [k: string]: any };
            }

            /** Properties of a BindingDelta. */
            interface IBindingDelta {

                /** BindingDelta action */
                action?: (google.iam.v1.BindingDelta.Action|null);

                /** BindingDelta role */
                role?: (string|null);

                /** BindingDelta member */
                member?: (string|null);

                /** BindingDelta condition */
                condition?: (google.type.IExpr|null);
            }

            /** Represents a BindingDelta. */
            class BindingDelta implements IBindingDelta {

                /**
                 * Constructs a new BindingDelta.
                 * @param [properties] Properties to set
                 */
                constructor(properties?: google.iam.v1.IBindingDelta);

                /** BindingDelta action. */
                public action: google.iam.v1.BindingDelta.Action;

                /** BindingDelta role. */
                public role: string;

                /** BindingDelta member. */
                public member: string;

                /** BindingDelta condition. */
                public condition?: (google.type.IExpr|null);

                /**
                 * Creates a new BindingDelta instance using the specified properties.
                 * @param [properties] Properties to set
                 * @returns BindingDelta instance
                 */
                public static create(properties?: google.iam.v1.IBindingDelta): google.iam.v1.BindingDelta;

                /**
                 * Encodes the specified BindingDelta message. Does not implicitly {@link google.iam.v1.BindingDelta.verify|verify} messages.
                 * @param message BindingDelta message or plain object to encode
                 * @param [writer] Writer to encode to
                 * @returns Writer
                 */
                public static encode(message: google.iam.v1.IBindingDelta, writer?: $protobuf.Writer): $protobuf.Writer;

                /**
                 * Encodes the specified BindingDelta message, length delimited. Does not implicitly {@link google.iam.v1.BindingDelta.verify|verify} messages.
                 * @param message BindingDelta message or plain object to encode
                 * @param [writer] Writer to encode to
                 * @returns Writer
                 */
                public static encodeDelimited(message: google.iam.v1.IBindingDelta, writer?: $protobuf.Writer): $protobuf.Writer;

                /**
                 * Decodes a BindingDelta message from the specified reader or buffer.
                 * @param reader Reader or buffer to decode from
                 * @param [length] Message length if known beforehand
                 * @returns BindingDelta
                 * @throws {Error} If the payload is not a reader or valid buffer
                 * @throws {$protobuf.util.ProtocolError} If required fields are missing
                 */
                public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.iam.v1.BindingDelta;

                /**
                 * Decodes a BindingDelta message from the specified reader or buffer, length delimited.
                 * @param reader Reader or buffer to decode from
                 * @returns BindingDelta
                 * @throws {Error} If the payload is not a reader or valid buffer
                 * @throws {$protobuf.util.ProtocolError} If required fields are missing
                 */
                public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.iam.v1.BindingDelta;

                /**
                 * Verifies a BindingDelta message.
                 * @param message Plain object to verify
                 * @returns `null` if valid, otherwise the reason why it is not
                 */
                public static verify(message: { [k: string]: any }): (string|null);

                /**
                 * Creates a BindingDelta message from a plain object. Also converts values to their respective internal types.
                 * @param object Plain object
                 * @returns BindingDelta
                 */
                public static fromObject(object: { [k: string]: any }): google.iam.v1.BindingDelta;

                /**
                 * Creates a plain object from a BindingDelta message. Also converts values to other types if specified.
                 * @param message BindingDelta
                 * @param [options] Conversion options
                 * @returns Plain object
                 */
                public static toObject(message: google.iam.v1.BindingDelta, options?: $protobuf.IConversionOptions): { [k: string]: any };

                /**
                 * Converts this BindingDelta to JSON.
                 * @returns JSON object
                 */
                public toJSON(): { [k: string]: any };
            }

            namespace BindingDelta {

                /** Action enum. */
                enum Action {
                    ACTION_UNSPECIFIED = 0,
                    ADD = 1,
                    REMOVE = 2
                }
            }

            /** Properties of an AuditConfigDelta. */
            interface IAuditConfigDelta {

                /** AuditConfigDelta action */
                action?: (google.iam.v1.AuditConfigDelta.Action|null);

                /** AuditConfigDelta service */
                service?: (string|null);

                /** AuditConfigDelta exemptedMember */
                exemptedMember?: (string|null);

                /** AuditConfigDelta logType */
                logType?: (string|null);
            }

            /** Represents an AuditConfigDelta. */
            class AuditConfigDelta implements IAuditConfigDelta {

                /**
                 * Constructs a new AuditConfigDelta.
                 * @param [properties] Properties to set
                 */
                constructor(properties?: google.iam.v1.IAuditConfigDelta);

                /** AuditConfigDelta action. */
                public action: google.iam.v1.AuditConfigDelta.Action;

                /** AuditConfigDelta service. */
                public service: string;

                /** AuditConfigDelta exemptedMember. */
                public exemptedMember: string;

                /** AuditConfigDelta logType. */
                public logType: string;

                /**
                 * Creates a new AuditConfigDelta instance using the specified properties.
                 * @param [properties] Properties to set
                 * @returns AuditConfigDelta instance
                 */
                public static create(properties?: google.iam.v1.IAuditConfigDelta): google.iam.v1.AuditConfigDelta;

                /**
                 * Encodes the specified AuditConfigDelta message. Does not implicitly {@link google.iam.v1.AuditConfigDelta.verify|verify} messages.
                 * @param message AuditConfigDelta message or plain object to encode
                 * @param [writer] Writer to encode to
                 * @returns Writer
                 */
                public static encode(message: google.iam.v1.IAuditConfigDelta, writer?: $protobuf.Writer): $protobuf.Writer;

                /**
                 * Encodes the specified AuditConfigDelta message, length delimited. Does not implicitly {@link google.iam.v1.AuditConfigDelta.verify|verify} messages.
                 * @param message AuditConfigDelta message or plain object to encode
                 * @param [writer] Writer to encode to
                 * @returns Writer
                 */
                public static encodeDelimited(message: google.iam.v1.IAuditConfigDelta, writer?: $protobuf.Writer): $protobuf.Writer;

                /**
                 * Decodes an AuditConfigDelta message from the specified reader or buffer.
                 * @param reader Reader or buffer to decode from
                 * @param [length] Message length if known beforehand
                 * @returns AuditConfigDelta
                 * @throws {Error} If the payload is not a reader or valid buffer
                 * @throws {$protobuf.util.ProtocolError} If required fields are missing
                 */
                public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.iam.v1.AuditConfigDelta;

                /**
                 * Decodes an AuditConfigDelta message from the specified reader or buffer, length delimited.
                 * @param reader Reader or buffer to decode from
                 * @returns AuditConfigDelta
                 * @throws {Error} If the payload is not a reader or valid buffer
                 * @throws {$protobuf.util.ProtocolError} If required fields are missing
                 */
                public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.iam.v1.AuditConfigDelta;

                /**
                 * Verifies an AuditConfigDelta message.
                 * @param message Plain object to verify
                 * @returns `null` if valid, otherwise the reason why it is not
                 */
                public static verify(message: { [k: string]: any }): (string|null);

                /**
                 * Creates an AuditConfigDelta message from a plain object. Also converts values to their respective internal types.
                 * @param object Plain object
                 * @returns AuditConfigDelta
                 */
                public static fromObject(object: { [k: string]: any }): google.iam.v1.AuditConfigDelta;

                /**
                 * Creates a plain object from an AuditConfigDelta message. Also converts values to other types if specified.
                 * @param message AuditConfigDelta
                 * @param [options] Conversion options
                 * @returns Plain object
                 */
                public static toObject(message: google.iam.v1.AuditConfigDelta, options?: $protobuf.IConversionOptions): { [k: string]: any };

                /**
                 * Converts this AuditConfigDelta to JSON.
                 * @returns JSON object
                 */
                public toJSON(): { [k: string]: any };
            }

            namespace AuditConfigDelta {

                /** Action enum. */
                enum Action {
                    ACTION_UNSPECIFIED = 0,
                    ADD = 1,
                    REMOVE = 2
                }
            }
        }
    }

    /** Namespace type. */
    namespace type {

        /** Properties of an Expr. */
        interface IExpr {

            /** Expr expression */
            expression?: (string|null);

            /** Expr title */
            title?: (string|null);

            /** Expr description */
            description?: (string|null);

            /** Expr location */
            location?: (string|null);
        }

        /** Represents an Expr. */
        class Expr implements IExpr {

            /**
             * Constructs a new Expr.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.type.IExpr);

            /** Expr expression. */
            public expression: string;

            /** Expr title. */
            public title: string;

            /** Expr description. */
            public description: string;

            /** Expr location. */
            public location: string;

            /**
             * Creates a new Expr instance using the specified properties.
             * @param [properties] Properties to set
             * @returns Expr instance
             */
            public static create(properties?: google.type.IExpr): google.type.Expr;

            /**
             * Encodes the specified Expr message. Does not implicitly {@link google.type.Expr.verify|verify} messages.
             * @param message Expr message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.type.IExpr, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified Expr message, length delimited. Does not implicitly {@link google.type.Expr.verify|verify} messages.
             * @param message Expr message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.type.IExpr, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes an Expr message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns Expr
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.type.Expr;

            /**
             * Decodes an Expr message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns Expr
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.type.Expr;

            /**
             * Verifies an Expr message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates an Expr message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns Expr
             */
            public static fromObject(object: { [k: string]: any }): google.type.Expr;

            /**
             * Creates a plain object from an Expr message. Also converts values to other types if specified.
             * @param message Expr
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.type.Expr, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this Expr to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }
    }

    /** Namespace longrunning. */
    namespace longrunning {

        /** Represents an Operations */
        class Operations extends $protobuf.rpc.Service {

            /**
             * Constructs a new Operations service.
             * @param rpcImpl RPC implementation
             * @param [requestDelimited=false] Whether requests are length-delimited
             * @param [responseDelimited=false] Whether responses are length-delimited
             */
            constructor(rpcImpl: $protobuf.RPCImpl, requestDelimited?: boolean, responseDelimited?: boolean);

            /**
             * Creates new Operations service using the specified rpc implementation.
             * @param rpcImpl RPC implementation
             * @param [requestDelimited=false] Whether requests are length-delimited
             * @param [responseDelimited=false] Whether responses are length-delimited
             * @returns RPC service. Useful where requests and/or responses are streamed.
             */
            public static create(rpcImpl: $protobuf.RPCImpl, requestDelimited?: boolean, responseDelimited?: boolean): Operations;

            /**
             * Calls ListOperations.
             * @param request ListOperationsRequest message or plain object
             * @param callback Node-style callback called with the error, if any, and ListOperationsResponse
             */
            public listOperations(request: google.longrunning.IListOperationsRequest, callback: google.longrunning.Operations.ListOperationsCallback): void;

            /**
             * Calls ListOperations.
             * @param request ListOperationsRequest message or plain object
             * @returns Promise
             */
            public listOperations(request: google.longrunning.IListOperationsRequest): Promise<google.longrunning.ListOperationsResponse>;

            /**
             * Calls GetOperation.
             * @param request GetOperationRequest message or plain object
             * @param callback Node-style callback called with the error, if any, and Operation
             */
            public getOperation(request: google.longrunning.IGetOperationRequest, callback: google.longrunning.Operations.GetOperationCallback): void;

            /**
             * Calls GetOperation.
             * @param request GetOperationRequest message or plain object
             * @returns Promise
             */
            public getOperation(request: google.longrunning.IGetOperationRequest): Promise<google.longrunning.Operation>;

            /**
             * Calls DeleteOperation.
             * @param request DeleteOperationRequest message or plain object
             * @param callback Node-style callback called with the error, if any, and Empty
             */
            public deleteOperation(request: google.longrunning.IDeleteOperationRequest, callback: google.longrunning.Operations.DeleteOperationCallback): void;

            /**
             * Calls DeleteOperation.
             * @param request DeleteOperationRequest message or plain object
             * @returns Promise
             */
            public deleteOperation(request: google.longrunning.IDeleteOperationRequest): Promise<google.protobuf.Empty>;

            /**
             * Calls CancelOperation.
             * @param request CancelOperationRequest message or plain object
             * @param callback Node-style callback called with the error, if any, and Empty
             */
            public cancelOperation(request: google.longrunning.ICancelOperationRequest, callback: google.longrunning.Operations.CancelOperationCallback): void;

            /**
             * Calls CancelOperation.
             * @param request CancelOperationRequest message or plain object
             * @returns Promise
             */
            public cancelOperation(request: google.longrunning.ICancelOperationRequest): Promise<google.protobuf.Empty>;

            /**
             * Calls WaitOperation.
             * @param request WaitOperationRequest message or plain object
             * @param callback Node-style callback called with the error, if any, and Operation
             */
            public waitOperation(request: google.longrunning.IWaitOperationRequest, callback: google.longrunning.Operations.WaitOperationCallback): void;

            /**
             * Calls WaitOperation.
             * @param request WaitOperationRequest message or plain object
             * @returns Promise
             */
            public waitOperation(request: google.longrunning.IWaitOperationRequest): Promise<google.longrunning.Operation>;
        }

        namespace Operations {

            /**
             * Callback as used by {@link google.longrunning.Operations#listOperations}.
             * @param error Error, if any
             * @param [response] ListOperationsResponse
             */
            type ListOperationsCallback = (error: (Error|null), response?: google.longrunning.ListOperationsResponse) => void;

            /**
             * Callback as used by {@link google.longrunning.Operations#getOperation}.
             * @param error Error, if any
             * @param [response] Operation
             */
            type GetOperationCallback = (error: (Error|null), response?: google.longrunning.Operation) => void;

            /**
             * Callback as used by {@link google.longrunning.Operations#deleteOperation}.
             * @param error Error, if any
             * @param [response] Empty
             */
            type DeleteOperationCallback = (error: (Error|null), response?: google.protobuf.Empty) => void;

            /**
             * Callback as used by {@link google.longrunning.Operations#cancelOperation}.
             * @param error Error, if any
             * @param [response] Empty
             */
            type CancelOperationCallback = (error: (Error|null), response?: google.protobuf.Empty) => void;

            /**
             * Callback as used by {@link google.longrunning.Operations#waitOperation}.
             * @param error Error, if any
             * @param [response] Operation
             */
            type WaitOperationCallback = (error: (Error|null), response?: google.longrunning.Operation) => void;
        }

        /** Properties of an Operation. */
        interface IOperation {

            /** Operation name */
            name?: (string|null);

            /** Operation metadata */
            metadata?: (google.protobuf.IAny|null);

            /** Operation done */
            done?: (boolean|null);

            /** Operation error */
            error?: (google.rpc.IStatus|null);

            /** Operation response */
            response?: (google.protobuf.IAny|null);
        }

        /** Represents an Operation. */
        class Operation implements IOperation {

            /**
             * Constructs a new Operation.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.longrunning.IOperation);

            /** Operation name. */
            public name: string;

            /** Operation metadata. */
            public metadata?: (google.protobuf.IAny|null);

            /** Operation done. */
            public done: boolean;

            /** Operation error. */
            public error?: (google.rpc.IStatus|null);

            /** Operation response. */
            public response?: (google.protobuf.IAny|null);

            /** Operation result. */
            public result?: ("error"|"response");

            /**
             * Creates a new Operation instance using the specified properties.
             * @param [properties] Properties to set
             * @returns Operation instance
             */
            public static create(properties?: google.longrunning.IOperation): google.longrunning.Operation;

            /**
             * Encodes the specified Operation message. Does not implicitly {@link google.longrunning.Operation.verify|verify} messages.
             * @param message Operation message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.longrunning.IOperation, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified Operation message, length delimited. Does not implicitly {@link google.longrunning.Operation.verify|verify} messages.
             * @param message Operation message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.longrunning.IOperation, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes an Operation message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns Operation
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.longrunning.Operation;

            /**
             * Decodes an Operation message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns Operation
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.longrunning.Operation;

            /**
             * Verifies an Operation message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates an Operation message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns Operation
             */
            public static fromObject(object: { [k: string]: any }): google.longrunning.Operation;

            /**
             * Creates a plain object from an Operation message. Also converts values to other types if specified.
             * @param message Operation
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.longrunning.Operation, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this Operation to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }

        /** Properties of a GetOperationRequest. */
        interface IGetOperationRequest {

            /** GetOperationRequest name */
            name?: (string|null);
        }

        /** Represents a GetOperationRequest. */
        class GetOperationRequest implements IGetOperationRequest {

            /**
             * Constructs a new GetOperationRequest.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.longrunning.IGetOperationRequest);

            /** GetOperationRequest name. */
            public name: string;

            /**
             * Creates a new GetOperationRequest instance using the specified properties.
             * @param [properties] Properties to set
             * @returns GetOperationRequest instance
             */
            public static create(properties?: google.longrunning.IGetOperationRequest): google.longrunning.GetOperationRequest;

            /**
             * Encodes the specified GetOperationRequest message. Does not implicitly {@link google.longrunning.GetOperationRequest.verify|verify} messages.
             * @param message GetOperationRequest message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.longrunning.IGetOperationRequest, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified GetOperationRequest message, length delimited. Does not implicitly {@link google.longrunning.GetOperationRequest.verify|verify} messages.
             * @param message GetOperationRequest message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.longrunning.IGetOperationRequest, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes a GetOperationRequest message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns GetOperationRequest
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.longrunning.GetOperationRequest;

            /**
             * Decodes a GetOperationRequest message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns GetOperationRequest
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.longrunning.GetOperationRequest;

            /**
             * Verifies a GetOperationRequest message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates a GetOperationRequest message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns GetOperationRequest
             */
            public static fromObject(object: { [k: string]: any }): google.longrunning.GetOperationRequest;

            /**
             * Creates a plain object from a GetOperationRequest message. Also converts values to other types if specified.
             * @param message GetOperationRequest
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.longrunning.GetOperationRequest, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this GetOperationRequest to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }

        /** Properties of a ListOperationsRequest. */
        interface IListOperationsRequest {

            /** ListOperationsRequest name */
            name?: (string|null);

            /** ListOperationsRequest filter */
            filter?: (string|null);

            /** ListOperationsRequest pageSize */
            pageSize?: (number|null);

            /** ListOperationsRequest pageToken */
            pageToken?: (string|null);
        }

        /** Represents a ListOperationsRequest. */
        class ListOperationsRequest implements IListOperationsRequest {

            /**
             * Constructs a new ListOperationsRequest.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.longrunning.IListOperationsRequest);

            /** ListOperationsRequest name. */
            public name: string;

            /** ListOperationsRequest filter. */
            public filter: string;

            /** ListOperationsRequest pageSize. */
            public pageSize: number;

            /** ListOperationsRequest pageToken. */
            public pageToken: string;

            /**
             * Creates a new ListOperationsRequest instance using the specified properties.
             * @param [properties] Properties to set
             * @returns ListOperationsRequest instance
             */
            public static create(properties?: google.longrunning.IListOperationsRequest): google.longrunning.ListOperationsRequest;

            /**
             * Encodes the specified ListOperationsRequest message. Does not implicitly {@link google.longrunning.ListOperationsRequest.verify|verify} messages.
             * @param message ListOperationsRequest message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.longrunning.IListOperationsRequest, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified ListOperationsRequest message, length delimited. Does not implicitly {@link google.longrunning.ListOperationsRequest.verify|verify} messages.
             * @param message ListOperationsRequest message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.longrunning.IListOperationsRequest, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes a ListOperationsRequest message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns ListOperationsRequest
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.longrunning.ListOperationsRequest;

            /**
             * Decodes a ListOperationsRequest message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns ListOperationsRequest
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.longrunning.ListOperationsRequest;

            /**
             * Verifies a ListOperationsRequest message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates a ListOperationsRequest message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns ListOperationsRequest
             */
            public static fromObject(object: { [k: string]: any }): google.longrunning.ListOperationsRequest;

            /**
             * Creates a plain object from a ListOperationsRequest message. Also converts values to other types if specified.
             * @param message ListOperationsRequest
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.longrunning.ListOperationsRequest, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this ListOperationsRequest to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }

        /** Properties of a ListOperationsResponse. */
        interface IListOperationsResponse {

            /** ListOperationsResponse operations */
            operations?: (google.longrunning.IOperation[]|null);

            /** ListOperationsResponse nextPageToken */
            nextPageToken?: (string|null);
        }

        /** Represents a ListOperationsResponse. */
        class ListOperationsResponse implements IListOperationsResponse {

            /**
             * Constructs a new ListOperationsResponse.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.longrunning.IListOperationsResponse);

            /** ListOperationsResponse operations. */
            public operations: google.longrunning.IOperation[];

            /** ListOperationsResponse nextPageToken. */
            public nextPageToken: string;

            /**
             * Creates a new ListOperationsResponse instance using the specified properties.
             * @param [properties] Properties to set
             * @returns ListOperationsResponse instance
             */
            public static create(properties?: google.longrunning.IListOperationsResponse): google.longrunning.ListOperationsResponse;

            /**
             * Encodes the specified ListOperationsResponse message. Does not implicitly {@link google.longrunning.ListOperationsResponse.verify|verify} messages.
             * @param message ListOperationsResponse message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.longrunning.IListOperationsResponse, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified ListOperationsResponse message, length delimited. Does not implicitly {@link google.longrunning.ListOperationsResponse.verify|verify} messages.
             * @param message ListOperationsResponse message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.longrunning.IListOperationsResponse, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes a ListOperationsResponse message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns ListOperationsResponse
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.longrunning.ListOperationsResponse;

            /**
             * Decodes a ListOperationsResponse message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns ListOperationsResponse
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.longrunning.ListOperationsResponse;

            /**
             * Verifies a ListOperationsResponse message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates a ListOperationsResponse message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns ListOperationsResponse
             */
            public static fromObject(object: { [k: string]: any }): google.longrunning.ListOperationsResponse;

            /**
             * Creates a plain object from a ListOperationsResponse message. Also converts values to other types if specified.
             * @param message ListOperationsResponse
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.longrunning.ListOperationsResponse, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this ListOperationsResponse to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }

        /** Properties of a CancelOperationRequest. */
        interface ICancelOperationRequest {

            /** CancelOperationRequest name */
            name?: (string|null);
        }

        /** Represents a CancelOperationRequest. */
        class CancelOperationRequest implements ICancelOperationRequest {

            /**
             * Constructs a new CancelOperationRequest.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.longrunning.ICancelOperationRequest);

            /** CancelOperationRequest name. */
            public name: string;

            /**
             * Creates a new CancelOperationRequest instance using the specified properties.
             * @param [properties] Properties to set
             * @returns CancelOperationRequest instance
             */
            public static create(properties?: google.longrunning.ICancelOperationRequest): google.longrunning.CancelOperationRequest;

            /**
             * Encodes the specified CancelOperationRequest message. Does not implicitly {@link google.longrunning.CancelOperationRequest.verify|verify} messages.
             * @param message CancelOperationRequest message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.longrunning.ICancelOperationRequest, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified CancelOperationRequest message, length delimited. Does not implicitly {@link google.longrunning.CancelOperationRequest.verify|verify} messages.
             * @param message CancelOperationRequest message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.longrunning.ICancelOperationRequest, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes a CancelOperationRequest message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns CancelOperationRequest
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.longrunning.CancelOperationRequest;

            /**
             * Decodes a CancelOperationRequest message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns CancelOperationRequest
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.longrunning.CancelOperationRequest;

            /**
             * Verifies a CancelOperationRequest message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates a CancelOperationRequest message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns CancelOperationRequest
             */
            public static fromObject(object: { [k: string]: any }): google.longrunning.CancelOperationRequest;

            /**
             * Creates a plain object from a CancelOperationRequest message. Also converts values to other types if specified.
             * @param message CancelOperationRequest
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.longrunning.CancelOperationRequest, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this CancelOperationRequest to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }

        /** Properties of a DeleteOperationRequest. */
        interface IDeleteOperationRequest {

            /** DeleteOperationRequest name */
            name?: (string|null);
        }

        /** Represents a DeleteOperationRequest. */
        class DeleteOperationRequest implements IDeleteOperationRequest {

            /**
             * Constructs a new DeleteOperationRequest.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.longrunning.IDeleteOperationRequest);

            /** DeleteOperationRequest name. */
            public name: string;

            /**
             * Creates a new DeleteOperationRequest instance using the specified properties.
             * @param [properties] Properties to set
             * @returns DeleteOperationRequest instance
             */
            public static create(properties?: google.longrunning.IDeleteOperationRequest): google.longrunning.DeleteOperationRequest;

            /**
             * Encodes the specified DeleteOperationRequest message. Does not implicitly {@link google.longrunning.DeleteOperationRequest.verify|verify} messages.
             * @param message DeleteOperationRequest message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.longrunning.IDeleteOperationRequest, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified DeleteOperationRequest message, length delimited. Does not implicitly {@link google.longrunning.DeleteOperationRequest.verify|verify} messages.
             * @param message DeleteOperationRequest message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.longrunning.IDeleteOperationRequest, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes a DeleteOperationRequest message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns DeleteOperationRequest
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.longrunning.DeleteOperationRequest;

            /**
             * Decodes a DeleteOperationRequest message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns DeleteOperationRequest
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.longrunning.DeleteOperationRequest;

            /**
             * Verifies a DeleteOperationRequest message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates a DeleteOperationRequest message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns DeleteOperationRequest
             */
            public static fromObject(object: { [k: string]: any }): google.longrunning.DeleteOperationRequest;

            /**
             * Creates a plain object from a DeleteOperationRequest message. Also converts values to other types if specified.
             * @param message DeleteOperationRequest
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.longrunning.DeleteOperationRequest, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this DeleteOperationRequest to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }

        /** Properties of a WaitOperationRequest. */
        interface IWaitOperationRequest {

            /** WaitOperationRequest name */
            name?: (string|null);

            /** WaitOperationRequest timeout */
            timeout?: (google.protobuf.IDuration|null);
        }

        /** Represents a WaitOperationRequest. */
        class WaitOperationRequest implements IWaitOperationRequest {

            /**
             * Constructs a new WaitOperationRequest.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.longrunning.IWaitOperationRequest);

            /** WaitOperationRequest name. */
            public name: string;

            /** WaitOperationRequest timeout. */
            public timeout?: (google.protobuf.IDuration|null);

            /**
             * Creates a new WaitOperationRequest instance using the specified properties.
             * @param [properties] Properties to set
             * @returns WaitOperationRequest instance
             */
            public static create(properties?: google.longrunning.IWaitOperationRequest): google.longrunning.WaitOperationRequest;

            /**
             * Encodes the specified WaitOperationRequest message. Does not implicitly {@link google.longrunning.WaitOperationRequest.verify|verify} messages.
             * @param message WaitOperationRequest message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.longrunning.IWaitOperationRequest, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified WaitOperationRequest message, length delimited. Does not implicitly {@link google.longrunning.WaitOperationRequest.verify|verify} messages.
             * @param message WaitOperationRequest message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.longrunning.IWaitOperationRequest, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes a WaitOperationRequest message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns WaitOperationRequest
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.longrunning.WaitOperationRequest;

            /**
             * Decodes a WaitOperationRequest message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns WaitOperationRequest
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.longrunning.WaitOperationRequest;

            /**
             * Verifies a WaitOperationRequest message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates a WaitOperationRequest message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns WaitOperationRequest
             */
            public static fromObject(object: { [k: string]: any }): google.longrunning.WaitOperationRequest;

            /**
             * Creates a plain object from a WaitOperationRequest message. Also converts values to other types if specified.
             * @param message WaitOperationRequest
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.longrunning.WaitOperationRequest, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this WaitOperationRequest to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }

        /** Properties of an OperationInfo. */
        interface IOperationInfo {

            /** OperationInfo responseType */
            responseType?: (string|null);

            /** OperationInfo metadataType */
            metadataType?: (string|null);
        }

        /** Represents an OperationInfo. */
        class OperationInfo implements IOperationInfo {

            /**
             * Constructs a new OperationInfo.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.longrunning.IOperationInfo);

            /** OperationInfo responseType. */
            public responseType: string;

            /** OperationInfo metadataType. */
            public metadataType: string;

            /**
             * Creates a new OperationInfo instance using the specified properties.
             * @param [properties] Properties to set
             * @returns OperationInfo instance
             */
            public static create(properties?: google.longrunning.IOperationInfo): google.longrunning.OperationInfo;

            /**
             * Encodes the specified OperationInfo message. Does not implicitly {@link google.longrunning.OperationInfo.verify|verify} messages.
             * @param message OperationInfo message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.longrunning.IOperationInfo, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified OperationInfo message, length delimited. Does not implicitly {@link google.longrunning.OperationInfo.verify|verify} messages.
             * @param message OperationInfo message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.longrunning.IOperationInfo, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes an OperationInfo message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns OperationInfo
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.longrunning.OperationInfo;

            /**
             * Decodes an OperationInfo message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns OperationInfo
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.longrunning.OperationInfo;

            /**
             * Verifies an OperationInfo message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates an OperationInfo message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns OperationInfo
             */
            public static fromObject(object: { [k: string]: any }): google.longrunning.OperationInfo;

            /**
             * Creates a plain object from an OperationInfo message. Also converts values to other types if specified.
             * @param message OperationInfo
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.longrunning.OperationInfo, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this OperationInfo to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }
    }

    /** Namespace rpc. */
    namespace rpc {

        /** Properties of a Status. */
        interface IStatus {

            /** Status code */
            code?: (number|null);

            /** Status message */
            message?: (string|null);

            /** Status details */
            details?: (google.protobuf.IAny[]|null);
        }

        /** Represents a Status. */
        class Status implements IStatus {

            /**
             * Constructs a new Status.
             * @param [properties] Properties to set
             */
            constructor(properties?: google.rpc.IStatus);

            /** Status code. */
            public code: number;

            /** Status message. */
            public message: string;

            /** Status details. */
            public details: google.protobuf.IAny[];

            /**
             * Creates a new Status instance using the specified properties.
             * @param [properties] Properties to set
             * @returns Status instance
             */
            public static create(properties?: google.rpc.IStatus): google.rpc.Status;

            /**
             * Encodes the specified Status message. Does not implicitly {@link google.rpc.Status.verify|verify} messages.
             * @param message Status message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encode(message: google.rpc.IStatus, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Encodes the specified Status message, length delimited. Does not implicitly {@link google.rpc.Status.verify|verify} messages.
             * @param message Status message or plain object to encode
             * @param [writer] Writer to encode to
             * @returns Writer
             */
            public static encodeDelimited(message: google.rpc.IStatus, writer?: $protobuf.Writer): $protobuf.Writer;

            /**
             * Decodes a Status message from the specified reader or buffer.
             * @param reader Reader or buffer to decode from
             * @param [length] Message length if known beforehand
             * @returns Status
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decode(reader: ($protobuf.Reader|Uint8Array), length?: number): google.rpc.Status;

            /**
             * Decodes a Status message from the specified reader or buffer, length delimited.
             * @param reader Reader or buffer to decode from
             * @returns Status
             * @throws {Error} If the payload is not a reader or valid buffer
             * @throws {$protobuf.util.ProtocolError} If required fields are missing
             */
            public static decodeDelimited(reader: ($protobuf.Reader|Uint8Array)): google.rpc.Status;

            /**
             * Verifies a Status message.
             * @param message Plain object to verify
             * @returns `null` if valid, otherwise the reason why it is not
             */
            public static verify(message: { [k: string]: any }): (string|null);

            /**
             * Creates a Status message from a plain object. Also converts values to their respective internal types.
             * @param object Plain object
             * @returns Status
             */
            public static fromObject(object: { [k: string]: any }): google.rpc.Status;

            /**
             * Creates a plain object from a Status message. Also converts values to other types if specified.
             * @param message Status
             * @param [options] Conversion options
             * @returns Plain object
             */
            public static toObject(message: google.rpc.Status, options?: $protobuf.IConversionOptions): { [k: string]: any };

            /**
             * Converts this Status to JSON.
             * @returns JSON object
             */
            public toJSON(): { [k: string]: any };
        }
    }
}
