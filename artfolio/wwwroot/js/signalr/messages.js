"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/MessagesHub").build();

//Disable send button until connection is established
document.getElementById("sendMessage").disabled = true;

// 3
connection.on("ReceiveMessage", function (senderId, receiverId, messageContent) {
    document.getElementById("getMessages").click();
});

// 1 : start connection
connection.start().then(function () {
    document.getElementById("sendMessage").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

// 2 : a message is sent
function startSignalR() {
    // we get the values needed
    var senderId = document.getElementById("senderId").value;
    var receiverId = document.getElementById("receiverId").value;

    // In MessagesHub
    connection.invoke("SendMessageHub", senderId, receiverId).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
};