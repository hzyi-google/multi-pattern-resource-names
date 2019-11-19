#/bin/bash

rm -rf artman-output
mkdir -f artman-output

GAPICS=(
	"java_gapic"\
	"csharp_gapic"\
	"nodejs_gapic"\
	"ruby_gapic"\
	"php_gapic"\
	"python_gapic"\
	"go_gapic"
)


APIS=(
	"google/cloud/dataproc/artman_dataproc_v1.yaml" \
	"google/cloud/dataproc/artman_dataproc_v1beta2.yaml" \
	"google/cloud/bigquery/datatransfer/artman_bigquerydatatransfer.yaml" \
	"google/cloud/kms/artman_cloudkms.yaml" \
	"google/cloud/secruitycenter/artman_securitycenter_v1.yaml" \
	"google/cloud/secruitycenter/artman_securitycenter_v1beta1.yaml" \
	"google/cloud/talent/artman_talent_v4beta1.yaml" \
	"google/devtools/containeranalysis/artman_containeranalysis.yaml" \
 	"google/devtools/containeranalysis/artman_containeranalysis_v1.yaml" \
	"google/devtools/containeranalysis/artman_containeranalysis_v1beta1.yaml" \
	"google/logging/artman_logging.yaml" \
	"google/privacy/dlp/artman_dlp_v2.yaml" \
	"google/pubsub/artman_pubsub.yaml" \
)

for gapic in "${GAPICS[@]}"
do
  for config in "${APIS[@]}"
	do
		artman --local --output-dir artman-output \
		  --root_dir `pwd`/googleapis \
		  --config $config
		 	generate $gapic
  done
done