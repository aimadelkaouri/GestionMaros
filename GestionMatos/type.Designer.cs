namespace GestionMatos
{
    partial class type
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
            this.inputId = new System.Windows.Forms.TextBox();
            this.inputNomMateriel = new System.Windows.Forms.TextBox();
            this.inputTypeMateriel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputNom = new System.Windows.Forms.Label();
            this.inputType = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.idtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typemateriel1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtype,
            this.nom1,
            this.typemateriel1});
            this.dataGridView1.Location = new System.Drawing.Point(215, 368);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(863, 402);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // inputId
            // 
            this.inputId.Location = new System.Drawing.Point(215, 72);
            this.inputId.Name = "inputId";
            this.inputId.Size = new System.Drawing.Size(368, 38);
            this.inputId.TabIndex = 1;
            // 
            // inputNomMateriel
            // 
            this.inputNomMateriel.Location = new System.Drawing.Point(215, 145);
            this.inputNomMateriel.Name = "inputNomMateriel";
            this.inputNomMateriel.Size = new System.Drawing.Size(368, 38);
            this.inputNomMateriel.TabIndex = 2;
            // 
            // inputTypeMateriel
            // 
            this.inputTypeMateriel.Location = new System.Drawing.Point(215, 221);
            this.inputTypeMateriel.Name = "inputTypeMateriel";
            this.inputTypeMateriel.Size = new System.Drawing.Size(368, 38);
            this.inputTypeMateriel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "id Type";
            // 
            // inputNom
            // 
            this.inputNom.AutoSize = true;
            this.inputNom.Location = new System.Drawing.Point(35, 148);
            this.inputNom.Name = "inputNom";
            this.inputNom.Size = new System.Drawing.Size(182, 32);
            this.inputNom.TabIndex = 5;
            this.inputNom.Text = "Nom Materiel";
            // 
            // inputType
            // 
            this.inputType.AutoSize = true;
            this.inputType.Location = new System.Drawing.Point(35, 227);
            this.inputType.Name = "inputType";
            this.inputType.Size = new System.Drawing.Size(77, 32);
            this.inputType.TabIndex = 6;
            this.inputType.Text = "Type";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(663, 293);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(172, 55);
            this.btnNew.TabIndex = 60;
            this.btnNew.Text = "Nouveau";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(456, 293);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(172, 55);
            this.btnModifier.TabIndex = 59;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(855, 293);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(172, 55);
            this.btnDelete.TabIndex = 58;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(241, 293);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(172, 55);
            this.btnAdd.TabIndex = 57;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // idtype
            // 
            this.idtype.HeaderText = "Id Type";
            this.idtype.MinimumWidth = 12;
            this.idtype.Name = "idtype";
            // 
            // nom1
            // 
            this.nom1.HeaderText = "Nom";
            this.nom1.MinimumWidth = 12;
            this.nom1.Name = "nom1";
            // 
            // typemateriel1
            // 
            this.typemateriel1.HeaderText = "Type";
            this.typemateriel1.MinimumWidth = 12;
            this.typemateriel1.Name = "typemateriel1";
            // 
            // type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1273, 802);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.inputType);
            this.Controls.Add(this.inputNom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTypeMateriel);
            this.Controls.Add(this.inputNomMateriel);
            this.Controls.Add(this.inputId);
            this.Controls.Add(this.dataGridView1);
            this.Name = "type";
            this.Text = "type";
            this.Load += new System.EventHandler(this.type_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox inputId;
        private System.Windows.Forms.TextBox inputNomMateriel;
        private System.Windows.Forms.TextBox inputTypeMateriel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label inputNom;
        private System.Windows.Forms.Label inputType;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typemateriel1;
    }
}