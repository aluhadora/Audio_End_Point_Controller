using System;
using System.Diagnostics;
using System.Linq;
using AudioSwitcherOptions;
using RegEdit;
using System.Windows.Forms;

namespace AudioSwitch
{
  static class Program
  {
    private const string ID = "ID";
    private const string Options = "Options";

    static readonly RegistryEditor RegistryEditor = new RegistryEditor(false);
    
    [STAThread]
    static void Main(string[] args)
    {
      if (args.Any(x => x.ToLower().Contains("options")))
      {
        StartOptions();
        return;
      }

      string options = RegistryEditor.Read(Options) ?? string.Empty;
      options.Replace(" ", string.Empty);
      var ids = options.Split(',');

      var currentID = RegistryEditor.Read(ID) ?? string.Empty;

      if (options != string.Empty)
      {
        if (currentID == string.Empty)
          currentID = ids[0];

        if (ids.Contains(currentID))
        {
          SetAudioDeviceNext(ids, Array.IndexOf(ids, currentID));
        }
        else
        {
          StartOptions();
        }
      }
      else
      {
        StartOptions();
      }
    }

    public static void SetAudioDeviceNext(string[] ids, int index)
    {
      index++;
      if (index >= ids.Count())
        index = 0;

      SetCurrentAudioDevice(ids[index]);

      RegistryEditor.Write(ID, ids[index]);
    }

    private static void SetCurrentAudioDevice(string id)
    {
      Process.Start(new ProcessStartInfo("EndPointController.exe", id)
      {
        UseShellExecute = false,
        RedirectStandardOutput = true,
        CreateNoWindow = true
      });
    }

    private static void StartOptions()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new OptionsForm());
    }
  }
}
