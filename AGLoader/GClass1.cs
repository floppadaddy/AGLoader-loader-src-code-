// Decompiled with JetBrains decompiler
// Type: GClass1
// Assembly: AGLoaderGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CCB78C09-B1CF-4611-914E-9EBA5B02B46C
// Assembly location: C:\Users\alex fr\Desktop\Renamed\AGLoaderGUI.exe

using CefSharp;
using System;
using System.IO;

public class GClass1 : IDownloadHandler
{
    private EventHandler<DownloadItem> eventHandler_0;
    private EventHandler<DownloadItem> eventHandler_1;

    public event EventHandler<DownloadItem> Event_0;

    public event EventHandler<DownloadItem> Event_1;

    public bool CanDownload(
      IWebBrowser chromiumWebBrowser,
      IBrowser browser,
      string url,
      string requestMethod)
    {
        return true;
    }

    public void OnBeforeDownload(
      IWebBrowser chromiumWebBrowser,
      IBrowser browser,
      DownloadItem downloadItem,
      IBeforeDownloadCallback callback)
    {
        // ISSUE: reference to a compiler-generated field
        EventHandler<DownloadItem> eventHandler0 = this.eventHandler_0;
        if (eventHandler0 != null)
            eventHandler0((object)this, downloadItem);
        if (callback.IsDisposed)
            return;
        using (callback)
        {
            int num = 3;
            string tempPath = Path.GetTempPath();
            callback.Continue(tempPath + "\\" + downloadItem.SuggestedFileName, false);
            while (File.Exists(tempPath + "\\" + downloadItem.SuggestedFileName))
            {
                if (num == 0)
                    ;
                Class0.smethod_1(tempPath + "\\" + downloadItem.SuggestedFileName);
                --num;
            }
        }
    }

    public void OnDownloadUpdated(
      IWebBrowser chromiumWebBrowser,
      IBrowser browser,
      DownloadItem downloadItem,
      IDownloadItemCallback callback)
    {
        // ISSUE: reference to a compiler-generated field
        EventHandler<DownloadItem> eventHandler1 = this.eventHandler_1;
        if (eventHandler1 == null)
            return;
        eventHandler1((object)this, downloadItem);
    }
}
