Algoritmo Problema2
	Definir cant1, cant2, cant3, cant4, cant5 Como Real;
	Definir tp1, tp2, tp3, tp4, tp5, prec1, prec2, prec3, prec4, prec5 Como Real;
	
	Escribir "Ingresa el precio del producto 1";
	Leer prec1;
	Escribir "Cuantos productos llevo?";
	Leer cant1;
	
	Escribir "Ingresa el precio del producto 2";
	Leer prec2;
	Escribir "Cuantos productos llevo?";
	Leer cant2;
	
	Escribir "Ingresa el precio del producto 3";
	Leer prec3;
	Escribir "Cuantos productos llevo?";
	Leer cant3;
	
	Escribir "Ingresa el precio del producto 4";
	Leer prec4;
	Escribir "Cuantos productos llevo?";
	Leer cant4;
	
	Escribir "Ingresa el precio del producto 5";
	Leer prec5;
	Escribir "Cuantos productos llevo?";
	Leer cant5;
	
	
	//proceso
	tp1 = prec1 * cant1;
	tp2 = prec2 * cant2;
	tp3 = prec3 * cant3;
	tp4 = prec4 * cant4;
	tp5 = prec5 * cant5;
	
	Definir tprod Como Real;
	tprod = cant1 + cant2 + cant3 + cant4 + cant5;
	
	
	Escribir "Usted llevó "  tprod  " Productos de los cuales";
	Escribir "llevó "  cant1  " de $"  prec1  ", en total: "  tp1;
	Escribir "llevó "  cant2  " de $"  prec2 ", en total: "  tp2;
	Escribir "llevó "  cant3  " de $"  prec3  ", en total: "  tp3;
	Escribir "llevó "  cant4  " de $"  prec4  ", en total: "  tp4;
	Escribir "llevó "  cant5  " de $"  prec5  ", en total: "  tp5;
	
	
FinAlgoritmo
