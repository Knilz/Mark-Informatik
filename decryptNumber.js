function decryptNumber(num){
	var arr = new Array(d);
	for(var i=0;i<d;i++)
		arr[i] = num;
	while(arr.length !=1)
		arr = zusammenfassen(arr,m); //wie funktioniert Referenz? vlt ist zusammenfassen(arr,m) besser
	return arr[0];
}
function zusammenfassen(arr,mod){
	var newArr = new Array(Math.ceil(arr.length/2));
	for(var i = 0; i< arr.length;i+=2)
		newArr[i/2] = arr[i] * ((arr[++i]==undefined)?1:arr[++i])%mod;
	return newArr;
}