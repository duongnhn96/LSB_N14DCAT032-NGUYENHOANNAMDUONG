namespace MyLSB_Duong
{
    partial class DuongLSBTool
    {
        /// <summary>
        /// Required designer variable. Duong Tools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DuongLSBTool));
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.Encode = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEncode = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.tbMess = new System.Windows.Forms.TextBox();
            this.tbOpen = new System.Windows.Forms.TextBox();
            this.picEncode = new System.Windows.Forms.PictureBox();
            this.picSelect = new System.Windows.Forms.PictureBox();
            this.Decode = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDecode = new System.Windows.Forms.Button();
            this.btnSelectDecode = new System.Windows.Forms.Button();
            this.tbMessDecode = new System.Windows.Forms.TextBox();
            this.tbSelectDecode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picDecode = new System.Windows.Forms.PictureBox();
            this.tabCtrl.SuspendLayout();
            this.Encode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEncode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelect)).BeginInit();
            this.Decode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDecode)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCtrl
            // 
            this.tabCtrl.AllowDrop = true;
            this.tabCtrl.Controls.Add(this.Encode);
            this.tabCtrl.Controls.Add(this.Decode);
            this.tabCtrl.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtrl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabCtrl.ItemSize = new System.Drawing.Size(100, 29);
            this.tabCtrl.Location = new System.Drawing.Point(13, 13);
            this.tabCtrl.Multiline = true;
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.Padding = new System.Drawing.Point(80, 2);
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(831, 473);
            this.tabCtrl.TabIndex = 0;
            // 
            // Encode
            // 
            this.Encode.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Encode.Controls.Add(this.label5);
            this.Encode.Controls.Add(this.pictureBox1);
            this.Encode.Controls.Add(this.label1);
            this.Encode.Controls.Add(this.label2);
            this.Encode.Controls.Add(this.btnEncode);
            this.Encode.Controls.Add(this.btnSelect);
            this.Encode.Controls.Add(this.tbMess);
            this.Encode.Controls.Add(this.tbOpen);
            this.Encode.Controls.Add(this.picEncode);
            this.Encode.Controls.Add(this.picSelect);
            this.Encode.Location = new System.Drawing.Point(4, 33);
            this.Encode.Name = "Encode";
            this.Encode.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Encode.Size = new System.Drawing.Size(823, 436);
            this.Encode.TabIndex = 0;
            this.Encode.Text = "Encode";
            this.Encode.Click += new System.EventHandler(this.Encode_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cornsilk;
            this.label5.Image = global::MyLSB_Duong.Properties.Resources._20173_neon_redblue_design;
            this.label5.Location = new System.Drawing.Point(465, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(309, 59);
            this.label5.TabIndex = 14;
            this.label5.Text = "DUONG\'S LSB TOOL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 20.25F);
            this.label1.Location = new System.Drawing.Point(393, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Your Messages";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Your Image ( .bmp only )";
            // 
            // btnEncode
            // 
            this.btnEncode.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncode.ForeColor = System.Drawing.Color.OldLace;
            this.btnEncode.Image = ((System.Drawing.Image)(resources.GetObject("btnEncode.Image")));
            this.btnEncode.Location = new System.Drawing.Point(559, 349);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(142, 55);
            this.btnEncode.TabIndex = 7;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Agency FB", 17.75F, System.Drawing.FontStyle.Bold);
            this.btnSelect.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnSelect.Image = global::MyLSB_Duong.Properties.Resources.button_146372_960_720;
            this.btnSelect.Location = new System.Drawing.Point(662, 143);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(142, 49);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "Select File";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // tbMess
            // 
            this.tbMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbMess.ForeColor = System.Drawing.Color.Crimson;
            this.tbMess.Location = new System.Drawing.Point(399, 265);
            this.tbMess.Multiline = true;
            this.tbMess.Name = "tbMess";
            this.tbMess.Size = new System.Drawing.Size(405, 71);
            this.tbMess.TabIndex = 5;
            // 
            // tbOpen
            // 
            this.tbOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbOpen.Location = new System.Drawing.Point(399, 143);
            this.tbOpen.Multiline = true;
            this.tbOpen.Name = "tbOpen";
            this.tbOpen.Size = new System.Drawing.Size(257, 49);
            this.tbOpen.TabIndex = 4;
            // 
            // picEncode
            // 
            this.picEncode.BackgroundImage = global::MyLSB_Duong.Properties.Resources.images;
            this.picEncode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEncode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picEncode.Location = new System.Drawing.Point(129, 226);
            this.picEncode.Name = "picEncode";
            this.picEncode.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.picEncode.Size = new System.Drawing.Size(213, 178);
            this.picEncode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEncode.TabIndex = 1;
            this.picEncode.TabStop = false;
            // 
            // picSelect
            // 
            this.picSelect.BackgroundImage = global::MyLSB_Duong.Properties.Resources.images;
            this.picSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSelect.Location = new System.Drawing.Point(129, 27);
            this.picSelect.Name = "picSelect";
            this.picSelect.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.picSelect.Size = new System.Drawing.Size(213, 178);
            this.picSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSelect.TabIndex = 0;
            this.picSelect.TabStop = false;
            this.picSelect.Click += new System.EventHandler(this.picSelect_Click);
            // 
            // Decode
            // 
            this.Decode.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Decode.Controls.Add(this.label6);
            this.Decode.Controls.Add(this.btnDecode);
            this.Decode.Controls.Add(this.btnSelectDecode);
            this.Decode.Controls.Add(this.tbMessDecode);
            this.Decode.Controls.Add(this.tbSelectDecode);
            this.Decode.Controls.Add(this.label3);
            this.Decode.Controls.Add(this.label4);
            this.Decode.Controls.Add(this.picDecode);
            this.Decode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Decode.Location = new System.Drawing.Point(4, 33);
            this.Decode.Name = "Decode";
            this.Decode.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Decode.Size = new System.Drawing.Size(823, 436);
            this.Decode.TabIndex = 1;
            this.Decode.Text = "Decode";
            this.Decode.Click += new System.EventHandler(this.Decode_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Cornsilk;
            this.label6.Image = global::MyLSB_Duong.Properties.Resources._20173_neon_redblue_design;
            this.label6.Location = new System.Drawing.Point(422, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(309, 59);
            this.label6.TabIndex = 15;
            this.label6.Text = "DUONG\'S LSB TOOL";
            // 
            // btnDecode
            // 
            this.btnDecode.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDecode.Font = new System.Drawing.Font("Agency FB", 19.75F, System.Drawing.FontStyle.Bold);
            this.btnDecode.ForeColor = System.Drawing.SystemColors.Info;
            this.btnDecode.Image = global::MyLSB_Duong.Properties.Resources._20173_neon_redblue_design;
            this.btnDecode.Location = new System.Drawing.Point(559, 210);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(172, 67);
            this.btnDecode.TabIndex = 14;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = false;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // btnSelectDecode
            // 
            this.btnSelectDecode.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSelectDecode.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSelectDecode.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.btnSelectDecode.FlatAppearance.BorderSize = 5;
            this.btnSelectDecode.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectDecode.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnSelectDecode.Image = global::MyLSB_Duong.Properties.Resources.button_146372_960_720;
            this.btnSelectDecode.Location = new System.Drawing.Point(682, 155);
            this.btnSelectDecode.Name = "btnSelectDecode";
            this.btnSelectDecode.Size = new System.Drawing.Size(122, 49);
            this.btnSelectDecode.TabIndex = 13;
            this.btnSelectDecode.Text = "Select File";
            this.btnSelectDecode.UseVisualStyleBackColor = true;
            this.btnSelectDecode.Click += new System.EventHandler(this.btnSelectDecode_Click);
            // 
            // tbMessDecode
            // 
            this.tbMessDecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbMessDecode.ForeColor = System.Drawing.Color.Crimson;
            this.tbMessDecode.Location = new System.Drawing.Point(324, 324);
            this.tbMessDecode.Multiline = true;
            this.tbMessDecode.Name = "tbMessDecode";
            this.tbMessDecode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMessDecode.Size = new System.Drawing.Size(480, 83);
            this.tbMessDecode.TabIndex = 12;
            // 
            // tbSelectDecode
            // 
            this.tbSelectDecode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSelectDecode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSelectDecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbSelectDecode.ForeColor = System.Drawing.Color.CadetBlue;
            this.tbSelectDecode.Location = new System.Drawing.Point(324, 155);
            this.tbSelectDecode.Multiline = true;
            this.tbSelectDecode.Name = "tbSelectDecode";
            this.tbSelectDecode.Size = new System.Drawing.Size(330, 49);
            this.tbSelectDecode.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(318, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Your Image ( .bmp only)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 20.25F);
            this.label4.Location = new System.Drawing.Point(318, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Result";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // picDecode
            // 
            this.picDecode.BackColor = System.Drawing.Color.White;
            this.picDecode.BackgroundImage = global::MyLSB_Duong.Properties.Resources.images;
            this.picDecode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDecode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDecode.Location = new System.Drawing.Point(19, 112);
            this.picDecode.Name = "picDecode";
            this.picDecode.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.picDecode.Size = new System.Drawing.Size(270, 227);
            this.picDecode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDecode.TabIndex = 8;
            this.picDecode.TabStop = false;
            this.picDecode.Click += new System.EventHandler(this.picDecode_Click);
            // 
            // DuongLSBTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 494);
            this.Controls.Add(this.tabCtrl);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DuongLSBTool";
            this.Text = "N14DCAT032-NguyenHoanNamDuong - LSB TOOL";
            this.Load += new System.EventHandler(this.DuongLSBTool_Load);
            this.tabCtrl.ResumeLayout(false);
            this.Encode.ResumeLayout(false);
            this.Encode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEncode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelect)).EndInit();
            this.Decode.ResumeLayout(false);
            this.Decode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDecode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage Encode;
        private System.Windows.Forms.TabPage Decode;
        private System.Windows.Forms.PictureBox picEncode;
        private System.Windows.Forms.PictureBox picSelect;
        private System.Windows.Forms.TextBox tbOpen;
        private System.Windows.Forms.TextBox tbMess;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Button btnSelectDecode;
        private System.Windows.Forms.TextBox tbMessDecode;
        private System.Windows.Forms.TextBox tbSelectDecode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picDecode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

