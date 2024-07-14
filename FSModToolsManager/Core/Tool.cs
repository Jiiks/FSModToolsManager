using FSModToolsManager.Services;
using System.Text.Json.Serialization;

namespace FSModToolsManager.Core;
public class Tool {
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("location")]
    public string Location { get; set; }
    [JsonPropertyName("download")]
    public string Download { get; set; }
    [JsonPropertyName("type")]
    public EToolType ToolType { get; set; }
    [JsonPropertyName("display")]
    public bool DisplayInMain { get; set; }

    [JsonIgnore]
    public string Id { get; set; }
    [JsonIgnore]
    public Control Ctrl { get; set; }

    public Tool Run(IConfig cfg, Utils.Utils utils) {
        if (Location == null || Location == string.Empty) {
            if (!Locate(cfg, utils)) return this;
        }

        if (!File.Exists(Location)) {
            if (!Locate(cfg, utils)) return this;
        }
        utils.StartTool(this);
        return this;
    }

    public bool Locate(IConfig cfg, Utils.Utils utils) {
        if (!utils.Ofd(out var fPath)) return false;
        Location = fPath;
        cfg.Save(this);
        return true;
    }

    public void DownloadTool(Utils.Utils utils) {
        utils.DownloadTool(this);
    }

    public void Save(IConfig cfg) {
        cfg.Save(this);
    }
}

public enum EToolType {
    Default,
    DragDrop
}