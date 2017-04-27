FrameworkAbstraction
--------------------

FrameworkAbstraction provides wrapper interfaces around .NET framework classes which interact with the operating system (e.g. classes in the System.IO.File and System.Net.Sockets namespaces).  This allows for mocking of these classes in unit tests.

The project was originally included as a part of the [Method Invocation Remoting](http://www.oraclepermissiongenerator.net/methodinvocationremoting/) project, and was named 'OperatingSystemAbstraction'.

#### Release History

<table>
  <tr>
    <td><b>Version</b></td>
    <td><b>Changes</b></td>
  </tr>
  <tr>
    <td valign="top">1.6.0.0</td>
    <td>
      Added class FileStream
      Added interface IFileStream
      Added the following methods to the IFile interface...
        ReadAllLines(String path)
        OpenRead(String path)
      Corrected Dispose() method in the following classes...
        File
        OleDbCommand
        OleDbConnection
        PerformanceCounter
        TcpClient
        TcpListener
    </td>
  </tr>
  <tr>
    <td valign="top">1.5.0.0</td>
    <td>
      Added class FileInfo
      Added interface IFileInfo
    </td>
  </tr>
  <tr>
    <td valign="top">1.4.0.0</td>
    <td>
      Initial version forked from the [Method Invocation Remoting](http://www.oraclepermissiongenerator.net/methodinvocationremoting/) project
    </td>
  </tr>
</table>