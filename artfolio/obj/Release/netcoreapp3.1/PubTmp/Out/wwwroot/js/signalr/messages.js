"use strict";

// 0 : connection builder
var connection = new signalR.HubConnectionBuilder().withUrl("/MessagesHub").build();

// 1 : start connection between the 2 artists
// .then can be added if we want
connection.start()
    .catch(function (err) {
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

// 3
connection.on("ReceiveMessage", function (senderId, receiverId, messageContent) {
    document.getElementById("getMessages").click();
});