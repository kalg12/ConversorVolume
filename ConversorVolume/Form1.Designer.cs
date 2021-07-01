
namespace ConversorVolume
{
    partial class volumeConverter
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
            this.convertClTitleLabel = new System.Windows.Forms.Label();
            this.ClTextBox = new System.Windows.Forms.TextBox();
            this.litreTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.ClLabel = new System.Windows.Forms.Label();
            this.litreLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // convertClTitleLabel
            // 
            this.convertClTitleLabel.AutoSize = true;
            this.convertClTitleLabel.Font = new System.Drawing.Font("Machala Sans", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertClTitleLabel.Location = new System.Drawing.Point(199, 28);
            this.convertClTitleLabel.Name = "convertClTitleLabel";
            this.convertClTitleLabel.Size = new System.Drawing.Size(417, 46);
            this.convertClTitleLabel.TabIndex = 0;
            this.convertClTitleLabel.Text = "Convertidor de CL a Litro";
            this.convertClTitleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ClTextBox
            // 
            this.ClTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClTextBox.Location = new System.Drawing.Point(335, 128);
            this.ClTextBox.Multiline = true;
            this.ClTextBox.Name = "ClTextBox";
            this.ClTextBox.Size = new System.Drawing.Size(150, 50);
            this.ClTextBox.TabIndex = 1;
            this.ClTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClTextBox.TextChanged += new System.EventHandler(this.ClTextBox_TextChanged);
            // 
            // litreTextBox
            // 
            this.litreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.litreTextBox.Location = new System.Drawing.Point(335, 204);
            this.litreTextBox.Multiline = true;
            this.litreTextBox.Name = "litreTextBox";
            this.litreTextBox.Size = new System.Drawing.Size(150, 50);
            this.litreTextBox.TabIndex = 2;
            this.litreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.litreTextBox.TextChanged += new System.EventHandler(this.litreTextBox_TextChanged);
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(267, 324);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(140, 50);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Convertir";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(433, 324);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(140, 50);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Limpiar";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // ClLabel
            // 
            this.ClLabel.AutoSize = true;
            this.ClLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClLabel.Location = new System.Drawing.Point(506, 137);
            this.ClLabel.Name = "ClLabel";
            this.ClLabel.Size = new System.Drawing.Size(49, 31);
            this.ClLabel.TabIndex = 5;
            this.ClLabel.Text = "CL";
            // 
            // litreLabel
            // 
            this.litreLabel.AutoSize = true;
            this.litreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.litreLabel.Location = new System.Drawing.Point(506, 214);
            this.litreLabel.Name = "litreLabel";
            this.litreLabel.Size = new System.Drawing.Size(67, 31);
            this.litreLabel.TabIndex = 6;
            this.litreLabel.Text = "Litro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Programa hecho por kalg12";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // volumeConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.litreLabel);
            this.Controls.Add(this.ClLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.litreTextBox);
            this.Controls.Add(this.ClTextBox);
            this.Controls.Add(this.convertClTitleLabel);
            this.MaximizeBox = false;
            this.Name = "volumeConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversos de volume de CL a Litro";
            this.Load += new System.EventHandler(this.volumeConverter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label convertClTitleLabel;
        private System.Windows.Forms.TextBox ClTextBox;
        private System.Windows.Forms.TextBox litreTextBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label ClLabel;
        private System.Windows.Forms.Label litreLabel;
        private System.Windows.Forms.Label label1;
    }
}

