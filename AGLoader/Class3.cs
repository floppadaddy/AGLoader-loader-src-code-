// Decompiled with JetBrains decompiler
// Type: Class3
// Assembly: AGLoaderGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F42A3A-3B30-4AF5-B541-3CA70F472B45
// Assembly location: C:\Users\alex fr\Desktop\AGLoaderGUI\bin\Release\AGLoaderGUI.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Class3
{
  private static ResourceManager resourceManager_0;
  private static CultureInfo cultureInfo_0;

  internal Class3()
  {
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static ResourceManager ResourceManager_0
  {
    get
    {
      if (Class3.resourceManager_0 == null)
        Class3.resourceManager_0 = new ResourceManager(nameof (Class3), typeof (Class3).Assembly);
      return Class3.resourceManager_0;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static CultureInfo CultureInfo_0
  {
    get => Class3.cultureInfo_0;
    set => Class3.cultureInfo_0 = value;
  }
}
