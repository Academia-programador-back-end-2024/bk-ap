namespace AulaWinFormsApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            statusStrip1 = new StatusStrip();
            miniToolStrip = new MenuStrip();
            toolStripTextBox1 = new ToolStripTextBox();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            gpWelcome = new GroupBox();
            lblHelloWorld = new Label();
            label1 = new Label();
            btnHelloWorld = new Button();
            txtMessageBox = new TextBox();
            checkBox1 = new CheckBox();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            openFileDialog1 = new OpenFileDialog();
            button2 = new Button();
            button3 = new Button();
            gpWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // miniToolStrip
            // 
            miniToolStrip.AccessibleName = "New item selection";
            miniToolStrip.AccessibleRole = AccessibleRole.ComboBox;
            miniToolStrip.AutoSize = false;
            miniToolStrip.Dock = DockStyle.None;
            miniToolStrip.Location = new Point(145, 4);
            miniToolStrip.Name = "miniToolStrip";
            miniToolStrip.Size = new Size(400, 27);
            miniToolStrip.TabIndex = 7;
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 23);
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, deleteToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 23);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(107, 22);
            openToolStripMenuItem.Text = "Open";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // gpWelcome
            // 
            gpWelcome.Controls.Add(lblHelloWorld);
            gpWelcome.Controls.Add(label1);
            gpWelcome.Controls.Add(btnHelloWorld);
            gpWelcome.Controls.Add(txtMessageBox);
            gpWelcome.Dock = DockStyle.Fill;
            gpWelcome.ForeColor = SystemColors.ButtonHighlight;
            gpWelcome.Location = new Point(3, 218);
            gpWelcome.Name = "gpWelcome";
            gpWelcome.Size = new Size(394, 209);
            gpWelcome.TabIndex = 5;
            gpWelcome.TabStop = false;
            gpWelcome.Text = "Bem vindo";
            // 
            // lblHelloWorld
            // 
            lblHelloWorld.AutoSize = true;
            lblHelloWorld.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHelloWorld.ForeColor = SystemColors.ControlLight;
            lblHelloWorld.Location = new Point(20, 52);
            lblHelloWorld.Name = "lblHelloWorld";
            lblHelloWorld.Size = new Size(95, 21);
            lblHelloWorld.TabIndex = 0;
            lblHelloWorld.Text = "Olá mundo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(20, 103);
            label1.Name = "label1";
            label1.Size = new Size(95, 21);
            label1.TabIndex = 4;
            label1.Text = "Olá mundo";
            // 
            // btnHelloWorld
            // 
            btnHelloWorld.Location = new Point(135, 49);
            btnHelloWorld.Name = "btnHelloWorld";
            btnHelloWorld.Size = new Size(173, 31);
            btnHelloWorld.TabIndex = 1;
            btnHelloWorld.Text = "Olá mundo Win Forms";
            btnHelloWorld.UseVisualStyleBackColor = true;
            btnHelloWorld.Click += btnHelloWorld_Click;
            // 
            // txtMessageBox
            // 
            txtMessageBox.Location = new Point(135, 105);
            txtMessageBox.Name = "txtMessageBox";
            txtMessageBox.Size = new Size(173, 23);
            txtMessageBox.TabIndex = 3;
            txtMessageBox.Text = "Bem vindo";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(3, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Mostrar bem vindo?";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(403, 218);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(394, 209);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button3, 0, 2);
            tableLayoutPanel1.Controls.Add(button2, 0, 2);
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(checkBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(gpWelcome, 0, 1);
            tableLayoutPanel1.Controls.Add(button1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(403, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripTextBox1, fileToolStripMenuItem });
            menuStrip1.Location = new Point(400, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(400, 27);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            button2.Location = new Point(403, 433);
            button2.Name = "button2";
            button2.Size = new Size(75, 14);
            button2.TabIndex = 8;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(3, 433);
            button3.Name = "button3";
            button3.Size = new Size(75, 14);
            button3.TabIndex = 9;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrchid;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(tableLayoutPanel1);
            MainMenuStrip = miniToolStrip;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Meu primeiro formulario";
            gpWelcome.ResumeLayout(false);
            gpWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip1;
        private MenuStrip miniToolStrip;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private GroupBox gpWelcome;
        private Label lblHelloWorld;
        private Label label1;
        private Button btnHelloWorld;
        private TextBox txtMessageBox;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private MenuStrip menuStrip1;
        private OpenFileDialog openFileDialog1;
        private Button button3;
        private Button button2;
    }
}
