ï|
MC:\Users\Mattia\source\repos\Barbiere_WCF\Barbiere_WCF_Server\Service1.svc.cs
	namespace 	
Barbiere_WCF_Server
 
{ 
public 

class 
Service1 
: 
	IService1 %
{& '
bool 
	IService1 
. 
UserChecker "
(" #
string# )
Utente* 0
)0 1
{ 	
try 
{ 
using 
( 
SqlConnection $
sqlcon% +
=, -
new. 1
SqlConnection2 ?
(? @

Properties@ J
.J K
SettingsK S
.S T
DefaultT [
.[ \
ConnectionString\ l
)l m
)m n
{ 
sqlcon 
. 
Open 
(  
)  !
;! "

SqlCommand 
UserChecker *
=+ ,
new- 0

SqlCommand1 ;
(; <
$str< o
,o p
sqlconq w
)w x
;x y
UserChecker 
.  

Parameters  *
.* +
AddWithValue+ 7
(7 8
$str8 A
,A B
UtenteC I
)I J
;J K
var 
result 
=  
UserChecker! ,
., -
ExecuteScalar- :
(: ;
); <
;< =
if 
( 
result 
!= !
null" &
)& '
{ 
return 
false $
;$ %
} 
else 
{ 
return   
true   #
;  # $
}!! 
}"" 
}## 
catch$$ 
($$ 
	Exception$$ 
exce$$ !
)$$! "
{%% 
Console&& 
.&& 
	WriteLine&& !
(&&! "
exce&&" &
.&&& '
ToString&&' /
(&&/ 0
)&&0 1
)&&1 2
;&&2 3
}'' 
throw(( 
new(( #
NotImplementedException(( -
(((- .
)((. /
;((/ 0
})) 	
public++ 
string++ 
Registration++ "
(++" #
string++# )
Nome++* .
,++. /
string++0 6
Cognome++7 >
,++> ?
string++@ F
Utente++G M
,++M N
string++O U
Password++V ^
,++^ _
bool++` d
Admin++e j
)++j k
{,, 	
try-- 
{.. 
using// 
(// 
SqlConnection// $
sqlCon//% +
=//, -
new//. 1
SqlConnection//2 ?
(//? @

Properties//@ J
.//J K
Settings//K S
.//S T
Default//T [
.//[ \
ConnectionString//\ l
)//l m
)//m n
{00 
sqlCon11 
.11 
Open11 
(11  
)11  !
;11! "

SqlCommand22 
UserAdd22 &
=22' (
new22) ,

SqlCommand22- 7
(227 8
$str228 A
,22A B
sqlCon22C I
)22I J
;22J K
UserAdd33 
.33 
CommandType33 '
=33( )
CommandType33* 5
.335 6
StoredProcedure336 E
;33E F
UserAdd44 
.44 

Parameters44 &
.44& '
AddWithValue44' 3
(443 4
$str444 ;
,44; <
Nome44= A
)44A B
;44B C
UserAdd55 
.55 

Parameters55 &
.55& '
AddWithValue55' 3
(553 4
$str554 >
,55> ?
Cognome55@ G
)55G H
;55H I
UserAdd66 
.66 

Parameters66 &
.66& '
AddWithValue66' 3
(663 4
$str664 =
,66= >
Utente66? E
)66E F
;66F G
UserAdd77 
.77 

Parameters77 &
.77& '
AddWithValue77' 3
(773 4
$str774 ?
,77? @
Password77A I
)77I J
;77J K
UserAdd88 
.88 

Parameters88 &
.88& '
AddWithValue88' 3
(883 4
$str884 <
,88< =
Admin88> C
)88C D
;88D E
UserAdd99 
.99 
ExecuteNonQuery99 +
(99+ ,
)99, -
;99- .
}:: 
return;; 
$str;; !
;;;! "
}<< 
catch== 
(== 
	Exception== 
ex== 
)==  
{>> 
Console?? 
.?? 
	WriteLine?? !
(??! "
ex??" $
.??$ %
ToString??% -
(??- .
)??. /
)??/ 0
;??0 1
return@@ 
$str@@ 
;@@  
}AA 
throwBB 
newBB #
NotImplementedExceptionBB -
(BB- .
)BB. /
;BB/ 0
}CC 	
publicFF 
boolFF 
isAdminFF 
{FF 
getFF "
;FF" #
setFF$ '
;FF' (
}FF) *
publicGG 
boolGG 
LoginGG 
(GG 
stringGG  
UtenteGG! '
,GG' (
stringGG) /
PasswordGG0 8
,GG8 9
boolGG: >
AdminGG? D
)GGD E
{HH 	
tryII 
{JJ 
usingKK 
(KK 
SqlConnectionKK $
sqlConKK% +
=KK, -
newKK. 1
SqlConnectionKK2 ?
(KK? @

PropertiesKK@ J
.KKJ K
SettingsKKK S
.KKS T
DefaultKKT [
.KK[ \
ConnectionStringKK\ l
)KKl m
)KKm n
{LL 
sqlConMM 
.MM 
OpenMM 
(MM  
)MM  !
;MM! "

SqlCommandNN 
LoginCheckerNN +
=NN, -
newNN. 1

SqlCommandNN2 <
(NN< =
$strNN= K
,NNK L
sqlConNNM S
)NNS T
;NNT U
LoginCheckerOO  
.OO  !
CommandTypeOO! ,
=OO- .
CommandTypeOO/ :
.OO: ;
StoredProcedureOO; J
;OOJ K
LoginCheckerPP  
.PP  !

ParametersPP! +
.PP+ ,
AddWithValuePP, 8
(PP8 9
$strPP9 B
,PPB C
UtentePPD J
)PPJ K
;PPK L
LoginCheckerQQ  
.QQ  !

ParametersQQ! +
.QQ+ ,
AddWithValueQQ, 8
(QQ8 9
$strQQ9 D
,QQD E
PasswordQQF N
)QQN O
;QQO P
LoginCheckerRR  
.RR  !
ExecuteNonQueryRR! 0
(RR0 1
)RR1 2
;RR2 3
SqlDataReaderTT !
myReaderTT" *
=TT+ ,
LoginCheckerTT- 9
.TT9 :
ExecuteReaderTT: G
(TTG H
CommandBehaviorTTH W
.TTW X
CloseConnectionTTX g
)TTg h
;TTh i
ifVV 
(VV 
myReaderVV  
.VV  !
ReadVV! %
(VV% &
)VV& '
)VV' (
{WW 
boolXX 
isAdminXX $
=XX% &
(XX' (
boolXX( ,
)XX, -
myReaderXX- 5
[XX5 6
$strXX6 =
]XX= >
;XX> ?
ifZZ 
(ZZ 
isAdminZZ #
)ZZ# $
{[[ 
return\\ "
true\\# '
;\\' (
}]] 
else^^ 
{__ 
return`` "
false``# (
;``( )
}aa 
}bb 
}dd 
}ee 
catchff 
(ff 
	Exceptionff 
gneff  
)ff  !
{gg 
gnehh 
.hh 
ToStringhh 
(hh 
)hh 
;hh 
}ii 
throwjj 
newjj #
NotImplementedExceptionjj -
(jj- .
)jj. /
;jj/ 0
}kk 	
publicmm 
stringmm 

AddBookingmm  
(mm  !
stringmm! '
Utentemm( .
,mm. /
DateTimemm0 8
Datemm9 =
,mm= >
DateTimemm? G
TimemmH L
)mmL M
{nn 	
tryoo 
{pp 
usingqq 
(qq 
SqlConnectionqq $
sqlConqq% +
=qq, -
newqq. 1
SqlConnectionqq2 ?
(qq? @

Propertiesqq@ J
.qqJ K
SettingsqqK S
.qqS T
DefaultqqT [
.qq[ \
ConnectionStringqq\ l
)qql m
)qqm n
{rr 
sqlConss 
.ss 
Openss 
(ss  
)ss  !
;ss! "

SqlCommandtt 

AddBookingtt )
=tt* +
newtt, /

SqlCommandtt0 :
(tt: ;
$strtt; G
,ttG H
sqlConttI O
)ttO P
;ttP Q

AddBookinguu 
.uu 
CommandTypeuu *
=uu+ ,
CommandTypeuu- 8
.uu8 9
StoredProcedureuu9 H
;uuH I

AddBookingvv 
.vv 

Parametersvv )
.vv) *
AddWithValuevv* 6
(vv6 7
$strvv7 @
,vv@ A
UtentevvB H
)vvH I
;vvI J

AddBookingww 
.ww 

Parametersww )
.ww) *
AddWithValueww* 6
(ww6 7
$strww7 >
,ww> ?
	SqlDbTypeww@ I
.wwI J
DatewwJ N
)wwN O
;wwO P

AddBookingxx 
.xx 

Parametersxx )
[xx) *
$strxx* 1
]xx1 2
.xx2 3
Valuexx3 8
=xx9 :
Datexx; ?
;xx? @

AddBookingyy 
.yy 

Parametersyy )
.yy) *
AddWithValueyy* 6
(yy6 7
$stryy7 =
,yy= >
	SqlDbTypeyy? H
.yyH I
DateTimeyyI Q
)yyQ R
;yyR S

AddBookingzz 
.zz 

Parameterszz )
[zz) *
$strzz* 0
]zz0 1
.zz1 2
Valuezz2 7
=zz8 9
Timezz: >
;zz> ?

AddBooking{{ 
.{{ 
ExecuteNonQuery{{ .
({{. /
){{/ 0
;{{0 1
}|| 
return}} 
$str}} !
;}}! "
}~~ 
catch 
( 
	Exception 
exc  
)  !
{
ÄÄ 
return
ÅÅ 
$str
ÅÅ !
;
ÅÅ! "
}
ÇÇ 
}
ÉÉ 	
public
ÖÖ 
string
ÖÖ 
PasswordRecovery
ÖÖ &
(
ÖÖ& '
string
ÖÖ' -
Utente
ÖÖ. 4
,
ÖÖ4 5
string
ÖÖ6 <
Password
ÖÖ= E
)
ÖÖE F
{
ÜÜ 	
try
áá 
{
àà 
using
éé 
(
éé 
SqlConnection
éé $
sqlCon
éé% +
=
éé, -
new
éé. 1
SqlConnection
éé2 ?
(
éé? @

Properties
éé@ J
.
ééJ K
Settings
ééK S
.
ééS T
Default
ééT [
.
éé[ \
ConnectionString
éé\ l
)
éél m
)
éém n
{
èè 
sqlCon
êê 
.
êê 
Open
êê 
(
êê  
)
êê  !
;
êê! "

SqlCommand
ëë 
PasswordRecovery
ëë /
=
ëë0 1
new
ëë2 5

SqlCommand
ëë6 @
(
ëë@ A
$str
ëëA S
,
ëëS T
sqlCon
ëëU [
)
ëë[ \
;
ëë\ ]
PasswordRecovery
íí $
.
íí$ %
CommandType
íí% 0
=
íí1 2
CommandType
íí3 >
.
íí> ?
StoredProcedure
íí? N
;
ííN O
PasswordRecovery
ìì $
.
ìì$ %

Parameters
ìì% /
.
ìì/ 0
AddWithValue
ìì0 <
(
ìì< =
$str
ìì= F
,
ììF G
Utente
ììH N
)
ììN O
;
ììO P
PasswordRecovery
îî $
.
îî$ %

Parameters
îî% /
.
îî/ 0
AddWithValue
îî0 <
(
îî< =
$str
îî= H
,
îîH I
Password
îîJ R
)
îîR S
;
îîS T
PasswordRecovery
ïï $
.
ïï$ %
ExecuteNonQuery
ïï% 4
(
ïï4 5
)
ïï5 6
;
ïï6 7
}
ññ 
return
óó 
$str
óó !
;
óó! "
}
òò 
catch
ôô 
(
ôô 
	Exception
ôô 
exc
ôô  
)
ôô  !
{
öö 
return
õõ 
$str
õõ !
;
õõ! "
}
úú 
throw
ùù 
new
ùù %
NotImplementedException
ùù -
(
ùù- .
)
ùù. /
;
ùù/ 0
}
ûû 	
public
¢¢ 
string
¢¢  
UserPasswordChange
¢¢ (
(
¢¢( )
string
¢¢) /
Utente
¢¢0 6
,
¢¢6 7
string
¢¢8 >
Password
¢¢? G
,
¢¢G H
string
¢¢I O
	oldUtente
¢¢P Y
,
¢¢Y Z
string
¢¢[ a
oldPassword
¢¢b m
)
¢¢m n
{
££ 	
try
§§ 
{
•• 
using
¶¶ 
(
¶¶ 
SqlConnection
¶¶ $
sqlcon
¶¶% +
=
¶¶, -
new
¶¶. 1
SqlConnection
¶¶2 ?
(
¶¶? @

Properties
¶¶@ J
.
¶¶J K
Settings
¶¶K S
.
¶¶S T
Default
¶¶T [
.
¶¶[ \
ConnectionString
¶¶\ l
)
¶¶l m
)
¶¶m n
{
ßß 
sqlcon
®® 
.
®® 
Open
®® 
(
®®  
)
®®  !
;
®®! "
using
©© 
(
©© 

SqlCommand
©© % 
UserPasswordChange
©©& 8
=
©©9 :
new
©©; >

SqlCommand
©©? I
(
©©I J
$str
©©J ^
,
©©^ _
sqlcon
©©` f
)
©©f g
)
©©g h
{
™™  
UserPasswordChange
´´ *
.
´´* +
CommandType
´´+ 6
=
´´7 8
CommandType
´´9 D
.
´´D E
StoredProcedure
´´E T
;
´´T U 
UserPasswordChange
¨¨ *
.
¨¨* +

Parameters
¨¨+ 5
.
¨¨5 6
AddWithValue
¨¨6 B
(
¨¨B C
$str
¨¨C L
,
¨¨L M
Utente
¨¨N T
)
¨¨T U
;
¨¨U V 
UserPasswordChange
≠≠ *
.
≠≠* +

Parameters
≠≠+ 5
.
≠≠5 6
AddWithValue
≠≠6 B
(
≠≠B C
$str
≠≠C N
,
≠≠N O
Password
≠≠P X
)
≠≠X Y
;
≠≠Y Z 
UserPasswordChange
ÆÆ *
.
ÆÆ* +

Parameters
ÆÆ+ 5
.
ÆÆ5 6
AddWithValue
ÆÆ6 B
(
ÆÆB C
$str
ÆÆC M
,
ÆÆM N
	oldUtente
ÆÆO X
)
ÆÆX Y
;
ÆÆY Z 
UserPasswordChange
ØØ *
.
ØØ* +

Parameters
ØØ+ 5
.
ØØ5 6
AddWithValue
ØØ6 B
(
ØØB C
$str
ØØC Q
,
ØØQ R
oldPassword
ØØS ^
)
ØØ^ _
;
ØØ_ ` 
UserPasswordChange
∞∞ *
.
∞∞* +
ExecuteNonQuery
∞∞+ :
(
∞∞: ;
)
∞∞; <
;
∞∞< =
}
±± 
}
≤≤ 
return
≥≥ 
$str
≥≥ "
;
≥≥" #
}
¥¥ 
catch
µµ 
(
µµ 
	Exception
µµ 
exce
µµ !
)
µµ! "
{
∂∂ 
return
∑∑ 
$str
∑∑ 
;
∑∑  
exce
∏∏ 
.
∏∏ 
ToString
∏∏ 
(
∏∏ 
)
∏∏ 
;
∏∏  
}
ππ 
throw
∫∫ 
new
∫∫ %
NotImplementedException
∫∫ -
(
∫∫- .
)
∫∫. /
;
∫∫/ 0
}
ªª 	
}
ºº 
}ΩΩ “
JC:\Users\Mattia\source\repos\Barbiere_WCF\Barbiere_WCF_Server\IService1.cs
	namespace		 	
Barbiere_WCF_Server		
 
{		 
[ 
ServiceContract 
] 
public 

	interface 
	IService1 
{  
[ 	
OperationContract	 
] 
string 
Registration 
( 
string "
Nome# '
,' (
string) /
Cognome0 7
,7 8
string9 ?
Utente@ F
,F G
stringH N
PasswordO W
,W X
boolY ]
Admin^ c
)c d
;d e
[ 	
OperationContract	 
] 
bool 
UserChecker 
( 
string 
Utente  &
)& '
;' (
[ 	
OperationContract	 
] 
bool 
Login 
( 
string 
Utente  
,  !
string" (
Password) 1
,1 2
bool3 7
Admin8 =
)= >
;> ?
[ 	
OperationContract	 
] 
string 

AddBooking 
( 
string  
Utente! '
,' (
DateTime) 1
Date2 6
,6 7
DateTime8 @
TimeA E
)E F
;F G
[ 	
OperationContract	 
] 
string 
PasswordRecovery 
(  
string  &
Utente' -
,- .
string/ 5
Password6 >
)> ?
;? @
[ 	
OperationContract	 
] 
string 
UserPasswordChange !
(! "
string" (
Utente) /
,/ 0
string1 7
Password8 @
,@ A
stringB H
	oldUtenteI R
,R S
stringT Z
oldPassword[ f
)f g
;g h
} 
} É
XC:\Users\Mattia\source\repos\Barbiere_WCF\Barbiere_WCF_Server\Properties\AssemblyInfo.cs
[ 
assembly 	
:	 

AssemblyTitle 
( 
$str .
). /
]/ 0
[		 
assembly		 	
:			 

AssemblyDescription		 
(		 
$str		 !
)		! "
]		" #
[

 
assembly

 	
:

	 
!
AssemblyConfiguration

  
(

  !
$str

! #
)

# $
]

$ %
[ 
assembly 	
:	 

AssemblyCompany 
( 
$str 
) 
] 
[ 
assembly 	
:	 

AssemblyProduct 
( 
$str 0
)0 1
]1 2
[ 
assembly 	
:	 

AssemblyCopyright 
( 
$str 0
)0 1
]1 2
[ 
assembly 	
:	 

AssemblyTrademark 
( 
$str 
)  
]  !
[ 
assembly 	
:	 

AssemblyCulture 
( 
$str 
) 
] 
[ 
assembly 	
:	 


ComVisible 
( 
false 
) 
] 
[ 
assembly 	
:	 

Guid 
( 
$str 6
)6 7
]7 8
[## 
assembly## 	
:##	 

AssemblyVersion## 
(## 
$str## $
)##$ %
]##% &
[$$ 
assembly$$ 	
:$$	 

AssemblyFileVersion$$ 
($$ 
$str$$ (
)$$( )
]$$) *