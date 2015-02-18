using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AudioSwitcher
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {

      // Set newDeviceID here, by some means. A common scenario
      // is to save the value using the registry so it can be toggled.

      Process.Start(new ProcessStartInfo("EndPointController.exe", textBox1.Text)
      {
        UseShellExecute = false,
        RedirectStandardOutput = true,
        CreateNoWindow = true
      });
    }
  }
}
