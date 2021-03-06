﻿// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
	"use strict";

	var app = WinJS.Application;
	var activation = Windows.ApplicationModel.Activation;

	app.onactivated = function (args) {
		if (args.detail.kind === activation.ActivationKind.launch) {
			if (args.detail.previousExecutionState !== activation.ApplicationExecutionState.terminated) {
			    // TODO: This application has been newly launched. Initialize your application here.

			    //Define variables
			    var emotes = [Bored, Happy, Confused, Neutral];
                var Bored = {count:0}; 
                var Happy = {count:0};
                var Confused = {count:0};
                var Neutral = {count:0};
                var out = null;

			    //Create server: 
			    //ServerSocket studentServer = new ServerSocket(8888);
			    //Client then Connects: 
			    //Socket connectionToTheServer = new Socket("localhost", 8888); //First param: server-address, Second: the port
			    //Server Accepts the connection: 
			    //Socket connectionToTheClient = server.accept();

                //Test the connection:
			    //OutputStream out = yourSocketHere.getOutputStream();
			    


			    //PrintStream ps = new PrintStream(out, true); // Second param: auto-flush on write = true
			    //ps.println("Hello, Other side of the connection!");
			    //

                //var storage = new JSON.


			} else {
				// TODO: This application was suspended and then terminated.
				// To create a smooth user experience, restore application state here so that it looks like the app never stopped running.
			}
			args.setPromise(WinJS.UI.processAll());
		}
	};

	app.oncheckpoint = function (args) {
		// TODO: This application is about to be suspended. Save any state that needs to persist across suspensions here.
		// You might use the WinJS.Application.sessionState object, which is automatically saved and restored across suspension.
		// If you need to complete an asynchronous operation before your application is suspended, call args.setPromise().
	};

	app.start();
})();
