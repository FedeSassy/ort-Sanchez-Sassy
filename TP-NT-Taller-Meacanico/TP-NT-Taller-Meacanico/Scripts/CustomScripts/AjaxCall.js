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
                if (response.p_id) {
                    ClientService.removeClient(response.p_id);
                } else if (response.order_id) {
                    OrdertService.closeOrderAndSetTotal(response.order_id, response.total_price, response.date_ended)
                }
                      
            },
            error: function (response) { alert(response.message); }
        });
    };
}

function makeUrl(actionName, controllerName) {
    return '/' + controllerName + '/' + actionName;
};