function temp(){
    var temp=parseInt(document.getElementById("temp").value);
    temp = (temp *(9/5) + 32)
    document.getElementById("result").innerHTML = temp + " F"
}