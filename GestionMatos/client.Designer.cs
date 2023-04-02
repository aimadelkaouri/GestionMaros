namespace GestionMatos
{
    partial class client
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
            this.btnNew = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.inputTel = new System.Windows.Forms.TextBox();
            this.inputMail = new System.Windows.Forms.TextBox();
            this.inputNom = new System.Windows.Forms.TextBox();
            this.inputId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IdClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(706, 341);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(172, 55);
            this.btnNew.TabIndex = 30;
            this.btnNew.Text = "Nouveau";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(499, 341);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(172, 55);
            this.btnModifier.TabIndex = 29;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(898, 341);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(172, 55);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(284, 341);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(172, 55);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // inputTel
            // 
            this.inputTel.Location = new System.Drawing.Point(316, 258);
            this.inputTel.Name = "inputTel";
            this.inputTel.Size = new System.Drawing.Size(245, 38);
            this.inputTel.TabIndex = 25;
            // 
            // inputMail
            // 
            this.inputMail.Location = new System.Drawing.Point(316, 196);
            this.inputMail.Name = "inputMail";
            this.inputMail.Size = new System.Drawing.Size(245, 38);
            this.inputMail.TabIndex = 24;
            // 
            // inputNom
            // 
            this.inputNom.Location = new System.Drawing.Point(316, 129);
            this.inputNom.Name = "inputNom";
            this.inputNom.Size = new System.Drawing.Size(245, 38);
            this.inputNom.TabIndex = 23;
            // 
            // inputId
            // 
            this.inputId.Location = new System.Drawing.Point(316, 64);
            this.inputId.Name = "inputId";
            this.inputId.Size = new System.Drawing.Size(245, 38);
            this.inputId.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 32);
            this.label6.TabIndex = 20;
            this.label6.Text = "Tel Client";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdClient,
            this.nomclient,
            this.mailclient,
            this.telClient});
            this.dataGridView1.Location = new System.Drawing.Point(170, 419);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1055, 428);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 32);
            this.label3.TabIndex = 35;
            this.label3.Text = "Mail Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 32);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nom Client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "IdClient";
            // 
            // IdClient
            // 
            this.IdClient.HeaderText = "ID Client";
            this.IdClient.MinimumWidth = 12;
            this.IdClient.Name = "IdClient";
            // 
            // nomclient
            // 
            this.nomclient.HeaderText = "Nom Client";
            this.nomclient.MinimumWidth = 12;
            this.nomclient.Name = "nomclient";
            // 
            // mailclient
            // 
            this.mailclient.HeaderText = "Mail Client";
            this.mailclient.MinimumWidth = 12;
            this.mailclient.Name = "mailclient";
            // 
            // telClient
            // 
            this.telClient.HeaderText = "Tel Client";
            this.telClient.MinimumWidth = 12;
            this.telClient.Name = "telClient";
            // 
            // client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1379, 968);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.inputTel);
            this.Controls.Add(this.inputMail);
            this.Controls.Add(this.inputNom);
            this.Controls.Add(this.inputId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Name = "client";
            this.Text = "client";
            this.Load += new System.EventHandler(this.client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox inputTel;
        private System.Windows.Forms.TextBox inputMail;
        private System.Windows.Forms.TextBox inputNom;
        private System.Windows.Forms.TextBox inputId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn telClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}