using FSModToolsManager.Core;
using FSModToolsManager.Services;

namespace FSModToolsManager.Controls;
internal class UcToolBtn : Button {

    private Color _backColor = Color.FromArgb(30, 30, 30);
    private Color _foreColor = Color.FromArgb(174, 174, 174);
    private Color _backHoverColor = Color.FromArgb(48, 48, 48);
    private Color _foreHoverColor = Color.FromArgb(255, 255, 255);

    private Tool _tool;
    private Utils.Utils _utils;
    private IConfig _cfg;

    public UcToolBtn(Tool tool, Utils.Utils utils, IConfig cfg) {
        _tool = tool;
        _utils = utils;
        _cfg = cfg;
        Text = tool.Name;
        Height = 50;
        Dock = DockStyle.Fill;
        MaximumSize = new Size(1000, 50);
        BackColor = _backColor;
        ForeColor = _foreColor;
        FlatStyle = FlatStyle.Flat;
    }

    protected override void OnMouseEnter(EventArgs e) {
        base.OnMouseEnter(e);
        BackColor = _backHoverColor;
        ForeColor = _foreHoverColor;
    }

    protected override void OnMouseLeave(EventArgs e) {
        base.OnMouseEnter(e);
        BackColor = _backColor;
        ForeColor = _foreColor;
    }

    protected override void OnClick(EventArgs e) {
        base.OnClick(e);
        _tool.Run(_cfg, _utils);
    }
}
