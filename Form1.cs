using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Crypt
{
    public partial class HybridEncode : Form
    {
        // Encoder B
        RSA asymEncoderDecoder = new RSA();

        public HybridEncode()
        {
            InitializeComponent();

            button_Decoder.Enabled = false;

            label_CharacterCount.Text += Convert.ToString(asymEncoderDecoder.getSizeCharacter());
        }

        private void button_Encoder_Click(object sender, EventArgs e)
        {
            // Field fill check
            if (textBox_OriginalMessage.Text.Length <= 0 || textBox_OriginalSymmetricKey.Text.Length <= 0
                || textBox_P.Text.Length <= 0 || textBox_Q.Text.Length <= 0)
            {
                MessageBox.Show("Fields are not filled");
                return;
            }

            string message = textBox_OriginalMessage.Text;      // Message A
            string codedMessage;                                // Encrypted message A

            string symKey = textBox_OriginalSymmetricKey.Text;     // Session key
            List<string> codedSymKey;                            // Encrypted session key

            // A: create session key
            byte[] keyByte = ASCIIEncoding.ASCII.GetBytes(symKey);
            RC4 symEncode = new RC4(keyByte);


            // A: Encoding message A using a symmetric algorithm

            byte[] messageBytes = ASCIIEncoding.ASCII.GetBytes(message);
            byte[] codedMessageByte = symEncode.Encode(messageBytes, messageBytes.Length);
            codedMessage = Convert.ToBase64String(codedMessageByte);
            label_CodedMessage.Text = codedMessage;


            // B: Generate and display RSA public key

            Int64 p = Convert.ToInt64(textBox_P.Text);
            Int64 q = Convert.ToInt64(textBox_Q.Text);

            if (!asymEncoderDecoder.GeneratePublicAndPrivateKey(p, q))
            {
                //MessageBox.Show("Symmetric key is not encoded");
                return;
            }

            Int64 N = asymEncoderDecoder.GetN();
            label_N_public.Text = Convert.ToString("N: " + N);

            Int64 E = asymEncoderDecoder.GetE();
            label_E.Text = Convert.ToString("E: " + E);


            // A: Encrypt symmetric key with RSA public key

            codedSymKey = asymEncoderDecoder.Encrypt(symKey);
            label_CodedSymmetricalKey.ResetText();
            foreach (string item in codedSymKey)
                label_CodedSymmetricalKey.Text += item + " ";

            button_Decoder.Enabled = true;
        }

        private void button_Decoder_Click(object sender, EventArgs e)
        {
            // Q: Print the private key

            Int64 N = asymEncoderDecoder.GetN();
            label_N_private.Text = Convert.ToString("N: " + N);
            Int64 d = asymEncoderDecoder.GetD();
            label_D.Text = Convert.ToString("D: " + d);


            // B: Read and decrypt the symmetric key using the RSA private key

            List<string> codedSymKey = new List<string>();
            string[] tmp = label_CodedSymmetricalKey.Text.Split(' ');
            for (int i = 0; i < tmp.Length; i++)
                codedSymKey.Add(tmp[i]);

            string origKey = asymEncoderDecoder.Decrypt(codedSymKey);
            label_DecodedSymmetricalKey.Text = origKey;


            // Q: decode message A with the decrypted symmetric key

            byte[] origKeyByte = ASCIIEncoding.ASCII.GetBytes(origKey);
            RC4 decoder = new RC4(origKeyByte);

            string codedMessage = label_CodedMessage.Text;
            byte[] codedMessageByte = Convert.FromBase64String(codedMessage);

            byte[] origMessageByte = decoder.Decode(codedMessageByte, codedMessageByte.Length);
            string origMessage = ASCIIEncoding.ASCII.GetString(origMessageByte);
            label_DecodedMessage.Text = origMessage;

            button_Decoder.Enabled = false;
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            label_CodedMessage.ResetText();
            label_CodedSymmetricalKey.ResetText();
            
            label_DecodedMessage.ResetText();
            label_DecodedSymmetricalKey.ResetText();
          
            label_Error.ResetText();

            label_N_private.ResetText();
            label_N_public.ResetText();
            label_E.ResetText();
            label_D.ResetText();

            textBox_OriginalSymmetricKey.ResetText();
            textBox_OriginalMessage.ResetText();
        }
    }
}