namespace AgregarEquiposPorPais.Winform
{
    partial class FormularioAgregarEquipo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTeamName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtCountryName = new TextBox();
            btnAgregarEquipo = new Button();
            label3 = new Label();
            dataGridViewToFill = new DataGridView();
            dataGridTeamId = new DataGridViewTextBoxColumn();
            dataGridTeamName = new DataGridViewTextBoxColumn();
            dataGridCountryName = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewToFill).BeginInit();
            SuspendLayout();
            // 
            // txtTeamName
            // 
            txtTeamName.Location = new Point(12, 36);
            txtTeamName.Name = "txtTeamName";
            txtTeamName.Size = new Size(134, 23);
            txtTeamName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Equipo";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 18);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 3;
            label2.Text = "Pais";
            // 
            // txtCountryName
            // 
            txtCountryName.Location = new Point(152, 36);
            txtCountryName.Name = "txtCountryName";
            txtCountryName.Size = new Size(132, 23);
            txtCountryName.TabIndex = 2;
            // 
            // btnAgregarEquipo
            // 
            btnAgregarEquipo.Location = new Point(290, 35);
            btnAgregarEquipo.Name = "btnAgregarEquipo";
            btnAgregarEquipo.Size = new Size(75, 23);
            btnAgregarEquipo.TabIndex = 4;
            btnAgregarEquipo.Text = "Agregar";
            btnAgregarEquipo.UseVisualStyleBackColor = true;
            btnAgregarEquipo.Click += btnAgregarEquipo_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 136);
            label3.Name = "label3";
            label3.Size = new Size(138, 15);
            label3.TabIndex = 6;
            label3.Text = "Lista de equipos actuales";
            // 
            // dataGridViewToFill
            // 
            dataGridViewToFill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewToFill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewToFill.Columns.AddRange(new DataGridViewColumn[] { dataGridTeamId, dataGridTeamName, dataGridCountryName });
            dataGridViewToFill.Location = new Point(12, 154);
            dataGridViewToFill.Name = "dataGridViewToFill";
            dataGridViewToFill.Size = new Size(466, 122);
            dataGridViewToFill.TabIndex = 7;
            dataGridViewToFill.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // dataGridTeamId
            // 
            dataGridTeamId.HeaderText = "ID";
            dataGridTeamId.Name = "dataGridTeamId";
            // 
            // dataGridTeamName
            // 
            dataGridTeamName.HeaderText = "Nombre";
            dataGridTeamName.Name = "dataGridTeamName";
            // 
            // dataGridCountryName
            // 
            dataGridCountryName.HeaderText = "Pais";
            dataGridCountryName.Name = "dataGridCountryName";
            // 
            // FormularioAgregarEquipo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 288);
            Controls.Add(dataGridViewToFill);
            Controls.Add(label3);
            Controls.Add(btnAgregarEquipo);
            Controls.Add(label2);
            Controls.Add(txtCountryName);
            Controls.Add(label1);
            Controls.Add(txtTeamName);
            Name = "FormularioAgregarEquipo";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewToFill).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTeamName;
        private Label label1;
        private Label label2;
        private TextBox txtCountryName;
        private Button btnAgregarEquipo;
        private Label label3;
        private DataGridView dataGridViewToFill;
        private DataGridViewTextBoxColumn dataGridTeamId;
        private DataGridViewTextBoxColumn dataGridTeamName;
        private DataGridViewTextBoxColumn dataGridCountryName;
    }
}
