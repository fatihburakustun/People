namespace PeopleWin
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
            this.btnGetir = new System.Windows.Forms.Button();
            this.dgwGetir = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYas = new System.Windows.Forms.Button();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGetir)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(495, 377);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(129, 71);
            this.btnGetir.TabIndex = 0;
            this.btnGetir.Text = "GETİR";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // dgwGetir
            // 
            this.dgwGetir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGetir.Location = new System.Drawing.Point(12, 12);
            this.dgwGetir.Name = "dgwGetir";
            this.dgwGetir.Size = new System.Drawing.Size(612, 359);
            this.dgwGetir.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "SOYİSMİNİ GİRİNİZ :";
            this.label1.Visible = false;
            // 
            // btnYas
            // 
            this.btnYas.Location = new System.Drawing.Point(96, 448);
            this.btnYas.Name = "btnYas";
            this.btnYas.Size = new System.Drawing.Size(85, 33);
            this.btnYas.TabIndex = 6;
            this.btnYas.Text = "YAS";
            this.btnYas.UseVisualStyleBackColor = true;
            this.btnYas.Visible = false;
            this.btnYas.Click += new System.EventHandler(this.btnYas_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(148, 403);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(148, 20);
            this.txtSoyad.TabIndex = 5;
            this.txtSoyad.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 507);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYas);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.dgwGetir);
            this.Controls.Add(this.btnGetir);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgwGetir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.DataGridView dgwGetir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYas;
        private System.Windows.Forms.TextBox txtSoyad;

    }
}

