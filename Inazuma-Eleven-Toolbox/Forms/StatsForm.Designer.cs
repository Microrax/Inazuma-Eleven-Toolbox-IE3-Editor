namespace Inazuma_Eleven_Toolbox.Forms
{
    partial class StatsForm
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
            this.cmbBoxGameVer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBoxRGN = new System.Windows.Forms.ComboBox();
            this.btn_Show_Stats = new System.Windows.Forms.Button();
            this.dataGridViewStats = new System.Windows.Forms.DataGridView();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Element = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Body = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Control = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stamina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Move1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LearnAt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Move2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LearnAt2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Move3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LearnAt3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Move4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LearnAt4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScoutHex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.save_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStats)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBoxGameVer
            // 
            this.cmbBoxGameVer.FormattingEnabled = true;
            this.cmbBoxGameVer.Items.AddRange(new object[] {
            "Inazuma Eleven",
            "Inazuma Eleven 2",
            "Inazuma Eleven 3"});
            this.cmbBoxGameVer.Location = new System.Drawing.Point(141, 17);
            this.cmbBoxGameVer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBoxGameVer.Name = "cmbBoxGameVer";
            this.cmbBoxGameVer.Size = new System.Drawing.Size(180, 28);
            this.cmbBoxGameVer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game Version:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Region:";
            // 
            // cmbBoxRGN
            // 
            this.cmbBoxRGN.FormattingEnabled = true;
            this.cmbBoxRGN.Items.AddRange(new object[] {
            "EUR",
            "JAP"});
            this.cmbBoxRGN.Location = new System.Drawing.Point(406, 17);
            this.cmbBoxRGN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBoxRGN.Name = "cmbBoxRGN";
            this.cmbBoxRGN.Size = new System.Drawing.Size(102, 28);
            this.cmbBoxRGN.TabIndex = 3;
            // 
            // btn_Show_Stats
            // 
            this.btn_Show_Stats.Location = new System.Drawing.Point(519, 14);
            this.btn_Show_Stats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Show_Stats.Name = "btn_Show_Stats";
            this.btn_Show_Stats.Size = new System.Drawing.Size(140, 35);
            this.btn_Show_Stats.TabIndex = 4;
            this.btn_Show_Stats.Text = "Load Stats!";
            this.btn_Show_Stats.UseVisualStyleBackColor = true;
            this.btn_Show_Stats.Click += new System.EventHandler(this.btn_Show_Stats_Click);
            // 
            // dataGridViewStats
            // 
            this.dataGridViewStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStats.ColumnHeadersHeight = 34;
            this.dataGridViewStats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.Position,
            this.Gender,
            this.Element,
            this.FP,
            this.TP,
            this.Kick,
            this.Body,
            this.Control,
            this.Guard,
            this.Speed,
            this.Stamina,
            this.Guts,
            this.Column16,
            this.Column17,
            this.Move1,
            this.LearnAt1,
            this.Move2,
            this.LearnAt2,
            this.Move3,
            this.LearnAt3,
            this.Move4,
            this.LearnAt4,
            this.Exp,
            this.ScoutHex});
            this.dataGridViewStats.Location = new System.Drawing.Point(22, 55);
            this.dataGridViewStats.Margin = new System.Windows.Forms.Padding(5, 5, 4, 5);
            this.dataGridViewStats.MaximumSize = new System.Drawing.Size(1800, 1000);
            this.dataGridViewStats.Name = "dataGridViewStats";
            this.dataGridViewStats.RowHeadersWidth = 62;
            this.dataGridViewStats.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewStats.Size = new System.Drawing.Size(1569, 269);
            this.dataGridViewStats.TabIndex = 5;
            this.dataGridViewStats.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStats_CellContentClick);
            // 
            // FullName
            // 
            this.FullName.FillWeight = 323.0309F;
            this.FullName.HeaderText = "Full Name";
            this.FullName.MinimumWidth = 8;
            this.FullName.Name = "FullName";
            this.FullName.Width = 120;
            // 
            // Position
            // 
            this.Position.FillWeight = 65.7506F;
            this.Position.HeaderText = "Position";
            this.Position.MinimumWidth = 8;
            this.Position.Name = "Position";
            this.Position.Width = 25;
            // 
            // Gender
            // 
            this.Gender.FillWeight = 107.8355F;
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 8;
            this.Gender.Name = "Gender";
            this.Gender.Width = 40;
            // 
            // Element
            // 
            this.Element.FillWeight = 100.3336F;
            this.Element.HeaderText = "Element";
            this.Element.MinimumWidth = 8;
            this.Element.Name = "Element";
            this.Element.Width = 38;
            // 
            // FP
            // 
            this.FP.FillWeight = 58.11647F;
            this.FP.HeaderText = "FP";
            this.FP.MinimumWidth = 8;
            this.FP.Name = "FP";
            this.FP.Width = 21;
            // 
            // TP
            // 
            this.TP.FillWeight = 57.29548F;
            this.TP.HeaderText = "TP";
            this.TP.MinimumWidth = 8;
            this.TP.Name = "TP";
            this.TP.Width = 21;
            // 
            // Kick
            // 
            this.Kick.FillWeight = 47.08255F;
            this.Kick.HeaderText = "Kick";
            this.Kick.MinimumWidth = 8;
            this.Kick.Name = "Kick";
            this.Kick.Width = 18;
            // 
            // Body
            // 
            this.Body.FillWeight = 46.67342F;
            this.Body.HeaderText = "Body";
            this.Body.MinimumWidth = 8;
            this.Body.Name = "Body";
            this.Body.Width = 17;
            // 
            // Control
            // 
            this.Control.FillWeight = 46.27449F;
            this.Control.HeaderText = "Control";
            this.Control.MinimumWidth = 8;
            this.Control.Name = "Control";
            this.Control.Width = 17;
            // 
            // Guard
            // 
            this.Guard.FillWeight = 45.8855F;
            this.Guard.HeaderText = "Guard";
            this.Guard.MinimumWidth = 8;
            this.Guard.Name = "Guard";
            this.Guard.Width = 17;
            // 
            // Speed
            // 
            this.Speed.FillWeight = 45.5062F;
            this.Speed.HeaderText = "Speed";
            this.Speed.MinimumWidth = 8;
            this.Speed.Name = "Speed";
            this.Speed.Width = 17;
            // 
            // Stamina
            // 
            this.Stamina.FillWeight = 45.13638F;
            this.Stamina.HeaderText = "Stamina";
            this.Stamina.MinimumWidth = 8;
            this.Stamina.Name = "Stamina";
            this.Stamina.Width = 17;
            // 
            // Guts
            // 
            this.Guts.FillWeight = 44.77575F;
            this.Guts.HeaderText = "Guts";
            this.Guts.MinimumWidth = 8;
            this.Guts.Name = "Guts";
            this.Guts.Width = 17;
            // 
            // Column16
            // 
            this.Column16.FillWeight = 53.30896F;
            this.Column16.HeaderText = "Freedom";
            this.Column16.MinimumWidth = 8;
            this.Column16.Name = "Column16";
            this.Column16.Width = 20;
            // 
            // Column17
            // 
            this.Column17.FillWeight = 87.71959F;
            this.Column17.HeaderText = "Total";
            this.Column17.MinimumWidth = 8;
            this.Column17.Name = "Column17";
            this.Column17.Width = 32;
            // 
            // Move1
            // 
            this.Move1.FillWeight = 213.6507F;
            this.Move1.HeaderText = "Move 1";
            this.Move1.MinimumWidth = 8;
            this.Move1.Name = "Move1";
            this.Move1.Width = 79;
            // 
            // LearnAt1
            // 
            this.LearnAt1.FillWeight = 102.2722F;
            this.LearnAt1.HeaderText = "Learns At";
            this.LearnAt1.MinimumWidth = 8;
            this.LearnAt1.Name = "LearnAt1";
            this.LearnAt1.Width = 38;
            // 
            // Move2
            // 
            this.Move2.FillWeight = 180.6535F;
            this.Move2.HeaderText = "Move 2";
            this.Move2.MinimumWidth = 8;
            this.Move2.Name = "Move2";
            this.Move2.Width = 67;
            // 
            // LearnAt2
            // 
            this.LearnAt2.FillWeight = 86.80738F;
            this.LearnAt2.HeaderText = "Learns At";
            this.LearnAt2.MinimumWidth = 8;
            this.LearnAt2.Name = "LearnAt2";
            this.LearnAt2.Width = 32;
            // 
            // Move3
            // 
            this.Move3.FillWeight = 153.9375F;
            this.Move3.HeaderText = "Move 3";
            this.Move3.MinimumWidth = 8;
            this.Move3.Name = "Move3";
            this.Move3.Width = 58;
            // 
            // LearnAt3
            // 
            this.LearnAt3.FillWeight = 74.28635F;
            this.LearnAt3.HeaderText = "Learns At";
            this.LearnAt3.MinimumWidth = 8;
            this.LearnAt3.Name = "LearnAt3";
            this.LearnAt3.Width = 27;
            // 
            // Move4
            // 
            this.Move4.FillWeight = 132.3071F;
            this.Move4.HeaderText = "Move 4";
            this.Move4.MinimumWidth = 8;
            this.Move4.Name = "Move4";
            this.Move4.Width = 49;
            // 
            // LearnAt4
            // 
            this.LearnAt4.FillWeight = 64.14883F;
            this.LearnAt4.HeaderText = "Learns At";
            this.LearnAt4.MinimumWidth = 8;
            this.LearnAt4.Name = "LearnAt4";
            this.LearnAt4.Width = 24;
            // 
            // Exp
            // 
            this.Exp.HeaderText = "Exp";
            this.Exp.MinimumWidth = 8;
            this.Exp.Name = "Exp";
            this.Exp.Width = 70;
            // 
            // ScoutHex
            // 
            this.ScoutHex.HeaderText = "ScoutHex";
            this.ScoutHex.MinimumWidth = 8;
            this.ScoutHex.Name = "ScoutHex";
            this.ScoutHex.Width = 150;
            // 
            // save_Button
            // 
            this.save_Button.Location = new System.Drawing.Point(688, 13);
            this.save_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(140, 35);
            this.save_Button.TabIndex = 6;
            this.save_Button.Text = "Save Stats!";
            this.save_Button.UseVisualStyleBackColor = true;
            this.save_Button.Click += new System.EventHandler(this.save_Button_Click);
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1605, 932);
            this.Controls.Add(this.save_Button);
            this.Controls.Add(this.dataGridViewStats);
            this.Controls.Add(this.btn_Show_Stats);
            this.Controls.Add(this.cmbBoxRGN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxGameVer);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StatsForm";
            this.Text = "Player Stats";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoxGameVer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBoxRGN;
        private System.Windows.Forms.Button btn_Show_Stats;
        private System.Windows.Forms.DataGridView dataGridViewStats;
        private System.Windows.Forms.Button save_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Element;
        private System.Windows.Forms.DataGridViewTextBoxColumn FP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kick;
        private System.Windows.Forms.DataGridViewTextBoxColumn Body;
        private System.Windows.Forms.DataGridViewTextBoxColumn Control;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stamina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Move1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LearnAt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Move2;
        private System.Windows.Forms.DataGridViewTextBoxColumn LearnAt2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Move3;
        private System.Windows.Forms.DataGridViewTextBoxColumn LearnAt3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Move4;
        private System.Windows.Forms.DataGridViewTextBoxColumn LearnAt4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScoutHex;
    }
}