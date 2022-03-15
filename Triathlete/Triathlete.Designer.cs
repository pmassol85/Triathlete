
namespace Triathlete
{
    partial class Triathlete
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtLic = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtPren = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtM = new System.Windows.Forms.RadioButton();
            this.radioButtF = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.comboClub = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxEntraine = new System.Windows.Forms.CheckBox();
            this.btCreer = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboCateg = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtPremLic = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(676, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 230);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(742, 252);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Charger photo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(152, 14);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(263, 23);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtLic
            // 
            this.txtLic.Location = new System.Drawing.Point(152, 55);
            this.txtLic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLic.Name = "txtLic";
            this.txtLic.ReadOnly = true;
            this.txtLic.Size = new System.Drawing.Size(242, 23);
            this.txtLic.TabIndex = 3;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(152, 222);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(242, 23);
            this.txtAdresse.TabIndex = 4;
            // 
            // txtPren
            // 
            this.txtPren.Location = new System.Drawing.Point(152, 186);
            this.txtPren.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPren.Name = "txtPren";
            this.txtPren.Size = new System.Drawing.Size(242, 23);
            this.txtPren.TabIndex = 5;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(152, 144);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(242, 23);
            this.txtNom.TabIndex = 6;
            this.txtNom.Validating += new System.ComponentModel.CancelEventHandler(this.txtNom_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numéro de licence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prénom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Adresse";
            // 
            // radioButtM
            // 
            this.radioButtM.AutoSize = true;
            this.radioButtM.Location = new System.Drawing.Point(7, 22);
            this.radioButtM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButtM.Name = "radioButtM";
            this.radioButtM.Size = new System.Drawing.Size(69, 19);
            this.radioButtM.TabIndex = 11;
            this.radioButtM.TabStop = true;
            this.radioButtM.Text = "Homme";
            this.radioButtM.UseVisualStyleBackColor = true;
            // 
            // radioButtF
            // 
            this.radioButtF.AutoSize = true;
            this.radioButtF.Location = new System.Drawing.Point(113, 22);
            this.radioButtF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButtF.Name = "radioButtF";
            this.radioButtF.Size = new System.Drawing.Size(65, 19);
            this.radioButtF.TabIndex = 12;
            this.radioButtF.TabStop = true;
            this.radioButtF.Text = "Femme";
            this.radioButtF.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtM);
            this.groupBox1.Controls.Add(this.radioButtF);
            this.groupBox1.Location = new System.Drawing.Point(152, 293);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(233, 50);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexe";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(152, 350);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(242, 23);
            this.txtMail.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 358);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Email";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(155, 263);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 23);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 270);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Date de naissance";
            // 
            // comboClub
            // 
            this.comboClub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClub.FormattingEnabled = true;
            this.comboClub.Location = new System.Drawing.Point(126, 14);
            this.comboClub.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboClub.Name = "comboClub";
            this.comboClub.Size = new System.Drawing.Size(263, 23);
            this.comboClub.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Club";
            // 
            // checkBoxEntraine
            // 
            this.checkBoxEntraine.AutoSize = true;
            this.checkBoxEntraine.Location = new System.Drawing.Point(795, 14);
            this.checkBoxEntraine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxEntraine.Name = "checkBoxEntraine";
            this.checkBoxEntraine.Size = new System.Drawing.Size(88, 19);
            this.checkBoxEntraine.TabIndex = 20;
            this.checkBoxEntraine.Text = "Entraineur ?";
            this.checkBoxEntraine.UseVisualStyleBackColor = true;
            // 
            // btCreer
            // 
            this.btCreer.Location = new System.Drawing.Point(168, 470);
            this.btCreer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btCreer.Name = "btCreer";
            this.btCreer.Size = new System.Drawing.Size(88, 27);
            this.btCreer.TabIndex = 21;
            this.btCreer.Text = "Créer";
            this.btCreer.UseVisualStyleBackColor = true;
            this.btCreer.Click += new System.EventHandler(this.btCreer_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(404, 470);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 27);
            this.button3.TabIndex = 22;
            this.button3.Text = "Modifier";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(664, 470);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 27);
            this.button4.TabIndex = 23;
            this.button4.Text = "Supprimer";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // comboCateg
            // 
            this.comboCateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCateg.FormattingEnabled = true;
            this.comboCateg.Location = new System.Drawing.Point(152, 105);
            this.comboCateg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboCateg.Name = "comboCateg";
            this.comboCateg.Size = new System.Drawing.Size(242, 23);
            this.comboCateg.TabIndex = 24;
            this.comboCateg.Validating += new System.ComponentModel.CancelEventHandler(this.comboCateg_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 108);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "Catégorie d\'age";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 22);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "Choisir un athlète";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(414, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 15);
            this.label9.TabIndex = 29;
            this.label9.Text = "Date première licence";
            // 
            // dtPremLic
            // 
            this.dtPremLic.Location = new System.Drawing.Point(536, 14);
            this.dtPremLic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtPremLic.Name = "dtPremLic";
            this.dtPremLic.Size = new System.Drawing.Size(233, 23);
            this.dtPremLic.TabIndex = 28;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dtPremLic);
            this.groupBox2.Controls.Add(this.checkBoxEntraine);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboClub);
            this.groupBox2.Location = new System.Drawing.Point(26, 384);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(898, 51);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Licencié en club";
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(402, 221);
            this.txtCP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(70, 23);
            this.txtCP.TabIndex = 31;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(480, 222);
            this.txtVille.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(188, 23);
            this.txtVille.TabIndex = 32;
            // 
            // Triathlete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboCateg);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btCreer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtPren);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtLic);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Triathlete";
            this.Text = "Triathlete";
            this.Load += new System.EventHandler(this.Triathlete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtLic;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtPren;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtM;
        private System.Windows.Forms.RadioButton radioButtF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboClub;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxEntraine;
        private System.Windows.Forms.Button btCreer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboCateg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtPremLic;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}