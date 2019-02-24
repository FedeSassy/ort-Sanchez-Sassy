var c_remove = $("#clientRemove");

c_remove.click(function () {
    removeClientByPersonalID(c_remove.parent().parent()[0].cells[1].textContent);
});

function removeClientByPersonalID(clientID) {
    var info = {
        id: clientID
    }

    console.log("info => ", info);
    //static makeAjaxRequest(type, action, controller, data) {
    AjaxClient.makeAjaxRequest("DELETE", "RemoveClient", "Client", info);
};