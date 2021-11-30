Algoritmo Problema8
	
	Definir salario, salud, at, st Como real;
	Escribir "Ingrese salario";
	Leer salario;
	salud = salario *0.07;
	at = salario * 0.04;
	st = (salario - salud) - at;
	Escribir "Descuento por salud es " salud;
	Escribir "Descuento por afiliacion es: " at;
	Escribir "Salario restante: " st;
	
	
	
FinAlgoritmo
