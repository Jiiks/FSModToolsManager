﻿using FSModToolsManager.Properties;
using FSModToolsManager.Services;
using System.Reflection;

namespace FSModToolsManager.Controls;
internal partial class FormMain : FormBase {
    public FormMain(IConfig cfg, Utils.Utils utils) {
        DoubleBuffered = true;
        SetStyle(ControlStyles.ResizeRedraw, true);

        InitializeComponent();

        menuStrip1.Renderer = new UcToolStripProfessionalRenderer();
        menuStrip1.BackColor = Color.FromArgb(40, 40, 40);

        var version = Assembly.GetExecutingAssembly().GetName().Version;
        label1.Text += $" - v{version}";


        if (cfg.GetLastError() != null) return; // Something went wrong with config so stop here
        cfg.Load();

        menuStrip1.Items.Add(new MenuSetTools(cfg, utils));

        foreach (var (k, v) in cfg.GetTools()) {
            if (v.ToolType == Core.EToolType.Default) {
                v.Ctrl = new UcToolBtn(v, utils, cfg) {
                    Visible = v.DisplayInMain
                };
                launchersLayoutPanel.Controls.Add(v.Ctrl);
            } else {
                v.Ctrl = new UcDragDrop(v);
                ddContainer.Controls.Add(v.Ctrl);
            }
        }

        foreach (var linkset in cfg.GetLinks()) {
            if (linkset.Links.Count <= 0) continue;
            menuStrip1.Items.Add(new MenuSetLinks(cfg, utils, linkset));
        }

        foreach (var miscExeSet in cfg.GetMiscExeSets()) {
            if (miscExeSet.Items.Count <= 0) continue;
            menuStrip1.Items.Add(new MenuSetMiscExecutables(cfg, utils, miscExeSet));
        }

        var addBtn = new UcToolStripItem("+");
        addBtn.Click += (s, e) => {
            using var addDialog = new DialogAddToolbarItem() { StartPosition = FormStartPosition.CenterParent };
            addDialog.ShowDialog(this);
            if (addDialog.DialogResult != DialogResult.OK) return;
            if (addDialog.Title == null || addDialog.Title == string.Empty) return;
            menuStrip1.Items.Remove(addBtn);
            menuStrip1.Items.Add(new UcToolStripItem(addDialog.Title));
            menuStrip1.Items.Add(addBtn);
        };
        //menuStrip1.Items.Add(addBtn);

        var games = cfg.GetMiscExeSet("games");
        foreach(var game in games.Items) {
            gameLauncherPanel.Controls.Add(new UcLauncherBtn(game.Key, game.Value, utils, cfg));
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

    private void btnMin_MouseEnter(object sender, EventArgs e) {
        btnMin.Image = Resources.minimize_hover;
    }

    private void btnMin_MouseLeave(object sender, EventArgs e) {
        btnMin.Image = Resources.minimize_normal;
    }

    private void btnMax_MouseEnter(object sender, EventArgs e) {
        if (WindowState == FormWindowState.Maximized) {
            btnMax.Image = Resources.restore_hover;
            return;
        }
        btnMax.Image = Resources.maximize_hover;
    }

    private void btnMax_MouseLeave(object sender, EventArgs e) {
        if (WindowState == FormWindowState.Maximized) {
            btnMax.Image = Resources.restore_normal;
            return;
        }
        
        btnMax.Image = Resources.maximize_normal;
    }

    private void btnClose_MouseEnter(object sender, EventArgs e) {
        btnClose.Image = Resources.close_hover;
    }

    private void btnClose_MouseLeave(object sender, EventArgs e) {
        btnClose.Image = Resources.close_normal;
    }

    private void btnPin_Click(object sender, EventArgs e) {
        TopMost = !TopMost;
        btnPin.Image = TopMost ? Resources.pinned_normal : Resources.notpinned_normal;
    }

    private void btnPin_MouseEnter(object sender, EventArgs e) {
        btnPin.Image = TopMost ? Resources.pinned_hover : Resources.notpinned_hover;
    }

    private void btnPin_MouseLeave(object sender, EventArgs e) {
        btnPin.Image = TopMost ? Resources.pinned_normal : Resources.notpinned_normal;
    }
}


