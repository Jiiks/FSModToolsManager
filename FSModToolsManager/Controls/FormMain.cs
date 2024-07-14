using FSModToolsManager.Services;
using System.Diagnostics;
using System.Reflection;

namespace FSModToolsManager.Controls;
internal partial class FormMain : FormBase {
    public FormMain(IConfig cfg, Utils.Utils utils) {
        DoubleBuffered = true;
        SetStyle(ControlStyles.ResizeRedraw, true);

        InitializeComponent();

        menuStrip1.Renderer = new UcToolStripProfessionalRenderer();
        menuStrip1.BackColor = Color.FromArgb(30, 30, 30);

        var version = Assembly.GetExecutingAssembly().GetName().Version;
        label1.Text += $" - v{version}";


        if (cfg.GetLastError() != null) return; // Something went wrong with config so stop here
        cfg.Load();

        menuStrip1.Items.Add(new MenuSetTools(cfg, utils));

        foreach (var linkset in cfg.GetLinks()) {
            if (linkset.Links.Count <= 0) continue;
            menuStrip1.Items.Add(new MenuSetLinks(cfg, utils, linkset));
        }

        foreach (var miscExeSet in cfg.GetMiscExeSets()) {
            if (miscExeSet.Items.Count <= 0) continue;
            menuStrip1.Items.Add(new MenuSetMiscExecutables(cfg, utils, miscExeSet));
        }

    }

    private void btnMin_Click(object sender, EventArgs e) {
        WindowState = FormWindowState.Minimized;
    }

    private void btnMax_Click(object sender, EventArgs e) {
        if (WindowState == FormWindowState.Maximized) WindowState = FormWindowState.Normal;
        else WindowState = FormWindowState.Maximized;
    }

    private void btnClose_Click(object sender, EventArgs e) {
        Application.Exit();
    }
}


