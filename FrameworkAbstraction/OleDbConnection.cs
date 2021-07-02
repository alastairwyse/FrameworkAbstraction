/*
 * Copyright 2017 Alastair Wyse (https://github.com/alastairwyse/FrameworkAbstraction)
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
    /// <summary>
    /// Provides an abstraction of the System.Data.OleDb.OleDbConnection class, to facilitate mocking and unit testing.
    /// </summary>
    public class OleDbConnection : IOleDbConnection
    {
        /// <summary>Indicates whether the object has been disposed.</summary>
        protected bool disposed;
        private System.Data.OleDb.OleDbConnection oleDbConnection;


        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="P:FrameworkAbstraction.IOleDbConnection.ConnectionString"]/*'/>
        public string ConnectionString
        {
            get
            {
                return oleDbConnection.ConnectionString;
            }
            set
            {
                oleDbConnection.ConnectionString = value;
            }
        }

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="P:FrameworkAbstraction.IOleDbConnection.State"]/*'/>
        public System.Data.ConnectionState State
        {
            get
            {
                return oleDbConnection.State;
            }
        }

        /// <summary>
        /// The connection underlying the abstraction.
        /// </summary>
        public System.Data.OleDb.OleDbConnection Connection
        {
            get
            {
                return oleDbConnection;
            }
        }

        /// <summary>
        /// Initialises a new instance of the FrameworkAbstraction.OleDbConnection class.
        /// </summary>
        public OleDbConnection()
        {
            oleDbConnection = new System.Data.OleDb.OleDbConnection();
            disposed = false;
        }

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="M:FrameworkAbstraction.IOleDbConnection.Open"]/*'/>
        public void Open()
        {
            oleDbConnection.Open();
        }

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="M:FrameworkAbstraction.IOleDbConnection.Close"]/*'/>
        public void Close()
        {
            oleDbConnection.Close();
        }

        #region Finalize / Dispose Methods

        /// <summary>
        /// Releases the unmanaged resources used by the OleDbConnection.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #pragma warning disable 1591
        ~OleDbConnection()
        {
            Dispose(false);
        }
        #pragma warning restore 1591

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
                    if (oleDbConnection != null)
                    {
                        oleDbConnection.Close();
                        oleDbConnection.Dispose();
                    }
                }
                // Free your own state (unmanaged objects).

                // Set large fields to null.
                oleDbConnection = null;

                disposed = true;
            }
        }

        #endregion
    }
}
