namespace Object_Oriented_Assessment
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
            this.rbJoe = new System.Windows.Forms.RadioButton();
            this.rbBob = new System.Windows.Forms.RadioButton();
            this.rbAl = new System.Windows.Forms.RadioButton();
            this.nudBettor = new System.Windows.Forms.NumericUpDown();
            this.nudDog = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMaxBet = new System.Windows.Forms.Label();
            this.txtJoe = new System.Windows.Forms.TextBox();
            this.txtBob = new System.Windows.Forms.TextBox();
            this.txtAl = new System.Windows.Forms.TextBox();
            this.btnPlaceBet = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRace = new System.Windows.Forms.Button();
            this.lbJoe = new System.Windows.Forms.Label();
            this.lbBob = new System.Windows.Forms.Label();
            this.lbAl = new System.Windows.Forms.Label();
            this.pbRaceStart = new System.Windows.Forms.PictureBox();
            this.designPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudBettor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceStart)).BeginInit();
            this.SuspendLayout();
            // 
            // rbJoe
            // 
            this.rbJoe.AutoSize = true;
            this.rbJoe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbJoe.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJoe.ForeColor = System.Drawing.SystemColors.Control;
            this.rbJoe.Location = new System.Drawing.Point(27, 363);
            this.rbJoe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbJoe.Name = "rbJoe";
            this.rbJoe.Size = new System.Drawing.Size(128, 21);
            this.rbJoe.TabIndex = 1;
            this.rbJoe.TabStop = true;
            this.rbJoe.Text = "JOE WHEELER";
            this.rbJoe.UseVisualStyleBackColor = false;
            // 
            // rbBob
            // 
            this.rbBob.AutoSize = true;
            this.rbBob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbBob.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBob.ForeColor = System.Drawing.SystemColors.Control;
            this.rbBob.Location = new System.Drawing.Point(27, 391);
            this.rbBob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbBob.Name = "rbBob";
            this.rbBob.Size = new System.Drawing.Size(131, 22);
            this.rbBob.TabIndex = 2;
            this.rbBob.TabStop = true;
            this.rbBob.Text = "BOB BURGER";
            this.rbBob.UseVisualStyleBackColor = false;
            // 
            // rbAl
            // 
            this.rbAl.AutoSize = true;
            this.rbAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbAl.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAl.ForeColor = System.Drawing.SystemColors.Control;
            this.rbAl.Location = new System.Drawing.Point(27, 419);
            this.rbAl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbAl.Name = "rbAl";
            this.rbAl.Size = new System.Drawing.Size(120, 21);
            this.rbAl.TabIndex = 3;
            this.rbAl.TabStop = true;
            this.rbAl.Text = "AL HANCOCK";
            this.rbAl.UseVisualStyleBackColor = false;
            // 
            // nudBettor
            // 
            this.nudBettor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.nudBettor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudBettor.ForeColor = System.Drawing.SystemColors.Control;
            this.nudBettor.Location = new System.Drawing.Point(76, 463);
            this.nudBettor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudBettor.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudBettor.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudBettor.Name = "nudBettor";
            this.nudBettor.Size = new System.Drawing.Size(64, 22);
            this.nudBettor.TabIndex = 4;
            this.nudBettor.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudBettor.ValueChanged += new System.EventHandler(this.nudBettor_ValueChanged);
            // 
            // nudDog
            // 
            this.nudDog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.nudDog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudDog.ForeColor = System.Drawing.SystemColors.Control;
            this.nudDog.Location = new System.Drawing.Point(284, 463);
            this.nudDog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudDog.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudDog.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDog.Name = "nudDog";
            this.nudDog.Size = new System.Drawing.Size(64, 22);
            this.nudDog.TabIndex = 5;
            this.nudDog.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(15, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "BET $:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(167, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "DOG NUMBER:";
            // 
            // lbMaxBet
            // 
            this.lbMaxBet.AutoSize = true;
            this.lbMaxBet.BackColor = System.Drawing.Color.Transparent;
            this.lbMaxBet.Font = new System.Drawing.Font("Rockwell Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaxBet.ForeColor = System.Drawing.SystemColors.Control;
            this.lbMaxBet.Location = new System.Drawing.Point(622, 356);
            this.lbMaxBet.Name = "lbMaxBet";
            this.lbMaxBet.Size = new System.Drawing.Size(122, 87);
            this.lbMaxBet.TabIndex = 8;
            this.lbMaxBet.Text = "INFORMATION\r\nMin Bet: $5\r\nMax Bet: $15";
            this.lbMaxBet.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtJoe
            // 
            this.txtJoe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.txtJoe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJoe.ForeColor = System.Drawing.SystemColors.Control;
            this.txtJoe.Location = new System.Drawing.Point(165, 363);
            this.txtJoe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJoe.Name = "txtJoe";
            this.txtJoe.ReadOnly = true;
            this.txtJoe.Size = new System.Drawing.Size(206, 22);
            this.txtJoe.TabIndex = 9;
            // 
            // txtBob
            // 
            this.txtBob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.txtBob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBob.ForeColor = System.Drawing.SystemColors.Control;
            this.txtBob.Location = new System.Drawing.Point(165, 390);
            this.txtBob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBob.Name = "txtBob";
            this.txtBob.ReadOnly = true;
            this.txtBob.Size = new System.Drawing.Size(206, 22);
            this.txtBob.TabIndex = 10;
            // 
            // txtAl
            // 
            this.txtAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.txtAl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAl.ForeColor = System.Drawing.SystemColors.Control;
            this.txtAl.Location = new System.Drawing.Point(165, 418);
            this.txtAl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAl.Name = "txtAl";
            this.txtAl.ReadOnly = true;
            this.txtAl.Size = new System.Drawing.Size(206, 22);
            this.txtAl.TabIndex = 11;
            // 
            // btnPlaceBet
            // 
            this.btnPlaceBet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPlaceBet.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPlaceBet.FlatAppearance.BorderSize = 2;
            this.btnPlaceBet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceBet.Font = new System.Drawing.Font("Franklin Gothic Book", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceBet.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPlaceBet.Location = new System.Drawing.Point(15, 498);
            this.btnPlaceBet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlaceBet.Name = "btnPlaceBet";
            this.btnPlaceBet.Size = new System.Drawing.Size(333, 50);
            this.btnPlaceBet.TabIndex = 12;
            this.btnPlaceBet.Text = "P L A C E   B E T !";
            this.btnPlaceBet.UseVisualStyleBackColor = false;
            this.btnPlaceBet.Click += new System.EventHandler(this.btnPlaceBet_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Franklin Gothic Book", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReset.Location = new System.Drawing.Point(361, 462);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(289, 34);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "R e s e t   R a c e";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRace
            // 
            this.btnRace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRace.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRace.FlatAppearance.BorderSize = 2;
            this.btnRace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRace.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRace.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRace.Location = new System.Drawing.Point(361, 500);
            this.btnRace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(289, 48);
            this.btnRace.TabIndex = 14;
            this.btnRace.Text = "R A C E !";
            this.btnRace.UseVisualStyleBackColor = false;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // lbJoe
            // 
            this.lbJoe.AutoSize = true;
            this.lbJoe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbJoe.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJoe.ForeColor = System.Drawing.SystemColors.Control;
            this.lbJoe.Location = new System.Drawing.Point(391, 363);
            this.lbJoe.Name = "lbJoe";
            this.lbJoe.Size = new System.Drawing.Size(86, 17);
            this.lbJoe.TabIndex = 19;
            this.lbJoe.Text = "Joe\'s Money";
            // 
            // lbBob
            // 
            this.lbBob.AutoSize = true;
            this.lbBob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbBob.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBob.ForeColor = System.Drawing.SystemColors.Control;
            this.lbBob.Location = new System.Drawing.Point(391, 391);
            this.lbBob.Name = "lbBob";
            this.lbBob.Size = new System.Drawing.Size(89, 17);
            this.lbBob.TabIndex = 21;
            this.lbBob.Text = "Bob\'s Money";
            // 
            // lbAl
            // 
            this.lbAl.AutoSize = true;
            this.lbAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbAl.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAl.ForeColor = System.Drawing.SystemColors.Control;
            this.lbAl.Location = new System.Drawing.Point(391, 418);
            this.lbAl.Name = "lbAl";
            this.lbAl.Size = new System.Drawing.Size(77, 17);
            this.lbAl.TabIndex = 22;
            this.lbAl.Text = "Al\'s Money";
            // 
            // pbRaceStart
            // 
            this.pbRaceStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbRaceStart.Image = global::Object_Oriented_Assessment.Properties.Resources.RaceStart;
            this.pbRaceStart.Location = new System.Drawing.Point(12, 12);
            this.pbRaceStart.Name = "pbRaceStart";
            this.pbRaceStart.Size = new System.Drawing.Size(724, 332);
            this.pbRaceStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRaceStart.TabIndex = 23;
            this.pbRaceStart.TabStop = false;
            // 
            // designPanel
            // 
            this.designPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.designPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.designPanel.ForeColor = System.Drawing.Color.Black;
            this.designPanel.Location = new System.Drawing.Point(15, 350);
            this.designPanel.Name = "designPanel";
            this.designPanel.Size = new System.Drawing.Size(525, 105);
            this.designPanel.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(22, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(522, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "D O G   R A C E   B E T T I N G   A P P L I C A T I O N";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(748, 559);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbRaceStart);
            this.Controls.Add(this.lbAl);
            this.Controls.Add(this.lbBob);
            this.Controls.Add(this.lbJoe);
            this.Controls.Add(this.btnRace);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPlaceBet);
            this.Controls.Add(this.txtAl);
            this.Controls.Add(this.txtBob);
            this.Controls.Add(this.txtJoe);
            this.Controls.Add(this.lbMaxBet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudDog);
            this.Controls.Add(this.nudBettor);
            this.Controls.Add(this.rbAl);
            this.Controls.Add(this.rbBob);
            this.Controls.Add(this.rbJoe);
            this.Controls.Add(this.designPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Welcome - Please Place Your Bets";
            ((System.ComponentModel.ISupportInitialize)(this.nudBettor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbJoe;
        private System.Windows.Forms.RadioButton rbBob;
        private System.Windows.Forms.RadioButton rbAl;
        private System.Windows.Forms.NumericUpDown nudBettor;
        private System.Windows.Forms.NumericUpDown nudDog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMaxBet;
        private System.Windows.Forms.TextBox txtJoe;
        private System.Windows.Forms.TextBox txtBob;
        private System.Windows.Forms.TextBox txtAl;
        private System.Windows.Forms.Button btnPlaceBet;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.Label lbJoe;
        private System.Windows.Forms.Label lbBob;
        private System.Windows.Forms.Label lbAl;
        private System.Windows.Forms.PictureBox pbRaceStart;
        private System.Windows.Forms.Panel designPanel;
        private System.Windows.Forms.Label label3;
    }
}

