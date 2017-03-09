function isPrime(a){			//W
	for(var i=2;i<a-1;i++){
		if(a%i==0){
			return false;
		}
	}
	return true;
}
function findPrime(min){		//W
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
	e = 2;
	while(true){
	e = findeNächstesTeilerfremdes(e);
	if(bestimmeInverses())
		break;
	}
}
function teilerfremd(a, b){			//W
	var kleinere = a>b?b:a==b?a:b;
	for(var i = 2;i<=kleinere;i++){
		if(a%i==0 && b%i==0)
			return false;
	}
	return true;
}
function ganzeZahl(a){      //W
	return (a == Math.round(a));
}
function findeNächstesTeilerfremdes(altes){   
	for(var i = altes +1 ;true; i++){
		if(teilerfremd(i,phi)){
			return i;
		}
	}	
}
function bestimmeInverses(){
	for(var k = -2,d;true;k--){
		d = (1-(k*phi))/e ;
		if(d<m){
			if(ganzeZahl(d)&& e*d%phi ==1)
			return true	
		}else{
			return false;
		}
	}
}
function encryptNumber(number){		//W
	return Math.pow(number,e)%m;
}
function decryptNumber(number){		//W
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
