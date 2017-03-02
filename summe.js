function summe(grenze,potenz,schritte){
	var summe = 0;
	for(var i = 0; i<grenze; i += schritte){
		summe += Math.pow(i,potenz);
	}
	return summe;
}

/*
*	Ist für die Zusatzaufgabe hilfreich
*/ 