using FSModToolsManager.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FSModToolsManager.Services;

public interface IConfig {
    public void Load();
    public void Save(Tool tool);
    public void Save(MiscExe miscExeSet);

    public Exception? GetLastError();

    public IDictionary<string, Tool> GetTools();
    public IEnumerable<LinkSet> GetLinks();
    public IEnumerable<MiscExe> GetMiscExeSets();
}

public struct MiscExe {
    [JsonPropertyName("id")]
    public string Id { get; set; }
    [JsonPropertyName("title")]
    public string Title { get; set; }
    [JsonPropertyName("items")]
    public IDictionary<string, string> Items { get; set; }

}

public struct LinkSet {
    [JsonPropertyName("category")]
    public string Category { get; set; }
    [JsonPropertyName("links")]
    public Dictionary<string, string> Links { get; set; }
}

internal struct Conf {
    [JsonPropertyName("tools")]
    public Dictionary<string, Tool> Tools {  get; set; }
    [JsonPropertyName("links")]
    public List<LinkSet> Links { get; set; }
    [JsonPropertyName("miscexe")]
    public List<MiscExe> MiscExecutables { get; set; }
    [JsonPropertyName("customlinks")]
    public List<LinkSet> CustomLinks { get; set; }
    [JsonPropertyName("customexes")]
    public List<MiscExe> CustomMiscExecutables { get; set; }
}

internal class Config : IConfig {

    private Utils.Utils _utils;
    private Conf _conf;
    private Exception? _lastError = null;
    public Exception? GetLastError() => _lastError;

    public IDictionary<string, Tool> GetTools() => _conf.Tools;
    public IEnumerable<LinkSet> GetLinks() => _conf.Links;
    public IEnumerable<MiscExe> GetMiscExeSets() => _conf.MiscExecutables;

    public Tool GetTool(string id) => _conf.Tools[id];

    public Config(Utils.Utils utils) {
        _utils = utils;
        try {
            utils.SanityChecks();
        } catch (Exception e) {
            _lastError = e;
            utils.DisplayError(e);
        }
    }

    public void Load() {
        _conf = _utils.DeserializeFromFile<Conf>("config.json");
        if(File.Exists("config.user.json")) {
            var userConf = _utils.DeserializeFromFile<Conf>("config.user.json");
            foreach(var(k, v) in userConf.Tools) {
                _conf.Tools[k] = v;
            }


            var uLinks = new List<LinkSet>();
            foreach(var linkSet in userConf.Links) {
                var exists = _conf.Links.FirstOrDefault(l => l.Category == linkSet.Category);
                if (exists.Equals(default(LinkSet))) {
                    uLinks.Add(linkSet);
                    continue;
                }

                foreach(var (k, v) in linkSet.Links) {
                    exists.Links[k] = v;
                }

                uLinks.Add(exists);
            }
            _conf.Links = uLinks;

            var uExecutables = new List<MiscExe>();
            foreach(var miscExeSet in userConf.MiscExecutables) {
                var exists = _conf.MiscExecutables.FirstOrDefault(m => m.Id == miscExeSet.Id);
                if(exists.Equals(default(MiscExe))) {
                    uExecutables.Add(miscExeSet);
                    continue;
                }
                
                foreach(var(k, v) in miscExeSet.Items) {
                    exists.Items[k] = v;
                }

                uExecutables.Add(exists);
            }
            _conf.MiscExecutables = uExecutables;
        }

        foreach (var (k, v) in _conf.Tools) {
            var t = _conf.Tools[k];
            t.Id = k;
            _conf.Tools[k] = t;
        }

        LoadCustoms();
    }

    private void LoadCustoms() { }

    public void Save(Tool tool) {
        _conf.Tools[tool.Id] = tool;
        _utils.SerializeToFile("config.user.json", _conf);
    }

    public void Save(MiscExe miscExeSet) {
        var set = _conf.MiscExecutables.Find(m => m.Id == miscExeSet.Id);
        var idx = _conf.MiscExecutables.IndexOf(set);
        _conf.MiscExecutables[idx] = miscExeSet;
        _utils.SerializeToFile("config.user.json", _conf);
    }

}
