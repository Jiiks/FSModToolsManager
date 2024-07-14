using FSModToolsManager.Core;
using FSModToolsManager.Properties;
using System.Diagnostics;
using System.Security.Policy;

namespace FSModToolsManager.Controls;
internal class UcDragDrop : FlowLayoutPanel {

    private Panel _ddHandler;
    private Tool _tool;

    public UcDragDrop(Tool tool) {
        _tool = tool;
        Text = tool.Name;
        //RowCount = 2;
        ///ColumnCount = 1;
  
        Margin = new Padding(0, 0, 0, 0);
        Padding = new Padding(0, 0, 0, 0);
        

        Controls.Add(new Label() { Text = tool.Name, Height = 30, ForeColor = Color.FromArgb(157,157,157) });
        BorderStyle = BorderStyle.FixedSingle;

        //Absolute size for now
        Width = 100;
        Height = 130;

        var ddHandler = new Panel() {
            AllowDrop = true,
            Width = 90,
            Height = 90
        };

        ddHandler.BackgroundImage = Resources.dd_gray;
        ddHandler.BackgroundImageLayout = ImageLayout.Stretch;

        ddHandler.DragEnter += DdHandler_DragEnter;
        ddHandler.DragLeave += DdHandler_DragLeave;
        ddHandler.DragDrop += DdHandler_DragDrop;

        Controls.Add(ddHandler);
        _ddHandler = ddHandler;
    }

    private void DdHandler_DragDrop(object? sender, DragEventArgs e) {
        var files = (string[])e.Data.GetData(DataFormats.FileDrop);
        //foreach (var file in files) Debug.WriteLine(file);
        try {
            Process.Start(new ProcessStartInfo(_tool.Location, files) { UseShellExecute = true });
        } catch (Exception ex) { } // TODO THIS IS ALL TEMPORARY
    }

    private void DdHandler_DragLeave(object? sender, EventArgs e) {
        _ddHandler.BackgroundImage = Resources.dd_gray;
    }

    private void DdHandler_DragEnter(object? sender, DragEventArgs e) {
        if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
            e.Effect = DragDropEffects.Copy;
            _ddHandler.BackgroundImage = Resources.dd_white;
        }
    }
}
