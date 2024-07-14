using FSModToolsManager.Core;
using System.Diagnostics;
using System.Text.Json;

namespace FSModToolsManager.Utils;
public class Utils {

    private const string TOOL_DB_URL = "http://soulsmodding.wikidot.com/tool:main";

    public void SanityChecks() {
        // Check that config file exists
        if (!File.Exists("config.json")) throw new Exception("config.json does not exist!");

        // Check that config is good
        DeserializeFromFile<dynamic>("config.json");

        // Check that user config is good
        if (File.Exists("config.user.json")) DeserializeFromFile<dynamic>("config.user.json");
    }

    public void DisplayError(string msg) {
        MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    public void DisplayError(Exception e) => DisplayError($"Source: {e.Source}{Environment.NewLine}Message: {e.Message}{Environment.NewLine}===== StackTrace ====={Environment.NewLine}{e.StackTrace}");

    private static JsonSerializerOptions _jsonSerializerOptions = new() { WriteIndented = true };
    public T DeserializeFromFile<T>(string path) => JsonSerializer.Deserialize<T>(File.ReadAllText(path));
    public void SerializeToFile(string path, object o) => File.WriteAllText(path, JsonSerializer.Serialize(o, _jsonSerializerOptions));

    public bool Ofd(out string fPath, string filter = "Executable files (*.exe)|*.exe|All files (*.*)|*.*") {
        var ofd = new OpenFileDialog {
            Filter = filter
        };

        if (ofd.ShowDialog() != DialogResult.OK) {
            fPath = string.Empty;
            return false;
        }

        fPath = ofd.FileName;
        return true;
    }

    public void StartTool(Tool tool) {
        StartExecutable(tool.Location);
    }

    public void DownloadTool(Tool tool) {
        if (tool.Download != null && tool.Download != string.Empty) OpenUrl(tool.Download);
        else OpenUrl(TOOL_DB_URL);
    }

    public void OpenUrl(string url, bool shellExecute = true) {
        Process.Start(new ProcessStartInfo(url) { UseShellExecute = shellExecute });
    }

    public void StartExecutable(string fPath, bool shellExecute = true) {
        Process.Start(new ProcessStartInfo(fPath) { UseShellExecute = shellExecute });
    }

    public Process ExecuteCommandLineFile(string fPath) {
        
        var psInfo = new ProcessStartInfo("cmd.exe", "/c " + Path.GetFileName(fPath));
        psInfo.WorkingDirectory = Path.GetDirectoryName(fPath);

        return Process.Start(psInfo);
    }

}
