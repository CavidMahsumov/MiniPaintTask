namespace MiniPaint
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
            this.figureCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.widthTxtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.heightTxtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectBtn = new System.Windows.Forms.Button();
            this.fillRadiobtn = new System.Windows.Forms.RadioButton();
            this.emptyRadiobtn = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // figureCombobox
            // 
            this.figureCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.figureCombobox.FormattingEnabled = true;
            this.figureCombobox.Location = new System.Drawing.Point(40, 45);
            this.figureCombobox.Name = "figureCombobox";
            this.figureCombobox.Size = new System.Drawing.Size(149, 33);
            this.figureCombobox.TabIndex = 0;
            this.figureCombobox.SelectedIndexChanged += new System.EventHandler(this.figureCombobox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(300, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Width";
            // 
            // widthTxtb
            // 
            this.widthTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.widthTxtb.Location = new System.Drawing.Point(398, 45);
            this.widthTxtb.Name = "widthTxtb";
            this.widthTxtb.Size = new System.Drawing.Size(100, 31);
            this.widthTxtb.TabIndex = 2;
            this.widthTxtb.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(549, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Height";
            // 
            // heightTxtb
            // 
            this.heightTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightTxtb.Location = new System.Drawing.Point(660, 45);
            this.heightTxtb.Name = "heightTxtb";
            this.heightTxtb.Size = new System.Drawing.Size(100, 31);
            this.heightTxtb.TabIndex = 4;
            this.heightTxtb.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(790, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Color";
            // 
            // selectBtn
            // 
            this.selectBtn.AutoSize = true;
            this.selectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectBtn.Location = new System.Drawing.Point(873, 45);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(101, 35);
            this.selectBtn.TabIndex = 6;
            this.selectBtn.Text = "Select";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // fillRadiobtn
            // 
            this.fillRadiobtn.AutoSize = true;
            this.fillRadiobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fillRadiobtn.Location = new System.Drawing.Point(1005, 45);
            this.fillRadiobtn.Name = "fillRadiobtn";
            this.fillRadiobtn.Size = new System.Drawing.Size(76, 29);
            this.fillRadiobtn.TabIndex = 7;
            this.fillRadiobtn.TabStop = true;
            this.fillRadiobtn.Text = "FILL";
            this.fillRadiobtn.UseVisualStyleBackColor = true;
            // 
            // emptyRadiobtn
            // 
            this.emptyRadiobtn.AutoSize = true;
            this.emptyRadiobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emptyRadiobtn.Location = new System.Drawing.Point(1005, 99);
            this.emptyRadiobtn.Name = "emptyRadiobtn";
            this.emptyRadiobtn.Size = new System.Drawing.Size(109, 29);
            this.emptyRadiobtn.TabIndex = 8;
            this.emptyRadiobtn.TabStop = true;
            this.emptyRadiobtn.Text = "EMPTY";
            this.emptyRadiobtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(50, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 592);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.emptyRadiobtn);
            this.Controls.Add(this.fillRadiobtn);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.heightTxtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.widthTxtb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.figureCombobox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox figureCombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox widthTxtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox heightTxtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.RadioButton fillRadiobtn;
        private System.Windows.Forms.RadioButton emptyRadiobtn;
        private System.Windows.Forms.Button button1;
    }
}

