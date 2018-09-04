namespace first_project
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSpin = new System.Windows.Forms.Button();
            this.radDodge = new System.Windows.Forms.RadioButton();
            this.lbxOutput = new System.Windows.Forms.ListBox();
            this.btnFire = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCheckBush = new System.Windows.Forms.Button();
            this.bush2 = new System.Windows.Forms.PictureBox();
            this.bush3 = new System.Windows.Forms.PictureBox();
            this.bush5 = new System.Windows.Forms.PictureBox();
            this.bush6 = new System.Windows.Forms.PictureBox();
            this.bush4 = new System.Windows.Forms.PictureBox();
            this.bush1 = new System.Windows.Forms.PictureBox();
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.btnTryAgain = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bush2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bush3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bush5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bush6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bush4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bush1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(713, 330);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load Ammo";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSpin
            // 
            this.btnSpin.Location = new System.Drawing.Point(713, 359);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(75, 23);
            this.btnSpin.TabIndex = 1;
            this.btnSpin.Text = "Aim";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // radDodge
            // 
            this.radDodge.Location = new System.Drawing.Point(0, 0);
            this.radDodge.Name = "radDodge";
            this.radDodge.Size = new System.Drawing.Size(104, 24);
            this.radDodge.TabIndex = 0;
            // 
            // lbxOutput
            // 
            this.lbxOutput.FormattingEnabled = true;
            this.lbxOutput.Location = new System.Drawing.Point(-2, 357);
            this.lbxOutput.Name = "lbxOutput";
            this.lbxOutput.Size = new System.Drawing.Size(120, 95);
            this.lbxOutput.TabIndex = 5;
            // 
            // btnFire
            // 
            this.btnFire.Location = new System.Drawing.Point(713, 388);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(75, 23);
            this.btnFire.TabIndex = 2;
            this.btnFire.Text = "Fire Gun";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // btnCheckBush
            // 
            this.btnCheckBush.Location = new System.Drawing.Point(713, 415);
            this.btnCheckBush.Name = "btnCheckBush";
            this.btnCheckBush.Size = new System.Drawing.Size(75, 23);
            this.btnCheckBush.TabIndex = 14;
            this.btnCheckBush.Text = "Check Bush";
            this.btnCheckBush.UseVisualStyleBackColor = true;
            this.btnCheckBush.Click += new System.EventHandler(this.btnCheckBush_Click);
            // 
            // bush2
            // 
            this.bush2.Image = ((System.Drawing.Image)(resources.GetObject("bush2.Image")));
            this.bush2.Location = new System.Drawing.Point(190, 284);
            this.bush2.Name = "bush2";
            this.bush2.Size = new System.Drawing.Size(186, 144);
            this.bush2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bush2.TabIndex = 12;
            this.bush2.TabStop = false;
            // 
            // bush3
            // 
            this.bush3.BackColor = System.Drawing.Color.Transparent;
            this.bush3.ErrorImage = null;
            this.bush3.Image = ((System.Drawing.Image)(resources.GetObject("bush3.Image")));
            this.bush3.InitialImage = null;
            this.bush3.Location = new System.Drawing.Point(233, 175);
            this.bush3.Name = "bush3";
            this.bush3.Size = new System.Drawing.Size(143, 103);
            this.bush3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bush3.TabIndex = 11;
            this.bush3.TabStop = false;
            // 
            // bush5
            // 
            this.bush5.Image = ((System.Drawing.Image)(resources.GetObject("bush5.Image")));
            this.bush5.Location = new System.Drawing.Point(423, 284);
            this.bush5.Name = "bush5";
            this.bush5.Size = new System.Drawing.Size(182, 112);
            this.bush5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bush5.TabIndex = 10;
            this.bush5.TabStop = false;
            // 
            // bush6
            // 
            this.bush6.Image = ((System.Drawing.Image)(resources.GetObject("bush6.Image")));
            this.bush6.InitialImage = null;
            this.bush6.Location = new System.Drawing.Point(597, 107);
            this.bush6.Name = "bush6";
            this.bush6.Size = new System.Drawing.Size(165, 171);
            this.bush6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bush6.TabIndex = 9;
            this.bush6.TabStop = false;
            // 
            // bush4
            // 
            this.bush4.Image = ((System.Drawing.Image)(resources.GetObject("bush4.Image")));
            this.bush4.Location = new System.Drawing.Point(423, 168);
            this.bush4.Name = "bush4";
            this.bush4.Size = new System.Drawing.Size(100, 110);
            this.bush4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bush4.TabIndex = 8;
            this.bush4.TabStop = false;
            // 
            // bush1
            // 
            this.bush1.BackColor = System.Drawing.Color.Transparent;
            this.bush1.Image = ((System.Drawing.Image)(resources.GetObject("bush1.Image")));
            this.bush1.Location = new System.Drawing.Point(35, 228);
            this.bush1.Name = "bush1";
            this.bush1.Size = new System.Drawing.Size(144, 123);
            this.bush1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bush1.TabIndex = 7;
            this.bush1.TabStop = false;
            // 
            // picBackground
            // 
            this.picBackground.Image = global::first_project.Resource1.background;
            this.picBackground.Location = new System.Drawing.Point(-2, -2);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(801, 454);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBackground.TabIndex = 6;
            this.picBackground.TabStop = false;
            // 
            // btnTryAgain
            // 
            this.btnTryAgain.Location = new System.Drawing.Point(295, 325);
            this.btnTryAgain.Name = "btnTryAgain";
            this.btnTryAgain.Size = new System.Drawing.Size(160, 71);
            this.btnTryAgain.TabIndex = 16;
            this.btnTryAgain.Text = "Try Again";
            this.btnTryAgain.UseVisualStyleBackColor = true;
            this.btnTryAgain.Click += new System.EventHandler(this.btnTryAgain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTryAgain);
            this.Controls.Add(this.btnCheckBush);
            this.Controls.Add(this.bush2);
            this.Controls.Add(this.bush3);
            this.Controls.Add(this.bush5);
            this.Controls.Add(this.bush6);
            this.Controls.Add(this.bush4);
            this.Controls.Add(this.bush1);
            this.Controls.Add(this.lbxOutput);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.picBackground);
            this.Name = "Form1";
            this.Text = "Dodge Bullet";
            ((System.ComponentModel.ISupportInitialize)(this.bush2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bush3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bush5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bush6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bush4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bush1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        public System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.ListBox lbxOutput;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.PictureBox bush1;
        private System.Windows.Forms.PictureBox bush4;
        private System.Windows.Forms.PictureBox bush6;
        private System.Windows.Forms.PictureBox bush5;
        private System.Windows.Forms.PictureBox bush3;
        private System.Windows.Forms.PictureBox bush2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton radDodge;
        private System.Windows.Forms.Button btnCheckBush;
        private System.Windows.Forms.Button btnTryAgain;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

