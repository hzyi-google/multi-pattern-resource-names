<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/devtools/containeranalysis/v1beta1/containeranalysis.proto

namespace GPBMetadata\Google\Devtools\Containeranalysis\V1Beta1;

class Containeranalysis
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();

        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\Annotations::initOnce();
        \GPBMetadata\Google\Iam\V1\IamPolicy::initOnce();
        \GPBMetadata\Google\Iam\V1\Policy::initOnce();
        \GPBMetadata\Google\Protobuf\Timestamp::initOnce();
        $pool->internalAddGeneratedFile(hex2bin(
            "0a89110a41676f6f676c652f646576746f6f6c732f636f6e7461696e6572" .
            "616e616c797369732f763162657461312f636f6e7461696e6572616e616c" .
            "797369732e70726f746f1229676f6f676c652e646576746f6f6c732e636f" .
            "6e7461696e6572616e616c797369732e763162657461311a1e676f6f676c" .
            "652f69616d2f76312f69616d5f706f6c6963792e70726f746f1a1a676f6f" .
            "676c652f69616d2f76312f706f6c6963792e70726f746f1a1f676f6f676c" .
            "652f70726f746f6275662f74696d657374616d702e70726f746f22a2010a" .
            "0a5363616e436f6e666967120c0a046e616d6518012001280912130a0b64" .
            "65736372697074696f6e180220012809120f0a07656e61626c6564180320" .
            "012808122f0a0b6372656174655f74696d6518042001280b321a2e676f6f" .
            "676c652e70726f746f6275662e54696d657374616d70122f0a0b75706461" .
            "74655f74696d6518052001280b321a2e676f6f676c652e70726f746f6275" .
            "662e54696d657374616d7022240a144765745363616e436f6e6669675265" .
            "7175657374120c0a046e616d65180120012809225f0a164c697374536361" .
            "6e436f6e6669677352657175657374120e0a06706172656e741801200128" .
            "09120e0a0666696c74657218022001280912110a09706167655f73697a65" .
            "18032001280512120a0a706167655f746f6b656e180420012809227f0a17" .
            "4c6973745363616e436f6e66696773526573706f6e7365124b0a0c736361" .
            "6e5f636f6e6669677318012003280b32352e676f6f676c652e646576746f" .
            "6f6c732e636f6e7461696e6572616e616c797369732e763162657461312e" .
            "5363616e436f6e66696712170a0f6e6578745f706167655f746f6b656e18" .
            "022001280922730a175570646174655363616e436f6e6669675265717565" .
            "7374120c0a046e616d65180120012809124a0a0b7363616e5f636f6e6669" .
            "6718022001280b32352e676f6f676c652e646576746f6f6c732e636f6e74" .
            "61696e6572616e616c797369732e763162657461312e5363616e436f6e66" .
            "696732840a0a18436f6e7461696e6572416e616c79736973563142657461" .
            "3112c9010a0c53657449616d506f6c69637912222e676f6f676c652e6961" .
            "6d2e76312e53657449616d506f6c696379526571756573741a152e676f6f" .
            "676c652e69616d2e76312e506f6c696379227e82d3e493027822332f7631" .
            "62657461312f7b7265736f757263653d70726f6a656374732f2a2f6e6f74" .
            "65732f2a7d3a73657449616d506f6c6963793a012a5a3e22392f76316265" .
            "7461312f7b7265736f757263653d70726f6a656374732f2a2f6f63637572" .
            "72656e6365732f2a7d3a73657449616d506f6c6963793a012a12c9010a0c" .
            "47657449616d506f6c69637912222e676f6f676c652e69616d2e76312e47" .
            "657449616d506f6c696379526571756573741a152e676f6f676c652e6961" .
            "6d2e76312e506f6c696379227e82d3e493027822332f763162657461312f" .
            "7b7265736f757263653d70726f6a656374732f2a2f6e6f7465732f2a7d3a" .
            "67657449616d506f6c6963793a012a5a3e22392f763162657461312f7b72" .
            "65736f757263653d70726f6a656374732f2a2f6f6363757272656e636573" .
            "2f2a7d3a67657449616d506f6c6963793a012a12f7010a12546573744961" .
            "6d5065726d697373696f6e7312282e676f6f676c652e69616d2e76312e54" .
            "65737449616d5065726d697373696f6e73526571756573741a292e676f6f" .
            "676c652e69616d2e76312e5465737449616d5065726d697373696f6e7352" .
            "6573706f6e7365228b0182d3e49302840122392f763162657461312f7b72" .
            "65736f757263653d70726f6a656374732f2a2f6e6f7465732f2a7d3a7465" .
            "737449616d5065726d697373696f6e733a012a5a44223f2f763162657461" .
            "312f7b7265736f757263653d70726f6a656374732f2a2f6f636375727265" .
            "6e6365732f2a7d3a7465737449616d5065726d697373696f6e733a012a12" .
            "b9010a0d4765745363616e436f6e666967123f2e676f6f676c652e646576" .
            "746f6f6c732e636f6e7461696e6572616e616c797369732e763162657461" .
            "312e4765745363616e436f6e666967526571756573741a352e676f6f676c" .
            "652e646576746f6f6c732e636f6e7461696e6572616e616c797369732e76" .
            "3162657461312e5363616e436f6e666967223082d3e493022a12282f7631" .
            "62657461312f7b6e616d653d70726f6a656374732f2a2f7363616e436f6e" .
            "666967732f2a7d12ca010a0f4c6973745363616e436f6e6669677312412e" .
            "676f6f676c652e646576746f6f6c732e636f6e7461696e6572616e616c79" .
            "7369732e763162657461312e4c6973745363616e436f6e66696773526571" .
            "756573741a422e676f6f676c652e646576746f6f6c732e636f6e7461696e" .
            "6572616e616c797369732e763162657461312e4c6973745363616e436f6e" .
            "66696773526573706f6e7365223082d3e493022a12282f76316265746131" .
            "2f7b706172656e743d70726f6a656374732f2a7d2f7363616e436f6e6669" .
            "677312cc010a105570646174655363616e436f6e66696712422e676f6f67" .
            "6c652e646576746f6f6c732e636f6e7461696e6572616e616c797369732e" .
            "763162657461312e5570646174655363616e436f6e666967526571756573" .
            "741a352e676f6f676c652e646576746f6f6c732e636f6e7461696e657261" .
            "6e616c797369732e763162657461312e5363616e436f6e666967223d82d3" .
            "e49302371a282f763162657461312f7b6e616d653d70726f6a656374732f" .
            "2a2f7363616e436f6e666967732f2a7d3a0b7363616e5f636f6e66696742" .
            "8a010a24636f6d2e676f6f676c652e636f6e7461696e6572616e616c7973" .
            "69732e7631626574613150015a5a676f6f676c652e676f6c616e672e6f72" .
            "672f67656e70726f746f2f676f6f676c65617069732f646576746f6f6c73" .
            "2f636f6e7461696e6572616e616c797369732f763162657461313b636f6e" .
            "7461696e6572616e616c79736973a20203474341620670726f746f33"
        ), true);

        static::$is_initialized = true;
    }
}

