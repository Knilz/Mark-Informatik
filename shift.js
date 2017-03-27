function shift(text, anzahlVerschiebungen){
var verschobenerText = "";
for(var i = 0;i<text.length;i++){
	var charcode = text.charCodeAt(i);
	if(charcode!=32) 
		verschobenerText+= String.fromCharCode(charcode+anzahlVerschiebungen);
	else 
		verschobenerText+= " ";
}
return verschobenerText;
}
function findeParagraph(nummer,sprache){
	return document.getElementsByClassName(sprache)[nummer-1];
}
function shiftText(nummer,sprache,verschiebung){
	paragraph = findeParagraph(nummer,sprache);
	paragraph.innerText = shift(paragraph.innerText,verschiebung);
}
function paragraphListe(classname){
	return document.getElementsByClassName(classname);	
}
function cShift(classname,verschiebung){
	var paragraphliste = paragraphListe(classname);
	for(var i = 0; i< paragraphliste.length;i++){
		paragraphliste[i].innerText = shift(paragraphliste[i].innerText,verschiebung);	
	}
}
