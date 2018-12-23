namespace Tanki_WF
{
    partial class Tanki
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
            this.battleField_panel = new System.Windows.Forms.Panel();
            this.xlb = new System.Windows.Forms.Label();
            this.ylb = new System.Windows.Forms.Label();
            this.wlb = new System.Windows.Forms.Label();
            this.hlb = new System.Windows.Forms.Label();
            this.exlb = new System.Windows.Forms.Label();
            this.eylb = new System.Windows.Forms.Label();
            this.ehlb = new System.Windows.Forms.Label();
            this.ewlb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // battleField_panel
            // 
            this.battleField_panel.Location = new System.Drawing.Point(12, 12);
            this.battleField_panel.Name = "battleField_panel";
            this.battleField_panel.Size = new System.Drawing.Size(502, 426);
            this.battleField_panel.TabIndex = 0;
            // 
            // xlb
            // 
            this.xlb.AutoSize = true;
            this.xlb.Location = new System.Drawing.Point(560, 19);
            this.xlb.Name = "xlb";
            this.xlb.Size = new System.Drawing.Size(17, 17);
            this.xlb.TabIndex = 3;
            this.xlb.Text = "X";
            // 
            // ylb
            // 
            this.ylb.AutoSize = true;
            this.ylb.Location = new System.Drawing.Point(560, 48);
            this.ylb.Name = "ylb";
            this.ylb.Size = new System.Drawing.Size(17, 17);
            this.ylb.TabIndex = 4;
            this.ylb.Text = "Y";
            // 
            // wlb
            // 
            this.wlb.AutoSize = true;
            this.wlb.Location = new System.Drawing.Point(560, 105);
            this.wlb.Name = "wlb";
            this.wlb.Size = new System.Drawing.Size(44, 17);
            this.wlb.TabIndex = 8;
            this.wlb.Text = "Width";
            // 
            // hlb
            // 
            this.hlb.AutoSize = true;
            this.hlb.Location = new System.Drawing.Point(560, 75);
            this.hlb.Name = "hlb";
            this.hlb.Size = new System.Drawing.Size(49, 17);
            this.hlb.TabIndex = 7;
            this.hlb.Text = "Height";
            // 
            // exlb
            // 
            this.exlb.AutoSize = true;
            this.exlb.Location = new System.Drawing.Point(583, 19);
            this.exlb.Name = "exlb";
            this.exlb.Size = new System.Drawing.Size(0, 17);
            this.exlb.TabIndex = 9;
            // 
            // eylb
            // 
            this.eylb.AutoSize = true;
            this.eylb.Location = new System.Drawing.Point(583, 48);
            this.eylb.Name = "eylb";
            this.eylb.Size = new System.Drawing.Size(0, 17);
            this.eylb.TabIndex = 10;
            // 
            // ehlb
            // 
            this.ehlb.AutoSize = true;
            this.ehlb.Location = new System.Drawing.Point(615, 75);
            this.ehlb.Name = "ehlb";
            this.ehlb.Size = new System.Drawing.Size(0, 17);
            this.ehlb.TabIndex = 11;
            // 
            // ewlb
            // 
            this.ewlb.AutoSize = true;
            this.ewlb.Location = new System.Drawing.Point(615, 105);
            this.ewlb.Name = "ewlb";
            this.ewlb.Size = new System.Drawing.Size(0, 17);
            this.ewlb.TabIndex = 12;
            // 
            // Tanki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ewlb);
            this.Controls.Add(this.ehlb);
            this.Controls.Add(this.eylb);
            this.Controls.Add(this.exlb);
            this.Controls.Add(this.wlb);
            this.Controls.Add(this.hlb);
            this.Controls.Add(this.ylb);
            this.Controls.Add(this.xlb);
            this.Controls.Add(this.battleField_panel);
            this.Name = "Tanki";
            this.Text = "Tanks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel battleField_panel;
        private System.Windows.Forms.Label xlb;
        private System.Windows.Forms.Label ylb;
        private System.Windows.Forms.Label wlb;
        private System.Windows.Forms.Label hlb;
        private System.Windows.Forms.Label exlb;
        private System.Windows.Forms.Label eylb;
        private System.Windows.Forms.Label ehlb;
        private System.Windows.Forms.Label ewlb;
    }
}

