namespace ControlMiniSup
{
    partial class Splayer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splayer));
            this.CargaPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CargaPanel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CargaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CargaPanel
            // 
            this.CargaPanel.BackColor = System.Drawing.Color.White;
            this.CargaPanel.Controls.Add(this.panel1);
            this.CargaPanel.Controls.Add(this.CargaPanel2);
            this.CargaPanel.Controls.Add(this.panel2);
            this.CargaPanel.Location = new System.Drawing.Point(128, 331);
            this.CargaPanel.Name = "CargaPanel";
            this.CargaPanel.Size = new System.Drawing.Size(352, 23);
            this.CargaPanel.TabIndex = 0;
            this.CargaPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CargaPanel_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 19);
            this.panel2.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CargaPanel2
            // 
            this.CargaPanel2.Location = new System.Drawing.Point(5, 2);
            this.CargaPanel2.Name = "CargaPanel2";
            this.CargaPanel2.Size = new System.Drawing.Size(0, 19);
            this.CargaPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 19);
            this.panel1.TabIndex = 2;
            // 
            // Splayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(604, 366);
            this.Controls.Add(this.CargaPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Splayer_FormClosing);
            this.Load += new System.EventHandler(this.Splayer_Load);
            this.CargaPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CargaPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel CargaPanel2;
        private System.Windows.Forms.Panel panel1;
    }
}

