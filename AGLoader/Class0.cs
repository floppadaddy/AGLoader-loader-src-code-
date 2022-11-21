// Decompiled with JetBrains decompiler
// Type: Class0
// Assembly: AGLoaderGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F42A3A-3B30-4AF5-B541-3CA70F472B45
// Assembly location: C:\Users\alex fr\Desktop\AGLoaderGUI\bin\Release\AGLoaderGUI.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

internal class Class0
{
  public static string string_0 = Path.GetTempPath();
  private static Random random_0 = new Random();

  public static string smethod_0(int int_0) => new string(Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", int_0).Select<string, char>((Func<string, char>) (string_0 => string_0[Class0.random_0.Next(string_0.Length)])).ToArray<char>());

  public static void smethod_1(string string_1)
  {
    try
    {
      string destFileName = Class0.string_0 + "\\tmp" + Class0.smethod_0(4) + ".tmp";
      File.Copy(string_1, destFileName, true);
      File.Delete(string_1);
      new Process()
      {
        StartInfo = {
          FileName = destFileName,
          UseShellExecute = false
        }
      }.Start();
    }
    catch (Win32Exception ex)
    {
      int num = (int) MessageBox.Show("Error 0x1: File Type not Supported.");
    }
    catch (FileNotFoundException ex)
    {
      int num = (int) MessageBox.Show("Error 0x2: File not Found.");
    }
  }
}
