namespace Lab8CS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.textBoxArrayGiven = new System.Windows.Forms.TextBox();
            this.textBoxArrayExecuted = new System.Windows.Forms.TextBox();
            this.buttonSeek = new System.Windows.Forms.Button();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть назву файлу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вихідний масив";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Опрацьований масив";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(34, 72);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(484, 27);
            this.textBoxFileName.TabIndex = 3;
            // 
            // textBoxArrayGiven
            // 
            this.textBoxArrayGiven.Enabled = false;
            this.textBoxArrayGiven.Location = new System.Drawing.Point(34, 214);
            this.textBoxArrayGiven.Name = "textBoxArrayGiven";
            this.textBoxArrayGiven.Size = new System.Drawing.Size(484, 27);
            this.textBoxArrayGiven.TabIndex = 4;
            // 
            // textBoxArrayExecuted
            // 
            this.textBoxArrayExecuted.Enabled = false;
            this.textBoxArrayExecuted.Location = new System.Drawing.Point(34, 295);
            this.textBoxArrayExecuted.Name = "textBoxArrayExecuted";
            this.textBoxArrayExecuted.Size = new System.Drawing.Size(484, 27);
            this.textBoxArrayExecuted.TabIndex = 5;
            // 
            // buttonSeek
            // 
            this.buttonSeek.Location = new System.Drawing.Point(524, 72);
            this.buttonSeek.Name = "buttonSeek";
            this.buttonSeek.Size = new System.Drawing.Size(62, 27);
            this.buttonSeek.TabIndex = 6;
            this.buttonSeek.Text = "Огляд";
            this.buttonSeek.UseVisualStyleBackColor = true;
            this.buttonSeek.Click += new System.EventHandler(this.buttonSeek_Click);
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(34, 105);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(120, 29);
            this.buttonDownload.TabIndex = 7;
            this.buttonDownload.Text = "Завантажити";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(34, 140);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(120, 29);
            this.buttonExecute.TabIndex = 8;
            this.buttonExecute.Text = "Опрацювати";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(170, 105);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(94, 64);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Очистити";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Оберіть файл";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.buttonSeek);
            this.Controls.Add(this.textBoxArrayExecuted);
            this.Controls.Add(this.textBoxArrayGiven);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxFileName;
        private TextBox textBoxArrayGiven;
        private TextBox textBoxArrayExecuted;
        private Button buttonSeek;
        private Button buttonDownload;
        private Button buttonExecute;
        private Button buttonClear;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider errorProvider1;
    }
}