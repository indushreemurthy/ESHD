namespace MDES
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rbFever = new System.Windows.Forms.RadioButton();
            this.rbAbsNo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.comboBoxAge = new System.Windows.Forms.ComboBox();
            this.comboBoxWeight = new System.Windows.Forms.ComboBox();
            this.comboBoxSymptom1 = new System.Windows.Forms.ComboBox();
            this.comboBoxSymptom2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Age ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Geder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Over Weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fever";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Symptom 1";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbFever
            // 
            this.rbFever.AutoSize = true;
            this.rbFever.Checked = true;
            this.rbFever.Location = new System.Drawing.Point(58, 14);
            this.rbFever.Name = "rbFever";
            this.rbFever.Size = new System.Drawing.Size(43, 17);
            this.rbFever.TabIndex = 11;
            this.rbFever.TabStop = true;
            this.rbFever.Text = "Yes";
            this.rbFever.UseVisualStyleBackColor = true;
            // 
            // rbAbsNo
            // 
            this.rbAbsNo.AutoSize = true;
            this.rbAbsNo.Location = new System.Drawing.Point(114, 14);
            this.rbAbsNo.Name = "rbAbsNo";
            this.rbAbsNo.Size = new System.Drawing.Size(39, 17);
            this.rbAbsNo.TabIndex = 12;
            this.rbAbsNo.TabStop = true;
            this.rbAbsNo.Text = "No";
            this.rbAbsNo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFever);
            this.groupBox1.Controls.Add(this.rbAbsNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(156, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 62);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(145, 527);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Symptom 2";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.comboBoxGender.Location = new System.Drawing.Point(268, 55);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGender.TabIndex = 17;
            this.comboBoxGender.Text = "SELECT";
            // 
            // comboBoxAge
            // 
            this.comboBoxAge.FormattingEnabled = true;
            this.comboBoxAge.Items.AddRange(new object[] {
            "teenage",
            "adult"});
            this.comboBoxAge.Location = new System.Drawing.Point(268, 109);
            this.comboBoxAge.Name = "comboBoxAge";
            this.comboBoxAge.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAge.TabIndex = 18;
            this.comboBoxAge.Text = "SELECT";
            // 
            // comboBoxWeight
            // 
            this.comboBoxWeight.FormattingEnabled = true;
            this.comboBoxWeight.Items.AddRange(new object[] {
            "no",
            "yes"});
            this.comboBoxWeight.Location = new System.Drawing.Point(268, 165);
            this.comboBoxWeight.Name = "comboBoxWeight";
            this.comboBoxWeight.Size = new System.Drawing.Size(121, 21);
            this.comboBoxWeight.TabIndex = 19;
            this.comboBoxWeight.Text = "SELECT";
            // 
            // comboBoxSymptom1
            // 
            this.comboBoxSymptom1.FormattingEnabled = true;
            this.comboBoxSymptom1.Items.AddRange(new object[] {
            "1",
            "headache",
            "3",
            "4",
            "5"});
            this.comboBoxSymptom1.Location = new System.Drawing.Point(268, 311);
            this.comboBoxSymptom1.Name = "comboBoxSymptom1";
            this.comboBoxSymptom1.Size = new System.Drawing.Size(266, 21);
            this.comboBoxSymptom1.TabIndex = 21;
            this.comboBoxSymptom1.Text = "SELECT";
            // 
            // comboBoxSymptom2
            // 
            this.comboBoxSymptom2.FormattingEnabled = true;
            this.comboBoxSymptom2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxSymptom2.Location = new System.Drawing.Point(270, 366);
            this.comboBoxSymptom2.Name = "comboBoxSymptom2";
            this.comboBoxSymptom2.Size = new System.Drawing.Size(264, 21);
            this.comboBoxSymptom2.TabIndex = 22;
            this.comboBoxSymptom2.Text = "SELECT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 620);
            this.Controls.Add(this.comboBoxSymptom2);
            this.Controls.Add(this.comboBoxSymptom1);
            this.Controls.Add(this.comboBoxWeight);
            this.Controls.Add(this.comboBoxAge);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "HumanDiseaseExpertSystem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbFever;
        private System.Windows.Forms.RadioButton rbAbsNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.ComboBox comboBoxAge;
        private System.Windows.Forms.ComboBox comboBoxWeight;
        private System.Windows.Forms.ComboBox comboBoxSymptom1;
        private System.Windows.Forms.ComboBox comboBoxSymptom2;
    }
}

