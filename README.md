FrameworkAbstraction
--------------------

FrameworkAbstraction provides wrapper interfaces around .NET framework classes which interact with the operating system (e.g. classes in the System.IO.File and System.Net.Sockets namespaces).  This allows for mocking of these classes in unit tests.

As of version 2.0.0, any interfaces which are part of .NET Standard have been removed from this project and moved over to [StandardAbstraction](https://github.com/alastairwyse/StandardAbstraction/).  Interfaces remaining in this project are specific to either Windows or .NET Framework.

#### Release History

<table>
  <tr>
    <td><b>Version</b></td>
    <td><b>Changes</b></td>
  </tr>
  <tr>
    <td valign="top">2.0.0.0</td>
    <td>
      Removed interfaces compatible with .NET Standard to the <a href="https://github.com/alastairwyse/StandardAbstraction">StandardAbstraction</a> project
    </td>
  </tr>
  <tr>
    <td valign="top">1.6.0.0</td>
    <td>
      Added class FileStream<br />
      Added interface IFileStream<br />
      Added the following methods to the IFile interface...<br />
      &nbsp;&nbsp;ReadAllLines(String path)<br />
      &nbsp;&nbsp;OpenRead(String path)<br />
      Corrected Dispose() method in the following classes...<br />
      &nbsp;&nbsp;File<br />
      &nbsp;&nbsp;OleDbCommand<br />
      &nbsp;&nbsp;OleDbConnection<br />
      &nbsp;&nbsp;PerformanceCounter<br />
      &nbsp;&nbsp;TcpClient<br />
      &nbsp;&nbsp;TcpListener
    </td>
  </tr>
  <tr>
    <td valign="top">1.5.0.0</td>
    <td>
      Added class FileInfo<br />
      Added interface IFileInfo
    </td>
  </tr>
  <tr>
    <td valign="top">1.4.0.0</td>
    <td>
      Initial version forked from the <a href="http://www.alastairwyse.net/methodinvocationremoting/">Method Invocation Remoting</a> project
    </td>
  </tr>
</table>