FrameworkAbstraction
--------------------

FrameworkAbstraction provides wrapper interfaces around .NET framework classes which interact with the operating system (e.g. classes in the System.IO.File and System.Net.Sockets namespaces).  This allows for mocking of these classes in unit tests.

The project was originally included as a part of the [Method Invocation Remoting](http://www.oraclepermissiongenerator.net/methodinvocationremoting/) project, and was named 'OperatingSystemAbstraction'.