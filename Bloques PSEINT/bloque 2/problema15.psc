Algoritmo Problema_15
	
	
	Definir seg, min, hora Como Entero;
	Escribir "Ingrese seg: ";
	leer seg;
	
	
	hora <- trunc (seg/3600);
	seg <- seg%3600;
	min <- trunc (seg/60);
	seg <- seg%60;
	Escribir "La cantidad de segundos tiene : ", hora " horas", min " minutos", seg, "segundos";
	
	
FinAlgoritmo
