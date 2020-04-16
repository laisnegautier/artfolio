"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/MessagesHub").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;

// 3
connection.on("ReceiveMessage", function (senderId, receiverId, messageContent) {
    // we check message then actualize messages
    $.ajax({
        url: '/Messages/MessagesE', // to get the right path to controller from TableRoutes of Asp.Net MVC
        type: "POST", //to do a post request 
        cache: false, //avoid caching results
        data: { 'senderId': senderId, 'receiverId': receiverId, 'messageContent': messageContent },
        success: function (data) {
            // data is your result from controller
            //alert(data);
            $('#ajaxresult').replaceWith(data);
        },
        error: function (xhr) {
            alert(xhr.responseText);
        }
    });
});

// 1 : start connection
connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

// 2 : a message is sent
document.getElementById("sendButton").addEventListener("click", function (event) {

    // we get the values needed
    var senderId = document.getElementById("senderId").value;
    var receiverId = document.getElementById("receiverId").value;
    var messageContent = document.getElementById("messageContent").value;

    // In MessagesHub
    connection.invoke("SendMessage", senderId, receiverId, messageContent).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});