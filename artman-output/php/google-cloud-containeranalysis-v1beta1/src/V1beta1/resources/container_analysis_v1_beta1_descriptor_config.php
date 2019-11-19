<?php

return [
    'interfaces' => [
        'google.devtools.containeranalysis.v1beta1.ContainerAnalysisV1Beta1' => [
            'ListScanConfigs' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getScanConfigs'
                ]
            ],
        ]
    ]
];
