
namespace explorer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.tb_reg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lb_results = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.l_all_files = new System.Windows.Forms.Label();
            this.l_search_file = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.l_path_file = new System.Windows.Forms.Label();
            this.l_time = new System.Windows.Forms.Label();
            this.lb_path = new System.Windows.Forms.ListBox();
            this.b_clear_all = new System.Windows.Forms.Button();
            this.b_clear_list = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Начать поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Где искать:";
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(84, 9);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(113, 20);
            this.tb_path.TabIndex = 2;
            this.tb_path.TextChanged += new System.EventHandler(this.tb_path_TextChanged);
            // 
            // tb_reg
            // 
            this.tb_reg.Location = new System.Drawing.Point(117, 42);
            this.tb_reg.Name = "tb_reg";
            this.tb_reg.Size = new System.Drawing.Size(461, 20);
            this.tb_reg.TabIndex = 4;
            this.tb_reg.TextChanged += new System.EventHandler(this.tb_reg_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Regex выражение";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(203, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Обзор";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb_results
            // 
            this.lb_results.FormattingEnabled = true;
            this.lb_results.Location = new System.Drawing.Point(237, 133);
            this.lb_results.Name = "lb_results";
            this.lb_results.Size = new System.Drawing.Size(551, 303);
            this.lb_results.TabIndex = 6;
            this.lb_results.DoubleClick += new System.EventHandler(this.lb_results_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Общее колчичество файлов:";
            // 
            // l_all_files
            // 
            this.l_all_files.AutoSize = true;
            this.l_all_files.Location = new System.Drawing.Point(14, 140);
            this.l_all_files.Name = "l_all_files";
            this.l_all_files.Size = new System.Drawing.Size(25, 13);
            this.l_all_files.TabIndex = 8;
            this.l_all_files.Text = "------";
            // 
            // l_search_file
            // 
            this.l_search_file.AutoSize = true;
            this.l_search_file.Location = new System.Drawing.Point(12, 185);
            this.l_search_file.Name = "l_search_file";
            this.l_search_file.Size = new System.Drawing.Size(28, 13);
            this.l_search_file.TabIndex = 10;
            this.l_search_file.Text = "-------";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Найденных файлов:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Прошло времени:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Текущая директория поиска файла:";
            // 
            // l_path_file
            // 
            this.l_path_file.AutoSize = true;
            this.l_path_file.Location = new System.Drawing.Point(16, 104);
            this.l_path_file.Name = "l_path_file";
            this.l_path_file.Size = new System.Drawing.Size(19, 13);
            this.l_path_file.TabIndex = 13;
            this.l_path_file.Text = "----";
            // 
            // l_time
            // 
            this.l_time.AutoSize = true;
            this.l_time.Location = new System.Drawing.Point(15, 233);
            this.l_time.Name = "l_time";
            this.l_time.Size = new System.Drawing.Size(22, 13);
            this.l_time.TabIndex = 14;
            this.l_time.Text = "-----";
            // 
            // lb_path
            // 
            this.lb_path.FormattingEnabled = true;
            this.lb_path.Location = new System.Drawing.Point(287, 162);
            this.lb_path.Name = "lb_path";
            this.lb_path.Size = new System.Drawing.Size(109, 43);
            this.lb_path.TabIndex = 15;
            this.lb_path.Visible = false;
            // 
            // b_clear_all
            // 
            this.b_clear_all.Location = new System.Drawing.Point(638, 42);
            this.b_clear_all.Name = "b_clear_all";
            this.b_clear_all.Size = new System.Drawing.Size(150, 23);
            this.b_clear_all.TabIndex = 16;
            this.b_clear_all.Text = "Очистить все";
            this.b_clear_all.UseVisualStyleBackColor = true;
            this.b_clear_all.Click += new System.EventHandler(this.b_clear_all_Click);
            // 
            // b_clear_list
            // 
            this.b_clear_list.Location = new System.Drawing.Point(638, 71);
            this.b_clear_list.Name = "b_clear_list";
            this.b_clear_list.Size = new System.Drawing.Size(150, 23);
            this.b_clear_list.TabIndex = 17;
            this.b_clear_list.Text = "Очистить список";
            this.b_clear_list.UseVisualStyleBackColor = true;
            this.b_clear_list.Click += new System.EventHandler(this.b_clear_list_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_clear_list);
            this.Controls.Add(this.b_clear_all);
            this.Controls.Add(this.l_time);
            this.Controls.Add(this.l_path_file);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.l_search_file);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.l_all_files);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_results);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tb_reg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_path);
            this.Name = "Form1";
            this.Text = "Поиск файлов по Reg выражениям ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.TextBox tb_reg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lb_results;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label l_all_files;
        public System.Windows.Forms.Label l_search_file;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label l_path_file;
        private System.Windows.Forms.Label l_time;
        private System.Windows.Forms.ListBox lb_path;
        private System.Windows.Forms.Button b_clear_all;
        private System.Windows.Forms.Button b_clear_list;
    }
}

