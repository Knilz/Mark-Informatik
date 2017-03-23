function shift(text, anzahlVerschiebungen){
var verschobenerText = "";
for(var i = 0;i<text.length;i++){
verschobenerText+= String.fromCharCode(text.charCodeAt(i)+anzahlVerschiebungen);
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
