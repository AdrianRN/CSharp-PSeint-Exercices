Algoritmo Problema_12
	Definir dinero, mil, quinientos, doscientos, cien, cincuenta, veinte como Entero;
	Escribir "Ingresar cantidad de dinero: ";
	leer dinero;
	mil <- trunc(dinero/1000);
	dinero <- dinero%1000;
	quinientos <- trunc(dinero/500);
	dinero <- dinero%500;
	doscientos <- trunc(dinero/200);
	dinero <- dinero%200;
	cien <- trunc(dinero/100);
	dinero <- dinero%100;
	cincuenta <- trunc(dinero/50);
	dinero <- dinero%50;
	veinte <- trunc(dinero/20);
	dinero <- dinero%20;
	Escribir "Cantidad de: ", mil, " en billetes de mil", quinientos, " en billetes de quinientos", doscientos, "en billetes de doscientos", cien, "en billetes de cien", cincuenta, "en billetes de cincuenta", veinte, "en billetes de veinte";
	
	
	

	
FinAlgoritmo
