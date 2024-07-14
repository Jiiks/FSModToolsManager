using FSModToolsManager.Services;

namespace FSModToolsManager.Controls;
internal class MenuSetLinks : UcToolStripItem {
    private IConfig _config;
    private Utils.Utils _utils;
    private LinkSet _linkSet;

    public MenuSetLinks(IConfig cfg, Utils.Utils utils, LinkSet linkSet) {
        Text = linkSet.Category;
        _config = cfg;
        _utils = utils;
        _linkSet = linkSet;

        foreach (var (k, v) in _linkSet.Links) {
            var linkBtn = new UcToolStripItem(k);
            linkBtn.Click += (s, e) => _utils.OpenUrl(v);
            DropDown.Items.Add(linkBtn);
        }

    }
}
