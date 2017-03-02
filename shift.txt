function shift(text, anzahlVerschiebungen){
var verschobenerText = "";
for(var i = 0;i<text.length;i++){
verschobenerText+= String.fromCharCode(text.charCodeAt(i)+anzahlVerschiebungen);
}
return verschobenerText;
}