<?php

return [
    'interfaces' => [
        'google.devtools.containeranalysis.v1beta1.ContainerAnalysisV1Beta1' => [
            'SetIamPolicy' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{resource=projects/*/notes/*}:setIamPolicy',
                'body' => '*',
                'additionalBindings' => [
                    [
                        'method' => 'post',
                        'uriTemplate' => '/v1beta1/{resource=projects/*/occurrences/*}:setIamPolicy',
                        'body' => '*',
                    ],
                ],
                'placeholders' => [
                    'resource' => [
                        'getters' => [
                            'getResource',
                        ],
                    ],
                ]
            ],
            'GetIamPolicy' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{resource=projects/*/notes/*}:getIamPolicy',
                'body' => '*',
                'additionalBindings' => [
                    [
                        'method' => 'post',
                        'uriTemplate' => '/v1beta1/{resource=projects/*/occurrences/*}:getIamPolicy',
                        'body' => '*',
                    ],
                ],
                'placeholders' => [
                    'resource' => [
                        'getters' => [
                            'getResource',
                        ],
                    ],
                ]
            ],
            'TestIamPermissions' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{resource=projects/*/notes/*}:testIamPermissions',
                'body' => '*',
                'additionalBindings' => [
                    [
                        'method' => 'post',
                        'uriTemplate' => '/v1beta1/{resource=projects/*/occurrences/*}:testIamPermissions',
                        'body' => '*',
                    ],
                ],
                'placeholders' => [
                    'resource' => [
                        'getters' => [
                            'getResource',
                        ],
                    ],
                ]
            ],
            'GetScanConfig' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{name=projects/*/scanConfigs/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ]
            ],
            'ListScanConfigs' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{parent=projects/*}/scanConfigs',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ]
            ],
            'UpdateScanConfig' => [
                'method' => 'put',
                'uriTemplate' => '/v1beta1/{name=projects/*/scanConfigs/*}',
                'body' => 'scan_config',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ]
            ],
        ],
    ]
];
