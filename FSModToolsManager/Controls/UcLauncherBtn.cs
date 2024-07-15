using FSModToolsManager.Services;
using FSModToolsManager.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSModToolsManager.Controls;
internal class UcLauncherBtn : Label {

    private string _id;
    private MiscExeInfo _miscExe;
    private Utils.Utils _utils;
    private IConfig _config;

    public UcLauncherBtn(string id, MiscExeInfo miscExe, Utils.Utils utils, IConfig config) {
        _id = id;
        _utils = utils;
        _config = config;
        _miscExe = miscExe;
        Height = 58;
        Width = 58;
        Cursor = Cursors.Hand;
        if (miscExe.Icon != null && miscExe.Icon != string.Empty) {
            Image = new Bitmap(Image.FromFile(@$"Images/{miscExe.Icon}"), Size);
        } else {
            Text = miscExe.Tag;
        }

        BorderStyle = BorderStyle.FixedSingle;
        
    }

    private bool _mouseOver = false;
    protected override void OnMouseEnter(EventArgs e) {
        base.OnMouseEnter(e);
        _mouseOver = true;
        Invalidate();
    }

    protected override void OnMouseLeave(EventArgs e) {
        base.OnMouseLeave(e); 
        _mouseOver = false;
        Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e) {
        base.OnPaint(e);
        var gfx = e.Graphics;
        if (_mouseOver) {
            var b = new SolidBrush(Color.FromArgb(50, 255, 255, 255));
           gfx.FillRectangle(b, 1, 1, Width - 2, Height - 2);
        }
    }

    protected override void OnClick(EventArgs e) {
        var me = _config.GetMiscExeInfo(_id);
        if (me == null) return;
        _miscExe = me.Value;

        if (!File.Exists(_miscExe.Location)) return;

        if(_miscExe.KillCommand != null && _miscExe.KillCommand != string.Empty) {
            Process.Start("cmd.exe", $"/c {_miscExe.KillCommand}");
            Thread.Sleep(100);
        }

        if(_miscExe.Location.EndsWith(".bat")) {
            _utils.ExecuteCommandLineFile(_miscExe.Location);
            return;
        }

        _utils.StartExecutable(_miscExe.Location, false);
    }

}
