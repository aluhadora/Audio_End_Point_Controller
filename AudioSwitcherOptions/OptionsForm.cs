using System;
using System.Windows.Forms;

namespace AudioSwitcherOptions
{
  public partial class OptionsForm : Form
  {
    readonly RegistryEditor _registryEditor = new RegistryEditor();
    private const string Options = "Options";
    private const string ID = "ID";

    public OptionsForm()
    {
      InitializeComponent();
      optionsTextBox.Text = _registryEditor.Read(Options) ?? string.Empty;
      idTextBox.Text = _registryEditor.Read(ID) ?? string.Empty;
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
      _registryEditor.Write(Options, optionsTextBox.Text);
      _registryEditor.Write(ID, idTextBox.Text);
    }

    private void SwitchButton_Click(object sender, EventArgs e)
    {
      var ids = optionsTextBox.Text.Split(',');
      Program.SetAudioDeviceNext(ids, Array.IndexOf(ids, idTextBox.Text));
      idTextBox.Text = _registryEditor.Read(ID) ?? string.Empty;
    }
  }
}
