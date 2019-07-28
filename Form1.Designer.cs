namespace Crypt
{
    partial class HybridEncode
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_P = new System.Windows.Forms.Label();
            this.label_Q = new System.Windows.Forms.Label();
            this.textBox_P = new System.Windows.Forms.TextBox();
            this.textBox_Q = new System.Windows.Forms.TextBox();
            this.textBox_OriginalMessage = new System.Windows.Forms.TextBox();
            this.label_RSA = new System.Windows.Forms.Label();
            this.label_N_private = new System.Windows.Forms.Label();
            this.label_E = new System.Windows.Forms.Label();
            this.label_PublicKey = new System.Windows.Forms.Label();
            this.label_PrivateKey = new System.Windows.Forms.Label();
            this.label_D = new System.Windows.Forms.Label();
            this.button_Encoder = new System.Windows.Forms.Button();
            this.button_Decoder = new System.Windows.Forms.Button();
            this.label_DecodedMessage = new System.Windows.Forms.Label();
            this.label_TextEncrypt = new System.Windows.Forms.Label();
            this.label_SymmetricKey = new System.Windows.Forms.Label();
            this.textBox_OriginalSymmetricKey = new System.Windows.Forms.TextBox();
            this.label_CodedSymmetricalKey = new System.Windows.Forms.Label();
            this.label_Error = new System.Windows.Forms.Label();
            this.label_N_public = new System.Windows.Forms.Label();
            this.label_CodedMessage = new System.Windows.Forms.Label();
            this.button_Reset = new System.Windows.Forms.Button();
            this.label_DecodedSymmetricalKey = new System.Windows.Forms.Label();
            this.label_CharacterCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_encrypt_message = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_rsa_input = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_P
            // 
            this.label_P.AutoSize = true;
            this.label_P.Location = new System.Drawing.Point(16, 75);
            this.label_P.Name = "label_P";
            this.label_P.Size = new System.Drawing.Size(14, 13);
            this.label_P.TabIndex = 0;
            this.label_P.Text = "P";
            // 
            // label_Q
            // 
            this.label_Q.AutoSize = true;
            this.label_Q.Location = new System.Drawing.Point(15, 96);
            this.label_Q.Name = "label_Q";
            this.label_Q.Size = new System.Drawing.Size(15, 13);
            this.label_Q.TabIndex = 1;
            this.label_Q.Text = "Q";
            // 
            // textBox_P
            // 
            this.textBox_P.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox_P.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox_P.Location = new System.Drawing.Point(33, 75);
            this.textBox_P.Name = "textBox_P";
            this.textBox_P.Size = new System.Drawing.Size(189, 20);
            this.textBox_P.TabIndex = 2;
            this.textBox_P.Text = "127";
            this.textBox_P.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_Q
            // 
            this.textBox_Q.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox_Q.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox_Q.Location = new System.Drawing.Point(33, 93);
            this.textBox_Q.Name = "textBox_Q";
            this.textBox_Q.Size = new System.Drawing.Size(189, 20);
            this.textBox_Q.TabIndex = 3;
            this.textBox_Q.Text = "521";
            this.textBox_Q.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_OriginalMessage
            // 
            this.textBox_OriginalMessage.Location = new System.Drawing.Point(20, 289);
            this.textBox_OriginalMessage.Multiline = true;
            this.textBox_OriginalMessage.Name = "textBox_OriginalMessage";
            this.textBox_OriginalMessage.Size = new System.Drawing.Size(202, 86);
            this.textBox_OriginalMessage.TabIndex = 4;
            this.textBox_OriginalMessage.Text = "Encrypt Me!@#$%^*(_=+";
            // 
            // label_RSA
            // 
            this.label_RSA.AutoSize = true;
            this.label_RSA.Location = new System.Drawing.Point(30, 9);
            this.label_RSA.Name = "label_RSA";
            this.label_RSA.Size = new System.Drawing.Size(29, 13);
            this.label_RSA.TabIndex = 6;
            this.label_RSA.Text = "RSA";
            // 
            // label_N_private
            // 
            this.label_N_private.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label_N_private.ForeColor = System.Drawing.Color.Red;
            this.label_N_private.Location = new System.Drawing.Point(413, 92);
            this.label_N_private.Name = "label_N_private";
            this.label_N_private.Size = new System.Drawing.Size(156, 20);
            this.label_N_private.TabIndex = 7;
            this.label_N_private.Text = "N (Module P*Q): ";
            // 
            // label_E
            // 
            this.label_E.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label_E.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label_E.Location = new System.Drawing.Point(245, 93);
            this.label_E.Name = "label_E";
            this.label_E.Size = new System.Drawing.Size(143, 20);
            this.label_E.TabIndex = 8;
            this.label_E.Text = "E (Exponent): ";
            // 
            // label_PublicKey
            // 
            this.label_PublicKey.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_PublicKey.ForeColor = System.Drawing.SystemColors.Window;
            this.label_PublicKey.Location = new System.Drawing.Point(245, 10);
            this.label_PublicKey.Name = "label_PublicKey";
            this.label_PublicKey.Size = new System.Drawing.Size(143, 65);
            this.label_PublicKey.TabIndex = 9;
            this.label_PublicKey.Text = "RSA Public Key";
            this.label_PublicKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_PrivateKey
            // 
            this.label_PrivateKey.BackColor = System.Drawing.SystemColors.MenuText;
            this.label_PrivateKey.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_PrivateKey.Location = new System.Drawing.Point(413, 9);
            this.label_PrivateKey.Name = "label_PrivateKey";
            this.label_PrivateKey.Size = new System.Drawing.Size(156, 65);
            this.label_PrivateKey.TabIndex = 10;
            this.label_PrivateKey.Text = "RSA Private Key";
            this.label_PrivateKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_D
            // 
            this.label_D.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label_D.ForeColor = System.Drawing.Color.Red;
            this.label_D.Location = new System.Drawing.Point(413, 74);
            this.label_D.Name = "label_D";
            this.label_D.Size = new System.Drawing.Size(156, 18);
            this.label_D.TabIndex = 12;
            this.label_D.Text = "D (Ptivate key):";
            // 
            // button_Encoder
            // 
            this.button_Encoder.Location = new System.Drawing.Point(18, 389);
            this.button_Encoder.Name = "button_Encoder";
            this.button_Encoder.Size = new System.Drawing.Size(110, 34);
            this.button_Encoder.TabIndex = 13;
            this.button_Encoder.Text = "Encrypt";
            this.button_Encoder.UseVisualStyleBackColor = true;
            this.button_Encoder.Click += new System.EventHandler(this.button_Encoder_Click);
            // 
            // button_Decoder
            // 
            this.button_Decoder.Location = new System.Drawing.Point(646, 389);
            this.button_Decoder.Name = "button_Decoder";
            this.button_Decoder.Size = new System.Drawing.Size(131, 34);
            this.button_Decoder.TabIndex = 14;
            this.button_Decoder.Text = "Decrypt";
            this.button_Decoder.UseVisualStyleBackColor = true;
            this.button_Decoder.Click += new System.EventHandler(this.button_Decoder_Click);
            // 
            // label_DecodedMessage
            // 
            this.label_DecodedMessage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_DecodedMessage.Location = new System.Drawing.Point(575, 183);
            this.label_DecodedMessage.Name = "label_DecodedMessage";
            this.label_DecodedMessage.Size = new System.Drawing.Size(202, 80);
            this.label_DecodedMessage.TabIndex = 15;
            // 
            // label_TextEncrypt
            // 
            this.label_TextEncrypt.AutoSize = true;
            this.label_TextEncrypt.Location = new System.Drawing.Point(495, 251);
            this.label_TextEncrypt.Name = "label_TextEncrypt";
            this.label_TextEncrypt.Size = new System.Drawing.Size(0, 13);
            this.label_TextEncrypt.TabIndex = 16;
            // 
            // label_SymmetricKey
            // 
            this.label_SymmetricKey.BackColor = System.Drawing.SystemColors.Highlight;
            this.label_SymmetricKey.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_SymmetricKey.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_SymmetricKey.Location = new System.Drawing.Point(20, 155);
            this.label_SymmetricKey.Name = "label_SymmetricKey";
            this.label_SymmetricKey.Size = new System.Drawing.Size(202, 31);
            this.label_SymmetricKey.TabIndex = 17;
            this.label_SymmetricKey.Text = "Symetrical key";
            this.label_SymmetricKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_OriginalSymmetricKey
            // 
            this.textBox_OriginalSymmetricKey.Location = new System.Drawing.Point(20, 183);
            this.textBox_OriginalSymmetricKey.Multiline = true;
            this.textBox_OriginalSymmetricKey.Name = "textBox_OriginalSymmetricKey";
            this.textBox_OriginalSymmetricKey.Size = new System.Drawing.Size(202, 80);
            this.textBox_OriginalSymmetricKey.TabIndex = 18;
            this.textBox_OriginalSymmetricKey.Text = "Key+*)^%$#@!  )))____";
            // 
            // label_CodedSymmetricalKey
            // 
            this.label_CodedSymmetricalKey.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_CodedSymmetricalKey.Location = new System.Drawing.Point(242, 186);
            this.label_CodedSymmetricalKey.Name = "label_CodedSymmetricalKey";
            this.label_CodedSymmetricalKey.Size = new System.Drawing.Size(202, 77);
            this.label_CodedSymmetricalKey.TabIndex = 19;
            // 
            // label_Error
            // 
            this.label_Error.Location = new System.Drawing.Point(0, 0);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(212, 23);
            this.label_Error.TabIndex = 25;
            // 
            // label_N_public
            // 
            this.label_N_public.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_N_public.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label_N_public.Location = new System.Drawing.Point(245, 75);
            this.label_N_public.Name = "label_N_public";
            this.label_N_public.Size = new System.Drawing.Size(143, 18);
            this.label_N_public.TabIndex = 21;
            this.label_N_public.Text = "N (Module P*Q): ";
            // 
            // label_CodedMessage
            // 
            this.label_CodedMessage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_CodedMessage.Location = new System.Drawing.Point(242, 288);
            this.label_CodedMessage.Name = "label_CodedMessage";
            this.label_CodedMessage.Size = new System.Drawing.Size(202, 87);
            this.label_CodedMessage.TabIndex = 22;
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(702, 10);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(75, 23);
            this.button_Reset.TabIndex = 23;
            this.button_Reset.Text = "Clear";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // label_DecodedSymmetricalKey
            // 
            this.label_DecodedSymmetricalKey.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_DecodedSymmetricalKey.Location = new System.Drawing.Point(575, 286);
            this.label_DecodedSymmetricalKey.Name = "label_DecodedSymmetricalKey";
            this.label_DecodedSymmetricalKey.Size = new System.Drawing.Size(202, 89);
            this.label_DecodedSymmetricalKey.TabIndex = 24;
            // 
            // label_CharacterCount
            // 
            this.label_CharacterCount.AutoSize = true;
            this.label_CharacterCount.BackColor = System.Drawing.SystemColors.Window;
            this.label_CharacterCount.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_CharacterCount.Location = new System.Drawing.Point(17, 428);
            this.label_CharacterCount.Name = "label_CharacterCount";
            this.label_CharacterCount.Size = new System.Drawing.Size(185, 13);
            this.label_CharacterCount.TabIndex = 26;
            this.label_CharacterCount.Text = "Number of characters in the alphabet:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(242, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Encrypted message (RC4)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Lime;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(575, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Decrypted symetrical key (RSA)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(242, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 31);
            this.label5.TabIndex = 30;
            this.label5.Text = "Encrypted Symetrical key (RSA)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_encrypt_message
            // 
            this.label_encrypt_message.BackColor = System.Drawing.SystemColors.Highlight;
            this.label_encrypt_message.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_encrypt_message.Location = new System.Drawing.Point(20, 266);
            this.label_encrypt_message.Name = "label_encrypt_message";
            this.label_encrypt_message.Size = new System.Drawing.Size(202, 26);
            this.label_encrypt_message.TabIndex = 31;
            this.label_encrypt_message.Text = "Message";
            this.label_encrypt_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(575, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 28);
            this.label2.TabIndex = 32;
            this.label2.Text = "Decrypted message (RC4)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_rsa_input
            // 
            this.label_rsa_input.BackColor = System.Drawing.SystemColors.Highlight;
            this.label_rsa_input.ForeColor = System.Drawing.SystemColors.Window;
            this.label_rsa_input.Location = new System.Drawing.Point(33, 38);
            this.label_rsa_input.Name = "label_rsa_input";
            this.label_rsa_input.Size = new System.Drawing.Size(189, 37);
            this.label_rsa_input.TabIndex = 33;
            this.label_rsa_input.Text = "Enter prime numbers";
            this.label_rsa_input.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HybridEncode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_rsa_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_encrypt_message);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_CharacterCount);
            this.Controls.Add(this.label_DecodedSymmetricalKey);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.label_CodedMessage);
            this.Controls.Add(this.label_N_public);
            this.Controls.Add(this.label_Error);
            this.Controls.Add(this.label_CodedSymmetricalKey);
            this.Controls.Add(this.textBox_OriginalSymmetricKey);
            this.Controls.Add(this.label_SymmetricKey);
            this.Controls.Add(this.label_TextEncrypt);
            this.Controls.Add(this.label_DecodedMessage);
            this.Controls.Add(this.button_Decoder);
            this.Controls.Add(this.button_Encoder);
            this.Controls.Add(this.label_D);
            this.Controls.Add(this.label_PrivateKey);
            this.Controls.Add(this.label_PublicKey);
            this.Controls.Add(this.label_E);
            this.Controls.Add(this.label_N_private);
            this.Controls.Add(this.label_RSA);
            this.Controls.Add(this.textBox_OriginalMessage);
            this.Controls.Add(this.textBox_Q);
            this.Controls.Add(this.textBox_P);
            this.Controls.Add(this.label_Q);
            this.Controls.Add(this.label_P);
            this.Name = "HybridEncode";
            this.Text = "Hybrid cryptosystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_P;
        private System.Windows.Forms.Label label_Q;
        private System.Windows.Forms.TextBox textBox_P;
        private System.Windows.Forms.TextBox textBox_Q;
        private System.Windows.Forms.TextBox textBox_OriginalMessage;
        private System.Windows.Forms.Label label_RSA;
        private System.Windows.Forms.Label label_N_private;
        private System.Windows.Forms.Label label_E;
        private System.Windows.Forms.Label label_PublicKey;
        private System.Windows.Forms.Label label_PrivateKey;
        private System.Windows.Forms.Label label_D;
        private System.Windows.Forms.Button button_Encoder;
        private System.Windows.Forms.Button button_Decoder;
        private System.Windows.Forms.Label label_DecodedMessage;
        private System.Windows.Forms.Label label_TextEncrypt;
        private System.Windows.Forms.Label label_SymmetricKey;
        private System.Windows.Forms.TextBox textBox_OriginalSymmetricKey;
        private System.Windows.Forms.Label label_CodedSymmetricalKey;
        private System.Windows.Forms.Label label_Error;
        private System.Windows.Forms.Label label_N_public;
        private System.Windows.Forms.Label label_CodedMessage;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Label label_DecodedSymmetricalKey;
        private System.Windows.Forms.Label label_CharacterCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_encrypt_message;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_rsa_input;
    }
}

