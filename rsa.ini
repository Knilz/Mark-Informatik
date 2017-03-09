function isPrime(a){
	for(var i=2;i<a-1;i++){
		if(a%i){
			return false;
		}
	}
	return true;
}
function findPrime(min){
	for(var i=min;true;i++){
		if(isPrime(i)){
			return i;
		}
	}
}
var p,q,e,d,m,phi ;

function GenerateKeys(min1,min2){
	p = findPrime(min1);
	q = findPrime(min2);
	m = p*q;
	phi = (p-1)*(q-1);
	for(var i =2;true; i++){
		if(teilerfremd(i,phi){
			e = i;
			break;
		}
	}
	d = bestimmeInverses(phi,e);
}
function teilerfremd(a, b){
	var kleinere = a>b?b:a==b?a:b;
	for(var i = 1;i<=kleinere;i++){
		if(ganzeZahl(a%i)&&ganzeZahl(b%i))
			return false;
	}
	return true;
}
function ganzeZahl(a){
	return (a == a.round());
}
function bestimmeInverses(phi,e){
	for(var k = -2,d;true;k--){
		d = (1-(k*phi))/e ;
		if(ganzeZahl(d))
			return d;
	}
}
function encryptNumber(number){
	return Math.pow(number,e)%m;
}
function decryptNumber(number){
	return Math.pow(number,d)%m;
}
function decryptText(geheimtext){
	var klartext;
	for(var i=0;i<geheimtext.Length;i++){
		klartext += String.fromCharCode(decryptNumber(geheimtext[i].charCodeAt()));
	}
	return klartext;
}
function encryptText(klartext){
	var geheimtext;
		for(var i=0;i<klartext.Length;i++){
		klartext += String.fromCharCode(encryptNumber(klartext[i].charCodeAt()));
	}
	return geheimtext;
}