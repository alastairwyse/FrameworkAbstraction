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
    /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="T:FrameworkAbstraction.IPerformanceCounterCategory"]/*'/>
    public interface IPerformanceCounterCategory
    {
        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="M:FrameworkAbstraction.IPerformanceCounterCategory.Exists(System.String)"]/*'/>
        bool Exists(string categoryName);

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="M:FrameworkAbstraction.IPerformanceCounterCategory.Delete(System.String)"]/*'/>
        void Delete(string categoryName);

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="M:FrameworkAbstraction.IPerformanceCounterCategory.Create(System.String,System.String,System.Diagnostics.PerformanceCounterCategoryType,ICounterCreationDataCollection)"]/*'/>
        void Create(string categoryName, string categoryHelp, System.Diagnostics.PerformanceCounterCategoryType categoryType, ICounterCreationDataCollection counterData);
    }
}
