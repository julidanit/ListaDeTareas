namespace ListaDeTareas
{
    partial class FormularioPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            this.titulolbl = new System.Windows.Forms.Label();
            this.Agregartareatxt = new System.Windows.Forms.TextBox();
            this.Agregartarealbl = new System.Windows.Forms.Label();
            this.AgregarTareabtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Listadetareaslst = new System.Windows.Forms.CheckedListBox();
            this.datatime1 = new System.Windows.Forms.DateTimePicker();
            this.fechalbl = new System.Windows.Forms.Label();
            this.filtrocmb = new System.Windows.Forms.ComboBox();
            this.verlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titulolbl
            // 
            this.titulolbl.AutoSize = true;
            this.titulolbl.BackColor = System.Drawing.Color.Transparent;
            this.titulolbl.Font = new System.Drawing.Font("Leelawadee UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulolbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.titulolbl.Location = new System.Drawing.Point(123, 30);
            this.titulolbl.Name = "titulolbl";
            this.titulolbl.Size = new System.Drawing.Size(202, 37);
            this.titulolbl.TabIndex = 0;
            this.titulolbl.Text = "Lista de tareas";
            // 
            // Agregartareatxt
            // 
            this.Agregartareatxt.Location = new System.Drawing.Point(146, 102);
            this.Agregartareatxt.Name = "Agregartareatxt";
            this.Agregartareatxt.Size = new System.Drawing.Size(256, 22);
            this.Agregartareatxt.TabIndex = 1;
            // 
            // Agregartarealbl
            // 
            this.Agregartarealbl.AutoSize = true;
            this.Agregartarealbl.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregartarealbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Agregartarealbl.Location = new System.Drawing.Point(30, 103);
            this.Agregartarealbl.Name = "Agregartarealbl";
            this.Agregartarealbl.Size = new System.Drawing.Size(94, 21);
            this.Agregartarealbl.TabIndex = 2;
            this.Agregartarealbl.Text = "Nueva tarea";
            // 
            // AgregarTareabtn
            // 
            this.AgregarTareabtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.AgregarTareabtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AgregarTareabtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.AgregarTareabtn.Location = new System.Drawing.Point(302, 216);
            this.AgregarTareabtn.Name = "AgregarTareabtn";
            this.AgregarTareabtn.Size = new System.Drawing.Size(100, 32);
            this.AgregarTareabtn.TabIndex = 3;
            this.AgregarTareabtn.Text = "Agregar tarea";
            this.AgregarTareabtn.UseVisualStyleBackColor = false;
            this.AgregarTareabtn.Click += new System.EventHandler(this.AgregarTareabtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button2.Location = new System.Drawing.Point(302, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "Eliminar tarea";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(34, 395);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Listadetareaslst
            // 
            this.Listadetareaslst.BackColor = System.Drawing.Color.Bisque;
            this.Listadetareaslst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Listadetareaslst.CheckOnClick = true;
            this.Listadetareaslst.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.Listadetareaslst.FormattingEnabled = true;
            this.Listadetareaslst.Location = new System.Drawing.Point(34, 295);
            this.Listadetareaslst.Name = "Listadetareaslst";
            this.Listadetareaslst.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Listadetareaslst.Size = new System.Drawing.Size(368, 82);
            this.Listadetareaslst.TabIndex = 7;
            this.Listadetareaslst.ThreeDCheckBoxes = true;
            this.Listadetareaslst.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Listadetareaslst_ItemCheck);
            // 
            // datatime1
            // 
            this.datatime1.Location = new System.Drawing.Point(146, 155);
            this.datatime1.Name = "datatime1";
            this.datatime1.Size = new System.Drawing.Size(256, 22);
            this.datatime1.TabIndex = 8;
            // 
            // fechalbl
            // 
            this.fechalbl.AutoSize = true;
            this.fechalbl.BackColor = System.Drawing.Color.Transparent;
            this.fechalbl.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechalbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.fechalbl.Location = new System.Drawing.Point(30, 155);
            this.fechalbl.Name = "fechalbl";
            this.fechalbl.Size = new System.Drawing.Size(93, 21);
            this.fechalbl.TabIndex = 9;
            this.fechalbl.Text = "Fecha límite";
            // 
            // filtrocmb
            // 
            this.filtrocmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtrocmb.FormattingEnabled = true;
            this.filtrocmb.Items.AddRange(new object[] {
            "Todas",
            "Completas",
            "Incompletas"});
            this.filtrocmb.Location = new System.Drawing.Point(73, 259);
            this.filtrocmb.Name = "filtrocmb";
            this.filtrocmb.Size = new System.Drawing.Size(121, 21);
            this.filtrocmb.TabIndex = 10;
            this.filtrocmb.SelectedIndexChanged += new System.EventHandler(this.filtrocmb_SelectedIndexChanged);
            // 
            // verlbl
            // 
            this.verlbl.AutoSize = true;
            this.verlbl.Font = new System.Drawing.Font("Leelawadee UI", 12F);
            this.verlbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.verlbl.Location = new System.Drawing.Point(30, 259);
            this.verlbl.Name = "verlbl";
            this.verlbl.Size = new System.Drawing.Size(37, 21);
            this.verlbl.TabIndex = 11;
            this.verlbl.Text = "Ver:";
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(446, 556);
            this.Controls.Add(this.verlbl);
            this.Controls.Add(this.filtrocmb);
            this.Controls.Add(this.fechalbl);
            this.Controls.Add(this.datatime1);
            this.Controls.Add(this.Listadetareaslst);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AgregarTareabtn);
            this.Controls.Add(this.Agregartarealbl);
            this.Controls.Add(this.Agregartareatxt);
            this.Controls.Add(this.titulolbl);
            this.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(606, 700);
            this.MinimumSize = new System.Drawing.Size(406, 500);
            this.Name = "FormularioPrincipal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de tareas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulolbl;
        private System.Windows.Forms.TextBox Agregartareatxt;
        private System.Windows.Forms.Label Agregartarealbl;
        private System.Windows.Forms.Button AgregarTareabtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckedListBox Listadetareaslst;
        private System.Windows.Forms.DateTimePicker datatime1;
        private System.Windows.Forms.Label fechalbl;
        private System.Windows.Forms.ComboBox filtrocmb;
        private System.Windows.Forms.Label verlbl;
    }
}

