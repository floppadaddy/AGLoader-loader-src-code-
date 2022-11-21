// Decompiled with JetBrains decompiler
// Type: GClass2
// Assembly: AGLoaderGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F42A3A-3B30-4AF5-B541-3CA70F472B45
// Assembly location: C:\Users\alex fr\Desktop\AGLoaderGUI\bin\Release\AGLoaderGUI.exe

using CefSharp;

public class GClass2 : IContextMenuHandler
{
  public void OnBeforeContextMenu(
    IWebBrowser browserControl,
    IBrowser browser,
    IFrame frame,
    IContextMenuParams parameters,
    IMenuModel model)
  {
    model.Clear();
  }

  public bool OnContextMenuCommand(
    IWebBrowser browserControl,
    IBrowser browser,
    IFrame frame,
    IContextMenuParams parameters,
    CefMenuCommand commandId,
    CefEventFlags eventFlags)
  {
    return false;
  }

  public void OnContextMenuDismissed(IWebBrowser browserControl, IBrowser browser, IFrame frame)
  {
  }

  public bool RunContextMenu(
    IWebBrowser browserControl,
    IBrowser browser,
    IFrame frame,
    IContextMenuParams parameters,
    IMenuModel model,
    IRunContextMenuCallback callback)
  {
    return false;
  }
}
