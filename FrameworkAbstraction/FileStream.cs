/*
 * Copyright 2017 Alastair Wyse (http://www.oraclepermissiongenerator.net/simpleml/)
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
using System.Linq;
using System.Text;

namespace FrameworkAbstraction
{
    /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="T:FrameworkAbstraction.IFileStream"]/*'/>
    public class FileStream : IFileStream
    {
        /// <summary>Indicates whether the object has been disposed.</summary>
        protected Boolean disposed;
        private System.IO.FileStream fileStream;

        /// <summary>
        /// Initialises a new instance of the FrameworkAbstraction.FileStream class.
        /// </summary>
        /// <param name="underlyingFileStream">The real System.IO.FileStream underlying this object.</param>
        public FileStream(System.IO.FileStream underlyingFileStream)
        {
            this.fileStream = underlyingFileStream;
        }

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="M:FrameworkAbstraction.IFileStream.Read(System.Byte[],System.Int32,System.Int32)"]/*'/>
        public long Seek(long offset, System.IO.SeekOrigin origin)
        {
            return fileStream.Seek(offset, origin);
        }

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="M:SimpleML.Containers.Persistence.IFileStream.Read(System.Byte[],System.Int32,System.Int32)"]/*'/>
        public int Read(ref byte[] array, int offset, int count)
        {
            return fileStream.Read(array, offset, count);
        }

        #region Finalize / Dispose Methods

        /// <summary>
        /// Releases all resources used by the Stream.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #pragma warning disable 1591
        ~FileStream()
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
                    if (fileStream != null)
                    {
                        fileStream.Dispose();
                    }
                }
                // Free your own state (unmanaged objects).

                // Set large fields to null.

                disposed = true;
            }
        }

        #endregion
    }
}
