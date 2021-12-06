
namespace merescs
{
    partial class fUjpalyazat
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
            this.lbID = new System.Windows.Forms.Label();
            this.btnUjpalyazath = new System.Windows.Forms.Button();
            this.tbC = new System.Windows.Forms.TextBox();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lbA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbID.Location = new System.Drawing.Point(12, 57);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(27, 16);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "ID: ";
            // 
            // btnUjpalyazath
            // 
            this.btnUjpalyazath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUjpalyazath.Location = new System.Drawing.Point(15, 360);
            this.btnUjpalyazath.Name = "btnUjpalyazath";
            this.btnUjpalyazath.Size = new System.Drawing.Size(275, 78);
            this.btnUjpalyazath.TabIndex = 5;
            this.btnUjpalyazath.Text = "Új pályázat hírdetése";
            this.btnUjpalyazath.UseVisualStyleBackColor = true;
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(45, 225);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(172, 20);
            this.tbC.TabIndex = 6;
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(45, 154);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(172, 20);
            this.tbA.TabIndex = 7;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(45, 53);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(29, 20);
            this.tbID.TabIndex = 8;
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbA.Location = new System.Drawing.Point(42, 135);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(156, 16);
            this.lbA.TabIndex = 9;
            this.lbA.Text = "\"A kategória értékkeret: \"";
            this.lbA.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(223, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "HUF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(42, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "\"C kategória értékkeret: \" ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(223, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "HUF";
            // 
            // fUjpalyazat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbA);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.btnUjpalyazath);
            this.Controls.Add(this.lbID);
            this.Name = "fUjpalyazat";
            this.Text = "Új pályázat rögzítése";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnUjpalyazath;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}