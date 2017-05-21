namespace CppTutor
{
    partial class TutorForm
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
            this.ProblemText = new System.Windows.Forms.RichTextBox();
            this.CodeText = new System.Windows.Forms.RichTextBox();
            this.Check = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateCurriculumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AnswerText = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ProblemLoad = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProblemText
            // 
            this.ProblemText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProblemText.Location = new System.Drawing.Point(13, 27);
            this.ProblemText.Name = "ProblemText";
            this.ProblemText.ReadOnly = true;
            this.ProblemText.Size = new System.Drawing.Size(298, 304);
            this.ProblemText.TabIndex = 0;
            this.ProblemText.Text = "";
            // 
            // CodeText
            // 
            this.CodeText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CodeText.Location = new System.Drawing.Point(317, 27);
            this.CodeText.Name = "CodeText";
            this.CodeText.Size = new System.Drawing.Size(298, 217);
            this.CodeText.TabIndex = 1;
            this.CodeText.Text = "";
            // 
            // Check
            // 
            this.Check.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Check.Location = new System.Drawing.Point(506, 313);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(75, 23);
            this.Check.TabIndex = 2;
            this.Check.Text = "Проверить";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuToolStripMenuItem
            // 
            this.MenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.CreateCurriculumToolStripMenuItem});
            this.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem";
            this.MenuToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.MenuToolStripMenuItem.Text = "Меню";
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.LoadToolStripMenuItem.Text = "Загрузить сохранение";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить прогресс";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // CreateCurriculumToolStripMenuItem
            // 
            this.CreateCurriculumToolStripMenuItem.Name = "CreateCurriculumToolStripMenuItem";
            this.CreateCurriculumToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.CreateCurriculumToolStripMenuItem.Text = "Создать свой учебный план";
            this.CreateCurriculumToolStripMenuItem.Click += new System.EventHandler(this.CreateCurriculumToolStripMenuItem_Click);
            // 
            // AnswerText
            // 
            this.AnswerText.Location = new System.Drawing.Point(317, 251);
            this.AnswerText.Name = "AnswerText";
            this.AnswerText.ReadOnly = true;
            this.AnswerText.Size = new System.Drawing.Size(295, 56);
            this.AnswerText.TabIndex = 4;
            this.AnswerText.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ProblemLoad
            // 
            this.ProblemLoad.Location = new System.Drawing.Point(376, 313);
            this.ProblemLoad.Name = "ProblemLoad";
            this.ProblemLoad.Size = new System.Drawing.Size(98, 23);
            this.ProblemLoad.TabIndex = 5;
            this.ProblemLoad.Text = "Задача/Теория";
            this.ProblemLoad.UseVisualStyleBackColor = true;
            this.ProblemLoad.Click += new System.EventHandler(this.ProblemLoad_Click_1);
            // 
            // TutorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 343);
            this.Controls.Add(this.ProblemLoad);
            this.Controls.Add(this.AnswerText);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.CodeText);
            this.Controls.Add(this.ProblemText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TutorForm";
            this.Text = "CppTutor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ProblemText;
        private System.Windows.Forms.RichTextBox CodeText;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        private System.Windows.Forms.RichTextBox AnswerText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button ProblemLoad;
        private System.Windows.Forms.ToolStripMenuItem CreateCurriculumToolStripMenuItem;
    }
}

