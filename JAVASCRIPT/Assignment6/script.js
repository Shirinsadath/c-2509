function startTimer() {
    var seconds = parseInt(document.getElementById("seconds").value);
    var countdownelement = document.getElementById("display");
    var countdown = setInterval(function() {
        countdownelement.textContent = seconds + "seconds remaining";
        seconds-- ;
        if(seconds<0){
            clearInterval(countdown);
            countdownelement.textContent="time is up";
        }
        
    }, 1000);
}

