// Decompiled with JetBrains decompiler
// Type: GClass0
// Assembly: AGLoaderGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F42A3A-3B30-4AF5-B541-3CA70F472B45
// Assembly location: C:\Users\alex fr\Desktop\AGLoaderGUI\bin\Release\AGLoaderGUI.exe

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

public class GClass0
{
  public static string[] string_0 = new string[23]
  {
    "processh",
    "debug",
    "debugger",
    "hacker",
    "inject",
    "dump",
    "dumper",
    "deobfs",
    "deobfuscator",
    "dnspy",
    "de4dot",
    "dbg",
    "string",
    "decrypt",
    "decryptor",
    "detect it easy",
    "die",
    "unpack",
    "unpacker",
    "http",
    "ollydbg",
    "fiddler",
    "ida"
  };

  public static void smethod_0()
  {
label_0:
    foreach (Process process in Process.GetProcesses())
    {
      if ((process.MainWindowTitle.Contains("Visual Studio") || process.MainWindowTitle.Contains("Chrome") || process.MainWindowTitle.Contains("Firefox") ? 1 : (process.MainWindowTitle.Contains("Explorer") ? 1 : 0)) == 0)
      {
        if (((IEnumerable<string>) GClass0.string_0).Any<string>(new Func<string, bool>(process.ProcessName.ToLower().Contains)))
        {
          GClass0.smethod_2(process.ProcessName);
          Environment.Exit(0);
        }
        else if (((IEnumerable<string>) GClass0.string_0).Any<string>(new Func<string, bool>(process.MainWindowTitle.ToLower().Contains)))
        {
          GClass0.smethod_2(process.ProcessName);
          Environment.Exit(0);
        }
      }
    }
    goto label_0;
  }

  public static void smethod_1()
  {
    if (Console.Title.Contains("AGLOADER"))
      return;
    Environment.Exit(0);
  }

  public static void smethod_2(string string_1)
  {
    try
    {
      foreach (Process process in Process.GetProcessesByName(string_1))
      {
        process.Kill();
        process.WaitForExit();
        process.Dispose();
      }
    }
    catch
    {
    }
  }
}
