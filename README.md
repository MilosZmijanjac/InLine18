# InLine18
Programming languege written in C# based on the following BNF notation.
<validan_red> ::= <tekst> | <deklaracija> | <ukljucivanje>
<tekst> ::= <string> | <string><rezervisani_simbol> |
<string><razmak><otvoren_tag><tekst><zatvoren_tag><string>
<otvoren_tag> ::= “<all_caps>”
<zatvoren_tag> ::= “</all_caps>”
<rezervisani_simbol> ::= “=”<promjenljiva> | “@{“<razmak><izraz><razmak>”}”
<ukljucivanje> ::= “include”<razmak><putanja>
<putanja> ::= “naziv_druge_datoteke”
<deklaracija> ::= <promjenljiva><razmak>”=”<razmak><izraz><razmak>
<izraz> ::= <izraz_num> | <izraz_str>
<izraz_num> ::= <promjenljiva>|<oznaceni_literal>|”(“<razmak><izraz_num><razmak>”)”|
<izraz_num><razmak><operator_num><razmak><izraz_num>
<izraz_str> ::= <promjenljiva>|<literal_str> |
<izraz_str><razmak><operator_str><razmak><izraz_str> |
<izraz_str><razmak><operator_str><razmak><izraz_num> |
<izraz_num><razmak><operator_str><razmak><izraz_str>
<oznaceni_literal> ::= <literal_num> | <znak><literal_num>
<znak> ::= “+” | “-”
<literal_num> ::= <cifra> | <cifra><literal_num>
<literal_str> ::= ”””<string>”””
<string> ::= <slovo> | <spec_karakter> | <cifra> | <slovo><razmak><string> |
<spec_karakter><razmak><string> | <cifra><razmak><string>
<operator_num> ::= ”+”|”*”|”/”|”-”|”%”
<operator_str> ::= ”+”
<promjenljiva> ::= ”[“<naziv_promjenljive>”]”
<naziv_promjenljive> ::= <slovo>|<slovo><ostatak_naziva>
<ostatak_naziva> ::= <cifra> | <slovo> | <spec_karakter> | <cifra><ostatak_naziva> |
<slovo><ostatak_naziva> | <spec_karakter><ostatak_naziva>
<slovo> ::=
”a”|”b”|”c”|”d”|”e”|”f”|”g”|”h”|”i”|”j”|”k”|”l”|”m”|”n”|”o”|”p”|”q”|”r”|”s”|”t”|”u”|”v”|”
w”|”x”|”y”|”z”|”A”|”B”|”C”|”D”|”E”|”F”|”G”|”H”|”I”|”J”|”K”|”L”|”M”|”N”|”O”|”P”|”Q”|”R”|”S
”|”T”|”U”|”V”|”W”|”X”|”Y”|”Z”
<cifra> ::= ”0”|”1”|”2”|”3”|”4”|”5”|”6”|”7”|”8”|”9”
<spec_karakter> ::= ”_”|”.”|”$”|”#”
<razmak> ::= <razmak><tab>|<tab>razmak|” “|””
