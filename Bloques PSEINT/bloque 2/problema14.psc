Algoritmo Problema_14
	
	
	Definir num, mill, cent, dec, uni, res Como Entero;
	
	
	Escribir "Ingrese un num de 4 dígitos: ";
	leer num;
	
	
	mill <- trunc(num/1000);
	num <- num%1000;
	cent <- trunc(num/100);
	num <- num%100;
	dec <- trunc(num/10);
	num <- num%10;
	uni <- trunc(num/1);
	num <- num%1;
	Escribir "millares: ", mill " centenas: ", cent, " decenas: ", dec, " unidades: ", uni; 
	
FinAlgoritmo
