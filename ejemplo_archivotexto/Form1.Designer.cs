
namespace ejemplo_archivotexto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonguardar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonleer = new System.Windows.Forms.Button();
            this.buttonLeerDirecto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonguardar
            // 
            this.buttonguardar.Location = new System.Drawing.Point(22, 40);
            this.buttonguardar.Name = "buttonguardar";
            this.buttonguardar.Size = new System.Drawing.Size(75, 23);
            this.buttonguardar.TabIndex = 0;
            this.buttonguardar.Text = "Guardar";
            this.buttonguardar.UseVisualStyleBackColor = true;
            this.buttonguardar.Click += new System.EventHandler(this.buttonguardar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 22);
            this.textBox1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(537, 61);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(212, 127);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonleer
            // 
            this.buttonleer.Location = new System.Drawing.Point(524, 240);
            this.buttonleer.Name = "buttonleer";
            this.buttonleer.Size = new System.Drawing.Size(108, 31);
            this.buttonleer.TabIndex = 3;
            this.buttonleer.Text = "Leer";
            this.buttonleer.UseVisualStyleBackColor = true;
            this.buttonleer.Click += new System.EventHandler(this.buttonleer_Click);
            // 
            // buttonLeerDirecto
            // 
            this.buttonLeerDirecto.Location = new System.Drawing.Point(638, 240);
            this.buttonLeerDirecto.Name = "buttonLeerDirecto";
            this.buttonLeerDirecto.Size = new System.Drawing.Size(99, 31);
            this.buttonLeerDirecto.TabIndex = 4;
            this.buttonLeerDirecto.Text = "Leer Directo";
            this.buttonLeerDirecto.UseVisualStyleBackColor = true;
            this.buttonLeerDirecto.Click += new System.EventHandler(this.buttonLeerDirecto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLeerDirecto);
            this.Controls.Add(this.buttonleer);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonguardar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonguardar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonleer;
        private System.Windows.Forms.Button buttonLeerDirecto;
    }
}

