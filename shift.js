function shift(text, anzahlVerschiebungen){
var verschobenerText = "";
for(var i = 0;i<text.length;i++){
	var charcode = text.charCodeAt(i);
	verschobenerText += String.fromCharcode(shiftCc(charcode,anzahlVerschiebungen)); 
}
return verschobenerText;
}
function shiftText(nummer,sprache,verschiebung){
	paragraph = document.getElementsByClassName(sprache)[nummer-1];
	paragraph.innerText = shift(paragraph.innerText,verschiebung);
}
function cShift(classname,verschiebung){
	var paragraphliste = document.getElementsByClassName(classname);
	for(var i = 0; i< paragraphliste.length;i++){
		var iT = paragraphliste[i].innerText;
		paragraphliste[i].innerText = shift(iT,verschiebung);	
	}
}
function shiftCc(charcode,anzahlVerschiebungen){
	if(!((charcode>64 && charcode<91)||(charcode>96 && charcode<123)))
		return charcode;
	var cc51 = inASCIIBereich51(charcode);
	cc51 = cc51+anzahlVerschiebungen % 52;
	return inASCIIBereich(cc51);
}
function inASCIIBereich51(charcode){
	if(charcode<91)
		return charcode-65;
	else
		return charcode-71;
}
function inASCIIBereich(charcode){
	if(charcode<26)
		return charcode+65;
	else
		return charcode+71;
}
