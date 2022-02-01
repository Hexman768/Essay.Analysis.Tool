namespace NotepadSharp.Windows
{
    partial class SettingsForm
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
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.groupBoxTheme = new System.Windows.Forms.GroupBox();
            this.textColorLabel = new System.Windows.Forms.Label();
            this.txtClrBox = new System.Windows.Forms.PictureBox();
            this.backColorLabel = new System.Windows.Forms.Label();
            this.bckClrBox = new System.Windows.Forms.PictureBox();
            this.currentLineColorLabel = new System.Windows.Forms.Label();
            this.changedLineLbl = new System.Windows.Forms.Label();
            this.lineClrLbl = new System.Windows.Forms.Label();
            this.curLineClrBox = new System.Windows.Forms.PictureBox();
            this.chgLineClrBox = new System.Windows.Forms.PictureBox();
            this.lineNbrClrBox = new System.Windows.Forms.PictureBox();
            this.caretClrLbl = new System.Windows.Forms.Label();
            this.caretClrBox = new System.Windows.Forms.PictureBox();
            this.slctClrLbl = new System.Windows.Forms.Label();
            this.slctClrBox = new System.Windows.Forms.PictureBox();
            this.groupBoxTheme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtClrBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bckClrBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curLineClrBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chgLineClrBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineNbrClrBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caretClrBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slctClrBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTheme
            // 
            this.groupBoxTheme.Controls.Add(this.slctClrBox);
            this.groupBoxTheme.Controls.Add(this.slctClrLbl);
            this.groupBoxTheme.Controls.Add(this.caretClrBox);
            this.groupBoxTheme.Controls.Add(this.caretClrLbl);
            this.groupBoxTheme.Controls.Add(this.lineNbrClrBox);
            this.groupBoxTheme.Controls.Add(this.chgLineClrBox);
            this.groupBoxTheme.Controls.Add(this.curLineClrBox);
            this.groupBoxTheme.Controls.Add(this.lineClrLbl);
            this.groupBoxTheme.Controls.Add(this.changedLineLbl);
            this.groupBoxTheme.Controls.Add(this.currentLineColorLabel);
            this.groupBoxTheme.Controls.Add(this.bckClrBox);
            this.groupBoxTheme.Controls.Add(this.backColorLabel);
            this.groupBoxTheme.Controls.Add(this.txtClrBox);
            this.groupBoxTheme.Controls.Add(this.textColorLabel);
            this.groupBoxTheme.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTheme.Name = "groupBoxTheme";
            this.groupBoxTheme.Size = new System.Drawing.Size(200, 204);
            this.groupBoxTheme.TabIndex = 0;
            this.groupBoxTheme.TabStop = false;
            this.groupBoxTheme.Text = "UI Theme Settings";
            // 
            // textColorLabel
            // 
            this.textColorLabel.AutoSize = true;
            this.textColorLabel.Location = new System.Drawing.Point(7, 20);
            this.textColorLabel.Name = "textColorLabel";
            this.textColorLabel.Size = new System.Drawing.Size(52, 13);
            this.textColorLabel.TabIndex = 0;
            this.textColorLabel.Text = "TextColor";
            // 
            // txtClrBox
            // 
            this.txtClrBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtClrBox.Location = new System.Drawing.Point(173, 12);
            this.txtClrBox.Name = "txtClrBox";
            this.txtClrBox.Size = new System.Drawing.Size(21, 21);
            this.txtClrBox.TabIndex = 1;
            this.txtClrBox.TabStop = false;
            this.txtClrBox.Click += new System.EventHandler(this.TxtClrBox_Click);
            // 
            // backColorLabel
            // 
            this.backColorLabel.AutoSize = true;
            this.backColorLabel.Location = new System.Drawing.Point(7, 46);
            this.backColorLabel.Name = "backColorLabel";
            this.backColorLabel.Size = new System.Drawing.Size(56, 13);
            this.backColorLabel.TabIndex = 2;
            this.backColorLabel.Text = "BackColor";
            // 
            // bckClrBox
            // 
            this.bckClrBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bckClrBox.Location = new System.Drawing.Point(173, 38);
            this.bckClrBox.Name = "bckClrBox";
            this.bckClrBox.Size = new System.Drawing.Size(21, 21);
            this.bckClrBox.TabIndex = 2;
            this.bckClrBox.TabStop = false;
            this.bckClrBox.Click += new System.EventHandler(this.BckClrBox_Click);
            // 
            // currentLineColorLabel
            // 
            this.currentLineColorLabel.AutoSize = true;
            this.currentLineColorLabel.Location = new System.Drawing.Point(7, 73);
            this.currentLineColorLabel.Name = "currentLineColorLabel";
            this.currentLineColorLabel.Size = new System.Drawing.Size(91, 13);
            this.currentLineColorLabel.TabIndex = 3;
            this.currentLineColorLabel.Text = "Current Line Color";
            // 
            // changedLineLbl
            // 
            this.changedLineLbl.AutoSize = true;
            this.changedLineLbl.Location = new System.Drawing.Point(7, 100);
            this.changedLineLbl.Name = "changedLineLbl";
            this.changedLineLbl.Size = new System.Drawing.Size(100, 13);
            this.changedLineLbl.TabIndex = 4;
            this.changedLineLbl.Text = "Changed Line Color";
            // 
            // lineClrLbl
            // 
            this.lineClrLbl.AutoSize = true;
            this.lineClrLbl.Location = new System.Drawing.Point(7, 127);
            this.lineClrLbl.Name = "lineClrLbl";
            this.lineClrLbl.Size = new System.Drawing.Size(94, 13);
            this.lineClrLbl.TabIndex = 5;
            this.lineClrLbl.Text = "Line Number Color";
            // 
            // curLineClrBox
            // 
            this.curLineClrBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.curLineClrBox.Location = new System.Drawing.Point(173, 65);
            this.curLineClrBox.Name = "curLineClrBox";
            this.curLineClrBox.Size = new System.Drawing.Size(21, 21);
            this.curLineClrBox.TabIndex = 3;
            this.curLineClrBox.TabStop = false;
            this.curLineClrBox.Click += new System.EventHandler(this.CurLineClrBox_Click);
            // 
            // chgLineClrBox
            // 
            this.chgLineClrBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.chgLineClrBox.Location = new System.Drawing.Point(173, 92);
            this.chgLineClrBox.Name = "chgLineClrBox";
            this.chgLineClrBox.Size = new System.Drawing.Size(21, 21);
            this.chgLineClrBox.TabIndex = 6;
            this.chgLineClrBox.TabStop = false;
            this.chgLineClrBox.Click += new System.EventHandler(this.ChgLineClrBox_Click);
            // 
            // lineNbrClrBox
            // 
            this.lineNbrClrBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lineNbrClrBox.Location = new System.Drawing.Point(173, 119);
            this.lineNbrClrBox.Name = "lineNbrClrBox";
            this.lineNbrClrBox.Size = new System.Drawing.Size(21, 21);
            this.lineNbrClrBox.TabIndex = 3;
            this.lineNbrClrBox.TabStop = false;
            this.lineNbrClrBox.Click += new System.EventHandler(this.LineNbrClrBox_Click);
            // 
            // caretClrLbl
            // 
            this.caretClrLbl.AutoSize = true;
            this.caretClrLbl.Location = new System.Drawing.Point(7, 154);
            this.caretClrLbl.Name = "caretClrLbl";
            this.caretClrLbl.Size = new System.Drawing.Size(59, 13);
            this.caretClrLbl.TabIndex = 7;
            this.caretClrLbl.Text = "Caret Color";
            // 
            // caretClrBox
            // 
            this.caretClrBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.caretClrBox.Location = new System.Drawing.Point(173, 146);
            this.caretClrBox.Name = "caretClrBox";
            this.caretClrBox.Size = new System.Drawing.Size(21, 21);
            this.caretClrBox.TabIndex = 8;
            this.caretClrBox.TabStop = false;
            this.caretClrBox.Click += new System.EventHandler(this.CaretClrBox_Click);
            // 
            // slctClrLbl
            // 
            this.slctClrLbl.AutoSize = true;
            this.slctClrLbl.Location = new System.Drawing.Point(7, 181);
            this.slctClrLbl.Name = "slctClrLbl";
            this.slctClrLbl.Size = new System.Drawing.Size(78, 13);
            this.slctClrLbl.TabIndex = 9;
            this.slctClrLbl.Text = "Selection Color";
            // 
            // slctClrBox
            // 
            this.slctClrBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.slctClrBox.Location = new System.Drawing.Point(173, 173);
            this.slctClrBox.Name = "slctClrBox";
            this.slctClrBox.Size = new System.Drawing.Size(21, 21);
            this.slctClrBox.TabIndex = 10;
            this.slctClrBox.TabStop = false;
            this.slctClrBox.Click += new System.EventHandler(this.SlctClrBox_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxTheme);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.groupBoxTheme.ResumeLayout(false);
            this.groupBoxTheme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtClrBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bckClrBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curLineClrBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chgLineClrBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineNbrClrBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caretClrBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slctClrBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.GroupBox groupBoxTheme;
        private System.Windows.Forms.PictureBox bckClrBox;
        private System.Windows.Forms.Label backColorLabel;
        private System.Windows.Forms.PictureBox txtClrBox;
        private System.Windows.Forms.Label textColorLabel;
        private System.Windows.Forms.Label currentLineColorLabel;
        private System.Windows.Forms.Label changedLineLbl;
        private System.Windows.Forms.PictureBox lineNbrClrBox;
        private System.Windows.Forms.PictureBox chgLineClrBox;
        private System.Windows.Forms.PictureBox curLineClrBox;
        private System.Windows.Forms.Label lineClrLbl;
        private System.Windows.Forms.PictureBox slctClrBox;
        private System.Windows.Forms.Label slctClrLbl;
        private System.Windows.Forms.PictureBox caretClrBox;
        private System.Windows.Forms.Label caretClrLbl;
    }
}