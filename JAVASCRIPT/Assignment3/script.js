function Check() {
    var num1 = parseInt(document.getElementById("number1").value);
    var num2 = parseInt(document.getElementById("number2").value);
    var num3 = parseInt(document.getElementById("number3").value);
    if (num1 > num2 && num1 > num3) {
        document.getElementById("result").innerHTML = num1 + " is the largest"
        
    }
    else if(num2>num3 && num2>num1){
        document.getElementById("result").innerHTML = num2 + " is the largest"   
    }
    else{
        document.getElementById("result").innerHTML = num3 + " is the largest"
    }
}