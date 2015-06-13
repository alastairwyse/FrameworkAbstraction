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
    // Class: CounterCreationDataCollection
    //
    //******************************************************************************
    /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="T:FrameworkAbstraction.ICounterCreationDataCollection"]/*'/>
    public class CounterCreationDataCollection : ICounterCreationDataCollection
    {
        private System.Diagnostics.CounterCreationDataCollection counterCreationDataCollection;

        //------------------------------------------------------------------------------
        //
        // Method: CounterCreationDataFactory (constructor)
        //
        //------------------------------------------------------------------------------
        /// <summary>
        /// Initialises a new instance of the FrameworkAbstraction.CounterCreationDataCollection class.
        /// </summary>
        public CounterCreationDataCollection()
        {
            counterCreationDataCollection = new System.Diagnostics.CounterCreationDataCollection();
        }

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="M:FrameworkAbstraction.ICounterCreationDataCollection.Add(FrameworkAbstraction.ICounterCreationData)"]/*'/>
        public int Add(ICounterCreationData value)
        {
            return counterCreationDataCollection.Add(value.CreationData);
        }

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="P:FrameworkAbstraction.ICounterCreationDataCollection.Collection"]/*'/>
        public System.Diagnostics.CounterCreationDataCollection Collection
        {
            get
            {
                return counterCreationDataCollection;
            }
        }
    }
}
