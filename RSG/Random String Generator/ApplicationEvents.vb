Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        Private Sub s() Handles MyBase.Startup

        End Sub

        Private Sub msgClient() Handles MyBase.NetworkAvailabilityChanged
            func = New Functions
            func.createToolTip("Network change exception.", "RSG has detected a change in your internet connection. Please check to make sure it's on/off.", "Info", 7000, True)
        End Sub
    End Class
End Namespace
