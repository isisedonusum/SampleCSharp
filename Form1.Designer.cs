namespace ISIS.EInvoiceEasy.Test
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label9 = new System.Windows.Forms.Label();
			this.txtURL = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtVKN = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnStore = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.lblReceiverVKN = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.lblSenderVKN = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lblInboundUUID = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.lblnoundID = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblInboundETTN = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnEnvelopeDone = new System.Windows.Forms.Button();
			this.btnInvoiceDone = new System.Windows.Forms.Button();
			this.btnGetSingleEnvelope = new System.Windows.Forms.Button();
			this.btnGetSingleInvoice = new System.Windows.Forms.Button();
			this.richInBound = new System.Windows.Forms.RichTextBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.label6 = new System.Windows.Forms.Label();
			this.txtReceiversVKN = new System.Windows.Forms.TextBox();
			this.btnPostbox = new System.Windows.Forms.Button();
			this.btnSendInvoice = new System.Windows.Forms.Button();
			this.btnSendEnvelope = new System.Windows.Forms.Button();
			this.richOutbound = new System.Windows.Forms.RichTextBox();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.richMessage = new System.Windows.Forms.RichTextBox();
			this.btnDownloadAllUblTr = new System.Windows.Forms.Button();
			this.txtReportGetInvoiceUrl = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
			this.tabControl1.ItemSize = new System.Drawing.Size(25, 150);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Multiline = true;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1008, 572);
			this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabControl1.TabIndex = 0;
			this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label11);
			this.tabPage1.Controls.Add(this.txtReportGetInvoiceUrl);
			this.tabPage1.Controls.Add(this.label9);
			this.tabPage1.Controls.Add(this.txtURL);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.txtVKN);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.btnStore);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.txtPassword);
			this.tabPage1.Controls.Add(this.txtUserName);
			this.tabPage1.Location = new System.Drawing.Point(154, 4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(850, 564);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "ServiceCredentials";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(321, 126);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(115, 13);
			this.label9.TabIndex = 9;
			this.label9.Text = "ReportInvoiceList URL";
			// 
			// txtURL
			// 
			this.txtURL.Location = new System.Drawing.Point(442, 123);
			this.txtURL.Name = "txtURL";
			this.txtURL.Size = new System.Drawing.Size(100, 20);
			this.txtURL.TabIndex = 8;
			this.txtURL.Text = "http://musteritestws.isisbilisim.com.tr/Services/einvoice/ReportInvoiceList.svc";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(374, 209);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "VKN";
			// 
			// txtVKN
			// 
			this.txtVKN.Location = new System.Drawing.Point(442, 202);
			this.txtVKN.Name = "txtVKN";
			this.txtVKN.Size = new System.Drawing.Size(100, 20);
			this.txtVKN.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(187, 275);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(601, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "Your Credentials have been stored to use different values retype necessary fields" +
    " and hit store again";
			this.label3.Visible = false;
			// 
			// btnStore
			// 
			this.btnStore.Location = new System.Drawing.Point(467, 237);
			this.btnStore.Name = "btnStore";
			this.btnStore.Size = new System.Drawing.Size(75, 23);
			this.btnStore.TabIndex = 4;
			this.btnStore.Text = "Store";
			this.btnStore.UseVisualStyleBackColor = true;
			this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(374, 182);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Pass";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(374, 155);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "User";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(442, 175);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(100, 20);
			this.txtPassword.TabIndex = 1;
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(442, 149);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(100, 20);
			this.txtUserName.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.lblReceiverVKN);
			this.tabPage2.Controls.Add(this.label12);
			this.tabPage2.Controls.Add(this.lblSenderVKN);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Controls.Add(this.lblInboundUUID);
			this.tabPage2.Controls.Add(this.label10);
			this.tabPage2.Controls.Add(this.lblnoundID);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.lblInboundETTN);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.btnEnvelopeDone);
			this.tabPage2.Controls.Add(this.btnInvoiceDone);
			this.tabPage2.Controls.Add(this.btnGetSingleEnvelope);
			this.tabPage2.Controls.Add(this.btnGetSingleInvoice);
			this.tabPage2.Controls.Add(this.richInBound);
			this.tabPage2.Location = new System.Drawing.Point(154, 4);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(850, 564);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "InboundActions";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// lblReceiverVKN
			// 
			this.lblReceiverVKN.AutoSize = true;
			this.lblReceiverVKN.ForeColor = System.Drawing.Color.Red;
			this.lblReceiverVKN.Location = new System.Drawing.Point(15, 396);
			this.lblReceiverVKN.Name = "lblReceiverVKN";
			this.lblReceiverVKN.Size = new System.Drawing.Size(10, 13);
			this.lblReceiverVKN.TabIndex = 14;
			this.lblReceiverVKN.Text = ".";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(12, 379);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(50, 13);
			this.label12.TabIndex = 13;
			this.label12.Text = "Receiver";
			// 
			// lblSenderVKN
			// 
			this.lblSenderVKN.AutoSize = true;
			this.lblSenderVKN.ForeColor = System.Drawing.Color.Red;
			this.lblSenderVKN.Location = new System.Drawing.Point(15, 327);
			this.lblSenderVKN.Name = "lblSenderVKN";
			this.lblSenderVKN.Size = new System.Drawing.Size(10, 13);
			this.lblSenderVKN.TabIndex = 12;
			this.lblSenderVKN.Text = ".";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 310);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(41, 13);
			this.label8.TabIndex = 11;
			this.label8.Text = "Sender";
			// 
			// lblInboundUUID
			// 
			this.lblInboundUUID.AutoSize = true;
			this.lblInboundUUID.ForeColor = System.Drawing.Color.Red;
			this.lblInboundUUID.Location = new System.Drawing.Point(15, 289);
			this.lblInboundUUID.Name = "lblInboundUUID";
			this.lblInboundUUID.Size = new System.Drawing.Size(10, 13);
			this.lblInboundUUID.TabIndex = 10;
			this.lblInboundUUID.Text = ".";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(12, 272);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(34, 13);
			this.label10.TabIndex = 9;
			this.label10.Text = "UUID";
			// 
			// lblnoundID
			// 
			this.lblnoundID.AutoSize = true;
			this.lblnoundID.ForeColor = System.Drawing.Color.Red;
			this.lblnoundID.Location = new System.Drawing.Point(12, 132);
			this.lblnoundID.Name = "lblnoundID";
			this.lblnoundID.Size = new System.Drawing.Size(10, 13);
			this.lblnoundID.TabIndex = 8;
			this.lblnoundID.Text = ".";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(9, 115);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(18, 13);
			this.label7.TabIndex = 7;
			this.label7.Text = "ID";
			// 
			// lblInboundETTN
			// 
			this.lblInboundETTN.AutoSize = true;
			this.lblInboundETTN.ForeColor = System.Drawing.Color.Red;
			this.lblInboundETTN.Location = new System.Drawing.Point(12, 94);
			this.lblInboundETTN.Name = "lblInboundETTN";
			this.lblInboundETTN.Size = new System.Drawing.Size(10, 13);
			this.lblInboundETTN.TabIndex = 6;
			this.lblInboundETTN.Text = ".";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 77);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(36, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "ETTN";
			// 
			// btnEnvelopeDone
			// 
			this.btnEnvelopeDone.Location = new System.Drawing.Point(9, 230);
			this.btnEnvelopeDone.Name = "btnEnvelopeDone";
			this.btnEnvelopeDone.Size = new System.Drawing.Size(132, 25);
			this.btnEnvelopeDone.TabIndex = 4;
			this.btnEnvelopeDone.Text = "ReceiveEnvelopeDone";
			this.btnEnvelopeDone.UseVisualStyleBackColor = true;
			// 
			// btnInvoiceDone
			// 
			this.btnInvoiceDone.Location = new System.Drawing.Point(9, 47);
			this.btnInvoiceDone.Name = "btnInvoiceDone";
			this.btnInvoiceDone.Size = new System.Drawing.Size(117, 23);
			this.btnInvoiceDone.TabIndex = 3;
			this.btnInvoiceDone.Text = "ReceiveInvoiceDone";
			this.btnInvoiceDone.UseVisualStyleBackColor = true;
			// 
			// btnGetSingleEnvelope
			// 
			this.btnGetSingleEnvelope.Location = new System.Drawing.Point(9, 199);
			this.btnGetSingleEnvelope.Name = "btnGetSingleEnvelope";
			this.btnGetSingleEnvelope.Size = new System.Drawing.Size(107, 25);
			this.btnGetSingleEnvelope.TabIndex = 2;
			this.btnGetSingleEnvelope.Text = "GetSingleEnvelope";
			this.btnGetSingleEnvelope.UseVisualStyleBackColor = true;
			this.btnGetSingleEnvelope.Click += new System.EventHandler(this.btnGetSingleEnvelope_Click);
			// 
			// btnGetSingleInvoice
			// 
			this.btnGetSingleInvoice.Location = new System.Drawing.Point(9, 18);
			this.btnGetSingleInvoice.Name = "btnGetSingleInvoice";
			this.btnGetSingleInvoice.Size = new System.Drawing.Size(107, 23);
			this.btnGetSingleInvoice.TabIndex = 1;
			this.btnGetSingleInvoice.Text = "GetSingleInvoice";
			this.btnGetSingleInvoice.UseVisualStyleBackColor = true;
			this.btnGetSingleInvoice.Click += new System.EventHandler(this.btnGetSingleInvoice_Click);
			// 
			// richInBound
			// 
			this.richInBound.Dock = System.Windows.Forms.DockStyle.Right;
			this.richInBound.Location = new System.Drawing.Point(162, 3);
			this.richInBound.Name = "richInBound";
			this.richInBound.Size = new System.Drawing.Size(685, 558);
			this.richInBound.TabIndex = 0;
			this.richInBound.Text = "";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.label6);
			this.tabPage3.Controls.Add(this.txtReceiversVKN);
			this.tabPage3.Controls.Add(this.btnPostbox);
			this.tabPage3.Controls.Add(this.btnSendInvoice);
			this.tabPage3.Controls.Add(this.btnSendEnvelope);
			this.tabPage3.Controls.Add(this.richOutbound);
			this.tabPage3.Location = new System.Drawing.Point(154, 4);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(850, 564);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Outbound Actions";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(9, 126);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(107, 13);
			this.label6.TabIndex = 6;
			this.label6.Text = "Type Receivers VKN";
			// 
			// txtReceiversVKN
			// 
			this.txtReceiversVKN.Location = new System.Drawing.Point(9, 149);
			this.txtReceiversVKN.Name = "txtReceiversVKN";
			this.txtReceiversVKN.Size = new System.Drawing.Size(154, 20);
			this.txtReceiversVKN.TabIndex = 5;
			// 
			// btnPostbox
			// 
			this.btnPostbox.Location = new System.Drawing.Point(9, 175);
			this.btnPostbox.Name = "btnPostbox";
			this.btnPostbox.Size = new System.Drawing.Size(100, 23);
			this.btnPostbox.TabIndex = 4;
			this.btnPostbox.Text = "QueryTaxPayer";
			this.btnPostbox.UseVisualStyleBackColor = true;
			this.btnPostbox.Click += new System.EventHandler(this.btnPostbox_Click);
			// 
			// btnSendInvoice
			// 
			this.btnSendInvoice.Location = new System.Drawing.Point(9, 59);
			this.btnSendInvoice.Name = "btnSendInvoice";
			this.btnSendInvoice.Size = new System.Drawing.Size(90, 23);
			this.btnSendInvoice.TabIndex = 3;
			this.btnSendInvoice.Text = "SendInvoice";
			this.btnSendInvoice.UseVisualStyleBackColor = true;
			this.btnSendInvoice.Click += new System.EventHandler(this.btnSendInvoice_Click);
			// 
			// btnSendEnvelope
			// 
			this.btnSendEnvelope.Location = new System.Drawing.Point(9, 17);
			this.btnSendEnvelope.Name = "btnSendEnvelope";
			this.btnSendEnvelope.Size = new System.Drawing.Size(90, 23);
			this.btnSendEnvelope.TabIndex = 2;
			this.btnSendEnvelope.Text = "SendEnvelope";
			this.btnSendEnvelope.UseVisualStyleBackColor = true;
			this.btnSendEnvelope.Click += new System.EventHandler(this.btnSendEnvelope_Click);
			// 
			// richOutbound
			// 
			this.richOutbound.Dock = System.Windows.Forms.DockStyle.Right;
			this.richOutbound.Location = new System.Drawing.Point(169, 3);
			this.richOutbound.Name = "richOutbound";
			this.richOutbound.Size = new System.Drawing.Size(678, 558);
			this.richOutbound.TabIndex = 1;
			this.richOutbound.Text = "";
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.btnDownloadAllUblTr);
			this.tabPage4.Controls.Add(this.textBox1);
			this.tabPage4.Controls.Add(this.button1);
			this.tabPage4.Location = new System.Drawing.Point(154, 4);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(850, 564);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "OutboundInvoiceList";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.textBox1.Location = new System.Drawing.Point(3, 83);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(844, 478);
			this.textBox1.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(381, 30);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Get List";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.richMessage);
			this.splitContainer1.Size = new System.Drawing.Size(1008, 729);
			this.splitContainer1.SplitterDistance = 572;
			this.splitContainer1.TabIndex = 1;
			// 
			// richMessage
			// 
			this.richMessage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richMessage.Location = new System.Drawing.Point(0, 0);
			this.richMessage.Name = "richMessage";
			this.richMessage.Size = new System.Drawing.Size(1008, 153);
			this.richMessage.TabIndex = 0;
			this.richMessage.Text = "";
			// 
			// btnDownloadAllUblTr
			// 
			this.btnDownloadAllUblTr.Enabled = false;
			this.btnDownloadAllUblTr.Location = new System.Drawing.Point(346, 59);
			this.btnDownloadAllUblTr.Name = "btnDownloadAllUblTr";
			this.btnDownloadAllUblTr.Size = new System.Drawing.Size(143, 23);
			this.btnDownloadAllUblTr.TabIndex = 2;
			this.btnDownloadAllUblTr.Text = "Download All as UBL-TR";
			this.btnDownloadAllUblTr.UseVisualStyleBackColor = true;
			this.btnDownloadAllUblTr.Click += new System.EventHandler(this.btnDownloadAllUblTr_Click);
			// 
			// txtReportGetInvoiceUrl
			// 
			this.txtReportGetInvoiceUrl.Location = new System.Drawing.Point(442, 97);
			this.txtReportGetInvoiceUrl.Name = "txtReportGetInvoiceUrl";
			this.txtReportGetInvoiceUrl.Size = new System.Drawing.Size(100, 20);
			this.txtReportGetInvoiceUrl.TabIndex = 10;
			this.txtReportGetInvoiceUrl.Text = "http://musteritestws.isisbilisim.com.tr/services/ReportGetInvoice.svc";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(320, 100);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(116, 13);
			this.label11.TabIndex = 11;
			this.label11.Text = "ReportGetInvoice URL";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(1008, 729);
			this.Controls.Add(this.splitContainer1);
			this.Name = "Form1";
			this.Text = "ISIS WebService Test Tool";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnvelopeDone;
        private System.Windows.Forms.Button btnInvoiceDone;
        private System.Windows.Forms.Button btnGetSingleEnvelope;
        private System.Windows.Forms.Button btnGetSingleInvoice;
        private System.Windows.Forms.RichTextBox richInBound;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVKN;
        private System.Windows.Forms.RichTextBox richMessage;
        private System.Windows.Forms.Label lblInboundETTN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblnoundID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblReceiverVKN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblSenderVKN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblInboundUUID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSendInvoice;
        private System.Windows.Forms.Button btnSendEnvelope;
        private System.Windows.Forms.RichTextBox richOutbound;
        private System.Windows.Forms.Button btnPostbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReceiversVKN;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtURL;
		private System.Windows.Forms.Button btnDownloadAllUblTr;
		private System.Windows.Forms.TextBox txtReportGetInvoiceUrl;
		private System.Windows.Forms.Label label11;
	}
}

