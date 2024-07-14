using FSModToolsManager.Core;
using FSModToolsManager.Services;
using System.Diagnostics;

namespace FSModToolsManager.Controls;
internal class MenuSetTools : UcToolStripItem {

    private IConfig _config;
    private Utils.Utils _utils;
    public MenuSetTools(IConfig cfg, Utils.Utils utils) {
        Text = "Tools";
        _config = cfg;
        _utils = utils;

        foreach(var (k, v) in cfg.GetTools()) {
            AddTool(k, v);
        }
    }

    private void AddTool(string key, Tool tool) {
        var root = new UcToolStripItem(tool.Name);

        var runBtn = new UcToolStripItem("Run");
        runBtn.Click += (s, e) => tool.Run(_config, _utils);

        var locateBtn = new UcToolStripItem("Locate");
        locateBtn.Click += (s, e) => tool.Locate(_config, _utils);

        var downloadBtn = new UcToolStripItem("Download");
        downloadBtn.Click += (s, e) => tool.DownloadTool(_utils);

        var dispBtn = new UcToolStripItem("Display in main window") {
            CheckOnClick = true,
            Checked = tool.DisplayInMain
        };

        dispBtn.CheckedChanged += (s, e) => {
            tool.DisplayInMain = dispBtn.Checked;
            tool.Ctrl.Visible = dispBtn.Checked;
            tool.Save(_config);
        };

        root.DropDown.Items.AddRange([runBtn, locateBtn, downloadBtn, dispBtn]);
        DropDown.Items.Add(root);
    }



}
