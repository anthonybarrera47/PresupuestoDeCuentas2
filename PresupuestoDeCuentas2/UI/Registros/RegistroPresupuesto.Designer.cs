namespace PresupuestoDeCuentas2.UI.Registros
{
    partial class RegistroPresupuesto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.FechaTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PresupuestoIDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CuentascomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ValorTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.AgregarCuentaButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TotalTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RemoverFila = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PresupuestoIDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha";
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(116, 57);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(310, 22);
            this.DescripciontextBox.TabIndex = 4;
            // 
            // FechaTimePicker
            // 
            this.FechaTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaTimePicker.Location = new System.Drawing.Point(116, 85);
            this.FechaTimePicker.Name = "FechaTimePicker";
            this.FechaTimePicker.Size = new System.Drawing.Size(120, 22);
            this.FechaTimePicker.TabIndex = 5;
            // 
            // PresupuestoIDnumericUpDown
            // 
            this.PresupuestoIDnumericUpDown.Location = new System.Drawing.Point(116, 30);
            this.PresupuestoIDnumericUpDown.Name = "PresupuestoIDnumericUpDown";
            this.PresupuestoIDnumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.PresupuestoIDnumericUpDown.TabIndex = 6;
            // 
            // CuentascomboBox
            // 
            this.CuentascomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CuentascomboBox.FormattingEnabled = true;
            this.CuentascomboBox.Location = new System.Drawing.Point(6, 39);
            this.CuentascomboBox.Name = "CuentascomboBox";
            this.CuentascomboBox.Size = new System.Drawing.Size(121, 24);
            this.CuentascomboBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cuentas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Valor";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(346, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ValorTextBox
            // 
            this.ValorTextBox.Location = new System.Drawing.Point(219, 39);
            this.ValorTextBox.Name = "ValorTextBox";
            this.ValorTextBox.ReadOnly = true;
            this.ValorTextBox.Size = new System.Drawing.Size(121, 22);
            this.ValorTextBox.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.ValorTextBox);
            this.groupBox1.Controls.Add(this.CuentascomboBox);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.AgregarCuentaButton);
            this.groupBox1.Location = new System.Drawing.Point(2, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 257);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Cuentas";
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::PresupuestoDeCuentas2.Properties.Resources.if_cross_24_103181;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(252, 422);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 62);
            this.EliminarButton.TabIndex = 17;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::PresupuestoDeCuentas2.Properties.Resources.if_floppy_disk_save_103863;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(161, 422);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 62);
            this.GuardarButton.TabIndex = 17;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::PresupuestoDeCuentas2.Properties.Resources.if_new10_216291;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(68, 423);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 62);
            this.NuevoButton.TabIndex = 17;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::PresupuestoDeCuentas2.Properties.Resources.if_search_126577;
            this.BuscarButton.Location = new System.Drawing.Point(242, 5);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(50, 47);
            this.BuscarButton.TabIndex = 16;
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BuscarButton.UseVisualStyleBackColor = true;
            // 
            // AgregarCuentaButton
            // 
            this.AgregarCuentaButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AgregarCuentaButton.Image = global::PresupuestoDeCuentas2.Properties.Resources.if_plus_square_black_243655;
            this.AgregarCuentaButton.Location = new System.Drawing.Point(133, 38);
            this.AgregarCuentaButton.Name = "AgregarCuentaButton";
            this.AgregarCuentaButton.Size = new System.Drawing.Size(25, 23);
            this.AgregarCuentaButton.TabIndex = 9;
            this.AgregarCuentaButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(418, 234);
            this.dataGridView1.TabIndex = 24;
            // 
            // TotalTextbox
            // 
            this.TotalTextbox.Location = new System.Drawing.Point(305, 376);
            this.TotalTextbox.Name = "TotalTextbox";
            this.TotalTextbox.ReadOnly = true;
            this.TotalTextbox.Size = new System.Drawing.Size(121, 22);
            this.TotalTextbox.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Total";
            // 
            // RemoverFila
            // 
            this.RemoverFila.Image = global::PresupuestoDeCuentas2.Properties.Resources.if_cross_24_103181;
            this.RemoverFila.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoverFila.Location = new System.Drawing.Point(8, 376);
            this.RemoverFila.Name = "RemoverFila";
            this.RemoverFila.Size = new System.Drawing.Size(135, 40);
            this.RemoverFila.TabIndex = 27;
            this.RemoverFila.Text = "RemoverFila";
            this.RemoverFila.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoverFila.UseVisualStyleBackColor = true;
            // 
            // RegistroPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 500);
            this.Controls.Add(this.RemoverFila);
            this.Controls.Add(this.TotalTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.PresupuestoIDnumericUpDown);
            this.Controls.Add(this.FechaTimePicker);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroPresupuesto";
            this.Text = "PresupuestoCuentas";
            ((System.ComponentModel.ISupportInitialize)(this.PresupuestoIDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.DateTimePicker FechaTimePicker;
        private System.Windows.Forms.NumericUpDown PresupuestoIDnumericUpDown;
        private System.Windows.Forms.ComboBox CuentascomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AgregarCuentaButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox ValorTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RemoverFila;
        private System.Windows.Forms.TextBox TotalTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}