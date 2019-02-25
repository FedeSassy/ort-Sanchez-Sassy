var c_removeList = $("*[id=clientRemove]");

c_removeList.each(function () {
    this.addEventListener("click", function () {
        closeOrder(this.parentElement.parentElement.cells[1].textContent);
    });
});

function closeOrder(clientID) {
    var info = {
        clientPersonalID: clientID
    }

    AjaxClient.makeAjaxRequest("GET", "ClientRemove", "Client", info);
};

class ClientService {
    static removeClient(client_id) {
        $('tr[personal_id=' + client_id + ']')[0].remove();
    }
}