namespace RegistroPersonas.UI.Registros
{
    partial class rDetalle
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
            this.GuardarDetallebutton = new System.Windows.Forms.Button();
            this.IdDetallenumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TipoDetalletextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IdDetallenumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // GuardarDetallebutton
            // 
            this.GuardarDetallebutton.BackColor = System.Drawing.Color.LawnGreen;
            this.GuardarDetallebutton.Location = new System.Drawing.Point(64, 97);
            this.GuardarDetallebutton.Name = "GuardarDetallebutton";
            this.GuardarDetallebutton.Size = new System.Drawing.Size(103, 35);
            this.GuardarDetallebutton.TabIndex = 9;
            this.GuardarDetallebutton.Text = "Guardar";
            this.GuardarDetallebutton.UseVisualStyleBackColor = false;
            this.GuardarDetallebutton.Click += new System.EventHandler(this.GuardarDetallebutton_Click);
            // 
            // IdDetallenumericUpDown
            // 
            this.IdDetallenumericUpDown.Location = new System.Drawing.Point(53, 20);
            this.IdDetallenumericUpDown.Name = "IdDetallenumericUpDown";
            this.IdDetallenumericUpDown.Size = new System.Drawing.Size(54, 20);
            this.IdDetallenumericUpDown.TabIndex = 8;
            // 
            // TipoDetalletextBox
            // 
            this.TipoDetalletextBox.Location = new System.Drawing.Point(53, 61);
            this.TipoDetalletextBox.Name = "TipoDetalletextBox";
            this.TipoDetalletextBox.Size = new System.Drawing.Size(130, 20);
            this.TipoDetalletextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // rDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(222, 163);
            this.Controls.Add(this.GuardarDetallebutton);
            this.Controls.Add(this.IdDetallenumericUpDown);
            this.Controls.Add(this.TipoDetalletextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rDetalle";
            this.Text = "rDetalle";
            ((System.ComponentModel.ISupportInitialize)(this.IdDetallenumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GuardarDetallebutton;
        private System.Windows.Forms.NumericUpDown IdDetallenumericUpDown;
        private System.Windows.Forms.TextBox TipoDetalletextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}