var c_removeList = $("*[id=orderCLose]");

c_removeList.each(function () {
    this.addEventListener("click", function () {
        closeOrder(this.parentElement.parentElement.cells[0].textContent);
    });
});

function closeOrder(orderID) {
    var info = {
        orderID: orderID
    }

    AjaxClient.makeAjaxRequest("GET", "OrderClose", "Home", info);
};

class OrdertService {
    static closeOrderAndSetTotal(orderID, totalPrice, dateEnded) {
        var row = $('tr[order_id=' + orderID + ']')[0];
        row.cells[2].textContent = dateEnded;
        row.cells[3].textContent = "DONE";
        row.cells[10].textContent = "$" + totalPrice;
    }
}