window.onload = function () {
    (function () {
        var date = new Date();
        var options = {
            year: 'numeric',
            month: 'long',
            day: 'numeric',
            weekday: 'long',
            timezone: 'UTC',
            hour: 'numeric',
            minute: 'numeric',
            second: 'numeric'
        };
        var todayDate ="Сегодня "+date.toLocaleString("ru", options);
        document.getElementsByTagName('div')[1].innerHTML = todayDate;
        window.setTimeout(arguments.callee, 1000);
    })();
};