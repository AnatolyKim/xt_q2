repeat.addEventListener("click", function(){window.location.href='Task_9.4.1.html'});
exit.addEventListener("click", function(){window.close()});
function startTimer(duration, display) {
    var timer = duration, seconds;
    setInterval(function () {
        seconds = parseInt(timer % 60, 10);
        seconds = seconds < 10 ? "0" + seconds : seconds;
        display.textContent = seconds;
        if (--timer < 0) {
            timer = 0;
        }
    }, 1000);
}
window.onload = function () {
    var countdown = 5,
        display = document.querySelector('#time');
    startTimer(countdown, display);
    setTimeout(function(){document.getElementById("action").classList.toggle("show");},6500);
};