﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Day22
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = "on x=-34..11,y=-37..11,z=-1..49\non x=-49..4,y=-38..7,z=-24..28\non x=-47..0,y=-30..20,z=-45..4\non x=-42..4,y=-20..34,z=-35..19\non x=-10..36,y=-48..5,z=-25..26\non x=-33..13,y=-13..31,z=-35..19\non x=-17..37,y=-35..15,z=-36..15\non x=-9..42,y=-13..35,z=-25..27\non x=-30..14,y=-17..32,z=-12..40\non x=-47..-3,y=-9..36,z=-27..26\noff x=22..33,y=4..15,z=-38..-19\non x=-17..27,y=-41..6,z=-46..1\noff x=19..30,y=-41..-30,z=-38..-23\non x=-1..46,y=-26..20,z=-30..24\noff x=-23..-5,y=33..48,z=-10..4\non x=-9..40,y=-27..27,z=-44..8" +
"\noff x=17..35,y=-2..17,z=-47..-36\non x=-10..39,y=-33..18,z=-12..37\noff x=-18..-1,y=26..40,z=15..28\non x=-26..23,y=-48..4,z=-33..12\non x=-7767..8465,y=70235..75043,z=-38186..-16627\non x=-10825..-157,y=-49643..-17077,z=61077..93187\non x=-78491..-65396,y=-22023..4184,z=24567..39917\non x=-69096..-45331,y=-57284..-24629,z=30263..44605\non x=-82945..-58658,y=-24057..8676,z=-59483..-25954\non x=23778..52633,y=52727..68692,z=-56606..-20022\non x=12027..45950,y=-77103..-71231,z=3616..21938\non x=-24115..-20698,y=57503..81343,z=-26718..1172\non x=-74752..-64480,y=-32793..-183,z=20877..51711" +
"\non x=12311..17848,y=42020..68842,z=48851..58123\non x=34878..65619,y=-65608..-44755,z=-18945..1760\non x=38046..50325,y=-76330..-59321,z=-44579..-7411\non x=-27083..-572,y=78641..84225,z=-4516..4273\non x=-67159..-51172,y=45211..75502,z=10331..38112\non x=73121..86106,y=17319..27445,z=12173..36253\non x=-86448..-60647,y=9576..22694,z=-34376..-1905\non x=51685..82061,y=-11976..-2951,z=-38217..-36377\non x=-21489..-11858,y=64405..80034,z=20703..32551\non x=54508..78271,y=-970..10688,z=-51796..-32776\non x=-62472..-41598,y=55079..83815,z=-12854..4221\non x=-62546..-41236,y=-59160..-42120,z=-29326..-10165" +
"\non x=3039..10873,y=-77792..-51183,z=39648..64691\non x=18908..42915,y=-85119..-66953,z=21555..41360\non x=-28304..-602,y=67010..76793,z=24207..41706\non x=-13014..-7561,y=-4862..20372,z=76161..90466\non x=-61371..-36585,y=-35323..-2134,z=-71901..-43476\non x=-60020..-27945,y=46935..74333,z=-52063..-28331\non x=37543..51771,y=39209..73478,z=-47815..-34418\non x=-75977..-49341,y=-35855..-14243,z=-43397..-35095\non x=-49747..-39743,y=23515..46066,z=-78748..-57265\non x=15746..37028,y=-90884..-62698,z=-7085..7329\non x=38086..39224,y=53141..61196,z=-38897..-32937\non x=-22143..2819,y=54500..77129,z=35532..43531" +
"\non x=27477..38919,y=-42201..-11290,z=-69900..-56761\non x=-35934..-2875,y=75729..77631,z=-4249..24749\non x=19824..49125,y=-37151..-29316,z=62470..68427\non x=43584..64069,y=-64224..-49061,z=14483..32637\non x=-87497..-65591,y=14477..31068,z=21325..43162\non x=-17118..-8857,y=-78865..-59966,z=-22027..8527\non x=53618..73102,y=11195..28823,z=29412..50395\non x=-35212..-10250,y=11617..34969,z=-94033..-66158\non x=-22093..4097,y=31794..43954,z=64840..70029\non x=-26558..-13357,y=-82883..-70841,z=-31475..-7987\non x=67626..89460,y=6455..20436,z=145..22189\non x=64917..84909,y=-38333..-16678,z=-42533..-11431" +
"\non x=-81933..-71821,y=-26889..-8552,z=-38934..-21226\non x=-67449..-42833,y=-69110..-45770,z=-45436..-31504\non x=-15115..4185,y=62913..84720,z=15053..23903\non x=23907..45353,y=-72846..-60283,z=-23317..-1868\non x=64343..75415,y=14351..52019,z=14951..34455\non x=11240..41017,y=-25279..-17020,z=67729..81871\non x=-8996..12336,y=37034..58454,z=-82997..-48451\non x=-3270..27905,y=-30126..-19878,z=67193..88272\non x=-34710..-23610,y=-66723..-57570,z=-50136..-37581\non x=-10917..12913,y=33262..46893,z=57043..88234\non x=-67037..-37105,y=-22210..2988,z=-75441..-44791\non x=30838..66044,y=-35285..-5629,z=44963..69204" +
"\non x=39905..70543,y=30249..52221,z=28786..35841\non x=-51915..-28142,y=32528..45281,z=56801..76859\non x=6458..23823,y=51825..77185,z=-70551..-41325\non x=-60518..-31990,y=-84789..-63450,z=-14122..516\non x=33404..38517,y=37688..49922,z=-65799..-48966\non x=-71634..-52166,y=-8962..5620,z=-38708..-18685\non x=-69404..-54364,y=47457..59308,z=6610..12786\non x=-27251..-599,y=64192..74923,z=34407..51267\non x=-69162..-47724,y=-53471..-36038,z=-3517..715\non x=-41252..-20367,y=49699..78813,z=-45598..-28953\non x=-57420..-42386,y=46099..66663,z=28200..50453\non x=-2523..21646,y=14911..38877,z=-77584..-74832" +
"\non x=-27706..-8808,y=-50429..-36991,z=-79330..-46143\non x=-26776..-4293,y=-61371..-53015,z=45653..52604\non x=-82166..-59572,y=-37275..-4524,z=10188..35182\non x=-3837..15847,y=-80620..-61494,z=29692..40627\non x=20621..49700,y=-75932..-45354,z=20952..34498\non x=33761..57796,y=17629..39231,z=-77877..-48856\non x=-7235..13550,y=63761..87931,z=-16801..11182\non x=-71492..-63856,y=-27212..-5261,z=-45581..-23803\non x=31331..50805,y=39635..70998,z=34728..46519\non x=-64168..-35899,y=13118..21395,z=-74199..-37645\non x=36973..63382,y=-25207..-20461,z=-63946..-33316\non x=10582..27193,y=-332..27840,z=65375..90981" +
"\non x=-63720..-26392,y=30681..58184,z=-56311..-42602\non x=50270..65633,y=-40312..-36420,z=7319..43677\non x=24715..42989,y=-69649..-40804,z=23051..59731\non x=-64854..-49827,y=-60637..-29941,z=24369..29936\non x=3548..20412,y=71738..90006,z=-5636..28912\non x=49052..62719,y=34882..58069,z=-34869..-23749\non x=-75660..-59228,y=-53236..-36280,z=-15746..-3511\non x=-25987..-3468,y=-77537..-45211,z=50010..64259\non x=-63544..-57391,y=12180..41011,z=-53997..-34554\non x=40331..48287,y=-30779..-12430,z=61052..66633\non x=-35292..-21416,y=41501..47212,z=49801..71909\non x=40187..49282,y=-21986..2142,z=-68197..-62470" +
"\non x=-16315..1250,y=63879..73643,z=38101..49818\non x=-76889..-73261,y=9935..41687,z=-19237..-1337\non x=13819..33206,y=-5983..24217,z=-83451..-56363\non x=-83726..-63835,y=23676..32711,z=-14408..5670\non x=-89135..-69895,y=32129..47740,z=-15117..-3168\non x=-57546..-49516,y=-64787..-58930,z=-8834..5788\non x=44444..76900,y=5785..22493,z=-50982..-32235\non x=31693..39789,y=-53676..-42677,z=39516..63346\non x=-9416..18362,y=-22206..3520,z=69116..94436\non x=-33856..-25337,y=-65795..-39367,z=43093..72546\non x=50975..60929,y=-69410..-45225,z=-6633..7513\non x=36582..49461,y=-29437..434,z=-78872..-55606" +
"\non x=43144..46769,y=-53895..-29625,z=43982..62606\non x=43712..50675,y=48621..72539,z=9795..37202\non x=-64586..-41013,y=-7237..11266,z=54306..84188\non x=-34017..-28332,y=-86180..-64548,z=15204..47876\non x=-73407..-46624,y=4427..25409,z=33192..58962\non x=-69241..-38165,y=25432..52998,z=-48446..-36465\non x=-71078..-60065,y=6673..22030,z=-53812..-38263\non x=23885..45710,y=19227..42605,z=62234..79168\non x=-47994..-31482,y=-49720..-37004,z=-60366..-56640\non x=34009..37186,y=45563..62534,z=36287..73297\non x=36634..53083,y=-50594..-16032,z=46865..72092\non x=-69970..-49816,y=36604..41716,z=-31691..-24207" +
"\non x=36098..65962,y=-75388..-50351,z=12487..28560\non x=3480..27091,y=17552..25519,z=-74907..-71099\non x=8366..13202,y=11489..16569,z=64937..94918\non x=-10285..-2162,y=-32609..-7091,z=-84844..-71354\non x=23331..47942,y=7373..42266,z=-77928..-50235\non x=2455..16526,y=-5891..8693,z=-84746..-64996\non x=61718..87907,y=-2796..15963,z=10640..38742\non x=-12743..1588,y=-55139..-40101,z=-78393..-51595\non x=-40418..-18531,y=46738..59883,z=-65962..-38897\non x=50009..84289,y=-29635..-3234,z=-52600..-27908\non x=-69133..-35815,y=24566..41950,z=39830..55089\non x=-47234..-39187,y=1546..23673,z=45703..66817" +
"\non x=40232..71981,y=-45799..-38422,z=30909..49315\non x=-67955..-49657,y=-44209..-23021,z=9543..28184\non x=19153..48780,y=-55928..-48379,z=-58378..-44807\non x=-67603..-43173,y=-52174..-44958,z=17520..22665\non x=53991..74216,y=-42819..-16670,z=-6927..16077\non x=-67593..-42620,y=39880..52732,z=-32957..-17962\non x=-28416..1152,y=-16719..10530,z=-80987..-60680\non x=39932..57751,y=47474..67718,z=-6562..3723\non x=-6587..30725,y=-51463..-28223,z=46811..76820\non x=-72754..-45346,y=-51303..-36048,z=7753..45540\non x=17310..48066,y=-55989..-32614,z=53157..68668\non x=-39464..-19233,y=62493..68001,z=-39757..-7025" +
"\non x=-22460..5774,y=-25339..-3695,z=71776..87885\non x=-78010..-60424,y=-30682..-9244,z=-26578..-2955\non x=-45283..-27634,y=-24705..13441,z=-79255..-50710\non x=11179..39102,y=54174..84052,z=21054..50634\non x=4201..28756,y=-80364..-61225,z=-63286..-29212\non x=-41030..-32812,y=-30883..-12748,z=-72855..-66428\non x=-28279..-11595,y=-18362..-10428,z=-84897..-60148\non x=-70513..-56470,y=39215..58141,z=-8203..20332\non x=-11346..7229,y=39154..52869,z=-67456..-55495\non x=-60043..-48619,y=-28151..-12484,z=46472..54351\non x=1347..25118,y=-82126..-71795,z=20313..30557\non x=-49442..-41761,y=53057..68985,z=-1898..11097" +
"\non x=-50389..-31843,y=13309..42788,z=55454..74671\non x=-22631..11425,y=57139..70782,z=-67903..-36359\non x=-8371..14680,y=76982..81183,z=-11026..5508\non x=61974..82360,y=-39890..-11512,z=-35972..-15702\non x=-55522..-49425,y=46444..70057,z=6690..31221\non x=29279..39332,y=49243..71085,z=22666..44070\non x=11092..28408,y=-66183..-48199,z=32847..57490\non x=-55994..-36820,y=-30962..8200,z=-59561..-44417\non x=-68262..-33591,y=-23642..-10931,z=-78266..-57197\non x=55289..83321,y=-20677..-3789,z=25987..49584\non x=-72334..-61950,y=38136..48219,z=-22541..5232\non x=-49580..-23944,y=39376..62541,z=-54706..-38304" +
"\non x=-70743..-59482,y=-4253..16223,z=-62423..-40841\non x=-7876..10436,y=-46539..-12815,z=54959..88893\non x=-92022..-70982,y=-42424..-24129,z=-10116..23370\non x=7749..10552,y=49119..58246,z=44187..62771\non x=44723..61902,y=37036..43020,z=28502..51387\non x=41611..55388,y=-67098..-33437,z=20091..48823\non x=-69891..-60767,y=-47350..-26212,z=9310..14713\non x=66583..93911,y=-24377..3154,z=-18190..9215\non x=-54285..-40673,y=-70513..-59198,z=19647..38954\non x=-50599..-41129,y=44749..71387,z=28051..47784\non x=-78119..-65816,y=30027..58535,z=-7854..-4718\non x=13342..43862,y=-79526..-55390,z=-45253..-15547" +
"\non x=8708..35204,y=23317..34468,z=69672..75087\non x=30496..48423,y=-19490..10271,z=-84394..-70670\non x=-79469..-63591,y=2794..26336,z=-40786..-17857\non x=-87265..-63571,y=16271..34025,z=-5693..11675\non x=23483..38191,y=63653..85191,z=-8490..19230\non x=53072..74807,y=41941..63275,z=-10625..5537\non x=53016..66381,y=-98..14309,z=36832..53464\non x=-49885..-18199,y=26989..51658,z=-68902..-63438\non x=-82594..-64035,y=6881..36898,z=-39153..-32427\non x=50281..72628,y=9327..19115,z=42099..61176\non x=-35013..-15975,y=-25531..-8630,z=61931..91226\non x=5137..18295,y=-77643..-69251,z=9805..14668" +
"\non x=-54097..-42601,y=-70586..-44862,z=24437..30435\non x=32530..58434,y=-1121..17374,z=53908..86911\non x=-11425..1092,y=-86820..-59255,z=19272..36854\non x=-74031..-47631,y=-56041..-42079,z=-34849..-5975\non x=23264..55393,y=-24385..-14341,z=-84810..-52053\non x=58623..84443,y=-44820..-18545,z=-29902..-6333\non x=-10321..24021,y=68936..96057,z=2909..28524\non x=47688..51476,y=57853..67038,z=-31669..2780\non x=38542..57982,y=-9157..18499,z=66278..73154\non x=-29105..-7227,y=-24863..-2067,z=-95380..-63951\non x=-6997..27477,y=61791..76011,z=10758..32484\noff x=60207..70772,y=-3858..6062,z=-64870..-48042" +
"\non x=67954..79836,y=-21374..-10560,z=-52419..-35545\non x=-6525..13141,y=-41207..-23456,z=-85950..-64683\noff x=-34053..-10576,y=45471..58402,z=47638..80530\noff x=19936..38768,y=67206..91922,z=-32893..-6903\non x=-6214..16999,y=-40057..-38153,z=64825..81603\noff x=-19878..-10427,y=-27314..-5605,z=70687..82915\noff x=61845..84369,y=24698..51745,z=-17642..1597\non x=-52250..-16561,y=-79526..-68440,z=14952..27829\non x=-72713..-49221,y=-44021..-23982,z=-36288..-17529\non x=39974..62347,y=-69558..-59198,z=-2103..3556\non x=-77388..-64730,y=-1924..14369,z=32096..55287\noff x=-76126..-56591,y=23341..26901,z=-5826..21015" +
"\non x=-67948..-48384,y=1641..16137,z=-74305..-40993\noff x=-19782..5263,y=64946..90702,z=-38785..-31109\non x=-27856..8334,y=4699..24064,z=56893..79348\non x=-76861..-61594,y=-28973..-9806,z=14102..43403\noff x=-10383..1204,y=79066..95101,z=-355..10820\non x=61525..89705,y=8152..24045,z=-34949..-18659\noff x=-71297..-65945,y=10014..23398,z=-50126..-31237\non x=12762..41670,y=53685..91939,z=-2493..18813\noff x=21213..30291,y=37196..58234,z=46629..64069\non x=10857..24730,y=-69859..-53004,z=-56739..-20976\noff x=-36732..-9710,y=-29706..-14078,z=-74817..-59368\non x=-63048..-45167,y=-54488..-47007,z=-60695..-26721" +
"\non x=-62289..-46875,y=26153..49805,z=-52356..-31082\non x=36770..56877,y=31395..66182,z=-64463..-33318\noff x=-88860..-60579,y=-23813..-5514,z=-39660..-7729\noff x=63291..93910,y=10885..31112,z=9425..28393\non x=-60809..-47189,y=-70401..-54609,z=-25876..-2158\non x=-94540..-68353,y=-10..27299,z=328..15612\non x=-49451..-39326,y=8258..23698,z=45902..82299\noff x=-31091..756,y=-5823..5426,z=62625..88378\non x=5845..30814,y=61840..77086,z=30945..53582\noff x=-78682..-54766,y=9889..27888,z=20941..45981\noff x=26194..42917,y=-58216..-39721,z=25007..61058\non x=21763..56338,y=8737..33216,z=-70432..-56137" +
"\noff x=59986..93339,y=-28557..-15415,z=-5233..11534\noff x=-87683..-54350,y=-16612..2297,z=-49393..-18659\noff x=-60692..-32499,y=49545..60067,z=26753..42264\non x=56380..70957,y=23901..54728,z=36375..50043\noff x=38009..74577,y=-57954..-48151,z=-14895..-11951\noff x=-79738..-70510,y=5910..19491,z=-15237..5145\noff x=-46827..-21081,y=-46230..-20158,z=-79319..-45699\noff x=-63554..-55785,y=-52364..-32900,z=-16876..-5239\noff x=45347..58244,y=28830..35820,z=38306..66942\noff x=-47587..-21084,y=57494..68452,z=21026..52003\non x=-56874..-33407,y=-29429..-9928,z=54871..71498\non x=51254..78091,y=39309..61364,z=20061..42565" +
"\noff x=-36466..-20174,y=-59961..-51155,z=33854..70992\noff x=3263..35985,y=-79265..-77531,z=-20433..3258\non x=-27091..-14940,y=-55722..-42281,z=40777..80184\non x=20439..41039,y=-22873..5532,z=-73121..-60355\noff x=32620..41069,y=24835..39737,z=-76125..-46671\noff x=-33131..2887,y=-16184..3748,z=-89695..-66464\non x=59426..75030,y=25169..31712,z=21145..34620\non x=18087..42525,y=48788..61157,z=34691..58778\noff x=-72381..-57707,y=-59843..-35634,z=-43185..-17390\noff x=2976..26568,y=-48972..-27104,z=61885..85496\noff x=10684..28945,y=49452..60028,z=-58169..-44154\non x=61615..82464,y=15193..44533,z=-24915..5235" +
"\noff x=-76354..-43775,y=39414..52719,z=-37441..-23866\noff x=-78385..-61092,y=-56337..-41616,z=-23258..-8443\noff x=48401..69430,y=-58394..-52203,z=2289..33917\non x=-92022..-66755,y=-6400..17470,z=23678..33531\non x=-81545..-68555,y=-7455..8278,z=-34541..-19376\noff x=16424..29163,y=-55292..-48820,z=41821..59197\non x=-7715..6007,y=60161..64880,z=47381..67475\noff x=74346..87929,y=-719..12458,z=-10722..9100\non x=36096..42796,y=-385..26447,z=-77539..-52795\non x=-49856..-17540,y=-72898..-63708,z=15050..41816\non x=-56355..-34800,y=-60202..-44642,z=-36805..-31457\non x=-68489..-47402,y=41390..67701,z=-41862..-7921" +
"\noff x=-17948..11318,y=-66472..-45762,z=-64892..-57599\non x=10572..37583,y=-37887..-8474,z=-69955..-63338\noff x=-96236..-65731,y=10410..29561,z=-14771..14159\non x=-86498..-47637,y=34181..37661,z=-41545..-12329\noff x=-75535..-66238,y=-30951..-5282,z=-46476..-27343\non x=-55148..-25191,y=59181..85871,z=-9782..16797\non x=-64990..-48307,y=-32624..-7934,z=-48546..-36839\non x=63138..80168,y=-7903..23895,z=-60804..-39167\non x=-64588..-56268,y=-42294..-21697,z=-60472..-40608\noff x=32749..52578,y=-34277..-16866,z=48846..69340\non x=-74631..-67621,y=-55302..-26055,z=-347..17618\noff x=15732..31912,y=-25375..515,z=59019..75891" +
"\noff x=46836..75282,y=35328..53016,z=26333..43664\noff x=-29466..4095,y=53484..67803,z=26791..56554\noff x=-33474..-4657,y=13661..24690,z=64518..84821\non x=-29484..7250,y=-55118..-38071,z=65890..78702\noff x=-49946..-24814,y=14972..44435,z=46565..67085\noff x=38830..68766,y=-32975..-22958,z=-59904..-33456\non x=8836..23146,y=-49841..-22183,z=-86051..-53643\non x=20478..36778,y=14563..38502,z=-76642..-70717\noff x=-62832..-49267,y=-59351..-48438,z=-36418..-21472\non x=-14596..-6332,y=-87997..-65934,z=-40230..-29024\noff x=-32875..56,y=-83259..-69446,z=9909..15485\noff x=-47296..-10695,y=42472..54099,z=44680..74972" +
"\noff x=-32015..-25918,y=57330..86009,z=9231..24381\non x=-92005..-65137,y=1111..25045,z=12394..24295\noff x=-46754..-29442,y=-45701..-36979,z=-71799..-51846\noff x=-26560..-10019,y=-55150..-26105,z=-77747..-53603\non x=-47187..-7813,y=-39573..-26101,z=-78537..-49086\noff x=-40293..-26328,y=-80544..-61579,z=7090..22715\non x=16296..28866,y=33754..69627,z=-65186..-44385\noff x=40090..70775,y=-47957..-34576,z=-56866..-33346\noff x=-23815..-12735,y=-22962..9222,z=76473..85790\noff x=-34613..-11422,y=40383..64894,z=-60311..-48702\noff x=-45722..-29675,y=-48051..-33369,z=-73768..-44779\noff x=-23366..4834,y=26003..59152,z=55244..73418" +
"\non x=214..28848,y=-84452..-62422,z=21223..56408\non x=52468..72363,y=-8603..9438,z=35911..72069\noff x=-8281..17663,y=-57767..-31151,z=-71957..-45416\noff x=24182..48932,y=-8472..23893,z=57719..77595\non x=60930..76770,y=-18794..2735,z=24412..39702\noff x=-49128..-19872,y=-2607..14981,z=54444..81616\noff x=35157..64048,y=-19732..1505,z=-81311..-59935\non x=34344..61718,y=-56242..-48630,z=20338..41819\noff x=20129..43326,y=-20383..488,z=67528..93528\non x=-6646..31268,y=-12194..-4850,z=-87483..-61752\noff x=31166..46790,y=-7966..20261,z=66736..92699\non x=-86066..-63997,y=-6063..8223,z=-39641..-26460" +
"\non x=34424..44432,y=61411..89553,z=-3432..9388\noff x=57868..75662,y=-33745..-15889,z=15753..36103\non x=16583..31266,y=75719..84591,z=8772..15176\noff x=-68011..-62685,y=16132..34438,z=30726..56409\noff x=18600..30643,y=53465..67517,z=33760..49622\noff x=-30907..-1822,y=60058..74013,z=-58516..-27597\non x=-34154..-5635,y=-24345..11649,z=71769..88510\noff x=29411..55649,y=-70059..-47919,z=-8530..13838\non x=-55036..-39458,y=57289..70310,z=-2961..20669\noff x=59951..64179,y=-43583..-20144,z=-34624..-31823\non x=-19941..-2932,y=36527..56357,z=51646..71595\noff x=-20826..-1270,y=-6101..10206,z=-79898..-60186" +
"\non x=12039..36702,y=-78626..-56073,z=26467..40527\noff x=39221..67420,y=-75200..-57145,z=-20868..6182\non x=-28238..-1572,y=-81490..-57341,z=-25569..-19056\non x=-38419..-17588,y=-73213..-58902,z=-43187..-24538\noff x=26656..57945,y=-34330..-6030,z=-73041..-59424\non x=54248..86350,y=-6160..29894,z=-34519..-24681\noff x=-81341..-47718,y=41904..51667,z=-19772..-9323\noff x=52866..76837,y=-43382..-14133,z=8930..26934\noff x=40213..51046,y=-54917..-39006,z=46674..64533\noff x=20388..34803,y=-23714..-11305,z=69931..89103\non x=37853..74769,y=-48683..-33518,z=19376..49424\non x=57672..91310,y=-9764..18655,z=-38899..-7057" +
"\noff x=14971..23994,y=-38021..-20102,z=-72096..-68016\noff x=-97500..-59589,y=-34086..-4384,z=-12155..-19\non x=71355..85569,y=-11406..-3628,z=-48749..-28058\noff x=-25434..-22190,y=24805..45598,z=68558..74239\noff x=-34170..-5688,y=-90046..-57103,z=-44191..-13631\non x=-43348..-9480,y=61574..81346,z=-25300..-12582\non x=-79082..-60719,y=-38949..-25733,z=-26319..-1266\noff x=-28869..-11474,y=28345..58166,z=-65968..-46601\noff x=14308..42299,y=48005..71471,z=23568..49865\non x=-69572..-52743,y=37747..44104,z=11579..21304\non x=53415..78311,y=23321..34099,z=10231..27613\noff x=-88236..-63055,y=-5227..12636,z=-30879..-2621" +
"\noff x=-54605..-42730,y=42301..67319,z=-4782..32237\non x=35747..67488,y=39494..48171,z=-54016..-40763\noff x=-70756..-57462,y=-50273..-28559,z=25208..52945\non x=-41622..-30289,y=71048..73967,z=-23963..-4294\noff x=41497..76660,y=-12021..1651,z=-60264..-40721\non x=49460..77966,y=-47644..-38758,z=23528..33928\non x=25670..48587,y=29101..67728,z=-54606..-34126\noff x=-89733..-67883,y=-2729..10669,z=-29506..1811\non x=-19574..7715,y=-77088..-62988,z=-37860..-27407\noff x=35400..50975,y=-33185..-4724,z=-66336..-48737\noff x=-22907..11539,y=-53987..-27504,z=-75205..-64428\non x=-67508..-44735,y=15179..32254,z=44509..58464" +
"\noff x=-33163..-2830,y=-45868..-43687,z=-67686..-49385\non x=26279..43172,y=-59509..-54127,z=26262..57683\noff x=-38685..-29279,y=41466..66224,z=-44286..-38863\non x=37624..55015,y=-64254..-49848,z=-37732..-18389\noff x=-25507..9118,y=-52385..-36161,z=61556..67175\non x=-24094..-12832,y=-80676..-75864,z=-29096..-5016\non x=11194..38447,y=-20827..3045,z=-88878..-64547\non x=-85098..-58314,y=24100..36264,z=-10627..14440\non x=48893..67082,y=-56370..-50414,z=-42036..-17363\non x=-18717..-2852,y=41017..75687,z=-58699..-51493\noff x=-32320..-18165,y=-17700..18129,z=-83857..-73189\non x=-40155..-26785,y=-21862..-3672,z=-75538..-64912" +
"\noff x=40977..65691,y=-28844..-10394,z=-75117..-39857\noff x=-76971..-49961,y=-54733..-34678,z=-17752..1721\non x=57070..63052,y=-45748..-34389,z=15730..36242\non x=-34782..-13270,y=56548..77452,z=-47043..-35700\non x=4062..23931,y=25044..49442,z=51002..72093\non x=-29099..-25714,y=5884..25198,z=-90509..-61060\non x=46552..58156,y=-60964..-38658,z=-31422..-11459\noff x=-5387..29901,y=-86998..-55243,z=39169..56690\non x=31513..39925,y=56605..85518,z=-13941..8450\non x=21968..25110,y=70210..85555,z=-10835..21979\noff x=41767..74319,y=-64378..-50743,z=-21161..-3603\non x=32973..61054,y=-61465..-47990,z=-50429..-43644" +
"\noff x=18858..31171,y=-85870..-65907,z=15915..40198\non x=-19817..8610,y=-16951..-5835,z=74580..97308\noff x=-10887..12709,y=-9975..3961,z=72570..98762\noff x=-23264..-2425,y=-79456..-51232,z=27142..59450\non x=54848..83006,y=9761..29404,z=-26553..-7533\non x=11682..20953,y=-20843..-2426,z=59391..84208\noff x=51881..73683,y=-56928..-43772,z=-23947..-6984";

            Console.WriteLine("Part 1 Result: " + ActiveCubesInRange(input, 50));
            Console.WriteLine("Part 2 Result: " + ActiveCubesInRange(input, int.MaxValue));
        }

        public static long ActiveCubesInRange(string input, int range)
        {
            Cmd[] Parse(string input)
            {
                var res = new List<Cmd>();
                foreach (var line in input.Split("\n"))
                {
                    var turnOff = line.StartsWith("off");
                    // get all the numbers with a regexp:
                    var m = Regex.Matches(line, "-?[0-9]+").Select(m => int.Parse(m.Value)).ToArray();
                    res.Add(new Cmd(turnOff, new Region(new Segment(m[0], m[1]), new Segment(m[2], m[3]), new Segment(m[4], m[5]))));
                }
                return res.ToArray();
            }

            var cmds = Parse(input);

            // Recursive approach

            // If we can determine the number of active cubes in subregions
            // we can compute the effect of the i-th cmd as well:
            long activeCubesAfterIcmd(int icmd, Region region)
            {

                if (region.IsEmpty || icmd < 0)
                {
                    return 0; // empty is empty
                }
                else
                {
                    var intersection = region.Intersect(cmds[icmd].region);
                    var activeInRegion = activeCubesAfterIcmd(icmd - 1, region);
                    var activeInIntersection = activeCubesAfterIcmd(icmd - 1, intersection);
                    var activeOutsideIntersection = activeInRegion - activeInIntersection;

                    // outside the intersection is unaffected, the rest is either on or off:
                    return cmds[icmd].turnOff ? activeOutsideIntersection : activeOutsideIntersection + intersection.Volume;
                }
            }

            return activeCubesAfterIcmd(
                cmds.Length - 1,
                new Region(
                    new Segment(-range, range),
                    new Segment(-range, range),
                    new Segment(-range, range)));
        }

        record Cmd(bool turnOff, Region region);

        record Segment(int from, int to)
        {
            public bool IsEmpty => from > to;
            public long Length => IsEmpty ? 0 : to - from + 1;

            public Segment Intersect(Segment that) =>
                new Segment(Math.Max(this.from, that.from), Math.Min(this.to, that.to));
        }

        record Region(Segment x, Segment y, Segment z)
        {
            public bool IsEmpty => x.IsEmpty || y.IsEmpty || z.IsEmpty;
            public long Volume => x.Length * y.Length * z.Length;

            public Region Intersect(Region that) =>
                new Region(this.x.Intersect(that.x), this.y.Intersect(that.y), this.z.Intersect(that.z));
        }
    }
}
