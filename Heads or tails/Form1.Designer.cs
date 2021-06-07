namespace Heads_or_tails
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
            this.btnreset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblheads = new System.Windows.Forms.Label();
            this.lbltails = new System.Windows.Forms.Label();
            this.lblheadsseries = new System.Windows.Forms.Label();
            this.lbltailsseries = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblflips = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnstart = new System.Windows.Forms.Button();
            this.btnflip = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnslower = new System.Windows.Forms.Button();
            this.btnfaster = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblmostdistance = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnreset.Location = new System.Drawing.Point(670, 180);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(95, 82);
            this.btnreset.TabIndex = 5;
            this.btnreset.Text = "reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Heads";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tails";
            // 
            // lblheads
            // 
            this.lblheads.AutoSize = true;
            this.lblheads.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblheads.Location = new System.Drawing.Point(12, 68);
            this.lblheads.Name = "lblheads";
            this.lblheads.Size = new System.Drawing.Size(87, 95);
            this.lblheads.TabIndex = 2;
            this.lblheads.Text = "0";
            // 
            // lbltails
            // 
            this.lbltails.AutoSize = true;
            this.lbltails.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltails.Location = new System.Drawing.Point(12, 235);
            this.lbltails.Name = "lbltails";
            this.lbltails.Size = new System.Drawing.Size(87, 95);
            this.lbltails.TabIndex = 2;
            this.lbltails.Text = "0";
            // 
            // lblheadsseries
            // 
            this.lblheadsseries.AutoSize = true;
            this.lblheadsseries.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblheadsseries.Location = new System.Drawing.Point(140, 16);
            this.lblheadsseries.Name = "lblheadsseries";
            this.lblheadsseries.Size = new System.Drawing.Size(43, 48);
            this.lblheadsseries.TabIndex = 3;
            this.lblheadsseries.Text = "0";
            // 
            // lbltailsseries
            // 
            this.lbltailsseries.AutoSize = true;
            this.lbltailsseries.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltailsseries.Location = new System.Drawing.Point(140, 180);
            this.lbltailsseries.Name = "lbltailsseries";
            this.lbltailsseries.Size = new System.Drawing.Size(43, 48);
            this.lbltailsseries.TabIndex = 3;
            this.lbltailsseries.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(423, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "flips";
            // 
            // lblflips
            // 
            this.lblflips.AutoSize = true;
            this.lblflips.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblflips.Location = new System.Drawing.Point(441, 59);
            this.lblflips.Name = "lblflips";
            this.lblflips.Size = new System.Drawing.Size(27, 29);
            this.lblflips.TabIndex = 5;
            this.lblflips.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnstart
            // 
            this.btnstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnstart.Location = new System.Drawing.Point(670, 4);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(95, 82);
            this.btnstart.TabIndex = 0;
            this.btnstart.Text = "start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnflip
            // 
            this.btnflip.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnflip.Location = new System.Drawing.Point(670, 268);
            this.btnflip.Name = "btnflip";
            this.btnflip.Size = new System.Drawing.Size(95, 82);
            this.btnflip.TabIndex = 3;
            this.btnflip.Text = "flip";
            this.btnflip.UseVisualStyleBackColor = true;
            this.btnflip.Click += new System.EventHandler(this.btnflip_Click);
            // 
            // btnstop
            // 
            this.btnstop.Enabled = false;
            this.btnstop.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnstop.Location = new System.Drawing.Point(670, 92);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(95, 82);
            this.btnstop.TabIndex = 1;
            this.btnstop.Text = "stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(558, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "speed";
            // 
            // btnslower
            // 
            this.btnslower.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnslower.Location = new System.Drawing.Point(590, 59);
            this.btnslower.Name = "btnslower";
            this.btnslower.Size = new System.Drawing.Size(32, 29);
            this.btnslower.TabIndex = 4;
            this.btnslower.Text = "+";
            this.btnslower.UseVisualStyleBackColor = true;
            this.btnslower.Click += new System.EventHandler(this.btnslower_Click);
            // 
            // btnfaster
            // 
            this.btnfaster.Enabled = false;
            this.btnfaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnfaster.Location = new System.Drawing.Point(590, 262);
            this.btnfaster.Name = "btnfaster";
            this.btnfaster.Size = new System.Drawing.Size(32, 29);
            this.btnfaster.TabIndex = 7;
            this.btnfaster.Text = "-";
            this.btnfaster.UseVisualStyleBackColor = true;
            this.btnfaster.Click += new System.EventHandler(this.btnfaster_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(595, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 39);
            this.label5.TabIndex = 8;
            this.label5.Text = "|";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(595, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 39);
            this.label6.TabIndex = 8;
            this.label6.Text = "|";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(595, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 39);
            this.label7.TabIndex = 8;
            this.label7.Text = "|";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(595, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 39);
            this.label8.TabIndex = 8;
            this.label8.Text = "|";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(372, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 29);
            this.label9.TabIndex = 9;
            this.label9.Text = "farthest distance";
            // 
            // lblmostdistance
            // 
            this.lblmostdistance.AutoSize = true;
            this.lblmostdistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmostdistance.Location = new System.Drawing.Point(421, 180);
            this.lblmostdistance.Name = "lblmostdistance";
            this.lblmostdistance.Size = new System.Drawing.Size(87, 95);
            this.lblmostdistance.TabIndex = 10;
            this.lblmostdistance.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(189, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 29);
            this.label10.TabIndex = 11;
            this.label10.Text = "in a row";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(189, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 29);
            this.label11.TabIndex = 11;
            this.label11.Text = "in a row";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 369);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblmostdistance);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnfaster);
            this.Controls.Add(this.btnslower);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnflip);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.lblflips);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbltailsseries);
            this.Controls.Add(this.lblheadsseries);
            this.Controls.Add(this.lbltails);
            this.Controls.Add(this.lblheads);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnreset);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Heads&Tails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblheads;
        private System.Windows.Forms.Label lbltails;
        private System.Windows.Forms.Label lblheadsseries;
        private System.Windows.Forms.Label lbltailsseries;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblflips;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnflip;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnslower;
        private System.Windows.Forms.Button btnfaster;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblmostdistance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

