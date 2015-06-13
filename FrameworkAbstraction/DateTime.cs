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
    // Class: DateTime
    //
    //******************************************************************************
    /// <summary>
    /// Provides an abstraction of the System.DateTime structure, to facilitate mocking and unit testing.
    /// </summary>
    public class DateTime : IDateTime
    {
        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="P:FrameworkAbstraction.IDateTime.Now"]/*'/>
        public System.DateTime Now
        {
            get
            {
                return System.DateTime.Now;
            }
        }

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="P:FrameworkAbstraction.IDateTime.UtcNow"]/*'/>
        public System.DateTime UtcNow
        {
            get 
            {
                return System.DateTime.UtcNow;
            }
        }
    }
}
