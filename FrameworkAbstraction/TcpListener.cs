/*
 * Copyright 2015 Alastair Wyse (https://github.com/alastairwyse/FrameworkAbstraction)
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace FrameworkAbstraction
{
    //******************************************************************************
    //
    // Class: TcpListener
    //
    //******************************************************************************
    /// <summary>
    /// Provides an abstraction of the System.Net.Sockets.TcpListener class, to facilitate mocking and unit testing.
    /// </summary>
    public class TcpListener : ITcpListener
    {
        /// <summary>Indicates whether the object has been disposed.</summary>
        protected bool disposed;
        private ExtendedTcpListener tcpListener;

        //------------------------------------------------------------------------------
        //
        // Method: TcpListener (constructor)
        //
        //------------------------------------------------------------------------------
        /// <summary>
        /// Initialises a new instance of the FrameworkAbstraction.TcpListener class.
        /// </summary>
        /// <param name="ipAddress">An IPAddress that represents the local IP address.</param>
        /// <param name="port">The port on which to listen for incoming connection attempts. </param>
        public TcpListener(System.Net.IPAddress ipAddress, int port)
        {
            disposed = false;
            tcpListener = new ExtendedTcpListener(ipAddress, port);
        }

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="P:FrameworkAbstraction.ITcpListener.Active"]/*'/>
        public bool Active
        {
            get
            {
                return tcpListener.Active;
            }
        }

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="M:FrameworkAbstraction.ITcpListener.Pending"]/*'/>
        public bool Pending()
        {
            return tcpListener.Pending();
        }

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="M:FrameworkAbstraction.ITcpListener.Start(System.Int32)"]/*'/>
        public void Start(int backlog)
        {
            tcpListener.Start(backlog);
        }

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="M:FrameworkAbstraction.ITcpListener.AcceptTcpClient"]/*'/>
        public ITcpClient AcceptTcpClient()
        {
            // Returning System.Net.Sockets.TcpClient wrapped in an FrameworkAbstraction.TcpClient and implementing ITcpClient, allows this method to be mocked
            System.Net.Sockets.TcpClient client = tcpListener.AcceptTcpClient();
            return new TcpClient(client);
        }

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="M:FrameworkAbstraction.ITcpListener.Stop"]/*'/>
        public void Stop()
        {
            tcpListener.Stop();
        }

        #region Finalize / Dispose Methods

        /// <summary>
        /// Releases the unmanaged resources used by the TcpListener.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #pragma warning disable 1591
        ~TcpListener()
        {
            Dispose(false);
        }
        #pragma warning restore 1591

        //------------------------------------------------------------------------------
        //
        // Method: Dispose
        //
        //------------------------------------------------------------------------------
        /// <summary>
        /// Provides a method to free unmanaged resources used by this class.
        /// </summary>
        /// <param name="disposing">Whether the method is being called as part of an explicit Dispose routine, and hence whether managed resources should also be freed.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Free other state (managed objects).
                }
                // Free your own state (unmanaged objects).
                if (tcpListener != null)
                {
                    tcpListener.Server.Close();
                    tcpListener.Stop();
                }
                // Set large fields to null.

                disposed = true;
            }
        }

        #endregion
    }
}
