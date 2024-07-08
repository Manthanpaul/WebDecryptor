namespace WebConfigDecryptor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.chkBox_EnvType = new System.Windows.Forms.CheckedListBox();
            this.txt_SIV = new System.Windows.Forms.TextBox();
            this.txt_Skey = new System.Windows.Forms.TextBox();
            this.cmb_ApplicationName = new System.Windows.Forms.ComboBox();
            this.txtBox_ConnString = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Decrypt);
            this.panel1.Controls.Add(this.chkBox_EnvType);
            this.panel1.Controls.Add(this.txt_SIV);
            this.panel1.Controls.Add(this.txt_Skey);
            this.panel1.Controls.Add(this.cmb_ApplicationName);
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 88);
            this.panel1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 14);
            this.label4.TabIndex = 19;
            this.label4.Text = "Type here to search";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(676, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "SIV";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(661, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "SKEY";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "APPLICATION";
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Decrypt.BackColor = System.Drawing.Color.Lavender;
            this.btn_Decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Decrypt.Location = new System.Drawing.Point(518, 32);
            this.btn_Decrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(121, 26);
            this.btn_Decrypt.TabIndex = 15;
            this.btn_Decrypt.Text = "Decrypt";
            this.btn_Decrypt.UseVisualStyleBackColor = false;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click_1);
            // 
            // chkBox_EnvType
            // 
            this.chkBox_EnvType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkBox_EnvType.BackColor = System.Drawing.Color.Lavender;
            this.chkBox_EnvType.CheckOnClick = true;
            this.chkBox_EnvType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBox_EnvType.FormattingEnabled = true;
            this.chkBox_EnvType.Items.AddRange(new object[] {
            "Dev",
            "QA",
            "Prod"});
            this.chkBox_EnvType.Location = new System.Drawing.Point(284, 13);
            this.chkBox_EnvType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkBox_EnvType.Name = "chkBox_EnvType";
            this.chkBox_EnvType.Size = new System.Drawing.Size(187, 58);
            this.chkBox_EnvType.TabIndex = 14;
            // 
            // txt_SIV
            // 
            this.txt_SIV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_SIV.BackColor = System.Drawing.Color.Lavender;
            this.txt_SIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SIV.Location = new System.Drawing.Point(733, 48);
            this.txt_SIV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SIV.Name = "txt_SIV";
            this.txt_SIV.Size = new System.Drawing.Size(175, 23);
            this.txt_SIV.TabIndex = 13;
            // 
            // txt_Skey
            // 
            this.txt_Skey.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Skey.BackColor = System.Drawing.Color.Lavender;
            this.txt_Skey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Skey.Location = new System.Drawing.Point(733, 14);
            this.txt_Skey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Skey.Name = "txt_Skey";
            this.txt_Skey.Size = new System.Drawing.Size(175, 23);
            this.txt_Skey.TabIndex = 12;
            // 
            // cmb_ApplicationName
            // 
            this.cmb_ApplicationName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_ApplicationName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_ApplicationName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_ApplicationName.BackColor = System.Drawing.Color.Lavender;
            this.cmb_ApplicationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ApplicationName.FormattingEnabled = true;
            this.cmb_ApplicationName.Items.AddRange(new object[] {
            "AutoReject-SpecProBatchJob",
            "CBNInsertLegacyData",
            "CGM",
            "CNC",
            "DCR",
            "doa-PriceWalk",
            "Envis",
            "EventViewer",
            "ITCOCorp",
            "ITCOEngineer",
            "OrderExplorer",
            "PQR",
            "PWL",
            "PWMS",
            "SalesCampaignTool",
            "SCO",
            "SOLive",
            "SP21DB2Parser",
            "SpecPro",
            "SPOE",
            "WAA-AutoApprovalBatchJob",
            "WAA-Corporate",
            "WAA-Supplier",
            "WebTCO"});
            this.cmb_ApplicationName.Location = new System.Drawing.Point(6, 33);
            this.cmb_ApplicationName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_ApplicationName.Name = "cmb_ApplicationName";
            this.cmb_ApplicationName.Size = new System.Drawing.Size(227, 25);
            this.cmb_ApplicationName.Sorted = true;
            this.cmb_ApplicationName.TabIndex = 11;
            this.cmb_ApplicationName.SelectedIndexChanged += new System.EventHandler(this.cmb_ApplicationName_SelectedIndexChanged);
            // 
            // txtBox_ConnString
            // 
            this.txtBox_ConnString.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_ConnString.BackColor = System.Drawing.Color.White;
            this.txtBox_ConnString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_ConnString.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_ConnString.Location = new System.Drawing.Point(12, 97);
            this.txtBox_ConnString.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_ConnString.Name = "txtBox_ConnString";
            this.txtBox_ConnString.Size = new System.Drawing.Size(951, 470);
            this.txtBox_ConnString.TabIndex = 16;
            this.txtBox_ConnString.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(975, 578);
            this.Controls.Add(this.txtBox_ConnString);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Web Config Decryptor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.CheckedListBox chkBox_EnvType;
        private System.Windows.Forms.TextBox txt_SIV;
        private System.Windows.Forms.TextBox txt_Skey;
        private System.Windows.Forms.ComboBox cmb_ApplicationName;
        private System.Windows.Forms.RichTextBox txtBox_ConnString;
    }
}

