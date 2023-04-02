namespace GestionMatos
{
    partial class site
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.inputCp = new System.Windows.Forms.TextBox();
            this.inputDepartement = new System.Windows.Forms.TextBox();
            this.inputNom = new System.Windows.Forms.TextBox();
            this.inputIdsite = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdSite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codepostale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputAdresse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, -45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 32);
            this.label1.TabIndex = 46;
            this.label1.Text = "IdClient";
            // 
            // inputId
            // 
            this.inputId.Location = new System.Drawing.Point(232, -45);
            this.inputId.Name = "inputId";
            this.inputId.Size = new System.Drawing.Size(245, 38);
            this.inputId.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 32);
            this.label3.TabIndex = 59;
            this.label3.Text = "Departement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 32);
            this.label2.TabIndex = 58;
            this.label2.Text = "Nom Client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 32);
            this.label4.TabIndex = 57;
            this.label4.Text = "Id Site";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(767, 382);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(172, 55);
            this.btnNew.TabIndex = 56;
            this.btnNew.Text = "Nouveau";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(560, 382);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(172, 55);
            this.btnModifier.TabIndex = 55;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(959, 382);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(172, 55);
            this.btnDelete.TabIndex = 54;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(345, 382);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(172, 55);
            this.btnAdd.TabIndex = 53;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // inputCp
            // 
            this.inputCp.Location = new System.Drawing.Point(345, 268);
            this.inputCp.Name = "inputCp";
            this.inputCp.Size = new System.Drawing.Size(245, 38);
            this.inputCp.TabIndex = 52;
            // 
            // inputDepartement
            // 
            this.inputDepartement.Location = new System.Drawing.Point(345, 206);
            this.inputDepartement.Name = "inputDepartement";
            this.inputDepartement.Size = new System.Drawing.Size(245, 38);
            this.inputDepartement.TabIndex = 51;
            // 
            // inputNom
            // 
            this.inputNom.Location = new System.Drawing.Point(345, 139);
            this.inputNom.Name = "inputNom";
            this.inputNom.Size = new System.Drawing.Size(245, 38);
            this.inputNom.TabIndex = 50;
            // 
            // inputIdsite
            // 
            this.inputIdsite.Location = new System.Drawing.Point(345, 74);
            this.inputIdsite.Name = "inputIdsite";
            this.inputIdsite.Size = new System.Drawing.Size(245, 38);
            this.inputIdsite.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 32);
            this.label6.TabIndex = 48;
            this.label6.Text = "Code Postale";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSite,
            this.nomclient,
            this.departement,
            this.codepostale,
            this.Adresse});
            this.dataGridView1.Location = new System.Drawing.Point(231, 460);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1055, 428);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IdSite
            // 
            this.IdSite.HeaderText = "ID Site";
            this.IdSite.MinimumWidth = 12;
            this.IdSite.Name = "IdSite";
            // 
            // nomclient
            // 
            this.nomclient.HeaderText = "Nom Client";
            this.nomclient.MinimumWidth = 12;
            this.nomclient.Name = "nomclient";
            // 
            // departement
            // 
            this.departement.HeaderText = "Departement";
            this.departement.MinimumWidth = 12;
            this.departement.Name = "departement";
            // 
            // codepostale
            // 
            this.codepostale.HeaderText = "Code Postale";
            this.codepostale.MinimumWidth = 12;
            this.codepostale.Name = "codepostale";
            // 
            // Adresse
            // 
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.MinimumWidth = 12;
            this.Adresse.Name = "Adresse";
            // 
            // inputAdresse
            // 
            this.inputAdresse.Location = new System.Drawing.Point(345, 320);
            this.inputAdresse.Name = "inputAdresse";
            this.inputAdresse.Size = new System.Drawing.Size(245, 38);
            this.inputAdresse.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 32);
            this.label5.TabIndex = 60;
            this.label5.Text = "Adresse";
            // 
            // site
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1456, 993);
            this.Controls.Add(this.inputAdresse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.inputCp);
            this.Controls.Add(this.inputDepartement);
            this.Controls.Add(this.inputNom);
            this.Controls.Add(this.inputIdsite);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputId);
            this.Name = "site";
            this.Text = "site";
            this.Load += new System.EventHandler(this.site_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox inputCp;
        private System.Windows.Forms.TextBox inputDepartement;
        private System.Windows.Forms.TextBox inputNom;
        private System.Windows.Forms.TextBox inputIdsite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSite;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn departement;
        private System.Windows.Forms.DataGridViewTextBoxColumn codepostale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.TextBox inputAdresse;
        private System.Windows.Forms.Label label5;
    }
}