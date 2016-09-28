namespace Compare2ColsInCSVGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.File1TXTBOX = new System.Windows.Forms.TextBox();
            this.Col1TXTBOX = new System.Windows.Forms.TextBox();
            this.File2TXTBOX = new System.Windows.Forms.TextBox();
            this.Col2TXTBOX = new System.Windows.Forms.TextBox();
            this.OKBTN = new System.Windows.Forms.Button();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.OUTPUTTXTBOX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NoReverseCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // File1TXTBOX
            // 
            this.File1TXTBOX.Location = new System.Drawing.Point(85, 25);
            this.File1TXTBOX.Name = "File1TXTBOX";
            this.File1TXTBOX.Size = new System.Drawing.Size(636, 20);
            this.File1TXTBOX.TabIndex = 0;
            this.File1TXTBOX.MouseClick += new System.Windows.Forms.MouseEventHandler(this.File1TXTBOX_MouseClick);
            this.File1TXTBOX.TextChanged += new System.EventHandler(this.File1TXTBOX_TextChanged);
            // 
            // Col1TXTBOX
            // 
            this.Col1TXTBOX.Location = new System.Drawing.Point(85, 52);
            this.Col1TXTBOX.Name = "Col1TXTBOX";
            this.Col1TXTBOX.Size = new System.Drawing.Size(64, 20);
            this.Col1TXTBOX.TabIndex = 1;
            this.Col1TXTBOX.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Col1TXTBOX_MouseClick);
            this.Col1TXTBOX.TextChanged += new System.EventHandler(this.Col1TXTBOX_TextChanged);
            // 
            // File2TXTBOX
            // 
            this.File2TXTBOX.Location = new System.Drawing.Point(85, 79);
            this.File2TXTBOX.Name = "File2TXTBOX";
            this.File2TXTBOX.Size = new System.Drawing.Size(636, 20);
            this.File2TXTBOX.TabIndex = 2;
            this.File2TXTBOX.MouseClick += new System.Windows.Forms.MouseEventHandler(this.File2TXTBOX_MouseClick);
            this.File2TXTBOX.TextChanged += new System.EventHandler(this.File2TXTBOX_TextChanged);
            // 
            // Col2TXTBOX
            // 
            this.Col2TXTBOX.Location = new System.Drawing.Point(85, 106);
            this.Col2TXTBOX.Name = "Col2TXTBOX";
            this.Col2TXTBOX.Size = new System.Drawing.Size(64, 20);
            this.Col2TXTBOX.TabIndex = 3;
            this.Col2TXTBOX.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Col2TXTBOX_MouseClick);
            this.Col2TXTBOX.TextChanged += new System.EventHandler(this.Col2TXTBOX_TextChanged);
            // 
            // OKBTN
            // 
            this.OKBTN.Location = new System.Drawing.Point(284, 181);
            this.OKBTN.Name = "OKBTN";
            this.OKBTN.Size = new System.Drawing.Size(75, 23);
            this.OKBTN.TabIndex = 5;
            this.OKBTN.Text = "Compare";
            this.OKBTN.UseVisualStyleBackColor = true;
            this.OKBTN.Click += new System.EventHandler(this.OKBTN_Click);
            // 
            // CancelBTN
            // 
            this.CancelBTN.Location = new System.Drawing.Point(420, 181);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(75, 23);
            this.CancelBTN.TabIndex = 6;
            this.CancelBTN.Text = "Close";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // OUTPUTTXTBOX
            // 
            this.OUTPUTTXTBOX.Location = new System.Drawing.Point(85, 156);
            this.OUTPUTTXTBOX.Name = "OUTPUTTXTBOX";
            this.OUTPUTTXTBOX.Size = new System.Drawing.Size(636, 20);
            this.OUTPUTTXTBOX.TabIndex = 7;
            this.OUTPUTTXTBOX.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OUTPUTTXTBOX_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "File 1 Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "File 1 Coloum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "File 2 Path";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "File 2 Coloum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Output Path";
            // 
            // NoReverseCheck
            // 
            this.NoReverseCheck.AutoSize = true;
            this.NoReverseCheck.Location = new System.Drawing.Point(85, 133);
            this.NoReverseCheck.Name = "NoReverseCheck";
            this.NoReverseCheck.Size = new System.Drawing.Size(117, 17);
            this.NoReverseCheck.TabIndex = 13;
            this.NoReverseCheck.Text = "No Reverse Check";
            this.NoReverseCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 222);
            this.Controls.Add(this.NoReverseCheck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OUTPUTTXTBOX);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.OKBTN);
            this.Controls.Add(this.Col2TXTBOX);
            this.Controls.Add(this.File2TXTBOX);
            this.Controls.Add(this.Col1TXTBOX);
            this.Controls.Add(this.File1TXTBOX);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "Form1";
            this.Text = "CSV Values Compare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox File1TXTBOX;
        private System.Windows.Forms.TextBox Col1TXTBOX;
        private System.Windows.Forms.TextBox File2TXTBOX;
        private System.Windows.Forms.TextBox Col2TXTBOX;
        private System.Windows.Forms.Button OKBTN;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.TextBox OUTPUTTXTBOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox NoReverseCheck;
    }
}

