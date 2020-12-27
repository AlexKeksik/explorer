using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;//для Process
using System.Threading;
using explorer.Properties;

namespace explorer
{
    public partial class Form1 : Form
    {
        functions fun = new functions();
        bool search = false;

        string reg;
        string path;

        Regex file;
        DirectoryInfo dr;

        Thread myThread;
        public Form1()
        {

            InitializeComponent();
            tb_path.Text = Settings.Default["Path"].ToString();
            tb_reg.Text = Settings.Default["Reg"].ToString();

            this.DoubleBuffered = true;

            fun.l_all_files = l_all_files;
            fun.l_search_files = l_search_file;
            fun.l_file = l_path_file;

            fun.lb_result = lb_results;
            fun.lb_path = lb_path;
            fun.l_time = l_time;

            l_all_files.Text = "";
            l_search_file.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            fun.c_Press++;
            if (fun.c_Press > 1)
            {
                fun.c_Press = 0;
            }

            reg = tb_reg.Text;
            path = tb_path.Text;

            file = new Regex(reg);
            dr = new DirectoryInfo(path);
            fun._dr = dr;

            myThread = new Thread(() =>
            fun.Search_time(file));
            if (search == false)
            {

                if (fun.c_Press == 1)
                {
                    fun.obnyl = true;
                }

                search = true;
                fun.search = search;

                myThread.Start();
                fun.IsPausePress = true;

                button1.Text = "Пауза";
                fun.s_text = button1.Text;

            }

            else
            {
                button1.Text = "Поиск";
                fun.s_text = button1.Text;

                search = false;
                fun.search = search;
                fun.IsPausePress = false;
                myThread.Abort();



            }

            Settings.Default["Reg"] = tb_reg.Text;
            Settings.Default["Path"] = tb_path.Text;
            Settings.Default.Save();

        }



        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog DirDialog = new FolderBrowserDialog
            {
                Description = "Выбор директории",
                SelectedPath = @"C:\"
            };

            if (DirDialog.ShowDialog() == DialogResult.OK)
            {
                tb_path.Text = DirDialog.SelectedPath;
            }

        }

        private void lb_results_DoubleClick(object sender, EventArgs e)
        {
            Console.WriteLine(lb_results.SelectedItem.ToString());
            Console.WriteLine(lb_results.SelectedIndex.ToString());

            int s = Convert.ToInt32(lb_results.SelectedIndex.ToString());
            lb_path.SelectedIndex = s;

            Process.Start(lb_path.SelectedItem.ToString());
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default["Reg"] = tb_reg.Text;
            Settings.Default["Path"] = tb_path.Text;
            Settings.Default.Save();
        }

        private void b_clear_all_Click(object sender, EventArgs e)
        {
            tb_reg.Text = "";
            tb_path.Text = "";
            lb_results.Items.Clear();
            lb_path.Items.Clear();

        }

        private void b_clear_list_Click(object sender, EventArgs e)
        {
            lb_results.Items.Clear();
            lb_path.Items.Clear();
            fun.i = 0;
            fun.search_file = 0;
            fun.all_files = 0;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default["Reg"] = tb_reg.Text;
            Settings.Default["Path"] = tb_path.Text;
            Settings.Default.Save();
        }

        private void tb_path_TextChanged(object sender, EventArgs e)
        {
            fun.c_Press = -1;
            fun.i = 0;
            fun.IsPausePress = false;
            search = false;
            button1.Text = "Начать поиск";
        }

        private void tb_reg_TextChanged(object sender, EventArgs e)
        {
            fun.c_Press = -1;
            fun.i = 0;
            fun.IsPausePress = false;
            search = false;
            button1.Text = "Начать поиск";
        }
    }
}
