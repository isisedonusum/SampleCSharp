using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
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
    }
}
