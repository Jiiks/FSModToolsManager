using FSModToolsManager.Core;
using FSModToolsManager.Services;
using System.Diagnostics;

namespace FSModToolsManager.Controls;
internal class MenuSetMiscExecutables : UcToolStripItem {

    private IConfig _config;
    private Utils.Utils _utils;
    private MiscExe _miscExeSet;

    public MenuSetMiscExecutables(IConfig cfg, Utils.Utils utils, MiscExe miscExeSet) {
        Text = miscExeSet.Title;
        _config = cfg;
        _utils = utils;
        _miscExeSet = miscExeSet;

        foreach(var (k, v) in miscExeSet.Items) {
            var launcher = new UcToolStripItem(k);

            var locate = new UcToolStripItem("Locate");
            var launch = new UcToolStripItem("Launch");

            locate.Click += (s, e) => {
                if (!_utils.Ofd(out var fPath)) return;
                _miscExeSet.Items[k] = fPath;
                _config.Save(_miscExeSet);
            };
            launch.Click += (s, e) => {
                var fPath = _miscExeSet.Items[k];
                if(fPath != null || fPath != string.Empty) {
                    if(File.Exists(fPath)) {
                        _utils.StartExecutable(fPath);
                        return;
                    }
                }
                locate.PerformClick();
            };

            launcher.DropDown.Items.AddRange([locate, launch]);

            DropDownItems.Add(launcher);
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
        Debug.WriteLine($"{tool.Name} {tool.DisplayInMain}");

        dispBtn.CheckedChanged += (s, e) => {
            tool.DisplayInMain = dispBtn.Checked;
            // TODO Show/Hide Control
            tool.Save(_config);
        };

        root.DropDown.Items.AddRange([runBtn, locateBtn, downloadBtn, dispBtn]);
        DropDown.Items.Add(root);
    }



}
