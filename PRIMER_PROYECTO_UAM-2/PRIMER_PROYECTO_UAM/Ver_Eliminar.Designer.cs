namespace PRIMER_PROYECTO_UAM
{
    partial class Ver_Eliminar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.r_apellido = new System.Windows.Forms.RadioButton();
            this.r_ced = new System.Windows.Forms.RadioButton();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.dataeliminar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataeliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.r_apellido);
            this.groupBox1.Controls.Add(this.r_ced);
            this.groupBox1.Controls.Add(this.txtcedula);
            this.groupBox1.Location = new System.Drawing.Point(12, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUSQUEDA DE CLIENTE";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // r_apellido
            // 
            this.r_apellido.AutoSize = true;
            this.r_apellido.Location = new System.Drawing.Point(6, 42);
            this.r_apellido.Name = "r_apellido";
            this.r_apellido.Size = new System.Drawing.Size(131, 17);
            this.r_apellido.TabIndex = 3;
            this.r_apellido.TabStop = true;
            this.r_apellido.Text = "Busqueda por Apellido";
            this.r_apellido.UseVisualStyleBackColor = true;
            this.r_apellido.CheckedChanged += new System.EventHandler(this.r_apellido_CheckedChanged);
            // 
            // r_ced
            // 
            this.r_ced.AutoSize = true;
            this.r_ced.Location = new System.Drawing.Point(6, 19);
            this.r_ced.Name = "r_ced";
            this.r_ced.Size = new System.Drawing.Size(127, 17);
            this.r_ced.TabIndex = 2;
            this.r_ced.TabStop = true;
            this.r_ced.Text = "Busqueda por Cédula";
            this.r_ced.UseVisualStyleBackColor = true;
            this.r_ced.CheckedChanged += new System.EventHandler(this.r_ced_CheckedChanged);
            // 
            // txtcedula
            // 
            this.txtcedula.BackColor = System.Drawing.Color.Coral;
            this.txtcedula.Location = new System.Drawing.Point(166, 29);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(127, 20);
            this.txtcedula.TabIndex = 1;
            this.txtcedula.TextChanged += new System.EventHandler(this.txtcedula_TextChanged);
            // 
            // dataeliminar
            // 
            this.dataeliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataeliminar.Location = new System.Drawing.Point(3, 179);
            this.dataeliminar.Margin = new System.Windows.Forms.Padding(5);
            this.dataeliminar.Name = "dataeliminar";
            this.dataeliminar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataeliminar.Size = new System.Drawing.Size(1026, 183);
            this.dataeliminar.TabIndex = 37;
            this.dataeliminar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1046, 122);
            this.label1.TabIndex = 2;
            this.label1.Text = "LISTA DE CLIENTES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(0, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1049, 256);
            this.label2.TabIndex = 3;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(459, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "ELIMINAR CLIENTE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ver_Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 379);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataeliminar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "Ver_Eliminar";
            this.Text = "Listado Clientes";
            this.Load += new System.EventHandler(this.Ver_Eliminar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataeliminar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.DataGridView dataeliminar;
        private System.Windows.Forms.RadioButton r_apellido;
        private System.Windows.Forms.RadioButton r_ced;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}