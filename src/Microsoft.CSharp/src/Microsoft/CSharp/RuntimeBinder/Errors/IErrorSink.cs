﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.CSharp.RuntimeBinder.Errors
{
    // This interface is used to decouple the error reporting
    // implementation from the error detection source. 
    internal interface IErrorSink
    {
        void SubmitError(CParameterizedError error);
        int ErrorCount();
    }
}