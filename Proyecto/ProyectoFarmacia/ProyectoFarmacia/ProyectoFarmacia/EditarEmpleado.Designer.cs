namespace ProyectoFarmacia
{
    partial class EditarEmpleado
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
            this.emailEmpleado = new System.Windows.Forms.TextBox();
            this.dpiEmpleado = new System.Windows.Forms.TextBox();
            this.apellidoEmpleado = new System.Windows.Forms.TextBox();
            this.nombreEmpleado = new System.Windows.Forms.TextBox();
            this.idEmpleado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailEmpleado
            // 
            this.emailEmpleado.Location = new System.Drawing.Point(87, 448);
            this.emailEmpleado.Name = "emailEmpleado";
            this.emailEmpleado.Size = new System.Drawing.Size(594, 26);
            this.emailEmpleado.TabIndex = 21;
            // 
            // dpiEmpleado
            // 
            this.dpiEmpleado.Location = new System.Drawing.Point(87, 390);
            this.dpiEmpleado.Name = "dpiEmpleado";
            this.dpiEmpleado.Size = new System.Drawing.Size(594, 26);
            this.dpiEmpleado.TabIndex = 20;
            // 
            // apellidoEmpleado
            // 
            this.apellidoEmpleado.Location = new System.Drawing.Point(87, 330);
            this.apellidoEmpleado.Name = "apellidoEmpleado";
            this.apellidoEmpleado.Size = new System.Drawing.Size(594, 26);
            this.apellidoEmpleado.TabIndex = 19;
            // 
            // nombreEmpleado
            // 
            this.nombreEmpleado.Location = new System.Drawing.Point(87, 262);
            this.nombreEmpleado.Name = "nombreEmpleado";
            this.nombreEmpleado.Size = new System.Drawing.Size(594, 26);
            this.nombreEmpleado.TabIndex = 18;
            // 
            // idEmpleado
            // 
            this.idEmpleado.Location = new System.Drawing.Point(87, 199);
            this.idEmpleado.Name = "idEmpleado";
            this.idEmpleado.Size = new System.Drawing.Size(100, 26);
            this.idEmpleado.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "E-Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "DPI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Id";
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(595, 699);
            this.Button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(112, 35);
            this.Button2.TabIndex = 47;
            this.Button2.Text = "Actualizar";
            this.Button2.UseVisualStyleBackColor = true;
            // 
            // EditarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 805);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.emailEmpleado);
            this.Controls.Add(this.dpiEmpleado);
            this.Controls.Add(this.apellidoEmpleado);
            this.Controls.Add(this.nombreEmpleado);
            this.Controls.Add(this.idEmpleado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "EditarEmpleado";
            this.Text = "EditarEmpleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailEmpleado;
        private System.Windows.Forms.TextBox dpiEmpleado;
        private System.Windows.Forms.TextBox apellidoEmpleado;
        private System.Windows.Forms.TextBox nombreEmpleado;
        private System.Windows.Forms.TextBox idEmpleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button Button2;
    }
}