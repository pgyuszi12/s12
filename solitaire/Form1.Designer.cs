namespace solitaire
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.column1_Panel = new System.Windows.Forms.Panel();
            this.column2_Panel = new System.Windows.Forms.Panel();
            this.column3_Panel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.column4_Panel = new System.Windows.Forms.Panel();
            this.column5_Panel = new System.Windows.Forms.Panel();
            this.column6_Panel = new System.Windows.Forms.Panel();
            this.column7_Panel = new System.Windows.Forms.Panel();
            this.drawCard = new System.Windows.Forms.PictureBox();
            this.drawed_Card = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawed_Card)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.drawed_Card);
            this.panel1.Controls.Add(this.drawCard);
            this.panel1.Location = new System.Drawing.Point(28, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 137);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(230, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 136);
            this.panel2.TabIndex = 1;
            // 
            // column1_Panel
            // 
            this.column1_Panel.AccessibleName = "Column1_Panel";
            this.column1_Panel.Location = new System.Drawing.Point(28, 155);
            this.column1_Panel.Name = "column1_Panel";
            this.column1_Panel.Size = new System.Drawing.Size(95, 475);
            this.column1_Panel.TabIndex = 3;
            // 
            // column2_Panel
            // 
            this.column2_Panel.AccessibleName = "Column2_Panel";
            this.column2_Panel.Location = new System.Drawing.Point(129, 155);
            this.column2_Panel.Name = "column2_Panel";
            this.column2_Panel.Size = new System.Drawing.Size(95, 475);
            this.column2_Panel.TabIndex = 4;
            // 
            // column3_Panel
            // 
            this.column3_Panel.AccessibleName = "Column3_Panel";
            this.column3_Panel.Location = new System.Drawing.Point(230, 155);
            this.column3_Panel.Name = "column3_Panel";
            this.column3_Panel.Size = new System.Drawing.Size(95, 475);
            this.column3_Panel.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(101, 142);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(95, 475);
            this.panel6.TabIndex = 6;
            // 
            // column4_Panel
            // 
            this.column4_Panel.AccessibleName = "Column4_Panel";
            this.column4_Panel.Location = new System.Drawing.Point(331, 155);
            this.column4_Panel.Name = "column4_Panel";
            this.column4_Panel.Size = new System.Drawing.Size(95, 475);
            this.column4_Panel.TabIndex = 6;
            // 
            // column5_Panel
            // 
            this.column5_Panel.AccessibleName = "Column5_Panel";
            this.column5_Panel.Location = new System.Drawing.Point(432, 155);
            this.column5_Panel.Name = "column5_Panel";
            this.column5_Panel.Size = new System.Drawing.Size(95, 475);
            this.column5_Panel.TabIndex = 6;
            // 
            // column6_Panel
            // 
            this.column6_Panel.AccessibleName = "Column6_Panel";
            this.column6_Panel.Location = new System.Drawing.Point(533, 155);
            this.column6_Panel.Name = "column6_Panel";
            this.column6_Panel.Size = new System.Drawing.Size(95, 475);
            this.column6_Panel.TabIndex = 6;
            // 
            // column7_Panel
            // 
            this.column7_Panel.AccessibleName = "Column7_Panel";
            this.column7_Panel.Location = new System.Drawing.Point(634, 155);
            this.column7_Panel.Name = "column7_Panel";
            this.column7_Panel.Size = new System.Drawing.Size(95, 475);
            this.column7_Panel.TabIndex = 6;
            // 
            // drawCard
            // 
            this.drawCard.Location = new System.Drawing.Point(19, 18);
            this.drawCard.Name = "drawCard";
            this.drawCard.Size = new System.Drawing.Size(60, 100);
            this.drawCard.TabIndex = 0;
            this.drawCard.TabStop = false;
            // 
            // drawed_Card
            // 
            this.drawed_Card.Location = new System.Drawing.Point(117, 18);
            this.drawed_Card.Name = "drawed_Card";
            this.drawed_Card.Size = new System.Drawing.Size(60, 100);
            this.drawed_Card.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.drawed_Card.TabIndex = 1;
            this.drawed_Card.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.column7_Panel);
            this.Controls.Add(this.column6_Panel);
            this.Controls.Add(this.column5_Panel);
            this.Controls.Add(this.column4_Panel);
            this.Controls.Add(this.column3_Panel);
            this.Controls.Add(this.column2_Panel);
            this.Controls.Add(this.column1_Panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 766);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drawCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawed_Card)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel column1_Panel;
        private System.Windows.Forms.Panel column2_Panel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel column3_Panel;
        private System.Windows.Forms.Panel column4_Panel;
        private System.Windows.Forms.Panel column5_Panel;
        private System.Windows.Forms.Panel column6_Panel;
        private System.Windows.Forms.Panel column7_Panel;
        private System.Windows.Forms.PictureBox drawCard;
        private System.Windows.Forms.PictureBox drawed_Card;
    }
}

