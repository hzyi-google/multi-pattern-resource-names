<?php

return [
    'interfaces' => [
        'google.logging.v2.LoggingServiceV2' => [
            'WriteLogEntries' => [
                'method' => 'post',
                'uriTemplate' => '/v2/entries:write',
                'body' => '*',
            ],
            'DeleteLog' => [
                'method' => 'delete',
                'uriTemplate' => '/v2/{log_name=projects/*/logs/*}',
                'additionalBindings' => [
                    [
                        'method' => 'delete',
                        'uriTemplate' => '/v2/{log_name=*/*/logs/*}',
                    ],
                    [
                        'method' => 'delete',
                        'uriTemplate' => '/v2/{log_name=organizations/*/logs/*}',
                    ],
                    [
                        'method' => 'delete',
                        'uriTemplate' => '/v2/{log_name=folders/*/logs/*}',
                    ],
                    [
                        'method' => 'delete',
                        'uriTemplate' => '/v2/{log_name=billingAccounts/*/logs/*}',
                    ],
                ],
                'placeholders' => [
                    'log_name' => [
                        'getters' => [
                            'getLogName',
                        ],
                    ],
                ],
            ],
            'ListLogEntries' => [
                'method' => 'post',
                'uriTemplate' => '/v2/entries:list',
                'body' => '*',
            ],
            'ListMonitoredResourceDescriptors' => [
                'method' => 'get',
                'uriTemplate' => '/v2/monitoredResourceDescriptors',
            ],
            'ListLogs' => [
                'method' => 'get',
                'uriTemplate' => '/v2/{parent=*/*}/logs',
                'additionalBindings' => [
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2/{parent=projects/*}/logs',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2/{parent=organizations/*}/logs',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2/{parent=folders/*}/logs',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2/{parent=billingAccounts/*}/logs',
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
        ],
    ],
];
