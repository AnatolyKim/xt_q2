execute.addEventListener("click",removeChars);
function removeChars(){
	var input=document.getElementsByName('input')[0].value;
	var output=document.getElementsByName('output')[0];
    var punctuations=[' ','\t',',','.',':','!','?'];
	var flag=0;
	var last=0;
	var result;
	for(var i=0; i<input.length; i++){ 
		for (var elem in punctuations){
			if(punctuations[elem]==input[i]||i==input.length-1){
				if(i==input.length-1) last=1;
				var word=input.substring(flag,i+last);
				flag=i+1;
				removeRepeats(word);				
			}			
		}
	}
	output.value=result;
	
	function removeRepeats(word){
		for (var j=0; j<word.length;j++){
			if(word.indexOf(word[j])!=word.lastIndexOf(word[j])){
				for(var k=0; k<input.length; k++){
					if (word[j]==input[k]){
						result=input.replace(word[j],"");
						input=result;
					}
				}
			}
		}
	}
}
