namespace RandomLabelMove
{
    partial class game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game));
            this.RaceBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Bet1 = new System.Windows.Forms.GroupBox();
            this.RacerSelect = new System.Windows.Forms.NumericUpDown();
            this.label_bike = new System.Windows.Forms.Label();
            this.anmountincredecrese = new System.Windows.Forms.NumericUpDown();
            this.bet_button = new System.Windows.Forms.Button();
            this.labelBetterName = new System.Windows.Forms.Label();
            this.dantelabel = new System.Windows.Forms.Label();
            this.jacklabel = new System.Windows.Forms.Label();
            this.sofialabel = new System.Windows.Forms.Label();
            this.labelbt = new System.Windows.Forms.Label();
            this.DanteradioButton = new System.Windows.Forms.RadioButton();
            this.JackradioButton = new System.Windows.Forms.RadioButton();
            this.SofiaradioButton = new System.Windows.Forms.RadioButton();
            this.betmin = new System.Windows.Forms.Label();
            this.bike4 = new System.Windows.Forms.PictureBox();
            this.bike3 = new System.Windows.Forms.PictureBox();
            this.bike2 = new System.Windows.Forms.PictureBox();
            this.bike1 = new System.Windows.Forms.PictureBox();
            this.racePicture = new System.Windows.Forms.PictureBox();
            this.Bet1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RacerSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anmountincredecrese)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bike4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bike3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bike2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bike1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // RaceBtn
            // 
            this.RaceBtn.Font = new System.Drawing.Font("Sitka Banner", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaceBtn.Location = new System.Drawing.Point(780, 462);
            this.RaceBtn.Name = "RaceBtn";
            this.RaceBtn.Size = new System.Drawing.Size(172, 85);
            this.RaceBtn.TabIndex = 3;
            this.RaceBtn.Text = "Race";
            this.RaceBtn.UseVisualStyleBackColor = true;
            this.RaceBtn.Click += new System.EventHandler(this.Racer_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Bet1
            // 
            this.Bet1.BackColor = System.Drawing.Color.Cornsilk;
            this.Bet1.Controls.Add(this.RacerSelect);
            this.Bet1.Controls.Add(this.label_bike);
            this.Bet1.Controls.Add(this.anmountincredecrese);
            this.Bet1.Controls.Add(this.bet_button);
            this.Bet1.Controls.Add(this.labelBetterName);
            this.Bet1.Controls.Add(this.dantelabel);
            this.Bet1.Controls.Add(this.jacklabel);
            this.Bet1.Controls.Add(this.sofialabel);
            this.Bet1.Controls.Add(this.labelbt);
            this.Bet1.Controls.Add(this.DanteradioButton);
            this.Bet1.Controls.Add(this.JackradioButton);
            this.Bet1.Controls.Add(this.SofiaradioButton);
            this.Bet1.Controls.Add(this.betmin);
            this.Bet1.Location = new System.Drawing.Point(12, 402);
            this.Bet1.Name = "Bet1";
            this.Bet1.Size = new System.Drawing.Size(724, 188);
            this.Bet1.TabIndex = 9;
            this.Bet1.TabStop = false;
            this.Bet1.Text = "Bet";
            // 
            // RacerSelect
            // 
            this.RacerSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RacerSelect.Location = new System.Drawing.Point(411, 66);
            this.RacerSelect.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.RacerSelect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RacerSelect.Name = "RacerSelect";
            this.RacerSelect.Size = new System.Drawing.Size(45, 22);
            this.RacerSelect.TabIndex = 16;
            this.RacerSelect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_bike
            // 
            this.label_bike.AutoSize = true;
            this.label_bike.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bike.Location = new System.Drawing.Point(262, 72);
            this.label_bike.Name = "label_bike";
            this.label_bike.Size = new System.Drawing.Size(119, 16);
            this.label_bike.TabIndex = 15;
            this.label_bike.Text = "dollars on racer no";
            // 
            // anmountincredecrese
            // 
            this.anmountincredecrese.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anmountincredecrese.Location = new System.Drawing.Point(185, 66);
            this.anmountincredecrese.Name = "anmountincredecrese";
            this.anmountincredecrese.Size = new System.Drawing.Size(45, 22);
            this.anmountincredecrese.TabIndex = 14;
            this.anmountincredecrese.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bet_button
            // 
            this.bet_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bet_button.Location = new System.Drawing.Point(100, 65);
            this.bet_button.Name = "bet_button";
            this.bet_button.Size = new System.Drawing.Size(54, 23);
            this.bet_button.TabIndex = 13;
            this.bet_button.Text = "Bets";
            this.bet_button.UseVisualStyleBackColor = true;
            this.bet_button.Click += new System.EventHandler(this.Betting_Click);
            // 
            // labelBetterName
            // 
            this.labelBetterName.AutoSize = true;
            this.labelBetterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBetterName.Location = new System.Drawing.Point(24, 68);
            this.labelBetterName.Name = "labelBetterName";
            this.labelBetterName.Size = new System.Drawing.Size(42, 16);
            this.labelBetterName.TabIndex = 12;
            this.labelBetterName.Text = "name";
            // 
            // dantelabel
            // 
            this.dantelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dantelabel.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dantelabel.Location = new System.Drawing.Point(231, 146);
            this.dantelabel.Name = "dantelabel";
            this.dantelabel.Size = new System.Drawing.Size(201, 23);
            this.dantelabel.TabIndex = 11;
            this.dantelabel.Text = "Dantelb";
            // 
            // jacklabel
            // 
            this.jacklabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jacklabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jacklabel.Location = new System.Drawing.Point(465, 144);
            this.jacklabel.Name = "jacklabel";
            this.jacklabel.Size = new System.Drawing.Size(201, 23);
            this.jacklabel.TabIndex = 10;
            this.jacklabel.Text = "jacklb";
            this.jacklabel.Click += new System.EventHandler(this.jacklabel_Click);
            // 
            // sofialabel
            // 
            this.sofialabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sofialabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sofialabel.Location = new System.Drawing.Point(6, 146);
            this.sofialabel.Name = "sofialabel";
            this.sofialabel.Size = new System.Drawing.Size(201, 25);
            this.sofialabel.TabIndex = 9;
            this.sofialabel.Text = "Sofialb";
            // 
            // labelbt
            // 
            this.labelbt.AutoSize = true;
            this.labelbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbt.Location = new System.Drawing.Point(276, 118);
            this.labelbt.Name = "labelbt";
            this.labelbt.Size = new System.Drawing.Size(84, 16);
            this.labelbt.TabIndex = 8;
            this.labelbt.Text = "Bet Placed";
            this.labelbt.Click += new System.EventHandler(this.labelbt_Click);
            // 
            // DanteradioButton
            // 
            this.DanteradioButton.AutoSize = true;
            this.DanteradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanteradioButton.Location = new System.Drawing.Point(280, 19);
            this.DanteradioButton.Name = "DanteradioButton";
            this.DanteradioButton.Size = new System.Drawing.Size(80, 20);
            this.DanteradioButton.TabIndex = 7;
            this.DanteradioButton.TabStop = true;
            this.DanteradioButton.Text = "DanteRb";
            this.DanteradioButton.UseVisualStyleBackColor = true;
            this.DanteradioButton.CheckedChanged += new System.EventHandler(this.danteRB_CheckedChanged);
            // 
            // JackradioButton
            // 
            this.JackradioButton.AutoSize = true;
            this.JackradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JackradioButton.Location = new System.Drawing.Point(157, 19);
            this.JackradioButton.Name = "JackradioButton";
            this.JackradioButton.Size = new System.Drawing.Size(73, 20);
            this.JackradioButton.TabIndex = 6;
            this.JackradioButton.TabStop = true;
            this.JackradioButton.Text = "JackRb";
            this.JackradioButton.UseVisualStyleBackColor = true;
            this.JackradioButton.CheckedChanged += new System.EventHandler(this.jackrb_CheckedChanged);
            // 
            // SofiaradioButton
            // 
            this.SofiaradioButton.AutoSize = true;
            this.SofiaradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SofiaradioButton.Location = new System.Drawing.Point(27, 19);
            this.SofiaradioButton.Name = "SofiaradioButton";
            this.SofiaradioButton.Size = new System.Drawing.Size(75, 20);
            this.SofiaradioButton.TabIndex = 5;
            this.SofiaradioButton.TabStop = true;
            this.SofiaradioButton.Text = "SofiaRb";
            this.SofiaradioButton.UseVisualStyleBackColor = true;
            this.SofiaradioButton.CheckedChanged += new System.EventHandler(this.Sofiarb_CheckedChanged);
            // 
            // betmin
            // 
            this.betmin.AutoSize = true;
            this.betmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betmin.Location = new System.Drawing.Point(12, 118);
            this.betmin.Name = "betmin";
            this.betmin.Size = new System.Drawing.Size(54, 16);
            this.betmin.TabIndex = 4;
            this.betmin.Text = "betmin";
            // 
            // bike4
            // 
            this.bike4.Image = global::bikerace.Properties.Resources.bike;
            this.bike4.Location = new System.Drawing.Point(12, 286);
            this.bike4.Name = "bike4";
            this.bike4.Size = new System.Drawing.Size(108, 56);
            this.bike4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bike4.TabIndex = 7;
            this.bike4.TabStop = false;
            this.bike4.Click += new System.EventHandler(this.bike4_Click);
            // 
            // bike3
            // 
            this.bike3.Image = global::bikerace.Properties.Resources.bike;
            this.bike3.Location = new System.Drawing.Point(12, 205);
            this.bike3.Name = "bike3";
            this.bike3.Size = new System.Drawing.Size(108, 57);
            this.bike3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bike3.TabIndex = 6;
            this.bike3.TabStop = false;
            // 
            // bike2
            // 
            this.bike2.Image = global::bikerace.Properties.Resources.bike;
            this.bike2.Location = new System.Drawing.Point(12, 132);
            this.bike2.Name = "bike2";
            this.bike2.Size = new System.Drawing.Size(108, 51);
            this.bike2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bike2.TabIndex = 5;
            this.bike2.TabStop = false;
            // 
            // bike1
            // 
            this.bike1.Image = global::bikerace.Properties.Resources.bike;
            this.bike1.Location = new System.Drawing.Point(12, 55);
            this.bike1.Name = "bike1";
            this.bike1.Size = new System.Drawing.Size(108, 53);
            this.bike1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bike1.TabIndex = 4;
            this.bike1.TabStop = false;
            // 
            // racePicture
            // 
            this.racePicture.Image = ((System.Drawing.Image)(resources.GetObject("racePicture.Image")));
            this.racePicture.Location = new System.Drawing.Point(-1, 0);
            this.racePicture.Name = "racePicture";
            this.racePicture.Size = new System.Drawing.Size(1037, 396);
            this.racePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racePicture.TabIndex = 8;
            this.racePicture.TabStop = false;
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 602);
            this.Controls.Add(this.Bet1);
            this.Controls.Add(this.bike4);
            this.Controls.Add(this.bike3);
            this.Controls.Add(this.bike2);
            this.Controls.Add(this.bike1);
            this.Controls.Add(this.RaceBtn);
            this.Controls.Add(this.racePicture);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "game";
            this.Text = "Form1";
            this.Bet1.ResumeLayout(false);
            this.Bet1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RacerSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anmountincredecrese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bike4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bike3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bike2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bike1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RaceBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox bike1;
        private System.Windows.Forms.PictureBox bike2;
        private System.Windows.Forms.PictureBox bike3;
        private System.Windows.Forms.PictureBox bike4;
        private System.Windows.Forms.PictureBox racePicture;
        private System.Windows.Forms.GroupBox Bet1;
        private System.Windows.Forms.Label betmin;
        private System.Windows.Forms.NumericUpDown RacerSelect;
        private System.Windows.Forms.Label label_bike;
        private System.Windows.Forms.NumericUpDown anmountincredecrese;
        private System.Windows.Forms.Button bet_button;
        private System.Windows.Forms.Label labelBetterName;
        private System.Windows.Forms.Label dantelabel;
        private System.Windows.Forms.Label jacklabel;
        private System.Windows.Forms.Label sofialabel;
        private System.Windows.Forms.Label labelbt;
        private System.Windows.Forms.RadioButton DanteradioButton;
        private System.Windows.Forms.RadioButton JackradioButton;
        private System.Windows.Forms.RadioButton SofiaradioButton;
    }
}

