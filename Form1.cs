using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Web;
using System.Text;
using System.Windows.Forms;

namespace ISIS.EInvoiceEasy.Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Vars.EasyCredentials cred = new Vars.EasyCredentials();
        public static Guid receivedETTN = new Guid();
        public static Guid receivedUUID = new Guid();
        private void Form1_Load(object sender, EventArgs e)
        {
            this.splitContainer1.Panel2Collapsed = true;
        }
        private void visualReset()
        {
            splitContainer1.Panel2Collapsed = true;
            richMessage.Text = "";
        }
        private void btnStore_Click(object sender, EventArgs e)
        {
            visualReset();
            if (!String.IsNullOrWhiteSpace(txtPassword.Text) && !String.IsNullOrWhiteSpace(txtUserName.Text) && !String.IsNullOrWhiteSpace(txtVKN.Text))
            {
                cred.Pass = txtPassword.Text;
                cred.User = txtUserName.Text;
                cred.VKN = txtVKN.Text;
                label3.Text = "Your Credentials have been stored to use different values retype necessary fields and hit store again";
                label3.Visible = true;
            }
            else
            {
                label3.Text = "Invalid values in neccessary fields!";
                label3.Visible = true;
            }
        }

        private void btnGetSingleInvoice_Click(object sender, EventArgs e)
        {
            visualReset();
            var ea = new EndpointAddress("http://erptestep.isisbilisim.com.tr/EInvoiceEasy.svc");
            var bn = new BasicHttpBinding();
            var EC = new EASY.EasyClient(bn, ea);
            var rsp = new EASY.ContractsResponseType();

            bn.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
            bn.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
            EC.ClientCredentials.UserName.UserName = cred.User;
            EC.ClientCredentials.UserName.Password = cred.Pass;

            try
            {
                rsp = EC.GetSingleInvoice(cred.VKN);
                if (rsp.ByteData == null)
                {
                    splitContainer1.Panel2Collapsed = false;
                    richMessage.Text = rsp.GIBMessage;
                    return;
                }
                var dat = ISIS.Core.Zip.Helper.DeCompressAsByte(rsp.ByteData);
                richInBound.Text = UTF8Encoding.UTF8.GetString(dat);
                ISIS.Core.Ubl.InvoiceType ubl = new Core.Ubl.InvoiceType();
                ubl = (Core.Ubl.InvoiceType)UtilityLayer.ObjectToByte.XmlByteArrayToObject(ubl, dat);
                lblInboundETTN.Text = ubl.UUID.Value;
                Guid.Parse(ubl.UUID.Value);
                lblnoundID.Text = ubl.ID.Value;
            }

            catch (Exception ex)
            {
                splitContainer1.Panel2Collapsed = false;
                richMessage.Text = ex.Message;
            }

        }

        private void btnGetSingleEnvelope_Click(object sender, EventArgs e)
        {
            visualReset();
            var ea = new EndpointAddress("http://erptestep.isisbilisim.com.tr/EInvoiceEasy.svc");
            var bn = new BasicHttpBinding();
            var EC = new EASY.EasyClient(bn, ea);
            var rsp = new EASY.ContractsResponseType();

            bn.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
            bn.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
            EC.ClientCredentials.UserName.UserName = cred.User;
            EC.ClientCredentials.UserName.Password = cred.Pass;

            try
            {
                rsp = EC.GetSingleEnvelope(cred.VKN);
                if (rsp.ByteData == null)
                {
                    splitContainer1.Panel2Collapsed = false;
                    richMessage.Text = rsp.GIBMessage;
                    return;
                }
                var dat = ISIS.Core.Zip.Helper.DeCompressAsByte(rsp.ByteData);
                richInBound.Text = UTF8Encoding.UTF8.GetString(dat);
                ISIS.Core.Ubl.BusinessDocument.StandardBusinessDocumentHeader ubl = new Core.Ubl.BusinessDocument.StandardBusinessDocumentHeader();
                ubl = (Core.Ubl.BusinessDocument.StandardBusinessDocumentHeader)UtilityLayer.ObjectToByte.XmlByteArrayToObject(ubl, dat);
                lblInboundUUID.Text = ubl.DocumentIdentification.InstanceIdentifier;
            }

            catch (Exception ex)
            {
                splitContainer1.Panel2Collapsed = false;
                richMessage.Text = ex.Message;
            }
        }

        private void btnPostbox_Click(object sender, EventArgs e)
        {
            visualReset();
            splitContainer1.Panel2Collapsed = true;
            var ea = new EndpointAddress("http://erptestep.isisbilisim.com.tr/EInvoiceEasy.svc");
            var bn = new BasicHttpBinding();
            var EC = new EASY.EasyClient(bn, ea);
            var rsp = new EASY.ContractsResponseType();

            bn.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
            bn.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
            EC.ClientCredentials.UserName.UserName = cred.User;
            EC.ClientCredentials.UserName.Password = cred.Pass;
            string[] aa = null;
            try
            {
                aa = EC.GetPostboxList(txtReceiversVKN.Text);
                if (aa.Length > 0)
                {
                    string result = null;
                    foreach (var item in aa)
                    {
                        result += item + "\r\n";
                    }
                    richOutbound.Text = result;
                }
            }
            catch (Exception ex)
            {
                splitContainer1.Panel2Collapsed = false;
                richMessage.Text = ex.Message;
            }

        }

        private void btnSendInvoice_Click(object sender, EventArgs e)
        {
            visualReset();
            splitContainer1.Panel2Collapsed = true;
            var ea = new EndpointAddress("http://erptestep.isisbilisim.com.tr/EInvoiceEasy.svc");
            var bn = new BasicHttpBinding();
            var EC = new EASY.EasyClient(bn, ea);
            var rsp = new EASY.ContractsResponseType();

            bn.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
            bn.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
            EC.ClientCredentials.UserName.UserName = cred.User;
            EC.ClientCredentials.UserName.Password = cred.Pass;
            try
            {
                rsp = EC.SendInvoice(cred.VKN, null, null, UTF8Encoding.UTF8.GetBytes(richOutbound.Text));
                splitContainer1.Panel2Collapsed = false;
                richMessage.Text += rsp.Status + "\r\n";
                richMessage.Text += rsp.GIBMessage;
                return;

            }
            catch (Exception ex)
            {
                splitContainer1.Panel2Collapsed = false;
                richMessage.Text = ex.Message;
            }
        }

        private void btnSendEnvelope_Click(object sender, EventArgs e)
        {
            visualReset();
            splitContainer1.Panel2Collapsed = true;
            var ea = new EndpointAddress("http://erptestep.isisbilisim.com.tr/EInvoiceEasy.svc");
            var bn = new BasicHttpBinding();
            var EC = new EASY.EasyClient(bn, ea);
            var rsp = new EASY.ContractsResponseType();

            bn.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
            bn.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
            EC.ClientCredentials.UserName.UserName = cred.User;
            EC.ClientCredentials.UserName.Password = cred.Pass;
            try
            {
                rsp = EC.SendEnvelope(cred.VKN, UTF8Encoding.UTF8.GetBytes(richOutbound.Text));
                splitContainer1.Panel2Collapsed = false;
                richMessage.Text += rsp.Status + "\r\n";
                richMessage.Text += rsp.GIBMessage;
                return;

            }
            catch (Exception ex)
            {
                splitContainer1.Panel2Collapsed = false;
                richMessage.Text = ex.Message;
            }

        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.White);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", (float)10.0, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
			var result = GetOutboundInvoiceList();
			textBox1.Text = String.Format("{0} adet fatura bulundu.\r\n", result.Count);
			foreach (var invoice in result)
			{
				textBox1.Text += String.Format("{0}\r\n", invoice.ID);
			}
			btnDownloadAllUblTr.Enabled = true;
		}

		private List<ReportInvoiceList.OutboxInvoiceHeader> GetOutboundInvoiceList()
		{
			EndpointAddress ea = new EndpointAddress(new Uri(txtURL.Text));
			CustomBinding cb = new CustomBinding();

			TextMessageEncodingBindingElement textMessageEncoding = new TextMessageEncodingBindingElement()
			{
				MessageVersion = MessageVersion.Soap11
			};
			cb.Elements.Add(textMessageEncoding);

			//HTTPS kontrolü
			HttpTransportBindingElement transport = null;
			if (txtURL.Text.Length > 5 && txtURL.Text.Substring(0, 5).ToLower() == "https")
				transport = new HttpsTransportBindingElement();
			else
				transport = new HttpTransportBindingElement();

			transport.UseDefaultWebProxy = true;
			transport.BypassProxyOnLocal = true;

			if (!String.IsNullOrEmpty(txtPassword.Text))
				transport.AuthenticationScheme = AuthenticationSchemes.Basic;

			transport.MaxReceivedMessageSize = int.MaxValue;

			cb.Elements.Add(transport);

			ReportInvoiceList.ReportInvoiceListClient client = new ReportInvoiceList.ReportInvoiceListClient(cb, ea);
			if (!String.IsNullOrEmpty(txtPassword.Text))
			{
				client.ClientCredentials.UserName.UserName = txtUserName.Text;
				client.ClientCredentials.UserName.Password = txtPassword.Text;
			}

			var request = new ReportInvoiceList.ContractsOutboundInvoiceListRequest();
			request.VKN = txtVKN.Text;
			request.RecordCount = 100;
			request.BeginRecordDateTime = DateTime.Now.AddDays(-30);
			request.EndRecordDateTime = DateTime.Now;

			// This wrapper is required for each call
			using (OperationContextScope scope = new OperationContextScope(client.InnerChannel))
			{
				var httpRequestProperty = new HttpRequestMessageProperty();
				httpRequestProperty.Headers[System.Net.HttpRequestHeader.Authorization] = "Basic " +
				Convert.ToBase64String(Encoding.ASCII.GetBytes(client.ClientCredentials.UserName.UserName + ":" + client.ClientCredentials.UserName.Password));
				OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = httpRequestProperty;

				return client.OutboundInvoiceListByFilter(request);
			}
		}

		private void btnDownloadAllUblTr_Click(object sender, EventArgs e)
		{
			var result = GetOutboundInvoiceList();
			foreach(var invoice in result)
			{
				File.WriteAllBytes(Path.Combine(Path.GetTempPath(), invoice.UUID + ".xml"), GetOutboundInvoiceUblTr(txtVKN.Text, invoice.UUID));
			}
			textBox1.Text += String.Format("\r\nDosyalar {0} klasörüne kaydedildi", Path.GetTempPath());
		}

		private byte[] GetOutboundInvoiceUblTr(string VKN, string UUID)
		{
			EndpointAddress ea = new EndpointAddress(new Uri(txtReportGetInvoiceUrl.Text));
			CustomBinding cb = new CustomBinding();

			TextMessageEncodingBindingElement textMessageEncoding = new TextMessageEncodingBindingElement()
			{
				MessageVersion = MessageVersion.Soap11
			};
			cb.Elements.Add(textMessageEncoding);

			//HTTPS kontrolü
			HttpTransportBindingElement transport = null;
			if (txtReportGetInvoiceUrl.Text.Length > 5 && txtReportGetInvoiceUrl.Text.Substring(0, 5).ToLower() == "https")
				transport = new HttpsTransportBindingElement();
			else
				transport = new HttpTransportBindingElement();

			transport.UseDefaultWebProxy = true;
			transport.BypassProxyOnLocal = true;

			if (!String.IsNullOrEmpty(txtPassword.Text))
				transport.AuthenticationScheme = AuthenticationSchemes.Basic;

			transport.MaxReceivedMessageSize = int.MaxValue;

			cb.Elements.Add(transport);

			ReportGetInvoice.ReportGetInvoiceClient client = new ReportGetInvoice.ReportGetInvoiceClient(cb, ea);
			if (!String.IsNullOrEmpty(txtPassword.Text))
			{
				client.ClientCredentials.UserName.UserName = txtUserName.Text;
				client.ClientCredentials.UserName.Password = txtPassword.Text;
			}

			var request = new ReportInvoiceList.ContractsOutboundInvoiceListRequest();
			request.VKN = txtVKN.Text;
			request.RecordCount = 100;
			request.BeginRecordDateTime = DateTime.Now.AddDays(-30);
			request.EndRecordDateTime = DateTime.Now;

			// This wrapper is required for each call
			using (OperationContextScope scope = new OperationContextScope(client.InnerChannel))
			{
				var httpRequestProperty = new HttpRequestMessageProperty();
				httpRequestProperty.Headers[System.Net.HttpRequestHeader.Authorization] = "Basic " +
				Convert.ToBase64String(Encoding.ASCII.GetBytes(client.ClientCredentials.UserName.UserName + ":" + client.ClientCredentials.UserName.Password));
				OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = httpRequestProperty;

				return client.GetOutboundInvoiceAsUblTr(VKN, null, null, null, UUID);
			}
		}
	}
}
