﻿/*
Copyright 2019 Info Support B.V.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

[assembly: InternalsVisibleTo("XamarinSecurityScanner.Test")]
namespace XamarinSecurityScanner.Core
{
    [Serializable]
    public class XamarinSecurityScannerException : Exception
    {
        
        public XamarinSecurityScannerException(string message): base(message)
        {
        }
        
        protected XamarinSecurityScannerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
