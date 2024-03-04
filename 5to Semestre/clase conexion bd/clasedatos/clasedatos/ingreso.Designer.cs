
namespace clasedatos
{
    partial class ingreso
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
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDA_usuario = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.dSingreso1 = new clasedatos.DSingreso();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbusuario = new System.Windows.Forms.TextBox();
            this.tbcontra = new System.Windows.Forms.TextBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dSingreso1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT Usuario.*\r\nFROM     Usuario";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlDA_usuario
            // 
            this.sqlDA_usuario.SelectCommand = this.sqlSelectCommand1;
            this.sqlDA_usuario.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Usuario", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Usuario", "Usuario"),
                        new System.Data.Common.DataColumnMapping("Contraseña", "Contraseña"),
                        new System.Data.Common.DataColumnMapping("Nivel", "Nivel")})});
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=(local);Initial Catalog=pubs;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // dSingreso1
            // 
            this.dSingreso1.DataSetName = "DSingreso";
            this.dSingreso1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // tbusuario
            // 
            this.tbusuario.Location = new System.Drawing.Point(303, 177);
            this.tbusuario.MaxLength = 8;
            this.tbusuario.Name = "tbusuario";
            this.tbusuario.Size = new System.Drawing.Size(100, 22);
            this.tbusuario.TabIndex = 2;
            // 
            // tbcontra
            // 
            this.tbcontra.Location = new System.Drawing.Point(303, 266);
            this.tbcontra.MaxLength = 8;
            this.tbcontra.Name = "tbcontra";
            this.tbcontra.PasswordChar = '*';
            this.tbcontra.Size = new System.Drawing.Size(100, 22);
            this.tbcontra.TabIndex = 3;
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(642, 107);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(75, 23);
            this.btningresar.TabIndex = 4;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(642, 189);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "Cancelar";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.tbcontra);
            this.Controls.Add(this.tbusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ingreso";
            this.Text = "ingreso";
            this.Load += new System.EventHandler(this.ingreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSingreso1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlDataAdapter sqlDA_usuario;
        private DSingreso dSingreso1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbusuario;
        private System.Windows.Forms.TextBox tbcontra;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.Button btncancel;
    }
}