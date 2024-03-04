
namespace Form_number_1_practice_class
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
            this.Box1 = new System.Windows.Forms.TextBox();
            this.Box2 = new System.Windows.Forms.TextBox();
            this.Box3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Process = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Box1
            // 
            this.Box1.Location = new System.Drawing.Point(68, 102);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(132, 20);
            this.Box1.TabIndex = 0;
            this.Box1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Box2
            // 
            this.Box2.Location = new System.Drawing.Point(226, 102);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(124, 20);
            this.Box2.TabIndex = 1;
            this.Box2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Box3
            // 
            this.Box3.Enabled = false;
            this.Box3.Location = new System.Drawing.Point(139, 153);
            this.Box3.Name = "Box3";
            this.Box3.Size = new System.Drawing.Size(131, 20);
            this.Box3.TabIndex = 2;
            this.Box3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Box3.TextChanged += new System.EventHandler(this.Box3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number 2 ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result";
            // 
            // Process
            // 
            this.Process.Location = new System.Drawing.Point(439, 74);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(137, 36);
            this.Process.TabIndex = 6;
            this.Process.Text = "Process";
            this.Process.UseVisualStyleBackColor = true;
            this.Process.Click += new System.EventHandler(this.Process_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(439, 116);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(137, 34);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(439, 156);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(137, 37);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(611, 287);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Process);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Box3);
            this.Controls.Add(this.Box2);
            this.Controls.Add(this.Box1);
            this.Name = "Form1";
            this.Text = "Form Practice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Box1;
        private System.Windows.Forms.TextBox Box2;
        private System.Windows.Forms.TextBox Box3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Process;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Exit;
    }
}

