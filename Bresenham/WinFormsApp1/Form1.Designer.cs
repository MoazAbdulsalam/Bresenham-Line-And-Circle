namespace WinFormsApp1
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
            tbX1 = new TextBox();
            tbY1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnLine = new Button();
            label3 = new Label();
            label4 = new Label();
            tbY2 = new TextBox();
            tbX2 = new TextBox();
            btnRectangle = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            tbRadius = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tbK = new TextBox();
            tbH = new TextBox();
            btnCircle = new Button();
            gbLines = new GroupBox();
            gbCircle = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbLines.SuspendLayout();
            gbCircle.SuspendLayout();
            SuspendLayout();
            // 
            // tbX1
            // 
            tbX1.Location = new Point(40, 39);
            tbX1.MaxLength = 4;
            tbX1.Name = "tbX1";
            tbX1.Size = new Size(52, 27);
            tbX1.TabIndex = 0;
            tbX1.TextChanged += EnableButton;
            tbX1.KeyPress += Valedate;
            // 
            // tbY1
            // 
            tbY1.Location = new Point(169, 39);
            tbY1.MaxLength = 4;
            tbY1.Name = "tbY1";
            tbY1.Size = new Size(54, 27);
            tbY1.TabIndex = 1;
            tbY1.TextChanged += EnableButton;
            tbY1.KeyPress += Valedate;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 42);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 2;
            label1.Text = "X1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 42);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 3;
            label2.Text = "Y1:";
            // 
            // btnLine
            // 
            btnLine.Image = Bresenham.Properties.Resources.icons8_lines_64;
            btnLine.ImageAlign = ContentAlignment.MiddleRight;
            btnLine.Location = new Point(11, 148);
            btnLine.Name = "btnLine";
            btnLine.Size = new Size(151, 62);
            btnLine.TabIndex = 4;
            btnLine.Text = "Draw Line";
            btnLine.TextAlign = ContentAlignment.MiddleLeft;
            btnLine.UseVisualStyleBackColor = true;
            btnLine.Click += btn_Line;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 91);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 8;
            label3.Text = "Y2:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 91);
            label4.Name = "label4";
            label4.Size = new Size(29, 20);
            label4.TabIndex = 7;
            label4.Text = "X2:";
            // 
            // tbY2
            // 
            tbY2.Location = new Point(169, 88);
            tbY2.MaxLength = 4;
            tbY2.Name = "tbY2";
            tbY2.Size = new Size(54, 27);
            tbY2.TabIndex = 6;
            tbY2.TextChanged += EnableButton;
            tbY2.KeyPress += Valedate;
            // 
            // tbX2
            // 
            tbX2.Location = new Point(40, 88);
            tbX2.MaxLength = 4;
            tbX2.Name = "tbX2";
            tbX2.Size = new Size(52, 27);
            tbX2.TabIndex = 5;
            tbX2.TextChanged += EnableButton;
            tbX2.KeyPress += Valedate;
            // 
            // btnRectangle
            // 
            btnRectangle.Image = Bresenham.Properties.Resources.icons8_rectangle_64;
            btnRectangle.ImageAlign = ContentAlignment.MiddleRight;
            btnRectangle.Location = new Point(168, 148);
            btnRectangle.Name = "btnRectangle";
            btnRectangle.Size = new Size(185, 62);
            btnRectangle.TabIndex = 9;
            btnRectangle.Text = "Draw Rectangle";
            btnRectangle.TextAlign = ContentAlignment.MiddleLeft;
            btnRectangle.UseVisualStyleBackColor = true;
            btnRectangle.Click += btnRectangle_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(372, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1063, 699);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Image = Bresenham.Properties.Resources.icons8_clear_50;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(30, 653);
            button1.Name = "button1";
            button1.Size = new Size(318, 67);
            button1.TabIndex = 11;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbRadius
            // 
            tbRadius.Location = new Point(67, 26);
            tbRadius.MaxLength = 3;
            tbRadius.Name = "tbRadius";
            tbRadius.Size = new Size(52, 27);
            tbRadius.TabIndex = 12;
            tbRadius.TextChanged += EnableButtonCircle;
            tbRadius.KeyPress += Valedate;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 29);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 13;
            label5.Text = "Radius:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(166, 69);
            label6.Name = "label6";
            label6.Size = new Size(21, 20);
            label6.TabIndex = 17;
            label6.Text = "K:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 69);
            label7.Name = "label7";
            label7.Size = new Size(23, 20);
            label7.TabIndex = 16;
            label7.Text = "H:";
            // 
            // tbK
            // 
            tbK.Location = new Point(197, 66);
            tbK.MaxLength = 4;
            tbK.Name = "tbK";
            tbK.Size = new Size(54, 27);
            tbK.TabIndex = 15;
            tbK.TextChanged += EnableButtonCircle;
            tbK.KeyPress += Valedate;
            // 
            // tbH
            // 
            tbH.Location = new Point(68, 66);
            tbH.MaxLength = 4;
            tbH.Name = "tbH";
            tbH.Size = new Size(52, 27);
            tbH.TabIndex = 14;
            tbH.TextChanged += EnableButtonCircle;
            tbH.KeyPress += Valedate;
            // 
            // btnCircle
            // 
            btnCircle.Image = (Image)resources.GetObject("btnCircle.Image");
            btnCircle.ImageAlign = ContentAlignment.MiddleRight;
            btnCircle.Location = new Point(5, 129);
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(309, 74);
            btnCircle.TabIndex = 18;
            btnCircle.Text = "Draw Circle";
            btnCircle.UseVisualStyleBackColor = true;
            btnCircle.Click += btnCircle_Click;
            // 
            // gbLines
            // 
            gbLines.Controls.Add(tbX1);
            gbLines.Controls.Add(tbY1);
            gbLines.Controls.Add(label1);
            gbLines.Controls.Add(label2);
            gbLines.Controls.Add(btnLine);
            gbLines.Controls.Add(tbX2);
            gbLines.Controls.Add(tbY2);
            gbLines.Controls.Add(label4);
            gbLines.Controls.Add(label3);
            gbLines.Controls.Add(btnRectangle);
            gbLines.Location = new Point(7, 34);
            gbLines.Name = "gbLines";
            gbLines.Size = new Size(359, 216);
            gbLines.TabIndex = 19;
            gbLines.TabStop = false;
            // 
            // gbCircle
            // 
            gbCircle.BackColor = Color.Transparent;
            gbCircle.Controls.Add(tbRadius);
            gbCircle.Controls.Add(label5);
            gbCircle.Controls.Add(btnCircle);
            gbCircle.Controls.Add(tbH);
            gbCircle.Controls.Add(label6);
            gbCircle.Controls.Add(tbK);
            gbCircle.Controls.Add(label7);
            gbCircle.Location = new Point(19, 289);
            gbCircle.Name = "gbCircle";
            gbCircle.Size = new Size(320, 209);
            gbCircle.TabIndex = 20;
            gbCircle.TabStop = false;
            // 
            // Form1
            // 
            AcceptButton = btnCircle;
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ActiveCaption;
            CancelButton = button1;
            ClientSize = new Size(1447, 734);
            Controls.Add(gbCircle);
            Controls.Add(gbLines);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "بريزينهام";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbLines.ResumeLayout(false);
            gbLines.PerformLayout();
            gbCircle.ResumeLayout(false);
            gbCircle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbX1;
        private TextBox tbY1;
        private Label label1;
        private Label label2;
        private Button btnLine;
        private Label label3;
        private Label label4;
        private TextBox tbY2;
        private TextBox tbX2;
        private Button btnRectangle;
        private PictureBox pictureBox1;
        private Button button1;
        private TextBox tbRadius;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tbK;
        private TextBox tbH;
        private Button btnCircle;
        private GroupBox gbLines;
        private GroupBox gbCircle;
    }
}
