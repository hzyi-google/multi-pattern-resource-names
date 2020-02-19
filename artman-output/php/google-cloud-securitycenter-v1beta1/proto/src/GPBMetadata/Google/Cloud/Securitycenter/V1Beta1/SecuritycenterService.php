<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/securitycenter/v1beta1/securitycenter_service.proto

namespace GPBMetadata\Google\Cloud\Securitycenter\V1Beta1;

class SecuritycenterService
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();

        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\Annotations::initOnce();
        \GPBMetadata\Google\Api\Client::initOnce();
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        \GPBMetadata\Google\Api\Resource::initOnce();
        \GPBMetadata\Google\Cloud\Securitycenter\V1Beta1\Asset::initOnce();
        \GPBMetadata\Google\Cloud\Securitycenter\V1Beta1\Finding::initOnce();
        \GPBMetadata\Google\Cloud\Securitycenter\V1Beta1\OrganizationSettings::initOnce();
        \GPBMetadata\Google\Cloud\Securitycenter\V1Beta1\SecurityMarks::initOnce();
        \GPBMetadata\Google\Cloud\Securitycenter\V1Beta1\Source::initOnce();
        \GPBMetadata\Google\Iam\V1\IamPolicy::initOnce();
        \GPBMetadata\Google\Iam\V1\Policy::initOnce();
        \GPBMetadata\Google\Longrunning\Operations::initOnce();
        \GPBMetadata\Google\Protobuf\Duration::initOnce();
        \GPBMetadata\Google\Protobuf\GPBEmpty::initOnce();
        \GPBMetadata\Google\Protobuf\FieldMask::initOnce();
        \GPBMetadata\Google\Protobuf\Struct::initOnce();
        \GPBMetadata\Google\Protobuf\Timestamp::initOnce();
        $pool->internalAddGeneratedFile(hex2bin(
            "0afb440a40676f6f676c652f636c6f75642f736563757269747963656e74" .
            "65722f763162657461312f736563757269747963656e7465725f73657276" .
            "6963652e70726f746f1223676f6f676c652e636c6f75642e736563757269" .
            "747963656e7465722e763162657461311a17676f6f676c652f6170692f63" .
            "6c69656e742e70726f746f1a1f676f6f676c652f6170692f6669656c645f" .
            "6265686176696f722e70726f746f1a19676f6f676c652f6170692f726573" .
            "6f757263652e70726f746f1a2f676f6f676c652f636c6f75642f73656375" .
            "7269747963656e7465722f763162657461312f61737365742e70726f746f" .
            "1a31676f6f676c652f636c6f75642f736563757269747963656e7465722f" .
            "763162657461312f66696e64696e672e70726f746f1a3f676f6f676c652f" .
            "636c6f75642f736563757269747963656e7465722f763162657461312f6f" .
            "7267616e697a6174696f6e5f73657474696e67732e70726f746f1a38676f" .
            "6f676c652f636c6f75642f736563757269747963656e7465722f76316265" .
            "7461312f73656375726974795f6d61726b732e70726f746f1a30676f6f67" .
            "6c652f636c6f75642f736563757269747963656e7465722f763162657461" .
            "312f736f757263652e70726f746f1a1e676f6f676c652f69616d2f76312f" .
            "69616d5f706f6c6963792e70726f746f1a1a676f6f676c652f69616d2f76" .
            "312f706f6c6963792e70726f746f1a23676f6f676c652f6c6f6e6772756e" .
            "6e696e672f6f7065726174696f6e732e70726f746f1a1e676f6f676c652f" .
            "70726f746f6275662f6475726174696f6e2e70726f746f1a1b676f6f676c" .
            "652f70726f746f6275662f656d7074792e70726f746f1a20676f6f676c65" .
            "2f70726f746f6275662f6669656c645f6d61736b2e70726f746f1a1c676f" .
            "6f676c652f70726f746f6275662f7374727563742e70726f746f1a1f676f" .
            "6f676c652f70726f746f6275662f74696d657374616d702e70726f746f22" .
            "b1010a1443726561746546696e64696e6752657175657374123c0a067061" .
            "72656e74180120012809422ce04102fa41260a2473656375726974796365" .
            "6e7465722e676f6f676c65617069732e636f6d2f536f7572636512170a0a" .
            "66696e64696e675f69641802200128094203e0410212420a0766696e6469" .
            "6e6718032001280b322c2e676f6f676c652e636c6f75642e736563757269" .
            "747963656e7465722e763162657461312e46696e64696e674203e0410222" .
            "a1010a13437265617465536f757263655265717565737412480a06706172" .
            "656e741801200128094238e04102fa41320a30636c6f75647265736f7572" .
            "63656d616e616765722e676f6f676c65617069732e636f6d2f4f7267616e" .
            "697a6174696f6e12400a06736f7572636518022001280b322b2e676f6f67" .
            "6c652e636c6f75642e736563757269747963656e7465722e763162657461" .
            "312e536f757263654203e04102226a0a1e4765744f7267616e697a617469" .
            "6f6e53657474696e67735265717565737412480a046e616d651801200128" .
            "09423ae04102fa41340a32736563757269747963656e7465722e676f6f67" .
            "6c65617069732e636f6d2f4f7267616e697a6174696f6e53657474696e67" .
            "73224e0a10476574536f7572636552657175657374123a0a046e616d6518" .
            "0120012809422ce04102fa41260a24736563757269747963656e7465722e" .
            "676f6f676c65617069732e636f6d2f536f757263652290020a1247726f75" .
            "704173736574735265717565737412480a06706172656e74180120012809" .
            "4238e04102fa41320a30636c6f75647265736f757263656d616e61676572" .
            "2e676f6f676c65617069732e636f6d2f4f7267616e697a6174696f6e120e" .
            "0a0666696c74657218022001280912150a0867726f75705f627918032001" .
            "28094203e0410212330a10636f6d706172655f6475726174696f6e180420" .
            "01280b32192e676f6f676c652e70726f746f6275662e4475726174696f6e" .
            "122d0a09726561645f74696d6518052001280b321a2e676f6f676c652e70" .
            "726f746f6275662e54696d657374616d7012120a0a706167655f746f6b65" .
            "6e18072001280912110a09706167655f73697a6518082001280522a9010a" .
            "1347726f7570417373657473526573706f6e7365124a0a1067726f75705f" .
            "62795f726573756c747318012003280b32302e676f6f676c652e636c6f75" .
            "642e736563757269747963656e7465722e763162657461312e47726f7570" .
            "526573756c74122d0a09726561645f74696d6518022001280b321a2e676f" .
            "6f676c652e70726f746f6275662e54696d657374616d7012170a0f6e6578" .
            "745f706167655f746f6b656e18032001280922d1010a1447726f75704669" .
            "6e64696e677352657175657374123c0a06706172656e7418012001280942" .
            "2ce04102fa41260a24736563757269747963656e7465722e676f6f676c65" .
            "617069732e636f6d2f536f75726365120e0a0666696c7465721802200128" .
            "0912150a0867726f75705f62791803200128094203e04102122d0a097265" .
            "61645f74696d6518042001280b321a2e676f6f676c652e70726f746f6275" .
            "662e54696d657374616d7012120a0a706167655f746f6b656e1805200128" .
            "0912110a09706167655f73697a6518062001280522ab010a1547726f7570" .
            "46696e64696e6773526573706f6e7365124a0a1067726f75705f62795f72" .
            "6573756c747318012003280b32302e676f6f676c652e636c6f75642e7365" .
            "63757269747963656e7465722e763162657461312e47726f757052657375" .
            "6c74122d0a09726561645f74696d6518022001280b321a2e676f6f676c65" .
            "2e70726f746f6275662e54696d657374616d7012170a0f6e6578745f7061" .
            "67655f746f6b656e18032001280922bd010a0b47726f7570526573756c74" .
            "12540a0a70726f7065727469657318012003280b32402e676f6f676c652e" .
            "636c6f75642e736563757269747963656e7465722e763162657461312e47" .
            "726f7570526573756c742e50726f70657274696573456e747279120d0a05" .
            "636f756e741802200128031a490a0f50726f70657274696573456e747279" .
            "120b0a036b657918012001280912250a0576616c756518022001280b3216" .
            "2e676f6f676c652e70726f746f6275662e56616c75653a0238012285010a" .
            "124c697374536f75726365735265717565737412480a06706172656e7418" .
            "01200128094238e04102fa41320a30636c6f75647265736f757263656d61" .
            "6e616765722e676f6f676c65617069732e636f6d2f4f7267616e697a6174" .
            "696f6e12120a0a706167655f746f6b656e18022001280912110a09706167" .
            "655f73697a65180720012805226c0a134c697374536f7572636573526573" .
            "706f6e7365123c0a07736f757263657318012003280b322b2e676f6f676c" .
            "652e636c6f75642e736563757269747963656e7465722e76316265746131" .
            "2e536f7572636512170a0f6e6578745f706167655f746f6b656e18022001" .
            "280922bf020a114c6973744173736574735265717565737412480a067061" .
            "72656e741801200128094238e04102fa41320a30636c6f75647265736f75" .
            "7263656d616e616765722e676f6f676c65617069732e636f6d2f4f726761" .
            "6e697a6174696f6e120e0a0666696c74657218022001280912100a086f72" .
            "6465725f6279180320012809122d0a09726561645f74696d651804200128" .
            "0b321a2e676f6f676c652e70726f746f6275662e54696d657374616d7012" .
            "330a10636f6d706172655f6475726174696f6e18052001280b32192e676f" .
            "6f676c652e70726f746f6275662e4475726174696f6e12330a0a6669656c" .
            "645f6d61736b18072001280b321a2e676f6f676c652e70726f746f627566" .
            "2e4669656c644d61736b4203e0410112120a0a706167655f746f6b656e18" .
            "082001280912110a09706167655f73697a6518092001280522d6030a124c" .
            "697374417373657473526573706f6e736512650a136c6973745f61737365" .
            "74735f726573756c747318012003280b32482e676f6f676c652e636c6f75" .
            "642e736563757269747963656e7465722e763162657461312e4c69737441" .
            "7373657473526573706f6e73652e4c697374417373657473526573756c74" .
            "122d0a09726561645f74696d6518022001280b321a2e676f6f676c652e70" .
            "726f746f6275662e54696d657374616d7012170a0f6e6578745f70616765" .
            "5f746f6b656e18032001280912120a0a746f74616c5f73697a6518042001" .
            "28051afc010a104c697374417373657473526573756c7412390a05617373" .
            "657418012001280b322a2e676f6f676c652e636c6f75642e736563757269" .
            "747963656e7465722e763162657461312e4173736574125d0a0573746174" .
            "6518022001280e324e2e676f6f676c652e636c6f75642e73656375726974" .
            "7963656e7465722e763162657461312e4c69737441737365747352657370" .
            "6f6e73652e4c697374417373657473526573756c742e5374617465224e0a" .
            "05537461746512150a1153544154455f554e535045434946494544100012" .
            "0a0a06554e55534544100112090a0541444445441002120b0a0752454d4f" .
            "5645441003120a0a0641435449564510042280020a134c69737446696e64" .
            "696e677352657175657374123c0a06706172656e74180120012809422ce0" .
            "4102fa41260a24736563757269747963656e7465722e676f6f676c656170" .
            "69732e636f6d2f536f75726365120e0a0666696c74657218022001280912" .
            "100a086f726465725f6279180320012809122d0a09726561645f74696d65" .
            "18042001280b321a2e676f6f676c652e70726f746f6275662e54696d6573" .
            "74616d7012330a0a6669656c645f6d61736b18052001280b321a2e676f6f" .
            "676c652e70726f746f6275662e4669656c644d61736b4203e0410112120a" .
            "0a706167655f746f6b656e18062001280912110a09706167655f73697a65" .
            "18072001280522b2010a144c69737446696e64696e6773526573706f6e73" .
            "65123e0a0866696e64696e677318012003280b322c2e676f6f676c652e63" .
            "6c6f75642e736563757269747963656e7465722e763162657461312e4669" .
            "6e64696e67122d0a09726561645f74696d6518022001280b321a2e676f6f" .
            "676c652e70726f746f6275662e54696d657374616d7012170a0f6e657874" .
            "5f706167655f746f6b656e18032001280912120a0a746f74616c5f73697a" .
            "6518042001280522d2010a1653657446696e64696e675374617465526571" .
            "75657374123b0a046e616d65180120012809422de04102fa41270a257365" .
            "63757269747963656e7465722e676f6f676c65617069732e636f6d2f4669" .
            "6e64696e6712460a05737461746518022001280e32322e676f6f676c652e" .
            "636c6f75642e736563757269747963656e7465722e763162657461312e46" .
            "696e64696e672e53746174654203e0410212330a0a73746172745f74696d" .
            "6518032001280b321a2e676f6f676c652e70726f746f6275662e54696d65" .
            "7374616d704203e0410222640a1852756e4173736574446973636f766572" .
            "795265717565737412480a06706172656e741801200128094238e04102fa" .
            "41320a30636c6f75647265736f757263656d616e616765722e676f6f676c" .
            "65617069732e636f6d2f4f7267616e697a6174696f6e228b010a14557064" .
            "61746546696e64696e675265717565737412420a0766696e64696e671801" .
            "2001280b322c2e676f6f676c652e636c6f75642e73656375726974796365" .
            "6e7465722e763162657461312e46696e64696e674203e04102122f0a0b75" .
            "70646174655f6d61736b18022001280b321a2e676f6f676c652e70726f74" .
            "6f6275662e4669656c644d61736b22b3010a215570646174654f7267616e" .
            "697a6174696f6e53657474696e677352657175657374125d0a156f726761" .
            "6e697a6174696f6e5f73657474696e677318012001280b32392e676f6f67" .
            "6c652e636c6f75642e736563757269747963656e7465722e763162657461" .
            "312e4f7267616e697a6174696f6e53657474696e67734203e04102122f0a" .
            "0b7570646174655f6d61736b18022001280b321a2e676f6f676c652e7072" .
            "6f746f6275662e4669656c644d61736b2288010a13557064617465536f75" .
            "7263655265717565737412400a06736f7572636518012001280b322b2e67" .
            "6f6f676c652e636c6f75642e736563757269747963656e7465722e763162" .
            "657461312e536f757263654203e04102122f0a0b7570646174655f6d6173" .
            "6b18022001280b321a2e676f6f676c652e70726f746f6275662e4669656c" .
            "644d61736b22ce010a1a55706461746553656375726974794d61726b7352" .
            "657175657374124f0a0e73656375726974795f6d61726b7318012001280b" .
            "32322e676f6f676c652e636c6f75642e736563757269747963656e746572" .
            "2e763162657461312e53656375726974794d61726b734203e04102122f0a" .
            "0b7570646174655f6d61736b18022001280b321a2e676f6f676c652e7072" .
            "6f746f6275662e4669656c644d61736b122e0a0a73746172745f74696d65" .
            "18032001280b321a2e676f6f676c652e70726f746f6275662e54696d6573" .
            "74616d7032eb1e0a0e536563757269747943656e74657212c0010a0c4372" .
            "65617465536f7572636512382e676f6f676c652e636c6f75642e73656375" .
            "7269747963656e7465722e763162657461312e437265617465536f757263" .
            "65526571756573741a2b2e676f6f676c652e636c6f75642e736563757269" .
            "747963656e7465722e763162657461312e536f75726365224982d3e49302" .
            "3322292f763162657461312f7b706172656e743d6f7267616e697a617469" .
            "6f6e732f2a7d2f736f75726365733a06736f75726365da410d706172656e" .
            "742c736f7572636512db010a0d43726561746546696e64696e6712392e67" .
            "6f6f676c652e636c6f75642e736563757269747963656e7465722e763162" .
            "657461312e43726561746546696e64696e67526571756573741a2c2e676f" .
            "6f676c652e636c6f75642e736563757269747963656e7465722e76316265" .
            "7461312e46696e64696e67226182d3e493023f22342f763162657461312f" .
            "7b706172656e743d6f7267616e697a6174696f6e732f2a2f736f75726365" .
            "732f2a7d2f66696e64696e67733a0766696e64696e67da4119706172656e" .
            "742c66696e64696e675f69642c66696e64696e67129b010a0c4765744961" .
            "6d506f6c69637912222e676f6f676c652e69616d2e76312e47657449616d" .
            "506f6c696379526571756573741a152e676f6f676c652e69616d2e76312e" .
            "506f6c696379225082d3e493023f223a2f763162657461312f7b7265736f" .
            "757263653d6f7267616e697a6174696f6e732f2a2f736f75726365732f2a" .
            "7d3a67657449616d506f6c6963793a012ada41087265736f7572636512de" .
            "010a174765744f7267616e697a6174696f6e53657474696e677312432e67" .
            "6f6f676c652e636c6f75642e736563757269747963656e7465722e763162" .
            "657461312e4765744f7267616e697a6174696f6e53657474696e67735265" .
            "71756573741a392e676f6f676c652e636c6f75642e736563757269747963" .
            "656e7465722e763162657461312e4f7267616e697a6174696f6e53657474" .
            "696e6773224382d3e493023612342f763162657461312f7b6e616d653d6f" .
            "7267616e697a6174696f6e732f2a2f6f7267616e697a6174696f6e536574" .
            "74696e67737dda41046e616d6512a9010a09476574536f7572636512352e" .
            "676f6f676c652e636c6f75642e736563757269747963656e7465722e7631" .
            "62657461312e476574536f75726365526571756573741a2b2e676f6f676c" .
            "652e636c6f75642e736563757269747963656e7465722e76316265746131" .
            "2e536f75726365223882d3e493022b12292f763162657461312f7b6e616d" .
            "653d6f7267616e697a6174696f6e732f2a2f736f75726365732f2a7dda41" .
            "046e616d6512bb010a0b47726f757041737365747312372e676f6f676c65" .
            "2e636c6f75642e736563757269747963656e7465722e763162657461312e" .
            "47726f7570417373657473526571756573741a382e676f6f676c652e636c" .
            "6f75642e736563757269747963656e7465722e763162657461312e47726f" .
            "7570417373657473526573706f6e7365223982d3e4930233222e2f763162" .
            "657461312f7b706172656e743d6f7267616e697a6174696f6e732f2a7d2f" .
            "6173736574733a67726f75703a012a12df010a0d47726f757046696e6469" .
            "6e677312392e676f6f676c652e636c6f75642e736563757269747963656e" .
            "7465722e763162657461312e47726f757046696e64696e67735265717565" .
            "73741a3a2e676f6f676c652e636c6f75642e736563757269747963656e74" .
            "65722e763162657461312e47726f757046696e64696e6773526573706f6e" .
            "7365225782d3e493023f223a2f763162657461312f7b706172656e743d6f" .
            "7267616e697a6174696f6e732f2a2f736f75726365732f2a7d2f66696e64" .
            "696e67733a67726f75703a012ada410f706172656e742c67726f75705f62" .
            "7912af010a0a4c69737441737365747312362e676f6f676c652e636c6f75" .
            "642e736563757269747963656e7465722e763162657461312e4c69737441" .
            "7373657473526571756573741a372e676f6f676c652e636c6f75642e7365" .
            "63757269747963656e7465722e763162657461312e4c6973744173736574" .
            "73526573706f6e7365223082d3e493022a12282f763162657461312f7b70" .
            "6172656e743d6f7267616e697a6174696f6e732f2a7d2f61737365747312" .
            "c1010a0c4c69737446696e64696e677312382e676f6f676c652e636c6f75" .
            "642e736563757269747963656e7465722e763162657461312e4c69737446" .
            "696e64696e6773526571756573741a392e676f6f676c652e636c6f75642e" .
            "736563757269747963656e7465722e763162657461312e4c69737446696e" .
            "64696e6773526573706f6e7365223c82d3e493023612342f763162657461" .
            "312f7b706172656e743d6f7267616e697a6174696f6e732f2a2f736f7572" .
            "6365732f2a7d2f66696e64696e677312bc010a0b4c697374536f75726365" .
            "7312372e676f6f676c652e636c6f75642e736563757269747963656e7465" .
            "722e763162657461312e4c697374536f7572636573526571756573741a38" .
            "2e676f6f676c652e636c6f75642e736563757269747963656e7465722e76" .
            "3162657461312e4c697374536f7572636573526573706f6e7365223a82d3" .
            "e493022b12292f763162657461312f7b706172656e743d6f7267616e697a" .
            "6174696f6e732f2a7d2f736f7572636573da4106706172656e7412ed010a" .
            "1152756e4173736574446973636f76657279123d2e676f6f676c652e636c" .
            "6f75642e736563757269747963656e7465722e763162657461312e52756e" .
            "4173736574446973636f76657279526571756573741a1d2e676f6f676c65" .
            "2e6c6f6e6772756e6e696e672e4f7065726174696f6e227a82d3e493023a" .
            "22352f763162657461312f7b706172656e743d6f7267616e697a6174696f" .
            "6e732f2a7d2f6173736574733a72756e446973636f766572793a012ada41" .
            "06706172656e74ca412e0a15676f6f676c652e70726f746f6275662e456d" .
            "7074791215676f6f676c652e70726f746f6275662e456d70747912de010a" .
            "0f53657446696e64696e675374617465123b2e676f6f676c652e636c6f75" .
            "642e736563757269747963656e7465722e763162657461312e5365744669" .
            "6e64696e675374617465526571756573741a2c2e676f6f676c652e636c6f" .
            "75642e736563757269747963656e7465722e763162657461312e46696e64" .
            "696e67226082d3e4930242223d2f763162657461312f7b6e616d653d6f72" .
            "67616e697a6174696f6e732f2a2f736f75726365732f2a2f66696e64696e" .
            "67732f2a7d3a73657453746174653a012ada41156e616d652c7374617465" .
            "2c73746172745f74696d6512a2010a0c53657449616d506f6c6963791222" .
            "2e676f6f676c652e69616d2e76312e53657449616d506f6c696379526571" .
            "756573741a152e676f6f676c652e69616d2e76312e506f6c696379225782" .
            "d3e493023f223a2f763162657461312f7b7265736f757263653d6f726761" .
            "6e697a6174696f6e732f2a2f736f75726365732f2a7d3a73657449616d50" .
            "6f6c6963793a012ada410f7265736f757263652c706f6c69637912cd010a" .
            "125465737449616d5065726d697373696f6e7312282e676f6f676c652e69" .
            "616d2e76312e5465737449616d5065726d697373696f6e73526571756573" .
            "741a292e676f6f676c652e69616d2e76312e5465737449616d5065726d69" .
            "7373696f6e73526573706f6e7365226282d3e493024522402f7631626574" .
            "61312f7b7265736f757263653d6f7267616e697a6174696f6e732f2a2f73" .
            "6f75726365732f2a7d3a7465737449616d5065726d697373696f6e733a01" .
            "2ada41147265736f757263652c7065726d697373696f6e7312d1010a0d55" .
            "706461746546696e64696e6712392e676f6f676c652e636c6f75642e7365" .
            "63757269747963656e7465722e763162657461312e55706461746546696e" .
            "64696e67526571756573741a2c2e676f6f676c652e636c6f75642e736563" .
            "757269747963656e7465722e763162657461312e46696e64696e67225782" .
            "d3e4930247323c2f763162657461312f7b66696e64696e672e6e616d653d" .
            "6f7267616e697a6174696f6e732f2a2f736f75726365732f2a2f66696e64" .
            "696e67732f2a7d3a0766696e64696e67da410766696e64696e6712a3020a" .
            "1a5570646174654f7267616e697a6174696f6e53657474696e677312462e" .
            "676f6f676c652e636c6f75642e736563757269747963656e7465722e7631" .
            "62657461312e5570646174654f7267616e697a6174696f6e53657474696e" .
            "6773526571756573741a392e676f6f676c652e636c6f75642e7365637572" .
            "69747963656e7465722e763162657461312e4f7267616e697a6174696f6e" .
            "53657474696e677322810182d3e4930263324a2f763162657461312f7b6f" .
            "7267616e697a6174696f6e5f73657474696e67732e6e616d653d6f726761" .
            "6e697a6174696f6e732f2a2f6f7267616e697a6174696f6e53657474696e" .
            "67737d3a156f7267616e697a6174696f6e5f73657474696e6773da41156f" .
            "7267616e697a6174696f6e5f73657474696e677312c0010a0c5570646174" .
            "65536f7572636512382e676f6f676c652e636c6f75642e73656375726974" .
            "7963656e7465722e763162657461312e557064617465536f757263655265" .
            "71756573741a2b2e676f6f676c652e636c6f75642e736563757269747963" .
            "656e7465722e763162657461312e536f75726365224982d3e493023a3230" .
            "2f763162657461312f7b736f757263652e6e616d653d6f7267616e697a61" .
            "74696f6e732f2a2f736f75726365732f2a7d3a06736f75726365da410673" .
            "6f7572636512e1020a1355706461746553656375726974794d61726b7312" .
            "3f2e676f6f676c652e636c6f75642e736563757269747963656e7465722e" .
            "763162657461312e55706461746553656375726974794d61726b73526571" .
            "756573741a322e676f6f676c652e636c6f75642e73656375726974796365" .
            "6e7465722e763162657461312e53656375726974794d61726b7322d40182" .
            "d3e49302bc0132452f763162657461312f7b73656375726974795f6d6172" .
            "6b732e6e616d653d6f7267616e697a6174696f6e732f2a2f617373657473" .
            "2f2a2f73656375726974794d61726b737d3a0e73656375726974795f6d61" .
            "726b735a6332512f763162657461312f7b73656375726974795f6d61726b" .
            "732e6e616d653d6f7267616e697a6174696f6e732f2a2f736f7572636573" .
            "2f2a2f66696e64696e67732f2a2f73656375726974794d61726b737d3a0e" .
            "73656375726974795f6d61726b73da410e73656375726974795f6d61726b" .
            "731a51ca411d736563757269747963656e7465722e676f6f676c65617069" .
            "732e636f6dd2412e68747470733a2f2f7777772e676f6f676c6561706973" .
            "2e636f6d2f617574682f636c6f75642d706c6174666f726d427e0a27636f" .
            "6d2e676f6f676c652e636c6f75642e736563757269747963656e7465722e" .
            "7631626574613150015a51676f6f676c652e676f6c616e672e6f72672f67" .
            "656e70726f746f2f676f6f676c65617069732f636c6f75642f7365637572" .
            "69747963656e7465722f763162657461313b736563757269747963656e74" .
            "6572620670726f746f33"
        ), true);

        static::$is_initialized = true;
    }
}
