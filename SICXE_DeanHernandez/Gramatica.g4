grammar Gramatica;

/*
*opciones de compilacion de la gramatica
*/
options {							
    language=CSharp2;	//lenguaje objetivo de la gramatica
}

programa	:    	inicio proposiciones fin;
inicio     	:    	etiqueta START num FINL | proposicion;
fin    		:    	END entrada FINL?;
entrada    	:    	TEXT?;
proposiciones  	: 	(proposicion FINL)*;
proposicion    	: 	instruccion | directiva;
instruccion	:    	etiqueta formato;
directiva	:    	etiqueta tipodirectiva opdirectiva;
tipodirectiva	:    	BYTE | WORD | RESB | RESW | BASE;
etiqueta	:    	TEXT?;
formato    	:    	f1 | f2 | f3 | f4;
f1    		:    	INSTR1;
f2    		:    	INSTR2(num | REG | REG ',' REG | REG ',' num); 
f3    		:    	simple3 | indirecto3 | inmediato3;
f4    		:    	'+'f3;
//Modos de direccionamiento
indexado	:	INDEXADO;
simple3    	:    	INSTR3 (TEXT|num) indexado? | 'RSUB';	
indirecto3	:    	INSTR3 '@'num | INSTR3 '@'TEXT;
inmediato3	:    	INSTR3 '#'num | INSTR3 '#'TEXT;
opdirectiva	:    	num | CONSTHEX | CONSTCAD | TEXT;
num		:	NUMDEC | NUMHEX;

/*
*	Reglas del Lexer.
*/

BASE		:	'BASE';
RESW		:	'RESW';
RESB		:	'RESB';
WORD		:	'WORD';
BYTE		:	'BYTE';
START		:	'START';
END		:	'END';
INDEXADO	:	',X'|', X';

INSTR1:		'FIX'|'FLOAT'|'HIO'|'NORM'|'SIO'|'TIO';

INSTR2:		'ADDR'|'CLEAR'|'COMPR'|'DIVR'|'MULR'|'RMO'|'SHIFTL'|'SHIFTR'|'SUBR'|'SVC'|'TIXR';

INSTR3:		'ADD'|'ADDF'|'AND'|'COMP'|'COMPF'|'DIV'|'DIVF'|'J'|'JEQ'|'JGT'|'JLT'
		|'JSUB'|'LDA'|'LDB'|'LDCH'|'LDF'|'LDL'|'LDS'|'LDT'|'LDX'|'LPS'
		|'MUL'|'MULF'|'OR'|'RD'|'RSUB'|'SSK'|'STA'|'STB'|'STCH'|'STF'|'STI'
		|'STL'|'STS'|'STSW'|'STT'|'STX'|'SUB'|'SUBF'|'TD'|'TIX'|'WD';
		
FINL 		:	('\r\n'|'\n')+;
REG            	: 	'A'|'X'|'L'|'B'|'S'|'T'|'F'|'CP'|'PC'|'SW';
NUMDEC          : 	('0'..'9')+;
NUMHEX_sh	:	(NUMDEC|'A'..'F')+;
NUMHEX          : 	('0'..'9'|'A'..'F')+('H' | 'h');
TEXT		:	('a'..'z'|'A'..'Z')('0'..'9'|'a'..'z'|'A'..'Z')*;	//Representa la parte de ID (una etiqueta) y una cadena
CONSTHEX       	: 	'X\''NUMHEX_sh'\'';
CONSTCAD       	: 	'C\''TEXT'\''; 						//Debe iniciar con letra
compileUnit		:
EOF
;