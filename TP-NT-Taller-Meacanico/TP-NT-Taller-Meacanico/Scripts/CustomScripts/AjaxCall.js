class AjaxClient {
    static makeAjaxRequest(type, actionName, controllerName, data) {
        var url = makeUrl(actionName, controllerName);
        console.log('url => ', url);

        $.ajax({
            type: type,
            url: url,
            contentType: "application/json; charset=utf-8",
            data: data,
            dataType: "json",
            success: function () { alert('Success'); },
            error: function () { alert('An error'); }
        });
    };
}

function makeUrl(actionName, controllerName) {
    return '/' + controllerName + '/' + actionName;
};