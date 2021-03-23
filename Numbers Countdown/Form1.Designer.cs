
namespace Numbers_Countdown
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
            this._buttNoneLarge = new System.Windows.Forms.Button();
            this._buttOneLage = new System.Windows.Forms.Button();
            this._buttTwoLarge = new System.Windows.Forms.Button();
            this._buttThreeLarge = new System.Windows.Forms.Button();
            this._buttFourLarge = new System.Windows.Forms.Button();
            this._buttPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _buttNoneLarge
            // 
            this._buttNoneLarge.Location = new System.Drawing.Point(160, 138);
            this._buttNoneLarge.Name = "_buttNoneLarge";
            this._buttNoneLarge.Size = new System.Drawing.Size(75, 23);
            this._buttNoneLarge.TabIndex = 0;
            this._buttNoneLarge.Text = "None";
            this._buttNoneLarge.UseVisualStyleBackColor = true;
            this._buttNoneLarge.Click += new System.EventHandler(this._selectedClick);
            // 
            // _buttOneLage
            // 
            this._buttOneLage.Location = new System.Drawing.Point(160, 167);
            this._buttOneLage.Name = "_buttOneLage";
            this._buttOneLage.Size = new System.Drawing.Size(75, 23);
            this._buttOneLage.TabIndex = 1;
            this._buttOneLage.Text = "1 Large";
            this._buttOneLage.UseVisualStyleBackColor = true;
            this._buttOneLage.Click += new System.EventHandler(this._selectedClick);
            // 
            // _buttTwoLarge
            // 
            this._buttTwoLarge.Location = new System.Drawing.Point(160, 196);
            this._buttTwoLarge.Name = "_buttTwoLarge";
            this._buttTwoLarge.Size = new System.Drawing.Size(75, 23);
            this._buttTwoLarge.TabIndex = 2;
            this._buttTwoLarge.Text = "2 Large";
            this._buttTwoLarge.UseVisualStyleBackColor = true;
            this._buttTwoLarge.Click += new System.EventHandler(this._selectedClick);
            // 
            // _buttThreeLarge
            // 
            this._buttThreeLarge.Location = new System.Drawing.Point(160, 225);
            this._buttThreeLarge.Name = "_buttThreeLarge";
            this._buttThreeLarge.Size = new System.Drawing.Size(75, 23);
            this._buttThreeLarge.TabIndex = 3;
            this._buttThreeLarge.Text = "3 Large";
            this._buttThreeLarge.UseVisualStyleBackColor = true;
            this._buttThreeLarge.Click += new System.EventHandler(this._selectedClick);
            // 
            // _buttFourLarge
            // 
            this._buttFourLarge.Location = new System.Drawing.Point(160, 254);
            this._buttFourLarge.Name = "_buttFourLarge";
            this._buttFourLarge.Size = new System.Drawing.Size(75, 23);
            this._buttFourLarge.TabIndex = 4;
            this._buttFourLarge.Text = "4 Large";
            this._buttFourLarge.UseVisualStyleBackColor = true;
            this._buttFourLarge.Click += new System.EventHandler(this._selectedClick);
            // 
            // _buttPlay
            // 
            this._buttPlay.Location = new System.Drawing.Point(160, 415);
            this._buttPlay.Name = "_buttPlay";
            this._buttPlay.Size = new System.Drawing.Size(75, 23);
            this._buttPlay.TabIndex = 5;
            this._buttPlay.Text = "Play";
            this._buttPlay.UseVisualStyleBackColor = true;
            this._buttPlay.Click += new System.EventHandler(this._buttPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 450);
            this.Controls.Add(this._buttPlay);
            this.Controls.Add(this._buttFourLarge);
            this.Controls.Add(this._buttThreeLarge);
            this.Controls.Add(this._buttTwoLarge);
            this.Controls.Add(this._buttOneLage);
            this.Controls.Add(this._buttNoneLarge);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _buttNoneLarge;
        private System.Windows.Forms.Button _buttOneLage;
        private System.Windows.Forms.Button _buttTwoLarge;
        private System.Windows.Forms.Button _buttThreeLarge;
        private System.Windows.Forms.Button _buttFourLarge;
        private System.Windows.Forms.Button _buttPlay;
    }
}

