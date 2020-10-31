using HexEditorBaseLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEditorGUI
{
    public partial class Form1 : Form
    {

      
        string Path = "";
        List<Label> hexList;
        HexEditor editor;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1920, 1080);
            hexList = new List<Label>();
            editor = new HexEditor();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var l in hexList)
            {
                l.MouseClick += label_Clicked(l);
            }
        }

        private MouseEventHandler label_Clicked(Label l)
        {
            var bytes = editor.HexToByteArray(l.Text);
            MessageBox.Show($"{editor.GetDecimal(bytes)}, {editor.GetBinary(bytes)}");

            return default;
        }

        
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void RunButton_Click_1(object sender, EventArgs e)
        {
            var bytes = editor.GetPathBytes(Path);
            var hex = editor.ConvertToHex(bytes);
            var decimals = editor.GetDecimal(bytes);
            var chars = editor.GetLettersFromHex(hex);
            //gfx.Clear(Color.CornflowerBlue);

            int Row = 30;
            int Column = 200;
            for (int i = 0; i < hex.Length; i += 16)
            {
                for (int z = i; z < (i + 16 < hex.Length ? i + 16 : hex.Length); z++)
                {
                    var l = new Label() { Text = hex[z], Location = new Point(Row + ((z - i) * 30), Column), Size = new Size(30, 30)};
                    hexList.Add(l);
                    this.Controls.Add(l);
                }
                Column += 30;
            }

            Row = 540;
            Column = 200;
            for (int i = 0; i < chars.Length; i += 16)
            {
                for (int z = i; z < (i + 16 < chars.Length ? i + 16 : hex.Length); z++)
                {
                    var l = new Label() { Text = (char.IsControl(chars[z]) ? "." : chars[z].ToString()), Location = new Point(Row + ((z - i) * 30), Column), Size = new Size(30, 30) };
                    this.Controls.Add(l);
                }
                Column += 30;
            }
        }

        private void PathButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Path = openFileDialog1.FileName;
            }
            PathLabel.Text = Path;
        }
    }
}
