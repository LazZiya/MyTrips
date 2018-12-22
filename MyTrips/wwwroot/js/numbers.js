var getJSON = function (url, callback) {
    var xhr = new XMLHttpRequest();
    xhr.open('GET', url, true);
    xhr.responseType = 'json';
    xhr.onload = function () {
        var status = xhr.status;
        if (status === 200) {
            callback(null, xhr.response);
        } else {
            callback(status, xhr.response);
        }
    };
    xhr.send();
};

function SetNumSystem(inputControlId, culture) {
    // file from cldr-core
    // see: https://github.com/unicode-cldr/cldr-core/blob/master/supplemental/numberingSystems.json
    getJSON('https://raw.githubusercontent.com/unicode-cldr/cldr-core/master/supplemental/numberingSystems.json',
        function (err, data) {
            if (err !== null) {
                alert('Something went wrong: ' + err);
            } else {
                var inputControl = document.getElementById(inputControlId);

                inputControl.addEventListener("keydown", function (event) {
                    if (event.key >= 0 && event.key <= 9) {
                        var numbersList = data.supplemental.numberingSystems[culture]._digits;
                        event.preventDefault();
                        var s = inputControl.value;
                        var i = inputControl.selectionStart;
                        s = s.substr(0, i) + numbersList[event.key] + s.substr(inputControl.selectionEnd);
                        inputControl.value = s;
                        inputControl.selectionStart = inputControl.selectionEnd = i + 1;
                        return false;
                    }
                }, false);
                console.log("a");
            }
        });
}