namespace WindowsFormsApp1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.inputBuscar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.inputVel = new System.Windows.Forms.TextBox();
            this.inputHealth = new System.Windows.Forms.TextBox();
            this.inputVelDisp = new System.Windows.Forms.TextBox();
            this.inputName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.inputVelUpdate = new System.Windows.Forms.TextBox();
            this.inputHealthUpdate = new System.Windows.Forms.TextBox();
            this.inputVelDispUpdate = new System.Windows.Forms.TextBox();
            this.inputNameUpdate = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.inputBuscarPotenciador = new System.Windows.Forms.TextBox();
            this.buscarPotenciador = new System.Windows.Forms.Label();
            this.buttonModificarPotenciador = new System.Windows.Forms.Button();
            this.inputDuracionPotenciador = new System.Windows.Forms.TextBox();
            this.inputNombrePotenciador = new System.Windows.Forms.TextBox();
            this.dataGridPotenciadores = new System.Windows.Forms.DataGridView();
            this.labelDuracion = new System.Windows.Forms.Label();
            this.nombrePotenciador = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPotenciadores)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(19, 5);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1159, 478);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.inputBuscar);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.inputVel);
            this.tabPage1.Controls.Add(this.inputHealth);
            this.tabPage1.Controls.Add(this.inputVelDisp);
            this.tabPage1.Controls.Add(this.inputName);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.buttonCreate);
            this.tabPage1.Controls.Add(this.buttonDelete);
            this.tabPage1.Controls.Add(this.buttonUpdate);
            this.tabPage1.Controls.Add(this.inputVelUpdate);
            this.tabPage1.Controls.Add(this.inputHealthUpdate);
            this.tabPage1.Controls.Add(this.inputVelDispUpdate);
            this.tabPage1.Controls.Add(this.inputNameUpdate);
            this.tabPage1.Controls.Add(this.grid);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1151, 449);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Enemigos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // inputBuscar
            // 
            this.inputBuscar.Location = new System.Drawing.Point(148, 100);
            this.inputBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.inputBuscar.Name = "inputBuscar";
            this.inputBuscar.Size = new System.Drawing.Size(132, 22);
            this.inputBuscar.TabIndex = 43;
            this.inputBuscar.TextChanged += new System.EventHandler(this.inputBuscar_TextChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 100);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "Buscar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(572, 5);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 41;
            this.label8.Text = "Velocidad";
            // 
            // inputVel
            // 
            this.inputVel.Location = new System.Drawing.Point(572, 23);
            this.inputVel.Margin = new System.Windows.Forms.Padding(4);
            this.inputVel.Name = "inputVel";
            this.inputVel.Size = new System.Drawing.Size(132, 22);
            this.inputVel.TabIndex = 40;
            // 
            // inputHealth
            // 
            this.inputHealth.Location = new System.Drawing.Point(392, 23);
            this.inputHealth.Margin = new System.Windows.Forms.Padding(4);
            this.inputHealth.Name = "inputHealth";
            this.inputHealth.Size = new System.Drawing.Size(132, 22);
            this.inputHealth.TabIndex = 39;
            this.inputHealth.TextChanged += new System.EventHandler(this.inputHealth_TextChanged);
            // 
            // inputVelDisp
            // 
            this.inputVelDisp.Location = new System.Drawing.Point(205, 23);
            this.inputVelDisp.Margin = new System.Windows.Forms.Padding(4);
            this.inputVelDisp.Name = "inputVelDisp";
            this.inputVelDisp.Size = new System.Drawing.Size(132, 22);
            this.inputVelDisp.TabIndex = 38;
            this.inputVelDisp.TextChanged += new System.EventHandler(this.inputVelDisp_TextChanged);
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(19, 25);
            this.inputName.Margin = new System.Windows.Forms.Padding(4);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(132, 22);
            this.inputName.TabIndex = 37;
            this.inputName.TextChanged += new System.EventHandler(this.inputName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(388, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Salud";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Vel. Disparo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Nombre";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(747, 25);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(100, 28);
            this.buttonCreate.TabIndex = 33;
            this.buttonCreate.Text = "Crear";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(181, 331);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 28);
            this.buttonDelete.TabIndex = 32;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(19, 331);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 28);
            this.buttonUpdate.TabIndex = 31;
            this.buttonUpdate.Text = "Modificar";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click_1);
            // 
            // inputVelUpdate
            // 
            this.inputVelUpdate.Location = new System.Drawing.Point(148, 281);
            this.inputVelUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.inputVelUpdate.Name = "inputVelUpdate";
            this.inputVelUpdate.Size = new System.Drawing.Size(132, 22);
            this.inputVelUpdate.TabIndex = 30;
            // 
            // inputHealthUpdate
            // 
            this.inputHealthUpdate.Location = new System.Drawing.Point(148, 240);
            this.inputHealthUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.inputHealthUpdate.Name = "inputHealthUpdate";
            this.inputHealthUpdate.Size = new System.Drawing.Size(132, 22);
            this.inputHealthUpdate.TabIndex = 29;
            // 
            // inputVelDispUpdate
            // 
            this.inputVelDispUpdate.Location = new System.Drawing.Point(148, 201);
            this.inputVelDispUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.inputVelDispUpdate.Name = "inputVelDispUpdate";
            this.inputVelDispUpdate.Size = new System.Drawing.Size(132, 22);
            this.inputVelDispUpdate.TabIndex = 28;
            // 
            // inputNameUpdate
            // 
            this.inputNameUpdate.Location = new System.Drawing.Point(148, 159);
            this.inputNameUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.inputNameUpdate.Name = "inputNameUpdate";
            this.inputNameUpdate.Size = new System.Drawing.Size(132, 22);
            this.inputNameUpdate.TabIndex = 27;
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(340, 80);
            this.grid.Margin = new System.Windows.Forms.Padding(4);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 51;
            this.grid.Size = new System.Drawing.Size(792, 361);
            this.grid.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 281);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Velocidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Salud";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Vel. Disparo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nombre";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.inputBuscarPotenciador);
            this.tabPage2.Controls.Add(this.buscarPotenciador);
            this.tabPage2.Controls.Add(this.buttonModificarPotenciador);
            this.tabPage2.Controls.Add(this.inputDuracionPotenciador);
            this.tabPage2.Controls.Add(this.inputNombrePotenciador);
            this.tabPage2.Controls.Add(this.dataGridPotenciadores);
            this.tabPage2.Controls.Add(this.labelDuracion);
            this.tabPage2.Controls.Add(this.nombrePotenciador);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1151, 449);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Potenciadores";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(226, 26);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 22);
            this.textBox3.TabIndex = 71;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(40, 28);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 22);
            this.textBox4.TabIndex = 70;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(222, 8);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 17);
            this.label12.TabIndex = 68;
            this.label12.Text = "Duración";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 8);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 17);
            this.label13.TabIndex = 67;
            this.label13.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 66;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputBuscarPotenciador
            // 
            this.inputBuscarPotenciador.Location = new System.Drawing.Point(148, 92);
            this.inputBuscarPotenciador.Margin = new System.Windows.Forms.Padding(4);
            this.inputBuscarPotenciador.Name = "inputBuscarPotenciador";
            this.inputBuscarPotenciador.Size = new System.Drawing.Size(132, 22);
            this.inputBuscarPotenciador.TabIndex = 65;
            this.inputBuscarPotenciador.TextChanged += new System.EventHandler(this.inputBuscarPotenciador_TextChanged);
            // 
            // buscarPotenciador
            // 
            this.buscarPotenciador.AutoSize = true;
            this.buscarPotenciador.Location = new System.Drawing.Point(15, 96);
            this.buscarPotenciador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buscarPotenciador.Name = "buscarPotenciador";
            this.buscarPotenciador.Size = new System.Drawing.Size(52, 17);
            this.buscarPotenciador.TabIndex = 64;
            this.buscarPotenciador.Text = "Buscar";
            // 
            // buttonModificarPotenciador
            // 
            this.buttonModificarPotenciador.Location = new System.Drawing.Point(181, 188);
            this.buttonModificarPotenciador.Margin = new System.Windows.Forms.Padding(4);
            this.buttonModificarPotenciador.Name = "buttonModificarPotenciador";
            this.buttonModificarPotenciador.Size = new System.Drawing.Size(100, 28);
            this.buttonModificarPotenciador.TabIndex = 53;
            this.buttonModificarPotenciador.Text = "Modificar";
            this.buttonModificarPotenciador.UseVisualStyleBackColor = true;
            this.buttonModificarPotenciador.Click += new System.EventHandler(this.buttonModificarPotenciador_Click);
            // 
            // inputDuracionPotenciador
            // 
            this.inputDuracionPotenciador.Location = new System.Drawing.Point(148, 156);
            this.inputDuracionPotenciador.Margin = new System.Windows.Forms.Padding(4);
            this.inputDuracionPotenciador.Name = "inputDuracionPotenciador";
            this.inputDuracionPotenciador.Size = new System.Drawing.Size(132, 22);
            this.inputDuracionPotenciador.TabIndex = 50;
            // 
            // inputNombrePotenciador
            // 
            this.inputNombrePotenciador.Location = new System.Drawing.Point(148, 124);
            this.inputNombrePotenciador.Margin = new System.Windows.Forms.Padding(4);
            this.inputNombrePotenciador.Name = "inputNombrePotenciador";
            this.inputNombrePotenciador.Size = new System.Drawing.Size(132, 22);
            this.inputNombrePotenciador.TabIndex = 49;
            // 
            // dataGridPotenciadores
            // 
            this.dataGridPotenciadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPotenciadores.Location = new System.Drawing.Point(340, 78);
            this.dataGridPotenciadores.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridPotenciadores.Name = "dataGridPotenciadores";
            this.dataGridPotenciadores.RowHeadersWidth = 51;
            this.dataGridPotenciadores.Size = new System.Drawing.Size(791, 362);
            this.dataGridPotenciadores.TabIndex = 48;
            // 
            // labelDuracion
            // 
            this.labelDuracion.AutoSize = true;
            this.labelDuracion.Location = new System.Drawing.Point(15, 160);
            this.labelDuracion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDuracion.Name = "labelDuracion";
            this.labelDuracion.Size = new System.Drawing.Size(65, 17);
            this.labelDuracion.TabIndex = 45;
            this.labelDuracion.Text = "Duracion";
            this.labelDuracion.Click += new System.EventHandler(this.label17_Click);
            // 
            // nombrePotenciador
            // 
            this.nombrePotenciador.AutoSize = true;
            this.nombrePotenciador.Location = new System.Drawing.Point(15, 128);
            this.nombrePotenciador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombrePotenciador.Name = "nombrePotenciador";
            this.nombrePotenciador.Size = new System.Drawing.Size(58, 17);
            this.nombrePotenciador.TabIndex = 44;
            this.nombrePotenciador.Text = "Nombre";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 188);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 72;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 496);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPotenciadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox inputBuscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox inputVel;
        private System.Windows.Forms.TextBox inputHealth;
        private System.Windows.Forms.TextBox inputVelDisp;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox inputVelUpdate;
        private System.Windows.Forms.TextBox inputHealthUpdate;
        private System.Windows.Forms.TextBox inputVelDispUpdate;
        private System.Windows.Forms.TextBox inputNameUpdate;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox inputBuscarPotenciador;
        private System.Windows.Forms.Label buscarPotenciador;
        private System.Windows.Forms.Button buttonModificarPotenciador;
        private System.Windows.Forms.TextBox inputDuracionPotenciador;
        private System.Windows.Forms.TextBox inputNombrePotenciador;
        private System.Windows.Forms.DataGridView dataGridPotenciadores;
        private System.Windows.Forms.Label labelDuracion;
        private System.Windows.Forms.Label nombrePotenciador;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

