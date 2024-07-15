using FSModToolsManager.Core;
using FSModToolsManager.Services;
using System.Diagnostics;

namespace FSModToolsManager.Controls;
internal class MenuSetMiscExecutables : UcToolStripItem {

    private IConfig _config;
    private Utils.Utils _utils;
    private MiscExe _miscExeSet;
    private Process? _process;

    public MenuSetMiscExecutables(IConfig cfg, Utils.Utils utils, MiscExe miscExeSet) {
        Text = miscExeSet.Title;
        _config = cfg;
        _utils = utils;
        _miscExeSet = miscExeSet;

        foreach(var (k, v) in miscExeSet.Items) {
            var launcher = new UcToolStripItem(k);

            var locate = new UcToolStripItem("Locate");
            var launch = new UcToolStripItem("Launch");
            var kill = new UcToolStripItem("Kill");

            locate.Click += (s, e) => {
                if (!_utils.Ofd(out var fPath, "Executable files (*.exe;*.bat)|*.exe;*.bat|All files (*.*)|*.*")) return;
                var me = _miscExeSet.Items[k];
                me.Location = fPath;
                _miscExeSet.Items[k] = me;
                _config.Save(_miscExeSet);
            };
            launch.Click += (s, e) => {
                var fPath = _miscExeSet.Items[k];
                if(fPath.Location != null || fPath.Location != string.Empty) {
                    if(File.Exists(fPath.Location)) {
                        if (fPath.KillCommand != null && fPath.KillCommand != string.Empty) {
                            Process.Start("cmd.exe", $"/c {fPath.KillCommand}");
                            Thread.Sleep(100);
                        }

                        if(fPath.Location.EndsWith(".bat")) {
                            _process = _utils.ExecuteCommandLineFile(fPath.Location);
                            return;
                        }

                        _utils.StartExecutable(fPath.Location, false);
                        return;
                    }
                }
                locate.PerformClick();
            };

            kill.Click += (s, e) => {
                var fPath = _miscExeSet.Items[k];
                if(fPath.KillCommand != null && fPath.KillCommand != string.Empty) Process.Start("cmd.exe", $"/c {fPath.KillCommand}");
            };

            launcher.DropDown.Items.AddRange([locate, launch, kill]);

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
