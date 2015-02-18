using System;
using System.Windows.Forms;
using RegEdit;

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
  }
}
