class AjaxClient {
    static makeAjaxRequest(type, actionName, controllerName, data) {
        var url = makeUrl(actionName, controllerName);

        $.ajax({
            type: type,
            url: url,
            contentType: "application/json; charset=utf-8",
            data: data,
            dataType: "json",
            success: function (response) {
                ClientService.removeClient(response.p_id);      
            },
            error: function (response) { alert(response.message); }
        });
    };
}

function makeUrl(actionName, controllerName) {
    return '/' + controllerName + '/' + actionName;
};