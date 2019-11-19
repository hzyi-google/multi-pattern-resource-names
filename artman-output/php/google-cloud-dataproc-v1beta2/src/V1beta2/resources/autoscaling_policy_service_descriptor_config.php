<?php

return [
    'interfaces' => [
        'google.cloud.dataproc.v1beta2.AutoscalingPolicyService' => [
            'ListAutoscalingPolicies' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getPolicies'
                ]
            ],
        ]
    ]
];
