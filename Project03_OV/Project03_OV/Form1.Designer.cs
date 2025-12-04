namespace Project03_OV
{
    partial class GameFrame
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
            this.btnBad = new System.Windows.Forms.Button();
            this.lblHeight = new System.Windows.Forms.Label();
            this.btnManual = new System.Windows.Forms.Button();
            this.tBoxHeight = new System.Windows.Forms.TextBox();
            this.tBoxWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblAccessory = new System.Windows.Forms.Label();
            this.btnGood = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreNum = new System.Windows.Forms.Label();
            this.pboxAccessoryYN = new System.Windows.Forms.PictureBox();
            this.pboxToy = new System.Windows.Forms.PictureBox();
            this.pboxDesk = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAccessoryYN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxToy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDesk)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBad
            // 
            this.btnBad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(39)))), ((int)(((byte)(26)))));
            this.btnBad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBad.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBad.Location = new System.Drawing.Point(27, 345);
            this.btnBad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBad.Name = "btnBad";
            this.btnBad.Size = new System.Drawing.Size(75, 75);
            this.btnBad.TabIndex = 2;
            this.btnBad.Text = "&X";
            this.btnBad.UseVisualStyleBackColor = false;
            this.btnBad.Click += new System.EventHandler(this.btnBad_Click);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(565, 98);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(49, 16);
            this.lblHeight.TabIndex = 4;
            this.lblHeight.Text = "Height:";
            // 
            // btnManual
            // 
            this.btnManual.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnManual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManual.Location = new System.Drawing.Point(625, 261);
            this.btnManual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(100, 31);
            this.btnManual.TabIndex = 5;
            this.btnManual.Text = "Toy &Manual";
            this.btnManual.UseVisualStyleBackColor = false;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // tBoxHeight
            // 
            this.tBoxHeight.Enabled = false;
            this.tBoxHeight.Location = new System.Drawing.Point(624, 98);
            this.tBoxHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxHeight.Name = "tBoxHeight";
            this.tBoxHeight.Size = new System.Drawing.Size(100, 22);
            this.tBoxHeight.TabIndex = 6;
            // 
            // tBoxWeight
            // 
            this.tBoxWeight.Enabled = false;
            this.tBoxWeight.Location = new System.Drawing.Point(624, 144);
            this.tBoxWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxWeight.Name = "tBoxWeight";
            this.tBoxWeight.Size = new System.Drawing.Size(100, 22);
            this.tBoxWeight.TabIndex = 7;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(563, 146);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(52, 16);
            this.lblWeight.TabIndex = 9;
            this.lblWeight.Text = "Weight:";
            // 
            // lblAccessory
            // 
            this.lblAccessory.AutoSize = true;
            this.lblAccessory.Location = new System.Drawing.Point(563, 196);
            this.lblAccessory.Name = "lblAccessory";
            this.lblAccessory.Size = new System.Drawing.Size(74, 16);
            this.lblAccessory.TabIndex = 10;
            this.lblAccessory.Text = "Accessory:";
            // 
            // btnGood
            // 
            this.btnGood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(203)))), ((int)(((byte)(27)))));
            this.btnGood.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGood.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGood.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGood.Location = new System.Drawing.Point(699, 345);
            this.btnGood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGood.Name = "btnGood";
            this.btnGood.Size = new System.Drawing.Size(75, 75);
            this.btnGood.TabIndex = 11;
            this.btnGood.Text = "&✔";
            this.btnGood.UseVisualStyleBackColor = false;
            this.btnGood.Click += new System.EventHandler(this.btnGood_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(13, 13);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(46, 16);
            this.lblScore.TabIndex = 12;
            this.lblScore.Text = "Score:";
            // 
            // lblScoreNum
            // 
            this.lblScoreNum.AutoSize = true;
            this.lblScoreNum.Location = new System.Drawing.Point(62, 13);
            this.lblScoreNum.Name = "lblScoreNum";
            this.lblScoreNum.Size = new System.Drawing.Size(49, 16);
            this.lblScoreNum.TabIndex = 13;
            this.lblScoreNum.Text = "000000";
            // 
            // pboxAccessoryYN
            // 
            this.pboxAccessoryYN.BackgroundImage = global::Project03_OV.Properties.Resources.XonRedBG;
            this.pboxAccessoryYN.Location = new System.Drawing.Point(649, 183);
            this.pboxAccessoryYN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pboxAccessoryYN.Name = "pboxAccessoryYN";
            this.pboxAccessoryYN.Size = new System.Drawing.Size(47, 43);
            this.pboxAccessoryYN.TabIndex = 8;
            this.pboxAccessoryYN.TabStop = false;
            // 
            // pboxToy
            // 
            this.pboxToy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pboxToy.BackgroundImage = global::Project03_OV.Properties.Resources.TeddyBear_var01;
            this.pboxToy.Location = new System.Drawing.Point(284, 85);
            this.pboxToy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pboxToy.Name = "pboxToy";
            this.pboxToy.Size = new System.Drawing.Size(232, 304);
            this.pboxToy.TabIndex = 0;
            this.pboxToy.TabStop = false;
            this.pboxToy.Click += new System.EventHandler(this.pboxToy_Click);
            // 
            // pboxDesk
            // 
            this.pboxDesk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(88)))), ((int)(((byte)(52)))));
            this.pboxDesk.Location = new System.Drawing.Point(-7, 314);
            this.pboxDesk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pboxDesk.Name = "pboxDesk";
            this.pboxDesk.Size = new System.Drawing.Size(813, 142);
            this.pboxDesk.TabIndex = 1;
            this.pboxDesk.TabStop = false;
            // 
            // GameFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(226)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblScoreNum);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnGood);
            this.Controls.Add(this.lblAccessory);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.pboxAccessoryYN);
            this.Controls.Add(this.tBoxWeight);
            this.Controls.Add(this.tBoxHeight);
            this.Controls.Add(this.btnManual);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.btnBad);
            this.Controls.Add(this.pboxToy);
            this.Controls.Add(this.pboxDesk);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GameFrame";
            this.Text = "AnomaToy!";
            this.Load += new System.EventHandler(this.GameFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxAccessoryYN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxToy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDesk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxToy;
        private System.Windows.Forms.PictureBox pboxDesk;
        private System.Windows.Forms.Button btnBad;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.TextBox tBoxHeight;
        private System.Windows.Forms.TextBox tBoxWeight;
        private System.Windows.Forms.PictureBox pboxAccessoryYN;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblAccessory;
        private System.Windows.Forms.Button btnGood;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScoreNum;
    }
}

