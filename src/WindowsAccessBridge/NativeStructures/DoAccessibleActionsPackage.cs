﻿// Copyright 2015 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using jint = System.Int32;
using BOOL = System.Int32;
using AccessibleContext = AccessBridgeExplorer.WindowsAccessBridge.JOBJECT64;

namespace AccessBridgeExplorer.WindowsAccessBridge.NativeStructures {
  /// <summary>
  /// struct for sending an message to do one or more actions
  /// </summary>
  [SuppressMessage("ReSharper", "InconsistentNaming")]
  [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
  public struct DoAccessibleActionsPackage {
    public int vmID;                         // the virtual machine ID
    public AccessibleContext accessibleContext;       // component to do the action
    public AccessibleActionsToDo actionsToDo; // the accessible actions to do
    public BOOL rResult;                      // action return value
    public jint failure;                      // index of action that failed if rResult is FALSE
  }
}