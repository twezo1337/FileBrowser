namespace FileBrowser
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxDisks = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.listBoxFolders = new System.Windows.Forms.ListBox();
            this.textBoxFolder = new System.Windows.Forms.TextBox();
            this.buttonUp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLastAccessTime = new System.Windows.Forms.TextBox();
            this.textBoxLastWriteTime = new System.Windows.Forms.TextBox();
            this.textBoxCreationTime = new System.Windows.Forms.TextBox();
            this.textBoxFileSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxNewPath = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCopyTo = new System.Windows.Forms.Button();
            this.buttonMoveTo = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PeachPuff;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1352, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.оПрограммеToolStripMenuItem.ForeColor = System.Drawing.Color.SaddleBrown;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.выходToolStripMenuItem.ForeColor = System.Drawing.Color.SaddleBrown;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(72, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Информация о логических дисках системы";
            // 
            // listBoxDisks
            // 
            this.listBoxDisks.BackColor = System.Drawing.Color.PeachPuff;
            this.listBoxDisks.Font = new System.Drawing.Font("Raleway Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxDisks.ForeColor = System.Drawing.Color.Brown;
            this.listBoxDisks.FormattingEnabled = true;
            this.listBoxDisks.ItemHeight = 18;
            this.listBoxDisks.Location = new System.Drawing.Point(15, 63);
            this.listBoxDisks.Name = "listBoxDisks";
            this.listBoxDisks.Size = new System.Drawing.Size(407, 346);
            this.listBoxDisks.TabIndex = 2;
            this.listBoxDisks.SelectedIndexChanged += new System.EventHandler(this.listBoxDisks_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button1.Location = new System.Drawing.Point(321, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Показать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.BackColor = System.Drawing.Color.White;
            this.buttonDisplay.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDisplay.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonDisplay.Location = new System.Drawing.Point(743, 27);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(96, 30);
            this.buttonDisplay.TabIndex = 5;
            this.buttonDisplay.Text = "Показать";
            this.buttonDisplay.UseVisualStyleBackColor = false;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.BackColor = System.Drawing.Color.PeachPuff;
            this.listBoxFiles.Font = new System.Drawing.Font("Raleway Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxFiles.ForeColor = System.Drawing.Color.Brown;
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 18;
            this.listBoxFiles.Location = new System.Drawing.Point(6, 112);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(197, 202);
            this.listBoxFiles.TabIndex = 6;
            this.listBoxFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxFiles_SelectedIndexChanged);
            // 
            // listBoxFolders
            // 
            this.listBoxFolders.BackColor = System.Drawing.Color.PeachPuff;
            this.listBoxFolders.Font = new System.Drawing.Font("Raleway Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxFolders.ForeColor = System.Drawing.Color.Brown;
            this.listBoxFolders.FormattingEnabled = true;
            this.listBoxFolders.ItemHeight = 18;
            this.listBoxFolders.Location = new System.Drawing.Point(215, 112);
            this.listBoxFolders.Name = "listBoxFolders";
            this.listBoxFolders.Size = new System.Drawing.Size(197, 202);
            this.listBoxFolders.TabIndex = 7;
            this.listBoxFolders.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // textBoxFolder
            // 
            this.textBoxFolder.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxFolder.Font = new System.Drawing.Font("Raleway Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFolder.ForeColor = System.Drawing.Color.Brown;
            this.textBoxFolder.Location = new System.Drawing.Point(6, 48);
            this.textBoxFolder.Name = "textBoxFolder";
            this.textBoxFolder.Size = new System.Drawing.Size(386, 23);
            this.textBoxFolder.TabIndex = 8;
            this.textBoxFolder.TextChanged += new System.EventHandler(this.textBoxFolder_TextChanged);
            // 
            // buttonUp
            // 
            this.buttonUp.BackColor = System.Drawing.Color.White;
            this.buttonUp.Location = new System.Drawing.Point(296, 14);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(96, 28);
            this.buttonUp.TabIndex = 9;
            this.buttonUp.Text = "Вверх";
            this.buttonUp.UseVisualStyleBackColor = false;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxLastAccessTime);
            this.groupBox1.Controls.Add(this.textBoxLastWriteTime);
            this.groupBox1.Controls.Add(this.textBoxCreationTime);
            this.groupBox1.Controls.Add(this.textBoxFileSize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxFileName);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Location = new System.Drawing.Point(875, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 182);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Детальная информация о выбранном файле";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Время последнего доступа";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Время последнего изменения";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Время создания";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Размер";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxLastAccessTime
            // 
            this.textBoxLastAccessTime.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxLastAccessTime.Font = new System.Drawing.Font("Raleway Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLastAccessTime.ForeColor = System.Drawing.Color.Brown;
            this.textBoxLastAccessTime.Location = new System.Drawing.Point(245, 138);
            this.textBoxLastAccessTime.Name = "textBoxLastAccessTime";
            this.textBoxLastAccessTime.Size = new System.Drawing.Size(205, 23);
            this.textBoxLastAccessTime.TabIndex = 16;
            // 
            // textBoxLastWriteTime
            // 
            this.textBoxLastWriteTime.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxLastWriteTime.Font = new System.Drawing.Font("Raleway Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLastWriteTime.ForeColor = System.Drawing.Color.Brown;
            this.textBoxLastWriteTime.Location = new System.Drawing.Point(16, 138);
            this.textBoxLastWriteTime.Name = "textBoxLastWriteTime";
            this.textBoxLastWriteTime.Size = new System.Drawing.Size(205, 23);
            this.textBoxLastWriteTime.TabIndex = 15;
            // 
            // textBoxCreationTime
            // 
            this.textBoxCreationTime.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxCreationTime.Font = new System.Drawing.Font("Raleway Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCreationTime.ForeColor = System.Drawing.Color.Brown;
            this.textBoxCreationTime.Location = new System.Drawing.Point(245, 92);
            this.textBoxCreationTime.Name = "textBoxCreationTime";
            this.textBoxCreationTime.Size = new System.Drawing.Size(205, 23);
            this.textBoxCreationTime.TabIndex = 14;
            // 
            // textBoxFileSize
            // 
            this.textBoxFileSize.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxFileSize.Font = new System.Drawing.Font("Raleway Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFileSize.ForeColor = System.Drawing.Color.Brown;
            this.textBoxFileSize.Location = new System.Drawing.Point(16, 92);
            this.textBoxFileSize.Name = "textBoxFileSize";
            this.textBoxFileSize.Size = new System.Drawing.Size(205, 23);
            this.textBoxFileSize.TabIndex = 13;
            this.textBoxFileSize.TextChanged += new System.EventHandler(this.textBoxFileSize_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Имя";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxFileName.Font = new System.Drawing.Font("Raleway Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFileName.ForeColor = System.Drawing.Color.Brown;
            this.textBoxFileName.Location = new System.Drawing.Point(112, 40);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(186, 23);
            this.textBoxFileName.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxNewPath);
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.buttonCopyTo);
            this.groupBox2.Controls.Add(this.buttonMoveTo);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox2.Location = new System.Drawing.Point(875, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 154);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Перемещение, удаление и копирование файлов";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBoxNewPath
            // 
            this.textBoxNewPath.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxNewPath.Font = new System.Drawing.Font("Raleway Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNewPath.ForeColor = System.Drawing.Color.Brown;
            this.textBoxNewPath.Location = new System.Drawing.Point(29, 106);
            this.textBoxNewPath.Name = "textBoxNewPath";
            this.textBoxNewPath.Size = new System.Drawing.Size(404, 23);
            this.textBoxNewPath.TabIndex = 13;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(325, 53);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(108, 35);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Удаление";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCopyTo
            // 
            this.buttonCopyTo.BackColor = System.Drawing.Color.White;
            this.buttonCopyTo.Location = new System.Drawing.Point(179, 53);
            this.buttonCopyTo.Name = "buttonCopyTo";
            this.buttonCopyTo.Size = new System.Drawing.Size(108, 35);
            this.buttonCopyTo.TabIndex = 14;
            this.buttonCopyTo.Text = "Копирование";
            this.buttonCopyTo.UseVisualStyleBackColor = false;
            this.buttonCopyTo.Click += new System.EventHandler(this.buttonCopyTo_Click);
            // 
            // buttonMoveTo
            // 
            this.buttonMoveTo.BackColor = System.Drawing.Color.White;
            this.buttonMoveTo.Location = new System.Drawing.Point(29, 53);
            this.buttonMoveTo.Name = "buttonMoveTo";
            this.buttonMoveTo.Size = new System.Drawing.Size(108, 35);
            this.buttonMoveTo.TabIndex = 13;
            this.buttonMoveTo.Text = "Перемещение";
            this.buttonMoveTo.UseVisualStyleBackColor = false;
            this.buttonMoveTo.Click += new System.EventHandler(this.buttonMoveTo_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxInput.Font = new System.Drawing.Font("Raleway Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInput.ForeColor = System.Drawing.Color.Brown;
            this.textBoxInput.Location = new System.Drawing.Point(440, 63);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(399, 23);
            this.textBoxInput.TabIndex = 13;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Файлы";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(212, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Папки";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxFolders);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.listBoxFiles);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.buttonUp);
            this.groupBox3.Controls.Add(this.textBoxFolder);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox3.Location = new System.Drawing.Point(440, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(418, 327);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Путь папки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(437, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Введите путь к файлу или папке\r\nи нажмите \"показать\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1352, 422);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxDisks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxDisks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.ListBox listBoxFolders;
        private System.Windows.Forms.TextBox textBoxFolder;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLastAccessTime;
        private System.Windows.Forms.TextBox textBoxLastWriteTime;
        private System.Windows.Forms.TextBox textBoxCreationTime;
        private System.Windows.Forms.TextBox textBoxFileSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxNewPath;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCopyTo;
        private System.Windows.Forms.Button buttonMoveTo;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
    }
}

