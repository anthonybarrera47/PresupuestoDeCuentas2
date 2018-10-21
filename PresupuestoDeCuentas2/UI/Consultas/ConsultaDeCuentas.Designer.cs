namespace PresupuestoDeCuentas2.UI.Consultas
{
    partial class ConsultaDeCuentas
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
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ConsultaButton = new System.Windows.Forms.Button();
            this.ConsultaVendedoresDataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ImprimrButton = new System.Windows.Forms.Button();
            this.vendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaVendedoresDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(78, 74);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(114, 22);
            this.DesdedateTimePicker.TabIndex = 1;
            this.DesdedateTimePicker.ValueChanged += new System.EventHandler(this.DesdedateTimePicker_ValueChanged);
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastadateTimePicker.Location = new System.Drawing.Point(352, 74);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(114, 22);
            this.HastadateTimePicker.TabIndex = 2;
            this.HastadateTimePicker.ValueChanged += new System.EventHandler(this.HastadateTimePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta";
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.DisplayMember = "0";
            this.FiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Todos",
            "ID"});
            this.FiltroComboBox.Location = new System.Drawing.Point(26, 44);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(166, 24);
            this.FiltroComboBox.TabIndex = 5;
            this.FiltroComboBox.ValueMember = "0";
            this.FiltroComboBox.TextChanged += new System.EventHandler(this.FiltroComboBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filtro";
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Location = new System.Drawing.Point(198, 44);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(268, 22);
            this.CriterioTextBox.TabIndex = 7;
            this.CriterioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CriterioTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Criterio";
            // 
            // ConsultaButton
            // 
            this.ConsultaButton.Location = new System.Drawing.Point(534, 43);
            this.ConsultaButton.Name = "ConsultaButton";
            this.ConsultaButton.Size = new System.Drawing.Size(94, 23);
            this.ConsultaButton.TabIndex = 9;
            this.ConsultaButton.Text = "Consulta";
            this.ConsultaButton.UseVisualStyleBackColor = true;
            this.ConsultaButton.Click += new System.EventHandler(this.ConsultaButton_Click_1);
            // 
            // ConsultaVendedoresDataGridView
            // 
            this.ConsultaVendedoresDataGridView.ColumnHeadersHeight = 30;
            this.ConsultaVendedoresDataGridView.Location = new System.Drawing.Point(12, 111);
            this.ConsultaVendedoresDataGridView.Name = "ConsultaVendedoresDataGridView";
            this.ConsultaVendedoresDataGridView.ReadOnly = true;
            this.ConsultaVendedoresDataGridView.RowTemplate.Height = 24;
            this.ConsultaVendedoresDataGridView.Size = new System.Drawing.Size(840, 329);
            this.ConsultaVendedoresDataGridView.TabIndex = 10;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ImprimrButton
            // 
            this.ImprimrButton.Image = global::PresupuestoDeCuentas2.Properties.Resources.if_print_326675;
            this.ImprimrButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ImprimrButton.Location = new System.Drawing.Point(12, 446);
            this.ImprimrButton.Name = "ImprimrButton";
            this.ImprimrButton.Size = new System.Drawing.Size(104, 45);
            this.ImprimrButton.TabIndex = 11;
            this.ImprimrButton.Text = "Imprimir";
            this.ImprimrButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ImprimrButton.UseVisualStyleBackColor = true;
            this.ImprimrButton.Click += new System.EventHandler(this.ImprimrButton_Click);
            // 
            // ConsultaDeCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 501);
            this.Controls.Add(this.ImprimrButton);
            this.Controls.Add(this.ConsultaVendedoresDataGridView);
            this.Controls.Add(this.ConsultaButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.DesdedateTimePicker);
            this.MinimizeBox = false;
            this.Name = "ConsultaDeCuentas";
            this.Text = "Consultar Presupuesto";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaVendedoresDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource vendedorBindingSource;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ConsultaButton;
        private System.Windows.Forms.DataGridView ConsultaVendedoresDataGridView;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button ImprimrButton;
    }
}