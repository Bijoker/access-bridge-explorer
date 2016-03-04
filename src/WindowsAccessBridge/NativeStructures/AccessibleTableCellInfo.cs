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
using AccessibleContext = AccessBridgeExplorer.WindowsAccessBridge.JOBJECT64;
using jint = System.Int32;
using jboolean = System.Byte;

namespace AccessBridgeExplorer.WindowsAccessBridge.NativeStructures {

  [SuppressMessage("ReSharper", "InconsistentNaming")]
  [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
  public struct AccessibleTableCellInfo {
    public AccessibleContext accessibleContext;
    public jint index;
    public jint row;
    public jint column;
    public jint rowExtent;
    public jint columnExtent;
    public jboolean isSelected;
  }
}