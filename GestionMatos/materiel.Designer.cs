namespace GestionMatos
{
    partial class materiel
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
            this.IdMateriel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtbf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInstallation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inputId = new System.Windows.Forms.TextBox();
            this.inputNom = new System.Windows.Forms.TextBox();
            this.inputSerie = new System.Windows.Forms.TextBox();
            this.inputMtbf = new System.Windows.Forms.TextBox();
            this.inputDate = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.inputDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMateriel,
            this.nom,
            this.numSerie,
            this.mtbf,
            this.dateInstallation,
            this.description});
            this.dataGridView1.Location = new System.Drawing.Point(77, 339);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1055, 428);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IdMateriel
            // 
            this.IdMateriel.HeaderText = "ID Materiel";
            this.IdMateriel.MinimumWidth = 12;
            this.IdMateriel.Name = "IdMateriel";
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.MinimumWidth = 12;
            this.nom.Name = "nom";
            // 
            // numSerie
            // 
            this.numSerie.HeaderText = "numéro de Serie";
            this.numSerie.MinimumWidth = 12;
            this.numSerie.Name = "numSerie";
            // 
            // mtbf
            // 
            this.mtbf.HeaderText = "MTBF";
            this.mtbf.MinimumWidth = 12;
            this.mtbf.Name = "mtbf";
            // 
            // dateInstallation
            // 
            this.dateInstallation.HeaderText = "Date Installation";
            this.dateInstallation.MinimumWidth = 12;
            this.dateInstallation.Name = "dateInstallation";
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 12;
            this.description.Name = "description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "IdMateriel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Num de série";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date d\'installation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(619, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = "MTBF";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // inputId
            // 
            this.inputId.Location = new System.Drawing.Point(225, 26);
            this.inputId.Name = "inputId";
            this.inputId.Size = new System.Drawing.Size(245, 38);
            this.inputId.TabIndex = 7;
            // 
            // inputNom
            // 
            this.inputNom.Location = new System.Drawing.Point(225, 91);
            this.inputNom.Name = "inputNom";
            this.inputNom.Size = new System.Drawing.Size(245, 38);
            this.inputNom.TabIndex = 8;
            // 
            // inputSerie
            // 
            this.inputSerie.Location = new System.Drawing.Point(225, 158);
            this.inputSerie.Name = "inputSerie";
            this.inputSerie.Size = new System.Drawing.Size(245, 38);
            this.inputSerie.TabIndex = 9;
            // 
            // inputMtbf
            // 
            this.inputMtbf.Location = new System.Drawing.Point(762, 23);
            this.inputMtbf.Name = "inputMtbf";
            this.inputMtbf.Size = new System.Drawing.Size(245, 38);
            this.inputMtbf.TabIndex = 10;
            // 
            // inputDate
            // 
            this.inputDate.Location = new System.Drawing.Point(762, 97);
            this.inputDate.Name = "inputDate";
            this.inputDate.Size = new System.Drawing.Size(245, 38);
            this.inputDate.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(191, 261);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(172, 55);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(805, 261);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(172, 55);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(406, 261);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(172, 55);
            this.btnModifier.TabIndex = 15;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(613, 261);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(172, 55);
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "Nouveau";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // inputDescription
            // 
            this.inputDescription.Location = new System.Drawing.Point(762, 158);
            this.inputDescription.Name = "inputDescription";
            this.inputDescription.Size = new System.Drawing.Size(245, 38);
            this.inputDescription.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(599, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 32);
            this.label4.TabIndex = 17;
            this.label4.Text = "Description";
            // 
            // materiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1528, 980);
            this.Controls.Add(this.inputDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.inputDate);
            this.Controls.Add(this.inputMtbf);
            this.Controls.Add(this.inputSerie);
            this.Controls.Add(this.inputNom);
            this.Controls.Add(this.inputId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "materiel";
            this.Text = "materielcs";
            this.Load += new System.EventHandler(this.materiel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputId;
        private System.Windows.Forms.TextBox inputNom;
        private System.Windows.Forms.TextBox inputSerie;
        private System.Windows.Forms.TextBox inputMtbf;
        private System.Windows.Forms.TextBox inputDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox inputDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMateriel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn numSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn mtbf;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInstallation;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
    }
}