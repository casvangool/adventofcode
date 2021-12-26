﻿using System;
using System.Linq;

namespace codeadvent15b
{
    public static class Input
    {
        public static int[][] grid()
        {
            string[] rows = data.Split("\r\n");
            return rows.Select(s => s.Trim().Select(c => c - '0').ToArray()).ToArray();
        }

        public static string testdata = @"1163751742
1381373672
2136511328
3694931569
7463417111
1319128137
1359912421
3125421639
1293138521
2311944581";

        public static string data => @"1947696975698896797929459993778378493663187915544561834986191836269969899167858897819699793994718987
2311559817927999719999597987189844226139358211239975663924921992997751999137989799783998666847189117
1398783175891937833687888598786896125883638881619291974159998891739786137969443961276399292284679298
1799975998227669996115794797677699798175616958417287499395295199789322764647852198997299659859389619
1739612118291539157254493162397155936981318995862379954635661973979239239969788818966686499766387398
8719671599693942744933141579913498448999942189769767769727796927818765883586697625896957338688939595
2796178218968711997834882837787524726852995959861184787996936352849434128388663893131285789869867179
1317915348335592621751989478997918859522948897849669839469818925318165648989686591857953378291512297
1917441697892979356516974994728598567293861181628838749943997155596868516192997995698976986999929371
5849994149999983668899666755471964957888827868382391818789668871178857186118299899984319718818547999
1858939984861235938958973189492499494194992452675713688286627988991934848921897684964578219133166893
5776439827541299259274198171669552698119771981281496128578196275168739222452299429369829811861496499
2931776597359576234168169379956899871919758688721864948334918341821841299995494661199995762869156991
6289867119753899419197123896818739991327589369298748196458376848925564912321896787819694349929839298
4997387711789873575455786193986389228961185892227229979178939244544847921296114415997191878689531627
8897817989689288875783994178238956724749794811386839271317691993557997889383197977991247644713122658
4813729998926163799795829927989966987647443825496186775588779436794595939819685969483895629779978994
9982381691182111249924694648195956274292964886651799679999461587916412391111914863298296939289519326
5518779882172129996799352736999989891351661978589977619474626595989979213281881181713962999638878749
1169143672568917918812189529673989891989319993181689616698876527476668229991785129399132957998293929
8932884767249667994824929985962599999446812717991922884965499769331385285883628677818991391979189591
9766631975919747512817886897999329888498273594543699991277687617365818493923416969949395683731666999
8689137997791238716357751996996932188896498564645962891656899188187886182198598949352147972939995981
8756667515181197779916113191699889768119499489778999982987198759665998771867182286475992682119989186
1124649829964624878299998991719216999531459818697398785544979997925391161972892999638319187263219291
9857974935269921914969318391941987992868999696658881799996369929596587999955211159959539834844838938
8919518179891539221114534928929998682984285713324169997579726187396989931396888199971975911197624343
4198999483679799381891316193673681916999839397617888964187992886961894398798991629876949216948895886
5192399967381999671189871735251138975778284959494189952999787338796649318699917846183585656874323596
1893214972385815928898851749895568669919679168894679448588489979936994294173766495171795996837279798
9925899897867776945988571695929419298879759819616189897989928981743763471116989379923999917866996988
7898189849949524777471266525684394299191312497519521975217389687694742133287697195338979526643967962
9615449115351624536799387998728899998781678539998641999545933534719891695719449897555887893629515822
9967782543998623985849896599999912897986696167296354329331689299784671929929891989669362197688839989
5967639211387841157996617492973348185229739299894428482889691838688742476486859868197983598966921825
7374376999914646846159231981424471219993689182736894895911492781597795948896794286911974218168959688
1996777211988193895413595213285949489968378779163387495998169499286948679138897132957778196186286879
8581565398788646998527126155638497989663368989725257857989562264976191159879979912849223699948128541
3599998922796929171999367932718549618454129935893613989956288834954647823429868649722282528769635169
7965999579595347289122479263497282984879518915648699638853761299869992425182816839951699576669738439
9497259397977683444889684985994631953896491966492184959179295719881915997916955981999124439848439919
9299184895781751297379927729227697885499115954722224199369169378989721498692828999492272998762926182
8899918997997499371887274979645481998679657997985273876598799769168969117892198614388378987917797485
8888639479899578581818994935127972889989716962616949248999484633993729811567929469229125921919195922
7412341947369985616487775891156912797213858175119775714813182782982441694221615772849179626271163979
9713899969178972587129996911977194578919896659891975573995285858147979997544523995539599519929954373
6977915961998959699139171198789946179721929991498551491999847478148232944999225846274848263749871969
7938429293718924342299994228859372817167111995691968294347997689992799383971648733721911178997296112
4718179195943598268197379998915778236975725765789985337768493125897931769569919116211139648687775539
3187169444859797746988567791165913976863864173975559773797411998489129397742123295741349118153954252
7743878683798777186899638785767783728999499991925419611637897819688137142944978799988422939887928872
9529716867483494769988271913447999618299718513193799548497329269976619887381213997945835119595149998
2119493423877341197391997989889828599881299199687322299193292396969114657449424183489412798998565996
8579268797199219755999277788599798198959989783926929897378971367634898793216982158621495661631646996
6381377477933896299924477362838647438119824946992939998353564984136993615423299987581558191799979519
4284948959891866211159982231989583128991667559619912479935821379597939998881793996672694751391685419
4271997567779892129695961889679529797699955298935611991393116929614329958133458557617126128737171975
8924279138787698771271599787383219399699878481218367439786486976729865875688999719974592891991931129
1968313888382783239491539891982969692611188184727363995581992416578489789999971887191895686866497961
6819682575973959978791722829899225893892198376185283982796625566898698248986788471994875177797286633
9987848869957999874963198739178572141271729926886697898157378897595998111491814996359777978135591911
8295753397299818884346189266465389842998289999978131417948287838948683275626697995786722885399714179
4159299297938377379499928398939358928119118498912227718798934986766315252625281777796575691241789157
1932549925919993995995496562798279994659989319749888713254969999598989919674989394958732958676463995
6516929358966191219219718536486198329523591968994882597281891198716816782728643297736984985991896791
9667699479375153511788876976916698889981985289355894998232798185556258115791517819499535167998448779
9182754699279987498847431286924977916798615881612933679988992599196459295988799917959819289939917357
5995185897223987369289994168735877289928918688486816695794378882617846797889119245831139989861169777
1919558599869961567591499919154298592898477398927649419859979599192511731998289569649669193569113849
4999946839545648998489891966649619198219798999999999914187151712276975396157763411169696498869957861
6289689397891392984985354697412929547898138862874899381561546592941246854928176476491796951999414774
5652838889814579419859281827997499845991343981287281999299378517918618996719949696298312496439778619
8398927129969385788911967691575591249119819485637541256534779912896664397798858922684487117588796791
7861849932949588973793868992958969291986221198819918596158567837435458346119946219376154498731588755
5493124289928195795516937184978949534987929879334213189453569461199679943999281876599997919794497891
9999289438489936768495687178923887113991426158815881798943621849679698865918385748747549198896945196
8329769676578863628791881283699954598381987222212959979488618852587529197619153796962699927717484239
9487296468769179278286959945169598513174655785739971473592952723691273674755969691937916991393346952
9411683765427277541128978945948779185769211693899298899969219797928988898587784915491518858848763988
4174999933693277496789136899128898432995597886796394298149458879355336792996641869734917699868828977
7828853373677139558387437918519944911824751833725979758971928474562189579766917561341888751644883128
9944957631796893189549142471959197819965859979874371592689845268979576141939919872799592796897681978
9129399759399864944997496561649469416722711829816839618967922198998944196191923796976124876598894711
1984651621989673719839789412249992689133656682689896115183298557783399663916359928184233859817826192
6747491896529965195479995582499576938291218158711891822699394479117975866839111928819987139962917979
5862897881242992991697478793791189884133668915997495392975899615191727919733914659972679523966971891
9989177777898175191124159959961821565185996187981771651916828189728186341115886299299282716795193914
8594917468798751791997499796918998296468668394472199718429631939161593978764875719457714959199328597
9971699893896568665199714839127299338839719637246871923899217816181864923749857618999197894993549475
7453732369719421164219599913199692119997885891788498915336679921979737838398149748219899989951721172
7795419181929159189156763936827178722398947294962661194194817349313848552459846299611933617899175511
6452998586858979994398825783449369926689988998317949118939599699399391489738115999949299784992548996
9558149995645639945478899819374918258599745978774328799577491834828698297964697221963783152673619218
1898846289739195946913361269877398668671669969831811232867623929582214121581877169678689911847611953
3389866271533776219379932895441898985239319472749732617688685138778937439175211298981167699614418877
5981952512941958193593448279411963515259361829919999916618896939551988188889799945993187694576962655
3381463186971948918531839533939811191699291588588992929191728587528918737888497916279526579853921937
2947186951912279898383973859526182194614259992831699857959715873216595149977719857546897969994566694
6599943861781981529974889474584753289169598547791967988964158798291811168499239339947159893217981248
9881729689387519626589799227787849951152391998437917592378789299389591999991829988849718719962682192";
    }
}