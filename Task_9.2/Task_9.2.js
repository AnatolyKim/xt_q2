execute.addEventListener("click",calculate);
function calculate(){   
    var input=document.getElementsByName("input")[0].value;
    var output=document.getElementsByName("output")[0];
    var equal=input.match(/=$/g);
    if(equal!=null){
        var digits=input.match(/\d+(\.\d+)?/g);
        var operators=input.match(/\+|\-|\*|\//g);
        var result=parseFloat(digits[0]);
        for(var i=0; i<operators.length;i++){
            switch(operators[i]){
                case '+':
                    result=result+parseFloat(digits[i+1]);
                    break;
                case '-':
                    result=result-parseFloat(digits[i+1]);
                    break;
                case '*':
                    result=result*parseFloat(digits[i+1]);
                    break;        
                case '/':
                    result=result/parseFloat(digits[i+1]);
                    break;   
            }
        }  
        output.value=result.toFixed(2);  
    }
    else output.value="Input equal sign"; 
}
