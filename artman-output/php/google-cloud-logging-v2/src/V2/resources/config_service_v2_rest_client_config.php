<?php

return [
    'interfaces' => [
        'google.logging.v2.ConfigServiceV2' => [
            'ListBuckets' => [
                'method' => 'get',
                'uriTemplate' => '/v2/{parent=*/*/locations/*}/buckets',
                'additionalBindings' => [
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2/{parent=projects/*/locations/*}/buckets',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2/{parent=organizations/*/locations/*}/buckets',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2/{parent=folders/*/locations/*}/buckets',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2/{parent=billingAccounts/*/locations/*}/buckets',
                    ],
                ],
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'GetBucket' => [
                'method' => 'get',
                'uriTemplate' => '/v2/{name=*/*/locations/*/buckets/*}',
                'additionalBindings' => [
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2/{name=projects/*/locations/*/buckets/*}',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2/{name=organizations/*/locations/*/buckets/*}',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2/{name=folders/*/locations/*/buckets/*}',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2/{name=billingAccounts/*/buckets/*}',
                    ],
                ],
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'UpdateBucket' => [
                'method' => 'patch',
                'uriTemplate' => '/v2/{name=*/*/locations/*/buckets/*}',
                'body' => 'bucket',
                'additionalBindings' => [
                    [
                        'method' => 'patch',
                        'uriTemplate' => '/v2/{name=projects/*/locations/*/buckets/*}',
                        'body' => 'bucket',
                    ],
                    [
                        'method' => 'patch',
                        'uriTemplate' => '/v2/{name=organizations/*/locations/*/buckets/*}',
                        'body' => 'bucket',
                    ],
                    [
                        'method' => 'patch',
                        'uriTemplate' => '/v2/{name=folders/*/locations/*/buckets/*}',
                        'body' => 'bucket',
                    ],
                    [
                        'method' => 'patch',
                        'uriTemplate' => '/v2/{name=billingAccounts/*/locations/*/buckets/*}',
                        'body' => 'bucket',
                    ],
                ],
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListSinks' => [
                'method' => 'get',
                'uriTemplate' => '/v2/{parent=*/*}/sinks',
                'additionalBindings' => [
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2/{parent=projects/*}/sinks',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2/{parent=organizations/*}/sinks',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2/{parent=folders/*}/sinks',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2/{parent=billingAccounts/*}/sinks',
                    ],
                ],
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'GetSink' => [
                'method' => 'get',
                'uriTemplate' => '/v2/{sink_name=*/*/sinks/*}',
                'additionalBindings' => [
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2/{sink_name=projects/*/sinks/*}',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2/{sink_name=organizations/*/sinks/*}',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2/{sink_name=folders/*/sinks/*}',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2/{sink_name=billingAccounts/*/sinks/*}',
                    ],
                ],
                'placeholders' => [
                    'sink_name' => [
                        'getters' => [
                            'getSinkName',
                        ],
                    ],
                ],
            ],
            'CreateSink' => [
                'method' => 'post',
                'uriTemplate' => '/v2/{parent=*/*}/sinks',
                'body' => 'sink',
                'additionalBindings' => [
                    [
                        'method' => 'post',
                        'uriTemplate' => '/v2/{parent=projects/*}/sinks',
                        'body' => 'sink',
                    ],
                    [
                        'method' => 'post',
                        'uriTemplate' => '/v2/{parent=organizations/*}/sinks',
                        'body' => 'sink',
                    ],
                    [
                        'method' => 'post',
                        'uriTemplate' => '/v2/{parent=folders/*}/sinks',
                        'body' => 'sink',
                    ],
                    [
                        'method' => 'post',
                        'uriTemplate' => '/v2/{parent=billingAccounts/*}/sinks',
                        'body' => 'sink',
                    ],
                ],
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'UpdateSink' => [
                'method' => 'put',
                'uriTemplate' => '/v2/{sink_name=*/*/sinks/*}',
                'body' => 'sink',
                'additionalBindings' => [
                    [
                        'method' => 'put',
                        'uriTemplate' => '/v2/{sink_name=projects/*/sinks/*}',
                        'body' => 'sink',
                    ],
                    [
                        'method' => 'put',
                        'uriTemplate' => '/v2/{sink_name=organizations/*/sinks/*}',
                        'body' => 'sink',
                    ],
                    [
                        'method' => 'put',
                        'uriTemplate' => '/v2/{sink_name=folders/*/sinks/*}',
                        'body' => 'sink',
                    ],
                    [
                        'method' => 'put',
                        'uriTemplate' => '/v2/{sink_name=billingAccounts/*/sinks/*}',
                        'body' => 'sink',
                    ],
                    [
                        'method' => 'put',
                        'uriTemplate' => '/v2/{sink_name=projects/*/sinks/*}',
                        'body' => 'sink',
                    ],
                    [
                        'method' => 'put',
                        'uriTemplate' => '/v2/{sink_name=organizations/*/sinks/*}',
                        'body' => 'sink',
                    ],
                    [
                        'method' => 'put',
                        'uriTemplate' => '/v2/{sink_name=folders/*/sinks/*}',
                        'body' => 'sink',
                    ],
                    [
                        'method' => 'put',
                        'uriTemplate' => '/v2/{sink_name=billingAccounts/*/sinks/*}',
                        'body' => 'sink',
                    ],
                ],
                'placeholders' => [
                    'sink_name' => [
                        'getters' => [
                            'getSinkName',
                        ],
                    ],
                ],
            ],
            'DeleteSink' => [
                'method' => 'delete',
                'uriTemplate' => '/v2/{sink_name=*/*/sinks/*}',
                'additionalBindings' => [
                    [
                        'method' => 'delete',
                        'uriTemplate' => '/v2/{sink_name=projects/*/sinks/*}',
                    ],
                    [
                        'method' => 'delete',
                        'uriTemplate' => '/v2/{sink_name=organizations/*/sinks/*}',
                    ],
                    [
                        'method' => 'delete',
                        'uriTemplate' => '/v2/{sink_name=folders/*/sinks/*}',
                    ],
                    [
                        'method' => 'delete',
                        'uriTemplate' => '/v2/{sink_name=billingAccounts/*/sinks/*}',
                    ],
                ],
                'placeholders' => [
                    'sink_name' => [
                        'getters' => [
                            'getSinkName',
                        ],
                    ],
                ],
            ],
            'ListExclusions' => [
                'method' => 'get',
                'uriTemplate' => '/v2/{parent=*/*}/exclusions',
                'additionalBindings' => [
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2/{parent=projects/*}/exclusions',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2/{parent=organizations/*}/exclusions',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2/{parent=folders/*}/exclusions',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2/{parent=billingAccounts/*}/exclusions',
                    ],
                ],
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'GetExclusion' => [
                'method' => 'get',
                'uriTemplate' => '/v2/{name=*/*/exclusions/*}',
                'additionalBindings' => [
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2/{name=projects/*/exclusions/*}',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2/{name=organizations/*/exclusions/*}',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2/{name=folders/*/exclusions/*}',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2/{name=billingAccounts/*/exclusions/*}',
                    ],
                ],
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'CreateExclusion' => [
                'method' => 'post',
                'uriTemplate' => '/v2/{parent=*/*}/exclusions',
                'body' => 'exclusion',
                'additionalBindings' => [
                    [
                        'method' => 'post',
                        'uriTemplate' => '/v2/{parent=projects/*}/exclusions',
                        'body' => 'exclusion',
                    ],
                    [
                        'method' => 'post',
                        'uriTemplate' => '/v2/{parent=organizations/*}/exclusions',
                        'body' => 'exclusion',
                    ],
                    [
                        'method' => 'post',
                        'uriTemplate' => '/v2/{parent=folders/*}/exclusions',
                        'body' => 'exclusion',
                    ],
                    [
                        'method' => 'post',
                        'uriTemplate' => '/v2/{parent=billingAccounts/*}/exclusions',
                        'body' => 'exclusion',
                    ],
                ],
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'UpdateExclusion' => [
                'method' => 'patch',
                'uriTemplate' => '/v2/{name=*/*/exclusions/*}',
                'body' => 'exclusion',
                'additionalBindings' => [
                    [
                        'method' => 'patch',
                        'uriTemplate' => '/v2/{name=projects/*/exclusions/*}',
                        'body' => 'exclusion',
                    ],
                    [
                        'method' => 'patch',
                        'uriTemplate' => '/v2/{name=organizations/*/exclusions/*}',
                        'body' => 'exclusion',
                    ],
                    [
                        'method' => 'patch',
                        'uriTemplate' => '/v2/{name=folders/*/exclusions/*}',
                        'body' => 'exclusion',
                    ],
                    [
                        'method' => 'patch',
                        'uriTemplate' => '/v2/{name=billingAccounts/*/exclusions/*}',
                        'body' => 'exclusion',
                    ],
                ],
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeleteExclusion' => [
                'method' => 'delete',
                'uriTemplate' => '/v2/{name=*/*/exclusions/*}',
                'additionalBindings' => [
                    [
                        'method' => 'delete',
                        'uriTemplate' => '/v2/{name=projects/*/exclusions/*}',
                    ],
                    [
                        'method' => 'delete',
                        'uriTemplate' => '/v2/{name=organizations/*/exclusions/*}',
                    ],
                    [
                        'method' => 'delete',
                        'uriTemplate' => '/v2/{name=folders/*/exclusions/*}',
                    ],
                    [
                        'method' => 'delete',
                        'uriTemplate' => '/v2/{name=billingAccounts/*/exclusions/*}',
                    ],
                ],
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetCmekSettings' => [
                'method' => 'get',
                'uriTemplate' => '/v2/{name=*/*}/cmekSettings',
                'additionalBindings' => [
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2/{name=organizations/*}/cmekSettings',
                    ],
                ],
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'UpdateCmekSettings' => [
                'method' => 'patch',
                'uriTemplate' => '/v2/{name=*/*}/cmekSettings',
                'body' => 'cmek_settings',
                'additionalBindings' => [
                    [
                        'method' => 'patch',
                        'uriTemplate' => '/v2/{name=organizations/*}/cmekSettings',
                        'body' => 'cmek_settings',
                    ],
                ],
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
        ],
    ],
];
