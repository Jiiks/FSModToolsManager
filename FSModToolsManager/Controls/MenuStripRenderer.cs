namespace FSModToolsManager.Controls;

internal class UcToolStripProfessionalRenderer : ToolStripProfessionalRenderer {
    public UcToolStripProfessionalRenderer() : base(new UcProfessionalColorTable()) { }
}
internal class UcProfessionalColorTable : ProfessionalColorTable {

    private Color _backColor = Color.FromArgb(30, 30, 30);
    private Color _foreColor = Color.FromArgb(174, 174, 174);
    private Color _backHoverColor = Color.FromArgb(48, 48, 48);
    private Color _foreHoverColor = Color.FromArgb(255, 255, 255);

    public override Color MenuItemBorder => Color.Teal;

    public override Color MenuBorder => Color.Teal;

    public override Color MenuItemSelected => _backHoverColor;
    public override Color MenuItemSelectedGradientBegin => _backColor;
    public override Color MenuItemSelectedGradientEnd => _backColor;

    public override Color MenuItemPressedGradientBegin => _backHoverColor;
    public override Color MenuItemPressedGradientEnd => _backHoverColor;

    public override Color ToolStripDropDownBackground => _backColor;
    public override Color CheckBackground => _backColor;
    public override Color ImageMarginGradientBegin => _backColor;
    public override Color ImageMarginGradientEnd => _backColor;
    public override Color ImageMarginGradientMiddle => _backColor;

}
