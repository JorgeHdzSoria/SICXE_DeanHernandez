grammar Gramatica;

/*
*opciones de compilacion de la gramatica
*/
options {							
    language=CSharp2;	//lenguaje objetivo de la gramatica
}

//Producciones principales
//programa	:    	inicio | proposicion | fin; // inicio proposiciones fin
programa	:		inicio proposiciones fin;
inicio     	:    	etiqueta START num saltoLinea;
fin    		:    	END etiqueta? saltoLinea?;
proposiciones  	: 	(proposicion saltoLinea)*;
//proposicion    	: 	(instruccion | directiva) saltoLinea+;
proposicion	:		instruccion | directiva;
saltoLinea	:		FINL;
//Manejo de directivas
directiva	:    	etiqueta? tipodirectiva;
tipodirectiva	:   byte | word | resb | resw | base;
byte		:		BYTE const;
word		:		WORD num;
resb		:		RESB num;
resw		:		RESW num;
base		:		BASE etiqueta;
//Manejo de instrucciones
instruccion	:    	etiqueta? formato;
formato    	:    	f1 | f2 | f3 | f4;
f1    		:    	INSTR1;
f2    		:    	INSTR2_r1r2(reg COMA reg) | INSTR2_r1r2(reg (',X'|', X')) |INSTR2_r1(reg) | INSTR2_r1n(reg COMA num) | INSTR2_n(num); 
f3    		:    	simple3 | indirecto3 | inmediato3;
f4    		:    	simple4 | indirecto4 | inmediato4;
//Modos de direccionamiento (instrucciones)
simple3    	:    	INSTR3 (TEXT|num) (',X'|', X')? | 'RSUB';
indirecto3	:    	INSTR3 '@'num | INSTR3 '@'TEXT;
inmediato3	:    	INSTR3 '#'num | INSTR3 '#'TEXT;

simple4    	:    	INSTR4 TEXT (',X'|', X')? | '+RSUB';
indirecto4	:    	INSTR4 '@'TEXT;
inmediato4	:    	INSTR4 '#'TEXT;
//Tipos de entrada
num			:	NUMDEC | NUMHEX;
etiqueta	:   TEXT;
const		:	CONSTHEX | CONSTCAD;
reg			:	REG;

/*
*	Reglas del Lexer.
*/
BASE		:	'BASE';
RESW		:	'RESW';
RESB		:	'RESB';
WORD		:	'WORD';
BYTE		:	'BYTE';
START		:	'START';
END			:	'END';
COMA		:	','|', ';

INSTR1		:	'FIX'|'FLOAT'|'HIO'|'NORM'|'SIO'|'TIO';
INSTR2_r1r2	:	'ADDR'|'COMPR'|'DIVR'|'MULR'|'RMO'|'SUBR';
INSTR2_r1	:	'CLEAR'|'TIXR';
INSTR2_r1n	:	'SHIFTL'|'SHIFTR';
INSTR2_n	:	'SVC';

INSTR3		:	'ADD'|'ADDF'|'AND'|'COMP'|'COMPF'|'DIV'|'DIVF'|'J'|'JEQ'|'JGT'|'JLT'
			|'JSUB'|'LDA'|'LDB'|'LDCH'|'LDF'|'LDL'|'LDS'|'LDT'|'LDX'|'LPS'
			|'MUL'|'MULF'|'OR'|'RD'|'SSK'|'STA'|'STB'|'STCH'|'STF'|'STI'
			|'STL'|'STS'|'STSW'|'STT'|'STX'|'SUB'|'SUBF'|'TD'|'TIX'|'WD'; //Excluimos RSUB por ser caso especial
			
INSTR4		:	'+'('ADD'|'ADDF'|'AND'|'COMP'|'COMPF'|'DIV'|'DIVF'|'J'|'JEQ'|'JGT'|'JLT'
			|'JSUB'|'LDA'|'LDB'|'LDCH'|'LDF'|'LDL'|'LDS'|'LDT'|'LDX'|'LPS'
			|'MUL'|'MULF'|'OR'|'RD'|'SSK'|'STA'|'STB'|'STCH'|'STF'|'STI'
			|'STL'|'STS'|'STSW'|'STT'|'STX'|'SUB'|'SUBF'|'TD'|'TIX'|'WD'); //Excluimos RSUB por ser caso especial
			
FINL 			:	('\r\n')+ | ('\n')+;
REG            	: 	'A'|'X'|'L'|'B'|'S'|'T'|'F'|'CP'|'PC'|'SW';
NUMDEC          : 	('0'..'9')+;
NUMHEX_sh		:	(NUMDEC|'A'..'F')+;
NUMHEX          : 	('0'..'9'|'A'..'F')+('H' | 'h');
TEXT			:	('a'..'z'|'A'..'Z')('0'..'9'|'a'..'z'|'A'..'Z')*;	//Representa la parte de ID (una etiqueta) y una cadena
CONSTHEX       	: 	'X\''NUMHEX_sh'\'';
CONSTCAD       	: 	'C\''TEXT'\''; 						//Debe iniciar con letra