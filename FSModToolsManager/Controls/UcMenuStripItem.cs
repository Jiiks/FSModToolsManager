namespace FSModToolsManager.Controls;
internal class UcToolStripItem : ToolStripMenuItem {

    private Color _backColor = Color.FromArgb(30, 30, 30);
    private Color _foreColor = Color.FromArgb(174, 174, 174);
    private Color _backHoverColor = Color.FromArgb(48, 48, 48);
    private Color _foreHoverColor = Color.FromArgb(255, 255, 255);

    public UcToolStripItem() {
        BackColor = _backColor;
        ForeColor = _foreColor;

        DropDown.ItemClicked += DropDown_ItemClicked;
        DropDown.Closing += DropDown_Closing;
    }

    public UcToolStripItem(string text) {
        Text = text;
        BackColor = _backColor;
        ForeColor = _foreColor;

        DropDown.ItemClicked += DropDown_ItemClicked;
        DropDown.Closing += DropDown_Closing;
    }

    private UcToolStripItem? _lastClickedItem;
    private void DropDown_Closing(object? sender, ToolStripDropDownClosingEventArgs e) {
        if (e.CloseReason == ToolStripDropDownCloseReason.ItemClicked && _lastClickedItem != null && _lastClickedItem.CheckOnClick) e.Cancel = true;
    }

    private void DropDown_ItemClicked(object? sender, ToolStripItemClickedEventArgs e) {
        if (e.ClickedItem is UcToolStripItem item) _lastClickedItem = item;
    }

    protected override void OnMouseEnter(EventArgs e) {
        base.OnMouseEnter(e);
        BackColor = _backHoverColor;
        ForeColor = _foreHoverColor;
    }

    protected override void OnMouseLeave(EventArgs e) {
        base.OnMouseLeave(e);
        BackColor = _backColor;
        ForeColor = _foreColor;
    }

   


}
