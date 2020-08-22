using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Free2D
{
    public partial class Form1 : Form
    {
        GlobalVars gv = new GlobalVars();
        KeyInputs ki = new KeyInputs();
        public Form1()
        {

            InitializeComponent();
            this.Size = new Size(1080, 720);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadText.Multiline = true;
            loadText.AcceptsTab = true;

            startText.Multiline = true;
            startText.AcceptsTab = true;

            drawText.Multiline = true;
            drawText.AcceptsTab = true;

            updateText.Multiline = true;
            updateText.AcceptsTab = true;
            string[] dirs = Directory.GetDirectories("Projects/");
            foreach(string d in dirs)
            {
                flatComboBox1.Items.Add(d);
            }
        }

        private void formSkin1_Click(object sender, EventArgs e)
        {
            
        }

        private void flatMini1_Click(object sender, EventArgs e)
        {

        }

        private void flatLabel3_Click(object sender, EventArgs e)
        {

        }

        private void flatLabel4_Click(object sender, EventArgs e)
        {

        }

        private void flatLabel5_Click(object sender, EventArgs e)
        {

        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            SaveProject();
            string title = String.Format("\"{0}\"", gameName.Text);
            string dir = String.Format("Projects/{0}/Build/", gameName.Text);
            File.Copy("Free2DEngine.dll", dir + "Free2DEngine.dll",true);
            File.Copy("OpenTK.dll", dir + "OpenTK.dll", true);
            File.Copy("NAudio.dll", dir + "NAudio.dll", true);

            CSharpCodeProvider csc = new CSharpCodeProvider(new Dictionary<string, string>() { { "CompilerVersion", "v4.0" } });
            CompilerParameters parameters = new CompilerParameters(new[] {"mscorlib.dll", "System.Core.dll","Free2DEngine.dll", "OpenTK.dll", "NAudio.dll" },dir+gameName.Text+".exe",true);
            parameters.GenerateExecutable = true;
            CompilerResults results = csc.CompileAssemblyFromSource(parameters, ("using System;using System.Collections.Generic;using System.Linq;" +
                "" +
                "namespace Free2D{" +
                "class Program{" +
                "static void Main(string[] args){" +
                "new Game();" +
                "}" +
                "}" +
                "" +
                "public class Game : Free2DEngine{" +
                 "public Game() : base(412,412," + title + "," + roomID.Value.ToString() + "){}" +
                 "" + gv.GetValue() +
                "public override void LoadContent(){" +
                "" + loadText.Text +
                "}" +
                "public override void Start(){" +
                "" + startText.Text +
                "}" +
                "public override void Update(GameTime gameTime, int RoomID){" +
                "" + updateText.Text +
                "}" +
                "public override void Draw(GameTime gameTime, int RoomID){" +
                "" + drawText.Text +
                "}" +
                "public override void OnKeyUp(string key){" +
                "" + ki.GetValueUp() +
                "}" +
                "public override void OnKeyDown(string key){" +
                "" + ki.GetValueDown() +
                "}" +
                "}" +
                "}" +
                ""));
            if (results.Errors.HasErrors)
            {
                results.Errors.Cast<CompilerError>().ToList().ForEach(error => { MessageBox.Show("Fatal Error: " + error); });
            }
            else
            {
                new Thread(RunBuild).Start(dir + gameName.Text + ".exe");
                
            }
        }
        void RunBuild(object dir)
        {
            Thread.Sleep(300);
            Process.Start(@""+Application.StartupPath +"\\"+ (string)dir);
        }
        private void flatButton2_Click(object sender, EventArgs e)
        {
            gv.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void flatButton3_Click(object sender, EventArgs e)
        {
            ki.Show();
        }

        private void flatButton4_Click(object sender, EventArgs e)
        {
            SaveProject();
        }

        public void SaveProject()
        {
            string title = String.Format("{0}", gameName.Text);
            if (Directory.Exists("Projects/" + title))
            {

            }
            else
            {
                Directory.CreateDirectory("Projects/" + title);
                Directory.CreateDirectory("Projects/" + title+ "/Build");
            }
            using (StreamWriter sw = new StreamWriter("Projects/" + title + "/load.txt"))
            {
                sw.WriteLine(loadText.Text);
            }
            using (StreamWriter sw = new StreamWriter("Projects/" + title + "/start.txt"))
            {
                sw.WriteLine(startText.Text);
            }
            using (StreamWriter sw = new StreamWriter("Projects/" + title + "/draw.txt"))
            {
                sw.WriteLine(drawText.Text);
            }
            using (StreamWriter sw = new StreamWriter("Projects/" + title + "/update.txt"))
            {
                sw.WriteLine(updateText.Text);
            }
            using (StreamWriter sw = new StreamWriter("Projects/" + title + "/global.txt"))
            {
                sw.WriteLine(gv.GetValue());
            }
            using (StreamWriter sw = new StreamWriter("Projects/" + title + "/keydown.txt"))
            {
                sw.WriteLine(ki.GetValueDown());
            }
            using (StreamWriter sw = new StreamWriter("Projects/" + title + "/keyup.txt"))
            {
                sw.WriteLine(ki.GetValueUp());
            }
        }

        private void flatButton5_Click(object sender, EventArgs e)
        {
            try
            {
                gameName.Text = flatComboBox1.Text.Split('/')[1];
                using (StreamReader sw = new StreamReader(flatComboBox1.Text + "/load.txt"))
                {
                    loadText.Text = sw.ReadToEnd();
                }
                using (StreamReader sw = new StreamReader(flatComboBox1.Text + "/start.txt"))
                {
                    startText.Text = sw.ReadToEnd();
                }
                using (StreamReader sw = new StreamReader(flatComboBox1.Text + "/draw.txt"))
                {
                    drawText.Text = sw.ReadToEnd();
                }
                using (StreamReader sw = new StreamReader(flatComboBox1.Text + "/update.txt"))
                {
                    updateText.Text = sw.ReadToEnd();
                }
                using (StreamReader sw = new StreamReader(flatComboBox1.Text + "/global.txt"))
                {
                    gv.SetValue(sw.ReadToEnd());
                }
                using (StreamReader sw = new StreamReader(flatComboBox1.Text + "/keydown.txt"))
                {
                    ki.SetValueDown(sw.ReadToEnd());
                }
                using (StreamReader sw = new StreamReader(flatComboBox1.Text + "/keyup.txt"))
                {
                    ki.SetValueUp(sw.ReadToEnd());
                }
            }
            catch
            {
                MessageBox.Show("Please select a project to load first!");
            }
        }
    }
}
