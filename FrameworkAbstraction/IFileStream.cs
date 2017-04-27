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
using System.Linq;
using System.Text;
using System.IO;

namespace FrameworkAbstraction
{
    /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="T:FrameworkAbstraction.IFileStream"]/*'/>
    public interface IFileStream : IDisposable
    {
        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="M:FrameworkAbstraction.IFileStream.Seek(System.Int64,System.IO.SeekOrigin)"]/*'/>
        Int64 Seek(Int64 offset, SeekOrigin origin);

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="M:FrameworkAbstraction.IFileStream.Read(System.Byte[],System.Int32,System.Int32)"]/*'/>
        /// <remarks>Note 'array' parameter has 'ref' keyword defined, even though it is not defined as such on System.IO.FileStream class.  Reason is that NMock2 SetNamedParameterAction requires ref be defined on methods where data passed in is changed, otherwise attempting to change the parameter value has no effect.</remarks>
        Int32 Read(ref Byte[] array, Int32 offset, Int32 count);
    }
}
