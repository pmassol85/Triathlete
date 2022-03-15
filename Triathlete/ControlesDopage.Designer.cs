
namespace Triathlete
{
    partial class ControlesDopage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTriathlon = new System.Windows.Forms.ComboBox();
            this.cbInscrip = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bValidate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(77, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(400, 194);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Triathlon";
            // 
            // cbTriathlon
            // 
            this.cbTriathlon.FormattingEnabled = true;
            this.cbTriathlon.Location = new System.Drawing.Point(143, 66);
            this.cbTriathlon.Name = "cbTriathlon";
            this.cbTriathlon.Size = new System.Drawing.Size(286, 23);
            this.cbTriathlon.TabIndex = 2;
            this.cbTriathlon.SelectedIndexChanged += new System.EventHandler(this.cbTriathlon_SelectedIndexChanged);
            // 
            // cbInscrip
            // 
            this.cbInscrip.FormattingEnabled = true;
            this.cbInscrip.Location = new System.Drawing.Point(143, 100);
            this.cbInscrip.Name = "cbInscrip";
            this.cbInscrip.Size = new System.Drawing.Size(286, 23);
            this.cbInscrip.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Incription";
            // 
            // bValidate
            // 
            this.bValidate.Location = new System.Drawing.Point(229, 371);
            this.bValidate.Name = "bValidate";
            this.bValidate.Size = new System.Drawing.Size(75, 23);
            this.bValidate.TabIndex = 5;
            this.bValidate.Text = "Valider";
            this.bValidate.UseVisualStyleBackColor = true;
            this.bValidate.Click += new System.EventHandler(this.bValidate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(143, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gestion des contrôles";
            // 
            // ControlesDopage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 408);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bValidate);
            this.Controls.Add(this.cbInscrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTriathlon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ControlesDopage";
            this.Text = "ControlesDopage";
            this.Load += new System.EventHandler(this.ControlesDopage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTriathlon;
        private System.Windows.Forms.ComboBox cbInscrip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bValidate;
        private System.Windows.Forms.Label label3;
    }
}