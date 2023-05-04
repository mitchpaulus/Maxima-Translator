grammar Maxima;

EXP : '%e^';
MATRIX : 'matrix' ;

IDENTIFIER : [a-zA-Z_][a-zA-Z0-9_]*;

INTEGER : [0-9]+;

LPAREN : '(' ;
RPAREN : ')' ;

LBRACKET : '[' ;
RBRACKET : ']' ;

COMMA : ',' ;

CARET : '^' ;

PLUS : '+' ;
MINUS : '-' ;
TIMES : '*' ;
DIVIDE : '/' ;

WS : [ \t\r\n]+ -> skip ;

matrix : MATRIX LPAREN matrix_rows RPAREN ;

matrix_rows : list (COMMA list)* ;

list : LBRACKET expression (COMMA expression)* RBRACKET ;

expression
    : expression CARET expression # PowerExp
    | expression op=(MINUS|PLUS|TIMES|DIVIDE|CARET) expression # BinaryExp
    | EXP MINUS? LPAREN expression RPAREN# ExpExp
    | MINUS expression # UnaryExp
    | LPAREN expression RPAREN # ParenExp
    | INTEGER # IntegerExp
    | IDENTIFIER # IdentifierExp
    | matrix # MatrixExp
    | list # ListExp
    ;
