Algoritmo Problema5
	Definir num1,num2,VA1,VA2,pot1,pot2,RC1,RC2,seno1,seno2,coseno1,coseno2,numMax,numMin,pE1,Pe2,redond1,redond2 Como Real;
	Escribir 'Escribe el primer numero';
	Leer num1;
	Escribir 'Escribe el segundo numero';
	Leer num2;
	VA1 <- abs(num1);
	VA2 <- abs(num2);
	pot1 <- num1^num2;
	pot2 <- num2^num2;
	RC1 <- rc(num1);
	RC2 <- rc(num2);
	seno1 <- sen(num1);
	seno2 <- sen(num2);
	coseno1 <- cos(num1);
	coseno2 <- cos(num2);
	numMax <- num1;
	numMin <- num2;
	pE1 <- trunc(num1);
	Pe2 <- trunc(num2);
	redond1 <- redon(num1);
	redond2 <- redon(num2);
	Escribir 'Numero 1:';
	Escribir 'Numero1. Valor absoluto: ',VA1;
	Escribir 'Numero1. Potencia : ',pot1;
	Escribir 'Numero1. Raiz : ',RC1;
	Escribir 'Numero1. Seno : ',seno1;
	Escribir 'Numero1. Coseno : ',coseno1;
	Escribir 'Numero1. Parte entera : ',numMax;
	Escribir 'Numero1. Redondeo : ',redond1;
	Escribir 'Numero 2:';
	Escribir 'Numero1. Valor absoluto: ',VA2;
	Escribir 'Numero1. Potencia : ',pot2;
	Escribir 'Numero1. Raiz : ',RC2;
	Escribir 'Numero1. Seno : ',seno2;
	Escribir 'Numero1. Coseno : ',coseno2;
	Escribir 'Numero1. Parte entera : ',Pe2;
	Escribir 'Numero1. Redondeo : ',redond2;
FinAlgoritmo

