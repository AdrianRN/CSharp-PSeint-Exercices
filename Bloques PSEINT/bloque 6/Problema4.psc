Algoritmo Problema4
	
	
	
	Definir hamb_es, hamb_senc, refresco, papas Como Real;
	Definir total, iva, totalhambes, totalhambsenc, totalrefresco, totalpapas, canthamb_es, canthamb_senc, cantrefresco, cantpapas, total_pagar Como Real;
	
	hamb_es = 35;
	hamb_senc = 25;
	refresco = 15;
	papas = 20;
	
	Escribir "Bienvenido al restaurante AdriansitoFelizQuierePasarProgramacion!  Muy largo eh...";
	Escribir "Mira nuestro menu!";
	Escribir "Hamburgesa especial $35, Hamburgesa sencilla $25, Refresco (Solo tenemos de uno, no preguntes $15, papas $20";
	
	
	Escribir "Cuantas hamburgesas especiales desea comprar?";
	Leer canthamb_es;
	
	
	Escribir "Cuantas hamburgesas sencillas desea comprar?";
	Leer canthamb_senc;
	
	Escribir "Cuantos refrescos desea comprar?";
	Leer cantrefresco;
	
	Escribir "Cuantas ordenes de papas desea comprar?";
	Leer cantpapas;
	
	
	totalhambes = canthamb_es * hamb_es;
	totalhambsenc = canthamb_senc * hamb_senc;
	totalrefresco = cantrefresco * refresco;
	totalpapas = cantpapas * papas;
	total = totalhambes + totalhambsenc + totalrefresco + totalpapas;
	iva = total * 0.16;
	total_pagar = total + iva;
	
	
	Escribir canthamb_es " " "Hamburguesa especial" " $"  totalhambes;
	Escribir canthamb_senc " " "Hamburguesa sencilla" " $"  totalhambsenc;
	Escribir cantrefresco " " "Refresco" " $"  totalrefresco;
	Escribir cantpapas " " "Papas" " $"  totalpapas;
	
	
	Escribir "Total a pagar" total_pagar;
	Escribir "Gracias por su compra!";
	Escribir "Vuelva pronto...!";
	
	
	
	
	
FinAlgoritmo
