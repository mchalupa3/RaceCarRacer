namespace RaceCarRacer
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
            this.btnGo = new System.Windows.Forms.Button();
            this.lblRaceResult = new System.Windows.Forms.Label();
            this.picFinishLine = new System.Windows.Forms.PictureBox();
            this.PicRedCar = new System.Windows.Forms.PictureBox();
            this.picYellowCar = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblYellowWins = new System.Windows.Forms.Label();
            this.lblRedWins = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFinishLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicRedCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYellowCar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(303, 356);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblRaceResult
            // 
            this.lblRaceResult.AutoSize = true;
            this.lblRaceResult.Location = new System.Drawing.Point(300, 319);
            this.lblRaceResult.Name = "lblRaceResult";
            this.lblRaceResult.Size = new System.Drawing.Size(0, 13);
            this.lblRaceResult.TabIndex = 3;
            // 
            // picFinishLine
            // 
            this.picFinishLine.Image = global::RaceCarRacer.Properties.Resources.g1407_512;
            this.picFinishLine.Location = new System.Drawing.Point(700, 10);
            this.picFinishLine.Name = "picFinishLine";
            this.picFinishLine.Size = new System.Drawing.Size(146, 63);
            this.picFinishLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFinishLine.TabIndex = 4;
            this.picFinishLine.TabStop = false;
            // 
            // PicRedCar
            // 
            this.PicRedCar.Image = global::RaceCarRacer.Properties.Resources.racecar;
            this.PicRedCar.Location = new System.Drawing.Point(100, 250);
            this.PicRedCar.Name = "PicRedCar";
            this.PicRedCar.Size = new System.Drawing.Size(100, 50);
            this.PicRedCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicRedCar.TabIndex = 1;
            this.PicRedCar.TabStop = false;
            // 
            // picYellowCar
            // 
            this.picYellowCar.Image = global::RaceCarRacer.Properties.Resources.yellowCar;
            this.picYellowCar.Location = new System.Drawing.Point(100, 150);
            this.picYellowCar.Name = "picYellowCar";
            this.picYellowCar.Size = new System.Drawing.Size(91, 50);
            this.picYellowCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picYellowCar.TabIndex = 0;
            this.picYellowCar.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(467, 356);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset Race";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblYellowWins
            // 
            this.lblYellowWins.AutoSize = true;
            this.lblYellowWins.Location = new System.Drawing.Point(100, 39);
            this.lblYellowWins.Name = "lblYellowWins";
            this.lblYellowWins.Size = new System.Drawing.Size(0, 13);
            this.lblYellowWins.TabIndex = 6;
            // 
            // lblRedWins
            // 
            this.lblRedWins.AutoSize = true;
            this.lblRedWins.Location = new System.Drawing.Point(103, 71);
            this.lblRedWins.Name = "lblRedWins";
            this.lblRedWins.Size = new System.Drawing.Size(0, 13);
            this.lblRedWins.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 453);
            this.Controls.Add(this.lblRedWins);
            this.Controls.Add(this.lblYellowWins);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.picFinishLine);
            this.Controls.Add(this.lblRaceResult);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.PicRedCar);
            this.Controls.Add(this.picYellowCar);
            this.Name = "Form1";
            this.Text = "The Race";
            ((System.ComponentModel.ISupportInitialize)(this.picFinishLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicRedCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYellowCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picYellowCar;
        private System.Windows.Forms.PictureBox PicRedCar;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblRaceResult;
        private System.Windows.Forms.PictureBox picFinishLine;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblYellowWins;
        private System.Windows.Forms.Label lblRedWins;
    }
}

