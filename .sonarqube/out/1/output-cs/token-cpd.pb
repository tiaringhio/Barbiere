Œ

VC:\Users\Mattia\source\repos\Barbiere_WCF\Barbiere_WCF_Client\Admin\Admin_Dashboard.cs
	namespace 	
Barbiere_WCF_Client
 
. 
Admin #
{$ %
public 

partial 
class 
Admin_Dashboard (
:) *
Form+ /
{0 1
public 
Admin_Dashboard 
( 
)  
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
private 
void  
Admin_Dashboard_Load )
() *
object* 0
sender1 7
,7 8
	EventArgs9 B
eC D
)D E
{ 	
} 	
private 
void "
LogOutLink_LinkClicked +
(+ ,
object, 2
sender3 9
,9 :)
LinkLabelLinkClickedEventArgs; X
eY Z
)Z [
{ 	
Barbiere 
logreg 
= 
new !
Barbiere" *
(* +
)+ ,
;, -
this 
. 
Hide 
( 
) 
; 
logreg 
. 

ShowDialog 
( 
) 
;  
} 	
} 
} ≥[
YC:\Users\Mattia\source\repos\Barbiere_WCF\Barbiere_WCF_Client\Cliente\Client_Dashboard.cs
	namespace 	
Barbiere_WCF_Client
 
. 
Cliente %
{& '
public 

partial 
class 
Client_Dashboard )
:* +
Form, 0
{1 2
string 
user 
= 
Barbiere 
. 
	UserTitle (
;( )
public 
void 

hidePanels 
( 
)  
{ 	
	BookPanel 
. 
Visible 
= 
false  %
;% &
MyBookingsPanel 
. 
Visible #
=$ %
false& +
;+ ,
ProfilePanel 
. 
Visible  
=! "
false# (
;( )
} 	
public 
Client_Dashboard 
(  
)  !
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
ServiceReference1 
. 
Service1Client (
client) /
=0 1
new2 5
ServiceReference16 G
.G H
Service1ClientH V
(V W
)W X
;X Y
private 
void 
Dashboard_Load #
(# $
object$ *
sender+ 1
,1 2
	EventArgs3 <
e= >
)> ?
{ 	
UsernameDisplayer 
. 
Text "
=# $
user% )
;) *
} 	
private 
void 
MenuPrenota_Click &
(& '
object' -
sender. 4
,4 5
	EventArgs6 ?
e@ A
)A B
{   	

hidePanels!! 
(!! 
)!! 
;!! 
	BookPanel"" 
."" 
Visible"" 
="" 
true""  $
;""$ %
}## 	
private%% 
void%% 
BookingButton_Click%% (
(%%( )
object%%) /
sender%%0 6
,%%6 7
	EventArgs%%8 A
e%%B C
)%%C D
{&& 	
try'' 
{(( 
client)) 
.)) 

AddBooking)) !
())! "
user))" &
,))& '

DatePicker))( 2
.))2 3
Value))3 8
,))8 9

TimePicker)): D
.))D E
Value))E J
)))J K
;))K L

MessageBox** 
.** 
Show** 
(**  
$str**  %
)**% &
;**& '

MessageBox++ 
.++ 
Show++ #
(++# $
$str++$ 1
+++2 3

DatePicker++4 >
.++> ?
Text++? C
+++D E
$str++F S
+++T U

TimePicker++V `
.++` a
Text++a e
+++f g
$str++h k
)++k l
;++l m
},, 
catch-- 
(-- 
	Exception-- 
exce-- !
)--! "
{.. 

MessageBox// 
.// 
Show// 
(//  
exce//  $
.//$ %
ToString//% -
(//- .
)//. /
)/// 0
;//0 1
}00 
}22 	
private44 
void44 %
MenuMiePrenotazioni_Click44 .
(44. /
object44/ 5
sender446 <
,44< =
	EventArgs44> G
e44H I
)44I J
{55 	

hidePanels77 
(77 
)77 
;77 
MyBookingsPanel88 
.88 
Visible88 #
=88$ %
true88& *
;88* +
try:: 
{;; 
using<< 
(<< 
SqlConnection<< $
sqlCon<<% +
=<<, -
new<<. 1
SqlConnection<<2 ?
(<<? @

Properties<<@ J
.<<J K
Settings<<K S
.<<S T
Default<<T [
.<<[ \
ConnectionString<<\ l
)<<l m
)<<m n
{== 
sqlCon>> 
.>> 
Open>> 
(>>  
)>>  !
;>>! "
using?? 
(?? 

SqlCommand?? %
ViewBookings??& 2
=??3 4
new??5 8

SqlCommand??9 C
(??C D
$str??D R
,??R S
sqlCon??T Z
)??Z [
)??[ \
{@@ 
ViewBookingsAA $
.AA$ %
CommandTypeAA% 0
=AA1 2
CommandTypeAA3 >
.AA> ?
StoredProcedureAA? N
;AAN O
ViewBookingsBB $
.BB$ %

ParametersBB% /
.BB/ 0
AddWithValueBB0 <
(BB< =
$strBB= F
,BBF G
UsernameDisplayerBBH Y
.BBY Z
TextBBZ ^
)BB^ _
;BB_ `
ViewBookingsCC $
.CC$ %
ExecuteNonQueryCC% 4
(CC4 5
)CC5 6
;CC6 7
usingEE 
(EE 
SqlDataAdapterEE -

datadapterEE. 8
=EE9 :
newEE; >
SqlDataAdapterEE? M
(EEM N
ViewBookingsEEN Z
)EEZ [
)EE[ \
{FF 
	DataTableGG %
mieprenotazioniGG& 5
=GG6 7
newGG8 ;
	DataTableGG< E
(GGE F
)GGF G
;GGG H

datadapterHH &
.HH& '
FillHH' +
(HH+ ,
mieprenotazioniHH, ;
)HH; <
;HH< =
MyBookingsTableII +
.II+ ,

DataSourceII, 6
=II7 8
mieprenotazioniII9 H
;IIH I
}JJ 
}KK 
}LL 
}MM 
catchNN 
(NN 
	ExceptionNN 
excNN  
)NN  !
{OO 

MessageBoxPP 
.PP 
ShowPP 
(PP  
excPP  #
.PP# $
ToStringPP$ ,
(PP, -
)PP- .
)PP. /
;PP/ 0
}QQ 
}RR 	
privateTT 
voidTT 
MenuProfilo_ClickTT &
(TT& '
objectTT' -
senderTT. 4
,TT4 5
	EventArgsTT6 ?
eTT@ A
)TTA B
{UU 	

hidePanelsVV 
(VV 
)VV 
;VV 
ProfilePanelWW 
.WW 
VisibleWW  
=WW! "
trueWW# '
;WW' (
}XX 	
private[[ 
void[[  
ChangeButton_Click_1[[ )
([[) *
object[[* 0
sender[[1 7
,[[7 8
	EventArgs[[9 B
e[[C D
)[[D E
{\\ 	
if]] 
(]] 
NewPasswordBox]] 
.]] 
Text]] #
==]]$ &
$str]]' )
&&]]* ,!
NewPasswordBoxConfirm]]- B
.]]B C
Text]]C G
==]]H J
$str]]K M
&&]]N P

NewUserBox]]Q [
.]][ \
Text]]\ `
==]]a c
$str]]d f
&&]]g i
OldPasswordBox]]j x
.]]x y
Text]]y }
==	]]~ Ä
$str
]]Å É
)
]]É Ñ
{^^ 

MessageBox__ 
.__ 
Show__ 
(__  
$str__  I
)__I J
;__J K
NewPasswordBox`` 
.`` 
Focus`` $
(``$ %
)``% &
;``& '
}aa 
elsecc 
ifcc 
(cc 
NewPasswordBoxcc #
.cc# $
Textcc$ (
!=cc) +!
NewPasswordBoxConfirmcc, A
.ccA B
TextccB F
)ccF G
{dd 

MessageBoxee 
.ee 
Showee 
(ee  
$stree  7
)ee7 8
;ee8 9
NewPasswordBoxff 
.ff 
Focusff $
(ff$ %
)ff% &
;ff& '
returngg 
;gg 
}hh 
elsejj 
ifjj 
(jj 
NewPasswordBoxjj #
.jj# $
Textjj$ (
!=jj) +
$strjj, .
&&jj/ 1
NewPasswordBoxjj2 @
.jj@ A
TextjjA E
.jjE F
LengthjjF L
<jjM N
$numjjO P
)jjP Q
{kk 

MessageBoxll 
.ll 
Showll 
(ll  
$strll  W
)llW X
;llX Y
NewPasswordBoxmm 
.mm 
Focusmm $
(mm$ %
)mm% &
;mm& '
returnnn 
;nn 
}oo 
ifqq 
(qq 
OldPasswordBoxqq 
.qq 
Textqq #
!=qq$ &
nullqq' +
&&qq, .
(qq/ 0

NewUserBoxqq0 :
.qq: ;
Textqq; ?
!=qq@ B
nullqqC G
||qqH J
NewPasswordBoxqqK Y
.qqY Z
TextqqZ ^
!=qq_ a
nullqqb f
)qqf g
)qqg h
{rr 
tryss 
{tt 
stringuu 
OldHashedPassworduu ,
=uu- .
EasyEncryptionuu/ =
.uu= >
MD5uu> A
.uuA B
ComputeMD5HashuuB P
(uuP Q
OldPasswordBoxuuQ _
.uu_ `
Textuu` d
)uud e
;uue f
stringvv 
NewHashedPasswordvv ,
=vv- .
$strvv/ 1
;vv1 2
ifww 
(ww 
NewPasswordBoxww &
.ww& '
Textww' +
!=ww, .
$strww/ 1
)ww1 2
{xx 
NewHashedPasswordyy )
=yy* +
EasyEncryptionyy, :
.yy: ;
MD5yy; >
.yy> ?
ComputeMD5Hashyy? M
(yyM N
NewPasswordBoxyyN \
.yy\ ]
Textyy] a
)yya b
;yyb c
}zz 
client{{ 
.{{ 
UserPasswordChange{{ -
({{- .

NewUserBox{{. 8
.{{8 9
Text{{9 =
,{{= >
NewHashedPassword{{? P
,{{P Q
CurrentUserBox{{R `
.{{` a
Text{{a e
,{{e f
OldHashedPassword{{g x
){{x y
;{{y z

MessageBox|| 
.|| 
Show|| #
(||# $
$str||$ +
)||+ ,
;||, -
if}} 
(}} 

NewUserBox}} "
.}}" #
Text}}# '
!=}}( *
$str}}+ -
&&}}. 0
OldPasswordBox}}1 ?
.}}? @
Text}}@ D
!=}}E G
$str}}H J
)}}J K
{~~ 
UsernameDisplayer )
.) *
Text* .
=/ 0

NewUserBox1 ;
.; <
Text< @
;@ A
}
ÄÄ 
}
ÅÅ 
catch
ÇÇ 
(
ÇÇ 
	Exception
ÇÇ  
yu
ÇÇ! #
)
ÇÇ# $
{
ÉÉ 

MessageBox
ÑÑ 
.
ÑÑ 
Show
ÑÑ #
(
ÑÑ# $
yu
ÑÑ$ &
.
ÑÑ& '
ToString
ÑÑ' /
(
ÑÑ/ 0
)
ÑÑ0 1
)
ÑÑ1 2
;
ÑÑ2 3
}
ÖÖ 
}
ÜÜ 
}
áá 	
private
ââ 
void
ââ $
LogOutLink_LinkClicked
ââ +
(
ââ+ ,
object
ââ, 2
sender
ââ3 9
,
ââ9 :+
LinkLabelLinkClickedEventArgs
ââ; X
e
ââY Z
)
ââZ [
{
ää 	
Barbiere
ãã 
logreg
ãã 
=
ãã 
new
ãã !
Barbiere
ãã" *
(
ãã* +
)
ãã+ ,
;
ãã, -
this
åå 
.
åå 
Hide
åå 
(
åå 
)
åå 
;
åå 
logreg
çç 
.
çç 

ShowDialog
çç 
(
çç 
)
çç 
;
çç  
}
éé 	
}
èè 
}êê ©
ZC:\Users\Mattia\source\repos\Barbiere_WCF\Barbiere_WCF_Client\Cliente\Password_Recovery.cs
	namespace 	
Barbiere_WCF_Client
 
. 
Cliente %
{& '
public 

partial 
class 
Password_Recovery *
:+ ,
Form- 1
{2 3
public 
Password_Recovery  
(  !
)! "
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
ServiceReference1 
. 
Service1Client (
client) /
=0 1
new2 5
ServiceReference16 G
.G H
Service1ClientH V
(V W
)W X
;X Y
private 
void (
PasswordRecoveryButton_Click 1
(1 2
object2 8
sender9 ?
,? @
	EventArgsA J
eK L
)L M
{ 	
if 
(  
PasswordRecoveryUser $
.$ %
Text% )
==* ,
$str- /
||0 2
PasswordRecoveryNew3 F
.F G
TextG K
==L N
$strO Q
)Q R
{ 

MessageBox 
. 
Show 
(  
$str  A
)A B
;B C 
PasswordRecoveryUser $
.$ %
Focus% *
(* +
)+ ,
;, -
return 
; 
} 
else   
if   
(   
PasswordRecoveryNew   (
.  ( )
Text  ) -
!=  . 0&
PasswordRecoveryNewConfirm  1 K
.  K L
Text  L P
)  P Q
{!! 

MessageBox"" 
."" 
Show"" 
(""  
$str""  @
)""@ A
;""A B
PasswordRecoveryNew## #
.### $
Focus##$ )
(##) *
)##* +
;##+ ,
return$$ 
;$$ 
}%% 
try&& 
{'' 
string,, 
HashedPassword,, %
=,,& '
EasyEncryption,,( 6
.,,6 7
MD5,,7 :
.,,: ;
ComputeMD5Hash,,; I
(,,I J
PasswordRecoveryNew,,J ]
.,,] ^
Text,,^ b
),,b c
;,,c d
client-- 
.-- 
PasswordRecovery-- '
(--' ( 
PasswordRecoveryUser--( <
.--< =
Text--= A
,--A B
HashedPassword--C Q
)--Q R
;--R S

MessageBox// 
.// 
Show// 
(//  
$str//  S
)//S T
;//T U
Barbiere11 
logreg11 
=11  !
new11" %
Barbiere11& .
(11. /
)11/ 0
;110 1
this22 
.22 
Hide22 
(22 
)22 
;22 
logreg33 
.33 

ShowDialog33 !
(33! "
)33" #
;33# $
}44 
catch55 
(55 
	Exception55 
exc55 !
)55! "
{66 

MessageBox77 
.77 
Show77 
(77  
exc77  #
.77# $
ToString77$ ,
(77, -
)77- .
)77. /
;77/ 0
}88 
}99 	
private;; 
void;; #
BackToLogin_LinkClicked;; ,
(;;, -
object;;- 3
sender;;4 :
,;;: ;)
LinkLabelLinkClickedEventArgs;;< Y
e;;Z [
);;[ \
{<< 	
Barbiere>> 
logreg>> 
=>> 
new>> !
Barbiere>>" *
(>>* +
)>>+ ,
;>>, -
this?? 
.?? 
Hide?? 
(?? 
)?? 
;?? 
logreg@@ 
.@@ 

ShowDialog@@ 
(@@ 
)@@ 
;@@  
}AA 	
}BB 
}CC èY
HC:\Users\Mattia\source\repos\Barbiere_WCF\Barbiere_WCF_Client\Log_Reg.cs
	namespace 	
Barbiere_WCF_Client
 
{ 
public 

partial 
class 
Barbiere !
:" #
Form$ (
{) *
public 
static 
string 
	UserTitle &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
public 
Barbiere 
( 
) 
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
ServiceReference1 
. 
Service1Client (
client) /
=0 1
new2 5
ServiceReference16 G
.G H
Service1ClientH V
(V W
)W X
;X Y
private 
void $
RegistrationButton_Click -
(- .
object. 4
sender5 ;
,; <
	EventArgs= F
eG H
)H I
{ 	
string 
HashedPassword !
=" #
EasyEncryption$ 2
.2 3
MD53 6
.6 7
ComputeMD5Hash7 E
(E F
PasswordBoxSignF U
.U V
TextV Z
)Z [
;[ \
if 
( 
UserBoxSign 
. 
Text  
==! #
$str$ &
||' )
PasswordBoxSign* 9
.9 :
Text: >
==? A
$strB D
)D E

MessageBox   
.   
Show   
(    
$str    A
)  A B
;  B C
else"" 
if"" 
("" 
PasswordBoxSign"" $
.""$ %
Text""% )
!=""* ,"
PasswordBoxSignConfirm""- C
.""C D
Text""D H
)""H I
{## 

MessageBox$$ 
.$$ 
Show$$ 
($$  
$str$$  @
)$$@ A
;$$A B
PasswordBoxSign%% 
.%%  
Focus%%  %
(%%% &
)%%& '
;%%' (
return&& 
;&& 
}'' 
else)) 
if)) 
()) 
PasswordBoxSign)) $
.))$ %
Text))% )
.))) *
Length))* 0
<))1 2
$num))3 4
)))4 5
{** 

MessageBox++ 
.++ 
Show++ 
(++  
$str++  W
)++W X
;++X Y
PasswordBoxSign,, 
.,,  
Focus,,  %
(,,% &
),,& '
;,,' (
return-- 
;-- 
}.. 
try00 
{11 
if33 
(33 
!33 
client33 
.33 
UserChecker33 '
(33' (
UserBoxSign33( 3
.333 4
Text334 8
)338 9
)339 :
{33; <

MessageBox44 
.44 
Show44 #
(44# $
$str44$ =
)44= >
;44> ?
}55 
else77 
{88 
client99 
.99 
Registration99 '
(99' (
NameBox99( /
.99/ 0
Text990 4
,994 5

SurnameBox996 @
.99@ A
Text99A E
,99E F
UserBoxSign99G R
.99R S
Text99S W
,99W X
HashedPassword99Y g
,99g h

AdminCheck99i s
.99s t
Checked99t {
)99{ |
;99| }

MessageBox:: 
.:: 
Show:: #
(::# $
$str::$ O
)::O P
;::P Q
Clear;; 
(;; 
);; 
;;; 
}<< 
}== 
catch>> 
(>> 
	Exception>> 
exce>> !
)>>! "
{?? 

MessageBox@@ 
.@@ 
Show@@ 
(@@  
exce@@  $
.@@$ %
ToString@@% -
(@@- .
)@@. /
)@@/ 0
;@@0 1
}AA 
}CC 	
voidDD 
ClearDD 
(DD 
)DD 
{EE 	
NameBoxFF 
.FF 
TextFF 
=FF 

SurnameBoxFF %
.FF% &
TextFF& *
=FF+ ,
UserBoxSignFF- 8
.FF8 9
TextFF9 =
=FF> ?
PasswordBoxSignFF@ O
.FFO P
TextFFP T
=FFU V"
PasswordBoxSignConfirmFFW m
.FFm n
TextFFn r
=FFs t
$strFFu w
;FFw x
}GG 	
privateII 
voidII 
LoginButton_ClickII &
(II& '
objectII' -
senderII. 4
,II4 5
	EventArgsII6 ?
eII@ A
)IIA B
{JJ 	
stringLL 
HashedPasswordLL !
=LL" #
EasyEncryptionLL$ 2
.LL2 3
MD5LL3 6
.LL6 7
ComputeMD5HashLL7 E
(LLE F
PasswordBoxLogLLF T
.LLT U
TextLLU Y
)LLY Z
;LLZ [
ifNN 
(NN 

UserBoxLogNN 
.NN 
TextNN 
==NN  "
$strNN# %
)NN% &
{OO 

MessageBoxPP 
.PP 
ShowPP 
(PP  
$strPP  D
)PPD E
;PPE F

UserBoxLogQQ 
.QQ 
FocusQQ  
(QQ  !
)QQ! "
;QQ" #
returnRR 
;RR 
}SS 
elseTT 
ifTT 
(TT 
PasswordBoxLogTT #
.TT# $
TextTT$ (
==TT) +
$strTT, .
)TT. /
{UU 

MessageBoxVV 
.VV 
ShowVV 
(VV  
$strVV  A
)VVA B
;VVB C
PasswordBoxLogWW 
.WW 
FocusWW $
(WW$ %
)WW% &
;WW& '
returnXX 
;XX 
}YY 
tryZZ 
{[[ 
using\\ 
(\\ 
SqlConnection\\ $
sqlCon\\% +
=\\, -
new\\. 1
SqlConnection\\2 ?
(\\? @

Properties\\@ J
.\\J K
Settings\\K S
.\\S T
Default\\T [
.\\[ \
ConnectionString\\\ l
)\\l m
)\\m n
{]] 
sqlCon^^ 
.^^ 
Open^^ 
(^^  
)^^  !
;^^! "

SqlCommand__ 
LoginChecker__ +
=__, -
new__. 1

SqlCommand__2 <
(__< =
$str__= K
,__K L
sqlCon__M S
)__S T
;__T U
LoginChecker``  
.``  !
CommandType``! ,
=``- .
CommandType``/ :
.``: ;
StoredProcedure``; J
;``J K
LoginCheckeraa  
.aa  !

Parametersaa! +
.aa+ ,
AddWithValueaa, 8
(aa8 9
$straa9 B
,aaB C

UserBoxLogaaD N
.aaN O
TextaaO S
)aaS T
;aaT U
LoginCheckerbb  
.bb  !

Parametersbb! +
.bb+ ,
AddWithValuebb, 8
(bb8 9
$strbb9 D
,bbD E
HashedPasswordbbF T
)bbT U
;bbU V
LoginCheckercc  
.cc  !
ExecuteNonQuerycc! 0
(cc0 1
)cc1 2
;cc2 3
SqlDataReaderee !
myReaderee" *
=ee+ ,
LoginCheckeree- 9
.ee9 :
ExecuteReaderee: G
(eeG H
CommandBehavioreeH W
.eeW X
CloseConnectioneeX g
)eeg h
;eeh i
ifgg 
(gg 
myReadergg  
.gg  !
Readgg! %
(gg% &
)gg& '
)gg' (
{hh 

MessageBoxii "
.ii" #
Showii# '
(ii' (
$strii( 5
+ii6 7

UserBoxLogii8 B
.iiB C
TextiiC G
)iiG H
;iiH I
trykk 
{ll 
boolmm  
isAdminmm! (
=mm) *
(mm+ ,
boolmm, 0
)mm0 1
myReadermm1 9
[mm9 :
$strmm: A
]mmA B
;mmB C
	UserTitlenn %
=nn& '

UserBoxLognn( 2
.nn2 3
Textnn3 7
;nn7 8
ifpp 
(pp  
!pp  !
isAdminpp! (
)pp( )
{qq 
Admin_Dashboardrr  /
adminrr0 5
=rr6 7
newrr8 ;
Admin_Dashboardrr< K
(rrK L
)rrL M
;rrM N
thisss  $
.ss$ %
Hidess% )
(ss) *
)ss* +
;ss+ ,
admintt  %
.tt% &

ShowDialogtt& 0
(tt0 1
)tt1 2
;tt2 3
	UserTitleuu  )
=uu* +

UserBoxLoguu, 6
.uu6 7
Textuu7 ;
;uu; <
}ww 
elseyy  
{zz 
Client_Dashboard{{  0
cliente{{1 8
={{9 :
new{{; >
Client_Dashboard{{? O
({{O P
){{P Q
;{{Q R
this||  $
.||$ %
Hide||% )
(||) *
)||* +
;||+ ,
cliente}}  '
.}}' (

ShowDialog}}( 2
(}}2 3
)}}3 4
;}}4 5
	UserTitle~~  )
=~~* +

UserBoxLog~~, 6
.~~6 7
Text~~7 ;
;~~; <
} 
}
ÄÄ 
catch
ÅÅ 
(
ÅÅ 
	Exception
ÅÅ (
gne
ÅÅ) ,
)
ÅÅ, -
{
ÇÇ 

MessageBox
ÉÉ &
.
ÉÉ& '
Show
ÉÉ' +
(
ÉÉ+ ,
gne
ÉÉ, /
.
ÉÉ/ 0
ToString
ÉÉ0 8
(
ÉÉ8 9
)
ÉÉ9 :
)
ÉÉ: ;
;
ÉÉ; <
}
ÑÑ 
}
ÜÜ 
else
àà 
{
ââ 

MessageBox
ää "
.
ää" #
Show
ää# '
(
ää' (
$str
ää( F
)
ääF G
;
ääG H

UserBoxLog
ãã "
.
ãã" #
Clear
ãã# (
(
ãã( )
)
ãã) *
;
ãã* +
PasswordBoxLog
åå &
.
åå& '
Clear
åå' ,
(
åå, -
)
åå- .
;
åå. /

UserBoxLog
çç "
.
çç" #
Focus
çç# (
(
çç( )
)
çç) *
;
çç* +
}
éé 
}
èè 
}
êê 
catch
ëë 
(
ëë 
	Exception
ëë 
ex
ëë 
)
ëë  
{
íí 

MessageBox
ìì 
.
ìì 
Show
ìì 
(
ìì  
ex
ìì  "
.
ìì" #
Message
ìì# *
,
ìì* +
$str
ìì, 4
)
ìì4 5
;
ìì5 6
}
îî 
}
ïï 	
private
óó 
void
óó .
 PasswordRecoveryLink_LinkClicked
óó 5
(
óó5 6
object
óó6 <
sender
óó= C
,
óóC D+
LinkLabelLinkClickedEventArgs
óóE b
e
óóc d
)
óód e
{
òò 	
this
ôô 
.
ôô 
Hide
ôô 
(
ôô 
)
ôô 
;
ôô 
Password_Recovery
öö 
recovery
öö &
=
öö' (
new
öö) ,
Password_Recovery
öö- >
(
öö> ?
)
öö? @
;
öö@ A
recovery
õõ 
.
õõ 

ShowDialog
õõ 
(
õõ  
)
õõ  !
;
õõ! "
}
úú 	
}
ùù 
}ûû ÷
HC:\Users\Mattia\source\repos\Barbiere_WCF\Barbiere_WCF_Client\Program.cs
	namespace 	
Barbiere_WCF_Client
 
{ 
static 

class 
Program 
{ 
[ 	
	STAThread	 
] 
static 
void 
Main 
( 
) 
{ 	
Application 
. 
EnableVisualStyles *
(* +
)+ ,
;, -
Application 
. -
!SetCompatibleTextRenderingDefault 9
(9 :
false: ?
)? @
;@ A
Application 
. 
Run 
( 
new 
Barbiere  (
(( )
)) *
)* +
;+ ,
} 	
} 
} É
XC:\Users\Mattia\source\repos\Barbiere_WCF\Barbiere_WCF_Client\Properties\AssemblyInfo.cs
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