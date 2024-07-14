using FSModToolsManager.Core;
using System.Diagnostics;

namespace FSModToolsManager.Controls;
internal class UcDragDrop : GroupBox {

    public UcDragDrop(Tool tool) {
        Text = tool.Name;

        //Absolute size for now
        Width = 100;
        Height = 100;

        var ddHandler = new Panel() {
            AllowDrop = true,
            Dock = DockStyle.Fill
        };

        ddHandler.DragEnter += DdHandler_DragEnter;
        ddHandler.DragLeave += DdHandler_DragLeave;
        ddHandler.DragDrop += DdHandler_DragDrop;

        Controls.Add(ddHandler);
    }

    private void DdHandler_DragDrop(object? sender, DragEventArgs e) {
        var files = (string[])e.Data.GetData(DataFormats.FileDrop);
        foreach (var file in files) Debug.WriteLine(file);
    }

    private void DdHandler_DragLeave(object? sender, EventArgs e) {
        
    }

    private void DdHandler_DragEnter(object? sender, DragEventArgs e) {
        if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
    }
}
